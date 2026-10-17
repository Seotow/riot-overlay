namespace LeagueCollector;

public static class DotEnv
{
    public static void Load(string path)
    {
        if (!File.Exists(path)) return;
        if (new FileInfo(path).Length > 65536) throw new InvalidDataException("Credentials file is too large.");
        var found = new HashSet<string>();
        foreach (string raw in File.ReadLines(path))
        {
            string line = raw.Trim();
            if (line.Length == 0 || line.StartsWith('#')) continue;
            int index = line.IndexOf('=');
            if (index < 0) throw new InvalidDataException("Invalid credentials file.");
            string key = line[..index].Trim(), value = line[(index+1)..].Trim();
            if (key is not ("LB_EMAIL" or "LB_PASSWORD") || !found.Add(key)) throw new InvalidDataException("Invalid or duplicate credential setting.");
            if (value.StartsWith('"') || value.StartsWith('\''))
            {
                if (value.Length < 2 || value[^1] != value[0]) throw new InvalidDataException("Unclosed credential quote.");
                value = value[1..^1];
            }
            if (Environment.GetEnvironmentVariable(key) == null) Environment.SetEnvironmentVariable(key, value);
        }
    }
}
