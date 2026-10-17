using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
[SkipLocalsInit]
internal sealed class _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__FieldRegex_1 : Regex
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
				if (num <= inputSpan.Length - 4 && num == 0)
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
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				int num13 = 0;
				int num14 = 0;
				int num15 = 0;
				int num16 = 0;
				int arg = 0;
				int arg2 = 0;
				int num17 = 0;
				int num18 = 0;
				int arg3 = 0;
				int arg4 = 0;
				int arg5 = 0;
				int arg6 = 0;
				int num19 = 0;
				int num20 = 0;
				int num21 = 0;
				int pos = 0;
				ReadOnlySpan<char> span = inputSpan.Slice(num);
				if (num != 0)
				{
					UncaptureUntil(0);
					return false;
				}
				num11 = num;
				int i;
				for (i = 0; (uint)i < (uint)span.Length && char.IsWhiteSpace(span[i]); i++)
				{
				}
				span = span.Slice(i);
				num += i;
				num12 = num;
				while (true)
				{
					num7 = Crawlpos();
					num19 = 0;
					while (true)
					{
						_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
						num19++;
						int num22 = num;
						int arg7;
						int arg8;
						if (!span.IsEmpty && span[0] == 'p')
						{
							arg7 = num;
							arg8 = Crawlpos();
							if (!span.Slice(1).StartsWith("ublic"))
							{
								goto IL_0170;
							}
							_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, 0, arg7, arg8);
							num += 6;
							span = inputSpan.Slice(num);
							goto IL_0270;
						}
						goto IL_02e1;
						IL_0170:
						num = arg7;
						span = inputSpan.Slice(num);
						UncaptureUntil(arg8);
						if ((uint)span.Length >= 2u && span[1] == 'r' && (uint)span.Length >= 3u)
						{
							char c = span[2];
							if (c != 'i')
							{
								if (c == 'o' && span.Slice(3).StartsWith("tected"))
								{
									num += 9;
									span = inputSpan.Slice(num);
									goto IL_0222;
								}
							}
							else if (span.Slice(3).StartsWith("vate"))
							{
								num += 7;
								span = inputSpan.Slice(num);
								goto IL_0222;
							}
						}
						goto IL_02e1;
						IL_028b:
						num22 = runstack[--pos];
						if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
						{
							CheckTimeout();
						}
						_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPop(runstack, ref pos, out arg8, out arg7);
						int num23 = runstack[--pos];
						if (num23 == 0)
						{
							goto IL_0170;
						}
						if (num23 != 1)
						{
							goto IL_0270;
						}
						goto IL_02e1;
						IL_0270:
						Capture(1, num22, num);
						_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, num22);
						int j;
						for (j = 0; (uint)j < (uint)span.Length && char.IsWhiteSpace(span[j]); j++)
						{
						}
						if (j == 0)
						{
							goto IL_028b;
						}
						span = span.Slice(j);
						num += j;
						if (num19 == 0)
						{
							continue;
						}
						goto IL_0336;
						IL_02e1:
						if (--num19 < 0)
						{
							break;
						}
						num = runstack[--pos];
						UncaptureUntil(runstack[--pos]);
						span = inputSpan.Slice(num);
						goto IL_0336;
						IL_0555:
						ulong num24;
						while (true)
						{
							Capture(2, num5, num);
							int k;
							for (k = 0; (uint)k < (uint)span.Length && char.IsWhiteSpace(span[k]); k++)
							{
							}
							if (k != 0)
							{
								span = span.Slice(k);
								num += k;
								num6 = num;
								if (!span.IsEmpty && (long)((ulong)(-261993005120L << (int)(num24 = (uint)(span[0] - 65))) & (num24 - 64)) < 0L)
								{
									num++;
									span = inputSpan.Slice(num);
									num13 = num;
									int l;
									for (l = 0; (uint)l < (uint)span.Length && _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsWordChar(span[l]); l++)
									{
									}
									span = span.Slice(l);
									num += l;
									num14 = num;
									while (true)
									{
										num8 = Crawlpos();
										Capture(3, num6, num);
										num15 = num;
										int m;
										for (m = 0; (uint)m < (uint)span.Length && char.IsWhiteSpace(span[m]); m++)
										{
										}
										span = span.Slice(m);
										num += m;
										num16 = num;
										while (true)
										{
											num9 = Crawlpos();
											num20 = 0;
											while (true)
											{
												_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
												num20++;
												if (!span.IsEmpty && span[0] == '=')
												{
													num++;
													span = inputSpan.Slice(num);
													arg = num;
													int n;
													for (n = 0; (uint)n < (uint)span.Length && char.IsWhiteSpace(span[n]); n++)
													{
													}
													span = span.Slice(n);
													num += n;
													arg2 = num;
													goto IL_07ab;
												}
												goto IL_087d;
												IL_087d:
												if (--num20 < 0)
												{
													break;
												}
												num = runstack[--pos];
												UncaptureUntil(runstack[--pos]);
												span = inputSpan.Slice(num);
												goto IL_08cf;
												IL_07ab:
												_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, arg, arg2, Crawlpos());
												int num25 = num;
												arg6 = num;
												goto IL_0819;
												IL_08cf:
												int num26;
												for (num26 = 0; (uint)num26 < (uint)span.Length && char.IsWhiteSpace(span[num26]); num26++)
												{
												}
												span = span.Slice(num26);
												num += num26;
												if (!span.IsEmpty && span[0] == ';')
												{
													num++;
													span = inputSpan.Slice(num);
													num17 = num;
													int num27;
													for (num27 = 0; (uint)num27 < (uint)span.Length && char.IsWhiteSpace(span[num27]); num27++)
													{
													}
													span = span.Slice(num27);
													num += num27;
													num18 = num;
													while (true)
													{
														num10 = Crawlpos();
														num21 = 0;
														while (true)
														{
															_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
															num21++;
															if (span.StartsWith("//"))
															{
																num += 2;
																span = inputSpan.Slice(num);
																arg3 = num;
																int num28 = span.IndexOf('\n');
																if (num28 < 0)
																{
																	num28 = span.Length;
																}
																span = span.Slice(num28);
																num += num28;
																arg4 = num;
																goto IL_0a5d;
															}
															goto IL_0a7d;
															IL_0a7d:
															if (--num21 < 0)
															{
																break;
															}
															num = runstack[--pos];
															UncaptureUntil(runstack[--pos]);
															span = inputSpan.Slice(num);
															goto IL_0ad2;
															IL_0ad2:
															if (num < inputSpan.Length - 1 || ((uint)num < (uint)inputSpan.Length && inputSpan[num] != '\n'))
															{
																if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
																{
																	CheckTimeout();
																}
																if (num21 != 0)
																{
																	UncaptureUntil(runstack[--pos]);
																	_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPop(runstack, ref pos, out arg4, out arg3);
																	if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
																	{
																		CheckTimeout();
																	}
																	if (arg3 < arg4)
																	{
																		num = --arg4;
																		span = inputSpan.Slice(num);
																		goto IL_0a5d;
																	}
																	goto IL_0a7d;
																}
																break;
															}
															runtextpos = num;
															Capture(0, start, num);
															return true;
															IL_0a5d:
															_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, arg3, arg4, Crawlpos());
															if (num21 == 0)
															{
																continue;
															}
															goto IL_0ad2;
														}
														UncaptureUntil(num10);
														if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
														{
															CheckTimeout();
														}
														if (num17 >= num18)
														{
															break;
														}
														num = --num18;
														span = inputSpan.Slice(num);
													}
												}
												if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
												{
													CheckTimeout();
												}
												if (num20 != 0)
												{
													num25 = runstack[--pos];
													_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPop(runstack, ref pos, out arg5, out arg6);
													UncaptureUntil(arg5);
													if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
													{
														CheckTimeout();
													}
													num = arg6;
													span = inputSpan.Slice(num);
													if (span.IsEmpty || span[0] == '\n')
													{
														UncaptureUntil(runstack[--pos]);
														_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPop(runstack, ref pos, out arg2, out arg);
														if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
														{
															CheckTimeout();
														}
														if (arg < arg2)
														{
															num = --arg2;
															span = inputSpan.Slice(num);
															goto IL_07ab;
														}
														goto IL_087d;
													}
													num++;
													span = inputSpan.Slice(num);
													arg6 = num;
													goto IL_0819;
												}
												break;
												IL_0819:
												arg5 = Crawlpos();
												_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, arg6, arg5);
												Capture(4, num25, num);
												_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, num25);
												if (num20 == 0)
												{
													continue;
												}
												goto IL_08cf;
											}
											UncaptureUntil(num9);
											if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
											{
												CheckTimeout();
											}
											if (num15 >= num16)
											{
												break;
											}
											num = --num16;
											span = inputSpan.Slice(num);
										}
										UncaptureUntil(num8);
										if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
										{
											CheckTimeout();
										}
										if (num13 >= num14)
										{
											break;
										}
										num = --num14;
										span = inputSpan.Slice(num);
									}
								}
							}
							if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
							{
								CheckTimeout();
							}
							if (num2 == 0)
							{
								break;
							}
							if (num2 != 1)
							{
								continue;
							}
							goto IL_031d;
						}
						goto IL_04b4;
						IL_0336:
						num5 = num;
						num4 = num;
						num3 = Crawlpos();
						if (span.StartsWith("array"))
						{
							int num29;
							for (num29 = 5; (uint)num29 < (uint)span.Length && char.IsWhiteSpace(span[num29]); num29++)
							{
							}
							span = span.Slice(num29);
							num += num29;
							if (!span.IsEmpty && span[0] == '<')
							{
								int num30;
								for (num30 = 1; (uint)num30 < (uint)span.Length && char.IsWhiteSpace(span[num30]); num30++)
								{
								}
								span = span.Slice(num30);
								num += num30;
								if (!span.IsEmpty && (long)((ulong)(-261993005120L << (int)(num24 = (uint)(span[0] - 65))) & (num24 - 64)) < 0L)
								{
									int num31;
									for (num31 = 1; (uint)num31 < (uint)span.Length && _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsWordChar(span[num31]); num31++)
									{
									}
									span = span.Slice(num31);
									num += num31;
									int num32;
									for (num32 = 0; (uint)num32 < (uint)span.Length && char.IsWhiteSpace(span[num32]); num32++)
									{
									}
									span = span.Slice(num32);
									num += num32;
									if (!span.IsEmpty && span[0] == '>')
									{
										num2 = 0;
										num++;
										span = inputSpan.Slice(num);
										goto IL_0555;
									}
								}
							}
						}
						goto IL_04b4;
						IL_031d:
						if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
						{
							CheckTimeout();
						}
						if (num19 == 0)
						{
							break;
						}
						goto IL_028b;
						IL_04b4:
						num = num4;
						span = inputSpan.Slice(num);
						UncaptureUntil(num3);
						if (span.IsEmpty || (long)((ulong)(-261993005120L << (int)(num24 = (uint)(span[0] - 65))) & (num24 - 64)) >= 0L)
						{
							goto IL_031d;
						}
						int num33;
						for (num33 = 1; (uint)num33 < (uint)span.Length && _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.IsWordChar(span[num33]); num33++)
						{
						}
						span = span.Slice(num33);
						num += num33;
						num2 = 1;
						goto IL_0555;
						IL_0222:
						_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.StackPush(ref runstack, ref pos, 1, arg7, arg8);
						goto IL_0270;
					}
					UncaptureUntil(num7);
					if (_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					if (num11 >= num12)
					{
						break;
					}
					num = --num12;
					span = inputSpan.Slice(num);
				}
				UncaptureUntil(0);
				return false;
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

	internal static readonly _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__FieldRegex_1 Instance = new _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__FieldRegex_1();

	private _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__FieldRegex_1()
	{
		pattern = "^\\s*(?:(public|private|protected)\\s+)?(array\\s*<\\s*[A-Za-z_]\\w*\\s*>|[A-Za-z_]\\w*)\\s+([A-Za-z_]\\w*)\\s*(?:=\\s*(.*?))?\\s*;\\s*(?://.*)?$";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 5;
	}
}
