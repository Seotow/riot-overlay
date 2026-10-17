// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180434320; descriptive alias: FUN_180434320
// Evidence: ev_43bb3f4fc3f21fe64c236ff16b3e71591a7a51044765d2fea05ff8b745104e86
// Original Evidence: rea-collector/0x180434320.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

ulonglong FUN_180434320(longlong *param_1,uint *param_2)

{
  ulonglong *puVar1;
  ulonglong *puVar2;
  uint uVar3;
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined1 auVar9 [16];
  undefined1 auVar10 [16];
  undefined1 auVar11 [16];
  undefined1 auVar12 [16];
  undefined1 auVar13 [16];
  undefined1 auVar14 [16];
  undefined1 auVar15 [16];
  undefined1 auVar16 [16];
  undefined1 auVar17 [16];
  undefined1 auVar18 [16];
  undefined1 auVar19 [16];
  undefined1 auVar20 [16];
  undefined1 auVar21 [16];
  undefined1 auVar22 [16];
  undefined1 auVar23 [16];
  undefined1 auVar24 [16];
  undefined1 auVar25 [16];
  undefined1 auVar26 [16];
  undefined1 auVar27 [16];
  undefined1 auVar28 [16];
  undefined1 auVar29 [16];
  ulonglong uVar30;
  ulonglong uVar31;
  ulonglong *puVar32;
  ulonglong uVar33;
  ulonglong uVar34;
  uint *puVar35;
  ulonglong uVar36;
  ulonglong uVar37;
  ulonglong uVar38;
  ulonglong uVar39;
  ulonglong uVar40;
  
  puVar35 = (uint *)((*(longlong *)(*param_1 + 0x38) + *(longlong *)(*param_1 + 0x28)) -
                    (ulonglong)*param_2);
  puVar32 = (ulonglong *)(puVar35 + 1);
  uVar3 = *puVar35;
  uVar36 = (ulonglong)uVar3;
  uVar37 = SUB168(ZEXT816(0x452821e638d011f5) * ZEXT816(0x243f6a8885a30886),8) + 0x452821e638d011f5;
  uVar30 = uVar37 ^ SUB168(ZEXT816(0x452821e638d011f5) * ZEXT816(0x243f6a8885a30886),0);
  if (uVar3 < 0x10) {
    uVar31 = uVar37;
    if (7 < uVar3) {
      uVar30 = uVar30 ^ *puVar32;
      if (uVar3 < 0xc) {
        uVar37 = ((((ulonglong)*(byte *)((longlong)puVar35 + uVar36 + 3) | 0x100) << 8 |
                  (ulonglong)*(byte *)((longlong)puVar35 + uVar36 + 2)) << 8 |
                 (ulonglong)*(byte *)((longlong)puVar35 + uVar36 + 1)) >>
                 ((uVar36 * 8 ^ 0x58) & 0x3f);
      }
      else {
        uVar37 = (((ulonglong)*(uint *)((longlong)puVar35 + uVar36) | 0x100000000) >>
                 (uVar36 * -8 + 0x80 & 0x3f)) << 0x20 | (ulonglong)puVar35[3];
      }
      goto LAB_1804346d0;
    }
    if (uVar3 != 0) {
      if (uVar3 < 4) {
        uVar30 = uVar30 ^ (byte)*puVar32 ^ 1L << (uVar36 * 8 & 0x3f);
        if ((uVar3 != 1) &&
           (uVar30 = (ulonglong)*(byte *)((longlong)puVar35 + 5) << 8 ^ uVar30, uVar3 != 2)) {
          uVar30 = (ulonglong)*(byte *)((longlong)puVar35 + 6) << 0x10 ^ uVar30;
        }
      }
      else {
        uVar30 = uVar30 ^ ((((ulonglong)*(uint *)((longlong)puVar35 + uVar36) | 0x100000000) >>
                           (uVar36 * -8 + 0x40 & 0x3f)) << 0x20 | (ulonglong)(uint)*puVar32);
      }
    }
  }
  else {
    if (0x1f < uVar3) {
      if (0x3f < uVar3) {
        uVar31 = uVar30 ^ 0x13198a2e03707344;
        uVar39 = uVar30 ^ 0xa4093822299f31d0;
        uVar34 = uVar30 ^ 0x82efa98ec4e6c89;
        uVar40 = uVar37 ^ 0xbe5466cf34e90c6c;
        uVar38 = uVar37 ^ 0xc0ac29b7c97c50dd;
        uVar33 = uVar37 ^ 0x3f84d5b5b5470917;
        do {
          puVar1 = puVar32 + 3;
          auVar4._8_8_ = 0;
          auVar4._0_8_ = uVar37 ^ puVar32[4];
          auVar17._8_8_ = 0;
          auVar17._0_8_ = uVar30 ^ *puVar32;
          uVar37 = uVar37 + SUB168(auVar4 * auVar17,8);
          auVar5._8_8_ = 0;
          auVar5._0_8_ = uVar40 ^ puVar32[5];
          auVar18._8_8_ = 0;
          auVar18._0_8_ = uVar31 ^ puVar32[1];
          uVar40 = uVar40 + SUB168(auVar5 * auVar18,8);
          auVar6._8_8_ = 0;
          auVar6._0_8_ = uVar38 ^ puVar32[6];
          auVar19._8_8_ = 0;
          auVar19._0_8_ = uVar39 ^ puVar32[2];
          uVar38 = uVar38 + SUB168(auVar6 * auVar19,8);
          puVar2 = puVar32 + 7;
          puVar32 = puVar32 + 8;
          auVar7._8_8_ = 0;
          auVar7._0_8_ = uVar33 ^ *puVar2;
          auVar20._8_8_ = 0;
          auVar20._0_8_ = uVar34 ^ *puVar1;
          uVar33 = uVar33 + SUB168(auVar7 * auVar20,8);
          uVar36 = uVar36 - 0x40;
          uVar34 = uVar38 ^ SUB168(auVar7 * auVar20,0);
          uVar30 = uVar33 ^ SUB168(auVar4 * auVar17,0);
          uVar39 = uVar40 ^ SUB168(auVar6 * auVar19,0);
          uVar31 = SUB168(auVar5 * auVar18,0) ^ uVar37;
        } while (0x3f < uVar36);
        uVar37 = uVar37 ^ uVar33 ^ uVar38 ^ uVar40;
        uVar30 = uVar30 ^ uVar34 ^ uVar39 ^ uVar31;
      }
      if (0x1f < uVar36) {
        uVar36 = uVar36 - 0x20;
        auVar8._8_8_ = 0;
        auVar8._0_8_ = uVar37 ^ puVar32[1];
        auVar21._8_8_ = 0;
        auVar21._0_8_ = uVar30 ^ *puVar32;
        uVar37 = SUB168(auVar8 * auVar21,8) + uVar37;
        auVar9._8_8_ = 0;
        auVar9._0_8_ = uVar37 ^ puVar32[3];
        auVar22._8_8_ = 0;
        auVar22._0_8_ = SUB168(auVar8 * auVar21,0) ^ puVar32[2] ^ uVar37;
        uVar37 = SUB168(auVar9 * auVar22,8) + uVar37;
        uVar30 = SUB168(auVar9 * auVar22,0) ^ uVar37;
        puVar32 = puVar32 + 4;
      }
      if (0xf < uVar36) {
        uVar36 = uVar36 - 0x10;
        auVar10._8_8_ = 0;
        auVar10._0_8_ = uVar37 ^ puVar32[1];
        auVar23._8_8_ = 0;
        auVar23._0_8_ = uVar30 ^ *puVar32;
        uVar37 = uVar37 + SUB168(auVar10 * auVar23,8);
        uVar30 = SUB168(auVar10 * auVar23,0) ^ uVar37;
        puVar32 = puVar32 + 2;
      }
      uVar31 = *(ulonglong *)((longlong)puVar32 + (uVar36 - 8)) >> 8 | 0x100000000000000;
      if (uVar36 < 8) {
        uVar33 = uVar31 >> ((uVar36 * 8 ^ 0x38) & 0x3f);
        uVar36 = uVar37;
      }
      else {
        uVar33 = *puVar32;
        uVar36 = uVar31 >> ((uVar36 * 8 ^ 0x78) & 0x3f) ^ uVar37;
      }
      auVar11._8_8_ = 0;
      auVar11._0_8_ = uVar36;
      auVar24._8_8_ = 0;
      auVar24._0_8_ = uVar33 ^ uVar30;
      uVar37 = SUB168(auVar11 * auVar24,8) + uVar37;
      auVar12._8_8_ = 0;
      auVar12._0_8_ = uVar37;
      auVar25._8_8_ = 0;
      auVar25._0_8_ = SUB168(auVar11 * auVar24,0) ^ uVar37;
      return SUB168(auVar12 * auVar25,8) + uVar37 ^ SUB168(auVar12 * auVar25,0);
    }
    auVar13._8_8_ = 0;
    auVar13._0_8_ = uVar37 ^ *(ulonglong *)(puVar35 + 3);
    auVar26._8_8_ = 0;
    auVar26._0_8_ = uVar30 ^ *puVar32;
    uVar31 = uVar37 + SUB168(auVar13 * auVar26,8);
    uVar30 = SUB168(auVar13 * auVar26,0) ^ uVar31;
    uVar37 = *(ulonglong *)((uVar36 - 8) + (longlong)puVar32) >> 8;
    if (uVar3 < 0x18) {
      auVar14._8_8_ = 0;
      auVar14._0_8_ = uVar31;
      auVar27._8_8_ = 0;
      auVar27._0_8_ = (uVar37 | 0x100000000000000) >> ((uVar36 * 8 ^ 0xb8) & 0x3f) ^ uVar30;
      auVar15 = auVar14 * auVar27;
      goto LAB_1804346d8;
    }
    uVar30 = uVar30 ^ *(ulonglong *)(puVar35 + 5);
    uVar37 = (uVar37 | 0x100000000000000) >> ((uVar36 * 8 ^ 0xf8) & 0x3f);
LAB_1804346d0:
    uVar37 = uVar37 ^ uVar31;
  }
  auVar15._8_8_ = 0;
  auVar15._0_8_ = uVar37;
  auVar28._8_8_ = 0;
  auVar28._0_8_ = uVar30;
  auVar15 = auVar15 * auVar28;
LAB_1804346d8:
  uVar31 = auVar15._8_8_ + uVar31;
  auVar16._8_8_ = 0;
  auVar16._0_8_ = uVar31;
  auVar29._8_8_ = 0;
  auVar29._0_8_ = auVar15._0_8_ ^ uVar31;
  return SUB168(auVar16 * auVar29,8) + uVar31 ^ SUB168(auVar16 * auVar29,0);
}

