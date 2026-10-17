// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431a20; descriptive alias: FUN_180431a20
// Evidence: ev_f275ce3d4ad8d386595167201a115d88c6132911507608a0a643386dd60621a5
// Original Evidence: rea-collector/0x180431a20.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Heritage AFTER dead removal. Example location: s0xffffffffffffffd8 : 0x000180431c60 */
/* WARNING: Removing unreachable block (ram,0x000180431b9e) */
/* WARNING: Removing unreachable block (ram,0x000180431c1f) */
/* WARNING: Removing unreachable block (ram,0x000180431c30) */
/* WARNING: Removing unreachable block (ram,0x000180431ba3) */
/* WARNING: Removing unreachable block (ram,0x000180431bb0) */
/* WARNING: Removing unreachable block (ram,0x000180431c1a) */
/* WARNING: Removing unreachable block (ram,0x000180431c53) */
/* WARNING: Removing unreachable block (ram,0x000180431c58) */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

undefined8 FUN_180431a20(longlong param_1)

{
  undefined1 auVar1 [32];
  byte bVar2;
  undefined1 auVar3 [32];
  int iVar4;
  uint uVar5;
  ulonglong uVar6;
  ulonglong uVar7;
  undefined8 uVar8;
  uint uVar9;
  byte *pbVar10;
  undefined1 auVar11 [16];
  undefined1 auVar12 [16];
  undefined1 auVar13 [16];
  undefined1 auVar14 [32];
  undefined1 in_ZMM3 [64];
  undefined1 auVar15 [64];
  undefined1 auVar16 [16];
  undefined1 in_ZMM6 [64];
  undefined1 auVar17 [64];
  undefined1 auStackX_18 [16];
  undefined1 auStack_48 [32];
  undefined1 local_28 [8];
  ulonglong local_20;
  undefined1 auStack_18 [16];
  
  auVar14 = in_ZMM3._0_32_;
  auVar16 = in_ZMM6._0_16_;
  auStack_18 = auVar16;
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_48;
  if (DAT_180d2f338 == '\0') {
    uVar5 = DAT_180d2eed0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar5 = FUN_18052b510(&DAT_180d2eed0);
    auVar14 = in_ZMM3._0_32_;
    auVar16 = in_ZMM6._0_16_;
  }
  pbVar10 = (byte *)((ulonglong)uVar5 + param_1);
  auVar16 = vpcmpeqd_avx(auVar16,auVar16);
  if (pbVar10[5] == 1) {
    uVar7 = 0;
    bVar2 = pbVar10[6];
    uVar5 = (uint)bVar2;
    auVar14 = vpcmpeqd_avx2(auVar14,auVar14);
    local_28[0] = *pbVar10;
    local_28[1] = pbVar10[(ulonglong)pbVar10[8] + 1];
    if (1 < bVar2) {
      if (0x1f < bVar2) {
        do {
          iVar4 = (int)uVar7;
          uVar6 = (ulonglong)(iVar4 + 8);
          auVar3 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar7 * 4),auVar14);
          auVar1 = *(undefined1 (*) [32])(local_28 + uVar6 * 4);
          *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1) =
               auVar3 ^ *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1);
          auVar1 = vpandn_avx2(auVar1,auVar14);
          *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1) =
               auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1);
          uVar7 = (ulonglong)(iVar4 + 0x10);
          auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar7 * 4),auVar14);
          *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1) =
               auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1);
          uVar6 = (ulonglong)(iVar4 + 0x18);
          uVar7 = (ulonglong)(iVar4 + 0x20U);
          auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar6 * 4),auVar14);
          *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1) =
               auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1);
        } while (iVar4 + 0x20U < (uVar5 & 0xffffffe0));
        if ((bVar2 & 0x1e) == 0) goto LAB_180431b61;
      }
      do {
        auVar11._8_8_ = 0;
        auVar11._0_8_ = *(ulonglong *)(local_28 + uVar7 * 4);
        auVar11 = vpandn_avx(auVar11,auVar16);
        *(ulonglong *)(local_28 + uVar7 * 4 + 1) =
             auVar11._0_8_ ^ *(ulonglong *)(local_28 + uVar7 * 4 + 1);
        uVar9 = (int)uVar7 + 2;
        uVar7 = (ulonglong)uVar9;
      } while (uVar9 < (uVar5 & 0xfffffffe));
    }
LAB_180431b61:
    uVar9 = (uint)uVar7;
    while (uVar9 < uVar5) {
      *(uint *)(local_28 + uVar7 * 4 + 1) =
           *(uint *)(local_28 + uVar7 * 4 + 1) ^ ~*(uint *)(local_28 + uVar7 * 4);
      uVar9 = (int)uVar7 + 1;
      uVar7 = (ulonglong)uVar9;
    }
    if (pbVar10[7] == 1) {
      local_28[1] = local_28[1] ^ ~local_28[0];
    }
    if (local_28[1] == 0) goto LAB_180431c7e;
LAB_180431ecb:
    uVar8 = 0;
  }
  else {
LAB_180431c7e:
    if (DAT_180d2d898 == '\0') {
      uVar7 = (ulonglong)(DAT_180d2d430 + 0xe6632e3aU ^ 0x11bf48c);
    }
    else {
      auVar15 = ZEXT1664(auVar14._0_16_);
      auVar17 = ZEXT1664(auVar16);
      uVar7 = FUN_18052b510(&DAT_180d2d430);
      auVar14 = auVar15._0_32_;
      auVar16 = auVar17._0_16_;
    }
    pbVar10 = (byte *)((uVar7 & 0xffffffff) + param_1);
    if (pbVar10[5] == 1) {
      uVar7 = 0;
      bVar2 = pbVar10[6];
      uVar5 = (uint)bVar2;
      local_28[0] = *pbVar10;
      local_28[1] = pbVar10[(ulonglong)pbVar10[8] + 1];
      if (1 < bVar2) {
        if (0x1f < bVar2) {
          auVar14 = vpcmpeqd_avx2(auVar14,auVar14);
          do {
            iVar4 = (int)uVar7;
            uVar6 = (ulonglong)(iVar4 + 8);
            auVar3 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar7 * 4),auVar14);
            auVar1 = *(undefined1 (*) [32])(local_28 + uVar6 * 4);
            *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1) =
                 auVar3 ^ *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1);
            auVar1 = vpandn_avx2(auVar1,auVar14);
            *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1) =
                 auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1);
            uVar7 = (ulonglong)(iVar4 + 0x10);
            auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar7 * 4),auVar14);
            *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1) =
                 auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar7 * 4 + 1);
            uVar6 = (ulonglong)(iVar4 + 0x18);
            uVar7 = (ulonglong)(iVar4 + 0x20U);
            auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar6 * 4),auVar14);
            *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1) =
                 auVar1 ^ *(undefined1 (*) [32])(local_28 + uVar6 * 4 + 1);
          } while (iVar4 + 0x20U < (uVar5 & 0xffffffe0));
          if ((bVar2 & 0x1e) == 0) goto LAB_180431da1;
        }
        do {
          auVar12._8_8_ = 0;
          auVar12._0_8_ = *(ulonglong *)(local_28 + uVar7 * 4);
          auVar11 = vpandn_avx(auVar12,auVar16);
          *(ulonglong *)(local_28 + uVar7 * 4 + 1) =
               auVar11._0_8_ ^ *(ulonglong *)(local_28 + uVar7 * 4 + 1);
          uVar9 = (int)uVar7 + 2;
          uVar7 = (ulonglong)uVar9;
        } while (uVar9 < (uVar5 & 0xfffffffe));
      }
LAB_180431da1:
      uVar9 = (uint)uVar7;
      while (uVar9 < uVar5) {
        *(uint *)(local_28 + uVar7 * 4 + 1) =
             *(uint *)(local_28 + uVar7 * 4 + 1) ^ ~*(uint *)(local_28 + uVar7 * 4);
        uVar9 = (int)uVar7 + 1;
        uVar7 = (ulonglong)uVar9;
      }
      bVar2 = pbVar10[7];
      uVar7 = 1 - (ulonglong)bVar2;
      if (uVar7 != 0) goto joined_r0x000180431ea7;
      if (7 < bVar2) {
        uVar7 = 0;
        if (0x7f < bVar2) {
          auVar14 = vpcmpeqd_avx2(auVar14,auVar14);
          uVar7 = 0;
          do {
            auVar3 = vpandn_avx2(*(undefined1 (*) [32])(local_28 + uVar7),auVar14);
            auVar1 = *(undefined1 (*) [32])(&stack0xfffffffffffffff8 + uVar7);
            *(undefined1 (*) [32])(local_28 + uVar7 + 1) =
                 auVar3 ^ *(undefined1 (*) [32])(local_28 + uVar7 + 1);
            auVar1 = vpandn_avx2(auVar1,auVar14);
            *(undefined1 (*) [32])(&stack0xfffffffffffffff9 + uVar7) =
                 auVar1 ^ *(undefined1 (*) [32])(&stack0xfffffffffffffff9 + uVar7);
            auVar3 = vpandn_avx2(*(undefined1 (*) [32])(auStackX_18 + uVar7),auVar14);
            auVar1 = *(undefined1 (*) [32])(&stack0x00000038 + uVar7);
            *(undefined1 (*) [32])(auStackX_18 + uVar7 + 1) =
                 auVar3 ^ *(undefined1 (*) [32])(auStackX_18 + uVar7 + 1);
            auVar1 = vpandn_avx2(auVar1,auVar14);
            *(undefined1 (*) [32])(&stack0x00000039 + uVar7) =
                 auVar1 ^ *(undefined1 (*) [32])(&stack0x00000039 + uVar7);
            uVar7 = uVar7 + 0x80;
          } while (uVar7 < 1 - (ulonglong)(bVar2 & 0x7f));
          if ((bVar2 & 0x78) == 0) goto joined_r0x000180431ea7;
        }
        do {
          auVar13._8_8_ = 0;
          auVar13._0_8_ = *(ulonglong *)(local_28 + uVar7);
          auVar11 = vpandn_avx(auVar13,auVar16);
          *(ulonglong *)(local_28 + uVar7 + 1) =
               auVar11._0_8_ ^ *(ulonglong *)(local_28 + uVar7 + 1);
          uVar7 = uVar7 + 8;
          if (1 - (ulonglong)(bVar2 & 7) <= uVar7) goto joined_r0x000180431ea7;
        } while( true );
      }
      do {
        local_28[1] = local_28[1] ^ ~local_28[0];
        uVar7 = 1;
joined_r0x000180431ea7:
      } while (uVar7 == 0);
      if (local_28[1] != 0) goto LAB_180431ecb;
    }
    uVar8 = 1;
  }
  return uVar8;
}

