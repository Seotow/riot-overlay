// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421cb0; descriptive alias: FUN_180421cb0
// Evidence: ev_1642c3c05db02024ea67888ba384db8cbfb2feb2edd9f89c2795d06aa7209a89
// Original Evidence: rea-collector/0x180421cb0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_180421cb0(longlong param_1)

{
  longlong lVar1;
  
  if (DAT_180d29ed0 == '\0') {
    return *(undefined1 *)((DAT_180d29a68 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c) + param_1);
  }
  lVar1 = FUN_18052c740(&DAT_180d29a68,0);
  return *(undefined1 *)(lVar1 + param_1);
}

