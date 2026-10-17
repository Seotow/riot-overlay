// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180441810; descriptive alias: FUN_180441810
// Evidence: ev_37a57daf2495e371e998306db14b9437e7f641b36cdad4fc079cd436b6b85dae
// Original Evidence: rea-collector/0x180441810.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180441810(undefined8 param_1,ulonglong param_2)

{
  FUN_1803fb950();
  if ((param_2 & 1) != 0) {
    thunk_FUN_180895720(param_1,0x8778);
  }
  return param_1;
}

