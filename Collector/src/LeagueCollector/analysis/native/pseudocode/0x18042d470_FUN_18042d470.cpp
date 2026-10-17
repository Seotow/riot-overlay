// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d470; descriptive alias: FUN_18042d470
// Evidence: ev_48f46efedb1b3d4f98ef9e866a88c0b6c6e62be7ef934fdc7d4a29db7ae63854
// Original Evidence: rea-collector/0x18042d470.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_18042d470(longlong param_1,longlong param_2,undefined4 *param_3)

{
  int iVar1;
  ulonglong uVar2;
  uint uVar3;
  uint uVar4;
  
  iVar1 = *(int *)(param_2 + 0xc);
  if (iVar1 == 0xb) {
    *param_3 = 1;
  }
  else if (iVar1 == 0xc) {
    uVar2 = *(ulonglong *)(param_2 + 0x18);
    if ((0x4000000 < uVar2) || (0x4000000 - uVar2 < (ulonglong)*(uint *)(param_2 + 0x28))) {
      *(undefined4 *)(param_1 + 0x34) = 0x7a;
      *param_3 = 0x8007007a;
      return 0;
    }
    FUN_1809bf2f0(uVar2 + 0x240 + param_1,*(undefined8 *)(param_2 + 0x20));
    uVar4 = *(int *)(param_2 + 0x28) + *(int *)(param_2 + 0x18);
    uVar3 = *(uint *)(param_1 + 0x30);
    if (*(uint *)(param_1 + 0x30) < uVar4) {
      uVar3 = uVar4;
    }
    *(uint *)(param_1 + 0x30) = uVar3;
    *param_3 = 0;
  }
  else if (iVar1 == 0xd) {
    *param_3 = 0;
    return 1;
  }
  return 1;
}

