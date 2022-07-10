using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<InputT:Ljava/lang/Object;OutputT:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AggregateFutureState<TOutputT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 171, 0, 0,
	17, 1, 0, 0, 0, 171, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)171,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AggregateFuture : AggregateFutureState
{
	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/AggregateFuture$ReleaseResourcesReason;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class ReleaseResourcesReason : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ReleaseResourcesReason OUTPUT_FUTURE_DONE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ReleaseResourcesReason ALL_INPUT_FUTURES_PROCESSED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ReleaseResourcesReason[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(335)]
		private ReleaseResourcesReason(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(335)]
		private static ReleaseResourcesReason[] _0024values()
		{
			return new ReleaseResourcesReason[2] { OUTPUT_FUTURE_DONE, ALL_INPUT_FUTURES_PROCESSED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(335)]
		public static ReleaseResourcesReason[] values()
		{
			return (ReleaseResourcesReason[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(335)]
		public static ReleaseResourcesReason valueOf(string P_0)
		{
			return (ReleaseResourcesReason)java.lang.Enum.valueOf(ClassLiteral<ReleaseResourcesReason>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 160, 222, 112, 16 })]
		static ReleaseResourcesReason()
		{
			OUTPUT_FUTURE_DONE = new ReleaseResourcesReason("OUTPUT_FUTURE_DONE", 0);
			ALL_INPUT_FUTURES_PROCESSED = new ReleaseResourcesReason("ALL_INPUT_FUTURES_PROCESSED", 1);
			_0024VALUES = _0024values();
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly AggregateFuture arg_00241;

		private readonly ListenableFuture arg_00242;

		private readonly int arg_00243;

		internal ___003C_003EAnon0(AggregateFuture P_0, ListenableFuture P_1, int P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void run()
		{
			arg_00241.lambda_0024init_00240(arg_00242, arg_00243);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : Runnable
	{
		private readonly AggregateFuture arg_00241;

		private readonly ImmutableCollection arg_00242;

		internal ___003C_003EAnon1(AggregateFuture P_0, ImmutableCollection P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			arg_00241.lambda_0024init_00241(arg_00242);
			_ = null;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Signature("Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<+TInputT;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableCollection futures;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool allMustSucceed;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool collectsValues;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 211, 231, 71, 103 })]
	internal virtual void releaseResources(ReleaseResourcesReason P_0)
	{
		Preconditions.checkNotNull(P_0);
		futures = null;
	}

	internal abstract void handleAllCompleted();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<Ljava/lang/Throwable;>;Ljava/lang/Throwable;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 237, 130, 99, 104, 227, 71, 226, 55, 233,
		76
	})]
	private static bool addCausalChain(Set P_0, System.Exception P_1)
	{
		for (System.Exception ex = P_1; ex != null; ex = Throwable.instancehelper_getCause(ex))
		{
			if (!P_0.add(ex))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 116, 104, 103, 102, 115 })]
	private static void log(System.Exception P_0)
	{
		string msg = ((!(P_0 is Error)) ? "Got more than one input Future failure. Logging failures after the first" : "Input Future failed with Error");
		logger.log(Level.SEVERE, msg, P_0);
	}

	[Signature("(ITInputT;)V")]
	internal abstract void collectOneValue(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 81, 135, 168, 104, 163, 109, 99, 104, 225,
		73, 232, 72, 136
	})]
	private void handleException(System.Exception P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (allMustSucceed && !setException(P_0) && addCausalChain(getOrInitSeenExceptions(), P_0))
		{
			log(P_0);
		}
		else if (P_0 is Error)
		{
			log(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Ljava/util/concurrent/Future<+TInputT;>;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 177, 99, 98, 123, 104, 136, 100, 130, 102,
		230, 72, 109
	})]
	private void processCompleted([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableCollection P_0)
	{
		if (P_0 != null)
		{
			int num = 0;
			UnmodifiableIterator unmodifiableIterator = P_0.iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				Future future = (Future)((Iterator)unmodifiableIterator).next();
				if (!future.isCancelled())
				{
					collectValueFromNonCancelledFuture(num, future);
				}
				num++;
			}
		}
		clearSeenExceptions();
		handleAllCompleted();
		releaseResources(ReleaseResourcesReason.ALL_INPUT_FUTURES_PROCESSED);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ILjava/util/concurrent/Future<+TInputT;>;)V")]
	[LineNumberTable(new byte[]
	{
		160,
		154,
		byte.MaxValue,
		12,
		69,
		226,
		60,
		97,
		172,
		2,
		97,
		135
	})]
	private void collectValueFromNonCancelledFuture(int P_0, Future P_1)
	{
		ExecutionException ex;
		System.Exception ex2;
		try
		{
			try
			{
				collectOneValue(P_0, Futures.getDone(P_1));
				return;
			}
			catch (ExecutionException x)
			{
				ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (System.Exception x2)
		{
			ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			goto IL_0028;
		}
		ExecutionException @this = ex;
		handleException(Throwable.instancehelper_getCause(@this));
		return;
		IL_0028:
		System.Exception ex3 = ex2;
		handleException(ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Ljava/util/concurrent/Future<+TInputT;>;>;)V")]
	[LineNumberTable(new byte[] { 160, 166, 103, 113, 99, 137 })]
	private void decrementCountAndMaybeComplete([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableCollection P_0)
	{
		int num = decrementRemainingAndGet();
		Preconditions.checkState(num >= 0, (object)"Less than 0 remaining futures");
		if (num == 0)
		{
			processCompleted(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 93, 168, 103, 138, 236, 72, 103, 35, 98, 98 })]
	private void lambda_0024init_00240(ListenableFuture P_0, int P_1)
	{
		try
		{
			if (P_0.isCancelled())
			{
				futures = null;
				cancel(false);
			}
			else
			{
				collectValueFromNonCancelledFuture(P_1, P_0);
			}
		}
		finally
		{
			decrementCountAndMaybeComplete(null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
	[LineNumberTable(181)]
	private void lambda_0024init_00241(ImmutableCollection P_0)
	{
		decrementCountAndMaybeComplete(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<+TInputT;>;>;ZZ)V")]
	[LineNumberTable(new byte[] { 159, 125, 68, 110, 113, 103, 103 })]
	internal AggregateFuture(ImmutableCollection P_0, bool P_1, bool P_2)
		: base(P_0.size())
	{
		futures = (ImmutableCollection)Preconditions.checkNotNull(P_0);
		allMustSucceed = P_1;
		collectsValues = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 26, 134, 103, 139, 112, 103, 123, 104, 226, 70 })]
	protected internal sealed override void afterDone()
	{
		base.afterDone();
		ImmutableCollection immutableCollection = futures;
		releaseResources(ReleaseResourcesReason.OUTPUT_FUTURE_DONE);
		if (isCancelled() && immutableCollection != null)
		{
			int mayInterruptIfRunning = (wasInterrupted() ? 1 : 0);
			UnmodifiableIterator unmodifiableIterator = immutableCollection.iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				Future future = (Future)((Iterator)unmodifiableIterator).next();
				future.cancel((byte)mayInterruptIfRunning != 0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 46, 103, 99, 159, 22 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal sealed override string pendingToString()
	{
		ImmutableCollection immutableCollection = futures;
		if (immutableCollection != null)
		{
			string text = java.lang.String.valueOf(immutableCollection);
			int num = 8 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("futures=").append(text).toString();
			_ = null;
			return result;
		}
		string result2 = base.pendingToString();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		66, 172, 109, 104, 225, 70, 232, 74, 98, 127,
		1, 102, 238, 84, 229, 44, 229, 85, 98, 226,
		82, 115, 111, 127, 5, 110, 130
	})]
	internal void init()
	{
		java.util.Objects.requireNonNull(futures);
		if (futures.isEmpty())
		{
			handleAllCompleted();
		}
		else if (allMustSucceed)
		{
			int num = 0;
			UnmodifiableIterator unmodifiableIterator = futures.iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				ListenableFuture listenableFuture = (ListenableFuture)((Iterator)unmodifiableIterator).next();
				int num2 = num;
				num++;
				int num3 = num2;
				listenableFuture.addListener(new ___003C_003EAnon0(this, listenableFuture, num3), MoreExecutors.directExecutor());
			}
		}
		else
		{
			ImmutableCollection immutableCollection = ((!collectsValues) ? null : futures);
			Runnable r = new ___003C_003EAnon1(this, immutableCollection);
			UnmodifiableIterator unmodifiableIterator2 = futures.iterator();
			while (((Iterator)unmodifiableIterator2).hasNext())
			{
				ListenableFuture listenableFuture2 = (ListenableFuture)((Iterator)unmodifiableIterator2).next();
				listenableFuture2.addListener(r, MoreExecutors.directExecutor());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<Ljava/lang/Throwable;>;)V")]
	[LineNumberTable(new byte[] { 160, 124, 103, 232, 82, 151 })]
	internal sealed override void addInitialException(Set P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (!isCancelled())
		{
			addCausalChain(P_0, (System.Exception)java.util.Objects.requireNonNull(tryInternalFastPathGetFailure()));
		}
	}

	[LineNumberTable(47)]
	static AggregateFuture()
	{
		AggregateFutureState.___003Cclinit_003E();
		logger = Logger.getLogger(ClassLiteral<AggregateFuture>.Value.getName(), AggregateFuture.___003CGetCallerID_003E());
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
