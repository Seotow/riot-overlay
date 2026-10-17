// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804316e0; descriptive alias: FUN_1804316e0
// Evidence: ev_2b2b7a8cbfaf1e78bf488187fcaee10e5d91485c73100133d0c39371d6e560a2
// Original Evidence: rea-collector/0x1804316e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804316e0(longlong param_1,undefined4 param_2)

{
  uint uVar1;
  
  if (DAT_180d31b28 == '\0') {
    *(undefined4 *)((ulonglong)(DAT_180d316c0 + 0xe6632e3aU ^ 0x11bf48c) + param_1) = param_2;
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d316c0);
  *(undefined4 *)((ulonglong)uVar1 + param_1) = param_2;
  return;
}

