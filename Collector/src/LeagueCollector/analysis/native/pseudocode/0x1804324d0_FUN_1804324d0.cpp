// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804324d0; descriptive alias: FUN_1804324d0
// Evidence: ev_80384e4d2a4fa9ae432c4994cd2aaa3665480976cdba0a76a2005f1b576c9def
// Original Evidence: rea-collector/0x1804324d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_1804324d0(void)

{
  longlong lVar1;
  longlong lVar2;
  
  lVar1 = FUN_180431510();
  if (DAT_180d21528 - DAT_180d21520 >> 3 != 0) {
    lVar2 = thunk_FUN_1809700d0(DAT_180d21520,DAT_180d21528,lVar1);
    if (lVar2 == DAT_180d21528) {
      lVar1 = 0;
    }
  }
  return CONCAT71(0xe26030,lVar1 == 0xe260302c);
}

