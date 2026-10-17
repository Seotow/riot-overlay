// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804423a0; descriptive alias: FUN_1804423a0
// Evidence: ev_67d6f5e43da1186c9c5a5f6324ee7cba4238eaa3ce14d88eeb2e510df8564510
// Original Evidence: rea-collector/0x1804423a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

int * FUN_1804423a0(longlong param_1,int *param_2,ulonglong param_3,longlong *param_4)

{
  longlong lVar1;
  char cVar2;
  uint uVar3;
  undefined4 uVar4;
  undefined4 *puVar5;
  longlong lVar6;
  ulonglong uVar7;
  longlong lVar8;
  undefined4 *puVar9;
  int *piVar10;
  undefined8 uVar11;
  undefined1 auVar12 [16];
  undefined8 uVar14;
  undefined1 auVar15 [16];
  undefined1 auVar17 [64];
  undefined1 auVar13 [64];
  undefined1 auVar16 [64];
  
  FUN_1801c3f20(param_1,param_3,0x18,8);
  lVar8 = param_3 * 0x18;
  if (lVar8 != 0) {
    FUN_1801c5410(param_1,lVar8);
    *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + param_3 * -0x18;
    *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + (int)lVar8;
  }
  if (param_3 != 0) {
    puVar9 = *(undefined4 **)(param_1 + 0x40);
    uVar7 = 0;
    lVar8 = *param_4;
    lVar1 = param_4[1];
    auVar17 = ZEXT1664(ZEXT816(0x7ff8000000000000));
    do {
      lVar6 = ((ulonglong)(DAT_180d43cd0 + 0xe6632e3a) ^ 0x11bf48c) * uVar7 + lVar1;
      if ((*(byte *)(lVar8 + 0x488) & 1) == 0) {
        auVar12 = auVar17._0_16_;
        auVar15 = auVar12;
      }
      else {
        auVar12._0_8_ =
             (double)*(float *)(lVar6 + ((ulonglong)(DAT_180d43cf0 + 0xe6632e3a) ^ 0x11bf48c));
        auVar12._8_8_ = 0;
        auVar15._0_8_ =
             (double)*(float *)(lVar6 + ((ulonglong)(DAT_180d43cf4 + 0xe6632e3a) ^ 0x11bf48c));
        auVar15._8_8_ = 0;
      }
      auVar16 = ZEXT1664(auVar15);
      auVar13 = ZEXT1664(auVar12);
      lVar6 = *(longlong *)(lVar6 + ((ulonglong)(DAT_180d43cd4 + 0xe6632e3a) ^ 0x11bf48c));
      cVar2 = FUN_1801fa260(lVar6);
      uVar14 = auVar16._0_8_;
      uVar11 = auVar13._0_8_;
      if (cVar2 == '\0') {
        FUN_180421d10();
        uVar14 = auVar16._0_8_;
        uVar11 = auVar13._0_8_;
        uVar4 = 0;
      }
      else {
        if (DAT_180d43cdc == 0xfffffffe) {
          uVar3 = 0xffffffff;
        }
        else {
          uVar3 = DAT_180d43cdc;
          if (DAT_180d43cdc == 0xffffffff) {
            uVar3 = FUN_1804220c0(&DAT_180d43cd8);
            uVar14 = auVar16._0_8_;
            uVar11 = auVar13._0_8_;
          }
        }
        if ((lVar6 == 0) || (uVar3 == 0xffffffff)) {
          puVar5 = &DAT_180d6e988;
        }
        else {
          puVar5 = (undefined4 *)((ulonglong)uVar3 + lVar6);
        }
        uVar4 = *puVar5;
      }
      *puVar9 = uVar4;
      uVar7 = uVar7 + 1;
      puVar9[1] = 0;
      *(undefined8 *)(puVar9 + 2) = uVar11;
      *(undefined8 *)(puVar9 + 4) = uVar14;
      puVar9 = puVar9 + 6;
    } while (uVar7 < param_3);
  }
  *(undefined1 *)(param_1 + 0x60) = 0;
  if (*(ulonglong *)(param_1 + 0x68) < 4) {
    *(undefined8 *)(param_1 + 0x68) = 4;
  }
  piVar10 = (int *)(param_1 + 0x30);
  FUN_1801c5360(param_1,-*piVar10 & 3);
  FUN_1801c5410(param_1,4);
  *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + -4;
  *piVar10 = *piVar10 + 4;
  **(undefined4 **)(param_1 + 0x40) = (int)param_3;
  *param_2 = *piVar10;
  return param_2;
}

