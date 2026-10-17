// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180434a50; descriptive alias: FUN_180434a50
// Evidence: ev_6ac08244ba939c00dac81508ba0d50a5a64d1af59573161b38f377f2ee32e5e2
// Original Evidence: rea-collector/0x180434a50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180434a50(longlong *param_1)

{
  longlong lVar1;
  longlong *plVar2;
  longlong *plVar3;
  longlong lVar4;
  longlong *plVar5;
  undefined8 *puVar6;
  undefined8 *puVar7;
  ulonglong uVar8;
  longlong lVar9;
  longlong *plVar10;
  longlong *plVar11;
  longlong *plVar12;
  longlong *local_48;
  longlong local_40;
  longlong local_38;
  
  lVar1 = *param_1;
  if ((lVar1 != 0) && (*(ulonglong *)(lVar1 + 0x20) != 0)) {
    plVar2 = *(longlong **)(lVar1 + 0x18);
    if (*(ulonglong *)(lVar1 + 0x20) < *(ulonglong *)(lVar1 + 0x48) >> 3) {
      plVar3 = (longlong *)*plVar2;
      if (plVar3 != plVar2) {
        lVar4 = *(longlong *)(lVar1 + 0x28);
        plVar5 = (longlong *)plVar3[1];
        local_38 = lVar4;
        uVar8 = FUN_180434320(lVar1,plVar3 + 2);
        lVar9 = (uVar8 & *(ulonglong *)(lVar1 + 0x40)) * 0x10;
        local_48 = (longlong *)(lVar4 + 8 + lVar9);
        local_40 = *(longlong *)(lVar9 + lVar4);
        plVar10 = (longlong *)*local_48;
        plVar12 = plVar3;
        do {
          plVar11 = (longlong *)*plVar12;
          thunk_FUN_180895720(plVar12,0x18);
          *(longlong *)(lVar1 + 0x20) = *(longlong *)(lVar1 + 0x20) + -1;
          if (plVar12 == plVar10) {
            plVar10 = plVar5;
            if ((longlong *)local_40 == plVar3) {
              *(longlong *)(lVar9 + lVar4) = (longlong)plVar2;
              plVar10 = plVar2;
            }
            *local_48 = (longlong)plVar10;
            while (plVar11 != plVar2) {
              uVar8 = FUN_180434320(lVar1,plVar11 + 2);
              uVar8 = uVar8 & *(ulonglong *)(lVar1 + 0x40);
              plVar10 = *(longlong **)(local_38 + 8 + uVar8 * 0x10);
              plVar3 = (longlong *)(local_38 + uVar8 * 0x10);
              plVar12 = plVar11;
              while( true ) {
                plVar11 = (longlong *)*plVar12;
                thunk_FUN_180895720(plVar12,0x18);
                *(longlong *)(lVar1 + 0x20) = *(longlong *)(lVar1 + 0x20) + -1;
                if (plVar12 == plVar10) break;
                plVar12 = plVar11;
                if (plVar11 == plVar2) {
                  *plVar3 = (longlong)plVar11;
                  goto LAB_180434b1b;
                }
              }
              *plVar3 = (longlong)plVar2;
              *(longlong **)(local_38 + 8 + uVar8 * 0x10) = plVar2;
            }
            goto LAB_180434b1b;
          }
          plVar12 = plVar11;
        } while (plVar11 != plVar2);
        if ((longlong *)local_40 == plVar3) {
          *(longlong *)(lVar9 + lVar4) = (longlong)plVar11;
        }
LAB_180434b1b:
        *plVar5 = (longlong)plVar11;
        plVar11[1] = (longlong)plVar5;
        return;
      }
    }
    else {
      *(undefined8 *)plVar2[1] = 0;
      puVar7 = (undefined8 *)*plVar2;
      while (puVar7 != (undefined8 *)0x0) {
        puVar6 = (undefined8 *)*puVar7;
        thunk_FUN_180895720(puVar7,0x18);
        puVar7 = puVar6;
      }
      *(undefined8 *)*(undefined8 *)(lVar1 + 0x18) = *(undefined8 *)(lVar1 + 0x18);
      *(longlong *)(*(longlong *)(lVar1 + 0x18) + 8) = *(longlong *)(lVar1 + 0x18);
      *(undefined8 *)(lVar1 + 0x20) = 0;
      local_48 = *(longlong **)(lVar1 + 0x18);
      FUN_1801ab6d0(*(undefined8 *)(lVar1 + 0x28),*(undefined8 *)(lVar1 + 0x30),&local_48);
    }
  }
  return;
}

