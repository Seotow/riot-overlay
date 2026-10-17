// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421b50; descriptive alias: FUN_180421b50
// Evidence: ev_247e26b47d251f8a5969174327ef2428c420df2fd2ad7dbeafff5986c3dea0e5
// Original Evidence: rea-collector/0x180421b50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined4 * FUN_180421b50(undefined4 *param_1)

{
  BOOL BVar1;
  LPCVOID pvVar2;
  HANDLE pvVar3;
  ulonglong uVar4;
  undefined1 auStackY_58 [32];
  ulonglong local_28;
  undefined4 local_20 [2];
  SIZE_T local_18;
  ulonglong local_10;
  
  local_10 = DAT_180d06cc0 ^ (ulonglong)auStackY_58;
  local_28 = 0;
  if (DAT_180d29ed0 == '\0') {
    uVar4 = DAT_180d29a68 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar4 = FUN_18052c740(&DAT_180d29a68,0);
  }
  local_20[0] = 0;
  if ((uVar4 != 0) &&
     (pvVar2 = (LPCVOID)FUN_1801f3090(&DAT_180d295f8), (longlong)pvVar2 - 1U < 0xfffffffffffffff8))
  {
    local_18 = 0;
    pvVar3 = GetCurrentProcess();
    BVar1 = ReadProcessMemory(pvVar3,pvVar2,&local_28,8,&local_18);
    if (((BVar1 != 0) && (((local_18 == 8 && (local_28 != 0)) && (local_28 <= ~uVar4)))) &&
       (pvVar2 = (LPCVOID)(uVar4 + local_28), (longlong)pvVar2 - 1U < 0xfffffffffffffffc)) {
      local_18 = 0;
      pvVar3 = GetCurrentProcess();
      BVar1 = ReadProcessMemory(pvVar3,pvVar2,local_20,4,&local_18);
      if ((BVar1 != 0) && (local_18 == 4)) {
        *param_1 = local_20[0];
        *(undefined1 *)(param_1 + 1) = 1;
        return param_1;
      }
    }
  }
  *(undefined1 *)(param_1 + 1) = 0;
  return param_1;
}

