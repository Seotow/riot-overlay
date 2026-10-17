// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803e6330; descriptive alias: start_feature_challenge
// Evidence: ev_bb0a23149cb93ee8c1227ca5d9e0ad5949a27fa6489a60477003cbc3b4058885
// Original Evidence: rea-authentication-start-handler.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1803e6330(undefined8 param_1,longlong *param_2,undefined8 param_3)

{
  undefined1 (*pauVar1) [16];
  longlong *plVar2;
  code *pcVar3;
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  longlong lVar7;
  byte bVar8;
  char cVar9;
  NTSTATUS NVar10;
  undefined4 uVar11;
  undefined1 (*pauVar12) [16];
  undefined4 *puVar13;
  undefined1 *puVar14;
  ulonglong uVar15;
  ulonglong uVar16;
  longlong lVar17;
  undefined1 auStack_168 [8];
  undefined1 auStack_160 [24];
  undefined8 local_148;
  undefined4 local_138 [4];
  undefined1 (*local_128) [16];
  undefined1 (*local_120) [16];
  undefined1 local_118 [16];
  undefined8 local_108;
  ulonglong local_100;
  char *local_f8;
  undefined8 local_f0;
  ulonglong local_e8 [11];
  undefined4 local_90;
  undefined1 local_8c [8];
  undefined1 local_84 [32];
  undefined1 local_58 [16];
  ulonglong local_48;
  
  puVar14 = auStack_168;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_168;
  uVar15 = 0;
  local_90 = (undefined4)param_2[9];
  local_e8[0] = 0x2000000000000000;
  local_e8[1] = 0x2000000000000004;
  auVar4 = vpmovzxwd_avx(ZEXT416(*(uint *)((longlong)param_2 + 0x4c)));
  local_8c = auVar4._0_8_;
  local_e8[2] = 0x2000000000000008;
  local_e8[3] = 0x200000000000000c;
  local_e8[4] = 0x2000000000000010;
  local_e8[5] = 0x2000000000000014;
  local_e8[6] = 0x2000000000000018;
  local_e8[7] = 0x200000000000001c;
  local_e8[8] = 0x2000000000000020;
  local_e8[9] = 0x2000000000000024;
  auVar4._8_8_ = 0;
  auVar4._0_8_ = param_2[10];
  local_84 = vpmovzxbd_avx2(auVar4);
  local_e8[10] = 0x2000000000000028;
  local_108 = 0;
  local_100 = 0xf;
  local_118._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar5[0xf] = 0;
  auVar5._0_15_ = local_118._1_15_;
  local_118 = auVar5 << 8;
  local_138[0] = 2;
  uVar16 = uVar15;
  do {
    bVar8 = (byte)(local_e8[uVar15] >> 0x3c);
    if (bVar8 == 0xc) {
      lVar17 = *(longlong *)(local_84 + ((local_e8[uVar15] & 0xfffffffffffffff) - 4));
    }
    else {
      lVar17 = 8;
      if (bVar8 == 0xb) {
        lVar17 = 0x20;
      }
    }
    uVar16 = uVar16 + lVar17;
    uVar15 = uVar15 + 1;
  } while (uVar15 < 0xb);
  lVar17 = uVar16 + 0x46;
  if (0xffffffffffffffb9 < uVar16) {
    lVar17 = -1;
  }
  FUN_18019f7a0(local_118,lVar17);
  local_128 = (undefined1 (*) [16])0xb;
  local_120 = (undefined1 (*) [16])local_e8;
  local_f8 = "{:08X}-{:04X}-{:04X}-{:02X}{:02X}-{:02X}{:02X}{:02X}{:02X}{:02X}{:02X}";
  local_f0 = 0x46;
  local_148 = 0;
  FUN_18018ad00(local_58,local_118,&local_f8,&local_128);
  if (local_100 < 0x10) {
LAB_1803e6542:
    local_108 = 0;
    local_100 = 0xf;
    auVar6[0xf] = 0;
    auVar6._0_15_ = local_118._1_15_;
    local_118 = auVar6 << 8;
    *(undefined1 *)((longlong)param_2 + 0x144) = 0;
    local_58._0_12_ = ZEXT812(0);
    NVar10 = BCryptGenRandom((BCRYPT_ALG_HANDLE)0x0,local_58,0xc,2);
    if (NVar10 == 0) {
      param_2[0x27] = local_58._0_8_;
      *(undefined4 *)(param_2 + 0x28) = local_58._8_4_;
      if (*(char *)((longlong)param_2 + 0x144) == '\0') {
        *(undefined1 *)((longlong)param_2 + 0x144) = 1;
      }
      lVar17 = param_2[0x27];
      lVar7 = param_2[0x28];
      pauVar12 = (undefined1 (*) [16])FUN_180976d80(0x98);
      *pauVar12 = (undefined1  [16])0x0;
      *(undefined4 *)(*pauVar12 + 8) = 1;
      *(undefined4 *)(*pauVar12 + 0xc) = 1;
      *(undefined ***)*pauVar12 = &PTR_FUN_180c5c310;
      pauVar1 = pauVar12 + 1;
      *(undefined8 *)*pauVar1 = 0;
      pauVar12[1][8] = 0;
      *(undefined8 *)pauVar12[2] = 0x14;
      *(undefined4 *)(pauVar12[2] + 8) = 0x7fffffff;
      *(undefined8 *)pauVar12[3] = 8;
      *(undefined8 *)(pauVar12[3] + 8) = 0;
      *(undefined4 *)pauVar12[4] = 0;
      *(undefined8 *)(pauVar12[4] + 8) = 0;
      *(undefined8 *)pauVar12[5] = 0;
      *(undefined8 *)(pauVar12[5] + 8) = 0;
      *(undefined4 *)pauVar12[6] = 0;
      *(undefined2 *)(pauVar12[6] + 4) = 0;
      *(undefined8 *)(pauVar12[6] + 8) = 0;
      *(undefined2 *)pauVar12[7] = 1;
      *(undefined8 *)(pauVar12[7] + 8) = 1;
      *(undefined2 *)pauVar12[8] = 0x100;
      *(undefined8 *)(pauVar12[8] + 8) = 0;
      *(undefined8 *)pauVar12[9] = 0;
      local_58._8_8_ = pauVar12;
      local_58._0_8_ = pauVar1;
      FUN_1801c5410(pauVar1,0xc);
      *(longlong *)pauVar12[5] = *(longlong *)pauVar12[5] + -0xc;
      *(int *)pauVar12[4] = *(int *)pauVar12[4] + 0xc;
      plVar2 = *(longlong **)pauVar12[5];
      *plVar2 = lVar17;
      *(int *)(plVar2 + 1) = (int)lVar7;
      uVar11 = *(undefined4 *)pauVar12[4];
      FUN_1801c5410(pauVar1,8);
      puVar13 = *(undefined4 **)(pauVar12[5] + 8);
      *puVar13 = uVar11;
      *(undefined2 *)(puVar13 + 1) = 4;
      *(undefined2 *)((longlong)puVar13 + 6) = local_58._6_2_;
      *(longlong *)(pauVar12[5] + 8) = *(longlong *)(pauVar12[5] + 8) + 8;
      *(int *)pauVar12[6] = *(int *)pauVar12[6] + 1;
      if (*(ushort *)(pauVar12[6] + 4) < 4) {
        *(undefined2 *)(pauVar12[6] + 4) = 4;
      }
      uVar11 = FUN_1801be990(pauVar1,0);
      local_148 = param_3;
      puVar13 = (undefined4 *)FUN_1801b3ec0(local_138,pauVar1,5,uVar11);
      FUN_1801c3db0(pauVar1,*puVar13);
      local_58 = (undefined1  [16])0x0;
      local_128 = pauVar1;
      local_120 = pauVar12;
      FUN_1803bd970(param_2,&local_128,0);
      goto LAB_1803e6750;
    }
    FUN_180395d90();
    FUN_1803f96c0();
    cVar9 = (**(code **)(*param_2 + 0x20))(param_2);
    puVar14 = auStack_168;
    if (cVar9 != '\0') {
      *(undefined4 *)(param_2 + 7) = 2;
      LOCK();
      *(undefined4 *)(param_2 + 5) = 0;
      UNLOCK();
      FUN_1802d5df0(param_2 + 6);
      (**(code **)*param_2)(param_2);
      puVar14 = auStack_168;
      goto LAB_1803e6750;
    }
  }
  else {
    uVar16 = local_100 + 1;
    lVar17 = local_118._0_8_;
    if (uVar16 < 0x1000) {
LAB_1803e653d:
      thunk_FUN_180895720(lVar17,uVar16);
      goto LAB_1803e6542;
    }
    lVar17 = *(longlong *)(local_118._0_8_ + -8);
    if ((local_118._0_8_ - lVar17) - 8U < 0x20) {
      uVar16 = local_100 + 0x28;
      goto LAB_1803e653d;
    }
    pcVar3 = (code *)swi(0x29);
    (*pcVar3)(5);
    puVar14 = auStack_160;
  }
  *(undefined8 *)(puVar14 + -8) = 0x1803e65cd;
  FUN_1803da020(param_2,param_3);
LAB_1803e6750:
  *(undefined8 *)(puVar14 + -8) = 0x1803e675c;
  return;
}

