// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180429e80; descriptive alias: FUN_180429e80
// Evidence: ev_50f863438533278324a3409506fa3abac0de6145cf31e544bddcb3d747ffd07c
// Original Evidence: rea-collector/0x180429e80.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __chkstk replaced with injection: alloca_probe */
/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_180429e80(longlong param_1,longlong param_2,longlong param_3)

{
  ulonglong *puVar1;
  byte bVar2;
  char cVar3;
  uint uVar4;
  uint uVar5;
  ulonglong *puVar6;
  byte bVar7;
  longlong *plVar8;
  ulonglong *puVar9;
  ulonglong uVar10;
  uint uVar11;
  ulonglong uVar12;
  uint *puVar13;
  ulonglong uVar14;
  undefined1 auStack_e0f8 [32];
  ulonglong local_e0d8;
  byte local_e0c8 [128];
  ulonglong local_e048 [7168];
  ulonglong local_48;
  undefined8 uStack_40;
  
  uStack_40 = 0x180429e9a;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_e0f8;
  if (DAT_180d3e3b0 == '\0') {
    uVar4 = DAT_180d3df48 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar4 = FUN_18052b510(&DAT_180d3df48);
  }
  plVar8 = (longlong *)(param_2 + (ulonglong)uVar4);
  if (((((plVar8 < (longlong *)0xfffffffffffffff8) && (cVar3 = FUN_1801fa260(plVar8), cVar3 != '\0')
        ) && (cVar3 = FUN_1801fa260((longlong)plVar8 + 7), cVar3 != '\0')) &&
      ((puVar13 = (uint *)(((ulonglong)(DAT_180d3e3c0 + 0xe6632e3a) ^ 0x11bf48c) + *plVar8),
       puVar13 < (uint *)0xfffffffffffffffc && (cVar3 = FUN_1801fa260(puVar13), cVar3 != '\0')))) &&
     (cVar3 = FUN_1801fa260((longlong)puVar13 + 3), cVar3 != '\0')) {
    uVar4 = *puVar13;
    if ((((uVar4 - 1 < 0x200) &&
         (plVar8 = (longlong *)(((ulonglong)(DAT_180d3df30 + 0xe6632e3a) ^ 0x11bf48c) + param_3),
         plVar8 < (longlong *)0xfffffffffffffff8)) &&
        ((cVar3 = FUN_1801fa260(plVar8), cVar3 != '\0' &&
         (((cVar3 = FUN_1801fa260((longlong)plVar8 + 7), cVar3 != '\0' &&
           (puVar9 = (ulonglong *)(((ulonglong)(DAT_180d3df34 + 0xe6632e3a) ^ 0x11bf48c) + *plVar8),
           puVar9 < (ulonglong *)0xfffffffffffffff8)) &&
          (cVar3 = FUN_1801fa260(puVar9), cVar3 != '\0')))))) &&
       (cVar3 = FUN_1801fa260((longlong)puVar9 + 7), cVar3 != '\0')) {
      uVar10 = *puVar9;
      *(uint *)(*(longlong *)(param_1 + 0x70) + 8) = uVar4;
      puVar9 = (ulonglong *)(param_1 + 0x120);
      puVar1 = (ulonglong *)(param_1 + 0x82a0);
      puVar6 = puVar9;
      if (param_1 != param_1 + 0x8180) {
        do {
          if ((*puVar6 == uVar10) && ((uint)puVar6[1] == uVar4)) break;
          puVar6 = puVar6 + 0x103;
        } while (puVar6 != puVar1);
      }
      local_e0d8 = uVar10;
      if (puVar6 == puVar1) {
        if ((param_1 != param_1 + 0x8180) &&
           (puVar6 = (ulonglong *)(param_1 + 0x938), param_1 != param_1 + 0x7968)) {
          do {
            if (puVar6[2] < puVar9[2]) {
              puVar9 = puVar6;
            }
            puVar6 = puVar6 + 0x103;
          } while (puVar6 != puVar1);
        }
        FUN_1809bef30(local_e048,0,0xe000);
        uVar5 = (DAT_180d3df3c + 0xe6632e3aU ^ 0x11bf48c) * uVar4;
        if ((((uVar5 == 0) || (~(ulonglong)uVar5 < uVar10)) ||
            (cVar3 = FUN_1801fa260(uVar10), cVar3 == '\0')) ||
           (cVar3 = FUN_1801fa260((uVar10 - 1) + (ulonglong)uVar5), cVar3 == '\0'))
        goto LAB_18042a259;
        FUN_1809bf2f0(local_e048,uVar10,uVar5);
        *puVar9 = 0;
        uVar12 = 0;
        if (uVar4 != 0) {
          do {
            uVar10 = (ulonglong)((DAT_180d3df3c + 0xe6632e3aU ^ 0x11bf48c) * (int)uVar12);
            uVar5 = *(uint *)((longlong)local_e048 +
                             ((ulonglong)(DAT_180d6b814 + 0xe6632e3a) ^ 0x11bf48c) + uVar10);
            uVar14 = (ulonglong)uVar5;
            local_e0c8[0] = 0;
            local_e0c8[1] = 0;
            local_e0c8[2] = 0;
            local_e0c8[3] = 0;
            local_e0c8[4] = 0;
            local_e0c8[5] = 0;
            local_e0c8[6] = 0;
            local_e0c8[7] = 0;
            local_e0c8[8] = 0;
            local_e0c8[9] = 0;
            local_e0c8[10] = 0;
            local_e0c8[0xb] = 0;
            local_e0c8[0xc] = 0;
            local_e0c8[0xd] = 0;
            local_e0c8[0xe] = 0;
            local_e0c8[0xf] = 0;
            local_e0c8[0x10] = 0;
            local_e0c8[0x11] = 0;
            local_e0c8[0x12] = 0;
            local_e0c8[0x13] = 0;
            local_e0c8[0x14] = 0;
            local_e0c8[0x15] = 0;
            local_e0c8[0x16] = 0;
            local_e0c8[0x17] = 0;
            local_e0c8[0x18] = 0;
            local_e0c8[0x19] = 0;
            local_e0c8[0x1a] = 0;
            local_e0c8[0x1b] = 0;
            local_e0c8[0x1c] = 0;
            local_e0c8[0x1d] = 0;
            local_e0c8[0x1e] = 0;
            local_e0c8[0x1f] = 0;
            local_e0c8[0x20] = 0;
            local_e0c8[0x21] = 0;
            local_e0c8[0x22] = 0;
            local_e0c8[0x23] = 0;
            local_e0c8[0x24] = 0;
            local_e0c8[0x25] = 0;
            local_e0c8[0x26] = 0;
            local_e0c8[0x27] = 0;
            local_e0c8[0x28] = 0;
            local_e0c8[0x29] = 0;
            local_e0c8[0x2a] = 0;
            local_e0c8[0x2b] = 0;
            local_e0c8[0x2c] = 0;
            local_e0c8[0x2d] = 0;
            local_e0c8[0x2e] = 0;
            local_e0c8[0x2f] = 0;
            local_e0c8[0x30] = 0;
            local_e0c8[0x31] = 0;
            local_e0c8[0x32] = 0;
            local_e0c8[0x33] = 0;
            local_e0c8[0x34] = 0;
            local_e0c8[0x35] = 0;
            local_e0c8[0x36] = 0;
            local_e0c8[0x37] = 0;
            local_e0c8[0x38] = 0;
            local_e0c8[0x39] = 0;
            local_e0c8[0x3a] = 0;
            local_e0c8[0x3b] = 0;
            local_e0c8[0x3c] = 0;
            local_e0c8[0x3d] = 0;
            local_e0c8[0x3e] = 0;
            local_e0c8[0x3f] = 0;
            local_e0c8[0x40] = 0;
            local_e0c8[0x41] = 0;
            local_e0c8[0x42] = 0;
            local_e0c8[0x43] = 0;
            local_e0c8[0x44] = 0;
            local_e0c8[0x45] = 0;
            local_e0c8[0x46] = 0;
            local_e0c8[0x47] = 0;
            local_e0c8[0x48] = 0;
            local_e0c8[0x49] = 0;
            local_e0c8[0x4a] = 0;
            local_e0c8[0x4b] = 0;
            local_e0c8[0x4c] = 0;
            local_e0c8[0x4d] = 0;
            local_e0c8[0x4e] = 0;
            local_e0c8[0x4f] = 0;
            local_e0c8[0x50] = 0;
            local_e0c8[0x51] = 0;
            local_e0c8[0x52] = 0;
            local_e0c8[0x53] = 0;
            local_e0c8[0x54] = 0;
            local_e0c8[0x55] = 0;
            local_e0c8[0x56] = 0;
            local_e0c8[0x57] = 0;
            local_e0c8[0x58] = 0;
            local_e0c8[0x59] = 0;
            local_e0c8[0x5a] = 0;
            local_e0c8[0x5b] = 0;
            local_e0c8[0x5c] = 0;
            local_e0c8[0x5d] = 0;
            local_e0c8[0x5e] = 0;
            local_e0c8[0x5f] = 0;
            local_e0c8[0x60] = 0;
            local_e0c8[0x61] = 0;
            local_e0c8[0x62] = 0;
            local_e0c8[99] = 0;
            local_e0c8[100] = 0;
            local_e0c8[0x65] = 0;
            local_e0c8[0x66] = 0;
            local_e0c8[0x67] = 0;
            local_e0c8[0x68] = 0;
            local_e0c8[0x69] = 0;
            local_e0c8[0x6a] = 0;
            local_e0c8[0x6b] = 0;
            local_e0c8[0x6c] = 0;
            local_e0c8[0x6d] = 0;
            local_e0c8[0x6e] = 0;
            local_e0c8[0x6f] = 0;
            local_e0c8[0x70] = 0;
            local_e0c8[0x71] = 0;
            local_e0c8[0x72] = 0;
            local_e0c8[0x73] = 0;
            local_e0c8[0x74] = 0;
            local_e0c8[0x75] = 0;
            local_e0c8[0x76] = 0;
            local_e0c8[0x77] = 0;
            local_e0c8[0x78] = 0;
            local_e0c8[0x79] = 0;
            local_e0c8[0x7a] = 0;
            local_e0c8[0x7b] = 0;
            local_e0c8[0x7c] = 0;
            local_e0c8[0x7d] = 0;
            local_e0c8[0x7e] = 0;
            local_e0c8[0x7f] = 0;
            if (((0x7e < uVar5 - 1) ||
                (uVar10 = *(ulonglong *)
                           ((longlong)local_e048 +
                           ((ulonglong)(DAT_180d3df38 + 0xe6632e3a) ^ 0x11bf48c) + uVar10),
                ~uVar14 < uVar10)) ||
               ((cVar3 = FUN_1801fa260(uVar10), cVar3 == '\0' ||
                (cVar3 = FUN_1801fa260((uVar14 - 1) + uVar10), cVar3 == '\0')))) goto LAB_18042a259;
            FUN_1809bf2f0(local_e0c8,uVar10,uVar5);
            uVar11 = 0x811c9dc5;
            uVar10 = 0;
            if (uVar5 != 0) {
              do {
                bVar2 = local_e0c8[uVar10];
                bVar7 = bVar2;
                if ((0x40 < bVar2) && (bVar7 = bVar2 + 0x20, 0x5a < bVar2)) {
                  bVar7 = bVar2;
                }
                uVar11 = (bVar7 ^ uVar11) * 0x1000193;
                uVar10 = uVar10 + 1;
              } while (uVar10 < uVar14);
            }
            *(uint *)((longlong)puVar9 + uVar12 * 4 + 0x18) = uVar11;
            uVar5 = (int)uVar12 + 1;
            uVar12 = (ulonglong)uVar5;
            uVar10 = local_e0d8;
          } while (uVar5 < uVar4);
        }
        *puVar9 = uVar10;
        *(uint *)(puVar9 + 1) = uVar4;
        puVar6 = puVar9;
      }
      puVar6[2] = *(ulonglong *)(param_1 + 0x88);
      if (uVar4 != 0) {
        FUN_1809bf2f0(*(longlong *)(param_1 + 0x70) + 0x14,puVar6 + 3,(ulonglong)uVar4 << 2);
      }
      return 1;
    }
  }
LAB_18042a259:
  **(undefined1 **)(param_1 + 0x70) = 3;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  return 0;
}

