#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// MobFox
struct MobFox_t2309945807;
// System.String
struct String_t;
// System.Collections.IEnumerator
struct IEnumerator_t3464575207;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String7231557.h"

// System.Void MobFox::.ctor()
extern "C"  void MobFox__ctor_m3166897068 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::_setUseLocation(System.Boolean)
extern "C"  void MobFox__setUseLocation_m3256561242 (Il2CppObject * __this /* static, unused */, bool ___useLocation0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 MobFox::_createBanner(System.String,System.Single,System.Single,System.Single,System.Single)
extern "C"  int32_t MobFox__createBanner_m2931888243 (Il2CppObject * __this /* static, unused */, String_t* ___invh0, float ___originX1, float ___originY2, float ___sizeWidth3, float ___sizeHeight4, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::_setGameObject(System.String)
extern "C"  void MobFox__setGameObject_m4091687542 (Il2CppObject * __this /* static, unused */, String_t* ___gameObject0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::_createInterstitial(System.String)
extern "C"  void MobFox__createInterstitial_m1488435793 (Il2CppObject * __this /* static, unused */, String_t* ___invh0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::_showInterstitial()
extern "C"  void MobFox__showInterstitial_m2933782162 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::_createNative(System.String)
extern "C"  void MobFox__createNative_m1082733318 (Il2CppObject * __this /* static, unused */, String_t* ___invh0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::Awake()
extern "C"  void MobFox_Awake_m3404502287 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ConnectToPlugin()
extern "C"  void MobFox_ConnectToPlugin_m530116642 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowToast(System.String)
extern "C"  void MobFox_ShowToast_m3513659534 (MobFox_t2309945807 * __this, String_t* ___message0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::CheckboxPressed()
extern "C"  void MobFox_CheckboxPressed_m2066398377 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::SetUseLocation_iPhone(System.Boolean)
extern "C"  void MobFox_SetUseLocation_iPhone_m387744907 (MobFox_t2309945807 * __this, bool ___in_useLocation0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::SetUseLocation_Android(System.Boolean)
extern "C"  void MobFox_SetUseLocation_Android_m2133621625 (MobFox_t2309945807 * __this, bool ___in_useLocation0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::SetUseLocation(System.Boolean)
extern "C"  void MobFox_SetUseLocation_m1299801961 (MobFox_t2309945807 * __this, bool ___in_useLocation0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxBanner_iPhone()
extern "C"  void MobFox_ShowMobFoxBanner_iPhone_m3324174550 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxBanner_Android()
extern "C"  void MobFox_ShowMobFoxBanner_Android_m830573312 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxBanner()
extern "C"  void MobFox_ShowMobFoxBanner_m1318680816 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::bannerReady(System.String)
extern "C"  void MobFox_bannerReady_m1870177889 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::bannerError(System.String)
extern "C"  void MobFox_bannerError_m2011641692 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::bannerClosed(System.String)
extern "C"  void MobFox_bannerClosed_m538189394 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::bannerClicked(System.String)
extern "C"  void MobFox_bannerClicked_m394064541 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::bannerFinished(System.String)
extern "C"  void MobFox_bannerFinished_m1829281612 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::CreateAndShowMobFoxInterstitial()
extern "C"  void MobFox_CreateAndShowMobFoxInterstitial_m2955565117 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::CreateMobFoxInterstitial_iPhone()
extern "C"  void MobFox_CreateMobFoxInterstitial_iPhone_m1545405303 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::CreateMobFoxInterstitial_Android()
extern "C"  void MobFox_CreateMobFoxInterstitial_Android_m1523301503 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::CreateMobFoxInterstitial()
extern "C"  void MobFox_CreateMobFoxInterstitial_m3272644975 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxInterstitial_iPhone()
extern "C"  void MobFox_ShowMobFoxInterstitial_iPhone_m1625071382 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxInterstitial_Android()
extern "C"  void MobFox_ShowMobFoxInterstitial_Android_m3992949952 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxInterstitial()
extern "C"  void MobFox_ShowMobFoxInterstitial_m3483189936 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::interstitialReady(System.String)
extern "C"  void MobFox_interstitialReady_m4276574497 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::interstitalError(System.String)
extern "C"  void MobFox_interstitalError_m3328691829 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::interstitialClosed(System.String)
extern "C"  void MobFox_interstitialClosed_m2122040210 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::interstitialClicked(System.String)
extern "C"  void MobFox_interstitialClicked_m2248799581 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::interstitialFinished(System.String)
extern "C"  void MobFox_interstitialFinished_m3491493004 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxNative_iPhone()
extern "C"  void MobFox_ShowMobFoxNative_iPhone_m3900368971 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxNative_Android()
extern "C"  void MobFox_ShowMobFoxNative_Android_m1512731179 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::ShowMobFoxNative()
extern "C"  void MobFox_ShowMobFoxNative_m925219611 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::nativePressed()
extern "C"  void MobFox_nativePressed_m1163656501 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::nativeReady(System.String)
extern "C"  void MobFox_nativeReady_m1171706828 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::nativeError(System.String)
extern "C"  void MobFox_nativeError_m1313170631 (MobFox_t2309945807 * __this, String_t* ___msg0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator MobFox::LoadIconImage(System.String)
extern "C"  Il2CppObject * MobFox_LoadIconImage_m3625723940 (MobFox_t2309945807 * __this, String_t* ___loadedURL0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator MobFox::LoadMainImage(System.String)
extern "C"  Il2CppObject * MobFox_LoadMainImage_m211603812 (MobFox_t2309945807 * __this, String_t* ___loadedURL0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::<ConnectToPlugin>m__0()
extern "C"  void MobFox_U3CConnectToPluginU3Em__0_m3316127855 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::<ShowMobFoxBanner_Android>m__2()
extern "C"  void MobFox_U3CShowMobFoxBanner_AndroidU3Em__2_m2983981879 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::<CreateMobFoxInterstitial_Android>m__3()
extern "C"  void MobFox_U3CCreateMobFoxInterstitial_AndroidU3Em__3_m1191455449 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::<ShowMobFoxInterstitial_Android>m__4()
extern "C"  void MobFox_U3CShowMobFoxInterstitial_AndroidU3Em__4_m1210159993 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void MobFox::<ShowMobFoxNative_Android>m__5()
extern "C"  void MobFox_U3CShowMobFoxNative_AndroidU3Em__5_m722197039 (MobFox_t2309945807 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
