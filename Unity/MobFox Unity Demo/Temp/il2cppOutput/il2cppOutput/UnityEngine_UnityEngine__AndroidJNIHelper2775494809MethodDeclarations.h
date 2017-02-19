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

// UnityEngine.AndroidJavaRunnable
struct AndroidJavaRunnable_t1289602340;
// UnityEngine.jvalue[]
struct jvalueU5BU5D_t1723627146;
// System.Object[]
struct ObjectU5BU5D_t1108656482;
// System.Array
struct Il2CppArray;
// System.String
struct String_t;
// System.Object
struct Il2CppObject;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_IntPtr4010401971.h"
#include "UnityEngine_UnityEngine_AndroidJavaRunnable1289602340.h"
#include "mscorlib_System_Array1146569071.h"
#include "mscorlib_System_String7231557.h"
#include "mscorlib_System_Object4170816371.h"

// System.IntPtr UnityEngine._AndroidJNIHelper::CreateJavaRunnable(UnityEngine.AndroidJavaRunnable)
extern "C"  IntPtr_t _AndroidJNIHelper_CreateJavaRunnable_m2949886695 (Il2CppObject * __this /* static, unused */, AndroidJavaRunnable_t1289602340 * ___jrunnable0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.jvalue[] UnityEngine._AndroidJNIHelper::CreateJNIArgArray(System.Object[])
extern "C"  jvalueU5BU5D_t1723627146* _AndroidJNIHelper_CreateJNIArgArray_m3400436963 (Il2CppObject * __this /* static, unused */, ObjectU5BU5D_t1108656482* ___args0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine._AndroidJNIHelper::DeleteJNIArgArray(System.Object[],UnityEngine.jvalue[])
extern "C"  void _AndroidJNIHelper_DeleteJNIArgArray_m2053299397 (Il2CppObject * __this /* static, unused */, ObjectU5BU5D_t1108656482* ___args0, jvalueU5BU5D_t1723627146* ___jniArgs1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine._AndroidJNIHelper::ConvertToJNIArray(System.Array)
extern "C"  IntPtr_t _AndroidJNIHelper_ConvertToJNIArray_m1911420401 (Il2CppObject * __this /* static, unused */, Il2CppArray * ___array0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.Object[],System.Boolean)
extern "C"  IntPtr_t _AndroidJNIHelper_GetMethodID_m4173184412 (Il2CppObject * __this /* static, unused */, IntPtr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t1108656482* ___args2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.String,System.Boolean)
extern "C"  IntPtr_t _AndroidJNIHelper_GetMethodID_m3581696140 (Il2CppObject * __this /* static, unused */, IntPtr_t ___jclass0, String_t* ___methodName1, String_t* ___signature2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodIDFallback(System.IntPtr,System.String,System.String,System.Boolean)
extern "C"  IntPtr_t _AndroidJNIHelper_GetMethodIDFallback_m2222932750 (Il2CppObject * __this /* static, unused */, IntPtr_t ___jclass0, String_t* ___methodName1, String_t* ___signature2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr UnityEngine._AndroidJNIHelper::GetFieldID(System.IntPtr,System.String,System.String,System.Boolean)
extern "C"  IntPtr_t _AndroidJNIHelper_GetFieldID_m597111337 (Il2CppObject * __this /* static, unused */, IntPtr_t ___jclass0, String_t* ___fieldName1, String_t* ___signature2, bool ___isStatic3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine._AndroidJNIHelper::GetSignature(System.Object)
extern "C"  String_t* _AndroidJNIHelper_GetSignature_m1099812039 (Il2CppObject * __this /* static, unused */, Il2CppObject * ___obj0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine._AndroidJNIHelper::GetSignature(System.Object[])
extern "C"  String_t* _AndroidJNIHelper_GetSignature_m357465637 (Il2CppObject * __this /* static, unused */, ObjectU5BU5D_t1108656482* ___args0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
