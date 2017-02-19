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

// System.String
struct String_t;
// UnityEngine.AndroidJavaRunnable
struct AndroidJavaRunnable_t1289602340;
// UnityEngine.AndroidJavaProxy
struct AndroidJavaProxy_t1828457281;
// UnityEngine.jvalue[]
struct jvalueU5BU5D_t1723627146;
// System.Object[]
struct ObjectU5BU5D_t1108656482;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_IntPtr4010401971.h"
#include "mscorlib_System_String7231557.h"
#include "UnityEngine_UnityEngine_AndroidJavaRunnable1289602340.h"
#include "UnityEngine_UnityEngine_AndroidJavaProxy1828457281.h"

// System.IntPtr UnityEngine.AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.String,System.Boolean)
extern "C"  IntPtr_t AndroidJNIHelper_GetMethodID_m951538837 (Il2CppObject * __this /* static, unused */, IntPtr_t ___javaClass0, String_t* ___methodName1, String_t* ___signature2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine.AndroidJNIHelper::GetFieldID(System.IntPtr,System.String,System.String,System.Boolean)
extern "C"  IntPtr_t AndroidJNIHelper_GetFieldID_m3698856192 (Il2CppObject * __this /* static, unused */, IntPtr_t ___javaClass0, String_t* ___fieldName1, String_t* ___signature2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine.AndroidJNIHelper::CreateJavaRunnable(UnityEngine.AndroidJavaRunnable)
extern "C"  IntPtr_t AndroidJNIHelper_CreateJavaRunnable_m1606930224 (Il2CppObject * __this /* static, unused */, AndroidJavaRunnable_t1289602340 * ___jrunnable0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine.AndroidJNIHelper::CreateJavaProxy(UnityEngine.AndroidJavaProxy)
extern "C"  IntPtr_t AndroidJNIHelper_CreateJavaProxy_m1509148942 (Il2CppObject * __this /* static, unused */, AndroidJavaProxy_t1828457281 * ___proxy0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.AndroidJNIHelper::INTERNAL_CALL_CreateJavaProxy(UnityEngine.AndroidJavaProxy,System.IntPtr&)
extern "C"  void AndroidJNIHelper_INTERNAL_CALL_CreateJavaProxy_m2036620154 (Il2CppObject * __this /* static, unused */, AndroidJavaProxy_t1828457281 * ___proxy0, IntPtr_t* ___value1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.jvalue[] UnityEngine.AndroidJNIHelper::CreateJNIArgArray(System.Object[])
extern "C"  jvalueU5BU5D_t1723627146* AndroidJNIHelper_CreateJNIArgArray_m3777113646 (Il2CppObject * __this /* static, unused */, ObjectU5BU5D_t1108656482* ___args0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.AndroidJNIHelper::DeleteJNIArgArray(System.Object[],UnityEngine.jvalue[])
extern "C"  void AndroidJNIHelper_DeleteJNIArgArray_m4114677528 (Il2CppObject * __this /* static, unused */, ObjectU5BU5D_t1108656482* ___args0, jvalueU5BU5D_t1723627146* ___jniArgs1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine.AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.Object[],System.Boolean)
extern "C"  IntPtr_t AndroidJNIHelper_GetMethodID_m2032786277 (Il2CppObject * __this /* static, unused */, IntPtr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t1108656482* ___args2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
