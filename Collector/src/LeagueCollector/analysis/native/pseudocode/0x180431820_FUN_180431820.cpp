// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431820; descriptive alias: FUN_180431820
// Evidence: ev_357da0f7b2e33bae63d625400e8c890ae891653bfa800757e365662cecb72cb3
// Original Evidence: rea-collector/0x180431820.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180431820(longlong param_1)

{
  int iVar1;
  uint uVar2;
  
  if (DAT_180d30088 == '\0') {
    uVar2 = DAT_180d2fc20 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d2fc20);
  }
  if (DAT_180d257c8 == '\0') {
    return *(undefined4 *)((ulonglong)((DAT_180d25360 + 0xe6632e3aU ^ 0x11bf48c) + uVar2) + param_1)
    ;
  }
  iVar1 = FUN_18052b510(&DAT_180d25360);
  return *(undefined4 *)((ulonglong)(iVar1 + uVar2) + param_1);
}

