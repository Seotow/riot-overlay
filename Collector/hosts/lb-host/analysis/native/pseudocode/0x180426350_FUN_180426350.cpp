// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180426350; descriptive alias: FUN_180426350
// Evidence: ev_61aaf2f27334c3aa22de301faf1d505c7b1cc494fa59324537c66ee1b2f8c56b
// Original Evidence: rea-collector/0x180426350.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180426350(longlong param_1)

{
  longlong *plVar1;
  code *pcVar2;
  ulonglong uVar3;
  ulonglong uVar4;
  
  uVar4 = *(ulonglong *)(param_1 + 8);
  if (uVar4 == 0) {
    return;
  }
  uVar3 = *(longlong *)(param_1 + 0x10) * 8;
  if (0xfff < uVar3) {
    plVar1 = (longlong *)(uVar4 - 8);
    uVar4 = (uVar4 - *plVar1) - 8;
    if (uVar4 < 0x20) {
      thunk_FUN_180895720(*plVar1,uVar3 + 0x27);
      return;
    }
    pcVar2 = (code *)swi(0x29);
    uVar3 = (*pcVar2)(5);
  }
  thunk_FUN_180895720(uVar4,uVar3);
  return;
}

