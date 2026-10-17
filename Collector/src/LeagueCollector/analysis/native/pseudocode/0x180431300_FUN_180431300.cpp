// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431300; descriptive alias: FUN_180431300
// Evidence: ev_eb403bd7888d72e864023dc7dbcd133dae7910a9bd7d76e8283b855432963dbf
// Original Evidence: rea-collector/0x180431300.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180431300(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d32ce8 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d32880 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d32880);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

