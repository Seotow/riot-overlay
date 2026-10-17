// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804426b0; descriptive alias: FUN_1804426b0
// Evidence: ev_9c8ebb38cfa2a2138313e6393aea3c3c80465f0475687e73df97f0b359ab24bd
// Original Evidence: rea-collector/0x1804426b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong * FUN_1804426b0(longlong *param_1,undefined8 param_2,longlong *param_3)

{
  longlong lVar1;
  undefined8 *puVar2;
  longlong lVar3;
  undefined4 *puVar4;
  undefined8 *puVar5;
  ulonglong uVar6;
  undefined4 local_38 [2];
  longlong *local_30;
  
  uVar6 = 0;
  *param_1 = 0;
  param_1[1] = 0;
  param_1[2] = 0;
  lVar1 = ((longlong *)param_3[1])[1];
  lVar3 = *(longlong *)param_3[1];
  if (*param_3 < 0) {
    lVar3 = FUN_180443fe0(lVar3,lVar1);
    *param_3 = lVar3 - *(longlong *)param_3[1] >> 3;
  }
  else {
    lVar3 = lVar3 + *param_3 * 8;
  }
  for (; lVar3 != lVar1; lVar3 = FUN_180443fe0(lVar3 + 8,*(undefined8 *)(param_3[1] + 8))) {
    uVar6 = uVar6 + 1;
  }
  puVar2 = (undefined8 *)((longlong *)param_3[1])[1];
  lVar3 = *(longlong *)param_3[1];
  if (*param_3 < 0) {
    puVar5 = (undefined8 *)FUN_180443fe0(lVar3,puVar2);
    *param_3 = (longlong)puVar5 - *(longlong *)param_3[1] >> 3;
  }
  else {
    puVar5 = (undefined8 *)(lVar3 + *param_3 * 8);
  }
  if (uVar6 != 0) {
    if (0x3fffffffffffffff < uVar6) {
                    /* WARNING: Subroutine does not return */
      FUN_180183310();
    }
    puVar4 = (undefined4 *)FUN_1801a22d0(uVar6 * 4);
    *param_1 = (longlong)puVar4;
    param_1[1] = (longlong)puVar4;
    param_1[2] = (longlong)(puVar4 + uVar6);
    local_30 = param_1;
    for (; puVar5 != puVar2;
        puVar5 = (undefined8 *)FUN_180443fe0(puVar5 + 1,*(undefined8 *)(param_3[1] + 8))) {
      (*(code *)param_3[3])(param_3[5],local_38,*puVar5);
      *puVar4 = local_38[0];
      puVar4 = puVar4 + 1;
    }
    param_1[1] = (longlong)puVar4;
  }
  return param_1;
}

