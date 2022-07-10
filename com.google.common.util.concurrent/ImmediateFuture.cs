using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using java.util.logging;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 90, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)90,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
internal class ImmediateFuture : java.lang.Object, ListenableFuture, Future
{
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 15, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)15,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class ImmediateCancelledFuture : AbstractFuture.TrustedFuture
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ImmediateFuture$ImmediateCancelledFuture<Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 15, 0, 0 })]
		internal static ImmediateCancelledFuture INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 54, 104, 104 })]
		internal ImmediateCancelledFuture()
		{
			cancel(false);
		}

		[LineNumberTable(new byte[] { 159, 117, 133, 52 })]
		static ImmediateCancelledFuture()
		{
			TrustedFuture.___003Cclinit_003E();
			INSTANCE = ((!AbstractFuture.GENERATE_CANCELLATION_CAUSES) ? new ImmediateCancelledFuture() : null);
		}
	}

	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 24, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)24,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class ImmediateFailedFuture : AbstractFuture.TrustedFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 45, 104, 104 })]
		internal ImmediateFailedFuture(System.Exception P_0)
		{
			base.setException(P_0);
		}

		[HideFromJava]
		static ImmediateFailedFuture()
		{
			TrustedFuture.___003Cclinit_003E();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
	internal static ListenableFuture NULL;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger log;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TV;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	private object value;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)V")]
	[LineNumberTable(new byte[] { 159, 181, 104, 103 })]
	internal ImmediateFuture([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_0)
	{
		value = P_0;
	}

	[Signature("()TV;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get()
	{
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159,
		187,
		108,
		140,
		254,
		72,
		229,
		57,
		161,
		byte.MaxValue,
		75,
		69
	})]
	public virtual void addListener(Runnable P_0, Executor P_1)
	{
		Preconditions.checkNotNull((object)P_0, (object)"Runnable was null.");
		Preconditions.checkNotNull((object)P_1, (object)"Executor was null.");
		RuntimeException ex2;
		try
		{
			P_1.execute(P_0);
			return;
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
		RuntimeException thrown = ex2;
		Logger logger = log;
		Level sEVERE = Level.SEVERE;
		string text = java.lang.String.valueOf(P_0);
		string text2 = java.lang.String.valueOf(P_1);
		int num = 57 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		logger.log(sEVERE, new StringBuilder(num).append("RuntimeException while executing runnable ").append(text).append(" with executor ")
			.append(text2)
			.toString(), thrown);
	}

	public virtual bool cancel(bool P_0)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
	[LineNumberTable(new byte[] { 24, 103 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get(long P_0, TimeUnit P_1)
	{
		Preconditions.checkNotNull(P_1);
		object result = get();
		_ = null;
		return result;
	}

	public virtual bool isCancelled()
	{
		return false;
	}

	public virtual bool isDone()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override string toString()
	{
		string text = base.toString();
		string text2 = java.lang.String.valueOf(value);
		int num = 27 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append(text).append("[status=SUCCESS, result=[").append(text2)
			.append("]]")
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 175, 139 })]
	static ImmediateFuture()
	{
		NULL = new ImmediateFuture(null);
		log = Logger.getLogger(ClassLiteral<ImmediateFuture>.Value.getName(), ImmediateFuture.___003CGetCallerID_003E());
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
