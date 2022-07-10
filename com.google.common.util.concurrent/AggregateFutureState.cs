using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent.atomic;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<OutputT:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<TOutputT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 97, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)97,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AggregateFutureState : AbstractFuture.TrustedFuture
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal new class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	internal new abstract class AtomicHelper : java.lang.Object
	{
		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;Ljava/util/Set<Ljava/lang/Throwable;>;Ljava/util/Set<Ljava/lang/Throwable;>;)V")]
		internal abstract void compareAndSetSeenExceptions(AggregateFutureState P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Set P_1, Set P_2);

		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;)I")]
		internal abstract int decrementAndGetRemainingCount(AggregateFutureState P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(152)]
		private AtomicHelper()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(152)]
		internal AtomicHelper(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal new sealed class SafeAtomicHelper : AtomicHelper
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AggregateFutureState<*>;Ljava/util/Set<Ljava/lang/Throwable;>;>;")]
		internal AtomicReferenceFieldUpdater seenExceptionsUpdater;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater<Lcom/google/common/util/concurrent/AggregateFutureState<*>;>;")]
		internal AtomicIntegerFieldUpdater remainingCountUpdater;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 120, 105, 167, 135 })]
		internal SafeAtomicHelper(AtomicReferenceFieldUpdater P_0, AtomicIntegerFieldUpdater P_1)
			: base(null)
		{
			seenExceptionsUpdater = P_0;
			remainingCountUpdater = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;Ljava/util/Set<Ljava/lang/Throwable;>;Ljava/util/Set<Ljava/lang/Throwable;>;)V")]
		[LineNumberTable(new byte[] { 160, 67, 111 })]
		internal override void compareAndSetSeenExceptions(AggregateFutureState P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Set P_1, Set P_2)
		{
			seenExceptionsUpdater.compareAndSet(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;)I")]
		[LineNumberTable(186)]
		internal override int decrementAndGetRemainingCount(AggregateFutureState P_0)
		{
			int result = remainingCountUpdater.decrementAndGet(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SynchronizedAtomicHelper : AtomicHelper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(190)]
		internal SynchronizedAtomicHelper(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(190)]
		private SynchronizedAtomicHelper()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;Ljava/util/Set<Ljava/lang/Throwable;>;Ljava/util/Set<Ljava/lang/Throwable;>;)V")]
		[LineNumberTable(new byte[] { 160, 80, 104, 105, 136, 111 })]
		internal override void compareAndSetSeenExceptions(AggregateFutureState P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Set P_1, Set P_2)
		{
			lock (P_0)
			{
				if (access_0024200(P_0) == P_1)
				{
					access_0024202(P_0, P_2);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AggregateFutureState<*>;)I")]
		[LineNumberTable(new byte[] { 160, 89, 104, 108 })]
		internal override int decrementAndGetRemainingCount(AggregateFutureState P_0)
		{
			//Discarded unreachable code: IL_0010
			lock (P_0)
			{
				return access_0024306(P_0);
			}
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private sealed class ___003CARFU_003E_0 : IntrinsicAtomicReferenceFieldUpdater
	{
		public override bool compareAndSet(object P_0, object P_1, object P_2)
		{
			return Interlocked.CompareExchange(ref ((AggregateFutureState)P_0).seenExceptions, (Set)P_2, (Set)P_1) == P_1;
		}

		public override object get(object P_0)
		{
			return ((AggregateFutureState)P_0).seenExceptions;
		}

		public override void set(object P_0, object P_1)
		{
			((AggregateFutureState)P_0).seenExceptions = (Set)P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		internal ___003CARFU_003E_0()
		{
		}
	}

	[Signature("Ljava/util/Set<Ljava/lang/Throwable;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile Set seenExceptions;

	private volatile int remaining;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static AtomicHelper ATOMIC_HELPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger log;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Signature("(Ljava/util/Set<Ljava/lang/Throwable;>;)V")]
	internal abstract void addInitialException(Set P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 30, 232, 32, 233, 97, 110 })]
	internal AggregateFutureState(int P_0)
	{
		seenExceptions = null;
		remaining = P_0;
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/lang/Throwable;>;")]
	[LineNumberTable(new byte[] { 51, 105, 227, 80, 230, 70, 135, 237, 74, 147 })]
	internal Set getOrInitSeenExceptions()
	{
		Set set = seenExceptions;
		if (set == null)
		{
			set = Sets.newConcurrentHashSet();
			addInitialException(set);
			ATOMIC_HELPER.compareAndSetSeenExceptions(this, null, set);
			set = (Set)Objects.requireNonNull(seenExceptions);
		}
		return set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(145)]
	internal int decrementRemainingAndGet()
	{
		int result = ATOMIC_HELPER.decrementAndGetRemainingCount(this);
		_ = null;
		return result;
	}

	internal void clearSeenExceptions()
	{
		seenExceptions = null;
		System.Threading.Thread.MemoryBarrier();
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static Set access_0024200(AggregateFutureState P_0)
	{
		return P_0.seenExceptions;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static Set access_0024202(AggregateFutureState P_0, Set P_1)
	{
		P_0.seenExceptions = P_1;
		System.Threading.Thread.MemoryBarrier();
		return P_1;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static int access_0024306(AggregateFutureState P_0)
	{
		int result = P_0.remaining - 1;
		P_0.remaining = result;
		System.Threading.Thread.MemoryBarrier();
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159,
		129,
		133,
		217,
		130,
		143,
		114,
		byte.MaxValue,
		3,
		72,
		226,
		57,
		225,
		69,
		98,
		135,
		166,
		99,
		149
	})]
	static AggregateFutureState()
	{
		TrustedFuture.___003Cclinit_003E();
		log = Logger.getLogger(ClassLiteral<AggregateFutureState>.Value.getName(), AggregateFutureState.___003CGetCallerID_003E());
		System.Exception ex = null;
		AtomicHelper aTOMIC_HELPER;
		System.Exception ex2;
		try
		{
			_ = ClassLiteral<AggregateFutureState>.Value;
			_ = ClassLiteral<Set>.Value;
			aTOMIC_HELPER = new SafeAtomicHelper(new ___003CARFU_003E_0(), AtomicIntegerFieldUpdater.newUpdater(ClassLiteral<AggregateFutureState>.Value, "remaining", AggregateFutureState.___003CGetCallerID_003E()));
		}
		catch (System.Exception x)
		{
			ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			goto IL_0060;
		}
		goto IL_006f;
		IL_0060:
		System.Exception ex3 = ex2;
		ex = ex3;
		aTOMIC_HELPER = new SynchronizedAtomicHelper(null);
		goto IL_006f;
		IL_006f:
		ATOMIC_HELPER = aTOMIC_HELPER;
		if (ex != null)
		{
			log.log(Level.SEVERE, "SafeAtomicHelper is broken!", ex);
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
