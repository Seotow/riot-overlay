// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804347d0; descriptive alias: FUN_1804347d0
// Evidence: ev_b706e22b9ca5e94c966966f26b7d3290a8c8817cd68f1bff7050f2d2c31fd7dc
// Original Evidence: rea-collector/0x1804347d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804347d0(longlong param_1,ulonglong param_2)

{
  uint uVar1;
  longlong *plVar2;
  longlong *plVar3;
  longlong lVar4;
  undefined8 *puVar5;
  undefined8 *puVar6;
  longlong lVar7;
  int iVar8;
  ulonglong uVar9;
  longlong lVar10;
  longlong *plVar11;
  longlong *plVar12;
  longlong *local_58;
  longlong local_50;
  longlong local_48;
  void *local_40;
  
  for (uVar9 = 0x3f; 0xfffffffffffffffU >> uVar9 == 0; uVar9 = uVar9 - 1) {
  }
  local_50 = param_1;
  if ((ulonglong)(1L << (uVar9 & 0x3f)) < param_2) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("invalid hash bucket count");
  }
  uVar9 = param_2 - 1 | 1;
  plVar2 = *(longlong **)(param_1 + 0x18);
  lVar10 = 0x3f;
  if (uVar9 != 0) {
    for (; uVar9 >> lVar10 == 0; lVar10 = lVar10 + -1) {
    }
  }
  uVar9 = (ulonglong)((int)lVar10 + 1);
  lVar10 = 1L << (uVar9 & 0x3f);
  plVar12 = (longlong *)(param_1 + 0x28);
  local_58 = plVar2;
  FUN_1801ab260(plVar12,2L << (uVar9 & 0x3f),plVar2);
  *(longlong *)(param_1 + 0x48) = lVar10;
  *(longlong *)(param_1 + 0x40) = lVar10 + -1;
  plVar11 = (longlong *)**(longlong **)(param_1 + 0x18);
  if (plVar11 != plVar2) {
    do {
      plVar2 = (longlong *)*plVar11;
      uVar9 = FUN_180434320(param_1,plVar11 + 2);
      lVar10 = *plVar12;
      uVar9 = *(ulonglong *)(param_1 + 0x40) & uVar9;
      plVar12 = *(longlong **)(lVar10 + uVar9 * 0x10);
      if (plVar12 == local_58) {
        *(longlong **)(lVar10 + uVar9 * 0x10) = plVar11;
        *(longlong **)(lVar10 + 8 + uVar9 * 0x10) = plVar11;
      }
      else {
        plVar3 = *(longlong **)(lVar10 + 8 + uVar9 * 0x10);
        local_48 = *(longlong *)(*(longlong *)(param_1 + 8) + 0x28);
        lVar4 = *(longlong *)(*(longlong *)(param_1 + 8) + 0x38);
        local_40 = (void *)(local_48 + 4 + (lVar4 - (ulonglong)*(uint *)(plVar11 + 2)));
        uVar1 = *(uint *)((lVar4 - (ulonglong)*(uint *)(plVar11 + 2)) + local_48);
        lVar7 = local_48;
        if ((uVar1 == *(uint *)((lVar4 - (ulonglong)*(uint *)(plVar3 + 2)) + local_48)) &&
           ((uVar1 == 0 ||
            (iVar8 = memcmp(local_40,(void *)((lVar4 - (ulonglong)*(uint *)(plVar3 + 2)) +
                                             local_48 + 4),(ulonglong)uVar1), lVar7 = local_48,
            iVar8 == 0)))) {
          plVar3 = (longlong *)*plVar3;
          if (plVar3 != plVar11) {
            plVar12 = (longlong *)plVar11[1];
            *plVar12 = (longlong)plVar2;
            puVar5 = (undefined8 *)plVar2[1];
            *puVar5 = plVar3;
            puVar6 = (undefined8 *)plVar3[1];
            *puVar6 = plVar11;
            plVar3[1] = (longlong)puVar5;
            plVar2[1] = (longlong)plVar12;
            plVar11[1] = (longlong)puVar6;
          }
          *(longlong **)(lVar10 + 8 + uVar9 * 0x10) = plVar11;
          param_1 = local_50;
        }
        else {
          do {
            if (plVar12 == plVar3) {
              plVar12 = (longlong *)plVar11[1];
              *plVar12 = (longlong)plVar2;
              puVar5 = (undefined8 *)plVar2[1];
              *puVar5 = plVar3;
              puVar6 = (undefined8 *)plVar3[1];
              *puVar6 = plVar11;
              plVar3[1] = (longlong)puVar5;
              plVar2[1] = (longlong)plVar12;
              plVar11[1] = (longlong)puVar6;
              *(longlong **)(lVar10 + uVar9 * 0x10) = plVar11;
              param_1 = local_50;
              goto LAB_1804349e1;
            }
            plVar3 = (longlong *)plVar3[1];
          } while ((uVar1 != *(uint *)(lVar4 + (lVar7 - (ulonglong)*(uint *)(plVar3 + 2)))) ||
                  ((uVar1 != 0 &&
                   (iVar8 = memcmp(local_40,(void *)((lVar7 - (ulonglong)*(uint *)(plVar3 + 2)) + 4
                                                    + lVar4),(ulonglong)uVar1), lVar7 = local_48,
                   iVar8 != 0))));
          lVar10 = *plVar3;
          plVar12 = (longlong *)plVar11[1];
          *plVar12 = (longlong)plVar2;
          plVar3 = (longlong *)plVar2[1];
          *plVar3 = lVar10;
          puVar5 = *(undefined8 **)(lVar10 + 8);
          *puVar5 = plVar11;
          *(longlong **)(lVar10 + 8) = plVar3;
          plVar2[1] = (longlong)plVar12;
          plVar11[1] = (longlong)puVar5;
          param_1 = local_50;
        }
      }
LAB_1804349e1:
      plVar12 = (longlong *)(param_1 + 0x28);
      plVar11 = plVar2;
    } while (plVar2 != local_58);
  }
  local_58 = (longlong *)0x0;
  FUN_180434a50(&local_58);
  return;
}

