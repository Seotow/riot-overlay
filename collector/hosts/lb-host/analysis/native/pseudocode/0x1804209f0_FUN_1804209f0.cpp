// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804209f0; descriptive alias: FUN_1804209f0
// Evidence: ev_b8783781c79cfbd711d318de0f7f7321f34b921a0aee88372dc3340bb125659f
// Original Evidence: rea-collector/0x1804209f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_1804209f0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5de90 == '\0') {
    return *(undefined1 *)((ulonglong)(DAT_180d5da28 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5da28);
  return *(undefined1 *)((ulonglong)uVar1 + param_1);
}

