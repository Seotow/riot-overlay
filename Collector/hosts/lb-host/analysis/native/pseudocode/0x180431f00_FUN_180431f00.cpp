// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431f00; descriptive alias: FUN_180431f00
// Evidence: ev_9ff1e1d093492c32fe3e70d0574347e4a2116d3b92524dfa6815678f328aa685
// Original Evidence: rea-collector/0x180431f00.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_180431f00(undefined8 param_1)

{
  undefined1 auStack_38 [32];
  undefined8 local_18;
  ulonglong local_10;
  
  local_10 = DAT_180d06cc0 ^ (ulonglong)auStack_38;
  local_18 = param_1;
  if (PTR_PTR_180d0fb88 != (undefined *)0x0) {
    (**(code **)(*(longlong *)PTR_PTR_180d0fb88 + 0x10))(PTR_PTR_180d0fb88,&local_18);
    return;
  }
                    /* WARNING: Subroutine does not return */
  FUN_18096ee50();
}

