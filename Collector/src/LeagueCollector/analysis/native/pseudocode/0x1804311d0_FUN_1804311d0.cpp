// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804311d0; descriptive alias: FUN_1804311d0
// Evidence: ev_fc0cd0f061977b186afb4e1b5960f8a11158ca9e575e6cc393456750e7b77009
// Original Evidence: rea-collector/0x1804311d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1804311d0(undefined8 *param_1,char *param_2)

{
  byte bVar1;
  char cVar2;
  longlong lVar3;
  
  cVar2 = FUN_1801fa260(param_2);
  if (cVar2 != '\0') {
    bVar1 = param_2[0x10];
    if (((((byte)(bVar1 - 1) < 0x80) && ((byte)(param_2[0x18] - 1U) < 0x40)) &&
        (bVar1 <= (byte)param_2[0x18])) &&
       (((*param_2 != '\0' || (param_2[1] != '\0')) ||
        ((param_2[2] != '\0' || (param_2[3] != '\0')))))) {
      if ((0xf < bVar1) || (lVar3 = FUN_1809bf980(param_2,0,(ulonglong)bVar1), lVar3 != 0)) {
        param_2 = *(char **)param_2;
        cVar2 = FUN_1801fa260(param_2);
        if (cVar2 == '\0') {
          param_1[1] = 0;
          *param_1 = &DAT_180c0f302;
          return param_1;
        }
      }
      *param_1 = param_2;
      param_1[1] = (ulonglong)bVar1;
      return param_1;
    }
  }
  *param_1 = &DAT_180c0f302;
  param_1[1] = 0;
  return param_1;
}

