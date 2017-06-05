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
	.asciz "Plugin.MobFoxAds.dll"
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
	.no_dead_strip Plugin_MobFoxAds_CrossMobFoxAds__ctor
Plugin_MobFoxAds_CrossMobFoxAds__ctor:
.file 1 "<unknown>"
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_CrossMobFoxAds_get_Current
Plugin_MobFoxAds_CrossMobFoxAds_get_Current:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #120]
.word 0xf9400001
.word 0xaa0103e0
.word 0xf940003e
bl _p_1
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xb40000c0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
bl _p_2
bl _p_3

Lme_1:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds
Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #128]
bl _p_4
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_2:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly
Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #136]
.word 0xf9000fa0

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #144]
bl _p_4
.word 0xf9400fa1
.word 0xf9000ba0
bl _p_5
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_CrossMobFoxAds__cctor
Plugin_MobFoxAds_CrossMobFoxAds__cctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9400000
.word 0xb5000340

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #160]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xf9001420

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #176]
.word 0xf9002020

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #184]
.word 0xf9401402
.word 0xf9000c22
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9000001

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9400000
.word 0xf9000fa0

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #192]
bl _p_4
.word 0xf9400fa1
.word 0xf9000ba0
.word 0xd2800022
bl _p_6
.word 0xf9400ba1

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #120]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation__ctor
Plugin_MobFoxAds_MobFoxAdsImplementation__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string
Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xf90017a1
.word 0xf9401720
.word 0xb4000120
.word 0xf9401723
.word 0xd2800000
.word 0x93407c01
.word 0xaa0303e0
.word 0xd2800002
.word 0xf940007e
bl _p_7
.word 0xf900173f

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #200]
bl _p_8
.word 0xf90023a0
bl _p_9
.word 0xf94023a0
.word 0xaa0003f8
.word 0xaa1803e2

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xaa0203e0
.word 0xf940005e
bl _p_10
.word 0xaa1803e0
.word 0xf94017a1
.word 0xf940031e
bl _p_11
.word 0xf9001738
.word 0x9100a320
bl _p_12
.word 0xf9401722

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x1, [x16, #216]
.word 0xaa0203e0
.word 0xf940005e
bl _p_13
.word 0xf9401721
.word 0xaa0103e0
.word 0xf940003e
bl _p_14
bl _p_15
.word 0xaa0003fa
.word 0xd2817700
bl _p_16
.word 0xf9001fa0
.word 0xeb1f033f
.word 0x10000011
.word 0x54000480

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #224]
bl _p_4
.word 0xf9001019
.word 0xf9001ba0
.word 0x91008000
bl _p_12
.word 0xf9401ba1
.word 0xf9401fa3

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #232]
.word 0xf9001420

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #240]
.word 0xf9002020

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #248]
.word 0xf9401402
.word 0xf9000c22
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f
.word 0xaa0303e0
.word 0xaa1a03e2
.word 0xf940007e
bl _p_17
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2800b00
.word 0xaa1103e1
bl _p_18

Lme_6:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string
Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_19
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string
Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xaa0003f8
.word 0xf90013a1
.word 0xf90017a2

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xf9400000
.word 0xb5000280

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x1, [x16, #264]
.word 0xaa1803e0
bl _p_20
.word 0xf9001fa0

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #272]
bl _p_4
.word 0xf9401fa2
.word 0xf9001ba0
.word 0xaa1803e1
bl _p_21
.word 0xf9401ba1

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xf9000001

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xf9400018
.word 0xaa1803e0
.word 0xb4000300

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #280]
bl _p_4
.word 0xaa0003f7
.word 0xf940001e
.word 0xf94013a1
.word 0xf9000801
.word 0xf9001ba0
.word 0x91004000
bl _p_12
.word 0xf9401ba0
.word 0xf94013a1
.word 0xf94002fe
.word 0xf94017a1
.word 0xf9000c01
.word 0x910062e0
bl _p_12
.word 0xf94017a0
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400f10
.word 0xd63f0200
.word 0xa94163b7
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_8:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int
Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_9:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner
Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner
Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string
Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xaa0003f8
.word 0xf90013a1
.word 0xf90017a2

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #288]
.word 0xf9400000
.word 0xb5000280

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x1, [x16, #296]
.word 0xaa1803e0
bl _p_20
.word 0xf9001fa0

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #304]
bl _p_4
.word 0xf9401fa2
.word 0xf9001ba0
.word 0xaa1803e1
bl _p_22
.word 0xf9401ba1

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #288]
.word 0xf9000001

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #288]
.word 0xf9400018
.word 0xaa1803e0
.word 0xb4000300

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #312]
bl _p_4
.word 0xaa0003f7
.word 0xf940001e
.word 0xf94013a1
.word 0xf9000801
.word 0xf9001ba0
.word 0x91004000
bl _p_12
.word 0xf9401ba0
.word 0xf94013a1
.word 0xf94002fe
.word 0xf94017a1
.word 0xf9000c01
.word 0x910062e0
bl _p_12
.word 0xf94017a0
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400f10
.word 0xd63f0200
.word 0xa94163b7
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_c:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string
Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial
Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string
Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string:
.loc 1 1 0
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000bb3
.word 0xaa0003f3
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0xf90023a6
.word 0xf90027a7

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9400000
.word 0xb5000280

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xaa1303e0
bl _p_20
.word 0xf90037a0

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #336]
bl _p_4
.word 0xf94037a2
.word 0xf90033a0
.word 0xaa1303e1
bl _p_23
.word 0xf94033a1

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9000001

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9400013
.word 0xaa1303e0
.word 0xb4000740

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #344]
bl _p_4
.word 0xf9002ba0
.word 0xf940001e
.word 0xf9400fa1
.word 0xf9000801
.word 0x91004000
bl _p_12
.word 0xf9400fa0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf94013a1
.word 0xf9000c01
.word 0x91006000
bl _p_12
.word 0xf94013a0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf94017a1
.word 0xf9001001
.word 0x91008000
bl _p_12
.word 0xf94017a0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf9401ba1
.word 0xf9001401
.word 0x9100a000
bl _p_12
.word 0xf9401ba0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf9401fa1
.word 0xf9001801
.word 0x9100c000
bl _p_12
.word 0xf9401fa0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf94023a1
.word 0xf9001c01
.word 0x9100e000
bl _p_12
.word 0xf94023a0
.word 0xf9402ba0
.word 0xf940001e
.word 0xf94027a1
.word 0xf9002001
.word 0x91010000
bl _p_12
.word 0xf94027a0
.word 0xaa1303e0
.word 0xf9402ba1
.word 0xf9400e70
.word 0xd63f0200
.word 0xf9400bb3
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string
Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation__cctor
Plugin_MobFoxAds_MobFoxAdsImplementation__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task
Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9401400
.word 0xb4000160
.word 0xf9400ba0
.word 0xf9401403
.word 0xd2800000
.word 0x93407c01
.word 0xaa0303e0
.word 0xd2800002
.word 0xf940007e
bl _p_7
.word 0xf9400ba0
.word 0xf900141f
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_12:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_24
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_25
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_14:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_26
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_15:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_27
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_16:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_28
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_17:
.text
	.align 4
	.no_dead_strip Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_29
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult
wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xb9400000
.word 0x350005e0
.word 0x14000001
.word 0xf9403759
.word 0xaa1903e0
.word 0xb50001a0
.word 0xf9401359
.word 0xaa1903e0
.word 0xb40000c0
.word 0xf9401f40
.word 0xf9400b41
.word 0xaa1903e0
.word 0xd63f0020
.word 0x1400001c
.word 0xf9401f40
.word 0xf9400b40
.word 0xd63f0000
.word 0x14000018
.word 0xb9801b3a
.word 0xd2800018
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400017
.word 0xaa1703e1
.word 0xaa0103e0
.word 0xf9001ba1
.word 0xf9400c30
.word 0xd63f0200
.word 0xf9401ba1
.word 0xaa0003f7
.word 0x11000718
.word 0xaa1803e0
.word 0x6b1a001f
.word 0x54fffdab
.word 0xaa1703e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_3
bl _p_30
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17ffffd0
.word 0xd2802800
.word 0xaa1103e1
bl _p_18

Lme_1a:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task
wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf9403738
.word 0xaa1803e0
.word 0xb50001e0
.word 0xf9401338
.word 0xaa1803e0
.word 0xb40000e0
.word 0xf9401f20
.word 0xf9400b22
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001c
.word 0xf9401f20
.word 0xf9400b21
.word 0xaa1a03e0
.word 0xd63f0020
.word 0x14000017
.word 0xb9801b19
.word 0xd2800017
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.word 0xaa1603e2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf90023a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006f7
.word 0xaa1703e0
.word 0x6b19001f
.word 0x54fffdab
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_3
bl _p_30
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2802800
.word 0xaa1103e1
bl _p_18

Lme_1b:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf9403738
.word 0xaa1803e0
.word 0xb50001e0
.word 0xf9401338
.word 0xaa1803e0
.word 0xb40000e0
.word 0xf9401f20
.word 0xf9400b22
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001c
.word 0xf9401f20
.word 0xf9400b21
.word 0xaa1a03e0
.word 0xd63f0020
.word 0x14000017
.word 0xb9801b19
.word 0xd2800017
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.word 0xaa1603e2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf90023a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006f7
.word 0xaa1703e0
.word 0x6b19001f
.word 0x54fffdab
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_3
bl _p_30
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2802800
.word 0xaa1103e1
bl _p_18

Lme_1c:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf9403738
.word 0xaa1803e0
.word 0xb50001e0
.word 0xf9401338
.word 0xaa1803e0
.word 0xb40000e0
.word 0xf9401f20
.word 0xf9400b22
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001c
.word 0xf9401f20
.word 0xf9400b21
.word 0xaa1a03e0
.word 0xd63f0020
.word 0x14000017
.word 0xb9801b19
.word 0xd2800017
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.word 0xaa1603e2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf90023a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006f7
.word 0xaa1703e0
.word 0x6b19001f
.word 0x54fffdab
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_3
bl _p_30
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2802800
.word 0xaa1103e1
bl _p_18

Lme_1d:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf9403738
.word 0xaa1803e0
.word 0xb50001e0
.word 0xf9401338
.word 0xaa1803e0
.word 0xb40000e0
.word 0xf9401f20
.word 0xf9400b22
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001c
.word 0xf9401f20
.word 0xf9400b21
.word 0xaa1a03e0
.word 0xd63f0020
.word 0x14000017
.word 0xb9801b19
.word 0xd2800017
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.word 0xaa1603e2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf90023a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006f7
.word 0xaa1703e0
.word 0x6b19001f
.word 0x54fffdab
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_3
bl _p_30
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2802800
.word 0xaa1103e1
bl _p_18

Lme_1e:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl Plugin_MobFoxAds_CrossMobFoxAds__ctor
bl Plugin_MobFoxAds_CrossMobFoxAds_get_Current
bl Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds
bl Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly
bl Plugin_MobFoxAds_CrossMobFoxAds__cctor
bl Plugin_MobFoxAds_MobFoxAdsImplementation__ctor
bl Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int
bl Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner
bl Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner
bl Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial
bl Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string
bl Plugin_MobFoxAds_MobFoxAdsImplementation__cctor
bl Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
bl Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
bl method_addresses
bl wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult
bl wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task
bl wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
bl wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
bl wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
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

	.byte 13,12,31,0,68,14,32,157,4,158,3,68,13,29,16,12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2,13
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29,21,12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.byte 68,154,6,18,12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5,13,12,31,0,68,14,64,157,8,158
	.byte 7,68,13,29,16,12,31,0,68,14,112,157,14,158,13,68,13,29,68,147,12,23,12,31,0,68,14,64,157,8,158,7
	.byte 68,13,29,68,151,6,152,5,68,153,4,154,3,26,12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7
	.byte 68,152,6,153,5,68,154,4

.text
	.align 4
plt:
mono_aot_Plugin_MobFoxAds_plt:
	.no_dead_strip plt_System_Lazy_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_get_Value
plt_System_Lazy_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_get_Value:
_p_1:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #368]
br x16
.word 585
	.no_dead_strip plt_Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly
plt_Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly:
_p_2:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #376]
br x16
.word 596
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_3:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #384]
br x16
.word 598
	.no_dead_strip plt__jit_icall_ves_icall_object_new_fast
plt__jit_icall_ves_icall_object_new_fast:
_p_4:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #392]
br x16
.word 626
	.no_dead_strip plt_System_NotImplementedException__ctor_string
plt_System_NotImplementedException__ctor_string:
_p_5:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #400]
br x16
.word 654
	.no_dead_strip plt_System_Lazy_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds__ctor_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_System_Threading_LazyThreadSafetyMode
plt_System_Lazy_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds__ctor_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_System_Threading_LazyThreadSafetyMode:
_p_6:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #408]
br x16
.word 659
	.no_dead_strip plt_UIKit_UIAlertView_DismissWithClickedButtonIndex_System_nint_bool
plt_UIKit_UIAlertView_DismissWithClickedButtonIndex_System_nint_bool:
_p_7:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #416]
br x16
.word 670
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_8:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #424]
br x16
.word 675
	.no_dead_strip plt_UIKit_UIAlertView__ctor
plt_UIKit_UIAlertView__ctor:
_p_9:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #432]
br x16
.word 707
	.no_dead_strip plt_UIKit_UIAlertView_set_Title_string
plt_UIKit_UIAlertView_set_Title_string:
_p_10:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #440]
br x16
.word 712
	.no_dead_strip plt_UIKit_UIAlertView_set_Message_string
plt_UIKit_UIAlertView_set_Message_string:
_p_11:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #448]
br x16
.word 717
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_conc_intptr
plt_wrapper_write_barrier_object_wbarrier_conc_intptr:
_p_12:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #456]
br x16
.word 722
	.no_dead_strip plt_UIKit_UIAlertView_AddButton_string
plt_UIKit_UIAlertView_AddButton_string:
_p_13:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #464]
br x16
.word 729
	.no_dead_strip plt_UIKit_UIAlertView_Show
plt_UIKit_UIAlertView_Show:
_p_14:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #472]
br x16
.word 734
	.no_dead_strip plt_System_Threading_Tasks_TaskScheduler_FromCurrentSynchronizationContext
plt_System_Threading_Tasks_TaskScheduler_FromCurrentSynchronizationContext:
_p_15:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #480]
br x16
.word 739
	.no_dead_strip plt_System_Threading_Tasks_Task_Delay_int
plt_System_Threading_Tasks_Task_Delay_int:
_p_16:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #488]
br x16
.word 744
	.no_dead_strip plt_System_Threading_Tasks_Task_ContinueWith_System_Action_1_System_Threading_Tasks_Task_System_Threading_Tasks_TaskScheduler
plt_System_Threading_Tasks_Task_ContinueWith_System_Action_1_System_Threading_Tasks_Task_System_Threading_Tasks_TaskScheduler:
_p_17:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #496]
br x16
.word 749
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_18:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #504]
br x16
.word 754
	.no_dead_strip plt_Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string
plt_Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string:
_p_19:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #512]
br x16
.word 789
	.no_dead_strip plt__jit_icall_mono_ldvirtfn
plt__jit_icall_mono_ldvirtfn:
_p_20:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #520]
br x16
.word 791
	.no_dead_strip plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor_object_intptr
plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs__ctor_object_intptr:
_p_21:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #528]
br x16
.word 807
	.no_dead_strip plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor_object_intptr
plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs__ctor_object_intptr:
_p_22:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #536]
br x16
.word 818
	.no_dead_strip plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor_object_intptr
plt_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs__ctor_object_intptr:
_p_23:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #544]
br x16
.word 829
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
_p_24:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #552]
br x16
.word 840
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler:
_p_25:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #560]
br x16
.word 845
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
_p_26:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #568]
br x16
.word 850
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler:
_p_27:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #576]
br x16
.word 855
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
_p_28:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #584]
br x16
.word 860
	.no_dead_strip plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
plt_Plugin_MobFoxAds_Abstractions_BaseMobFox_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler:
_p_29:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #592]
br x16
.word 865
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_30:
adrp x16, mono_aot_Plugin_MobFoxAds_got@PAGE+0
add x16, x16, mono_aot_Plugin_MobFoxAds_got@PAGEOFF
ldr x16, [x16, #600]
br x16
.word 870
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_Plugin_MobFoxAds_got, 608
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
	.asciz "56299B84-7338-4C32-BDCE-2454EFBAA576"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "Plugin.MobFoxAds"
.data
	.align 3
_mono_aot_file_info:

	.long 137,0
	.align 3
	.quad mono_aot_Plugin_MobFoxAds_got
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

	.long 45,608,31,31,66,923871743,0,1082
	.long 128,8,8,10,0,15,1936,848
	.long 488,264,0,392,464,312,0,216
	.long 64,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 41,78,79,134,144,198,49,215,33,193,33,191,28,208,255,70
	.globl _mono_aot_module_Plugin_MobFoxAds_info
	.align 3
_mono_aot_module_Plugin_MobFoxAds_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_0:

	.byte 5
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds"

	.byte 16,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds"

LDIFF_SYM7=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2
	.asciz "Plugin.MobFoxAds.CrossMobFoxAds:.ctor"
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_CrossMobFoxAds__ctor
	.quad Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM10=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM11=Lfde0_end - Lfde0_start
	.long LDIFF_SYM11
Lfde0_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_CrossMobFoxAds__ctor

LDIFF_SYM12=Lme_0 - Plugin_MobFoxAds_CrossMobFoxAds__ctor
	.long LDIFF_SYM12
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 17
	.asciz "Plugin_MobFoxAds_Abstractions_IMobFoxAds"

	.byte 16,7
	.asciz "Plugin_MobFoxAds_Abstractions_IMobFoxAds"

LDIFF_SYM13=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM14=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM15=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2
	.asciz "Plugin.MobFoxAds.CrossMobFoxAds:get_Current"
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds_get_Current"

	.byte 0,0
	.quad Plugin_MobFoxAds_CrossMobFoxAds_get_Current
	.quad Lme_1

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM16=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM17=Lfde1_end - Lfde1_start
	.long LDIFF_SYM17
Lfde1_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_CrossMobFoxAds_get_Current

LDIFF_SYM18=Lme_1 - Plugin_MobFoxAds_CrossMobFoxAds_get_Current
	.long LDIFF_SYM18
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.CrossMobFoxAds:CreateMobFoxAds"
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds"

	.byte 0,0
	.quad Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds
	.quad Lme_2

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM19=Lfde2_end - Lfde2_start
	.long LDIFF_SYM19
Lfde2_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds

LDIFF_SYM20=Lme_2 - Plugin_MobFoxAds_CrossMobFoxAds_CreateMobFoxAds
	.long LDIFF_SYM20
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.CrossMobFoxAds:NotImplementedInReferenceAssembly"
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly"

	.byte 0,0
	.quad Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly
	.quad Lme_3

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM21=Lfde3_end - Lfde3_start
	.long LDIFF_SYM21
Lfde3_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly

LDIFF_SYM22=Lme_3 - Plugin_MobFoxAds_CrossMobFoxAds_NotImplementedInReferenceAssembly
	.long LDIFF_SYM22
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.CrossMobFoxAds:.cctor"
	.asciz "Plugin_MobFoxAds_CrossMobFoxAds__cctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_CrossMobFoxAds__cctor
	.quad Lme_4

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM23=Lfde4_end - Lfde4_start
	.long LDIFF_SYM23
Lfde4_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_CrossMobFoxAds__cctor

LDIFF_SYM24=Lme_4 - Plugin_MobFoxAds_CrossMobFoxAds__cctor
	.long LDIFF_SYM24
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_10:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 16,16
LDIFF_SYM25=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM26=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM27=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM28=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_9:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 16,16
LDIFF_SYM29=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM30=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM30
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM31=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM31
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM32=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM32
LTDIE_8:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 16,16
LDIFF_SYM33=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM33
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM34=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM35=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM36=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM36
LTDIE_12:

	.byte 5
	.asciz "System_Type"

	.byte 24,16
LDIFF_SYM37=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM38=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2,35,16,0,7
	.asciz "System_Type"

LDIFF_SYM39=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM39
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM40=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM40
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM41=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM41
LTDIE_14:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM42=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM43=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM44=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM45=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM45
LTDIE_13:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM46=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM47=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM48=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM48
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM49=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM50=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM50
LTDIE_11:

	.byte 5
	.asciz "System_DelegateData"

	.byte 40,16
LDIFF_SYM51=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM52=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,16,6
	.asciz "method_name"

LDIFF_SYM53=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,35,24,6
	.asciz "curried_first_arg"

LDIFF_SYM54=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM54
	.byte 2,35,32,0,7
	.asciz "System_DelegateData"

LDIFF_SYM55=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM55
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM56=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM56
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM57=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM57
LTDIE_7:

	.byte 5
	.asciz "System_Delegate"

	.byte 104,16
LDIFF_SYM58=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM59=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,35,16,6
	.asciz "invoke_impl"

LDIFF_SYM60=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,24,6
	.asciz "m_target"

LDIFF_SYM61=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,32,6
	.asciz "method"

LDIFF_SYM62=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,35,40,6
	.asciz "delegate_trampoline"

LDIFF_SYM63=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2,35,48,6
	.asciz "extra_arg"

LDIFF_SYM64=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,56,6
	.asciz "method_code"

LDIFF_SYM65=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,35,64,6
	.asciz "method_info"

LDIFF_SYM66=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM66
	.byte 2,35,72,6
	.asciz "original_method_info"

LDIFF_SYM67=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 2,35,80,6
	.asciz "data"

LDIFF_SYM68=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,35,88,6
	.asciz "method_is_virtual"

LDIFF_SYM69=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 2,35,96,0,7
	.asciz "System_Delegate"

LDIFF_SYM70=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM71=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM72=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM72
LTDIE_6:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 112,16
LDIFF_SYM73=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM74=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,35,104,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM75=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM76=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM76
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM77=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM77
LTDIE_5:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 112,16
LDIFF_SYM78=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

LDIFF_SYM79=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM79
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM80=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM80
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM81=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM81
LTDIE_15:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 112,16
LDIFF_SYM82=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

LDIFF_SYM83=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM83
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM84=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM84
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM85=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM85
LTDIE_16:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 112,16
LDIFF_SYM86=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM86
	.byte 2,35,0,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

LDIFF_SYM87=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM87
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM88=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM88
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM89=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM89
LTDIE_4:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox"

	.byte 40,16
LDIFF_SYM90=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,0,6
	.asciz "MobFoxBannerCallbackHandler"

LDIFF_SYM91=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,16,6
	.asciz "MobFoxInterstitialCallbackHandler"

LDIFF_SYM92=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,35,24,6
	.asciz "MobFoxNativeCallbackHandler"

LDIFF_SYM93=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 2,35,32,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_BaseMobFox"

LDIFF_SYM94=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM94
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM95=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM95
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM96=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM96
LTDIE_21:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM97=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,9
	.asciz "HasManagedRef"

	.byte 32,0,7
	.asciz "_Flags"

LDIFF_SYM98=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM98
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM99=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM99
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM100=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM100
LTDIE_20:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 40,16
LDIFF_SYM101=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM101
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM102=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 2,35,16,6
	.asciz "class_handle"

LDIFF_SYM103=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,24,6
	.asciz "flags"

LDIFF_SYM104=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 2,35,32,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM105=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM106=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM106
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM107=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM107
LTDIE_19:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 40,16
LDIFF_SYM108=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,0,0,7
	.asciz "UIKit_UIResponder"

LDIFF_SYM109=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM110=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM111=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM111
LTDIE_18:

	.byte 5
	.asciz "UIKit_UIView"

	.byte 48,16
LDIFF_SYM112=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM113=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,35,40,0,7
	.asciz "UIKit_UIView"

LDIFF_SYM114=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM115=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM115
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM116=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM116
LTDIE_17:

	.byte 5
	.asciz "UIKit_UIAlertView"

	.byte 48,16
LDIFF_SYM117=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,0,0,7
	.asciz "UIKit_UIAlertView"

LDIFF_SYM118=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM118
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM119=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM119
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM120=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM120
LTDIE_3:

	.byte 5
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation"

	.byte 48,16
LDIFF_SYM121=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2,35,0,6
	.asciz "mToast"

LDIFF_SYM122=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,35,40,0,7
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation"

LDIFF_SYM123=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM123
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM124=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM124
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM125=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:.ctor"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation__ctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__ctor
	.quad Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM126=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM127=Lfde5_end - Lfde5_start
	.long LDIFF_SYM127
Lfde5_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__ctor

LDIFF_SYM128=Lme_5 - Plugin_MobFoxAds_MobFoxAdsImplementation__ctor
	.long LDIFF_SYM128
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_22:

	.byte 5
	.asciz "System_Threading_Tasks_TaskScheduler"

	.byte 16,16
LDIFF_SYM129=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,35,0,0,7
	.asciz "System_Threading_Tasks_TaskScheduler"

LDIFF_SYM130=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM130
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM131=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM131
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM132=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:show_toast"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string
	.quad Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM133=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 1,105,3
	.asciz "text"

LDIFF_SYM134=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM135=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM135
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM136=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM137=Lfde6_end - Lfde6_start
	.long LDIFF_SYM137
Lfde6_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string

LDIFF_SYM138=Lme_6 - Plugin_MobFoxAds_MobFoxAdsImplementation_show_toast_string
	.long LDIFF_SYM138
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7,68,154,6
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:ShowToast"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string
	.quad Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM139=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM139
	.byte 2,141,16,3
	.asciz "text"

LDIFF_SYM140=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM141=Lfde7_end - Lfde7_start
	.long LDIFF_SYM141
Lfde7_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string

LDIFF_SYM142=Lme_7 - Plugin_MobFoxAds_MobFoxAdsImplementation_ShowToast_string
	.long LDIFF_SYM142
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_23:

	.byte 5
	.asciz "System_Action`1"

	.byte 112,16
LDIFF_SYM143=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 2,35,0,0,7
	.asciz "System_Action`1"

LDIFF_SYM144=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM144
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM145=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM145
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM146=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_25:

	.byte 5
	.asciz "System_EventArgs"

	.byte 16,16
LDIFF_SYM147=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM147
	.byte 2,35,0,0,7
	.asciz "System_EventArgs"

LDIFF_SYM148=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM148
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM149=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM149
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM150=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM150
LTDIE_24:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 32,16
LDIFF_SYM151=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM151
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM152=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM153=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

LDIFF_SYM154=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM154
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM155=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM155
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM156=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:SendBannerCallbackEvent"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string
	.quad Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM157=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 1,104,3
	.asciz "type"

LDIFF_SYM158=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,141,32,3
	.asciz "error"

LDIFF_SYM159=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM160=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM161=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM162=Lfde8_end - Lfde8_start
	.long LDIFF_SYM162
Lfde8_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string

LDIFF_SYM163=Lme_8 - Plugin_MobFoxAds_MobFoxAdsImplementation_SendBannerCallbackEvent_string_string
	.long LDIFF_SYM163
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_26:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM164=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM165=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM165
	.byte 2,35,16,0,7
	.asciz "System_Int32"

LDIFF_SYM166=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM166
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM167=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM167
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM168=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:CreateBanner"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int
	.quad Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM169=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM169
	.byte 0,3
	.asciz "hash"

LDIFF_SYM170=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 0,3
	.asciz "x"

LDIFF_SYM171=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 0,3
	.asciz "y"

LDIFF_SYM172=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 0,3
	.asciz "width"

LDIFF_SYM173=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 0,3
	.asciz "height"

LDIFF_SYM174=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM175=Lfde9_end - Lfde9_start
	.long LDIFF_SYM175
Lfde9_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int

LDIFF_SYM176=Lme_9 - Plugin_MobFoxAds_MobFoxAdsImplementation_CreateBanner_string_int_int_int_int
	.long LDIFF_SYM176
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:HideBanner"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner
	.quad Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM177=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM177
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM178=Lfde10_end - Lfde10_start
	.long LDIFF_SYM178
Lfde10_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner

LDIFF_SYM179=Lme_a - Plugin_MobFoxAds_MobFoxAdsImplementation_HideBanner
	.long LDIFF_SYM179
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:UnideBanner"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner
	.quad Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM180=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM180
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM181=Lfde11_end - Lfde11_start
	.long LDIFF_SYM181
Lfde11_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner

LDIFF_SYM182=Lme_b - Plugin_MobFoxAds_MobFoxAdsImplementation_UnideBanner
	.long LDIFF_SYM182
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_27:

	.byte 5
	.asciz "System_Action`1"

	.byte 112,16
LDIFF_SYM183=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,35,0,0,7
	.asciz "System_Action`1"

LDIFF_SYM184=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM184
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM185=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM185
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM186=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM186
LTDIE_28:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 32,16
LDIFF_SYM187=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM188=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM188
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM189=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

LDIFF_SYM190=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM190
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM191=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM191
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM192=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM192
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:SendInterstitialCallbackEvent"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string
	.quad Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM193=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM193
	.byte 1,104,3
	.asciz "type"

LDIFF_SYM194=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,141,32,3
	.asciz "error"

LDIFF_SYM195=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM196=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM197=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM198=Lfde12_end - Lfde12_start
	.long LDIFF_SYM198
Lfde12_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string

LDIFF_SYM199=Lme_c - Plugin_MobFoxAds_MobFoxAdsImplementation_SendInterstitialCallbackEvent_string_string
	.long LDIFF_SYM199
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:CreateInterstitial"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string
	.quad Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM200=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM200
	.byte 0,3
	.asciz "hash"

LDIFF_SYM201=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM201
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM202=Lfde13_end - Lfde13_start
	.long LDIFF_SYM202
Lfde13_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string

LDIFF_SYM203=Lme_d - Plugin_MobFoxAds_MobFoxAdsImplementation_CreateInterstitial_string
	.long LDIFF_SYM203
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:ShowInterstitial"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial
	.quad Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM204=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM205=Lfde14_end - Lfde14_start
	.long LDIFF_SYM205
Lfde14_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial

LDIFF_SYM206=Lme_e - Plugin_MobFoxAds_MobFoxAdsImplementation_ShowInterstitial
	.long LDIFF_SYM206
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_29:

	.byte 5
	.asciz "System_Action`1"

	.byte 112,16
LDIFF_SYM207=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 2,35,0,0,7
	.asciz "System_Action`1"

LDIFF_SYM208=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM208
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM209=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM209
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM210=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM210
LTDIE_30:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 72,16
LDIFF_SYM211=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM212=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM212
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM213=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM213
	.byte 2,35,24,6
	.asciz "<TitleText>k__BackingField"

LDIFF_SYM214=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM214
	.byte 2,35,32,6
	.asciz "<BodyText>k__BackingField"

LDIFF_SYM215=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM215
	.byte 2,35,40,6
	.asciz "<IconUrl>k__BackingField"

LDIFF_SYM216=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,35,48,6
	.asciz "<MainImageUrl>k__BackingField"

LDIFF_SYM217=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM217
	.byte 2,35,56,6
	.asciz "<ClickUrl>k__BackingField"

LDIFF_SYM218=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM218
	.byte 2,35,64,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

LDIFF_SYM219=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM219
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM220=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM220
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM221=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:SendNativeCallbackEvent"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM222=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 1,99,3
	.asciz "type"

LDIFF_SYM223=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 2,141,24,3
	.asciz "error"

LDIFF_SYM224=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM224
	.byte 2,141,32,3
	.asciz "titleText"

LDIFF_SYM225=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM225
	.byte 2,141,40,3
	.asciz "bodyText"

LDIFF_SYM226=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM226
	.byte 2,141,48,3
	.asciz "iconUrl"

LDIFF_SYM227=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,141,56,3
	.asciz "mainImageUrl"

LDIFF_SYM228=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 3,141,192,0,3
	.asciz "clickUrl"

LDIFF_SYM229=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 3,141,200,0,11
	.asciz "V_0"

LDIFF_SYM230=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 1,99,11
	.asciz "V_1"

LDIFF_SYM231=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 3,141,208,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM232=Lfde15_end - Lfde15_start
	.long LDIFF_SYM232
Lfde15_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string

LDIFF_SYM233=Lme_f - Plugin_MobFoxAds_MobFoxAdsImplementation_SendNativeCallbackEvent_string_string_string_string_string_string_string
	.long LDIFF_SYM233
	.long 0
	.byte 12,31,0,68,14,112,157,14,158,13,68,13,29,68,147,12
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:CreateNative"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string
	.quad Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM234=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM234
	.byte 0,3
	.asciz "hash"

LDIFF_SYM235=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM236=Lfde16_end - Lfde16_start
	.long LDIFF_SYM236
Lfde16_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string

LDIFF_SYM237=Lme_10 - Plugin_MobFoxAds_MobFoxAdsImplementation_CreateNative_string
	.long LDIFF_SYM237
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde16_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:.cctor"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation__cctor"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__cctor
	.quad Lme_11

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM238=Lfde17_end - Lfde17_start
	.long LDIFF_SYM238
Lfde17_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__cctor

LDIFF_SYM239=Lme_11 - Plugin_MobFoxAds_MobFoxAdsImplementation__cctor
	.long LDIFF_SYM239
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde17_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_34:

	.byte 5
	.asciz "System_Threading_SynchronizationContext"

	.byte 16,16
LDIFF_SYM240=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM240
	.byte 2,35,0,0,7
	.asciz "System_Threading_SynchronizationContext"

LDIFF_SYM241=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM241
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM242=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM242
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM243=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM243
LTDIE_37:

	.byte 5
	.asciz "System_Single"

	.byte 20,16
LDIFF_SYM244=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM244
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM245=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM245
	.byte 2,35,16,0,7
	.asciz "System_Single"

LDIFF_SYM246=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM247=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM247
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM248=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_38:

	.byte 17
	.asciz "System_Collections_ICollection"

	.byte 16,7
	.asciz "System_Collections_ICollection"

LDIFF_SYM249=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM249
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM250=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM250
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM251=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM251
LTDIE_39:

	.byte 17
	.asciz "System_Collections_IEqualityComparer"

	.byte 16,7
	.asciz "System_Collections_IEqualityComparer"

LDIFF_SYM252=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM252
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM253=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM253
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM254=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM254
LTDIE_36:

	.byte 5
	.asciz "System_Collections_Hashtable"

	.byte 80,16
LDIFF_SYM255=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM256=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 2,35,16,6
	.asciz "count"

LDIFF_SYM257=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 2,35,56,6
	.asciz "occupancy"

LDIFF_SYM258=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM258
	.byte 2,35,60,6
	.asciz "loadsize"

LDIFF_SYM259=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM259
	.byte 2,35,64,6
	.asciz "loadFactor"

LDIFF_SYM260=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM260
	.byte 2,35,68,6
	.asciz "version"

LDIFF_SYM261=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,35,72,6
	.asciz "isWriterInProgress"

LDIFF_SYM262=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,35,76,6
	.asciz "keys"

LDIFF_SYM263=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 2,35,24,6
	.asciz "values"

LDIFF_SYM264=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,35,32,6
	.asciz "_keycomparer"

LDIFF_SYM265=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM265
	.byte 2,35,40,6
	.asciz "_syncRoot"

LDIFF_SYM266=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM266
	.byte 2,35,48,0,7
	.asciz "System_Collections_Hashtable"

LDIFF_SYM267=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM267
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM268=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM268
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM269=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM269
LTDIE_40:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

	.byte 16,16
LDIFF_SYM270=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

LDIFF_SYM271=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM271
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM272=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM272
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM273=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM273
LTDIE_41:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

	.byte 16,16
LDIFF_SYM274=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

LDIFF_SYM275=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM275
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM276=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM276
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM277=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM277
LTDIE_35:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

	.byte 56,16
LDIFF_SYM278=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM278
	.byte 2,35,0,6
	.asciz "m_Datastore"

LDIFF_SYM279=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 2,35,16,6
	.asciz "m_RemotingData"

LDIFF_SYM280=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,35,24,6
	.asciz "m_SecurityData"

LDIFF_SYM281=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM281
	.byte 2,35,32,6
	.asciz "m_HostContext"

LDIFF_SYM282=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM282
	.byte 2,35,40,6
	.asciz "m_IsCorrelationMgr"

LDIFF_SYM283=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,35,48,0,7
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

LDIFF_SYM284=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM284
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM285=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM285
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM286=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM286
LTDIE_42:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

	.byte 16,16
LDIFF_SYM287=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

LDIFF_SYM288=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM288
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM289=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM289
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM290=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM290
LTDIE_43:

	.byte 8
	.asciz "_Flags"

	.byte 4
LDIFF_SYM291=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "IsNewCapture"

	.byte 1,9
	.asciz "IsFlowSuppressed"

	.byte 2,9
	.asciz "IsPreAllocatedDefault"

	.byte 4,0,7
	.asciz "_Flags"

LDIFF_SYM292=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM292
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM293=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM293
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM294=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM294
LTDIE_45:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM295=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM295
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM296=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM296
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM297=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM297
LTDIE_46:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM298=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM298
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM299=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM300=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM300
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM301=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM301
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM302=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM302
LTDIE_47:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM303=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM303
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM304=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM305=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM305
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM306=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM306
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM307=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM307
LTDIE_44:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM308=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM309=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM309
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM310=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM311=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM312=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM313=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM313
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM314=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM314
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM315=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM315
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM316=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM317=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM318=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM319=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM319
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM320=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM320
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM321=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM321
LTDIE_48:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM322=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM323=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM324=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM324
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM325=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM325
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM326=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM326
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM327=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM327
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM328=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM328
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM329=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM329
LTDIE_33:

	.byte 5
	.asciz "System_Threading_ExecutionContext"

	.byte 72,16
LDIFF_SYM330=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,35,0,6
	.asciz "_syncContext"

LDIFF_SYM331=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM331
	.byte 2,35,16,6
	.asciz "_syncContextNoFlow"

LDIFF_SYM332=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM332
	.byte 2,35,24,6
	.asciz "_logicalCallContext"

LDIFF_SYM333=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 2,35,32,6
	.asciz "_illogicalCallContext"

LDIFF_SYM334=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM334
	.byte 2,35,40,6
	.asciz "_flags"

LDIFF_SYM335=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM335
	.byte 2,35,64,6
	.asciz "_localValues"

LDIFF_SYM336=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 2,35,48,6
	.asciz "_localChangeNotifications"

LDIFF_SYM337=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM337
	.byte 2,35,56,0,7
	.asciz "System_Threading_ExecutionContext"

LDIFF_SYM338=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM338
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM339=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM339
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM340=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM340
LTDIE_53:

	.byte 5
	.asciz "System_MarshalByRefObject"

	.byte 24,16
LDIFF_SYM341=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM341
	.byte 2,35,0,6
	.asciz "_identity"

LDIFF_SYM342=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM342
	.byte 2,35,16,0,7
	.asciz "System_MarshalByRefObject"

LDIFF_SYM343=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM343
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM344=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM344
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM345=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM345
LTDIE_57:

	.byte 5
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

	.byte 16,16
LDIFF_SYM346=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM346
	.byte 2,35,0,0,7
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

LDIFF_SYM347=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM347
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM348=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM348
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM349=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM349
LTDIE_56:

	.byte 5
	.asciz "System_Runtime_InteropServices_SafeHandle"

	.byte 32,16
LDIFF_SYM350=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM351=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM351
	.byte 2,35,16,6
	.asciz "_state"

LDIFF_SYM352=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM352
	.byte 2,35,24,6
	.asciz "_ownsHandle"

LDIFF_SYM353=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM353
	.byte 2,35,28,6
	.asciz "_fullyInitialized"

LDIFF_SYM354=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 2,35,29,0,7
	.asciz "System_Runtime_InteropServices_SafeHandle"

LDIFF_SYM355=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM355
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM356=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM356
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM357=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM357
LTDIE_55:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

	.byte 32,16
LDIFF_SYM358=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM358
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

LDIFF_SYM359=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM359
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM360=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM360
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM361=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM361
LTDIE_54:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

	.byte 32,16
LDIFF_SYM362=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

LDIFF_SYM363=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM363
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM364=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM364
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM365=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM365
LTDIE_52:

	.byte 5
	.asciz "System_Threading_WaitHandle"

	.byte 48,16
LDIFF_SYM366=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM366
	.byte 2,35,0,6
	.asciz "waitHandle"

LDIFF_SYM367=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM367
	.byte 2,35,24,6
	.asciz "safeWaitHandle"

LDIFF_SYM368=LTDIE_54_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM368
	.byte 2,35,32,6
	.asciz "hasThreadAffinity"

LDIFF_SYM369=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM369
	.byte 2,35,40,0,7
	.asciz "System_Threading_WaitHandle"

LDIFF_SYM370=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM370
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM371=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM371
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM372=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM372
LTDIE_51:

	.byte 5
	.asciz "System_Threading_EventWaitHandle"

	.byte 48,16
LDIFF_SYM373=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 2,35,0,0,7
	.asciz "System_Threading_EventWaitHandle"

LDIFF_SYM374=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM374
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM375=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM375
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM376=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM376
LTDIE_50:

	.byte 5
	.asciz "System_Threading_ManualResetEvent"

	.byte 48,16
LDIFF_SYM377=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,35,0,0,7
	.asciz "System_Threading_ManualResetEvent"

LDIFF_SYM378=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM378
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM379=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM379
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM380=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM380
LTDIE_49:

	.byte 5
	.asciz "System_Threading_ManualResetEventSlim"

	.byte 40,16
LDIFF_SYM381=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM381
	.byte 2,35,0,6
	.asciz "m_lock"

LDIFF_SYM382=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 2,35,16,6
	.asciz "m_eventObj"

LDIFF_SYM383=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM383
	.byte 2,35,24,6
	.asciz "m_combinedState"

LDIFF_SYM384=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM384
	.byte 2,35,32,0,7
	.asciz "System_Threading_ManualResetEventSlim"

LDIFF_SYM385=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM385
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM386=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM386
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM387=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM387
LTDIE_59:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM388=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM388
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM389=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM389
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM390=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM390
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM391=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM392=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM392
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM393=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM393
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM394=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM394
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM395=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM395
LTDIE_62:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 16,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM396=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM396
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM397=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM397
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM398=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM398
LTDIE_64:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM399=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM399
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM400=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM400
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM401=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM401
LTDIE_67:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM402=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM402
LTDIE_67_POINTER:

	.byte 13
LDIFF_SYM403=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM403
LTDIE_67_REFERENCE:

	.byte 14
LDIFF_SYM404=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM404
LTDIE_68:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM405=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM405
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM406=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM407=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM407
LTDIE_68_POINTER:

	.byte 13
LDIFF_SYM408=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM408
LTDIE_68_REFERENCE:

	.byte 14
LDIFF_SYM409=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM409
LTDIE_69:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM410=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM410
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM411=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM411
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM412=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM412
LTDIE_69_POINTER:

	.byte 13
LDIFF_SYM413=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM413
LTDIE_69_REFERENCE:

	.byte 14
LDIFF_SYM414=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM414
LTDIE_66:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM415=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM416=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM416
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM417=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM417
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM418=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM418
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM419=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM419
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM420=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM421=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM421
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM422=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM422
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM423=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM424=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM425=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM425
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM426=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM426
LTDIE_66_POINTER:

	.byte 13
LDIFF_SYM427=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM427
LTDIE_66_REFERENCE:

	.byte 14
LDIFF_SYM428=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM428
LTDIE_70:

	.byte 17
	.asciz "System_Runtime_Serialization_IFormatterConverter"

	.byte 16,7
	.asciz "System_Runtime_Serialization_IFormatterConverter"

LDIFF_SYM429=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM429
LTDIE_70_POINTER:

	.byte 13
LDIFF_SYM430=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM430
LTDIE_70_REFERENCE:

	.byte 14
LDIFF_SYM431=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM431
LTDIE_65:

	.byte 5
	.asciz "System_Runtime_Serialization_SerializationInfo"

	.byte 88,16
LDIFF_SYM432=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM432
	.byte 2,35,0,6
	.asciz "m_members"

LDIFF_SYM433=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM433
	.byte 2,35,16,6
	.asciz "m_data"

LDIFF_SYM434=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM434
	.byte 2,35,24,6
	.asciz "m_types"

LDIFF_SYM435=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM435
	.byte 2,35,32,6
	.asciz "m_nameToIndex"

LDIFF_SYM436=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM436
	.byte 2,35,40,6
	.asciz "m_currMember"

LDIFF_SYM437=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM437
	.byte 2,35,80,6
	.asciz "m_converter"

LDIFF_SYM438=LTDIE_70_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM438
	.byte 2,35,48,6
	.asciz "m_fullTypeName"

LDIFF_SYM439=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM439
	.byte 2,35,56,6
	.asciz "m_assemName"

LDIFF_SYM440=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 2,35,64,6
	.asciz "objectType"

LDIFF_SYM441=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM441
	.byte 2,35,72,6
	.asciz "isFullTypeNameSetExplicit"

LDIFF_SYM442=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM442
	.byte 2,35,84,6
	.asciz "isAssemblyNameSetExplicit"

LDIFF_SYM443=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM443
	.byte 2,35,85,6
	.asciz "requireSameTokenInPartialTrust"

LDIFF_SYM444=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM444
	.byte 2,35,86,0,7
	.asciz "System_Runtime_Serialization_SerializationInfo"

LDIFF_SYM445=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM445
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM446=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM446
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM447=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM447
LTDIE_72:

	.byte 5
	.asciz "System_Reflection_TypeInfo"

	.byte 24,16
LDIFF_SYM448=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM448
	.byte 2,35,0,0,7
	.asciz "System_Reflection_TypeInfo"

LDIFF_SYM449=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM449
LTDIE_72_POINTER:

	.byte 13
LDIFF_SYM450=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM450
LTDIE_72_REFERENCE:

	.byte 14
LDIFF_SYM451=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM451
LTDIE_76:

	.byte 5
	.asciz "System_Reflection_ConstructorInfo"

	.byte 16,16
LDIFF_SYM452=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM452
	.byte 2,35,0,0,7
	.asciz "System_Reflection_ConstructorInfo"

LDIFF_SYM453=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM453
LTDIE_76_POINTER:

	.byte 13
LDIFF_SYM454=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM454
LTDIE_76_REFERENCE:

	.byte 14
LDIFF_SYM455=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM455
LTDIE_75:

	.byte 5
	.asciz "System_Reflection_RuntimeConstructorInfo"

	.byte 16,16
LDIFF_SYM456=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM456
	.byte 2,35,0,0,7
	.asciz "System_Reflection_RuntimeConstructorInfo"

LDIFF_SYM457=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM457
LTDIE_75_POINTER:

	.byte 13
LDIFF_SYM458=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM458
LTDIE_75_REFERENCE:

	.byte 14
LDIFF_SYM459=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM459
LTDIE_74:

	.byte 5
	.asciz "System_Reflection_MonoCMethod"

	.byte 40,16
LDIFF_SYM460=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM460
	.byte 2,35,0,6
	.asciz "mhandle"

LDIFF_SYM461=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 2,35,16,6
	.asciz "name"

LDIFF_SYM462=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM462
	.byte 2,35,24,6
	.asciz "reftype"

LDIFF_SYM463=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM463
	.byte 2,35,32,0,7
	.asciz "System_Reflection_MonoCMethod"

LDIFF_SYM464=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM464
LTDIE_74_POINTER:

	.byte 13
LDIFF_SYM465=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM465
LTDIE_74_REFERENCE:

	.byte 14
LDIFF_SYM466=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM466
LTDIE_73:

	.byte 5
	.asciz "System_MonoTypeInfo"

	.byte 32,16
LDIFF_SYM467=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM467
	.byte 2,35,0,6
	.asciz "full_name"

LDIFF_SYM468=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM468
	.byte 2,35,16,6
	.asciz "default_ctor"

LDIFF_SYM469=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM469
	.byte 2,35,24,0,7
	.asciz "System_MonoTypeInfo"

LDIFF_SYM470=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM470
LTDIE_73_POINTER:

	.byte 13
LDIFF_SYM471=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM471
LTDIE_73_REFERENCE:

	.byte 14
LDIFF_SYM472=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM472
LTDIE_71:

	.byte 5
	.asciz "System_RuntimeType"

	.byte 48,16
LDIFF_SYM473=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 2,35,0,6
	.asciz "type_info"

LDIFF_SYM474=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 2,35,24,6
	.asciz "GenericCache"

LDIFF_SYM475=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM475
	.byte 2,35,32,6
	.asciz "m_serializationCtor"

LDIFF_SYM476=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM476
	.byte 2,35,40,0,7
	.asciz "System_RuntimeType"

LDIFF_SYM477=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM477
LTDIE_71_POINTER:

	.byte 13
LDIFF_SYM478=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM478
LTDIE_71_REFERENCE:

	.byte 14
LDIFF_SYM479=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM479
LTDIE_77:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM480=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM480
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM481=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM481
LTDIE_77_POINTER:

	.byte 13
LDIFF_SYM482=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM482
LTDIE_77_REFERENCE:

	.byte 14
LDIFF_SYM483=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM483
LTDIE_63:

	.byte 5
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

	.byte 56,16
LDIFF_SYM484=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM484
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM485=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM485
	.byte 2,35,16,6
	.asciz "m_savedSerializationInfo"

LDIFF_SYM486=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,35,24,6
	.asciz "m_realObject"

LDIFF_SYM487=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM487
	.byte 2,35,32,6
	.asciz "m_realType"

LDIFF_SYM488=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM488
	.byte 2,35,40,6
	.asciz "SerializeObjectState"

LDIFF_SYM489=LTDIE_77_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM489
	.byte 2,35,48,0,7
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

LDIFF_SYM490=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM490
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM491=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM491
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM492=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM492
LTDIE_61:

	.byte 5
	.asciz "System_Exception"

	.byte 136,1,16
LDIFF_SYM493=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM493
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM494=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 2,35,16,6
	.asciz "_message"

LDIFF_SYM495=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 2,35,24,6
	.asciz "_data"

LDIFF_SYM496=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM496
	.byte 2,35,32,6
	.asciz "_innerException"

LDIFF_SYM497=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM497
	.byte 2,35,40,6
	.asciz "_helpURL"

LDIFF_SYM498=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM498
	.byte 2,35,48,6
	.asciz "_stackTrace"

LDIFF_SYM499=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM499
	.byte 2,35,56,6
	.asciz "_stackTraceString"

LDIFF_SYM500=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM500
	.byte 2,35,64,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM501=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM501
	.byte 2,35,72,6
	.asciz "_remoteStackIndex"

LDIFF_SYM502=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM502
	.byte 2,35,80,6
	.asciz "_dynamicMethods"

LDIFF_SYM503=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM503
	.byte 2,35,88,6
	.asciz "_HResult"

LDIFF_SYM504=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM504
	.byte 2,35,96,6
	.asciz "_source"

LDIFF_SYM505=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM505
	.byte 2,35,104,6
	.asciz "_safeSerializationManager"

LDIFF_SYM506=LTDIE_63_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM506
	.byte 2,35,112,6
	.asciz "captured_traces"

LDIFF_SYM507=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM507
	.byte 2,35,120,6
	.asciz "native_trace_ips"

LDIFF_SYM508=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM508
	.byte 3,35,128,1,0,7
	.asciz "System_Exception"

LDIFF_SYM509=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM509
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM510=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM510
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM511=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM511
LTDIE_60:

	.byte 5
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

	.byte 32,16
LDIFF_SYM512=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM512
	.byte 2,35,0,6
	.asciz "m_Exception"

LDIFF_SYM513=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM513
	.byte 2,35,16,6
	.asciz "m_stackTrace"

LDIFF_SYM514=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM514
	.byte 2,35,24,0,7
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

LDIFF_SYM515=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM515
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM516=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM516
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM517=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM517
LTDIE_58:

	.byte 5
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

	.byte 48,16
LDIFF_SYM518=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM518
	.byte 2,35,0,6
	.asciz "m_task"

LDIFF_SYM519=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM519
	.byte 2,35,16,6
	.asciz "m_faultExceptions"

LDIFF_SYM520=LTDIE_59_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM520
	.byte 2,35,24,6
	.asciz "m_cancellationException"

LDIFF_SYM521=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM521
	.byte 2,35,32,6
	.asciz "m_isHandled"

LDIFF_SYM522=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 2,35,40,0,7
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

LDIFF_SYM523=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM523
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM524=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM524
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM525=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM525
LTDIE_78:

	.byte 5
	.asciz "System_Threading_Tasks_Shared`1"

	.byte 40,16
LDIFF_SYM526=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM526
	.byte 2,35,0,6
	.asciz "Value"

LDIFF_SYM527=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM527
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_Shared`1"

LDIFF_SYM528=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM528
LTDIE_78_POINTER:

	.byte 13
LDIFF_SYM529=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM529
LTDIE_78_REFERENCE:

	.byte 14
LDIFF_SYM530=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM530
LTDIE_79:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM531=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM532=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM532
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM533=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM533
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM534=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM534
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM535=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM535
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM536=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM536
LTDIE_79_POINTER:

	.byte 13
LDIFF_SYM537=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM537
LTDIE_79_REFERENCE:

	.byte 14
LDIFF_SYM538=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM538
LTDIE_32:

	.byte 5
	.asciz "_ContingentProperties"

	.byte 72,16
LDIFF_SYM539=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,35,0,6
	.asciz "m_capturedContext"

LDIFF_SYM540=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM540
	.byte 2,35,16,6
	.asciz "m_completionEvent"

LDIFF_SYM541=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM541
	.byte 2,35,24,6
	.asciz "m_exceptionsHolder"

LDIFF_SYM542=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM542
	.byte 2,35,32,6
	.asciz "m_cancellationToken"

LDIFF_SYM543=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM543
	.byte 2,35,40,6
	.asciz "m_cancellationRegistration"

LDIFF_SYM544=LTDIE_78_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM544
	.byte 2,35,48,6
	.asciz "m_internalCancellationRequested"

LDIFF_SYM545=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM545
	.byte 2,35,64,6
	.asciz "m_completionCountdown"

LDIFF_SYM546=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM546
	.byte 2,35,68,6
	.asciz "m_exceptionalChildren"

LDIFF_SYM547=LTDIE_79_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM547
	.byte 2,35,56,0,7
	.asciz "_ContingentProperties"

LDIFF_SYM548=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM548
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM549=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM549
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM550=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM550
LTDIE_31:

	.byte 5
	.asciz "System_Threading_Tasks_Task"

	.byte 72,16
LDIFF_SYM551=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM551
	.byte 2,35,0,6
	.asciz "m_taskId"

LDIFF_SYM552=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM552
	.byte 2,35,64,6
	.asciz "m_action"

LDIFF_SYM553=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM553
	.byte 2,35,16,6
	.asciz "m_stateObject"

LDIFF_SYM554=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM554
	.byte 2,35,24,6
	.asciz "m_taskScheduler"

LDIFF_SYM555=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM555
	.byte 2,35,32,6
	.asciz "m_parent"

LDIFF_SYM556=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,35,40,6
	.asciz "m_stateFlags"

LDIFF_SYM557=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM557
	.byte 2,35,68,6
	.asciz "m_continuationObject"

LDIFF_SYM558=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM558
	.byte 2,35,48,6
	.asciz "m_contingentProperties"

LDIFF_SYM559=LTDIE_32_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM559
	.byte 2,35,56,0,7
	.asciz "System_Threading_Tasks_Task"

LDIFF_SYM560=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM560
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM561=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM561
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM562=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM562
	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:<show_toast>m__0"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task
	.quad Lme_12

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM563=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM563
	.byte 2,141,16,3
	.asciz "task"

LDIFF_SYM564=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM565=Lfde18_end - Lfde18_start
	.long LDIFF_SYM565
Lfde18_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task

LDIFF_SYM566=Lme_12 - Plugin_MobFoxAds_MobFoxAdsImplementation__show_toastm__0_System_Threading_Tasks_Task
	.long LDIFF_SYM566
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde18_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.add_MobFoxBannerCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.quad Lme_13

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM567=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM568=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM568
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM569=Lfde19_end - Lfde19_start
	.long LDIFF_SYM569
Lfde19_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler

LDIFF_SYM570=Lme_13 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.long LDIFF_SYM570
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.remove_MobFoxBannerCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.quad Lme_14

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM571=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM571
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM572=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM572
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM573=Lfde20_end - Lfde20_start
	.long LDIFF_SYM573
Lfde20_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler

LDIFF_SYM574=Lme_14 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxBannerCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventHandler
	.long LDIFF_SYM574
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde20_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.add_MobFoxInterstitialCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.quad Lme_15

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM575=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM575
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM576=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM576
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM577=Lfde21_end - Lfde21_start
	.long LDIFF_SYM577
Lfde21_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler

LDIFF_SYM578=Lme_15 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.long LDIFF_SYM578
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.remove_MobFoxInterstitialCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.quad Lme_16

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM579=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM579
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM580=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM580
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM581=Lfde22_end - Lfde22_start
	.long LDIFF_SYM581
Lfde22_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler

LDIFF_SYM582=Lme_16 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxInterstitialCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventHandler
	.long LDIFF_SYM582
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.add_MobFoxNativeCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.quad Lme_17

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM583=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM583
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM584=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM584
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM585=Lfde23_end - Lfde23_start
	.long LDIFF_SYM585
Lfde23_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler

LDIFF_SYM586=Lme_17 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_add_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.long LDIFF_SYM586
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde23_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Plugin.MobFoxAds.MobFoxAdsImplementation:Plugin.MobFoxAds.Abstractions.IMobFoxAds.remove_MobFoxNativeCallbackHandler"
	.asciz "Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler"

	.byte 0,0
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.quad Lme_18

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM587=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM587
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM588=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM588
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM589=Lfde24_end - Lfde24_start
	.long LDIFF_SYM589
Lfde24_start:

	.long 0
	.align 3
	.quad Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler

LDIFF_SYM590=Lme_18 - Plugin_MobFoxAds_MobFoxAdsImplementation_Plugin_MobFoxAds_Abstractions_IMobFoxAds_remove_MobFoxNativeCallbackHandler_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventHandler
	.long LDIFF_SYM590
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde24_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_80:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM591=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM591
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM592=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM592
LTDIE_80_POINTER:

	.byte 13
LDIFF_SYM593=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM593
LTDIE_80_REFERENCE:

	.byte 14
LDIFF_SYM594=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM594
LTDIE_81:

	.byte 5
	.asciz "System_Array"

	.byte 16,16
LDIFF_SYM595=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM595
	.byte 2,35,0,0,7
	.asciz "System_Array"

LDIFF_SYM596=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM596
LTDIE_81_POINTER:

	.byte 13
LDIFF_SYM597=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM597
LTDIE_81_REFERENCE:

	.byte 14
LDIFF_SYM598=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM598
	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.Func`1<Plugin.MobFoxAds.Abstractions.IMobFoxAds>:invoke_TResult"
	.asciz "wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult"

	.byte 0,0
	.quad wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult
	.quad Lme_1a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM599=LTDIE_80_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM599
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM600=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM600
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM601=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM601
	.byte 1,106,11
	.asciz "V_2"

LDIFF_SYM602=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM602
	.byte 1,105,11
	.asciz "V_3"

LDIFF_SYM603=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM603
	.byte 1,103,11
	.asciz "V_4"

LDIFF_SYM604=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM604
	.byte 1,105,11
	.asciz "V_5"

LDIFF_SYM605=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM606=Lfde25_end - Lfde25_start
	.long LDIFF_SYM606
Lfde25_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult

LDIFF_SYM607=Lme_1a - wrapper_delegate_invoke_System_Func_1_Plugin_MobFoxAds_Abstractions_IMobFoxAds_invoke_TResult
	.long LDIFF_SYM607
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde25_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_82:

	.byte 5
	.asciz "System_Action`1"

	.byte 112,16
LDIFF_SYM608=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM608
	.byte 2,35,0,0,7
	.asciz "System_Action`1"

LDIFF_SYM609=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM609
LTDIE_82_POINTER:

	.byte 13
LDIFF_SYM610=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM610
LTDIE_82_REFERENCE:

	.byte 14
LDIFF_SYM611=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM611
	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.Action`1<System.Threading.Tasks.Task>:invoke_void_T"
	.asciz "wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task"

	.byte 0,0
	.quad wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task
	.quad Lme_1b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM612=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM613=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM614=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM614
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM615=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM615
	.byte 1,105,11
	.asciz "V_2"

LDIFF_SYM616=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 1,104,11
	.asciz "V_3"

LDIFF_SYM617=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 1,102,11
	.asciz "V_4"

LDIFF_SYM618=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM618
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM619=Lfde26_end - Lfde26_start
	.long LDIFF_SYM619
Lfde26_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task

LDIFF_SYM620=Lme_1b - wrapper_delegate_invoke_System_Action_1_System_Threading_Tasks_Task_invoke_void_T_System_Threading_Tasks_Task
	.long LDIFF_SYM620
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde26_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.Action`1<Plugin.MobFoxAds.Abstractions.MobFoxBannerCallbackEventArgs>:invoke_void_T"
	.asciz "wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.quad Lme_1c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM621=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM622=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM622
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM623=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM623
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM624=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM624
	.byte 1,105,11
	.asciz "V_2"

LDIFF_SYM625=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 1,104,11
	.asciz "V_3"

LDIFF_SYM626=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM626
	.byte 1,102,11
	.asciz "V_4"

LDIFF_SYM627=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM627
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM628=Lfde27_end - Lfde27_start
	.long LDIFF_SYM628
Lfde27_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs

LDIFF_SYM629=Lme_1c - wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.long LDIFF_SYM629
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.Action`1<Plugin.MobFoxAds.Abstractions.MobFoxInterstitialCallbackEventArgs>:invoke_void_T"
	.asciz "wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.quad Lme_1d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM630=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM630
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM631=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM631
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM632=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM632
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM633=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM633
	.byte 1,105,11
	.asciz "V_2"

LDIFF_SYM634=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM634
	.byte 1,104,11
	.asciz "V_3"

LDIFF_SYM635=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM635
	.byte 1,102,11
	.asciz "V_4"

LDIFF_SYM636=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM637=Lfde28_end - Lfde28_start
	.long LDIFF_SYM637
Lfde28_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs

LDIFF_SYM638=Lme_1d - wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.long LDIFF_SYM638
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.Action`1<Plugin.MobFoxAds.Abstractions.MobFoxNativeCallbackEventArgs>:invoke_void_T"
	.asciz "wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 0,0
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.quad Lme_1e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM639=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM639
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM640=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM641=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM641
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM642=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM642
	.byte 1,105,11
	.asciz "V_2"

LDIFF_SYM643=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM643
	.byte 1,104,11
	.asciz "V_3"

LDIFF_SYM644=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM644
	.byte 1,102,11
	.asciz "V_4"

LDIFF_SYM645=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM646=Lfde29_end - Lfde29_start
	.long LDIFF_SYM646
Lfde29_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs

LDIFF_SYM647=Lme_1e - wrapper_delegate_invoke_System_Action_1_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs_invoke_void_T_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.long LDIFF_SYM647
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
