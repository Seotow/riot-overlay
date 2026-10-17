using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Farsight.BBObject;

public record ChampionAssets
{
	private string Identifier__BackingField;
	private int Id__BackingField;
	private string? LoadingImage__BackingField;
	private string? SplashImage__BackingField;
	private string? SplashCenteredImage__BackingField;
	private string? SquareImage__BackingField;
	private string? TileImage__BackingField;
	public required string Identifier
	{
		[CompilerGenerated]
		get
		{
			return Identifier__BackingField;
		}
		[CompilerGenerated]
		set
		{
			Identifier__BackingField = value;
		}
	}

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return Id__BackingField;
		}
		[CompilerGenerated]
		set
		{
			Id__BackingField = value;
		}
	}

	public string? LoadingImage
	{
		[CompilerGenerated]
		get
		{
			return LoadingImage__BackingField;
		}
		[CompilerGenerated]
		set
		{
			LoadingImage__BackingField = value;
		}
	}

	public string? SplashImage
	{
		[CompilerGenerated]
		get
		{
			return SplashImage__BackingField;
		}
		[CompilerGenerated]
		set
		{
			SplashImage__BackingField = value;
		}
	}

	public string? SplashCenteredImage
	{
		[CompilerGenerated]
		get
		{
			return SplashCenteredImage__BackingField;
		}
		[CompilerGenerated]
		set
		{
			SplashCenteredImage__BackingField = value;
		}
	}

	public string? SquareImage
	{
		[CompilerGenerated]
		get
		{
			return SquareImage__BackingField;
		}
		[CompilerGenerated]
		set
		{
			SquareImage__BackingField = value;
		}
	}

	public string? TileImage
	{
		[CompilerGenerated]
		get
		{
			return TileImage__BackingField;
		}
		[CompilerGenerated]
		set
		{
			TileImage__BackingField = value;
		}
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	protected ChampionAssets(ChampionAssets original)
	{
		Identifier__BackingField = original.Identifier__BackingField;
		Id__BackingField = original.Id__BackingField;
		LoadingImage__BackingField = original.LoadingImage__BackingField;
		SplashImage__BackingField = original.SplashImage__BackingField;
		SplashCenteredImage__BackingField = original.SplashCenteredImage__BackingField;
		SquareImage__BackingField = original.SquareImage__BackingField;
		TileImage__BackingField = original.TileImage__BackingField;
	}
}
