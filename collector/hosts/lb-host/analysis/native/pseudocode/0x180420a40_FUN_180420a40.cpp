// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420a40; descriptive alias: FUN_180420a40
// Evidence: ev_4ddf79670f40a4cc433173df8131df26f1fae2d86f6a2adb43e1e4b40edd3220
// Original Evidence: rea-collector/0x180420a40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180420a40(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5d5b0 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d5d148 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5d148);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

