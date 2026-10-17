namespace Farsight.BBObject;

public record PlayerData
{
	public string? Alias { get; set; }

	public string? Name { get; set; }

	public string? Surname { get; set; }

	public ChampionAssets? ChampionAssets { get; set; }

	public string? Image { get; set; }
}
