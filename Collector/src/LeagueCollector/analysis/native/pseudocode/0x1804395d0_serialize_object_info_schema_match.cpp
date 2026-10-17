// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804395d0; descriptive alias: serialize_object_info_schema_match
// Evidence: ev_efde4332bf23356c0d6165b665d8c86eb3cf86d710eadbd1c5b34470e3901919
// Original Evidence: rea-collector/0x1804395d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_1804395d0(longlong param_1,undefined8 param_2,longlong *param_3)

{
  undefined1 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  undefined8 uVar4;
  float fVar5;
  uint uVar6;
  uint uVar7;
  float *pfVar8;
  undefined4 *puVar9;
  undefined4 uVar10;
  undefined1 auStack_c8 [32];
  undefined4 local_a8;
  longlong local_a0;
  undefined4 local_98;
  undefined1 local_90;
  undefined1 local_88 [16];
  longlong local_78;
  undefined8 uStack_70;
  longlong local_68;
  undefined8 uStack_60;
  ulonglong local_58;
  
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStack_c8;
  if ((*(byte *)(param_1 + 0x488) & 4) == 0) {
    uVar10 = 0x7fc00000;
  }
  else {
    pfVar8 = (float *)(**(code **)(*param_3 +
                                  ((ulonglong)(DAT_180d36f84 + 0xe6632e3a) ^ 0x11bf48c) * 8))
                                (param_3);
    fVar5 = pfVar8[1] * 57.295776;
    if ((*pfVar8 != 0.0) || (pfVar8[2] != 0.0)) {
      fVar5 = 180.0 - fVar5;
    }
    if (fVar5 < 0.0) {
      fVar5 = fVar5 + 360.0;
    }
    uVar10 = FUN_18099a090(fVar5);
  }
  if (DAT_180d2dd08 == '\0') {
    uVar6 = DAT_180d2d8a0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar6 = FUN_18052b510(&DAT_180d2d8a0);
  }
  uVar1 = *(undefined1 *)((ulonglong)uVar6 + (longlong)param_3);
  if (DAT_180d2ea58 == '\0') {
    uVar6 = DAT_180d2e5f0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar6 = FUN_18052b510(&DAT_180d2e5f0);
  }
  if (DAT_180d2d428 == '\0') {
    uVar7 = DAT_180d2cfc0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar7 = FUN_18052b510(&DAT_180d2cfc0);
  }
  uVar2 = *(undefined4 *)((ulonglong)uVar7 + (longlong)param_3);
  if (DAT_180d2e5e8 == '\0') {
    uVar7 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar7 = FUN_18052b510(&DAT_180d2e180);
  }
  uVar3 = *(undefined4 *)((ulonglong)uVar7 + (longlong)param_3);
  uVar4 = *(undefined8 *)(param_1 + 0x480);
  if (DAT_180d2e178 == '\0') {
    uVar7 = DAT_180d2dd10 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar7 = FUN_18052b510(&DAT_180d2dd10);
  }
  local_68 = (ulonglong)uVar7 + (longlong)param_3;
  if (PTR_PTR_180d0fac8 == (undefined *)0x0) {
                    /* WARNING: Subroutine does not return */
    FUN_18096ee50();
  }
  (**(code **)(*(longlong *)PTR_PTR_180d0fac8 + 0x10))(PTR_PTR_180d0fac8,&local_78,&local_68);
  local_68 = local_78;
  uStack_60 = uStack_70;
  puVar9 = (undefined4 *)FUN_180433ef0(uVar4,local_88,&local_68);
  local_a0 = (ulonglong)uVar6 + (longlong)param_3;
  local_a8 = uVar2;
  local_98 = uVar10;
  local_90 = uVar1;
  FUN_180434f70(param_2,*(undefined8 *)(param_1 + 0x480),*puVar9,uVar3);
  return param_2;
}

