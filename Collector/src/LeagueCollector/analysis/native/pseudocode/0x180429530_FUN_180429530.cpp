// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180429530; descriptive alias: FUN_180429530
// Evidence: ev_faf42a27e5e3292c0994406347d0a315a0446a41750f7f4412cb56dfdfcde064
// Original Evidence: rea-collector/0x180429530.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __chkstk replaced with injection: alloca_probe */
/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

char * FUN_180429530(char *param_1,longlong param_2)

{
  float fVar1;
  bool bVar2;
  char cVar3;
  uint uVar4;
  ulonglong uVar5;
  undefined4 *puVar6;
  char *pcVar7;
  longlong lVar8;
  ulonglong uVar9;
  longlong lVar10;
  ulonglong uVar11;
  uint uVar12;
  char *pcVar13;
  uint uVar14;
  longlong *plVar15;
  ulonglong *puVar16;
  undefined1 *puVar17;
  uint uVar18;
  ulonglong uVar19;
  uint uVar20;
  ulonglong uVar21;
  ulonglong uVar22;
  float fVar23;
  undefined1 auVar24 [64];
  undefined1 auVar25 [64];
  undefined1 auStack_1bf8 [32];
  undefined8 local_1bd8;
  float *local_1bd0;
  undefined1 local_1bc8 [16];
  ulonglong local_1bb8 [36];
  longlong local_1a98 [70];
  float local_1868 [512];
  undefined4 local_1068 [512];
  undefined4 local_868 [512];
  ulonglong local_68;
  
  local_68 = DAT_180d06cc0 ^ (ulonglong)auStack_1bf8;
  **(undefined1 **)(param_1 + 0x70) = 1;
  uVar22 = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 8) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
  param_1[0x78] = -1;
  param_1[0x79] = -1;
  param_1[0x7a] = -1;
  param_1[0x7b] = -1;
  param_1[0x98] = '\0';
  param_1[0x99] = '\0';
  param_1[0x9a] = '\0';
  param_1[0x9b] = '\0';
  *(longlong *)(param_1 + 0x88) = *(longlong *)(param_1 + 0x88) + 1;
  *(longlong *)(param_1 + 0x80) = param_2;
  if ((*param_1 == '\0') || (param_2 == 0)) {
    **(undefined1 **)(param_1 + 0x70) = 0;
    pcVar7 = *(char **)(param_1 + 0x70);
  }
  else {
    local_1bc8 = (undefined1  [16])0x0;
    if (DAT_180d3df28 == '\0') {
      uVar4 = DAT_180d3dac0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar4 = FUN_18052b510(&DAT_180d3dac0);
    }
    plVar15 = (longlong *)((ulonglong)uVar4 + param_2);
    if (((plVar15 < (longlong *)0xfffffffffffffff8) &&
        (cVar3 = FUN_1801fa260(plVar15), cVar3 != '\0')) &&
       (cVar3 = FUN_1801fa260((longlong)plVar15 + 7), cVar3 != '\0')) {
      lVar8 = *plVar15;
      cVar3 = FUN_1804287f0(((ulonglong)(DAT_180d6b810 + 0xe6632e3a) ^ 0x11bf48c) + lVar8,local_1bc8
                            ,*(undefined8 *)(param_1 + 8));
      if ((cVar3 != '\0') && (cVar3 = FUN_180429e80(param_1,param_2,lVar8), cVar3 != '\0')) {
        uVar4 = *(uint *)(local_1bc8 + ((ulonglong)(DAT_180d6b81c + 0xe6632e3a) ^ 0x11bf48c));
        FUN_1809bef30(local_1bb8 + 4,0,0x100);
        if ((uVar4 < 0x21) &&
           ((uVar4 == 0 ||
            (cVar3 = FUN_1804287f0(*(undefined8 *)
                                    (local_1bc8 +
                                    ((ulonglong)(DAT_180d6b818 + 0xe6632e3a) ^ 0x11bf48c)),
                                   local_1bb8 + 4,(ulonglong)uVar4 << 3), cVar3 != '\0')))) {
          puVar6 = local_868;
          lVar8 = 0x200;
          do {
            *puVar6 = 0x3f800000;
            puVar6 = puVar6 + 1;
            lVar8 = lVar8 + -1;
          } while (lVar8 != 0);
          if (uVar4 == 0) {
LAB_180429c41:
            pcVar7 = *(char **)(param_1 + 0x70);
            if (*pcVar7 != '\x01') {
              return pcVar7;
            }
            uVar21 = uVar22;
            if (*(int *)(pcVar7 + 4) == 0) {
              return pcVar7;
            }
            do {
              fVar23 = *(float *)(pcVar7 + uVar21 * 0x820 + 0x838);
              *(float *)(pcVar7 + uVar21 * 0x820 + 0x830) = fVar23;
              pcVar7[uVar21 * 0x820 + 0x835] = '\0';
              pcVar13 = *(char **)(param_1 + 0x70);
              uVar11 = uVar22;
              uVar19 = uVar22;
              if (*(int *)(pcVar13 + 8) != 0) {
                do {
                  fVar1 = *(float *)(pcVar7 + uVar11 * 4 + uVar21 * 0x820 + 0x838);
                  pcVar7[uVar21 * 0x820 + 0x835] = fVar1 != fVar23 | (byte)uVar19;
                  uVar4 = (int)uVar11 + 1;
                  pcVar13 = *(char **)(param_1 + 0x70);
                  uVar11 = (ulonglong)uVar4;
                  uVar19 = (ulonglong)((uint)uVar19 | (uint)(fVar1 != fVar23));
                } while (uVar4 < *(uint *)(pcVar13 + 8));
              }
              uVar4 = (int)uVar21 + 1;
              pcVar7 = pcVar13;
              uVar21 = (ulonglong)uVar4;
            } while (uVar4 < *(uint *)(pcVar13 + 4));
            return pcVar13;
          }
          auVar25 = ZEXT1264(ZEXT812(0));
          uVar21 = uVar22;
LAB_180429720:
          local_1bb8[0] = 0;
          local_1bb8[1] = 0;
          local_1bb8[2] = 0;
          local_1bb8[3] = 0;
          auVar25 = ZEXT1664(auVar25._0_16_);
          FUN_1809bef30(local_1a98,0,0x230);
          local_1bc8._0_12_ = ZEXT812(0);
          uVar11 = *(ulonglong *)(param_1 + 0x10);
          if (uVar11 != 0) {
            uVar19 = local_1bb8[uVar21 + 4];
            if (((~uVar11 < uVar19) || (cVar3 = FUN_1801fa260(uVar19), cVar3 == '\0')) ||
               (cVar3 = FUN_1801fa260((uVar11 - 1) + uVar19), cVar3 == '\0')) goto LAB_180429c1b;
            FUN_1809bf2f0(local_1bb8,uVar19,uVar11);
            uVar11 = *(ulonglong *)
                      ((longlong)local_1bb8 + ((ulonglong)(DAT_180d6b820 + 0xe6632e3a) ^ 0x11bf48c))
            ;
            puVar16 = (ulonglong *)(((ulonglong)(DAT_180d6b828 + 0xe6632e3a) ^ 0x11bf48c) + uVar11);
            if ((((ulonglong *)0xfffffffffffffff7 < puVar16) ||
                (cVar3 = FUN_1801fa260(puVar16), cVar3 == '\0')) ||
               (cVar3 = FUN_1801fa260((longlong)puVar16 + 7), cVar3 == '\0')) goto LAB_180429c1b;
            uVar19 = *puVar16;
            if (DAT_180d6bd70 == '\0') {
              uVar9 = DAT_180d6b908 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
            }
            else {
              uVar9 = FUN_18052c740(&DAT_180d6b908,0);
            }
            uVar5 = uVar22;
            if (uVar9 != 0) {
              uVar5 = DAT_180d20bd0 + uVar9;
            }
            if (uVar19 != uVar5) {
              **(undefined1 **)(param_1 + 0x70) = 2;
              goto LAB_180429c22;
            }
            uVar19 = *(ulonglong *)(param_1 + 0x18);
            if (((uVar19 == 0) || (~uVar19 < uVar11)) ||
               ((cVar3 = FUN_1801fa260(uVar11), cVar3 == '\0' ||
                (cVar3 = FUN_1801fa260((uVar19 - 1) + uVar11), cVar3 == '\0')))) goto LAB_180429c1b;
            FUN_1809bf2f0(local_1a98,uVar11,uVar19);
            lVar8 = *(longlong *)
                     ((longlong)local_1a98 + ((ulonglong)(DAT_180d6b82c + 0xe6632e3a) ^ 0x11bf48c));
            if ((lVar8 == 0) &&
               (*(longlong *)
                 ((longlong)local_1a98 + ((ulonglong)(DAT_180d6b830 + 0xe6632e3a) ^ 0x11bf48c)) == 0
               )) {
LAB_180429bfa:
              uVar18 = (int)uVar21 + 1;
              uVar21 = (ulonglong)uVar18;
              if (uVar4 <= uVar18) goto LAB_180429c41;
              goto LAB_180429720;
            }
            uVar11 = *(ulonglong *)(param_1 + 0x20);
            if ((uVar11 != 0) &&
               (((uVar19 = *(ulonglong *)
                            ((longlong)local_1bb8 +
                            ((ulonglong)(DAT_180d6b824 + 0xe6632e3a) ^ 0x11bf48c)),
                 uVar19 <= ~uVar11 && (cVar3 = FUN_1801fa260(uVar19), cVar3 != '\0')) &&
                (cVar3 = FUN_1801fa260((uVar11 - 1) + uVar19), cVar3 != '\0')))) {
              FUN_1809bf2f0(local_1bc8,uVar19,uVar11);
              fVar23 = *(float *)(local_1bc8 + ((ulonglong)(DAT_180d6b844 + 0xe6632e3a) ^ 0x11bf48c)
                                 );
              auVar24 = ZEXT464((uint)fVar23);
              uVar11 = (ulonglong)(uint)fVar23;
              if ((((uint)fVar23 & 0x7f800000) == 0x7f800000) || (fVar23 < auVar25._0_4_))
              goto LAB_180429c1b;
              if (fVar23 == auVar25._0_4_) goto LAB_180429bfa;
              uVar14 = DAT_180d6b840 + 0xe6632e3a;
              uVar18 = *(uint *)(*(longlong *)(param_1 + 0x70) + 4);
              param_1[0x78] = -1;
              param_1[0x79] = -1;
              param_1[0x7a] = -1;
              param_1[0x7b] = -1;
              puVar6 = local_1068;
              lVar10 = 0x200;
              do {
                *puVar6 = 0x3f800000;
                puVar6 = puVar6 + 1;
                lVar10 = lVar10 + -1;
              } while (lVar10 != 0);
              if ((*(longlong *)
                    ((longlong)local_1a98 + ((ulonglong)(DAT_180d6b834 + 0xe6632e3a) ^ 0x11bf48c))
                   == 0) &&
                 (*(longlong *)
                   ((longlong)local_1a98 + ((ulonglong)(DAT_180d6b838 + 0xe6632e3a) ^ 0x11bf48c)) ==
                  0)) {
                if (lVar8 != 0) {
                  local_1bd8 = (undefined4 *)((ulonglong)local_1bd8._4_4_ << 0x20);
                  cVar3 = FUN_18042a480(param_1,lVar8,uVar21,local_1068);
                  uVar11 = auVar24._0_8_;
                  goto LAB_180429a68;
                }
              }
              else {
                local_1bd8 = (undefined4 *)((ulonglong)local_1bd8._4_4_ << 0x20);
                cVar3 = FUN_18042b7b0(param_1,(ulonglong)(DAT_180d6b83c + 0xe6632e3aU ^ 0x11bf48c) +
                                              *(longlong *)
                                               ((longlong)local_1bb8 +
                                               ((ulonglong)(DAT_180d6b820 + 0xe6632e3a) ^ 0x11bf48c)
                                               ),uVar21,local_1068);
                uVar11 = auVar24._0_8_;
LAB_180429a68:
                if (cVar3 == '\0') goto LAB_180429c41;
              }
              bVar2 = (byte)(local_1bc8[(ulonglong)uVar14 ^ 0x11bf48c] - 1) < 2;
              local_1bd0 = local_1868;
              local_1bd8 = local_868;
              cVar3 = FUN_180428870(local_1068,uVar11,bVar2,
                                    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 8));
              puVar17 = *(undefined1 **)(param_1 + 0x70);
              if (cVar3 == '\0') {
                *puVar17 = 3;
                goto LAB_180429c22;
              }
              uVar14 = *(uint *)(puVar17 + 4);
              for (uVar20 = uVar18; uVar20 < uVar14; uVar20 = uVar20 + 1) {
                if (*(int *)(puVar17 + 8) != 0) {
                  uVar11 = uVar22;
                  do {
                    lVar8 = (ulonglong)uVar20 * 0x820 + 0x838 + uVar11 * 4;
                    *(float *)(puVar17 + lVar8) = local_1868[uVar11] * *(float *)(puVar17 + lVar8);
                    uVar12 = (int)uVar11 + 1;
                    uVar11 = (ulonglong)uVar12;
                    puVar17 = *(undefined1 **)(param_1 + 0x70);
                  } while (uVar12 < *(uint *)(puVar17 + 8));
                }
              }
              if (uVar18 < *(uint *)(puVar17 + 4)) {
                do {
                  puVar17[(ulonglong)uVar18 * 0x820 + 0x834] = bVar2;
                  uVar18 = uVar18 + 1;
                  puVar17 = *(undefined1 **)(param_1 + 0x70);
                } while (uVar18 < *(uint *)(puVar17 + 4));
              }
              if (-1 < *(int *)(param_1 + 0x78)) {
                uVar18 = *(uint *)(puVar17 + 0x10);
                *(uint *)(puVar17 + 0x10) = uVar18 + 1;
                lVar8 = (ulonglong)uVar18 * 0x810;
                *(int *)(puVar17 + lVar8 + 0xa1a18) = (int)uVar21;
                *(undefined4 *)(puVar17 + lVar8 + 0xa1a1c) = *(undefined4 *)(param_1 + 0x78);
                puVar17[lVar8 + 0xa1a24] = bVar2;
                *(float *)(puVar17 + lVar8 + 0xa1a20) = local_1868[0];
                puVar17[lVar8 + 0xa1a25] = 0;
                fVar23 = local_1868[0];
                FUN_1809bf2f0(puVar17 + lVar8 + 0xa1a28,local_1868,0x800);
                uVar11 = uVar22;
                uVar19 = uVar22;
                if (*(int *)(*(longlong *)(param_1 + 0x70) + 8) != 0) {
                  do {
                    fVar1 = local_1868[uVar11];
                    puVar17[lVar8 + 0xa1a25] = fVar1 != fVar23 | (byte)uVar19;
                    uVar18 = (int)uVar11 + 1;
                    uVar11 = (ulonglong)uVar18;
                    uVar19 = (ulonglong)((uint)uVar19 | (uint)(fVar1 != fVar23));
                  } while (uVar18 < *(uint *)(*(longlong *)(param_1 + 0x70) + 8));
                }
              }
              goto LAB_180429bfa;
            }
          }
LAB_180429c1b:
          **(undefined1 **)(param_1 + 0x70) = 3;
LAB_180429c22:
          *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
          *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
          *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
          param_1[0x78] = -1;
          param_1[0x79] = -1;
          param_1[0x7a] = -1;
          param_1[0x7b] = -1;
          goto LAB_180429c41;
        }
      }
    }
    **(undefined1 **)(param_1 + 0x70) = 3;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
    pcVar7 = *(char **)(param_1 + 0x70);
    param_1[0x78] = -1;
    param_1[0x79] = -1;
    param_1[0x7a] = -1;
    param_1[0x7b] = -1;
  }
  return pcVar7;
}

