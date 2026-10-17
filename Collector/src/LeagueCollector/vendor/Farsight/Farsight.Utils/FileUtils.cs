using System.IO;

namespace Farsight.Utils;

public static class FileUtils
{
	public static string AddTrailingSeparatorIfItIsAFolder(string fileOrFolderPath)
	{
		if (!Directory.Exists(fileOrFolderPath))
		{
			return fileOrFolderPath;
		}
		return fileOrFolderPath + "\\";
	}

	public static string ToCanonicalPath(string fileOrFolderPath)
	{
		string text = Path.GetFullPath(fileOrFolderPath);
		if (!text.EndsWith('\\') && Directory.Exists(text))
		{
			text += "\\";
		}
		return text;
	}

	public static bool Exists(string path)
	{
		if (!File.Exists(path))
		{
			return Directory.Exists(path);
		}
		return true;
	}
}
