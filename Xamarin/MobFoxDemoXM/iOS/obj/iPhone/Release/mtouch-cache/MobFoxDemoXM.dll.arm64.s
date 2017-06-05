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
	.asciz "MobFoxDemoXM.dll"
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
	.no_dead_strip MobFoxDemoXM_App__ctor
MobFoxDemoXM_App__ctor:
.file 1 "<unknown>"
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
bl _p_1
.word 0xf9400ba0
bl _p_2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #120]
bl _p_3
.word 0xf90013a0
bl _p_4
.word 0xf94013a1
.word 0xf9400ba0
bl _p_5
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_App_OnStart
MobFoxDemoXM_App_OnStart:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_App_OnSleep
MobFoxDemoXM_App_OnSleep:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_App_OnResume
MobFoxDemoXM_App_OnResume:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_App_InitializeComponent
MobFoxDemoXM_App_InitializeComponent:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #128]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #136]
.word 0xf9400ba0
bl _p_6
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage__ctor
MobFoxDemoXM_MobFoxDemoXMPage__ctor:
.loc 1 1 0
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #144]
.word 0xf9400000
.word 0xf90013a0
.word 0xf900e740
.word 0x91072340
bl _p_7
.word 0xf94013a0
.word 0xaa1a03e0
bl _p_8
.word 0xaa1a03e0
bl _p_9
bl _p_10
.word 0xaa0003e1

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9400000
.word 0xaa0103f9
.word 0xb5000340

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #160]
bl _p_11
.word 0xaa0003e1

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xf9001420

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #176]
.word 0xf9002020

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #184]
.word 0xf9401402
.word 0xf9000c22
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9000001

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #152]
.word 0xf9400001
.word 0xaa1903e0
.word 0xf9400322

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #192]
.word 0x928006f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
bl _p_10
.word 0xf9002ba0
.word 0xeb1f035f
.word 0x10000011
.word 0x54001640

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #200]
bl _p_11
.word 0xf900101a
.word 0xf90027a0
.word 0x91008000
bl _p_7
.word 0xf94027a1
.word 0xf9402ba2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #208]
.word 0xf9001420

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #216]
.word 0xf9002020

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #224]
.word 0xf9401403
.word 0xf9000c23
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #232]
.word 0x928011f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
bl _p_10
.word 0xf90023a0
.word 0xeb1f035f
.word 0x10000011
.word 0x54001140

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #240]
bl _p_11
.word 0xf900101a
.word 0xf9001fa0
.word 0x91008000
bl _p_7
.word 0xf9401fa1
.word 0xf94023a2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #248]
.word 0xf9001420

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xf9002020

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #264]
.word 0xf9401403
.word 0xf9000c23
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #272]
.word 0x92800af0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #280]
bl _p_11
.word 0xf9001ba0
bl _p_12
.word 0xf9401ba0
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xf90017a0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000b40

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #288]
bl _p_11
.word 0xf900101a
.word 0xf90013a0
.word 0x91008000
bl _p_7
.word 0xf94013a1
.word 0xf94017a2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #296]
.word 0xf9001420

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #304]
.word 0xf9002020

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xf9401403
.word 0xf9000c23
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f
.word 0xaa0203e0
.word 0xf940005e
bl _p_13
.word 0xf940ef40
.word 0xaa0003e1
.word 0xf940003e
.word 0xf940b002
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #320]
.word 0x928004f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xf940f340
.word 0xaa0003e1
.word 0xf940003e
.word 0xf940b002
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #320]
.word 0x928004f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xf940eb40
.word 0xaa0003e1
.word 0xf940003e
.word 0xf940b002
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #320]
.word 0x928004f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xf940f740
.word 0xaa0003e1
.word 0xf940003e
.word 0xf940b002
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #320]
.word 0x928004f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xd2800b00
.word 0xaa1103e1
bl _p_14

Lme_5:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
bl _p_10
.word 0xaa0003e6

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xaa0603e0
.word 0xd2800142
.word 0xd2800283
.word 0xd2802804
.word 0xd2800645
.word 0xf94000c6

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #336]
.word 0x928004f0
.word 0xf2bffff0
.word 0xf87068d0
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_6:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
bl _p_10
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #344]
.word 0x928006f0
.word 0xf2bffff0
.word 0xf8706830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
bl _p_10
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #352]
.word 0x928007f0
.word 0xf2bffff0
.word 0xf8706830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_8:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xd280003e
.word 0x3907c01e
bl _p_10
.word 0xaa0003e2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #360]
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #368]
.word 0x928012f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_9:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0x3907c01f
bl _p_10
.word 0xaa0003e2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #360]
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #368]
.word 0x928012f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_a:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
bl _p_10
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #376]
.word 0x928006f0
.word 0xf2bffff0
.word 0xf8706830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_b:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
bl _p_10
.word 0xaa0003e2

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #384]
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #392]
.word 0x928012f0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_c:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent
MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #400]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #408]
.word 0xaa1a03e0
bl _p_15

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #416]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #424]
.word 0xaa1a03e0
bl _p_16
.word 0xf9001fa0
.word 0xf900eb40
.word 0x91074340
bl _p_7
.word 0xf9401fa0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #432]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #440]
.word 0xaa1a03e0
bl _p_17
.word 0xf9001ba0
.word 0xf900ef40
.word 0x91076340
bl _p_7
.word 0xf9401ba0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #448]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #440]
.word 0xaa1a03e0
bl _p_17
.word 0xf90017a0
.word 0xf900f340
.word 0x91078340
bl _p_7
.word 0xf94017a0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #456]

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #424]
.word 0xaa1a03e0
bl _p_16
.word 0xf90013a0
.word 0xf900f740
.word 0x9107a340
bl _p_7
.word 0xf94013a0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
bl _p_10
.word 0xf90013a0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #464]
.word 0xf940035e
.word 0xf9400b41

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x2, [x16, #472]
.word 0xf940035e
.word 0xf9400f43
bl _p_18
.word 0xaa0003e1
.word 0xf94013a2
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #480]
.word 0x92800ff0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xf90013a1
.word 0xaa0203fa
.word 0xf940035e
.word 0xf9400b42

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #488]
.word 0xaa0203e0
.word 0xf940005e
bl _p_19
.word 0x53001c00
.word 0x34000200
.word 0xf9400fa0
.word 0x3947c000
.word 0x340001a0
bl _p_10
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #376]
.word 0x928006f0
.word 0xf2bffff0
.word 0xf8706830
.word 0xd63f0200
.word 0x14000019
bl _p_10
.word 0xf9001ba0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #496]
.word 0xf940035e
.word 0xf9400b41

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x2, [x16, #472]
.word 0xf940035e
.word 0xf9400f43
bl _p_18
.word 0xaa0003e1
.word 0xf9401ba2
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #480]
.word 0x92800ff0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs:
.loc 1 1 0
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xf90017a1
.word 0xaa0203fa
.word 0xf940035e
.word 0xf9400b42

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x1, [x16, #504]
.word 0xaa0203e0
.word 0xf940005e
bl _p_19
.word 0x53001c00
.word 0x34000fa0
.word 0xf940ef22
.word 0xf940035e
.word 0xf9401341
.word 0xaa0203e0
.word 0xf940005e
bl _p_20
.word 0xf940f322
.word 0xf940035e
.word 0xf9401741
.word 0xaa0203e0
.word 0xf940005e
bl _p_20
.word 0xf940eb20
.word 0xf90043a0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #512]
.word 0x3980ac10
.word 0xb5000050
bl _p_21

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #512]
bl _p_11
.word 0xf90053a0
bl _p_22
.word 0xf94053a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xf9004ba0
.word 0xf940035e
.word 0xf9401b40
.word 0xf9004fa0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #520]
bl _p_11
.word 0xf9404fa1
.word 0xf90047a0
bl _p_23
.word 0xf94047a1
.word 0xf9404ba2
.word 0xaa0203e0
.word 0xf940005e
bl _p_24
.word 0xaa1803e0
.word 0xd2800021
.word 0xf940031e
bl _p_25
.word 0xf90027bf
.word 0x910123a0
.word 0xd28000a1
.word 0xd2800002
.word 0xd2800003
.word 0xd2800004
bl _p_26
.word 0xf94027a0
.word 0xf9001fa0
.word 0xaa1803e0
.word 0xf9401fa1
.word 0xf940031e
bl _p_27
.word 0xf94043a2
.word 0xaa0203e0
.word 0xaa1803e1
.word 0xf940005e
bl _p_28
.word 0xf940f720
.word 0xf9002fa0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #512]
bl _p_11
.word 0xf9003fa0
bl _p_22
.word 0xf9403fa0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xf90037a0
.word 0xf940035e
.word 0xf9401f40
.word 0xf9003ba0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #520]
bl _p_11
.word 0xf9403ba1
.word 0xf90033a0
bl _p_23
.word 0xf94033a1
.word 0xf94037a2
.word 0xaa0203e0
.word 0xf940005e
bl _p_24
.word 0xaa1803e0
.word 0xd2800021
.word 0xf940031e
bl _p_25
.word 0xf90023bf
.word 0x910103a0
.word 0xd28000a1
.word 0xd2800002
.word 0xd2800003
.word 0xd2800004
bl _p_26
.word 0xf94023a0
.word 0xf9001ba0
.word 0xaa1803e0
.word 0xf9401ba1
.word 0xf940031e
bl _p_27
.word 0xf9402fa2
.word 0xaa0203e0
.word 0xaa1803e1
.word 0xf940005e
bl _p_28
.word 0xf940035e
.word 0xf9402340
.word 0xf9002ba0
.word 0xf900e720
.word 0x91072320
bl _p_7
.word 0xf9402ba0
.word 0x14000019
bl _p_10
.word 0xf9002ba0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #528]
.word 0xf940035e
.word 0xf9400b41

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x2, [x16, #472]
.word 0xf940035e
.word 0xf9400f43
bl _p_18
.word 0xaa0003e1
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xf9400042

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x15, [x16, #480]
.word 0x92800ff0
.word 0xf2bffff0
.word 0xf8706850
.word 0xd63f0200
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs
MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xf940e400
.word 0xb9801000
.word 0x6b1f001f
.word 0x540001ad
.word 0xf9400ba0
.word 0xf940e400
.word 0xf9001fa0

adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x0, [x16, #520]
bl _p_11
.word 0xf9401fa1
.word 0xf9001ba0
bl _p_23
.word 0xf9401ba0
bl _p_29
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_get_Count
System_Array_InternalArray__ICollection_get_Count:
.file 2 "/Library/Frameworks/Xamarin.iOS.framework/Versions/10.8.0.175/src/mono/mcs/class/corlib/System/Array.cs"
.loc 2 68 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xb9801800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_get_IsReadOnly
System_Array_InternalArray__ICollection_get_IsReadOnly:
.loc 2 73 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd2800020
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_14:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_Clear
System_Array_InternalArray__ICollection_Clear:
.loc 2 83 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd29e7300
.word 0xf2a00020
bl _p_30
.word 0xaa0003e1
.word 0xd2802e40
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_15:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_Add_T_REF_T_REF
System_Array_InternalArray__ICollection_Add_T_REF_T_REF:
.loc 2 88 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013af
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xd29e7900
.word 0xf2a00020
bl _p_30
.word 0xaa0003e1
.word 0xd2802e40
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_16:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_Remove_T_REF_T_REF
System_Array_InternalArray__ICollection_Remove_T_REF_T_REF:
.loc 2 93 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013af
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xd29e7900
.word 0xf2a00020
bl _p_30
.word 0xaa0003e1
.word 0xd2802e40
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_17:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_Contains_T_REF_T_REF
System_Array_InternalArray__ICollection_Contains_T_REF_T_REF:
.loc 2 98 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xf9001faf
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400320
.word 0x3940a800
.word 0xd280003e
.word 0x6b1e001f
.word 0x5400044c
.loc 2 101 0
.word 0xb9801b38
.loc 2 102 0
.word 0xd2800017
.word 0x14000016
.loc 2 104 0
.word 0xf9401fa0
bl _p_32
.word 0x93407ee0
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400016
.loc 2 105 0
.word 0xb500009a
.loc 2 106 0
.word 0xb5000196
.loc 2 107 0
.word 0xd2800020
.word 0x1400000e
.loc 2 113 0
.word 0xaa1a03e0
.word 0xaa1603e1
.word 0xf9400342
.word 0xf9402c50
.word 0xd63f0200
.word 0x53001c00
.word 0x34000060
.loc 2 114 0
.word 0xd2800020
.word 0x14000005
.loc 2 102 0
.word 0x110006f7
.word 0x6b1802ff
.word 0x54fffd4b
.loc 2 118 0
.word 0xd2800000
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 2 99 0
.word 0xd29e8080
.word 0xf2a00020
bl _p_30
bl _p_33
.word 0xaa0003e1
.word 0xd2802fe0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31

Lme_18:
.text
	.align 4
	.no_dead_strip System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int
System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int:
.loc 2 123 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xf90027af
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa
.word 0xb4000879
.loc 2 128 0
.word 0xf9400300
.word 0x3940a800
.word 0xd280003e
.word 0x6b1e001f
.word 0x540008ac
.loc 2 130 0
.word 0xaa1a03f7
.word 0xaa1803f6
.word 0xf9400b15
.word 0xeb1f02bf
.word 0x54000060
.word 0xb98002b5
.word 0x14000002
.word 0xb9801ad5
.word 0xb1502f6
.word 0xf9400b37
.word 0xeb1f02ff
.word 0x54000060
.word 0xb98006f7
.word 0x14000002
.word 0xd2800017
.word 0xaa1903f5
.word 0xf9400b34
.word 0xeb1f029f
.word 0x54000060
.word 0xb9800294
.word 0x14000002
.word 0xb9801ab4
.word 0xb1402e0
.word 0x6b0002df
.word 0x540006ac
.loc 2 134 0
.word 0xf9400320
.word 0x3940a800
.word 0xd280003e
.word 0x6b1e001f
.word 0x5400070c
.loc 2 136 0
.word 0x6b1f035f
.word 0x540007eb
.loc 2 140 0
.word 0xaa1803f7
.word 0xf9400b16
.word 0xeb1f02df
.word 0x54000060
.word 0xb98006d6
.word 0x14000002
.word 0xd2800016
.word 0xaa1903f5
.word 0xaa1a03f9
.word 0xaa1803fa
.word 0xf9400b14
.word 0xeb1f029f
.word 0x54000060
.word 0xb9800298
.word 0x14000002
.word 0xb9801b58
.word 0xaa1703e0
.word 0xaa1603e1
.word 0xaa1503e2
.word 0xaa1903e3
.word 0xaa1803e4
bl _p_34
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.loc 2 124 0
.word 0xd285a1a0
bl _p_30
.word 0xaa0003e1
.word 0xd2800b20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.loc 2 129 0
.word 0xd29e8080
.word 0xf2a00020
bl _p_30
bl _p_33
.word 0xaa0003e1
.word 0xd2802fe0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.loc 2 131 0
.word 0xd29e8b80
.word 0xf2a00020
bl _p_30
.word 0xaa0003e1
.word 0xd2800b00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.loc 2 135 0
.word 0xd29e8080
.word 0xf2a00020
bl _p_30
bl _p_33
.word 0xaa0003e1
.word 0xd2802fe0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_31
.loc 2 137 0
.word 0xd284d200
bl _p_30
.word 0xf9002ba0
.word 0xd29ea3e0
.word 0xf2a00020
bl _p_30
bl _p_33
.word 0xaa0003e2
.word 0xf9402ba1
.word 0xd2800b40
.word 0xf2a04000
bl _mono_create_corlib_exception_2
bl _p_31

Lme_19:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl MobFoxDemoXM_App__ctor
bl MobFoxDemoXM_App_OnStart
bl MobFoxDemoXM_App_OnSleep
bl MobFoxDemoXM_App_OnResume
bl MobFoxDemoXM_App_InitializeComponent
bl MobFoxDemoXM_MobFoxDemoXMPage__ctor
bl MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent
bl MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
bl MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs
bl method_addresses
bl System_Array_InternalArray__ICollection_get_Count
bl System_Array_InternalArray__ICollection_get_IsReadOnly
bl System_Array_InternalArray__ICollection_Clear
bl System_Array_InternalArray__ICollection_Add_T_REF_T_REF
bl System_Array_InternalArray__ICollection_Remove_T_REF_T_REF
bl System_Array_InternalArray__ICollection_Contains_T_REF_T_REF
bl System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int
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

	.byte 13,12,31,0,68,14,48,157,6,158,5,68,13,29,13,12,31,0,68,14,32,157,4,158,3,68,13,29,18,12,31,0
	.byte 68,14,96,157,12,158,11,68,13,29,68,153,10,154,9,16,12,31,0,68,14,64,157,8,158,7,68,13,29,68,154,6
	.byte 16,12,31,0,68,14,48,157,6,158,5,68,13,29,68,154,4,22,12,31,0,68,14,176,1,157,22,158,21,68,13,29
	.byte 68,152,20,153,19,68,154,18,13,12,31,0,68,14,64,157,8,158,7,68,13,29,26,12,31,0,68,14,64,157,8,158
	.byte 7,68,13,29,68,150,6,151,5,68,152,4,153,3,68,154,2,31,12,31,0,68,14,96,157,12,158,11,68,13,29,68
	.byte 148,10,149,9,68,150,8,151,7,68,152,6,153,5,68,154,4

.text
	.align 4
plt:
mono_aot_MobFoxDemoXM_plt:
	.no_dead_strip plt_Xamarin_Forms_Application__ctor
plt_Xamarin_Forms_Application__ctor:
_p_1:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #544]
br x16
.word 806
	.no_dead_strip plt_MobFoxDemoXM_App_InitializeComponent
plt_MobFoxDemoXM_App_InitializeComponent:
_p_2:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #552]
br x16
.word 811
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_3:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #560]
br x16
.word 816
	.no_dead_strip plt_MobFoxDemoXM_MobFoxDemoXMPage__ctor
plt_MobFoxDemoXM_MobFoxDemoXMPage__ctor:
_p_4:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #568]
br x16
.word 848
	.no_dead_strip plt_Xamarin_Forms_Application_set_MainPage_Xamarin_Forms_Page
plt_Xamarin_Forms_Application_set_MainPage_Xamarin_Forms_Page:
_p_5:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #576]
br x16
.word 853
	.no_dead_strip plt_Xamarin_Forms_Xaml_Extensions_LoadFromXaml_MobFoxDemoXM_App_MobFoxDemoXM_App_System_Type
plt_Xamarin_Forms_Xaml_Extensions_LoadFromXaml_MobFoxDemoXM_App_MobFoxDemoXM_App_System_Type:
_p_6:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #584]
br x16
.word 858
	.no_dead_strip plt_wrapper_write_barrier_object_wbarrier_conc_intptr
plt_wrapper_write_barrier_object_wbarrier_conc_intptr:
_p_7:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #592]
br x16
.word 870
	.no_dead_strip plt_Xamarin_Forms_ContentPage__ctor
plt_Xamarin_Forms_ContentPage__ctor:
_p_8:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #600]
br x16
.word 877
	.no_dead_strip plt_MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent
plt_MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent:
_p_9:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #608]
br x16
.word 882
	.no_dead_strip plt_Plugin_MobFoxAds_CrossMobFoxAds_get_Current
plt_Plugin_MobFoxAds_CrossMobFoxAds_get_Current:
_p_10:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #616]
br x16
.word 887
	.no_dead_strip plt__jit_icall_ves_icall_object_new_fast
plt__jit_icall_ves_icall_object_new_fast:
_p_11:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #624]
br x16
.word 892
	.no_dead_strip plt_Xamarin_Forms_TapGestureRecognizer__ctor
plt_Xamarin_Forms_TapGestureRecognizer__ctor:
_p_12:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #632]
br x16
.word 920
	.no_dead_strip plt_Xamarin_Forms_TapGestureRecognizer_add_Tapped_System_EventHandler
plt_Xamarin_Forms_TapGestureRecognizer_add_Tapped_System_EventHandler:
_p_13:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #640]
br x16
.word 925
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_14:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #648]
br x16
.word 930
	.no_dead_strip plt_Xamarin_Forms_Xaml_Extensions_LoadFromXaml_MobFoxDemoXM_MobFoxDemoXMPage_MobFoxDemoXM_MobFoxDemoXMPage_System_Type
plt_Xamarin_Forms_Xaml_Extensions_LoadFromXaml_MobFoxDemoXM_MobFoxDemoXMPage_MobFoxDemoXM_MobFoxDemoXMPage_System_Type:
_p_15:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #656]
br x16
.word 965
	.no_dead_strip plt_Xamarin_Forms_NameScopeExtensions_FindByName_Xamarin_Forms_Image_Xamarin_Forms_Element_string
plt_Xamarin_Forms_NameScopeExtensions_FindByName_Xamarin_Forms_Image_Xamarin_Forms_Element_string:
_p_16:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #664]
br x16
.word 977
	.no_dead_strip plt_Xamarin_Forms_NameScopeExtensions_FindByName_Xamarin_Forms_Label_Xamarin_Forms_Element_string
plt_Xamarin_Forms_NameScopeExtensions_FindByName_Xamarin_Forms_Label_Xamarin_Forms_Element_string:
_p_17:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #672]
br x16
.word 989
	.no_dead_strip plt_string_Concat_string_string_string_string
plt_string_Concat_string_string_string_string:
_p_18:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #680]
br x16
.word 1001
	.no_dead_strip plt_string_Equals_string
plt_string_Equals_string:
_p_19:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #688]
br x16
.word 1004
	.no_dead_strip plt_Xamarin_Forms_Label_set_Text_string
plt_Xamarin_Forms_Label_set_Text_string:
_p_20:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #696]
br x16
.word 1007
	.no_dead_strip plt__jit_icall_mono_generic_class_init
plt__jit_icall_mono_generic_class_init:
_p_21:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #704]
br x16
.word 1012
	.no_dead_strip plt_Xamarin_Forms_UriImageSource__ctor
plt_Xamarin_Forms_UriImageSource__ctor:
_p_22:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #712]
br x16
.word 1038
	.no_dead_strip plt_System_Uri__ctor_string
plt_System_Uri__ctor_string:
_p_23:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #720]
br x16
.word 1043
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_Uri_System_Uri
plt_Xamarin_Forms_UriImageSource_set_Uri_System_Uri:
_p_24:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #728]
br x16
.word 1048
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_CachingEnabled_bool
plt_Xamarin_Forms_UriImageSource_set_CachingEnabled_bool:
_p_25:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #736]
br x16
.word 1053
	.no_dead_strip plt_System_TimeSpan__ctor_int_int_int_int
plt_System_TimeSpan__ctor_int_int_int_int:
_p_26:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #744]
br x16
.word 1058
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_CacheValidity_System_TimeSpan
plt_Xamarin_Forms_UriImageSource_set_CacheValidity_System_TimeSpan:
_p_27:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #752]
br x16
.word 1061
	.no_dead_strip plt_Xamarin_Forms_Image_set_Source_Xamarin_Forms_ImageSource
plt_Xamarin_Forms_Image_set_Source_Xamarin_Forms_ImageSource:
_p_28:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #760]
br x16
.word 1066
	.no_dead_strip plt_Xamarin_Forms_Device_OpenUri_System_Uri
plt_Xamarin_Forms_Device_OpenUri_System_Uri:
_p_29:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #768]
br x16
.word 1071
	.no_dead_strip plt__jit_icall_mono_helper_ldstr_mscorlib
plt__jit_icall_mono_helper_ldstr_mscorlib:
_p_30:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #776]
br x16
.word 1076
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_31:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #784]
br x16
.word 1105
	.no_dead_strip plt__rgctx_fetch_0
plt__rgctx_fetch_0:
_p_32:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #792]
br x16
.word 1151
	.no_dead_strip plt_Locale_GetText_string
plt_Locale_GetText_string:
_p_33:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #800]
br x16
.word 1174
	.no_dead_strip plt_System_Array_Copy_System_Array_int_System_Array_int_int
plt_System_Array_Copy_System_Array_int_System_Array_int_int:
_p_34:
adrp x16, mono_aot_MobFoxDemoXM_got@PAGE+0
add x16, x16, mono_aot_MobFoxDemoXM_got@PAGEOFF
ldr x16, [x16, #808]
br x16
.word 1176
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_MobFoxDemoXM_got, 816
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
	.asciz "4FD57D0E-E54B-4A06-A1D5-55C9114B35D9"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "MobFoxDemoXM"
.data
	.align 3
_mono_aot_file_info:

	.long 137,0
	.align 3
	.quad mono_aot_MobFoxDemoXM_got
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

	.long 67,816,35,26,66,923871743,0,1802
	.long 128,8,8,10,0,15,2920,1112
	.long 520,264,0,432,496,320,0,200
	.long 56,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 32,135,99,246,203,21,77,114,172,31,208,178,103,43,37,100
	.globl _mono_aot_module_MobFoxDemoXM_info
	.align 3
_mono_aot_module_MobFoxDemoXM_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_4:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_7:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM6=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM7=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_6:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM10=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM11=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 2,35,16,0,7
	.asciz "System_Int32"

LDIFF_SYM12=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM12
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM13=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM14=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_5:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM15=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM16=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM17=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM17
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM18=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM18
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM19=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM19
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM20=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM21=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM22=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM22
LTDIE_8:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM23=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM24=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM25=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM26=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM27=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_14:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 16,16
LDIFF_SYM28=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM29=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM29
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM30=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM30
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM31=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM31
LTDIE_13:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 16,16
LDIFF_SYM32=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM33=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM34=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM35=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_12:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 16,16
LDIFF_SYM36=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM37=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM37
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM38=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM38
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM39=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM39
LTDIE_16:

	.byte 5
	.asciz "System_Type"

	.byte 24,16
LDIFF_SYM40=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM41=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 2,35,16,0,7
	.asciz "System_Type"

LDIFF_SYM42=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM43=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM44=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_15:

	.byte 5
	.asciz "System_DelegateData"

	.byte 40,16
LDIFF_SYM45=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM46=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,35,16,6
	.asciz "method_name"

LDIFF_SYM47=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,24,6
	.asciz "curried_first_arg"

LDIFF_SYM48=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2,35,32,0,7
	.asciz "System_DelegateData"

LDIFF_SYM49=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM50=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM50
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM51=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM51
LTDIE_11:

	.byte 5
	.asciz "System_Delegate"

	.byte 104,16
LDIFF_SYM52=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM53=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,35,16,6
	.asciz "invoke_impl"

LDIFF_SYM54=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM54
	.byte 2,35,24,6
	.asciz "m_target"

LDIFF_SYM55=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM55
	.byte 2,35,32,6
	.asciz "method"

LDIFF_SYM56=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,40,6
	.asciz "delegate_trampoline"

LDIFF_SYM57=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,35,48,6
	.asciz "extra_arg"

LDIFF_SYM58=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,56,6
	.asciz "method_code"

LDIFF_SYM59=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,35,64,6
	.asciz "method_info"

LDIFF_SYM60=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,72,6
	.asciz "original_method_info"

LDIFF_SYM61=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,80,6
	.asciz "data"

LDIFF_SYM62=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,35,88,6
	.asciz "method_is_virtual"

LDIFF_SYM63=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2,35,96,0,7
	.asciz "System_Delegate"

LDIFF_SYM64=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM64
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM65=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM65
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM66=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_10:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 112,16
LDIFF_SYM67=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM68=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,35,104,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM69=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM69
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM70=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM71=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_9:

	.byte 5
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

	.byte 112,16
LDIFF_SYM72=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,35,0,0,7
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

LDIFF_SYM73=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM73
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM74=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM74
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM75=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_17:

	.byte 5
	.asciz "System_EventHandler"

	.byte 112,16
LDIFF_SYM76=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,35,0,0,7
	.asciz "System_EventHandler"

LDIFF_SYM77=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM77
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM78=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM78
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM79=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM79
LTDIE_18:

	.byte 5
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

	.byte 112,16
LDIFF_SYM80=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

LDIFF_SYM81=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM81
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM82=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM82
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM83=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM83
LTDIE_3:

	.byte 5
	.asciz "Xamarin_Forms_BindableObject"

	.byte 64,16
LDIFF_SYM84=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,35,0,6
	.asciz "_properties"

LDIFF_SYM85=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,35,16,6
	.asciz "_applying"

LDIFF_SYM86=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM86
	.byte 2,35,56,6
	.asciz "_inheritedContext"

LDIFF_SYM87=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,35,24,6
	.asciz "PropertyChanged"

LDIFF_SYM88=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,35,32,6
	.asciz "BindingContextChanged"

LDIFF_SYM89=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,35,40,6
	.asciz "PropertyChanging"

LDIFF_SYM90=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,48,0,7
	.asciz "Xamarin_Forms_BindableObject"

LDIFF_SYM91=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM91
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM92=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM92
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM93=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM93
LTDIE_19:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM94=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM94
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM95=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM95
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM96=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM96
LTDIE_20:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM97=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM98=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM99=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM100=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM101=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM101
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM102=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM102
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM103=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM103
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM104=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM104
LTDIE_21:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM105=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM105
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM106=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM106
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM107=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM108=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM109=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM109
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM110=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM111=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM111
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM112=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM112
LTDIE_22:

	.byte 17
	.asciz "Xamarin_Forms_IEffectControlProvider"

	.byte 16,7
	.asciz "Xamarin_Forms_IEffectControlProvider"

LDIFF_SYM113=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM113
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM114=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM115=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM115
LTDIE_26:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM116=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM116
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM117=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM117
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM118=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM118
LTDIE_25:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 32,16
LDIFF_SYM119=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM120=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2,35,16,6
	.asciz "_syncRoot"

LDIFF_SYM121=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM122=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM122
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM123=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM123
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM124=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM124
LTDIE_27:

	.byte 5
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

	.byte 112,16
LDIFF_SYM125=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 2,35,0,0,7
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

LDIFF_SYM126=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM126
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM127=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM127
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM128=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM128
LTDIE_28:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 20,16
LDIFF_SYM129=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM130=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 2,35,16,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM131=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM131
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM132=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM132
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM133=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM133
LTDIE_24:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 56,16
LDIFF_SYM134=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 2,35,0,6
	.asciz "CollectionChanged"

LDIFF_SYM135=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM135
	.byte 2,35,32,6
	.asciz "PropertyChanged"

LDIFF_SYM136=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,35,40,6
	.asciz "_monitor"

LDIFF_SYM137=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,35,48,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM138=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM138
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM139=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM139
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM140=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM140
LTDIE_23:

	.byte 5
	.asciz "Xamarin_Forms_TrackableCollection`1"

	.byte 64,16
LDIFF_SYM141=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 2,35,0,6
	.asciz "Clearing"

LDIFF_SYM142=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,35,56,0,7
	.asciz "Xamarin_Forms_TrackableCollection`1"

LDIFF_SYM143=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM143
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM144=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM144
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM145=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM145
LTDIE_29:

	.byte 17
	.asciz "Xamarin_Forms_IPlatform"

	.byte 16,7
	.asciz "Xamarin_Forms_IPlatform"

LDIFF_SYM146=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM147=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM147
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM148=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM148
LTDIE_30:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM149=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM150=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM150
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM151=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM151
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM152=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM152
LTDIE_2:

	.byte 5
	.asciz "Xamarin_Forms_Element"

	.byte 216,1,16
LDIFF_SYM153=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,0,6
	.asciz "_automationId"

LDIFF_SYM154=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,64,6
	.asciz "_bindableResources"

LDIFF_SYM155=LTDIE_19_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM155
	.byte 2,35,72,6
	.asciz "_changeHandlers"

LDIFF_SYM156=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2,35,80,6
	.asciz "_dynamicResources"

LDIFF_SYM157=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 2,35,88,6
	.asciz "_effectControlProvider"

LDIFF_SYM158=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,35,96,6
	.asciz "_effects"

LDIFF_SYM159=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,35,104,6
	.asciz "_id"

LDIFF_SYM160=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 3,35,192,1,6
	.asciz "_parentOverride"

LDIFF_SYM161=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,35,112,6
	.asciz "_platform"

LDIFF_SYM162=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,35,120,6
	.asciz "_styleId"

LDIFF_SYM163=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 3,35,128,1,6
	.asciz "<Owned>k__BackingField"

LDIFF_SYM164=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 3,35,212,1,6
	.asciz "<RealParent>k__BackingField"

LDIFF_SYM165=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM165
	.byte 3,35,136,1,6
	.asciz "ChildAdded"

LDIFF_SYM166=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 3,35,144,1,6
	.asciz "ChildRemoved"

LDIFF_SYM167=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 3,35,152,1,6
	.asciz "DescendantAdded"

LDIFF_SYM168=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 3,35,160,1,6
	.asciz "DescendantRemoved"

LDIFF_SYM169=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM169
	.byte 3,35,168,1,6
	.asciz "ParentSet"

LDIFF_SYM170=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 3,35,176,1,6
	.asciz "PlatformSet"

LDIFF_SYM171=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 3,35,184,1,0,7
	.asciz "Xamarin_Forms_Element"

LDIFF_SYM172=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM172
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM173=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM173
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM174=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM174
LTDIE_33:

	.byte 5
	.asciz "System_Threading_Tasks_TaskScheduler"

	.byte 16,16
LDIFF_SYM175=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 2,35,0,0,7
	.asciz "System_Threading_Tasks_TaskScheduler"

LDIFF_SYM176=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM176
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM177=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM177
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM178=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM178
LTDIE_36:

	.byte 5
	.asciz "System_Threading_SynchronizationContext"

	.byte 16,16
LDIFF_SYM179=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 2,35,0,0,7
	.asciz "System_Threading_SynchronizationContext"

LDIFF_SYM180=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM180
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM181=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM181
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM182=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM182
LTDIE_39:

	.byte 5
	.asciz "System_Single"

	.byte 20,16
LDIFF_SYM183=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM184=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,35,16,0,7
	.asciz "System_Single"

LDIFF_SYM185=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM185
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM186=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM186
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM187=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM187
LTDIE_40:

	.byte 17
	.asciz "System_Collections_ICollection"

	.byte 16,7
	.asciz "System_Collections_ICollection"

LDIFF_SYM188=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM188
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM189=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM189
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM190=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM190
LTDIE_41:

	.byte 17
	.asciz "System_Collections_IEqualityComparer"

	.byte 16,7
	.asciz "System_Collections_IEqualityComparer"

LDIFF_SYM191=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM191
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM192=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM192
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM193=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM193
LTDIE_38:

	.byte 5
	.asciz "System_Collections_Hashtable"

	.byte 80,16
LDIFF_SYM194=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM195=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,35,16,6
	.asciz "count"

LDIFF_SYM196=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 2,35,56,6
	.asciz "occupancy"

LDIFF_SYM197=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 2,35,60,6
	.asciz "loadsize"

LDIFF_SYM198=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 2,35,64,6
	.asciz "loadFactor"

LDIFF_SYM199=LDIE_R4 - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 2,35,68,6
	.asciz "version"

LDIFF_SYM200=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM200
	.byte 2,35,72,6
	.asciz "isWriterInProgress"

LDIFF_SYM201=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM201
	.byte 2,35,76,6
	.asciz "keys"

LDIFF_SYM202=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM202
	.byte 2,35,24,6
	.asciz "values"

LDIFF_SYM203=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 2,35,32,6
	.asciz "_keycomparer"

LDIFF_SYM204=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 2,35,40,6
	.asciz "_syncRoot"

LDIFF_SYM205=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM205
	.byte 2,35,48,0,7
	.asciz "System_Collections_Hashtable"

LDIFF_SYM206=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM206
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM207=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM207
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM208=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM208
LTDIE_42:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

	.byte 16,16
LDIFF_SYM209=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM209
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextRemotingData"

LDIFF_SYM210=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM210
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM211=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM211
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM212=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM212
LTDIE_43:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

	.byte 16,16
LDIFF_SYM213=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM213
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_CallContextSecurityData"

LDIFF_SYM214=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM214
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM215=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM215
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM216=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM216
LTDIE_37:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

	.byte 56,16
LDIFF_SYM217=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM217
	.byte 2,35,0,6
	.asciz "m_Datastore"

LDIFF_SYM218=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM218
	.byte 2,35,16,6
	.asciz "m_RemotingData"

LDIFF_SYM219=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM219
	.byte 2,35,24,6
	.asciz "m_SecurityData"

LDIFF_SYM220=LTDIE_43_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 2,35,32,6
	.asciz "m_HostContext"

LDIFF_SYM221=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 2,35,40,6
	.asciz "m_IsCorrelationMgr"

LDIFF_SYM222=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 2,35,48,0,7
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

LDIFF_SYM223=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM223
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM224=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM224
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM225=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM225
LTDIE_44:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

	.byte 16,16
LDIFF_SYM226=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM226
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_IllogicalCallContext"

LDIFF_SYM227=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM227
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM228=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM228
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM229=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM229
LTDIE_45:

	.byte 8
	.asciz "_Flags"

	.byte 4
LDIFF_SYM230=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM230
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

LDIFF_SYM231=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM231
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM232=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM232
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM233=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM233
LTDIE_47:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM234=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM234
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM235=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM235
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM236=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM236
LTDIE_48:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM237=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM238=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM239=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM239
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM240=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM240
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM241=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM241
LTDIE_49:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM242=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM242
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM243=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM243
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM244=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM245=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM245
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM246=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_46:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM247=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM248=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM248
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM249=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM249
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM250=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM250
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM251=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM252=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM253=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM254=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM255=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM256=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM257=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM258=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM258
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM259=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM259
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM260=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM260
LTDIE_50:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM261=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM262=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM263=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM264=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM265=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM265
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM266=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM266
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM267=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM267
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM268=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM268
LTDIE_35:

	.byte 5
	.asciz "System_Threading_ExecutionContext"

	.byte 72,16
LDIFF_SYM269=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM269
	.byte 2,35,0,6
	.asciz "_syncContext"

LDIFF_SYM270=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,35,16,6
	.asciz "_syncContextNoFlow"

LDIFF_SYM271=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,35,24,6
	.asciz "_logicalCallContext"

LDIFF_SYM272=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 2,35,32,6
	.asciz "_illogicalCallContext"

LDIFF_SYM273=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM273
	.byte 2,35,40,6
	.asciz "_flags"

LDIFF_SYM274=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 2,35,64,6
	.asciz "_localValues"

LDIFF_SYM275=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 2,35,48,6
	.asciz "_localChangeNotifications"

LDIFF_SYM276=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 2,35,56,0,7
	.asciz "System_Threading_ExecutionContext"

LDIFF_SYM277=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM277
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM278=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM278
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM279=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM279
LTDIE_55:

	.byte 5
	.asciz "System_MarshalByRefObject"

	.byte 24,16
LDIFF_SYM280=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,35,0,6
	.asciz "_identity"

LDIFF_SYM281=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM281
	.byte 2,35,16,0,7
	.asciz "System_MarshalByRefObject"

LDIFF_SYM282=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM282
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM283=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM283
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM284=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM284
LTDIE_59:

	.byte 5
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

	.byte 16,16
LDIFF_SYM285=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,0,0,7
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

LDIFF_SYM286=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM286
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM287=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM287
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM288=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM288
LTDIE_58:

	.byte 5
	.asciz "System_Runtime_InteropServices_SafeHandle"

	.byte 32,16
LDIFF_SYM289=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM289
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM290=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM290
	.byte 2,35,16,6
	.asciz "_state"

LDIFF_SYM291=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2,35,24,6
	.asciz "_ownsHandle"

LDIFF_SYM292=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,35,28,6
	.asciz "_fullyInitialized"

LDIFF_SYM293=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 2,35,29,0,7
	.asciz "System_Runtime_InteropServices_SafeHandle"

LDIFF_SYM294=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM294
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM295=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM295
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM296=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM296
LTDIE_57:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

	.byte 32,16
LDIFF_SYM297=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

LDIFF_SYM298=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM298
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM299=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM299
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM300=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM300
LTDIE_56:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

	.byte 32,16
LDIFF_SYM301=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM301
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

LDIFF_SYM302=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM302
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM303=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM303
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM304=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM304
LTDIE_54:

	.byte 5
	.asciz "System_Threading_WaitHandle"

	.byte 48,16
LDIFF_SYM305=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,35,0,6
	.asciz "waitHandle"

LDIFF_SYM306=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,35,24,6
	.asciz "safeWaitHandle"

LDIFF_SYM307=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 2,35,32,6
	.asciz "hasThreadAffinity"

LDIFF_SYM308=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,35,40,0,7
	.asciz "System_Threading_WaitHandle"

LDIFF_SYM309=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM309
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM310=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM310
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM311=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM311
LTDIE_53:

	.byte 5
	.asciz "System_Threading_EventWaitHandle"

	.byte 48,16
LDIFF_SYM312=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,35,0,0,7
	.asciz "System_Threading_EventWaitHandle"

LDIFF_SYM313=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM313
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM314=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM314
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM315=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM315
LTDIE_52:

	.byte 5
	.asciz "System_Threading_ManualResetEvent"

	.byte 48,16
LDIFF_SYM316=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,35,0,0,7
	.asciz "System_Threading_ManualResetEvent"

LDIFF_SYM317=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM317
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM318=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM318
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM319=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM319
LTDIE_51:

	.byte 5
	.asciz "System_Threading_ManualResetEventSlim"

	.byte 40,16
LDIFF_SYM320=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 2,35,0,6
	.asciz "m_lock"

LDIFF_SYM321=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,35,16,6
	.asciz "m_eventObj"

LDIFF_SYM322=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 2,35,24,6
	.asciz "m_combinedState"

LDIFF_SYM323=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 2,35,32,0,7
	.asciz "System_Threading_ManualResetEventSlim"

LDIFF_SYM324=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM324
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM325=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM325
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM326=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM326
LTDIE_61:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM327=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM328=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM329=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM329
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM330=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM331=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM331
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM332=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM332
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM333=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM333
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM334=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM334
LTDIE_64:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 16,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM335=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM335
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM336=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM336
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM337=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM337
LTDIE_66:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM338=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM338
LTDIE_66_POINTER:

	.byte 13
LDIFF_SYM339=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM339
LTDIE_66_REFERENCE:

	.byte 14
LDIFF_SYM340=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM340
LTDIE_69:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM341=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM341
LTDIE_69_POINTER:

	.byte 13
LDIFF_SYM342=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM342
LTDIE_69_REFERENCE:

	.byte 14
LDIFF_SYM343=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM343
LTDIE_70:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM344=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM344
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM345=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM345
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM346=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM346
LTDIE_70_POINTER:

	.byte 13
LDIFF_SYM347=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM347
LTDIE_70_REFERENCE:

	.byte 14
LDIFF_SYM348=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM348
LTDIE_71:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM349=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM349
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM350=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM351=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM351
LTDIE_71_POINTER:

	.byte 13
LDIFF_SYM352=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM352
LTDIE_71_REFERENCE:

	.byte 14
LDIFF_SYM353=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM353
LTDIE_68:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM354=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM355=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM355
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM356=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM356
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM357=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM357
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM358=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM358
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM359=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM359
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM360=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM360
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM361=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM361
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM362=LTDIE_70_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM363=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM363
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM364=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM364
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM365=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM365
LTDIE_68_POINTER:

	.byte 13
LDIFF_SYM366=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM366
LTDIE_68_REFERENCE:

	.byte 14
LDIFF_SYM367=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM367
LTDIE_72:

	.byte 17
	.asciz "System_Runtime_Serialization_IFormatterConverter"

	.byte 16,7
	.asciz "System_Runtime_Serialization_IFormatterConverter"

LDIFF_SYM368=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM368
LTDIE_72_POINTER:

	.byte 13
LDIFF_SYM369=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM369
LTDIE_72_REFERENCE:

	.byte 14
LDIFF_SYM370=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM370
LTDIE_67:

	.byte 5
	.asciz "System_Runtime_Serialization_SerializationInfo"

	.byte 88,16
LDIFF_SYM371=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM371
	.byte 2,35,0,6
	.asciz "m_members"

LDIFF_SYM372=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM372
	.byte 2,35,16,6
	.asciz "m_data"

LDIFF_SYM373=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 2,35,24,6
	.asciz "m_types"

LDIFF_SYM374=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM374
	.byte 2,35,32,6
	.asciz "m_nameToIndex"

LDIFF_SYM375=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM375
	.byte 2,35,40,6
	.asciz "m_currMember"

LDIFF_SYM376=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM376
	.byte 2,35,80,6
	.asciz "m_converter"

LDIFF_SYM377=LTDIE_72_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,35,48,6
	.asciz "m_fullTypeName"

LDIFF_SYM378=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM378
	.byte 2,35,56,6
	.asciz "m_assemName"

LDIFF_SYM379=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM379
	.byte 2,35,64,6
	.asciz "objectType"

LDIFF_SYM380=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM380
	.byte 2,35,72,6
	.asciz "isFullTypeNameSetExplicit"

LDIFF_SYM381=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM381
	.byte 2,35,84,6
	.asciz "isAssemblyNameSetExplicit"

LDIFF_SYM382=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 2,35,85,6
	.asciz "requireSameTokenInPartialTrust"

LDIFF_SYM383=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM383
	.byte 2,35,86,0,7
	.asciz "System_Runtime_Serialization_SerializationInfo"

LDIFF_SYM384=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM384
LTDIE_67_POINTER:

	.byte 13
LDIFF_SYM385=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM385
LTDIE_67_REFERENCE:

	.byte 14
LDIFF_SYM386=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM386
LTDIE_74:

	.byte 5
	.asciz "System_Reflection_TypeInfo"

	.byte 24,16
LDIFF_SYM387=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM387
	.byte 2,35,0,0,7
	.asciz "System_Reflection_TypeInfo"

LDIFF_SYM388=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM388
LTDIE_74_POINTER:

	.byte 13
LDIFF_SYM389=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM389
LTDIE_74_REFERENCE:

	.byte 14
LDIFF_SYM390=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM390
LTDIE_78:

	.byte 5
	.asciz "System_Reflection_ConstructorInfo"

	.byte 16,16
LDIFF_SYM391=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,0,0,7
	.asciz "System_Reflection_ConstructorInfo"

LDIFF_SYM392=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM392
LTDIE_78_POINTER:

	.byte 13
LDIFF_SYM393=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM393
LTDIE_78_REFERENCE:

	.byte 14
LDIFF_SYM394=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM394
LTDIE_77:

	.byte 5
	.asciz "System_Reflection_RuntimeConstructorInfo"

	.byte 16,16
LDIFF_SYM395=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM395
	.byte 2,35,0,0,7
	.asciz "System_Reflection_RuntimeConstructorInfo"

LDIFF_SYM396=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM396
LTDIE_77_POINTER:

	.byte 13
LDIFF_SYM397=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM397
LTDIE_77_REFERENCE:

	.byte 14
LDIFF_SYM398=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM398
LTDIE_76:

	.byte 5
	.asciz "System_Reflection_MonoCMethod"

	.byte 40,16
LDIFF_SYM399=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM399
	.byte 2,35,0,6
	.asciz "mhandle"

LDIFF_SYM400=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM400
	.byte 2,35,16,6
	.asciz "name"

LDIFF_SYM401=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM401
	.byte 2,35,24,6
	.asciz "reftype"

LDIFF_SYM402=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM402
	.byte 2,35,32,0,7
	.asciz "System_Reflection_MonoCMethod"

LDIFF_SYM403=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM403
LTDIE_76_POINTER:

	.byte 13
LDIFF_SYM404=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM404
LTDIE_76_REFERENCE:

	.byte 14
LDIFF_SYM405=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM405
LTDIE_75:

	.byte 5
	.asciz "System_MonoTypeInfo"

	.byte 32,16
LDIFF_SYM406=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,0,6
	.asciz "full_name"

LDIFF_SYM407=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,35,16,6
	.asciz "default_ctor"

LDIFF_SYM408=LTDIE_76_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 2,35,24,0,7
	.asciz "System_MonoTypeInfo"

LDIFF_SYM409=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM409
LTDIE_75_POINTER:

	.byte 13
LDIFF_SYM410=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM410
LTDIE_75_REFERENCE:

	.byte 14
LDIFF_SYM411=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM411
LTDIE_73:

	.byte 5
	.asciz "System_RuntimeType"

	.byte 48,16
LDIFF_SYM412=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM412
	.byte 2,35,0,6
	.asciz "type_info"

LDIFF_SYM413=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM413
	.byte 2,35,24,6
	.asciz "GenericCache"

LDIFF_SYM414=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM414
	.byte 2,35,32,6
	.asciz "m_serializationCtor"

LDIFF_SYM415=LTDIE_77_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,35,40,0,7
	.asciz "System_RuntimeType"

LDIFF_SYM416=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM416
LTDIE_73_POINTER:

	.byte 13
LDIFF_SYM417=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM417
LTDIE_73_REFERENCE:

	.byte 14
LDIFF_SYM418=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM418
LTDIE_79:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM419=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM419
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM420=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM420
LTDIE_79_POINTER:

	.byte 13
LDIFF_SYM421=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM421
LTDIE_79_REFERENCE:

	.byte 14
LDIFF_SYM422=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM422
LTDIE_65:

	.byte 5
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

	.byte 56,16
LDIFF_SYM423=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM424=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,35,16,6
	.asciz "m_savedSerializationInfo"

LDIFF_SYM425=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM425
	.byte 2,35,24,6
	.asciz "m_realObject"

LDIFF_SYM426=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM426
	.byte 2,35,32,6
	.asciz "m_realType"

LDIFF_SYM427=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM427
	.byte 2,35,40,6
	.asciz "SerializeObjectState"

LDIFF_SYM428=LTDIE_79_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 2,35,48,0,7
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

LDIFF_SYM429=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM429
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM430=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM430
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM431=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM431
LTDIE_63:

	.byte 5
	.asciz "System_Exception"

	.byte 136,1,16
LDIFF_SYM432=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM432
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM433=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM433
	.byte 2,35,16,6
	.asciz "_message"

LDIFF_SYM434=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM434
	.byte 2,35,24,6
	.asciz "_data"

LDIFF_SYM435=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM435
	.byte 2,35,32,6
	.asciz "_innerException"

LDIFF_SYM436=LTDIE_63_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM436
	.byte 2,35,40,6
	.asciz "_helpURL"

LDIFF_SYM437=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM437
	.byte 2,35,48,6
	.asciz "_stackTrace"

LDIFF_SYM438=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM438
	.byte 2,35,56,6
	.asciz "_stackTraceString"

LDIFF_SYM439=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM439
	.byte 2,35,64,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM440=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 2,35,72,6
	.asciz "_remoteStackIndex"

LDIFF_SYM441=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM441
	.byte 2,35,80,6
	.asciz "_dynamicMethods"

LDIFF_SYM442=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM442
	.byte 2,35,88,6
	.asciz "_HResult"

LDIFF_SYM443=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM443
	.byte 2,35,96,6
	.asciz "_source"

LDIFF_SYM444=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM444
	.byte 2,35,104,6
	.asciz "_safeSerializationManager"

LDIFF_SYM445=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM445
	.byte 2,35,112,6
	.asciz "captured_traces"

LDIFF_SYM446=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM446
	.byte 2,35,120,6
	.asciz "native_trace_ips"

LDIFF_SYM447=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM447
	.byte 3,35,128,1,0,7
	.asciz "System_Exception"

LDIFF_SYM448=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM448
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM449=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM449
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM450=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM450
LTDIE_62:

	.byte 5
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

	.byte 32,16
LDIFF_SYM451=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM451
	.byte 2,35,0,6
	.asciz "m_Exception"

LDIFF_SYM452=LTDIE_63_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM452
	.byte 2,35,16,6
	.asciz "m_stackTrace"

LDIFF_SYM453=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM453
	.byte 2,35,24,0,7
	.asciz "System_Runtime_ExceptionServices_ExceptionDispatchInfo"

LDIFF_SYM454=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM454
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM455=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM455
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM456=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM456
LTDIE_60:

	.byte 5
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

	.byte 48,16
LDIFF_SYM457=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM457
	.byte 2,35,0,6
	.asciz "m_task"

LDIFF_SYM458=LTDIE_32_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM458
	.byte 2,35,16,6
	.asciz "m_faultExceptions"

LDIFF_SYM459=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM459
	.byte 2,35,24,6
	.asciz "m_cancellationException"

LDIFF_SYM460=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM460
	.byte 2,35,32,6
	.asciz "m_isHandled"

LDIFF_SYM461=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 2,35,40,0,7
	.asciz "System_Threading_Tasks_TaskExceptionHolder"

LDIFF_SYM462=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM462
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM463=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM463
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM464=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM464
LTDIE_80:

	.byte 5
	.asciz "System_Threading_Tasks_Shared`1"

	.byte 40,16
LDIFF_SYM465=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM465
	.byte 2,35,0,6
	.asciz "Value"

LDIFF_SYM466=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM466
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_Shared`1"

LDIFF_SYM467=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM467
LTDIE_80_POINTER:

	.byte 13
LDIFF_SYM468=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM468
LTDIE_80_REFERENCE:

	.byte 14
LDIFF_SYM469=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM469
LTDIE_81:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM470=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM470
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM471=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM471
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM472=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM472
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM473=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM474=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM475=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM475
LTDIE_81_POINTER:

	.byte 13
LDIFF_SYM476=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM476
LTDIE_81_REFERENCE:

	.byte 14
LDIFF_SYM477=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM477
LTDIE_34:

	.byte 5
	.asciz "_ContingentProperties"

	.byte 72,16
LDIFF_SYM478=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 2,35,0,6
	.asciz "m_capturedContext"

LDIFF_SYM479=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM479
	.byte 2,35,16,6
	.asciz "m_completionEvent"

LDIFF_SYM480=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM480
	.byte 2,35,24,6
	.asciz "m_exceptionsHolder"

LDIFF_SYM481=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM481
	.byte 2,35,32,6
	.asciz "m_cancellationToken"

LDIFF_SYM482=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM482
	.byte 2,35,40,6
	.asciz "m_cancellationRegistration"

LDIFF_SYM483=LTDIE_80_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM483
	.byte 2,35,48,6
	.asciz "m_internalCancellationRequested"

LDIFF_SYM484=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM484
	.byte 2,35,64,6
	.asciz "m_completionCountdown"

LDIFF_SYM485=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM485
	.byte 2,35,68,6
	.asciz "m_exceptionalChildren"

LDIFF_SYM486=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,35,56,0,7
	.asciz "_ContingentProperties"

LDIFF_SYM487=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM487
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM488=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM488
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM489=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM489
LTDIE_32:

	.byte 5
	.asciz "System_Threading_Tasks_Task"

	.byte 72,16
LDIFF_SYM490=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM490
	.byte 2,35,0,6
	.asciz "m_taskId"

LDIFF_SYM491=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM491
	.byte 2,35,64,6
	.asciz "m_action"

LDIFF_SYM492=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM492
	.byte 2,35,16,6
	.asciz "m_stateObject"

LDIFF_SYM493=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM493
	.byte 2,35,24,6
	.asciz "m_taskScheduler"

LDIFF_SYM494=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 2,35,32,6
	.asciz "m_parent"

LDIFF_SYM495=LTDIE_32_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 2,35,40,6
	.asciz "m_stateFlags"

LDIFF_SYM496=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM496
	.byte 2,35,68,6
	.asciz "m_continuationObject"

LDIFF_SYM497=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM497
	.byte 2,35,48,6
	.asciz "m_contingentProperties"

LDIFF_SYM498=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM498
	.byte 2,35,56,0,7
	.asciz "System_Threading_Tasks_Task"

LDIFF_SYM499=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM499
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM500=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM500
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM501=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM501
LTDIE_82:

	.byte 17
	.asciz "System_Collections_Generic_IDictionary`2"

	.byte 16,7
	.asciz "System_Collections_Generic_IDictionary`2"

LDIFF_SYM502=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM502
LTDIE_82_POINTER:

	.byte 13
LDIFF_SYM503=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM503
LTDIE_82_REFERENCE:

	.byte 14
LDIFF_SYM504=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM504
LTDIE_31:

	.byte 5
	.asciz "System_Threading_Tasks_Task`1"

	.byte 80,16
LDIFF_SYM505=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM505
	.byte 2,35,0,6
	.asciz "m_result"

LDIFF_SYM506=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM506
	.byte 2,35,72,0,7
	.asciz "System_Threading_Tasks_Task`1"

LDIFF_SYM507=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM507
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM508=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM508
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM509=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM509
LTDIE_84:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM510=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM510
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM511=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM511
LTDIE_84_POINTER:

	.byte 13
LDIFF_SYM512=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM512
LTDIE_84_REFERENCE:

	.byte 14
LDIFF_SYM513=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM513
LTDIE_83:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 40,16
LDIFF_SYM514=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM514
	.byte 2,35,0,6
	.asciz "m_boxed"

LDIFF_SYM515=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM515
	.byte 2,35,16,6
	.asciz "m_valueFactory"

LDIFF_SYM516=LTDIE_84_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM516
	.byte 2,35,24,6
	.asciz "m_threadSafeObj"

LDIFF_SYM517=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM517
	.byte 2,35,32,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM518=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM518
LTDIE_83_POINTER:

	.byte 13
LDIFF_SYM519=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM519
LTDIE_83_REFERENCE:

	.byte 14
LDIFF_SYM520=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM520
LTDIE_85:

	.byte 17
	.asciz "Xamarin_Forms_IAppIndexingProvider"

	.byte 16,7
	.asciz "Xamarin_Forms_IAppIndexingProvider"

LDIFF_SYM521=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM521
LTDIE_85_POINTER:

	.byte 13
LDIFF_SYM522=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM522
LTDIE_85_REFERENCE:

	.byte 14
LDIFF_SYM523=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM523
LTDIE_87:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM524=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM524
LTDIE_87_POINTER:

	.byte 13
LDIFF_SYM525=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM525
LTDIE_87_REFERENCE:

	.byte 14
LDIFF_SYM526=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM526
LTDIE_86:

	.byte 5
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

	.byte 32,16
LDIFF_SYM527=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM527
	.byte 2,35,0,6
	.asciz "list"

LDIFF_SYM528=LTDIE_87_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM528
	.byte 2,35,16,6
	.asciz "_syncRoot"

LDIFF_SYM529=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM529
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

LDIFF_SYM530=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM530
LTDIE_86_POINTER:

	.byte 13
LDIFF_SYM531=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM531
LTDIE_86_REFERENCE:

	.byte 14
LDIFF_SYM532=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM532
LTDIE_91:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM533=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM533
LTDIE_91_POINTER:

	.byte 13
LDIFF_SYM534=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM534
LTDIE_91_REFERENCE:

	.byte 14
LDIFF_SYM535=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM535
LTDIE_92:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM536=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM536
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM537=LTDIE_90_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM537
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM538=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM538
LTDIE_92_POINTER:

	.byte 13
LDIFF_SYM539=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM539
LTDIE_92_REFERENCE:

	.byte 14
LDIFF_SYM540=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM540
LTDIE_93:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM541=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM541
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM542=LTDIE_90_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM542
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM543=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM543
LTDIE_93_POINTER:

	.byte 13
LDIFF_SYM544=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM544
LTDIE_93_REFERENCE:

	.byte 14
LDIFF_SYM545=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM545
LTDIE_90:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM546=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM546
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM547=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM547
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM548=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM548
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM549=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM549
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM550=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM550
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM551=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM551
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM552=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM552
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM553=LTDIE_91_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM553
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM554=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM554
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM555=LTDIE_93_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM555
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM556=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM557=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM557
LTDIE_90_POINTER:

	.byte 13
LDIFF_SYM558=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM558
LTDIE_90_REFERENCE:

	.byte 14
LDIFF_SYM559=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM559
LTDIE_95:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM560=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM560
LTDIE_95_POINTER:

	.byte 13
LDIFF_SYM561=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM561
LTDIE_95_REFERENCE:

	.byte 14
LDIFF_SYM562=LTDIE_95 - Ldebug_info_start
	.long LDIFF_SYM562
LTDIE_96:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 40,16
LDIFF_SYM563=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM563
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM564=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 2,35,16,6
	.asciz "_size"

LDIFF_SYM565=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM565
	.byte 2,35,32,6
	.asciz "_version"

LDIFF_SYM566=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM566
	.byte 2,35,36,6
	.asciz "_syncRoot"

LDIFF_SYM567=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,35,24,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM568=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM568
LTDIE_96_POINTER:

	.byte 13
LDIFF_SYM569=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM569
LTDIE_96_REFERENCE:

	.byte 14
LDIFF_SYM570=LTDIE_96 - Ldebug_info_start
	.long LDIFF_SYM570
LTDIE_97:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM571=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM571
LTDIE_97_POINTER:

	.byte 13
LDIFF_SYM572=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM572
LTDIE_97_REFERENCE:

	.byte 14
LDIFF_SYM573=LTDIE_97 - Ldebug_info_start
	.long LDIFF_SYM573
LTDIE_98:

	.byte 17
	.asciz "Xamarin_Forms_IStyle"

	.byte 16,7
	.asciz "Xamarin_Forms_IStyle"

LDIFF_SYM574=LTDIE_98 - Ldebug_info_start
	.long LDIFF_SYM574
LTDIE_98_POINTER:

	.byte 13
LDIFF_SYM575=LTDIE_98 - Ldebug_info_start
	.long LDIFF_SYM575
LTDIE_98_REFERENCE:

	.byte 14
LDIFF_SYM576=LTDIE_98 - Ldebug_info_start
	.long LDIFF_SYM576
LTDIE_99:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM577=LTDIE_99 - Ldebug_info_start
	.long LDIFF_SYM577
LTDIE_99_POINTER:

	.byte 13
LDIFF_SYM578=LTDIE_99 - Ldebug_info_start
	.long LDIFF_SYM578
LTDIE_99_REFERENCE:

	.byte 14
LDIFF_SYM579=LTDIE_99 - Ldebug_info_start
	.long LDIFF_SYM579
LTDIE_94:

	.byte 5
	.asciz "_MergedStyle"

	.byte 80,16
LDIFF_SYM580=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM580
	.byte 2,35,0,6
	.asciz "_classStyleProperties"

LDIFF_SYM581=LTDIE_95_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM581
	.byte 2,35,16,6
	.asciz "_implicitStyles"

LDIFF_SYM582=LTDIE_96_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM582
	.byte 2,35,24,6
	.asciz "_classStyles"

LDIFF_SYM583=LTDIE_97_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM583
	.byte 2,35,32,6
	.asciz "_implicitStyle"

LDIFF_SYM584=LTDIE_98_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM584
	.byte 2,35,40,6
	.asciz "_style"

LDIFF_SYM585=LTDIE_98_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM585
	.byte 2,35,48,6
	.asciz "_styleClass"

LDIFF_SYM586=LTDIE_99_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM586
	.byte 2,35,56,6
	.asciz "<Target>k__BackingField"

LDIFF_SYM587=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM587
	.byte 2,35,64,6
	.asciz "<TargetType>k__BackingField"

LDIFF_SYM588=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM588
	.byte 2,35,72,0,7
	.asciz "_MergedStyle"

LDIFF_SYM589=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM589
LTDIE_94_POINTER:

	.byte 13
LDIFF_SYM590=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM590
LTDIE_94_REFERENCE:

	.byte 14
LDIFF_SYM591=LTDIE_94 - Ldebug_info_start
	.long LDIFF_SYM591
LTDIE_100:

	.byte 8
	.asciz "Xamarin_Forms_LayoutConstraint"

	.byte 4
LDIFF_SYM592=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM592
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "HorizontallyFixed"

	.byte 1,9
	.asciz "VerticallyFixed"

	.byte 2,9
	.asciz "Fixed"

	.byte 3,0,7
	.asciz "Xamarin_Forms_LayoutConstraint"

LDIFF_SYM593=LTDIE_100 - Ldebug_info_start
	.long LDIFF_SYM593
LTDIE_100_POINTER:

	.byte 13
LDIFF_SYM594=LTDIE_100 - Ldebug_info_start
	.long LDIFF_SYM594
LTDIE_100_REFERENCE:

	.byte 14
LDIFF_SYM595=LTDIE_100 - Ldebug_info_start
	.long LDIFF_SYM595
LTDIE_101:

	.byte 5
	.asciz "System_Double"

	.byte 24,16
LDIFF_SYM596=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM596
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM597=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM597
	.byte 2,35,16,0,7
	.asciz "System_Double"

LDIFF_SYM598=LTDIE_101 - Ldebug_info_start
	.long LDIFF_SYM598
LTDIE_101_POINTER:

	.byte 13
LDIFF_SYM599=LTDIE_101 - Ldebug_info_start
	.long LDIFF_SYM599
LTDIE_101_REFERENCE:

	.byte 14
LDIFF_SYM600=LTDIE_101 - Ldebug_info_start
	.long LDIFF_SYM600
LTDIE_104:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM601=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM601
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM602=LTDIE_103_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM602
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM603=LTDIE_104 - Ldebug_info_start
	.long LDIFF_SYM603
LTDIE_104_POINTER:

	.byte 13
LDIFF_SYM604=LTDIE_104 - Ldebug_info_start
	.long LDIFF_SYM604
LTDIE_104_REFERENCE:

	.byte 14
LDIFF_SYM605=LTDIE_104 - Ldebug_info_start
	.long LDIFF_SYM605
LTDIE_105:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM606=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM606
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM607=LTDIE_103_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM607
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM608=LTDIE_105 - Ldebug_info_start
	.long LDIFF_SYM608
LTDIE_105_POINTER:

	.byte 13
LDIFF_SYM609=LTDIE_105 - Ldebug_info_start
	.long LDIFF_SYM609
LTDIE_105_REFERENCE:

	.byte 14
LDIFF_SYM610=LTDIE_105 - Ldebug_info_start
	.long LDIFF_SYM610
LTDIE_103:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM611=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM611
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM612=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM613=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM614=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM614
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM615=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM615
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM616=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM617=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM618=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM618
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM619=LTDIE_104_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM619
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM620=LTDIE_105_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM620
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM621=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM622=LTDIE_103 - Ldebug_info_start
	.long LDIFF_SYM622
LTDIE_103_POINTER:

	.byte 13
LDIFF_SYM623=LTDIE_103 - Ldebug_info_start
	.long LDIFF_SYM623
LTDIE_103_REFERENCE:

	.byte 14
LDIFF_SYM624=LTDIE_103 - Ldebug_info_start
	.long LDIFF_SYM624
LTDIE_106:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM625=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM626=LTDIE_106 - Ldebug_info_start
	.long LDIFF_SYM626
LTDIE_106_POINTER:

	.byte 13
LDIFF_SYM627=LTDIE_106 - Ldebug_info_start
	.long LDIFF_SYM627
LTDIE_106_REFERENCE:

	.byte 14
LDIFF_SYM628=LTDIE_106 - Ldebug_info_start
	.long LDIFF_SYM628
LTDIE_102:

	.byte 5
	.asciz "Xamarin_Forms_ResourceDictionary"

	.byte 48,16
LDIFF_SYM629=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM629
	.byte 2,35,0,6
	.asciz "_innerDictionary"

LDIFF_SYM630=LTDIE_103_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM630
	.byte 2,35,16,6
	.asciz "_mergedWith"

LDIFF_SYM631=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM631
	.byte 2,35,24,6
	.asciz "_mergedInstance"

LDIFF_SYM632=LTDIE_102_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM632
	.byte 2,35,32,6
	.asciz "ValuesChanged"

LDIFF_SYM633=LTDIE_106_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM633
	.byte 2,35,40,0,7
	.asciz "Xamarin_Forms_ResourceDictionary"

LDIFF_SYM634=LTDIE_102 - Ldebug_info_start
	.long LDIFF_SYM634
LTDIE_102_POINTER:

	.byte 13
LDIFF_SYM635=LTDIE_102 - Ldebug_info_start
	.long LDIFF_SYM635
LTDIE_102_REFERENCE:

	.byte 14
LDIFF_SYM636=LTDIE_102 - Ldebug_info_start
	.long LDIFF_SYM636
LTDIE_107:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM637=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM637
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM638=LTDIE_107 - Ldebug_info_start
	.long LDIFF_SYM638
LTDIE_107_POINTER:

	.byte 13
LDIFF_SYM639=LTDIE_107 - Ldebug_info_start
	.long LDIFF_SYM639
LTDIE_107_REFERENCE:

	.byte 14
LDIFF_SYM640=LTDIE_107 - Ldebug_info_start
	.long LDIFF_SYM640
LTDIE_108:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM641=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM641
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM642=LTDIE_108 - Ldebug_info_start
	.long LDIFF_SYM642
LTDIE_108_POINTER:

	.byte 13
LDIFF_SYM643=LTDIE_108 - Ldebug_info_start
	.long LDIFF_SYM643
LTDIE_108_REFERENCE:

	.byte 14
LDIFF_SYM644=LTDIE_108 - Ldebug_info_start
	.long LDIFF_SYM644
LTDIE_109:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM645=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM646=LTDIE_109 - Ldebug_info_start
	.long LDIFF_SYM646
LTDIE_109_POINTER:

	.byte 13
LDIFF_SYM647=LTDIE_109 - Ldebug_info_start
	.long LDIFF_SYM647
LTDIE_109_REFERENCE:

	.byte 14
LDIFF_SYM648=LTDIE_109 - Ldebug_info_start
	.long LDIFF_SYM648
LTDIE_89:

	.byte 5
	.asciz "Xamarin_Forms_VisualElement"

	.byte 224,2,16
LDIFF_SYM649=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM649
	.byte 2,35,0,6
	.asciz "_measureCache"

LDIFF_SYM650=LTDIE_90_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM650
	.byte 3,35,216,1,6
	.asciz "_mergedStyle"

LDIFF_SYM651=LTDIE_94_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM651
	.byte 3,35,224,1,6
	.asciz "_batched"

LDIFF_SYM652=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM652
	.byte 3,35,168,2,6
	.asciz "_computedConstraint"

LDIFF_SYM653=LTDIE_100 - Ldebug_info_start
	.long LDIFF_SYM653
	.byte 3,35,172,2,6
	.asciz "_isInNativeLayout"

LDIFF_SYM654=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM654
	.byte 3,35,176,2,6
	.asciz "_isNativeStateConsistent"

LDIFF_SYM655=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM655
	.byte 3,35,177,2,6
	.asciz "_isPlatformEnabled"

LDIFF_SYM656=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM656
	.byte 3,35,178,2,6
	.asciz "_mockHeight"

LDIFF_SYM657=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM657
	.byte 3,35,184,2,6
	.asciz "_mockWidth"

LDIFF_SYM658=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM658
	.byte 3,35,192,2,6
	.asciz "_mockX"

LDIFF_SYM659=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM659
	.byte 3,35,200,2,6
	.asciz "_mockY"

LDIFF_SYM660=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM660
	.byte 3,35,208,2,6
	.asciz "_resources"

LDIFF_SYM661=LTDIE_102_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM661
	.byte 3,35,232,1,6
	.asciz "_selfConstraint"

LDIFF_SYM662=LTDIE_100 - Ldebug_info_start
	.long LDIFF_SYM662
	.byte 3,35,216,2,6
	.asciz "<DisableLayout>k__BackingField"

LDIFF_SYM663=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM663
	.byte 3,35,220,2,6
	.asciz "ChildrenReordered"

LDIFF_SYM664=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM664
	.byte 3,35,240,1,6
	.asciz "Focused"

LDIFF_SYM665=LTDIE_107_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM665
	.byte 3,35,248,1,6
	.asciz "MeasureInvalidated"

LDIFF_SYM666=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM666
	.byte 3,35,128,2,6
	.asciz "SizeChanged"

LDIFF_SYM667=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM667
	.byte 3,35,136,2,6
	.asciz "Unfocused"

LDIFF_SYM668=LTDIE_107_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM668
	.byte 3,35,144,2,6
	.asciz "BatchCommitted"

LDIFF_SYM669=LTDIE_108_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM669
	.byte 3,35,152,2,6
	.asciz "FocusChangeRequested"

LDIFF_SYM670=LTDIE_109_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM670
	.byte 3,35,160,2,0,7
	.asciz "Xamarin_Forms_VisualElement"

LDIFF_SYM671=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM671
LTDIE_89_POINTER:

	.byte 13
LDIFF_SYM672=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM672
LTDIE_89_REFERENCE:

	.byte 14
LDIFF_SYM673=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM673
LTDIE_111:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM674=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM674
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM675=LTDIE_111 - Ldebug_info_start
	.long LDIFF_SYM675
LTDIE_111_POINTER:

	.byte 13
LDIFF_SYM676=LTDIE_111 - Ldebug_info_start
	.long LDIFF_SYM676
LTDIE_111_REFERENCE:

	.byte 14
LDIFF_SYM677=LTDIE_111 - Ldebug_info_start
	.long LDIFF_SYM677
LTDIE_110:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 40,16
LDIFF_SYM678=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM678
	.byte 2,35,0,6
	.asciz "m_boxed"

LDIFF_SYM679=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM679
	.byte 2,35,16,6
	.asciz "m_valueFactory"

LDIFF_SYM680=LTDIE_111_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM680
	.byte 2,35,24,6
	.asciz "m_threadSafeObj"

LDIFF_SYM681=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM681
	.byte 2,35,32,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM682=LTDIE_110 - Ldebug_info_start
	.long LDIFF_SYM682
LTDIE_110_POINTER:

	.byte 13
LDIFF_SYM683=LTDIE_110 - Ldebug_info_start
	.long LDIFF_SYM683
LTDIE_110_REFERENCE:

	.byte 14
LDIFF_SYM684=LTDIE_110 - Ldebug_info_start
	.long LDIFF_SYM684
LTDIE_112:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM685=LTDIE_112 - Ldebug_info_start
	.long LDIFF_SYM685
LTDIE_112_POINTER:

	.byte 13
LDIFF_SYM686=LTDIE_112 - Ldebug_info_start
	.long LDIFF_SYM686
LTDIE_112_REFERENCE:

	.byte 14
LDIFF_SYM687=LTDIE_112 - Ldebug_info_start
	.long LDIFF_SYM687
LTDIE_114:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 32,16
LDIFF_SYM688=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM688
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM689=LTDIE_87_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM689
	.byte 2,35,16,6
	.asciz "_syncRoot"

LDIFF_SYM690=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM690
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM691=LTDIE_114 - Ldebug_info_start
	.long LDIFF_SYM691
LTDIE_114_POINTER:

	.byte 13
LDIFF_SYM692=LTDIE_114 - Ldebug_info_start
	.long LDIFF_SYM692
LTDIE_114_REFERENCE:

	.byte 14
LDIFF_SYM693=LTDIE_114 - Ldebug_info_start
	.long LDIFF_SYM693
LTDIE_115:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 20,16
LDIFF_SYM694=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM694
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM695=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM695
	.byte 2,35,16,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM696=LTDIE_115 - Ldebug_info_start
	.long LDIFF_SYM696
LTDIE_115_POINTER:

	.byte 13
LDIFF_SYM697=LTDIE_115 - Ldebug_info_start
	.long LDIFF_SYM697
LTDIE_115_REFERENCE:

	.byte 14
LDIFF_SYM698=LTDIE_115 - Ldebug_info_start
	.long LDIFF_SYM698
LTDIE_113:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 56,16
LDIFF_SYM699=LTDIE_114 - Ldebug_info_start
	.long LDIFF_SYM699
	.byte 2,35,0,6
	.asciz "CollectionChanged"

LDIFF_SYM700=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM700
	.byte 2,35,32,6
	.asciz "PropertyChanged"

LDIFF_SYM701=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM701
	.byte 2,35,40,6
	.asciz "_monitor"

LDIFF_SYM702=LTDIE_115_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM702
	.byte 2,35,48,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM703=LTDIE_113 - Ldebug_info_start
	.long LDIFF_SYM703
LTDIE_113_POINTER:

	.byte 13
LDIFF_SYM704=LTDIE_113 - Ldebug_info_start
	.long LDIFF_SYM704
LTDIE_113_REFERENCE:

	.byte 14
LDIFF_SYM705=LTDIE_113 - Ldebug_info_start
	.long LDIFF_SYM705
LTDIE_88:

	.byte 5
	.asciz "Xamarin_Forms_Page"

	.byte 200,3,16
LDIFF_SYM706=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM706
	.byte 2,35,0,6
	.asciz "_platformConfigurationRegistry"

LDIFF_SYM707=LTDIE_110_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM707
	.byte 3,35,224,2,6
	.asciz "_allocatedFlag"

LDIFF_SYM708=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM708
	.byte 3,35,152,3,6
	.asciz "_containerArea"

LDIFF_SYM709=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM709
	.byte 3,35,160,3,6
	.asciz "_containerAreaSet"

LDIFF_SYM710=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM710
	.byte 3,35,192,3,6
	.asciz "_hasAppeared"

LDIFF_SYM711=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM711
	.byte 3,35,193,3,6
	.asciz "_logicalChildren"

LDIFF_SYM712=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM712
	.byte 3,35,232,2,6
	.asciz "<ToolbarItems>k__BackingField"

LDIFF_SYM713=LTDIE_112_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM713
	.byte 3,35,240,2,6
	.asciz "<Xamarin.Forms.IPageController.InternalChildren>k__BackingField"

LDIFF_SYM714=LTDIE_113_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM714
	.byte 3,35,248,2,6
	.asciz "LayoutChanged"

LDIFF_SYM715=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM715
	.byte 3,35,128,3,6
	.asciz "Appearing"

LDIFF_SYM716=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM716
	.byte 3,35,136,3,6
	.asciz "Disappearing"

LDIFF_SYM717=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM717
	.byte 3,35,144,3,0,7
	.asciz "Xamarin_Forms_Page"

LDIFF_SYM718=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM718
LTDIE_88_POINTER:

	.byte 13
LDIFF_SYM719=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM719
LTDIE_88_REFERENCE:

	.byte 14
LDIFF_SYM720=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM720
LTDIE_117:

	.byte 17
	.asciz "Xamarin_Forms_INavigation"

	.byte 16,7
	.asciz "Xamarin_Forms_INavigation"

LDIFF_SYM721=LTDIE_117 - Ldebug_info_start
	.long LDIFF_SYM721
LTDIE_117_POINTER:

	.byte 13
LDIFF_SYM722=LTDIE_117 - Ldebug_info_start
	.long LDIFF_SYM722
LTDIE_117_REFERENCE:

	.byte 14
LDIFF_SYM723=LTDIE_117 - Ldebug_info_start
	.long LDIFF_SYM723
LTDIE_119:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM724=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM724
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM725=LTDIE_119 - Ldebug_info_start
	.long LDIFF_SYM725
LTDIE_119_POINTER:

	.byte 13
LDIFF_SYM726=LTDIE_119 - Ldebug_info_start
	.long LDIFF_SYM726
LTDIE_119_REFERENCE:

	.byte 14
LDIFF_SYM727=LTDIE_119 - Ldebug_info_start
	.long LDIFF_SYM727
LTDIE_118:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 40,16
LDIFF_SYM728=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM728
	.byte 2,35,0,6
	.asciz "m_boxed"

LDIFF_SYM729=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM729
	.byte 2,35,16,6
	.asciz "m_valueFactory"

LDIFF_SYM730=LTDIE_119_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM730
	.byte 2,35,24,6
	.asciz "m_threadSafeObj"

LDIFF_SYM731=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM731
	.byte 2,35,32,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM732=LTDIE_118 - Ldebug_info_start
	.long LDIFF_SYM732
LTDIE_118_POINTER:

	.byte 13
LDIFF_SYM733=LTDIE_118 - Ldebug_info_start
	.long LDIFF_SYM733
LTDIE_118_REFERENCE:

	.byte 14
LDIFF_SYM734=LTDIE_118 - Ldebug_info_start
	.long LDIFF_SYM734
LTDIE_116:

	.byte 5
	.asciz "Xamarin_Forms_NavigationProxy"

	.byte 40,16
LDIFF_SYM735=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM735
	.byte 2,35,0,6
	.asciz "_inner"

LDIFF_SYM736=LTDIE_117_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM736
	.byte 2,35,16,6
	.asciz "_modalStack"

LDIFF_SYM737=LTDIE_118_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM737
	.byte 2,35,24,6
	.asciz "_pushStack"

LDIFF_SYM738=LTDIE_118_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM738
	.byte 2,35,32,0,7
	.asciz "Xamarin_Forms_NavigationProxy"

LDIFF_SYM739=LTDIE_116 - Ldebug_info_start
	.long LDIFF_SYM739
LTDIE_116_POINTER:

	.byte 13
LDIFF_SYM740=LTDIE_116 - Ldebug_info_start
	.long LDIFF_SYM740
LTDIE_116_REFERENCE:

	.byte 14
LDIFF_SYM741=LTDIE_116 - Ldebug_info_start
	.long LDIFF_SYM741
LTDIE_120:

	.byte 17
	.asciz "Xamarin_Forms_IResourceDictionary"

	.byte 16,7
	.asciz "Xamarin_Forms_IResourceDictionary"

LDIFF_SYM742=LTDIE_120 - Ldebug_info_start
	.long LDIFF_SYM742
LTDIE_120_POINTER:

	.byte 13
LDIFF_SYM743=LTDIE_120 - Ldebug_info_start
	.long LDIFF_SYM743
LTDIE_120_REFERENCE:

	.byte 14
LDIFF_SYM744=LTDIE_120 - Ldebug_info_start
	.long LDIFF_SYM744
LTDIE_121:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM745=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM745
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM746=LTDIE_121 - Ldebug_info_start
	.long LDIFF_SYM746
LTDIE_121_POINTER:

	.byte 13
LDIFF_SYM747=LTDIE_121 - Ldebug_info_start
	.long LDIFF_SYM747
LTDIE_121_REFERENCE:

	.byte 14
LDIFF_SYM748=LTDIE_121 - Ldebug_info_start
	.long LDIFF_SYM748
LTDIE_122:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM749=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM749
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM750=LTDIE_122 - Ldebug_info_start
	.long LDIFF_SYM750
LTDIE_122_POINTER:

	.byte 13
LDIFF_SYM751=LTDIE_122 - Ldebug_info_start
	.long LDIFF_SYM751
LTDIE_122_REFERENCE:

	.byte 14
LDIFF_SYM752=LTDIE_122 - Ldebug_info_start
	.long LDIFF_SYM752
LTDIE_123:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM753=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM753
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM754=LTDIE_123 - Ldebug_info_start
	.long LDIFF_SYM754
LTDIE_123_POINTER:

	.byte 13
LDIFF_SYM755=LTDIE_123 - Ldebug_info_start
	.long LDIFF_SYM755
LTDIE_123_REFERENCE:

	.byte 14
LDIFF_SYM756=LTDIE_123 - Ldebug_info_start
	.long LDIFF_SYM756
LTDIE_124:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 112,16
LDIFF_SYM757=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM757
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM758=LTDIE_124 - Ldebug_info_start
	.long LDIFF_SYM758
LTDIE_124_POINTER:

	.byte 13
LDIFF_SYM759=LTDIE_124 - Ldebug_info_start
	.long LDIFF_SYM759
LTDIE_124_REFERENCE:

	.byte 14
LDIFF_SYM760=LTDIE_124 - Ldebug_info_start
	.long LDIFF_SYM760
LTDIE_1:

	.byte 5
	.asciz "Xamarin_Forms_Application"

	.byte 208,2,16
LDIFF_SYM761=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM761
	.byte 2,35,0,6
	.asciz "_propertiesTask"

LDIFF_SYM762=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM762
	.byte 3,35,216,1,6
	.asciz "_platformConfigurationRegistry"

LDIFF_SYM763=LTDIE_83_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM763
	.byte 3,35,224,1,6
	.asciz "_appIndexProvider"

LDIFF_SYM764=LTDIE_85_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM764
	.byte 3,35,232,1,6
	.asciz "_isSaving"

LDIFF_SYM765=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM765
	.byte 3,35,200,2,6
	.asciz "_logicalChildren"

LDIFF_SYM766=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM766
	.byte 3,35,240,1,6
	.asciz "_mainPage"

LDIFF_SYM767=LTDIE_88_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM767
	.byte 3,35,248,1,6
	.asciz "_resources"

LDIFF_SYM768=LTDIE_102_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM768
	.byte 3,35,128,2,6
	.asciz "_saveAgain"

LDIFF_SYM769=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM769
	.byte 3,35,201,2,6
	.asciz "<NavigationProxy>k__BackingField"

LDIFF_SYM770=LTDIE_116_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM770
	.byte 3,35,136,2,6
	.asciz "<PanGestureId>k__BackingField"

LDIFF_SYM771=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM771
	.byte 3,35,204,2,6
	.asciz "<SystemResources>k__BackingField"

LDIFF_SYM772=LTDIE_120_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM772
	.byte 3,35,144,2,6
	.asciz "<InternalChildren>k__BackingField"

LDIFF_SYM773=LTDIE_113_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM773
	.byte 3,35,152,2,6
	.asciz "ModalPopped"

LDIFF_SYM774=LTDIE_121_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM774
	.byte 3,35,160,2,6
	.asciz "ModalPopping"

LDIFF_SYM775=LTDIE_122_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM775
	.byte 3,35,168,2,6
	.asciz "ModalPushed"

LDIFF_SYM776=LTDIE_123_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM776
	.byte 3,35,176,2,6
	.asciz "ModalPushing"

LDIFF_SYM777=LTDIE_124_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM777
	.byte 3,35,184,2,6
	.asciz "PopCanceled"

LDIFF_SYM778=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM778
	.byte 3,35,192,2,0,7
	.asciz "Xamarin_Forms_Application"

LDIFF_SYM779=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM779
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM780=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM780
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM781=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM781
LTDIE_0:

	.byte 5
	.asciz "MobFoxDemoXM_App"

	.byte 208,2,16
LDIFF_SYM782=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM782
	.byte 2,35,0,0,7
	.asciz "MobFoxDemoXM_App"

LDIFF_SYM783=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM783
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM784=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM784
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM785=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM785
	.byte 2
	.asciz "MobFoxDemoXM.App:.ctor"
	.asciz "MobFoxDemoXM_App__ctor"

	.byte 0,0
	.quad MobFoxDemoXM_App__ctor
	.quad Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM786=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM786
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM787=Lfde0_end - Lfde0_start
	.long LDIFF_SYM787
Lfde0_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_App__ctor

LDIFF_SYM788=Lme_0 - MobFoxDemoXM_App__ctor
	.long LDIFF_SYM788
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.App:OnStart"
	.asciz "MobFoxDemoXM_App_OnStart"

	.byte 0,0
	.quad MobFoxDemoXM_App_OnStart
	.quad Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM789=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM789
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM790=Lfde1_end - Lfde1_start
	.long LDIFF_SYM790
Lfde1_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_App_OnStart

LDIFF_SYM791=Lme_1 - MobFoxDemoXM_App_OnStart
	.long LDIFF_SYM791
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.App:OnSleep"
	.asciz "MobFoxDemoXM_App_OnSleep"

	.byte 0,0
	.quad MobFoxDemoXM_App_OnSleep
	.quad Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM792=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM792
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM793=Lfde2_end - Lfde2_start
	.long LDIFF_SYM793
Lfde2_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_App_OnSleep

LDIFF_SYM794=Lme_2 - MobFoxDemoXM_App_OnSleep
	.long LDIFF_SYM794
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.App:OnResume"
	.asciz "MobFoxDemoXM_App_OnResume"

	.byte 0,0
	.quad MobFoxDemoXM_App_OnResume
	.quad Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM795=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM795
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM796=Lfde3_end - Lfde3_start
	.long LDIFF_SYM796
Lfde3_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_App_OnResume

LDIFF_SYM797=Lme_3 - MobFoxDemoXM_App_OnResume
	.long LDIFF_SYM797
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.App:InitializeComponent"
	.asciz "MobFoxDemoXM_App_InitializeComponent"

	.byte 0,0
	.quad MobFoxDemoXM_App_InitializeComponent
	.quad Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM798=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM798
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM799=Lfde4_end - Lfde4_start
	.long LDIFF_SYM799
Lfde4_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_App_InitializeComponent

LDIFF_SYM800=Lme_4 - MobFoxDemoXM_App_InitializeComponent
	.long LDIFF_SYM800
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_127:

	.byte 5
	.asciz "Xamarin_Forms_TemplatedPage"

	.byte 200,3,16
LDIFF_SYM801=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM801
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_TemplatedPage"

LDIFF_SYM802=LTDIE_127 - Ldebug_info_start
	.long LDIFF_SYM802
LTDIE_127_POINTER:

	.byte 13
LDIFF_SYM803=LTDIE_127 - Ldebug_info_start
	.long LDIFF_SYM803
LTDIE_127_REFERENCE:

	.byte 14
LDIFF_SYM804=LTDIE_127 - Ldebug_info_start
	.long LDIFF_SYM804
LTDIE_126:

	.byte 5
	.asciz "Xamarin_Forms_ContentPage"

	.byte 200,3,16
LDIFF_SYM805=LTDIE_127 - Ldebug_info_start
	.long LDIFF_SYM805
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_ContentPage"

LDIFF_SYM806=LTDIE_126 - Ldebug_info_start
	.long LDIFF_SYM806
LTDIE_126_POINTER:

	.byte 13
LDIFF_SYM807=LTDIE_126 - Ldebug_info_start
	.long LDIFF_SYM807
LTDIE_126_REFERENCE:

	.byte 14
LDIFF_SYM808=LTDIE_126 - Ldebug_info_start
	.long LDIFF_SYM808
LTDIE_132:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 16,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM809=LTDIE_132 - Ldebug_info_start
	.long LDIFF_SYM809
LTDIE_132_POINTER:

	.byte 13
LDIFF_SYM810=LTDIE_132 - Ldebug_info_start
	.long LDIFF_SYM810
LTDIE_132_REFERENCE:

	.byte 14
LDIFF_SYM811=LTDIE_132 - Ldebug_info_start
	.long LDIFF_SYM811
LTDIE_131:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 32,16
LDIFF_SYM812=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM812
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM813=LTDIE_132_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM813
	.byte 2,35,16,6
	.asciz "_syncRoot"

LDIFF_SYM814=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM814
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM815=LTDIE_131 - Ldebug_info_start
	.long LDIFF_SYM815
LTDIE_131_POINTER:

	.byte 13
LDIFF_SYM816=LTDIE_131 - Ldebug_info_start
	.long LDIFF_SYM816
LTDIE_131_REFERENCE:

	.byte 14
LDIFF_SYM817=LTDIE_131 - Ldebug_info_start
	.long LDIFF_SYM817
LTDIE_133:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 20,16
LDIFF_SYM818=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM818
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM819=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM819
	.byte 2,35,16,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM820=LTDIE_133 - Ldebug_info_start
	.long LDIFF_SYM820
LTDIE_133_POINTER:

	.byte 13
LDIFF_SYM821=LTDIE_133 - Ldebug_info_start
	.long LDIFF_SYM821
LTDIE_133_REFERENCE:

	.byte 14
LDIFF_SYM822=LTDIE_133 - Ldebug_info_start
	.long LDIFF_SYM822
LTDIE_130:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 56,16
LDIFF_SYM823=LTDIE_131 - Ldebug_info_start
	.long LDIFF_SYM823
	.byte 2,35,0,6
	.asciz "CollectionChanged"

LDIFF_SYM824=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM824
	.byte 2,35,32,6
	.asciz "PropertyChanged"

LDIFF_SYM825=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM825
	.byte 2,35,40,6
	.asciz "_monitor"

LDIFF_SYM826=LTDIE_133_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM826
	.byte 2,35,48,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM827=LTDIE_130 - Ldebug_info_start
	.long LDIFF_SYM827
LTDIE_130_POINTER:

	.byte 13
LDIFF_SYM828=LTDIE_130 - Ldebug_info_start
	.long LDIFF_SYM828
LTDIE_130_REFERENCE:

	.byte 14
LDIFF_SYM829=LTDIE_130 - Ldebug_info_start
	.long LDIFF_SYM829
LTDIE_129:

	.byte 5
	.asciz "Xamarin_Forms_View"

	.byte 232,2,16
LDIFF_SYM830=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM830
	.byte 2,35,0,6
	.asciz "_gestureRecognizers"

LDIFF_SYM831=LTDIE_130_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM831
	.byte 3,35,224,2,0,7
	.asciz "Xamarin_Forms_View"

LDIFF_SYM832=LTDIE_129 - Ldebug_info_start
	.long LDIFF_SYM832
LTDIE_129_POINTER:

	.byte 13
LDIFF_SYM833=LTDIE_129 - Ldebug_info_start
	.long LDIFF_SYM833
LTDIE_129_REFERENCE:

	.byte 14
LDIFF_SYM834=LTDIE_129 - Ldebug_info_start
	.long LDIFF_SYM834
LTDIE_135:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM835=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM835
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM836=LTDIE_135 - Ldebug_info_start
	.long LDIFF_SYM836
LTDIE_135_POINTER:

	.byte 13
LDIFF_SYM837=LTDIE_135 - Ldebug_info_start
	.long LDIFF_SYM837
LTDIE_135_REFERENCE:

	.byte 14
LDIFF_SYM838=LTDIE_135 - Ldebug_info_start
	.long LDIFF_SYM838
LTDIE_134:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 40,16
LDIFF_SYM839=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM839
	.byte 2,35,0,6
	.asciz "m_boxed"

LDIFF_SYM840=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM840
	.byte 2,35,16,6
	.asciz "m_valueFactory"

LDIFF_SYM841=LTDIE_135_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM841
	.byte 2,35,24,6
	.asciz "m_threadSafeObj"

LDIFF_SYM842=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM842
	.byte 2,35,32,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM843=LTDIE_134 - Ldebug_info_start
	.long LDIFF_SYM843
LTDIE_134_POINTER:

	.byte 13
LDIFF_SYM844=LTDIE_134 - Ldebug_info_start
	.long LDIFF_SYM844
LTDIE_134_REFERENCE:

	.byte 14
LDIFF_SYM845=LTDIE_134 - Ldebug_info_start
	.long LDIFF_SYM845
LTDIE_128:

	.byte 5
	.asciz "Xamarin_Forms_Image"

	.byte 240,2,16
LDIFF_SYM846=LTDIE_129 - Ldebug_info_start
	.long LDIFF_SYM846
	.byte 2,35,0,6
	.asciz "_platformConfigurationRegistry"

LDIFF_SYM847=LTDIE_134_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM847
	.byte 3,35,232,2,0,7
	.asciz "Xamarin_Forms_Image"

LDIFF_SYM848=LTDIE_128 - Ldebug_info_start
	.long LDIFF_SYM848
LTDIE_128_POINTER:

	.byte 13
LDIFF_SYM849=LTDIE_128 - Ldebug_info_start
	.long LDIFF_SYM849
LTDIE_128_REFERENCE:

	.byte 14
LDIFF_SYM850=LTDIE_128 - Ldebug_info_start
	.long LDIFF_SYM850
LTDIE_138:

	.byte 5
	.asciz "System_Func`1"

	.byte 112,16
LDIFF_SYM851=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM851
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM852=LTDIE_138 - Ldebug_info_start
	.long LDIFF_SYM852
LTDIE_138_POINTER:

	.byte 13
LDIFF_SYM853=LTDIE_138 - Ldebug_info_start
	.long LDIFF_SYM853
LTDIE_138_REFERENCE:

	.byte 14
LDIFF_SYM854=LTDIE_138 - Ldebug_info_start
	.long LDIFF_SYM854
LTDIE_137:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 40,16
LDIFF_SYM855=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM855
	.byte 2,35,0,6
	.asciz "m_boxed"

LDIFF_SYM856=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM856
	.byte 2,35,16,6
	.asciz "m_valueFactory"

LDIFF_SYM857=LTDIE_138_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM857
	.byte 2,35,24,6
	.asciz "m_threadSafeObj"

LDIFF_SYM858=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM858
	.byte 2,35,32,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM859=LTDIE_137 - Ldebug_info_start
	.long LDIFF_SYM859
LTDIE_137_POINTER:

	.byte 13
LDIFF_SYM860=LTDIE_137 - Ldebug_info_start
	.long LDIFF_SYM860
LTDIE_137_REFERENCE:

	.byte 14
LDIFF_SYM861=LTDIE_137 - Ldebug_info_start
	.long LDIFF_SYM861
LTDIE_136:

	.byte 5
	.asciz "Xamarin_Forms_Label"

	.byte 248,2,16
LDIFF_SYM862=LTDIE_129 - Ldebug_info_start
	.long LDIFF_SYM862
	.byte 2,35,0,6
	.asciz "_platformConfigurationRegistry"

LDIFF_SYM863=LTDIE_137_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM863
	.byte 3,35,232,2,6
	.asciz "_cancelEvents"

LDIFF_SYM864=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM864
	.byte 3,35,240,2,0,7
	.asciz "Xamarin_Forms_Label"

LDIFF_SYM865=LTDIE_136 - Ldebug_info_start
	.long LDIFF_SYM865
LTDIE_136_POINTER:

	.byte 13
LDIFF_SYM866=LTDIE_136 - Ldebug_info_start
	.long LDIFF_SYM866
LTDIE_136_REFERENCE:

	.byte 14
LDIFF_SYM867=LTDIE_136 - Ldebug_info_start
	.long LDIFF_SYM867
LTDIE_125:

	.byte 5
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage"

	.byte 248,3,16
LDIFF_SYM868=LTDIE_126 - Ldebug_info_start
	.long LDIFF_SYM868
	.byte 2,35,0,6
	.asciz "mAutoShowInterstitial"

LDIFF_SYM869=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM869
	.byte 3,35,240,3,6
	.asciz "mNativeClickUrl"

LDIFF_SYM870=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM870
	.byte 3,35,200,3,6
	.asciz "nativeIcon"

LDIFF_SYM871=LTDIE_128_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM871
	.byte 3,35,208,3,6
	.asciz "nativeTitle"

LDIFF_SYM872=LTDIE_136_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM872
	.byte 3,35,216,3,6
	.asciz "nativeBody"

LDIFF_SYM873=LTDIE_136_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM873
	.byte 3,35,224,3,6
	.asciz "nativeMainIcon"

LDIFF_SYM874=LTDIE_128_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM874
	.byte 3,35,232,3,0,7
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage"

LDIFF_SYM875=LTDIE_125 - Ldebug_info_start
	.long LDIFF_SYM875
LTDIE_125_POINTER:

	.byte 13
LDIFF_SYM876=LTDIE_125 - Ldebug_info_start
	.long LDIFF_SYM876
LTDIE_125_REFERENCE:

	.byte 14
LDIFF_SYM877=LTDIE_125 - Ldebug_info_start
	.long LDIFF_SYM877
LTDIE_140:

	.byte 5
	.asciz "Xamarin_Forms_GestureRecognizer"

	.byte 216,1,16
LDIFF_SYM878=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM878
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_GestureRecognizer"

LDIFF_SYM879=LTDIE_140 - Ldebug_info_start
	.long LDIFF_SYM879
LTDIE_140_POINTER:

	.byte 13
LDIFF_SYM880=LTDIE_140 - Ldebug_info_start
	.long LDIFF_SYM880
LTDIE_140_REFERENCE:

	.byte 14
LDIFF_SYM881=LTDIE_140 - Ldebug_info_start
	.long LDIFF_SYM881
LTDIE_139:

	.byte 5
	.asciz "Xamarin_Forms_TapGestureRecognizer"

	.byte 224,1,16
LDIFF_SYM882=LTDIE_140 - Ldebug_info_start
	.long LDIFF_SYM882
	.byte 2,35,0,6
	.asciz "Tapped"

LDIFF_SYM883=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM883
	.byte 3,35,216,1,0,7
	.asciz "Xamarin_Forms_TapGestureRecognizer"

LDIFF_SYM884=LTDIE_139 - Ldebug_info_start
	.long LDIFF_SYM884
LTDIE_139_POINTER:

	.byte 13
LDIFF_SYM885=LTDIE_139 - Ldebug_info_start
	.long LDIFF_SYM885
LTDIE_139_REFERENCE:

	.byte 14
LDIFF_SYM886=LTDIE_139 - Ldebug_info_start
	.long LDIFF_SYM886
	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:.ctor"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage__ctor"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage__ctor
	.quad Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM887=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM887
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM888=LTDIE_139_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM888
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM889=Lfde5_end - Lfde5_start
	.long LDIFF_SYM889
Lfde5_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage__ctor

LDIFF_SYM890=Lme_5 - MobFoxDemoXM_MobFoxDemoXMPage__ctor
	.long LDIFF_SYM890
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,153,10,154,9
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_141:

	.byte 5
	.asciz "System_EventArgs"

	.byte 16,16
LDIFF_SYM891=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM891
	.byte 2,35,0,0,7
	.asciz "System_EventArgs"

LDIFF_SYM892=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM892
LTDIE_141_POINTER:

	.byte 13
LDIFF_SYM893=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM893
LTDIE_141_REFERENCE:

	.byte 14
LDIFF_SYM894=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM894
	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnCreateBanner"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs
	.quad Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM895=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM895
	.byte 0,3
	.asciz "sender"

LDIFF_SYM896=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM896
	.byte 0,3
	.asciz "e"

LDIFF_SYM897=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM897
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM898=Lfde6_end - Lfde6_start
	.long LDIFF_SYM898
Lfde6_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs

LDIFF_SYM899=Lme_6 - MobFoxDemoXM_MobFoxDemoXMPage_OnCreateBanner_object_System_EventArgs
	.long LDIFF_SYM899
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnHideBanner"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs
	.quad Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM900=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM900
	.byte 0,3
	.asciz "sender"

LDIFF_SYM901=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM901
	.byte 0,3
	.asciz "e"

LDIFF_SYM902=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM902
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM903=Lfde7_end - Lfde7_start
	.long LDIFF_SYM903
Lfde7_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs

LDIFF_SYM904=Lme_7 - MobFoxDemoXM_MobFoxDemoXMPage_OnHideBanner_object_System_EventArgs
	.long LDIFF_SYM904
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnUnhideBanner"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs
	.quad Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM905=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM905
	.byte 0,3
	.asciz "sender"

LDIFF_SYM906=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM906
	.byte 0,3
	.asciz "e"

LDIFF_SYM907=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM907
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM908=Lfde8_end - Lfde8_start
	.long LDIFF_SYM908
Lfde8_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs

LDIFF_SYM909=Lme_8 - MobFoxDemoXM_MobFoxDemoXMPage_OnUnhideBanner_object_System_EventArgs
	.long LDIFF_SYM909
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnCreateInterstitial"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs
	.quad Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM910=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM910
	.byte 2,141,16,3
	.asciz "sender"

LDIFF_SYM911=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM911
	.byte 0,3
	.asciz "e"

LDIFF_SYM912=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM912
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM913=Lfde9_end - Lfde9_start
	.long LDIFF_SYM913
Lfde9_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs

LDIFF_SYM914=Lme_9 - MobFoxDemoXM_MobFoxDemoXMPage_OnCreateInterstitial_object_System_EventArgs
	.long LDIFF_SYM914
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnLoadInterstitial"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs
	.quad Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM915=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM915
	.byte 2,141,16,3
	.asciz "sender"

LDIFF_SYM916=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM916
	.byte 0,3
	.asciz "e"

LDIFF_SYM917=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM917
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM918=Lfde10_end - Lfde10_start
	.long LDIFF_SYM918
Lfde10_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs

LDIFF_SYM919=Lme_a - MobFoxDemoXM_MobFoxDemoXMPage_OnLoadInterstitial_object_System_EventArgs
	.long LDIFF_SYM919
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnShowInterstitial"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs
	.quad Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM920=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM920
	.byte 0,3
	.asciz "sender"

LDIFF_SYM921=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM921
	.byte 0,3
	.asciz "e"

LDIFF_SYM922=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM922
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM923=Lfde11_end - Lfde11_start
	.long LDIFF_SYM923
Lfde11_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs

LDIFF_SYM924=Lme_b - MobFoxDemoXM_MobFoxDemoXMPage_OnShowInterstitial_object_System_EventArgs
	.long LDIFF_SYM924
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:OnCreateNative"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs
	.quad Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM925=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM925
	.byte 0,3
	.asciz "sender"

LDIFF_SYM926=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM926
	.byte 0,3
	.asciz "e"

LDIFF_SYM927=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM927
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM928=Lfde12_end - Lfde12_start
	.long LDIFF_SYM928
Lfde12_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs

LDIFF_SYM929=Lme_c - MobFoxDemoXM_MobFoxDemoXMPage_OnCreateNative_object_System_EventArgs
	.long LDIFF_SYM929
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:InitializeComponent"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent
	.quad Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM930=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM930
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM931=Lfde13_end - Lfde13_start
	.long LDIFF_SYM931
Lfde13_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent

LDIFF_SYM932=Lme_d - MobFoxDemoXM_MobFoxDemoXMPage_InitializeComponent
	.long LDIFF_SYM932
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,154,6
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_142:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 32,16
LDIFF_SYM933=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM933
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM934=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM934
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM935=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM935
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

LDIFF_SYM936=LTDIE_142 - Ldebug_info_start
	.long LDIFF_SYM936
LTDIE_142_POINTER:

	.byte 13
LDIFF_SYM937=LTDIE_142 - Ldebug_info_start
	.long LDIFF_SYM937
LTDIE_142_REFERENCE:

	.byte 14
LDIFF_SYM938=LTDIE_142 - Ldebug_info_start
	.long LDIFF_SYM938
	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:<MobFoxDemoXMPage>m__0"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.quad Lme_e

	.byte 2,118,16,3
	.asciz "sender"

LDIFF_SYM939=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM939
	.byte 0,3
	.asciz "args"

LDIFF_SYM940=LTDIE_142_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM940
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM941=Lfde14_end - Lfde14_start
	.long LDIFF_SYM941
Lfde14_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs

LDIFF_SYM942=Lme_e - MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__0_object_Plugin_MobFoxAds_Abstractions_MobFoxBannerCallbackEventArgs
	.long LDIFF_SYM942
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,154,4
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_143:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 32,16
LDIFF_SYM943=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM943
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM944=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM944
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM945=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM945
	.byte 2,35,24,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

LDIFF_SYM946=LTDIE_143 - Ldebug_info_start
	.long LDIFF_SYM946
LTDIE_143_POINTER:

	.byte 13
LDIFF_SYM947=LTDIE_143 - Ldebug_info_start
	.long LDIFF_SYM947
LTDIE_143_REFERENCE:

	.byte 14
LDIFF_SYM948=LTDIE_143 - Ldebug_info_start
	.long LDIFF_SYM948
	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:<MobFoxDemoXMPage>m__1"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM949=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM949
	.byte 2,141,24,3
	.asciz "sender"

LDIFF_SYM950=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM950
	.byte 0,3
	.asciz "args"

LDIFF_SYM951=LTDIE_143_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM951
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM952=Lfde15_end - Lfde15_start
	.long LDIFF_SYM952
Lfde15_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs

LDIFF_SYM953=Lme_f - MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__1_object_Plugin_MobFoxAds_Abstractions_MobFoxInterstitialCallbackEventArgs
	.long LDIFF_SYM953
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,154,6
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_144:

	.byte 5
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 72,16
LDIFF_SYM954=LTDIE_141 - Ldebug_info_start
	.long LDIFF_SYM954
	.byte 2,35,0,6
	.asciz "<EventType>k__BackingField"

LDIFF_SYM955=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM955
	.byte 2,35,16,6
	.asciz "<ErrorDesc>k__BackingField"

LDIFF_SYM956=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM956
	.byte 2,35,24,6
	.asciz "<TitleText>k__BackingField"

LDIFF_SYM957=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM957
	.byte 2,35,32,6
	.asciz "<BodyText>k__BackingField"

LDIFF_SYM958=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM958
	.byte 2,35,40,6
	.asciz "<IconUrl>k__BackingField"

LDIFF_SYM959=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM959
	.byte 2,35,48,6
	.asciz "<MainImageUrl>k__BackingField"

LDIFF_SYM960=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM960
	.byte 2,35,56,6
	.asciz "<ClickUrl>k__BackingField"

LDIFF_SYM961=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM961
	.byte 2,35,64,0,7
	.asciz "Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

LDIFF_SYM962=LTDIE_144 - Ldebug_info_start
	.long LDIFF_SYM962
LTDIE_144_POINTER:

	.byte 13
LDIFF_SYM963=LTDIE_144 - Ldebug_info_start
	.long LDIFF_SYM963
LTDIE_144_REFERENCE:

	.byte 14
LDIFF_SYM964=LTDIE_144 - Ldebug_info_start
	.long LDIFF_SYM964
LTDIE_149:

	.byte 5
	.asciz "System_Action`1"

	.byte 112,16
LDIFF_SYM965=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM965
	.byte 2,35,0,0,7
	.asciz "System_Action`1"

LDIFF_SYM966=LTDIE_149 - Ldebug_info_start
	.long LDIFF_SYM966
LTDIE_149_POINTER:

	.byte 13
LDIFF_SYM967=LTDIE_149 - Ldebug_info_start
	.long LDIFF_SYM967
LTDIE_149_REFERENCE:

	.byte 14
LDIFF_SYM968=LTDIE_149 - Ldebug_info_start
	.long LDIFF_SYM968
LTDIE_148:

	.byte 5
	.asciz "System_Threading_CancellationCallbackInfo"

	.byte 56,16
LDIFF_SYM969=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM969
	.byte 2,35,0,6
	.asciz "Callback"

LDIFF_SYM970=LTDIE_149_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM970
	.byte 2,35,16,6
	.asciz "StateForCallback"

LDIFF_SYM971=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM971
	.byte 2,35,24,6
	.asciz "TargetSyncContext"

LDIFF_SYM972=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM972
	.byte 2,35,32,6
	.asciz "TargetExecutionContext"

LDIFF_SYM973=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM973
	.byte 2,35,40,6
	.asciz "CancellationTokenSource"

LDIFF_SYM974=LTDIE_147_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM974
	.byte 2,35,48,0,7
	.asciz "System_Threading_CancellationCallbackInfo"

LDIFF_SYM975=LTDIE_148 - Ldebug_info_start
	.long LDIFF_SYM975
LTDIE_148_POINTER:

	.byte 13
LDIFF_SYM976=LTDIE_148 - Ldebug_info_start
	.long LDIFF_SYM976
LTDIE_148_REFERENCE:

	.byte 14
LDIFF_SYM977=LTDIE_148 - Ldebug_info_start
	.long LDIFF_SYM977
LTDIE_151:

	.byte 5
	.asciz "System_Threading_TimerCallback"

	.byte 112,16
LDIFF_SYM978=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM978
	.byte 2,35,0,0,7
	.asciz "System_Threading_TimerCallback"

LDIFF_SYM979=LTDIE_151 - Ldebug_info_start
	.long LDIFF_SYM979
LTDIE_151_POINTER:

	.byte 13
LDIFF_SYM980=LTDIE_151 - Ldebug_info_start
	.long LDIFF_SYM980
LTDIE_151_REFERENCE:

	.byte 14
LDIFF_SYM981=LTDIE_151 - Ldebug_info_start
	.long LDIFF_SYM981
LTDIE_152:

	.byte 5
	.asciz "System_Int64"

	.byte 24,16
LDIFF_SYM982=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM982
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM983=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM983
	.byte 2,35,16,0,7
	.asciz "System_Int64"

LDIFF_SYM984=LTDIE_152 - Ldebug_info_start
	.long LDIFF_SYM984
LTDIE_152_POINTER:

	.byte 13
LDIFF_SYM985=LTDIE_152 - Ldebug_info_start
	.long LDIFF_SYM985
LTDIE_152_REFERENCE:

	.byte 14
LDIFF_SYM986=LTDIE_152 - Ldebug_info_start
	.long LDIFF_SYM986
LTDIE_150:

	.byte 5
	.asciz "System_Threading_Timer"

	.byte 72,16
LDIFF_SYM987=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM987
	.byte 2,35,0,6
	.asciz "callback"

LDIFF_SYM988=LTDIE_151_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM988
	.byte 2,35,24,6
	.asciz "state"

LDIFF_SYM989=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM989
	.byte 2,35,32,6
	.asciz "due_time_ms"

LDIFF_SYM990=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM990
	.byte 2,35,40,6
	.asciz "period_ms"

LDIFF_SYM991=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM991
	.byte 2,35,48,6
	.asciz "next_run"

LDIFF_SYM992=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM992
	.byte 2,35,56,6
	.asciz "disposed"

LDIFF_SYM993=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM993
	.byte 2,35,64,0,7
	.asciz "System_Threading_Timer"

LDIFF_SYM994=LTDIE_150 - Ldebug_info_start
	.long LDIFF_SYM994
LTDIE_150_POINTER:

	.byte 13
LDIFF_SYM995=LTDIE_150 - Ldebug_info_start
	.long LDIFF_SYM995
LTDIE_150_REFERENCE:

	.byte 14
LDIFF_SYM996=LTDIE_150 - Ldebug_info_start
	.long LDIFF_SYM996
LTDIE_147:

	.byte 5
	.asciz "System_Threading_CancellationTokenSource"

	.byte 72,16
LDIFF_SYM997=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM997
	.byte 2,35,0,6
	.asciz "m_kernelEvent"

LDIFF_SYM998=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM998
	.byte 2,35,16,6
	.asciz "m_registeredCallbacksLists"

LDIFF_SYM999=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM999
	.byte 2,35,24,6
	.asciz "m_state"

LDIFF_SYM1000=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1000
	.byte 2,35,56,6
	.asciz "m_threadIDExecutingCallbacks"

LDIFF_SYM1001=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1001
	.byte 2,35,60,6
	.asciz "m_disposed"

LDIFF_SYM1002=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1002
	.byte 2,35,64,6
	.asciz "m_linkingRegistrations"

LDIFF_SYM1003=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1003
	.byte 2,35,32,6
	.asciz "m_executingCallback"

LDIFF_SYM1004=LTDIE_148_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1004
	.byte 2,35,40,6
	.asciz "m_timer"

LDIFF_SYM1005=LTDIE_150_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1005
	.byte 2,35,48,0,7
	.asciz "System_Threading_CancellationTokenSource"

LDIFF_SYM1006=LTDIE_147 - Ldebug_info_start
	.long LDIFF_SYM1006
LTDIE_147_POINTER:

	.byte 13
LDIFF_SYM1007=LTDIE_147 - Ldebug_info_start
	.long LDIFF_SYM1007
LTDIE_147_REFERENCE:

	.byte 14
LDIFF_SYM1008=LTDIE_147 - Ldebug_info_start
	.long LDIFF_SYM1008
LTDIE_154:

	.byte 5
	.asciz "System_Threading_Tasks_Task`1"

	.byte 80,16
LDIFF_SYM1009=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM1009
	.byte 2,35,0,6
	.asciz "m_result"

LDIFF_SYM1010=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1010
	.byte 2,35,72,0,7
	.asciz "System_Threading_Tasks_Task`1"

LDIFF_SYM1011=LTDIE_154 - Ldebug_info_start
	.long LDIFF_SYM1011
LTDIE_154_POINTER:

	.byte 13
LDIFF_SYM1012=LTDIE_154 - Ldebug_info_start
	.long LDIFF_SYM1012
LTDIE_154_REFERENCE:

	.byte 14
LDIFF_SYM1013=LTDIE_154 - Ldebug_info_start
	.long LDIFF_SYM1013
LTDIE_153:

	.byte 5
	.asciz "System_Threading_Tasks_TaskCompletionSource`1"

	.byte 24,16
LDIFF_SYM1014=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1014
	.byte 2,35,0,6
	.asciz "m_task"

LDIFF_SYM1015=LTDIE_154_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1015
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_TaskCompletionSource`1"

LDIFF_SYM1016=LTDIE_153 - Ldebug_info_start
	.long LDIFF_SYM1016
LTDIE_153_POINTER:

	.byte 13
LDIFF_SYM1017=LTDIE_153 - Ldebug_info_start
	.long LDIFF_SYM1017
LTDIE_153_REFERENCE:

	.byte 14
LDIFF_SYM1018=LTDIE_153 - Ldebug_info_start
	.long LDIFF_SYM1018
LTDIE_157:

	.byte 5
	.asciz "_KeyCollection"

	.byte 24,16
LDIFF_SYM1019=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1019
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1020=LTDIE_156_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1020
	.byte 2,35,16,0,7
	.asciz "_KeyCollection"

LDIFF_SYM1021=LTDIE_157 - Ldebug_info_start
	.long LDIFF_SYM1021
LTDIE_157_POINTER:

	.byte 13
LDIFF_SYM1022=LTDIE_157 - Ldebug_info_start
	.long LDIFF_SYM1022
LTDIE_157_REFERENCE:

	.byte 14
LDIFF_SYM1023=LTDIE_157 - Ldebug_info_start
	.long LDIFF_SYM1023
LTDIE_158:

	.byte 5
	.asciz "_ValueCollection"

	.byte 24,16
LDIFF_SYM1024=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1024
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1025=LTDIE_156_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1025
	.byte 2,35,16,0,7
	.asciz "_ValueCollection"

LDIFF_SYM1026=LTDIE_158 - Ldebug_info_start
	.long LDIFF_SYM1026
LTDIE_158_POINTER:

	.byte 13
LDIFF_SYM1027=LTDIE_158 - Ldebug_info_start
	.long LDIFF_SYM1027
LTDIE_158_REFERENCE:

	.byte 14
LDIFF_SYM1028=LTDIE_158 - Ldebug_info_start
	.long LDIFF_SYM1028
LTDIE_156:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 80,16
LDIFF_SYM1029=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1029
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM1030=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1030
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM1031=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1031
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM1032=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1032
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM1033=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1033
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM1034=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1034
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM1035=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1035
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM1036=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1036
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM1037=LTDIE_157_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1037
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM1038=LTDIE_158_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1038
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM1039=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1039
	.byte 2,35,56,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM1040=LTDIE_156 - Ldebug_info_start
	.long LDIFF_SYM1040
LTDIE_156_POINTER:

	.byte 13
LDIFF_SYM1041=LTDIE_156 - Ldebug_info_start
	.long LDIFF_SYM1041
LTDIE_156_REFERENCE:

	.byte 14
LDIFF_SYM1042=LTDIE_156 - Ldebug_info_start
	.long LDIFF_SYM1042
LTDIE_155:

	.byte 5
	.asciz "Xamarin_Forms_WeakEventManager"

	.byte 24,16
LDIFF_SYM1043=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1043
	.byte 2,35,0,6
	.asciz "_eventHandlers"

LDIFF_SYM1044=LTDIE_156_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1044
	.byte 2,35,16,0,7
	.asciz "Xamarin_Forms_WeakEventManager"

LDIFF_SYM1045=LTDIE_155 - Ldebug_info_start
	.long LDIFF_SYM1045
LTDIE_155_POINTER:

	.byte 13
LDIFF_SYM1046=LTDIE_155 - Ldebug_info_start
	.long LDIFF_SYM1046
LTDIE_155_REFERENCE:

	.byte 14
LDIFF_SYM1047=LTDIE_155 - Ldebug_info_start
	.long LDIFF_SYM1047
LTDIE_146:

	.byte 5
	.asciz "Xamarin_Forms_ImageSource"

	.byte 248,1,16
LDIFF_SYM1048=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM1048
	.byte 2,35,0,6
	.asciz "_synchandle"

LDIFF_SYM1049=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1049
	.byte 3,35,216,1,6
	.asciz "_cancellationTokenSource"

LDIFF_SYM1050=LTDIE_147_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1050
	.byte 3,35,224,1,6
	.asciz "_completionSource"

LDIFF_SYM1051=LTDIE_153_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1051
	.byte 3,35,232,1,6
	.asciz "_weakEventManager"

LDIFF_SYM1052=LTDIE_155_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1052
	.byte 3,35,240,1,0,7
	.asciz "Xamarin_Forms_ImageSource"

LDIFF_SYM1053=LTDIE_146 - Ldebug_info_start
	.long LDIFF_SYM1053
LTDIE_146_POINTER:

	.byte 13
LDIFF_SYM1054=LTDIE_146 - Ldebug_info_start
	.long LDIFF_SYM1054
LTDIE_146_REFERENCE:

	.byte 14
LDIFF_SYM1055=LTDIE_146 - Ldebug_info_start
	.long LDIFF_SYM1055
LTDIE_145:

	.byte 5
	.asciz "Xamarin_Forms_UriImageSource"

	.byte 136,2,16
LDIFF_SYM1056=LTDIE_146 - Ldebug_info_start
	.long LDIFF_SYM1056
	.byte 2,35,0,6
	.asciz "_cacheValidity"

LDIFF_SYM1057=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1057
	.byte 3,35,248,1,6
	.asciz "_cachingEnabled"

LDIFF_SYM1058=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1058
	.byte 3,35,128,2,0,7
	.asciz "Xamarin_Forms_UriImageSource"

LDIFF_SYM1059=LTDIE_145 - Ldebug_info_start
	.long LDIFF_SYM1059
LTDIE_145_POINTER:

	.byte 13
LDIFF_SYM1060=LTDIE_145 - Ldebug_info_start
	.long LDIFF_SYM1060
LTDIE_145_REFERENCE:

	.byte 14
LDIFF_SYM1061=LTDIE_145 - Ldebug_info_start
	.long LDIFF_SYM1061
	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:<MobFoxDemoXMPage>m__2"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.quad Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1062=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1062
	.byte 1,105,3
	.asciz "sender"

LDIFF_SYM1063=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1063
	.byte 0,3
	.asciz "args"

LDIFF_SYM1064=LTDIE_144_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1064
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM1065=LTDIE_145_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1065
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1066=Lfde16_end - Lfde16_start
	.long LDIFF_SYM1066
Lfde16_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs

LDIFF_SYM1067=Lme_10 - MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__2_object_Plugin_MobFoxAds_Abstractions_MobFoxNativeCallbackEventArgs
	.long LDIFF_SYM1067
	.long 0
	.byte 12,31,0,68,14,176,1,157,22,158,21,68,13,29,68,152,20,153,19,68,154,18
	.align 3
Lfde16_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "MobFoxDemoXM.MobFoxDemoXMPage:<MobFoxDemoXMPage>m__3"
	.asciz "MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs"

	.byte 0,0
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs
	.quad Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1068=LTDIE_125_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1068
	.byte 2,141,16,3
	.asciz "s"

LDIFF_SYM1069=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1069
	.byte 0,3
	.asciz "e"

LDIFF_SYM1070=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1070
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1071=Lfde17_end - Lfde17_start
	.long LDIFF_SYM1071
Lfde17_start:

	.long 0
	.align 3
	.quad MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs

LDIFF_SYM1072=Lme_11 - MobFoxDemoXM_MobFoxDemoXMPage__MobFoxDemoXMPagem__3_object_System_EventArgs
	.long LDIFF_SYM1072
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde17_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_159:

	.byte 5
	.asciz "System_Array"

	.byte 16,16
LDIFF_SYM1073=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1073
	.byte 2,35,0,0,7
	.asciz "System_Array"

LDIFF_SYM1074=LTDIE_159 - Ldebug_info_start
	.long LDIFF_SYM1074
LTDIE_159_POINTER:

	.byte 13
LDIFF_SYM1075=LTDIE_159 - Ldebug_info_start
	.long LDIFF_SYM1075
LTDIE_159_REFERENCE:

	.byte 14
LDIFF_SYM1076=LTDIE_159 - Ldebug_info_start
	.long LDIFF_SYM1076
	.byte 2
	.asciz "System.Array:InternalArray__ICollection_get_Count"
	.asciz "System_Array_InternalArray__ICollection_get_Count"

	.byte 1,68
	.quad System_Array_InternalArray__ICollection_get_Count
	.quad Lme_13

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1077=LTDIE_159_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1077
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1078=Lfde18_end - Lfde18_start
	.long LDIFF_SYM1078
Lfde18_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_get_Count

LDIFF_SYM1079=Lme_13 - System_Array_InternalArray__ICollection_get_Count
	.long LDIFF_SYM1079
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde18_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_get_IsReadOnly"
	.asciz "System_Array_InternalArray__ICollection_get_IsReadOnly"

	.byte 1,73
	.quad System_Array_InternalArray__ICollection_get_IsReadOnly
	.quad Lme_14

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1080=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1080
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1081=Lfde19_end - Lfde19_start
	.long LDIFF_SYM1081
Lfde19_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_get_IsReadOnly

LDIFF_SYM1082=Lme_14 - System_Array_InternalArray__ICollection_get_IsReadOnly
	.long LDIFF_SYM1082
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_Clear"
	.asciz "System_Array_InternalArray__ICollection_Clear"

	.byte 1,83
	.quad System_Array_InternalArray__ICollection_Clear
	.quad Lme_15

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1083=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1083
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1084=Lfde20_end - Lfde20_start
	.long LDIFF_SYM1084
Lfde20_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_Clear

LDIFF_SYM1085=Lme_15 - System_Array_InternalArray__ICollection_Clear
	.long LDIFF_SYM1085
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde20_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_Add<T_REF>"
	.asciz "System_Array_InternalArray__ICollection_Add_T_REF_T_REF"

	.byte 1,88
	.quad System_Array_InternalArray__ICollection_Add_T_REF_T_REF
	.quad Lme_16

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1086=LTDIE_159_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1086
	.byte 2,141,16,3
	.asciz "param0"

LDIFF_SYM1087=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1087
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1088=Lfde21_end - Lfde21_start
	.long LDIFF_SYM1088
Lfde21_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_Add_T_REF_T_REF

LDIFF_SYM1089=Lme_16 - System_Array_InternalArray__ICollection_Add_T_REF_T_REF
	.long LDIFF_SYM1089
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_Remove<T_REF>"
	.asciz "System_Array_InternalArray__ICollection_Remove_T_REF_T_REF"

	.byte 1,93
	.quad System_Array_InternalArray__ICollection_Remove_T_REF_T_REF
	.quad Lme_17

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1090=LTDIE_159_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1090
	.byte 2,141,16,3
	.asciz "param0"

LDIFF_SYM1091=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1091
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1092=Lfde22_end - Lfde22_start
	.long LDIFF_SYM1092
Lfde22_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_Remove_T_REF_T_REF

LDIFF_SYM1093=Lme_17 - System_Array_InternalArray__ICollection_Remove_T_REF_T_REF
	.long LDIFF_SYM1093
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_Contains<T_REF>"
	.asciz "System_Array_InternalArray__ICollection_Contains_T_REF_T_REF"

	.byte 1,98
	.quad System_Array_InternalArray__ICollection_Contains_T_REF_T_REF
	.quad Lme_18

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1094=LTDIE_159_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1094
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM1095=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1095
	.byte 1,106,11
	.asciz "length"

LDIFF_SYM1096=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1096
	.byte 1,104,11
	.asciz "i"

LDIFF_SYM1097=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1097
	.byte 1,103,11
	.asciz "value"

LDIFF_SYM1098=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1098
	.byte 1,102,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1099=Lfde23_end - Lfde23_start
	.long LDIFF_SYM1099
Lfde23_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_Contains_T_REF_T_REF

LDIFF_SYM1100=Lme_18 - System_Array_InternalArray__ICollection_Contains_T_REF_T_REF
	.long LDIFF_SYM1100
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,150,6,151,5,68,152,4,153,3,68,154,2
	.align 3
Lfde23_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:InternalArray__ICollection_CopyTo<T_REF>"
	.asciz "System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int"

	.byte 1,123
	.quad System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int
	.quad Lme_19

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1101=LTDIE_159_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1101
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM1102=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1102
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1103=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1103
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1104=Lfde24_end - Lfde24_start
	.long LDIFF_SYM1104
Lfde24_start:

	.long 0
	.align 3
	.quad System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int

LDIFF_SYM1105=Lme_19 - System_Array_InternalArray__ICollection_CopyTo_T_REF_T_REF___int
	.long LDIFF_SYM1105
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,148,10,149,9,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde24_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
