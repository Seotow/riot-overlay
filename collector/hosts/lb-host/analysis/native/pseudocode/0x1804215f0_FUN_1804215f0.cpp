// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804215f0; descriptive alias: FUN_1804215f0
// Evidence: ev_1fa658c193cde2a8665f4896876d854f74475ab79dd89176cafa3a045416f930
// Original Evidence: rea-collector/0x1804215f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_1804215f0(longlong param_1,undefined8 param_2)

{
  undefined8 uVar1;
  char cVar2;
  ulonglong uVar3;
  
  if (((uint)param_2 & 0x7f800000) != 0x7f800000) {
    if (DAT_180d26df8 == '\0') {
      uVar3 = DAT_180d26990 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
    }
    else {
      uVar3 = FUN_18052c740(&DAT_180d26990,0);
    }
    if (uVar3 != 0) {
      uVar1 = *(undefined8 *)((DAT_180d288a0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c) + param_1);
      cVar2 = FUN_1801fa260(uVar1);
      if (cVar2 != '\0') {
        if (DAT_180d26df8 == '\0') {
          uVar3 = DAT_180d26990 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
        }
        else {
          uVar3 = FUN_18052c740(&DAT_180d26990,0);
        }
        (*(code *)(uVar3 + DAT_180d20bd0))(uVar1,param_2);
        return 1;
      }
      FUN_1804216e0();
    }
  }
  return 0;
}

