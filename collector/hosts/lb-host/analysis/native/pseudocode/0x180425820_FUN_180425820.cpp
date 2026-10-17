// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425820; descriptive alias: FUN_180425820
// Evidence: ev_8c9132d07347555f4d8049d594a316fe9f4b897dfb0e8b5b822cc49107d3bdd2
// Original Evidence: rea-collector/0x180425820.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180425820(longlong param_1,undefined8 *param_2)

{
  uint uVar1;
  char cVar2;
  undefined8 *puVar3;
  
  puVar3 = (undefined8 *)(((ulonglong)(DAT_180d39318 + 0xe6632e3a) ^ 0x11bf48c) + param_1);
  cVar2 = FUN_1801fa260(puVar3);
  if (cVar2 != '\0') {
    uVar1 = *(uint *)(puVar3 + 1);
    if (((uVar1 - 1 < 0x80) && (*(uint *)((longlong)puVar3 + 0xc) - 1 < 0x80)) &&
       (uVar1 <= *(uint *)((longlong)puVar3 + 0xc))) {
      *param_2 = *puVar3;
      param_2[1] = (ulonglong)uVar1;
      return param_2;
    }
  }
  param_2[1] = 0;
  *param_2 = &DAT_180c0f302;
  return param_2;
}

