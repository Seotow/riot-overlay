// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180393770; descriptive alias: has_feature
// Evidence: ev_6c7ed6dc5ca592730a0867606305cc04be27abf785138208c07fd31ef0d829de
// Original Evidence: rea-feature-bit-test.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

ulonglong FUN_180393770(longlong param_1,uint param_2)

{
  uint uVar1;
  ulonglong in_RAX;
  
  if (param_2 < 0xf) {
    uVar1 = *(uint *)(param_1 + (ulonglong)(param_2 >> 5) * 4);
    return (ulonglong)CONCAT31((int3)(uVar1 >> 8),(uVar1 >> (param_2 & 0x1f) & 1) != 0);
  }
  return in_RAX & 0xffffffffffffff00;
}

