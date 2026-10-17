// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803c3680; descriptive alias: FUN_1803c3680
// Evidence: ev_b65f0b4f2ed1ffdc406edb014c1211b4ab3fc2b597c2ad36267035d1147b5899
// Original Evidence: rea-server-task.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 (*) [16]
FUN_1803c3680(undefined1 (*param_1) [16],undefined8 param_2,undefined8 *param_3,undefined8 *param_4)

{
  int *piVar1;
  undefined8 *puVar2;
  longlong lVar3;
  undefined1 (*pauVar4) [16];
  
  *param_1 = (undefined1  [16])0x0;
  pauVar4 = param_1;
  piVar1 = (int *)FUN_180976d80(0x20);
  *piVar1 = 1;
  piVar1[1] = 2;
  piVar1[2] = 0;
  piVar1[3] = 0;
  piVar1[4] = 0;
  piVar1[5] = 0;
  piVar1[6] = 0;
  *(int **)param_1[1] = piVar1;
  if (piVar1 != (int *)0x0) {
    LOCK();
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  puVar2 = (undefined8 *)FUN_180976d80(0x20);
  *puVar2 = *param_4;
  *param_4 = 0xffffffffffffffff;
  puVar2[1] = *param_3;
  puVar2[2] = piVar1;
  puVar2[3] = FUN_1803c0440;
  lVar3 = FUN_180988944(0,0,FUN_1803c8c80,puVar2,0,*param_1 + 8,0,pauVar4,puVar2);
  *(longlong *)*param_1 = lVar3;
  if (lVar3 != 0) {
    return param_1;
  }
  *(undefined4 *)(*param_1 + 8) = 0;
                    /* WARNING: Subroutine does not return */
  FUN_1809737c0(6);
}

