// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042a480; descriptive alias: FUN_18042a480
// Evidence: ev_773f45fa8d52b7c7384b9fc069c5d8f12c6e9154bf435c1178ba7d86d4820de9
// Original Evidence: rea-collector/0x18042a480.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
FUN_18042a480(longlong param_1,longlong *param_2,undefined4 param_3,undefined8 param_4,uint param_5)

{
  float fVar1;
  int iVar2;
  char cVar3;
  uint uVar4;
  uint uVar5;
  uint uVar6;
  longlong lVar7;
  undefined8 uVar8;
  longlong lVar9;
  ulonglong uVar10;
  float *pfVar11;
  ulonglong *puVar12;
  ulonglong uVar13;
  uint *puVar14;
  longlong *plVar15;
  uint uVar16;
  uint uVar17;
  ulonglong uVar18;
  ulonglong uVar19;
  undefined4 uVar20;
  float fVar21;
  undefined1 auVar22 [64];
  undefined1 auVar23 [64];
  undefined1 auVar24 [16];
  undefined1 auVar25 [64];
  undefined1 auVar26 [64];
  float fVar27;
  undefined1 auVar28 [64];
  undefined1 auStack_ca8 [32];
  undefined8 local_c88;
  float *local_c80;
  undefined1 local_c78;
  undefined4 local_c68;
  uint local_c64;
  uint local_c60;
  int local_c5c;
  uint local_c58;
  uint local_c54;
  uint local_c50;
  uint local_c4c;
  longlong *local_c48;
  ulonglong local_c40;
  ulonglong local_c38;
  undefined8 local_c30;
  undefined8 local_c28;
  undefined1 local_c20 [16];
  undefined1 local_c10 [16];
  undefined8 local_c00;
  float local_bf8 [40];
  uint local_b58 [40];
  longlong local_ab8 [64];
  float local_8b8 [512];
  ulonglong local_b8;
  
  local_b8 = DAT_180d06cc0 ^ (ulonglong)auStack_ca8;
  local_c68 = param_3;
  local_c48 = param_2;
  local_c30 = param_4;
  if (param_2 == (longlong *)0x0) {
    FUN_1809bef30(param_4,0,0x800);
    uVar8 = 1;
    goto LAB_18042b015;
  }
  if (((((param_5 < 0x10) &&
        (*(int *)(param_1 + 0x98) = *(int *)(param_1 + 0x98) + 1, *(uint *)(param_1 + 0x98) < 0x101)
        ) && (lVar9 = param_1 + ((ulonglong)param_5 + 0x14) * 8,
             lVar7 = thunk_FUN_1809700d0(param_1 + 0xa0,lVar9,param_2), lVar7 == lVar9)) &&
      ((*(longlong **)(param_1 + 0xa0 + (ulonglong)param_5 * 8) = param_2,
       param_2 < (longlong *)0xfffffffffffffff8 && (cVar3 = FUN_1801fa260(param_2), cVar3 != '\0')))
      ) && (cVar3 = FUN_1801fa260((longlong)param_2 + 7), cVar3 != '\0')) {
    lVar9 = *param_2;
    lVar7 = FUN_1801f3090(&DAT_180d6bd78);
    if (lVar9 == lVar7) {
      FUN_1809bef30(local_b58,0,0xa0);
      uVar13 = *(ulonglong *)(param_1 + 0x28);
      if (((uVar13 != 0) && (param_2 <= (longlong *)~uVar13)) &&
         ((cVar3 = FUN_1801fa260(param_2), cVar3 != '\0' &&
          (cVar3 = FUN_1801fa260((longlong)param_2 + (uVar13 - 1)), cVar3 != '\0')))) {
        FUN_1809bf2f0(local_b58,param_2,uVar13);
        local_c78 = 0;
        local_c88 = CONCAT44(local_c88._4_4_,param_3);
        local_c80 = (float *)param_4;
        uVar8 = FUN_18042b070(param_1,param_2,
                              *(undefined8 *)
                               ((longlong)local_b58 +
                               ((ulonglong)(DAT_180d6b854 + 0xe6632e3a) ^ 0x11bf48c)),
                              *(undefined4 *)
                               ((longlong)local_b58 +
                               ((ulonglong)(DAT_180d6b850 + 0xe6632e3a) ^ 0x11bf48c)));
        return uVar8;
      }
      goto LAB_18042aff1;
    }
    lVar7 = FUN_1801f3090(&DAT_180d6c1e8);
    if (lVar9 == lVar7) {
      local_c88 = CONCAT44(local_c88._4_4_,param_5 + 1);
      uVar8 = FUN_18042b7b0(param_1,(ulonglong)(DAT_180d6b84c + 0xe6632e3aU ^ 0x11bf48c) +
                                    (longlong)param_2,param_3,param_4);
      return uVar8;
    }
    lVar7 = FUN_1801f3090(&DAT_180d6c658);
    if (lVar9 == lVar7) {
      FUN_1809bef30(local_bf8,0,0xa0);
      FUN_1809bef30(local_b58,0,0xa0);
      local_c10 = (undefined1  [16])0x0;
      local_c00 = 0;
      uVar13 = *(ulonglong *)(param_1 + 0x48);
      if ((((uVar13 != 0) && (param_2 <= (longlong *)~uVar13)) &&
          (cVar3 = FUN_1801fa260(param_2), cVar3 != '\0')) &&
         (cVar3 = FUN_1801fa260((longlong)param_2 + (uVar13 - 1)), cVar3 != '\0')) {
        FUN_1809bf2f0(local_bf8,param_2,uVar13);
        uVar13 = *(ulonglong *)(param_1 + 0x48);
        if (((uVar13 != 0) &&
            (uVar18 = *(ulonglong *)
                       ((longlong)local_bf8 + ((ulonglong)(DAT_180d6b854 + 0xe6632e3a) ^ 0x11bf48c))
            , uVar18 <= ~uVar13)) &&
           ((cVar3 = FUN_1801fa260(uVar18), cVar3 != '\0' &&
            (cVar3 = FUN_1801fa260((uVar13 - 1) + uVar18), cVar3 != '\0')))) {
          FUN_1809bf2f0(local_b58,uVar18,uVar13);
          if (DAT_180d3e830 == '\0') {
            uVar4 = DAT_180d3e3c8 + 0xe6632e3aU ^ 0x11bf48c;
          }
          else {
            uVar4 = FUN_18052b510(&DAT_180d3e3c8);
          }
          puVar12 = (ulonglong *)(*(longlong *)(param_1 + 0x80) + (ulonglong)uVar4);
          if ((((puVar12 < (ulonglong *)0xfffffffffffffff8) &&
               (cVar3 = FUN_1801fa260(puVar12), cVar3 != '\0')) &&
              ((cVar3 = FUN_1801fa260((longlong)puVar12 + 7), cVar3 != '\0' &&
               (((uVar13 = *(ulonglong *)(param_1 + 0x50), uVar13 != 0 &&
                 (uVar18 = *puVar12, uVar18 <= ~uVar13)) &&
                (cVar3 = FUN_1801fa260(uVar18), cVar3 != '\0')))))) &&
             (cVar3 = FUN_1801fa260((uVar13 - 1) + uVar18), cVar3 != '\0')) {
            FUN_1809bf2f0(local_c10,uVar18,uVar13);
            fVar21 = *(float *)((longlong)local_bf8 +
                               ((ulonglong)(DAT_180d6b894 + 0xe6632e3a) ^ 0x11bf48c));
            fVar1 = *(float *)((longlong)local_bf8 +
                              ((ulonglong)(DAT_180d6b898 + 0xe6632e3a) ^ 0x11bf48c));
            uVar4 = *(uint *)((longlong)local_b58 +
                             ((ulonglong)(DAT_180d6b8ac + 0xe6632e3a) ^ 0x11bf48c));
            if (uVar4 < 0x101) {
              uVar13 = (ulonglong)(DAT_180d6b88c + 0xe6632e3a) ^ 0x11bf48c;
              uVar17 = *(uint *)((longlong)local_bf8 + uVar13);
              if (uVar17 < uVar4) {
                uVar18 = (ulonglong)(DAT_180d6b890 + 0xe6632e3a) ^ 0x11bf48c;
                uVar16 = *(uint *)((longlong)local_bf8 + uVar18);
                if (((uVar16 < uVar4) &&
                    (auVar23 = ZEXT464((uint)fVar21), ((uint)fVar21 & 0x7f800000) != 0x7f800000)) &&
                   ((((fVar27 = 0.0, 0.0 <= fVar21 &&
                      ((auVar25 = ZEXT464(0x3f800000), fVar21 <= 1.0 &&
                       (auVar26 = ZEXT464((uint)fVar1), ((uint)fVar1 & 0x7f800000) != 0x7f800000))))
                     && (0.0 <= fVar1)) && (fVar1 <= 1.0)))) {
                  local_c28 = 0xffffffffffffffff;
                  uVar19 = 0;
                  uVar5 = (uVar17 != uVar16) + 1;
                  uVar4 = *(uint *)(local_c10 +
                                   ((ulonglong)(DAT_180d6b8b8 + 0xe6632e3a) ^ 0x11bf48c));
                  local_c64 = 0;
                  auVar28 = ZEXT464((uint)(1.0 - fVar21));
                  local_c5c = param_5 + 1;
                  uVar10 = uVar19;
                  uVar20 = local_c68;
                  local_c60 = uVar5;
                  local_c54 = uVar4;
                  local_c50 = uVar17;
                  local_c4c = uVar16;
                  local_c40 = uVar13;
                  local_c38 = uVar18;
                  do {
                    uVar6 = (uint)uVar10;
                    if (uVar17 == uVar16) {
                      auVar24 = auVar25._0_16_;
LAB_18042a9ec:
                      auVar22 = ZEXT1664(auVar24);
                      local_c20 = (undefined1  [16])0x0;
                      if (uVar6 == 0) {
                        uVar18 = uVar13;
                      }
                      puVar14 = (uint *)((ulonglong)*(uint *)((longlong)local_bf8 + uVar18) *
                                         ((ulonglong)(DAT_180d6b8b0 + 0xe6632e3a) ^ 0x11bf48c) +
                                         *(longlong *)
                                          ((longlong)local_b58 +
                                          ((ulonglong)(DAT_180d6b8a8 + 0xe6632e3a) ^ 0x11bf48c)) +
                                        ((ulonglong)(DAT_180d6b8b4 + 0xe6632e3a) ^ 0x11bf48c));
                      if ((((uint *)0xfffffffffffffffb < puVar14) ||
                          (cVar3 = FUN_1801fa260(puVar14), cVar3 == '\0')) ||
                         (cVar3 = FUN_1801fa260((longlong)puVar14 + 3), cVar3 == '\0'))
                      goto LAB_18042afbe;
                      uVar17 = *puVar14;
                      if ((((uVar4 <= uVar17) || (0x10000 < uVar4)) ||
                          ((uVar13 = *(ulonglong *)(param_1 + 0x58), uVar13 == 0 ||
                           ((uVar18 = *(longlong *)
                                       (local_c10 +
                                       ((ulonglong)(DAT_180d3e838 + 0xe6632e3a) ^ 0x11bf48c)) +
                                      ((ulonglong)(DAT_180d6b8bc + 0xe6632e3a) ^ 0x11bf48c) *
                                      (ulonglong)uVar17, ~uVar13 < uVar18 ||
                            (cVar3 = FUN_1801fa260(uVar18), cVar3 == '\0')))))) ||
                         (cVar3 = FUN_1801fa260((uVar13 - 1) + uVar18), cVar3 == '\0'))
                      goto LAB_18042afbe;
                      FUN_1809bf2f0(local_c20,uVar18,uVar13);
                      puVar12 = *(ulonglong **)
                                 (local_c20 + ((ulonglong)(DAT_180d6b8c0 + 0xe6632e3a) ^ 0x11bf48c))
                      ;
                      if ((((ulonglong *)0xfffffffffffffff7 < puVar12) ||
                          (cVar3 = FUN_1801fa260(puVar12), cVar3 == '\0')) ||
                         (cVar3 = FUN_1801fa260((longlong)puVar12 + 7), cVar3 == '\0'))
                      goto LAB_18042afbe;
                      uVar13 = *puVar12;
                      uVar4 = *(uint *)(*(longlong *)(param_1 + 0x70) + 4);
                      local_c58 = uVar4;
                      if (DAT_180d6cf30 == '\0') {
                        uVar18 = _DAT_180d6cac8 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
                      }
                      else {
                        uVar18 = FUN_18052c740(&DAT_180d6cac8,0);
                      }
                      uVar10 = uVar19;
                      if (uVar18 != 0) {
                        uVar10 = DAT_180d20bd0 + uVar18;
                      }
                      if (uVar13 == uVar10) {
                        local_c78 = 1;
                        local_c80 = local_8b8;
                        local_c88 = CONCAT44(local_c88._4_4_,uVar20);
                        cVar3 = FUN_18042b070(param_1,param_2,
                                              *(undefined8 *)
                                               (local_c20 +
                                               ((ulonglong)(DAT_180d6b8c0 + 0xe6632e3a) ^ 0x11bf48c)
                                               ),auVar26._0_8_);
                        fVar21 = auVar22._0_4_;
                      }
                      else {
                        uVar4 = *(uint *)((longlong)local_bf8 +
                                         ((ulonglong)(DAT_180d6b8a0 + 0xe6632e3a) ^ 0x11bf48c));
                        if (0x40 < uVar4) goto LAB_18042afbe;
                        FUN_1809bef30(local_ab8,0,0x200);
                        if (uVar4 != 0) {
                          uVar18 = *(ulonglong *)
                                    ((longlong)local_bf8 +
                                    ((ulonglong)(DAT_180d6b89c + 0xe6632e3a) ^ 0x11bf48c));
                          uVar13 = (ulonglong)uVar4 * 8;
                          if (((~uVar13 < uVar18) || (cVar3 = FUN_1801fa260(uVar18), cVar3 == '\0'))
                             || (cVar3 = FUN_1801fa260((uVar18 - 1) + uVar13), cVar3 == '\0'))
                          goto LAB_18042afbe;
                          FUN_1809bf2f0(local_ab8,uVar18,uVar13);
                        }
                        uVar13 = uVar19;
                        if (uVar4 == 0) goto LAB_18042afac;
                        while( true ) {
                          lVar9 = local_ab8[uVar13];
                          plVar15 = (longlong *)
                                    (((ulonglong)(DAT_180d6b854 + 0xe6632e3a) ^ 0x11bf48c) + lVar9);
                          if ((((longlong *)0xfffffffffffffff7 < plVar15) ||
                              (cVar3 = FUN_1801fa260(plVar15), cVar3 == '\0')) ||
                             ((cVar3 = FUN_1801fa260((longlong)plVar15 + 7), cVar3 == '\0' ||
                              (((puVar14 = (uint *)(((ulonglong)(DAT_180d6b8c4 + 0xe6632e3a) ^
                                                    0x11bf48c) + *plVar15),
                                (uint *)0xfffffffffffffffb < puVar14 ||
                                (cVar3 = FUN_1801fa260(puVar14), cVar3 == '\0')) ||
                               (cVar3 = FUN_1801fa260((longlong)puVar14 + 3), cVar3 == '\0'))))))
                          goto LAB_18042afbe;
                          if (*puVar14 == uVar17) break;
                          uVar16 = (int)uVar13 + 1;
                          uVar13 = (ulonglong)uVar16;
                          if (uVar4 <= uVar16) {
                            **(undefined1 **)(param_1 + 0x70) = 2;
                            goto LAB_18042afc5;
                          }
                        }
                        if (lVar9 == 0) goto LAB_18042afac;
                        local_c88 = CONCAT44(local_c88._4_4_,local_c5c);
                        cVar3 = FUN_18042a480(param_1,lVar9,local_c68,local_8b8);
                        fVar21 = auVar22._0_4_;
                        uVar4 = local_c58;
                        param_2 = local_c48;
                        uVar20 = local_c68;
                      }
                      if (cVar3 == '\0') {
                        return 0;
                      }
                      pfVar11 = local_8b8;
                      if (fVar21 == 0.0) {
                        FUN_1809bef30(pfVar11,0,0x800);
                      }
                      else {
                        lVar9 = 0x200;
                        do {
                          *pfVar11 = fVar21;
                          pfVar11 = pfVar11 + 1;
                          lVar9 = lVar9 + -1;
                        } while (lVar9 != 0);
                      }
                      lVar9 = *(longlong *)(param_1 + 0x70);
                      uVar17 = *(uint *)(lVar9 + 4);
                      for (; uVar4 < uVar17; uVar4 = uVar4 + 1) {
                        if (*(int *)(lVar9 + 8) != 0) {
                          uVar13 = uVar19;
                          do {
                            lVar7 = (ulonglong)uVar4 * 0x820 + 0x838 + uVar13 * 4;
                            *(float *)(lVar9 + lVar7) =
                                 local_8b8[uVar13] * *(float *)(lVar9 + lVar7);
                            uVar16 = (int)uVar13 + 1;
                            uVar13 = (ulonglong)uVar16;
                            lVar9 = *(longlong *)(param_1 + 0x70);
                          } while (uVar16 < *(uint *)(lVar9 + 8));
                        }
                      }
                      *(undefined4 *)(local_c20 + (ulonglong)local_c64 * 4 + -8) =
                           *(undefined4 *)(param_1 + 0x78);
                      uVar13 = local_c40;
                      uVar18 = local_c38;
                      uVar17 = local_c50;
                      uVar16 = local_c4c;
                      uVar4 = local_c54;
                      uVar5 = local_c60;
                      uVar6 = local_c64;
                    }
                    else {
                      auVar24 = vpcmpeqd_avx(ZEXT416(uVar6),ZEXT416(0));
                      auVar24 = vblendvps_avx(auVar23._0_16_,auVar28._0_16_,auVar24);
                      if (auVar24._0_4_ != fVar27) goto LAB_18042a9ec;
                    }
                    uVar8 = local_c30;
                    local_c64 = uVar6 + 1;
                    uVar10 = (ulonglong)local_c64;
                  } while (local_c64 < uVar5);
                  cVar3 = FUN_18042a2b0(param_1,*(undefined8 *)
                                                 ((longlong)local_b58 +
                                                 ((ulonglong)(DAT_180d6b85c + 0xe6632e3a) ^
                                                 0x11bf48c)),local_c30);
                  uVar13 = local_c28;
                  if (cVar3 == '\0') {
                    return 0;
                  }
                  iVar2 = (int)local_c28;
                  local_c88 = 0;
                  cVar3 = FUN_180429d50(param_1,local_c28 & 0xffffffff,local_c28._4_4_,auVar23._0_8_
                                       );
                  if (cVar3 == '\0') {
                    return 0;
                  }
                  if ((iVar2 < 0) || ((longlong)uVar13 < 0)) goto LAB_18042af87;
                  plVar15 = (longlong *)
                            (*(longlong *)
                              ((longlong)local_b58 +
                              ((ulonglong)(DAT_180d6b8a4 + 0xe6632e3a) ^ 0x11bf48c)) +
                            ((ulonglong)(DAT_180d6b8fc + 0xe6632e3a) ^ 0x11bf48c));
                  if (((plVar15 < (longlong *)0xfffffffffffffff8) &&
                      ((cVar3 = FUN_1801fa260(plVar15), cVar3 != '\0' &&
                       (cVar3 = FUN_1801fa260((longlong)plVar15 + 7), cVar3 != '\0')))) &&
                     ((plVar15 = (longlong *)
                                 (((ulonglong)(DAT_180d6b900 + 0xe6632e3a) ^ 0x11bf48c) + *plVar15),
                      plVar15 < (longlong *)0xfffffffffffffff8 &&
                      ((cVar3 = FUN_1801fa260(plVar15), cVar3 != '\0' &&
                       (cVar3 = FUN_1801fa260((longlong)plVar15 + 7), cVar3 != '\0')))))) {
                    lVar9 = *plVar15;
                    lVar7 = FUN_1801f3090(&DAT_180d6d818);
                    if (lVar9 == lVar7) {
                      *(undefined1 *)
                       ((longlong)*(int *)(param_1 + 0x78) * 0x1014 + 0x2102a +
                       *(longlong *)(param_1 + 0x70)) = 1;
LAB_18042af87:
                      FUN_180429e10(param_1,uVar8);
                      return 1;
                    }
                    lVar7 = FUN_1801f3090(&DAT_180d6dc88);
                    if (lVar9 == lVar7) goto LAB_18042af87;
LAB_18042afac:
                    **(undefined1 **)(param_1 + 0x70) = 2;
                    goto LAB_18042afc5;
                  }
                }
              }
            }
          }
        }
      }
LAB_18042afbe:
      **(undefined1 **)(param_1 + 0x70) = 3;
LAB_18042afc5:
      *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
      *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
      *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
      *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
      return 0;
    }
    **(undefined1 **)(param_1 + 0x70) = 2;
  }
  else {
LAB_18042aff1:
    **(undefined1 **)(param_1 + 0x70) = 3;
  }
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
  uVar8 = 0;
LAB_18042b015:
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  return uVar8;
}

