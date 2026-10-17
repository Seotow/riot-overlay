// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180438b60; descriptive alias: FUN_180438b60
// Evidence: ev_e6fccb9b7cbf05fd9616ecaf1008fd80b29c0cf95b382118fd8d010f28ab3ccb
// Original Evidence: rea-collector/0x180438b60.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

ulonglong FUN_180438b60(longlong param_1,ulonglong param_2,longlong param_3,undefined1 param_4)

{
  ulonglong uVar1;
  longlong lVar2;
  undefined1 uVar3;
  undefined2 uVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  code *pcVar7;
  char cVar8;
  uint uVar9;
  ulonglong uVar10;
  longlong *plVar11;
  longlong *plVar12;
  undefined8 uVar13;
  ulonglong uVar14;
  longlong *plVar15;
  undefined4 *puVar16;
  longlong lVar17;
  undefined4 uVar18;
  undefined1 *puVar19;
  longlong *plVar20;
  ulonglong uVar21;
  ulonglong uVar22;
  undefined8 *puVar23;
  byte bVar24;
  longlong lVar25;
  undefined1 auStack_138 [8];
  undefined1 auStack_130 [24];
  undefined4 local_118;
  undefined4 local_110;
  undefined1 local_108;
  ushort local_100;
  undefined2 local_f8;
  undefined1 local_f0;
  undefined4 local_e8;
  byte local_d8;
  undefined1 local_d7;
  longlong local_d0;
  uint local_c8;
  undefined1 local_c4 [4];
  longlong local_c0;
  undefined8 *local_b8;
  undefined8 *local_b0;
  longlong local_a8;
  longlong local_a0;
  ulonglong local_98;
  undefined8 local_88;
  longlong lStack_80;
  undefined1 local_78 [16];
  longlong local_68;
  undefined1 local_58 [16];
  ulonglong local_48;
  
  puVar19 = auStack_138;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_138;
  local_78._4_12_ = SUB1612((undefined1  [16])0x0,4);
  local_78._0_5_ = 0x6d657469;
  local_d7 = param_4;
  local_d0 = param_1;
  local_a8 = param_3;
  local_98 = param_2;
  if (DAT_180d445d8 == '\0') {
    uVar9 = DAT_180d44170 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d44170);
  }
  lVar17 = *(longlong *)((ulonglong)uVar9 + param_3);
  local_c0 = lVar17;
  if (DAT_180d44ec0 == '\0') {
    uVar9 = DAT_180d44a58 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d44a58);
  }
  local_a0 = *(longlong *)((ulonglong)uVar9 + lVar17);
  if (DAT_180d45330 == '\0') {
    local_c8 = DAT_180d44ec8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    local_c8 = FUN_18052b510(&DAT_180d44ec8);
  }
  puVar23 = *(undefined8 **)(((ulonglong)(DAT_180d445e0 + 0xe6632e3aU) ^ 0x11bf48c) + lVar17);
  uVar22 = *(longlong *)((ulonglong)((DAT_180d445e0 + 0xe6632e3aU ^ 0x11bf48c) + 8) + lVar17) -
           (longlong)puVar23;
  uVar10 = (longlong)uVar22 >> 3;
  local_78 = (undefined1  [16])0x0;
  local_68 = 0;
  plVar11 = (longlong *)0x0;
  plVar20 = (longlong *)0x0;
  local_b8 = puVar23;
  if (uVar10 == 0) {
    uVar22 = uVar22 & 0xfffffffffffffff8;
  }
  else {
    if (0x1fffffffffffffff < uVar10) {
                    /* WARNING: Subroutine does not return */
      FUN_180183310();
    }
    uVar22 = uVar10 * 8;
    plVar11 = (longlong *)FUN_1801a22d0(uVar22);
    plVar20 = plVar11 + uVar10;
  }
  bVar24 = 0;
  local_d8 = 0;
  local_b0 = (undefined8 *)(uVar22 + (longlong)puVar23);
  plVar15 = plVar11;
  plVar12 = plVar11;
  if (uVar22 == 0) {
LAB_18043907c:
    uVar18 = 0;
  }
  else {
    do {
      uVar13 = *puVar23;
      cVar8 = FUN_1801fa260(uVar13);
      plVar12 = plVar15;
      if (cVar8 == '\0') {
        if (plVar11 == plVar20) {
          uVar22 = (longlong)plVar11 - (longlong)plVar15;
          if ((longlong)uVar22 >> 3 == 0x1fffffffffffffff) {
LAB_1804392cd:
                    /* WARNING: Subroutine does not return */
            FUN_180183310();
          }
          uVar10 = ((longlong)uVar22 >> 3) + 1;
          uVar21 = (longlong)plVar20 - (longlong)plVar15 >> 3;
          if (0x1fffffffffffffff - (uVar21 >> 1) < uVar21) {
            uVar14 = 0x1fffffffffffffff;
          }
          else {
            uVar1 = (uVar21 >> 1) + uVar21;
            uVar14 = uVar10;
            if (uVar10 <= uVar1) {
              uVar14 = uVar1;
            }
            if (0x1fffffffffffffff < uVar14) {
LAB_1804392c7:
                    /* WARNING: Subroutine does not return */
              FUN_1801a22b0();
            }
          }
          plVar12 = (longlong *)FUN_1801a22d0();
          *(undefined8 *)((uVar22 & 0xfffffffffffffff8) + (longlong)plVar12) = 0;
          FUN_1809bf2f0(plVar12,plVar15,uVar22);
          if (plVar15 != (longlong *)0x0) {
            uVar21 = uVar21 * 8;
            if (0xfff < uVar21) {
              if (0x1f < (ulonglong)((longlong)plVar15 + (-8 - plVar15[-1]))) goto LAB_180439271;
              uVar21 = uVar21 + 0x27;
              plVar15 = (longlong *)plVar15[-1];
            }
            thunk_FUN_180895720(plVar15,uVar21);
          }
          plVar11 = plVar12 + uVar10;
          plVar20 = plVar12 + uVar14;
          lVar17 = local_d0;
          bVar24 = local_d8;
        }
        else {
          *plVar11 = 0;
          plVar11 = plVar11 + 1;
          lVar17 = local_d0;
        }
      }
      else {
        local_88 = uVar13;
        if (PTR_PTR_180d0fb48 == (undefined *)0x0) {
                    /* WARNING: Subroutine does not return */
          FUN_18096ee50();
        }
        lVar17 = (**(code **)(*(longlong *)PTR_PTR_180d0fb48 + 0x10))(PTR_PTR_180d0fb48,&local_88);
        if (plVar11 == plVar20) {
          uVar22 = (longlong)plVar11 - (longlong)plVar15;
          if ((longlong)uVar22 >> 3 == 0x1fffffffffffffff) goto LAB_1804392cd;
          uVar10 = ((longlong)uVar22 >> 3) + 1;
          uVar21 = (longlong)plVar20 - (longlong)plVar15 >> 3;
          if (0x1fffffffffffffff - (uVar21 >> 1) < uVar21) {
            uVar14 = 0x1fffffffffffffff;
          }
          else {
            uVar1 = (uVar21 >> 1) + uVar21;
            uVar14 = uVar10;
            if (uVar10 <= uVar1) {
              uVar14 = uVar1;
            }
            if (0x1fffffffffffffff < uVar14) goto LAB_1804392c7;
          }
          plVar12 = (longlong *)FUN_1801a22d0(uVar14 * 8);
          *(longlong *)((longlong)plVar12 + (uVar22 & 0xfffffffffffffff8)) = lVar17;
          FUN_1809bf2f0(plVar12,plVar15,uVar22);
          if (plVar15 != (longlong *)0x0) {
            uVar21 = uVar21 * 8;
            if (0xfff < uVar21) {
              if (0x1f < (ulonglong)((longlong)plVar15 + (-8 - plVar15[-1]))) goto LAB_180439271;
              uVar21 = uVar21 + 0x27;
              plVar15 = (longlong *)plVar15[-1];
            }
            thunk_FUN_180895720(plVar15,uVar21);
          }
          plVar11 = plVar12 + uVar10;
          plVar20 = plVar12 + uVar14;
          puVar23 = local_b8;
          bVar24 = local_d8;
        }
        else {
          *plVar11 = lVar17;
          plVar11 = plVar11 + 1;
        }
        local_58 = (undefined1  [16])0x0;
        if (PTR_PTR_180d0fb08 == (undefined *)0x0) {
          local_88 = uVar13;
                    /* WARNING: Subroutine does not return */
          FUN_18096ee50();
        }
        bVar24 = bVar24 | lVar17 != 0;
        local_d8 = bVar24;
        local_88 = uVar13;
        (**(code **)(*(longlong *)PTR_PTR_180d0fb08 + 0x10))(PTR_PTR_180d0fb08,local_58,&local_88);
        lVar17 = local_d0;
        if (local_58._8_8_ != 0) {
          local_88 = local_58._0_8_;
          lStack_80 = local_58._8_8_;
          uVar13 = FUN_180433ef0(*(undefined8 *)(local_d0 + 0x480),local_c4,&local_88);
          FUN_1802996d0(local_78,uVar13);
        }
      }
      puVar23 = puVar23 + 1;
      plVar15 = plVar12;
      local_b8 = puVar23;
    } while (puVar23 != local_b0);
    if (bVar24 == 0) goto LAB_18043907c;
    lVar17 = *(longlong *)(lVar17 + 0x480);
    lVar25 = (longlong)plVar11 - (longlong)plVar12 >> 3;
    plVar15 = (longlong *)&DAT_180d20bc3;
    if (plVar12 != plVar11) {
      plVar15 = plVar12;
    }
    FUN_1801c3f20(lVar17,lVar25,8);
    if ((lVar25 != 0) && (lVar2 = lVar25 * 8, lVar2 != 0)) {
      FUN_1801c5410(lVar17,lVar2);
      *(longlong *)(lVar17 + 0x40) = *(longlong *)(lVar17 + 0x40) + lVar25 * -8;
      *(int *)(lVar17 + 0x30) = *(int *)(lVar17 + 0x30) + (int)lVar2;
      FUN_1809bf2f0(*(undefined8 *)(lVar17 + 0x40),plVar15,lVar2);
    }
    *(undefined1 *)(lVar17 + 0x60) = 0;
    if (*(ulonglong *)(lVar17 + 0x68) < 4) {
      *(undefined8 *)(lVar17 + 0x68) = 4;
    }
    FUN_1801c5360(lVar17,-*(int *)(lVar17 + 0x30) & 3);
    FUN_1801c5410(lVar17,4);
    *(longlong *)(lVar17 + 0x40) = *(longlong *)(lVar17 + 0x40) + -4;
    *(int *)(lVar17 + 0x30) = *(int *)(lVar17 + 0x30) + 4;
    **(undefined4 **)(lVar17 + 0x40) = (int)lVar25;
    uVar18 = *(undefined4 *)(lVar17 + 0x30);
  }
  lVar17 = local_c0;
  local_c0 = (ulonglong)local_c8 + local_c0;
  if (DAT_180d457a8 == '\0') {
    uVar9 = DAT_180d45340 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d45340);
  }
  uVar4 = *(undefined2 *)((ulonglong)uVar9 + lVar17);
  if (DAT_180d44a50 == '\0') {
    uVar9 = DAT_180d445e8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d445e8);
  }
  bVar24 = *(byte *)((ulonglong)uVar9 + lVar17);
  uVar3 = *(undefined1 *)(((ulonglong)(DAT_180d44168 + 0xe6632e3a) ^ 0x11bf48c) + local_a8);
  if (DAT_180d457b4 == 0xfffffffe) {
    uVar9 = 0xffffffff;
  }
  else {
    uVar9 = DAT_180d457b4;
    if (DAT_180d457b4 == 0xffffffff) {
      uVar9 = FUN_180425350(&DAT_180d457b0);
    }
  }
  lVar17 = local_a0;
  if ((local_a0 == 0) || (uVar9 == 0xffffffff)) {
    puVar16 = &DAT_180d6e998;
  }
  else {
    puVar16 = (undefined4 *)((ulonglong)uVar9 + local_a0);
  }
  uVar5 = *puVar16;
  if (DAT_180d457bc == 0xfffffffe) {
    uVar9 = 0xffffffff;
  }
  else {
    uVar9 = DAT_180d457bc;
    if (DAT_180d457bc == 0xffffffff) {
      uVar9 = FUN_180425080(&DAT_180d457b8);
    }
  }
  if ((lVar17 == 0) || (uVar9 == 0xffffffff)) {
    puVar16 = &DAT_180d6e99c;
  }
  else {
    puVar16 = (undefined4 *)(lVar17 + (ulonglong)uVar9);
  }
  uVar6 = *puVar16;
  puVar16 = (undefined4 *)FUN_1803e6df0(*(undefined8 *)(local_d0 + 0x480),local_c4,local_78);
  uVar22 = local_98;
  local_f0 = local_d7;
  local_100 = (ushort)bVar24;
  local_118 = uVar6;
  local_110 = uVar5;
  local_108 = uVar3;
  local_f8 = uVar4;
  local_e8 = uVar18;
  FUN_1804355d0(local_98,*(undefined8 *)(local_d0 + 0x480),*puVar16,local_c0);
  if (plVar12 == (longlong *)0x0) {
LAB_18043922d:
    if (local_78._0_8_ == 0) goto LAB_180439283;
    lVar17 = local_78._0_8_;
    puVar19 = auStack_138;
    if ((0xfff < (ulonglong)((local_68 - local_78._0_8_ >> 2) * 4)) &&
       (lVar17 = *(longlong *)(local_78._0_8_ + -8), puVar19 = auStack_138,
       0x1f < (local_78._0_8_ - *(longlong *)(local_78._0_8_ + -8)) - 8U)) goto LAB_180439271;
  }
  else {
    uVar10 = ((longlong)plVar20 - (longlong)plVar12 >> 3) * 8;
    if (uVar10 < 0x1000) {
LAB_180439228:
      thunk_FUN_180895720(plVar12,uVar10);
      goto LAB_18043922d;
    }
    if ((ulonglong)((longlong)plVar12 + (-8 - plVar12[-1])) < 0x20) {
      uVar10 = uVar10 + 0x27;
      plVar12 = (longlong *)plVar12[-1];
      goto LAB_180439228;
    }
LAB_180439271:
    lVar17 = 5;
    pcVar7 = (code *)swi(0x29);
    (*pcVar7)(5);
    puVar19 = auStack_130;
  }
  *(undefined8 *)(puVar19 + -8) = 0x180439283;
  thunk_FUN_180895720(lVar17);
LAB_180439283:
  *(undefined8 *)(puVar19 + -8) = 0x180439296;
  return uVar22;
}

