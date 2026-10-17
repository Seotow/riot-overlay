// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420c00; descriptive alias: FUN_180420c00
// Evidence: ev_d2f404b996b76ccf14dcc2cd246e1a6768ffde293dd3ad53a0a547c03fd203dc
// Original Evidence: rea-collector/0x180420c00.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180420c00(longlong param_1,undefined4 param_2)

{
  uint uVar1;
  
  if (DAT_180d5d5b0 == '\0') {
    *(undefined4 *)((ulonglong)(DAT_180d5d148 + 0xe6632e3aU ^ 0x11bf48c) + param_1) = param_2;
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d5d148);
  *(undefined4 *)((ulonglong)uVar1 + param_1) = param_2;
  return;
}

