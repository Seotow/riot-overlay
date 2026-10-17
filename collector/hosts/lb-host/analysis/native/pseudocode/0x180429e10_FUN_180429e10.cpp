// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180429e10; descriptive alias: FUN_180429e10
// Evidence: ev_8b2e9dcf4b9bc9d6a9877448688f9aade2db775b45376d72d340f1f3b3b3bcb6
// Original Evidence: rea-collector/0x180429e10.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180429e10(longlong param_1,float *param_2)

{
  float *pfVar1;
  uint uVar2;
  longlong lVar3;
  
  uVar2 = *(uint *)(*(longlong *)(param_1 + 0x70) + 8);
  lVar3 = (longlong)*(int *)(param_1 + 0x78) * 0x1014 + *(longlong *)(param_1 + 0x70);
  pfVar1 = param_2 + uVar2;
  if (uVar2 != 0) {
    do {
      if (*param_2 != 1.0) {
        *(undefined1 *)(lVar3 + 0x21029) = 1;
        FUN_1809bf2f0(lVar3 + 0x2182c,0x3f800000,0x800);
        return;
      }
      param_2 = param_2 + 1;
    } while (param_2 != pfVar1);
  }
  *(undefined1 *)(lVar3 + 0x21029) = 0;
  return;
}

