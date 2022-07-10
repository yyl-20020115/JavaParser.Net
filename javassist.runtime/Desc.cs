using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;

namespace javassist.runtime;

public class Desc : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/ThreadLocal<Ljava/lang/Boolean;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : ThreadLocal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(40)]
		protected internal new virtual Boolean initialValue()
		{
			Boolean result = Boolean.valueOf(b: false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(37)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(37)]
		protected internal override object initialValue()
		{
			Boolean result = initialValue();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			ThreadLocal.___003Cclinit_003E();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	public static bool useContextClassLoader;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/ThreadLocal<Ljava/lang/Boolean;>;")]
	private static ThreadLocal USE_CONTEXT_CLASS_LOADER_LOCALLY;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 20, 125, 121 })]
	private static Class getClassObject(string P_0)
	{
		if (useContextClassLoader || ((Boolean)USE_CONTEXT_CLASS_LOADER_LOCALLY.get()).booleanValue())
		{
			Class result = Class.forName(P_0, true, Thread.currentThread().getContextClassLoader(), Desc.___003CGetCallerID_003E());
			_ = null;
			return result;
		}
		Class result2 = Class.forName(P_0, Desc.___003CGetCallerID_003E());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;III)[Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		67, 100, 135, 104, 159, 87, 102, 133, 102, 130,
		102, 130, 102, 130, 102, 130, 102, 130, 102, 130,
		102, 130, 102, 162, 140, 167, 110, 100
	})]
	private static Class[] getType(string P_0, int P_1, int P_2, int P_3)
	{
		if (P_2 >= P_1)
		{
			return new Class[P_3];
		}
		Class tYPE;
		switch (String.instancehelper_charAt(P_0, P_2))
		{
		case 'Z':
			tYPE = Boolean.TYPE;
			break;
		case 'C':
			tYPE = Character.TYPE;
			break;
		case 'B':
			tYPE = Byte.TYPE;
			break;
		case 'S':
			tYPE = Short.TYPE;
			break;
		case 'I':
			tYPE = Integer.TYPE;
			break;
		case 'J':
			tYPE = Long.TYPE;
			break;
		case 'F':
			tYPE = Float.TYPE;
			break;
		case 'D':
			tYPE = Double.TYPE;
			break;
		case 'V':
			tYPE = Void.TYPE;
			break;
		case 'L':
		case '[':
		{
			Class[] classType = getClassType(P_0, P_1, P_2, P_3);
			_ = null;
			return classType;
		}
		default:
			return new Class[P_3];
		}
		Class[] type = getType(P_0, P_1, P_2 + 1, P_3 + 1);
		type[P_3] = tYPE;
		return type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;III)[Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		113,
		98,
		107,
		134,
		107,
		106,
		100,
		208,
		107,
		141,
		139,
		142,
		byte.MaxValue,
		5,
		69,
		226,
		61,
		130,
		178
	})]
	private static Class[] getClassType(string P_0, int P_1, int P_2, int P_3)
	{
		int i;
		for (i = P_2; String.instancehelper_charAt(P_0, i) == '['; i++)
		{
		}
		if (String.instancehelper_charAt(P_0, i) == 'L')
		{
			i = String.instancehelper_indexOf(P_0, 59, i);
			if (i < 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IndexOutOfBoundsException("bad descriptor");
			}
		}
		string @this = ((String.instancehelper_charAt(P_0, P_2) != 'L') ? String.instancehelper_substring(P_0, P_2, i + 1) : String.instancehelper_substring(P_0, P_2 + 1, i));
		Class[] type = getType(P_0, P_1, i + 1, P_3 + 1);
		java.lang.ClassNotFoundException ex;
		try
		{
			type[P_3] = getClassObject(String.instancehelper_replace(@this, '/', '.'));
			return type;
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException this2 = ex;
		string message = Throwable.instancehelper_getMessage(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(25)]
	public Desc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 114 })]
	public static void setUseContextClassLoaderLocally()
	{
		USE_CONTEXT_CLASS_LOADER_LOCALLY.set(Boolean.valueOf(b: true));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 108 })]
	public static void resetUseContextClassLoaderLocally()
	{
		USE_CONTEXT_CLASS_LOADER_LOCALLY.remove();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 31, 156, 97, 191, 5 })]
	public static Class getClazz(string name)
	{
		//Discarded unreachable code: IL_0008
		java.lang.ClassNotFoundException ex;
		try
		{
			return getClassObject(name);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		string message = new StringBuilder().append("$class: internal error, could not find class '").append(name).append("' (Desc.useContextClassLoader: ")
			.append(Boolean.toString(useContextClassLoader))
			.append(")")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)[Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 46, 107, 144 })]
	public static Class[] getParams(string desc)
	{
		if (String.instancehelper_charAt(desc, 0) != '(')
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("$sig: internal error");
		}
		Class[] type = getType(desc, String.instancehelper_length(desc), 1, 0);
		_ = null;
		return type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 57, 111, 104, 144 })]
	public static Class getType(string desc)
	{
		Class[] type = getType(desc, String.instancehelper_length(desc), 0, 0);
		if (type == null || (nint)type.LongLength != 1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("$type: internal error");
		}
		return type[0];
	}

	[LineNumberTable(new byte[] { 159, 177, 134 })]
	static Desc()
	{
		useContextClassLoader = false;
		USE_CONTEXT_CLASS_LOADER_LOCALLY = new _1();
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
