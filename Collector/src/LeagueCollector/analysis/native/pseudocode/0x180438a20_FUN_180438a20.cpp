// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180438a20; descriptive alias: FUN_180438a20
// Evidence: ev_fb840e7273fec57f3d481b5a4efbed38aaf442cba6668831ebcfc170c3460ba3
// Original Evidence: rea-collector/0x180438a20.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * FUN_180438a20(undefined8 *param_1)

{
  uint uVar1;
  char cVar2;
  undefined8 uVar3;
  longlong lVar4;
  ulonglong uVar5;
  undefined8 *puVar6;
  undefined1 *local_18;
  ulonglong uStack_10;
  
  uVar3 = FUN_1804214d0();
  cVar2 = FUN_1801fa260(uVar3);
  if (cVar2 == '\0') {
    param_1[1] = 0;
    *param_1 = &DAT_180c0f302;
    return param_1;
  }
  lVar4 = FUN_180421590(uVar3);
  cVar2 = FUN_1801fa260(lVar4);
  if (cVar2 == '\0') {
    uStack_10 = 0;
    local_18 = &DAT_180c0f302;
  }
  else {
    if (DAT_180d295f0 == '\0') {
      uVar5 = _DAT_180d29188 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
    }
    else {
      uVar5 = FUN_18052c740(&DAT_180d29188,0);
    }
    if (uVar5 != 0) {
      puVar6 = (undefined8 *)(lVar4 + uVar5);
      cVar2 = FUN_1801fa260(puVar6);
      if (cVar2 != '\0') {
        uVar1 = *(uint *)(puVar6 + 1);
        uStack_10 = (ulonglong)uVar1;
        if (((uVar1 - 1 < 0x80) && (*(uint *)((longlong)puVar6 + 0xc) - 1 < 0x80)) &&
           (uVar1 <= *(uint *)((longlong)puVar6 + 0xc))) {
          local_18 = (undefined1 *)*puVar6;
          cVar2 = FUN_1801fa260(local_18);
          if (cVar2 != '\0') goto LAB_180438b37;
        }
      }
    }
    local_18 = &DAT_180c0f302;
    uStack_10 = 0;
  }
LAB_180438b37:
  *param_1 = local_18;
  param_1[1] = uStack_10;
  return param_1;
}

