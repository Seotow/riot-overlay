// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d260; descriptive alias: FUN_18042d260
// Evidence: ev_87e5be46fe6bb830b2e3fe1788bed7d90e6b88b0e25134df7921a28a56d408d3
// Original Evidence: rea-collector/0x18042d260.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042d260(longlong param_1,ulonglong param_2)

{
  uint uVar1;
  uint uVar2;
  longlong *plVar3;
  ulonglong uVar4;
  ulonglong uVar5;
  longlong *plVar6;
  longlong *plVar7;
  longlong *plVar8;
  undefined8 *puVar9;
  undefined8 *puVar10;
  longlong *plVar11;
  ulonglong uVar12;
  longlong lVar13;
  ulonglong uVar14;
  
  for (uVar12 = 0x3f; 0xfffffffffffffffU >> uVar12 == 0; uVar12 = uVar12 - 1) {
  }
  if ((ulonglong)(1L << (uVar12 & 0x3f)) < param_2) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("invalid hash bucket count");
  }
  plVar3 = *(longlong **)(param_1 + 8);
  uVar12 = param_2 - 1 | 1;
  lVar13 = 0x3f;
  if (uVar12 != 0) {
    for (; uVar12 >> lVar13 == 0; lVar13 = lVar13 + -1) {
    }
  }
  uVar12 = (ulonglong)((int)lVar13 + 1);
  lVar13 = 1L << (uVar12 & 0x3f);
  FUN_1801b0350(param_1 + 0x18,2L << (uVar12 & 0x3f),plVar3);
  *(longlong *)(param_1 + 0x38) = lVar13;
  *(longlong *)(param_1 + 0x30) = lVar13 + -1;
  plVar11 = (longlong *)**(undefined8 **)(param_1 + 8);
joined_r0x00018042d2e1:
  do {
    while( true ) {
      while( true ) {
        if (plVar11 == plVar3) {
          return;
        }
        uVar12 = plVar11[3];
        uVar4 = plVar11[2];
        uVar1 = *(uint *)(plVar11 + 5);
        uVar5 = plVar11[4];
        uVar2 = *(uint *)((longlong)plVar11 + 0x2c);
        lVar13 = *(longlong *)(param_1 + 0x18);
        plVar6 = (longlong *)*plVar11;
        uVar14 = (((uVar12 ^ uVar4) >> 1 ^ uVar5) >> 3 ^ (ulonglong)uVar1 * 2 ^ (ulonglong)uVar2) &
                 *(ulonglong *)(param_1 + 0x30);
        plVar7 = *(longlong **)(lVar13 + uVar14 * 0x10);
        if (plVar7 != plVar3) break;
        *(longlong **)(lVar13 + uVar14 * 0x10) = plVar11;
        *(longlong **)(lVar13 + 8 + uVar14 * 0x10) = plVar11;
        plVar11 = plVar6;
      }
      plVar8 = *(longlong **)(lVar13 + 8 + uVar14 * 0x10);
      if ((((uVar4 != plVar8[2]) || (uVar12 != plVar8[3])) || (uVar5 != plVar8[4])) ||
         ((uVar1 != *(uint *)(plVar8 + 5) || (uVar2 != *(uint *)((longlong)plVar8 + 0x2c))))) break;
      plVar8 = (longlong *)*plVar8;
      if (plVar8 != plVar11) {
        plVar7 = (longlong *)plVar11[1];
        *plVar7 = (longlong)plVar6;
        puVar9 = (undefined8 *)plVar6[1];
        *puVar9 = plVar8;
        puVar10 = (undefined8 *)plVar8[1];
        *puVar10 = plVar11;
        plVar8[1] = (longlong)puVar9;
        plVar6[1] = (longlong)plVar7;
        plVar11[1] = (longlong)puVar10;
      }
      *(longlong **)(lVar13 + 8 + uVar14 * 0x10) = plVar11;
      plVar11 = plVar6;
    }
    do {
      if (plVar7 == plVar8) {
        plVar7 = (longlong *)plVar11[1];
        *plVar7 = (longlong)plVar6;
        puVar9 = (undefined8 *)plVar6[1];
        *puVar9 = plVar8;
        puVar10 = (undefined8 *)plVar8[1];
        *puVar10 = plVar11;
        plVar8[1] = (longlong)puVar9;
        plVar6[1] = (longlong)plVar7;
        plVar11[1] = (longlong)puVar10;
        *(longlong **)(lVar13 + uVar14 * 0x10) = plVar11;
        plVar11 = plVar6;
        goto joined_r0x00018042d2e1;
      }
      plVar8 = (longlong *)plVar8[1];
    } while (((uVar4 != plVar8[2]) || (uVar12 != plVar8[3])) ||
            ((uVar5 != plVar8[4] ||
             ((uVar1 != *(uint *)(plVar8 + 5) || (uVar2 != *(uint *)((longlong)plVar8 + 0x2c)))))));
    lVar13 = *plVar8;
    plVar7 = (longlong *)plVar11[1];
    *plVar7 = (longlong)plVar6;
    plVar8 = (longlong *)plVar6[1];
    *plVar8 = lVar13;
    puVar9 = *(undefined8 **)(lVar13 + 8);
    *puVar9 = plVar11;
    *(longlong **)(lVar13 + 8) = plVar8;
    plVar6[1] = (longlong)plVar7;
    plVar11[1] = (longlong)puVar9;
    plVar11 = plVar6;
  } while( true );
}

