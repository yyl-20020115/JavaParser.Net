using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Throwables : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/StackTraceElement;>;")]
	[EnclosingMethod(null, "jlaStackTrace", "(Ljava.lang.Throwable;)Ljava.util.List;")]
	internal class _1 : AbstractList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal System.Exception val_0024t;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 56, 63, 18, 42 })]
		public new virtual StackTraceElement get(int P_0)
		{
			return (StackTraceElement)access_0024200((Method)java.util.Objects.requireNonNull(access_0024000()), java.util.Objects.requireNonNull(access_0024100()), new object[2]
			{
				val_0024t,
				Integer.valueOf(P_0)
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(417)]
		internal _1(System.Exception P_0)
		{
			val_0024t = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 63, 63, 9, 42 })]
		public override int size()
		{
			int result = ((Integer)access_0024200((Method)java.util.Objects.requireNonNull(access_0024300()), java.util.Objects.requireNonNull(access_0024100()), new object[1] { val_0024t })).intValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(417)]
		public override object get(int P_0)
		{
			StackTraceElement result = get(P_0);
			_ = null;
			return result;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const string JAVA_LANG_ACCESS_CLASSNAME = "sun.misc.JavaLangAccess";

	internal const string SHARED_SECRETS_CLASSNAME = "sun.misc.SharedSecrets";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object jla;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Method getStackTraceElementMethod;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Method getStackTraceDepthMethod;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Method access_0024000()
	{
		return getStackTraceElementMethod;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static object access_0024100()
	{
		return jla;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(49)]
	internal static object access_0024200(Method P_0, object P_1, object[] P_2)
	{
		object result = invokeAccessibleNonThrowingMethod(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Method access_0024300()
	{
		return getStackTraceDepthMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 72, 127, 16, 97, 108, 98 })]
	private static object invokeAccessibleNonThrowingMethod(Method P_0, object P_1, params object[] P_2)
	{
		//Discarded unreachable code: IL_000f
		IllegalAccessException ex;
		InvocationTargetException ex2;
		try
		{
			try
			{
				return P_0.invoke(P_1, P_2, Throwables.___003CGetCallerID_003E());
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (InvocationTargetException x2)
		{
			ex2 = ByteCodeHelper.MapException<InvocationTargetException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002b;
		}
		IllegalAccessException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
		IL_002b:
		InvocationTargetException ex3 = ex2;
		throw Throwable.___003Cunmap_003E(propagate(ex3.getCause()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)V^TX;")]
	[LineNumberTable(new byte[] { 25, 103, 105, 146 })]
	public static void throwIfInstanceOf(System.Exception throwable, Class declaredType)
	{
		Preconditions.checkNotNull(throwable);
		if (declaredType.isInstance(throwable))
		{
			throw Throwable.___003Cunmap_003E((System.Exception)declaredType.cast(throwable));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 103, 104, 140, 104, 140 })]
	public static void throwIfUnchecked(System.Exception throwable)
	{
		Preconditions.checkNotNull(throwable);
		if (throwable is RuntimeException)
		{
			throw Throwable.___003Cunmap_003E((RuntimeException)throwable);
		}
		if (throwable is Error)
		{
			throw Throwable.___003Cunmap_003E((Error)throwable);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[Obsolete]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)V^TX;")]
	[LineNumberTable(new byte[] { 54, 99, 137 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void propagateIfInstanceOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception throwable, Class declaredType)
	{
		if (throwable != null)
		{
			throwIfInstanceOf(throwable, declaredType);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 109, 99, 136 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void propagateIfPossible([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception throwable)
	{
		if (throwable != null)
		{
			throwIfUnchecked(throwable);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)V^TX;")]
	[LineNumberTable(new byte[] { 160, 71, 103, 104 })]
	public static void propagateIfPossible([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception throwable, Class declaredType)
	{
		propagateIfInstanceOf(throwable, declaredType);
		propagateIfPossible(throwable);
	}

	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static bool lazyStackTraceIsLazy()
	{
		return (getStackTraceElementMethod != null && getStackTraceDepthMethod != null) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Throwable;)Ljava/util/List<Ljava/lang/StackTraceElement;>;")]
	[LineNumberTable(new byte[] { 161, 40, 231, 71 })]
	private static List jlaStackTrace(System.Exception P_0)
	{
		Preconditions.checkNotNull(P_0);
		_1 result = new _1(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 160, 127, 102 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static RuntimeException propagate(System.Exception throwable)
	{
		throwIfUnchecked(throwable);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(throwable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ThreadDeath" })]
	[Signature("(Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 161, 174, 127, 36, 97, 103, 225, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Method getJlaMethod(string P_0, params Class[] P_1)
	{
		//Discarded unreachable code: IL_001f
		ThreadDeath threadDeath2;
		try
		{
			try
			{
				return Class.forName("sun.misc.JavaLangAccess", false, null, Throwables.___003CGetCallerID_003E()).getMethod(P_0, P_1, Throwables.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ThreadDeath threadDeath = ByteCodeHelper.MapException<ThreadDeath>(x, ByteCodeHelper.MapFlags.None);
				if (threadDeath == null)
				{
					throw;
				}
				threadDeath2 = threadDeath;
			}
		}
		catch (System.Exception x2)
		{
			ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.Unused);
			goto IL_003f;
		}
		ThreadDeath threadDeath3 = threadDeath2;
		throw Throwable.___003Cunmap_003E(threadDeath3);
		IL_003f:
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 122, 114, 119, 127, 25, 98, 104, 225, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object getJLA()
	{
		//Discarded unreachable code: IL_003d
		ThreadDeath threadDeath2;
		try
		{
			try
			{
				Class @class = Class.forName("sun.misc.SharedSecrets", false, null, Throwables.___003CGetCallerID_003E());
				Method method = @class.getMethod("getJavaLangAccess", new Class[0], Throwables.___003CGetCallerID_003E());
				return method.invoke(null, new object[0], Throwables.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ThreadDeath threadDeath = ByteCodeHelper.MapException<ThreadDeath>(x, ByteCodeHelper.MapFlags.None);
				if (threadDeath == null)
				{
					throw;
				}
				threadDeath2 = threadDeath;
			}
		}
		catch (System.Exception x2)
		{
			ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.Unused);
			goto IL_005d;
		}
		ThreadDeath threadDeath3 = threadDeath2;
		throw Throwable.___003Cunmap_003E(threadDeath3);
		IL_005d:
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(513)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Method getGetMethod()
	{
		Method jlaMethod = getJlaMethod("getStackTraceElement", ClassLiteral<Throwable>.Value, Integer.TYPE);
		_ = null;
		return jlaMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 159, 121, 99, 158, 123, 122, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Method getSizeMethod(object P_0)
	{
		//Discarded unreachable code: IL_0021, IL_0058
		Method jlaMethod;
		try
		{
			try
			{
				try
				{
					jlaMethod = getJlaMethod("getStackTraceDepth", ClassLiteral<Throwable>.Value);
					if (jlaMethod == null)
					{
						_ = null;
						goto IL_002d;
					}
				}
				catch (UnsupportedOperationException)
				{
					goto IL_0030;
				}
			}
			catch (IllegalAccessException)
			{
				goto IL_0033;
			}
		}
		catch (InvocationTargetException)
		{
			goto IL_0036;
		}
		try
		{
			try
			{
				try
				{
					jlaMethod.invoke(P_0, new object[1]
					{
						new Throwable()
					}, Throwables.___003CGetCallerID_003E());
					return jlaMethod;
				}
				catch (UnsupportedOperationException)
				{
				}
			}
			catch (IllegalAccessException)
			{
				goto IL_0068;
			}
		}
		catch (InvocationTargetException)
		{
			goto IL_006b;
		}
		object obj = null;
		goto IL_006f;
		IL_0036:
		obj = null;
		goto IL_006f;
		IL_0033:
		obj = null;
		goto IL_006f;
		IL_0030:
		obj = null;
		goto IL_006f;
		IL_006f:
		return null;
		IL_006b:
		obj = null;
		goto IL_006f;
		IL_0068:
		obj = null;
		goto IL_006f;
		IL_002d:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(50)]
	private Throwables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable", "java.lang.Throwable" })]
	[Signature("<X1:Ljava/lang/Throwable;X2:Ljava/lang/Throwable;>(Ljava/lang/Throwable;Ljava/lang/Class<TX1;>;Ljava/lang/Class<TX2;>;)V^TX1;^TX2;")]
	[LineNumberTable(new byte[] { 160, 90, 103, 103, 105 })]
	public static void propagateIfPossible([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception throwable, Class declaredType1, Class declaredType2)
	{
		Preconditions.checkNotNull(declaredType2);
		propagateIfInstanceOf(throwable, declaredType1);
		propagateIfPossible(throwable, declaredType2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 144, 98, 162, 106, 131, 100, 145, 99, 135,
		138
	})]
	public static System.Exception getRootCause(System.Exception throwable)
	{
		System.Exception ex = throwable;
		int num = 0;
		System.Exception ex2;
		while ((ex2 = Throwable.instancehelper_getCause(throwable)) != null)
		{
			throwable = ex2;
			if (throwable == ex)
			{
				System.Exception cause = throwable;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException("Loop in causal chain detected.", cause);
			}
			if (num != 0)
			{
				ex = Throwable.instancehelper_getCause(ex);
			}
			num = ((num == 0) ? 1 : 0);
		}
		return throwable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Throwable;)Ljava/util/List<Ljava/lang/Throwable;>;")]
	[LineNumberTable(new byte[]
	{
		160, 179, 103, 103, 200, 98, 162, 106, 99, 136,
		100, 145, 99, 135, 138
	})]
	public static List getCausalChain(System.Exception throwable)
	{
		Preconditions.checkNotNull(throwable);
		ArrayList arrayList = new ArrayList(4);
		((List)arrayList).add((object)throwable);
		System.Exception ex = throwable;
		int num = 0;
		System.Exception ex2;
		while ((ex2 = Throwable.instancehelper_getCause(throwable)) != null)
		{
			throwable = ex2;
			((List)arrayList).add((object)throwable);
			if (throwable == ex)
			{
				System.Exception cause = throwable;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException("Loop in causal chain detected.", cause);
			}
			if (num != 0)
			{
				ex = Throwable.instancehelper_getCause(ex);
			}
			num = ((num == 0) ? 1 : 0);
		}
		List result = Collections.unmodifiableList(arrayList);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)TX;")]
	[LineNumberTable(new byte[] { 160, 222, 127, 13, 97, 104 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static System.Exception getCauseAs(System.Exception throwable, Class expectedCauseType)
	{
		//Discarded unreachable code: IL_0013
		ClassCastException ex2;
		try
		{
			return (System.Exception)expectedCauseType.cast(Throwable.instancehelper_getCause(throwable));
		}
		catch (System.Exception x)
		{
			ClassCastException ex = ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		ClassCastException ex3 = ex2;
		Throwable.instancehelper_initCause(ex3, throwable);
		throw Throwable.___003Cunmap_003E(ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 237, 102, 108 })]
	public static string getStackTraceAsString(System.Exception throwable)
	{
		StringWriter stringWriter = new StringWriter();
		Throwable.instancehelper_printStackTrace(throwable, new PrintWriter(stringWriter));
		string result = stringWriter.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Throwable;)Ljava/util/List<Ljava/lang/StackTraceElement;>;")]
	[LineNumberTable(new byte[] { 161, 19, 103, 104, 18 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static List lazyStackTrace(System.Exception throwable)
	{
		List result = ((!lazyStackTraceIsLazy()) ? Collections.unmodifiableList(Arrays.asList(Throwable.instancehelper_getStackTrace(throwable))) : jlaStackTrace(throwable));
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 161, 92, 234, 72, 244, 72 })]
	static Throwables()
	{
		jla = getJLA();
		getStackTraceElementMethod = ((jla != null) ? getGetMethod() : null);
		getStackTraceDepthMethod = ((jla != null) ? getSizeMethod(jla) : null);
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
