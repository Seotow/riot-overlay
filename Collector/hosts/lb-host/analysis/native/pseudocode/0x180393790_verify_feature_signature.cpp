// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180393790; descriptive alias: verify_feature_signature
// Evidence: ev_fd4ccf26a8ecab26267bcba7a556ccf88402c851181e113e91b7015296579086
// Original Evidence: rea-signature-verification.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

ulonglong FUN_180393790(longlong param_1,uint *param_2,longlong *param_3,undefined8 param_4)

{
  undefined4 uVar1;
  code *pcVar2;
  int iVar3;
  ulonglong uVar4;
  longlong lVar5;
  longlong lVar6;
  undefined8 ****ppppuVar7;
  uint uVar8;
  ulonglong uVar9;
  bool bVar10;
  undefined8 extraout_XMM0_Qa;
  undefined8 uVar11;
  undefined1 auStack_a8 [32];
  longlong local_88;
  int local_78 [2];
  undefined1 local_70 [16];
  undefined8 ***local_60 [3];
  ulonglong local_48;
  ulonglong local_40;
  
  local_40 = DAT_180d06cc0 ^ (ulonglong)auStack_a8;
  if (*(char *)(param_1 + 0x144) == '\0') {
    uVar4 = FUN_180394900();
    uVar4 = uVar4 & 0xffffffffffffff00;
  }
  else {
    uVar11 = *(undefined8 *)(param_1 + 0x138);
    uVar1 = *(undefined4 *)(param_1 + 0x140);
    *(undefined1 *)(param_1 + 0x144) = 0;
    if (param_3[1] == 0) {
      uVar4 = FUN_180394c60();
      uVar4 = uVar4 & 0xffffffffffffff00;
    }
    else {
      local_70 = (undefined1  [16])0x0;
      FUN_1801c7930(&DAT_180d0f780,local_60);
      ppppuVar7 = local_60;
      if (0xf < local_48) {
        ppppuVar7 = (undefined8 ****)local_60[0];
      }
      lVar5 = FUN_18053a160(ppppuVar7,0xffffffff);
      if (lVar5 == 0) {
        FUN_180394fc0();
        uVar4 = 0;
      }
      else {
        lVar6 = FUN_18053a3e0(lVar5,0);
        FUN_18053b060(lVar5);
        if (lVar6 == 0) {
          FUN_180395320();
          uVar4 = 0;
        }
        else {
          lVar5 = FUN_18053da80();
          if (lVar5 == 0) {
            FUN_180395680();
            FUN_180540c50(lVar6);
            uVar4 = 0;
          }
          else {
            local_88 = lVar6;
            local_78[0] = FUN_18053f8f0(lVar5,0);
            if (local_78[0] == 1) {
              local_70._8_4_ = uVar1;
              local_70._0_8_ = uVar11;
              local_70._12_4_ = *(undefined4 *)*param_3;
              local_88 = 0x10;
              iVar3 = FUN_18053f490(lVar5,param_4);
              bVar10 = iVar3 == 1;
            }
            else {
              bVar10 = false;
              FUN_1803959e0(extraout_XMM0_Qa,local_78);
            }
            FUN_18053d9d0(lVar5);
            FUN_180540c50();
            if (bVar10) {
              *param_2 = 0;
              lVar5 = 0;
              uVar4 = 0;
              uVar9 = 0;
              uVar8 = 1;
              do {
                if ((uVar9 & 0x3f) == 0) {
                  uVar4 = *(ulonglong *)(*param_3 + lVar5 * 8);
                  lVar5 = lVar5 + 1;
                }
                if ((uVar4 & 1) != 0) {
                  param_2[uVar9 >> 5] = param_2[uVar9 >> 5] | uVar8;
                }
                uVar4 = uVar4 >> 1;
                uVar9 = uVar9 + 1;
                uVar8 = uVar8 << 1 | (uint)((int)uVar8 < 0);
              } while (uVar9 < 0xf);
              uVar8 = *param_2;
              if ((uVar8 & 4) != 0) {
                uVar8 = uVar8 | 2;
                *param_2 = uVar8;
              }
              if ((uVar8 & 2) != 0) {
                *param_2 = uVar8 | 1;
              }
              uVar4 = 1;
            }
            else {
              uVar4 = 0;
            }
          }
        }
      }
      if (0xf < local_48) {
        uVar9 = local_48 + 1;
        ppppuVar7 = (undefined8 ****)local_60[0];
        if (0xfff < uVar9) {
          ppppuVar7 = (undefined8 ****)local_60[0][-1];
          if (0x1f < (ulonglong)((longlong)local_60[0] + (-8 - (longlong)ppppuVar7))) {
            pcVar2 = (code *)swi(0x29);
            (*pcVar2)(5);
            pcVar2 = (code *)swi(3);
            uVar4 = (*pcVar2)();
            return uVar4;
          }
          uVar9 = local_48 + 0x28;
        }
        thunk_FUN_180895720(ppppuVar7,uVar9);
      }
    }
  }
  return uVar4;
}

