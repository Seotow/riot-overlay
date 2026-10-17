// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180428af0; descriptive alias: FUN_180428af0
// Evidence: ev_d2a7dbf33ac0a93c21e1dcbced593f6d2c7eeb4f5703a9e7588b5b0f63428ee1
// Original Evidence: rea-collector/0x180428af0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 * FUN_180428af0(undefined1 *param_1)

{
  float *pfVar1;
  undefined1 auVar2 [16];
  undefined1 uVar3;
  uint uVar4;
  undefined1 *puVar5;
  longlong lVar6;
  longlong lVar7;
  undefined8 uVar8;
  ulonglong uVar9;
  ulonglong uVar10;
  undefined1 auVar11 [16];
  float fVar13;
  undefined1 auVar14 [16];
  float fVar15;
  undefined1 auVar16 [16];
  longlong local_a8;
  longlong local_a0;
  longlong local_98;
  longlong local_90;
  longlong local_88;
  longlong local_80;
  longlong local_78;
  longlong local_70;
  longlong local_68;
  longlong local_60;
  longlong local_58;
  undefined1 local_50 [8];
  float *local_48;
  undefined1 *local_40;
  undefined1 auVar12 [12];
  
  *param_1 = 0;
  *(undefined8 *)(param_1 + 8) = 0;
  *(undefined8 *)(param_1 + 0x10) = 0;
  *(undefined8 *)(param_1 + 0x18) = 0;
  *(undefined8 *)(param_1 + 0x20) = 0;
  *(undefined8 *)(param_1 + 0x28) = 0;
  *(undefined8 *)(param_1 + 0x30) = 0;
  *(undefined8 *)(param_1 + 0x38) = 0;
  *(undefined8 *)(param_1 + 0x40) = 0;
  *(undefined8 *)(param_1 + 0x48) = 0;
  *(undefined8 *)(param_1 + 0x50) = 0;
  *(undefined8 *)(param_1 + 0x58) = 0;
  *(undefined8 *)(param_1 + 0x60) = 0;
  *(undefined8 *)(param_1 + 0x68) = 0;
  local_40 = param_1;
  puVar5 = (undefined1 *)FUN_180976d80(0xb1c18);
  *(undefined2 *)(puVar5 + 1) = 0;
  puVar5[3] = 0;
  *(undefined4 *)(puVar5 + 0x814) = 0;
  *puVar5 = 0;
  *(undefined8 *)(puVar5 + 4) = 0;
  *(undefined8 *)(puVar5 + 0xc) = 0;
  FUN_1809bef30(puVar5 + 0x14,0,0x800);
  FUN_1809bef30(puVar5 + 0x818,0,0x20800);
  FUN_18042c440(puVar5 + 0x818);
  FUN_1809bef30(puVar5 + 0x21018,0,0x80a00);
  FUN_18042c880(puVar5 + 0x21018);
  FUN_1809bef30(puVar5 + 0xa1a18,0,0x10200);
  FUN_18042cbb0(puVar5 + 0xa1a18);
  *(undefined1 **)(param_1 + 0x70) = puVar5;
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  *(undefined8 *)(param_1 + 0x80) = 0;
  *(undefined8 *)(param_1 + 0x88) = 0;
  *(undefined8 *)(param_1 + 0x90) = 1;
  *(undefined4 *)(param_1 + 0x98) = 0;
  *(undefined8 *)(param_1 + 0xa0) = 0;
  *(undefined8 *)(param_1 + 0xa8) = 0;
  *(undefined8 *)(param_1 + 0xb0) = 0;
  *(undefined8 *)(param_1 + 0xb8) = 0;
  *(undefined8 *)(param_1 + 0xc0) = 0;
  *(undefined8 *)(param_1 + 200) = 0;
  *(undefined8 *)(param_1 + 0xd0) = 0;
  *(undefined8 *)(param_1 + 0xd8) = 0;
  *(undefined8 *)(param_1 + 0xe0) = 0;
  *(undefined8 *)(param_1 + 0xe8) = 0;
  *(undefined8 *)(param_1 + 0xf0) = 0;
  *(undefined8 *)(param_1 + 0xf8) = 0;
  *(undefined8 *)(param_1 + 0x100) = 0;
  *(undefined8 *)(param_1 + 0x108) = 0;
  *(undefined8 *)(param_1 + 0x110) = 0;
  *(undefined8 *)(param_1 + 0x118) = 0;
  FUN_1809bef30(param_1 + 0x120,0,0x8180);
  FUN_18042c100(param_1 + 0x120);
  pfVar1 = (float *)(param_1 + 0x82a0);
  *pfVar1 = 0.0;
  *(undefined8 *)(param_1 + 0x82a8) = 0;
  *(undefined8 *)(param_1 + 0x82b0) = 0;
  local_48 = pfVar1;
  lVar6 = FUN_180976d80(0x38);
  *(longlong *)lVar6 = lVar6;
  *(longlong *)(lVar6 + 8) = lVar6;
  *(longlong *)(param_1 + 0x82a8) = lVar6;
  *(undefined8 *)(param_1 + 0x82b8) = 0;
  *(undefined8 *)(param_1 + 0x82c0) = 0;
  *(undefined8 *)(param_1 + 0x82c8) = 0;
  *(undefined8 *)(param_1 + 0x82d0) = 7;
  *(undefined8 *)(param_1 + 0x82d8) = 8;
  *pfVar1 = 1.0;
  FUN_1801b0350(param_1 + 0x82b8,0x10,*(undefined8 *)(param_1 + 0x82a8));
  auVar16._0_12_ = ZEXT812(0);
  auVar16._12_4_ = 0;
  auVar16 = vroundss_avx(auVar16,ZEXT416((uint)(256.0 / *pfVar1)),2);
  fVar15 = auVar16._0_4_;
  lVar6 = 0;
  if ((9.223372e+18 <= fVar15) && (fVar15 = fVar15 - 9.223372e+18, fVar15 < 9.223372e+18)) {
    lVar6 = -0x8000000000000000;
  }
  auVar2._8_8_ = 0;
  auVar2._0_8_ = SUB648(ZEXT6064((undefined1  [60])0x0),4);
  auVar12 = SUB1612(auVar2 << 0x40,4);
  if ((longlong)*(ulonglong *)(param_1 + 0x82b0) < 0) {
    auVar12 = (undefined1  [12])0x0;
  }
  auVar11._0_4_ = (float)*(ulonglong *)(param_1 + 0x82b0) / *pfVar1;
  auVar11._4_12_ = auVar12;
  auVar14._0_12_ = ZEXT812(0);
  auVar14._12_4_ = 0;
  auVar16 = vroundss_avx(auVar14,auVar11,2);
  fVar13 = auVar16._0_4_;
  lVar7 = 0;
  if ((9.223372e+18 <= fVar13) && (fVar13 = fVar13 - 9.223372e+18, fVar13 < 9.223372e+18)) {
    lVar7 = -0x8000000000000000;
  }
  uVar9 = (longlong)fVar13 + lVar7;
  if ((ulonglong)((longlong)fVar13 + lVar7) < (ulonglong)((longlong)fVar15 + lVar6)) {
    uVar9 = (longlong)fVar15 + lVar6;
  }
  if (*(ulonglong *)(param_1 + 0x82d8) < uVar9) {
    FUN_18042d260(pfVar1);
  }
  uVar10 = ((ulonglong)(DAT_180d6b81c + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar9 = ((ulonglong)(DAT_180d6b818 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  if (uVar9 < uVar10) {
    uVar9 = uVar10;
  }
  *(ulonglong *)(param_1 + 8) = uVar9;
  uVar4 = DAT_180d6b820 + 0xe6632e3aU;
  if (((ulonglong)(DAT_180d6b820 + 0xe6632e3aU) ^ 0x11bf48c) + 8 <
      ((ulonglong)(DAT_180d6b824 + 0xe6632e3aU) ^ 0x11bf48c) + 8) {
    uVar4 = DAT_180d6b824 + 0xe6632e3aU;
  }
  *(ulonglong *)(param_1 + 0x10) = ((ulonglong)uVar4 ^ 0x11bf48c) + 8;
  local_a8 = ((ulonglong)(DAT_180d6b828 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_a0 = ((ulonglong)(DAT_180d6b82c + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_98 = ((ulonglong)(DAT_180d6b830 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_90 = ((ulonglong)(DAT_180d6b834 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_88 = ((ulonglong)(DAT_180d6b838 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  uVar8 = thunk_FUN_180971670(&local_a8,&local_80);
  *(undefined8 *)(param_1 + 0x18) = uVar8;
  uVar10 = ((ulonglong)(DAT_180d6b844 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar9 = ((ulonglong)(DAT_180d6b840 + 0xe6632e3a) ^ 0x11bf48c) + 1;
  if (uVar9 < uVar10) {
    uVar9 = uVar10;
  }
  *(ulonglong *)(param_1 + 0x20) = uVar9;
  uVar10 = ((ulonglong)(DAT_180d6b854 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  uVar9 = ((ulonglong)(DAT_180d6b850 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  if (uVar9 < uVar10) {
    uVar9 = uVar10;
  }
  *(ulonglong *)(param_1 + 0x28) = uVar9;
  local_a8 = ((ulonglong)(DAT_180d6b858 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_a0 = ((ulonglong)(DAT_180d6b85c + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_98 = ((ulonglong)(DAT_180d6b860 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_90 = ((ulonglong)(DAT_180d6b864 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_88 = ((ulonglong)(DAT_180d6b868 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_80 = ((ulonglong)(DAT_180d6b86c + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar8 = thunk_FUN_180971670(&local_a8,&local_78);
  *(undefined8 *)(param_1 + 0x30) = uVar8;
  uVar10 = ((ulonglong)(DAT_180d6b874 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar9 = ((ulonglong)(DAT_180d6b870 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  if (uVar9 < uVar10) {
    uVar9 = uVar10;
  }
  *(ulonglong *)(param_1 + 0x38) = uVar9;
  local_a8 = ((ulonglong)(DAT_180d6b878 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_a0 = ((ulonglong)(DAT_180d6b880 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_98 = ((ulonglong)(DAT_180d6b884 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_90 = ((ulonglong)(DAT_180d6b888 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar8 = thunk_FUN_180971670(&local_a8,&local_88);
  *(undefined8 *)(param_1 + 0x40) = uVar8;
  local_a8 = *(longlong *)(param_1 + 0x28);
  local_a0 = ((ulonglong)(DAT_180d6b88c + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_98 = ((ulonglong)(DAT_180d6b85c + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_90 = ((ulonglong)(DAT_180d6b890 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_88 = ((ulonglong)(DAT_180d6b894 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_80 = ((ulonglong)(DAT_180d6b898 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_78 = ((ulonglong)(DAT_180d6b89c + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_70 = ((ulonglong)(DAT_180d6b8a0 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_68 = ((ulonglong)(DAT_180d6b8a4 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_60 = ((ulonglong)(DAT_180d6b8a8 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_58 = ((ulonglong)(DAT_180d6b8ac + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar8 = thunk_FUN_180971670(&local_a8,local_50);
  *(undefined8 *)(param_1 + 0x48) = uVar8;
  uVar10 = ((ulonglong)(DAT_180d6b8b8 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar9 = ((ulonglong)(DAT_180d3e838 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  if (uVar9 < uVar10) {
    uVar9 = uVar10;
  }
  *(ulonglong *)(param_1 + 0x50) = uVar9;
  *(ulonglong *)(param_1 + 0x58) = ((ulonglong)(DAT_180d6b8c0 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_a8 = ((ulonglong)(DAT_180d6b8c8 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_a0 = ((ulonglong)(DAT_180d6b8cc + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_98 = ((ulonglong)(DAT_180d6b8d0 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_90 = ((ulonglong)(DAT_180d6b8d4 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_88 = ((ulonglong)(DAT_180d6b8d8 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_80 = ((ulonglong)(DAT_180d6b8dc + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_78 = ((ulonglong)(DAT_180d6b8e0 + 0xe6632e3a) ^ 0x11bf48c) + 1;
  local_70 = ((ulonglong)(DAT_180d6b8e4 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar8 = thunk_FUN_180971670(&local_a8,&local_68);
  *(undefined8 *)(param_1 + 0x60) = uVar8;
  local_a8 = ((ulonglong)(DAT_180d6b8e8 + 0xe6632e3a) ^ 0x11bf48c) + 8;
  local_a0 = ((ulonglong)(DAT_180d6b8ec + 0xe6632e3a) ^ 0x11bf48c) + 4;
  local_98 = ((ulonglong)(DAT_180d6b8f0 + 0xe6632e3a) ^ 0x11bf48c) + 4;
  uVar8 = thunk_FUN_180971670(&local_a8,&local_90);
  *(undefined8 *)(param_1 + 0x68) = uVar8;
  if (DAT_180d3df28 == '\0') {
    uVar4 = DAT_180d3dac0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar4 = FUN_18052b510(&DAT_180d3dac0);
  }
  if (uVar4 != 0) {
    if (DAT_180d3e3b0 == '\0') {
      uVar4 = DAT_180d3df48 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar4 = FUN_18052b510(&DAT_180d3df48);
    }
    if (uVar4 != 0) {
      if (DAT_180d3e830 == '\0') {
        uVar4 = DAT_180d3e3c8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar4 = FUN_18052b510(&DAT_180d3e3c8);
      }
      if (((((((uVar4 != 0) && ((DAT_180d3df3c + 0xe6632e3aU ^ 0x11bf48c) - 8 < 0x69)) &&
             (3 < (DAT_180d6b8b0 + 0xe6632e3aU ^ 0x11bf48c))) &&
            (((7 < (DAT_180d6b8bc + 0xe6632e3aU ^ 0x11bf48c) &&
              (uVar9 = (ulonglong)(DAT_180d3df3c + 0xe6632e3aU) ^ 0x11bf48c,
              ((ulonglong)(DAT_180d3df38 + 0xe6632e3a) ^ 0x11bf48c) + 8 <= uVar9)) &&
             ((((ulonglong)(DAT_180d6b814 + 0xe6632e3a) ^ 0x11bf48c) + 4 <= uVar9 &&
              ((((ulonglong)(DAT_180d6b8b4 + 0xe6632e3a) ^ 0x11bf48c) <=
                ((ulonglong)(DAT_180d6b8b0 + 0xe6632e3aU) ^ 0x11bf48c) - 4 &&
               (((ulonglong)(DAT_180d6b8c0 + 0xe6632e3a) ^ 0x11bf48c) <=
                ((ulonglong)(DAT_180d6b8bc + 0xe6632e3aU) ^ 0x11bf48c) - 8)))))))) &&
           ((*(ulonglong *)(param_1 + 8) < 0x11 &&
            (((*(ulonglong *)(param_1 + 0x10) < 0x21 && (*(ulonglong *)(param_1 + 0x18) < 0x231)) &&
             (*(ulonglong *)(param_1 + 0x20) < 0xd)))))) &&
          (((*(ulonglong *)(param_1 + 0x28) < 0xa1 && (*(ulonglong *)(param_1 + 0x30) < 0xa1)) &&
           (((*(ulonglong *)(param_1 + 0x38) < 0x19 &&
             ((*(ulonglong *)(param_1 + 0x40) < 0x31 && (*(ulonglong *)(param_1 + 0x48) < 0xa1))))
            && (*(ulonglong *)(param_1 + 0x50) < 0x19)))))) &&
         (((*(ulonglong *)(param_1 + 0x58) < 0x11 && (*(ulonglong *)(param_1 + 0x60) < 0x81)) &&
          (*(ulonglong *)(param_1 + 0x68) < 0x19)))) {
        uVar3 = 1;
        goto LAB_18042950f;
      }
    }
  }
  uVar3 = 0;
LAB_18042950f:
  *param_1 = uVar3;
  return param_1;
}

