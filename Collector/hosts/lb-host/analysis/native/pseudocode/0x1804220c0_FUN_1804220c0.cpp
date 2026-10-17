// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804220c0; descriptive alias: FUN_1804220c0
// Evidence: ev_9de42e0d99eafeeb7ff90ea031230915a57491ea25f1e42983ca8f1cdee7570e
// Original Evidence: rea-collector/0x1804220c0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180422341) */
/* WARNING: Removing unreachable block (ram,0x0001804222f7) */
/* WARNING: Removing unreachable block (ram,0x00018042234f) */

undefined4 FUN_1804220c0(longlong param_1)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined8 uVar5;
  char cVar6;
  int iVar7;
  undefined4 uVar8;
  longlong *plVar9;
  ulonglong uVar10;
  undefined1 (*pauVar11) [16];
  longlong lVar12;
  undefined1 *puVar13;
  undefined1 *puVar14;
  undefined1 *puVar15;
  undefined8 uStack_360;
  undefined1 auStack_358 [8];
  undefined1 auStack_350 [24];
  longlong local_338 [2];
  undefined1 local_328 [16];
  undefined *local_318;
  longlong local_310;
  undefined8 local_308;
  undefined4 auStack_300 [2];
  undefined1 auStack_2f8 [16];
  undefined1 local_2e8 [16];
  undefined1 auStack_2d8 [16];
  undefined1 local_2c8 [16];
  undefined1 auStack_2b8 [16];
  undefined1 local_2a8 [16];
  undefined1 auStack_298 [16];
  undefined1 local_288 [16];
  undefined1 auStack_278 [16];
  undefined1 local_268 [16];
  undefined1 auStack_258 [16];
  undefined1 local_248 [16];
  undefined1 auStack_238 [16];
  undefined1 local_228 [16];
  undefined1 auStack_218 [16];
  longlong local_208;
  undefined8 local_1f8;
  undefined8 uStack_1f0;
  undefined1 auStack_1e8 [16];
  undefined1 local_1d8 [16];
  undefined1 auStack_1c8 [16];
  undefined1 local_1b8 [16];
  undefined1 auStack_1a8 [16];
  undefined1 local_198 [16];
  undefined1 auStack_188 [16];
  undefined1 local_178 [16];
  undefined1 auStack_168 [16];
  undefined1 local_158 [16];
  undefined1 auStack_148 [16];
  undefined1 local_138 [16];
  undefined1 auStack_128 [16];
  undefined1 local_118 [16];
  undefined1 auStack_108 [16];
  longlong local_f8;
  longlong local_e8;
  undefined8 *local_e0;
  code *local_d8;
  ulonglong local_d0;
  undefined8 local_c8;
  undefined1 local_c0 [16];
  undefined8 local_a8;
  longlong *local_a0;
  undefined1 local_98 [8];
  int local_90 [2];
  undefined1 local_88 [16];
  undefined8 uStack_78;
  ulonglong uStack_70;
  int local_68 [2];
  undefined1 local_60 [16];
  undefined8 local_50;
  ulonglong local_48;
  ulonglong local_40;
  
  puVar13 = auStack_358;
  puVar14 = auStack_358;
  local_40 = DAT_180d06cc0 ^ (ulonglong)auStack_358;
  uVar10 = 0;
  local_90[0] = 0;
  cVar6 = FUN_18038af90();
  puVar15 = auStack_358;
  if (cVar6 != '\0') {
    if (DAT_180d6e980 == 0) {
      plVar9 = (longlong *)FUN_18038af30();
      if ((DAT_180d20cb0 == -0x4174c954) && (DAT_180d6e590 != 0)) {
LAB_18042231f:
        DAT_180d6e980 = DAT_180d6e590;
        if (DAT_180d6e590 != 0) goto LAB_1804227ba;
      }
      else {
        if (*(uint *)(plVar9 + 1) != 0) {
          do {
            lVar12 = *(longlong *)(*plVar9 + uVar10 * 8);
            if (*(int *)(lVar12 + 8) == -0x4174c954) {
              DAT_180d20cb0 = -0x4174c954;
              DAT_180d6e590 = lVar12;
              goto LAB_18042231f;
            }
            uVar10 = uVar10 + 1;
          } while (uVar10 < *(uint *)(plVar9 + 1));
        }
        DAT_180d6e980 = 0;
      }
      local_308 = 8;
      auStack_300[0] = 0x27312300;
      auStack_300[1] = 0x29302712;
      auStack_2f8 = (undefined1  [16])0x0;
      local_2e8 = (undefined1  [16])0x0;
      auStack_2d8 = (undefined1  [16])0x0;
      local_2c8 = (undefined1  [16])0x0;
      auStack_2b8 = (undefined1  [16])0x0;
      local_2a8 = (undefined1  [16])0x0;
      auStack_298 = (undefined1  [16])0x0;
      local_288 = (undefined1  [16])0x0;
      auStack_278 = (undefined1  [16])0x0;
      local_268 = (undefined1  [16])0x0;
      auStack_258 = (undefined1  [16])0x0;
      local_248 = (undefined1  [16])0x0;
      auStack_238 = (undefined1  [16])0x0;
      local_228 = (undefined1  [16])0x0;
      auStack_218 = (undefined1  [16])0x0;
      local_208 = 0;
      local_c0._0_9_ = ZEXT89(0x180d6eb78);
      local_c0._9_7_ = 0;
      iVar7 = FUN_180973810(&DAT_180d6eb78);
      if (iVar7 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_c0[8] = 1;
      local_328[0] = 0;
      FUN_180185e60(&DAT_180d6eb28,local_328);
      local_90[0] = 0x1d;
      FUN_1801877a0(&DAT_180d6eb28,local_90,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f3f8,0x1d);
      local_c8 = _Xtime_get_ticks();
      local_e0 = &local_c8;
      local_d8 = FUN_180191210;
      local_e8 = -0x3000000000000000;
      local_50 = 0;
      local_48 = 0xf;
      local_60._1_15_ = SUB1615((undefined1  [16])0x0,1);
      auVar2[0xf] = 0;
      auVar2._0_15_ = local_60._1_15_;
      local_60 = auVar2 << 8;
      local_90[0] = 2;
      FUN_18019f7a0(local_60,0x11);
      local_a8 = 1;
      local_a0 = &local_e8;
      local_318 = &DAT_180c09610;
      local_310 = 9;
      local_338[0] = 0;
      FUN_18018ad00(local_98,local_60,&local_318,&local_a8);
      local_90[0] = 1;
      FUN_180185f70(&DAT_180d6eb28,local_90);
      local_90[0] = (int)local_50;
      FUN_1801877a0(&DAT_180d6eb28,local_90,4);
      puVar15 = local_60;
      if (0xf < local_48) {
        puVar15 = (undefined1 *)local_60._0_8_;
      }
      FUN_1801877a0(&DAT_180d6eb28,puVar15,local_50);
      uStack_1f0 = CONCAT44(auStack_300[1],auStack_300[0]);
      local_1f8 = local_308;
      auStack_1e8 = auStack_2f8;
      local_1d8 = local_2e8;
      auStack_1c8 = auStack_2d8;
      local_1b8 = local_2c8;
      auStack_1a8 = auStack_2b8;
      local_198 = local_2a8;
      auStack_188 = auStack_298;
      local_178 = local_288;
      auStack_168 = auStack_278;
      local_158 = local_268;
      auStack_148 = auStack_258;
      local_138 = local_248;
      auStack_128 = auStack_238;
      local_118 = local_228;
      auStack_108 = auStack_218;
      local_f8 = local_208;
      uStack_78 = 0;
      uStack_70 = 0xf;
      local_88._1_15_ = SUB1615((undefined1  [16])0x0,1);
      auVar3[0xf] = 0;
      auVar3._0_15_ = local_88._1_15_;
      local_88 = auVar3 << 8;
      pauVar11 = (undefined1 (*) [16])FUN_1801c7930(&local_1f8,&local_e8);
      if (&local_88 == pauVar11) {
LAB_18042254c:
        if (0xf < local_d0) {
          uVar10 = local_d0 + 1;
          lVar12 = local_e8;
          if (0xfff < uVar10) {
            lVar12 = *(longlong *)(local_e8 + -8);
            if (0x1f < (local_e8 - lVar12) - 8U) goto LAB_18042290a;
            uVar10 = local_d0 + 0x28;
          }
          thunk_FUN_180895720(lVar12,uVar10);
        }
        uVar5 = uStack_78;
        puVar15 = local_88;
        if (0xf < uStack_70) {
          puVar15 = (undefined1 *)local_88._0_8_;
        }
        local_90[0] = 1;
        FUN_180185f70(&DAT_180d6eb28,local_90);
        local_90[0] = (int)uVar5;
        FUN_1801877a0(&DAT_180d6eb28,local_90,4);
        FUN_1801877a0(&DAT_180d6eb28,puVar15,uVar5);
        if (0xf < uStack_70) {
          uVar10 = uStack_70 + 1;
          lVar12 = local_88._0_8_;
          if (0xfff < uVar10) {
            lVar12 = *(longlong *)(local_88._0_8_ + -8);
            if (0x1f < (local_88._0_8_ - lVar12) - 8U) goto LAB_180422911;
            uVar10 = uStack_70 + 0x28;
          }
          thunk_FUN_180895720(lVar12,uVar10);
        }
        if (DAT_180d6ebe0 != '\0') {
          local_90[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
          FUN_1803c9190(&DAT_180d6ebc8,&local_318,local_90,4);
          FUN_1803c9190(&DAT_180d6ebc8,&local_318,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                        DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_318 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_310 = DAT_180d6eb30 - (longlong)local_318;
        FUN_1801806e0(&DAT_180d6eb40,&local_318);
        local_68[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,local_68,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        if (0xf < local_48) {
          uVar10 = local_48 + 1;
          lVar12 = local_60._0_8_;
          if (0xfff < uVar10) {
            lVar12 = *(longlong *)(local_60._0_8_ + -8);
            if (0x1f < (local_60._0_8_ - lVar12) - 8U) goto LAB_180422918;
            uVar10 = local_48 + 0x28;
          }
          thunk_FUN_180895720(lVar12,uVar10);
        }
        local_50 = 0;
        local_48 = 0xf;
        auVar4[0xf] = 0;
        auVar4._0_15_ = local_60._1_15_;
        local_60 = auVar4 << 8;
        FUN_180973930(&DAT_180d6eb78);
        puVar15 = auStack_358;
        if (DAT_180d6e980 == 0) goto LAB_1804228df;
        goto LAB_1804227ba;
      }
      if (uStack_70 < 0x10) {
LAB_180422518:
        local_88 = *pauVar11;
        uStack_78 = *(undefined8 *)pauVar11[1];
        uStack_70 = *(ulonglong *)(pauVar11[1] + 8);
        *(undefined8 *)pauVar11[1] = 0;
        *(undefined8 *)(pauVar11[1] + 8) = 0xf;
        (*pauVar11)[0] = 0;
        goto LAB_18042254c;
      }
      uVar10 = uStack_70 + 1;
      lVar12 = local_88._0_8_;
      if (uVar10 < 0x1000) {
LAB_180422513:
        thunk_FUN_180895720(lVar12,uVar10);
        goto LAB_180422518;
      }
      lVar12 = *(longlong *)(local_88._0_8_ + -8);
      if ((local_88._0_8_ - lVar12) - 8U < 0x20) {
        uVar10 = uStack_70 + 0x28;
        goto LAB_180422513;
      }
LAB_18042290a:
      pcVar1 = (code *)swi(0x29);
      (*pcVar1)(5);
      puVar13 = auStack_350;
LAB_180422911:
      pcVar1 = (code *)swi(0x29);
      (*pcVar1)(5);
      puVar14 = puVar13 + 8;
LAB_180422918:
      pcVar1 = (code *)swi(0x29);
      local_208 = (*pcVar1)(5);
      puVar15 = puVar14 + 8;
    }
    else {
LAB_1804227ba:
      local_208 = FUN_18038c1b0(DAT_180d6e980,0x36f7ed41);
      puVar15 = auStack_358;
      if (local_208 == 0) {
        local_308 = 7;
        auStack_300[0] = 0x3027122f;
        auStack_300[1] = 0x260b29;
        auStack_2f8 = (undefined1  [16])0x0;
        local_2e8 = (undefined1  [16])0x0;
        auStack_2d8 = (undefined1  [16])0x0;
        local_2c8 = (undefined1  [16])0x0;
        auStack_2b8 = (undefined1  [16])0x0;
        local_2a8 = (undefined1  [16])0x0;
        auStack_298 = (undefined1  [16])0x0;
        local_288 = (undefined1  [16])0x0;
        auStack_278 = (undefined1  [16])0x0;
        local_268 = (undefined1  [16])0x0;
        auStack_258 = (undefined1  [16])0x0;
        local_248 = (undefined1  [16])0x0;
        auStack_238 = (undefined1  [16])0x0;
        local_228 = (undefined1  [16])0x0;
        auStack_218 = (undefined1  [16])0x0;
        local_1f8 = 8;
        uStack_1f0 = 0x2930271227312300;
        auStack_1e8 = (undefined1  [16])0x0;
        local_1d8 = (undefined1  [16])0x0;
        auStack_1c8 = (undefined1  [16])0x0;
        local_1b8 = (undefined1  [16])0x0;
        auStack_1a8 = (undefined1  [16])0x0;
        local_198 = (undefined1  [16])0x0;
        auStack_188 = (undefined1  [16])0x0;
        local_178 = (undefined1  [16])0x0;
        auStack_168 = (undefined1  [16])0x0;
        local_158 = (undefined1  [16])0x0;
        auStack_148 = (undefined1  [16])0x0;
        local_138 = (undefined1  [16])0x0;
        auStack_128 = (undefined1  [16])0x0;
        local_118 = (undefined1  [16])0x0;
        auStack_108 = (undefined1  [16])0x0;
        local_f8 = local_208;
        FUN_180422a90(0,&local_1f8,&local_308);
        puVar15 = auStack_358;
        goto LAB_1804228df;
      }
    }
    if (*(char *)(local_208 + 0x11) == '\a') {
      uVar8 = *(undefined4 *)(local_208 + 0xc);
      *(undefined4 *)(param_1 + 4) = uVar8;
      goto LAB_1804228eb;
    }
    puVar15[0x30] = 7;
    local_1f8 = 7;
    uStack_1f0 = 0x260b293027122f;
    auStack_1e8 = (undefined1  [16])0x0;
    local_1d8 = (undefined1  [16])0x0;
    auStack_1c8 = (undefined1  [16])0x0;
    local_1b8 = (undefined1  [16])0x0;
    auStack_1a8 = (undefined1  [16])0x0;
    local_198 = (undefined1  [16])0x0;
    auStack_188 = (undefined1  [16])0x0;
    local_178 = (undefined1  [16])0x0;
    auStack_168 = (undefined1  [16])0x0;
    local_158 = (undefined1  [16])0x0;
    auStack_148 = (undefined1  [16])0x0;
    local_138 = (undefined1  [16])0x0;
    auStack_128 = (undefined1  [16])0x0;
    local_118 = (undefined1  [16])0x0;
    auStack_108 = (undefined1  [16])0x0;
    local_f8 = 0;
    *(undefined8 *)(puVar15 + 0x50) = 8;
    *(undefined4 *)(puVar15 + 0x58) = 0x27312300;
    *(undefined4 *)(puVar15 + 0x5c) = 0x29302712;
    *(undefined1 (*) [16])(puVar15 + 0x60) = (undefined1  [16])0x0;
    *(undefined1 (*) [16])(puVar15 + 0x70) = (undefined1  [16])0x0;
    auStack_2d8 = (undefined1  [16])0x0;
    local_2c8 = (undefined1  [16])0x0;
    auStack_2b8 = (undefined1  [16])0x0;
    local_2a8 = (undefined1  [16])0x0;
    auStack_298 = (undefined1  [16])0x0;
    local_288 = (undefined1  [16])0x0;
    auStack_278 = (undefined1  [16])0x0;
    local_268 = (undefined1  [16])0x0;
    auStack_258 = (undefined1  [16])0x0;
    local_248 = (undefined1  [16])0x0;
    auStack_238 = (undefined1  [16])0x0;
    local_228 = (undefined1  [16])0x0;
    auStack_218 = (undefined1  [16])0x0;
    local_208 = 0;
    *(undefined1 **)(puVar15 + 0x20) = puVar15 + 0x30;
    *(undefined8 *)(puVar15 + -8) = 0x180422a56;
    FUN_1804232c0(0,puVar15 + 0x50,&local_1f8);
  }
LAB_1804228df:
  *(undefined4 *)(param_1 + 4) = 0xfffffffe;
  uVar8 = 0xffffffff;
LAB_1804228eb:
  *(undefined8 *)(puVar15 + -8) = 0x1804228fa;
  return uVar8;
}

