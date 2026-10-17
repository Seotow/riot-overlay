// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425350; descriptive alias: FUN_180425350
// Evidence: ev_743e1a03c1a87431753ab2e22de1dffc2289103800f31d1855b442b77f1dac12
// Original Evidence: rea-collector/0x180425350.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180425350(longlong param_1)

{
  undefined4 uVar1;
  char cVar2;
  longlong lVar3;
  undefined1 local_res10 [24];
  undefined8 local_228;
  undefined4 local_220;
  undefined4 local_21c;
  undefined1 local_218 [16];
  undefined1 local_208 [16];
  undefined1 local_1f8 [16];
  undefined1 local_1e8 [16];
  undefined1 local_1d8 [16];
  undefined1 local_1c8 [16];
  undefined1 local_1b8 [16];
  undefined1 local_1a8 [16];
  undefined1 local_198 [16];
  undefined1 local_188 [16];
  undefined1 local_178 [16];
  undefined1 local_168 [16];
  undefined1 local_158 [16];
  undefined1 local_148 [16];
  undefined1 local_138 [16];
  longlong local_128;
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
  
  cVar2 = FUN_18038af90();
  if (cVar2 != '\0') {
    lVar3 = FUN_180425620();
    if (lVar3 != 0) {
      local_128 = FUN_18038c1b0(lVar3,0x13bddc7b);
      if (local_128 == 0) {
        local_228 = 6;
        local_220 = 0x2f27362b;
        local_218 = (undefined1  [16])0x0;
        local_208 = (undefined1  [16])0x0;
        local_1f8 = (undefined1  [16])0x0;
        local_1e8 = (undefined1  [16])0x0;
        local_1d8 = (undefined1  [16])0x0;
        local_1c8 = (undefined1  [16])0x0;
        local_1b8 = (undefined1  [16])0x0;
        local_1a8 = (undefined1  [16])0x0;
        local_198 = (undefined1  [16])0x0;
        local_188 = (undefined1  [16])0x0;
        local_178 = (undefined1  [16])0x0;
        local_168 = (undefined1  [16])0x0;
        local_158 = (undefined1  [16])0x0;
        local_148 = (undefined1  [16])0x0;
        local_138 = (undefined1  [16])0x0;
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
        local_21c = 0x60b;
        local_118 = 8;
        local_110 = 0x2f27360b;
        local_10c = 0x23362306;
        local_18 = local_128;
        FUN_180422a90(0,&local_118,&local_228);
      }
      else {
        lVar3 = local_128 + 0x11;
        if (*(char *)(local_128 + 0x11) == '\a') {
          uVar1 = *(undefined4 *)(local_128 + 0xc);
          *(undefined4 *)(param_1 + 4) = uVar1;
          return uVar1;
        }
        local_res10[0] = 7;
        local_118 = 6;
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
        local_218 = (undefined1  [16])0x0;
        local_208 = (undefined1  [16])0x0;
        local_1f8 = (undefined1  [16])0x0;
        local_1e8 = (undefined1  [16])0x0;
        local_1d8 = (undefined1  [16])0x0;
        local_1c8 = (undefined1  [16])0x0;
        local_1b8 = (undefined1  [16])0x0;
        local_1a8 = (undefined1  [16])0x0;
        local_198 = (undefined1  [16])0x0;
        local_188 = (undefined1  [16])0x0;
        local_178 = (undefined1  [16])0x0;
        local_168 = (undefined1  [16])0x0;
        local_158 = (undefined1  [16])0x0;
        local_148 = (undefined1  [16])0x0;
        local_138 = (undefined1  [16])0x0;
        local_110 = 0x2f27362b;
        local_10c = 0x60b;
        local_18 = 0;
        local_228 = 8;
        local_220 = 0x2f27360b;
        local_21c = 0x23362306;
        local_128 = 0;
        FUN_1804232c0(0,&local_228,&local_118,lVar3,local_res10);
      }
    }
  }
  *(undefined4 *)(param_1 + 4) = 0xfffffffe;
  return 0xffffffff;
}

