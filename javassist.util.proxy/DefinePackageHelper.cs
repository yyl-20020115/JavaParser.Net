using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.invoke;
using java.lang.reflect;
using java.net;
using javassist.bytecode;

namespace javassist.util.proxy;

public class DefinePackageHelper : java.lang.Object
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
		[Throws(new string[] { "java.lang.IllegalArgumentException" })]
		internal abstract Package definePackage(ClassLoader P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6, string P_7, URL P_8);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(35)]
		private Helper()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(35)]
		internal Helper(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Java7 : Helper
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private SecurityActions stack;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new MethodHandle m_definePackage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(54)]
		internal Java7(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 4, 105, 107 })]
		private Java7()
			: base(null)
		{
			stack = SecurityActions.stack;
			this.m_definePackage = getDefinePackageMethodHandle();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			9,
			115,
			144,
			byte.MaxValue,
			76,
			69,
			97
		})]
		private MethodHandle getDefinePackageMethodHandle()
		{
			//Discarded unreachable code: IL_007a
			if (stack.getCallerClass() != java.lang.Object.instancehelper_getClass(this))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			NoSuchMethodException ex;
			try
			{
				return SecurityActions.getMethodHandle(ClassLiteral<ClassLoader>.Value, "definePackage", new Class[8]
				{
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<URL>.Value
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
		[Throws(new string[] { "java.lang.IllegalArgumentException" })]
		[LineNumberTable(new byte[] { 28, 114, 144, 159, 56, 97, 116, 148 })]
		internal override Package definePackage(ClassLoader P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6, string P_7, URL P_8)
		{
			//Discarded unreachable code: IL_0065
			if (stack.getCallerClass() != ClassLiteral<DefinePackageHelper>.Value)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			System.Exception ex;
			try
			{
				return (Package)this.m_definePackage.invokeWithArguments(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			if (ex2 is IllegalArgumentException)
			{
				throw Throwable.___003Cunmap_003E((IllegalArgumentException)ex2);
			}
			if (ex2 is RuntimeException)
			{
				throw Throwable.___003Cunmap_003E((RuntimeException)ex2);
			}
			return null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Java9 : Helper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(42)]
		internal Java9(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(42)]
		private Java9()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.IllegalArgumentException" })]
		[LineNumberTable(50)]
		internal override Package definePackage(ClassLoader P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6, string P_7, URL P_8)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("define package has been disabled for jigsaw");
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
		private SecurityActions stack;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new Method m_definePackage;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal JavaOther(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 41, 105, 107 })]
		private JavaOther()
			: base(null)
		{
			stack = SecurityActions.stack;
			this.m_definePackage = getDefinePackageMethod();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			46,
			115,
			144,
			byte.MaxValue,
			76,
			69,
			97
		})]
		private Method getDefinePackageMethod()
		{
			//Discarded unreachable code: IL_007a
			if (stack.getCallerClass() != java.lang.Object.instancehelper_getClass(this))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			NoSuchMethodException ex;
			try
			{
				return SecurityActions.getDeclaredMethod(ClassLiteral<ClassLoader>.Value, "definePackage", new Class[8]
				{
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<java.lang.String>.Value,
					ClassLiteral<URL>.Value
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
		[Throws(new string[] { "java.lang.IllegalArgumentException" })]
		[LineNumberTable(new byte[]
		{
			65, 114, 144, 108, 223, 57, 97, 104, 108, 104,
			140, 148
		})]
		internal override Package definePackage(ClassLoader P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6, string P_7, URL P_8)
		{
			//Discarded unreachable code: IL_0072
			if (stack.getCallerClass() != ClassLiteral<DefinePackageHelper>.Value)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.IllegalAccessError("Access denied for caller.");
			}
			System.Exception ex;
			try
			{
				this.m_definePackage.setAccessible(flag: true);
				return (Package)this.m_definePackage.invoke(P_0, new object[8] { P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8 }, JavaOther.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			if (ex2 is InvocationTargetException)
			{
				System.Exception targetException = ((InvocationTargetException)ex2).getTargetException();
				if (targetException is IllegalArgumentException)
				{
					throw Throwable.___003Cunmap_003E((IllegalArgumentException)targetException);
				}
			}
			if (ex2 is RuntimeException)
			{
				throw Throwable.___003Cunmap_003E((RuntimeException)ex2);
			}
			return null;
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Helper privileged;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		115,
		byte.MaxValue,
		17,
		74,
		226,
		57,
		161,
		129,
		97,
		140
	})]
	public static void definePackage(string className, ClassLoader loader)
	{
		java.lang.Exception ex3;
		try
		{
			try
			{
				privileged.definePackage(loader, className, null, null, null, null, null, null, null);
				return;
			}
			catch (IllegalArgumentException)
			{
			}
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex2 = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex2 == null)
			{
				throw;
			}
			ex3 = ex2;
			goto IL_002d;
		}
		_ = null;
		return;
		IL_002d:
		java.lang.Exception e = ex3;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	private DefinePackageHelper()
	{
	}

	[LineNumberTable(new byte[] { 86, 105, 113, 243, 61 })]
	static DefinePackageHelper()
	{
		privileged = ((ClassFile.___003C_003EMAJOR_VERSION >= 53) ? new Java9(null) : ((ClassFile.___003C_003EMAJOR_VERSION < 51) ? ((Helper)new JavaOther(null)) : ((Helper)new Java7(null))));
	}
}
