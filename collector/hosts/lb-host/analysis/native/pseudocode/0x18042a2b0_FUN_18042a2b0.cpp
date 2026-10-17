// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042a2b0; descriptive alias: FUN_18042a2b0
// Evidence: ev_a5cc41470ce9f8a9dd2b63f94e24a98dd81ada7564c0fc272b4a5c47af5043f3
// Original Evidence: rea-collector/0x18042a2b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

bool FUN_18042a2b0(longlong param_1,ulonglong param_2,undefined8 *param_3)

{
  float fVar1;
  uint uVar2;
  ulonglong uVar3;
  char cVar4;
  undefined8 *puVar5;
  uint uVar6;
  longlong lVar7;
  bool bVar8;
  undefined1 auStack_58 [32];
  undefined1 local_38 [16];
  undefined8 local_28;
  ulonglong local_20;
  
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_58;
  lVar7 = 0x20;
  puVar5 = param_3;
  do {
    *puVar5 = 0x3f8000003f800000;
    puVar5[1] = 0x3f8000003f800000;
    puVar5[2] = 0x3f8000003f800000;
    puVar5[3] = 0x3f8000003f800000;
    puVar5[4] = 0x3f8000003f800000;
    puVar5[5] = 0x3f8000003f800000;
    puVar5[6] = 0x3f8000003f800000;
    puVar5[7] = 0x3f8000003f800000;
    lVar7 = lVar7 + -1;
    puVar5 = puVar5 + 8;
  } while (lVar7 != 0);
  if (param_2 == 0) {
    return true;
  }
  local_38 = (undefined1  [16])0x0;
  local_28 = 0;
  uVar3 = *(ulonglong *)(param_1 + 0x38);
  if ((((uVar3 != 0) && (param_2 <= ~uVar3)) && (cVar4 = FUN_1801fa260(param_2), cVar4 != '\0')) &&
     (cVar4 = FUN_1801fa260((param_2 - 1) + uVar3), cVar4 != '\0')) {
    FUN_1809bf2f0(local_38,param_2,uVar3);
    uVar2 = *(uint *)(local_38 + ((ulonglong)(DAT_180d6b874 + 0xe6632e3a) ^ 0x11bf48c));
    if (uVar2 < 0x201) {
      if (uVar2 != 0) {
        uVar6 = *(uint *)(*(longlong *)(param_1 + 0x70) + 8);
        if (uVar6 < uVar2) {
          uVar2 = uVar6;
        }
        cVar4 = FUN_1804287f0(*(undefined8 *)
                               (local_38 + ((ulonglong)(DAT_180d6b870 + 0xe6632e3a) ^ 0x11bf48c)),
                              param_3,(ulonglong)uVar2 << 2);
        if (cVar4 == '\0') goto LAB_18042a432;
      }
      uVar6 = 0;
      uVar2 = *(uint *)(*(undefined1 **)(param_1 + 0x70) + 8);
      if (uVar2 == 0) {
        return true;
      }
      while( true ) {
        fVar1 = *(float *)((longlong)param_3 + (ulonglong)uVar6 * 4);
        bVar8 = ((uint)fVar1 & 0x7f800000) != 0x7f800000;
        if ((!bVar8) || (fVar1 < 0.0)) break;
        uVar6 = uVar6 + 1;
        if (uVar2 <= uVar6) {
          return bVar8;
        }
      }
      **(undefined1 **)(param_1 + 0x70) = 3;
      goto LAB_18042a43b;
    }
  }
LAB_18042a432:
  **(undefined1 **)(param_1 + 0x70) = 3;
LAB_18042a43b:
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
  *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
  *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
  return false;
}

