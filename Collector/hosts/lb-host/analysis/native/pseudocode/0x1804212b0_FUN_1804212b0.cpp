// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804212b0; descriptive alias: FUN_1804212b0
// Evidence: ev_9b761b5eec3007935b34dc243257249487b0e73df86fc930d7ea893da070fc71
// Original Evidence: rea-collector/0x1804212b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_1804212b0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d59bf0 == '\0') {
    return *(undefined8 *)((ulonglong)(DAT_180d59788 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d59788);
  return *(undefined8 *)((ulonglong)uVar1 + param_1);
}

