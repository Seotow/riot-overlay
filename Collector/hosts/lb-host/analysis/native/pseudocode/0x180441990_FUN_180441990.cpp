// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180441990; descriptive alias: FUN_180441990
// Evidence: ev_2b9c361e510ce0dee29f3e510e6e22554e9592675732f1bb8d1113a0b861d3ed
// Original Evidence: rea-collector/0x180441990.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong FUN_180441990(longlong param_1,ulonglong param_2)

{
  FUN_1801a2440(param_1 + 0x8770);
  FUN_1803fb950(param_1);
  if ((param_2 & 1) != 0) {
    thunk_FUN_180895720(param_1,0x8790);
  }
  return param_1;
}

