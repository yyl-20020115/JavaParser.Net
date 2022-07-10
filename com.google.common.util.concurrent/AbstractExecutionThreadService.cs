using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;
using java.util.function;
using java.util.logging;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractExecutionThreadService : java.lang.Object, Service
{
	[SpecialName]
	[EnclosingMethod(null, null, null)]
	internal class _1 : AbstractService
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/lang/String;>;")]
		[EnclosingMethod(null, "doStart", "()V")]
		[Implements(new string[] { "com.google.common.base.Supplier" })]
		internal new class _1 : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AbstractExecutionThreadService._1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(53)]
			public virtual string get()
			{
				string result = this_00241.this_00240.serviceName();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(50)]
			internal _1(AbstractExecutionThreadService._1 P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(50)]
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
			internal AbstractExecutionThreadService._1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(57)]
			internal _2(AbstractExecutionThreadService._1 P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				11,
				112,
				171,
				141,
				byte.MaxValue,
				0,
				79,
				253,
				50,
				129,
				byte.MaxValue,
				6,
				73,
				253,
				56,
				194,
				byte.MaxValue,
				11,
				69,
				108,
				209,
				112,
				191,
				0,
				2,
				97,
				140
			})]
			public virtual void run()
			{
				System.Exception ex;
				System.Exception ex2;
				try
				{
					this_00241.this_00240.startUp();
					this_00241.notifyStarted();
					if (this_00241.isRunning())
					{
						try
						{
							this_00241.this_00240.run();
						}
						catch (System.Exception x)
						{
							ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
							goto IL_0059;
						}
					}
				}
				catch (System.Exception x2)
				{
					ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_005c;
				}
				System.Exception ex3;
				try
				{
					this_00241.this_00240.shutDown();
					this_00241.notifyStopped();
					return;
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
				}
				System.Exception ex4 = ex3;
				goto IL_0121;
				IL_005c:
				ex4 = ex2;
				goto IL_0121;
				IL_00d3:
				System.Exception ex5;
				System.Exception cause;
				try
				{
					this_00241.notifyFailed(cause);
					return;
				}
				catch (System.Exception x4)
				{
					ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
				}
				ex4 = ex5;
				goto IL_0121;
				IL_0121:
				cause = ex4;
				this_00241.notifyFailed(cause);
				return;
				IL_0059:
				System.Exception ex6 = ex;
				java.lang.Exception ex8;
				try
				{
					cause = ex6;
					try
					{
						this_00241.this_00240.shutDown();
					}
					catch (System.Exception x5)
					{
						java.lang.Exception ex7 = ByteCodeHelper.MapException<java.lang.Exception>(x5, ByteCodeHelper.MapFlags.None);
						if (ex7 == null)
						{
							throw;
						}
						ex8 = ex7;
						goto IL_0097;
					}
				}
				catch (System.Exception x6)
				{
					ex6 = ByteCodeHelper.MapException<System.Exception>(x6, ByteCodeHelper.MapFlags.None);
					goto IL_009d;
				}
				goto IL_00d3;
				IL_009d:
				ex4 = ex6;
				goto IL_0121;
				IL_0097:
				java.lang.Exception ex9 = ex8;
				System.Exception ex10;
				try
				{
					java.lang.Exception thrown = ex9;
					AbstractExecutionThreadService.access_0024000().log(Level.WARNING, "Error while attempting to shut down the service after failure.", thrown);
				}
				catch (System.Exception x7)
				{
					ex10 = ByteCodeHelper.MapException<System.Exception>(x7, ByteCodeHelper.MapFlags.None);
					goto IL_00cf;
				}
				goto IL_00d3;
				IL_00cf:
				ex4 = ex10;
				goto IL_0121;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractExecutionThreadService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(44)]
		internal _1(AbstractExecutionThreadService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 189, 134, 43, 230, 72, 238, 100 })]
		protected internal sealed override void doStart()
		{
			Executor executor = MoreExecutors.renamingDecorator(this_00240.executor(), new _1(this));
			executor.execute(new _2(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 46, 109 })]
		protected internal override void doStop()
		{
			this_00240.triggerShutdown();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(101)]
		public override string toString()
		{
			string result = this_00240.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			AbstractService.___003Cclinit_003E();
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "executor", "()Ljava.util.concurrent.Executor;")]
	internal class _2 : java.lang.Object, Executor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractExecutionThreadService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(165)]
		internal _2(AbstractExecutionThreadService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 118, 120 })]
		public virtual void execute(Runnable P_0)
		{
			MoreExecutors.newThread(this_00240.serviceName(), P_0).start();
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
	private Service @delegate;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(261)]
	protected internal virtual string serviceName()
	{
		string simpleName = java.lang.Object.instancehelper_getClass(this).getSimpleName();
		_ = null;
		return simpleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(165)]
	protected internal virtual Executor executor()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	protected internal virtual void triggerShutdown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(175)]
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
	[LineNumberTable(185)]
	public Service.State state()
	{
		Service.State result = @delegate.state();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 56, 232, 1, 236, 127 })]
	protected internal AbstractExecutionThreadService()
	{
		@delegate = new _1(this);
	}

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal virtual void startUp()
	{
	}

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal abstract void run();

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal virtual void shutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(180)]
	public bool isRunning()
	{
		bool result = @delegate.isRunning();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 77, 111 })]
	public void addListener(Service.Listener listener, Executor executor)
	{
		@delegate.addListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(197)]
	public System.Exception failureCause()
	{
		System.Exception result = @delegate.failureCause();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 90, 108 })]
	public Service startAsync()
	{
		@delegate.startAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 98, 108 })]
	public Service stopAsync()
	{
		@delegate.stopAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 105, 109 })]
	public void awaitRunning()
	{
		@delegate.awaitRunning();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 111, 105 })]
	public void awaitRunning(Duration timeout)
	{
		Service._003Cdefault_003EawaitRunning(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 117, 111 })]
	public void awaitRunning(long timeout, TimeUnit unit)
	{
		@delegate.awaitRunning(timeout, unit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 123, 109 })]
	public void awaitTerminated()
	{
		@delegate.awaitTerminated();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 129, 105 })]
	public void awaitTerminated(Duration timeout)
	{
		Service._003Cdefault_003EawaitTerminated(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 135, 111 })]
	public void awaitTerminated(long timeout, TimeUnit unit)
	{
		@delegate.awaitTerminated(timeout, unit);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024000()
	{
		return logger;
	}

	[LineNumberTable(new byte[] { 159, 181, 101, 52 })]
	static AbstractExecutionThreadService()
	{
		logger = Logger.getLogger(ClassLiteral<AbstractExecutionThreadService>.Value.getName(), AbstractExecutionThreadService.___003CGetCallerID_003E());
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
