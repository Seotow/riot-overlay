// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180428870; descriptive alias: FUN_180428870
// Evidence: ev_618163b9fac201c8dc2199427893c845226a3401bd70e64bad9ab839ff67d310
// Original Evidence: rea-collector/0x180428870.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

ulonglong FUN_180428870(longlong param_1,float param_2,char param_3,uint param_4,ulonglong param_5,
                       ulonglong param_6)

{
  float fVar1;
  undefined1 auVar2 [32];
  int iVar3;
  uint uVar4;
  ulonglong uVar5;
  ulonglong uVar6;
  bool bVar7;
  float fVar8;
  undefined1 auVar9 [16];
  undefined1 auVar10 [16];
  
  uVar5 = FUN_1809bef30(param_6,0,0x800);
  if (((0x200 < param_4) ||
      (uVar4 = (uint)param_2 & 0x7f800000,
      uVar5 = (ulonglong)CONCAT31((int3)(uVar4 >> 8),uVar4 != 0x7f800000), uVar4 == 0x7f800000)) ||
     (param_2 < 0.0)) {
LAB_180428aca:
    return uVar5 & 0xffffffffffffff00;
  }
  uVar6 = 0;
  if (param_4 != 0) {
    do {
      fVar8 = *(float *)(param_1 + uVar6 * 4);
      if (((((uint)fVar8 & 0x7f800000) == 0x7f800000) || (fVar8 < 0.0)) ||
         ((fVar1 = *(float *)(param_5 + uVar6 * 4), ((uint)fVar1 & 0x7f800000) == 0x7f800000 ||
          (fVar1 < 0.0)))) {
LAB_180428aba:
        uVar5 = FUN_1809bef30(param_6,0,0x800);
        goto LAB_180428aca;
      }
      fVar8 = fVar8 * param_2;
      bVar7 = ((uint)fVar8 & 0x7f800000) != 0x7f800000;
      uVar5 = (ulonglong)CONCAT31((int3)(((uint)fVar8 & 0x7f800000) >> 8),bVar7);
      if (!bVar7) goto LAB_180428aba;
      if ((bool)param_3 != bVar7) {
        auVar9 = vminss_avx(ZEXT416((uint)fVar1),ZEXT416((uint)fVar8));
        fVar8 = auVar9._0_4_;
      }
      *(float *)(param_6 + uVar6 * 4) = fVar8;
      uVar4 = (int)uVar6 + 1;
      uVar6 = (ulonglong)uVar4;
    } while (uVar4 < param_4);
  }
  if ((param_3 != '\0') || (param_4 == 0)) goto LAB_180428ab6;
  uVar6 = 0;
  if (1 < param_4) {
    uVar5 = param_6 + (ulonglong)(param_4 - 1) * 4;
    if ((uVar5 < param_5) || (uVar5 = param_5 + (ulonglong)(param_4 - 1) * 4, uVar5 < param_6)) {
      if (param_4 < 0x20) {
LAB_180428a13:
        do {
          auVar9._8_8_ = 0;
          auVar9._0_8_ = *(ulonglong *)(param_5 + uVar6 * 4);
          auVar10._8_8_ = 0;
          auVar10._0_8_ = *(ulonglong *)(param_6 + uVar6 * 4);
          auVar9 = vsubps_avx(auVar9,auVar10);
          *(longlong *)(param_5 + uVar6 * 4) = auVar9._0_8_;
          uVar4 = (int)uVar6 + 2;
          uVar6 = (ulonglong)uVar4;
        } while (uVar4 < (param_4 & 0xfffffffe));
      }
      else {
        do {
          auVar2 = vsubps_avx(*(undefined1 (*) [32])(param_5 + uVar6 * 4),
                              *(undefined1 (*) [32])(param_6 + uVar6 * 4));
          iVar3 = (int)uVar6;
          uVar5 = (ulonglong)(iVar3 + 8);
          *(undefined1 (*) [32])(param_5 + uVar6 * 4) = auVar2;
          auVar2 = vsubps_avx(*(undefined1 (*) [32])(param_5 + uVar5 * 4),
                              *(undefined1 (*) [32])(param_6 + uVar5 * 4));
          *(undefined1 (*) [32])(param_5 + uVar5 * 4) = auVar2;
          uVar5 = (ulonglong)(iVar3 + 0x10);
          auVar2 = vsubps_avx(*(undefined1 (*) [32])(param_5 + uVar5 * 4),
                              *(undefined1 (*) [32])(param_6 + uVar5 * 4));
          *(undefined1 (*) [32])(param_5 + uVar5 * 4) = auVar2;
          uVar5 = (ulonglong)(iVar3 + 0x18);
          uVar6 = (ulonglong)(iVar3 + 0x20U);
          auVar2 = vsubps_avx(*(undefined1 (*) [32])(param_5 + uVar5 * 4),
                              *(undefined1 (*) [32])(param_6 + uVar5 * 4));
          *(undefined1 (*) [32])(param_5 + uVar5 * 4) = auVar2;
        } while (iVar3 + 0x20U < (param_4 & 0xffffffe0));
        if ((param_4 & 0x1e) != 0) goto LAB_180428a13;
      }
      if (param_4 <= (uint)uVar6) goto LAB_180428ab6;
    }
  }
  uVar4 = param_4 - (int)uVar6;
  uVar5 = (ulonglong)uVar4;
  if (3 < uVar4) {
    do {
      iVar3 = (int)uVar6;
      uVar5 = (ulonglong)(iVar3 + 1);
      fVar8 = *(float *)(param_5 + uVar5 * 4);
      *(float *)(param_5 + uVar6 * 4) =
           *(float *)(param_5 + uVar6 * 4) - *(float *)(param_6 + uVar6 * 4);
      *(float *)(param_5 + uVar5 * 4) = fVar8 - *(float *)(param_6 + uVar5 * 4);
      uVar5 = (ulonglong)(iVar3 + 2);
      *(float *)(param_5 + uVar5 * 4) =
           *(float *)(param_5 + uVar5 * 4) - *(float *)(param_6 + uVar5 * 4);
      uVar5 = (ulonglong)(iVar3 + 3);
      uVar4 = iVar3 + 4;
      uVar6 = (ulonglong)uVar4;
      *(float *)(param_5 + uVar5 * 4) =
           *(float *)(param_5 + uVar5 * 4) - *(float *)(param_6 + uVar5 * 4);
    } while (uVar4 < param_4 - 3);
    if (param_4 <= uVar4) goto LAB_180428ab6;
  }
  do {
    *(float *)(param_5 + uVar6 * 4) =
         *(float *)(param_5 + uVar6 * 4) - *(float *)(param_6 + uVar6 * 4);
    uVar4 = (int)uVar6 + 1;
    uVar6 = (ulonglong)uVar4;
  } while (uVar4 < param_4);
LAB_180428ab6:
  return CONCAT71((int7)(uVar5 >> 8),1);
}

