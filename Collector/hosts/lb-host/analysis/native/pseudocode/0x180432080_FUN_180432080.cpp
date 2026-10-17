// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432080; descriptive alias: FUN_180432080
// Evidence: ev_83a6210cb0ead5fafdb21bed7be827e80ec998226b5b4c4237fe7c0c5e977873
// Original Evidence: rea-collector/0x180432080.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

uint FUN_180432080(longlong param_1)

{
  uint uVar1;
  uint uVar2;
  
  if (DAT_180d30dd8 == '\0') {
    uVar2 = DAT_180d30970 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d30970);
  }
  if (DAT_180d31248 == '\0') {
    uVar1 = DAT_180d30de0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d30de0);
  }
  uVar2 = *(uint *)((ulonglong)(uVar1 + uVar2) + param_1);
  if (0xff < uVar2) {
    uVar2 = 0xff;
  }
  return uVar2;
}

