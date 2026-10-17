// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420ae0; descriptive alias: FUN_180420ae0
// Evidence: ev_bdd4145a7040c03c51b7fa779fc512e2750358876354d6770f374cfd4b614df2
// Original Evidence: rea-collector/0x180420ae0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180420ae0(longlong param_1,undefined1 param_2)

{
  uint uVar1;
  
  if (DAT_180d5de90 == '\0') {
    *(undefined1 *)((ulonglong)(DAT_180d5da28 + 0xe6632e3aU ^ 0x11bf48c) + param_1) = param_2;
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d5da28);
  *(undefined1 *)((ulonglong)uVar1 + param_1) = param_2;
  return;
}

