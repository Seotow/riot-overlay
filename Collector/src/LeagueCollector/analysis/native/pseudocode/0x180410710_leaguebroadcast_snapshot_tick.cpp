// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180410710; descriptive alias: leaguebroadcast_snapshot_tick
// Evidence: ev_86ab94cb5bf793e7e3194ddfa1d28c9b1d5d2a27d9d8d9f8f47f76d3e9dd67c1
// Original Evidence: rea-lb-snapshot-tick.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_180410710(longlong param_1)

{
  longlong lVar1;
  longlong *plVar2;
  longlong lVar3;
  int iVar4;
  undefined4 *puVar5;
  undefined8 *puVar6;
  longlong *plVar7;
  ulonglong uVar8;
  float fVar9;
  undefined1 auStack_1d8 [32];
  undefined8 local_1b8;
  longlong local_1a8;
  undefined1 local_1a0 [8];
  undefined1 local_198 [16];
  undefined1 local_188 [16];
  undefined1 local_178 [8];
  undefined1 (*local_170) [16];
  undefined1 local_168 [24];
  undefined1 local_150 [24];
  undefined1 local_138 [24];
  undefined1 local_120 [24];
  undefined1 local_108 [24];
  undefined1 local_f0 [24];
  undefined1 local_d8 [24];
  undefined1 local_c0 [24];
  undefined1 local_a8 [24];
  undefined1 local_90 [24];
  undefined1 local_78 [32];
  ulonglong local_58;
  
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStack_1d8;
  if (DAT_180d08f8e != '\0') {
    FUN_180404800(*(longlong *)(param_1 + 8) + 0x88c8,*(longlong *)(param_1 + 8) + 0xd0);
    FUN_1801fe670(&local_1a8);
    fVar9 = (float)FUN_1804263a0();
    lVar1 = *(longlong *)(param_1 + 8);
    if ((*(float *)(lVar1 + 0x8840) * 1e+09 <= (float)(local_1a8 - *(longlong *)(lVar1 + 0x8848)))
       || (*(float *)(lVar1 + 0x8840) <= fVar9 - *(float *)(lVar1 + 0x8850))) {
      *(longlong *)(lVar1 + 0x8848) = local_1a8;
      *(float *)(*(longlong *)(param_1 + 8) + 0x8850) = fVar9;
      FUN_1803e9ed0(*(longlong *)(param_1 + 8) + 0xd0,local_168);
      lVar1 = *(longlong *)(param_1 + 8);
      uVar8 = lVar1 + 0x70;
      local_188._8_8_ = 0;
      local_188._0_8_ = uVar8;
      iVar4 = FUN_180973810(uVar8);
      if (iVar4 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (*(int *)(lVar1 + 0xbc) == 0x7fffffff) {
        *(undefined4 *)(lVar1 + 0xbc) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_188[8] = 1;
      plVar2 = *(longlong **)(*(longlong *)(param_1 + 8) + 0x38);
      plVar7 = (longlong *)*plVar2;
      if (plVar7 != plVar2) {
        do {
          lVar1 = plVar7[2];
          lVar3 = *(longlong *)(param_1 + 8);
          *(undefined4 *)(lVar3 + 0x550) = *(undefined4 *)(lVar1 + 0x130);
          puVar5 = (undefined4 *)FUN_18043eea0(lVar3 + 200,local_1a0,local_168);
          local_1b8 = 0;
          puVar5 = (undefined4 *)FUN_1801b3ec0(local_178,*(undefined8 *)(lVar3 + 0x548),1,*puVar5);
          *(undefined4 *)(lVar3 + 0x8838) = *puVar5;
          puVar6 = (undefined8 *)(*(longlong *)(param_1 + 8) + 200);
          local_1a8 = 0;
          (**(code **)*puVar6)(puVar6,&local_1a8);
          lVar3 = local_1a8;
          local_198 = (undefined1  [16])0x0;
          if (local_1a8 != 0) {
            local_170 = (undefined1 (*) [16])FUN_180976d80(0x18);
            *local_170 = (undefined1  [16])0x0;
            *(undefined4 *)(*local_170 + 8) = 1;
            *(undefined4 *)(*local_170 + 0xc) = 1;
            *(undefined ***)*local_170 = &PTR_FUN_180c6f148;
            *(longlong *)local_170[1] = lVar3;
            local_198._8_8_ = local_170;
            local_198._0_8_ = lVar3;
            local_1a8 = 0;
          }
          FUN_1803bd970(lVar1,local_198,0);
          lVar1 = local_1a8;
          if (local_1a8 != 0) {
            lVar3 = *(longlong *)(local_1a8 + 0x80);
            if (lVar3 != 0) {
              FUN_1801ad9b0(lVar3 + 0x28);
              FUN_1801c5db0(lVar3 + 0x18);
              thunk_FUN_180895720(lVar3,0x50);
            }
            FUN_1801c58d0(lVar1);
            thunk_FUN_180895720(lVar1,0x88);
          }
          plVar7 = (longlong *)*plVar7;
        } while (plVar7 != plVar2);
        uVar8 = local_188._0_8_;
      }
      FUN_180973930(uVar8);
      FUN_18022fbb0(local_78);
      FUN_1801e5ed0(local_90);
      FUN_1803fb4e0(local_a8);
      FUN_1801d11e0(local_c0);
      FUN_1801f3260(local_d8);
      FUN_1801d11e0(local_f0);
      FUN_1801ad9b0(local_108);
      FUN_1802d14e0(local_120);
      FUN_1801f3260(local_138);
      FUN_1802d14e0(local_150);
      FUN_1802d14e0(local_168);
    }
  }
  return;
}

