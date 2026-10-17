// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431510; descriptive alias: FUN_180431510
// Evidence: ev_6bfbb1c8a990a3a7dbf09a2ceec87b40284b2bb45ddc80c8027f5333424fc328
// Original Evidence: rea-collector/0x180431510.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180431510(undefined8 param_1)

{
  char cVar1;
  longlong lVar2;
  
  cVar1 = FUN_1801fa260();
  if (cVar1 == '\0') {
    FUN_180432a60();
  }
  else {
    cVar1 = FUN_1801fa260();
    if (cVar1 == '\0') {
      FUN_180432e10();
      return 0;
    }
    lVar2 = FUN_1804314e0(param_1);
    cVar1 = FUN_1801fa260(lVar2);
    if (cVar1 != '\0') {
      cVar1 = FUN_1801fa260((undefined8 *)(lVar2 + 8));
      if (cVar1 == '\0') {
        FUN_1804331d0();
        return 0;
      }
      return *(undefined8 *)(lVar2 + 8);
    }
  }
  return 0;
}

