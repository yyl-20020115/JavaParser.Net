using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent.atomic;
using java.util.concurrent.locks;

namespace com.google.common.util.concurrent;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Ljava/util/concurrent/atomic/AtomicReference<Ljava/lang/Runnable;>;Ljava/lang/Runnable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0,
	2,
	16,
	byte.MaxValue,
	byte.MaxValue,
	1,
	3,
	0,
	0,
	123,
	0,
	0,
	17,
	0,
	0,
	0,
	0,
	123,
	0,
	0
})]
[ConstantPool(new object[]
{
	(byte)123,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Runnable" })]
internal abstract class InterruptibleTask : AtomicReference, Runnable
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

	[Serializable]
	[Implements(new string[] { "java.lang.Runnable" })]
	internal sealed class Blocker : AbstractOwnableSynchronizer, Runnable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/InterruptibleTask<*>;")]
		private InterruptibleTask task;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(220)]
		internal Blocker(InterruptibleTask P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(220)]
		internal static void access_0024200(Blocker P_0, Thread P_1)
		{
			P_0.setOwner(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 117, 105 })]
		private void setOwner(Thread P_0)
		{
			setExclusiveOwnerThread(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/InterruptibleTask<*>;)V")]
		[LineNumberTable(new byte[] { 160, 109, 104, 103 })]
		private Blocker(InterruptibleTask P_0)
		{
			task = P_0;
		}

		public virtual void run()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(236)]
		public override string toString()
		{
			string result = task.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Blocker(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class DoNothingRunnable : java.lang.Object, Runnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(44)]
		internal DoNothingRunnable(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(44)]
		private DoNothingRunnable()
		{
		}

		public virtual void run()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Runnable DONE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Runnable PARKED;

	private const int MAX_BUSY_WAIT_SPINS = 1000;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	internal abstract bool isDone();

	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("()TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal abstract object runInterruptibly();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		54, 98, 226, 74, 108, 98, 115, 104, 135, 100,
		232, 72, 246, 76, 111, 168, 133, 145, 99, 232,
		71
	})]
	private void waitForInterrupt(Thread P_0)
	{
		int num = 0;
		int num2 = 0;
		Runnable runnable = (Runnable)get();
		Blocker blocker = null;
		while (runnable is Blocker || runnable == PARKED)
		{
			if (runnable is Blocker)
			{
				blocker = (Blocker)runnable;
			}
			num2++;
			if (num2 > 1000)
			{
				if (runnable == PARKED || compareAndSet(runnable, PARKED))
				{
					num = ((Thread.interrupted() || num != 0) ? 1 : 0);
					LockSupport.park(blocker);
				}
			}
			else
			{
				Thread.yield();
			}
			runnable = (Runnable)get();
		}
		if (num != 0)
		{
			P_0.interrupt();
		}
	}

	[Signature("(TT;)V")]
	internal abstract void afterRanInterruptiblySuccess([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_0);

	internal abstract void afterRanInterruptiblyFailure(System.Exception P_0);

	internal abstract string toPendingString();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	internal InterruptibleTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		14, 102, 106, 161, 109, 98, 130, 99, 245, 70,
		110, 135, 99, 131, 142, 167, 231, 53, 110, 135,
		102, 131, 142, 233, 52, 98, 163, 110, 135, 99,
		131, 142, 201
	})]
	public void run()
	{
		Thread thread = Thread.currentThread();
		if (!compareAndSet(null, thread))
		{
			return;
		}
		int num = ((!isDone()) ? 1 : 0);
		object obj = null;
		System.Exception ex = null;
		System.Exception ex2;
		try
		{
			try
			{
				if (num != 0)
				{
					obj = runInterruptibly();
				}
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_006d;
			}
		}
		catch
		{
			//try-fault
			if (!compareAndSet(thread, DONE))
			{
				waitForInterrupt(thread);
			}
			if (num != 0)
			{
				if (ex == null)
				{
					afterRanInterruptiblySuccess(NullnessCasts.uncheckedCastNullableTToT(obj));
				}
				else
				{
					afterRanInterruptiblyFailure(ex);
				}
			}
			throw;
		}
		if (!compareAndSet(thread, DONE))
		{
			waitForInterrupt(thread);
		}
		if (num != 0)
		{
			if ((object)null == null)
			{
				afterRanInterruptiblySuccess(NullnessCasts.uncheckedCastNullableTToT(obj));
			}
			else
			{
				afterRanInterruptiblyFailure(null);
			}
		}
		return;
		IL_006d:
		System.Exception ex3 = ex2;
		ex = ex3;
		if (!compareAndSet(thread, DONE))
		{
			waitForInterrupt(thread);
		}
		if (num != 0)
		{
			if (ex == null)
			{
				afterRanInterruptiblySuccess(NullnessCasts.uncheckedCastNullableTToT(obj));
			}
			else
			{
				afterRanInterruptiblyFailure(ex);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 79, 108, 107, 104, 107, 237, 70, 143, 113,
		104, 139, 227, 60, 113, 104, 139, 162
	})]
	internal void interruptTask()
	{
		Runnable runnable = (Runnable)get();
		if (!(runnable is Thread))
		{
			return;
		}
		Blocker blocker = new Blocker(this, null);
		Blocker.access_0024200(blocker, Thread.currentThread());
		if (!compareAndSet(runnable, blocker))
		{
			return;
		}
		try
		{
			((Thread)runnable).interrupt();
		}
		catch
		{
			//try-fault
			Runnable runnable2 = (Runnable)getAndSet(DONE);
			if (runnable2 == PARKED)
			{
				LockSupport.unpark((Thread)runnable);
			}
			throw;
		}
		Runnable runnable3 = (Runnable)getAndSet(DONE);
		if (runnable3 == PARKED)
		{
			LockSupport.unpark((Thread)runnable);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 128, 140, 104, 107, 104, 104, 136, 159, 38,
		134
	})]
	public sealed override string toString()
	{
		Runnable runnable = (Runnable)get();
		string text;
		string name;
		int num;
		if (runnable == DONE)
		{
			text = "running=[DONE]";
		}
		else if (runnable is Blocker)
		{
			text = "running=[INTERRUPTED]";
		}
		else if (runnable is Thread)
		{
			name = ((Thread)runnable).getName();
			num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
			num = num;
			text = new StringBuilder(num).append("running=[RUNNING ON ").append(name).append("]")
				.toString();
		}
		else
		{
			text = "running=[NOT STARTED YET]";
		}
		name = toPendingString();
		num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
		num = num;
		string result = new StringBuilder(num).append(text).append(", ").append(name)
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 183, 230, 73, 107 })]
	static InterruptibleTask()
	{
		_ = ClassLiteral<LockSupport>.Value;
		DONE = new DoNothingRunnable(null);
		PARKED = new DoNothingRunnable(null);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected InterruptibleTask(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
