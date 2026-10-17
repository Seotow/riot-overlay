# Provenance and bundled components

- `native` reader core and `host`: new implementation for this task. They do
  not link to or load BlueBottle's Farsight, AWS libraries or lblib.
- `profiles/profile-catalog.json`: derived descriptor/signature facts and
  selected field mappings from the shipped lblib artifact. This is static
  reconstruction evidence, not the original repository or a runtime guarantee.
- `analysis/native` in the source archive: recovered decompiler text and
  analysis evidence. Reproduction of the analysis needs the original target
  DLL from the earlier delivery; that binary is not a reader runtime dependency.
- Windows DLL includes GCC/MinGW runtime components under their upstream
  licenses and runtime exceptions; see `native/third-party` and the Windows
  build manifest. Windows system DLLs are not redistributed.
- The optional Windows host package bundles Microsoft .NET/ASP.NET Core
  runtime from the prior verified official downloads, retaining its license
  and ThirdPartyNotices files.

This private delivery does not publish a repository or change upstream licenses.
