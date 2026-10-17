using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Common.ColorRGBA")]
public class ColorRGBA
{
	[FlatBufferItem(0)]
	public virtual byte R { get; set; }

	[FlatBufferItem(1)]
	public virtual byte G { get; set; }

	[FlatBufferItem(2)]
	public virtual byte B { get; set; }

	[FlatBufferItem(3)]
	public virtual byte A { get; set; }

	public override string ToString()
	{
		return $"#{R:X2}{G:X2}{B:X2}{A:X2}";
	}

	public static ColorRGBA FromHex(string hex)
	{
		if (hex.StartsWith('#'))
		{
			hex = hex.Substring(1);
		}
		if (hex.Length != 8)
		{
			throw new ArgumentException("Hex string must be 8 characters long (RRGGBBAA).");
		}
		byte r = Convert.ToByte(hex.Substring(0, 2), 16);
		byte g = Convert.ToByte(hex.Substring(2, 2), 16);
		byte b = Convert.ToByte(hex.Substring(4, 2), 16);
		byte a = Convert.ToByte(hex.Substring(6, 2), 16);
		return new ColorRGBA
		{
			R = r,
			G = g,
			B = b,
			A = a
		};
	}

	public static implicit operator ColorRGBA(string hex)
	{
		return FromHex(hex);
	}

	public static implicit operator string(ColorRGBA color)
	{
		return color.ToString();
	}

	public static implicit operator Color(ColorRGBA color)
	{
		return Color.FromArgb(color.A, color.R, color.G, color.B);
	}

	public static implicit operator ColorRGBA(Color color)
	{
		return new ColorRGBA
		{
			R = color.R,
			G = color.G,
			B = color.B,
			A = color.A
		};
	}

	static ColorRGBA()
	{
	}

	public ColorRGBA()
	{
	}

	protected ColorRGBA(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ColorRGBA(ColorRGBA source)
	{
		R = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.R);
		G = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.G);
		B = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.B);
		A = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.A);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
