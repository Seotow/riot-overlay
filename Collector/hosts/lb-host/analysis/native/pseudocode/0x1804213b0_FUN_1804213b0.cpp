// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804213b0; descriptive alias: FUN_1804213b0
// Evidence: ev_9385312074550b8ef775c24e8923570e433ae27b6f20ef7e6721a9f579c3eb55
// Original Evidence: rea-collector/0x1804213b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1804213b0(undefined8 *param_1,undefined8 *param_2)

{
  uint uVar1;
  undefined8 uVar2;
  char cVar3;
  
  cVar3 = FUN_1801fa260(param_2);
  if (cVar3 != '\0') {
    uVar1 = *(uint *)(param_2 + 1);
    if (((uVar1 - 1 < 0x80) && (*(uint *)((longlong)param_2 + 0xc) - 1 < 0x80)) &&
       (uVar1 <= *(uint *)((longlong)param_2 + 0xc))) {
      uVar2 = *param_2;
      cVar3 = FUN_1801fa260(uVar2);
      if (cVar3 != '\0') {
        *param_1 = uVar2;
        param_1[1] = (ulonglong)uVar1;
        return param_1;
      }
    }
  }
  *param_1 = &DAT_180c0f302;
  param_1[1] = 0;
  return param_1;
}

