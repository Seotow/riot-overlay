// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803db220; descriptive alias: register_client
// Evidence: ev_ef598079fd73fb1be0be033d54cd45acf6a404132d42e4330955a2e50f94f407
// Original Evidence: rea-server-accept-client.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1803db220(char *param_1,longlong *param_2)

{
  int *piVar1;
  char *pcVar2;
  char *pcVar3;
  undefined1 auVar4 [16];
  code *pcVar5;
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined4 uVar8;
  undefined4 uVar9;
  char *pcVar10;
  char cVar11;
  byte bVar12;
  int iVar13;
  undefined8 *puVar14;
  longlong lVar15;
  undefined1 auVar16 [8];
  longlong *plVar17;
  undefined1 *puVar18;
  undefined1 *puVar19;
  longlong *plVar20;
  ulonglong uVar21;
  ulonglong uVar22;
  undefined8 uVar23;
  undefined8 extraout_XMM0_Qb;
  undefined8 uVar24;
  undefined1 auStack_188 [8];
  undefined1 auStack_180 [24];
  undefined8 local_168;
  undefined1 *local_160;
  undefined1 local_158 [16];
  undefined1 local_148 [8];
  longlong *plStack_140;
  undefined1 local_138 [16];
  undefined1 local_128 [8];
  undefined8 uStack_120;
  longlong *local_118;
  ulonglong local_110;
  char *local_108;
  undefined8 local_100;
  longlong *local_f8;
  undefined1 local_e8 [16];
  undefined8 local_d8;
  ulonglong *local_d0;
  ulonglong local_c8 [11];
  undefined4 local_70;
  undefined1 local_6c [8];
  undefined1 local_64 [32];
  
  puVar18 = auStack_188;
  uVar21 = 0;
  auVar6._12_4_ = 0;
  auVar6._0_12_ = stack0xfffffffffffffebc;
  _local_148 = auVar6 << 0x20;
  pcVar2 = param_1 + 0xb8;
  local_e8._8_8_ = 0;
  local_e8._0_8_ = pcVar2;
  iVar13 = FUN_180973810(pcVar2);
  if (iVar13 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (*(int *)(param_1 + 0x104) == 0x7fffffff) {
    param_1[0x104] = -2;
    param_1[0x105] = -1;
    param_1[0x106] = -1;
    param_1[0x107] = '\x7f';
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(6);
  }
  local_e8[8] = 1;
  if (*(int *)(param_1 + 0x238) == 0) {
    FUN_1803ebad0();
    goto LAB_1803db77f;
  }
  cVar11 = (**(code **)(*(longlong *)*param_2 + 0x20))();
  if (cVar11 == '\0') {
    *(undefined4 *)(*param_2 + 0x130) = *(undefined4 *)(param_1 + 0x2c4);
  }
  local_138 = (undefined1  [16])0x0;
  plVar17 = (longlong *)*param_2;
  if (plVar17 == (longlong *)0x0) {
    local_138._0_8_ = (longlong *)0x0;
    plVar17 = (longlong *)local_138._0_8_;
  }
  else {
    local_138._8_8_ = FUN_180976d80(0x18);
    local_148 = (undefined1  [8])local_138._8_8_;
    *(undefined1 (*) [16])local_138._8_8_ = (undefined1  [16])0x0;
    *(undefined4 *)(*(undefined1 (*) [16])local_138._8_8_ + 8) = 1;
    *(undefined4 *)(*(undefined1 (*) [16])local_138._8_8_ + 0xc) = 1;
    *(undefined ***)*(undefined1 (*) [16])local_138._8_8_ = &PTR_FUN_180c6f128;
    *(longlong **)*(undefined1 (*) [16])(local_138._8_8_ + 0x10) = plVar17;
    local_138._0_8_ = plVar17;
    *param_2 = 0;
  }
  FUN_1803e7f60(param_1 + 0x108,&local_108,plVar17 + 9,local_138);
  plVar20 = (longlong *)local_138._0_8_;
  LOCK();
  *(undefined4 *)(local_138._0_8_ + 0x28) = 1;
  UNLOCK();
  puVar14 = (undefined8 *)FUN_180976d80(8);
  *puVar14 = plVar20;
  local_160 = local_158 + 8;
  local_168._0_4_ = 0;
  local_148 = (undefined1  [8])puVar14;
  lVar15 = FUN_180988944(0,0,FUN_1803be810,puVar14);
  auVar6 = local_158;
  local_158._0_8_ = lVar15;
  auVar4 = local_158;
  local_158._12_4_ = auVar6._12_4_;
  uVar9 = local_158._12_4_;
  if (lVar15 == 0) {
    local_158._0_12_ = ZEXT812(0);
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(6);
  }
  if ((int)*(longlong *)((undefined8)plVar20 + 2) != 0) {
    local_158 = auVar4;
                    /* WARNING: Subroutine does not return */
    FUN_1809887f4();
  }
  local_158._8_4_ = auVar6._8_4_;
  uVar8 = local_158._8_4_;
  local_158 = (undefined1  [16])0x0;
  *(longlong *)((undefined8)plVar20 + 1) = lVar15;
  *(undefined4 *)((undefined8)plVar20 + 2) = uVar8;
  *(undefined4 *)((longlong)plVar20 + 0x14) = uVar9;
  local_148 = (undefined1  [8])FUN_180976d80(8);
  *(longlong **)local_148 = plVar20;
  local_160 = local_158 + 8;
  local_168 = (ulonglong)local_168._4_4_ << 0x20;
  lVar15 = FUN_180988944(0,0,FUN_1803bf150,local_148);
  pcVar10 = local_108;
  auVar6 = local_158;
  local_158._0_8_ = lVar15;
  auVar4 = local_158;
  local_158._12_4_ = auVar6._12_4_;
  uVar9 = local_158._12_4_;
  if (lVar15 == 0) {
    local_158._0_12_ = ZEXT812(0);
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(6);
  }
  if ((int)*(longlong *)((undefined8)plVar20 + 4) != 0) {
    local_158 = auVar4;
                    /* WARNING: Subroutine does not return */
    FUN_1809887f4();
  }
  local_158._8_4_ = auVar6._8_4_;
  uVar8 = local_158._8_4_;
  local_158 = (undefined1  [16])0x0;
  *(longlong *)((undefined8)plVar20 + 3) = lVar15;
  *(undefined4 *)((undefined8)plVar20 + 4) = uVar8;
  *(undefined4 *)((longlong)plVar20 + 0x24) = uVar9;
  local_70 = *(undefined4 *)(local_108 + 0x10);
  local_c8[0] = 0x2000000000000000;
  local_c8[1] = 0x2000000000000004;
  auVar6 = vpmovzxwd_avx(ZEXT416(*(uint *)(local_108 + 0x14)));
  local_6c = auVar6._0_8_;
  local_c8[2] = 0x2000000000000008;
  local_c8[3] = 0x200000000000000c;
  local_c8[4] = 0x2000000000000010;
  local_c8[5] = 0x2000000000000014;
  local_c8[6] = 0x2000000000000018;
  local_c8[7] = 0x200000000000001c;
  local_c8[8] = 0x2000000000000020;
  local_c8[9] = 0x2000000000000024;
  auVar4._8_8_ = 0;
  auVar4._0_8_ = *(ulonglong *)(local_108 + 0x18);
  local_64 = vpmovzxbd_avx2(auVar4);
  local_c8[10] = 0x2000000000000028;
  local_118 = (longlong *)0x0;
  local_110 = 0xf;
  stack0xfffffffffffffed9 = SUB1615((undefined1  [16])0x0,1);
  auVar7[0xf] = 0;
  auVar7._0_15_ = stack0xfffffffffffffed9;
  _local_128 = auVar7 << 8;
  local_148._0_4_ = 0xb;
  uVar22 = uVar21;
  do {
    bVar12 = (byte)(local_c8[uVar21] >> 0x3c);
    if (bVar12 == 0xc) {
      lVar15 = *(longlong *)(local_64 + ((local_c8[uVar21] & 0xfffffffffffffff) - 4));
    }
    else {
      lVar15 = 8;
      if (bVar12 == 0xb) {
        lVar15 = 0x20;
      }
    }
    uVar22 = uVar22 + lVar15;
    uVar21 = uVar21 + 1;
  } while (uVar21 < 0xb);
  lVar15 = uVar22 + 0x46;
  if (0xffffffffffffffb9 < uVar22) {
    lVar15 = -1;
  }
  FUN_18019f7a0(local_128,lVar15);
  local_d8 = 0xb;
  local_d0 = local_c8;
  local_108 = "{:08X}-{:04X}-{:04X}-{:02X}{:02X}-{:02X}{:02X}{:02X}{:02X}{:02X}{:02X}";
  local_100 = 0x46;
  local_168 = 0;
  FUN_18018ad00(local_158,local_128,&local_108,&local_d8);
  if (local_110 < 0x10) {
LAB_1803db5cd:
    cVar11 = (**(code **)(*plVar20 + 0x20))(plVar20);
    plVar17 = (longlong *)local_138._8_8_;
    if (cVar11 != '\0') {
      pcVar3 = param_1 + 600;
      local_158._0_8_ = pcVar3;
      iVar13 = FUN_180973810(pcVar3);
      if (iVar13 != 0) goto LAB_1803db7db;
      iVar13 = *(int *)(param_1 + 0x2a4);
      if (iVar13 == 0x7fffffff) goto LAB_1803db7e6;
      local_148 = (undefined1  [8])0x0;
      plStack_140 = (longlong *)0x0;
      if (plVar17 != (longlong *)0x0) {
        local_148 = (undefined1  [8])local_138._0_8_;
        plStack_140 = (longlong *)local_138._8_8_;
        LOCK();
        *(int *)((longlong)plVar17 + 0xc) = *(int *)((longlong)plVar17 + 0xc) + 1;
        UNLOCK();
      }
      uStack_120 = local_148;
      local_128 = (undefined1  [8])param_1;
      local_118 = plStack_140;
      _local_148 = (undefined1  [16])0x0;
      local_110 = *(ulonglong *)((undefined8)plVar20 + 8);
      FUN_1803e81e0(param_1 + 0x2a8,local_128);
      if (local_118 != (longlong *)0x0) {
        LOCK();
        piVar1 = (int *)((longlong)local_118 + 0xc);
        iVar13 = *piVar1;
        *piVar1 = *piVar1 + -1;
        UNLOCK();
        if (iVar13 == 1) {
          (**(code **)(*local_118 + 8))();
        }
      }
      FUN_180973930(pcVar3);
    }
    cVar11 = (**(code **)(*plVar20 + 0x28))(plVar20);
    puVar19 = auStack_188;
    if (cVar11 != '\0') {
      plVar20 = (longlong *)(param_1 + 600);
      local_158._0_8_ = plVar20;
      iVar13 = FUN_180973810(plVar20);
      if (iVar13 != 0) {
LAB_1803db7db:
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      iVar13 = *(int *)(param_1 + 0x2a4);
      if (iVar13 == 0x7fffffff) {
LAB_1803db7e6:
        *(int *)(param_1 + 0x2a4) = iVar13 + -1;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      uVar23 = 0;
      uVar24 = 0;
      _local_148 = (undefined1  [16])0x0;
      local_f8 = *(longlong **)(pcVar10 + 0x28);
      if (local_f8 == (longlong *)0x0) goto LAB_1803db6f5;
      local_100 = *(undefined8 *)(pcVar10 + 0x20);
      LOCK();
      *(int *)((longlong)local_f8 + 0xc) = *(int *)((longlong)local_f8 + 0xc) + 1;
      UNLOCK();
      puVar18 = auStack_188;
      uVar23 = 0;
      uVar24 = 0;
      goto LAB_1803db6ff;
    }
  }
  else {
    uVar21 = local_110 + 1;
    auVar16 = local_128;
    if (uVar21 < 0x1000) {
LAB_1803db5c8:
      thunk_FUN_180895720(auVar16,uVar21);
      goto LAB_1803db5cd;
    }
    auVar16 = *(undefined1 (*) [8])((longlong)local_128 + -8);
    if (((longlong)local_128 - (longlong)auVar16) - 8U < 0x20) {
      uVar21 = local_110 + 0x28;
      goto LAB_1803db5c8;
    }
    pcVar5 = (code *)swi(0x29);
    uVar23 = (*pcVar5)(5);
    puVar18 = auStack_180;
    uVar24 = extraout_XMM0_Qb;
LAB_1803db6f5:
    local_f8 = *(longlong **)(puVar18 + 0x48);
    local_100 = *(undefined8 *)(puVar18 + 0x40);
LAB_1803db6ff:
    *(undefined8 *)(puVar18 + 0x40) = uVar23;
    *(undefined8 *)(puVar18 + 0x48) = uVar24;
    *(undefined8 *)(puVar18 + -8) = 0x1803db721;
    local_108 = param_1;
    FUN_1803e8340(param_1 + 0x2a8,&local_108);
    if (local_f8 != (longlong *)0x0) {
      LOCK();
      piVar1 = (int *)((longlong)local_f8 + 0xc);
      iVar13 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar13 == 1) {
        pcVar5 = *(code **)(*local_f8 + 8);
        *(undefined8 *)(puVar18 + -8) = 0x1803db73e;
        (*pcVar5)();
      }
    }
    *(undefined8 *)(puVar18 + -8) = 0x1803db747;
    FUN_180973930(plVar20);
    puVar19 = puVar18;
  }
  if (plVar17 != (longlong *)0x0) {
    LOCK();
    plVar20 = plVar17 + 1;
    lVar15 = *plVar20;
    *(int *)plVar20 = (int)*plVar20 + -1;
    UNLOCK();
    if ((int)lVar15 == 1) {
      pcVar5 = *(code **)*plVar17;
      *(undefined8 *)(puVar19 + -8) = 0x1803db762;
      (*pcVar5)(plVar17);
      LOCK();
      piVar1 = (int *)((longlong)plVar17 + 0xc);
      iVar13 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar13 == 1) {
        pcVar5 = *(code **)(*plVar17 + 8);
        *(undefined8 *)(puVar19 + -8) = 0x1803db777;
        (*pcVar5)(plVar17);
      }
    }
  }
LAB_1803db77f:
  FUN_180973930(pcVar2);
  return;
}

