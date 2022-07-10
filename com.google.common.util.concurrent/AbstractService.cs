using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractService : java.lang.Object, Service
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, ListenerCallQueue.Event
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(56)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 9, 104 })]
		public virtual void call(Service.Listener P_0)
		{
			P_0.starting();
		}

		public override string toString()
		{
			return "starting()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(56)]
		public virtual void call(object P_0)
		{
			call((Service.Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _2 : java.lang.Object, ListenerCallQueue.Event
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(68)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 21, 104 })]
		public virtual void call(Service.Listener P_0)
		{
			P_0.running();
		}

		public override string toString()
		{
			return "running()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(68)]
		public virtual void call(object P_0)
		{
			call((Service.Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[EnclosingMethod(null, "terminatedEvent", "(Lcom.google.common.util.concurrent.Service$State;)Lcom.google.common.util.concurrent.ListenerCallQueue$Event;")]
	internal class _3 : java.lang.Object, ListenerCallQueue.Event
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Service.State val_0024from;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(94)]
		internal _3(Service.State P_0)
		{
			val_0024from = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 47, 110 })]
		public virtual void call(Service.Listener P_0)
		{
			P_0.terminated(val_0024from);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(102)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(val_0024from);
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("terminated({from = ").append(text).append("})")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(94)]
		public virtual void call(object P_0)
		{
			call((Service.Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[EnclosingMethod(null, "stoppingEvent", "(Lcom.google.common.util.concurrent.Service$State;)Lcom.google.common.util.concurrent.ListenerCallQueue$Event;")]
	internal class _4 : java.lang.Object, ListenerCallQueue.Event
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Service.State val_0024from;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(108)]
		internal _4(Service.State P_0)
		{
			val_0024from = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 61, 110 })]
		public virtual void call(Service.Listener P_0)
		{
			P_0.stopping(val_0024from);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(116)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(val_0024from);
			int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("stopping({from = ").append(text).append("})")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(108)]
		public virtual void call(object P_0)
		{
			call((Service.Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[EnclosingMethod(null, "enqueueFailedEvent", "(Lcom.google.common.util.concurrent.Service$State;Ljava.lang.Throwable;)V")]
	internal class _5 : java.lang.Object, ListenerCallQueue.Event
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Service.State val_0024from;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal System.Exception val_0024cause;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(561)]
		internal _5(AbstractService P_0, Service.State P_1, System.Exception P_2)
		{
			val_0024from = P_1;
			val_0024cause = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 194, 116 })]
		public virtual void call(Service.Listener P_0)
		{
			P_0.failed(val_0024from, val_0024cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(569)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(val_0024from);
			string text2 = java.lang.String.valueOf(val_0024cause);
			int num = 27 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("failed({from = ").append(text).append(", cause = ")
				.append(text2)
				.append("})")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(561)]
		public virtual void call(object P_0)
		{
			call((Service.Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _6 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(270)]
		static _6()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State = new int[(nint)Service.State.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003ENEW.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003ESTARTING.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			_ = null;
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003ERUNNING.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			_ = null;
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003ESTOPPING.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			_ = null;
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003ETERMINATED.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			_ = null;
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[Service.State.___003C_003EFAILED.ordinal()] = 6;
				return;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_6()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class HasReachedRunningGuard : Monitor.Guard
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 105, 103, 110 })]
		internal HasReachedRunningGuard(AbstractService P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024000(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(161)]
		public override bool isSatisfied()
		{
			return this_00240.state().compareTo(Service.State.___003C_003ERUNNING) >= 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class IsStartableGuard : Monitor.Guard
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 77, 103, 110 })]
		internal IsStartableGuard(AbstractService P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024000(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(133)]
		public override bool isSatisfied()
		{
			return this_00240.state() == Service.State.___003C_003ENEW;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class IsStoppableGuard : Monitor.Guard
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 91, 103, 110 })]
		internal IsStoppableGuard(AbstractService P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024000(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(147)]
		public override bool isSatisfied()
		{
			return this_00240.state().compareTo(Service.State.___003C_003ERUNNING) <= 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class IsStoppedGuard : Monitor.Guard
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 119, 103, 110 })]
		internal IsStoppedGuard(AbstractService P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024000(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		public override bool isSatisfied()
		{
			return this_00240.state().compareTo(Service.State.___003C_003ETERMINATED) >= 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class StateSnapshot : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		internal Service.State state;

		[Modifiers(Modifiers.Final)]
		internal bool shutdownWhenStartupFinishes;

		[Modifiers(Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal System.Exception failure;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 226, 107 })]
		internal StateSnapshot(Service.State P_0)
			: this(P_0, false, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 248, 66, 104, 218, 253, 70, 103, 103, 103 })]
		internal StateSnapshot(Service.State P_0, bool P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] System.Exception P_2)
		{
			Preconditions.checkArgument((!P_1 || P_0 == Service.State.___003C_003ESTARTING) ? true : false, "shutdownWhenStartupFinishes can only be set if state is STARTING. Got %s instead.", P_0);
			Preconditions.checkArgument(P_2 != null == (P_0 == Service.State.___003C_003EFAILED), "A failure cause should be set if and only if the state is failed.  Got %s and %s instead.", P_0, P_2);
			state = P_0;
			shutdownWhenStartupFinishes = P_1;
			failure = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 248, 117, 134 })]
		internal virtual Service.State externalState()
		{
			if (shutdownWhenStartupFinishes && state == Service.State.___003C_003ESTARTING)
			{
				return Service.State.___003C_003ESTOPPING;
			}
			return state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 1, 253, 69 })]
		internal virtual System.Exception failureCause()
		{
			Preconditions.checkState(state == Service.State.___003C_003EFAILED, "failureCause() is only valid if the service has failed, service is %s", state);
			return (System.Exception)java.util.Objects.requireNonNull(failure);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event STARTING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event RUNNING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event STOPPING_FROM_STARTING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event STOPPING_FROM_RUNNING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event TERMINATED_FROM_NEW_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event TERMINATED_FROM_STARTING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event TERMINATED_FROM_RUNNING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private static ListenerCallQueue.Event TERMINATED_FROM_STOPPING_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Monitor monitor;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Monitor.Guard isStartable;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Monitor.Guard isStoppable;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Monitor.Guard hasReachedRunning;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Monitor.Guard isStopped;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	private ListenerCallQueue listeners;

	private volatile StateSnapshot snapshot;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 151, 114 })]
	private void enqueueStartingEvent()
	{
		listeners.enqueue(STARTING_EVENT);
	}

	protected internal abstract void doStart();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 145, 109, 141 })]
	private void dispatchListenerEvents()
	{
		if (!monitor.isOccupiedByCurrentThread())
		{
			listeners.dispatch();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 88, 135, 139, 103, 191, 17, 223, 32, 121,
		104, 228, 70, 107, 102, 3, 130, 98
	})]
	protected internal void notifyFailed(System.Exception cause)
	{
		Preconditions.checkNotNull(cause);
		monitor.enter();
		try
		{
			Service.State state = this.state();
			switch (_6._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[state.ordinal()])
			{
			case 1:
			case 5:
			{
				string text = java.lang.String.valueOf(state);
				int num = 22 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string message = new StringBuilder(num).append("Failed while in state:").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException(message, cause);
			}
			case 2:
			case 3:
			case 4:
				snapshot = new StateSnapshot(Service.State.___003C_003EFAILED, false, cause);
				System.Threading.Thread.MemoryBarrier();
				enqueueFailedEvent(state, cause);
				break;
			case 6:
				break;
			}
		}
		finally
		{
			monitor.leave();
			dispatchListenerEvents();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(490)]
	public Service.State state()
	{
		Service.State result = snapshot.externalState();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 169, 159, 14, 112, 130, 112, 130, 112, 130,
		112, 162, 139
	})]
	private void enqueueTerminatedEvent(Service.State P_0)
	{
		switch (_6._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[P_0.ordinal()])
		{
		case 1:
			listeners.enqueue(TERMINATED_FROM_NEW_EVENT);
			break;
		case 2:
			listeners.enqueue(TERMINATED_FROM_STARTING_EVENT);
			break;
		case 3:
			listeners.enqueue(TERMINATED_FROM_RUNNING_EVENT);
			break;
		case 4:
			listeners.enqueue(TERMINATED_FROM_STOPPING_EVENT);
			break;
		case 5:
		case 6:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 159, 104, 114, 104, 146, 139 })]
	private void enqueueStoppingEvent(Service.State P_0)
	{
		if (P_0 == Service.State.___003C_003ESTARTING)
		{
			listeners.enqueue(STOPPING_FROM_STARTING_EVENT);
			return;
		}
		if (P_0 == Service.State.___003C_003ERUNNING)
		{
			listeners.enqueue(STOPPING_FROM_RUNNING_EVENT);
			return;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	protected internal virtual void doCancelStart()
	{
	}

	protected internal abstract void doStop();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 5, 103, 103, 139, 159, 66, 144, 191, 104 })]
	private void checkCurrentState(Service.State P_0)
	{
		Service.State state = this.state();
		if (state != P_0)
		{
			string text;
			string text2;
			int num;
			if (state == Service.State.___003C_003EFAILED)
			{
				text = java.lang.String.valueOf(this);
				text2 = java.lang.String.valueOf(P_0);
				num = 56 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num = num;
				string message = new StringBuilder(num).append("Expected the service ").append(text).append(" to be ")
					.append(text2)
					.append(", but the service has FAILED")
					.toString();
				System.Exception cause = failureCause();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException(message, cause);
			}
			text = java.lang.String.valueOf(this);
			text2 = java.lang.String.valueOf(P_0);
			string text3 = java.lang.String.valueOf(state);
			num = 38 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
			num = num;
			string s = new StringBuilder(num).append("Expected the service ").append(text).append(" to be ")
				.append(text2)
				.append(", but was ")
				.append(text3)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(496)]
	public System.Exception failureCause()
	{
		System.Exception result = snapshot.failureCause();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 155, 114 })]
	private void enqueueRunningEvent()
	{
		listeners.enqueue(RUNNING_EVENT);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 190, 245, 76 })]
	private void enqueueFailedEvent(Service.State P_0, System.Exception P_1)
	{
		listeners.enqueue(new _5(this, P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/Service$State;)Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[LineNumberTable(108)]
	private static ListenerCallQueue.Event stoppingEvent(Service.State P_0)
	{
		_4 result = new _4(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/Service$State;)Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/Service$Listener;>;")]
	[LineNumberTable(94)]
	private static ListenerCallQueue.Event terminatedEvent(Service.State P_0)
	{
		_3 result = new _3(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 80, 232, 159, 183, 139, 236, 78, 236, 78,
		236, 78, 236, 79, 235, 75, 183
	})]
	protected internal AbstractService()
	{
		monitor = new Monitor();
		isStartable = new IsStartableGuard(this);
		isStoppable = new IsStoppableGuard(this);
		hasReachedRunning = new HasReachedRunningGuard(this);
		isStopped = new IsStoppedGuard(this);
		listeners = new ListenerCallQueue();
		snapshot = new StateSnapshot(Service.State.___003C_003ENEW);
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 133, 150, 119, 102, 211, 107, 102, 6, 107,
		102, 228, 59, 97, 139, 107, 102, 3, 130, 132,
		159, 45
	})]
	public Service startAsync()
	{
		System.Exception ex;
		if (monitor.enterIf(isStartable))
		{
			try
			{
				try
				{
					snapshot = new StateSnapshot(Service.State.___003C_003ESTARTING);
					System.Threading.Thread.MemoryBarrier();
					enqueueStartingEvent();
					doStart();
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_005a;
				}
			}
			catch
			{
				//try-fault
				monitor.leave();
				dispatchListenerEvents();
				throw;
			}
			monitor.leave();
			dispatchListenerEvents();
			goto IL_00e4;
		}
		string text = java.lang.String.valueOf(this);
		int num = 33 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string s = new StringBuilder(num).append("Service ").append(text).append(" has already been started")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalStateException(s);
		IL_00e4:
		return this;
		IL_005a:
		System.Exception ex2 = ex;
		try
		{
			System.Exception cause = ex2;
			notifyFailed(cause);
		}
		finally
		{
			monitor.leave();
			dispatchListenerEvents();
		}
		goto IL_00e4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		153,
		150,
		103,
		159,
		17,
		119,
		107,
		133,
		121,
		107,
		102,
		133,
		119,
		107,
		102,
		226,
		69,
		byte.MaxValue,
		42,
		69,
		107,
		102,
		6,
		107,
		102,
		230,
		59,
		98,
		140,
		107,
		102,
		3,
		130,
		130
	})]
	public Service stopAsync()
	{
		System.Exception ex;
		if (monitor.enterIf(isStoppable))
		{
			try
			{
				try
				{
					Service.State state = this.state();
					switch (_6._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[state.ordinal()])
					{
					case 1:
						snapshot = new StateSnapshot(Service.State.___003C_003ETERMINATED);
						System.Threading.Thread.MemoryBarrier();
						enqueueTerminatedEvent(Service.State.___003C_003ENEW);
						break;
					case 2:
						snapshot = new StateSnapshot(Service.State.___003C_003ESTARTING, true, null);
						System.Threading.Thread.MemoryBarrier();
						enqueueStoppingEvent(Service.State.___003C_003ESTARTING);
						doCancelStart();
						break;
					case 3:
						snapshot = new StateSnapshot(Service.State.___003C_003ESTOPPING);
						System.Threading.Thread.MemoryBarrier();
						enqueueStoppingEvent(Service.State.___003C_003ERUNNING);
						doStop();
						break;
					case 4:
					case 5:
					case 6:
					{
						string text = java.lang.String.valueOf(state);
						int num = 45 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
						num = num;
						string detailMessage = new StringBuilder(num).append("isStoppable is incorrectly implemented, saw: ").append(text).toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new AssertionError(detailMessage);
					}
					}
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_012a;
				}
			}
			catch
			{
				//try-fault
				monitor.leave();
				dispatchListenerEvents();
				throw;
			}
			monitor.leave();
			dispatchListenerEvents();
		}
		goto IL_016a;
		IL_016a:
		return this;
		IL_012a:
		System.Exception ex2 = ex;
		try
		{
			System.Exception cause = ex2;
			notifyFailed(cause);
		}
		finally
		{
			monitor.leave();
			dispatchListenerEvents();
		}
		goto IL_016a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 189, 145, 143, 107, 35, 98, 98 })]
	public void awaitRunning()
	{
		monitor.enterWhenUninterruptibly(hasReachedRunning);
		try
		{
			checkCurrentState(Service.State.___003C_003ERUNNING);
		}
		finally
		{
			monitor.leave();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 200, 105 })]
	public void awaitRunning(Duration timeout)
	{
		Service._003Cdefault_003EawaitRunning(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[]
	{
		160, 205, 149, 143, 107, 35, 98, 228, 70, 159,
		41
	})]
	public void awaitRunning(long timeout, TimeUnit unit)
	{
		if (monitor.enterWhenUninterruptibly(hasReachedRunning, timeout, unit))
		{
			try
			{
				checkCurrentState(Service.State.___003C_003ERUNNING);
				return;
			}
			finally
			{
				monitor.leave();
			}
		}
		string text = java.lang.String.valueOf(this);
		int num = 50 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string message = new StringBuilder(num).append("Timed out waiting for ").append(text).append(" to reach the RUNNING state.")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.util.concurrent.TimeoutException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 222, 145, 143, 107, 35, 98, 98 })]
	public void awaitTerminated()
	{
		monitor.enterWhenUninterruptibly(isStopped);
		try
		{
			checkCurrentState(Service.State.___003C_003ETERMINATED);
		}
		finally
		{
			monitor.leave();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 233, 105 })]
	public void awaitTerminated(Duration timeout)
	{
		Service._003Cdefault_003EawaitTerminated(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[]
	{
		160, 238, 149, 143, 107, 35, 98, 231, 70, 232,
		69, 159, 63
	})]
	public void awaitTerminated(long timeout, TimeUnit unit)
	{
		if (monitor.enterWhenUninterruptibly(isStopped, timeout, unit))
		{
			try
			{
				checkCurrentState(Service.State.___003C_003ETERMINATED);
				return;
			}
			finally
			{
				monitor.leave();
			}
		}
		string text = java.lang.String.valueOf(this);
		string text2 = java.lang.String.valueOf(state());
		int num = 65 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string message = new StringBuilder(num).append("Timed out waiting for ").append(text).append(" to reach a terminal state. Current state: ")
			.append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.util.concurrent.TimeoutException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 25, 203, 116, 191, 38, 103, 167, 111, 183,
		136, 119, 170, 107, 102, 3, 130, 98
	})]
	protected internal void notifyStarted()
	{
		monitor.enter();
		try
		{
			if (snapshot.state != Service.State.___003C_003ESTARTING)
			{
				string text = java.lang.String.valueOf(snapshot.state);
				int num = 43 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				IllegalStateException ex = new IllegalStateException(new StringBuilder(num).append("Cannot notifyStarted() when the service is ").append(text).toString());
				notifyFailed(ex);
				throw Throwable.___003Cunmap_003E(ex);
			}
			if (snapshot.shutdownWhenStartupFinishes)
			{
				snapshot = new StateSnapshot(Service.State.___003C_003ESTOPPING);
				System.Threading.Thread.MemoryBarrier();
				doStop();
			}
			else
			{
				snapshot = new StateSnapshot(Service.State.___003C_003ERUNNING);
				System.Threading.Thread.MemoryBarrier();
				enqueueRunningEvent();
			}
		}
		finally
		{
			monitor.leave();
			dispatchListenerEvents();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 61, 139, 103, 223, 14, 223, 31, 119, 203,
		107, 102, 3, 130, 98
	})]
	protected internal void notifyStopped()
	{
		monitor.enter();
		try
		{
			Service.State state = this.state();
			switch (_6._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024Service_0024State[state.ordinal()])
			{
			case 1:
			case 5:
			case 6:
			{
				string text = java.lang.String.valueOf(state);
				int num = 43 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string s = new StringBuilder(num).append("Cannot notifyStopped() when the service is ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException(s);
			}
			case 2:
			case 3:
			case 4:
				snapshot = new StateSnapshot(Service.State.___003C_003ETERMINATED);
				System.Threading.Thread.MemoryBarrier();
				enqueueTerminatedEvent(state);
				break;
			}
		}
		finally
		{
			monitor.leave();
			dispatchListenerEvents();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(485)]
	public bool isRunning()
	{
		return state() == Service.State.___003C_003ERUNNING;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 132, 111 })]
	public void addListener(Service.Listener listener, Executor executor)
	{
		listeners.addListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(507)]
	public override string toString()
	{
		string simpleName = java.lang.Object.instancehelper_getClass(this).getSimpleName();
		string text = java.lang.String.valueOf(state());
		int num = 3 + java.lang.String.instancehelper_length(java.lang.String.valueOf(simpleName)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(simpleName).append(" [").append(text)
			.append("]")
			.toString();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static Monitor access_0024000(AbstractService P_0)
	{
		return P_0.monitor;
	}

	[LineNumberTable(new byte[]
	{
		5, 234, 76, 234, 76, 101, 106, 101, 138, 101,
		106, 101, 106, 101, 106, 101, 42
	})]
	static AbstractService()
	{
		STARTING_EVENT = new _1();
		RUNNING_EVENT = new _2();
		STOPPING_FROM_STARTING_EVENT = stoppingEvent(Service.State.___003C_003ESTARTING);
		STOPPING_FROM_RUNNING_EVENT = stoppingEvent(Service.State.___003C_003ERUNNING);
		TERMINATED_FROM_NEW_EVENT = terminatedEvent(Service.State.___003C_003ENEW);
		TERMINATED_FROM_STARTING_EVENT = terminatedEvent(Service.State.___003C_003ESTARTING);
		TERMINATED_FROM_RUNNING_EVENT = terminatedEvent(Service.State.___003C_003ERUNNING);
		TERMINATED_FROM_STOPPING_EVENT = terminatedEvent(Service.State.___003C_003ESTOPPING);
	}
}
