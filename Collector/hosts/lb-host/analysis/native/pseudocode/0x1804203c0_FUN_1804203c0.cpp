// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804203c0; descriptive alias: FUN_1804203c0
// Evidence: ev_f0c8c8f0bc6c9e163fdc4f1c8bb9e76cea81b07a4ede852f720851ad6ed0153b
// Original Evidence: rea-collector/0x1804203c0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804203c0(float *param_1,longlong param_2,undefined8 *param_3,longlong param_4,
                  longlong param_5)

{
  float *pfVar1;
  float *pfVar2;
  undefined8 uVar3;
  longlong lVar4;
  float *pfVar5;
  undefined8 *puVar6;
  longlong lVar7;
  longlong lVar8;
  float *pfVar9;
  
  if (param_4 < param_5) {
    pfVar9 = param_1;
    do {
      pfVar2 = pfVar9 + param_4 * 5;
      lVar7 = param_5 - param_4;
      lVar4 = param_4;
      if (lVar7 < param_4) {
        lVar4 = lVar7;
      }
      lVar8 = param_4 * 2;
      if (lVar7 < param_4) {
        lVar8 = param_5;
      }
      param_1 = pfVar9 + lVar8 * 5;
      pfVar5 = pfVar2;
      do {
        while (puVar6 = param_3, param_3 = (undefined8 *)((longlong)puVar6 + 0x14),
              *pfVar5 < *pfVar9) {
          uVar3 = *(undefined8 *)(pfVar5 + 2);
          *puVar6 = *(undefined8 *)pfVar5;
          puVar6[1] = uVar3;
          pfVar1 = pfVar5 + 4;
          pfVar5 = pfVar5 + 5;
          *(float *)(puVar6 + 2) = *pfVar1;
          if (pfVar5 == param_1) {
            lVar8 = (longlong)pfVar2 - (longlong)pfVar9;
            pfVar5 = pfVar9;
            goto LAB_180420492;
          }
        }
        uVar3 = *(undefined8 *)(pfVar9 + 2);
        *puVar6 = *(undefined8 *)pfVar9;
        puVar6[1] = uVar3;
        pfVar1 = pfVar9 + 4;
        pfVar9 = pfVar9 + 5;
        *(float *)(puVar6 + 2) = *pfVar1;
      } while (pfVar9 != pfVar2);
      lVar8 = (longlong)param_1 - (longlong)pfVar5;
LAB_180420492:
      FUN_1809bf2f0(param_3,pfVar5,lVar8);
      param_3 = (undefined8 *)((longlong)puVar6 + lVar8 + 0x14);
      param_5 = lVar7 - lVar4;
      pfVar9 = param_1;
    } while (param_4 < lVar7 - lVar4);
  }
  FUN_1809bf2f0(param_3,param_1,param_2 - (longlong)param_1);
  return;
}

