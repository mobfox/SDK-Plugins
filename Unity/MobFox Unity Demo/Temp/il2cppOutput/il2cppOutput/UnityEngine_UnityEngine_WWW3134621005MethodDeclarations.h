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

// UnityEngine.WWW
struct WWW_t3134621005;
// System.String
struct String_t;
// System.Byte[]
struct ByteU5BU5D_t4260760469;
// System.String[]
struct StringU5BU5D_t4054002952;
// System.Text.Encoding
struct Encoding_t2012439129;
// UnityEngine.Texture2D
struct Texture2D_t3884108195;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String7231557.h"

// System.Void UnityEngine.WWW::.ctor(System.String)
extern "C"  void WWW__ctor_m1985874080 (WWW_t3134621005 * __this, String_t* ___url0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::Dispose()
extern "C"  void WWW_Dispose_m2446678367 (WWW_t3134621005 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::Finalize()
extern "C"  void WWW_Finalize_m1793349504 (WWW_t3134621005 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::DestroyWWW(System.Boolean)
extern "C"  void WWW_DestroyWWW_m300967382 (WWW_t3134621005 * __this, bool ___cancel0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.WWW::InitWWW(System.String,System.Byte[],System.String[])
extern "C"  void WWW_InitWWW_m3594284248 (WWW_t3134621005 * __this, String_t* ___url0, ByteU5BU5D_t4260760469* ___postData1, StringU5BU5D_t4054002952* ___iHeaders2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Text.Encoding UnityEngine.WWW::get_DefaultEncoding()
extern "C"  Encoding_t2012439129 * WWW_get_DefaultEncoding_m2507364293 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture2D UnityEngine.WWW::GetTexture(System.Boolean)
extern "C"  Texture2D_t3884108195 * WWW_GetTexture_m1996665057 (WWW_t3134621005 * __this, bool ___markNonReadable0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Texture2D UnityEngine.WWW::get_texture()
extern "C"  Texture2D_t3884108195 * WWW_get_texture_m2854732303 (WWW_t3134621005 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
