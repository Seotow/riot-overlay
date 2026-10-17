// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442e20; descriptive alias: FUN_180442e20
// Evidence: ev_cc82a8231e5e885b25af2e6393faa614851ac57334cfbcdbdb6bcb7dc035f6c7
// Original Evidence: rea-collector/0x180442e20.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180442e20(longlong *param_1)

{
  longlong lVar1;
  longlong lVar2;
  undefined8 uVar3;
  
  lVar1 = *param_1;
  if ((ulonglong)(param_1[2] - lVar1 >> 2) < 2) {
    lVar2 = param_1[1];
    uVar3 = FUN_1801a22d0(8);
    FUN_1809bf2f0(uVar3,*param_1,param_1[1] - *param_1);
    FUN_180189f40(param_1,uVar3,lVar2 - lVar1 >> 2,2);
  }
  return;
}

