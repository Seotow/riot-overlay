// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d090; descriptive alias: FUN_18042d090
// Evidence: ev_7da2737762695724fcfdf5bbfb6edfa22af9dcef37904ee51902f649269ad2d2
// Original Evidence: rea-collector/0x18042d090.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong * FUN_18042d090(longlong param_1,longlong *param_2,longlong *param_3)

{
  longlong *plVar1;
  longlong lVar2;
  undefined8 *puVar3;
  undefined8 *puVar4;
  longlong *plVar5;
  undefined8 *puVar6;
  longlong *plVar7;
  longlong lVar8;
  longlong *plVar9;
  longlong *plVar10;
  longlong *plVar11;
  ulonglong uVar12;
  
  if (param_2 == param_3) {
    return param_3;
  }
  lVar2 = *(longlong *)(param_1 + 0x18);
  puVar3 = *(undefined8 **)(param_1 + 8);
  puVar4 = (undefined8 *)param_2[1];
  lVar8 = ((((ulonglong)(param_2[3] ^ param_2[2]) >> 1 ^ param_2[4]) >> 3 ^
            (ulonglong)*(uint *)(param_2 + 5) * 2 ^ (ulonglong)*(uint *)((longlong)param_2 + 0x2c))
          & *(ulonglong *)(param_1 + 0x30)) * 0x10;
  plVar7 = (longlong *)(lVar2 + 8 + lVar8);
  plVar1 = (longlong *)(lVar8 + lVar2);
  plVar5 = (longlong *)*plVar7;
  plVar10 = (longlong *)*plVar1;
  plVar9 = param_2;
  do {
    plVar11 = (longlong *)*plVar9;
    thunk_FUN_180895720(plVar9,0x38);
    *(longlong *)(param_1 + 0x10) = *(longlong *)(param_1 + 0x10) + -1;
    if (plVar9 == plVar5) {
      puVar6 = puVar4;
      if (plVar10 == param_2) {
        *plVar1 = (longlong)puVar3;
        puVar6 = puVar3;
      }
      *plVar7 = (longlong)puVar6;
      while (plVar11 != param_3) {
        uVar12 = (((ulonglong)(plVar11[3] ^ plVar11[2]) >> 1 ^ plVar11[4]) >> 3 ^
                  (ulonglong)*(uint *)(plVar11 + 5) * 2 ^
                 (ulonglong)*(uint *)((longlong)plVar11 + 0x2c)) & *(ulonglong *)(param_1 + 0x30);
        plVar5 = *(longlong **)(lVar2 + 8 + uVar12 * 0x10);
        plVar1 = (longlong *)(lVar2 + uVar12 * 0x10);
        plVar10 = plVar11;
        while( true ) {
          plVar11 = (longlong *)*plVar10;
          thunk_FUN_180895720(plVar10,0x38);
          *(longlong *)(param_1 + 0x10) = *(longlong *)(param_1 + 0x10) + -1;
          if (plVar10 == plVar5) break;
          plVar10 = plVar11;
          if (plVar11 == param_3) {
            *plVar1 = (longlong)plVar11;
            *puVar4 = plVar11;
            plVar11[1] = (longlong)puVar4;
            return param_3;
          }
        }
        *plVar1 = (longlong)puVar3;
        *(undefined8 **)(lVar2 + 8 + uVar12 * 0x10) = puVar3;
      }
      goto LAB_18042d21f;
    }
    plVar9 = plVar11;
  } while (plVar11 != param_3);
  if (plVar10 == param_2) {
    *plVar1 = (longlong)plVar11;
  }
LAB_18042d21f:
  *puVar4 = plVar11;
  plVar11[1] = (longlong)puVar4;
  return param_3;
}

