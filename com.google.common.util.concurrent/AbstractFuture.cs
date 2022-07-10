using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using com.google.common.util.concurrent.@internal;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.security;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.concurrent.locks;
using java.util.logging;
using javax.annotation;
using sun.misc;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/internal/InternalFutureFailureAccess;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 1, 82, 0, 0 })]
[ConstantPool(new object[]
{
	(ushort)338,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
public abstract class AbstractFuture : InternalFutureFailureAccess, ListenableFuture, Future
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	internal abstract class AtomicHelper : java.lang.Object
	{
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Z")]
		internal abstract bool casWaiters(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_2);

		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		internal abstract bool casValue(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, object P_2);

		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Z")]
		internal abstract bool casListeners(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Listener P_1, Listener P_2);

		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Lcom/google/common/util/concurrent/AbstractFuture$Waiter;")]
		internal abstract Waiter gasWaiters(AbstractFuture P_0, Waiter P_1);

		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Lcom/google/common/util/concurrent/AbstractFuture$Listener;")]
		internal abstract Listener gasListeners(AbstractFuture P_0, Listener P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1282)]
		private AtomicHelper()
		{
		}

		internal abstract void putThread(Waiter P_0, java.lang.Thread P_1);

		internal abstract void putNext(Waiter P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1282)]
		internal AtomicHelper(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Cancellation : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal static Cancellation CAUSELESS_INTERRUPTED;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal static Cancellation CAUSELESS_CANCELLED;

		[Modifiers(Modifiers.Final)]
		internal bool wasInterrupted;

		[Modifiers(Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal System.Exception cause;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 58, 66, 104, 103, 103 })]
		internal Cancellation(bool P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] System.Exception P_1)
		{
			wasInterrupted = P_0;
			cause = P_1;
		}

		[LineNumberTable(new byte[] { 160, 210, 103, 102, 136, 108, 140 })]
		static Cancellation()
		{
			if (GENERATE_CANCELLATION_CAUSES)
			{
				CAUSELESS_CANCELLED = null;
				CAUSELESS_INTERRUPTED = null;
			}
			else
			{
				CAUSELESS_CANCELLED = new Cancellation(false, null);
				CAUSELESS_INTERRUPTED = new Cancellation(true, null);
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Failure : java.lang.Object
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, null, null)]
		internal class _1 : Throwable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(304)]
			internal _1(string P_0)
				: base(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override System.Exception fillInStackTrace()
			{
				return this;
			}

			[HideFromJava]
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
			protected _1(SerializationInfo P_0, StreamingContext P_1)
				: base(P_0, P_1)
			{
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Failure FALLBACK_INSTANCE;

		[Modifiers(Modifiers.Final)]
		internal System.Exception exception;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 198, 104, 113 })]
		internal Failure(System.Exception P_0)
		{
			exception = (System.Exception)Preconditions.checkNotNull(P_0);
		}

		[LineNumberTable(302)]
		static Failure()
		{
			FALLBACK_INSTANCE = new Failure(new _1("Failure occurred while trying to finish a future."));
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Listener : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Listener TOMBSTONE;

		[Modifiers(Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Runnable task;

		[Modifiers(Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Executor executor;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Listener next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 172, 104, 103, 103 })]
		internal Listener(Runnable P_0, Executor P_1)
		{
			task = P_0;
			executor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 177, 104, 103, 103 })]
		internal Listener()
		{
			task = null;
			executor = null;
		}

		[LineNumberTable(277)]
		static Listener()
		{
			TOMBSTONE = new Listener();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SafeAtomicHelper : AtomicHelper
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Ljava/lang/Thread;>;")]
		internal AtomicReferenceFieldUpdater waiterThreadUpdater;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;>;")]
		internal AtomicReferenceFieldUpdater waiterNextUpdater;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;>;")]
		internal AtomicReferenceFieldUpdater waitersUpdater;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Lcom/google/common/util/concurrent/AbstractFuture$Listener;>;")]
		internal AtomicReferenceFieldUpdater listenersUpdater;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Ljava/lang/Object;>;")]
		internal AtomicReferenceFieldUpdater valueUpdater;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Ljava/lang/Thread;>;Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;>;Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;>;Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Lcom/google/common/util/concurrent/AbstractFuture$Listener;>;Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater<Lcom/google/common/util/concurrent/AbstractFuture;Ljava/lang/Object;>;)V")]
		[LineNumberTable(new byte[] { 165, 24, 105, 103, 103, 103, 104, 104 })]
		internal SafeAtomicHelper(AtomicReferenceFieldUpdater P_0, AtomicReferenceFieldUpdater P_1, AtomicReferenceFieldUpdater P_2, AtomicReferenceFieldUpdater P_3, AtomicReferenceFieldUpdater P_4)
			: base(null)
		{
			waiterThreadUpdater = P_0;
			waiterNextUpdater = P_1;
			waitersUpdater = P_2;
			listenersUpdater = P_3;
			valueUpdater = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 34, 111 })]
		internal override void putThread(Waiter P_0, java.lang.Thread P_1)
		{
			waiterThreadUpdater.lazySet(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 39, 111 })]
		internal override void putNext(Waiter P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1)
		{
			waiterNextUpdater.lazySet(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Z")]
		[LineNumberTable(1439)]
		internal override bool casWaiters(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_2)
		{
			bool result = waitersUpdater.compareAndSet(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Z")]
		[LineNumberTable(1444)]
		internal override bool casListeners(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Listener P_1, Listener P_2)
		{
			bool result = listenersUpdater.compareAndSet(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Lcom/google/common/util/concurrent/AbstractFuture$Listener;")]
		[LineNumberTable(1450)]
		internal override Listener gasListeners(AbstractFuture P_0, Listener P_1)
		{
			return (Listener)listenersUpdater.getAndSet(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Lcom/google/common/util/concurrent/AbstractFuture$Waiter;")]
		[LineNumberTable(1456)]
		internal override Waiter gasWaiters(AbstractFuture P_0, Waiter P_1)
		{
			return (Waiter)waitersUpdater.getAndSet(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		[LineNumberTable(1461)]
		internal override bool casValue(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, object P_2)
		{
			bool result = valueUpdater.compareAndSet(P_0, P_1, P_2);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 40, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)40,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class SetFuture : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/AbstractFuture<TV;>;")]
		internal AbstractFuture owner;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;")]
		internal ListenableFuture future;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<TV;>;Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 233, 104, 103, 103 })]
		internal SetFuture(AbstractFuture P_0, ListenableFuture P_1)
		{
			owner = P_0;
			future = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 240, 142, 129, 108, 116, 141 })]
		public virtual void run()
		{
			if (access_0024300(owner) == this)
			{
				object obj = access_0024400(future);
				if (access_0024200().casValue(owner, this, obj))
				{
					access_0024500(owner);
				}
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SynchronizedHelper : AtomicHelper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1471)]
		internal SynchronizedHelper(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1471)]
		private SynchronizedHelper()
			: base(null)
		{
		}

		[LineNumberTable(new byte[] { 165, 80, 110 })]
		internal override void putThread(Waiter P_0, java.lang.Thread P_1)
		{
			P_0.thread = P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		[LineNumberTable(new byte[] { 165, 85, 110 })]
		internal override void putNext(Waiter P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1)
		{
			P_0.next = P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Z")]
		[LineNumberTable(new byte[] { 165, 91, 104, 105, 104, 138, 109 })]
		internal override bool casWaiters(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_2)
		{
			//Discarded unreachable code: IL_002c
			AbstractFuture obj;
			System.Threading.Monitor.Enter(obj = P_0);
			try
			{
				if (access_0024700(P_0) == P_1)
				{
					access_0024702(P_0, P_2);
					System.Threading.Monitor.Exit(obj);
					return true;
				}
				System.Threading.Monitor.Exit(obj);
				return false;
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Z")]
		[LineNumberTable(new byte[] { 165, 102, 104, 105, 104, 138, 109 })]
		internal override bool casListeners(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Listener P_1, Listener P_2)
		{
			//Discarded unreachable code: IL_002c
			AbstractFuture obj;
			System.Threading.Monitor.Enter(obj = P_0);
			try
			{
				if (access_0024800(P_0) == P_1)
				{
					access_0024802(P_0, P_2);
					System.Threading.Monitor.Exit(obj);
					return true;
				}
				System.Threading.Monitor.Exit(obj);
				return false;
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Lcom/google/common/util/concurrent/AbstractFuture$Listener;")]
		[LineNumberTable(new byte[] { 165, 114, 104, 103, 100, 136, 103 })]
		internal override Listener gasListeners(AbstractFuture P_0, Listener P_1)
		{
			//Discarded unreachable code: IL_001e
			lock (P_0)
			{
				Listener listener = access_0024800(P_0);
				if (listener != P_1)
				{
					access_0024802(P_0, P_1);
				}
				return listener;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Lcom/google/common/util/concurrent/AbstractFuture$Waiter;")]
		[LineNumberTable(new byte[] { 165, 126, 104, 103, 100, 136, 103 })]
		internal override Waiter gasWaiters(AbstractFuture P_0, Waiter P_1)
		{
			//Discarded unreachable code: IL_001e
			lock (P_0)
			{
				Waiter waiter = access_0024700(P_0);
				if (waiter != P_1)
				{
					access_0024702(P_0, P_1);
				}
				return waiter;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		[LineNumberTable(new byte[] { 165, 137, 104, 105, 104, 138, 109 })]
		internal override bool casValue(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, object P_2)
		{
			//Discarded unreachable code: IL_002c
			AbstractFuture obj;
			System.Threading.Monitor.Enter(obj = P_0);
			try
			{
				if (access_0024300(P_0) == P_1)
				{
					access_0024302(P_0, P_2);
					System.Threading.Monitor.Exit(obj);
					return true;
				}
				System.Threading.Monitor.Exit(obj);
				return false;
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 9, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)9,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
	internal interface Trusted : ListenableFuture, Future
	{
	}

	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture<TV;>;Lcom/google/common/util/concurrent/AbstractFuture$Trusted<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 58, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)58,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.util.concurrent.AbstractFuture$Trusted" })]
	internal abstract class TrustedFuture : AbstractFuture, Trusted, ListenableFuture, Future
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(107)]
		internal TrustedFuture()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
		[Signature("()TV;")]
		[LineNumberTable(113)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public sealed override object get()
		{
			object result = base.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
		[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
		[LineNumberTable(121)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public sealed override object get(long P_0, TimeUnit P_1)
		{
			object result = base.get(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(126)]
		public sealed override bool isDone()
		{
			bool result = base.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(131)]
		public sealed override bool isCancelled()
		{
			bool result = base.isCancelled();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 86, 106 })]
		public sealed override void addListener(Runnable P_0, Executor P_1)
		{
			base.addListener(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(142)]
		public sealed override bool cancel(bool P_0)
		{
			bool result = base.cancel(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static TrustedFuture()
		{
			AbstractFuture.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class UnsafeAtomicHelper : AtomicHelper
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Lsun/misc/Unsafe;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _1 : java.lang.Object, PrivilegedExceptionAction
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
			[Throws(new string[] { "java.lang.Exception" })]
			[LineNumberTable(new byte[]
			{
				164, 195, 102, 122, 104, 111, 106, 238, 60, 230,
				71
			})]
			public virtual Unsafe run()
			{
				Class value = ClassLiteral<Unsafe>.Value;
				Field[] declaredFields = value.getDeclaredFields(_1.___003CGetCallerID_003E());
				int num = declaredFields.Length;
				for (int i = 0; i < num; i++)
				{
					Field field = declaredFields[i];
					field.setAccessible(flag: true);
					object obj = field.get(null, _1.___003CGetCallerID_003E());
					if (value.isInstance(obj))
					{
						return (Unsafe)value.cast(obj);
					}
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchFieldError("the Unsafe");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1330)]
			internal _1()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1330)]
			public virtual object run()
			{
				Unsafe result = this.run();
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

		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Unsafe UNSAFE;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long LISTENERS_OFFSET;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long WAITERS_OFFSET;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long VALUE_OFFSET;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long WAITER_THREAD_OFFSET;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long WAITER_NEXT_OFFSET;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1314)]
		internal UnsafeAtomicHelper(AbstractFuture._1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1314)]
		private UnsafeAtomicHelper()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 226, 115 })]
		internal override void putThread(Waiter P_0, java.lang.Thread P_1)
		{
			UNSAFE.putObject(P_0, WAITER_THREAD_OFFSET, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 231, 115 })]
		internal override void putNext(Waiter P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1)
		{
			UNSAFE.putObject(P_0, WAITER_NEXT_OFFSET, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Z")]
		[LineNumberTable(1376)]
		internal override bool casWaiters(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_2)
		{
			bool result = UNSAFE.compareAndSwapObject(P_0, WAITERS_OFFSET, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Z")]
		[LineNumberTable(1382)]
		internal override bool casListeners(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Listener P_1, Listener P_2)
		{
			bool result = UNSAFE.compareAndSwapObject(P_0, LISTENERS_OFFSET, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Listener;)Lcom/google/common/util/concurrent/AbstractFuture$Listener;")]
		[LineNumberTable(1388)]
		internal override Listener gasListeners(AbstractFuture P_0, Listener P_1)
		{
			return (Listener)UNSAFE.getAndSetObject(P_0, LISTENERS_OFFSET, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Lcom/google/common/util/concurrent/AbstractFuture$Waiter;)Lcom/google/common/util/concurrent/AbstractFuture$Waiter;")]
		[LineNumberTable(1394)]
		internal override Waiter gasWaiters(AbstractFuture P_0, Waiter P_1)
		{
			return (Waiter)UNSAFE.getAndSetObject(P_0, WAITERS_OFFSET, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		[LineNumberTable(1400)]
		internal override bool casValue(AbstractFuture P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, object P_2)
		{
			bool result = UNSAFE.compareAndSwapObject(P_0, VALUE_OFFSET, P_1, P_2);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[]
		{
			164,
			185,
			130,
			246,
			86,
			226,
			43,
			129,
			101,
			byte.MaxValue,
			3,
			81,
			2,
			97,
			214,
			102,
			123,
			123,
			123,
			127,
			0,
			127,
			0,
			223,
			0,
			226,
			61,
			98,
			103,
			141
		})]
		static UnsafeAtomicHelper()
		{
			_ = null;
			Unsafe @unsafe;
			try
			{
				@unsafe = Unsafe.getUnsafe(UnsafeAtomicHelper.___003CGetCallerID_003E());
			}
			catch (SecurityException)
			{
				goto IL_0015;
			}
			goto IL_005b;
			IL_0015:
			_ = null;
			PrivilegedActionException ex2;
			try
			{
				@unsafe = (Unsafe)AccessController.doPrivileged(new _1(), UnsafeAtomicHelper.___003CGetCallerID_003E());
			}
			catch (PrivilegedActionException x)
			{
				ex2 = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_003f;
			}
			goto IL_005b;
			IL_003f:
			PrivilegedActionException ex3 = ex2;
			System.Exception cause = ex3.getCause();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("Could not initialize intrinsics", cause);
			IL_005b:
			java.lang.Exception ex5;
			try
			{
				Class value = ClassLiteral<AbstractFuture>.Value;
				WAITERS_OFFSET = @unsafe.objectFieldOffset(value.getDeclaredField("waiters", UnsafeAtomicHelper.___003CGetCallerID_003E()));
				LISTENERS_OFFSET = @unsafe.objectFieldOffset(value.getDeclaredField("listeners", UnsafeAtomicHelper.___003CGetCallerID_003E()));
				VALUE_OFFSET = @unsafe.objectFieldOffset(value.getDeclaredField("value", UnsafeAtomicHelper.___003CGetCallerID_003E()));
				WAITER_THREAD_OFFSET = @unsafe.objectFieldOffset(ClassLiteral<Waiter>.Value.getDeclaredField("thread", UnsafeAtomicHelper.___003CGetCallerID_003E()));
				WAITER_NEXT_OFFSET = @unsafe.objectFieldOffset(ClassLiteral<Waiter>.Value.getDeclaredField("next", UnsafeAtomicHelper.___003CGetCallerID_003E()));
				UNSAFE = @unsafe;
				return;
			}
			catch (System.Exception x2)
			{
				java.lang.Exception ex4 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
				if (ex4 == null)
				{
					throw;
				}
				ex5 = ex4;
			}
			java.lang.Exception ex6 = ex5;
			Throwables.throwIfUnchecked(ex6);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(ex6);
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Waiter : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Waiter TOMBSTONE;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal volatile java.lang.Thread thread;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal volatile Waiter next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 99, 136, 114 })]
		internal Waiter()
		{
			access_0024200().putThread(this, java.lang.Thread.currentThread());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 107, 110 })]
		internal virtual void setNext([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Waiter P_0)
		{
			access_0024200().putNext(this, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 114, 105, 99, 110, 136 })]
		internal virtual void unpark()
		{
			java.lang.Thread thread = this.thread;
			if (thread != null)
			{
				this.thread = null;
				System.Threading.Thread.MemoryBarrier();
				LockSupport.unpark(thread);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(211)]
		internal Waiter(bool P_0)
		{
		}

		[LineNumberTable(202)]
		static Waiter()
		{
			TOMBSTONE = new Waiter(false);
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
			return Interlocked.CompareExchange(ref ((AbstractFuture)P_0).waiters, (Waiter)P_2, (Waiter)P_1) == P_1;
		}

		public override object get(object P_0)
		{
			return ((AbstractFuture)P_0).waiters;
		}

		public override void set(object P_0, object P_1)
		{
			((AbstractFuture)P_0).waiters = (Waiter)P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		internal ___003CARFU_003E_0()
		{
		}
	}

	private sealed class ___003CARFU_003E_1 : IntrinsicAtomicReferenceFieldUpdater
	{
		public override bool compareAndSet(object P_0, object P_1, object P_2)
		{
			return Interlocked.CompareExchange(ref ((AbstractFuture)P_0).listeners, (Listener)P_2, (Listener)P_1) == P_1;
		}

		public override object get(object P_0)
		{
			return ((AbstractFuture)P_0).listeners;
		}

		public override void set(object P_0, object P_1)
		{
			((AbstractFuture)P_0).listeners = (Listener)P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		internal ___003CARFU_003E_1()
		{
		}
	}

	private sealed class ___003CARFU_003E_2 : IntrinsicAtomicReferenceFieldUpdater
	{
		public override bool compareAndSet(object P_0, object P_1, object P_2)
		{
			return Interlocked.CompareExchange<object>(ref ((AbstractFuture)P_0).value, P_2, P_1) == P_1;
		}

		public override object get(object P_0)
		{
			return ((AbstractFuture)P_0).value;
		}

		public override void set(object P_0, object P_1)
		{
			((AbstractFuture)P_0).value = P_1;
			System.Threading.Thread.MemoryBarrier();
		}

		internal ___003CARFU_003E_2()
		{
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static bool GENERATE_CANCELLATION_CAUSES;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger log;

	private const long SPIN_THRESHOLD_NANOS = 1000L;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static AtomicHelper ATOMIC_HELPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object NULL;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile object value;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile Listener listeners;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile Waiter waiters;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)Z")]
	[LineNumberTable(new byte[] { 162, 155, 108, 111, 102, 130 })]
	protected internal virtual bool set([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object value)
	{
		object obj = ((value != null) ? value : NULL);
		if (ATOMIC_HELPER.casValue(this, null, obj))
		{
			complete(this);
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 180, 118, 111, 102, 130 })]
	protected internal virtual bool setException(System.Exception throwable)
	{
		Failure.___003Cclinit_003E();
		Failure failure = new Failure((System.Exception)Preconditions.checkNotNull(throwable));
		if (ATOMIC_HELPER.casValue(this, null, failure))
		{
			complete(this);
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/AbstractFuture<*>;)V")]
	[LineNumberTable(new byte[]
	{
		163, 113, 130, 162, 230, 70, 134, 104, 98, 102,
		98, 231, 69, 113, 104, 232, 70, 104, 108, 110,
		113, 197, 226, 69, 150, 165
	})]
	private static void complete(AbstractFuture P_0)
	{
		AbstractFuture abstractFuture = P_0;
		Listener listener = null;
		while (true)
		{
			abstractFuture.releaseWaiters();
			abstractFuture.afterDone();
			listener = abstractFuture.clearListeners(listener);
			_ = null;
			while (true)
			{
				if (listener == null)
				{
					return;
				}
				Listener listener2 = listener;
				listener = listener.next;
				Runnable runnable = (Runnable)java.util.Objects.requireNonNull(listener2.task);
				if (runnable is SetFuture)
				{
					SetFuture setFuture = (SetFuture)runnable;
					abstractFuture = setFuture.owner;
					if (abstractFuture.value == setFuture)
					{
						object futureValue = getFutureValue(setFuture.future);
						if (ATOMIC_HELPER.casValue(abstractFuture, setFuture, futureValue))
						{
							break;
						}
					}
				}
				else
				{
					executeListener(runnable, (Executor)java.util.Objects.requireNonNull(listener2.executor));
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<*>;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[]
	{
		163,
		13,
		232,
		69,
		110,
		200,
		103,
		136,
		104,
		115,
		198,
		135,
		104,
		102,
		102,
		99,
		167,
		135,
		239,
		69,
		203,
		104,
		99,
		byte.MaxValue,
		47,
		71,
		127,
		46,
		98,
		99,
		byte.MaxValue,
		46,
		72,
		114,
		98,
		99,
		byte.MaxValue,
		45,
		70,
		105,
		98
	})]
	private static object getFutureValue(ListenableFuture P_0)
	{
		//Discarded unreachable code: IL_00fc
		if (P_0 is Trusted)
		{
			object obj = ((AbstractFuture)P_0).value;
			if (obj is Cancellation)
			{
				Cancellation cancellation = (Cancellation)obj;
				if (cancellation.wasInterrupted)
				{
					Cancellation cancellation2;
					if (cancellation.cause != null)
					{
						Cancellation.___003Cclinit_003E();
						cancellation2 = new Cancellation(false, cancellation.cause);
					}
					else
					{
						cancellation2 = Cancellation.CAUSELESS_CANCELLED;
					}
					obj = cancellation2;
				}
			}
			return java.util.Objects.requireNonNull(obj);
		}
		if (P_0 is InternalFutureFailureAccess)
		{
			System.Exception ex = InternalFutures.tryInternalFastPathGetFailure((InternalFutureFailureAccess)P_0);
			if (ex != null)
			{
				return new Failure(ex);
			}
		}
		int num = (P_0.isCancelled() ? 1 : 0);
		if (((((!GENERATE_CANCELLATION_CAUSES) ? true : false) ? 1u : 0u) & (uint)num) != 0)
		{
			return java.util.Objects.requireNonNull(Cancellation.CAUSELESS_CANCELLED);
		}
		ExecutionException ex2;
		CancellationException ex3;
		System.Exception ex4;
		try
		{
			try
			{
				try
				{
					object uninterruptibly = getUninterruptibly(P_0);
					if (num != 0)
					{
						Cancellation.___003Cclinit_003E();
						string text = java.lang.String.valueOf(P_0);
						int num2 = 84 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
						num2 = num2;
						return new Cancellation(false, new IllegalArgumentException(new StringBuilder(num2).append("get() did not throw CancellationException, despite reporting isCancelled() == true: ").append(text).toString()));
					}
					return (uninterruptibly != null) ? uninterruptibly : NULL;
				}
				catch (ExecutionException x)
				{
					ex2 = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (CancellationException x2)
			{
				ex3 = ByteCodeHelper.MapException<CancellationException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_012b;
			}
		}
		catch (System.Exception x3)
		{
			ex4 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
			goto IL_0132;
		}
		ExecutionException ex5 = ex2;
		if (num != 0)
		{
			Cancellation.___003Cclinit_003E();
			string text = java.lang.String.valueOf(P_0);
			int num2 = 84 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num2 = num2;
			return new Cancellation(false, new IllegalArgumentException(new StringBuilder(num2).append("get() did not throw CancellationException, despite reporting isCancelled() == true: ").append(text).toString(), ex5));
		}
		Failure.___003Cclinit_003E();
		return new Failure(Throwable.instancehelper_getCause(ex5));
		IL_012b:
		CancellationException ex6 = ex3;
		if (num == 0)
		{
			Failure.___003Cclinit_003E();
			string text = java.lang.String.valueOf(P_0);
			int num2 = 77 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num2 = num2;
			return new Failure(new IllegalArgumentException(new StringBuilder(num2).append("get() threw CancellationException, despite reporting isCancelled() == false: ").append(text).toString(), ex6));
		}
		return new Cancellation(false, ex6);
		IL_0132:
		System.Exception ex7 = ex4;
		return new Failure(ex7);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 215, 104, 123, 104, 118, 232, 69, 168, 98 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	private object getDoneValue(object P_0)
	{
		if (P_0 is Cancellation)
		{
			throw Throwable.___003Cunmap_003E(cancellationExceptionWithCause("Task was cancelled.", ((Cancellation)P_0).cause));
		}
		if (P_0 is Failure)
		{
			System.Exception exception = ((Failure)P_0).exception;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionException(exception);
		}
		if (P_0 == NULL)
		{
			object result = NullnessCasts.uncheckedNull();
			_ = null;
			return result;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 134, 174, 98, 105, 104, 161, 102, 105, 106,
		100, 99, 110, 106, 133, 111, 133, 199
	})]
	private void removeWaiter(Waiter P_0)
	{
		P_0.thread = null;
		System.Threading.Thread.MemoryBarrier();
		while (true)
		{
			Waiter waiter = null;
			Waiter waiter2 = waiters;
			if (waiter2 == Waiter.TOMBSTONE)
			{
				break;
			}
			while (true)
			{
				if (waiter2 == null)
				{
					return;
				}
				Waiter next = waiter2.next;
				if (waiter2.thread != null)
				{
					waiter = waiter2;
				}
				else if (waiter != null)
				{
					waiter.next = next;
					System.Threading.Thread.MemoryBarrier();
					if (waiter.thread == null)
					{
						break;
					}
				}
				else if (!ATOMIC_HELPER.casWaiters(this, waiter2, next))
				{
					break;
				}
				waiter2 = next;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 5, 102, 119, 148, 146, 127, 4, 104, 110,
		104, 137, 135
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (java.lang.String.instancehelper_startsWith(java.lang.Object.instancehelper_getClass(this).getName(), "com.google.common.util.concurrent."))
		{
			stringBuilder.append(java.lang.Object.instancehelper_getClass(this).getSimpleName());
		}
		else
		{
			stringBuilder.append(java.lang.Object.instancehelper_getClass(this).getName());
		}
		stringBuilder.append('@').append(Integer.toHexString(java.lang.System.identityHashCode(this))).append("[status=");
		if (isCancelled())
		{
			stringBuilder.append("CANCELLED");
		}
		else if (isDone())
		{
			addDoneString(stringBuilder);
		}
		else
		{
			addPendingString(stringBuilder);
		}
		string result = stringBuilder.append("]").toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 161, 234, 105 })]
	public virtual bool isDone()
	{
		object obj = value;
		return obj != null && !(obj is SetFuture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 149, 103, 104 })]
	private static CancellationException cancellationExceptionWithCause(string P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception P_1)
	{
		CancellationException ex = new CancellationException(P_0);
		Throwable.instancehelper_initCause(ex, P_1);
		return ex;
	}

	protected internal virtual void interruptTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164,
		132,
		254,
		73,
		229,
		56,
		193,
		byte.MaxValue,
		75,
		69
	})]
	private static void executeListener(Runnable P_0, Executor P_1)
	{
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 82, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		163, 94, 194, 237, 70, 99, 138, 230, 61, 99,
		234, 57, 100, 97, 98, 164, 99, 138
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	private static object getUninterruptibly(Future P_0)
	{
		int num = 0;
		object result;
		while (true)
		{
			try
			{
				try
				{
					result = P_0.get();
				}
				catch (InterruptedException)
				{
					goto IL_001f;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					java.lang.Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001f:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					java.lang.Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			java.lang.Thread.currentThread().interrupt();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 228, 113, 101, 38, 171 })]
	private void releaseWaiters()
	{
		Waiter waiter = ATOMIC_HELPER.gasWaiters(this, Waiter.TOMBSTONE);
		for (Waiter waiter2 = waiter; waiter2 != null; waiter2 = waiter2.next)
		{
			waiter2.unpark();
		}
	}

	protected internal virtual void afterDone()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 246, 113, 98, 99, 98, 103, 103, 98, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Listener clearListeners([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Listener P_0)
	{
		Listener listener = ATOMIC_HELPER.gasListeners(this, Listener.TOMBSTONE);
		Listener listener2 = P_0;
		while (listener != null)
		{
			Listener listener3 = listener;
			listener = listener.next;
			listener3.next = listener2;
			listener2 = listener3;
		}
		return listener2;
	}

	[LineNumberTable(new byte[] { 161, 240, 105 })]
	public virtual bool isCancelled()
	{
		object obj = value;
		return obj is Cancellation;
	}

	[LineNumberTable(new byte[] { 162, 98, 105 })]
	protected internal bool wasInterrupted()
	{
		object obj = value;
		return (obj is Cancellation && ((Cancellation)obj).wasInterrupted) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164,
		76,
		103,
		108,
		104,
		byte.MaxValue,
		21,
		71,
		226,
		58,
		97,
		byte.MaxValue,
		2,
		69,
		226,
		60,
		97,
		172,
		2,
		98,
		159,
		3
	})]
	private void addDoneString(StringBuilder P_0)
	{
		ExecutionException ex;
		RuntimeException ex4;
		try
		{
			try
			{
				try
				{
					object uninterruptibly = getUninterruptibly(this);
					P_0.append("SUCCESS, result=[");
					appendResultObject(P_0, uninterruptibly);
					P_0.append("]");
					return;
				}
				catch (ExecutionException x)
				{
					ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (CancellationException)
			{
				goto IL_0049;
			}
		}
		catch (System.Exception x2)
		{
			RuntimeException ex3 = ByteCodeHelper.MapException<RuntimeException>(x2, ByteCodeHelper.MapFlags.None);
			if (ex3 == null)
			{
				throw;
			}
			ex4 = ex3;
			goto IL_004c;
		}
		ExecutionException @this = ex;
		P_0.append("FAILURE, cause=[").append(Throwable.instancehelper_getCause(@this)).append("]");
		return;
		IL_004c:
		RuntimeException this2 = ex4;
		P_0.append("UNKNOWN, cause=[").append(java.lang.Object.instancehelper_getClass(this2)).append(" thrown from get()]");
		return;
		IL_0049:
		_ = null;
		P_0.append("CANCELLED");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164,
		42,
		135,
		140,
		105,
		104,
		108,
		114,
		209,
		byte.MaxValue,
		23,
		69,
		226,
		60,
		162,
		159,
		34,
		99,
		252,
		70,
		136,
		110,
		135
	})]
	private void addPendingString(StringBuilder P_0)
	{
		int start = P_0.length();
		P_0.append("PENDING");
		object obj = value;
		if (obj is SetFuture)
		{
			P_0.append(", setFuture=[");
			appendUserObject(P_0, ((SetFuture)obj).future);
			P_0.append("]");
			goto IL_00ed;
		}
		string text;
		RuntimeException ex2;
		StackOverflowError stackOverflowError2;
		try
		{
			try
			{
				text = Strings.emptyToNull(pendingToString());
			}
			catch (System.Exception x)
			{
				RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_0082;
			}
		}
		catch (System.Exception x2)
		{
			StackOverflowError stackOverflowError = ByteCodeHelper.MapException<StackOverflowError>(x2, ByteCodeHelper.MapFlags.None);
			if (stackOverflowError == null)
			{
				throw;
			}
			stackOverflowError2 = stackOverflowError;
			goto IL_0085;
		}
		goto IL_00ce;
		IL_00ce:
		if (text != null)
		{
			P_0.append(", info=[").append(text).append("]");
		}
		goto IL_00ed;
		IL_00ed:
		if (isDone())
		{
			P_0.delete(start, P_0.length());
			addDoneString(P_0);
		}
		return;
		IL_0085:
		object obj2 = stackOverflowError2;
		goto IL_008b;
		IL_0082:
		obj2 = ex2;
		goto IL_008b;
		IL_008b:
		System.Exception @this = (System.Exception)obj2;
		string text2 = java.lang.String.valueOf(java.lang.Object.instancehelper_getClass(@this));
		int num = 38 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		text = new StringBuilder(num).append("Exception thrown from implementation: ").append(text2).toString();
		goto IL_00ce;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164,
		114,
		100,
		142,
		byte.MaxValue,
		17,
		70,
		226,
		60,
		161,
		151
	})]
	private void appendUserObject(StringBuilder P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		RuntimeException ex2;
		StackOverflowError stackOverflowError2;
		try
		{
			try
			{
				if (P_1 == this)
				{
					P_0.append("this future");
				}
				else
				{
					P_0.append(P_1);
				}
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
		}
		catch (System.Exception x2)
		{
			StackOverflowError stackOverflowError = ByteCodeHelper.MapException<StackOverflowError>(x2, ByteCodeHelper.MapFlags.None);
			if (stackOverflowError == null)
			{
				throw;
			}
			stackOverflowError2 = stackOverflowError;
			goto IL_003f;
		}
		object obj = ex2;
		goto IL_0044;
		IL_003f:
		obj = stackOverflowError2;
		goto IL_0044;
		IL_0044:
		System.Exception @this = (System.Exception)obj;
		P_0.append("Exception thrown from implementation: ").append(java.lang.Object.instancehelper_getClass(@this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 31, 104, 107, 63, 19, 193 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual string pendingToString()
	{
		if (this is ScheduledFuture)
		{
			long delay = ((ScheduledFuture)this).getDelay(TimeUnit.MILLISECONDS);
			int num = 41;
			num = num;
			string result = new StringBuilder(num).append("remaining delay=[").append(delay).append(" ms]")
				.toString();
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 95, 99, 110, 100, 142, 98, 116, 102, 144 })]
	private void appendResultObject(StringBuilder P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == null)
		{
			P_0.append("null");
		}
		else if (P_1 == this)
		{
			P_0.append("this future");
		}
		else
		{
			P_0.append(java.lang.Object.instancehelper_getClass(P_1).getName()).append("@").append(Integer.toHexString(java.lang.System.identityHashCode(P_1)));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(391)]
	protected internal AbstractFuture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.TimeoutException", "java.util.concurrent.ExecutionException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
	[LineNumberTable(new byte[]
	{
		161, 62, 104, 98, 103, 139, 105, 118, 170, 145,
		108, 106, 108, 135, 105, 148, 135, 103, 104, 235,
		69, 105, 118, 202, 104, 140, 104, 194, 106, 236,
		69, 214, 101, 105, 118, 138, 103, 139, 170, 104,
		114, 159, 55, 143, 115, 100, 111, 109, 150, 105,
		127, 57, 100, 147, 147, 100, 191, 37, 243, 69,
		104, 156
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get(long timeout, TimeUnit unit)
	{
		long num = unit.toNanos(timeout);
		long num2 = num;
		if (java.lang.Thread.interrupted())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InterruptedException();
		}
		object obj = value;
		if (obj != null && !(obj is SetFuture))
		{
			object doneValue = getDoneValue(obj);
			_ = null;
			return doneValue;
		}
		long num3 = ((num2 <= 0) ? 0 : (java.lang.System.nanoTime() + num2));
		if (num2 >= 1000u)
		{
			Waiter waiter = waiters;
			if (waiter == Waiter.TOMBSTONE)
			{
				goto IL_011a;
			}
			Waiter waiter2 = new Waiter();
			while (true)
			{
				waiter2.setNext(waiter);
				if (ATOMIC_HELPER.casWaiters(this, waiter, waiter2))
				{
					break;
				}
				waiter = waiters;
				if (waiter != Waiter.TOMBSTONE)
				{
					continue;
				}
				goto IL_011a;
			}
			do
			{
				OverflowAvoidingLockSupport.parkNanos(this, num2);
				if (java.lang.Thread.interrupted())
				{
					removeWaiter(waiter2);
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new InterruptedException();
				}
				obj = value;
				if (obj != null && !(obj is SetFuture))
				{
					object doneValue2 = getDoneValue(obj);
					_ = null;
					return doneValue2;
				}
				num2 = num3 - java.lang.System.nanoTime();
			}
			while (num2 >= 1000u);
			removeWaiter(waiter2);
		}
		while (num2 > 0)
		{
			obj = value;
			if (obj != null && !(obj is SetFuture))
			{
				object doneValue3 = getDoneValue(obj);
				_ = null;
				return doneValue3;
			}
			if (java.lang.Thread.interrupted())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new InterruptedException();
			}
			num2 = num3 - java.lang.System.nanoTime();
		}
		string text = toString();
		string text2 = java.lang.String.instancehelper_toLowerCase(unit.toString(), Locale.ROOT);
		string text3 = java.lang.String.instancehelper_toLowerCase(unit.toString(), Locale.ROOT);
		int num4 = 28 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
		num4 = num4;
		string text4 = new StringBuilder(num4).append("Waited ").append(timeout).append(" ")
			.append(text3)
			.toString();
		if (num2 + 1000u < 0)
		{
			text4 = java.lang.String.instancehelper_concat(java.lang.String.valueOf(text4), " (plus ");
			long num5 = -num2;
			long num6 = unit.convert(num5, TimeUnit.NANOSECONDS);
			long num7 = num5 - unit.toNanos(num6);
			int num8 = ((num6 == 0 || num7 > 1000u) ? 1 : 0);
			if (num6 > 0)
			{
				string text5 = java.lang.String.valueOf(text4);
				num4 = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text5)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num4 = num4;
				text4 = new StringBuilder(num4).append(text5).append(num6).append(" ")
					.append(text2)
					.toString();
				if (num8 != 0)
				{
					text4 = java.lang.String.instancehelper_concat(java.lang.String.valueOf(text4), ",");
				}
				text4 = java.lang.String.instancehelper_concat(java.lang.String.valueOf(text4), " ");
			}
			if (num8 != 0)
			{
				string text5 = java.lang.String.valueOf(text4);
				num4 = 33 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text5));
				num4 = num4;
				text4 = new StringBuilder(num4).append(text5).append(num7).append(" nanoseconds ")
					.toString();
			}
			text4 = java.lang.String.instancehelper_concat(java.lang.String.valueOf(text4), "delay)");
		}
		if (isDone())
		{
			string message = java.lang.String.instancehelper_concat(java.lang.String.valueOf(text4), " but future completed as timeout expired");
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.util.concurrent.TimeoutException(message);
		}
		text3 = text4;
		num4 = 5 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num4 = num4;
		string message2 = new StringBuilder(num4).append(text3).append(" for ").append(text)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.util.concurrent.TimeoutException(message2);
		IL_011a:
		object doneValue4 = getDoneValue(java.util.Objects.requireNonNull(value));
		_ = null;
		return doneValue4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("()TV;")]
	[LineNumberTable(new byte[]
	{
		161, 172, 103, 139, 105, 118, 138, 105, 107, 134,
		103, 175, 134, 103, 103, 203, 105, 118, 202, 105,
		235, 69
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get()
	{
		if (java.lang.Thread.interrupted())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InterruptedException();
		}
		object obj = value;
		if (obj != null && !(obj is SetFuture))
		{
			object doneValue = getDoneValue(obj);
			_ = null;
			return doneValue;
		}
		Waiter waiter = waiters;
		if (waiter != Waiter.TOMBSTONE)
		{
			Waiter waiter2 = new Waiter();
			do
			{
				waiter2.setNext(waiter);
				if (ATOMIC_HELPER.casWaiters(this, waiter, waiter2))
				{
					do
					{
						LockSupport.park(this);
						if (java.lang.Thread.interrupted())
						{
							removeWaiter(waiter2);
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new InterruptedException();
						}
						obj = value;
					}
					while (!(obj != null && !(obj is SetFuture)));
					object doneValue2 = getDoneValue(obj);
					_ = null;
					return doneValue2;
				}
				waiter = waiters;
			}
			while (waiter != Waiter.TOMBSTONE);
		}
		object doneValue3 = getDoneValue(java.util.Objects.requireNonNull(value));
		_ = null;
		return doneValue3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 240, 98, 105, 98, 214, 103, 247, 77, 99,
		103, 229, 61, 198, 131, 115, 162, 99, 135, 103,
		171, 109, 233, 72, 105, 106, 115, 100, 133, 130,
		137, 194, 106, 203, 194
	})]
	public virtual bool cancel(bool mayInterruptIfRunning)
	{
		object obj = value;
		int result = 0;
		if (obj == null || obj is SetFuture)
		{
			object obj2;
			if (GENERATE_CANCELLATION_CAUSES)
			{
				Cancellation.___003Cclinit_003E();
				obj2 = new Cancellation(mayInterruptIfRunning, new CancellationException("Future.cancel() was called."));
			}
			else
			{
				obj2 = java.util.Objects.requireNonNull((!mayInterruptIfRunning) ? Cancellation.CAUSELESS_CANCELLED : Cancellation.CAUSELESS_INTERRUPTED);
			}
			object obj3 = obj2;
			AbstractFuture abstractFuture = this;
			while (true)
			{
				if (ATOMIC_HELPER.casValue(abstractFuture, obj, obj3))
				{
					result = 1;
					if (mayInterruptIfRunning)
					{
						abstractFuture.interruptTask();
					}
					complete(abstractFuture);
					if (!(obj is SetFuture))
					{
						break;
					}
					ListenableFuture future = ((SetFuture)obj).future;
					if (!(future is Trusted))
					{
						future.cancel(mayInterruptIfRunning);
						break;
					}
					AbstractFuture abstractFuture2 = (AbstractFuture)future;
					obj = abstractFuture2.value;
					if (!(obj == null || obj is SetFuture))
					{
						break;
					}
					abstractFuture = abstractFuture2;
				}
				else
				{
					obj = abstractFuture.value;
					if (!(obj is SetFuture))
					{
						break;
					}
				}
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 109, 108, 236, 74, 104, 105, 104, 136, 103,
		111, 129, 105, 232, 69, 105
	})]
	public virtual void addListener(Runnable listener, Executor executor)
	{
		Preconditions.checkNotNull((object)listener, (object)"Runnable was null.");
		Preconditions.checkNotNull((object)executor, (object)"Executor was null.");
		if (!isDone())
		{
			Listener listener2 = listeners;
			if (listener2 != Listener.TOMBSTONE)
			{
				Listener listener3 = new Listener(listener, executor);
				do
				{
					listener3.next = listener2;
					if (ATOMIC_HELPER.casListeners(this, listener2, listener3))
					{
						return;
					}
					listener2 = listeners;
				}
				while (listener2 != Listener.TOMBSTONE);
			}
		}
		executeListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Z")]
	[LineNumberTable(new byte[]
	{
		162, 219, 103, 105, 102, 104, 103, 111, 102, 130,
		130, 104, 210, 254, 77, 226, 52, 226, 70, 186,
		2, 97, 167, 143, 130, 201, 136, 146
	})]
	protected internal virtual bool setFuture(ListenableFuture future)
	{
		Preconditions.checkNotNull(future);
		object obj = value;
		SetFuture setFuture;
		System.Exception ex;
		if (obj == null)
		{
			if (future.isDone())
			{
				object futureValue = getFutureValue(future);
				if (ATOMIC_HELPER.casValue(this, null, futureValue))
				{
					complete(this);
					return true;
				}
				return false;
			}
			setFuture = new SetFuture(this, future);
			if (ATOMIC_HELPER.casValue(this, null, setFuture))
			{
				try
				{
					future.addListener(setFuture, DirectExecutor.INSTANCE);
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0073;
				}
				goto IL_00ad;
			}
			obj = value;
		}
		if (obj is Cancellation)
		{
			future.cancel(((Cancellation)obj).wasInterrupted);
		}
		return false;
		IL_0091:
		_ = null;
		Failure failure = Failure.FALLBACK_INSTANCE;
		goto IL_009e;
		IL_0073:
		System.Exception ex2 = ex;
		try
		{
			failure = new Failure(ex2);
		}
		catch (System.Exception x2)
		{
			ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.Unused);
			goto IL_0091;
		}
		goto IL_009e;
		IL_009e:
		ATOMIC_HELPER.casValue(this, setFuture, failure);
		goto IL_00ad;
		IL_00ad:
		return true;
	}

	[LineNumberTable(new byte[] { 163, 207, 104, 105, 104, 172 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal sealed override System.Exception tryInternalFastPathGetFailure()
	{
		if (this is Trusted)
		{
			object obj = value;
			if (obj is Failure)
			{
				return ((Failure)obj).exception;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/Future<*>;)V")]
	[LineNumberTable(new byte[] { 163, 221, 112, 141 })]
	internal void maybePropagateCancellationTo([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Future P_0)
	{
		if ((P_0 != null) & isCancelled())
		{
			P_0.cancel(wasInterrupted());
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static AtomicHelper access_0024200()
	{
		return ATOMIC_HELPER;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static object access_0024300(AbstractFuture P_0)
	{
		return P_0.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static object access_0024400(ListenableFuture P_0)
	{
		object futureValue = getFutureValue(P_0);
		_ = null;
		return futureValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static void access_0024500(AbstractFuture P_0)
	{
		complete(P_0);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Waiter access_0024700(AbstractFuture P_0)
	{
		return P_0.waiters;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Waiter access_0024702(AbstractFuture P_0, Waiter P_1)
	{
		P_0.waiters = P_1;
		System.Threading.Thread.MemoryBarrier();
		return P_1;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Listener access_0024800(AbstractFuture P_0)
	{
		return P_0.listeners;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Listener access_0024802(AbstractFuture P_0, Listener P_1)
	{
		P_0.listeners = P_1;
		System.Threading.Thread.MemoryBarrier();
		return P_1;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static object access_0024302(AbstractFuture P_0, object P_1)
	{
		P_0.value = P_1;
		System.Threading.Thread.MemoryBarrier();
		return P_1;
	}

	[LineNumberTable(new byte[]
	{
		37,
		138,
		37,
		209,
		2,
		97,
		130,
		230,
		118,
		249,
		74,
		98,
		162,
		251,
		86,
		229,
		43,
		98,
		227,
		69,
		143,
		121,
		121,
		119,
		119,
		byte.MaxValue,
		3,
		72,
		226,
		57,
		226,
		69,
		99,
		167,
		230,
		69,
		198,
		99,
		117,
		245,
		160,
		103
	})]
	static AbstractFuture()
	{
		int gENERATE_CANCELLATION_CAUSES;
		try
		{
			gENERATE_CANCELLATION_CAUSES = (java.lang.Boolean.parseBoolean(java.lang.System.getProperty("guava.concurrent.generate_cancellation_cause", "false")) ? 1 : 0);
		}
		catch (SecurityException)
		{
			goto IL_001d;
		}
		goto IL_0025;
		IL_001d:
		_ = null;
		gENERATE_CANCELLATION_CAUSES = 0;
		goto IL_0025;
		IL_0025:
		GENERATE_CANCELLATION_CAUSES = (byte)gENERATE_CANCELLATION_CAUSES != 0;
		log = Logger.getLogger(ClassLiteral<AbstractFuture>.Value.getName(), AbstractFuture.___003CGetCallerID_003E());
		System.Exception thrown = null;
		System.Exception ex2 = null;
		AtomicHelper aTOMIC_HELPER;
		System.Exception ex3;
		try
		{
			aTOMIC_HELPER = new UnsafeAtomicHelper(null);
		}
		catch (System.Exception x)
		{
			ex3 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			goto IL_005f;
		}
		goto IL_010c;
		IL_005f:
		System.Exception ex4 = ex3;
		thrown = ex4;
		System.Exception ex5;
		try
		{
			AtomicReferenceFieldUpdater atomicReferenceFieldUpdater = AtomicReferenceFieldUpdater.newUpdater(ClassLiteral<Waiter>.Value, ClassLiteral<java.lang.Thread>.Value, "thread", AbstractFuture.___003CGetCallerID_003E());
			AtomicReferenceFieldUpdater atomicReferenceFieldUpdater2 = AtomicReferenceFieldUpdater.newUpdater(ClassLiteral<Waiter>.Value, ClassLiteral<Waiter>.Value, "next", AbstractFuture.___003CGetCallerID_003E());
			_ = ClassLiteral<AbstractFuture>.Value;
			_ = ClassLiteral<Waiter>.Value;
			___003CARFU_003E_0 __003CARFU_003E_ = new ___003CARFU_003E_0();
			_ = ClassLiteral<AbstractFuture>.Value;
			_ = ClassLiteral<Listener>.Value;
			___003CARFU_003E_1 __003CARFU_003E_2 = new ___003CARFU_003E_1();
			_ = ClassLiteral<AbstractFuture>.Value;
			_ = ClassLiteral<java.lang.Object>.Value;
			aTOMIC_HELPER = new SafeAtomicHelper(atomicReferenceFieldUpdater, atomicReferenceFieldUpdater2, __003CARFU_003E_, __003CARFU_003E_2, new ___003CARFU_003E_2());
		}
		catch (System.Exception x2)
		{
			ex5 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			goto IL_00fa;
		}
		goto IL_010c;
		IL_00fa:
		System.Exception ex6 = ex5;
		ex2 = ex6;
		aTOMIC_HELPER = new SynchronizedHelper(null);
		goto IL_010c;
		IL_010c:
		ATOMIC_HELPER = aTOMIC_HELPER;
		_ = ClassLiteral<LockSupport>.Value;
		if (ex2 != null)
		{
			log.log(Level.SEVERE, "UnsafeAtomicHelper is broken!", thrown);
			log.log(Level.SEVERE, "SafeAtomicHelper is broken!", ex2);
		}
		NULL = new java.lang.Object();
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
