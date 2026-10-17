// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803a1c90; descriptive alias: FUN_1803a1c90
// Evidence: ev_033d054dedf23bfa1b98e700304fbe3dca8b5ea8dd72b324814b42c16ad48bf6
// Original Evidence: rea-spectator-check.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_1803a1c90(void)

{
  code *pcVar1;
  char cVar2;
  short sVar3;
  BOOL BVar4;
  int iVar5;
  DWORD DVar6;
  longlong *plVar7;
  HANDLE hProcess;
  longlong lVar8;
  longlong lVar9;
  ulonglong *puVar10;
  uint *puVar11;
  undefined1 *puVar12;
  undefined8 uVar13;
  undefined8 *puVar14;
  ulonglong uVar15;
  undefined1 *puVar16;
  undefined8 *****pppppuVar17;
  uint uVar18;
  undefined8 *****pppppuVar19;
  undefined1 *puVar20;
  undefined1 *puVar21;
  LPCVOID lpBaseAddress;
  undefined1 *puVar22;
  undefined8 *****pppppuVar23;
  undefined8 *puVar24;
  bool bVar25;
  undefined8 uStackY_120;
  undefined1 auStackY_118 [8];
  undefined1 auStackY_110 [24];
  undefined8 ****local_e8;
  undefined1 local_e0 [8];
  undefined1 local_d8 [32];
  undefined8 local_b8;
  undefined8 local_b0;
  longlong local_a8;
  undefined1 local_a0;
  undefined7 uStack_9f;
  ulonglong local_90;
  ulonglong local_88;
  longlong local_80;
  undefined8 ****local_78 [3];
  ulonglong local_60;
  ulonglong local_58;
  
  puVar21 = auStackY_118;
  puVar20 = auStackY_118;
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStackY_118;
  if (DAT_180d66c98 == '\0') {
    uVar15 = DAT_180d66830 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar15 = FUN_18052c740(&DAT_180d66830,0);
  }
  if (uVar15 == 0) {
    lVar8 = 0;
  }
  else {
    lVar8 = DAT_180d20bd0 + uVar15;
  }
  if (DAT_180d67108 == '\0') {
    uVar18 = DAT_180d66ca0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar18 = FUN_18052b510(&DAT_180d66ca0);
  }
  if (DAT_180d67578 == '\0') {
    uVar15 = DAT_180d67110 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar15 = FUN_18052c740(&DAT_180d67110,0);
  }
  if (uVar15 == 0) {
    lVar9 = 0;
  }
  else {
    lVar9 = DAT_180d20bd0 + uVar15;
  }
  if (((lVar8 == 0) || (uVar18 == 0)) || (lVar9 == 0)) {
    FUN_1803a4d10();
    puVar16 = auStackY_118;
  }
  else {
    plVar7 = (longlong *)FUN_1801fe670(&local_e8);
    lVar8 = *plVar7;
    while (puVar16 = auStackY_118, DAT_180d20bf0 == '\0') {
      local_a8 = 0;
      if (DAT_180d67578 == '\0') {
        uVar15 = DAT_180d67110 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
      }
      else {
        uVar15 = FUN_18052c740(&DAT_180d67110,0);
      }
      if ((uVar15 == 0) ||
         (lpBaseAddress = (LPCVOID)(DAT_180d20bd0 + uVar15),
         0xfffffffffffffff7 < (longlong)lpBaseAddress - 1U)) {
LAB_1803a1f40:
        local_b8._0_5_ = (uint5)(uint)local_b8;
      }
      else {
        local_b0 = (undefined8 *****)0x0;
        hProcess = GetCurrentProcess();
        BVar4 = ReadProcessMemory(hProcess,lpBaseAddress,&local_a8,8,&local_b0);
        if ((BVar4 == 0) || ((local_b0 != (undefined8 *****)&DAT_00000008 || (local_a8 == 0))))
        goto LAB_1803a1f40;
        FUN_180534210(&local_b8);
        if (local_b8._4_1_ != '\0') {
          if ((uint)local_b8 - 1 < 4) {
            FUN_1803a5420();
            lVar8 = FUN_1801f3090(&DAT_180d295f8);
            lVar9 = FUN_1801f3220(&DAT_180d29a68);
            if ((lVar8 == 0) || (lVar9 == 0)) {
              FUN_1803a5b30();
              puVar16 = auStackY_118;
            }
            else {
              FUN_1801fe670(&local_e8);
              puVar16 = auStackY_118;
              pppppuVar19 = (undefined8 *****)local_e8;
              if (DAT_180d20bf0 == '\0') goto LAB_1803a1ee0;
            }
          }
          else {
            FUN_1803a5070();
            puVar16 = auStackY_118;
          }
          break;
        }
      }
      plVar7 = (longlong *)FUN_1801fe670(local_e0);
      if (lVar8 + 30000000000 <= *plVar7) {
        FUN_1803a57d0();
        puVar16 = auStackY_118;
        break;
      }
      FUN_1801fe670(&local_e8);
      if ((longlong)local_e8 < 0x7ffffffffe0875bf) {
        local_b0 = (undefined8 *****)(local_e8 + 0x3ef148);
      }
      else {
        local_b0 = (undefined8 *****)0x7fffffffffffffff;
      }
      FUN_1802239d0(&local_b0);
    }
  }
  goto LAB_1803a22f3;
LAB_1803a2085:
  sVar3 = Ordinal_15((short)puVar11[(longlong)pppppuVar23 * 7 + 3]);
  if ((sVar3 != 2999) || (puVar11[(longlong)pppppuVar23 * 7 + 6] != DVar6)) goto LAB_1803a20a3;
  thunk_FUN_1809a0a60(puVar11);
  FUN_1803a0990(&local_a0);
  puVar16 = (undefined1 *)CONCAT71(uStack_9f,local_a0);
  puVar22 = &local_a0;
  if (0xf < local_88) {
    puVar22 = puVar16;
  }
  if (local_90 < 7) {
LAB_1803a2161:
    puVar22 = &local_a0;
    if (0xf < local_88) {
      puVar22 = puVar16;
    }
    if (((8 < local_90) &&
        (puVar16 = puVar22 + local_90,
        puVar12 = (undefined1 *)thunk_FUN_1809723c0(puVar22,puVar16,"Spectator",9),
        puVar12 != puVar16)) && ((longlong)puVar12 - (longlong)puVar22 != -1)) goto LAB_1803a219d;
    puVar14 = (undefined8 *)FUN_1801a2330(local_d8,&local_a0);
    if ((undefined8 *****)puVar14[2] != (undefined8 *****)0x0) {
      pppppuVar23 = pppppuVar19;
      do {
        puVar24 = puVar14;
        if (0xf < (ulonglong)puVar14[3]) {
          puVar24 = (undefined8 *)*puVar14;
        }
        lVar8 = 0x125;
        lVar9 = 1;
        pppppuVar17 = pppppuVar23;
        if (pppppuVar23 != (undefined8 *****)0x0) {
          do {
            if (((ulonglong)pppppuVar17 & 1) != 0) {
              lVar9 = lVar9 * lVar8;
            }
            lVar8 = lVar8 * lVar8;
            bVar25 = (undefined8 *****)0x1 < pppppuVar17;
            pppppuVar17 = (undefined8 *****)((ulonglong)pppppuVar17 >> 1);
          } while (bVar25);
        }
        pppppuVar19 = (undefined8 *****)
                      ((longlong)pppppuVar19 +
                      *(char *)((longlong)puVar24 + (longlong)pppppuVar23) * lVar9);
        pppppuVar23 = (undefined8 *****)((longlong)pppppuVar23 + 1);
      } while (pppppuVar23 < (undefined8 *****)puVar14[2]);
    }
    FUN_1801a2650(puVar14);
    local_e8 = pppppuVar19;
    FUN_1803a7070();
LAB_1803a226b:
    uVar13 = 1;
  }
  else {
    puVar16 = puVar22 + local_90;
    puVar12 = (undefined1 *)thunk_FUN_1809723c0(puVar22,puVar16,"Unknown",7);
    if ((puVar12 == puVar16) || ((longlong)puVar12 - (longlong)puVar22 == -1)) {
      puVar16 = (undefined1 *)CONCAT71(uStack_9f,local_a0);
      goto LAB_1803a2161;
    }
LAB_1803a219d:
    local_80 = 0;
    uVar13 = FUN_1801f3090(&DAT_180d2cb50);
    cVar2 = FUN_1803a2af0(uVar13,&local_80);
    if (cVar2 == '\0') {
      FUN_1803a7420();
      goto LAB_1803a226b;
    }
    if (local_80 != 0) {
      FUN_1803a7780();
      goto LAB_1803a226b;
    }
    FUN_1803a7ae0();
    uVar13 = 0;
  }
  if (local_88 < 0x10) {
LAB_1803a22a4:
    local_90 = 0;
    local_88 = 0xf;
    local_a0 = 0;
    goto LAB_1803a20b8;
  }
  uVar15 = local_88 + 1;
  lVar9 = CONCAT71(uStack_9f,local_a0);
  lVar8 = lVar9;
  if (uVar15 < 0x1000) {
LAB_1803a229f:
    thunk_FUN_180895720(lVar8,uVar15);
    goto LAB_1803a22a4;
  }
  lVar8 = *(longlong *)(lVar9 + -8);
  if ((lVar9 - lVar8) - 8U < 0x20) {
    uVar15 = local_88 + 0x28;
    goto LAB_1803a229f;
  }
  pcVar1 = (code *)swi(0x29);
  (*pcVar1)(5);
  puVar20 = auStackY_110;
  goto LAB_1803a22c0;
LAB_1803a20a3:
  uVar18 = (int)pppppuVar23 + 1;
  pppppuVar23 = (undefined8 *****)(ulonglong)uVar18;
  if (*puVar11 <= uVar18) goto LAB_1803a20a9;
  goto LAB_1803a2085;
LAB_1803a20a9:
  thunk_FUN_1809a0a60(puVar11);
  FUN_1803a6d10();
  uVar13 = 1;
LAB_1803a20b8:
  puVar16 = auStackY_118;
  if (local_60 < 0x10) goto LAB_1803a22f5;
  uVar15 = local_60 + 1;
  pppppuVar19 = (undefined8 *****)local_78[0];
  if (0xfff < uVar15) {
    pppppuVar19 = (undefined8 *****)local_78[0][-1];
    if (0x1f < (ulonglong)((longlong)local_78[0] + (-8 - (longlong)pppppuVar19))) {
LAB_1803a22c0:
      pcVar1 = (code *)swi(0x29);
      (*pcVar1)(5);
      puVar21 = puVar20 + 8;
LAB_1803a22c7:
      *(undefined8 *)(puVar21 + -8) = 0x1803a22d0;
      FUN_1803a5e90();
      puVar16 = puVar21;
      goto LAB_1803a22f3;
    }
    uVar15 = local_60 + 0x28;
  }
  thunk_FUN_180895720(pppppuVar19,uVar15);
  puVar16 = auStackY_118;
  goto LAB_1803a22f5;
  while( true ) {
    FUN_1801fe670(&local_a8);
    if (local_a8 < 0x7ffffffffe0875bf) {
      local_b8 = local_a8 + 33000000;
    }
    else {
      local_b8 = 0x7fffffffffffffff;
    }
    FUN_1802239d0(&local_b8);
    puVar16 = auStackY_118;
    if (DAT_180d20bf0 != '\0') break;
LAB_1803a1ee0:
    FUN_180421b50(&local_b0);
    if (local_b0._4_1_ == '\0') {
      plVar7 = (longlong *)FUN_1801fe670(&local_e8);
      if (29999999999 < *plVar7 - (longlong)pppppuVar19) {
        FUN_1803a6240();
        puVar16 = auStackY_118;
        break;
      }
    }
    else {
      uVar18 = (uint)local_b0;
      if (2 < uVar18) goto LAB_1803a22c7;
      puVar10 = (ulonglong *)FUN_1801fe670(local_e0);
      pppppuVar19 = (undefined8 *****)*puVar10;
      if (uVar18 == 2) {
        if (PTR_PTR_180d0fcc8 == (undefined *)0x0) {
                    /* WARNING: Subroutine does not return */
          FUN_18096ee50();
        }
        iVar5 = (**(code **)(*(longlong *)PTR_PTR_180d0fcc8 + 0x10))();
        if (iVar5 != 0) {
          FUN_180421a40(local_78);
          local_e8 = local_78;
          if (0xf < local_60) {
            local_e8 = local_78[0];
          }
          local_b8._0_4_ = iVar5;
          FUN_1803a6900();
          DVar6 = GetCurrentProcessId();
          pppppuVar19 = (undefined8 *****)0x0;
          local_b8 = (ulonglong)local_b8._4_4_ << 0x20;
          GetTcpTable2(0,&local_b8,1);
          puVar11 = (uint *)_malloc_base(local_b8 & 0xffffffff);
          if (puVar11 == (uint *)0x0) {
            FUN_18097f274();
            FUN_1803a3b50();
          }
          iVar5 = GetTcpTable2(puVar11,&local_b8,1);
          if ((iVar5 != 0) || (pppppuVar23 = pppppuVar19, *puVar11 == 0)) goto LAB_1803a20a9;
          goto LAB_1803a2085;
        }
        FUN_1803a65a0();
        puVar16 = auStackY_118;
        break;
      }
    }
  }
LAB_1803a22f3:
  uVar13 = 1;
LAB_1803a22f5:
  *(undefined8 *)(puVar16 + -8) = 0x1803a2301;
  return uVar13;
}

