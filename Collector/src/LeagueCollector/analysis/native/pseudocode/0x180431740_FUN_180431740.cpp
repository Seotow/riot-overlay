// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431740; descriptive alias: FUN_180431740
// Evidence: ev_3529d200e119d4619094a186b0ead6825f0a76a8d75cca2a9529adce1f330b59
// Original Evidence: rea-collector/0x180431740.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180431740(longlong param_1)

{
  int iVar1;
  uint uVar2;
  
  if (DAT_180d31b28 == '\0') {
    uVar2 = DAT_180d316c0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d316c0);
  }
  if (DAT_180d257c8 == '\0') {
    return *(undefined4 *)((ulonglong)((DAT_180d25360 + 0xe6632e3aU ^ 0x11bf48c) + uVar2) + param_1)
    ;
  }
  iVar1 = FUN_18052b510(&DAT_180d25360);
  return *(undefined4 *)((ulonglong)(iVar1 + uVar2) + param_1);
}

