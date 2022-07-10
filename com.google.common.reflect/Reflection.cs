using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;

namespace com.google.common.reflect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Reflection : Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 105 })]
	public static string getPackageName(string classFullName)
	{
		int num = String.instancehelper_lastIndexOf(classFullName, 46);
		string result = ((num >= 0) ? String.instancehelper_substring(classFullName, 0, num) : "");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/String;")]
	[LineNumberTable(37)]
	public static string getPackageName(Class clazz)
	{
		string packageName = getPackageName(clazz.getName());
		_ = null;
		return packageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[] { 12, 146, 191, 18, 2, 98, 237, 60, 233, 71 })]
	public static void initialize(params Class[] classes)
	{
		int num = classes.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = classes[i];
			java.lang.ClassNotFoundException ex;
			try
			{
				Class.forName(@class.getName(), true, @class.getClassLoader(Reflection.___003CGetCallerID_003E()), Reflection.___003CGetCallerID_003E());
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_003f;
			}
			continue;
			IL_003f:
			java.lang.ClassNotFoundException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;Ljava/lang/reflect/InvocationHandler;)TT;")]
	[LineNumberTable(new byte[] { 31, 103, 113, 129, 53, 139 })]
	public static object newProxy(Class interfaceType, InvocationHandler handler)
	{
		Preconditions.checkNotNull(handler);
		Preconditions.checkArgument(interfaceType.isInterface(), "%s is not an interface", interfaceType);
		object obj = Proxy.newProxyInstance(interfaceType.getClassLoader(Reflection.___003CGetCallerID_003E()), new Class[1] { interfaceType }, handler, Reflection.___003CGetCallerID_003E());
		object result = interfaceType.cast(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	private Reflection()
	{
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
