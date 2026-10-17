// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804209a0; descriptive alias: FUN_1804209a0
// Evidence: ev_f97ad3211b26464c1054b0f201b10bebfa0a54dbcd3bf11c7409ff0be3436b0a
// Original Evidence: rea-collector/0x1804209a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_1804209a0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5ccd0 == '\0') {
    return *(undefined1 *)((ulonglong)(DAT_180d5c868 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5c868);
  return *(undefined1 *)((ulonglong)uVar1 + param_1);
}

