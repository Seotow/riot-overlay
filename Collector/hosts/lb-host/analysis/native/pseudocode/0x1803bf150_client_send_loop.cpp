// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803bf150; descriptive alias: client_send_loop
// Evidence: ev_af3ebf9056dc5297d5a9e2869e9adc18ce402d9c249b1b85d8afaef76133e357
// Original Evidence: rea-client-send-thread.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001803bf4c4) */
/* WARNING: Removing unreachable block (ram,0x0001803bf5ba) */
/* WARNING: Removing unreachable block (ram,0x0001803bf5c1) */

undefined8 FUN_1803bf150(longlong *param_1)

{
  longlong *plVar1;
  longlong *plVar2;
  int *piVar3;
  longlong *plVar4;
  code *pcVar5;
  bool bVar6;
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined8 uVar9;
  undefined8 uVar10;
  bool bVar11;
  int iVar12;
  longlong lVar13;
  undefined1 *puVar14;
  ulonglong uVar15;
  undefined1 *puVar16;
  undefined1 auStack_148 [8];
  undefined1 auStack_140 [24];
  undefined8 local_128;
  undefined1 local_118 [16];
  longlong local_108;
  int **local_100;
  longlong *local_f8;
  int *local_f0;
  int *local_e8;
  int **local_e0;
  code *local_d8;
  undefined1 local_c8 [24];
  int local_b0 [2];
  undefined1 local_a8 [16];
  undefined8 uStack_98;
  ulonglong uStack_90;
  undefined8 local_88;
  longlong *local_80;
  undefined *local_78;
  undefined8 local_70;
  int local_68 [2];
  char local_60;
  ulonglong local_58;
  
  puVar16 = auStack_148;
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStack_148;
  plVar2 = (longlong *)*param_1;
  local_f8 = param_1;
  if ((int)plVar2[5] != 0) {
    plVar1 = plVar2 + 0xf;
    do {
      piVar3 = (int *)plVar2[6];
      if (piVar3 != (int *)0x0) {
        LOCK();
        *piVar3 = *piVar3 + 1;
        UNLOCK();
      }
      iVar12 = FUN_180973810(plVar2 + 0x1a);
      if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (*(int *)((longlong)plVar2 + 0x11c) == 0x7fffffff) {
        *(int *)((longlong)plVar2 + 0x11c) = *(int *)((longlong)plVar2 + 0x11c) + -1;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      if (piVar3 != (int *)0x0) {
        LOCK();
        *piVar3 = *piVar3 + 1;
        UNLOCK();
      }
      local_a8 = ZEXT816(0);
      uStack_98 = 0;
      uStack_90 = 0;
      local_88 = 0;
      local_f0 = piVar3;
      local_80 = plVar1;
      FUN_1803bf8c0(local_a8,&local_f0,&local_80);
      lVar13 = plVar2[0x25];
      while (lVar13 == 0) {
        lVar13 = *plVar1;
        iVar12 = FUN_180973810(lVar13);
        if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (*(int *)(lVar13 + 0x4c) == 0x7fffffff) {
          *(undefined4 *)(lVar13 + 0x4c) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        if ((piVar3 != (int *)0x0) && ((piVar3[1] & 1U) != 0)) {
          FUN_180973930(lVar13);
          FUN_1803bfa30(local_a8);
          LOCK();
          iVar12 = *piVar3;
          *piVar3 = *piVar3 + -1;
          UNLOCK();
          if (iVar12 != 1) goto LAB_1803bf2cc;
          goto LAB_1803bf2c4;
        }
        FUN_180973930(plVar2 + 0x1a);
        FUN_180974e10(plVar2 + 0x11,*plVar1);
        FUN_180973930(lVar13);
        iVar12 = FUN_180973810(plVar2 + 0x1a);
        if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (*(int *)((longlong)plVar2 + 0x11c) == 0x7fffffff) {
          *(int *)((longlong)plVar2 + 0x11c) = *(int *)((longlong)plVar2 + 0x11c) + -1;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        lVar13 = plVar2[0x25];
      }
      FUN_1803bfa30(local_a8);
      if (piVar3 == (int *)0x0) {
LAB_1803bf311:
        lVar13 = *(longlong *)plVar2[0x24];
        auVar7 = *(undefined1 (*) [16])(lVar13 + 0x10);
        *(undefined8 *)(lVar13 + 0x10) = 0;
        *(undefined8 *)(lVar13 + 0x18) = 0;
        plVar4 = *(longlong **)plVar2[0x24];
        lVar13 = *plVar4;
        plVar2[0x25] = plVar2[0x25] + -1;
        *(longlong *)plVar4[1] = lVar13;
        *(longlong *)(lVar13 + 8) = plVar4[1];
        FUN_1803bfbe0();
        bVar6 = true;
        local_c8._0_16_ = auVar7;
        FUN_180973930(plVar2 + 0x1a);
        bVar11 = true;
        if (piVar3 != (int *)0x0) goto LAB_1803bf378;
      }
      else {
        LOCK();
        iVar12 = *piVar3;
        *piVar3 = *piVar3 + -1;
        UNLOCK();
        if (iVar12 == 1) {
LAB_1803bf2c4:
          thunk_FUN_180895720(piVar3,0x20);
        }
LAB_1803bf2cc:
        if ((piVar3[1] & 1U) == 0) goto LAB_1803bf311;
        FUN_180973930(plVar2 + 0x1a);
        bVar11 = false;
LAB_1803bf378:
        bVar6 = bVar11;
        LOCK();
        iVar12 = *piVar3;
        *piVar3 = *piVar3 + -1;
        UNLOCK();
        if (iVar12 == 1) {
          thunk_FUN_180895720(piVar3,0x20);
        }
      }
      if (!bVar6) break;
      uVar9 = local_c8._0_8_;
      uVar10 = local_c8._8_8_;
      local_c8._0_16_ = (undefined1  [16])0x0;
      local_b0[0] = *(int *)(uVar9 + 0x30);
      local_e8 = local_b0;
      local_e0 = (int **)0x4;
      (**(code **)(*plVar2 + 0x10))(plVar2,&local_78,&local_e8);
      if ((char)local_70 == '\0') {
        local_68[0] = (int)local_78;
        local_60 = '\0';
        if ((longlong *)uVar10 != (longlong *)0x0) goto LAB_1803bf503;
LAB_1803bf3f1:
        iVar12 = FUN_180973810(&DAT_180d6eb78);
        if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (DAT_180d6ebc4 == 0x7fffffff) {
          DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        local_118[0] = 0;
        FUN_180185e60(&DAT_180d6eb28,local_118);
        local_b0[0] = 0x16;
        FUN_1801877a0(&DAT_180d6eb28,local_b0,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d978,0x16);
        local_f0 = (int *)_Xtime_get_ticks();
        local_e0 = &local_f0;
        local_d8 = FUN_180191210;
        local_e8 = (int *)0xd000000000000000;
        uStack_98 = 0;
        uStack_90 = 0xf;
        local_a8._1_15_ = SUB1615((undefined1  [16])0x0,1);
        auVar7[0xf] = 0;
        auVar7._0_15_ = local_a8._1_15_;
        local_a8 = auVar7 << 8;
        FUN_18019f7a0(local_a8,0x11);
        local_108 = 1;
        local_100 = &local_e8;
        local_78 = &DAT_180c09610;
        local_70 = 9;
        local_128 = 0;
        FUN_18018ad00(local_b0,local_a8,&local_78,&local_108);
        local_b0[0] = 1;
        FUN_180185f70(&DAT_180d6eb28,local_b0);
        local_b0[0] = (int)uStack_98;
        FUN_1801877a0(&DAT_180d6eb28,local_b0,4);
        puVar14 = local_a8;
        if (0xf < uStack_90) {
          puVar14 = (undefined1 *)local_a8._0_8_;
        }
        FUN_1801877a0(&DAT_180d6eb28,puVar14,uStack_98);
        iVar12 = local_68[0];
        local_b0[0] = 0;
        FUN_180185f70(&DAT_180d6eb28,local_b0);
        local_b0[0] = 4;
        FUN_1801877a0(&DAT_180d6eb28,local_b0,4);
        local_b0[0] = iVar12;
        FUN_1801877a0(&DAT_180d6eb28,local_b0,4);
        if (DAT_180d6ebe0 != '\0') {
          local_b0[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
          FUN_1803c9190(&DAT_180d6ebc8,&local_108,local_b0,4);
          FUN_1803c9190(&DAT_180d6ebc8,&local_108,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                        DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_108 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_100 = (int **)(DAT_180d6eb30 - local_108);
        FUN_1801806e0(&DAT_180d6eb40,&local_108);
        local_80 = (longlong *)
                   CONCAT44(local_80._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
        FUN_180186fb0(&DAT_180d6ea20,&local_80,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        if (0xf < uStack_90) {
          uVar15 = uStack_90 + 1;
          lVar13 = local_a8._0_8_;
          if (0xfff < uVar15) {
            lVar13 = *(longlong *)(local_a8._0_8_ + -8);
            if (0x1f < (local_a8._0_8_ - lVar13) - 8U) {
              pcVar5 = (code *)swi(0x29);
              iVar12 = (*pcVar5)(5);
              puVar16 = auStack_140;
              goto LAB_1803bf82d;
            }
            uVar15 = uStack_90 + 0x28;
          }
          thunk_FUN_180895720(lVar13,uVar15);
        }
        uStack_98 = 0;
        uStack_90 = 0xf;
        auVar8[0xf] = 0;
        auVar8._0_15_ = local_a8._1_15_;
        local_a8 = auVar8 << 8;
        FUN_180973930(&DAT_180d6eb78);
        *(undefined4 *)(plVar2 + 7) = 2;
        LOCK();
        *(undefined4 *)(plVar2 + 5) = 0;
        UNLOCK();
        FUN_1802d5df0(plVar2 + 6);
        (**(code **)*plVar2)(plVar2);
        FUN_1803bddc0(plVar2);
        break;
      }
      local_108 = *(longlong *)(uVar9 + 0x40);
      local_100 = (int **)(ulonglong)*(uint *)(uVar9 + 0x30);
      (**(code **)(*plVar2 + 0x10))(plVar2,local_68,&local_108);
      if ((longlong *)uVar10 != (longlong *)0x0) {
LAB_1803bf503:
        LOCK();
        plVar4 = (longlong *)(uVar10 + 8);
        lVar13 = *plVar4;
        *(int *)plVar4 = (int)*plVar4 + -1;
        UNLOCK();
        if ((int)lVar13 == 1) {
          (*(code *)**(undefined8 **)uVar10)(uVar10);
          LOCK();
          piVar3 = (int *)(uVar10 + 0xc);
          iVar12 = *piVar3;
          *piVar3 = *piVar3 + -1;
          UNLOCK();
          if (iVar12 == 1) {
            (**(code **)(*(longlong *)uVar10 + 8))(uVar10);
          }
        }
      }
      if (local_60 == '\0') goto LAB_1803bf3f1;
    } while ((int)plVar2[5] != 0);
  }
  plVar1 = local_f8;
  iVar12 = FUN_180973810(plVar2 + 0x1a);
  if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  iVar12 = *(int *)((longlong)plVar2 + 0x11c);
  if (iVar12 != 0x7fffffff) {
    FUN_180973930(plVar2 + 0x1a);
    FUN_180974e60();
    thunk_FUN_180895720(plVar1,8);
    return 0;
  }
LAB_1803bf82d:
  *(int *)((longlong)plVar2 + 0x11c) = iVar12 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar16 + -8) = &UNK_1803bf840;
  FUN_1809737c0(6);
}

