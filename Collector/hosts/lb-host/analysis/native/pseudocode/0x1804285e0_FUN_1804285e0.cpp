// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804285e0; descriptive alias: FUN_1804285e0
// Evidence: ev_f6ad8c46732e5379a96362dda7309fc77edc05a4c50549ae37dd929362b1ebc9
// Original Evidence: rea-collector/0x1804285e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1804285e0(float *param_1,undefined8 *param_2,byte *param_3,undefined8 param_4)

{
  float *pfVar1;
  int iVar2;
  longlong lVar3;
  undefined8 *puVar4;
  undefined8 *puVar5;
  undefined8 *puVar6;
  ulonglong uVar7;
  undefined8 *puVar8;
  
  uVar7 = (((((ulonglong)*param_3 ^ 0xcbf29ce484222325) * 0x100000001b3 ^ (ulonglong)param_3[1]) *
            0x100000001b3 ^ (ulonglong)param_3[2]) * 0x100000001b3 ^ (ulonglong)param_3[3]) *
          0x100000001b3;
  puVar6 = (undefined8 *)(uVar7 & *(ulonglong *)(param_1 + 0xc));
  lVar3 = *(longlong *)(param_1 + 6);
  puVar5 = *(undefined8 **)(lVar3 + 8 + (longlong)puVar6 * 0x10);
  pfVar1 = param_1 + 2;
  puVar8 = *(undefined8 **)pfVar1;
  if (puVar5 != puVar8) {
    puVar6 = *(undefined8 **)(lVar3 + (longlong)puVar6 * 0x10);
    iVar2 = *(int *)(puVar5 + 2);
    puVar8 = puVar5;
    while( true ) {
      if (*(int *)param_3 == iVar2) {
        *param_2 = puVar8;
        *(undefined1 *)(param_2 + 1) = 0;
        return param_2;
      }
      if (puVar8 == puVar6) break;
      puVar8 = (undefined8 *)puVar8[1];
      iVar2 = *(int *)(puVar8 + 2);
    }
  }
  if (*(longlong *)(param_1 + 4) == 0xaaaaaaaaaaaaaaa) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("unordered_map/set too long");
  }
  puVar5 = (undefined8 *)FUN_180976d80(0x18,puVar6,lVar3,param_4,pfVar1,0);
  *(undefined4 *)(puVar5 + 2) = *(undefined4 *)param_3;
  *(undefined4 *)((longlong)puVar5 + 0x14) = 0;
  if (*param_1 < (float)(*(longlong *)(param_1 + 4) + 1) / (float)*(ulonglong *)(param_1 + 0xe)) {
    FUN_18035b570(param_1);
    puVar6 = *(undefined8 **)
              (*(longlong *)(param_1 + 6) + 8 + (uVar7 & *(ulonglong *)(param_1 + 0xc)) * 0x10);
    puVar8 = *(undefined8 **)pfVar1;
    if (puVar6 != puVar8) {
      iVar2 = *(int *)(puVar6 + 2);
      puVar8 = puVar6;
      while (*(int *)(puVar5 + 2) != iVar2) {
        if (puVar8 == *(undefined8 **)
                       (*(longlong *)(param_1 + 6) + (uVar7 & *(ulonglong *)(param_1 + 0xc)) * 0x10)
           ) goto LAB_180428781;
        puVar8 = (undefined8 *)puVar8[1];
        iVar2 = *(int *)(puVar8 + 2);
      }
      puVar8 = (undefined8 *)*puVar8;
    }
  }
LAB_180428781:
  puVar6 = (undefined8 *)puVar8[1];
  *(longlong *)(param_1 + 4) = *(longlong *)(param_1 + 4) + 1;
  *puVar5 = puVar8;
  puVar5[1] = puVar6;
  *puVar6 = puVar5;
  puVar8[1] = puVar5;
  lVar3 = *(longlong *)(param_1 + 6);
  uVar7 = *(ulonglong *)(param_1 + 0xc) & uVar7;
  puVar4 = *(undefined8 **)(lVar3 + uVar7 * 0x10);
  if (puVar4 == *(undefined8 **)pfVar1) {
    *(undefined8 **)(lVar3 + uVar7 * 0x10) = puVar5;
  }
  else {
    if (puVar4 == puVar8) {
      *(undefined8 **)(lVar3 + uVar7 * 0x10) = puVar5;
      goto LAB_1804287d1;
    }
    if (*(undefined8 **)(lVar3 + 8 + uVar7 * 0x10) != puVar6) goto LAB_1804287d1;
  }
  *(undefined8 **)(lVar3 + 8 + uVar7 * 0x10) = puVar5;
LAB_1804287d1:
  *param_2 = puVar5;
  *(undefined1 *)(param_2 + 1) = 1;
  return param_2;
}

