// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803bd780; descriptive alias: initialize_client_session
// Evidence: ev_ce3e3adeee157c9d35f2c12e48adde94d645d14aa6ae71fbab398c5b275861f7
// Original Evidence: rea-client-session-init-current.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1803bd780(undefined8 *param_1,undefined8 param_2,byte param_3,char param_4)

{
  undefined4 *puVar1;
  longlong *plVar2;
  longlong lVar3;
  undefined8 *local_28;
  undefined8 *local_20;
  
  *param_1 = &PTR_FUN_180c6f008;
  param_1[1] = 0;
  param_1[2] = 0;
  param_1[3] = 0;
  param_1[4] = 0;
  *(undefined4 *)(param_1 + 5) = 0;
  local_20 = param_1;
  puVar1 = (undefined4 *)FUN_180976d80();
  *puVar1 = 1;
  puVar1[1] = 2;
  *(undefined8 *)(puVar1 + 2) = 0;
  *(undefined8 *)(puVar1 + 4) = 0;
  puVar1[6] = 0;
  param_1[6] = puVar1;
  *(uint *)(param_1 + 7) = (uint)param_3;
  if (param_4 == '\0') {
    lVar3 = 0x7fffffffffffffff;
  }
  else {
    plVar2 = (longlong *)FUN_1801fe670(&local_28);
    lVar3 = *plVar2 + 30000000000;
  }
  param_1[8] = lVar3;
  CoCreateGuid((GUID *)(param_1 + 9));
  param_1[0xb] = 0;
  param_1[0xc] = 0;
  param_1[0xd] = 0;
  param_1[0xe] = param_2;
  local_28 = param_1 + 0xf;
  FUN_1803bfda0(local_28);
  param_1[0x1d] = 0;
  param_1[0x1e] = 0;
  param_1[0x1f] = 0;
  param_1[0x20] = 0;
  param_1[0x1f] = 0;
  param_1[0x20] = 0;
  param_1[0x21] = 0;
  param_1[0x22] = 0;
  param_1[0x1b] = 0;
  param_1[0x1c] = 0;
  *(undefined4 *)(param_1 + 0x23) = 0xffffffff;
  *(undefined4 *)(param_1 + 0x1a) = 2;
  *(undefined4 *)((longlong)param_1 + 0x11c) = 0;
  param_1[0x24] = 0;
  param_1[0x25] = 0;
  lVar3 = FUN_180976d80(0x28);
  *(longlong *)lVar3 = lVar3;
  *(longlong *)(lVar3 + 8) = lVar3;
  param_1[0x24] = lVar3;
  param_1[0x26] = 0;
  *(undefined2 *)((longlong)param_1 + 0x144) = 0;
  *(undefined1 *)((longlong)param_1 + 0x146) = 0;
  return param_1;
}

