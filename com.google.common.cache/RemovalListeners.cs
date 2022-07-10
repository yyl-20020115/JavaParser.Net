using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.cache;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public sealed class RemovalListeners : Object
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : RemovalListener
	{
		private readonly Executor arg_00241;

		private readonly RemovalListener arg_00242;

		internal ___003C_003EAnon0(Executor P_0, RemovalListener P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void onRemoval(RemovalNotification P_0)
		{
			lambda_0024asynchronous_00241(arg_00241, arg_00242, P_0);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : Runnable
	{
		private readonly RemovalListener arg_00241;

		private readonly RemovalNotification arg_00242;

		internal ___003C_003EAnon1(RemovalListener P_0, RemovalNotification P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			lambda_0024asynchronous_00240(arg_00241, arg_00242);
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	private static void lambda_0024asynchronous_00241(Executor P_0, RemovalListener P_1, RemovalNotification P_2)
	{
		P_0.execute(new ___003C_003EAnon1(P_1, P_2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	private static void lambda_0024asynchronous_00240(RemovalListener P_0, RemovalNotification P_1)
	{
		P_0.onRemoval(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	private RemovalListeners()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/RemovalListener<TK;TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/cache/RemovalListener<TK;TV;>;")]
	[LineNumberTable(new byte[] { 159, 185, 103, 103 })]
	public static RemovalListener asynchronous(RemovalListener listener, Executor executor)
	{
		Preconditions.checkNotNull(listener);
		Preconditions.checkNotNull(executor);
		return new ___003C_003EAnon0(executor, listener);
	}
}
