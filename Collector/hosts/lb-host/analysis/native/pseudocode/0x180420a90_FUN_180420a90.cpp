// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420a90; descriptive alias: FUN_180420a90
// Evidence: ev_c63f25e02615831413a4cf9de295654fc2bc31d7545ad76db74d6476a4cf7bab
// Original Evidence: rea-collector/0x180420a90.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180420a90(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5da20 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d5d5b8 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5d5b8);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

