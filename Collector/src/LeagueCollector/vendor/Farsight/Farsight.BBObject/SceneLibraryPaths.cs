using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Farsight.BBObject;

public sealed class SceneLibraryPaths
{
	public string RootDirectory { get; }

	public string ScenesDirectory { get; }

	public string AssetsDirectory { get; }

	public string ScriptDirectory { get; }

	public string TextureDirectory { get; }

	public string FontDirectory { get; }

	public string ModelDirectory { get; }

	public string PrefabDirectory { get; }

	public SceneLibraryPaths(string rootDirectory)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(rootDirectory, "rootDirectory");
		RootDirectory = Path.GetFullPath(rootDirectory);
		ScenesDirectory = Path.Combine(RootDirectory, "Scenes");
		AssetsDirectory = Path.Combine(RootDirectory, "Assets");
		ScriptDirectory = Path.Combine(AssetsDirectory, "Scripts");
		TextureDirectory = Path.Combine(AssetsDirectory, "Textures");
		FontDirectory = Path.Combine(AssetsDirectory, "Fonts");
		ModelDirectory = Path.Combine(AssetsDirectory, "Models");
		PrefabDirectory = Path.Combine(AssetsDirectory, "Prefabs");
	}

	public void EnsureCreated()
	{
		Directory.CreateDirectory(RootDirectory);
		RejectReparsePoints(RootDirectory, RootDirectory);
		Directory.CreateDirectory(ScenesDirectory);
		RejectReparsePoints(RootDirectory, ScenesDirectory);
		Directory.CreateDirectory(AssetsDirectory);
		RejectReparsePoints(RootDirectory, AssetsDirectory);
		Directory.CreateDirectory(ScriptDirectory);
		RejectReparsePoints(RootDirectory, ScriptDirectory);
		Directory.CreateDirectory(TextureDirectory);
		RejectReparsePoints(RootDirectory, TextureDirectory);
		Directory.CreateDirectory(FontDirectory);
		RejectReparsePoints(RootDirectory, FontDirectory);
		Directory.CreateDirectory(ModelDirectory);
		RejectReparsePoints(RootDirectory, ModelDirectory);
		Directory.CreateDirectory(PrefabDirectory);
		RejectReparsePoints(RootDirectory, PrefabDirectory);
	}

	public static string NormalizeRelativePath(string relativePath)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(relativePath, "relativePath");
		if (Path.IsPathRooted(relativePath))
		{
			throw new ArgumentException("The path must be relative.", "relativePath");
		}
		string[] array = relativePath.Replace('\\', '/').Split('/', StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0 || array.Any((string segment) => ((segment == "." || segment == "..") ? true : false) || segment.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0))
		{
			throw new ArgumentException("The path contains an invalid segment.", "relativePath");
		}
		return string.Join('/', array);
	}

	public static string ResolveRelativePath(string rootDirectory, string relativePath)
	{
		string fullPath = Path.GetFullPath(rootDirectory);
		string text = NormalizeRelativePath(relativePath);
		string fullPath2 = Path.GetFullPath(Path.Combine(fullPath, text.Replace('/', Path.DirectorySeparatorChar)));
		string value = fullPath.TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		}) + Path.DirectorySeparatorChar;
		if (!fullPath2.StartsWith(value, StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException("The path escapes the scene library.", "relativePath");
		}
		RejectReparsePoints(fullPath, fullPath2);
		return fullPath2;
	}

	public static string ResolveFolderPath(string rootDirectory, string? folderPath)
	{
		if (!string.IsNullOrWhiteSpace(folderPath))
		{
			return ResolveRelativePath(rootDirectory, folderPath);
		}
		string fullPath = Path.GetFullPath(rootDirectory);
		RejectReparsePoints(fullPath, fullPath);
		return fullPath;
	}

	public static string GetAssetKey(string rootDirectory, string filePath)
	{
		return NormalizeRelativePath(Path.ChangeExtension(Path.GetRelativePath(Path.GetFullPath(rootDirectory), Path.GetFullPath(filePath)), null) ?? throw new ArgumentException("The asset path has no file name.", "filePath"));
	}

	private static void RejectReparsePoints(string rootDirectory, string targetPath)
	{
		if ((Directory.Exists(rootDirectory) || File.Exists(rootDirectory)) && File.GetAttributes(rootDirectory).HasFlag(FileAttributes.ReparsePoint))
		{
			throw new IOException("Scene library roots cannot be reparse points: " + rootDirectory);
		}
		string relativePath = Path.GetRelativePath(rootDirectory, targetPath);
		string text = rootDirectory;
		InlineArray2<char> buffer = default;
		buffer[0] = Path.DirectorySeparatorChar;
		buffer[1] = Path.AltDirectorySeparatorChar;
		string[] array = relativePath.Split(buffer);
		foreach (string path in array)
		{
			text = Path.Combine(text, path);
			if ((Directory.Exists(text) || File.Exists(text)) && File.GetAttributes(text).HasFlag(FileAttributes.ReparsePoint))
			{
				throw new IOException("Scene library paths cannot traverse reparse points: " + text);
			}
		}
	}
}
