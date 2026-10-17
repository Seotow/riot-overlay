// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180433db0; descriptive alias: FUN_180433db0
// Evidence: ev_14b79b91dab73641ab4a09939a796424fbbf653480f5099897f4d1f14e124007
// Original Evidence: rea-collector/0x180433db0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * FUN_180433db0(undefined8 param_1,undefined8 *param_2,undefined8 *param_3)

{
  code *pcVar1;
  undefined8 *puVar2;
  ulonglong uVar3;
  longlong lVar4;
  undefined1 auStack_88 [40];
  undefined8 *local_60;
  undefined1 *local_58;
  undefined4 local_50;
  undefined4 local_4c;
  undefined8 local_48;
  undefined1 local_40 [16];
  undefined8 local_30;
  ulonglong local_28;
  ulonglong local_20;
  
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_88;
  pcVar1 = (code *)0x0;
  local_40 = (undefined1  [16])0x0;
  local_30 = 0;
  local_28 = 0;
  local_60 = param_2;
  FUN_1801a0b30(local_40,*param_3,param_3[1]);
  local_58 = local_40;
  if (0xf < local_28) {
    local_58 = (undefined1 *)local_40._0_8_;
  }
  local_50 = (undefined4)local_30;
  local_48 = 0;
  local_60 = (undefined8 *)0x0;
  local_4c = local_50;
  if (DAT_180d68ba8 == '\0') {
    uVar3 = _DAT_180d68740 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar3 = FUN_18052c740(&DAT_180d68740,0);
  }
  if (uVar3 != 0) {
    pcVar1 = (code *)(DAT_180d20bd0 + uVar3);
  }
  (*pcVar1)(param_1,&local_60,&local_58);
  *param_2 = local_60;
  if (0xf < local_28) {
    uVar3 = local_28 + 1;
    lVar4 = local_40._0_8_;
    if (0xfff < uVar3) {
      lVar4 = *(longlong *)(local_40._0_8_ + -8);
      if (0x1f < (local_40._0_8_ - lVar4) - 8U) {
        pcVar1 = (code *)swi(0x29);
        (*pcVar1)(5);
        pcVar1 = (code *)swi(3);
        puVar2 = (undefined8 *)(*pcVar1)();
        return puVar2;
      }
      uVar3 = local_28 + 0x28;
    }
    thunk_FUN_180895720(lVar4,uVar3);
  }
  return param_2;
}

