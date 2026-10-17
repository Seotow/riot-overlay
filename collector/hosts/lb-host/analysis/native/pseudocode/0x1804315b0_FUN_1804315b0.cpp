// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804315b0; descriptive alias: FUN_1804315b0
// Evidence: ev_b240aba3fa2f37a3ca622138c97799a621992b1aa606318a0c5d5e0fdd732c72
// Original Evidence: rea-collector/0x1804315b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_1804315b0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d33a38 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d335d0 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d335d0);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

