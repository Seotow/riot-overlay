// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804430e0; descriptive alias: FUN_1804430e0
// Evidence: ev_863dcede0bcdc34e3bc6b43366969c6246306b07115ec89d15e972303269f57b
// Original Evidence: rea-collector/0x1804430e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __chkstk replaced with injection: alloca_probe */
/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined4 * FUN_1804430e0(longlong param_1,undefined4 *param_2,longlong param_3,longlong param_4)

{
  int iVar1;
  int iVar2;
  int *piVar3;
  longlong lVar4;
  ulonglong uVar5;
  ulonglong uVar6;
  longlong lVar7;
  undefined1 auStack_1098 [32];
  ulonglong local_1078;
  longlong *local_1070;
  longlong local_1068 [2];
  undefined1 *local_1058;
  ulonglong local_1050;
  undefined1 local_1048 [4096];
  ulonglong local_48;
  undefined8 uStack_40;
  
  uStack_40 = 0x1804430f5;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_1098;
  lVar7 = param_3 + param_4 * 4;
  lVar4 = param_4 * 4 >> 2;
  local_1068[0] = param_1;
  if (lVar4 < 0x21) {
    FUN_180444470(param_3,lVar7,local_1068);
  }
  else {
    uVar5 = lVar4 - lVar4 / 2;
    uVar6 = 0x7fffffffffffffff;
    if ((longlong)uVar5 < 0x7fffffffffffffff) {
      uVar6 = uVar5;
    }
    if (0x400 < uVar5) {
      if ((uVar6 < 0x4000000000000000) && (0 < (longlong)uVar6)) {
        do {
          local_1058 = (undefined1 *)FUN_180976f70(uVar6 * 4,&DAT_180bd7760);
          if (local_1058 != (undefined1 *)0x0) {
            if (0x400 < uVar6) goto LAB_1804431c6;
            goto LAB_1804431b4;
          }
          uVar6 = uVar6 >> 1;
        } while (uVar6 != 0);
      }
      local_1058 = (undefined1 *)0x0;
LAB_1804431b4:
      FUN_180895720(local_1058);
      uVar5 = 0x400;
    }
    uVar6 = uVar5;
    local_1058 = local_1048;
LAB_1804431c6:
    local_1070 = local_1068;
    local_1078 = uVar6;
    local_1050 = uVar6;
    FUN_1804445f0(param_3,lVar7,lVar4,local_1058);
    if (0x400 < local_1050) {
      FUN_180895720(local_1058);
    }
  }
  FUN_1801c3f20(param_1,param_4,4);
  lVar7 = param_4;
  while (lVar7 != 0) {
    lVar7 = lVar7 + -1;
    iVar1 = *(int *)(param_3 + lVar7 * 4);
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(undefined8 *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-*(int *)(param_1 + 0x30) & 3);
    iVar2 = *(int *)(param_1 + 0x30);
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(undefined8 *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-iVar2 & 3);
    FUN_1801c5410(param_1,4);
    piVar3 = (int *)(*(longlong *)(param_1 + 0x40) + -4);
    *(int **)(param_1 + 0x40) = piVar3;
    *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + 4;
    *piVar3 = (iVar2 - iVar1) + 4;
  }
  *(undefined1 *)(param_1 + 0x60) = 0;
  if (*(ulonglong *)(param_1 + 0x68) < 4) {
    *(undefined8 *)(param_1 + 0x68) = 4;
  }
  FUN_1801c5360(param_1,-*(int *)(param_1 + 0x30) & 3);
  FUN_1801c5410(param_1,4);
  *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + -4;
  *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + 4;
  **(undefined4 **)(param_1 + 0x40) = (int)param_4;
  *param_2 = *(undefined4 *)(param_1 + 0x30);
  return param_2;
}

