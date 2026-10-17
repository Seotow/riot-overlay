// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420c60; descriptive alias: FUN_180420c60
// Evidence: ev_b3effe6e6787a696fbe5bb052f92e2c69813eaf8818b7225ce4802ec371aef03
// Original Evidence: rea-collector/0x180420c60.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180420c60(longlong param_1,undefined1 param_2)

{
  uint uVar1;
  
  if (DAT_180d5e300 == '\0') {
    *(undefined1 *)((ulonglong)(DAT_180d5de98 + 0xe6632e3aU ^ 0x11bf48c) + param_1) = param_2;
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d5de98);
  *(undefined1 *)((ulonglong)uVar1 + param_1) = param_2;
  return;
}

