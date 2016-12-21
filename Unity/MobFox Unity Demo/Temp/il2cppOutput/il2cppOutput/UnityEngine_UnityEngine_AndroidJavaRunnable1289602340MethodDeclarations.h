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
// System.Object
struct Il2CppObject;
// System.IAsyncResult
struct IAsyncResult_t2754620036;
// System.AsyncCallback
struct AsyncCallback_t1369114871;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Object4170816371.h"
#include "mscorlib_System_IntPtr4010401971.h"
#include "mscorlib_System_AsyncCallback1369114871.h"

// System.Void UnityEngine.AndroidJavaRunnable::.ctor(System.Object,System.IntPtr)
extern "C"  void AndroidJavaRunnable__ctor_m1140889495 (AndroidJavaRunnable_t1289602340 * __this, Il2CppObject * ___object0, IntPtr_t ___method1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.AndroidJavaRunnable::Invoke()
extern "C"  void AndroidJavaRunnable_Invoke_m3101692593 (AndroidJavaRunnable_t1289602340 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IAsyncResult UnityEngine.AndroidJavaRunnable::BeginInvoke(System.AsyncCallback,System.Object)
extern "C"  Il2CppObject * AndroidJavaRunnable_BeginInvoke_m364328122 (AndroidJavaRunnable_t1289602340 * __this, AsyncCallback_t1369114871 * ___callback0, Il2CppObject * ___object1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.AndroidJavaRunnable::EndInvoke(System.IAsyncResult)
extern "C"  void AndroidJavaRunnable_EndInvoke_m3666177319 (AndroidJavaRunnable_t1289602340 * __this, Il2CppObject * ___result0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
