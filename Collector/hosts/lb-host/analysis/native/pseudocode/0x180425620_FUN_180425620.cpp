// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425620; descriptive alias: FUN_180425620
// Evidence: ev_be71ef1fc5af1dfe54073409bc8c081fbb817c0309ebf5a141dca71982d28ac5
// Original Evidence: rea-collector/0x180425620.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong FUN_180425620(void)

{
  longlong *plVar1;
  ulonglong uVar2;
  undefined8 local_118;
  undefined4 local_110;
  undefined4 local_10c;
  undefined1 local_108 [16];
  undefined1 local_f8 [16];
  undefined1 local_e8 [16];
  undefined1 local_d8 [16];
  undefined1 local_c8 [16];
  undefined1 local_b8 [16];
  undefined1 local_a8 [16];
  undefined1 local_98 [16];
  undefined1 local_88 [16];
  undefined1 local_78 [16];
  undefined1 local_68 [16];
  undefined1 local_58 [16];
  undefined1 local_48 [16];
  undefined1 local_38 [16];
  undefined1 local_28 [16];
  longlong local_18;
  
  if (DAT_180d6e990 == 0) {
    plVar1 = (longlong *)FUN_18038af30();
    if ((DAT_180d20cb0 != 0x244c26e6) || (DAT_180d6e990 = DAT_180d6e590, DAT_180d6e590 == 0)) {
      if (*(uint *)(plVar1 + 1) != 0) {
        uVar2 = 0;
        do {
          DAT_180d6e990 = *(longlong *)(*plVar1 + uVar2 * 8);
          if (*(int *)(DAT_180d6e990 + 8) == 0x244c26e6) {
            DAT_180d20cb0 = 0x244c26e6;
            DAT_180d6e590 = DAT_180d6e990;
            goto LAB_18042568b;
          }
          uVar2 = uVar2 + 1;
        } while (uVar2 < *(uint *)(plVar1 + 1));
      }
      DAT_180d6e990 = 0;
    }
LAB_18042568b:
    if (DAT_180d6e990 == 0) {
      local_118 = 8;
      local_108 = (undefined1  [16])0x0;
      local_f8 = (undefined1  [16])0x0;
      local_e8 = (undefined1  [16])0x0;
      local_d8 = (undefined1  [16])0x0;
      local_c8 = (undefined1  [16])0x0;
      local_b8 = (undefined1  [16])0x0;
      local_a8 = (undefined1  [16])0x0;
      local_98 = (undefined1  [16])0x0;
      local_88 = (undefined1  [16])0x0;
      local_78 = (undefined1  [16])0x0;
      local_68 = (undefined1  [16])0x0;
      local_58 = (undefined1  [16])0x0;
      local_48 = (undefined1  [16])0x0;
      local_38 = (undefined1  [16])0x0;
      local_28 = (undefined1  [16])0x0;
      local_110 = 0x2f27360b;
      local_10c = 0x23362306;
      local_18 = DAT_180d6e990;
      FUN_180423bb0(0,&local_118);
      return DAT_180d6e990;
    }
  }
  return DAT_180d6e990;
}

