// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431490; descriptive alias: FUN_180431490
// Evidence: ev_2db4822ee0c59e9b190d4686e26b9fe2ecfde6bb4433b6a80aa970fab70dc483
// Original Evidence: rea-collector/0x180431490.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_180431490(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d2dd08 == '\0') {
    return *(undefined1 *)((ulonglong)(DAT_180d2d8a0 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d2d8a0);
  return *(undefined1 *)((ulonglong)uVar1 + param_1);
}

