// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804313a0; descriptive alias: FUN_1804313a0
// Evidence: ev_50df9033e8a90c72f1513ff09672266cd6a2e5c3fe2f502547080e8c3459e5d5
// Original Evidence: rea-collector/0x1804313a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_1804313a0(longlong param_1,undefined8 param_2)

{
  uint uVar1;
  undefined1 auStack_38 [32];
  longlong local_18;
  ulonglong local_10;
  
  local_10 = DAT_180d06cc0 ^ (ulonglong)auStack_38;
  if (DAT_180d2e178 == '\0') {
    uVar1 = DAT_180d2dd10 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d2dd10);
  }
  local_18 = (ulonglong)uVar1 + param_1;
  if (PTR_PTR_180d0fac8 != (undefined *)0x0) {
    (**(code **)(*(longlong *)PTR_PTR_180d0fac8 + 0x10))(PTR_PTR_180d0fac8,param_2,&local_18);
    return param_2;
  }
                    /* WARNING: Subroutine does not return */
  FUN_18096ee50();
}

