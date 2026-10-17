// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042b070; descriptive alias: FUN_18042b070
// Evidence: ev_3cbce049df4120c6f57b62e6c167f240750747ce8031d3adc7b079c8ade5462f
// Original Evidence: rea-collector/0x18042b070.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

ulonglong FUN_18042b070(longlong param_1,longlong param_2,ulonglong param_3,undefined8 param_4,
                       undefined4 param_5,float *param_6,char param_7)

{
  undefined8 *puVar1;
  float fVar2;
  uint uVar3;
  int iVar4;
  undefined4 uVar5;
  ulonglong uVar6;
  undefined1 *puVar7;
  undefined1 auVar8 [16];
  uint uVar9;
  char cVar10;
  longlong lVar11;
  undefined8 *puVar12;
  float *pfVar13;
  longlong lVar14;
  longlong *plVar15;
  ulonglong uVar16;
  longlong lVar17;
  float fVar18;
  undefined1 in_ZMM3 [64];
  float fVar19;
  undefined1 auVar20 [64];
  float fVar21;
  float fVar22;
  undefined1 auVar23 [16];
  undefined1 auVar24 [64];
  undefined1 auStack_198 [32];
  longlong local_178;
  char local_170;
  float *local_168;
  undefined8 local_160;
  longlong lStack_158;
  ulonglong uStack_150;
  undefined8 uStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  float local_128 [40];
  ulonglong local_88;
  
  local_88 = DAT_180d06cc0 ^ (ulonglong)auStack_198;
  auVar24 = ZEXT1664(in_ZMM3._0_16_);
  local_168 = param_6;
  local_178 = param_2;
  FUN_1809bef30(local_128,0);
  if ((((*(uint *)(*(longlong *)(param_1 + 0x70) + 4) < 0x40) &&
       (uVar6 = *(ulonglong *)(param_1 + 0x30), uVar6 != 0)) && (param_3 <= ~uVar6)) &&
     ((cVar10 = FUN_1801fa260(param_3), cVar10 != '\0' &&
      (cVar10 = FUN_1801fa260((param_3 - 1) + uVar6), cVar10 != '\0')))) {
    FUN_1809bf2f0(local_128,param_3);
    fVar2 = *(float *)((longlong)local_128 + ((ulonglong)(DAT_180d6b860 + 0xe6632e3a) ^ 0x11bf48c));
    uVar3 = *(uint *)((longlong)local_128 + ((ulonglong)(DAT_180d6b868 + 0xe6632e3a) ^ 0x11bf48c));
    auVar23._0_12_ = ZEXT812(0);
    auVar23._12_4_ = 0;
    fVar21 = 1.0;
    fVar19 = 1e+06;
    fVar18 = *(float *)((longlong)local_128 + ((ulonglong)(DAT_180d6b86c + 0xe6632e3a) ^ 0x11bf48c))
    ;
    if (fVar18 < 0.0) {
      local_160 = 0;
      lStack_158 = 0;
      uStack_150 = 0;
      uStack_148 = 0;
      uStack_140 = 0;
      uStack_138 = 0;
      uVar6 = *(ulonglong *)
               ((longlong)local_128 + ((ulonglong)(DAT_180d6b864 + 0xe6632e3a) ^ 0x11bf48c));
      plVar15 = (longlong *)(((ulonglong)(DAT_180d6b878 + 0xe6632e3a) ^ 0x11bf48c) + uVar6);
      if (plVar15 < (longlong *)0xfffffffffffffff8) {
        auVar20 = ZEXT1664(auVar23);
        auVar24 = ZEXT1664(auVar24._0_16_);
        fVar19 = 1e+06;
        cVar10 = FUN_1801fa260(plVar15);
        if (((cVar10 != '\0') && (cVar10 = FUN_1801fa260((longlong)plVar15 + 7), cVar10 != '\0')) &&
           ((plVar15 = (longlong *)
                       (((ulonglong)(DAT_180d6b87c + 0xe6632e3a) ^ 0x11bf48c) + *plVar15),
            plVar15 < (longlong *)0xfffffffffffffff8 &&
            ((cVar10 = FUN_1801fa260(plVar15), cVar10 != '\0' &&
             (cVar10 = FUN_1801fa260((longlong)plVar15 + 7), cVar10 != '\0')))))) {
          lVar17 = *plVar15;
          lVar11 = FUN_1801f3090(&DAT_180d6cf38);
          if (lVar17 == lVar11) {
            uVar9 = DAT_180d6b880 + 0xe6632e3aU;
            if (((ulonglong)(DAT_180d6b880 + 0xe6632e3aU) ^ 0x11bf48c) + 4 <
                ((ulonglong)(DAT_180d6b884 + 0xe6632e3aU) ^ 0x11bf48c) + 4) {
              uVar9 = DAT_180d6b884 + 0xe6632e3aU;
            }
            if (((uVar6 <= ~(((ulonglong)uVar9 ^ 0x11bf48c) + 4)) &&
                (cVar10 = FUN_1801fa260(uVar6), cVar10 != '\0')) &&
               (cVar10 = FUN_1801fa260(uVar6 + 3 + ((ulonglong)uVar9 ^ 0x11bf48c)), cVar10 != '\0'))
            {
              FUN_1809bf2f0(&local_160,uVar6);
              auVar23 = auVar20._0_16_;
              fVar18 = *(float *)((longlong)&local_160 +
                                 ((ulonglong)(DAT_180d6b884 + 0xe6632e3a) ^ 0x11bf48c)) *
                       *(float *)((longlong)&local_160 +
                                 ((ulonglong)(DAT_180d6b880 + 0xe6632e3a) ^ 0x11bf48c));
              if (((((uint)fVar18 & 0x7f800000) != 0x7f800000) && (fVar21 <= fVar18)) &&
                 (fVar18 <= fVar19)) {
                fVar18 = (float)(int)fVar18;
LAB_18042b406:
                fVar18 = fVar18 - fVar21;
                param_6 = local_168;
                goto LAB_18042b40f;
              }
            }
          }
          else {
            lVar11 = FUN_1801f3090(&DAT_180d6d3a8);
            if (lVar17 != lVar11) {
              **(undefined1 **)(param_1 + 0x70) = 2;
              goto LAB_18042b746;
            }
            uVar16 = (ulonglong)(DAT_180d6b888 + 0xe6632e3a) ^ 0x11bf48c;
            if (((uVar6 <= ~(uVar16 + 4)) && (cVar10 = FUN_1801fa260(uVar6), cVar10 != '\0')) &&
               (cVar10 = FUN_1801fa260(uVar16 + 3 + uVar6), cVar10 != '\0')) {
              FUN_1809bf2f0(&local_160,uVar6);
              auVar23 = auVar20._0_16_;
              iVar4 = *(int *)((longlong)&local_160 +
                              ((ulonglong)(DAT_180d6b888 + 0xe6632e3a) ^ 0x11bf48c));
              if (iVar4 - 2U < 1000000) {
                fVar18 = (float)(iVar4 - 1);
                goto LAB_18042b406;
              }
            }
          }
        }
      }
    }
    else {
LAB_18042b40f:
      auVar8 = vmaxss_avx(auVar23,ZEXT416(uVar3));
      fVar18 = (fVar18 - auVar8._0_4_) + fVar21;
      if (((((((uint)fVar18 & 0x7f800000) != 0x7f800000) &&
            (fVar22 = auVar23._0_4_, fVar22 < fVar18)) && (fVar18 <= fVar19)) &&
          ((((uint)fVar2 & 0x7f800000) != 0x7f800000 && (fVar22 < fVar2)))) &&
         ((((uint)auVar24._0_4_ & 0x7f800000) != 0x7f800000 && (fVar22 <= auVar24._0_4_)))) {
        fVar2 = (float)(int)fVar18 * fVar2;
        auVar20 = ZEXT464((uint)fVar2);
        if (((((uint)fVar2 & 0x7f800000) != 0x7f800000) && (fVar22 < fVar2)) &&
           ((fVar2 <= 3600.0 &&
            (cVar10 = FUN_18042a2b0(param_1,*(undefined8 *)
                                             ((longlong)local_128 +
                                             ((ulonglong)(DAT_180d6b85c + 0xe6632e3a) ^ 0x11bf48c)))
            , cVar10 != '\0')))) {
          puVar7 = *(undefined1 **)(param_1 + 0x70);
          uVar3 = *(uint *)(puVar7 + 0xc);
          if (uVar3 < 0x80) {
            uVar5 = *(undefined4 *)(puVar7 + 4);
            *(uint *)(puVar7 + 0xc) = uVar3 + 1;
            *(uint *)(param_1 + 0x78) = uVar3;
            lVar11 = (longlong)(int)uVar3 * 0x1014;
            lVar17 = *(longlong *)(param_1 + 0x70);
            *(undefined8 *)(lVar11 + 0x21018 + lVar17) = 0xffffffffffffffff;
            *(undefined4 *)(lVar11 + 0x21020 + lVar17) = 0xffffffff;
            *(undefined4 *)(lVar11 + 0x21024 + lVar17) = 0;
            *(undefined2 *)(lVar11 + 0x21028 + lVar17) = 0;
            *(undefined1 *)(lVar11 + 0x2102a + lVar17) = 0;
            *(undefined4 *)
             ((longlong)*(int *)(param_1 + 0x78) * 0x1014 + 0x21018 + *(longlong *)(param_1 + 0x70))
                 = uVar5;
            lVar17 = (longlong)*(int *)(param_1 + 0x78) * 0x1014 + *(longlong *)(param_1 + 0x70);
            uVar3 = *(uint *)(*(longlong *)(param_1 + 0x70) + 8);
            pfVar13 = param_6;
            if (uVar3 != 0) {
              do {
                if (*pfVar13 != fVar21) {
                  *(undefined1 *)(lVar17 + 0x21029) = 1;
                  FUN_1809bf2f0(lVar17 + 0x2182c,param_6,0x800);
                  goto LAB_18042b5e5;
                }
                pfVar13 = pfVar13 + 1;
              } while (pfVar13 != param_6 + uVar3);
            }
            *(undefined1 *)(lVar17 + 0x21029) = 0;
LAB_18042b5e5:
            lVar17 = *(longlong *)(param_1 + 0x70);
            uVar3 = *(uint *)(lVar17 + 4);
            *(uint *)(lVar17 + 4) = uVar3 + 1;
            lVar11 = (ulonglong)uVar3 * 0x820;
            uVar5 = *(undefined4 *)
                     ((longlong)local_128 + ((ulonglong)(DAT_180d6b858 + 0xe6632e3a) ^ 0x11bf48c));
            *(undefined4 *)(lVar11 + 0x820 + lVar17) = uVar5;
            if (0x7ff < *(ulonglong *)(param_1 + 0x82b0)) {
              FUN_18042c390(param_1 + 0x82a0);
            }
            local_160 = *(undefined8 *)(param_1 + 0x80);
            lStack_158 = local_178;
            uStack_148 = CONCAT44(param_5,uVar5);
            uStack_150 = param_3;
            FUN_18042cdc0(param_1 + 0x82a0,&local_178,&local_160,param_1 + 0x90);
            auVar23 = auVar24._0_16_;
            if (local_170 != '\0') {
              *(longlong *)(param_1 + 0x90) = *(longlong *)(param_1 + 0x90) + 1;
            }
            *(undefined8 *)(lVar11 + 0x818 + lVar17) = *(undefined8 *)(local_178 + 0x30);
            *(undefined4 *)(lVar11 + 0x824 + lVar17) = param_5;
            if (param_7 != '\0') {
              auVar23 = ZEXT416((uint)(auVar20._0_4_ * auVar24._0_4_));
            }
            auVar23 = vminss_avx(auVar20._0_16_,auVar23);
            *(int *)(lVar11 + 0x828 + lVar17) = auVar23._0_4_;
            *(float *)(lVar11 + 0x82c + lVar17) = auVar20._0_4_;
            *(undefined1 *)(lVar11 + 0x834 + lVar17) = 0;
            lVar14 = 0x20;
            puVar12 = (undefined8 *)(lVar17 + 0x838 + lVar11);
            do {
              *puVar12 = 0x3f8000003f800000;
              puVar12[1] = 0x3f8000003f800000;
              puVar12[2] = 0x3f8000003f800000;
              puVar1 = puVar12 + 8;
              puVar12[3] = 0x3f8000003f800000;
              puVar12[4] = 0x3f8000003f800000;
              puVar12[5] = 0x3f8000003f800000;
              puVar12[6] = 0x3f8000003f800000;
              puVar12[7] = 0x3f8000003f800000;
              lVar14 = lVar14 + -1;
              puVar12 = puVar1;
            } while (lVar14 != 0);
            return CONCAT71((int7)((ulonglong)puVar1 >> 8),1);
          }
          *puVar7 = 3;
          goto LAB_18042b746;
        }
      }
    }
  }
  **(undefined1 **)(param_1 + 0x70) = 3;
LAB_18042b746:
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  uVar6 = *(ulonglong *)(param_1 + 0x70);
  *(undefined4 *)(uVar6 + 0x10) = 0;
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  return uVar6 & 0xffffffffffffff00;
}

