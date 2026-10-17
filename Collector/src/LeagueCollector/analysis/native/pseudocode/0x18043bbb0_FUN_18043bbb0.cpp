// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043bbb0; descriptive alias: FUN_18043bbb0
// Evidence: ev_22e2c3f3e0c17b8ee8cfd276effeb115b421ed8a1a890667f52480c3457903ab
// Original Evidence: rea-collector/0x18043bbb0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_18043bbb0(longlong param_1,undefined4 *param_2,longlong param_3)

{
  undefined4 *puVar1;
  char cVar2;
  uint uVar3;
  undefined8 extraout_XMM0_Qa;
  undefined8 extraout_XMM0_Qa_00;
  undefined8 uVar4;
  longlong local_118;
  ulonglong local_110;
  ulonglong local_108;
  ulonglong local_100;
  ulonglong local_f8;
  ulonglong local_f0;
  ulonglong local_e8;
  ulonglong local_e0;
  ulonglong local_d8;
  ulonglong local_d0;
  ulonglong local_c8;
  ulonglong local_c0;
  ulonglong local_b8;
  ulonglong local_b0;
  ulonglong local_a8;
  ulonglong local_a0;
  ulonglong local_98;
  ulonglong local_90;
  ulonglong local_88;
  ulonglong local_80;
  ulonglong local_78;
  longlong local_70;
  undefined4 *local_68;
  
  if (((*(byte *)(param_1 + 0x488) & 4) != 0) &&
     (local_70 = param_1, local_68 = param_2, cVar2 = FUN_1801fa260(param_3), cVar2 != '\0')) {
    if (DAT_180d36228 == '\0') {
      uVar3 = DAT_180d35dc0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d35dc0);
    }
    param_3 = param_3 + (ulonglong)uVar3;
    local_118 = param_3;
    cVar2 = FUN_1801fa260(param_3);
    uVar4 = extraout_XMM0_Qa;
    if ((cVar2 != '\0') &&
       (cVar2 = FUN_1801fa260(param_3 + 0xa00), puVar1 = local_68, uVar4 = extraout_XMM0_Qa_00,
       cVar2 != '\0')) {
      local_110 = (ulonglong)(DAT_180d39c80 + 0xe6632e3a) ^ 0x11bf48c;
      local_108 = (ulonglong)(DAT_180d39c7c + 0xe6632e3a) ^ 0x11bf48c;
      local_100 = (ulonglong)(DAT_180d39c78 + 0xe6632e3a) ^ 0x11bf48c;
      local_f8 = (ulonglong)(DAT_180d39c74 + 0xe6632e3a) ^ 0x11bf48c;
      local_f0 = (ulonglong)(DAT_180d39c70 + 0xe6632e3a) ^ 0x11bf48c;
      local_e8 = (ulonglong)(DAT_180d39c6c + 0xe6632e3a) ^ 0x11bf48c;
      local_e0 = (ulonglong)(DAT_180d39c68 + 0xe6632e3a) ^ 0x11bf48c;
      local_d8 = (ulonglong)(DAT_180d39c64 + 0xe6632e3a) ^ 0x11bf48c;
      local_d0 = (ulonglong)(DAT_180d39c60 + 0xe6632e3a) ^ 0x11bf48c;
      local_c8 = (ulonglong)(DAT_180d39c5c + 0xe6632e3a) ^ 0x11bf48c;
      local_c0 = (ulonglong)(DAT_180d39c58 + 0xe6632e3a) ^ 0x11bf48c;
      local_b8 = (ulonglong)(DAT_180d39c54 + 0xe6632e3a) ^ 0x11bf48c;
      local_b0 = (ulonglong)(DAT_180d39c50 + 0xe6632e3a) ^ 0x11bf48c;
      local_a8 = (ulonglong)(DAT_180d39c4c + 0xe6632e3a) ^ 0x11bf48c;
      local_a0 = (ulonglong)(DAT_180d39c48 + 0xe6632e3a) ^ 0x11bf48c;
      local_98 = (ulonglong)(DAT_180d39c44 + 0xe6632e3a) ^ 0x11bf48c;
      local_90 = (ulonglong)(DAT_180d39c40 + 0xe6632e3a) ^ 0x11bf48c;
      local_88 = (ulonglong)(DAT_180d39c3c + 0xe6632e3a) ^ 0x11bf48c;
      local_80 = (ulonglong)(DAT_180d39c38 + 0xe6632e3a) ^ 0x11bf48c;
      local_78 = (ulonglong)(DAT_180d39c34 + 0xe6632e3a) ^ 0x11bf48c;
      FUN_1804372e0(local_68,*(undefined8 *)(local_70 + 0x480),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c00 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c04 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c08 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c0c + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c10 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c14 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c18 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c1c + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c20 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (local_118 + ((ulonglong)(DAT_180d39c24 + 0xe6632e3a) ^ 0x11bf48c)),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c28 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c2c + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)
                     (((ulonglong)(DAT_180d39c30 + 0xe6632e3a) ^ 0x11bf48c) + local_118),
                    *(undefined4 *)(local_118 + local_78),*(undefined4 *)(local_80 + local_118),
                    *(undefined4 *)(local_88 + local_118),*(undefined4 *)(local_90 + local_118),
                    *(undefined4 *)(local_98 + local_118),*(undefined4 *)(local_a0 + local_118),
                    *(undefined4 *)(local_a8 + local_118),*(undefined4 *)(local_b0 + local_118),
                    *(undefined4 *)(local_b8 + local_118),*(undefined4 *)(local_c0 + local_118),
                    *(undefined4 *)(local_c8 + local_118),*(undefined4 *)(local_d0 + local_118),
                    *(undefined4 *)(local_d8 + local_118),*(undefined4 *)(local_e0 + local_118),
                    *(undefined4 *)(local_e8 + local_118),*(undefined4 *)(local_f0 + local_118),
                    *(undefined4 *)(local_f8 + local_118),*(undefined4 *)(local_100 + local_118),
                    *(undefined4 *)(local_108 + local_118),*(undefined4 *)(local_110 + local_118));
      return puVar1;
    }
    FUN_180443320(uVar4,&local_118);
  }
  *param_2 = 0;
  return param_2;
}

