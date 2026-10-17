// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803e5af0; descriptive alias: handle_offset_dump
// Evidence: ev_aa7ec320e561d990767c728c21473a9289715f7611c202acd4786d54b4b51710
// Original Evidence: rea-previous-handler.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1803e5af0(undefined8 param_1,longlong param_2,undefined8 param_3)

{
  longlong *plVar1;
  int iVar2;
  int iVar3;
  code *pcVar4;
  undefined4 uVar5;
  undefined8 uVar6;
  int *piVar7;
  undefined1 *puVar8;
  longlong lVar9;
  longlong lVar10;
  undefined *puVar11;
  undefined1 auStack_278 [8];
  undefined1 auStack_270 [24];
  undefined8 local_258;
  undefined1 local_248;
  undefined1 **local_238;
  undefined8 uStack_230;
  undefined1 local_228 [416];
  undefined1 local_88 [16];
  undefined4 local_78 [2];
  undefined1 local_70 [16];
  longlong local_60;
  undefined1 *local_58;
  undefined1 *local_50;
  undefined4 *local_48;
  ulonglong local_40;
  
  puVar8 = auStack_278;
  local_40 = DAT_180d06cc0 ^ (ulonglong)auStack_278;
  if ((*(uint *)(param_2 + 0x130) & 0x200) == 0) {
    FUN_1803da020(param_2,param_3);
  }
  else {
    local_88 = (undefined1  [16])0x0;
    local_88._8_8_ = FUN_180976d80(0x98);
    *(undefined1 (*) [16])local_88._8_8_ = (undefined1  [16])0x0;
    *(undefined4 *)(*(undefined1 (*) [16])local_88._8_8_ + 8) = 1;
    *(undefined4 *)(*(undefined1 (*) [16])local_88._8_8_ + 0xc) = 1;
    *(undefined ***)*(undefined1 (*) [16])local_88._8_8_ = &PTR_FUN_180c5c310;
    *(undefined8 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x10) = 0;
    (*(undefined1 (*) [16])(local_88._8_8_ + 0x10))[8] = 0;
    *(undefined8 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x20) = 0x4000;
    *(undefined4 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x20) + 8) = 0x7fffffff;
    *(undefined8 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x30) = 8;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x30) + 8) = 0;
    *(undefined4 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x40) = 0;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x40) + 8) = 0;
    *(undefined8 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x50) = 0;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x50) + 8) = 0;
    *(undefined4 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x60) = 0;
    *(undefined2 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x60) + 4) = 0;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x60) + 8) = 0;
    *(undefined2 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x70) = 0;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x70) + 8) = 1;
    *(undefined2 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x80) = 0x100;
    *(undefined8 *)(*(undefined1 (*) [16])(local_88._8_8_ + 0x80) + 8) = 0;
    *(undefined8 *)*(undefined1 (*) [16])(local_88._8_8_ + 0x90) = 0;
    local_88._0_8_ = (undefined1 (*) [16])(local_88._8_8_ + 0x10);
    local_70 = (undefined1  [16])0x0;
    local_60 = 0;
    local_78[0] = 0;
    local_58 = local_70;
    local_50 = local_88;
    local_48 = local_78;
    local_238 = &local_58;
    uVar6 = FUN_1803fbd00(local_228);
    FUN_1803fcf70(uVar6,&local_238,0,local_248);
    uVar6 = local_88._0_8_;
    lVar10 = (longlong)(local_70._8_8_ - local_70._0_8_) >> 2;
    puVar11 = &DAT_180d6e974;
    if (local_70._0_8_ != local_70._8_8_) {
      puVar11 = (undefined *)local_70._0_8_;
    }
    FUN_1801c3f20(local_88._0_8_,lVar10,4);
    lVar9 = lVar10;
    while (lVar9 != 0) {
      lVar9 = lVar9 + -1;
      iVar2 = *(int *)(puVar11 + lVar9 * 4);
      if (*(ulonglong *)(uVar6 + 0x68) < 4) {
        *(undefined8 *)(uVar6 + 0x68) = 4;
      }
      FUN_1801c5360(uVar6,-*(int *)(uVar6 + 0x30) & 3);
      iVar3 = *(int *)(uVar6 + 0x30);
      if (*(ulonglong *)(uVar6 + 0x68) < 4) {
        *(undefined8 *)(uVar6 + 0x68) = 4;
      }
      FUN_1801c5360(uVar6,-iVar3 & 3);
      FUN_1801c5410(uVar6,4);
      piVar7 = (int *)(*(longlong *)(uVar6 + 0x40) + -4);
      *(int **)(uVar6 + 0x40) = piVar7;
      *(int *)(uVar6 + 0x30) = *(int *)(uVar6 + 0x30) + 4;
      *piVar7 = (iVar3 - iVar2) + 4;
    }
    *(undefined1 *)(uVar6 + 0x60) = 0;
    if (*(ulonglong *)(uVar6 + 0x68) < 4) {
      *(undefined8 *)(uVar6 + 0x68) = 4;
    }
    FUN_1801c5360(uVar6,-*(int *)(uVar6 + 0x30) & 3);
    FUN_1801c5410(uVar6,4);
    *(longlong *)(uVar6 + 0x40) = *(longlong *)(uVar6 + 0x40) + -4;
    *(int *)(uVar6 + 0x30) = *(int *)(uVar6 + 0x30) + 4;
    **(undefined4 **)(uVar6 + 0x40) = (int)lVar10;
    iVar2 = *(int *)(uVar6 + 0x30);
    uVar6 = local_88._0_8_;
    *(undefined1 *)(local_88._0_8_ + 0x60) = 1;
    iVar3 = *(int *)(local_88._0_8_ + 0x30);
    if (iVar2 != 0) {
      if (*(ulonglong *)(local_88._0_8_ + 0x68) < 4) {
        *(undefined8 *)(local_88._0_8_ + 0x68) = 4;
      }
      FUN_1801c5360(local_88._0_8_,-iVar3 & 3);
      FUN_1801bd800(uVar6,4,(*(int *)(uVar6 + 0x30) - iVar2) + 4,0);
    }
    uVar5 = FUN_1801be990(uVar6,iVar3);
    local_258 = param_3;
    FUN_1801b3ec0(&local_238,local_88._0_8_,0xf,uVar5);
    FUN_1801c3db0(local_88._0_8_,(ulonglong)local_238 & 0xffffffff);
    local_238 = (undefined1 **)local_88._0_8_;
    uStack_230 = local_88._8_8_;
    local_88 = (undefined1  [16])0x0;
    FUN_1803bd970(param_2,&local_238,0);
    puVar8 = auStack_278;
    if (local_70._0_8_ != 0) {
      lVar10 = local_70._0_8_;
      puVar8 = auStack_278;
      if ((0xfff < (ulonglong)((local_60 - local_70._0_8_ >> 2) * 4)) &&
         (lVar10 = *(longlong *)(local_70._0_8_ + -8), puVar8 = auStack_278,
         0x1f < (local_70._0_8_ - lVar10) - 8U)) {
        lVar10 = 5;
        pcVar4 = (code *)swi(0x29);
        (*pcVar4)(5);
        puVar8 = auStack_270;
      }
      *(undefined8 *)(puVar8 + -8) = 0x1803e5e68;
      thunk_FUN_180895720(lVar10);
      local_70 = (undefined1  [16])0x0;
      local_60 = 0;
    }
    uVar6 = local_88._8_8_;
    if ((longlong *)local_88._8_8_ != (longlong *)0x0) {
      LOCK();
      plVar1 = (longlong *)(local_88._8_8_ + 8);
      lVar10 = *plVar1;
      *(int *)plVar1 = (int)*plVar1 + -1;
      UNLOCK();
      if ((int)lVar10 == 1) {
        pcVar4 = (code *)**(undefined8 **)local_88._8_8_;
        *(undefined8 *)(puVar8 + -8) = 0x1803e5ea4;
        (*pcVar4)(local_88._8_8_);
        LOCK();
        piVar7 = (int *)(uVar6 + 0xc);
        iVar2 = *piVar7;
        *piVar7 = *piVar7 + -1;
        UNLOCK();
        if (iVar2 == 1) {
          pcVar4 = *(code **)(*(longlong *)uVar6 + 8);
          *(undefined8 *)(puVar8 + -8) = 0x1803e5eb7;
          (*pcVar4)(uVar6);
        }
      }
    }
  }
  *(undefined8 *)(puVar8 + -8) = 0x1803e5ec6;
  return;
}

