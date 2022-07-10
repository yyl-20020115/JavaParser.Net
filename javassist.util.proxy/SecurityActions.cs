using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.invoke;
using java.lang.reflect;
using java.security;
using java.util;
using javassist.bytecode;

namespace javassist.util.proxy;

internal class SecurityActions : SecurityManager
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedAction<[Ljava/lang/reflect/Method;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getDeclaredMethods", "(Ljava.lang.Class;)[Ljava.lang.reflect.Method;")]
	internal class _1 : java.lang.Object, PrivilegedAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024clazz;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(65)]
		public virtual Method[] run()
		{
			Method[] declaredMethods = val_0024clazz.getDeclaredMethods(_1.___003CGetCallerID_003E());
			_ = null;
			return declaredMethods;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(63)]
		internal _1(Class P_0)
		{
			val_0024clazz = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(63)]
		public virtual object run()
		{
			Method[] result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedAction<[Ljava/lang/reflect/Constructor<*>;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getDeclaredConstructors", "(Ljava.lang.Class;)[Ljava.lang.reflect.Constructor;")]
	internal class _2 : java.lang.Object, PrivilegedAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024clazz;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(77)]
		internal _2(Class P_0)
		{
			val_0024clazz = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()[Ljava/lang/reflect/Constructor<*>;")]
		[LineNumberTable(79)]
		public virtual Constructor[] run()
		{
			Constructor[] declaredConstructors = val_0024clazz.getDeclaredConstructors(_2.___003CGetCallerID_003E());
			_ = null;
			return declaredConstructors;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(77)]
		public virtual object run()
		{
			Constructor[] result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljava/lang/invoke/MethodHandle;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getMethodHandle", "(Ljava.lang.Class;Ljava.lang.String;[Ljava.lang.Class;)Ljava.lang.invoke.MethodHandle;")]
	internal class _3 : java.lang.Object, PrivilegedExceptionAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024clazz;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024name;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class[] val_0024params;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(90)]
		internal _3(Class P_0, string P_1, Class[] P_2)
		{
			val_0024clazz = P_0;
			val_0024name = P_1;
			val_0024params = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.IllegalAccessException", "java.lang.NoSuchMethodException", "java.lang.SecurityException" })]
		[LineNumberTable(new byte[] { 43, 125, 103, 113, 103 })]
		public virtual MethodHandle run()
		{
			Method declaredMethod = val_0024clazz.getDeclaredMethod(val_0024name, val_0024params, _3.___003CGetCallerID_003E());
			declaredMethod.setAccessible(flag: true);
			MethodHandle result = MethodHandles.lookup(_3.___003CGetCallerID_003E()).unreflect(declaredMethod);
			declaredMethod.setAccessible(flag: false);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(90)]
		public virtual object run()
		{
			MethodHandle result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljava/lang/reflect/Method;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getDeclaredMethod", "(Ljava.lang.Class;Ljava.lang.String;[Ljava.lang.Class;)Ljava.lang.reflect.Method;")]
	internal class _4 : java.lang.Object, PrivilegedExceptionAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024clazz;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024name;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class[] val_0024types;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(116)]
		internal _4(Class P_0, string P_1, Class[] P_2)
		{
			val_0024clazz = P_0;
			val_0024name = P_1;
			val_0024types = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(118)]
		public virtual Method run()
		{
			Method declaredMethod = val_0024clazz.getDeclaredMethod(val_0024name, val_0024types, _4.___003CGetCallerID_003E());
			_ = null;
			return declaredMethod;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(116)]
		public virtual object run()
		{
			Method result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljava/lang/reflect/Constructor<*>;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getDeclaredConstructor", "(Ljava.lang.Class;[Ljava.lang.Class;)Ljava.lang.reflect.Constructor;")]
	internal class _5 : java.lang.Object, PrivilegedExceptionAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024clazz;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class[] val_0024types;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(140)]
		internal _5(Class P_0, Class[] P_1)
		{
			val_0024clazz = P_0;
			val_0024types = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[IKVM.Attributes.Signature("()Ljava/lang/reflect/Constructor<*>;")]
		[LineNumberTable(142)]
		public virtual Constructor run()
		{
			Constructor declaredConstructor = val_0024clazz.getDeclaredConstructor(val_0024types, _5.___003CGetCallerID_003E());
			_ = null;
			return declaredConstructor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(140)]
		public virtual object run()
		{
			Constructor result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedAction<Ljava/lang/Void;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "setAccessible", "(Ljava.lang.reflect.AccessibleObject;Z)V")]
	internal class _6 : java.lang.Object, PrivilegedAction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AccessibleObject val_0024ao;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal bool val_0024accessible;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(161)]
		internal _6(AccessibleObject P_0, bool P_1)
		{
			val_0024ao = P_0;
			val_0024accessible = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 113, 113 })]
		public virtual java.lang.Void run()
		{
			val_0024ao.setAccessible(val_0024accessible);
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(161)]
		public virtual object run()
		{
			java.lang.Void result = this.run();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljava/lang/Void;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "set", "(Ljava.lang.reflect.Field;Ljava.lang.Object;Ljava.lang.Object;)V")]
	internal class _7 : java.lang.Object, PrivilegedExceptionAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Field val_0024fld;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024target;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024value;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(178)]
		internal _7(Field P_0, object P_1, object P_2)
		{
			val_0024fld = P_0;
			val_0024target = P_1;
			val_0024value = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 66, 124 })]
		public virtual java.lang.Void run()
		{
			val_0024fld.set(val_0024target, val_0024value, _7.___003CGetCallerID_003E());
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(178)]
		public virtual object run()
		{
			java.lang.Void result = this.run();
			_ = null;
			return result;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljavassist/util/proxy/SecurityActions$TheUnsafe;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "getSunMiscUnsafeAnonymously", "()Ljavassist.util.proxy.SecurityActions$TheUnsafe;")]
	internal class _8 : java.lang.Object, PrivilegedExceptionAction
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
		[LineNumberTable(197)]
		internal _8()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.ClassNotFoundException", "java.lang.NoSuchFieldException", "java.lang.SecurityException", "java.lang.IllegalArgumentException", "java.lang.IllegalAccessException" })]
		[LineNumberTable(new byte[] { 160, 86, 112, 113, 103, 127, 0, 103, 102 })]
		public virtual TheUnsafe run()
		{
			Class @class = Class.forName("sun.misc.Unsafe", _8.___003CGetCallerID_003E());
			Field declaredField = @class.getDeclaredField("theUnsafe", _8.___003CGetCallerID_003E());
			declaredField.setAccessible(flag: true);
			SecurityActions stack = SecurityActions.stack;
			Objects.requireNonNull(stack);
			TheUnsafe theUnsafe = new TheUnsafe(stack, @class, declaredField.get(null, _8.___003CGetCallerID_003E()));
			declaredField.setAccessible(flag: false);
			disableWarning(theUnsafe);
			return theUnsafe;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(197)]
		public virtual object run()
		{
			TheUnsafe result = this.run();
			_ = null;
			return result;
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

	internal class TheUnsafe : java.lang.Object
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final)]
		[IKVM.Attributes.Signature("Ljava/lang/Class<*>;")]
		internal Class @unsafe;

		[Modifiers(Modifiers.Final)]
		internal object theUnsafe;

		[Modifiers(Modifiers.Final)]
		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/reflect/Method;>;>;")]
		internal Map methods;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SecurityActions this_00240;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 150, 127, 16, 103 })]
		public virtual object call(string P_0, params object[] P_1)
		{
			//Discarded unreachable code: IL_001b
			System.Exception ex;
			try
			{
				return getM(P_0, P_1).invoke(theUnsafe, P_1, TheUnsafe.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception @this = ex;
			Throwable.instancehelper_printStackTrace(@this);
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[]
		{
			160,
			127,
			239,
			60,
			235,
			69,
			103,
			103,
			127,
			3,
			116,
			122,
			133,
			127,
			0,
			122,
			52,
			134,
			byte.MaxValue,
			0,
			56,
			233,
			74
		})]
		internal TheUnsafe(SecurityActions P_0, Class P_1, object P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			methods = new HashMap();
			@unsafe = P_1;
			theUnsafe = P_2;
			Method[] declaredMethods = @unsafe.getDeclaredMethods(TheUnsafe.___003CGetCallerID_003E());
			int num = declaredMethods.Length;
			for (int i = 0; i < num; i++)
			{
				Method method = declaredMethods[i];
				if (!methods.containsKey(method.getName()))
				{
					methods.put(method.getName(), Collections.singletonList(method));
					continue;
				}
				if (((List)methods.get(method.getName())).size() == 1)
				{
					Map map = methods;
					string name = method.getName();
					ArrayList.___003Cclinit_003E();
					map.put(name, new ArrayList((Collection)methods.get(method.getName())));
				}
				((List)methods.get(method.getName())).add(method);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(258)]
		private Method getM(string P_0, object[] P_1)
		{
			return (Method)((List)methods.get(P_0)).get(0);
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static SecurityActions stack;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	[LineNumberTable(54)]
	public virtual Class getCallerClass()
	{
		return getClassContext()[2];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[]
	{
		61,
		103,
		174,
		byte.MaxValue,
		14,
		71,
		97,
		109,
		145
	})]
	internal static Method getDeclaredMethod(Class P_0, string P_1, Class[] P_2)
	{
		//Discarded unreachable code: IL_002e
		if (java.lang.System.getSecurityManager() == null)
		{
			return P_0.getDeclaredMethod(P_1, P_2, SecurityActions.___003CGetCallerID_003E());
		}
		PrivilegedActionException ex;
		try
		{
			return (Method)AccessController.doPrivileged(new _4(P_0, P_1, P_2), SecurityActions.___003CGetCallerID_003E());
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		if (ex2.getCause() is NoSuchMethodException)
		{
			throw Throwable.___003Cunmap_003E((NoSuchMethodException)ex2.getCause());
		}
		System.Exception cause = ex2.getCause();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 103, 130, 103, 137, 242, 71 })]
	internal static void setAccessible(AccessibleObject P_0, bool P_1)
	{
		if (java.lang.System.getSecurityManager() == null)
		{
			P_0.setAccessible(P_1);
		}
		else
		{
			AccessController.doPrivileged(new _6(P_0, P_1), SecurityActions.___003CGetCallerID_003E());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/invoke/MethodHandle;")]
	[LineNumberTable(new byte[]
	{
		39,
		byte.MaxValue,
		14,
		76,
		97,
		109,
		113
	})]
	internal static MethodHandle getMethodHandle(Class P_0, string P_1, Class[] P_2)
	{
		//Discarded unreachable code: IL_0019
		PrivilegedActionException ex;
		try
		{
			return (MethodHandle)AccessController.doPrivileged(new _3(P_0, P_1, P_2), SecurityActions.___003CGetCallerID_003E());
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		if (ex2.getCause() is NoSuchMethodException)
		{
			throw Throwable.___003Cunmap_003E((NoSuchMethodException)ex2.getCause());
		}
		System.Exception cause = ex2.getCause();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160,
		82,
		byte.MaxValue,
		11,
		78,
		97,
		109,
		113,
		109,
		118,
		110,
		108,
		118
	})]
	internal static TheUnsafe getSunMiscUnsafeAnonymously()
	{
		//Discarded unreachable code: IL_0016
		PrivilegedActionException ex;
		try
		{
			return (TheUnsafe)AccessController.doPrivileged(new _8(), SecurityActions.___003CGetCallerID_003E());
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		if (ex2.getCause() is java.lang.ClassNotFoundException)
		{
			throw Throwable.___003Cunmap_003E((java.lang.ClassNotFoundException)ex2.getCause());
		}
		if (ex2.getCause() is NoSuchFieldException)
		{
			System.Exception cause = ex2.getCause();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException("No such instance.", cause);
		}
		if (ex2.getCause() is IllegalAccessException || ex2.getCause() is SecurityException)
		{
			System.Exception cause2 = ex2.getCause();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException("Security denied access.", cause2);
		}
		System.Exception cause3 = ex2.getCause();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)[Ljava/lang/reflect/Constructor<*>;")]
	[LineNumberTable(new byte[] { 23, 103, 142 })]
	internal static Constructor[] getDeclaredConstructors(Class P_0)
	{
		if (java.lang.System.getSecurityManager() == null)
		{
			Constructor[] declaredConstructors = P_0.getDeclaredConstructors(SecurityActions.___003CGetCallerID_003E());
			_ = null;
			return declaredConstructors;
		}
		return (Constructor[])AccessController.doPrivileged(new _2(P_0), SecurityActions.___003CGetCallerID_003E());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)[Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 9, 103, 142 })]
	internal static Method[] getDeclaredMethods(Class P_0)
	{
		if (java.lang.System.getSecurityManager() == null)
		{
			Method[] declaredMethods = P_0.getDeclaredMethods(SecurityActions.___003CGetCallerID_003E());
			_ = null;
			return declaredMethods;
		}
		return (Method[])AccessController.doPrivileged(new _1(P_0), SecurityActions.___003CGetCallerID_003E());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	internal SecurityActions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<*>;")]
	[LineNumberTable(new byte[]
	{
		85,
		103,
		173,
		byte.MaxValue,
		13,
		71,
		97,
		109,
		145
	})]
	internal static Constructor getDeclaredConstructor(Class P_0, Class[] P_1)
	{
		//Discarded unreachable code: IL_002c
		if (java.lang.System.getSecurityManager() == null)
		{
			return P_0.getDeclaredConstructor(P_1, SecurityActions.___003CGetCallerID_003E());
		}
		PrivilegedActionException ex;
		try
		{
			return (Constructor)AccessController.doPrivileged(new _5(P_0, P_1), SecurityActions.___003CGetCallerID_003E());
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		if (ex2.getCause() is NoSuchMethodException)
		{
			throw Throwable.___003Cunmap_003E((NoSuchMethodException)ex2.getCause());
		}
		System.Exception cause = ex2.getCause();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.IllegalAccessException" })]
	[LineNumberTable(new byte[]
	{
		123,
		103,
		178,
		byte.MaxValue,
		6,
		76,
		226,
		60,
		97,
		109,
		113,
		177
	})]
	internal static void set(Field P_0, object P_1, object P_2)
	{
		if (java.lang.System.getSecurityManager() == null)
		{
			P_0.set(P_1, P_2, SecurityActions.___003CGetCallerID_003E());
			return;
		}
		PrivilegedActionException ex;
		try
		{
			AccessController.doPrivileged(new _7(P_0, P_1, P_2), SecurityActions.___003CGetCallerID_003E());
			return;
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		if (ex2.getCause() is NoSuchMethodException)
		{
			throw Throwable.___003Cunmap_003E((IllegalAccessException)ex2.getCause());
		}
		System.Exception cause = ex2.getCause();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 163, 105, 101, 112, 113, 127, 41, 99 })]
	internal static void disableWarning(TheUnsafe P_0)
	{
		try
		{
			if (ClassFile.___003C_003EMAJOR_VERSION >= 53)
			{
				Class @class = Class.forName("jdk.internal.module.IllegalAccessLogger", SecurityActions.___003CGetCallerID_003E());
				Field declaredField = @class.getDeclaredField("logger", SecurityActions.___003CGetCallerID_003E());
				P_0.call("putObjectVolatile", @class, P_0.call("staticFieldOffset", declaredField), null);
			}
			return;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
	}

	[LineNumberTable(38)]
	static SecurityActions()
	{
		SecurityManager.___003Cclinit_003E();
		stack = new SecurityActions();
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
