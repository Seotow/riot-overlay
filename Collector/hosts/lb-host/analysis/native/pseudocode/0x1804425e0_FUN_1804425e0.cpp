// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804425e0; descriptive alias: FUN_1804425e0
// Evidence: ev_74ad7754321fa4c7505372decb5f5ef553324cb3adef6e6895345ebb7cd8d53f
// Original Evidence: rea-collector/0x1804425e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong * FUN_1804425e0(longlong *param_1,undefined8 param_2,longlong *param_3)

{
  undefined8 *puVar1;
  undefined8 *puVar2;
  undefined4 *puVar3;
  longlong lVar4;
  ulonglong uVar5;
  undefined4 local_38 [4];
  
  *param_1 = 0;
  param_1[1] = 0;
  param_1[2] = 0;
  puVar1 = *(undefined8 **)*param_3;
  puVar2 = (undefined8 *)((longlong *)*param_3)[1];
  lVar4 = (longlong)puVar2 - (longlong)puVar1;
  if (lVar4 != 0) {
    uVar5 = lVar4 >> 3;
    if (0x3fffffffffffffff < uVar5) {
                    /* WARNING: Subroutine does not return */
      FUN_180183310();
    }
    puVar3 = (undefined4 *)FUN_1801a22d0(uVar5 * 4);
    *param_1 = (longlong)puVar3;
    param_1[1] = (longlong)puVar3;
    param_1[2] = (longlong)(puVar3 + uVar5);
    for (; puVar1 != puVar2; puVar1 = puVar1 + 1) {
      (*(code *)param_3[1])(param_3[3],local_38,*puVar1);
      *puVar3 = local_38[0];
      puVar3 = puVar3 + 1;
    }
    param_1[1] = (longlong)puVar3;
  }
  return param_1;
}

