// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804266d0; descriptive alias: FUN_1804266d0
// Evidence: ev_4d8bdbf3803d5033c990e07ab247ae0c653c019560fc8c5777eaaccb85186a9a
// Original Evidence: rea-collector/0x1804266d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 * FUN_1804266d0(longlong param_1,undefined8 *param_2)

{
  undefined8 *puVar1;
  char cVar2;
  uint uVar3;
  longlong *plVar4;
  ulonglong uVar5;
  undefined8 extraout_XMM0_Qa;
  undefined8 extraout_XMM0_Qa_00;
  undefined8 uVar6;
  undefined1 auStack_68 [32];
  undefined8 *local_48 [2];
  undefined1 local_38 [16];
  undefined8 local_28;
  ulonglong local_20;
  
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_68;
  uVar5 = 0;
  local_48[0] = param_2;
  if (DAT_180d3e830 == '\0') {
    uVar3 = DAT_180d3e3c8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar3 = FUN_18052b510(&DAT_180d3e3c8);
  }
  if (uVar3 != 0) {
    if (DAT_180d3e830 == '\0') {
      uVar3 = DAT_180d3e3c8 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d3e3c8);
    }
    puVar1 = *(undefined8 **)((ulonglong)uVar3 + param_1);
    local_48[0] = puVar1;
    cVar2 = FUN_1801fa260(puVar1);
    if (cVar2 == '\0') {
      FUN_180427e80(extraout_XMM0_Qa,local_48);
    }
    else {
      plVar4 = (longlong *)
               (((ulonglong)(DAT_180d3e838 + 0xe6632e3a) ^ 0x11bf48c) + (longlong)puVar1);
      uVar6 = extraout_XMM0_Qa;
      if ((*(uint *)(plVar4 + 1) < 0x10001) &&
         ((*(uint *)(plVar4 + 1) == 0 ||
          (cVar2 = FUN_1801fa260(*plVar4), uVar6 = extraout_XMM0_Qa_00, cVar2 != '\0')))) {
        local_38 = (undefined1  [16])0x0;
        local_28 = 0;
        FUN_1801d9870(local_38,(int)plVar4[1]);
        if ((int)plVar4[1] != 0) {
          do {
            FUN_180181510(local_38,uVar5 * 0x10 + *plVar4);
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint *)(plVar4 + 1));
        }
        *param_2 = local_38._0_8_;
        param_2[1] = local_38._8_8_;
        param_2[2] = local_28;
        return param_2;
      }
      local_48[0] = (undefined8 *)*plVar4;
      FUN_180428230(uVar6,local_48);
    }
  }
  param_2[2] = 0;
  param_2[1] = 0;
  *param_2 = 0;
  return param_2;
}

