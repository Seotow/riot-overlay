// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424900; descriptive alias: FUN_180424900
// Evidence: ev_1cca5e05abebb8547d228f0bb0d2a46b593f7cc5cf785e5555bbfa624cebf9c0
// Original Evidence: rea-collector/0x180424900.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_180424900(void)

{
  uint uVar1;
  int iVar2;
  undefined8 *puVar3;
  
  if (DAT_180d47280 == '\0') {
    uVar1 = DAT_180d46e18 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d46e18);
  }
  if (uVar1 == 0) {
    puVar3 = (undefined8 *)0x0;
  }
  else {
    puVar3 = (undefined8 *)((ulonglong)uVar1 + DAT_180d20bd0);
  }
  iVar2 = FUN_180973810(&DAT_180d0f9b0);
  if (iVar2 == 0) {
    if (DAT_180d0f9fc != 0x7fffffff) {
      if (DAT_180d0fa80 == '\0') {
        DAT_180d0fa81 = puVar3 != (undefined8 *)0x0;
        if (puVar3 != (undefined8 *)0x0) {
          _DAT_180d0fa00 = *puVar3;
          uRam0000000180d0fa08 = puVar3[1];
          uRam0000000180d0fa10 = puVar3[2];
          uRam0000000180d0fa18 = puVar3[3];
          _DAT_180d0fa20 = puVar3[4];
          uRam0000000180d0fa28 = puVar3[5];
          uRam0000000180d0fa30 = puVar3[6];
          uRam0000000180d0fa38 = puVar3[7];
          _DAT_180d0fa40 = puVar3[8];
          uRam0000000180d0fa48 = puVar3[9];
          uRam0000000180d0fa50 = puVar3[10];
          uRam0000000180d0fa58 = puVar3[0xb];
          _DAT_180d0fa60 = puVar3[0xc];
          uRam0000000180d0fa68 = puVar3[0xd];
          uRam0000000180d0fa70 = puVar3[0xe];
          uRam0000000180d0fa78 = puVar3[0xf];
        }
        DAT_180d0fa80 = '\x01';
      }
      FUN_180973930(&DAT_180d0f9b0);
      return;
    }
    DAT_180d0f9fc = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(6);
  }
                    /* WARNING: Subroutine does not return */
  FUN_1809737c0(5);
}

