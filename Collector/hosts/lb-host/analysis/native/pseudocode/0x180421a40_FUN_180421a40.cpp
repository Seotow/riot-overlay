// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421a40; descriptive alias: FUN_180421a40
// Evidence: ev_e3e65fe8cceb51709d7c196940716ad6a5c451a45150577e238b38223034a70f
// Original Evidence: rea-collector/0x180421a40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 (*) [16] FUN_180421a40(undefined1 (*param_1) [16])

{
  char *pcVar1;
  size_t sVar2;
  ulonglong uVar3;
  char *_Str;
  
  if (DAT_180d21e18 == '\0') {
    uVar3 = _DAT_180d219b0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar3 = FUN_18052c740(&DAT_180d219b0,0);
  }
  if (uVar3 == 0) {
    sVar2 = 0;
    _Str = (char *)0x0;
  }
  else {
    pcVar1 = (char *)(*(code *)(uVar3 + DAT_180d20bd0))();
    _Str = "";
    if (pcVar1 != (char *)0x0) {
      _Str = pcVar1;
    }
    sVar2 = strlen(_Str);
  }
  *param_1 = (undefined1  [16])0x0;
  *(undefined8 *)param_1[1] = 0;
  *(undefined8 *)(param_1[1] + 8) = 0;
  FUN_1801a0b30(param_1,_Str,sVar2);
  return param_1;
}

