// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804346f0; descriptive alias: FUN_1804346f0
// Evidence: ev_7ee061a028e52c7f4320b6ccfd6f3a26ab9fd414cb9525732f51c38451743465
// Original Evidence: rea-collector/0x1804346f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong * FUN_1804346f0(longlong param_1,longlong *param_2,uint *param_3,ulonglong param_4)

{
  uint uVar1;
  longlong *plVar2;
  longlong lVar3;
  longlong lVar4;
  int iVar5;
  longlong lVar6;
  longlong *plVar7;
  longlong lVar8;
  
  param_4 = *(ulonglong *)(param_1 + 0x40) & param_4;
  plVar7 = *(longlong **)(*(longlong *)(param_1 + 0x28) + 8 + param_4 * 0x10);
  if (plVar7 == *(longlong **)(param_1 + 0x18)) {
    *param_2 = (longlong)*(longlong **)(param_1 + 0x18);
    param_2[1] = 0;
    return param_2;
  }
  plVar2 = *(longlong **)(*(longlong *)(param_1 + 0x28) + param_4 * 0x10);
  lVar3 = *(longlong *)(*(longlong *)(param_1 + 8) + 0x28);
  lVar4 = *(longlong *)(*(longlong *)(param_1 + 8) + 0x38);
  lVar8 = lVar4 - (ulonglong)*param_3;
  uVar1 = *(uint *)(lVar8 + lVar3);
  while ((lVar6 = lVar4 - (ulonglong)*(uint *)(plVar7 + 2), uVar1 != *(uint *)(lVar6 + lVar3) ||
         ((uVar1 != 0 &&
          (iVar5 = memcmp((void *)(lVar3 + 4 + lVar8),(void *)(lVar3 + 4 + lVar6),(ulonglong)uVar1),
          iVar5 != 0))))) {
    if (plVar7 == plVar2) {
      *param_2 = (longlong)plVar7;
      param_2[1] = 0;
      return param_2;
    }
    plVar7 = (longlong *)plVar7[1];
  }
  *param_2 = *plVar7;
  param_2[1] = (longlong)plVar7;
  return param_2;
}

