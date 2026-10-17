using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ScriptClassRegex_0 : Regex
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
				if (num <= inputSpan.Length - 12)
				{
					int num2 = inputSpan.Slice(num).IndexOfAny(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_indexOfString_class_Ordinal);
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
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				if (!_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsPreWordCharBoundary(inputSpan, num))
				{
					return false;
				}
				if (!span.StartsWith("class"))
				{
					return false;
				}
				num += 5;
				span = inputSpan.Slice(num);
				int i;
				for (i = 0; (uint)i < (uint)span.Length && char.IsWhiteSpace(span[i]); i++)
				{
				}
				if (i == 0)
				{
					return false;
				}
				span = span.Slice(i);
				num += i;
				if (!span.StartsWith("Script"))
				{
					return false;
				}
				if (!_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsPostWordCharBoundary(inputSpan, num + 6))
				{
					return false;
				}
				Capture(0, start, runtextpos = num + 6);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ScriptClassRegex_0 Instance = new _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ScriptClassRegex_0();

	private _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ScriptClassRegex_0()
	{
		pattern = "\\bclass\\s+Script\\b";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 1;
	}
}
