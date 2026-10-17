// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804327b0; descriptive alias: FUN_1804327b0
// Evidence: ev_455b2490a01c16d4a566f06689c8b8ec2ac2628aef94954be4a5cae0876be14f
// Original Evidence: rea-collector/0x1804327b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined * FUN_1804327b0(void)

{
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d6e9d8) {
    FUN_180977040(&DAT_180d6e9d8);
    if (DAT_180d6e9d8 == -1) {
      DAT_180d6e9d5 = 0;
      FUN_180976d40(&DAT_1809dd730);
      _Init_thread_footer(&DAT_180d6e9d8);
      return &DAT_180d6e9d5;
    }
  }
  return &DAT_180d6e9d5;
}

