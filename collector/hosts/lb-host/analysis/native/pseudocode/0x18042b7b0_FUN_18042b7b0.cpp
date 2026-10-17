// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042b7b0; descriptive alias: FUN_18042b7b0
// Evidence: ev_c186b3308364b6eb01da4927f3eb3dd07c59caaa8e4efb18e2fa38de0a418692
// Original Evidence: rea-collector/0x18042b7b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __chkstk replaced with injection: alloca_probe */
/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8
FUN_18042b7b0(longlong param_1,ulonglong param_2,undefined4 param_3,longlong param_4,uint param_5)

{
  ulonglong uVar1;
  longlong lVar2;
  ulonglong uVar3;
  undefined1 *puVar4;
  bool bVar5;
  char cVar6;
  undefined8 uVar7;
  float *pfVar8;
  float *pfVar9;
  uint uVar10;
  ulonglong uVar11;
  longlong lVar12;
  float *pfVar13;
  longlong lVar14;
  uint uVar15;
  float *pfVar16;
  uint uVar17;
  float fVar18;
  longlong lVar19;
  ulonglong *puVar20;
  ulonglong *puVar21;
  float fVar22;
  float fVar23;
  undefined1 auVar24 [16];
  undefined1 auVar26 [64];
  undefined4 uVar27;
  undefined1 auVar28 [16];
  undefined1 auVar30 [64];
  float fVar31;
  undefined1 auVar32 [64];
  undefined1 auStack_29c8 [32];
  uint local_29a8;
  float local_2998;
  float local_2994;
  float local_2990 [3];
  undefined4 local_2984;
  longlong local_2980;
  longlong local_2978;
  undefined1 local_2970 [16];
  undefined8 local_2960;
  undefined1 local_2958 [16];
  undefined8 local_2948;
  float local_2938 [544];
  float local_20b8 [512];
  float local_18b8 [512];
  short local_10b8 [1024];
  float local_8b8 [512];
  ulonglong local_b8;
  undefined8 local_48;
  undefined1 auVar25 [64];
  undefined1 auVar29 [64];
  
  local_48 = 0x18042b7cf;
  local_b8 = DAT_180d06cc0 ^ (ulonglong)auStack_29c8;
  local_2938[0] = 0.0;
  local_2938[1] = 0.0;
  local_2938[2] = 0.0;
  local_2938[3] = 0.0;
  local_2938[4] = 0.0;
  local_2938[5] = 0.0;
  local_2938[6] = 0.0;
  local_2938[7] = 0.0;
  local_2938[8] = 0.0;
  local_2938[9] = 0.0;
  local_2938[10] = 0.0;
  local_2938[0xb] = 0.0;
  local_2938[0xc] = 0.0;
  local_2938[0xd] = 0.0;
  local_2938[0xe] = 0.0;
  local_2938[0xf] = 0.0;
  local_2938[0x10] = 0.0;
  local_2938[0x11] = 0.0;
  local_2938[0x12] = 0.0;
  local_2938[0x13] = 0.0;
  local_2938[0x14] = 0.0;
  local_2938[0x15] = 0.0;
  local_2938[0x16] = 0.0;
  local_2938[0x17] = 0.0;
  local_2938[0x18] = 0.0;
  local_2938[0x19] = 0.0;
  local_2938[0x1a] = 0.0;
  local_2938[0x1b] = 0.0;
  local_2938[0x1c] = 0.0;
  local_2938[0x1d] = 0.0;
  local_2938[0x1e] = 0.0;
  local_2938[0x1f] = 0.0;
  local_2970 = (undefined1  [16])0x0;
  local_2960 = 0;
  local_2958 = (undefined1  [16])0x0;
  local_2948 = 0;
  if ((((param_5 < 0x10) && (uVar11 = *(ulonglong *)(param_1 + 0x60), uVar11 != 0)) &&
      (param_2 <= ~uVar11)) &&
     ((local_2978 = param_4, cVar6 = FUN_1801fa260(param_2), cVar6 != '\0' &&
      (cVar6 = FUN_1801fa260((param_2 - 1) + uVar11), cVar6 != '\0')))) {
    FUN_1809bf2f0(local_2938,param_2,uVar11);
    lVar19 = *(longlong *)
              ((longlong)local_2938 + ((ulonglong)(DAT_180d6b8c8 + 0xe6632e3a) ^ 0x11bf48c));
    uVar17 = DAT_180d6b8cc + 0xe6632e3a;
    if (((lVar19 == 0) ||
        (cVar6 = FUN_1804287f0(lVar19,local_2970,*(undefined8 *)(param_1 + 0x68)), cVar6 != '\0'))
       && ((lVar19 = *(longlong *)((longlong)local_2938 + ((ulonglong)uVar17 ^ 0x11bf48c)),
           lVar19 == 0 ||
           (cVar6 = FUN_1804287f0(lVar19,local_2958,*(undefined8 *)(param_1 + 0x68)), cVar6 != '\0')
           ))) {
      fVar18 = (*(float *)((longlong)local_2938 +
                          ((ulonglong)(DAT_180d6b8d4 + 0xe6632e3a) ^ 0x11bf48c)) -
               *(float *)((longlong)local_2938 +
                         ((ulonglong)(DAT_180d6b8d8 + 0xe6632e3a) ^ 0x11bf48c))) *
               *(float *)((longlong)local_2938 +
                         ((ulonglong)(DAT_180d6b8dc + 0xe6632e3a) ^ 0x11bf48c));
      local_2994 = *(float *)(local_2970 + ((ulonglong)(DAT_180d6b8ec + 0xe6632e3a) ^ 0x11bf48c));
      fVar22 = *(float *)(local_2958 + ((ulonglong)(DAT_180d6b8f0 + 0xe6632e3a) ^ 0x11bf48c));
      if (((uint)fVar18 & 0x7f800000) != 0x7f800000) {
        auVar24._0_12_ = ZEXT812(0);
        auVar24._12_4_ = 0;
        auVar25 = ZEXT1664(auVar24);
        if (0.0 <= fVar18) {
          uVar11 = (ulonglong)(DAT_180d6b8e8 + 0xe6632e3a) ^ 0x11bf48c;
          lVar19 = *(longlong *)(local_2970 + uVar11);
          if (((lVar19 == 0) ||
              ((((uint)local_2994 & 0x7f800000) != 0x7f800000 && (0.0 <= local_2994)))) &&
             ((lVar2 = *(longlong *)(local_2958 + uVar11), lVar2 == 0 ||
              ((((uint)fVar22 & 0x7f800000) != 0x7f800000 && (0.0 <= fVar22)))))) {
            auVar30 = ZEXT464(0x3f800000);
            if (lVar19 == 0) {
              auVar32 = ZEXT864(0);
            }
            else if (0.0 < local_2994) {
              auVar24 = vmaxss_avx(ZEXT416((uint)(1.0 - fVar18 / local_2994)),auVar24);
              auVar32 = ZEXT1664(auVar24);
            }
            else {
              auVar32 = ZEXT864(0);
            }
            if (lVar2 == 0) {
              auVar26 = ZEXT1264(ZEXT812(0));
            }
            else if (0.0 < fVar22) {
              auVar24 = vminss_avx(ZEXT416((uint)(fVar18 / fVar22)),auVar30._0_16_);
              auVar26 = ZEXT1664(auVar24);
            }
            else {
              auVar26 = ZEXT1664(auVar30._0_16_);
            }
            local_2998 = fVar22;
            local_2980 = lVar19;
            if ((auVar32._0_4_ == 0.0) && (auVar26._0_4_ == 1.0)) {
              local_29a8 = param_5;
              uVar7 = FUN_18042a480(param_1,lVar2,param_3,local_2978);
              return uVar7;
            }
            FUN_1809bef30(local_18b8,0,0x800);
            FUN_1809bef30(local_20b8,0,0x800);
            uVar17 = *(uint *)(*(longlong *)(param_1 + 0x70) + 4);
            *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
            if (lVar19 != 0) {
              local_29a8 = param_5;
              cVar6 = FUN_18042a480(param_1,lVar19,param_3,local_18b8);
              if (cVar6 == '\0') {
                return 0;
              }
            }
            local_2984 = *(undefined4 *)(param_1 + 0x78);
            local_2994 = *(float *)(*(longlong *)(param_1 + 0x70) + 4);
            *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
            if (lVar2 != 0) {
              local_29a8 = param_5;
              cVar6 = FUN_18042a480(param_1,lVar2,param_3,local_20b8);
              if (cVar6 == '\0') {
                return 0;
              }
            }
            fVar18 = *(float *)(param_1 + 0x78);
            fVar23 = auVar26._0_4_ + auVar32._0_4_;
            if (fVar23 <= auVar25._0_4_) {
              auVar28._0_12_ = ZEXT812(0);
              auVar28._12_4_ = 0;
            }
            else {
              auVar28._0_4_ = auVar26._0_4_ / fVar23;
              auVar28._4_12_ = auVar26._4_12_;
            }
            auVar29 = ZEXT1664(auVar28);
            local_2998 = fVar18;
            if (auVar28._0_4_ == 0.0) {
              FUN_1809bef30(local_2938 + 0x20,0,0x800);
            }
            else {
              pfVar8 = local_2938 + 0x20;
              lVar12 = 0x200;
              do {
                *pfVar8 = auVar28._0_4_;
                pfVar8 = pfVar8 + 1;
                lVar12 = lVar12 + -1;
              } while (lVar12 != 0);
            }
            uVar27 = auVar29._0_4_;
            pfVar8 = (float *)0x0;
            if (((auVar32._0_4_ <= auVar25._0_4_) || (auVar26._0_4_ <= auVar25._0_4_)) ||
               (*(char *)((longlong)local_2938 +
                         ((ulonglong)(DAT_180d6b8e0 + 0xe6632e3a) ^ 0x11bf48c)) == '\0')) {
              bVar5 = false;
LAB_18042be9f:
              fVar22 = auVar26._0_4_;
              fVar23 = auVar30._0_4_;
              fVar31 = auVar32._0_4_;
              pfVar16 = local_2938 + 0x20;
              if (!bVar5) {
                pfVar16 = pfVar8;
              }
              puVar4 = *(undefined1 **)(param_1 + 0x70);
              uVar10 = *(uint *)(puVar4 + 0xc);
              if (uVar10 < 0x80) {
                *(uint *)(puVar4 + 0xc) = uVar10 + 1;
                *(uint *)(param_1 + 0x78) = uVar10;
                lVar14 = (longlong)(int)uVar10 * 0x1014;
                lVar12 = *(longlong *)(param_1 + 0x70);
                *(undefined4 *)(lVar14 + 0x21018 + lVar12) = 0xffffffff;
                *(undefined4 *)(lVar14 + 0x2101c + lVar12) = local_2984;
                *(float *)(lVar14 + 0x21020 + lVar12) = fVar18;
                *(undefined4 *)(lVar14 + 0x21024 + lVar12) = uVar27;
                *(bool *)(lVar14 + 0x21028 + lVar12) = pfVar16 != (float *)0x0;
                *(undefined2 *)(lVar14 + 0x21029 + lVar12) = 0;
                if (pfVar16 != (float *)0x0) {
                  FUN_1809bf2f0(lVar14 + lVar12 + 0x2102c,pfVar16,0x800);
                  fVar22 = auVar26._0_4_;
                  fVar23 = auVar30._0_4_;
                  fVar31 = auVar32._0_4_;
                }
                lVar12 = *(longlong *)(param_1 + 0x70);
                uVar10 = *(uint *)(lVar12 + 4);
                for (fVar18 = local_2994; (uint)fVar18 < uVar10; fVar18 = (float)((int)fVar18 + 1))
                {
                  if (*(int *)(lVar12 + 8) != 0) {
                    pfVar16 = pfVar8;
                    do {
                      lVar14 = (ulonglong)(uint)fVar18 * 0x820 + 0x838 + (longlong)pfVar16 * 4;
                      *(float *)(lVar12 + lVar14) =
                           local_2938[(longlong)(pfVar16 + 8)] * *(float *)(lVar12 + lVar14);
                      uVar15 = (int)pfVar16 + 1;
                      pfVar16 = (float *)(ulonglong)uVar15;
                      lVar12 = *(longlong *)(param_1 + 0x70);
                    } while (uVar15 < *(uint *)(lVar12 + 8));
                  }
                }
                if (*(int *)(lVar12 + 8) != 0) {
                  do {
                    if ((lVar19 == 0) || (lVar2 == 0)) {
                      fVar18 = fVar22 * local_20b8[(longlong)pfVar8] +
                               fVar31 * local_18b8[(longlong)pfVar8];
                    }
                    else {
                      fVar18 = (local_20b8[(longlong)pfVar8] - local_18b8[(longlong)pfVar8]) *
                               fVar22 + local_18b8[(longlong)pfVar8];
                    }
                    *(float *)((longlong)pfVar8 * 4 + local_2978) = fVar18;
                    local_2938[(longlong)(pfVar8 + 8)] = fVar23 - local_2938[(longlong)(pfVar8 + 8)]
                    ;
                    uVar10 = (int)pfVar8 + 1;
                    pfVar8 = (float *)(ulonglong)uVar10;
                    lVar12 = *(longlong *)(param_1 + 0x70);
                  } while (uVar10 < *(uint *)(lVar12 + 8));
                }
                for (; uVar17 < (uint)local_2994; uVar17 = uVar17 + 1) {
                  if (*(int *)(lVar12 + 8) != 0) {
                    uVar10 = 0;
                    do {
                      lVar19 = (ulonglong)uVar17 * 0x820 + 0x838 + (ulonglong)uVar10 * 4;
                      *(float *)(lVar12 + lVar19) =
                           local_2938[(ulonglong)uVar10 + 0x20] * *(float *)(lVar12 + lVar19);
                      uVar10 = uVar10 + 1;
                      lVar12 = *(longlong *)(param_1 + 0x70);
                    } while (uVar10 < *(uint *)(lVar12 + 8));
                  }
                }
                return 1;
              }
              *puVar4 = 3;
              goto LAB_18042c088;
            }
            lVar19 = *(longlong *)
                      ((longlong)local_2938 + ((ulonglong)(DAT_180d6b8d0 + 0xe6632e3a) ^ 0x11bf48c))
            ;
            FUN_1809bef30(local_8b8,0,0x800);
            FUN_1809bef30(local_10b8,0,0x800);
            puVar21 = (ulonglong *)(((ulonglong)(DAT_180d6b8f4 + 0xe6632e3a) ^ 0x11bf48c) + lVar19);
            if (((puVar21 < (ulonglong *)0xfffffffffffffff8) &&
                (cVar6 = FUN_1801fa260(puVar21), cVar6 != '\0')) &&
               ((cVar6 = FUN_1801fa260((longlong)puVar21 + 7), cVar6 != '\0' &&
                (puVar20 = (ulonglong *)
                           (lVar19 + ((ulonglong)(DAT_180d6b8f8 + 0xe6632e3a) ^ 0x11bf48c)),
                puVar20 < (ulonglong *)0xfffffffffffffff8)))) {
              uVar11 = *puVar21;
              cVar6 = FUN_1801fa260(puVar20);
              if (((cVar6 != '\0') && (cVar6 = FUN_1801fa260((longlong)puVar20 + 7), cVar6 != '\0'))
                 && ((uVar10 = *(uint *)(*(longlong *)(param_1 + 0x70) + 8), uVar10 != 0 &&
                     (uVar1 = (ulonglong)uVar10 * 4, uVar11 <= ~uVar1)))) {
                uVar3 = *puVar20;
                cVar6 = FUN_1801fa260(uVar11);
                if ((cVar6 != '\0') && (cVar6 = FUN_1801fa260((uVar1 - 1) + uVar11), cVar6 != '\0'))
                {
                  FUN_1809bf2f0(local_8b8,uVar11,uVar1);
                  uVar10 = *(uint *)(*(longlong *)(param_1 + 0x70) + 8);
                  if ((uVar10 != 0) &&
                     (((uVar11 = (ulonglong)uVar10 * 4, uVar3 <= ~uVar11 &&
                       (cVar6 = FUN_1801fa260(uVar3), cVar6 != '\0')) &&
                      (cVar6 = FUN_1801fa260((uVar11 - 1) + uVar3), cVar6 != '\0')))) {
                    FUN_1809bf2f0(local_10b8,uVar3,uVar11);
                    uVar27 = auVar29._0_4_;
                    fVar18 = *(float *)((longlong)local_2938 +
                                       ((ulonglong)(DAT_180d6b8e4 + 0xe6632e3a) ^ 0x11bf48c));
                    if (((((uint)fVar18 & 0x7f800000) != 0x7f800000) &&
                        (fVar23 = auVar25._0_4_, fVar23 < fVar18)) &&
                       (fVar22 = *(float *)((longlong)local_2938 +
                                           ((ulonglong)(DAT_180d6b8d4 + 0xe6632e3a) ^ 0x11bf48c)) /
                                 fVar22, ((uint)fVar22 & 0x7f800000) != 0x7f800000)) {
                      puVar4 = *(undefined1 **)(param_1 + 0x70);
                      uVar10 = *(uint *)(puVar4 + 8);
                      pfVar16 = pfVar8;
                      if (uVar10 != 0) {
                        do {
                          if ((ushort)(local_10b8[(longlong)pfVar16 * 2] - 1U) < 0xfffe) {
                            if (((uint)local_8b8[(longlong)pfVar16] & 0x7f800000) == 0x7f800000) {
                              *puVar4 = 3;
                              goto LAB_18042c088;
                            }
                            local_2990[2] = auVar30._0_4_;
                            local_2990[0] = fVar23;
                            local_2990[1] =
                                 (fVar22 - (local_8b8[(longlong)pfVar16] - fVar18)) / fVar18;
                            pfVar13 = local_2990;
                            if (fVar23 <= local_2990[1]) {
                              pfVar13 = local_2990 + 1;
                            }
                            pfVar9 = local_2990 + 2;
                            if (local_2990[1] <= auVar30._0_4_) {
                              pfVar9 = pfVar13;
                            }
                            local_2938[(longlong)(pfVar16 + 8)] = *pfVar9;
                          }
                          uVar15 = (int)pfVar16 + 1;
                          pfVar16 = (float *)(ulonglong)uVar15;
                        } while (uVar15 < uVar10);
                      }
                      bVar5 = true;
                      lVar19 = local_2980;
                      fVar18 = local_2998;
                      goto LAB_18042be9f;
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  **(undefined1 **)(param_1 + 0x70) = 3;
LAB_18042c088:
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  return 0;
}

