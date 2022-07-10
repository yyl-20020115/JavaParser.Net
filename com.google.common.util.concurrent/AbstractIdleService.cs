using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;
using java.util.function;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractIdleService : java.lang.Object, Service
{
	[SpecialName]
	[EnclosingMethod(null, "executor", "()Ljava.util.concurrent.Executor;")]
	internal class _1 : java.lang.Object, Executor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractIdleService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(111)]
		internal _1(AbstractIdleService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 64, 127, 3 })]
		public virtual void execute(Runnable P_0)
		{
			MoreExecutors.newThread((string)access_0024200(this_00240).get(), P_0).start();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class DelegateService : AbstractService
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "doStart", "()V")]
		internal new class _1 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal DelegateService this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(58)]
			internal _1(DelegateService P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 12, 112, 189, 2, 97, 140 })]
			public virtual void run()
			{
				System.Exception ex;
				try
				{
					this_00241.this_00240.startUp();
					this_00241.notifyStarted();
					return;
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				}
				System.Exception cause = ex;
				this_00241.notifyFailed(cause);
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "doStop", "()V")]
		internal new class _2 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal DelegateService this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(75)]
			internal _2(DelegateService P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 29, 112, 189, 2, 97, 140 })]
			public virtual void run()
			{
				System.Exception ex;
				try
				{
					this_00241.this_00240.shutDown();
					this_00241.notifyStopped();
					return;
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				}
				System.Exception cause = ex;
				this_00241.notifyFailed(cause);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractIdleService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(53)]
		internal DelegateService(AbstractIdleService P_0, AbstractIdleService._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(53)]
		private DelegateService(AbstractIdleService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 6, 127, 2, 231, 76 })]
		protected internal sealed override void doStart()
		{
			MoreExecutors.renamingDecorator(this_00240.executor(), access_0024200(this_00240)).execute(new _1(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 23, 127, 2, 231, 76 })]
		protected internal sealed override void doStop()
		{
			MoreExecutors.renamingDecorator(this_00240.executor(), access_0024200(this_00240)).execute(new _2(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(90)]
		public override string toString()
		{
			string result = this_00240.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		static DelegateService()
		{
			AbstractService.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/lang/String;>;")]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal sealed class ThreadNameSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractIdleService this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(42)]
		internal ThreadNameSupplier(AbstractIdleService P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(42)]
		private ThreadNameSupplier(AbstractIdleService P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(45)]
		public virtual string get()
		{
			string text = this_00240.serviceName();
			string text2 = java.lang.String.valueOf(this_00240.state());
			int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(" ").append(text2)
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(41)]
		public virtual object get()
		{
			string result = this.get();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Supplier<Ljava/lang/String;>;")]
	private com.google.common.@base.Supplier threadNameSupplier;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Service @delegate;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal static com.google.common.@base.Supplier access_0024200(AbstractIdleService P_0)
	{
		return P_0.threadNameSupplier;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(205)]
	protected internal virtual string serviceName()
	{
		string simpleName = java.lang.Object.instancehelper_getClass(this).getSimpleName();
		_ = null;
		return simpleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(131)]
	public Service.State state()
	{
		Service.State result = @delegate.state();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 45, 232, 8, 237, 75, 237, 109 })]
	protected internal AbstractIdleService()
	{
		threadNameSupplier = new ThreadNameSupplier(this, null);
		@delegate = new DelegateService(this, null);
	}

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal abstract void startUp();

	[Throws(new string[] { "java.lang.Exception" })]
	protected internal abstract void shutDown();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(111)]
	protected internal virtual Executor executor()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(121)]
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
	[LineNumberTable(126)]
	public bool isRunning()
	{
		bool result = @delegate.isRunning();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 87, 111 })]
	public void addListener(Service.Listener listener, Executor executor)
	{
		@delegate.addListener(listener, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(143)]
	public System.Exception failureCause()
	{
		System.Exception result = @delegate.failureCause();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 100, 108 })]
	public Service startAsync()
	{
		@delegate.startAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 108 })]
	public Service stopAsync()
	{
		@delegate.stopAsync();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 115, 109 })]
	public void awaitRunning()
	{
		@delegate.awaitRunning();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 121, 105 })]
	public void awaitRunning(Duration timeout)
	{
		Service._003Cdefault_003EawaitRunning(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 127, 111 })]
	public void awaitRunning(long timeout, TimeUnit unit)
	{
		@delegate.awaitRunning(timeout, unit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 109 })]
	public void awaitTerminated()
	{
		@delegate.awaitTerminated();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 75, 105 })]
	public void awaitTerminated(Duration timeout)
	{
		Service._003Cdefault_003EawaitTerminated(this, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[] { 160, 81, 111 })]
	public void awaitTerminated(long timeout, TimeUnit unit)
	{
		@delegate.awaitTerminated(timeout, unit);
	}
}
