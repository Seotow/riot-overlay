// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424010; descriptive alias: FUN_180424010
// Evidence: ev_9cbd7866881f8abeab549e6390cfbcbe93975b8416a33cef51d2d483cb7cba5f
// Original Evidence: rea-collector/0x180424010.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_180424010(longlong *param_1,undefined8 param_2)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined8 uVar3;
  undefined1 (*pauVar4) [16];
  longlong lVar5;
  ulonglong uVar6;
  undefined1 *puVar7;
  undefined1 auStack_88 [32];
  undefined4 local_68 [2];
  longlong local_60 [3];
  ulonglong local_48;
  undefined1 local_40 [16];
  undefined8 uStack_30;
  ulonglong uStack_28;
  ulonglong local_20;
  
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_88;
  uStack_30 = 0;
  uStack_28 = 0xf;
  local_40._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar2[0xf] = 0;
  auVar2._0_15_ = local_40._1_15_;
  local_40 = auVar2 << 8;
  pauVar4 = (undefined1 (*) [16])FUN_1801c7930(param_2,local_60);
  if (&local_40 != pauVar4) {
    if (uStack_28 < 0x10) {
LAB_1804240a1:
      local_40 = *pauVar4;
      uStack_30 = *(undefined8 *)pauVar4[1];
      uStack_28 = *(ulonglong *)(pauVar4[1] + 8);
      *(undefined8 *)pauVar4[1] = 0;
      *(undefined8 *)(pauVar4[1] + 8) = 0xf;
      (*pauVar4)[0] = 0;
      goto LAB_1804240c9;
    }
    uVar6 = uStack_28 + 1;
    lVar5 = local_40._0_8_;
    if (uVar6 < 0x1000) {
LAB_18042409c:
      thunk_FUN_180895720(lVar5,uVar6);
      goto LAB_1804240a1;
    }
    lVar5 = *(longlong *)(local_40._0_8_ + -8);
    if ((local_40._0_8_ - lVar5) - 8U < 0x20) {
      uVar6 = uStack_28 + 0x28;
      goto LAB_18042409c;
    }
LAB_1804241bb:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
LAB_1804241c2:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
LAB_1804240c9:
  if (0xf < local_48) {
    uVar6 = local_48 + 1;
    lVar5 = local_60[0];
    if (0xfff < uVar6) {
      lVar5 = *(longlong *)(local_60[0] + -8);
      if (0x1f < (local_60[0] - lVar5) - 8U) goto LAB_1804241bb;
      uVar6 = local_48 + 0x28;
    }
    thunk_FUN_180895720(lVar5,uVar6);
  }
  uVar3 = uStack_30;
  puVar7 = local_40;
  if (0xf < uStack_28) {
    puVar7 = (undefined1 *)local_40._0_8_;
  }
  local_68[0] = 1;
  FUN_180185f70(*param_1 + 0x128,local_68);
  local_68[0] = (undefined4)uVar3;
  FUN_1801877a0(*param_1 + 0x128,local_68,4);
  FUN_1801877a0(*param_1 + 0x128,puVar7,uVar3);
  if (0xf < uStack_28) {
    uVar6 = uStack_28 + 1;
    lVar5 = local_40._0_8_;
    if (0xfff < uVar6) {
      lVar5 = *(longlong *)(local_40._0_8_ + -8);
      if (0x1f < (local_40._0_8_ - lVar5) - 8U) goto LAB_1804241c2;
      uVar6 = uStack_28 + 0x28;
    }
    thunk_FUN_180895720(lVar5,uVar6);
  }
  return;
}

