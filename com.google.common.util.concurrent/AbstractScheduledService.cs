using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util;
using java.util.concurrent;
using java.util.concurrent.locks;
using java.util.function;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractScheduledService : java.lang.Object, Service
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "executor", "()Ljava.util.concurrent.ScheduledExecutorService;")]
	internal class _1 : Service.Listener
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ScheduledExecutorService val_0024executor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(386)]
		internal _1(AbstractScheduledService P_0, ScheduledExecutorService P_1)
		{
			val_0024executor = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 19, 109 })]
		public override void terminated(Service.State P_0)
		{
			val_0024executor.shutdown();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 24, 109 })]
		public override void failed(Service.State P_0, System.Exception P_1)
		{
			val_0024executor.shutdown();
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "executor", "()Ljava.util.concurrent.ScheduledExecutorService;")]
	internal class _1ThreadFactoryImpl : java.lang.Object, ThreadFactory
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractScheduledService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(372)]
		internal _1ThreadFactoryImpl(AbstractScheduledService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(375)]
		public virtual java.lang.Thread newThread(Runnable P_0)
		{
			java.lang.Thread result = MoreExecutors.newThread(this_00240.serviceName(), P_0);
			_ = null;
			return result;
		}
	}

	internal interface Cancellable
	{
		virtual void cancel(bool P_0);

		virtual bool isCancelled();
	}

	public abstract class CustomScheduler : Scheduler
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<Ljava/lang/Void;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 16, 0, 0, 1, 3, 0, 0, 91,
			0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)91,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class ReschedulableCallable : java.lang.Object, Callable
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private Runnable wrappedRunnable;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private ScheduledExecutorService executor;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private AbstractService service;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private ReentrantLock @lock;

			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			private SupplantableFuture cancellationDelegate;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal CustomScheduler this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				161, 226, 222, 226, 61, 97, 108, 235, 70, 130,
				139, 246, 77, 107, 39, 107, 230, 51, 226, 73,
				99, 143, 107, 35, 98, 130, 99, 140
			})]
			public virtual Cancellable reschedule()
			{
				Schedule nextSchedule;
				System.Exception ex;
				try
				{
					nextSchedule = this_00240.getNextSchedule();
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_001b;
				}
				System.Exception ex2 = null;
				@lock.@lock();
				object obj;
				System.Exception ex3;
				try
				{
					try
					{
						obj = initializeOrUpdateCancellationDelegate(nextSchedule);
					}
					catch (System.Exception x2)
					{
						ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_0069;
					}
				}
				catch
				{
					//try-fault
					@lock.unlock();
					throw;
				}
				@lock.unlock();
				goto IL_00a4;
				IL_001b:
				ex2 = ex;
				service.notifyFailed(ex2);
				return new FutureAsCancellable(Futures.immediateCancelledFuture());
				IL_00a4:
				if (ex2 != null)
				{
					service.notifyFailed(ex2);
				}
				object obj2 = obj;
				return (obj2 == null) ? null : ((obj2 as Cancellable) ?? throw new java.lang.IncompatibleClassChangeError());
				IL_0069:
				System.Exception ex4 = ex3;
				try
				{
					System.Exception ex5 = ex4;
					ex2 = ex5;
					obj = new FutureAsCancellable(Futures.immediateCancelledFuture());
				}
				finally
				{
					@lock.unlock();
				}
				goto IL_00a4;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 14, 104, 158, 114, 147 })]
			private Cancellable initializeOrUpdateCancellationDelegate(Schedule P_0)
			{
				if (cancellationDelegate == null)
				{
					SupplantableFuture result = new SupplantableFuture(@lock, submitToExecutor(P_0));
					cancellationDelegate = result;
					return result;
				}
				if (!SupplantableFuture.access_0024800(cancellationDelegate).isCancelled())
				{
					SupplantableFuture.access_0024802(cancellationDelegate, submitToExecutor(P_0));
				}
				return cancellationDelegate;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/util/concurrent/AbstractScheduledService$CustomScheduler$Schedule;)Ljava/util/concurrent/ScheduledFuture<Ljava/lang/Void;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 91, 0, 0 })]
			[LineNumberTable(650)]
			private ScheduledFuture submitToExecutor(Schedule P_0)
			{
				ScheduledFuture result = executor.schedule(this, Schedule.access_0024900(P_0), Schedule.access_00241000(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[LineNumberTable(new byte[] { 161, 212, 107, 103 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual java.lang.Void call()
			{
				wrappedRunnable.run();
				reschedule();
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 203, 239, 56, 235, 73, 104, 103, 103 })]
			internal ReschedulableCallable(CustomScheduler P_0, AbstractService P_1, ScheduledExecutorService P_2, Runnable P_3)
			{
				this_00240 = P_0;
				base._002Ector();
				@lock = new ReentrantLock();
				wrappedRunnable = P_3;
				executor = P_2;
				service = P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(525)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual object call()
			{
				java.lang.Void result = this.call();
				_ = null;
				return result;
			}
		}

		[InnerClass(null, Modifiers.Protected | Modifiers.Static | Modifiers.Final)]
		public sealed class Schedule : java.lang.Object
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private long delay;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private TimeUnit unit;

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(713)]
			internal static long access_0024900(Schedule P_0)
			{
				return P_0.delay;
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(713)]
			internal static TimeUnit access_00241000(Schedule P_0)
			{
				return P_0.unit;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 96, 104, 103, 113 })]
			public Schedule(long delay, TimeUnit unit)
			{
				this.delay = delay;
				this.unit = (TimeUnit)Preconditions.checkNotNull(unit);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 106, 115 })]
			public Schedule(Duration delay)
				: this(Internal.toNanosSaturated(delay), TimeUnit.NANOSECONDS)
			{
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[ConstantPool(new object[]
		{
			(byte)21,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class SupplantableFuture : java.lang.Object, Cancellable
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private ReentrantLock @lock;

			[Signature("Ljava/util/concurrent/Future<Ljava/lang/Void;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 21, 0, 0 })]
			private Future currentFuture;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/concurrent/locks/ReentrantLock;Ljava/util/concurrent/Future<Ljava/lang/Void;>;)V")]
			[RuntimeVisibleTypeAnnotations(new byte[]
			{
				0, 1, 22, 1, 1, 3, 0, 0, 21, 0,
				0
			})]
			[LineNumberTable(new byte[] { 162, 38, 104, 103, 103 })]
			internal SupplantableFuture(ReentrantLock P_0, Future P_1)
			{
				@lock = P_0;
				currentFuture = P_1;
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(658)]
			internal static Future access_0024800(SupplantableFuture P_0)
			{
				return P_0.currentFuture;
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(658)]
			internal static Future access_0024802(SupplantableFuture P_0, Future P_1)
			{
				P_0.currentFuture = P_1;
				return P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 158, 228, 130, 139, 145, 107, 35, 98, 98 })]
			public virtual void cancel(bool P_0)
			{
				@lock.@lock();
				try
				{
					currentFuture.cancel(P_0);
				}
				finally
				{
					@lock.unlock();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 66, 139, 144, 107, 35, 2 })]
			public virtual bool isCancelled()
			{
				@lock.@lock();
				try
				{
					return currentFuture.isCancelled();
				}
				finally
				{
					@lock.unlock();
				}
			}
		}

		[Throws(new string[] { "java.lang.Exception" })]
		protected internal abstract Schedule getNextSchedule();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(522)]
		public CustomScheduler()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(704)]
		internal sealed override Cancellable schedule(AbstractService P_0, ScheduledExecutorService P_1, Runnable P_2)
		{
			Cancellable result = new ReschedulableCallable(this, P_0, P_1, P_2).reschedule();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class FutureAsCancellable : java.lang.Object, Cancellable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Future<*>;")]
		private Future @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Future<*>;)V")]
		[LineNumberTable(new byte[] { 161, 129, 104, 103 })]
		internal FutureAsCancellable(Future P_0)
		{
			@delegate = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 16, 98, 109 })]
		public virtual void cancel(bool P_0)
		{
			@delegate.cancel(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(510)]
		public virtual bool isCancelled()
		{
			bool result = @delegate.isCancelled();
			_ = null;
			return result;
		}
	}

	public abstract class Scheduler : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "newFixedDelaySchedule", "(JJLjava.util.concurrent.TimeUnit;)Lcom.google.common.util.concurrent.AbstractScheduledService$Scheduler;")]
		internal class _1 : Scheduler
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal long val_0024initialDelay;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal long val_0024delay;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TimeUnit val_0024unit;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(149)]
			internal _1(long P_0, long P_1, TimeUnit P_2)
			{
				val_0024initialDelay = P_0;
				val_0024delay = P_1;
				val_0024unit = P_2;
				base._002Ector(null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 103, 116, 44 })]
			public override Cancellable schedule(AbstractService P_0, ScheduledExecutorService P_1, Runnable P_2)
			{
				FutureAsCancellable result = new FutureAsCancellable(P_1.scheduleWithFixedDelay(P_2, val_0024initialDelay, val_0024delay, val_0024unit));
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "newFixedRateSchedule", "(JJLjava.util.concurrent.TimeUnit;)Lcom.google.common.util.concurrent.AbstractScheduledService$Scheduler;")]
		internal class _2 : Scheduler
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal long val_0024initialDelay;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal long val_0024period;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TimeUnit val_0024unit;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(185)]
			internal _2(long P_0, long P_1, TimeUnit P_2)
			{
				val_0024initialDelay = P_0;
				val_0024period = P_1;
				val_0024unit = P_2;
				base._002Ector(null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 75, 116, 44 })]
			public override Cancellable schedule(AbstractService P_0, ScheduledExecutorService P_1, Runnable P_2)
			{
				FutureAsCancellable result = new FutureAsCancellable(P_1.scheduleAtFixedRate(P_2, val_0024initialDelay, val_0024period, val_0024unit));
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(199)]
		private Scheduler()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 97, 103, 112 })]
		public static Scheduler newFixedDelaySchedule(long initialDelay, long delay, TimeUnit unit)
		{
			Preconditions.checkNotNull(unit);
			Preconditions.checkArgument(delay > 0, "delay must be > 0, found %s", delay);
			_1 result = new _1(initialDelay, delay, unit);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 69, 103, 112 })]
		public static Scheduler newFixedRateSchedule(long initialDelay, long period, TimeUnit unit)
		{
			Preconditions.checkNotNull(unit);
			Preconditions.checkArgument(period > 0, "period must be > 0, found %s", period);
			_2 result = new _2(initialDelay, period, unit);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 81, 97, 48 })]
		public static Scheduler newFixedDelaySchedule(Duration initialDelay, Duration delay)
		{
			Scheduler result = newFixedDelaySchedule(Internal.toNanosSaturated(initialDelay), Internal.toNanosSaturated(delay), TimeUnit.NANOSECONDS);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 118, 97, 48 })]
		public static Scheduler newFixedRateSchedule(Duration initialDelay, Duration period)
		{
			Scheduler result = newFixedRateSchedule(Internal.toNanosSaturated(initialDelay), Internal.toNanosSaturated(period), TimeUnit.NANOSECONDS);
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Abstract)]
		internal virtual Cancellable schedule(AbstractService P_0, ScheduledExecutorService P_1, Runnable P_2)
		{
			throw new AbstractMethodError("com.google.common.util.concurrent.AbstractScheduledService$Scheduler.schedule(Lcom.google.common.util.concurrent.AbstractService;Ljava.util.concurrent.ScheduledExecutorService;Ljava.lang.Runnable;)Lcom.google.common.util.concurrent.AbstractScheduledService$Cancellable;");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(120)]
		internal Scheduler(AbstractScheduledService._1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class ServiceDelegate : AbstractService
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/lang/String;>;")]
		[EnclosingMethod(null, "doStart", "()V")]
		[Implements(new string[] { "com.google.common.base.Supplier" })]
		internal new class _1 : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceDelegate this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(262)]
			public virtual string get()
			{
				string text = this_00241.this_00240.serviceName();
				string text2 = java.lang.String.valueOf(this_00241.state());
				int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num = num;
				string result = new StringBuilder(num).append(text).append(" ").append(text2)
					.toString();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(259)]
			internal _1(ServiceDelegate P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(259)]
			public virtual object get()
			{
				string result = this.get();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "doStart", "()V")]
		internal new class _2 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceDelegate this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(266)]
			internal _2(ServiceDelegate P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160, 155, 144, 112, 127, 40, 248, 72, 112, 38,
				112, 228, 56, 97, 108, 141, 181, 112, 35, 98,
				98
			})]
			public virtual void run()
			{
				access_0024200(this_00241).@lock();
				System.Exception ex;
				try
				{
					try
					{
						this_00241.this_00240.startUp();
						access_0024302(this_00241, this_00241.this_00240.scheduler().schedule(access_0024500(this_00241.this_00240), access_0024600(this_00241), access_0024700(this_00241)));
						this_00241.notifyStarted();
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_0092;
					}
				}
				catch
				{
					//try-fault
					access_0024200(this_00241).unlock();
					throw;
				}
				access_0024200(this_00241).unlock();
				return;
				IL_0092:
				System.Exception ex2 = ex;
				try
				{
					System.Exception cause = ex2;
					this_00241.notifyFailed(cause);
					if (access_0024300(this_00241) != null)
					{
						access_0024300(this_00241).cancel(false);
					}
				}
				finally
				{
					access_0024200(this_00241).unlock();
				}
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "doStop", "()V")]
		internal new class _3 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceDelegate this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(294)]
			internal _3(ServiceDelegate P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160,
				184,
				144,
				byte.MaxValue,
				6,
				73,
				240,
				60,
				130,
				159,
				0,
				112,
				59,
				114,
				116,
				191,
				0,
				2,
				98,
				141
			})]
			public virtual void run()
			{
				System.Exception ex;
				System.Exception ex2;
				System.Exception ex3;
				try
				{
					access_0024200(this_00241).@lock();
					try
					{
						if (this_00241.state() != Service.State.___003C_003ESTOPPING)
						{
							goto IL_0035;
						}
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto end_IL_0000;
					}
					try
					{
						this_00241.this_00240.shutDown();
					}
					catch (System.Exception x2)
					{
						ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_0087;
					}
					access_0024200(this_00241).unlock();
					goto IL_00b7;
					IL_0035:
					access_0024200(this_00241).unlock();
					return;
					end_IL_0000:;
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_008c;
				}
				System.Exception ex4 = ex;
				goto IL_008f;
				IL_008c:
				System.Exception ex5 = ex3;
				goto IL_00d8;
				IL_00b7:
				System.Exception ex6;
				try
				{
					this_00241.notifyStopped();
					return;
				}
				catch (System.Exception x4)
				{
					ex6 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
				}
				ex5 = ex6;
				goto IL_00d8;
				IL_00d8:
				System.Exception cause = ex5;
				this_00241.notifyFailed(cause);
				return;
				IL_0087:
				ex4 = ex2;
				goto IL_008f;
				IL_008f:
				System.Exception ex7 = ex4;
				try
				{
					cause = ex7;
					access_0024200(this_00241).unlock();
					throw Throwable.___003Cunmap_003E(cause);
				}
				catch (System.Exception x5)
				{
					ex7 = ByteCodeHelper.MapException<System.Exception>(x5, ByteCodeHelper.MapFlags.None);
				}
				ex5 = ex7;
				goto IL_00d8;
			}
		}

		[InnerClass(null, (Modifiers)0)]
		internal class Task : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ServiceDelegate this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(220)]
			internal Task(ServiceDelegate P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160,
				109,
				240,
				70,
				byte.MaxValue,
				12,
				82,
				112,
				40,
				240,
				48,
				129,
				253,
				78,
				112,
				38,
				112,
				231,
				50,
				129,
				byte.MaxValue,
				6,
				70,
				228,
				69,
				112,
				235,
				53,
				98,
				250,
				73,
				112,
				227,
				59,
				140,
				159,
				0,
				112,
				35,
				98,
				98
			})]
			public virtual void run()
			{
				access_0024200(this_00241).@lock();
				System.Exception ex;
				try
				{
					try
					{
						if (((Cancellable)java.util.Objects.requireNonNull(access_0024300(this_00241))).isCancelled())
						{
							goto IL_0053;
						}
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_0050;
					}
				}
				catch
				{
					//try-fault
					access_0024200(this_00241).unlock();
					throw;
				}
				System.Exception ex2;
				try
				{
					try
					{
						this_00241.this_00240.runOneIteration();
					}
					catch (System.Exception x2)
					{
						ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_0094;
					}
				}
				catch
				{
					//try-fault
					access_0024200(this_00241).unlock();
					throw;
				}
				access_0024200(this_00241).unlock();
				return;
				IL_0050:
				System.Exception ex3 = ex;
				goto IL_00ac;
				IL_0053:
				access_0024200(this_00241).unlock();
				return;
				IL_0094:
				ex3 = ex2;
				goto IL_00ac;
				IL_00ac:
				System.Exception ex4 = ex3;
				System.Exception cause;
				java.lang.Exception ex6;
				try
				{
					cause = ex4;
					try
					{
						this_00241.this_00240.shutDown();
					}
					catch (System.Exception x3)
					{
						java.lang.Exception ex5 = ByteCodeHelper.MapException<java.lang.Exception>(x3, ByteCodeHelper.MapFlags.None);
						if (ex5 == null)
						{
							throw;
						}
						ex6 = ex5;
						goto IL_00e9;
					}
				}
				catch
				{
					//try-fault
					access_0024200(this_00241).unlock();
					throw;
				}
				goto IL_0122;
				IL_00e9:
				java.lang.Exception ex7 = ex6;
				try
				{
					java.lang.Exception thrown = ex7;
					access_0024400().log(Level.WARNING, "Error while attempting to shut down the service after failure.", thrown);
				}
				catch
				{
					//try-fault
					access_0024200(this_00241).unlock();
					throw;
				}
				goto IL_0122;
				IL_0122:
				try
				{
					this_00241.notifyFailed(cause);
					((Cancellable)java.util.Objects.requireNonNull(access_0024300(this_00241))).cancel(false);
				}
				finally
				{
					access_0024200(this_00241).unlock();
				}
			}
		}

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private volatile Cancellable runningTask;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private volatile ScheduledExecutorService executorService;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ReentrantLock @lock;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Runnable task;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractScheduledService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal ServiceDelegate(AbstractScheduledService P_0, AbstractScheduledService._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 92, 239, 75, 235, 99 })]
		private ServiceDelegate(AbstractScheduledService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			@lock = new ReentrantLock();
			task = new Task(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 142, 135, 43, 241, 72, 245, 84 })]
		protected internal sealed override void doStart()
		{
			executorService = MoreExecutors.renamingDecorator(this_00240.executor(), new _1(this));
			System.Threading.Thread.MemoryBarrier();
			executorService.execute(new _2(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 176, 110, 110, 110, 245, 88 })]
		protected internal sealed override void doStop()
		{
			java.util.Objects.requireNonNull(runningTask);
			java.util.Objects.requireNonNull(executorService);
			runningTask.cancel(false);
			executorService.execute(new _3(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(321)]
		public override string toString()
		{
			string result = this_00240.toString();
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal static ReentrantLock access_0024200(ServiceDelegate P_0)
		{
			return P_0.@lock;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal static Cancellable access_0024300(ServiceDelegate P_0)
		{
			return P_0.runningTask;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal static Cancellable access_0024302(ServiceDelegate P_0, Cancellable P_1)
		{
			P_0.runningTask = P_1;
			System.Threading.Thread.MemoryBarrier();
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal static ScheduledExecutorService access_0024600(ServiceDelegate P_0)
		{
			return P_0.executorService;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal static Runnable access_0024700(ServiceDelegate P_0)
		{
			return P_0.task;
		}

		[HideFromJava]
		static ServiceDelegate()
		{
			AbstractService.___003Cclinit_003E();
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private AbstractService @delegate;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 59, 111 })]
	public void addListener(Service.Listener listener, Executor executor)
	{
		@delegate.addListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(408)]
	protected internal virtual string serviceName()
	{
		string simpleName = java.lang.Object.instancehelper_getClass(this).getSimpleName();
		_ = null;
		return simpleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(423)]
	public Service.State state()
	{
		Service.State result = @delegate.state();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 212, 232, 159, 133, 237, 160, 123 })]
	protected internal AbstractScheduledService()
	{
		@delegate = new ServiceDelegate(this, null);
	}

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal abstract void runOneIteration();

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal virtual void startUp()
	{
	}

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal virtual void shutDown()
	{
	}

	protected internal abstract Scheduler scheduler();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 8, 102, 230, 70, 232, 76, 229, 52, 229,
		77
	})]
	protected internal virtual ScheduledExecutorService executor()
	{
		ScheduledExecutorService scheduledExecutorService = Executors.newSingleThreadScheduledExecutor(new _1ThreadFactoryImpl(this));
		addListener(new _1(this, scheduledExecutorService), MoreExecutors.directExecutor());
		return scheduledExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(413)]
	public override string toString()
	{
		string text = serviceName();
		string text2 = java.lang.String.valueOf(state());
		int num = 3 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append(text).append(" [").append(text2)
			.append("]")
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(418)]
	public bool isRunning()
	{
		bool result = @delegate.isRunning();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(435)]
	public System.Exception failureCause()
	{
		System.Exception result = @delegate.failureCause();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 72, 108 })]
	public Service startAsync()
	{
		@delegate.startAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 80, 108 })]
	public Service stopAsync()
	{
		@delegate.stopAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 87, 109 })]
	public void awaitRunning()
	{
		@delegate.awaitRunning();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 161, 93, 105 })]
	public void awaitRunning(Duration timeout)
	{
		Service._003Cdefault_003EawaitRunning(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 161, 99, 111 })]
	public void awaitRunning(long timeout, TimeUnit unit)
	{
		@delegate.awaitRunning(timeout, unit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 105, 109 })]
	public void awaitTerminated()
	{
		@delegate.awaitTerminated();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 161, 111, 105 })]
	public void awaitTerminated(Duration timeout)
	{
		Service._003Cdefault_003EawaitTerminated(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 161, 117, 111 })]
	public void awaitTerminated(long timeout, TimeUnit unit)
	{
		@delegate.awaitTerminated(timeout, unit);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024400()
	{
		return logger;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(105)]
	internal static AbstractService access_0024500(AbstractScheduledService P_0)
	{
		return P_0.@delegate;
	}

	[LineNumberTable(106)]
	static AbstractScheduledService()
	{
		logger = Logger.getLogger(ClassLiteral<AbstractScheduledService>.Value.getName(), AbstractScheduledService.___003CGetCallerID_003E());
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
