// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420e40; descriptive alias: FUN_180420e40
// Evidence: ev_72cb5aa6381eaa0e8c031dae5ab4deb6eb32cbb5f0ab14523de1178cf2f55337
// Original Evidence: rea-collector/0x180420e40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

float * FUN_180420e40(float *param_1)

{
  float fVar1;
  char cVar2;
  longlong lVar3;
  float *pfVar4;
  float *pfVar5;
  float *pfVar6;
  ulonglong uVar7;
  uint uVar8;
  uint uVar9;
  longlong *plVar10;
  char *pcVar11;
  uint *puVar12;
  float fVar13;
  float fVar14;
  float fVar15;
  undefined1 auVar16 [64];
  float fVar17;
  undefined1 auVar18 [64];
  float local_88 [28];
  
  if (DAT_180d566b0 == '\0') {
    uVar7 = DAT_180d56248 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar7 = FUN_18052c740(&DAT_180d56248);
  }
  if ((((uVar7 == 0) ||
       (plVar10 = (longlong *)(DAT_180d20bd0 + uVar7), (longlong *)0xffffffffffffffef < plVar10)) ||
      (cVar2 = FUN_1801fa260(plVar10), cVar2 == '\0')) ||
     (cVar2 = FUN_1801fa260((longlong)plVar10 + 0xf), cVar2 == '\0')) goto LAB_180421261;
  lVar3 = *plVar10;
  if (plVar10[1] != 0) {
    lVar3 = plVar10[1];
  }
  if (DAT_180d56b20 == '\0') {
    uVar9 = DAT_180d566b8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d566b8);
  }
  if (DAT_180d56f90 == '\0') {
    uVar8 = DAT_180d56b28 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d56b28);
  }
  if ((((((uVar9 == 0) || (uVar8 == 0)) ||
        ((cVar2 = FUN_1801fa260(lVar3), cVar2 == '\0' ||
         ((pcVar11 = (char *)((ulonglong)uVar9 + lVar3), pcVar11 == (char *)0xffffffffffffffff ||
          (cVar2 = FUN_1801fa260(pcVar11), cVar2 == '\0')))))) ||
       (cVar2 = FUN_1801fa260(pcVar11), cVar2 == '\0')) ||
      (((*pcVar11 == '\0' ||
        (plVar10 = (longlong *)((ulonglong)uVar8 + lVar3), (longlong *)0xfffffffffffffff7 < plVar10)
        ) || (cVar2 = FUN_1801fa260(plVar10), cVar2 == '\0')))) ||
     (cVar2 = FUN_1801fa260((longlong)plVar10 + 7), cVar2 == '\0')) goto LAB_180421261;
  lVar3 = *plVar10;
  if (DAT_180d57400 == '\0') {
    uVar9 = DAT_180d56f98 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar9 = FUN_18052b510(&DAT_180d56f98);
  }
  if (((uVar9 == 0) || (cVar2 = FUN_1801fa260(lVar3), cVar2 == '\0')) ||
     ((puVar12 = (uint *)((ulonglong)uVar9 + lVar3), (uint *)0xffffffffffffffef < puVar12 ||
      ((cVar2 = FUN_1801fa260(puVar12), cVar2 == '\0' ||
       (cVar2 = FUN_1801fa260((longlong)puVar12 + 0xf), cVar2 == '\0')))))) goto LAB_180421261;
  auVar16 = ZEXT464(*puVar12);
  auVar18 = ZEXT464(puVar12[1]);
  fVar13 = (float)puVar12[2];
  fVar14 = (float)puVar12[3];
  lVar3 = FUN_180424860();
  if ((lVar3 == 0) || (cVar2 = FUN_1801fa260(lVar3), cVar2 == '\0')) {
    fVar17 = auVar18._0_4_;
    fVar15 = auVar16._0_4_;
    uVar8 = 0;
    uVar9 = 0;
    if (lVar3 != 0) goto LAB_18042109a;
LAB_1804210b2:
    uVar9 = 0;
  }
  else {
    uVar9 = FUN_180424ab0(lVar3);
LAB_18042109a:
    uVar8 = uVar9;
    cVar2 = FUN_1801fa260(lVar3);
    fVar17 = auVar18._0_4_;
    fVar15 = auVar16._0_4_;
    if (cVar2 == '\0') goto LAB_1804210b2;
    uVar9 = FUN_180424b00(lVar3);
    fVar17 = auVar18._0_4_;
    fVar15 = auVar16._0_4_;
  }
  if ((((((uint)fVar15 & 0x7f800000) != 0x7f800000) && (((uint)fVar17 & 0x7f800000) != 0x7f800000))
      && (((uint)fVar13 & 0x7f800000) != 0x7f800000)) &&
     (((((uint)fVar14 & 0x7f800000) != 0x7f800000 && (0.0 < fVar13)) &&
      ((0.0 < fVar14 && ((uVar8 != 0 && (uVar9 != 0)))))))) {
    local_88[1] = fVar15 / (float)uVar8;
    pfVar6 = local_88;
    if (0.0 <= local_88[1]) {
      pfVar6 = local_88 + 1;
    }
    local_88[2] = 1.0;
    pfVar4 = local_88 + 2;
    if (local_88[1] <= 1.0) {
      pfVar4 = pfVar6;
    }
    local_88[0] = 0.0;
    local_88[8] = 1.0;
    fVar1 = *pfVar4;
    local_88[4] = fVar17 / (float)uVar9;
    pfVar6 = local_88 + 3;
    if (0.0 <= local_88[4]) {
      pfVar6 = local_88 + 4;
    }
    pfVar4 = local_88 + 5;
    if (local_88[4] <= 1.0) {
      pfVar4 = pfVar6;
    }
    local_88[7] = (fVar13 + fVar15) / (float)uVar8;
    pfVar6 = local_88 + 6;
    if (0.0 <= local_88[7]) {
      pfVar6 = local_88 + 7;
    }
    pfVar5 = local_88 + 8;
    if (local_88[7] <= 1.0) {
      pfVar5 = pfVar6;
    }
    local_88[10] = (fVar14 + fVar17) / (float)uVar9;
    local_88[6] = 0.0;
    fVar13 = *pfVar5;
    pfVar6 = local_88 + 9;
    if (0.0 <= local_88[10]) {
      pfVar6 = local_88 + 10;
    }
    local_88[5] = 1.0;
    pfVar5 = local_88 + 0xb;
    if (local_88[10] <= 1.0) {
      pfVar5 = pfVar6;
    }
    local_88[3] = 0.0;
    local_88[0xb] = 1.0;
    local_88[9] = 0.0;
    if (fVar1 < fVar13) {
      fVar14 = *pfVar4;
      fVar15 = *pfVar5;
      if (fVar14 < fVar15) {
        *param_1 = fVar1;
        param_1[1] = fVar14;
        param_1[2] = fVar13 - fVar1;
        param_1[3] = fVar15 - fVar14;
        *(undefined1 *)(param_1 + 4) = 1;
        return param_1;
      }
    }
  }
LAB_180421261:
  *(undefined1 *)(param_1 + 4) = 0;
  return param_1;
}

