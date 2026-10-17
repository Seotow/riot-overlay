// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425f60; descriptive alias: FUN_180425f60
// Evidence: ev_ea131bade80a0b04b7218eed7f7623bc8137c2dd15b18fa155bca8aafc55ff60
// Original Evidence: rea-collector/0x180425f60.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong * FUN_180425f60(longlong *param_1)

{
  ulonglong uVar1;
  code *pcVar2;
  char cVar3;
  longlong lVar4;
  longlong *plVar5;
  longlong *plVar6;
  longlong lVar7;
  ulonglong uVar8;
  ulonglong uVar9;
  longlong *plVar10;
  ulonglong uVar11;
  undefined1 *puVar12;
  undefined1 auStack_58 [8];
  undefined1 auStack_50 [24];
  longlong *local_38;
  
  puVar12 = auStack_58;
  if (DAT_180d6e8c0 != DAT_180d6e8c8) {
    DAT_180d6e8c8 = DAT_180d6e8c0;
  }
  local_38 = param_1;
  local_38 = (longlong *)FUN_180425d20();
  FUN_180426210();
  lVar4 = FUN_180425de0(DAT_180d6e8c8[-1]);
  while ((lVar4 != 0 && (cVar3 = FUN_1801fa260(lVar4), plVar6 = DAT_180d6e8c8, cVar3 != '\0'))) {
    if (DAT_180d6e8c8 == DAT_180d6e8d0) {
      uVar11 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0;
      lVar7 = (longlong)uVar11 >> 3;
      if (lVar7 == 0x1fffffffffffffff) goto LAB_1804261ff;
      uVar1 = lVar7 + 1;
      uVar8 = (longlong)DAT_180d6e8d0 - (longlong)DAT_180d6e8c0 >> 3;
      if (0x1fffffffffffffff - (uVar8 >> 1) < uVar8) {
        uVar9 = 0x1fffffffffffffff;
      }
      else {
        uVar8 = (uVar8 >> 1) + uVar8;
        uVar9 = uVar1;
        if (uVar1 <= uVar8) {
          uVar9 = uVar8;
        }
        if (0x1fffffffffffffff < uVar9) goto LAB_1804261f9;
      }
      plVar5 = (longlong *)FUN_1801a22d0(uVar9 * 8);
      uVar11 = uVar11 & 0xfffffffffffffff8;
      *(longlong *)((longlong)plVar5 + uVar11) = lVar4;
      if (plVar6 == DAT_180d6e8c8) {
        lVar4 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0;
        plVar10 = plVar5;
        plVar6 = DAT_180d6e8c0;
      }
      else {
        FUN_1809bf2f0(plVar5,DAT_180d6e8c0,(longlong)plVar6 - (longlong)DAT_180d6e8c0);
        lVar4 = (longlong)DAT_180d6e8c8 - (longlong)plVar6;
        plVar10 = (longlong *)(uVar11 + 8 + (longlong)plVar5);
      }
      FUN_1809bf2f0(plVar10,plVar6,lVar4);
      if (DAT_180d6e8c0 != (longlong *)0x0) {
        uVar11 = ((longlong)DAT_180d6e8d0 - (longlong)DAT_180d6e8c0 >> 3) * 8;
        plVar6 = DAT_180d6e8c0;
        if (0xfff < uVar11) {
          if (0x1f < (ulonglong)((longlong)DAT_180d6e8c0 + (-8 - DAT_180d6e8c0[-1]))) {
            pcVar2 = (code *)swi(0x29);
            (*pcVar2)(5);
            puVar12 = auStack_50;
LAB_1804261f9:
                    /* WARNING: Subroutine does not return */
            *(undefined **)(puVar12 + -8) = &UNK_1804261fe;
            FUN_1801a22b0();
          }
          uVar11 = uVar11 + 0x27;
          plVar6 = (longlong *)DAT_180d6e8c0[-1];
        }
        thunk_FUN_180895720(plVar6,uVar11);
      }
      DAT_180d6e8d0 = plVar5 + uVar9;
      DAT_180d6e8c8 = plVar5 + uVar1;
      DAT_180d6e8c0 = plVar5;
    }
    else {
      *DAT_180d6e8c8 = lVar4;
      DAT_180d6e8c8 = DAT_180d6e8c8 + 1;
    }
    lVar4 = FUN_180425de0(DAT_180d6e8c8[-1]);
  }
  *param_1 = 0;
  param_1[1] = 0;
  param_1[2] = 0;
  if ((longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0 != 0) {
    uVar11 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0 >> 3;
    if (0x1fffffffffffffff < uVar11) {
LAB_1804261ff:
                    /* WARNING: Subroutine does not return */
      FUN_180183310();
    }
    lVar4 = uVar11 * 8;
    lVar7 = FUN_1801a22d0(lVar4);
    *param_1 = lVar7;
    param_1[1] = lVar7;
    param_1[2] = lVar7 + lVar4;
    uVar11 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0;
    FUN_1809bf2f0(lVar7,DAT_180d6e8c0,uVar11);
    param_1[1] = (uVar11 & 0xfffffffffffffff8) + lVar7;
  }
  return param_1;
}

