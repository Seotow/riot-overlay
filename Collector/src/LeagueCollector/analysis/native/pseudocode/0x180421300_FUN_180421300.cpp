// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421300; descriptive alias: FUN_180421300
// Evidence: ev_72e4548f9f7676606830586ce7417ef2814167377ac4e9c49c84482066a1a787
// Original Evidence: rea-collector/0x180421300.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180421300(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5a4d0 == '\0') {
    return *(undefined8 *)((ulonglong)(DAT_180d5a068 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5a068);
  return *(undefined8 *)((ulonglong)uVar1 + param_1);
}

