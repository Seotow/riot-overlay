// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420820; descriptive alias: FUN_180420820
// Evidence: ev_03e2fc42a1d8d6bda784cbb85a692eedff72bd7975e15f54a830c2ff9390ed27
// Original Evidence: rea-collector/0x180420820.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180420820(longlong param_1)

{
  longlong lVar1;
  char cVar2;
  longlong *plVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  int *piVar6;
  
  plVar3 = (longlong *)(((ulonglong)(DAT_180d46528 + 0xe6632e3a) ^ 0x11bf48c) + param_1);
  cVar2 = FUN_1801fa260(plVar3);
  if (cVar2 != '\0') {
    lVar1 = *plVar3;
    cVar2 = FUN_1801fa260(lVar1);
    if (cVar2 != '\0') {
      piVar6 = (int *)(((ulonglong)(DAT_180d4652c + 0xe6632e3a) ^ 0x11bf48c) + lVar1);
      cVar2 = FUN_1801fa260(piVar6);
      if ((cVar2 != '\0') && (*piVar6 != 0)) {
        puVar4 = (undefined8 *)(lVar1 + ((ulonglong)(DAT_180d46530 + 0xe6632e3a) ^ 0x11bf48c));
        cVar2 = FUN_1801fa260(puVar4);
        if (cVar2 != '\0') {
          puVar4 = (undefined8 *)*puVar4;
          cVar2 = FUN_1801fa260(puVar4);
          if (cVar2 != '\0') {
            uVar5 = *puVar4;
            cVar2 = FUN_1801fa260(uVar5);
            if (cVar2 == '\0') {
              uVar5 = 0;
            }
            return uVar5;
          }
        }
      }
    }
  }
  return 0;
}

