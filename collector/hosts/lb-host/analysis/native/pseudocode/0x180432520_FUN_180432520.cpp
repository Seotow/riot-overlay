// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432520; descriptive alias: FUN_180432520
// Evidence: ev_071dc8965a6be8ac00ac7365ab6ce7841084433850eb44be9d5289b0d346b66e
// Original Evidence: rea-collector/0x180432520.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180432520(longlong *param_1)

{
  uint uVar1;
  
  if (DAT_180d38a28 == '\0') {
                    /* WARNING: Could not recover jumptable at 0x00018043254c. Too many branches */
                    /* WARNING: Treating indirect jump as call */
    (**(code **)(*param_1 + (ulonglong)(DAT_180d385c0 + 0xe6632e3aU ^ 0x11bf48c) * 8))();
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d385c0);
                    /* WARNING: Could not recover jumptable at 0x000180432569. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (**(code **)(*param_1 + (ulonglong)uVar1 * 8))(param_1);
  return;
}

