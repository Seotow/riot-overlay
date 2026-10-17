// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d8e0; descriptive alias: BlueBottleHook
// Evidence: ev_0808b1409126cd738116ecccd53a0d56e6f7096e387f6d444829b7f0cdacebe7
// Original Evidence: rea-collector/0x18042d8e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void BlueBottleHook(undefined4 param_1,undefined8 param_2,undefined8 param_3)

{
                    /* 0x42d8e0  1  BlueBottleHook */
                    /* WARNING: Could not recover jumptable at 0x00018042d8ea. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  CallNextHookEx(0,param_1,param_2,param_3);
  return;
}

