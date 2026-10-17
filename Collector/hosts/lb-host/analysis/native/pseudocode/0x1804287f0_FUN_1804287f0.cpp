// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804287f0; descriptive alias: FUN_1804287f0
// Evidence: ev_5902b4e2f605e198b2897b31902698934182fd3a055fe81b0685d7caecbeb597
// Original Evidence: rea-collector/0x1804287f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_1804287f0(ulonglong param_1,longlong param_2,ulonglong param_3)

{
  char cVar1;
  
  if (((param_2 != 0) && (param_3 != 0)) && (param_1 <= ~param_3)) {
    cVar1 = FUN_1801fa260();
    if (cVar1 != '\0') {
      cVar1 = FUN_1801fa260((param_3 - 1) + param_1);
      if (cVar1 != '\0') {
        FUN_1809bf2f0(param_2,param_1,param_3);
        return 1;
      }
    }
  }
  return 0;
}

