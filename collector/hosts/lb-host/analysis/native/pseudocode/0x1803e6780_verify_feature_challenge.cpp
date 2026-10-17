// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803e6780; descriptive alias: verify_feature_challenge
// Evidence: ev_3b2bc7919640ed00d9c7bc0a5a0b023def0d9cb0cdd5a453ec6d53b3f86c27f0
// Original Evidence: rea-authentication-verify-handler.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1803e6780(longlong param_1,longlong *param_2,undefined8 param_3,undefined8 *param_4,
                  undefined8 param_5)

{
  uint uVar1;
  code *pcVar2;
  undefined8 *puVar3;
  undefined8 *puVar4;
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  byte bVar8;
  char cVar9;
  int iVar10;
  longlong *plVar11;
  uint uVar12;
  undefined1 *puVar13;
  ulonglong uVar14;
  ulonglong uVar15;
  longlong lVar16;
  undefined1 auStack_168 [8];
  undefined1 auStack_160 [24];
  undefined8 local_148;
  undefined1 local_138 [16];
  undefined8 local_128;
  ulonglong local_120;
  char *local_118;
  undefined8 uStack_110;
  undefined1 local_108 [16];
  undefined8 local_f8;
  ulonglong *local_f0;
  ulonglong local_e8 [11];
  undefined4 local_90;
  undefined1 local_8c [8];
  undefined1 local_84 [32];
  uint local_58 [2];
  ulonglong local_50;
  
  local_50 = DAT_180d06cc0 ^ (ulonglong)auStack_168;
  uVar14 = 0;
  local_90 = (undefined4)param_2[9];
  local_e8[0] = 0x2000000000000000;
  local_e8[1] = 0x2000000000000004;
  auVar5 = vpmovzxwd_avx(ZEXT416(*(uint *)((longlong)param_2 + 0x4c)));
  local_8c = auVar5._0_8_;
  local_e8[2] = 0x2000000000000008;
  local_e8[3] = 0x200000000000000c;
  local_e8[4] = 0x2000000000000010;
  local_e8[5] = 0x2000000000000014;
  local_e8[6] = 0x2000000000000018;
  local_e8[7] = 0x200000000000001c;
  local_e8[8] = 0x2000000000000020;
  local_e8[9] = 0x2000000000000024;
  auVar5._8_8_ = 0;
  auVar5._0_8_ = param_2[10];
  local_84 = vpmovzxbd_avx2(auVar5);
  local_e8[10] = 0x2000000000000028;
  local_128 = 0;
  local_120 = 0xf;
  local_138._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar6[0xf] = 0;
  auVar6._0_15_ = local_138._1_15_;
  local_138 = auVar6 << 8;
  local_58[0] = 2;
  uVar15 = uVar14;
  do {
    bVar8 = (byte)(local_e8[uVar14] >> 0x3c);
    if (bVar8 == 0xc) {
      lVar16 = *(longlong *)(local_84 + ((local_e8[uVar14] & 0xfffffffffffffff) - 4));
    }
    else {
      lVar16 = 8;
      if (bVar8 == 0xb) {
        lVar16 = 0x20;
      }
    }
    uVar15 = uVar15 + lVar16;
    uVar14 = uVar14 + 1;
  } while (uVar14 < 0xb);
  lVar16 = uVar15 + 0x46;
  if (0xffffffffffffffb9 < uVar15) {
    lVar16 = -1;
  }
  FUN_18019f7a0(local_138,lVar16);
  local_f8 = 0xb;
  local_f0 = local_e8;
  local_118 = "{:08X}-{:04X}-{:04X}-{:02X}{:02X}-{:02X}{:02X}{:02X}{:02X}{:02X}{:02X}";
  uStack_110 = 0x46;
  local_148 = 0;
  FUN_18018ad00(local_108,local_138,&local_118,&local_f8);
  if (local_120 < 0x10) {
LAB_1803e6993:
    local_128 = 0;
    local_120 = 0xf;
    auVar7[0xf] = 0;
    auVar7._0_15_ = local_138._1_15_;
    local_138 = auVar7 << 8;
    local_58[0] = 0;
    local_118 = (char *)*param_4;
    uStack_110 = param_4[1];
    bVar8 = FUN_180393790(param_2,local_58,&local_118,param_5);
    cVar9 = (**(code **)(*param_2 + 0x20))(param_2);
    uVar1 = local_58[0];
    if (cVar9 == '\0') {
      if (bVar8 == 0) {
        FUN_1803f9d80();
      }
      else {
LAB_1803e6a5f:
        *(uint *)(param_2 + 0x26) = uVar1;
        *(uint *)((longlong)param_2 + 0x134) = uVar1;
        cVar9 = (**(code **)(*param_2 + 0x20))(param_2);
        if (cVar9 == '\0') {
          uVar1 = *(uint *)(param_1 + 0x2c4);
          uVar12 = uVar1 | *(uint *)(param_2 + 0x26);
          *(uint *)(param_1 + 0x2c4) = uVar12;
          LOCK();
          DAT_180d20cf0 = DAT_180d20cf0 | uVar12;
          UNLOCK();
          if (POPCOUNT(*(undefined4 *)(param_1 + 0x2c4)) != POPCOUNT(uVar1)) {
            iVar10 = FUN_180973810(param_1 + 0xb8);
            if (iVar10 != 0) {
                    /* WARNING: Subroutine does not return */
              FUN_1809737c0(5);
            }
            if (*(int *)(param_1 + 0x104) == 0x7fffffff) {
              *(undefined4 *)(param_1 + 0x104) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
              FUN_1809737c0(6);
            }
            puVar3 = *(undefined8 **)(param_1 + 0x110);
            for (puVar4 = (undefined8 *)*puVar3; puVar4 != puVar3; puVar4 = (undefined8 *)*puVar4) {
              cVar9 = (**(code **)(*(longlong *)puVar4[4] + 0x20))();
              if (cVar9 == '\0') {
                *(uint *)(puVar4[4] + 0x130) =
                     *(uint *)(puVar4[4] + 0x130) | *(uint *)(param_1 + 0x2c4);
              }
            }
            FUN_180973930(param_1 + 0xb8);
          }
        }
        else {
          LOCK();
          DAT_180d20cf0 = DAT_180d20cf0 | *(uint *)(param_2 + 0x26);
          UNLOCK();
        }
      }
      FUN_1803da1b0(param_2,param_3,(bVar8 ^ 1) + 4);
      puVar13 = auStack_168;
      goto LAB_1803e6b43;
    }
    puVar13 = auStack_168;
    if ((bVar8 != 0) && (puVar13 = auStack_168, (local_58[0] >> 9 & 1) != 0)) {
      if ((int)param_2[7] == 1) {
LAB_1803e6a13:
        bVar8 = 1;
        goto LAB_1803e6a5f;
      }
      plVar11 = (longlong *)FUN_1801fe670(local_108);
      puVar13 = auStack_168;
      if (*plVar11 < param_2[8]) {
        LOCK();
        uVar12 = *(uint *)(param_2 + 7);
        if (uVar12 == 0) {
          *(uint *)(param_2 + 7) = 1;
          uVar12 = 0;
        }
        UNLOCK();
        puVar13 = auStack_168;
        if (uVar12 < 2) goto LAB_1803e6a13;
      }
    }
  }
  else {
    uVar15 = local_120 + 1;
    lVar16 = local_138._0_8_;
    if (uVar15 < 0x1000) {
LAB_1803e698e:
      thunk_FUN_180895720(lVar16,uVar15);
      goto LAB_1803e6993;
    }
    lVar16 = *(longlong *)(local_138._0_8_ + -8);
    if ((local_138._0_8_ - lVar16) - 8U < 0x20) {
      uVar15 = local_120 + 0x28;
      goto LAB_1803e698e;
    }
    pcVar2 = (code *)swi(0x29);
    (*pcVar2)(5);
    puVar13 = auStack_160;
  }
  *(undefined4 *)((longlong)param_2 + 0x134) = 0;
  *(undefined4 *)(param_2 + 0x26) = 0;
  *(undefined4 *)(param_2 + 7) = 2;
  LOCK();
  *(undefined4 *)(param_2 + 5) = 0;
  UNLOCK();
  *(undefined8 *)(puVar13 + -8) = 0x1803e6a44;
  FUN_1802d5df0(param_2 + 6);
  pcVar2 = *(code **)*param_2;
  *(undefined8 *)(puVar13 + -8) = 0x1803e6a4c;
  (*pcVar2)(param_2);
  *(undefined8 *)(puVar13 + -8) = 0x1803e6a51;
  FUN_1803f9a20();
LAB_1803e6b43:
  *(undefined8 *)(puVar13 + -8) = 0x1803e6b4f;
  return;
}

