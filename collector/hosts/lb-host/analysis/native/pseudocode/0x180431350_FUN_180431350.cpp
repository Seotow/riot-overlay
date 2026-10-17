// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431350; descriptive alias: FUN_180431350
// Evidence: ev_8c9716b2518b308cc54b46c39be1fd812f1de8c68a458963963ff24ffd8a2375
// Original Evidence: rea-collector/0x180431350.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180431350(longlong param_1)

{
  int iVar1;
  
  if (DAT_180d32ce8 == '\0') {
    return *(undefined4 *)((ulonglong)((DAT_180d32880 + 0xe6632e3aU ^ 0x11bf48c) + 8) + param_1);
  }
  iVar1 = FUN_18052b510(&DAT_180d32880);
  return *(undefined4 *)((ulonglong)(iVar1 + 8) + param_1);
}

