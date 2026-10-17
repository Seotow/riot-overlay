// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432200; descriptive alias: FUN_180432200
// Evidence: ev_49efc62e2cafc41f954c4adaf4fb00264ab391fbfd135f83bb421156516167dd
// Original Evidence: rea-collector/0x180432200.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180432200(longlong param_1)

{
  code *UNRECOVERED_JUMPTABLE;
  uint uVar1;
  undefined8 uVar2;
  
  if (DAT_180d36698 == '\0') {
    uVar1 = DAT_180d36230 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d36230);
  }
  if (uVar1 != 0) {
    if ((*(longlong *)((ulonglong)uVar1 + param_1) != 0) &&
       (UNRECOVERED_JUMPTABLE = *(code **)(*(longlong *)((ulonglong)uVar1 + param_1) + 0x10),
       UNRECOVERED_JUMPTABLE != (code *)0x0)) {
                    /* WARNING: Could not recover jumptable at 0x00018043224f. Too many branches */
                    /* WARNING: Treating indirect jump as call */
      uVar2 = (*UNRECOVERED_JUMPTABLE)();
      return uVar2;
    }
  }
  return 0;
}

