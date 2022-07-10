using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.reflect;

[ConstantPool(new object[]
{
	(byte)51,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractInvocationHandler : Object, InvocationHandler
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object[] NO_ARGS;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[] { 88, 234, 70, 109, 251, 57 })]
	private static bool isProxyOfSameInterfaces(object P_0, Class P_1)
	{
		return (P_1.isInstance(P_0) || (Proxy.isProxyClass(Object.instancehelper_getClass(P_0)) && Arrays.equals(Object.instancehelper_getClass(P_0).getInterfaces(), P_1.getInterfaces()))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(115)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(134)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.lang.Throwable" })]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 51, 0,
		0
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract object handleInvocation(object obj, Method m, object[] objarr);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public AbstractInvocationHandler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 51, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		15, 99, 135, 118, 142, 105, 114, 110, 100, 99,
		137, 100, 137, 112, 53, 168, 118, 137
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public object invoke(object proxy, Method method, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object[] args)
	{
		if (args == null)
		{
			args = NO_ARGS;
		}
		if (args.Length == 0 && String.instancehelper_equals(method.getName(), "hashCode"))
		{
			Integer result = Integer.valueOf(hashCode());
			_ = null;
			return result;
		}
		if ((nint)args.LongLength == 1 && String.instancehelper_equals(method.getName(), "equals") && method.getParameterTypes()[0] == ClassLiteral<Object>.Value)
		{
			object obj = args[0];
			if (obj == null)
			{
				Boolean result2 = Boolean.valueOf(b: false);
				_ = null;
				return result2;
			}
			if (proxy == obj)
			{
				Boolean result3 = Boolean.valueOf(b: true);
				_ = null;
				return result3;
			}
			Boolean result4 = Boolean.valueOf((isProxyOfSameInterfaces(obj, Object.instancehelper_getClass(proxy)) && equals(Proxy.getInvocationHandler(obj, AbstractInvocationHandler.___003CGetCallerID_003E()))) ? true : false);
			_ = null;
			return result4;
		}
		if (args.Length == 0 && String.instancehelper_equals(method.getName(), "toString"))
		{
			string result5 = toString();
			_ = null;
			return result5;
		}
		object result6 = handleInvocation(proxy, method, args);
		_ = null;
		return result6;
	}

	[LineNumberTable(44)]
	static AbstractInvocationHandler()
	{
		NO_ARGS = new object[0];
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
