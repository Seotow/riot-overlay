// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442920; descriptive alias: FUN_180442920
// Evidence: ev_4cc3d04c13fb7cbc6f7cdd91c7e7d86683889f85eb795a36f20651ae76c303d4
// Original Evidence: rea-collector/0x180442920.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180442920(float *param_1,byte *param_2)

{
  float *pfVar1;
  longlong *plVar2;
  longlong *plVar3;
  longlong *plVar4;
  longlong *plVar5;
  undefined8 *puVar6;
  undefined8 *puVar7;
  longlong *plVar8;
  undefined8 *puVar9;
  ulonglong uVar10;
  longlong lVar11;
  ulonglong uVar12;
  ulonglong uVar13;
  undefined8 *puVar14;
  ulonglong uVar15;
  undefined1 auVar16 [16];
  float fVar17;
  undefined1 auVar18 [16];
  undefined1 auVar19 [16];
  float *local_48;
  undefined8 *local_40;
  
  uVar15 = (((((((((ulonglong)*param_2 ^ 0xcbf29ce484222325) * 0x100000001b3 ^ (ulonglong)param_2[1]
                 ) * 0x100000001b3 ^ (ulonglong)param_2[2]) * 0x100000001b3 ^ (ulonglong)param_2[3])
               * 0x100000001b3 ^ (ulonglong)param_2[4]) * 0x100000001b3 ^ (ulonglong)param_2[5]) *
             0x100000001b3 ^ (ulonglong)param_2[6]) * 0x100000001b3 ^ (ulonglong)param_2[7]) *
           0x100000001b3;
  puVar9 = *(undefined8 **)
            (*(longlong *)(param_1 + 6) + 8 + (uVar15 & *(ulonglong *)(param_1 + 0xc)) * 0x10);
  pfVar1 = param_1 + 2;
  puVar14 = *(undefined8 **)pfVar1;
  if (puVar9 != puVar14) {
    lVar11 = puVar9[2];
    puVar14 = puVar9;
    while (puVar9 = puVar14, *(longlong *)param_2 != lVar11) {
      if (puVar14 ==
          *(undefined8 **)
           (*(longlong *)(param_1 + 6) + (uVar15 & *(ulonglong *)(param_1 + 0xc)) * 0x10))
      goto LAB_1804429f7;
      puVar14 = (undefined8 *)puVar14[1];
      lVar11 = puVar14[2];
    }
    goto LAB_180442d6a;
  }
LAB_1804429f7:
  if (*(longlong *)(param_1 + 4) == 0x555555555555555) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("unordered_map/set too long");
  }
  local_40 = (undefined8 *)0x0;
  local_48 = pfVar1;
  puVar9 = (undefined8 *)FUN_180976d80(0x30);
  puVar9[2] = *(undefined8 *)param_2;
  puVar9[3] = 0;
  puVar9[4] = 0;
  puVar9[5] = 0;
  uVar10 = *(longlong *)(param_1 + 4) + 1;
  if ((longlong)uVar10 < 0) {
    auVar18 = ZEXT416((uint)(float)uVar10);
  }
  else {
    auVar18._0_4_ = (float)(longlong)uVar10;
    auVar18._4_8_ = SUB128(ZEXT812(0),4);
    auVar18._12_4_ = 0;
  }
  uVar10 = *(ulonglong *)(param_1 + 0xe);
  if (*param_1 < auVar18._0_4_ / (float)uVar10) {
    auVar16._0_4_ = auVar18._0_4_ / *param_1;
    auVar16._4_12_ = auVar18._4_12_;
    auVar19._0_12_ = ZEXT812(0);
    auVar19._12_4_ = 0;
    auVar18 = vroundss_avx(auVar19,auVar16,2);
    fVar17 = auVar18._0_4_;
    lVar11 = 0;
    if ((9.223372e+18 <= fVar17) && (fVar17 = fVar17 - 9.223372e+18, fVar17 < 9.223372e+18)) {
      lVar11 = -0x8000000000000000;
    }
    uVar12 = 8;
    if (8 < (ulonglong)((longlong)fVar17 + lVar11)) {
      uVar12 = (longlong)fVar17 + lVar11;
    }
    uVar13 = uVar10;
    if ((uVar10 < uVar12) && ((0x1ff < uVar10 || (uVar13 = uVar10 * 8, uVar10 * 8 < uVar12)))) {
      uVar13 = uVar12;
    }
    for (uVar10 = 0x3f; 0xfffffffffffffffU >> uVar10 == 0; uVar10 = uVar10 - 1) {
    }
    local_40 = puVar9;
    if ((ulonglong)(1L << (uVar10 & 0x3f)) < uVar13) {
                    /* WARNING: Subroutine does not return */
      FUN_18096eea0("invalid hash bucket count");
    }
    uVar10 = uVar13 - 1 | 1;
    lVar11 = 0x3f;
    if (uVar10 != 0) {
      for (; uVar10 >> lVar11 == 0; lVar11 = lVar11 + -1) {
      }
    }
    uVar10 = (ulonglong)((int)lVar11 + 1);
    lVar11 = 1L << (uVar10 & 0x3f);
    plVar2 = *(longlong **)pfVar1;
    FUN_1801ab260(param_1 + 6,2L << (uVar10 & 0x3f),plVar2);
    *(longlong *)(param_1 + 0xc) = lVar11 + -1;
    *(longlong *)(param_1 + 0xe) = lVar11;
    plVar8 = (longlong *)**(undefined8 **)pfVar1;
joined_r0x000180442b74:
    if (plVar8 != plVar2) {
      plVar3 = (longlong *)*plVar8;
      uVar10 = *(ulonglong *)(param_1 + 0xc) &
               (((((((((ulonglong)*(byte *)(plVar8 + 2) ^ 0xcbf29ce484222325) * 0x100000001b3 ^
                     (ulonglong)*(byte *)((longlong)plVar8 + 0x11)) * 0x100000001b3 ^
                    (ulonglong)*(byte *)((longlong)plVar8 + 0x12)) * 0x100000001b3 ^
                   (ulonglong)*(byte *)((longlong)plVar8 + 0x13)) * 0x100000001b3 ^
                  (ulonglong)*(byte *)((longlong)plVar8 + 0x14)) * 0x100000001b3 ^
                 (ulonglong)*(byte *)((longlong)plVar8 + 0x15)) * 0x100000001b3 ^
                (ulonglong)*(byte *)((longlong)plVar8 + 0x16)) * 0x100000001b3 ^
               (ulonglong)*(byte *)((longlong)plVar8 + 0x17)) * 0x100000001b3;
      lVar11 = *(longlong *)(param_1 + 6);
      plVar4 = *(longlong **)(lVar11 + uVar10 * 0x10);
      if (plVar4 == plVar2) {
        *(longlong **)(lVar11 + uVar10 * 0x10) = plVar8;
        *(longlong **)(lVar11 + 8 + uVar10 * 0x10) = plVar8;
        plVar8 = plVar3;
      }
      else {
        plVar5 = *(longlong **)(lVar11 + 8 + uVar10 * 0x10);
        if (plVar8[2] == plVar5[2]) {
          plVar5 = (longlong *)*plVar5;
          if (plVar5 != plVar8) {
            plVar4 = (longlong *)plVar8[1];
            *plVar4 = (longlong)plVar3;
            puVar14 = (undefined8 *)plVar3[1];
            *puVar14 = plVar5;
            puVar6 = (undefined8 *)plVar5[1];
            *puVar6 = plVar8;
            plVar5[1] = (longlong)puVar14;
            plVar3[1] = (longlong)plVar4;
            plVar8[1] = (longlong)puVar6;
          }
          *(longlong **)(lVar11 + 8 + uVar10 * 0x10) = plVar8;
          plVar8 = plVar3;
        }
        else {
          do {
            if (plVar4 == plVar5) {
              plVar4 = (longlong *)plVar8[1];
              *plVar4 = (longlong)plVar3;
              puVar14 = (undefined8 *)plVar3[1];
              *puVar14 = plVar5;
              puVar6 = (undefined8 *)plVar5[1];
              *puVar6 = plVar8;
              plVar5[1] = (longlong)puVar14;
              plVar3[1] = (longlong)plVar4;
              plVar8[1] = (longlong)puVar6;
              *(longlong **)(lVar11 + uVar10 * 0x10) = plVar8;
              plVar8 = plVar3;
              goto joined_r0x000180442b74;
            }
            plVar5 = (longlong *)plVar5[1];
          } while (plVar8[2] != plVar5[2]);
          lVar11 = *plVar5;
          plVar4 = (longlong *)plVar8[1];
          *plVar4 = (longlong)plVar3;
          plVar5 = (longlong *)plVar3[1];
          *plVar5 = lVar11;
          puVar14 = *(undefined8 **)(lVar11 + 8);
          *puVar14 = plVar8;
          *(longlong **)(lVar11 + 8) = plVar5;
          plVar3[1] = (longlong)plVar4;
          plVar8[1] = (longlong)puVar14;
          plVar8 = plVar3;
        }
      }
      goto joined_r0x000180442b74;
    }
    local_48 = (float *)0x0;
    FUN_1804455f0(&local_48);
    puVar6 = *(undefined8 **)
              (*(longlong *)(param_1 + 6) + 8 + (uVar15 & *(ulonglong *)(param_1 + 0xc)) * 0x10);
    puVar14 = *(undefined8 **)(param_1 + 2);
    if (puVar6 != puVar14) {
      lVar11 = puVar6[2];
      puVar14 = puVar6;
      while (puVar9[2] != lVar11) {
        if (puVar14 ==
            *(undefined8 **)
             (*(longlong *)(param_1 + 6) + (uVar15 & *(ulonglong *)(param_1 + 0xc)) * 0x10))
        goto LAB_180442cf2;
        puVar14 = (undefined8 *)puVar14[1];
        lVar11 = puVar14[2];
      }
      puVar14 = (undefined8 *)*puVar14;
    }
  }
LAB_180442cf2:
  puVar6 = (undefined8 *)puVar14[1];
  *(longlong *)(param_1 + 4) = *(longlong *)(param_1 + 4) + 1;
  *puVar9 = puVar14;
  puVar9[1] = puVar6;
  *puVar6 = puVar9;
  puVar14[1] = puVar9;
  lVar11 = *(longlong *)(param_1 + 6);
  uVar15 = *(ulonglong *)(param_1 + 0xc) & uVar15;
  puVar7 = *(undefined8 **)(lVar11 + uVar15 * 0x10);
  if (puVar7 == *(undefined8 **)(param_1 + 2)) {
    *(undefined8 **)(lVar11 + uVar15 * 0x10) = puVar9;
  }
  else {
    if (puVar7 == puVar14) {
      *(undefined8 **)(lVar11 + uVar15 * 0x10) = puVar9;
      goto LAB_180442d6a;
    }
    if (*(undefined8 **)(lVar11 + 8 + uVar15 * 0x10) != puVar6) goto LAB_180442d6a;
  }
  *(undefined8 **)(lVar11 + 8 + uVar15 * 0x10) = puVar9;
LAB_180442d6a:
  return puVar9 + 3;
}

