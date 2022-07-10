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

public class DefineClassHelper : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	internal abstract class Helper : java.lang.Object
	{
		[Throws(new string[] { "java.lang.ClassFormatError", "javassist.CannotCompileException" })]
		[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
		internal abstract Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, Class P_4, ClassLoader P_5, ProtectionDomain P_6);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(36)]
		private Helper()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(36)]
		internal Helper(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Java11 : JavaOther
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(42)]
		internal Java11(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(42)]
		private Java11()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.ClassFormatError", "javassist.CannotCompileException" })]
		[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 159, 189, 100, 203 })]
		internal override Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, Class P_4, ClassLoader P_5, ProtectionDomain P_6)
		{
			if (P_4 != null)
			{
				Class result = toClass(P_4, P_1);
				_ = null;
				return result;
			}
			Class result2 = base.defineClass(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
			_ = null;
			return result2;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Java7 : Helper
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private SecurityActions stack;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new MethodHandle m_defineClass;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(152)]
		internal Java7(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 102, 105, 107 })]
		private Java7()
			: base(null)
		{
			stack = SecurityActions.stack;
			this.m_defineClass = getDefineClassMethodHandle();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[LineNumberTable(new byte[]
		{
			106,
			122,
			144,
			byte.MaxValue,
			52,
			69,
			97
		})]
		private MethodHandle getDefineClassMethodHandle()
		{
			//Discarded unreachable code: IL_0069
			if (access_0024400() != null && stack.getCallerClass() != java.lang.Object.instancehelper_getClass(this))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			NoSuchMethodException ex;
			try
			{
				return SecurityActions.getMethodHandle(ClassLiteral<ClassLoader>.Value, "defineClass", new Class[5]
				{
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<byte[]>.Value,
					Integer.TYPE,
					Integer.TYPE,
					ClassLiteral<ProtectionDomain>.Value
				});
			}
			catch (NoSuchMethodException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchMethodException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			NoSuchMethodException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("cannot initialize", cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.ClassFormatError" })]
		[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 124, 114, 144, 124, 53, 159, 1, 97, 116, 116 })]
		internal override Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, Class P_4, ClassLoader P_5, ProtectionDomain P_6)
		{
			//Discarded unreachable code: IL_005f
			if (stack.getCallerClass() != ClassLiteral<DefineClassHelper>.Value)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			System.Exception ex;
			try
			{
				return (Class)this.m_defineClass.invokeWithArguments(P_5, P_0, P_1, Integer.valueOf(P_2), Integer.valueOf(P_3), P_6);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			if (ex2 is RuntimeException)
			{
				throw Throwable.___003Cunmap_003E((RuntimeException)ex2);
			}
			if (ex2 is java.lang.ClassFormatError)
			{
				throw Throwable.___003Cunmap_003E((java.lang.ClassFormatError)ex2);
			}
			string s = Throwable.instancehelper_getMessage(ex2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassFormatError(s);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Java9 : Helper
	{
		internal sealed class ReferencedUnsafe : java.lang.Object
		{
			private sealed class ___003CCallerID_003E : CallerID
			{
				internal ___003CCallerID_003E()
				{
				}
			}

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private SecurityActions.TheUnsafe sunMiscUnsafeTheUnsafe;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private MethodHandle m_defineClass;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Java9 this_00240;

			[SpecialName]
			private static CallerID ___003CcallerID_003E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 12, 111, 103, 103 })]
			internal ReferencedUnsafe(Java9 P_0, SecurityActions.TheUnsafe P_1, MethodHandle P_2)
			{
				this_00240 = P_0;
				base._002Ector();
				sunMiscUnsafeTheUnsafe = P_1;
				this.m_defineClass = P_2;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.ClassFormatError" })]
			[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
			[LineNumberTable(new byte[]
			{
				22, 127, 14, 191, 6, 2, 97, 177, 159, 6,
				26, 191, 1, 98, 118, 118
			})]
			internal virtual Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, ClassLoader P_4, ProtectionDomain P_5)
			{
				//Discarded unreachable code: IL_00b1
				java.lang.Exception ex2;
				try
				{
					if (access_0024200(this_00240).invoke(access_0024100(this_00240), new object[0], ReferencedUnsafe.___003CGetCallerID_003E()) != ClassLiteral<Java9>.Value)
					{
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new java.lang.IllegalAccessError("Access denied for caller.");
					}
				}
				catch (System.Exception x)
				{
					java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
					if (ex == null)
					{
						throw;
					}
					ex2 = ex;
					goto IL_004f;
				}
				System.Exception ex3;
				try
				{
					return (Class)this.m_defineClass.invokeWithArguments(sunMiscUnsafeTheUnsafe.theUnsafe, P_0, P_1, Integer.valueOf(P_2), Integer.valueOf(P_3), P_4, P_5);
				}
				catch (System.Exception x2)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
				}
				System.Exception ex4 = ex3;
				if (ex4 is RuntimeException)
				{
					throw Throwable.___003Cunmap_003E((RuntimeException)ex4);
				}
				if (ex4 is java.lang.ClassFormatError)
				{
					throw Throwable.___003Cunmap_003E((java.lang.ClassFormatError)ex4);
				}
				string s = Throwable.instancehelper_getMessage(ex4);
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.ClassFormatError(s);
				IL_004f:
				java.lang.Exception cause = ex2;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("cannot initialize", cause);
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

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object stack;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Method getCallerClass;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ReferencedUnsafe sunMiscUnsafe;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			43, 9, 172, 130, 187, 2, 161, 134, 112, 159,
			6, 119, 191, 15, 2, 98, 178, 103, 135
		})]
		internal Java9()
			: base(null)
		{
			sunMiscUnsafe = getReferencedUnsafe();
			Class @class = null;
			try
			{
				@class = Class.forName("java.lang.StackWalker", Java9.___003CGetCallerID_003E());
			}
			catch (java.lang.ClassNotFoundException)
			{
				goto IL_002f;
			}
			goto IL_0035;
			IL_002f:
			_ = null;
			goto IL_0035;
			IL_0035:
			if (@class != null)
			{
				System.Exception ex2;
				try
				{
					Class class2 = Class.forName("java.lang.StackWalker$Option", Java9.___003CGetCallerID_003E());
					stack = @class.getMethod("getInstance", new Class[1] { class2 }, Java9.___003CGetCallerID_003E()).invoke(null, new object[1] { class2.getEnumConstants()[0] }, Java9.___003CGetCallerID_003E());
					getCallerClass = @class.getMethod("getCallerClass", new Class[0], Java9.___003CGetCallerID_003E());
					return;
				}
				catch (System.Exception x)
				{
					ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				}
				System.Exception cause = ex2;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("cannot initialize", cause);
			}
			stack = null;
			getCallerClass = null;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal static Method access_0024200(Java9 P_0)
		{
			return P_0.getCallerClass;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal static object access_0024100(Java9 P_0)
		{
			return P_0.stack;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[LineNumberTable(new byte[]
		{
			68, 127, 12, 191, 6, 2, 97, 177, 102, 150,
			100, 101, 125, 127, 8, 98
		})]
		private ReferencedUnsafe getReferencedUnsafe()
		{
			//Discarded unreachable code: IL_00b1
			java.lang.Exception ex2;
			try
			{
				if (access_0024400() != null && getCallerClass.invoke(stack, new object[0], Java9.___003CGetCallerID_003E()) != java.lang.Object.instancehelper_getClass(this))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new java.lang.IllegalAccessError("Access denied for caller.");
				}
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_004d;
			}
			System.Exception ex3;
			try
			{
				SecurityActions.TheUnsafe sunMiscUnsafeAnonymously = SecurityActions.getSunMiscUnsafeAnonymously();
				List list = (List)sunMiscUnsafeAnonymously.methods.get("defineClass");
				if (null == list)
				{
					return null;
				}
				MethodHandle methodHandle = MethodHandles.lookup(Java9.___003CGetCallerID_003E()).unreflect((Method)list.get(0));
				return new ReferencedUnsafe(this, sunMiscUnsafeAnonymously, methodHandle);
			}
			catch (System.Exception x2)
			{
				ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			}
			System.Exception cause = ex3;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("cannot initialize", cause);
			IL_004d:
			java.lang.Exception cause2 = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("cannot initialize", cause2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.ClassFormatError" })]
		[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 92, 127, 4, 191, 6, 2, 97, 145 })]
		internal override Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, Class P_4, ClassLoader P_5, ProtectionDomain P_6)
		{
			java.lang.Exception ex2;
			try
			{
				if (getCallerClass.invoke(stack, new object[0], Java9.___003CGetCallerID_003E()) != ClassLiteral<DefineClassHelper>.Value)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new java.lang.IllegalAccessError("Access denied for caller.");
				}
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_0045;
			}
			return sunMiscUnsafe.defineClass(P_0, P_1, P_2, P_3, P_5, P_6);
			IL_0045:
			java.lang.Exception cause = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("cannot initialize", cause);
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class JavaOther : Helper
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new Method m_defineClass;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private SecurityActions stack;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(187)]
		internal JavaOther(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 73, 105, 108 })]
		private JavaOther()
			: base(null)
		{
			this.m_defineClass = getDefineClassMethod();
			stack = SecurityActions.stack;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[LineNumberTable(new byte[] { 160, 78, 122, 144, 223, 52, 97 })]
		private Method getDefineClassMethod()
		{
			//Discarded unreachable code: IL_0069
			if (access_0024400() != null && stack.getCallerClass() != java.lang.Object.instancehelper_getClass(this))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			NoSuchMethodException ex;
			try
			{
				return SecurityActions.getDeclaredMethod(ClassLiteral<ClassLoader>.Value, "defineClass", new Class[5]
				{
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<byte[]>.Value,
					Integer.TYPE,
					Integer.TYPE,
					ClassLiteral<ProtectionDomain>.Value
				});
			}
			catch (NoSuchMethodException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchMethodException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			NoSuchMethodException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("cannot initialize", cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.ClassFormatError", "javassist.CannotCompileException" })]
		[IKVM.Attributes.Signature("(Ljava/lang/String;[BIILjava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[]
		{
			160, 95, 108, 113, 144, 108, 121, 53, 191, 6,
			97, 116, 116
		})]
		internal override Class defineClass(string P_0, byte[] P_1, int P_2, int P_3, Class P_4, ClassLoader P_5, ProtectionDomain P_6)
		{
			//Discarded unreachable code: IL_0078
			Class callerClass = stack.getCallerClass();
			if (callerClass != ClassLiteral<DefineClassHelper>.Value && callerClass != java.lang.Object.instancehelper_getClass(this))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			System.Exception ex;
			try
			{
				SecurityActions.setAccessible(this.m_defineClass, true);
				return (Class)this.m_defineClass.invoke(P_5, new object[5]
				{
					P_0,
					P_1,
					Integer.valueOf(P_2),
					Integer.valueOf(P_3),
					P_6
				}, JavaOther.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			if (ex2 is java.lang.ClassFormatError)
			{
				throw Throwable.___003Cunmap_003E((java.lang.ClassFormatError)ex2);
			}
			if (ex2 is RuntimeException)
			{
				throw Throwable.___003Cunmap_003E((RuntimeException)ex2);
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(ex2);
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Helper privileged;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;[B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 160, 178, 223, 9, 97 })]
	public static Class toClass(Class neighbor, byte[] bcode)
	{
		IllegalAccessException ex;
		IllegalArgumentException ex2;
		try
		{
			try
			{
				_ = ClassLiteral<DefineClassHelper>.Value;
				throw new NoSuchMethodError("java.lang.Class.getModule()Ljava.lang.Module;");
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalArgumentException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalArgumentException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0025;
		}
		object ex3 = ex;
		goto IL_0028;
		IL_0025:
		ex3 = ex2;
		goto IL_0028;
		IL_0028:
		java.lang.Exception @this = (java.lang.Exception)ex3;
		string msg = new StringBuilder().append(Throwable.instancehelper_getMessage(@this)).append(": ").append(neighbor.getName())
			.append(" has no permission to define the class")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;[B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 160, 200, 127, 6, 97 })]
	public static Class toClass(MethodHandles.Lookup lookup, byte[] bcode)
	{
		IllegalAccessException ex;
		IllegalArgumentException ex2;
		try
		{
			try
			{
				throw new NoSuchMethodError("java.lang.invoke.MethodHandles$Lookup.defineClass([B)Ljava.lang.Class;");
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalArgumentException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalArgumentException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0022;
		}
		object ex3 = ex;
		goto IL_0025;
		IL_0022:
		ex3 = ex2;
		goto IL_0025;
		IL_0025:
		java.lang.Exception @this = (java.lang.Exception)ex3;
		string msg = Throwable.instancehelper_getMessage(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;[B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		160, 146, 191, 64, 98, 136, 98, 136, 98, 105,
		149, 98
	})]
	public static Class toClass(string className, Class neighbor, ClassLoader loader, ProtectionDomain domain, byte[] bcode)
	{
		//Discarded unreachable code: IL_0016
		RuntimeException ex2;
		CannotCompileException ex3;
		java.lang.ClassFormatError classFormatError2;
		java.lang.Exception ex5;
		try
		{
			try
			{
				try
				{
					try
					{
						return privileged.defineClass(className, bcode, 0, bcode.Length, neighbor, loader, domain);
					}
					catch (System.Exception x)
					{
						RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
						if (ex == null)
						{
							throw;
						}
						ex2 = ex;
					}
				}
				catch (CannotCompileException x2)
				{
					ex3 = ByteCodeHelper.MapException<CannotCompileException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0054;
				}
			}
			catch (System.Exception x3)
			{
				java.lang.ClassFormatError classFormatError = ByteCodeHelper.MapException<java.lang.ClassFormatError>(x3, ByteCodeHelper.MapFlags.None);
				if (classFormatError == null)
				{
					throw;
				}
				classFormatError2 = classFormatError;
				goto IL_0057;
			}
		}
		catch (System.Exception x4)
		{
			java.lang.Exception ex4 = ByteCodeHelper.MapException<java.lang.Exception>(x4, ByteCodeHelper.MapFlags.None);
			if (ex4 == null)
			{
				throw;
			}
			ex5 = ex4;
			goto IL_005a;
		}
		RuntimeException ex6 = ex2;
		throw Throwable.___003Cunmap_003E(ex6);
		IL_005a:
		java.lang.Exception e = ex5;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0057:
		java.lang.ClassFormatError classFormatError3 = classFormatError2;
		System.Exception ex7 = Throwable.instancehelper_getCause(classFormatError3);
		System.Exception e2 = ((ex7 != null) ? ex7 : classFormatError3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_0054:
		CannotCompileException ex8 = ex3;
		throw Throwable.___003Cunmap_003E(ex8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;[B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 160, 215, 107, 185, 97 })]
	internal static Class toPublicClass(string P_0, byte[] P_1)
	{
		System.Exception ex;
		try
		{
			MethodHandles.Lookup lookup = MethodHandles.lookup(DefineClassHelper.___003CGetCallerID_003E());
			_ = 2;
			throw new NoSuchMethodError("java.lang.invoke.MethodHandles$Lookup.dropLookupMode(I)Ljava.lang.invoke.MethodHandles$Lookup;");
		}
		catch (System.Exception x)
		{
			ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
		}
		System.Exception e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(338)]
	private DefineClassHelper()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Helper access_0024400()
	{
		return privileged;
	}

	[LineNumberTable(new byte[] { 160, 113, 105, 104, 105, 103, 252, 60 })]
	static DefineClassHelper()
	{
		privileged = ((ClassFile.___003C_003EMAJOR_VERSION > 54) ? new Java11(null) : ((ClassFile.___003C_003EMAJOR_VERSION >= 53) ? new Java9() : ((ClassFile.___003C_003EMAJOR_VERSION < 51) ? ((Helper)new JavaOther(null)) : ((Helper)new Java7(null)))));
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
