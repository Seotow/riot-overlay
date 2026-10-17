using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__EnumRegex_3 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				while (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan) && runtextpos != inputSpan.Length)
				{
					runtextpos++;
					if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
				}
			}

			private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				if (num <= inputSpan.Length - 8)
				{
					int num2 = inputSpan.Slice(num).IndexOfAny(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_indexOfString_enum_Ordinal);
					if (num2 >= 0)
					{
						runtextpos = num + num2;
						return true;
					}
				}
				runtextpos = inputSpan.Length;
				return false;
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				if (!_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsPreWordCharBoundary(inputSpan, num))
				{
					UncaptureUntil(0);
					return false;
				}
				if (!span.StartsWith("enum"))
				{
					UncaptureUntil(0);
					return false;
				}
				num += 4;
				span = inputSpan.Slice(num);
				int i;
				for (i = 0; (uint)i < (uint)span.Length && char.IsWhiteSpace(span[i]); i++)
				{
				}
				if (i == 0)
				{
					UncaptureUntil(0);
					return false;
				}
				span = span.Slice(i);
				num += i;
				num2 = num;
				ulong num6;
				if (span.IsEmpty || (long)((ulong)(-261993005120L << (int)(num6 = (uint)(span[0] - 65))) & (num6 - 64)) >= 0L)
				{
					UncaptureUntil(0);
					return false;
				}
				int j;
				for (j = 1; (uint)j < (uint)span.Length && _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsWordChar(span[j]); j++)
				{
				}
				span = span.Slice(j);
				num += j;
				Capture(1, num2, num);
				int k;
				for (k = 0; (uint)k < (uint)span.Length && char.IsWhiteSpace(span[k]); k++)
				{
				}
				span = span.Slice(k);
				num += k;
				if (span.IsEmpty || span[0] != '{')
				{
					UncaptureUntil(0);
					return false;
				}
				num++;
				span = inputSpan.Slice(num);
				num3 = num;
				num5 = num;
				while (true)
				{
					num4 = Crawlpos();
					Capture(2, num3, num);
					if (!span.IsEmpty && span[0] == '}')
					{
						break;
					}
					UncaptureUntil(num4);
					if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					num = num5;
					span = inputSpan.Slice(num);
					if (span.IsEmpty)
					{
						UncaptureUntil(0);
						return false;
					}
					num++;
					span = inputSpan.Slice(num);
					num5 = span.IndexOf('}');
					if (num5 < 0)
					{
						UncaptureUntil(0);
						return false;
					}
					num += num5;
					span = inputSpan.Slice(num);
					num5 = num;
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

	internal static readonly _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__EnumRegex_3 Instance = new _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__EnumRegex_3();

	private _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__EnumRegex_3()
	{
		pattern = "\\benum\\s+([A-Za-z_]\\w*)\\s*\\{(.*?)\\}";
		roptions = RegexOptions.Singleline;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 3;
	}
}
