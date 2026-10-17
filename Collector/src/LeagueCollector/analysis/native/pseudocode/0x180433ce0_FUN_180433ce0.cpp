// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180433ce0; descriptive alias: FUN_180433ce0
// Evidence: ev_7f1e8699c627458e7af25565fe3d963d960e47f3b09bf1bc7f89f26b1c8748a0
// Original Evidence: rea-collector/0x180433ce0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180433ce0(undefined8 param_1)

{
  longlong lVar1;
  
  if (DAT_180d40be8 == '\0') {
                    /* WARNING: Could not recover jumptable at 0x000180433d22. Too many branches */
                    /* WARNING: Treating indirect jump as call */
    (*(code *)((DAT_180d40780 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c) + DAT_180d20bd0))(param_1);
    return;
  }
  lVar1 = FUN_18052c740(&DAT_180d40780,0);
                    /* WARNING: Could not recover jumptable at 0x000180433d42. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*(code *)(lVar1 + DAT_180d20bd0))(param_1);
  return;
}

