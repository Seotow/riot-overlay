// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180430940; descriptive alias: FUN_180430940
// Evidence: ev_ce9e639ebe5ed4b783f6610702b00b23223d2334baddb16eb91b2d54f133b142
// Original Evidence: rea-collector/0x180430940.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180430940(undefined8 *param_1)

{
  int iVar1;
  ulonglong uVar2;
  longlong *plVar3;
  
  if (DAT_180d2bdf8 == '\0') {
    uVar2 = DAT_180d2b990 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar2 = FUN_18052c740(&DAT_180d2b990,0);
  }
  if (uVar2 == 0) {
    plVar3 = (longlong *)0x0;
  }
  else {
    plVar3 = (longlong *)(DAT_180d20bd0 + uVar2);
  }
  iVar1 = *(int *)(*plVar3 + 0x10);
  *param_1 = *(undefined8 *)(*plVar3 + 8);
  param_1[1] = (longlong)iVar1;
  return param_1;
}

