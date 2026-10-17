// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180441340; descriptive alias: FUN_180441340
// Evidence: ev_beca7cd29c67443eb99b659c0be22f0e2ecf0c3a734b32948f8c07aeebb88df8
// Original Evidence: rea-collector/0x180441340.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_180441340(longlong param_1)

{
  int iVar1;
  undefined4 *puVar2;
  int iVar3;
  int iVar4;
  char cVar5;
  undefined4 uVar6;
  longlong lVar7;
  undefined8 *puVar8;
  char *pcVar9;
  size_t sVar10;
  ulonglong uVar11;
  char *_Str;
  int local_68;
  undefined2 local_62;
  undefined8 local_58;
  undefined8 uStack_50;
  undefined1 local_48 [24];
  
  lVar7 = FUN_180421af0();
  if (lVar7 == 0) {
    cVar5 = '\0';
  }
  else {
    cVar5 = FUN_180421cb0(lVar7);
  }
  puVar8 = (undefined8 *)FUN_180438a20(local_48);
  local_58 = *puVar8;
  uStack_50 = puVar8[1];
  FUN_180433ef0(param_1,&local_68,&local_58);
  if (DAT_180d21e18 == '\0') {
    uVar11 = _DAT_180d219b0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar11 = FUN_18052c740(&DAT_180d219b0,0);
  }
  iVar3 = local_68;
  if (uVar11 == 0) {
    sVar10 = 0;
    _Str = (char *)0x0;
  }
  else {
    pcVar9 = (char *)(*(code *)(uVar11 + DAT_180d20bd0))();
    _Str = "";
    if (pcVar9 != (char *)0x0) {
      _Str = pcVar9;
    }
    sVar10 = strlen(_Str);
  }
  FUN_1801bec10(param_1,&local_68,_Str,sVar10);
  iVar4 = local_68;
  *(undefined1 *)(param_1 + 0x60) = 1;
  iVar1 = *(int *)(param_1 + 0x30);
  if (iVar3 != 0) {
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(undefined8 *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-iVar1 & 3);
    FUN_1801bd800(param_1,8,(*(int *)(param_1 + 0x30) - iVar3) + 4,0);
  }
  if (iVar4 != 0) {
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(ulonglong *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-*(int *)(param_1 + 0x30) & 3);
    FUN_1801bd800(param_1,4,(*(int *)(param_1 + 0x30) - iVar4) + 4,0);
  }
  if ((cVar5 != '\0') || (*(char *)(param_1 + 0x70) != '\0')) {
    if (*(longlong *)(param_1 + 0x68) == 0) {
      *(longlong *)(param_1 + 0x68) = 1;
    }
    FUN_1801c5410(param_1,1);
    *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + -1;
    *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + 1;
    **(char **)(param_1 + 0x40) = cVar5;
    uVar6 = *(undefined4 *)(param_1 + 0x30);
    FUN_1801c5410(param_1,8);
    puVar2 = *(undefined4 **)(param_1 + 0x48);
    *puVar2 = uVar6;
    *(undefined2 *)(puVar2 + 1) = 6;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_1 + 0x48) = *(longlong *)(param_1 + 0x48) + 8;
    *(int *)(param_1 + 0x50) = *(int *)(param_1 + 0x50) + 1;
    if (*(ushort *)(param_1 + 0x54) < 6) {
      *(undefined2 *)(param_1 + 0x54) = 6;
    }
  }
  uVar6 = FUN_1801be990(param_1,iVar1);
  FUN_1801b3ec0(&local_68,param_1,2,uVar6,0);
  FUN_1801c3db0(param_1,local_68);
  return;
}

