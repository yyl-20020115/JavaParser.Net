using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.logging;
using javax.annotation;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)68,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Closeable" })]
public sealed class Closer : java.lang.Object, Closeable, AutoCloseable
{
	internal sealed class LoggingSuppressor : java.lang.Object, Suppressor
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static LoggingSuppressor INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(247)]
		internal LoggingSuppressor()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 140, 159, 38 })]
		public virtual void suppress(Closeable P_0, System.Exception P_1, System.Exception P_2)
		{
			Logger logger = Closeables.logger;
			Level wARNING = Level.WARNING;
			string text = java.lang.String.valueOf(P_0);
			int num = 42 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			logger.log(wARNING, new StringBuilder(num).append("Suppressing exception thrown when closing ").append(text).toString(), P_2);
		}

		[LineNumberTable(249)]
		static LoggingSuppressor()
		{
			INSTANCE = new LoggingSuppressor();
		}
	}

	internal sealed class SuppressingSuppressor : java.lang.Object, Suppressor
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Method addSuppressed;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 155, 191, 21, 2, 97, 130 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal static SuppressingSuppressor tryCreate()
		{
			Method method;
			try
			{
				method = ClassLiteral<Throwable>.Value.getMethod("addSuppressed", new Class[1] { ClassLiteral<Throwable>.Value }, SuppressingSuppressor.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
				goto IL_0031;
			}
			return new SuppressingSuppressor(method);
			IL_0031:
			_ = null;
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 164, 104, 103 })]
		private SuppressingSuppressor(Method P_0)
		{
			addSuppressed = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 171, 100, 161, 223, 14, 226, 61, 129, 141 })]
		public virtual void suppress(Closeable P_0, System.Exception P_1, System.Exception P_2)
		{
			if (P_1 != P_2)
			{
				try
				{
					addSuppressed.invoke(P_1, new object[1] { P_2 }, SuppressingSuppressor.___003CGetCallerID_003E());
					return;
				}
				catch (System.Exception x)
				{
					ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
				}
				_ = null;
				LoggingSuppressor.INSTANCE.suppress(P_0, P_1, P_2);
			}
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

	internal interface Suppressor
	{
		virtual void suppress(Closeable P_0, System.Exception P_1, System.Exception P_2);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Suppressor SUPPRESSOR;

	[Modifiers(Modifiers.Final)]
	internal Suppressor suppressor;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Deque<Ljava/io/Closeable;>;")]
	private Deque stack;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private System.Exception thrown;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	public static Closer create()
	{
		Closer result = new Closer(SUPPRESSOR);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/io/Closeable;>(TC;)TC;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 1, 0, 0, 68, 0, 0 })]
	[LineNumberTable(new byte[] { 79, 99, 172 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public virtual Closeable register([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})] Closeable closeable)
	{
		if (closeable != null)
		{
			stack.addFirst(closeable);
		}
		return closeable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 98, 167, 112, 145, 248, 71, 226, 58, 97,
		99, 132, 174, 133, 107, 107, 140
	})]
	public virtual void close()
	{
		System.Exception ex = thrown;
		while (!stack.isEmpty())
		{
			Closeable closeable = (Closeable)stack.removeFirst();
			System.Exception ex2;
			try
			{
				closeable.close();
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_003d;
			}
			continue;
			IL_003d:
			System.Exception ex3 = ex2;
			if (ex == null)
			{
				ex = ex3;
			}
			else
			{
				suppressor.suppress(closeable, ex, ex3);
			}
		}
		if (thrown == null && ex != null)
		{
			Throwables.propagateIfPossible(ex, ClassLiteral<IOException>.Value);
			System.Exception detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 100, 103, 103, 107 })]
	public virtual RuntimeException rethrow(System.Exception e)
	{
		Preconditions.checkNotNull(e);
		thrown = e;
		Throwables.propagateIfPossible(e, ClassLiteral<IOException>.Value);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 65, 232, 60, 236, 69, 113 })]
	internal Closer(Suppressor P_0)
	{
		stack = new ArrayDeque(4);
		suppressor = (Suppressor)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.Exception" })]
	[Signature("<X:Ljava/lang/Exception;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)Ljava/lang/RuntimeException;^Ljava/io/IOException;^TX;")]
	[LineNumberTable(new byte[] { 122, 103, 103, 107, 103 })]
	public virtual RuntimeException rethrow(System.Exception e, Class declaredType)
	{
		Preconditions.checkNotNull(e);
		thrown = e;
		Throwables.propagateIfPossible(e, ClassLiteral<IOException>.Value);
		Throwables.propagateIfPossible(e, declaredType);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.Exception", "java.lang.Exception" })]
	[Signature("<X1:Ljava/lang/Exception;X2:Ljava/lang/Exception;>(Ljava/lang/Throwable;Ljava/lang/Class<TX1;>;Ljava/lang/Class<TX2;>;)Ljava/lang/RuntimeException;^Ljava/io/IOException;^TX1;^TX2;")]
	[LineNumberTable(new byte[] { 160, 82, 103, 103, 107, 104 })]
	public virtual RuntimeException rethrow(System.Exception e, Class declaredType1, Class declaredType2)
	{
		Preconditions.checkNotNull(e);
		thrown = e;
		Throwables.propagateIfPossible(e, ClassLiteral<IOException>.Value);
		Throwables.propagateIfPossible(e, declaredType1, declaredType2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(e);
	}

	[LineNumberTable(new byte[] { 49, 102, 127, 4 })]
	static Closer()
	{
		SuppressingSuppressor suppressingSuppressor = SuppressingSuppressor.tryCreate();
		object obj = ((suppressingSuppressor != null) ? ((object)suppressingSuppressor) : ((object)LoggingSuppressor.INSTANCE));
		SUPPRESSOR = ((obj == null) ? null : ((obj as Suppressor) ?? throw new java.lang.IncompatibleClassChangeError()));
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
