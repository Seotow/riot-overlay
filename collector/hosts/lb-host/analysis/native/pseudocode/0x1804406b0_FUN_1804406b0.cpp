// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804406b0; descriptive alias: FUN_1804406b0
// Evidence: ev_ec5037984654b379a4644c2224e5aaca1ca908ead82d47c726902808d90d61cb
// Original Evidence: rea-collector/0x1804406b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_1804406b0(longlong *param_1,undefined4 *param_2,undefined8 *param_3,undefined8 *param_4,
             undefined8 *param_5,undefined8 *param_6,undefined8 *param_7,undefined8 *param_8,
             undefined8 *param_9,undefined8 *param_10,undefined8 *param_11,undefined8 *param_12,
             undefined8 *param_13)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  undefined4 uVar9;
  undefined4 uVar10;
  undefined *puVar11;
  longlong lVar12;
  undefined *puVar13;
  undefined *puVar14;
  longlong lVar15;
  longlong lVar16;
  longlong lVar17;
  
  puVar11 = (undefined *)*param_3;
  lVar12 = *(longlong *)(*param_1 + 0x480);
  lVar15 = (longlong)param_3[1] - (longlong)puVar11 >> 2;
  lVar16 = lVar15 * -0x3333333333333333;
  puVar13 = &DAT_180d6e9ee;
  if (puVar11 != (undefined *)param_3[1]) {
    puVar13 = puVar11;
  }
  FUN_1801c3f20(lVar12,lVar16,0x14,4);
  if ((lVar16 != 0) && (lVar17 = lVar15 * 4, lVar17 != 0)) {
    FUN_1801c5410(lVar12,lVar17);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar17;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar13,lVar17);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)lVar16;
  uVar1 = *(undefined4 *)(lVar12 + 0x30);
  puVar11 = (undefined *)*param_4;
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar13 = (undefined *)param_4[1];
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  *(undefined1 *)(lVar12 + 0x60) = 1;
  puVar14 = &DAT_180d6e9ef;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * 0x6db6db6db6db6db7 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * 0x6db6db6db6db6db7);
  uVar2 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_5;
  puVar13 = (undefined *)param_5[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f0;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0xf0f0f0f0f0f0f0f != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0xf0f0f0f0f0f0f0f);
  uVar3 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_6;
  puVar13 = (undefined *)param_6[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 5;
  puVar14 = &DAT_180d6e9f1;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 0x20;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -0x20;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)lVar15;
  uVar4 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_7;
  puVar13 = (undefined *)param_7[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f5;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0x5555555555555555 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0x5555555555555555);
  uVar5 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_8;
  puVar13 = (undefined *)param_8[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 5;
  puVar14 = &DAT_180d6e9f6;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 0x20;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -0x20;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)lVar15;
  uVar6 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_9;
  puVar13 = (undefined *)param_9[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 3;
  puVar14 = &DAT_180d6e9f7;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 8;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -8;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)lVar15;
  uVar7 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_10;
  puVar13 = (undefined *)param_10[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f8;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0x71c71c71c71c71c7 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0x71c71c71c71c71c7);
  uVar8 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_11;
  puVar13 = (undefined *)param_11[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f2;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0x5555555555555555 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0x5555555555555555);
  uVar9 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_12;
  puVar13 = (undefined *)param_12[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f3;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0x71c71c71c71c71c7 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0x71c71c71c71c71c7);
  uVar10 = *(undefined4 *)(lVar12 + 0x30);
  lVar12 = *(longlong *)(*param_1 + 0x480);
  puVar11 = (undefined *)*param_13;
  puVar13 = (undefined *)param_13[1];
  *(undefined1 *)(lVar12 + 0x60) = 1;
  lVar15 = (longlong)puVar13 - (longlong)puVar11 >> 2;
  puVar14 = &DAT_180d6e9f4;
  if (puVar11 != puVar13) {
    puVar14 = puVar11;
  }
  lVar16 = lVar15 * 4;
  if (lVar16 != 0) {
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
    if (*(ulonglong *)(lVar12 + 0x68) < 4) {
      *(undefined8 *)(lVar12 + 0x68) = 4;
    }
    FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  }
  if ((lVar15 * -0x71c71c71c71c71c7 != 0) && (lVar16 != 0)) {
    FUN_1801c5410(lVar12,lVar16);
    *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + lVar15 * -4;
    *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + (int)lVar16;
    FUN_1809bf2f0(*(undefined8 *)(lVar12 + 0x40),puVar14,lVar16);
  }
  *(undefined1 *)(lVar12 + 0x60) = 0;
  if (*(ulonglong *)(lVar12 + 0x68) < 4) {
    *(undefined8 *)(lVar12 + 0x68) = 4;
  }
  FUN_1801c5360(lVar12,-*(int *)(lVar12 + 0x30) & 3);
  FUN_1801c5410(lVar12,4);
  *(longlong *)(lVar12 + 0x40) = *(longlong *)(lVar12 + 0x40) + -4;
  *(int *)(lVar12 + 0x30) = *(int *)(lVar12 + 0x30) + 4;
  **(undefined4 **)(lVar12 + 0x40) = (int)(lVar15 * -0x71c71c71c71c71c7);
  *param_2 = *(undefined4 *)(lVar12 + 0x30);
  param_2[1] = uVar10;
  param_2[2] = uVar9;
  param_2[3] = uVar8;
  param_2[4] = uVar7;
  param_2[5] = uVar6;
  param_2[6] = uVar5;
  param_2[7] = uVar4;
  param_2[8] = uVar3;
  param_2[9] = uVar2;
  param_2[10] = uVar1;
  return param_2;
}

