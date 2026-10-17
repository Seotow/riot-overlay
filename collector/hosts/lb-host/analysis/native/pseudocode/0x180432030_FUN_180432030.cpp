// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432030; descriptive alias: FUN_180432030
// Evidence: ev_8e8ed59cc9ac00963f6a4b13101f193bdd6ef45029ca326bb294baedc8447d3f
// Original Evidence: rea-collector/0x180432030.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180432030(void)

{
  undefined8 uVar1;
  longlong lVar2;
  
  uVar1 = FUN_180431510();
  if (DAT_180d21528 - DAT_180d21520 >> 3 != 0) {
    lVar2 = thunk_FUN_1809700d0(DAT_180d21520,DAT_180d21528,uVar1);
    if (lVar2 == DAT_180d21528) {
      uVar1 = 0;
    }
  }
  return uVar1;
}

