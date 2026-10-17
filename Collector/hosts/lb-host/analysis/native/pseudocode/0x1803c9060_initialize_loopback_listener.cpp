// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803c9060; descriptive alias: initialize_loopback_listener
// Evidence: ev_7b69d735f11b77b4a39273d4373a0adc54c7122333be5947737b4d0aa4a6845a
// Original Evidence: rea-ipc-init.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

longlong * FUN_1803c9060(longlong *param_1)

{
  undefined4 uVar1;
  int iVar2;
  longlong lVar3;
  undefined1 auStack_78 [32];
  undefined2 local_58;
  longlong *local_48;
  undefined2 local_40;
  undefined2 local_3e;
  undefined4 local_3c;
  undefined1 local_38;
  undefined4 local_37;
  undefined2 local_33;
  undefined1 local_31;
  ulonglong local_30;
  
  local_30 = DAT_180d06cc0 ^ (ulonglong)auStack_78;
  local_58 = 0x1386;
  local_48 = param_1;
  lVar3 = Ordinal_23(2,1,6);
  local_48 = (longlong *)lVar3;
  if (lVar3 == -1) {
    FUN_1803c9d40();
    uVar1 = Ordinal_111();
    *(undefined4 *)param_1 = uVar1;
    *(undefined1 *)(param_1 + 1) = 0;
  }
  else {
    local_40 = 2;
    local_3e = Ordinal_9(0x1386);
    local_3c = Ordinal_8(0x7f000001);
    local_38 = 0;
    local_37 = 0;
    local_33 = 0;
    local_31 = 0;
    iVar2 = Ordinal_2(lVar3,&local_40,0x10);
    if (iVar2 == 0) {
      iVar2 = Ordinal_13(lVar3,0x7fffffff);
      if (iVar2 == 0) {
        *param_1 = lVar3;
        *(undefined1 *)(param_1 + 1) = 1;
        return param_1;
      }
      FUN_1803ca450();
    }
    else {
      FUN_1803ca0f0();
    }
    uVar1 = Ordinal_111();
    *(undefined4 *)param_1 = uVar1;
    *(undefined1 *)(param_1 + 1) = 0;
    Ordinal_3(lVar3);
  }
  return param_1;
}

