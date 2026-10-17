using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ArrayTypeRegex_2 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				if (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan))
				{
					runtextpos = inputSpan.Length;
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 8 && num == 0)
				{
					return true;
				}
				runtextpos = inputSpan.Length;
				return false;
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				int num2 = 0;
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				if (num != 0)
				{
					UncaptureUntil(0);
					return false;
				}
				if (!span.StartsWith("array"))
				{
					UncaptureUntil(0);
					return false;
				}
				int i;
				for (i = 5; (uint)i < (uint)span.Length && char.IsWhiteSpace(span[i]); i++)
				{
				}
				span = span.Slice(i);
				num += i;
				if (span.IsEmpty || span[0] != '<')
				{
					UncaptureUntil(0);
					return false;
				}
				int j;
				for (j = 1; (uint)j < (uint)span.Length && char.IsWhiteSpace(span[j]); j++)
				{
				}
				span = span.Slice(j);
				num += j;
				num2 = num;
				ulong num3;
				if (span.IsEmpty || (long)((ulong)(-261993005120L << (int)(num3 = (uint)(span[0] - 65))) & (num3 - 64)) >= 0L)
				{
					UncaptureUntil(0);
					return false;
				}
				int k;
				for (k = 1; (uint)k < (uint)span.Length && _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsWordChar(span[k]); k++)
				{
				}
				span = span.Slice(k);
				num += k;
				Capture(1, num2, num);
				int l;
				for (l = 0; (uint)l < (uint)span.Length && char.IsWhiteSpace(span[l]); l++)
				{
				}
				span = span.Slice(l);
				num += l;
				if (span.IsEmpty || span[0] != '>')
				{
					UncaptureUntil(0);
					return false;
				}
				if (2 < span.Length || (1 < span.Length && span[1] != '\n'))
				{
					UncaptureUntil(0);
					return false;
				}
				Capture(0, start, runtextpos = num + 1);
				return true;
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				void UncaptureUntil(int capturePosition)
				{
					while (Crawlpos() > capturePosition)
					{
						Uncapture();
					}
				}
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ArrayTypeRegex_2 Instance = new _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ArrayTypeRegex_2();

	private _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ArrayTypeRegex_2()
	{
		pattern = "^array\\s*<\\s*([A-Za-z_]\\w*)\\s*>$";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 2;
	}
}
