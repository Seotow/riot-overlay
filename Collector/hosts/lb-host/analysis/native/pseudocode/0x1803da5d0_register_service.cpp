// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803da5d0; descriptive alias: register_service
// Evidence: ev_f50661c563bb38a0fdae3b354bea8849fa094d8d93350910be9ffa5effa366f4
// Original Evidence: rea-register-service.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1803da5d0(longlong param_1,undefined8 *param_2,undefined8 param_3,ulonglong param_4,
                  ulonglong *param_5)

{
  longlong *plVar1;
  longlong *plVar2;
  code *pcVar3;
  undefined1 *puVar4;
  char cVar5;
  int iVar6;
  undefined8 *puVar7;
  ulonglong *puVar8;
  ulonglong uVar9;
  longlong lVar10;
  ulonglong uVar11;
  undefined8 uVar12;
  ulonglong uVar13;
  uint *puVar14;
  ulonglong *puVar15;
  undefined1 *puVar16;
  undefined1 *puVar17;
  longlong lVar18;
  uint uVar19;
  ulonglong uVar20;
  ulonglong uVar21;
  undefined1 auVar22 [16];
  undefined1 auVar23 [16];
  undefined1 auVar24 [16];
  undefined1 extraout_var [56];
  undefined1 auVar25 [64];
  undefined1 auVar26 [64];
  undefined1 auStack_148 [8];
  undefined1 auStack_140 [24];
  uint local_128 [2];
  uint local_120 [2];
  undefined8 local_118;
  ulonglong *local_110;
  ulonglong *local_108;
  undefined1 local_100 [16];
  undefined8 local_f0;
  ulonglong local_e8;
  undefined8 local_e0;
  ulonglong *local_d8;
  ulonglong *local_d0;
  undefined1 local_c0 [16];
  ulonglong *local_b0;
  undefined1 local_a8 [16];
  undefined8 local_98;
  ulonglong local_90;
  longlong *local_88;
  undefined8 *local_68;
  undefined8 *local_60;
  
  puVar17 = auStack_148;
  puVar16 = auStack_148;
  local_60 = (undefined8 *)(DAT_180d06cc0 ^ (ulonglong)auStack_148);
  uVar19 = (uint)param_4;
  uVar13 = (ulonglong)(int)uVar19;
  local_d8 = param_5;
  uVar21 = param_1 + 0x1a8;
  local_c0._8_8_ = 0;
  local_c0._0_8_ = uVar21;
  local_128[0] = uVar19;
  local_118 = param_3;
  local_108 = (ulonglong *)param_1;
  local_e0 = param_3;
  local_68 = param_2;
  iVar6 = FUN_180973810(uVar21);
  puVar15 = local_108;
  if (iVar6 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (*(int *)((longlong)local_108 + 500) == 0x7fffffff) {
    *(undefined4 *)((longlong)local_108 + 500) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(6);
  }
  local_c0[8] = 1;
  local_108 = (ulonglong *)((longlong)local_108 + 0x228);
  uVar20 = ((((param_4 & 0xff ^ 0xcbf29ce484222325) * 0x100000001b3 ^ param_4 >> 8 & 0xff) *
             0x100000001b3 ^ param_4 >> 0x10 & 0xff) * 0x100000001b3 ^ param_4 >> 0x18 & 0xff) *
           0x100000001b3 & *local_108;
  local_88 = (longlong *)((longlong)puVar15 + 0x210);
  lVar10 = *(longlong *)((longlong)puVar15 + 0x210);
  uVar9 = *(ulonglong *)(lVar10 + 8 + uVar20 * 0x10);
  local_d0 = (ulonglong *)((longlong)puVar15 + 0x200);
  uVar11 = 0;
  if (uVar9 != *(ulonglong *)((longlong)puVar15 + 0x200)) {
    for (; (uVar11 = uVar9, uVar19 != *(uint *)(uVar9 + 0x10) &&
           (uVar11 = 0, uVar9 != *(ulonglong *)(lVar10 + uVar20 * 0x10)));
        uVar9 = *(ulonglong *)(uVar9 + 8)) {
    }
  }
  puVar4 = auStack_148;
  if (uVar11 == 0) {
    if (uVar19 < 6) {
      local_b0 = param_5;
      puVar15 = (ulonglong *)((longlong)puVar15 + 0x1f8);
      local_110 = puVar15;
      switch(uVar19) {
      case 0:
        puVar7 = (undefined8 *)FUN_180976d80(0x8958);
        local_100._0_8_ = puVar7;
        FUN_1809bef30(puVar7,0,0x8958);
        FUN_180404e80(puVar7);
        *puVar7 = &PTR_FUN_180c6fb48;
        FUN_180441560(puVar7 + 0x19,0x80000);
        *(undefined4 *)(puVar7 + 0x1107) = 0;
        puVar7[0x19] = &PTR_FUN_180c6ff48;
        puVar7[0x1108] = 0;
        puVar7[0x1109] = 0;
        puVar7[0x110a] = 0;
        puVar7[0x110b] = 0;
        puVar7[0x110c] = 0;
        puVar7[0x110d] = 0;
        puVar7[0x110e] = 0;
        puVar7[0x110f] = 0;
        puVar7[0x1110] = 0;
        puVar7[0x1111] = 0;
        puVar7[0x1112] = 0;
        puVar7[0x1113] = 0;
        puVar7[0x1114] = 0;
        puVar7[0x1115] = 0;
        FUN_1804063c0(puVar7 + 0x1116);
        local_68 = puVar7;
        FUN_180404900(puVar7);
        FUN_1803e7b70(puVar15,local_100,local_128,&local_68);
        FUN_1803e9510(&local_68);
        break;
      case 1:
        if ((uint)*param_5 != 0) {
          puVar14 = (uint *)((longlong)param_5 + 4);
          local_100._0_8_ = puVar14;
          if (*(int *)((ulonglong)*puVar14 + 4 + (longlong)param_5) != 0) {
            auVar24._0_12_ = ZEXT812(0);
            auVar24._12_4_ = 0;
            local_120[0] = 0;
            puVar16 = auStack_148;
            if ((1 < (uint)*param_5) &&
               (puVar16 = auStack_148,
               *(int *)((ulonglong)(uint)param_5[1] + 8 + (longlong)param_5) != 0)) {
              local_98 = 0;
              local_90 = 0;
              local_a8 = auVar24;
              FUN_1801a0b30(local_a8,(ulonglong)(uint)param_5[1] + 0xc + (longlong)param_5,
                            *(undefined4 *)((ulonglong)(uint)param_5[1] + 8 + (longlong)param_5));
              local_120[0] = FUN_180402d90(local_a8);
              puVar16 = auStack_148;
              if (0xf < local_90) {
                uVar13 = local_90 + 1;
                lVar10 = local_a8._0_8_;
                if (0xfff < uVar13) {
                  lVar10 = *(longlong *)(local_a8._0_8_ + -8);
                  if (0x1f < (local_a8._0_8_ - lVar10) - 8U) {
                    pcVar3 = (code *)swi(0x29);
                    (*pcVar3)(5);
                    local_110 = local_d8;
                    puVar14 = (uint *)local_100._8_8_;
                    puVar16 = auStack_140;
                    puVar15 = local_108;
                    uVar21 = local_c0._8_8_;
                    param_5 = (ulonglong *)local_a8._0_8_;
                    param_2 = local_60;
                    goto LAB_1803daba0;
                  }
                  uVar13 = local_90 + 0x28;
                }
                thunk_FUN_180895720(lVar10,uVar13);
                puVar16 = auStack_148;
              }
            }
LAB_1803daba0:
            *(undefined8 *)(puVar16 + 0xe0) = 0;
            uVar19 = *puVar14;
            *(ulonglong *)(puVar16 + 0x48) = (longlong)param_5 + (ulonglong)uVar19 + 8;
            *(ulonglong *)(puVar16 + 0x50) =
                 (ulonglong)*(uint *)((ulonglong)uVar19 + 4 + (longlong)param_5);
            *(undefined8 *)(puVar16 + -8) = 0x1803dabd6;
            FUN_1803e7d90(puVar16 + 0xe0,puVar16 + 0x48,puVar16 + 0x28);
            *(undefined8 *)(puVar16 + -8) = 0x1803dabe4;
            FUN_180404900(*(undefined8 *)(puVar16 + 0xe0));
            *(undefined8 *)(puVar16 + -8) = 0x1803dabfe;
            FUN_1803e7b70(puVar15,puVar16 + 0x48,puVar16 + 0x20,puVar16 + 0xe0);
            *(undefined8 *)(puVar16 + -8) = 0x1803dac0c;
            FUN_1803e9380(puVar16 + 0xe0);
            break;
          }
        }
        FUN_1803eabb0();
        goto LAB_1803db02c;
      case 2:
        auVar26 = ZEXT464(0x3e4ccccd);
        auVar25 = ZEXT1664(auVar26._0_16_);
        local_120[0] = 0x3e4ccccd;
        puVar16 = auStack_148;
        if (((uint)*param_5 != 0) &&
           (puVar16 = auStack_148,
           *(int *)((ulonglong)*(uint *)((longlong)param_5 + 4) + 4 + (longlong)param_5) != 0)) {
          local_100 = (undefined1  [16])0x0;
          local_f0 = 0;
          local_e8 = 0;
          FUN_1801a0b30(local_100,
                        (ulonglong)*(uint *)((longlong)param_5 + 4) + 8 + (longlong)param_5,
                        *(undefined4 *)
                         ((ulonglong)*(uint *)((longlong)param_5 + 4) + 4 + (longlong)param_5));
          auVar25._0_8_ = FUN_180402d90(local_100);
          auVar25._8_56_ = extraout_var;
          auVar22 = auVar25._0_16_;
          auVar25 = ZEXT1664(auVar22);
          if (0xf < local_e8) {
            uVar13 = local_e8 + 1;
            lVar10 = local_100._0_8_;
            if (0xfff < uVar13) {
              lVar10 = *(longlong *)(local_100._0_8_ + -8);
              if (0x1f < (local_100._0_8_ - lVar10) - 8U) {
                pcVar3 = (code *)swi(0x29);
                (*pcVar3)(5);
                puVar16 = auStack_140;
                auVar25 = ZEXT464((uint)local_118);
                auVar26 = ZEXT464(0x3e4ccccd);
                local_110 = local_d8;
                puVar15 = local_108;
                uVar21 = local_c0._8_8_;
                param_5 = local_d0;
                param_2 = local_60;
                goto LAB_1803da968;
              }
              uVar13 = local_e8 + 0x28;
            }
            thunk_FUN_180895720(lVar10,uVar13);
            auVar22 = auVar25._0_16_;
          }
          auVar23._0_4_ = auVar22._0_4_ / 1000.0;
          auVar23._4_12_ = auVar22._4_12_;
          auVar22 = vmaxss_avx(auVar23,ZEXT416(0x3c83126f));
          auVar25 = ZEXT1664(auVar22);
          local_120[0] = auVar22._0_4_;
          puVar16 = auStack_148;
        }
LAB_1803da968:
        *(undefined8 *)(puVar16 + -8) = 0x1803da972;
        puVar7 = (undefined8 *)FUN_180976d80(0x8970);
        *(undefined8 **)(puVar16 + 0x48) = puVar7;
        *(undefined8 *)(puVar16 + -8) = 0x1803da98a;
        FUN_1809bef30(puVar7,0,0x8970);
        *(undefined8 *)(puVar16 + -8) = 0x1803da992;
        FUN_180404e80(puVar7);
        *puVar7 = &PTR_FUN_180c6fb88;
        *(undefined8 *)(puVar16 + -8) = 0x1803da9ae;
        FUN_180441560(puVar7 + 0x19,0x80000);
        puVar7[0x19] = &PTR_FUN_180c6ff48;
        *(undefined4 *)(puVar7 + 0x1107) = 0;
        auVar22._0_12_ = ZEXT812(0);
        auVar22._12_4_ = 0;
        auVar22 = vcmpss_avx(auVar25._0_16_,auVar22,2);
        auVar22 = vblendvps_avx(auVar25._0_16_,auVar26._0_16_,auVar22);
        *(int *)(puVar7 + 0x1108) = auVar22._0_4_;
        *(undefined8 *)(puVar16 + -8) = 0x1803da9e5;
        FUN_1801fe670(puVar7 + 0x1109);
        *(undefined4 *)(puVar7 + 0x110a) = 0;
        puVar7[0x110b] = 0;
        puVar7[0x110c] = 0;
        puVar7[0x110d] = 0;
        puVar7[0x110e] = 0;
        puVar7[0x110f] = 0;
        puVar7[0x1110] = 0;
        puVar7[0x1111] = 0;
        puVar7[0x1112] = 0;
        puVar7[0x1113] = 0;
        puVar7[0x1114] = 0;
        puVar7[0x1115] = 0;
        puVar7[0x1116] = 0;
        puVar7[0x1117] = 0;
        puVar7[0x1118] = 0;
        *(undefined8 *)(puVar16 + -8) = 0x1803daa59;
        FUN_1804063c0(puVar7 + 0x1119);
        *(undefined8 **)(puVar16 + 0xe0) = puVar7;
        *(undefined8 *)(puVar16 + -8) = 0x1803daa6a;
        FUN_180404900(puVar7);
        *(undefined8 *)(puVar16 + -8) = 0x1803daa84;
        FUN_1803e7b70(puVar15,puVar16 + 0x48,puVar16 + 0x20,puVar16 + 0xe0);
        *(undefined8 *)(puVar16 + -8) = 0x1803daa92;
        FUN_1803e9450(puVar16 + 0xe0);
        break;
      case 3:
        puVar8 = (ulonglong *)FUN_180976d80(0x138);
        local_100._0_8_ = puVar8;
        FUN_1809bef30(puVar8,0,0x138);
        FUN_180404e80(puVar8);
        *puVar8 = (ulonglong)&PTR_FUN_180c6fa80;
        puVar8[0x19] = 0;
        FUN_1801fe670(puVar8 + 0x1a);
        puVar8[0x1e] = 0;
        puVar8[0x1f] = 0;
        puVar8[0x20] = 0;
        puVar8[0x21] = 0;
        puVar8[0x20] = 0;
        puVar8[0x21] = 0;
        puVar8[0x22] = 0;
        puVar8[0x23] = 0;
        puVar8[0x1c] = 0;
        puVar8[0x1d] = 0;
        *(uint *)(puVar8 + 0x24) = 0xffffffff;
        *(uint *)(puVar8 + 0x1b) = 2;
        *(uint *)((longlong)puVar8 + 0x124) = 0;
        puVar8[0x25] = 0;
        puVar8[0x26] = 0;
        FUN_18040c510();
        local_110 = puVar8;
        FUN_180404900(puVar8);
        FUN_1803e7b70(puVar15,local_100,local_128,&local_110);
        puVar15 = local_110;
        puVar16 = auStack_148;
        if (local_110 != (ulonglong *)0x0) {
          FUN_1803c39d0(local_110 + 0x25);
          FUN_1804049a0(puVar15);
          uVar12 = 0x138;
LAB_1803dacfe:
          thunk_FUN_180895720(puVar15,uVar12);
          puVar16 = auStack_148;
        }
        break;
      case 4:
        puVar8 = (ulonglong *)FUN_180976d80(0xf0);
        local_100._0_8_ = puVar8;
        FUN_1809bef30(puVar8,0,0xf0);
        FUN_180404e80(puVar8);
        *puVar8 = (ulonglong)&PTR_FUN_180c6fac0;
        *(uint *)(puVar8 + 0x19) = 0;
        *(uint *)((longlong)puVar8 + 0xcc) = 0x3f800000;
        *(undefined1 *)(puVar8 + 0x1a) = 0;
        puVar8[0x1b] = 0;
        puVar8[0x1c] = 0;
        puVar8[0x1d] = 0;
        FUN_18040c870();
        local_110 = puVar8;
        FUN_180404900(puVar8);
        FUN_1803e7b70(puVar15,local_100,local_128,&local_110);
        puVar15 = local_110;
        puVar16 = auStack_148;
        if (local_110 != (ulonglong *)0x0) {
          FUN_1803c39d0(local_110 + 0x1c);
          FUN_1804049a0(puVar15);
          uVar12 = 0xf0;
          goto LAB_1803dacfe;
        }
        break;
      case 5:
        puVar8 = (ulonglong *)FUN_180976d80(0x118);
        local_100._0_8_ = puVar8;
        FUN_1809bef30(puVar8,0,0x118);
        FUN_180404e80(puVar8);
        *puVar8 = (ulonglong)&PTR_FUN_180c6fa40;
        puVar8[0x19] = 0;
        FUN_1801fe670(puVar8 + 0x1a);
        *(undefined1 *)(puVar8 + 0x1b) = 0;
        ((uint *)((longlong)puVar8 + 0xdc))[0] = 0;
        ((uint *)((longlong)puVar8 + 0xdc))[1] = 0;
        ((uint *)((longlong)puVar8 + 0xe4))[0] = 0;
        ((uint *)((longlong)puVar8 + 0xe4))[1] = 0;
        ((uint *)((longlong)puVar8 + 0xec))[0] = 0;
        ((uint *)((longlong)puVar8 + 0xec))[1] = 0;
        FUN_1801fe670(puVar8 + 0x1f);
        *(uint *)(puVar8 + 0x20) = 0;
        puVar8[0x21] = 0;
        puVar8[0x22] = 0;
        FUN_18040cbd0();
        local_110 = puVar8;
        FUN_180404900(puVar8);
        FUN_1803e7b70(puVar15,local_100,local_128,&local_110);
        puVar15 = local_110;
        puVar16 = auStack_148;
        if (local_110 != (ulonglong *)0x0) {
          FUN_1803c39d0(local_110 + 0x21);
          FUN_1804049a0(puVar15);
          uVar12 = 0x118;
          goto LAB_1803dacfe;
        }
      }
      uVar13 = (ulonglong)*(uint *)(puVar16 + 0x20);
      param_3 = *(undefined8 *)(puVar16 + 0x30);
      puVar4 = puVar16;
      goto LAB_1803dad0f;
    }
    local_120[0] = uVar19;
    FUN_1803eaf10(0,local_120);
    puVar17 = auStack_148;
  }
  else {
LAB_1803dad0f:
    puVar17 = puVar4;
    uVar11 = ((((uVar13 & 0xff ^ 0xcbf29ce484222325) * 0x100000001b3 ^
               (ulonglong)(byte)puVar17[0x21]) * 0x100000001b3 ^ (ulonglong)(byte)puVar17[0x22]) *
              0x100000001b3 ^ (ulonglong)(byte)puVar17[0x23]) * 0x100000001b3 &
             **(ulonglong **)(puVar17 + 0x40);
    lVar10 = *(longlong *)(**(longlong **)(puVar17 + 0xc0) + 8 + uVar11 * 0x10);
    uVar9 = uVar11;
    lVar18 = 0;
    if (lVar10 != **(longlong **)(puVar17 + 0x78)) {
      uVar9 = uVar11 * 2;
      iVar6 = *(int *)(lVar10 + 0x10);
      while ((lVar18 = lVar10, (int)uVar13 != iVar6 &&
             (lVar18 = 0, lVar10 != *(longlong *)(**(longlong **)(puVar17 + 0xc0) + uVar11 * 0x10)))
            ) {
        lVar10 = *(longlong *)(lVar10 + 8);
        iVar6 = *(int *)(lVar10 + 0x10);
      }
    }
    if (((lVar18 == 0) || (lVar18 == **(longlong **)(puVar17 + 0x78))) ||
       (plVar2 = *(longlong **)(lVar18 + 0x18), plVar2 == (longlong *)0x0)) {
      *(int *)(puVar17 + 0x28) = (int)uVar13;
      *(undefined8 *)(puVar17 + -8) = 0x1803db020;
      FUN_1803eb2c0(uVar9,puVar17 + 0x28);
    }
    else {
      *(undefined8 **)(puVar17 + 0x40) = param_2;
      pcVar3 = *(code **)(*plVar2 + 0x20);
      *(undefined8 *)(puVar17 + -8) = 0x1803dadcd;
      cVar5 = (*pcVar3)(plVar2,param_2 + 0x26);
      if (cVar5 != '\0') {
        *(undefined1 (*) [16])(puVar17 + 0x78) = (undefined1  [16])0x0;
        plVar1 = plVar2 + 0xe;
        *(longlong **)(puVar17 + 0x78) = plVar1;
        puVar17[0x80] = 0;
        *(undefined8 *)(puVar17 + -8) = 0x1803dadf8;
        iVar6 = FUN_180973810(plVar1);
        if (iVar6 != 0) {
                    /* WARNING: Subroutine does not return */
          *(undefined **)(puVar17 + -8) = &UNK_1803db09b;
          FUN_1809737c0(5);
        }
        if (*(int *)((longlong)plVar2 + 0xbc) == 0x7fffffff) {
          *(undefined4 *)((longlong)plVar2 + 0xbc) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          *(undefined **)(puVar17 + -8) = &UNK_1803db0ae;
          FUN_1809737c0(6);
        }
        puVar17[0x80] = 1;
        *(undefined8 *)(puVar17 + -8) = 0x1803dafdc;
        FUN_18040cf30(plVar2 + 6,puVar17 + 0xc0,puVar17 + 0x40);
        uVar12 = *(undefined8 *)(puVar17 + 0x40);
        pcVar3 = *(code **)(*plVar2 + 8);
        *(undefined8 *)(puVar17 + -8) = 0x1803daff0;
        (*pcVar3)(plVar2,uVar12,param_5);
        pcVar3 = *(code **)(*plVar2 + 0x10);
        *(undefined8 *)(puVar17 + -8) = 0x1803daffc;
        (*pcVar3)(plVar2,uVar12);
        *(undefined8 *)(puVar17 + -8) = 0x1803db005;
        FUN_180973930(plVar1);
        *(undefined8 *)(puVar17 + -8) = 0x1803db010;
        FUN_1803d9e90(param_2,param_3);
        goto LAB_1803db02c;
      }
    }
  }
  *(undefined8 *)(puVar17 + -8) = 0x1803db02b;
  FUN_1803da020(param_2,param_3);
LAB_1803db02c:
  *(undefined8 *)(puVar17 + -8) = 0x1803db034;
  FUN_180973930(uVar21);
  *(undefined8 *)(puVar17 + -8) = 0x1803db044;
  return;
}

