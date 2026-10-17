using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;
using Farsight.Entity;
using FlatSharp;
using Microsoft.Extensions.Logging;

namespace Farsight.BBObject;

public class SceneManager : IDisposable
{
	private sealed class CreatedAssetTracker : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		private readonly List<(string Path, byte[] Hash)> _entries = new List<(string, byte[])>();

		public IEnumerable<(string Path, byte[] Hash)> EntriesInReverseOrder => _entries.AsEnumerable().Reverse();

		public int Count => _entries.Count;

		public bool IsReadOnly => false;

		public void Add(string item)
		{
			using FileStream source = File.OpenRead(item);
			_entries.Add((item, SHA256.HashData(source)));
		}

		public void Clear()
		{
			_entries.Clear();
		}

		public bool Contains(string item)
		{
			return _entries.Any(((string Path, byte[] Hash) entry) => entry.Path.Equals(item, StringComparison.OrdinalIgnoreCase));
		}

		public bool TryGetHash(string path, out byte[] hash)
		{
			foreach (var (text, array) in _entries)
			{
				if (text.Equals(path, StringComparison.OrdinalIgnoreCase))
				{
					hash = array;
					return true;
				}
			}
			hash = Array.Empty<byte>();
			return false;
		}

		public void CopyTo(string[] array, int arrayIndex)
		{
			_entries.Select(((string Path, byte[] Hash) entry) => entry.Path).ToArray().CopyTo(array, arrayIndex);
		}

		public bool Remove(string item)
		{
			int num = _entries.FindIndex(((string Path, byte[] Hash) entry) => entry.Path.Equals(item, StringComparison.OrdinalIgnoreCase));
			if (num < 0)
			{
				return false;
			}
			_entries.RemoveAt(num);
			return true;
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _entries.Select(((string Path, byte[] Hash) entry) => entry.Path).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	private readonly string _sceneRootDirectory;

	private readonly SceneLibraryPaths? _libraryPaths;

	private readonly ILoggerFactory _loggerFactory;

	private readonly ILogger<SceneManager> _logger;

	private readonly ObservableCollection<Scene> _scenes = new ObservableCollection<Scene>();

	private readonly SceneAssetManager _assetManager;

	private readonly IPlayerDataProvider _playerDataProvider;

	private FileStream? _editLease;

	private Scene? _editLeaseScene;

	public ReadOnlyObservableCollection<Scene> Scenes => new ReadOnlyObservableCollection<Scene>(_scenes);

	public IEnumerable<Scene> ActiveScenes => _scenes.Where((Scene s) => s.IsActive);

	public Scene? EditModeScene => _scenes.FirstOrDefault((Scene s) => s.IsEditMode);

	public bool HasEditLease
	{
		get
		{
			if (_editLease != null)
			{
				return _editLeaseScene != null;
			}
			return false;
		}
	}

	public SceneAssetManager AssetManager => _assetManager;

	public SceneLibraryPaths? LibraryPaths => _libraryPaths;

	public IReadOnlyList<ScriptAsset> ScriptLibrary => _assetManager.ScriptLibrary;

	public event EventHandler<Scene>? SceneCreated;

	public event EventHandler<Scene>? SceneRemoved;

	public event EventHandler<Scene>? SceneActivated;

	public event EventHandler<Scene>? SceneDeactivated;

	public event EventHandler<Scene>? SceneUpdated;

	public event EventHandler<(Scene Scene, ulong EntityId)>? ExternalEntityAdded;

	public IReadOnlyList<ScriptAsset> RefreshScriptAssets()
	{
		return _assetManager.RefreshScriptAssets();
	}

	public ScriptAsset? GetScriptAsset(string scriptId)
	{
		return _assetManager.GetScriptAsset(scriptId);
	}

	public string GetScriptFilePath(string scriptId)
	{
		return _assetManager.GetScriptFilePath(scriptId);
	}

	public ScriptAsset CreateScriptAsset(string name, string content)
	{
		return _assetManager.CreateScriptAsset(name, content);
	}

	public async Task<ScriptAsset> UpdateScriptAssetAsync(string scriptId, string name, string content)
	{
		ScriptAsset asset = _assetManager.UpdateScriptAsset(scriptId, name, content);
		await RefreshScriptReferencesAsync(scriptId).ConfigureAwait(continueOnCapturedContext: false);
		return asset;
	}

	public void DeleteScriptAsset(string scriptId)
	{
		using (_assetManager.AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			_assetManager.RefreshScriptAssetsUnderWriteLease();
			if (IsScriptReferenced(scriptId) || IsScriptReferencedOnDisk(scriptId))
			{
				throw new ScriptAssetConflictException("Script '" + scriptId + "' is referenced by a scene and cannot be deleted.");
			}
			_assetManager.DeleteScriptAssetUnderWriteLease(scriptId);
		}
	}

	public bool IsScriptReferenced(string scriptId)
	{
		return _scenes.Any((Scene scene) => scene.ReferencesScript(scriptId));
	}

	private bool IsScriptReferencedOnDisk(string scriptId)
	{
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		foreach (string item in Directory.EnumerateFiles(_sceneRootDirectory, "scene.fb", enumerationOptions))
		{
			try
			{
				foreach (EntityRecord item2 in SceneFile.Serializer.Parse(new ArrayInputBuffer(File.ReadAllBytes(item))).Entities ?? new List<EntityRecord>())
				{
					foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item3 in item2.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
					{
						if (item3.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script)
						{
							ComponentScript script = item3.Script;
							if (script != null && script.Scripts?.Any((ScriptEntry entry) => entry.ScriptId == scriptId) == true)
							{
								return true;
							}
						}
					}
				}
			}
			catch (Exception ex) when ((ex is IOException || ex is ArgumentException || ex is InvalidCastException || ex is InvalidOperationException) ? true : false)
			{
				throw new ScriptAssetConflictException("Script references could not be verified in scene file '" + item + "'.");
			}
		}
		return false;
	}

	public async Task RefreshScriptReferencesAsync(string scriptId)
	{
		foreach (Scene scene in _scenes)
		{
			try
			{
				await scene.RefreshScriptReferencesAsync(scriptId).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception exception)
			{
				_logger.LogWarning(exception, "Could not refresh shared script '{ScriptId}' in loaded scene '{SceneName}'.", scriptId, scene.Name);
			}
		}
	}

	public SceneManager(SceneLibraryPaths libraryPaths, ILoggerFactory loggerFactory, IPlayerDataProvider playerDataProvider)
		: this(libraryPaths.ScenesDirectory, loggerFactory, playerDataProvider, libraryPaths.FontDirectory, libraryPaths.TextureDirectory, libraryPaths.ModelDirectory, libraryPaths.ScriptDirectory, libraryPaths)
	{
	}

	public SceneManager(string sceneRootDirectory, ILoggerFactory loggerFactory, IPlayerDataProvider playerDataProvider, string? centralFontDirectory = null, string? centralDecalDirectory = null, string? centralModelDirectory = null)
		: this(sceneRootDirectory, loggerFactory, playerDataProvider, centralFontDirectory ?? Path.Combine(sceneRootDirectory, "_fonts"), centralDecalDirectory ?? Path.Combine(sceneRootDirectory, "_decals"), centralModelDirectory ?? Path.Combine(sceneRootDirectory, "_models"), Path.Combine(sceneRootDirectory, "_scripts"), null)
	{
	}

	private SceneManager(string sceneRootDirectory, ILoggerFactory loggerFactory, IPlayerDataProvider playerDataProvider, string centralFontDirectory, string centralDecalDirectory, string centralModelDirectory, string centralScriptDirectory, SceneLibraryPaths? libraryPaths)
	{
		_loggerFactory = loggerFactory;
		_logger = _loggerFactory.CreateLogger<SceneManager>();
		_sceneRootDirectory = sceneRootDirectory;
		_libraryPaths = libraryPaths;
		_playerDataProvider = playerDataProvider;
		libraryPaths?.EnsureCreated();
		_assetManager = new SceneAssetManager(centralDecalDirectory, centralFontDirectory, centralModelDirectory, centralScriptDirectory, _loggerFactory.CreateLogger<SceneAssetManager>());
		Directory.CreateDirectory(_sceneRootDirectory);
		_assetManager.LoadExistingAssets();
		_assetManager.FontAdded += async (object? _, SceneAssetManager.FontAddedEventArgs e) =>
		{
			await AssetConnector.CreateAsync(AssetType.font, e.FontPath, e.FontName);
		};
	}

	public async Task PreloadFontsAsync()
	{
		string fontDir = _assetManager.CentralFontDirectory;
		if (!Directory.Exists(fontDir))
		{
			return;
		}
		string[] array = (from f in _assetManager.GetFontFiles()
			where f.EndsWith(".ttf", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".otf", StringComparison.OrdinalIgnoreCase)
			select f).ToArray();
		if (array.Length != 0)
		{
			_logger.LogDebug("Preloading {Count} fonts from {Dir}", array.Length, fontDir);
			await AssetConnector.CreateBatchAsync(array.Select((string f) => (font: AssetType.font, f: f, SceneLibraryPaths.GetAssetKey(fontDir, f))).ToList());
		}
	}

	public bool SceneExists(string sceneName)
	{
		return _scenes.Any((Scene s) => s.Name.Equals(sceneName, StringComparison.OrdinalIgnoreCase));
	}

	public async Task<Scene?> CreateSceneAsync(string sceneName)
	{
		if (string.IsNullOrEmpty(sceneName))
		{
			_logger.LogWarning("Scene name cannot be null or empty.");
			return null;
		}
		using FileStream creationLease = TryAcquireSceneCreationLease();
		if (creationLease == null)
		{
			_logger.LogWarning("Scene library is busy in another application.");
			return null;
		}
		try
		{
			ResolveSceneDirectory(sceneName);
		}
		catch (ArgumentException exception)
		{
			_logger.LogWarning(exception, "Scene name '{SceneName}' is invalid.", sceneName);
			return null;
		}
		if (SceneExists(sceneName))
		{
			_logger.LogWarning("Scene '{sceneName}' already exists.", sceneName);
			return null;
		}
		Scene newScene = await LoadScene(sceneName);
		if (newScene != null)
		{
			if (!(await newScene.SaveAsync().ConfigureAwait(continueOnCapturedContext: false)))
			{
				await RemoveSceneAsync(sceneName).ConfigureAwait(continueOnCapturedContext: false);
				return null;
			}
			SceneCreated?.Invoke(this, newScene);
		}
		return newScene;
	}

	public async Task<bool> RemoveSceneAsync(string sceneName, bool deleteFiles = true)
	{
		if (string.IsNullOrEmpty(sceneName))
		{
			_logger.LogWarning("Scene name cannot be null or empty.");
			return false;
		}
		if (!TryGetScene(sceneName, out Scene scene))
		{
			_logger.LogWarning("Scene '{sceneName}' not found for removal.", sceneName);
			return false;
		}
		if (scene == _editLeaseScene)
		{
			TrySetExclusiveEditMode(null);
		}
		if (deleteFiles)
		{
			string text = ResolveSceneDirectory(sceneName);
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
					_logger.LogInformation("Scene directory '{sceneDir}' deleted successfully.", text);
				}
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to delete scene directory '{sceneDir}'", text);
				return false;
			}
		}
		_scenes.Remove(scene);
		scene.PropertyChanged -= OnSceneUpdated;
		scene.ExternalEntityReady -= OnExternalEntityReady;
		scene.Dispose();
		SceneRemoved?.Invoke(this, scene);
		_logger.LogInformation("Scene '{sceneName}' removed successfully.", sceneName);
		return true;
	}

	public bool TrySetExclusiveEditMode(Scene? sceneToEdit)
	{
		if (sceneToEdit == _editLeaseScene)
		{
			return true;
		}
		FileStream fileStream = ((sceneToEdit == null) ? null : TryAcquireEditLease(sceneToEdit));
		if (sceneToEdit != null && fileStream == null)
		{
			return false;
		}
		foreach (Scene scene in _scenes)
		{
			if (scene != sceneToEdit && scene.IsEditMode)
			{
				scene.IsEditMode = false;
			}
		}
		_editLease?.Dispose();
		_editLease = fileStream;
		_editLeaseScene = sceneToEdit;
		if (sceneToEdit != null)
		{
			sceneToEdit.IsEditMode = true;
		}
		return true;
	}

	public bool OwnsEditLease(Scene scene)
	{
		if (_editLease != null)
		{
			return _editLeaseScene == scene;
		}
		return false;
	}

	public void SetExclusiveEditMode(Scene? sceneToEdit)
	{
		if (!TrySetExclusiveEditMode(sceneToEdit))
		{
			throw new InvalidOperationException("Scene '" + sceneToEdit?.Name + "' is being edited by another application.");
		}
	}

	public bool TryGetScene(string sceneName, out Scene? scene)
	{
		scene = _scenes.FirstOrDefault((Scene s) => s.Name.Equals(sceneName, StringComparison.OrdinalIgnoreCase));
		return scene != null;
	}

	public async Task<uint> LoadAllScenesAsync()
	{
		if (!Directory.Exists(_sceneRootDirectory))
		{
			_logger.LogWarning("Scene root directory '{directory}' does not exist.", _sceneRootDirectory);
			return 0u;
		}
		TrySetExclusiveEditMode(null);
		foreach (Scene scene in _scenes)
		{
			scene.PropertyChanged -= OnSceneUpdated;
			scene.ExternalEntityReady -= OnExternalEntityReady;
			scene.Dispose();
		}
		_scenes.Clear();
		string[] directories = Directory.GetDirectories(_sceneRootDirectory);
		string[] array = directories;
		for (int i = 0; i < array.Length; i++)
		{
			string fileName = Path.GetFileName(array[i]);
			if (!fileName.StartsWith('_'))
			{
				await LoadScene(fileName);
			}
		}
		_logger.LogInformation("Loaded {count} scenes. Active: {activeCount}", _scenes.Count, string.Join(", ", ActiveScenes.Select((Scene s) => s.Name)));
		return (uint)_scenes.Count;
	}

	public async Task<bool> SaveAllScenesAsync()
	{
		bool flag = true;
		foreach (Scene scene in _scenes)
		{
			bool flag2 = flag;
			flag = flag2 & await scene.SaveAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
		return flag;
	}

	public async Task<bool> ApplyAllScenesAsync()
	{
		_logger.LogDebug("Applying all active scenes to the game: {sceneNames}", string.Join(", ", ActiveScenes.Select((Scene s) => s.Name)));
		bool flag = true;
		foreach (Scene activeScene in ActiveScenes)
		{
			bool flag2 = flag;
			flag = flag2 & await activeScene.ApplyToGameAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
		return flag;
	}

	public async Task<bool> ReconnectScenesAsync()
	{
		SceneConnector sceneConnector = LeagueConnector.SceneConnector;
		if (sceneConnector == null)
		{
			_logger.LogWarning("Cannot reconnect scenes: SceneConnector is null.");
			return await ApplyAllScenesAsync();
		}
		SceneList sceneList = await sceneConnector.ListScenesAsync();
		Dictionary<string, uint> nativeScenesByName = new Dictionary<string, uint>();
		if (sceneList?.Scenes != null)
		{
			foreach (SceneDescriptor scene in sceneList.Scenes)
			{
				if (!string.IsNullOrEmpty(scene.Name))
				{
					nativeScenesByName[scene.Name] = scene.SceneId;
					_logger.LogDebug("Found existing native scene '{Name}' with ID {Id}.", scene.Name, scene.SceneId);
				}
			}
			_logger.LogInformation("Reconnect: found {Count} existing scene(s) in lblib.", nativeScenesByName.Count);
			bool flag = true;
			foreach (Scene activeScene in ActiveScenes)
			{
				if (nativeScenesByName.TryGetValue(activeScene.Name, out var value))
				{
					_logger.LogInformation("Reconnect: adopting existing scene '{Name}' (native ID {Id}).", activeScene.Name, value);
					bool flag2 = flag;
					flag = flag2 & await activeScene.AdoptExistingAsync(value).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					_logger.LogInformation("Reconnect: scene '{Name}' not found in lblib, creating fresh.", activeScene.Name);
					bool flag2 = flag;
					flag = flag2 & await activeScene.ApplyToGameAsync().ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			return flag;
		}
		_logger.LogInformation("Reconnect: no existing scenes found in lblib, applying fresh.");
		return await ApplyAllScenesAsync();
	}

	public async Task<bool> RemoveAllScenesAsync()
	{
		bool flag = true;
		foreach (Scene activeScene in ActiveScenes)
		{
			bool flag2 = flag;
			flag = flag2 & await activeScene.RemoveFromGameAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
		return flag;
	}

	public void ResetAllNativeState()
	{
		_logger.LogInformation("Resetting native state for all scenes (connection lost).");
		foreach (Scene scene in _scenes)
		{
			scene.ResetNativeState();
		}
	}

	public async Task<bool> ExportSceneAsync(string sceneName, string exportPath)
	{
		Scene sceneToExport = _scenes.FirstOrDefault((Scene s) => s.Name.Equals(sceneName, StringComparison.OrdinalIgnoreCase));
		if (sceneToExport == null)
		{
			_logger.LogWarning("Scene '{sceneName}' not found for export.", sceneName);
			return false;
		}
		if (!(await sceneToExport.SaveAsync().ConfigureAwait(continueOnCapturedContext: false)))
		{
			_logger.LogWarning("Scene '{sceneName}' changed before export; export aborted.", sceneName);
			return false;
		}
		string path = ResolveSceneDirectory(sceneName);
		using FileStream fileStream = _assetManager.AcquireWriteLease();
		if (fileStream == null)
		{
			_logger.LogWarning("The shared asset library is busy. Export aborted.");
			return false;
		}
		_assetManager.RefreshScriptAssetsUnderWriteLease();
		if (File.Exists(exportPath))
		{
			File.Delete(exportPath);
		}
		string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(text);
		try
		{
			string text2 = SceneLibraryPaths.ResolveRelativePath(Path.Combine(text, "Scenes"), sceneName);
			Directory.CreateDirectory(text2);
			string text3 = Path.Combine(path, "scene.json");
			if (File.Exists(text3))
			{
				File.Copy(text3, Path.Combine(text2, "scene.json"), overwrite: true);
			}
			string text4 = Path.Combine(path, "scene.fb");
			if (File.Exists(text4))
			{
				File.Copy(text4, Path.Combine(text2, "scene.fb"), overwrite: true);
			}
			string text5 = Path.Combine(path, "sequence.fb");
			if (File.Exists(text5))
			{
				File.Copy(text5, Path.Combine(text2, "sequence.fb"), overwrite: true);
			}
			IReadOnlySet<string> referencedScriptIds = sceneToExport.GetReferencedScriptIds();
			if (referencedScriptIds.Count > 0)
			{
				string text6 = Path.Combine(text, "Assets", "Scripts");
				Directory.CreateDirectory(text6);
				foreach (string item in referencedScriptIds)
				{
					string scriptFilePath = _assetManager.GetScriptFilePath(item);
					CopyScriptToExport(_assetManager.CentralScriptDirectory, scriptFilePath, text6);
				}
			}
			HashSet<string> decalPathsForScenes = SceneAssetManager.GetDecalPathsForScenes(new _003C_003Ez__ReadOnlySingleElementList<Scene>(sceneToExport));
			if (decalPathsForScenes.Count > 0)
			{
				string text7 = Path.Combine(text, "Assets", "Textures");
				Directory.CreateDirectory(text7);
				foreach (string item2 in decalPathsForScenes)
				{
					string text8 = _assetManager.ResolveDecalPath(item2);
					if (text8 != null)
					{
						CopyAssetToExport(_assetManager.CentralDecalDirectory, text8, text7);
					}
				}
			}
			HashSet<string> fontNamesForScenes = SceneAssetManager.GetFontNamesForScenes(new _003C_003Ez__ReadOnlySingleElementList<Scene>(sceneToExport));
			if (fontNamesForScenes.Count > 0)
			{
				string text9 = Path.Combine(text, "Assets", "Fonts");
				Directory.CreateDirectory(text9);
				foreach (string item3 in fontNamesForScenes)
				{
					string text10 = _assetManager.ResolveFontPath(item3);
					if (text10 != null)
					{
						CopyAssetToExport(_assetManager.CentralFontDirectory, text10, text9);
					}
				}
			}
			HashSet<string> modelPathsForScenes = SceneAssetManager.GetModelPathsForScenes(new _003C_003Ez__ReadOnlySingleElementList<Scene>(sceneToExport));
			if (modelPathsForScenes.Count > 0)
			{
				string text11 = Path.Combine(text, "Assets", "Models");
				Directory.CreateDirectory(text11);
				foreach (string item4 in modelPathsForScenes)
				{
					string text12 = _assetManager.ResolveModelPath(item4);
					if (text12 != null)
					{
						CopyAssetToExport(_assetManager.CentralModelDirectory, text12, text11);
					}
				}
			}
			ZipFile.CreateFromDirectory(text, exportPath, CompressionLevel.Optimal, includeBaseDirectory: false);
			_logger.LogInformation("Scene '{sceneName}' exported successfully.", sceneName);
			return true;
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to clean up temporary export directory");
			}
		}
	}

	public bool TryAddDecalAsset(byte[] imageData, string fileExtension, out string? assetPath, string? originalFileName = null, string? folderPath = null)
	{
		return _assetManager.TryAddDecalAsset(imageData, fileExtension, out assetPath, originalFileName, folderPath);
	}

	public bool TryAddFontAsset(byte[] fontData, string fileExtension, string fontName)
	{
		return _assetManager.TryAddFontAsset(fontData, fileExtension, fontName);
	}

	public bool TryAddFontAsset(byte[] fontData, string fileExtension, out string? assetPath, string fontName, string? folderPath)
	{
		return _assetManager.TryAddFontAsset(fontData, fileExtension, out assetPath, fontName, folderPath);
	}

	public bool TryAddModelAsset(byte[] modelData, string fileExtension, out string? assetPath, string? originalFileName = null, string? folderPath = null)
	{
		return _assetManager.TryAddModelAsset(modelData, fileExtension, out assetPath, originalFileName, folderPath);
	}

	private async Task<Scene?> LoadScene(string sceneName)
	{
		ResolveSceneDirectory(sceneName);
		Scene newScene = new Scene(sceneName, _sceneRootDirectory, _assetManager, _playerDataProvider, _loggerFactory.CreateLogger<Scene>());
		if (!(await newScene.LoadingTask.ConfigureAwait(continueOnCapturedContext: false)))
		{
			newScene.Dispose();
			return null;
		}
		_scenes.Add(newScene);
		newScene.PropertyChanged += OnSceneUpdated;
		newScene.ExternalEntityReady += OnExternalEntityReady;
		_logger.LogInformation("Scene '{sceneName}' created successfully.", sceneName);
		return newScene;
	}

	private void OnExternalEntityReady(object? sender, ulong entityId)
	{
		if (sender is Scene item)
		{
			ExternalEntityAdded?.Invoke(this, (item, entityId));
		}
	}

	private void OnSceneUpdated(object? sender, PropertyChangedEventArgs e)
	{
		if (!(sender is Scene scene))
		{
			return;
		}
		if (e.PropertyName == "IsActive")
		{
			if (scene.IsActive)
			{
				SceneActivated?.Invoke(this, scene);
			}
			else
			{
				SceneDeactivated?.Invoke(this, scene);
			}
		}
		else
		{
			SceneUpdated?.Invoke(this, scene);
		}
	}

	public async Task<Scene?> ImportSceneAsync(string importPath, string? sceneName = null)
	{
		if (!File.Exists(importPath))
		{
			_logger.LogWarning("Import path '{importPath}' does not exist.", importPath);
			return null;
		}
		string targetSceneName = sceneName ?? Path.GetFileNameWithoutExtension(importPath);
		string targetSceneDir;
		try
		{
			targetSceneDir = ResolveSceneDirectory(targetSceneName);
		}
		catch (ArgumentException exception)
		{
			_logger.LogWarning(exception, "Imported scene name '{SceneName}' is invalid.", targetSceneName);
			return null;
		}
		using FileStream creationLease = TryAcquireSceneCreationLease();
		if (creationLease == null || Directory.Exists(targetSceneDir))
		{
			_logger.LogWarning("Scene '{sceneName}' already exists or the scene library is busy. Import aborted.", targetSceneName);
			return null;
		}
		using FileStream assetWriteLease = _assetManager.AcquireWriteLease();
		if (assetWriteLease == null)
		{
			_logger.LogWarning("The shared asset library is busy. Import aborted.");
			return null;
		}
		string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		CreatedAssetTracker createdAssets = new CreatedAssetTracker();
		bool committed = false;
		bool sceneDirectoryCreated = false;
		try
		{
			ExtractArchiveSafely(importPath, tempDir);
			string importSceneDirectory = ResolveImportedSceneDirectory(tempDir);
			string sceneFbPath = Path.Combine(importSceneDirectory, "scene.fb");
			if (!File.Exists(sceneFbPath))
			{
				_logger.LogWarning("scene.fb not found in the imported scene package. Scene will start empty.");
			}
			string importDecalsDir = ResolveImportedAssetDirectory(tempDir, Path.Combine("Assets", "Textures"), "decals", Path.Combine("assets", "decals"));
			string importFontsDir = ResolveImportedAssetDirectory(tempDir, Path.Combine("Assets", "Fonts"), "fonts", Path.Combine("assets", "fonts"));
			string importModelsDir = ResolveImportedAssetDirectory(tempDir, Path.Combine("Assets", "Models"), "models", Path.Combine("assets", "models"));
			string importScriptsDir = Path.Combine(tempDir, "Assets", "Scripts");
			_assetManager.ValidateImportedAssets(new _003C_003Ez__ReadOnlyArray<(string, string)>(new (string, string)[3]
			{
				(importDecalsDir, _assetManager.CentralDecalDirectory),
				(importFontsDir, _assetManager.CentralFontDirectory),
				(importModelsDir, _assetManager.CentralModelDirectory)
			}));
			if (Directory.Exists(importScriptsDir))
			{
				_assetManager.ValidateImportedScriptAssets(importScriptsDir);
			}
			if (File.Exists(sceneFbPath))
			{
				List<string> importedLegacySourcePaths = new List<string>();
				SceneFile sceneFile;
				try
				{
					byte[] buffer = await File.ReadAllBytesAsync(sceneFbPath);
					sceneFile = SceneFile.Serializer.Parse(new ArrayInputBuffer(buffer));
				}
				catch (Exception ex) when ((ex is ArgumentException || ex is InvalidDataException || ex is InvalidOperationException) ? true : false)
				{
					_logger.LogWarning(ex, "The imported scene file is invalid. Import was rolled back.");
					return null;
				}
				foreach (ScriptAsset item in sceneFile.ScriptLibrary ?? new List<ScriptAsset>())
				{
					string text = ResolveLegacyScriptPath(importSceneDirectory, item);
					if (text != null)
					{
						importedLegacySourcePaths.Add(text);
					}
					_assetManager.MigrateLegacyScriptUnderWriteLease(item, text, createdAssets);
				}
				IList<ScriptAsset>? scriptLibrary = sceneFile.ScriptLibrary;
				if (scriptLibrary != null && scriptLibrary.Count > 0)
				{
					sceneFile.ScriptLibrary = null;
					await File.WriteAllBytesAsync(sceneFbPath, SerializeSceneFile(sceneFile));
				}
				CleanupImportedLegacySources(importSceneDirectory, importedLegacySourcePaths);
			}
			if (Directory.Exists(importScriptsDir))
			{
				_assetManager.CopyImportedScriptAssets(importScriptsDir, createdAssets);
				Directory.Delete(importScriptsDir, recursive: true);
			}
			if (Directory.Exists(importDecalsDir))
			{
				CopyImportedAssets(importDecalsDir, _assetManager.CentralDecalDirectory, createdAssets);
				Directory.Delete(importDecalsDir, recursive: true);
			}
			if (Directory.Exists(importFontsDir))
			{
				CopyImportedAssets(importFontsDir, _assetManager.CentralFontDirectory, createdAssets);
				Directory.Delete(importFontsDir, recursive: true);
			}
			if (Directory.Exists(importModelsDir))
			{
				CopyImportedAssets(importModelsDir, _assetManager.CentralModelDirectory, createdAssets);
				Directory.Delete(importModelsDir, recursive: true);
			}
			_assetManager.LoadExistingAssetsUnderWriteLease();
			sceneDirectoryCreated = true;
			CopyImportedScene(importSceneDirectory, targetSceneDir);
			Scene scene = await LoadScene(targetSceneName);
			if (scene == null)
			{
				_logger.LogWarning("Imported scene '{sceneName}' could not be loaded. Import was rolled back.", targetSceneName);
				return null;
			}
			committed = true;
			_logger.LogInformation("Scene '{sceneName}' imported successfully.", targetSceneName);
			return scene;
		}
		finally
		{
			if (!committed)
			{
				try
				{
					if (sceneDirectoryCreated && Directory.Exists(targetSceneDir))
					{
						Directory.Delete(targetSceneDir, recursive: true);
					}
					HashSet<string> referencedAssetPaths = GetReferencedAssetPaths();
					HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
					foreach (ScriptAsset item2 in _assetManager.ScriptLibrary)
					{
						string scriptFilePath = _assetManager.GetScriptFilePath(item2.Id);
						string text2 = scriptFilePath + ".meta";
						if (!referencedAssetPaths.Contains(scriptFilePath) && createdAssets.TryGetHash(scriptFilePath, out byte[] hash) && createdAssets.TryGetHash(text2, out byte[] hash2) && File.Exists(scriptFilePath) && File.Exists(text2) && FileMatchesHash(scriptFilePath, hash) && FileMatchesHash(text2, hash2))
						{
							_assetManager.DeleteScriptAssetUnderWriteLease(item2.Id);
							hashSet.Add(scriptFilePath);
							hashSet.Add(text2);
						}
					}
					foreach (var (text3, expectedHash) in createdAssets.EntriesInReverseOrder)
					{
						if (hashSet.Contains(text3))
						{
							continue;
						}
						if (text3.EndsWith(".as", StringComparison.OrdinalIgnoreCase) || text3.EndsWith(".as.meta", StringComparison.OrdinalIgnoreCase))
						{
							_logger.LogWarning("Imported script file '{AssetPath}' could not be rolled back as a verified pair and was preserved.", text3);
						}
						else if (File.Exists(text3))
						{
							if (referencedAssetPaths.Contains(text3))
							{
								_logger.LogWarning("Imported asset '{AssetPath}' became referenced before rollback and was preserved.", text3);
							}
							else if (FileMatchesHash(text3, expectedHash))
							{
								File.Delete(text3);
							}
							else
							{
								_logger.LogWarning("Imported asset '{AssetPath}' changed before rollback and was preserved.", text3);
							}
						}
					}
					_assetManager.LoadExistingAssetsUnderWriteLease();
				}
				catch (Exception exception2)
				{
					_logger.LogError(exception2, "Failed to roll back scene import '{SceneName}'.", targetSceneName);
				}
			}
			assetWriteLease.Dispose();
			try
			{
				if (Directory.Exists(tempDir))
				{
					Directory.Delete(tempDir, recursive: true);
				}
			}
			catch (Exception exception3)
			{
				_logger.LogError(exception3, "Failed to clean up temporary directory");
			}
		}
	}

	private static string ResolveImportedSceneDirectory(string importRoot)
	{
		List<string> list = new List<string>();
		if (File.Exists(Path.Combine(importRoot, "scene.fb")))
		{
			list.Add(importRoot);
		}
		string path = Path.Combine(importRoot, "Scenes");
		if (Directory.Exists(path))
		{
			list.AddRange(from path2 in Directory.EnumerateFiles(path, "scene.fb", SearchOption.AllDirectories)
				select Path.GetDirectoryName(path2));
		}
		list = list.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
		return list.Count switch
		{
			0 => importRoot, 
			1 => list[0], 
			_ => throw new InvalidDataException("The scene archive contains more than one scene."), 
		};
	}

	private static string ResolveImportedAssetDirectory(string importRoot, params string[] relativeCandidates)
	{
		string[] array = relativeCandidates.Select((string relativePath) => SceneLibraryPaths.ResolveRelativePath(importRoot, relativePath)).Where(Directory.Exists).Distinct(StringComparer.OrdinalIgnoreCase)
			.ToArray();
		return array.Length switch
		{
			0 => SceneLibraryPaths.ResolveRelativePath(importRoot, relativeCandidates[0]), 
			1 => array[0], 
			_ => throw new InvalidDataException("The scene archive contains multiple layouts for the same asset type."), 
		};
	}

	private static string? ResolveLegacyScriptPath(string sceneDirectory, ScriptAsset script)
	{
		string text = SceneLibraryPaths.ResolveRelativePath(sceneDirectory, "scripts");
		if (!Directory.Exists(text))
		{
			return null;
		}
		string text2 = new string(script.Name.Select((char character) =>
		{
			bool flag = char.IsLetterOrDigit(character);
			if (!flag)
			{
				bool flag2 = ((character == '-' || character == '_') ? true : false);
				flag = flag2;
			}
			return (!flag) ? '-' : character;
		}).Take(80).ToArray()).Trim('-');
		if (string.IsNullOrEmpty(text2))
		{
			text2 = "Script";
		}
		string text3 = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(script.Id))).Substring(0, 16).ToLowerInvariant();
		string text4 = SceneLibraryPaths.ResolveRelativePath(text, text2 + "--" + text3 + ".as");
		if (File.Exists(text4))
		{
			return text4;
		}
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		string[] array = Directory.EnumerateFiles(text, "*--" + text3 + ".as", enumerationOptions).ToArray();
		return array.Length switch
		{
			0 => null, 
			1 => array[0], 
			_ => throw new InvalidDataException("Multiple source files exist for script '" + script.Id + "'."), 
		};
	}

	private static void CleanupImportedLegacySources(string sceneDirectory, IEnumerable<string> migratedSourcePaths)
	{
		string path = SceneLibraryPaths.ResolveRelativePath(sceneDirectory, "scripts");
		if (!Directory.Exists(path))
		{
			return;
		}
		foreach (string item in migratedSourcePaths.Distinct(StringComparer.OrdinalIgnoreCase))
		{
			File.Delete(item);
		}
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		foreach (string item2 in from text in Directory.EnumerateDirectories(path, "*", enumerationOptions)
			orderby text.Length descending
			select text)
		{
			if (!Directory.EnumerateFileSystemEntries(item2).Any())
			{
				Directory.Delete(item2, recursive: false);
			}
		}
		if (!Directory.EnumerateFileSystemEntries(path).Any())
		{
			Directory.Delete(path, recursive: false);
		}
	}

	private static void CopyImportedScene(string sourceDirectory, string destinationDirectory)
	{
		Directory.CreateDirectory(destinationDirectory);
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		foreach (string item in Directory.EnumerateFiles(sourceDirectory, "*", enumerationOptions))
		{
			string relativePath = Path.GetRelativePath(sourceDirectory, item);
			string text = SceneLibraryPaths.ResolveRelativePath(destinationDirectory, relativePath);
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			File.Copy(item, text, overwrite: false);
		}
	}

	private static byte[] SerializeSceneFile(SceneFile sceneFile)
	{
		byte[] array = new byte[SceneFile.Serializer.GetMaxSize(sceneFile)];
		int length = SceneFile.Serializer.Write(array, sceneFile);
		return array.AsMemory(0, length).ToArray();
	}

	private static bool FileMatchesHash(string path, byte[] expectedHash)
	{
		using FileStream source = File.OpenRead(path);
		return SHA256.HashData(source).SequenceEqual(expectedHash);
	}

	private HashSet<string> GetReferencedAssetPaths()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (ScriptAsset item in _assetManager.ScriptLibrary)
		{
			if (IsScriptReferenced(item.Id) || IsScriptReferencedOnDisk(item.Id))
			{
				string scriptFilePath = _assetManager.GetScriptFilePath(item.Id);
				hashSet.Add(scriptFilePath);
				hashSet.Add(scriptFilePath + ".meta");
			}
		}
		foreach (string decalPathsForScene in SceneAssetManager.GetDecalPathsForScenes(_scenes))
		{
			string text = _assetManager.ResolveDecalPath(decalPathsForScene);
			if (text != null)
			{
				hashSet.Add(text);
			}
		}
		foreach (string fontNamesForScene in SceneAssetManager.GetFontNamesForScenes(_scenes))
		{
			string text2 = _assetManager.ResolveFontPath(fontNamesForScene);
			if (text2 != null)
			{
				hashSet.Add(text2);
			}
		}
		foreach (string modelPathsForScene in SceneAssetManager.GetModelPathsForScenes(_scenes))
		{
			string text3 = _assetManager.ResolveModelPath(modelPathsForScene);
			if (text3 != null)
			{
				hashSet.Add(text3);
			}
		}
		return hashSet;
	}

	private static void CopyAssetToExport(string sourceRoot, string sourcePath, string exportRoot)
	{
		string relativePath = Path.GetRelativePath(sourceRoot, sourcePath);
		string text = SceneLibraryPaths.ResolveRelativePath(exportRoot, relativePath);
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		File.Copy(sourcePath, text, overwrite: true);
	}

	private static void CopyScriptToExport(string sourceRoot, string scriptPath, string exportRoot)
	{
		string path = scriptPath + ".meta";
		byte[] array = File.ReadAllBytes(scriptPath);
		byte[] array2 = File.ReadAllBytes(path);
		string path2 = SceneLibraryPaths.ResolveRelativePath(exportRoot, Path.GetRelativePath(sourceRoot, scriptPath));
		string path3 = SceneLibraryPaths.ResolveRelativePath(exportRoot, Path.GetRelativePath(sourceRoot, path));
		Directory.CreateDirectory(Path.GetDirectoryName(path2));
		File.WriteAllBytes(path2, array);
		File.WriteAllBytes(path3, array2);
		if (!array.SequenceEqual(File.ReadAllBytes(scriptPath)) || !array2.SequenceEqual(File.ReadAllBytes(path)))
		{
			throw new ScriptAssetConflictException("Script '" + scriptPath + "' changed during export.");
		}
	}

	private static void CopyImportedAssets(string importRoot, string destinationRoot, ICollection<string> createdAssetPaths)
	{
		foreach (string item in Directory.EnumerateFiles(importRoot, "*", SearchOption.AllDirectories))
		{
			string relativePath = Path.GetRelativePath(importRoot, item);
			string text = SceneLibraryPaths.ResolveRelativePath(destinationRoot, relativePath);
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			if (File.Exists(text))
			{
				using (FileStream source = File.OpenRead(item))
				{
					using FileStream source2 = File.OpenRead(text);
					if (!SHA256.HashData(source).SequenceEqual(SHA256.HashData(source2)))
					{
						throw new IOException("Imported asset conflicts with '" + text + "'.");
					}
				}
				continue;
			}
			string text2 = text + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
			try
			{
				using (FileStream fileStream = File.OpenRead(item))
				{
					using FileStream fileStream2 = new FileStream(text2, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough);
					fileStream.CopyTo(fileStream2);
					fileStream2.Flush(flushToDisk: true);
				}
				File.Move(text2, text, overwrite: false);
				createdAssetPaths.Add(text);
			}
			finally
			{
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
			}
		}
	}

	private static void ExtractArchiveSafely(string archivePath, string destinationRoot)
	{
		long num = 0L;
		using ZipArchive zipArchive = ZipFile.OpenRead(archivePath);
		foreach (ZipArchiveEntry entry in zipArchive.Entries)
		{
			if (!string.IsNullOrWhiteSpace(entry.FullName))
			{
				num = checked(num + entry.Length);
				if (num > 1073741824)
				{
					throw new InvalidDataException("The scene archive exceeds the extraction size limit.");
				}
				string text = SceneLibraryPaths.ResolveRelativePath(destinationRoot, entry.FullName);
				if (string.IsNullOrEmpty(entry.Name))
				{
					Directory.CreateDirectory(text);
					continue;
				}
				Directory.CreateDirectory(Path.GetDirectoryName(text));
				entry.ExtractToFile(text, overwrite: false);
			}
		}
	}

	private string ResolveSceneDirectory(string sceneName)
	{
		string text = SceneLibraryPaths.NormalizeRelativePath(sceneName);
		if (text.Contains('/'))
		{
			throw new ArgumentException("Scene names cannot contain directory separators.", "sceneName");
		}
		return SceneLibraryPaths.ResolveRelativePath(_sceneRootDirectory, text);
	}

	private static FileStream? TryAcquireEditLease(Scene scene)
	{
		try
		{
			Directory.CreateDirectory(scene.SceneDirectory);
			FileStream fileStream = new FileStream(Path.Combine(scene.SceneDirectory, ".edit.lock"), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
			fileStream.SetLength(0L);
			using StreamWriter streamWriter = new StreamWriter(fileStream, null, -1, leaveOpen: true);
			streamWriter.Write($"{Environment.ProcessId}|{Environment.ProcessPath}|{DateTimeOffset.UtcNow:O}");
			streamWriter.Flush();
			fileStream.Position = 0L;
			return fileStream;
		}
		catch (IOException)
		{
			return null;
		}
	}

	private FileStream? TryAcquireSceneCreationLease()
	{
		Directory.CreateDirectory(_sceneRootDirectory);
		string path = Path.Combine(_sceneRootDirectory, ".create.lock");
		for (int i = 0; i < 1200; i++)
		{
			try
			{
				return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
			}
			catch (IOException) when (i < 1199)
			{
				Thread.Sleep(50);
			}
		}
		return null;
	}

	public void Dispose()
	{
		_editLease?.Dispose();
		_editLease = null;
		_editLeaseScene = null;
		foreach (Scene scene in _scenes)
		{
			scene.Dispose();
		}
		GC.SuppressFinalize(this);
	}
}
