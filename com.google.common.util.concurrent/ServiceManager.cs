using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.@ref;
using java.time;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.logging;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class ServiceManager : java.lang.Object, ServiceManagerBridge
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, ListenerCallQueue.Event
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 81, 104 })]
		public virtual void call(Listener P_0)
		{
			P_0.healthy();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(128)]
		internal _1()
		{
		}

		public override string toString()
		{
			return "healthy()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(128)]
		public virtual void call(object P_0)
		{
			call((Listener)P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _2 : java.lang.Object, ListenerCallQueue.Event
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(140)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 93, 104 })]
		public virtual void call(Listener P_0)
		{
			P_0.stopped();
		}

		public override string toString()
		{
			return "stopped()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(140)]
		public virtual void call(object P_0)
		{
			call((Listener)P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class EmptyServiceManagerWarning : Throwable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(878)]
		internal EmptyServiceManagerWarning(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(878)]
		private EmptyServiceManagerWarning()
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected EmptyServiceManagerWarning(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class FailedService : Throwable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 0, 98, 102, 7, 231, 69 })]
		internal FailedService(Service P_0)
			: base(java.lang.Object.instancehelper_toString(P_0), P_0.failureCause(), enableSuppression: false, writableStackTrace: false)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected FailedService(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	public abstract class Listener : java.lang.Object
	{
		public virtual void healthy()
		{
		}

		public virtual void stopped()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(161)]
		public Listener()
		{
		}

		public virtual void failure(Service service)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class NoOpService : AbstractService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(865)]
		internal NoOpService(ServiceManager._1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(865)]
		private NoOpService()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 242, 104 })]
		protected internal override void doStart()
		{
			notifyStarted();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 247, 104 })]
		protected internal override void doStop()
		{
			notifyStopped();
		}

		[HideFromJava]
		static NoOpService()
		{
			AbstractService.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ServiceListener : Service.Listener
	{
		[Modifiers(Modifiers.Final)]
		internal Service service;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/ref/WeakReference<Lcom/google/common/util/concurrent/ServiceManager$ServiceManagerState;>;")]
		internal java.lang.@ref.WeakReference state;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/Service;Ljava/lang/ref/WeakReference<Lcom/google/common/util/concurrent/ServiceManager$ServiceManagerState;>;)V")]
		[LineNumberTable(new byte[] { 162, 162, 104, 103, 103 })]
		internal ServiceListener(Service P_0, java.lang.@ref.WeakReference P_1)
		{
			service = P_0;
			state = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 169, 113, 99, 118, 109, 188 })]
		public override void starting()
		{
			ServiceManagerState serviceManagerState = (ServiceManagerState)state.get();
			if (serviceManagerState != null)
			{
				serviceManagerState.transitionService(service, Service.State.___003C_003ENEW, Service.State.___003C_003ESTARTING);
				if (!(service is NoOpService))
				{
					access_0024200().log(Level.FINE, "Starting {0}.", service);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 180, 113, 99, 152 })]
		public override void running()
		{
			((ServiceManagerState)state.get())?.transitionService(service, Service.State.___003C_003ESTARTING, Service.State.___003C_003ERUNNING);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 188, 113, 99, 148 })]
		public override void stopping(Service.State P_0)
		{
			((ServiceManagerState)state.get())?.transitionService(service, P_0, Service.State.___003C_003ESTOPPING);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162,
			196,
			113,
			99,
			109,
			byte.MaxValue,
			8,
			69,
			148
		})]
		public override void terminated(Service.State P_0)
		{
			ServiceManagerState serviceManagerState = (ServiceManagerState)state.get();
			if (serviceManagerState != null)
			{
				if (!(service is NoOpService))
				{
					access_0024200().log(Level.FINE, "Service {0} has terminated. Previous state was: {1}", new object[2] { service, P_0 });
				}
				serviceManagerState.transitionService(service, P_0, Service.State.___003C_003ETERMINATED);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162,
			210,
			113,
			166,
			242,
			69,
			110,
			102,
			byte.MaxValue,
			90,
			69,
			148
		})]
		public override void failed(Service.State P_0, System.Exception P_1)
		{
			ServiceManagerState serviceManagerState = (ServiceManagerState)state.get();
			if (serviceManagerState != null)
			{
				int num = ((!(service is NoOpService)) ? 1 : 0);
				if (((uint)num & ((P_0 != Service.State.___003C_003ESTARTING) ? 1u : 0u)) != 0)
				{
					Logger logger = access_0024200();
					Level sEVERE = Level.SEVERE;
					string text = java.lang.String.valueOf(service);
					string text2 = java.lang.String.valueOf(P_0);
					int num2 = 34 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
					num2 = num2;
					logger.log(sEVERE, new StringBuilder(num2).append("Service ").append(text).append(" has failed in the ")
						.append(text2)
						.append(" state.")
						.toString(), P_1);
				}
				serviceManagerState.transitionService(service, P_0, Service.State.___003C_003EFAILED);
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ServiceManagerState : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map$Entry<Lcom/google/common/util/concurrent/Service;Ljava/lang/Long;>;Ljava/lang/Long;>;")]
		[EnclosingMethod(null, "startupTimes", "()Lcom.google.common.collect.ImmutableMap;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<Lcom/google/common/util/concurrent/Service;Ljava/lang/Long;>;)Ljava/lang/Long;")]
			[LineNumberTable(658)]
			public virtual Long apply(Map.Entry P_0)
			{
				return (Long)P_0.getValue();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(655)]
			internal _1(ServiceManagerState P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(655)]
			public virtual object apply(object P_0)
			{
				Long result = apply((Map.Entry)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
		[EnclosingMethod(null, "enqueueFailedEvent", "(Lcom.google.common.util.concurrent.Service;)V")]
		internal class _2 : java.lang.Object, ListenerCallQueue.Event
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Service val_0024service;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(741)]
			internal _2(ServiceManagerState P_0, Service P_1)
			{
				val_0024service = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 118, 110 })]
			public virtual void call(Listener P_0)
			{
				P_0.failure(val_0024service);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(749)]
			public override string toString()
			{
				string text = java.lang.String.valueOf(val_0024service);
				int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string result = new StringBuilder(num).append("failed({service=").append(text).append("})")
					.toString();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(741)]
			public virtual void call(object P_0)
			{
				call((Listener)P_0);
			}
		}

		internal sealed class AwaitHealthGuard : Monitor.Guard
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceManagerState this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 114, 103, 110 })]
			internal AwaitHealthGuard(ServiceManagerState P_0)
			{
				this_00240 = P_0;
				base._002Ector(P_0.monitor);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 122, 127, 19, 119, 119, 235, 61 })]
			public override bool isSatisfied()
			{
				return (this_00240.states.count(Service.State.___003C_003ERUNNING) == this_00240.numberOfServices || this_00240.states.contains(Service.State.___003C_003ESTOPPING) || this_00240.states.contains(Service.State.___003C_003ETERMINATED) || this_00240.states.contains(Service.State.___003C_003EFAILED)) ? true : false;
			}
		}

		internal sealed class StoppedGuard : Monitor.Guard
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceManagerState this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 134, 103, 110 })]
			internal StoppedGuard(ServiceManagerState P_0)
			{
				this_00240 = P_0;
				base._002Ector(P_0.monitor);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(511)]
			public override bool isSatisfied()
			{
				return this_00240.states.count(Service.State.___003C_003ETERMINATED) + this_00240.states.count(Service.State.___003C_003EFAILED) == this_00240.numberOfServices;
			}
		}

		[Modifiers(Modifiers.Final)]
		internal Monitor monitor;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/SetMultimap<Lcom/google/common/util/concurrent/Service$State;Lcom/google/common/util/concurrent/Service;>;")]
		internal SetMultimap servicesByState;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<Lcom/google/common/util/concurrent/Service$State;>;")]
		internal Multiset states;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<Lcom/google/common/util/concurrent/Service;Lcom/google/common/base/Stopwatch;>;")]
		internal Map startupTimers;

		internal bool ready;

		internal bool transitioned;

		[Modifiers(Modifiers.Final)]
		internal int numberOfServices;

		[Modifiers(Modifiers.Final)]
		internal Monitor.Guard awaitHealthGuard;

		[Modifiers(Modifiers.Final)]
		internal Monitor.Guard stoppedGuard;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
		internal ListenerCallQueue listeners;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableCollection<Lcom/google/common/util/concurrent/Service;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 154, 232, 159, 175, 139, 134, 148, 103, 138,
			97, 234, 91, 236, 84, 236, 80, 235, 73, 108,
			114
		})]
		internal ServiceManagerState(ImmutableCollection P_0)
		{
			monitor = new Monitor();
			this.servicesByState = MultimapBuilder.enumKeys(ClassLiteral<Service.State>.Value).linkedHashSetValues().build();
			states = this.servicesByState.keys();
			startupTimers = Maps.newIdentityHashMap();
			awaitHealthGuard = new AwaitHealthGuard(this);
			stoppedGuard = new StoppedGuard(this);
			listeners = new ListenerCallQueue();
			numberOfServices = P_0.size();
			this.servicesByState.putAll(Service.State.___003C_003ENEW, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161,
			180,
			139,
			136,
			172,
			102,
			127,
			6,
			109,
			136,
			98,
			byte.MaxValue,
			37,
			70,
			107,
			35,
			98,
			98
		})]
		internal virtual void markReady()
		{
			monitor.enter();
			try
			{
				if (!transitioned)
				{
					ready = true;
					return;
				}
				ArrayList arrayList = Lists.newArrayList();
				UnmodifiableIterator unmodifiableIterator = servicesByState().values().iterator();
				while (((Iterator)unmodifiableIterator).hasNext())
				{
					Service service = (Service)((Iterator)unmodifiableIterator).next();
					if (service.state() != Service.State.___003C_003ENEW)
					{
						((List)arrayList).add((object)service);
					}
				}
				string text = java.lang.String.valueOf(arrayList);
				int num = 89 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string s = new StringBuilder(num).append("Services started transitioning asynchronously before the ServiceManager was constructed: ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			finally
			{
				monitor.leave();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 204, 111 })]
		internal virtual void addListener(Listener P_0, Executor P_1)
		{
			listeners.addListener(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 164, 139, 114, 99, 182, 107, 35, 98, 98 })]
		internal virtual void tryStartTiming(Service P_0)
		{
			monitor.enter();
			try
			{
				Stopwatch stopwatch = (Stopwatch)startupTimers.get(P_0);
				if (stopwatch == null)
				{
					startupTimers.put(P_0, Stopwatch.createStarted());
				}
			}
			finally
			{
				monitor.leave();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 208, 145, 138, 107, 35, 98, 98 })]
		internal virtual void awaitHealthy()
		{
			monitor.enterWhenUninterruptibly(awaitHealthGuard);
			try
			{
				checkHealthy();
			}
			finally
			{
				monitor.leave();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
		[LineNumberTable(new byte[]
		{
			161, 217, 139, 117, 176, 159, 45, 138, 107, 35,
			98, 98
		})]
		internal virtual void awaitHealthy(long P_0, TimeUnit P_1)
		{
			monitor.enter();
			try
			{
				if (!monitor.waitForUninterruptibly(awaitHealthGuard, P_0, P_1))
				{
					string text = java.lang.String.valueOf(Multimaps.filterKeys(this.servicesByState, Predicates.@in(ImmutableSet.of(Service.State.___003C_003ENEW, Service.State.___003C_003ESTARTING))));
					int num = 93 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num = num;
					string message = new StringBuilder(num).append("Timeout waiting for the services to become healthy. The following services have not started: ").append(text).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new java.util.concurrent.TimeoutException(message);
				}
				checkHealthy();
			}
			finally
			{
				monitor.leave();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 232, 113, 109 })]
		internal virtual void awaitStopped()
		{
			monitor.enterWhenUninterruptibly(stoppedGuard);
			monitor.leave();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
		[LineNumberTable(new byte[]
		{
			161, 237, 139, 117, 176, 191, 52, 107, 35, 98,
			98
		})]
		internal virtual void awaitStopped(long P_0, TimeUnit P_1)
		{
			monitor.enter();
			try
			{
				if (!monitor.waitForUninterruptibly(stoppedGuard, P_0, P_1))
				{
					string text = java.lang.String.valueOf(Multimaps.filterKeys(this.servicesByState, Predicates.not(Predicates.@in(EnumSet.of(Service.State.___003C_003ETERMINATED, Service.State.___003C_003EFAILED)))));
					int num = 83 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num = num;
					string message = new StringBuilder(num).append("Timeout waiting for the services to stop. The following services have not stopped: ").append(text).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new java.util.concurrent.TimeoutException(message);
				}
			}
			finally
			{
				monitor.leave();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<Lcom/google/common/util/concurrent/Service$State;Lcom/google/common/util/concurrent/Service;>;")]
		[LineNumberTable(new byte[]
		{
			161, 251, 102, 139, 127, 6, 109, 136, 132, 107,
			35, 98, 98
		})]
		internal virtual ImmutableSetMultimap servicesByState()
		{
			ImmutableSetMultimap.Builder builder = ImmutableSetMultimap.builder();
			monitor.enter();
			try
			{
				Iterator iterator = this.servicesByState.entries().iterator();
				while (iterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)iterator.next();
					if (!(entry.getValue() is NoOpService))
					{
						builder.put(entry);
					}
				}
			}
			finally
			{
				monitor.leave();
			}
			return builder.build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<Lcom/google/common/util/concurrent/Service;Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[]
		{
			162, 11, 139, 145, 127, 9, 108, 109, 113, 158,
			135, 107, 35, 98, 98, 129, 107, 229, 61, 229,
			74
		})]
		internal virtual ImmutableMap startupTimes()
		{
			monitor.enter();
			ArrayList arrayList;
			try
			{
				arrayList = Lists.newArrayListWithCapacity(startupTimers.size());
				Iterator iterator = startupTimers.entrySet().iterator();
				while (iterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)iterator.next();
					Service service = (Service)entry.getKey();
					Stopwatch stopwatch = (Stopwatch)entry.getValue();
					if (!stopwatch.isRunning() && !(service is NoOpService))
					{
						((List)arrayList).add((object)Maps.immutableEntry(service, Long.valueOf(stopwatch.elapsed(TimeUnit.MILLISECONDS))));
					}
				}
			}
			finally
			{
				monitor.leave();
			}
			Collections.sort(arrayList, Ordering.natural().onResultOf(new _1(this)));
			return ImmutableMap.copyOf(arrayList);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162,
			51,
			103,
			108,
			139,
			103,
			238,
			107,
			139,
			102,
			229,
			61,
			139,
			230,
			20,
			161,
			104,
			44,
			229,
			69,
			104,
			44,
			229,
			70,
			114,
			131,
			102,
			142,
			150,
			103,
			104,
			byte.MaxValue,
			3,
			70,
			104,
			167,
			184,
			104,
			127,
			10,
			170,
			139,
			102,
			227,
			61,
			162,
			98
		})]
		internal virtual void transitionService(Service P_0, Service.State P_1, Service.State P_2)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkArgument(P_1 != P_2);
			monitor.enter();
			try
			{
				transitioned = true;
				if (!ready)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				monitor.leave();
				dispatchListenerEvents();
				throw;
			}
			try
			{
				Preconditions.checkState(this.servicesByState.remove(P_1, P_0), "Service %s not at the expected location in the state map %s", P_0, P_1);
				Preconditions.checkState(this.servicesByState.put(P_2, P_0), "Service %s in the state map unexpectedly at %s", P_0, P_2);
				Stopwatch stopwatch = (Stopwatch)startupTimers.get(P_0);
				if (stopwatch == null)
				{
					stopwatch = Stopwatch.createStarted();
					startupTimers.put(P_0, stopwatch);
				}
				if (P_2.compareTo(Service.State.___003C_003ERUNNING) >= 0 && stopwatch.isRunning())
				{
					stopwatch.stop();
					if (!(P_0 is NoOpService))
					{
						access_0024200().log(Level.FINE, "Started {0} in {1}.", new object[2] { P_0, stopwatch });
					}
				}
				if (P_2 == Service.State.___003C_003EFAILED)
				{
					enqueueFailedEvent(P_0);
				}
				if (states.count(Service.State.___003C_003ERUNNING) == numberOfServices)
				{
					enqueueHealthyEvent();
				}
				else if (states.count(Service.State.___003C_003ETERMINATED) + states.count(Service.State.___003C_003EFAILED) == numberOfServices)
				{
					enqueueStoppedEvent();
				}
				return;
			}
			finally
			{
				monitor.leave();
				dispatchListenerEvents();
			}
			IL_0049:
			monitor.leave();
			dispatchListenerEvents();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 138, 123, 171, 127, 40, 127, 12, 109, 98,
			135
		})]
		internal virtual void checkHealthy()
		{
			if (states.count(Service.State.___003C_003ERUNNING) != numberOfServices)
			{
				string text = java.lang.String.valueOf(Multimaps.filterKeys(this.servicesByState, Predicates.not(Predicates.equalTo(Service.State.___003C_003ERUNNING))));
				int num = 79 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				IllegalStateException ex = new IllegalStateException(new StringBuilder(num).append("Expected to be healthy after starting. The following services are not running: ").append(text).toString());
				Iterator iterator = this.servicesByState.get(Service.State.___003C_003EFAILED).iterator();
				while (iterator.hasNext())
				{
					Service service = (Service)iterator.next();
					Throwable.instancehelper_addSuppressed(ex, new FailedService(service));
				}
				throw Throwable.___003Cunmap_003E(ex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 130, 102, 48, 165, 109 })]
		internal virtual void dispatchListenerEvents()
		{
			Preconditions.checkState((!monitor.isOccupiedByCurrentThread()) ? true : false, (object)"It is incorrect to execute listeners with the monitor held.");
			listeners.dispatch();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 114, 244, 76 })]
		internal virtual void enqueueFailedEvent(Service P_0)
		{
			listeners.enqueue(new _2(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 110, 114 })]
		internal virtual void enqueueHealthyEvent()
		{
			listeners.enqueue(access_0024400());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 106, 114 })]
		internal virtual void enqueueStoppedEvent()
		{
			listeners.enqueue(access_0024300());
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Duration result = Duration.ofMillis(((Long)P_0).longValue());
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
	private static ListenerCallQueue.Event HEALTHY_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenerCallQueue$Event<Lcom/google/common/util/concurrent/ServiceManager$Listener;>;")]
	private static ListenerCallQueue.Event STOPPED_EVENT;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ServiceManagerState state;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/Service;>;")]
	private ImmutableList services;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 211, 111 })]
	public virtual void awaitHealthy(long timeout, TimeUnit unit)
	{
		state.awaitHealthy(timeout, unit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 161, 5, 111 })]
	public virtual void awaitStopped(long timeout, TimeUnit unit)
	{
		state.awaitStopped(timeout, unit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<Lcom/google/common/util/concurrent/Service;Ljava/lang/Long;>;")]
	[LineNumberTable(414)]
	public virtual ImmutableMap startupTimes()
	{
		ImmutableMap result = state.startupTimes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<Lcom/google/common/util/concurrent/Service$State;Lcom/google/common/util/concurrent/Service;>;")]
	[LineNumberTable(403)]
	public virtual ImmutableSetMultimap servicesByState()
	{
		ImmutableSetMultimap result = state.servicesByState();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/Service;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 90, 104, 103, 168, 218, 140, 108, 103, 108,
		124, 180, 122, 162, 109
	})]
	public ServiceManager(Iterable services)
	{
		ImmutableList immutableList = ImmutableList.copyOf(services);
		if (immutableList.isEmpty())
		{
			logger.log(Level.WARNING, "ServiceManager configured with no services.  Is your application configured properly?", new EmptyServiceManagerWarning(null));
			immutableList = ImmutableList.of(new NoOpService(null));
		}
		state = new ServiceManagerState(immutableList);
		this.services = immutableList;
		java.lang.@ref.WeakReference weakReference = new java.lang.@ref.WeakReference(state);
		UnmodifiableIterator unmodifiableIterator = immutableList.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Service service = (Service)((Iterator)unmodifiableIterator).next();
			service.addListener(new ServiceListener(service, weakReference), MoreExecutors.directExecutor());
			Preconditions.checkArgument(service.state() == Service.State.___003C_003ENEW, "Can only manage NEW services, %s", service);
		}
		state.markReady();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 140, 111 })]
	public virtual void addListener(Listener listener, Executor executor)
	{
		state.addListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 153, 127, 1, 120, 98, 159, 4, 108, 249,
		71, 226, 58, 225, 69, 159, 43, 101
	})]
	public virtual ServiceManager startAsync()
	{
		UnmodifiableIterator unmodifiableIterator = services.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Service service = (Service)((Iterator)unmodifiableIterator).next();
			Preconditions.checkState(service.state() == Service.State.___003C_003ENEW, "Not all services are NEW, cannot start %s", this);
		}
		unmodifiableIterator = services.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Service service = (Service)((Iterator)unmodifiableIterator).next();
			IllegalStateException ex;
			try
			{
				state.tryStartTiming(service);
				service.startAsync();
			}
			catch (IllegalStateException x)
			{
				ex = ByteCodeHelper.MapException<IllegalStateException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_007f;
			}
			continue;
			IL_007f:
			IllegalStateException thrown = ex;
			Logger obj = logger;
			Level wARNING = Level.WARNING;
			string text = java.lang.String.valueOf(service);
			int num = 24 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			obj.log(wARNING, new StringBuilder(num).append("Unable to start Service ").append(text).toString(), thrown);
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 180, 109 })]
	public virtual void awaitHealthy()
	{
		state.awaitHealthy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 195, 115 })]
	public virtual void awaitHealthy(Duration timeout)
	{
		awaitHealthy(Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 222, 127, 1, 103, 98 })]
	public virtual ServiceManager stopAsync()
	{
		UnmodifiableIterator unmodifiableIterator = services.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Service service = (Service)((Iterator)unmodifiableIterator).next();
			service.stopAsync();
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 234, 109 })]
	public virtual void awaitStopped()
	{
		state.awaitStopped();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 247, 115 })]
	public virtual void awaitStopped(Duration timeout)
	{
		awaitStopped(Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 15, 127, 1, 104, 130, 98 })]
	public virtual bool isHealthy()
	{
		UnmodifiableIterator unmodifiableIterator = services.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Service service = (Service)((Iterator)unmodifiableIterator).next();
			if (!service.isRunning())
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<Lcom/google/common/util/concurrent/Service;Ljava/time/Duration;>;")]
	[LineNumberTable(new byte[] { 161, 57, 97, 52 })]
	public virtual ImmutableMap startupDurations()
	{
		ImmutableMap result = ImmutableMap.copyOf(Maps.transformValues(startupTimes(), new ___003C_003EAnon0()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 63, 122, 116, 7 })]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(ClassLiteral<ServiceManager>.Value).add("services", Collections2.filter(services, Predicates.not(Predicates.instanceOf(ClassLiteral<NoOpService>.Value)))).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(123)]
	public virtual ImmutableMultimap _003Cbridge_003EservicesByState()
	{
		ImmutableSetMultimap result = servicesByState();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024200()
	{
		return logger;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ListenerCallQueue.Event access_0024300()
	{
		return STOPPED_EVENT;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ListenerCallQueue.Event access_0024400()
	{
		return HEALTHY_EVENT;
	}

	[LineNumberTable(new byte[] { 76, 121, 234, 76 })]
	static ServiceManager()
	{
		logger = Logger.getLogger(ClassLiteral<ServiceManager>.Value.getName(), ServiceManager.___003CGetCallerID_003E());
		HEALTHY_EVENT = new _1();
		STOPPED_EVENT = new _2();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	ImmutableMultimap ServiceManagerBridge.ServiceManagerBridge_003A_003AservicesByState()
	{
		return _003Cbridge_003EservicesByState();
	}
}
