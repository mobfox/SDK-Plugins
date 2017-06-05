.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 8,1
	.asciz "Mono AOT Compiler 4.8.0 (tarball Tue Mar 28 13:52:20 EDT 2017)"
	.asciz "Plugin.MobFoxAds.Abstractions.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,8,5
	.asciz "intptr"
LDIE_U:

	.byte 4,8,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,8,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,8,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,8,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,120,30
	.align 3
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor
Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor:
.file 1 "<unknown>"
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType
Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string
Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000801
.word 0x91004000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc
Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string
Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000c01
.word 0x91006000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor
Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_16:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType
Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_17:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string
Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000801
.word 0x91004000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc
Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string
Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000c01
.word 0x91006000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1a:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_20:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000801
.word 0x91004000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_21:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_22:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9000c01
.word 0x91006000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_23:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_24:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9001001
.word 0x91008000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_25:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9001401
.word 0x9100a000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9001801
.word 0x9100c000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_29:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9001c01
.word 0x9100e000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2b:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2c:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string
Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf9400ba0
.word 0xf9002001
.word 0x91010000
bl _p_1
.word 0xf9400fa0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2d:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor
Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_32:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400800
.word 0xb4000120
.word 0xf9400ba1
.word 0xf9400823
.word 0xaa0303e0
.word 0xf9400fa2
.word 0xf90013a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_33:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400b38
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91004336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_2
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #120]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #128]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_34:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400b38
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91004336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_4
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #120]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #128]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_35:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400c00
.word 0xb4000120
.word 0xf9400ba1
.word 0xf9400c23
.word 0xaa0303e0
.word 0xf9400fa2
.word 0xf90013a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_36:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400f38
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91006336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_2
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #136]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #144]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_37:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400f38
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91006336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_4
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #136]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #144]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_38:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9401000
.word 0xb4000120
.word 0xf9400ba1
.word 0xf9401023
.word 0xaa0303e0
.word 0xf9400fa2
.word 0xf90013a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_39:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9401338
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91008336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_2
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #152]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_3a:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9401338
.word 0xaa1803f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000580
.word 0x91008336
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_4
.word 0xaa0003f5
.word 0xb4000175
.word 0xf94002a0
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x1, [x16, #152]
.word 0xeb01001f
.word 0x10000011
.word 0x54000321

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xc85f7ed0
.word 0xeb18021f
.word 0x54000061
.word 0xc811fed5
.word 0x35ffff91
.word 0xd50330bf
.word 0xaa1003e0
.word 0xf90023a0
.word 0xaa1603e0
bl _p_1
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xeb17001f
.word 0x54fffb61
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd28028a0
.word 0xaa1103e1
bl _p_3
.word 0xd2802e60
.word 0xaa1103e1
bl _p_3

Lme_3b:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xb9400000
.word 0x35000680
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001e
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_5
bl _p_6
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffcb
.word 0xd2802800
.word 0xaa1103e1
bl _p_3

Lme_3d:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xd2800519
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_7
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_3e:
.text
	.align 4
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xd2800219
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0xf9001bb8
.word 0x9100a3a0
.word 0xf9000300
.word 0xf94013a0
.word 0xaa1803e1
bl _p_8
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_3f:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xb9400000
.word 0x35000680
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001e
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_5
bl _p_6
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffcb
.word 0xd2802800
.word 0xaa1103e1
bl _p_3

Lme_40:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xd2800519
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_7
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_41:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xb9400000
.word 0x35000680
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001e
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_5
bl _p_6
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffcb
.word 0xd2802800
.word 0xaa1103e1
bl _p_3

Lme_42:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xd2800519
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_7
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_43:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor
bl Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType
bl Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string
bl Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc
bl Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor
bl Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType
bl Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string
bl Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc
bl Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl
bl Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
bl Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
bl method_addresses
bl wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object
bl wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
bl wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object
bl wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 13,12,31,0,68,14,32,157,4,158,3,68,13,29,13,12,31,0,68,14,48,157,6,158,5,68,13,29,28,12,31,0
	.byte 68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3,18,12,31,0,68,14,80
	.byte 157,10,158,9,68,13,29,68,152,8,153,7,18,12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5

.text
	.align 4
plt:
mono_aot_Plugin_MobFoxAds_Abstractions_plt:
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_conc_intptr
plt_wrapper_write_barrier_object_wbarrier_conc_intptr:
_p_1:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #184]
br x16
.word 512
	.no_dead_strip plt_System_Delegate_Combine_System_Delegate_System_Delegate
plt_System_Delegate_Combine_System_Delegate_System_Delegate:
_p_2:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #192]
br x16
.word 519
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_3:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #200]
br x16
.word 524
	.no_dead_strip plt_System_Delegate_Remove_System_Delegate_System_Delegate
plt_System_Delegate_Remove_System_Delegate_System_Delegate:
_p_4:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #208]
br x16
.word 559
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_5:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #216]
br x16
.word 564
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_6:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #224]
br x16
.word 592
	.no_dead_strip plt__jit_icall_mono_delegate_begin_invoke
plt__jit_icall_mono_delegate_begin_invoke:
_p_7:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #232]
br x16
.word 630
	.no_dead_strip plt__jit_icall_mono_delegate_end_invoke
plt__jit_icall_mono_delegate_end_invoke:
_p_8:
adrp x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_Abstractions_got@PAGEOFF
ldr x16, [x16, #240]
br x16
.word 659
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_Plugin_MobFoxAds_Abstractions_got, 248
got_end:
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 3
	.quad Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "660EC603-1155-4603-B762-85751468E22B"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "Plugin.MobFoxAds.Abstractions"
.data
	.align 3
_mono_aot_file_info:

	.long 137,0
	.align 3
	.quad mono_aot_Plugin_MobFoxAds_Abstractions_got
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad jit_code_start
	.align 3
	.quad jit_code_end
	.align 3
	.quad method_addresses
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad mem_end
	.align 3
	.quad assembly_guid
	.align 3
	.quad runtime_version
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad globals
	.align 3
	.quad assembly_name
	.align 3
	.quad plt
	.align 3
	.quad plt_end
	.align 3
	.quad unwind_info
	.align 3
	.quad unbox_trampolines
	.align 3
	.quad unbox_trampolines_end
	.align 3
	.quad unbox_trampoline_addresses

	.long 22,248,9,68,66,923871743,0,1083
	.long 128,8,8,10,0,15,1920,824
	.long 632,344,0,480,600,432,0,280
	.long 112,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 139,234,109,197,133,19,175,80,108,99,121,117,112,216,243,214
	.globl _mono_aot_module_Plugin_MobFoxAds_Abstractions_info
	.align 3
_mono_aot_module_Plugin_MobFoxAds_Abstractions_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_1:

	.byte 5
	.asciz "System_EventArgs"

	.byte 16,16
LDIFF_SYM6=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "System_EventArgs"

LDIFF_SYM7=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_0:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 32,16
LDIFF_SYM10=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM11=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM12=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM12
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

LDIFF_SYM13=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM14=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM15=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs:.ctor"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor
	.quad Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM16=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM17=Lfde0_end - Lfde0_start
	.long LDIFF_SYM17
Lfde0_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor

LDIFF_SYM18=Lme_d - Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor
	.long LDIFF_SYM18
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs:get_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType
	.quad Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM19=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM19
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM20=Lfde1_end - Lfde1_start
	.long LDIFF_SYM20
Lfde1_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType

LDIFF_SYM21=Lme_e - Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_EventType
	.long LDIFF_SYM21
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs:set_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM22=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM23=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM24=Lfde2_end - Lfde2_start
	.long LDIFF_SYM24
Lfde2_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string

LDIFF_SYM25=Lme_f - Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_EventType_string
	.long LDIFF_SYM25
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs:get_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc
	.quad Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM26=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM26
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM27=Lfde3_end - Lfde3_start
	.long LDIFF_SYM27
Lfde3_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc

LDIFF_SYM28=Lme_10 - Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_get_ErrorDesc
	.long LDIFF_SYM28
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs:set_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string
	.quad Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM29=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM30=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM31=Lfde4_end - Lfde4_start
	.long LDIFF_SYM31
Lfde4_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string

LDIFF_SYM32=Lme_11 - Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_set_ErrorDesc_string
	.long LDIFF_SYM32
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_3:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 32,16
LDIFF_SYM33=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM33
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM34=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM34
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM35=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

LDIFF_SYM36=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM36
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM37=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM37
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM38=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs:.ctor"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor
	.quad Lme_16

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM39=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM40=Lfde5_end - Lfde5_start
	.long LDIFF_SYM40
Lfde5_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor

LDIFF_SYM41=Lme_16 - Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor
	.long LDIFF_SYM41
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs:get_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType
	.quad Lme_17

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM42=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM43=Lfde6_end - Lfde6_start
	.long LDIFF_SYM43
Lfde6_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType

LDIFF_SYM44=Lme_17 - Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_EventType
	.long LDIFF_SYM44
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs:set_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string
	.quad Lme_18

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM45=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM46=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM47=Lfde7_end - Lfde7_start
	.long LDIFF_SYM47
Lfde7_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string

LDIFF_SYM48=Lme_18 - Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_EventType_string
	.long LDIFF_SYM48
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs:get_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc
	.quad Lme_19

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM49=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM50=Lfde8_end - Lfde8_start
	.long LDIFF_SYM50
Lfde8_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc

LDIFF_SYM51=Lme_19 - Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_get_ErrorDesc
	.long LDIFF_SYM51
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs:set_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string
	.quad Lme_1a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM52=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM53=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde9_end - Lfde9_start
	.long LDIFF_SYM54
Lfde9_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string

LDIFF_SYM55=Lme_1a - Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_set_ErrorDesc_string
	.long LDIFF_SYM55
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_4:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 72,16
LDIFF_SYM56=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM57=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM58=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,24,6
	.asciz "<TitleText>k__BackingField"

LDIFF_SYM59=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,35,32,6
	.asciz "<BodyText>k__BackingField"

LDIFF_SYM60=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,40,6
	.asciz "<IconUrl>k__BackingField"

LDIFF_SYM61=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,48,6
	.asciz "<MainImageUrl>k__BackingField"

LDIFF_SYM62=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,35,56,6
	.asciz "<ClickUrl>k__BackingField"

LDIFF_SYM63=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2,35,64,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

LDIFF_SYM64=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM64
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM65=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM65
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM66=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM66
	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:.ctor"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor
	.quad Lme_1f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM67=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM68=Lfde10_end - Lfde10_start
	.long LDIFF_SYM68
Lfde10_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor

LDIFF_SYM69=Lme_1f - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor
	.long LDIFF_SYM69
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType
	.quad Lme_20

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM70=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM71=Lfde11_end - Lfde11_start
	.long LDIFF_SYM71
Lfde11_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType

LDIFF_SYM72=Lme_20 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_EventType
	.long LDIFF_SYM72
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_EventType"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string
	.quad Lme_21

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM73=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM74=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM75=Lfde12_end - Lfde12_start
	.long LDIFF_SYM75
Lfde12_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string

LDIFF_SYM76=Lme_21 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_EventType_string
	.long LDIFF_SYM76
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc
	.quad Lme_22

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM77=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM78=Lfde13_end - Lfde13_start
	.long LDIFF_SYM78
Lfde13_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc

LDIFF_SYM79=Lme_22 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ErrorDesc
	.long LDIFF_SYM79
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_ErrorDesc"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string
	.quad Lme_23

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM80=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM81=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM82=Lfde14_end - Lfde14_start
	.long LDIFF_SYM82
Lfde14_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string

LDIFF_SYM83=Lme_23 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ErrorDesc_string
	.long LDIFF_SYM83
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_TitleText"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText
	.quad Lme_24

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM84=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM85=Lfde15_end - Lfde15_start
	.long LDIFF_SYM85
Lfde15_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText

LDIFF_SYM86=Lme_24 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_TitleText
	.long LDIFF_SYM86
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_TitleText"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string
	.quad Lme_25

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM87=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM88=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM89=Lfde16_end - Lfde16_start
	.long LDIFF_SYM89
Lfde16_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string

LDIFF_SYM90=Lme_25 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_TitleText_string
	.long LDIFF_SYM90
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde16_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_BodyText"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText
	.quad Lme_26

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM91=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM92=Lfde17_end - Lfde17_start
	.long LDIFF_SYM92
Lfde17_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText

LDIFF_SYM93=Lme_26 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_BodyText
	.long LDIFF_SYM93
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde17_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_BodyText"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string
	.quad Lme_27

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM94=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM95=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM96=Lfde18_end - Lfde18_start
	.long LDIFF_SYM96
Lfde18_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string

LDIFF_SYM97=Lme_27 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_BodyText_string
	.long LDIFF_SYM97
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde18_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_IconUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl
	.quad Lme_28

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM98=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM99=Lfde19_end - Lfde19_start
	.long LDIFF_SYM99
Lfde19_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl

LDIFF_SYM100=Lme_28 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_IconUrl
	.long LDIFF_SYM100
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_IconUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string
	.quad Lme_29

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM101=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM101
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM102=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM103=Lfde20_end - Lfde20_start
	.long LDIFF_SYM103
Lfde20_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string

LDIFF_SYM104=Lme_29 - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_IconUrl_string
	.long LDIFF_SYM104
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde20_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_MainImageUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl
	.quad Lme_2a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM105=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM105
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM106=Lfde21_end - Lfde21_start
	.long LDIFF_SYM106
Lfde21_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl

LDIFF_SYM107=Lme_2a - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_MainImageUrl
	.long LDIFF_SYM107
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_MainImageUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string
	.quad Lme_2b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM108=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM109=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM109
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM110=Lfde22_end - Lfde22_start
	.long LDIFF_SYM110
Lfde22_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string

LDIFF_SYM111=Lme_2b - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_MainImageUrl_string
	.long LDIFF_SYM111
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:get_ClickUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl
	.quad Lme_2c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM112=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM113=Lfde23_end - Lfde23_start
	.long LDIFF_SYM113
Lfde23_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl

LDIFF_SYM114=Lme_2c - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_get_ClickUrl
	.long LDIFF_SYM114
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde23_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs:set_ClickUrl"
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string
	.quad Lme_2d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM115=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM115
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM116=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM117=Lfde24_end - Lfde24_start
	.long LDIFF_SYM117
Lfde24_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string

LDIFF_SYM118=Lme_2d - Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_set_ClickUrl_string
	.long LDIFF_SYM118
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde24_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 16,16
LDIFF_SYM119=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM120=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM120
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM121=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM121
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM122=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM122
LTDIE_10:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 16,16
LDIFF_SYM123=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM124=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM124
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM125=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM125
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM126=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM126
LTDIE_9:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 16,16
LDIFF_SYM127=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM127
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM128=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM128
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM129=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM129
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM130=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM130
LTDIE_13:

	.byte 5
	.asciz "System_Type"

	.byte 24,16
LDIFF_SYM131=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM131
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM132=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2,35,16,0,7
	.asciz "System_Type"

LDIFF_SYM133=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM133
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM134=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM134
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM135=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM135
LTDIE_15:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM136=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM137=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM137
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM138=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM138
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM139=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM139
LTDIE_14:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM140=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM141=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM142=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM142
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM143=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM143
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM144=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM144
LTDIE_12:

	.byte 5
	.asciz "System_DelegateData"

	.byte 40,16
LDIFF_SYM145=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM145
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM146=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM146
	.byte 2,35,16,6
	.asciz "method_name"

LDIFF_SYM147=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM147
	.byte 2,35,24,6
	.asciz "curried_first_arg"

LDIFF_SYM148=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM148
	.byte 2,35,32,0,7
	.asciz "System_DelegateData"

LDIFF_SYM149=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM149
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM150=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM150
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM151=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM151
LTDIE_8:

	.byte 5
	.asciz "System_Delegate"

	.byte 104,16
LDIFF_SYM152=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM153=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,16,6
	.asciz "invoke_impl"

LDIFF_SYM154=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,24,6
	.asciz "m_target"

LDIFF_SYM155=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM155
	.byte 2,35,32,6
	.asciz "method"

LDIFF_SYM156=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2,35,40,6
	.asciz "delegate_trampoline"

LDIFF_SYM157=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 2,35,48,6
	.asciz "extra_arg"

LDIFF_SYM158=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,35,56,6
	.asciz "method_code"

LDIFF_SYM159=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,35,64,6
	.asciz "method_info"

LDIFF_SYM160=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 2,35,72,6
	.asciz "original_method_info"

LDIFF_SYM161=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,35,80,6
	.asciz "data"

LDIFF_SYM162=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,35,88,6
	.asciz "method_is_virtual"

LDIFF_SYM163=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 2,35,96,0,7
	.asciz "System_Delegate"

LDIFF_SYM164=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM164
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM165=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM165
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM166=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM166
LTDIE_7:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 112,16
LDIFF_SYM167=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM168=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 2,35,104,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM169=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM169
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM170=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM170
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM171=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM171
LTDIE_6:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 112,16
LDIFF_SYM172=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

LDIFF_SYM173=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM173
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM174=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM174
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM175=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM175
LTDIE_16:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 112,16
LDIFF_SYM176=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM176
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

LDIFF_SYM177=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM177
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM178=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM178
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM179=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM179
LTDIE_17:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 112,16
LDIFF_SYM180=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM180
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

LDIFF_SYM181=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM181
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM182=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM182
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM183=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM183
LTDIE_5:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox"

	.byte 40,16
LDIFF_SYM184=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,35,0,6
	.asciz "MobFoxBannerCallbackHandler"

LDIFF_SYM185=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM185
	.byte 2,35,16,6
	.asciz "MobFoxInterstitialCallbackHandler"

LDIFF_SYM186=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 2,35,24,6
	.asciz "MobFoxNativeCallbackHandler"

LDIFF_SYM187=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 2,35,32,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox"

LDIFF_SYM188=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM188
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM189=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM189
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM190=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:.ctor"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor
	.quad Lme_32

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM191=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM192=Lfde25_end - Lfde25_start
	.long LDIFF_SYM192
Lfde25_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor

LDIFF_SYM193=Lme_32 - Plugin_MobFoxAds_Abstractions_BaseMobFox__ctor
	.long LDIFF_SYM193
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde25_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:OnMobFoxBannerCallback"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.quad Lme_33

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM194=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,141,16,3
	.asciz "e"

LDIFF_SYM195=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM196=Lfde26_end - Lfde26_start
	.long LDIFF_SYM196
Lfde26_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs

LDIFF_SYM197=Lme_33 - Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxBannerCallback_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.long LDIFF_SYM197
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde26_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:add_MobFoxBannerCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.quad Lme_34

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM198=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM199=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM200=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM200
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM201=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM201
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM202=Lfde27_end - Lfde27_start
	.long LDIFF_SYM202
Lfde27_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler

LDIFF_SYM203=Lme_34 - Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.long LDIFF_SYM203
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:remove_MobFoxBannerCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.quad Lme_35

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM204=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM205=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM205
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM206=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM206
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM207=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM208=Lfde28_end - Lfde28_start
	.long LDIFF_SYM208
Lfde28_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler

LDIFF_SYM209=Lme_35 - Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.long LDIFF_SYM209
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:OnMobFoxInterstitialCallback"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.quad Lme_36

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM210=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM210
	.byte 2,141,16,3
	.asciz "e"

LDIFF_SYM211=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM212=Lfde29_end - Lfde29_start
	.long LDIFF_SYM212
Lfde29_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs

LDIFF_SYM213=Lme_36 - Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxInterstitialCallback_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.long LDIFF_SYM213
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:add_MobFoxInterstitialCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.quad Lme_37

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM214=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM214
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM215=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM215
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM216=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM217=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM217
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM218=Lfde30_end - Lfde30_start
	.long LDIFF_SYM218
Lfde30_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler

LDIFF_SYM219=Lme_37 - Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.long LDIFF_SYM219
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde30_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:remove_MobFoxInterstitialCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.quad Lme_38

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM220=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM221=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM222=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM223=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM224=Lfde31_end - Lfde31_start
	.long LDIFF_SYM224
Lfde31_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler

LDIFF_SYM225=Lme_38 - Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.long LDIFF_SYM225
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde31_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:OnMobFoxNativeCallback"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.quad Lme_39

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM226=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM226
	.byte 2,141,16,3
	.asciz "e"

LDIFF_SYM227=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM228=Lfde32_end - Lfde32_start
	.long LDIFF_SYM228
Lfde32_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs

LDIFF_SYM229=Lme_39 - Plugin_MobFoxAds_Abstractions_BaseMobFox_OnMobFoxNativeCallback_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.long LDIFF_SYM229
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde32_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:add_MobFoxNativeCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.quad Lme_3a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM230=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM231=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM232=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM233=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM234=Lfde33_end - Lfde33_start
	.long LDIFF_SYM234
Lfde33_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler

LDIFF_SYM235=Lme_3a - Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.long LDIFF_SYM235
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde33_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.Abstractions.BaseMobFox:remove_MobFoxNativeCallbackHandler"
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.quad Lme_3b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM236=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM237=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM238=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM239=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM239
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM240=Lfde34_end - Lfde34_start
	.long LDIFF_SYM240
Lfde34_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler

LDIFF_SYM241=Lme_3b - Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.long LDIFF_SYM241
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde34_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_18:

	.byte 17
	.asciz "_<Module>"

	.byte 16,7
	.asciz "_<Module>"

LDIFF_SYM242=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM242
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM243=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM243
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM244=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_19:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM245=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM245
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM246=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM246
	.byte 2,35,16,0,7
	.asciz "System_Int32"

LDIFF_SYM247=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM247
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM248=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM249=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM249
LTDIE_20:

	.byte 5
	.asciz "System_Array"

	.byte 16,16
LDIFF_SYM250=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM250
	.byte 2,35,0,0,7
	.asciz "System_Array"

LDIFF_SYM251=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM251
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM252=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM252
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM253=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_object_MobFoxBannerCallbackEventArgs"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.quad Lme_3d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM254=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM255=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM256=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM257=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM258=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM258
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM259=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM259
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM260=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM260
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM261=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM262=Lfde35_end - Lfde35_start
	.long LDIFF_SYM262
Lfde35_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs

LDIFF_SYM263=Lme_3d - wrapper_delegate_invoke__Module_invoke_void_object_MobFoxBannerCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.long LDIFF_SYM263
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde35_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_21:

	.byte 5
	.asciz "System_AsyncCallback"

	.byte 112,16
LDIFF_SYM264=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,35,0,0,7
	.asciz "System_AsyncCallback"

LDIFF_SYM265=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM265
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM266=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM266
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM267=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object
	.quad Lme_3e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM268=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM268
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM269=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM269
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM270=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM271=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM272=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 3,141,192,0,11
	.asciz "V_0"

LDIFF_SYM273=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM273
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM274=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM275=Lfde36_end - Lfde36_start
	.long LDIFF_SYM275
Lfde36_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object

LDIFF_SYM276=Lme_3e - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxBannerCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_System_AsyncCallback_object
	.long LDIFF_SYM276
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde36_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_22:

	.byte 17
	.asciz "System_IAsyncResult"

	.byte 16,7
	.asciz "System_IAsyncResult"

LDIFF_SYM277=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM277
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM278=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM278
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM279=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_void__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.quad wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.quad Lme_3f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM280=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM281=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM281
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM282=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM282
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM283=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,141,48,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM284=Lfde37_end - Lfde37_start
	.long LDIFF_SYM284
Lfde37_start:

	.long 0
	.align 3
	.quad wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM285=Lme_3f - wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM285
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5
	.align 3
Lfde37_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_object_MobFoxInterstitialCallbackEventArgs"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.quad Lme_40

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM286=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM287=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM288=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM289=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM289
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM290=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM290
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM291=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM292=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM293=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM294=Lfde38_end - Lfde38_start
	.long LDIFF_SYM294
Lfde38_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs

LDIFF_SYM295=Lme_40 - wrapper_delegate_invoke__Module_invoke_void_object_MobFoxInterstitialCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.long LDIFF_SYM295
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde38_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object
	.quad Lme_41

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM296=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM296
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM297=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM298=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM298
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM299=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM300=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 3,141,192,0,11
	.asciz "V_0"

LDIFF_SYM301=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM301
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM302=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM302
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM303=Lfde39_end - Lfde39_start
	.long LDIFF_SYM303
Lfde39_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object

LDIFF_SYM304=Lme_41 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxInterstitialCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_System_AsyncCallback_object
	.long LDIFF_SYM304
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde39_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_object_MobFoxNativeCallbackEventArgs"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.quad Lme_42

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM305=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM306=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM307=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM308=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM309=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM309
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM310=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM311=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM312=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM313=Lfde40_end - Lfde40_start
	.long LDIFF_SYM313
Lfde40_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs

LDIFF_SYM314=Lme_42 - wrapper_delegate_invoke__Module_invoke_void_object_MobFoxNativeCallbackEventArgs_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.long LDIFF_SYM314
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde40_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object
	.quad Lme_43

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM315=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM315
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM316=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM317=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM318=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM319=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM319
	.byte 3,141,192,0,11
	.asciz "V_0"

LDIFF_SYM320=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM321=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM322=Lfde41_end - Lfde41_start
	.long LDIFF_SYM322
Lfde41_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object

LDIFF_SYM323=Lme_43 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___object_MobFoxNativeCallbackEventArgs_AsyncCallback_object_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_System_AsyncCallback_object
	.long LDIFF_SYM323
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde41_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
