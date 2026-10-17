// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432830; descriptive alias: FUN_180432830
// Evidence: ev_4e287ee24cdea591fdd694ff85042ca9d329544ac014ffcb609c305d9ff9a6e2
// Original Evidence: rea-collector/0x180432830.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Heritage AFTER dead removal. Example location: s0xffffffffffffffe8 : 0x000180432a30 */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

ulonglong FUN_180432830(byte *param_1)

{
  undefined1 auVar1 [32];
  byte bVar2;
  undefined1 auVar3 [16];
  undefined1 auVar4 [32];
  undefined1 auVar5 [32];
  int iVar6;
  ulonglong uVar7;
  ulonglong uVar8;
  uint uVar9;
  uint uVar10;
  undefined1 auVar11 [16];
  undefined1 auVar12 [16];
  undefined1 in_ZMM3 [64];
  undefined1 in_ZMM4 [64];
  undefined1 auStackX_8 [32];
  undefined1 local_18 [8];
  ulonglong local_10;
  
  local_10 = DAT_180d06cc0 ^ (ulonglong)local_18;
  if (param_1[5] != 1) {
    return (DAT_180d06cc0 ^ (ulonglong)local_18) & 0xffffffffffffff00;
  }
  uVar8 = 0;
  bVar2 = param_1[6];
  uVar10 = (uint)bVar2;
  auVar3 = vpcmpeqd_avx(in_ZMM4._0_16_,in_ZMM4._0_16_);
  auVar5 = vpcmpeqd_avx2(in_ZMM3._0_32_,in_ZMM3._0_32_);
  local_18[0] = *param_1;
  local_18[1] = param_1[(ulonglong)param_1[8] + 1];
  if (1 < bVar2) {
    if (0x1f < bVar2) {
      do {
        iVar6 = (int)uVar8;
        uVar7 = (ulonglong)(iVar6 + 8);
        auVar4 = vpandn_avx2(*(undefined1 (*) [32])(local_18 + uVar8 * 4),auVar5);
        auVar1 = *(undefined1 (*) [32])(local_18 + uVar7 * 4);
        *(undefined1 (*) [32])(local_18 + uVar8 * 4 + 1) =
             auVar4 ^ *(undefined1 (*) [32])(local_18 + uVar8 * 4 + 1);
        auVar1 = vpandn_avx2(auVar1,auVar5);
        *(undefined1 (*) [32])(local_18 + uVar7 * 4 + 1) =
             auVar1 ^ *(undefined1 (*) [32])(local_18 + uVar7 * 4 + 1);
        uVar8 = (ulonglong)(iVar6 + 0x10);
        auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_18 + uVar8 * 4),auVar5);
        *(undefined1 (*) [32])(local_18 + uVar8 * 4 + 1) =
             auVar1 ^ *(undefined1 (*) [32])(local_18 + uVar8 * 4 + 1);
        uVar7 = (ulonglong)(iVar6 + 0x18);
        uVar8 = (ulonglong)(iVar6 + 0x20U);
        auVar1 = vpandn_avx2(*(undefined1 (*) [32])(local_18 + uVar7 * 4),auVar5);
        *(undefined1 (*) [32])(local_18 + uVar7 * 4 + 1) =
             auVar1 ^ *(undefined1 (*) [32])(local_18 + uVar7 * 4 + 1);
      } while (iVar6 + 0x20U < (uVar10 & 0xffffffe0));
      if ((bVar2 & 0x1e) == 0) goto LAB_180432931;
    }
    do {
      auVar11._8_8_ = 0;
      auVar11._0_8_ = *(ulonglong *)(local_18 + uVar8 * 4);
      auVar11 = vpandn_avx(auVar11,auVar3);
      *(ulonglong *)(local_18 + uVar8 * 4 + 1) =
           auVar11._0_8_ ^ *(ulonglong *)(local_18 + uVar8 * 4 + 1);
      uVar9 = (int)uVar8 + 2;
      uVar8 = (ulonglong)uVar9;
    } while (uVar9 < (uVar10 & 0xfffffffe));
  }
LAB_180432931:
  uVar9 = (uint)uVar8;
  while (uVar9 < uVar10) {
    *(uint *)(local_18 + uVar8 * 4 + 1) =
         *(uint *)(local_18 + uVar8 * 4 + 1) ^ ~*(uint *)(local_18 + uVar8 * 4);
    uVar9 = (int)uVar8 + 1;
    uVar8 = (ulonglong)uVar9;
  }
  bVar2 = param_1[7];
  uVar8 = 1 - (ulonglong)bVar2;
  if (uVar8 == 0) {
    if (7 < bVar2) {
      uVar8 = 0;
      if (0x7f < bVar2) {
        uVar8 = 0;
        do {
          auVar4 = vpandn_avx2(*(undefined1 (*) [32])(local_18 + uVar8),auVar5);
          auVar1 = *(undefined1 (*) [32])(auStackX_8 + uVar8);
          *(undefined1 (*) [32])(local_18 + uVar8 + 1) =
               auVar4 ^ *(undefined1 (*) [32])(local_18 + uVar8 + 1);
          auVar4 = vpandn_avx2(auVar1,auVar5);
          auVar1 = *(undefined1 (*) [32])(&stack0x00000028 + uVar8);
          *(undefined1 (*) [32])(auStackX_8 + uVar8 + 1) =
               auVar4 ^ *(undefined1 (*) [32])(auStackX_8 + uVar8 + 1);
          auVar1 = vpandn_avx2(auVar1,auVar5);
          *(undefined1 (*) [32])(&stack0x00000029 + uVar8) =
               auVar1 ^ *(undefined1 (*) [32])(&stack0x00000029 + uVar8);
          auVar1 = vpandn_avx2(*(undefined1 (*) [32])(&stack0x00000048 + uVar8),auVar5);
          *(undefined1 (*) [32])(&stack0x00000049 + uVar8) =
               auVar1 ^ *(undefined1 (*) [32])(&stack0x00000049 + uVar8);
          uVar8 = uVar8 + 0x80;
        } while (uVar8 < 1 - (ulonglong)(bVar2 & 0x7f));
        if ((bVar2 & 0x78) == 0) goto LAB_180432a22;
      }
      do {
        auVar12._8_8_ = 0;
        auVar12._0_8_ = *(ulonglong *)(local_18 + uVar8);
        auVar11 = vpandn_avx(auVar12,auVar3);
        *(ulonglong *)(local_18 + uVar8 + 1) = auVar11._0_8_ ^ *(ulonglong *)(local_18 + uVar8 + 1);
        uVar8 = uVar8 + 8;
      } while (uVar8 < 1 - (ulonglong)(bVar2 & 7));
      goto LAB_180432a22;
    }
  }
  else {
LAB_180432a22:
    if (uVar8 != 0) goto LAB_180432a43;
  }
  local_18[1] = local_18[1] ^ ~local_18[0];
LAB_180432a43:
  return (ulonglong)local_18[1];
}

