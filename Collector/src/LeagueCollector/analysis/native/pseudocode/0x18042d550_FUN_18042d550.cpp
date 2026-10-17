// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d550; descriptive alias: FUN_18042d550
// Evidence: ev_57e9252f7e31640277e56bf58383f81747005dc644ce0561ff233825078595b4
// Original Evidence: rea-collector/0x18042d550.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_18042d550(undefined8 *param_1)

{
  undefined4 *puVar1;
  code *pcVar2;
  DWORD DVar3;
  int iVar4;
  SIZE_T SVar5;
  HANDLE pvVar6;
  undefined8 uVar7;
  undefined4 uVar8;
  longlong lVar9;
  undefined4 *lpAddress;
  undefined4 *puVar10;
  bool bVar11;
  undefined1 auStack_a8 [32];
  undefined4 *local_88;
  undefined8 local_80;
  code **local_78;
  undefined4 local_68;
  undefined8 *local_64;
  undefined4 local_5c;
  code *local_58;
  longlong local_50;
  _MEMORY_BASIC_INFORMATION local_48;
  _FILETIME local_18;
  ulonglong local_10;
  
  local_10 = DAT_180d06cc0 ^ (ulonglong)auStack_a8;
  LOCK();
  bVar11 = DAT_180d6e9d0 == 0;
  if (bVar11) {
    DAT_180d6e9d0 = 1;
  }
  UNLOCK();
  if ((bVar11) && (DAT_180d6e9a8 != 0)) {
    LOCK();
    *(undefined4 *)(DAT_180d6e9a8 + 8) = 1;
    UNLOCK();
    DVar3 = GetCurrentThreadId();
    puVar10 = (undefined4 *)0x0;
    *(DWORD *)(DAT_180d6e9a8 + 0x10) = DVar3;
    local_18.dwLowDateTime = 0;
    local_18.dwHighDateTime = 0;
    GetSystemTimeAsFileTime(&local_18);
    lVar9 = DAT_180d6e9a8;
    *(_FILETIME *)(DAT_180d6e9a8 + 0x18) = local_18;
    uVar8 = 0;
    lpAddress = puVar10;
    if ((param_1 != (undefined8 *)0x0) &&
       (puVar1 = (undefined4 *)*param_1, puVar1 != (undefined4 *)0x0)) {
      uVar8 = *puVar1;
      lpAddress = *(undefined4 **)(puVar1 + 4);
    }
    *(undefined4 *)(lVar9 + 0x14) = uVar8;
    *(undefined4 **)(lVar9 + 0x20) = lpAddress;
    local_48.BaseAddress = (PVOID)0x0;
    local_48.AllocationBase = (HMODULE)0x0;
    local_48.AllocationProtect = 0;
    local_48._20_4_ = 0;
    local_48.RegionSize = 0;
    local_48.State = 0;
    local_48.Protect = 0;
    local_48.Type = 0;
    local_48._44_4_ = 0;
    if ((lpAddress != (undefined4 *)0x0) &&
       (SVar5 = VirtualQuery(lpAddress,&local_48,0x30), lVar9 = DAT_180d6e9a8, SVar5 != 0)) {
      *(longlong *)(DAT_180d6e9a8 + 0x28) = (longlong)lpAddress - (longlong)local_48.AllocationBase;
      GetModuleFileNameW(local_48.AllocationBase,(LPWSTR)(lVar9 + 0x38),0x104);
      lVar9 = DAT_180d6e9a8;
      *(undefined2 *)(DAT_180d6e9a8 + 0x23e) = 0;
    }
    pcVar2 = DAT_180d6e9b8;
    if (DAT_180d6e9b8 == (code *)0x0) {
      *(undefined4 *)(lVar9 + 0x34) = 0x7f;
    }
    else {
      local_68 = *(undefined4 *)(lVar9 + 0x10);
      local_58 = FUN_18042d470;
      local_5c = 0;
      local_64 = param_1;
      local_50 = lVar9;
      DVar3 = GetCurrentProcessId();
      pvVar6 = GetCurrentProcess();
      local_88 = &local_68;
      if (param_1 == (undefined8 *)0x0) {
        local_88 = puVar10;
      }
      local_78 = &local_58;
      local_80 = 0;
      iVar4 = (*pcVar2)(pvVar6,DVar3,0,0x1040);
      lVar9 = DAT_180d6e9a8;
      if (iVar4 == 0) {
        if (*(int *)(DAT_180d6e9a8 + 0x34) == 0) {
          DVar3 = GetLastError();
          lVar9 = DAT_180d6e9a8;
          *(DWORD *)(DAT_180d6e9a8 + 0x34) = DVar3;
          if (DVar3 == 0) {
            *(undefined4 *)(lVar9 + 0x34) = 0x1f;
          }
        }
        *(undefined4 *)(lVar9 + 0x30) = 0;
      }
    }
    LOCK();
    *(undefined4 *)(lVar9 + 8) = 2;
    UNLOCK();
    SetEvent(DAT_180d6e9c0);
  }
  if (((param_1 == (undefined8 *)0x0) || (DAT_180d6e9b0 == (code *)0x0)) ||
     (DAT_180d6e9b0 == FUN_18042d550)) {
    uVar7 = 0;
  }
  else {
    uVar7 = (*DAT_180d6e9b0)(param_1);
  }
  return uVar7;
}

