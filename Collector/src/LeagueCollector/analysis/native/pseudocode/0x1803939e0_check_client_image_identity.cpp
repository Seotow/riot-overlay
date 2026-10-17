// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803939e0; descriptive alias: check_client_image_identity
// Evidence: ev_7ca00c052581c83da67ed4c2c843eeaf1c97bd6b51b72ec9925e617b77f717a0
// Original Evidence: rea-client-image-identity.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

ulonglong FUN_1803939e0(LPCWSTR param_1)

{
  BYTE *pBVar1;
  code *pcVar2;
  bool bVar3;
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined8 uVar8;
  LONG LVar9;
  BOOL BVar10;
  DWORD DVar11;
  int iVar12;
  undefined4 extraout_var;
  ulonglong uVar13;
  HLOCAL pvData;
  PCCERT_CONTEXT pCertContext;
  size_t sVar14;
  longlong lVar15;
  undefined1 *puVar16;
  undefined4 extraout_var_00;
  undefined4 extraout_var_01;
  uint uVar17;
  ulonglong uVar18;
  undefined1 *puVar19;
  undefined1 *puVar20;
  undefined1 *puVar21;
  char *pcVar22;
  char *pcVar23;
  DWORD dwIndex;
  undefined8 extraout_XMM0_Qa;
  undefined8 extraout_XMM0_Qa_00;
  undefined8 extraout_XMM0_Qa_01;
  undefined8 extraout_XMM0_Qa_02;
  undefined8 uVar24;
  undefined8 extraout_XMM0_Qa_03;
  undefined8 extraout_XMM0_Qa_04;
  undefined8 extraout_XMM0_Qa_05;
  undefined8 extraout_XMM0_Qa_06;
  undefined1 auStackY_1243 [1779];
  undefined *puStackY_b50;
  undefined1 auStackY_b48 [8];
  undefined1 auStackY_b40 [24];
  CHAR *local_ae8;
  size_t local_ae0;
  HCRYPTMSG local_ad8 [2];
  DWORD local_ac8 [4];
  undefined8 local_ab8;
  undefined8 uStack_ab0;
  undefined8 uStack_aa8;
  undefined8 uStack_aa0;
  undefined8 local_a98;
  undefined8 *puStack_a90;
  undefined4 uStack_a88;
  undefined4 uStack_a84;
  undefined8 uStack_a80;
  undefined8 uStack_a78;
  undefined8 local_a70;
  undefined8 uStack_a68;
  undefined8 local_a58;
  LPCWSTR local_a50;
  undefined1 local_a48 [16];
  DWORD local_a38 [2];
  undefined1 local_a30 [16];
  undefined8 local_a20;
  ulonglong local_a18;
  uint local_a10 [2];
  GUID local_a08;
  undefined1 local_9f8 [16];
  undefined8 local_9e8;
  ulonglong local_9e0;
  DWORD local_9d8 [2];
  undefined1 local_9d0 [16];
  ulonglong local_9c0;
  ulonglong local_9b8;
  undefined1 local_9b0 [16];
  longlong local_9a0;
  DWORD local_998;
  DWORD local_994;
  DWORD local_990 [2];
  undefined1 local_988 [8];
  undefined8 local_980;
  undefined8 uStack_978;
  undefined8 local_958;
  undefined8 uStack_950;
  char local_8b8 [16];
  char local_8a8 [16];
  char local_898 [34];
  char local_876;
  undefined2 local_875;
  char local_873 [11];
  CHAR local_868 [1024];
  CHAR local_468 [1040];
  ulonglong local_58;
  
  puVar21 = auStackY_b48;
  puVar19 = auStackY_b48;
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStackY_b48;
  dwIndex = 0;
  local_468[0] = '\0';
  puStackY_b50 = (undefined *)0x180393a4e;
  WideCharToMultiByte(0xfde9,0,param_1,-1,local_468,0x410,(LPCSTR)0x0,(LPBOOL)0x0);
  local_ae8 = local_468;
  puStackY_b50 = (undefined *)0x180393a66;
  local_ae0 = strlen(local_468);
  local_a58 = 0x20;
  local_a48 = (undefined1  [16])0x0;
  local_a08.Data1 = 0xaac56b;
  local_a08.Data2 = 0xcd44;
  local_a08.Data3 = 0x11d0;
  local_a08.Data4[0] = 0x8c;
  local_a08.Data4[1] = 0xc2;
  local_a08.Data4[2] = '\0';
  local_a08.Data4[3] = 0xc0;
  local_a08.Data4[4] = 'O';
  local_a08.Data4[5] = 0xc2;
  local_a08.Data4[6] = 0x95;
  local_a08.Data4[7] = 0xee;
  uStack_ab0 = 0;
  uStack_aa8 = 0;
  uStack_a80 = 0;
  uStack_a78 = 0;
  uStack_a68 = 0;
  local_ab8 = 0x58;
  uStack_aa0 = 2;
  local_a98 = 1;
  uStack_a88 = 1;
  uStack_a84 = 0;
  local_a70 = 0x1010;
  puStack_a90 = &local_a58;
  puStackY_b50 = (undefined *)0x180393ae9;
  local_a50 = param_1;
  local_a38[0] = WinVerifyTrust((HWND)0x0,&local_a08,&local_ab8);
  if (local_a38[0] == 0) {
    _uStack_a88 = CONCAT44(uStack_a84,2);
    puStackY_b50 = (undefined *)0x180393b31;
    WinVerifyTrust((HWND)0x0,&local_a08,&local_ab8);
    local_ad8[1] = (HCERTSTORE)0x0;
    local_ad8[0] = (HCRYPTMSG)0x0;
    puStackY_b50 = (undefined *)0x180393b97;
    BVar10 = CryptQueryObject(1,param_1,0x400,2,0,local_990,&local_994,&local_998,local_ad8 + 1,
                              local_ad8,(void **)0x0);
    if (BVar10 == 0) {
      puStackY_b50 = (undefined *)0x180393ba1;
      local_a38[0] = GetLastError();
      puStackY_b50 = (undefined *)0x180393bb2;
      uVar13 = FUN_180396510(extraout_XMM0_Qa_00,local_a38,&local_ae8);
    }
    else {
      local_a10[0] = 0;
      local_9d8[0] = 4;
      puStackY_b50 = (undefined *)0x180393be2;
      BVar10 = CryptMsgGetParam(local_ad8[0],5,0,local_a10,local_9d8);
      if (BVar10 == 0) {
        puStackY_b50 = (undefined *)0x180393bec;
        local_a38[0] = GetLastError();
        puStackY_b50 = (undefined *)0x180393bfd;
        FUN_180396930(extraout_XMM0_Qa_02,local_a38,&local_ae8);
      }
      else {
        uVar24 = extraout_XMM0_Qa_01;
        if (local_a10[0] != 0) {
          do {
            local_ac8[0] = 0;
            puStackY_b50 = (undefined *)0x180393c33;
            BVar10 = CryptMsgGetParam(local_ad8[0],6,dwIndex,(void *)0x0,local_ac8);
            if (BVar10 == 0) {
              puStackY_b50 = (undefined *)0x18039471f;
              local_a38[0] = GetLastError();
              puStackY_b50 = (undefined *)0x180394730;
              FUN_180396d50(extraout_XMM0_Qa_06,local_a38,&local_ae8);
              puStackY_b50 = (undefined *)0x180394738;
              LocalFree((HLOCAL)0x0);
              goto LAB_18039464f;
            }
            puStackY_b50 = (undefined *)0x180393c49;
            pvData = LocalAlloc(0x40,(ulonglong)local_ac8[0]);
            puStackY_b50 = (undefined *)0x180393c6b;
            BVar10 = CryptMsgGetParam(local_ad8[0],6,dwIndex,pvData,local_ac8);
            if (BVar10 == 0) {
              puStackY_b50 = (undefined *)0x1803946fa;
              local_a38[0] = GetLastError();
              puStackY_b50 = (undefined *)0x18039470b;
              FUN_180397170(extraout_XMM0_Qa_05,local_a38,&local_ae8);
              puStackY_b50 = (undefined *)0x180394714;
              LocalFree(pvData);
              goto LAB_18039464f;
            }
            puStackY_b50 = (undefined *)0x180393c87;
            FUN_1809bef30(local_988,0,0xd0);
            local_958 = *(undefined8 *)((longlong)pvData + 8);
            uStack_950 = *(undefined8 *)((longlong)pvData + 0x10);
            local_980 = *(undefined8 *)((longlong)pvData + 0x18);
            uStack_978 = *(undefined8 *)((longlong)pvData + 0x20);
            puStackY_b50 = (undefined *)0x180393ccf;
            pCertContext = CertFindCertificateInStore
                                     (local_ad8[1],0x10001,0,0xb0000,local_988,(PCCERT_CONTEXT)0x0);
            if (pCertContext == (PCCERT_CONTEXT)0x0) {
              puStackY_b50 = (undefined *)0x1803946d5;
              local_a38[0] = GetLastError();
              puStackY_b50 = (undefined *)0x1803946e6;
              FUN_180397590(extraout_XMM0_Qa_04,local_a38,&local_ae8);
              puStackY_b50 = (undefined *)0x1803946ef;
              LocalFree(pvData);
              goto LAB_18039464f;
            }
            bVar3 = false;
            puStackY_b50 = (undefined *)0x180393cf2;
            FUN_1809bef30(local_868,0,0x100);
            puStackY_b50 = (undefined *)0x180393d1e;
            DVar11 = CertGetNameStringA(pCertContext,3,0,"2.5.4.3",local_868,0x100);
            puStackY_b50 = (undefined *)0x180393d30;
            FUN_1801c7930(&DAT_180d0f8a0,local_9d0);
            uVar13 = local_9b8;
            uVar24 = local_9d0._0_8_;
            if (1 < DVar11) {
              puStackY_b50 = (undefined *)0x180393d4c;
              sVar14 = strlen(local_868);
              puVar16 = local_9d0;
              if (0xf < uVar13) {
                puVar16 = (undefined1 *)uVar24;
              }
              if (local_9c0 == sVar14) {
                if (local_9c0 != 0) {
                  puStackY_b50 = (undefined *)0x180393d75;
                  iVar12 = memcmp(puVar16,local_868,local_9c0);
                  if (iVar12 != 0) goto LAB_180393d7c;
                }
                bVar3 = true;
              }
            }
LAB_180393d7c:
            if (0xf < uVar13) {
              uVar18 = uVar13 + 1;
              puVar16 = (undefined1 *)uVar24;
              if (uVar18 < 0x1000) {
LAB_180393dab:
                puStackY_b50 = (undefined *)0x180393db3;
                thunk_FUN_180895720(puVar16,uVar18);
                goto LAB_180393db3;
              }
              puVar16 = *(undefined1 **)(uVar24 + -8);
              puVar20 = auStackY_b48;
              if ((undefined1 *)(uVar24 + (-8 - (longlong)puVar16)) < (undefined1 *)0x20) {
                uVar18 = uVar13 + 0x28;
                goto LAB_180393dab;
              }
LAB_18039469a:
              pcVar2 = (code *)swi(0x29);
              (*pcVar2)(5);
              puVar21 = puVar20 + 8;
LAB_1803946a1:
              *(undefined8 *)(puVar21 + -8) = 0x1803946aa;
              CertFreeCertificateContext(pCertContext);
              *(undefined8 *)(puVar21 + -8) = 0x1803946b3;
              LocalFree(pvData);
              *(undefined8 *)(puVar21 + -8) = 0x1803946c0;
              CertCloseStore(*(HCERTSTORE *)(puVar21 + 0x78),0);
              *(undefined8 *)(puVar21 + -8) = 0x1803946cb;
              BVar10 = CryptMsgClose(*(HCRYPTMSG *)(puVar21 + 0x70));
              uVar13 = CONCAT71((int7)(CONCAT44(extraout_var_01,BVar10) >> 8),1);
              goto LAB_180394669;
            }
LAB_180393db3:
            if (bVar3) goto LAB_1803946a1;
            puStackY_b50 = (undefined *)0x180393dc1;
            FUN_1803979b0();
            uVar13 = 0;
            local_9e8 = 0;
            local_9e0 = 0xf;
            local_9f8._1_15_ = SUB1615((undefined1  [16])0x0,1);
            auVar4[0xf] = 0;
            auVar4._0_15_ = local_9f8._1_15_;
            local_9f8 = auVar4 << 8;
            local_a20 = 0;
            local_a18 = 0xf;
            local_a30._1_15_ = SUB1615((undefined1  [16])0x0,1);
            auVar5[0xf] = 0;
            auVar5._0_15_ = local_a30._1_15_;
            local_a30 = auVar5 << 8;
            puStackY_b50 = (undefined *)0x180393e08;
            FUN_180191b40(local_9f8,"SerialNumber: ",0xe);
            uVar17 = (pCertContext->pCertInfo->SerialNumber).cbData;
            pBVar1 = (pCertContext->pCertInfo->SerialNumber).pbData;
            local_a20 = 0;
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            *puVar16 = 0;
            puStackY_b50 = (undefined *)0x180393e3e;
            FUN_1801a1f50(local_a30,"blob(",5);
            puStackY_b50 = (undefined *)0x180393e59;
            FUN_1801aca30(local_8b8,0x10,&DAT_180c687a4,uVar17);
            puStackY_b50 = (undefined *)0x180393e65;
            sVar14 = strlen(local_8b8);
            puStackY_b50 = (undefined *)0x180393e78;
            FUN_1801a1f50(local_a30,local_8b8,sVar14);
            puStackY_b50 = (undefined *)0x180393e8e;
            FUN_1801a1f50(local_a30,&DAT_180c687a0,3);
            uVar18 = uVar13;
            if (uVar17 != 0) {
              do {
                puStackY_b50 = (undefined *)0x180393ec4;
                FUN_1801aca30(local_8b8,0x10,&DAT_180c68798,pBVar1[(uVar17 - uVar18) + -1]);
                puStackY_b50 = (undefined *)0x180393ed0;
                sVar14 = strlen(local_8b8);
                puStackY_b50 = (undefined *)0x180393ee3;
                FUN_1801a1f50(local_a30,local_8b8,sVar14);
                uVar18 = uVar18 + 1;
              } while (uVar18 < uVar17);
            }
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            puStackY_b50 = (undefined *)0x180393f06;
            FUN_1801a1f50(local_9f8,puVar16,local_a20);
            puStackY_b50 = (undefined *)0x180393f1c;
            FUN_1801a1f50(local_9f8," Algorithm: ",0xc);
            pcVar23 = (pCertContext->pCertInfo->SignatureAlgorithm).pszObjId;
            puStackY_b50 = (undefined *)0x180393f2c;
            sVar14 = strlen(pcVar23);
            puStackY_b50 = (undefined *)0x180393f3b;
            FUN_1801a1f50(local_9f8,pcVar23,sVar14);
            local_868[0] = '\0';
            puStackY_b50 = (undefined *)0x180393f6a;
            CertNameToStrA(1,&pCertContext->pCertInfo->Issuer,3,local_868,0x400);
            puStackY_b50 = (undefined *)0x180393f80;
            FUN_1801a1f50(local_9f8," Issuer: ",9);
            puStackY_b50 = (undefined *)0x180393f8c;
            sVar14 = strlen(local_868);
            puStackY_b50 = (undefined *)0x180393f9f;
            FUN_1801a1f50(local_9f8,local_868,sVar14);
            puStackY_b50 = (undefined *)0x180393fb5;
            FUN_1801a1f50(local_9f8," NotBefore: ",0xc);
            puStackY_b50 = (undefined *)0x180393fdd;
            FUN_1801aca30(local_868,0x400,"%lX%lX",
                          (pCertContext->pCertInfo->NotBefore).dwHighDateTime);
            puStackY_b50 = (undefined *)0x180393fe9;
            sVar14 = strlen(local_868);
            puStackY_b50 = (undefined *)0x180393ffc;
            FUN_1801a1f50(local_9f8,local_868,sVar14);
            puStackY_b50 = (undefined *)0x180394012;
            FUN_1801a1f50(local_9f8," NotAfter: ",0xb);
            puStackY_b50 = (undefined *)0x18039403a;
            FUN_1801aca30(local_868,0x400,"%lX%lX",
                          (pCertContext->pCertInfo->NotAfter).dwHighDateTime);
            puStackY_b50 = (undefined *)0x180394046;
            sVar14 = strlen(local_868);
            puStackY_b50 = (undefined *)0x180394059;
            FUN_1801a1f50(local_9f8,local_868,sVar14);
            local_868[0] = '\0';
            puStackY_b50 = (undefined *)0x180394088;
            CertNameToStrA(1,&pCertContext->pCertInfo->Subject,3,local_868,0x400);
            puStackY_b50 = (undefined *)0x18039409e;
            FUN_1801a1f50(local_9f8," Subject: ",10);
            puStackY_b50 = (undefined *)0x1803940aa;
            sVar14 = strlen(local_868);
            puStackY_b50 = (undefined *)0x1803940bd;
            FUN_1801a1f50(local_9f8,local_868,sVar14);
            puStackY_b50 = (undefined *)0x1803940d3;
            FUN_1801a1f50(local_9f8," SubjPubKey: ",0xd);
            pcVar23 = (pCertContext->pCertInfo->SubjectPublicKeyInfo).Algorithm.pszObjId;
            puStackY_b50 = (undefined *)0x1803940e3;
            sVar14 = strlen(pcVar23);
            puStackY_b50 = (undefined *)0x1803940f2;
            FUN_1801a1f50(local_9f8,pcVar23,sVar14);
            puStackY_b50 = (undefined *)0x1803940fd;
            FUN_1801a0510(local_9f8,0x20);
            uVar17 = (pCertContext->pCertInfo->SubjectPublicKeyInfo).PublicKey.cbData;
            pBVar1 = (pCertContext->pCertInfo->SubjectPublicKeyInfo).PublicKey.pbData;
            local_a20 = 0;
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            *puVar16 = 0;
            puStackY_b50 = (undefined *)0x180394136;
            FUN_1801a1f50(local_a30,"blob(",5);
            puStackY_b50 = (undefined *)0x180394151;
            FUN_1801aca30(local_8a8,0x10,&DAT_180c687a4,uVar17);
            puStackY_b50 = (undefined *)0x18039415d;
            sVar14 = strlen(local_8a8);
            puStackY_b50 = (undefined *)0x180394170;
            FUN_1801a1f50(local_a30,local_8a8,sVar14);
            puStackY_b50 = (undefined *)0x180394186;
            FUN_1801a1f50(local_a30,&DAT_180c687a0,3);
            if (uVar17 != 0) {
              do {
                puStackY_b50 = (undefined *)0x1803941ad;
                FUN_1801aca30(local_8a8,0x10,&DAT_180c68798,pBVar1[uVar13]);
                puStackY_b50 = (undefined *)0x1803941b9;
                sVar14 = strlen(local_8a8);
                puStackY_b50 = (undefined *)0x1803941cc;
                FUN_1801a1f50(local_a30,local_8a8,sVar14);
                uVar13 = uVar13 + 1;
              } while (uVar13 < uVar17);
            }
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            puStackY_b50 = (undefined *)0x1803941ef;
            FUN_1801a1f50(local_9f8,puVar16,local_a20);
            puStackY_b50 = (undefined *)0x180394205;
            FUN_1801a1f50(local_9f8," Unused: ",9);
            uVar17 = (pCertContext->pCertInfo->SubjectPublicKeyInfo).PublicKey.cUnusedBits;
            if (uVar17 < 10) {
              local_875._1_1_ = (char)uVar17 + '0';
              pcVar23 = (char *)((longlong)&local_875 + 1);
            }
            else {
              uVar13 = (ulonglong)uVar17;
              pcVar23 = local_873;
              do {
                pcVar22 = pcVar23;
                uVar18 = uVar13 / 100;
                uVar17 = (uint)uVar18;
                pcVar23 = pcVar22 + -2;
                *(undefined2 *)pcVar23 = (&DAT_180c0f400)[(int)uVar13 + uVar17 * -100];
                uVar13 = uVar18;
              } while (9 < uVar17);
              if (uVar17 != 0) {
                pcVar23 = pcVar22 + -3;
                *pcVar23 = (char)uVar18 + '0';
              }
            }
            local_9d0 = (undefined1  [16])0x0;
            local_9c0 = 0;
            local_9b8 = 0;
            if (pcVar23 == local_873) {
              local_9c0 = 0;
              local_9b8 = 0xf;
              local_9d0._1_15_ = SUB1615((undefined1  [16])0x0,1);
              auVar6[0xf] = 0;
              auVar6._0_15_ = local_9d0._1_15_;
              local_9d0 = auVar6 << 8;
              uVar13 = 0;
              uVar18 = 0xf;
            }
            else {
              uVar13 = (longlong)local_873 - (longlong)pcVar23;
              if (0x7fffffffffffffff < uVar13) {
                    /* WARNING: Subroutine does not return */
                puStackY_b50 = &UNK_180394742;
                FUN_1801a21a0();
              }
              if (uVar13 < 0x10) {
                local_9b8 = 0xf;
                puStackY_b50 = (undefined *)0x1803942fa;
                local_9c0 = uVar13;
                FUN_1809bf2f0(local_9d0,pcVar23,uVar13);
                local_9d0[uVar13] = 0;
                uVar13 = local_9c0;
                uVar18 = local_9b8;
              }
              else {
                uVar18 = uVar13 | 0xf;
                if (uVar18 < 0x8000000000000000) {
                  if (uVar18 < 0x16) {
                    uVar18 = 0x16;
                  }
                }
                else {
                  uVar18 = 0x7fffffffffffffff;
                }
                puStackY_b50 = (undefined *)0x180394336;
                lVar15 = FUN_1801a22d0(uVar18 + 1);
                local_9d0._0_8_ = lVar15;
                puStackY_b50 = (undefined *)0x180394359;
                local_9c0 = uVar13;
                local_9b8 = uVar18;
                FUN_1809bf2f0(lVar15,pcVar23,uVar13);
                *(undefined1 *)(lVar15 + uVar13) = 0;
              }
            }
            puVar16 = local_9d0;
            if (0xf < uVar18) {
              puVar16 = (undefined1 *)local_9d0._0_8_;
            }
            puStackY_b50 = (undefined *)0x180394376;
            FUN_1801a1f50(local_9f8,puVar16,uVar13);
            if (0xf < local_9b8) {
              uVar13 = local_9b8 + 1;
              lVar15 = local_9d0._0_8_;
              if (uVar13 < 0x1000) {
LAB_1803943b0:
                puStackY_b50 = (undefined *)0x1803943b5;
                thunk_FUN_180895720(lVar15,uVar13);
                goto LAB_1803943b5;
              }
              lVar15 = *(longlong *)(local_9d0._0_8_ + -8);
              if ((local_9d0._0_8_ - lVar15) - 8U < 0x20) {
                uVar13 = local_9b8 + 0x28;
                goto LAB_1803943b0;
              }
LAB_18039468c:
              pcVar2 = (code *)swi(0x29);
              (*pcVar2)(5);
              puVar19 = auStackY_b40;
LAB_180394693:
              pcVar2 = (code *)swi(0x29);
              (*pcVar2)(5);
              puVar20 = puVar19 + 8;
              goto LAB_18039469a;
            }
LAB_1803943b5:
            uVar13 = 0;
            local_a38[0] = 0;
            puStackY_b50 = (undefined *)0x1803943e3;
            CryptHashCertificate
                      (0,0,0,pCertContext->pbCertEncoded,pCertContext->cbCertEncoded,(BYTE *)0x0,
                       local_a38);
            local_9b0 = (undefined1  [16])0x0;
            local_9a0 = 0;
            puStackY_b50 = (undefined *)0x180394405;
            FUN_1801a8ca0(local_9b0,local_a38[0]);
            puStackY_b50 = (undefined *)0x180394433;
            CryptHashCertificate
                      (0,0,0,pCertContext->pbCertEncoded,pCertContext->cbCertEncoded,
                       (BYTE *)local_9b0._0_8_,local_a38);
            uVar8 = local_9b0._8_8_;
            uVar24 = local_9b0._0_8_;
            uVar18 = local_9b0._8_8_ - local_9b0._0_8_;
            local_a20 = 0;
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            *puVar16 = 0;
            puStackY_b50 = (undefined *)0x18039446f;
            FUN_1801a1f50(local_a30,"blob(",5);
            puStackY_b50 = (undefined *)0x18039448a;
            FUN_1801aca30(local_898,0x10,&DAT_180c687a4);
            puStackY_b50 = (undefined *)0x180394496;
            sVar14 = strlen(local_898);
            puStackY_b50 = (undefined *)0x1803944a9;
            FUN_1801a1f50(local_a30,local_898,sVar14);
            puStackY_b50 = (undefined *)0x1803944bf;
            FUN_1801a1f50(local_a30,&DAT_180c687a0,3);
            if (uVar8 != uVar24) {
              do {
                puStackY_b50 = (undefined *)0x1803944ed;
                FUN_1801aca30(local_898,0x10,&DAT_180c68798);
                puStackY_b50 = (undefined *)0x1803944f9;
                sVar14 = strlen(local_898);
                puStackY_b50 = (undefined *)0x18039450c;
                FUN_1801a1f50(local_a30,local_898,sVar14);
                uVar13 = uVar13 + 1;
              } while (uVar13 < uVar18);
            }
            puStackY_b50 = (undefined *)0x18039452a;
            FUN_1801a1f50(local_9f8," Hash: ",7);
            puVar16 = local_a30;
            if (0xf < local_a18) {
              puVar16 = (undefined1 *)local_a30._0_8_;
            }
            puStackY_b50 = (undefined *)0x180394545;
            uVar24 = FUN_1801a1f50(local_9f8,puVar16,local_a20);
            puStackY_b50 = (undefined *)0x18039454e;
            FUN_180397d10(uVar24,local_9f8);
            puStackY_b50 = (undefined *)0x180394557;
            CertFreeCertificateContext(pCertContext);
            puStackY_b50 = (undefined *)0x180394560;
            LocalFree(pvData);
            uVar24 = extraout_XMM0_Qa_03;
            if (local_9b0._0_8_ != 0) {
              uVar13 = local_9a0 - local_9b0._0_8_;
              lVar15 = local_9b0._0_8_;
              if (0xfff < uVar13) {
                if (0x1f < (local_9b0._0_8_ - *(longlong *)(local_9b0._0_8_ + -8)) - 8U)
                goto LAB_18039468c;
                uVar13 = uVar13 + 0x27;
                lVar15 = *(longlong *)(local_9b0._0_8_ + -8);
              }
              puStackY_b50 = (undefined *)0x1803945a3;
              thunk_FUN_180895720(lVar15,uVar13);
              uVar24 = 0;
              local_9b0 = (undefined1  [16])0x0;
              local_9a0 = 0;
            }
            if (0xf < local_a18) {
              uVar13 = local_a18 + 1;
              lVar15 = local_a30._0_8_;
              if (0xfff < uVar13) {
                lVar15 = *(longlong *)(local_a30._0_8_ + -8);
                if (0x1f < (local_a30._0_8_ - lVar15) - 8U) goto LAB_180394693;
                uVar13 = local_a18 + 0x28;
              }
              puStackY_b50 = (undefined *)0x1803945f1;
              uVar24 = thunk_FUN_180895720(lVar15,uVar13);
            }
            local_a20 = 0;
            local_a18 = 0xf;
            auVar7[0xf] = 0;
            auVar7._0_15_ = local_a30._1_15_;
            local_a30 = auVar7 << 8;
            if (0xf < local_9e0) {
              uVar13 = local_9e0 + 1;
              lVar15 = local_9f8._0_8_;
              if (0xfff < uVar13) {
                lVar15 = *(longlong *)(local_9f8._0_8_ + -8);
                puVar20 = auStackY_b48;
                if (0x1f < (local_9f8._0_8_ - lVar15) - 8U) goto LAB_18039469a;
                uVar13 = local_9e0 + 0x28;
              }
              puStackY_b50 = (undefined *)0x180394638;
              uVar24 = thunk_FUN_180895720(lVar15,uVar13);
            }
            dwIndex = dwIndex + 1;
          } while (dwIndex < local_a10[0]);
        }
        puStackY_b50 = (undefined *)0x18039464f;
        FUN_180398100(uVar24,&local_ae8);
      }
LAB_18039464f:
      puStackY_b50 = (undefined *)0x18039465c;
      CertCloseStore(local_ad8[1],0);
      puStackY_b50 = (undefined *)0x180394667;
      BVar10 = CryptMsgClose(local_ad8[0]);
      uVar13 = CONCAT44(extraout_var_00,BVar10);
    }
  }
  else {
    puStackY_b50 = (undefined *)0x180393afe;
    FUN_1803960f0(extraout_XMM0_Qa,local_a38,&local_ae8);
    _uStack_a88 = CONCAT44(uStack_a84,2);
    puStackY_b50 = (undefined *)0x180393b15;
    LVar9 = WinVerifyTrust((HWND)0x0,&local_a08,&local_ab8);
    uVar13 = CONCAT44(extraout_var,LVar9);
  }
  uVar13 = uVar13 & 0xffffffffffffff00;
  puVar21 = auStackY_b48;
LAB_180394669:
  *(undefined8 *)(puVar21 + -8) = 0x180394678;
  return uVar13;
}

