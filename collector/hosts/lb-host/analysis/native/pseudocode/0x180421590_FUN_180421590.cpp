// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421590; descriptive alias: FUN_180421590
// Evidence: ev_fe8fe8bc941f6a961d6c7a24d5033b638a05a2196a30c1a5ef49a19b72950c1f
// Original Evidence: rea-collector/0x180421590.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180421590(longlong param_1)

{
  longlong lVar1;
  
  if (DAT_180d28898 == '\0') {
    return *(undefined8 *)((DAT_180d28430 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c) + param_1);
  }
  lVar1 = FUN_18052c740(&DAT_180d28430,0);
  return *(undefined8 *)(lVar1 + param_1);
}

