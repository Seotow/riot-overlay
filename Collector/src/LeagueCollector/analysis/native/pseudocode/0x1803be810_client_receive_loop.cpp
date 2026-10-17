// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803be810; descriptive alias: client_receive_loop
// Evidence: ev_6b9edc0923236e6c7eabce57f27080804b6a05a3a3a9daf65effb1d69e2e800a
// Original Evidence: rea-client-receive-thread.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001803bee35) */
/* WARNING: Removing unreachable block (ram,0x0001803bee14) */
/* WARNING: Removing unreachable block (ram,0x0001803bee3c) */

undefined8 FUN_1803be810(longlong *param_1)

{
  int *piVar1;
  longlong *plVar2;
  longlong lVar3;
  longlong lVar4;
  undefined8 *puVar5;
  code *pcVar6;
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined1 auVar9 [16];
  uint uVar10;
  undefined8 uVar11;
  int iVar12;
  undefined8 uVar13;
  longlong lVar14;
  longlong lVar15;
  longlong lVar16;
  longlong *plVar17;
  undefined1 auVar18 [8];
  ulonglong uVar19;
  longlong lVar20;
  undefined1 *puVar21;
  undefined1 *puVar22;
  bool bVar23;
  undefined1 auStack_188 [8];
  undefined1 auStack_180 [24];
  undefined8 local_168;
  undefined1 local_158 [16];
  undefined *local_148;
  longlong local_140;
  undefined8 local_138;
  undefined8 *local_130;
  code *local_128;
  uint *local_118;
  undefined8 local_110;
  longlong *local_108;
  undefined8 local_f8;
  undefined8 *local_f0;
  uint local_e8 [2];
  undefined8 local_e0;
  undefined1 local_d8 [16];
  ulonglong local_c8;
  undefined1 local_c0 [8];
  longlong *plStack_b8;
  longlong local_b0;
  ulonglong local_a8;
  char local_a0;
  undefined4 local_98;
  longlong local_88;
  undefined8 *local_80;
  undefined8 local_78;
  ulonglong local_70;
  undefined4 local_68 [2];
  char local_60;
  ulonglong local_58;
  
  puVar21 = auStack_188;
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStack_188;
  plVar2 = (longlong *)*param_1;
  iVar12 = (int)plVar2[5];
  local_108 = param_1;
  do {
    puVar22 = auStack_188;
    if (iVar12 == 0) {
LAB_1803bf0cb:
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0d0;
      FUN_180974e60();
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0de;
      thunk_FUN_180895720(local_108,8);
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0ec;
      return 0;
    }
    lVar20 = 0;
    local_d8 = (undefined1  [16])0x0;
    local_c8 = 0;
    local_e8[0] = 0;
    local_118 = local_e8;
    local_110 = 4;
    (**(code **)(*plVar2 + 8))(plVar2,local_68,&local_118);
    uVar10 = local_e8[0];
    if (local_60 == '\0') {
LAB_1803bf087:
      local_d8._0_4_ = local_68[0];
LAB_1803bf08d:
      local_c8 = local_c8 & 0xffffffffffffff00;
      puVar22 = puVar21;
LAB_1803bf091:
      *(undefined4 *)(plVar2 + 7) = 2;
      LOCK();
      *(undefined4 *)(plVar2 + 5) = 0;
      UNLOCK();
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0a7;
      FUN_1802d5df0(plVar2 + 6);
      pcVar6 = *(code **)*plVar2;
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0af;
      (*pcVar6)(plVar2);
      *(undefined8 *)(puVar22 + -8) = 0x1803bf0b7;
      FUN_1803bddc0(plVar2);
      if (((char)local_c8 != '\0') && (local_d8._0_8_ != 0)) {
        *(undefined8 *)(puVar22 + -8) = 0x1803bf0cb;
        thunk_FUN_180895720();
      }
      goto LAB_1803bf0cb;
    }
    if (0x3ffffff < local_e8[0] - 1) {
      iVar12 = FUN_180973810(&DAT_180d6eb78);
      if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_158[0] = 1;
      FUN_180185e60(&DAT_180d6eb28,local_158);
      local_e0 = CONCAT44(local_e0._4_4_,0x25);
      FUN_1801877a0(&DAT_180d6eb28,&local_e0,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d950,0x25);
      local_e0 = _Xtime_get_ticks();
      local_130 = &local_e0;
      local_128 = FUN_180191210;
      local_138 = 0xd000000000000000;
      local_b0 = 0;
      local_a8 = 0xf;
      stack0xffffffffffffff41 = SUB1615((undefined1  [16])0x0,1);
      auVar8[0xf] = 0;
      auVar8._0_15_ = stack0xffffffffffffff41;
      _local_c0 = auVar8 << 8;
      FUN_18019f7a0(local_c0,0x11);
      local_f8 = 1;
      local_f0 = &local_138;
      local_148 = &DAT_180c09610;
      local_140 = 9;
      local_168 = 0;
      FUN_18018ad00(&local_118,local_c0,&local_148,&local_f8);
      local_e0._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_e0);
      local_e0._0_4_ = (uint)local_b0;
      FUN_1801877a0(&DAT_180d6eb28,&local_e0,4);
      auVar18 = (undefined1  [8])local_c0;
      if (0xf < local_a8) {
        auVar18 = local_c0;
      }
      FUN_1801877a0(&DAT_180d6eb28,auVar18,local_b0);
      uVar10 = local_e8[0];
      local_e0._0_4_ = 0;
      FUN_180185f70(&DAT_180d6eb28,&local_e0);
      local_e0._0_4_ = 4;
      FUN_1801877a0(&DAT_180d6eb28,&local_e0,4);
      local_e0 = CONCAT44(local_e0._4_4_,uVar10);
      FUN_1801877a0(&DAT_180d6eb28,&local_e0,4);
      if (DAT_180d6ebe0 != '\0') {
        local_e0 = CONCAT44(local_e0._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_148,&local_e0,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_148,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_148 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_140 = DAT_180d6eb30 - (longlong)local_148;
      FUN_1801806e0(&DAT_180d6eb40,&local_148);
      local_78 = CONCAT44(local_78._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,&local_78,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (0xf < local_a8) {
        uVar19 = local_a8 + 1;
        auVar18 = local_c0;
        if (0xfff < uVar19) {
          auVar18 = *(undefined1 (*) [8])((longlong)local_c0 + -8);
          if (0x1f < ((longlong)local_c0 - (longlong)auVar18) - 8U) {
            pcVar6 = (code *)swi(0x29);
            (*pcVar6)(5);
            puVar21 = auStack_180;
            goto LAB_1803bf087;
          }
          uVar19 = local_a8 + 0x28;
        }
        thunk_FUN_180895720(auVar18,uVar19);
      }
      local_b0 = 0;
      local_a8 = 0xf;
      auVar9[0xf] = 0;
      auVar9._0_15_ = stack0xffffffffffffff41;
      _local_c0 = auVar9 << 8;
      FUN_180973930(&DAT_180d6eb78);
      local_d8._0_4_ = 0xd;
      puVar21 = auStack_188;
      goto LAB_1803bf08d;
    }
    uVar13 = thunk_FUN_180976d80();
    FUN_1809bef30(uVar13,0,uVar10);
    local_70 = (ulonglong)local_e8[0];
    local_78 = uVar13;
    (**(code **)(*plVar2 + 8))(plVar2,&local_88,&local_78);
    if ((char)local_80 == '\0') {
      local_d8._0_4_ = (undefined4)local_88;
      local_c8 = (ulonglong)local_c8._1_7_ << 8;
      thunk_FUN_180895720(uVar13);
      puVar22 = auStack_188;
      if ((char)local_c8 != '\0') goto LAB_1803be910;
      goto LAB_1803bf091;
    }
    local_d8._8_4_ = local_e8[0];
    local_d8._0_8_ = uVar13;
    local_d8._12_4_ = 0;
    local_c8 = CONCAT71(local_c8._1_7_,1);
LAB_1803be910:
    lVar3 = plVar2[0xe];
    if (*(char *)(lVar3 + 0x250) != '\0') {
LAB_1803beb23:
      FUN_18019fb70(&DAT_180d6eb78);
      local_158[0] = 1;
      FUN_180185e60(&DAT_180d6eb28,local_158);
      local_e8[0] = 0x40;
      FUN_1801877a0(&DAT_180d6eb28,local_e8,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d910,0x40);
      local_78 = _Xtime_get_ticks();
      local_130 = &local_78;
      local_128 = FUN_180191210;
      local_138 = 0xd000000000000000;
      local_88 = 1;
      local_80 = &local_138;
      local_118 = (uint *)&DAT_180c09610;
      local_110 = 9;
      FUN_1801858b0(local_c0,&local_118,&local_88);
      local_e8[0] = 1;
      FUN_180185f70(&DAT_180d6eb28,local_e8);
      local_e8[0] = (uint)local_b0;
      FUN_1801877a0(&DAT_180d6eb28,local_e8,4);
      auVar18 = (undefined1  [8])local_c0;
      if (0xf < local_a8) {
        auVar18 = local_c0;
      }
      FUN_1801877a0(&DAT_180d6eb28,auVar18,local_b0);
      if (DAT_180d6ebe0 != '\0') {
        local_e8[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
        FUN_1803c9190(&DAT_180d6ebc8,local_68,local_e8,4);
        FUN_1803c9190(&DAT_180d6ebc8,local_68,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_88 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_80 = (undefined8 *)(DAT_180d6eb30 - local_88);
      FUN_1801806e0(&DAT_180d6eb40,&local_88);
      local_e0 = CONCAT44(local_e0._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,&local_e0,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      FUN_1801a2650(local_c0);
      FUN_180973930(&DAT_180d6eb78);
      puVar22 = auStack_188;
      goto LAB_1803bf091;
    }
    iVar12 = FUN_180973810(lVar3 + 0xb8);
    if (iVar12 != 0) {
LAB_1803bf129:
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (*(int *)(lVar3 + 0x104) == 0x7fffffff) {
      *(int *)(lVar3 + 0x104) = *(int *)(lVar3 + 0x104) + -1;
LAB_1803bf11e:
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    lVar14 = FUN_1803eba20(lVar3 + 0x108,&local_148,plVar2 + 9,(longlong)(char)plVar2[9]);
    lVar14 = *(longlong *)(lVar14 + 8);
    if ((lVar14 == 0) || (lVar14 == *(longlong *)(lVar3 + 0x110))) {
LAB_1803beb17:
      FUN_180973930(lVar3 + 0xb8);
      goto LAB_1803beb23;
    }
    lVar4 = *(longlong *)(lVar14 + 0x20);
    uVar13 = local_d8._8_8_;
    lVar15 = *(longlong *)(lVar4 + 0x60);
    do {
      if (0x8000000U - lVar15 < (ulonglong)local_d8._8_8_) goto LAB_1803beb17;
      LOCK();
      lVar16 = *(longlong *)(lVar4 + 0x60);
      bVar23 = lVar15 == lVar16;
      if (bVar23) {
        *(longlong *)(lVar4 + 0x60) = local_d8._8_8_ + lVar15;
        lVar16 = lVar15;
      }
      UNLOCK();
      lVar15 = lVar16;
    } while (!bVar23);
    LOCK();
    plVar17 = (longlong *)(lVar4 + 0x68);
    lVar15 = *plVar17;
    *plVar17 = *plVar17 + 1;
    UNLOCK();
    if (0x80 < lVar15 + 1U) {
      LOCK();
      *(longlong *)(lVar4 + 0x68) = *(longlong *)(lVar4 + 0x68) + -1;
      UNLOCK();
      LOCK();
      *(longlong *)(lVar4 + 0x60) = *(longlong *)(lVar4 + 0x60) - local_d8._8_8_;
      UNLOCK();
      goto LAB_1803beb17;
    }
    lVar4 = *(longlong *)(lVar14 + 0x28);
    lVar15 = lVar20;
    if (lVar4 != 0) {
      lVar15 = *(longlong *)(lVar14 + 0x20);
      LOCK();
      *(int *)(lVar4 + 0xc) = *(int *)(lVar4 + 0xc) + 1;
      UNLOCK();
      lVar20 = lVar4;
    }
    uVar11 = local_d8._0_8_;
    auVar7._8_8_ = 0;
    auVar7._0_8_ = local_d8._8_8_;
    local_d8 = auVar7 << 0x40;
    iVar12 = FUN_180973810(lVar3 + 0x58);
    if (iVar12 != 0) goto LAB_1803bf129;
    if (*(int *)(lVar3 + 0xa4) == 0x7fffffff) {
      *(int *)(lVar3 + 0xa4) = *(int *)(lVar3 + 0xa4) + -1;
      goto LAB_1803bf11e;
    }
    plStack_b8 = (longlong *)lVar20;
    local_c0 = (undefined1  [8])lVar15;
    local_b0 = uVar11;
    local_a8 = uVar13;
    local_a0 = '\0';
    local_98 = 0;
    if (*(longlong *)(lVar3 + 0xb0) == 0x3ffffffffffffff) {
                    /* WARNING: Subroutine does not return */
      FUN_18096eea0("list too long");
    }
    lVar20 = *(longlong *)(lVar3 + 0xa8);
    plVar17 = (longlong *)FUN_180976d80(0x40);
    FUN_1803ea470(plVar17 + 2,local_c0);
    *(undefined4 *)(plVar17 + 7) = local_98;
    *(longlong *)(lVar3 + 0xb0) = *(longlong *)(lVar3 + 0xb0) + 1;
    puVar5 = *(undefined8 **)(lVar20 + 8);
    *plVar17 = lVar20;
    plVar17[1] = (longlong)puVar5;
    *(longlong **)(lVar20 + 8) = plVar17;
    *puVar5 = plVar17;
    if ((local_a0 != -1) && (local_a0 == '\0')) {
      if (local_b0 != 0) {
        thunk_FUN_180895720();
      }
      if (plStack_b8 != (longlong *)0x0) {
        LOCK();
        piVar1 = (int *)((longlong)plStack_b8 + 0xc);
        iVar12 = *piVar1;
        *piVar1 = *piVar1 + -1;
        UNLOCK();
        if (iVar12 == 1) {
          (**(code **)(*plStack_b8 + 8))();
        }
      }
    }
    FUN_1803bfce0(lVar3);
    FUN_180973930(lVar3 + 0x58);
    FUN_180973930(lVar3 + 0xb8);
    if (((char)local_c8 != '\0') && (local_d8._0_8_ != 0)) {
      thunk_FUN_180895720();
    }
    iVar12 = (int)plVar2[5];
  } while( true );
}

