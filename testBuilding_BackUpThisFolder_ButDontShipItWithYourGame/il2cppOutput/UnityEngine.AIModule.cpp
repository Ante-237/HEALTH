﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.AI.NavMeshAgent
struct NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F;
// UnityEngine.AI.NavMeshPath
struct NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.AI.NavMesh/OnNavMeshPreUpdate
struct OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7;

IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2;

struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tC64F337A786EF1DE807D08323D848149E353A750 
{
};
struct Il2CppArrayBounds;

// UnityEngine.AI.NavMesh
struct NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46  : public RuntimeObject
{
};

struct NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_StaticFields
{
	// UnityEngine.AI.NavMesh/OnNavMeshPreUpdate UnityEngine.AI.NavMesh::onPreUpdate
	OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* ___onPreUpdate_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// UnityEngine.AI.NavMeshHit
struct NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B 
{
	// UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::m_Position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Position_0;
	// UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::m_Normal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___m_Normal_1;
	// System.Single UnityEngine.AI.NavMeshHit::m_Distance
	float ___m_Distance_2;
	// System.Int32 UnityEngine.AI.NavMeshHit::m_Mask
	int32_t ___m_Mask_3;
	// System.Int32 UnityEngine.AI.NavMeshHit::m_Hit
	int32_t ___m_Hit_4;
};

// UnityEngine.AI.NavMeshPath
struct NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7  : public RuntimeObject
{
	// System.IntPtr UnityEngine.AI.NavMeshPath::m_Ptr
	intptr_t ___m_Ptr_0;
	// UnityEngine.Vector3[] UnityEngine.AI.NavMeshPath::m_Corners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_Corners_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.AI.NavMeshPath
struct NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___m_Corners_1;
};
// Native definition for COM marshalling of UnityEngine.AI.NavMeshPath
struct NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_com
{
	intptr_t ___m_Ptr_0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___m_Corners_1;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// UnityEngine.AI.NavMeshData
struct NavMeshData_t8BA8655BA9F2090EAD42953E956E8FDB98AA5284  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.AI.NavMesh/OnNavMeshPreUpdate
struct OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7  : public MulticastDelegate_t
{
};

// UnityEngine.AI.NavMeshAgent
struct NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 m_Items[1];

	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		m_Items[index] = value;
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};



// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.IntPtr UnityEngine.AI.NavMeshPath::InitializeNavMeshPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2 (const RuntimeMethod* method) ;
// System.Void System.Object::Finalize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Finalize_mC98C96301CCABFE00F1A7EF8E15DF507CACD42B2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB (intptr_t ___ptr0, const RuntimeMethod* method) ;
// System.Void UnityEngine.AI.NavMeshPath::ClearCornersInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606 (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AI.NavMeshAgent::SetDestination_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___target0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 NavMeshHit_get_position_m09E8FF6DEF5BFA3F30B3C4BCA4642442FF1BCBF1 (NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AI.NavMeshHit::get_distance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float NavMeshHit_get_distance_m2B9E0F1A139278132493964480B1A833A4FCCFEB (NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_inline (OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___targetPosition1, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit2, int32_t ___areaMask3, const RuntimeMethod* method) ;
// System.Void UnityEngine.AI.NavMeshPath::ClearCorners()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_ClearCorners_m8633C3989850C01982EBD3D4BC70E85AF461CE5B (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_CalculatePathInternal_m41F1F0B17C50CEF69000295E6D8F010711431896 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___targetPosition1, int32_t ___areaMask2, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* ___path3, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___targetPosition1, int32_t ___areaMask2, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* ___path3, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit1, float ___maxDistance2, int32_t ___areaMask3, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.AI.NavMeshPath
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_pinvoke(const NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7& unmarshaled, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.___m_Ptr_0;
	if (unmarshaled.___m_Corners_1 != NULL)
	{
		il2cpp_array_size_t _unmarshaledm_Corners_Length = (unmarshaled.___m_Corners_1)->max_length;
		marshaled.___m_Corners_1 = il2cpp_codegen_marshal_allocate_array<Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2>(_unmarshaledm_Corners_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledm_Corners_Length); i++)
		{
			(marshaled.___m_Corners_1)[i] = (unmarshaled.___m_Corners_1)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i));
		}
	}
	else
	{
		marshaled.___m_Corners_1 = NULL;
	}
}
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_pinvoke_back(const NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_pinvoke& marshaled, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t unmarshaledm_Ptr_temp_0;
	memset((&unmarshaledm_Ptr_temp_0), 0, sizeof(unmarshaledm_Ptr_temp_0));
	unmarshaledm_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.___m_Ptr_0 = unmarshaledm_Ptr_temp_0;
	if (marshaled.___m_Corners_1 != NULL)
	{
		if (unmarshaled.___m_Corners_1 == NULL)
		{
			unmarshaled.___m_Corners_1 = reinterpret_cast<Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*>((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_Corners_1), (void*)reinterpret_cast<Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*>((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___m_Corners_1)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			(unmarshaled.___m_Corners_1)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (marshaled.___m_Corners_1)[i]);
		}
	}
}
// Conversion method for clean up from marshalling of: UnityEngine.AI.NavMeshPath
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_pinvoke_cleanup(NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_pinvoke& marshaled)
{
	if (marshaled.___m_Corners_1 != NULL)
	{
		il2cpp_codegen_marshal_free(marshaled.___m_Corners_1);
		marshaled.___m_Corners_1 = NULL;
	}
}
// Conversion methods for marshalling of: UnityEngine.AI.NavMeshPath
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_com(const NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7& unmarshaled, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_com& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.___m_Ptr_0;
	if (unmarshaled.___m_Corners_1 != NULL)
	{
		il2cpp_array_size_t _unmarshaledm_Corners_Length = (unmarshaled.___m_Corners_1)->max_length;
		marshaled.___m_Corners_1 = il2cpp_codegen_marshal_allocate_array<Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2>(_unmarshaledm_Corners_Length);
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_unmarshaledm_Corners_Length); i++)
		{
			(marshaled.___m_Corners_1)[i] = (unmarshaled.___m_Corners_1)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i));
		}
	}
	else
	{
		marshaled.___m_Corners_1 = NULL;
	}
}
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_com_back(const NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_com& marshaled, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t unmarshaledm_Ptr_temp_0;
	memset((&unmarshaledm_Ptr_temp_0), 0, sizeof(unmarshaledm_Ptr_temp_0));
	unmarshaledm_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.___m_Ptr_0 = unmarshaledm_Ptr_temp_0;
	if (marshaled.___m_Corners_1 != NULL)
	{
		if (unmarshaled.___m_Corners_1 == NULL)
		{
			unmarshaled.___m_Corners_1 = reinterpret_cast<Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*>((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, 1));
			Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___m_Corners_1), (void*)reinterpret_cast<Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*>((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, 1)));
		}
		il2cpp_array_size_t _arrayLength = (unmarshaled.___m_Corners_1)->max_length;
		for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(_arrayLength); i++)
		{
			(unmarshaled.___m_Corners_1)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (marshaled.___m_Corners_1)[i]);
		}
	}
}
// Conversion method for clean up from marshalling of: UnityEngine.AI.NavMeshPath
IL2CPP_EXTERN_C void NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshal_com_cleanup(NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7_marshaled_com& marshaled)
{
	if (marshaled.___m_Corners_1 != NULL)
	{
		il2cpp_codegen_marshal_free(marshaled.___m_Corners_1);
		marshaled.___m_Corners_1 = NULL;
	}
}
// System.Void UnityEngine.AI.NavMeshPath::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath__ctor_mEA40BFC2492814FFC97A71C3AEC2154A9415C37F (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		intptr_t L_0;
		L_0 = NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2(NULL);
		__this->___m_Ptr_0 = L_0;
		return;
	}
}
// System.Void UnityEngine.AI.NavMeshPath::Finalize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_Finalize_mB151BFBD5D7E65C343415B6B332A58504F12AF77 (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_001b:
			{// begin finally (depth: 1)
				Object_Finalize_mC98C96301CCABFE00F1A7EF8E15DF507CACD42B2(__this, NULL);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			intptr_t L_0 = __this->___m_Ptr_0;
			NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB(L_0, NULL);
			__this->___m_Ptr_0 = (0);
			goto IL_0023;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0023:
	{
		return;
	}
}
// System.IntPtr UnityEngine.AI.NavMeshPath::InitializeNavMeshPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2 (const RuntimeMethod* method) 
{
	typedef intptr_t (*NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2_ftn) ();
	static NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshPath_InitializeNavMeshPath_m91B9A02C11B0C86F33F726A047B11D015230E9C2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshPath::InitializeNavMeshPath()");
	intptr_t icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB (intptr_t ___ptr0, const RuntimeMethod* method) 
{
	typedef void (*NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB_ftn) (intptr_t);
	static NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshPath_DestroyNavMeshPath_mE7FD23F7D0456507277BDC8ED868A7C6888796EB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr)");
	_il2cpp_icall_func(___ptr0);
}
// System.Void UnityEngine.AI.NavMeshPath::ClearCornersInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606 (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) 
{
	typedef void (*NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606_ftn) (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7*);
	static NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshPath::ClearCornersInternal()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.AI.NavMeshPath::ClearCorners()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMeshPath_ClearCorners_m8633C3989850C01982EBD3D4BC70E85AF461CE5B (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) 
{
	{
		NavMeshPath_ClearCornersInternal_m2310C5CB9B4EB2B3C4685476B2CF8440ED369606(__this, NULL);
		__this->___m_Corners_1 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Corners_1), (void*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL);
		return;
	}
}
// UnityEngine.AI.NavMeshPathStatus UnityEngine.AI.NavMeshPath::get_status()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NavMeshPath_get_status_m63B0AEDA3149C7053987C4D0A02B3FE8B41BD74B (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* __this, const RuntimeMethod* method) 
{
	typedef int32_t (*NavMeshPath_get_status_m63B0AEDA3149C7053987C4D0A02B3FE8B41BD74B_ftn) (NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7*);
	static NavMeshPath_get_status_m63B0AEDA3149C7053987C4D0A02B3FE8B41BD74B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshPath_get_status_m63B0AEDA3149C7053987C4D0A02B3FE8B41BD74B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshPath::get_status()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.AI.NavMeshAgent::SetDestination(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMeshAgent_SetDestination_mD5D960933827F1F14B29CF4A3B6F305C064EBF46 (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___target0, const RuntimeMethod* method) 
{
	{
		bool L_0;
		L_0 = NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA(__this, (&___target0), NULL);
		return L_0;
	}
}
// System.Single UnityEngine.AI.NavMeshAgent::get_remainingDistance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float NavMeshAgent_get_remainingDistance_m051C1B408E2740A95B5A5577C5EC7222311AA73A (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F* __this, const RuntimeMethod* method) 
{
	typedef float (*NavMeshAgent_get_remainingDistance_m051C1B408E2740A95B5A5577C5EC7222311AA73A_ftn) (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F*);
	static NavMeshAgent_get_remainingDistance_m051C1B408E2740A95B5A5577C5EC7222311AA73A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshAgent_get_remainingDistance_m051C1B408E2740A95B5A5577C5EC7222311AA73A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshAgent::get_remainingDistance()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AI.NavMeshAgent::get_pathPending()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMeshAgent_get_pathPending_mA806A4DC1E06CA32A4E7E71B6846B516EC8C2487 (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F* __this, const RuntimeMethod* method) 
{
	typedef bool (*NavMeshAgent_get_pathPending_mA806A4DC1E06CA32A4E7E71B6846B516EC8C2487_ftn) (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F*);
	static NavMeshAgent_get_pathPending_mA806A4DC1E06CA32A4E7E71B6846B516EC8C2487_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshAgent_get_pathPending_mA806A4DC1E06CA32A4E7E71B6846B516EC8C2487_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshAgent::get_pathPending()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AI.NavMeshAgent::SetDestination_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___target0, const RuntimeMethod* method) 
{
	typedef bool (*NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA_ftn) (NavMeshAgent_t5D0CCC0B3B78242F286C9BD8EDD87C3CCBD0A66F*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*);
	static NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMeshAgent_SetDestination_Injected_mC3EF405F5AAFF9F98C5D5AECAD641525CDF742EA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMeshAgent::SetDestination_Injected(UnityEngine.Vector3&)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___target0);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 NavMeshHit_get_position_m09E8FF6DEF5BFA3F30B3C4BCA4642442FF1BCBF1 (NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* __this, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___m_Position_0;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 NavMeshHit_get_position_m09E8FF6DEF5BFA3F30B3C4BCA4642442FF1BCBF1_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = NavMeshHit_get_position_m09E8FF6DEF5BFA3F30B3C4BCA4642442FF1BCBF1(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AI.NavMeshHit::get_distance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float NavMeshHit_get_distance_m2B9E0F1A139278132493964480B1A833A4FCCFEB (NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->___m_Distance_2;
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float NavMeshHit_get_distance_m2B9E0F1A139278132493964480B1A833A4FCCFEB_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B*>(__this + _offset);
	float _returnValue;
	_returnValue = NavMeshHit_get_distance_m2B9E0F1A139278132493964480B1A833A4FCCFEB(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AI.NavMesh::Internal_CallOnNavMeshPreUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NavMesh_Internal_CallOnNavMeshPreUpdate_m80148CFDD0C6F1DDDE5B3DA67A8D9613043A4233 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* L_0 = ((NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_StaticFields*)il2cpp_codegen_static_fields_for(NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_il2cpp_TypeInfo_var))->___onPreUpdate_0;
		V_0 = (bool)((!(((RuntimeObject*)(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7*)L_0) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0018;
		}
	}
	{
		OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* L_2 = ((NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_StaticFields*)il2cpp_codegen_static_fields_for(NavMesh_t3543D236ABB9A67F696BCF9440D669A1578B3D46_il2cpp_TypeInfo_var))->___onPreUpdate_0;
		NullCheck(L_2);
		OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_inline(L_2, NULL);
	}

IL_0018:
	{
		return;
	}
}
// System.Boolean UnityEngine.AI.NavMesh::Raycast(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_Raycast_m981EBA5073D823068AAAB0FFC4B568AFFC7E5755 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___targetPosition1, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit2, int32_t ___areaMask3, const RuntimeMethod* method) 
{
	{
		NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* L_0 = ___hit2;
		int32_t L_1 = ___areaMask3;
		bool L_2;
		L_2 = NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900((&___sourcePosition0), (&___targetPosition1), L_0, L_1, NULL);
		return L_2;
	}
}
// System.Boolean UnityEngine.AI.NavMesh::CalculatePath(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_CalculatePath_m2D0FF786CDEA88E7490ABA4582967087006F6E5E (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___targetPosition1, int32_t ___areaMask2, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* ___path3, const RuntimeMethod* method) 
{
	bool V_0 = false;
	{
		NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* L_0 = ___path3;
		NullCheck(L_0);
		NavMeshPath_ClearCorners_m8633C3989850C01982EBD3D4BC70E85AF461CE5B(L_0, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = ___sourcePosition0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___targetPosition1;
		int32_t L_3 = ___areaMask2;
		NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* L_4 = ___path3;
		bool L_5;
		L_5 = NavMesh_CalculatePathInternal_m41F1F0B17C50CEF69000295E6D8F010711431896(L_1, L_2, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0014;
	}

IL_0014:
	{
		bool L_6 = V_0;
		return L_6;
	}
}
// System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_CalculatePathInternal_m41F1F0B17C50CEF69000295E6D8F010711431896 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___targetPosition1, int32_t ___areaMask2, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* ___path3, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___areaMask2;
		NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* L_1 = ___path3;
		bool L_2;
		L_2 = NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA((&___sourcePosition0), (&___targetPosition1), L_0, L_1, NULL);
		return L_2;
	}
}
// System.Boolean UnityEngine.AI.NavMesh::SamplePosition(UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_SamplePosition_m51497866E71DD5263425E8572F2232D496E8F65A (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___sourcePosition0, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit1, float ___maxDistance2, int32_t ___areaMask3, const RuntimeMethod* method) 
{
	{
		NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* L_0 = ___hit1;
		float L_1 = ___maxDistance2;
		int32_t L_2 = ___areaMask3;
		bool L_3;
		L_3 = NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D((&___sourcePosition0), L_0, L_1, L_2, NULL);
		return L_3;
	}
}
// System.Int32 UnityEngine.AI.NavMesh::GetAreaFromName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NavMesh_GetAreaFromName_m4E45AABCA8F23DD9D1600807600157664D624BD8 (String_t* ___areaName0, const RuntimeMethod* method) 
{
	typedef int32_t (*NavMesh_GetAreaFromName_m4E45AABCA8F23DD9D1600807600157664D624BD8_ftn) (String_t*);
	static NavMesh_GetAreaFromName_m4E45AABCA8F23DD9D1600807600157664D624BD8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMesh_GetAreaFromName_m4E45AABCA8F23DD9D1600807600157664D624BD8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMesh::GetAreaFromName(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___areaName0);
	return icallRetVal;
}
// System.Boolean UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___targetPosition1, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit2, int32_t ___areaMask3, const RuntimeMethod* method) 
{
	typedef bool (*NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900_ftn) (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B*, int32_t);
	static NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMesh_Raycast_Injected_m3EFAD681DAC1B3ACC3EC4DB292BAE457F6673900_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___sourcePosition0, ___targetPosition1, ___hit2, ___areaMask3);
	return icallRetVal;
}
// System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___targetPosition1, int32_t ___areaMask2, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7* ___path3, const RuntimeMethod* method) 
{
	typedef bool (*NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA_ftn) (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, int32_t, NavMeshPath_tC77ABF4A25FC0F0A94E8A70E304E114FE690A3A7*);
	static NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMesh_CalculatePathInternal_Injected_m1A3CD6FB027FDE465104295B32C0767ABEB4EBBA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath)");
	bool icallRetVal = _il2cpp_icall_func(___sourcePosition0, ___targetPosition1, ___areaMask2, ___path3);
	return icallRetVal;
}
// System.Boolean UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___sourcePosition0, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B* ___hit1, float ___maxDistance2, int32_t ___areaMask3, const RuntimeMethod* method) 
{
	typedef bool (*NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D_ftn) (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, NavMeshHit_t6323FC1F2D00E24FBFFC3E27C2F349A3BAD16F8B*, float, int32_t);
	static NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (NavMesh_SamplePosition_Injected_m59777E11E947B46F60E9BCDF8C7CCFFAA5529E0D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(___sourcePosition0, ___hit1, ___maxDistance2, ___areaMask3);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_Multicast(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* currentDelegate = reinterpret_cast<OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_OpenInst(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_OpenStatic(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_OpenStaticInvoker(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_ClosedStaticInvoker(OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7 (OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnNavMeshPreUpdate__ctor_m7142A3AA991BE50B637A16D946AB7604C64EF9BA (OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___object0 == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_Multicast;
}
// System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914 (OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OnNavMeshPreUpdate_Invoke_mFB224B9BBF9C78B7F39AA91A047F175C69897914_inline (OnNavMeshPreUpdate_t332BD19DBCB087D7DE3F4F48C1E8F6A4EAB691C7* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
