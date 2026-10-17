// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431fa0; descriptive alias: FUN_180431fa0
// Evidence: ev_19c273ea0e61beffe8b5f3d12d9607c056cf8df3dbd15cfefa256f3372573c65
// Original Evidence: rea-collector/0x180431fa0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180431fa0(void)

{
  int iVar1;
  longlong lVar2;
  undefined1 local_18 [16];
  
  local_18 = (undefined1  [16])0x0;
  FUN_180432100(0,local_18);
  if (local_18._8_8_ == 6) {
    iVar1 = *(int *)local_18._0_8_ + -0x61636572;
    if (iVar1 == 0) {
      iVar1 = *(ushort *)(local_18._0_8_ + 4) - 0x6c6c;
    }
    if (iVar1 == 0) {
      return 1;
    }
  }
  if (local_18._8_8_ == 0xb) {
    lVar2 = *(longlong *)local_18._0_8_ + -0x6365527265707553;
    if ((lVar2 == 0) && (lVar2 = (ulonglong)*(ushort *)(local_18._0_8_ + 8) - 0x6c61, lVar2 == 0)) {
      lVar2 = (ulonglong)*(byte *)(local_18._0_8_ + 10) - 0x6c;
    }
    if (lVar2 == 0) {
      return 1;
    }
  }
  return 0;
}

