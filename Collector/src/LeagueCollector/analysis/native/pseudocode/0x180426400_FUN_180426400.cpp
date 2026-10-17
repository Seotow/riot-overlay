// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180426400; descriptive alias: FUN_180426400
// Evidence: ev_96ed593bd01345759a73e31607e1902060f14637d740092eade984f0896990e8
// Original Evidence: rea-collector/0x180426400.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

uint * FUN_180426400(uint *param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  char cVar3;
  undefined1 uVar4;
  ulonglong uVar5;
  ulonglong *puVar6;
  ulonglong uVar7;
  uint uVar8;
  code *pcVar9;
  ulonglong uVar10;
  code *pcVar11;
  ulonglong uVar12;
  float fVar13;
  double dVar14;
  undefined8 local_res10;
  undefined8 local_68;
  undefined2 local_5b;
  undefined1 local_59;
  
  if (DAT_180d226f8 == '\0') {
    uVar5 = DAT_180d22290 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar5 = FUN_18052c740(&DAT_180d22290,0);
  }
  if (uVar5 != 0) {
    puVar6 = (ulonglong *)FUN_1801f3090(&DAT_180d22290);
    uVar5 = *puVar6;
    if (DAT_180d22b68 == '\0') {
      uVar8 = DAT_180d22700 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d22700);
    }
    cVar3 = FUN_1801fa260(uVar5);
    if (((cVar3 != '\0') && (uVar8 != 0)) && (uVar5 <= ~(ulonglong)uVar8)) {
      uVar2 = *(undefined8 *)(uVar8 + uVar5);
      cVar3 = FUN_1801fa260(uVar2);
      local_res10 = local_68;
      if (cVar3 != '\0') {
        local_res10 = uVar2;
      }
      goto LAB_1804264e7;
    }
  }
  cVar3 = '\0';
LAB_1804264e7:
  if (DAT_180d22fd8 == '\0') {
    uVar5 = DAT_180d22b70 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar5 = FUN_18052c740(&DAT_180d22b70,0);
  }
  if (DAT_180d23448 == '\0') {
    uVar12 = DAT_180d22fe0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar12 = FUN_18052c740(&DAT_180d22fe0,0);
  }
  if (DAT_180d238b8 == '\0') {
    uVar10 = DAT_180d23450 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d23450,0);
  }
  if (DAT_180d23d28 == '\0') {
    uVar7 = DAT_180d238c0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar7 = FUN_18052c740(&DAT_180d238c0,0);
  }
  if (((cVar3 != '\0') && (uVar5 != 0)) && ((uVar12 != 0 && ((uVar10 != 0 && (uVar7 != 0)))))) {
    pcVar9 = (code *)(uVar5 + DAT_180d20bd0);
    pcVar11 = (code *)(uVar10 + DAT_180d20bd0);
    pcVar1 = (code *)(uVar7 + DAT_180d20bd0);
    uVar8 = (*(code *)(DAT_180d20bd0 + uVar12))(local_res10);
    fVar13 = (float)(*pcVar9)(local_res10);
    dVar14 = (double)(*pcVar11)(local_res10);
    uVar4 = (*pcVar1)(local_res10);
    if (((uVar8 & 0x7f800000) != 0x7f800000) &&
       (((((uint)fVar13 & 0x7f800000) != 0x7f800000 &&
         (((uint)(float)dVar14 & 0x7f800000) != 0x7f800000)) && (0.0 <= fVar13)))) {
      *(undefined2 *)((longlong)param_1 + 0xd) = local_5b;
      *(undefined1 *)((longlong)param_1 + 0xf) = local_59;
      *param_1 = uVar8;
      param_1[1] = (uint)fVar13;
      param_1[2] = (uint)(float)dVar14;
      *(undefined1 *)(param_1 + 3) = uVar4;
      *(undefined1 *)(param_1 + 4) = 1;
      return param_1;
    }
  }
  *(undefined1 *)(param_1 + 4) = 0;
  return param_1;
}

