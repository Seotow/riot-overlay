// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804204e0; descriptive alias: FUN_1804204e0
// Evidence: ev_6efff67a4e3966c8d9a2648edc4e15f8bd69bb5186227898d5bd36a980ee6966
// Original Evidence: rea-collector/0x1804204e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804204e0(undefined8 param_1,longlong param_2,undefined8 param_3,longlong param_4,
                  undefined8 param_5,undefined8 param_6,longlong param_7,undefined1 param_8,
                  longlong param_9,longlong param_10,longlong param_11,longlong param_12)

{
  longlong lVar1;
  
  param_4 = param_4 - param_11;
  lVar1 = param_10;
  if ((param_4 != 0) && (lVar1 = param_9, param_12 != 0)) {
    if ((param_12 < param_4) || (param_7 < param_4)) {
      if (param_7 < param_12) {
        lVar1 = param_10;
        if ((param_9 != param_2) && (lVar1 = param_9, param_2 != param_10)) {
          FUN_180972d90(param_9,param_2,param_10);
          lVar1 = param_9 + (param_10 - param_2 >> 2) * 4;
        }
      }
      else {
        lVar1 = param_10 - param_2;
        FUN_1809bf2f0(param_6,param_2,lVar1);
        FUN_1809bf2f0(param_10 - (param_2 - param_9),param_9,param_2 - param_9);
        FUN_1809bf2f0(param_9,param_6,lVar1);
        lVar1 = param_9 + lVar1;
      }
    }
    else {
      FUN_1809bf2f0(param_6,param_9,param_2 - param_9);
      FUN_1809bf2f0(param_9,param_2,param_10 - param_2);
      lVar1 = param_9 + (param_10 - param_2);
      FUN_1809bf2f0(lVar1,param_6,param_2 - param_9);
    }
  }
  FUN_18041ffc0(param_1,param_9,lVar1,param_11,param_12,param_6,param_7,param_8);
  FUN_18041ffc0(lVar1,param_10,param_3,param_4);
  return;
}

