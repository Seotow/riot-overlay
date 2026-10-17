// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043b360; descriptive alias: FUN_18043b360
// Evidence: ev_ee412c16b1d4308abc19350fded7ccadedb8ee4353e9620bbf4257d6a1a53161
// Original Evidence: rea-collector/0x18043b360.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined4 * FUN_18043b360(longlong param_1,undefined4 *param_2,longlong *param_3)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  uint uVar5;
  undefined8 uVar6;
  int *piVar7;
  longlong lVar8;
  ulonglong uVar9;
  undefined1 *puVar10;
  longlong lVar11;
  longlong lVar12;
  longlong lVar13;
  undefined8 extraout_XMM0_Qa;
  undefined1 auStack_88 [8];
  undefined1 auStack_80 [24];
  undefined1 local_68 [8];
  longlong *local_60;
  undefined1 local_58 [16];
  longlong local_48;
  ulonglong local_38;
  
  puVar10 = auStack_88;
  local_38 = DAT_180d06cc0 ^ (ulonglong)auStack_88;
  local_58 = (undefined1  [16])0x0;
  local_48 = 0;
  uVar9 = 0;
  do {
    cVar4 = FUN_1801fa260(param_3);
    if (cVar4 == '\0') {
      local_60 = param_3;
      FUN_180424cd0(extraout_XMM0_Qa,&local_60);
    }
    else {
      lVar8 = (**(code **)(*param_3 + 0x10))(param_3,uVar9 & 0xffffffff);
      if (lVar8 != 0) {
        if (DAT_180d445d8 == '\0') {
          uVar5 = DAT_180d44170 + 0xe6632e3aU ^ 0x11bf48c;
        }
        else {
          uVar5 = FUN_18052b510(&DAT_180d44170);
        }
        if (*(longlong *)(lVar8 + (ulonglong)uVar5) != 0) {
          uVar6 = FUN_180438b60(param_1,local_68,lVar8,uVar9 & 0xff);
          FUN_1801c3a50(local_58,uVar6);
        }
      }
    }
    uVar9 = uVar9 + 1;
  } while (uVar9 < 9);
  lVar8 = *(longlong *)(param_1 + 0x480);
  lVar11 = (longlong)(local_58._8_8_ - local_58._0_8_) >> 2;
  lVar13 = 0x180d6e9e4;
  if (local_58._0_8_ != local_58._8_8_) {
    lVar13 = local_58._0_8_;
  }
  FUN_1801c3f20(lVar8,lVar11,4);
  lVar12 = lVar11;
  while (lVar12 != 0) {
    lVar12 = lVar12 + -1;
    iVar1 = *(int *)(lVar13 + lVar12 * 4);
    if (*(ulonglong *)(lVar8 + 0x68) < 4) {
      *(undefined8 *)(lVar8 + 0x68) = 4;
    }
    FUN_1801c5360(lVar8,-*(int *)(lVar8 + 0x30) & 3);
    iVar2 = *(int *)(lVar8 + 0x30);
    if (*(ulonglong *)(lVar8 + 0x68) < 4) {
      *(undefined8 *)(lVar8 + 0x68) = 4;
    }
    FUN_1801c5360(lVar8,-iVar2 & 3);
    FUN_1801c5410(lVar8,4);
    piVar7 = (int *)(*(longlong *)(lVar8 + 0x40) + -4);
    *(int **)(lVar8 + 0x40) = piVar7;
    *(int *)(lVar8 + 0x30) = *(int *)(lVar8 + 0x30) + 4;
    *piVar7 = (iVar2 - iVar1) + 4;
  }
  *(undefined1 *)(lVar8 + 0x60) = 0;
  if (*(ulonglong *)(lVar8 + 0x68) < 4) {
    *(undefined8 *)(lVar8 + 0x68) = 4;
  }
  FUN_1801c5360(lVar8,-*(int *)(lVar8 + 0x30) & 3);
  FUN_1801c5410(lVar8,4);
  *(longlong *)(lVar8 + 0x40) = *(longlong *)(lVar8 + 0x40) + -4;
  *(int *)(lVar8 + 0x30) = *(int *)(lVar8 + 0x30) + 4;
  **(undefined4 **)(lVar8 + 0x40) = (int)lVar11;
  *param_2 = *(undefined4 *)(lVar8 + 0x30);
  if (local_58._0_8_ != 0) {
    lVar8 = local_58._0_8_;
    puVar10 = auStack_88;
    if ((0xfff < (ulonglong)((local_48 - local_58._0_8_ >> 2) * 4)) &&
       (lVar8 = *(longlong *)(local_58._0_8_ + -8), puVar10 = auStack_88,
       0x1f < (local_58._0_8_ - lVar8) - 8U)) {
      lVar8 = 5;
      pcVar3 = (code *)swi(0x29);
      (*pcVar3)(5);
      puVar10 = auStack_80;
    }
    *(undefined8 *)(puVar10 + -8) = 0x18043b598;
    thunk_FUN_180895720(lVar8);
  }
  *(undefined8 *)(puVar10 + -8) = 0x18043b5a8;
  return param_2;
}

