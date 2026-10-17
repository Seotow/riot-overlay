using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using BlueBottleIPC.LeagueBroadcast.Scene;
using Microsoft.Extensions.Logging;

namespace Farsight.BBObject;

public class SceneAssetManager
{
	public class FontAddedEventArgs(string fontName, string fontPath) : EventArgs
	{
		public string FontName { get; } = fontName;

		public string FontPath { get; } = fontPath;
	}

	private sealed class ScriptTransaction
	{
		[JsonPropertyName("operation")]
		public string Operation { get; init; } = "";

		[JsonPropertyName("scriptId")]
		public string ScriptId { get; init; } = "";

		[JsonPropertyName("sourcePath")]
		public string? SourcePath { get; init; }

		[JsonPropertyName("sourceContentHash")]
		public string? SourceContentHash { get; init; }

		[JsonPropertyName("sourceMetadataHash")]
		public string? SourceMetadataHash { get; init; }

		[JsonPropertyName("targetPath")]
		public string? TargetPath { get; init; }

		[JsonPropertyName("targetContentHash")]
		public string? TargetContentHash { get; init; }

		[JsonPropertyName("targetMetadataHash")]
		public string? TargetMetadataHash { get; init; }

		[JsonPropertyName("stageSourcePath")]
		public string? StageSourcePath { get; init; }

		[JsonPropertyName("stageMetadataPath")]
		public string? StageMetadataPath { get; init; }
	}

	private sealed class ScriptMetadata
	{
		[JsonPropertyName("id")]
		public string Id { get; init; } = "";
	}

	private sealed record ScriptCatalogEntry(ScriptAsset Asset, string Path, string MetadataPath, byte[] ContentHash, byte[] MetadataHash)
	{
		public bool Matches(ScriptCatalogEntry other)
		{
			if (Path.Equals(other.Path, StringComparison.OrdinalIgnoreCase) && MetadataPath.Equals(other.MetadataPath, StringComparison.OrdinalIgnoreCase) && ContentHash.SequenceEqual(other.ContentHash))
			{
				return MetadataHash.SequenceEqual(other.MetadataHash);
			}
			return false;
		}
	}

	private static readonly UTF8Encoding s_utf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

	private readonly ConcurrentDictionary<string, string> _loadedDecals = new ConcurrentDictionary<string, string>();

	private readonly ConcurrentDictionary<string, string> _loadedFonts = new ConcurrentDictionary<string, string>();

	private readonly ConcurrentDictionary<string, string> _loadedModels = new ConcurrentDictionary<string, string>();

	private readonly object _scriptCatalogLock = new object();

	private Dictionary<string, ScriptCatalogEntry> _scriptEntries = new Dictionary<string, ScriptCatalogEntry>(StringComparer.Ordinal);

	private readonly string _centralDecalDirectory;

	private readonly string _centralFontDirectory;

	private readonly string _centralModelDirectory;

	private readonly string _centralScriptDirectory;

	private readonly string _scriptTransactionPath;

	private readonly string _assetWriteLockPath;

	private readonly ILogger<SceneAssetManager> _logger;

	public string CentralDecalDirectory => _centralDecalDirectory;

	public string CentralFontDirectory => _centralFontDirectory;

	public string CentralModelDirectory => _centralModelDirectory;

	public string CentralScriptDirectory => _centralScriptDirectory;

	public IReadOnlyList<ScriptAsset> ScriptLibrary
	{
		get
		{
			lock (_scriptCatalogLock)
			{
				List<ScriptAsset> list = new List<ScriptAsset>();
				list.AddRange(_scriptEntries.Values.Select((ScriptCatalogEntry entry) => CloneScriptAsset(entry.Asset)).OrderBy((ScriptAsset asset) => asset.Name, StringComparer.OrdinalIgnoreCase));
				return new _003C_003Ez__ReadOnlyList<ScriptAsset>(list);
			}
		}
	}

	public event EventHandler<FontAddedEventArgs>? FontAdded;

	public SceneAssetManager(string centralDecalDirectory, string centralFontDirectory, string centralModelDirectory, string centralScriptDirectory, ILogger<SceneAssetManager> logger)
	{
		_centralDecalDirectory = centralDecalDirectory;
		_centralFontDirectory = centralFontDirectory;
		_centralModelDirectory = centralModelDirectory;
		_centralScriptDirectory = centralScriptDirectory;
		_assetWriteLockPath = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(_centralDecalDirectory)), ".asset-write.lock");
		_logger = logger;
		Directory.CreateDirectory(_centralDecalDirectory);
		Directory.CreateDirectory(_centralFontDirectory);
		Directory.CreateDirectory(_centralModelDirectory);
		Directory.CreateDirectory(_centralScriptDirectory);
		_scriptTransactionPath = SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, ".script-transaction.json");
	}

	public IReadOnlyList<ScriptAsset> RefreshScriptAssets()
	{
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			return RefreshScriptAssetsUnderWriteLease();
		}
	}

	internal IReadOnlyList<ScriptAsset> RefreshScriptAssetsUnderWriteLease()
	{
		RefreshScriptAssetsCore(createMissingMetadata: true);
		return ScriptLibrary;
	}

	public ScriptAsset? GetScriptAsset(string scriptId)
	{
		lock (_scriptCatalogLock)
		{
			ScriptCatalogEntry value;
			return _scriptEntries.TryGetValue(scriptId, out value) ? CloneScriptAsset(value.Asset) : null;
		}
	}

	public string GetScriptFilePath(string scriptId)
	{
		lock (_scriptCatalogLock)
		{
			if (!_scriptEntries.TryGetValue(scriptId, out ScriptCatalogEntry value))
			{
				throw new KeyNotFoundException("Script '" + scriptId + "' does not exist.");
			}
			return value.Path;
		}
	}

	public ScriptAsset CreateScriptAsset(string name, string content)
	{
		return CreateScriptAsset(Guid.NewGuid().ToString(), name, content, null, writeLeaseHeld: false);
	}

	public ScriptAsset UpdateScriptAsset(string scriptId, string name, string content)
	{
		ScriptCatalogEntry other;
		lock (_scriptCatalogLock)
		{
			other = _scriptEntries.GetValueOrDefault(scriptId) ?? throw new KeyNotFoundException("Script '" + scriptId + "' does not exist.");
		}
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			Dictionary<string, ScriptCatalogEntry> dictionary = ReadCentralScriptCatalog(createMissingMetadata: true);
			if (!dictionary.TryGetValue(scriptId, out ScriptCatalogEntry value) || !value.Matches(other))
			{
				throw new ScriptAssetConflictException("Script '" + scriptId + "' changed on disk. Refresh the script library and try again.");
			}
			string normalizedName = NormalizeScriptName(name);
			ScriptCatalogEntry scriptCatalogEntry = dictionary.Values.FirstOrDefault((ScriptCatalogEntry entry) => entry.Asset.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase) && entry.Asset.Id != scriptId);
			if ((object)scriptCatalogEntry != null)
			{
				throw new ScriptAssetConflictException($"Script path '{normalizedName}' is already used by '{scriptCatalogEntry.Asset.Id}'.");
			}
			string scriptPath = GetScriptPath(normalizedName);
			string scriptMetadataPath = GetScriptMetadataPath(scriptPath);
			byte[] bytes = s_utf8.GetBytes(content);
			if (value.Asset.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase) && !value.Asset.Name.Equals(normalizedName, StringComparison.Ordinal))
			{
				throw new ScriptAssetConflictException("Case-only script renames are not supported. Rename through a distinct path.");
			}
			if (value.Path.Equals(scriptPath, StringComparison.OrdinalIgnoreCase))
			{
				ReplaceFileAtomic(scriptPath, bytes);
			}
			else
			{
				MoveScriptPairTransaction(value, scriptPath, scriptMetadataPath, bytes, SerializeMetadata(scriptId));
			}
			RefreshScriptAssetsCore(createMissingMetadata: false);
			return GetScriptAsset(scriptId);
		}
	}

	public void DeleteScriptAsset(string scriptId)
	{
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			DeleteScriptAssetUnderWriteLease(scriptId);
		}
	}

	internal void DeleteScriptAssetUnderWriteLease(string scriptId)
	{
		ScriptCatalogEntry other;
		lock (_scriptCatalogLock)
		{
			other = _scriptEntries.GetValueOrDefault(scriptId) ?? throw new KeyNotFoundException("Script '" + scriptId + "' does not exist.");
		}
		if (!ReadCentralScriptCatalog(createMissingMetadata: true).TryGetValue(scriptId, out ScriptCatalogEntry value) || !value.Matches(other))
		{
			throw new ScriptAssetConflictException("Script '" + scriptId + "' changed on disk. Refresh the script library and try again.");
		}
		DeleteScriptPairTransaction(value);
		RefreshScriptAssetsCore(createMissingMetadata: false);
	}

	public string? ResolveDecalPath(string name)
	{
		return ResolveAssetInDirectory(_centralDecalDirectory, name);
	}

	public string? ResolveFontPath(string name)
	{
		return ResolveAssetInDirectory(_centralFontDirectory, name);
	}

	public string? ResolveModelPath(string name)
	{
		return ResolveAssetInDirectory(_centralModelDirectory, name);
	}

	private static string? ResolveAssetInDirectory(string directory, string name)
	{
		if (!Directory.Exists(directory))
		{
			return null;
		}
		string normalized;
		try
		{
			normalized = SceneLibraryPaths.NormalizeRelativePath(name);
		}
		catch (Exception ex) when ((ex is ArgumentException || ex is IOException) ? true : false)
		{
			return null;
		}
		string text = SceneLibraryPaths.ResolveRelativePath(directory, normalized);
		if (File.Exists(text))
		{
			return text;
		}
		string directoryName = Path.GetDirectoryName(text);
		string requestedName = Path.GetFileName(text);
		if (directoryName != null && Directory.Exists(directoryName))
		{
			string[] array = (from file in Directory.EnumerateFiles(directoryName)
				where string.Equals(Path.GetFileNameWithoutExtension(file), requestedName, StringComparison.OrdinalIgnoreCase)
				select file).Take(2).ToArray();
			if (array.Length == 1)
			{
				return array[0];
			}
			if (array.Length > 1)
			{
				return null;
			}
		}
		if (normalized.Contains('/'))
		{
			return null;
		}
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		string[] array2 = (from file in Directory.EnumerateFiles(directory, "*", enumerationOptions)
			where string.Equals(Path.GetFileNameWithoutExtension(file), normalized, StringComparison.OrdinalIgnoreCase)
			select file).Take(2).ToArray();
		if (array2.Length != 1)
		{
			return null;
		}
		return array2[0];
	}

	public bool TryAddDecalAsset(byte[] imageData, string fileExtension, out string? assetPath, string? originalFileName = null, string? folderPath = null)
	{
		try
		{
			string text = CalculateDataHash(imageData);
			if (string.IsNullOrWhiteSpace(folderPath) && TryGetImagePath(text, out string imagePath))
			{
				_logger.LogDebug("Decal with hash {ImageHash} already loaded at {ImagePath}", text, imagePath);
				assetPath = imagePath;
				return true;
			}
			string text2 = fileExtension.TrimStart('.');
			string targetDirectory = SceneLibraryPaths.ResolveFolderPath(_centralDecalDirectory, folderPath);
			string requestedFileName = ((!string.IsNullOrWhiteSpace(originalFileName)) ? (Path.GetFileNameWithoutExtension(originalFileName) + "." + text2) : (text + "." + text2));
			string text3 = StoreAsset(imageData, _centralDecalDirectory, targetDirectory, requestedFileName, "texture");
			_loadedDecals[text] = text3;
			assetPath = text3;
			return true;
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to add decal asset");
			assetPath = null;
			return false;
		}
	}

	public bool TryAddFontAsset(byte[] fontData, string fileExtension, string fontName)
	{
		string assetPath;
		return TryAddFontAsset(fontData, fileExtension, out assetPath, fontName, null);
	}

	public bool TryAddFontAsset(byte[] fontData, string fileExtension, out string? assetPath, string fontName, string? folderPath)
	{
		try
		{
			string text = CalculateDataHash(fontData);
			if (string.IsNullOrWhiteSpace(folderPath) && TryGetFontName(text, out string fontName2))
			{
				_logger.LogDebug("Font with hash {FontHash} already loaded: {FontName}", text, fontName2);
				assetPath = ResolveFontPath(fontName2);
				return true;
			}
			string requestedFileName = ((!string.IsNullOrEmpty(fontName)) ? (fontName + "." + fileExtension) : (text + "." + fileExtension));
			string targetDirectory = SceneLibraryPaths.ResolveFolderPath(_centralFontDirectory, folderPath);
			string text2 = StoreAsset(fontData, _centralFontDirectory, targetDirectory, requestedFileName, "font");
			string assetKey = SceneLibraryPaths.GetAssetKey(_centralFontDirectory, text2);
			_loadedFonts[text] = assetKey;
			assetPath = text2;
			FontAdded?.Invoke(this, new FontAddedEventArgs(assetKey, text2));
			return true;
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to add font asset");
			assetPath = null;
			return false;
		}
	}

	public bool TryRemoveDecalAsset(string assetPath, IEnumerable<Scene> allScenes)
	{
		string text = CalculateFileHash(assetPath);
		string assetName = Path.GetFileNameWithoutExtension(assetPath);
		if (allScenes.Any((Scene scene) => scene.GetDecalAssetNames().Contains(assetName)))
		{
			_logger.LogWarning("Cannot remove decal asset with hash {ImageHash} because it is still in use", text);
			return false;
		}
		if (TryGetImagePath(text, out string imagePath))
		{
			try
			{
				if (File.Exists(imagePath))
				{
					File.Delete(imagePath);
					_logger.LogDebug("Deleted decal asset at {ImagePath}", imagePath);
				}
				_loadedDecals.TryRemove(text, out string _);
				return true;
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to remove decal asset at {ImagePath}", imagePath);
				return false;
			}
		}
		return false;
	}

	public bool HasDecalAsset(string assetPath)
	{
		if (!File.Exists(assetPath))
		{
			return false;
		}
		string imageHash = CalculateFileHash(assetPath);
		string imagePath;
		return TryGetImagePath(imageHash, out imagePath);
	}

	public bool HasFontAsset(string fontName)
	{
		return ResolveFontPath(fontName) != null;
	}

	public bool TryGetFontByName(string fontName, out string? fontPath)
	{
		fontPath = ResolveFontPath(fontName);
		if (string.IsNullOrEmpty(fontPath))
		{
			return false;
		}
		string fontHash = CalculateFileHash(fontPath);
		string fontName2;
		return TryGetFontName(fontHash, out fontName2);
	}

	public bool TryAddModelAsset(byte[] modelData, string fileExtension, out string? assetPath, string? originalFileName = null, string? folderPath = null)
	{
		try
		{
			string text = CalculateDataHash(modelData);
			if (string.IsNullOrWhiteSpace(folderPath) && TryGetModelPath(text, out string modelPath))
			{
				_logger.LogDebug("Model with hash {ModelHash} already loaded at {ModelPath}", text, modelPath);
				assetPath = modelPath;
				return true;
			}
			string text2 = fileExtension.TrimStart('.');
			string targetDirectory = SceneLibraryPaths.ResolveFolderPath(_centralModelDirectory, folderPath);
			string requestedFileName = ((!string.IsNullOrWhiteSpace(originalFileName)) ? (Path.GetFileNameWithoutExtension(originalFileName) + "." + text2) : (text + "." + text2));
			string text3 = StoreAsset(modelData, _centralModelDirectory, targetDirectory, requestedFileName, "model");
			_loadedModels[text] = text3;
			assetPath = text3;
			return true;
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to add model asset");
			assetPath = null;
			return false;
		}
	}

	public bool TryReplaceModelAsset(string assetName, byte[] modelData, string fileExtension, out string? assetPath)
	{
		try
		{
			using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
			{
				string text = ResolveModelPath(assetName) ?? throw new FileNotFoundException("Model asset '" + assetName + "' does not exist.");
				string extension = "." + fileExtension.TrimStart('.');
				string text2 = Path.ChangeExtension(text, extension);
				if (!string.Equals(text, text2, StringComparison.OrdinalIgnoreCase) && File.Exists(text2))
				{
					throw new IOException("Model asset target '" + text2 + "' already exists.");
				}
				string text3 = text2 + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
				string text4 = null;
				try
				{
					WriteFile(text3, modelData);
					if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
					{
						File.Move(text3, text, overwrite: true);
					}
					else
					{
						text4 = text + $".{Environment.ProcessId}.{Guid.NewGuid():N}.bak";
						File.Move(text, text4, overwrite: false);
						try
						{
							File.Move(text3, text2, overwrite: false);
							File.Delete(text4);
							text4 = null;
						}
						catch
						{
							DeleteFileIfExists(text2);
							if (File.Exists(text4) && !File.Exists(text))
							{
								File.Move(text4, text, overwrite: false);
								text4 = null;
							}
							throw;
						}
					}
				}
				finally
				{
					DeleteFileIfExists(text3);
					if (text4 != null && File.Exists(text4) && !File.Exists(text))
					{
						File.Move(text4, text, overwrite: false);
					}
				}
				_loadedModels.Clear();
				LoadExistingModelAssets();
				assetPath = text2;
				_logger.LogInformation("Replaced model asset {AssetName} at {AssetPath}", assetName, text2);
				return true;
			}
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to replace model asset {AssetName}", assetName);
			assetPath = null;
			return false;
		}
	}

	public bool HasModelAsset(string assetPath)
	{
		if (!File.Exists(assetPath))
		{
			return false;
		}
		string modelHash = CalculateFileHash(assetPath);
		string modelPath;
		return TryGetModelPath(modelHash, out modelPath);
	}

	internal ScriptAsset MigrateLegacyScript(ScriptAsset legacyAsset, string? sourcePath)
	{
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			return MigrateLegacyScriptCore(legacyAsset, sourcePath, null);
		}
	}

	internal ScriptAsset MigrateLegacyScriptUnderWriteLease(ScriptAsset legacyAsset, string? sourcePath, ICollection<string> createdAssetPaths)
	{
		return MigrateLegacyScriptCore(legacyAsset, sourcePath, createdAssetPaths);
	}

	internal void ValidateImportedScriptAssets(string importRoot)
	{
		Dictionary<string, ScriptCatalogEntry> current = ReadCentralScriptCatalog(createMissingMetadata: true);
		Dictionary<string, ScriptCatalogEntry> imported = ReadScriptCatalog(importRoot, createMissingMetadata: false);
		ValidateImportedScriptAssets(current, imported);
	}

	internal void CopyImportedScriptAssets(string importRoot, ICollection<string> createdAssetPaths)
	{
		Dictionary<string, ScriptCatalogEntry> dictionary = ReadCentralScriptCatalog(createMissingMetadata: true);
		Dictionary<string, ScriptCatalogEntry> dictionary2 = ReadScriptCatalog(importRoot, createMissingMetadata: false);
		ValidateImportedScriptAssets(dictionary, dictionary2);
		foreach (ScriptCatalogEntry value in dictionary2.Values)
		{
			if (!dictionary.ContainsKey(value.Asset.Id))
			{
				string scriptPath = GetScriptPath(value.Asset.Name);
				string scriptMetadataPath = GetScriptMetadataPath(scriptPath);
				CreateScriptPairTransaction(scriptPath, scriptMetadataPath, File.ReadAllBytes(value.Path), File.ReadAllBytes(value.MetadataPath));
				createdAssetPaths.Add(scriptPath);
				createdAssetPaths.Add(scriptMetadataPath);
			}
		}
		RefreshScriptAssetsCore(createMissingMetadata: false);
	}

	public void LoadExistingAssets()
	{
		ValidateUniqueAssetKeys();
		RefreshScriptAssets();
		LoadExistingAssetsCore();
	}

	internal void LoadExistingAssetsUnderWriteLease()
	{
		ValidateUniqueAssetKeys();
		RefreshScriptAssetsCore(createMissingMetadata: true);
		LoadExistingAssetsCore();
	}

	private void LoadExistingAssetsCore()
	{
		_loadedDecals.Clear();
		_loadedFonts.Clear();
		_loadedModels.Clear();
		LoadExistingDecalAssets();
		LoadExistingFontAssets();
		LoadExistingModelAssets();
	}

	private void LoadExistingDecalAssets()
	{
		if (!Directory.Exists(_centralDecalDirectory))
		{
			_logger.LogWarning("Central decal directory does not exist: {DecalDirectory}", _centralDecalDirectory);
			return;
		}
		foreach (string decalFile in GetDecalFiles())
		{
			try
			{
				string key = CalculateFileHash(decalFile);
				if (!_loadedDecals.ContainsKey(key))
				{
					_loadedDecals[key] = decalFile;
					_logger.LogDebug("Loaded existing decal asset: {ImagePath}", decalFile);
				}
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to load decal asset from file: {FilePath}", decalFile);
			}
		}
	}

	private void LoadExistingFontAssets()
	{
		if (!Directory.Exists(_centralFontDirectory))
		{
			_logger.LogWarning("Central font directory does not exist: {FontDirectory}", _centralFontDirectory);
			return;
		}
		foreach (string fontFile in GetFontFiles())
		{
			try
			{
				string key = CalculateFileHash(fontFile);
				string assetKey = SceneLibraryPaths.GetAssetKey(_centralFontDirectory, fontFile);
				if (!_loadedFonts.ContainsKey(key))
				{
					_loadedFonts[key] = assetKey;
					_logger.LogDebug("Loaded existing font asset: {FontName}", assetKey);
				}
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to load font asset from file: {FilePath}", fontFile);
			}
		}
	}

	private void LoadExistingModelAssets()
	{
		if (!Directory.Exists(_centralModelDirectory))
		{
			_logger.LogWarning("Central model directory does not exist: {ModelDirectory}", _centralModelDirectory);
			return;
		}
		foreach (string modelFile in GetModelFiles())
		{
			try
			{
				string key = CalculateFileHash(modelFile);
				if (!_loadedModels.ContainsKey(key))
				{
					_loadedModels[key] = modelFile;
					_logger.LogDebug("Loaded existing model asset: {ModelPath}", modelFile);
				}
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, "Failed to load model asset from file: {FilePath}", modelFile);
			}
		}
	}

	private bool TryGetImagePath(string imageHash, out string? imagePath)
	{
		return _loadedDecals.TryGetValue(imageHash, out imagePath);
	}

	private bool TryGetModelPath(string modelHash, out string? modelPath)
	{
		return _loadedModels.TryGetValue(modelHash, out modelPath);
	}

	private bool TryGetFontName(string fontHash, out string? fontName)
	{
		return _loadedFonts.TryGetValue(fontHash, out fontName);
	}

	public IReadOnlyList<string> GetDecalFiles()
	{
		return GetAssetFiles(_centralDecalDirectory, new string[7] { ".png", ".jpg", ".jpeg", ".webp", ".dds", ".bmp", ".tga" });
	}

	public IReadOnlyList<string> GetFontFiles()
	{
		return GetAssetFiles(_centralFontDirectory, new string[4] { ".ttf", ".otf", ".woff", ".woff2" });
	}

	public IReadOnlyList<string> GetModelFiles()
	{
		return GetAssetFiles(_centralModelDirectory, new string[3] { ".glb", ".gltf", ".obj" });
	}

	public void CreateAssetFolder(string assetRoot, string folderPath)
	{
		ValidateAssetRoot(assetRoot);
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			Directory.CreateDirectory(SceneLibraryPaths.ResolveRelativePath(assetRoot, folderPath));
		}
	}

	public bool DeleteAssetFolder(string assetRoot, string folderPath)
	{
		ValidateAssetRoot(assetRoot);
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			string path = SceneLibraryPaths.ResolveRelativePath(assetRoot, folderPath);
			if (!Directory.Exists(path))
			{
				return false;
			}
			Directory.Delete(path, recursive: false);
			return true;
		}
	}

	private static IReadOnlyList<string> GetAssetFiles(string directory, string[] extensions)
	{
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		if (!Directory.Exists(directory))
		{
			return Array.Empty<string>();
		}
		List<string> list = new List<string>();
		list.AddRange((from path in Directory.EnumerateFiles(directory, "*", enumerationOptions)
			where extensions.Contains(Path.GetExtension(path).ToLowerInvariant())
			select path).OrderBy((string path) => path, StringComparer.OrdinalIgnoreCase));
		return new _003C_003Ez__ReadOnlyList<string>(list);
	}

	private string StoreAsset(byte[] data, string assetTypeRoot, string targetDirectory, string requestedFileName, string typeTag)
	{
		using (AcquireWriteLease() ?? throw new IOException("The shared asset library is busy in another application."))
		{
			Directory.CreateDirectory(targetDirectory);
			string text = CalculateDataHash(data);
			string extension = Path.GetExtension(requestedFileName);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(requestedFileName);
			for (int i = 0; i < 100; i++)
			{
				string relativePath = ((i == 0) ? requestedFileName : $"{fileNameWithoutExtension}_{typeTag}_{text.Substring(0, 8)}{((i == 1) ? "" : $"_{i}")}{extension}");
				string text2 = SceneLibraryPaths.ResolveRelativePath(targetDirectory, relativePath);
				string assetKey = SceneLibraryPaths.GetAssetKey(assetTypeRoot, text2);
				(string, string)? tuple = FindAssetByKey(assetKey);
				if (tuple.HasValue)
				{
					if (string.Equals(tuple.Value.Item1, assetTypeRoot, StringComparison.OrdinalIgnoreCase) && FileMatchesData(tuple.Value.Item2, data))
					{
						return tuple.Value.Item2;
					}
					continue;
				}
				string text3 = text2 + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
				try
				{
					using (FileStream fileStream = new FileStream(text3, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough))
					{
						fileStream.Write(data);
						fileStream.Flush(flushToDisk: true);
					}
					File.Move(text3, text2, overwrite: false);
					_logger.LogDebug("Saved new {AssetType} asset to {AssetPath}", typeTag, text2);
					return text2;
				}
				finally
				{
					if (File.Exists(text3))
					{
						File.Delete(text3);
					}
				}
			}
			throw new IOException("Could not allocate a unique name for asset '" + requestedFileName + "'.");
		}
	}

	private (string Root, string Path)? FindAssetByKey(string key)
	{
		foreach (var item in EnumerateTypedAssetFiles())
		{
			var (text, _) = item;
			foreach (string item2 in item.Files)
			{
				if (string.Equals(SceneLibraryPaths.GetAssetKey(text, item2), key, StringComparison.OrdinalIgnoreCase))
				{
					return (text, item2);
				}
			}
		}
		return null;
	}

	private void ValidateUniqueAssetKeys()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (var item in EnumerateTypedAssetFiles())
		{
			var (rootDirectory, _) = item;
			foreach (string item2 in item.Files)
			{
				string assetKey = SceneLibraryPaths.GetAssetKey(rootDirectory, item2);
				if (dictionary.TryGetValue(assetKey, out var value))
				{
					throw new IOException($"Scene assets '{value}' and '{item2}' share the logical name '{assetKey}'. Rename one before starting the editor.");
				}
				dictionary[assetKey] = item2;
			}
		}
	}

	private IEnumerable<(string Root, IReadOnlyList<string> Files)> EnumerateTypedAssetFiles()
	{
		yield return (Root: _centralDecalDirectory, Files: GetDecalFiles());
		yield return (Root: _centralFontDirectory, Files: GetFontFiles());
		yield return (Root: _centralModelDirectory, Files: GetModelFiles());
	}

	private void ValidateAssetRoot(string assetRoot)
	{
		string fullPath = Path.GetFullPath(assetRoot);
		if (!string.Equals(fullPath, Path.GetFullPath(_centralDecalDirectory), StringComparison.OrdinalIgnoreCase) && !string.Equals(fullPath, Path.GetFullPath(_centralFontDirectory), StringComparison.OrdinalIgnoreCase) && !string.Equals(fullPath, Path.GetFullPath(_centralModelDirectory), StringComparison.OrdinalIgnoreCase) && !string.Equals(fullPath, Path.GetFullPath(_centralScriptDirectory), StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException("The directory is not a managed scene-asset root.", "assetRoot");
		}
	}

	internal FileStream? AcquireWriteLease()
	{
		for (int i = 0; i < 1200; i++)
		{
			try
			{
				return new FileStream(_assetWriteLockPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
			}
			catch (IOException) when (i < 1199)
			{
				Thread.Sleep(50);
			}
		}
		return null;
	}

	internal void ValidateImportedAssets(IEnumerable<(string SourceRoot, string DestinationRoot)> imports)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (var item in EnumerateTypedAssetFiles())
		{
			var (rootDirectory, _) = item;
			foreach (string item2 in item.Files)
			{
				dictionary[SceneLibraryPaths.GetAssetKey(rootDirectory, item2)] = item2;
			}
		}
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		foreach (var (text, text2) in imports)
		{
			ValidateAssetRoot(text2);
			if (!Directory.Exists(text))
			{
				continue;
			}
			foreach (string item3 in Directory.EnumerateFiles(text, "*", enumerationOptions))
			{
				string relativePath = Path.GetRelativePath(text, item3);
				string text3 = SceneLibraryPaths.ResolveRelativePath(text2, relativePath);
				string assetKey = SceneLibraryPaths.GetAssetKey(text2, text3);
				if (dictionary.TryGetValue(assetKey, out var value))
				{
					if (!string.Equals(Path.GetFullPath(value), Path.GetFullPath(text3), StringComparison.OrdinalIgnoreCase) || !File.Exists(value) || !FileMatchesFile(item3, value))
					{
						throw new IOException($"Imported asset '{item3}' conflicts with '{value}'.");
					}
				}
				else
				{
					dictionary[assetKey] = text3;
				}
			}
		}
	}

	private ScriptAsset MigrateLegacyScriptCore(ScriptAsset legacyAsset, string? sourcePath, ICollection<string>? createdAssetPaths)
	{
		if (string.IsNullOrWhiteSpace(legacyAsset.Id))
		{
			throw new InvalidDataException("A legacy script has no stable ID.");
		}
		string text = ((sourcePath != null && File.Exists(sourcePath)) ? DecodeScript(File.ReadAllBytes(sourcePath)) : (legacyAsset.Content ?? ""));
		Dictionary<string, ScriptCatalogEntry> dictionary = ReadCentralScriptCatalog(createMissingMetadata: true);
		if (dictionary.TryGetValue(legacyAsset.Id, out var value))
		{
			byte[] array = SHA256.HashData(s_utf8.GetBytes(text));
			if (!value.ContentHash.SequenceEqual(array))
			{
				throw new ScriptAssetConflictException("Legacy script ID '" + legacyAsset.Id + "' already exists with different content.");
			}
			RefreshScriptAssetsCore(createMissingMetadata: false);
			return CloneScriptAsset(value.Asset);
		}
		string candidate;
		string value2 = (candidate = NormalizeScriptName(legacyAsset.Name));
		int num = 2;
		while (dictionary.Values.Any((ScriptCatalogEntry entry) => entry.Asset.Name.Equals(candidate, StringComparison.OrdinalIgnoreCase)))
		{
			candidate = $"{value2}-{num}";
			num++;
		}
		return CreateScriptAsset(legacyAsset.Id, candidate, text, createdAssetPaths, writeLeaseHeld: true);
	}

	private ScriptAsset CreateScriptAsset(string scriptId, string name, string content, ICollection<string>? createdAssetPaths, bool writeLeaseHeld)
	{
		FileStream fileStream = (writeLeaseHeld ? null : AcquireWriteLease());
		if (!writeLeaseHeld && fileStream == null)
		{
			throw new IOException("The shared asset library is busy in another application.");
		}
		try
		{
			Dictionary<string, ScriptCatalogEntry> dictionary = ReadCentralScriptCatalog(createMissingMetadata: true);
			byte[] bytes = s_utf8.GetBytes(content);
			if (dictionary.TryGetValue(scriptId, out var value))
			{
				if (!SHA256.HashData(bytes).SequenceEqual(value.ContentHash))
				{
					throw new ScriptAssetConflictException("Script ID '" + scriptId + "' already exists with different content.");
				}
				RefreshScriptAssetsCore(createMissingMetadata: false);
				return CloneScriptAsset(value.Asset);
			}
			string normalizedName = NormalizeScriptName(name);
			ScriptCatalogEntry scriptCatalogEntry = dictionary.Values.FirstOrDefault((ScriptCatalogEntry entry) => entry.Asset.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase));
			if ((object)scriptCatalogEntry != null)
			{
				throw new ScriptAssetConflictException($"Script path '{normalizedName}' is already used by '{scriptCatalogEntry.Asset.Id}'.");
			}
			string scriptPath = GetScriptPath(normalizedName);
			string scriptMetadataPath = GetScriptMetadataPath(scriptPath);
			CreateScriptPairTransaction(scriptPath, scriptMetadataPath, bytes, SerializeMetadata(scriptId));
			createdAssetPaths?.Add(scriptPath);
			createdAssetPaths?.Add(scriptMetadataPath);
			RefreshScriptAssetsCore(createMissingMetadata: false);
			return GetScriptAsset(scriptId);
		}
		finally
		{
			fileStream?.Dispose();
		}
	}

	private void RefreshScriptAssetsCore(bool createMissingMetadata)
	{
		Dictionary<string, ScriptCatalogEntry> scriptEntries = ReadCentralScriptCatalog(createMissingMetadata);
		lock (_scriptCatalogLock)
		{
			_scriptEntries = scriptEntries;
		}
	}

	private Dictionary<string, ScriptCatalogEntry> ReadCentralScriptCatalog(bool createMissingMetadata)
	{
		RecoverScriptTransaction();
		return ReadScriptCatalog(_centralScriptDirectory, createMissingMetadata);
	}

	private static Dictionary<string, ScriptCatalogEntry> ReadScriptCatalog(string scriptRoot, bool createMissingMetadata)
	{
		Dictionary<string, ScriptCatalogEntry> dictionary = new Dictionary<string, ScriptCatalogEntry>(StringComparer.Ordinal);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		if (!Directory.Exists(scriptRoot))
		{
			return dictionary;
		}
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		string[] array = (from path in Directory.EnumerateFiles(scriptRoot, "*", enumerationOptions)
			where Path.GetExtension(path).Equals(".as", StringComparison.OrdinalIgnoreCase)
			select path).OrderBy((string path) => path, StringComparer.OrdinalIgnoreCase).ToArray();
		foreach (string text in array)
		{
			string assetKey = SceneLibraryPaths.GetAssetKey(scriptRoot, text);
			if (dictionary2.TryGetValue(assetKey, out var value))
			{
				throw new InvalidDataException($"Scripts '{value}' and '{text}' share the logical path '{assetKey}'.");
			}
			string text2 = SceneLibraryPaths.ResolveRelativePath(scriptRoot, Path.GetRelativePath(scriptRoot, GetScriptMetadataPath(text)));
			if (!File.Exists(text2))
			{
				if (!createMissingMetadata)
				{
					throw new InvalidDataException("Script '" + text + "' has no .as.meta sidecar.");
				}
				WriteNewFileAtomic(text2, SerializeMetadata(Guid.NewGuid().ToString()));
			}
			byte[] array2 = File.ReadAllBytes(text2);
			ScriptMetadata scriptMetadata;
			try
			{
				scriptMetadata = JsonSerializer.Deserialize<ScriptMetadata>(array2) ?? throw new JsonException("The metadata document is empty.");
			}
			catch (JsonException innerException)
			{
				throw new InvalidDataException("Script metadata '" + text2 + "' is malformed.", innerException);
			}
			if (string.IsNullOrWhiteSpace(scriptMetadata.Id))
			{
				throw new InvalidDataException("Script metadata '" + text2 + "' has no stable ID.");
			}
			if (dictionary.TryGetValue(scriptMetadata.Id, out var value2))
			{
				throw new InvalidDataException($"Scripts '{value2.Path}' and '{text}' share ID '{scriptMetadata.Id}'.");
			}
			byte[] array3 = File.ReadAllBytes(text);
			string content = DecodeScript(array3);
			ScriptAsset asset = new ScriptAsset
			{
				Id = scriptMetadata.Id,
				Name = assetKey,
				Content = content,
				Variables = ScriptVariableParser.Parse(content)
			};
			dictionary.Add(scriptMetadata.Id, new ScriptCatalogEntry(asset, text, text2, SHA256.HashData(array3), SHA256.HashData(array2)));
			dictionary2.Add(assetKey, text);
		}
		foreach (string item in from path in Directory.EnumerateFiles(scriptRoot, "*", enumerationOptions)
			where path.EndsWith(".as.meta", StringComparison.OrdinalIgnoreCase)
			select path)
		{
			string text3 = item;
			int num = ".meta".Length;
			if (!File.Exists(text3.Substring(0, text3.Length - num)))
			{
				throw new InvalidDataException("Script metadata '" + item + "' has no matching .as source file.");
			}
		}
		return dictionary;
	}

	private static void ValidateImportedScriptAssets(IReadOnlyDictionary<string, ScriptCatalogEntry> current, IReadOnlyDictionary<string, ScriptCatalogEntry> imported)
	{
		Dictionary<string, ScriptCatalogEntry> dictionary = current.Values.ToDictionary((ScriptCatalogEntry entry) => entry.Asset.Name, StringComparer.OrdinalIgnoreCase);
		foreach (ScriptCatalogEntry value3 in imported.Values)
		{
			if (current.TryGetValue(value3.Asset.Id, out ScriptCatalogEntry value))
			{
				if (!value.ContentHash.SequenceEqual(value3.ContentHash))
				{
					throw new ScriptAssetConflictException($"Imported script '{value3.Path}' conflicts with '{value.Path}'.");
				}
				continue;
			}
			if (dictionary.TryGetValue(value3.Asset.Name, out var value2))
			{
				throw new ScriptAssetConflictException($"Imported script '{value3.Path}' conflicts with '{value2.Path}'.");
			}
			dictionary.Add(value3.Asset.Name, value3);
		}
	}

	private string GetScriptPath(string name)
	{
		return SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, name + ".as");
	}

	private static string GetScriptMetadataPath(string scriptPath)
	{
		return scriptPath + ".meta";
	}

	private static string NormalizeScriptName(string name)
	{
		string text = SceneLibraryPaths.NormalizeRelativePath(name);
		if (text.EndsWith(".as", StringComparison.OrdinalIgnoreCase))
		{
			string text2 = text;
			text = SceneLibraryPaths.NormalizeRelativePath(text2.Substring(0, text2.Length - 3));
		}
		return text;
	}

	private static ScriptAsset CloneScriptAsset(ScriptAsset asset)
	{
		string content = asset.Content ?? "";
		return new ScriptAsset
		{
			Id = asset.Id,
			Name = asset.Name,
			Content = content,
			Variables = ScriptVariableParser.Parse(content)
		};
	}

	private static byte[] SerializeMetadata(string scriptId)
	{
		return JsonSerializer.SerializeToUtf8Bytes(new ScriptMetadata
		{
			Id = scriptId
		});
	}

	private static string DecodeScript(byte[] data)
	{
		ReadOnlySpan<byte> readOnlySpan = data;
		ReadOnlySpan<byte> preamble = s_utf8.Preamble;
		if (readOnlySpan.StartsWith(preamble))
		{
			readOnlySpan = readOnlySpan.Slice(preamble.Length);
		}
		return s_utf8.GetString(readOnlySpan);
	}

	private void CreateScriptPairTransaction(string scriptPath, string metadataPath, byte[] contentData, byte[] metadataData)
	{
		if (!metadataPath.Equals(GetScriptMetadataPath(scriptPath), StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidDataException("A managed script sidecar must be adjacent to its source file.");
		}
		ScriptTransaction scriptTransaction = CreateScriptTransaction("create", null, scriptPath, contentData, metadataData);
		WriteScriptTransaction(scriptTransaction);
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(scriptPath));
			File.Move(ResolveTransactionStagePath(scriptTransaction.StageSourcePath, ".source"), scriptPath, overwrite: false);
			File.Move(ResolveTransactionStagePath(scriptTransaction.StageMetadataPath, ".metadata"), metadataPath, overwrite: false);
			ValidateFileHash(scriptPath, scriptTransaction.TargetContentHash);
			ValidateFileHash(metadataPath, scriptTransaction.TargetMetadataHash);
			ClearScriptTransaction();
		}
		catch
		{
			RecoverScriptTransaction();
			if (File.Exists(scriptPath) && File.Exists(metadataPath) && ValidateFileHash(scriptPath, scriptTransaction.TargetContentHash) && ValidateFileHash(metadataPath, scriptTransaction.TargetMetadataHash))
			{
				return;
			}
			throw;
		}
	}

	private void MoveScriptPairTransaction(ScriptCatalogEntry source, string targetPath, string targetMetadataPath, byte[] contentData, byte[] metadataData)
	{
		ScriptTransaction scriptTransaction = CreateScriptTransaction("rename", source, targetPath, contentData, metadataData);
		WriteScriptTransaction(scriptTransaction);
		RecoverScriptTransaction();
		ValidateFileHash(targetPath, scriptTransaction.TargetContentHash);
		ValidateFileHash(targetMetadataPath, scriptTransaction.TargetMetadataHash);
	}

	private void DeleteScriptPairTransaction(ScriptCatalogEntry source)
	{
		ScriptTransaction transaction = new ScriptTransaction
		{
			Operation = "delete",
			ScriptId = source.Asset.Id,
			SourcePath = GetTransactionRelativePath(source.Path),
			SourceContentHash = GetHash(source.ContentHash),
			SourceMetadataHash = GetHash(source.MetadataHash)
		};
		WriteScriptTransaction(transaction);
		RecoverScriptTransaction();
	}

	private ScriptTransaction CreateScriptTransaction(string operation, ScriptCatalogEntry? source, string targetPath, byte[] contentData, byte[] metadataData)
	{
		string text = DeserializeMetadataId(metadataData);
		if ((object)source != null && source.Asset.Id != text)
		{
			throw new InvalidDataException("A script rename cannot change its stable ID.");
		}
		string sourcePath = (((object)source == null) ? null : GetTransactionRelativePath(source.Path));
		string transactionRelativePath = GetTransactionRelativePath(targetPath);
		string hash = GetHash(SHA256.HashData(contentData));
		string hash2 = GetHash(SHA256.HashData(metadataData));
		string text2 = Guid.NewGuid().ToString("N");
		string path = Path.Combine(_centralScriptDirectory, ".script-stage-" + text2 + ".source");
		string path2 = Path.Combine(_centralScriptDirectory, ".script-stage-" + text2 + ".metadata");
		try
		{
			WriteNewFileAtomic(path, contentData);
			WriteNewFileAtomic(path2, metadataData);
		}
		catch
		{
			DeleteFileIfExists(path);
			DeleteFileIfExists(path2);
			throw;
		}
		return new ScriptTransaction
		{
			Operation = operation,
			ScriptId = text,
			SourcePath = sourcePath,
			SourceContentHash = (((object)source == null) ? null : GetHash(source.ContentHash)),
			SourceMetadataHash = (((object)source == null) ? null : GetHash(source.MetadataHash)),
			TargetPath = transactionRelativePath,
			TargetContentHash = hash,
			TargetMetadataHash = hash2,
			StageSourcePath = GetTransactionRelativePath(path),
			StageMetadataPath = GetTransactionRelativePath(path2)
		};
	}

	private void WriteScriptTransaction(ScriptTransaction transaction)
	{
		try
		{
			string validatedScriptTransactionPath = GetValidatedScriptTransactionPath();
			if (File.Exists(validatedScriptTransactionPath))
			{
				throw new ScriptAssetConflictException("A script transaction is already pending recovery.");
			}
			WriteNewFileAtomic(validatedScriptTransactionPath, JsonSerializer.SerializeToUtf8Bytes(transaction));
		}
		catch
		{
			if (transaction.StageSourcePath != null)
			{
				DeleteFileIfExists(ResolveTransactionStagePath(transaction.StageSourcePath, ".source"));
			}
			if (transaction.StageMetadataPath != null)
			{
				DeleteFileIfExists(ResolveTransactionStagePath(transaction.StageMetadataPath, ".metadata"));
			}
			throw;
		}
	}

	private void RecoverScriptTransaction()
	{
		string validatedScriptTransactionPath = GetValidatedScriptTransactionPath();
		if (!File.Exists(validatedScriptTransactionPath))
		{
			DeleteOrphanedTransactionStages();
			return;
		}
		ScriptTransaction scriptTransaction;
		try
		{
			scriptTransaction = JsonSerializer.Deserialize<ScriptTransaction>(File.ReadAllBytes(validatedScriptTransactionPath)) ?? throw new JsonException("The transaction journal is empty.");
		}
		catch (JsonException innerException)
		{
			throw new InvalidDataException("The script transaction journal is malformed.", innerException);
		}
		if (string.IsNullOrWhiteSpace(scriptTransaction.ScriptId))
		{
			throw new InvalidDataException("The script transaction journal has no stable ID.");
		}
		switch (scriptTransaction.Operation)
		{
		case "create":
			RecoverCreateScriptTransaction(scriptTransaction);
			break;
		case "rename":
			RecoverRenameScriptTransaction(scriptTransaction);
			break;
		case "delete":
			RecoverDeleteScriptTransaction(scriptTransaction);
			break;
		default:
			throw new InvalidDataException("Unknown script transaction operation '" + scriptTransaction.Operation + "'.");
		}
	}

	private void DeleteOrphanedTransactionStages()
	{
		foreach (string item in Directory.EnumerateFiles(_centralScriptDirectory, ".script-stage-*", SearchOption.TopDirectoryOnly))
		{
			if (item.EndsWith(".source", StringComparison.Ordinal) || item.EndsWith(".metadata", StringComparison.Ordinal))
			{
				DeleteFileIfExists(item);
			}
		}
	}

	private void RecoverCreateScriptTransaction(ScriptTransaction transaction)
	{
		(string TargetPath, string MetadataPath) tuple = ResolveTransactionTarget(transaction);
		string item = tuple.TargetPath;
		string item2 = tuple.MetadataPath;
		string path = ResolveTransactionStagePath(transaction.StageSourcePath, ".source");
		string text = ResolveTransactionStagePath(transaction.StageMetadataPath, ".metadata");
		bool flag = ValidateFileHash(item, transaction.TargetContentHash);
		bool flag2 = ValidateFileHash(item2, transaction.TargetMetadataHash);
		bool flag3 = ValidateFileHash(path, transaction.TargetContentHash);
		bool flag4 = ValidateFileHash(text, transaction.TargetMetadataHash);
		if (flag2)
		{
			ValidateMetadataId(item2, transaction.ScriptId);
		}
		if (flag4)
		{
			ValidateMetadataId(text, transaction.ScriptId);
		}
		if ((flag & flag3) || (flag2 & flag4))
		{
			throw new ScriptAssetConflictException("A script create recovery found an unexpected duplicate file.");
		}
		if ((flag & flag2) && !flag3 && !flag4)
		{
			ClearScriptTransaction();
			return;
		}
		DeleteFileIfExists(item);
		DeleteFileIfExists(item2);
		DeleteFileIfExists(path);
		DeleteFileIfExists(text);
		ClearScriptTransaction();
	}

	private void RecoverRenameScriptTransaction(ScriptTransaction transaction)
	{
		var (text, text2) = ResolveTransactionSource(transaction);
		var (text3, text4) = ResolveTransactionTarget(transaction);
		if (text.Equals(text3, StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidDataException("A script rename transaction uses the same source and target path.");
		}
		ValidateFileHash(text, transaction.SourceContentHash);
		if (ValidateFileHash(text2, transaction.SourceMetadataHash))
		{
			ValidateMetadataId(text2, transaction.ScriptId);
		}
		string stagePath = ResolveTransactionStagePath(transaction.StageSourcePath, ".source");
		string stagePath2 = ResolveTransactionStagePath(transaction.StageMetadataPath, ".metadata");
		CompleteTransactionMove(stagePath, text3, transaction.TargetContentHash);
		CompleteTransactionMove(stagePath2, text4, transaction.TargetMetadataHash);
		ValidateMetadataId(text4, transaction.ScriptId);
		DeleteFileIfExists(text);
		DeleteFileIfExists(text2);
		ClearScriptTransaction();
	}

	private void RecoverDeleteScriptTransaction(ScriptTransaction transaction)
	{
		var (path, text) = ResolveTransactionSource(transaction);
		ValidateFileHash(path, transaction.SourceContentHash);
		if (ValidateFileHash(text, transaction.SourceMetadataHash))
		{
			ValidateMetadataId(text, transaction.ScriptId);
		}
		DeleteFileIfExists(path);
		DeleteFileIfExists(text);
		ClearScriptTransaction();
	}

	private static void CompleteTransactionMove(string stagePath, string targetPath, string? expectedHash)
	{
		bool flag = ValidateFileHash(stagePath, expectedHash);
		bool flag2 = ValidateFileHash(targetPath, expectedHash);
		if (flag & flag2)
		{
			throw new ScriptAssetConflictException("Both staged and target script files exist at '" + targetPath + "'.");
		}
		if (!flag && !flag2)
		{
			throw new InvalidDataException("A staged script file and its target are both missing at '" + targetPath + "'.");
		}
		if (flag)
		{
			Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
			File.Move(stagePath, targetPath, overwrite: false);
		}
		ValidateFileHash(targetPath, expectedHash);
	}

	private (string SourcePath, string MetadataPath) ResolveTransactionSource(ScriptTransaction transaction)
	{
		string text = ResolveTransactionScriptPath(transaction.SourcePath);
		ValidateHash(transaction.SourceContentHash);
		ValidateHash(transaction.SourceMetadataHash);
		return (SourcePath: text, MetadataPath: ResolveManagedMetadataPath(text));
	}

	private (string TargetPath, string MetadataPath) ResolveTransactionTarget(ScriptTransaction transaction)
	{
		string text = ResolveTransactionScriptPath(transaction.TargetPath);
		ValidateHash(transaction.TargetContentHash);
		ValidateHash(transaction.TargetMetadataHash);
		return (TargetPath: text, MetadataPath: ResolveManagedMetadataPath(text));
	}

	private string ResolveTransactionScriptPath(string? relativePath)
	{
		if (string.IsNullOrWhiteSpace(relativePath) || !relativePath.EndsWith(".as", StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidDataException("A script transaction contains an invalid source or target path.");
		}
		try
		{
			return SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, relativePath);
		}
		catch (ArgumentException innerException)
		{
			throw new InvalidDataException("A script transaction path escapes the script library.", innerException);
		}
	}

	private string ResolveTransactionStagePath(string? relativePath, string suffix)
	{
		if (string.IsNullOrWhiteSpace(relativePath))
		{
			throw new InvalidDataException("A script transaction has no staging path.");
		}
		string text;
		try
		{
			text = SceneLibraryPaths.NormalizeRelativePath(relativePath);
		}
		catch (ArgumentException innerException)
		{
			throw new InvalidDataException("A script transaction has an invalid staging path.", innerException);
		}
		if (text.Contains('/') || !text.StartsWith(".script-stage-", StringComparison.Ordinal) || !text.EndsWith(suffix, StringComparison.Ordinal))
		{
			throw new InvalidDataException("A script transaction has an invalid staging path.");
		}
		return SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, text);
	}

	private string GetTransactionRelativePath(string path)
	{
		string text = SceneLibraryPaths.NormalizeRelativePath(Path.GetRelativePath(_centralScriptDirectory, path));
		SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, text);
		return text;
	}

	private string ResolveManagedMetadataPath(string scriptPath)
	{
		return SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, Path.GetRelativePath(_centralScriptDirectory, GetScriptMetadataPath(scriptPath)));
	}

	private string GetValidatedScriptTransactionPath()
	{
		return SceneLibraryPaths.ResolveRelativePath(_centralScriptDirectory, Path.GetRelativePath(_centralScriptDirectory, _scriptTransactionPath));
	}

	private static bool ValidateFileHash(string path, string? expectedHash)
	{
		ValidateHash(expectedHash);
		if (!File.Exists(path))
		{
			return false;
		}
		using FileStream source = File.OpenRead(path);
		if (!GetHash(SHA256.HashData(source)).Equals(expectedHash, StringComparison.OrdinalIgnoreCase))
		{
			throw new ScriptAssetConflictException("Script transaction file '" + path + "' has unexpected content.");
		}
		return true;
	}

	private static void ValidateHash(string? hash)
	{
		try
		{
			if (hash == null || Convert.FromHexString(hash).Length != 32)
			{
				throw new FormatException();
			}
		}
		catch (FormatException innerException)
		{
			throw new InvalidDataException("A script transaction contains an invalid hash.", innerException);
		}
	}

	private static string GetHash(byte[] hash)
	{
		return Convert.ToHexString(hash).ToLowerInvariant();
	}

	private static string DeserializeMetadataId(byte[] metadataData)
	{
		try
		{
			ScriptMetadata? scriptMetadata = JsonSerializer.Deserialize<ScriptMetadata>(metadataData) ?? throw new JsonException("The metadata document is empty.");
			if (string.IsNullOrWhiteSpace(scriptMetadata.Id))
			{
				throw new JsonException("The metadata document has no stable ID.");
			}
			return scriptMetadata.Id;
		}
		catch (JsonException innerException)
		{
			throw new InvalidDataException("Script metadata is malformed.", innerException);
		}
	}

	private static void ValidateMetadataId(string metadataPath, string expectedId)
	{
		string text = DeserializeMetadataId(File.ReadAllBytes(metadataPath));
		if (text != expectedId)
		{
			throw new ScriptAssetConflictException($"Script transaction metadata '{metadataPath}' has unexpected ID '{text}'.");
		}
	}

	private void ClearScriptTransaction()
	{
		File.Delete(GetValidatedScriptTransactionPath());
	}

	private static void WriteNewFileAtomic(string path, byte[] data)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(path));
		string text = path + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
		try
		{
			WriteFile(text, data);
			File.Move(text, path, overwrite: false);
		}
		finally
		{
			DeleteFileIfExists(text);
		}
	}

	private static void ReplaceFileAtomic(string path, byte[] data)
	{
		string text = path + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
		try
		{
			WriteFile(text, data);
			File.Move(text, path, overwrite: true);
		}
		finally
		{
			DeleteFileIfExists(text);
		}
	}

	private static void WriteFile(string path, byte[] data)
	{
		using FileStream fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough);
		fileStream.Write(data);
		fileStream.Flush(flushToDisk: true);
	}

	private static void DeleteFileIfExists(string path)
	{
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	private static bool FileMatchesData(string filePath, byte[] data)
	{
		if (new FileInfo(filePath).Length != data.Length)
		{
			return false;
		}
		using FileStream source = File.OpenRead(filePath);
		return SHA256.HashData(source).SequenceEqual(SHA256.HashData(data));
	}

	private static bool FileMatchesFile(string leftPath, string rightPath)
	{
		FileInfo fileInfo = new FileInfo(leftPath);
		FileInfo fileInfo2 = new FileInfo(rightPath);
		if (fileInfo.Length != fileInfo2.Length)
		{
			return false;
		}
		using FileStream source = File.OpenRead(leftPath);
		using FileStream source2 = File.OpenRead(rightPath);
		return SHA256.HashData(source).SequenceEqual(SHA256.HashData(source2));
	}

	private static string CalculateFileHash(string filePath)
	{
		using SHA256 sHA = SHA256.Create();
		using FileStream inputStream = File.OpenRead(filePath);
		return Convert.ToHexString(sHA.ComputeHash(inputStream)).ToLowerInvariant();
	}

	private static string CalculateDataHash(byte[] data)
	{
		return Convert.ToHexString(SHA256.HashData(data)).ToLowerInvariant();
	}

	internal static HashSet<string> GetDecalPathsForScenes(IEnumerable<Scene> scenes)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Scene scene in scenes)
		{
			foreach (string decalAssetName in scene.GetDecalAssetNames())
			{
				hashSet.Add(decalAssetName);
			}
		}
		return hashSet;
	}

	internal static HashSet<string> GetFontNamesForScenes(IEnumerable<Scene> scenes)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Scene scene in scenes)
		{
			foreach (string fontName in scene.GetFontNames())
			{
				hashSet.Add(fontName);
			}
		}
		return hashSet;
	}

	internal static HashSet<string> GetModelPathsForScenes(IEnumerable<Scene> scenes)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Scene scene in scenes)
		{
			foreach (string modelAssetName in scene.GetModelAssetNames())
			{
				hashSet.Add(modelAssetName);
			}
		}
		return hashSet;
	}
}
