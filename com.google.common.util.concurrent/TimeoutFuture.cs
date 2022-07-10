using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture$TrustedFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 64, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)64,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class TimeoutFuture : FluentFuture.TrustedFuture
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 72, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)72,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class Fire : java.lang.Object, Runnable
	{
		[Signature("Lcom/google/common/util/concurrent/TimeoutFuture<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal TimeoutFuture timeoutFutureRef;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/TimeoutFuture<TV;>;)V")]
		[LineNumberTable(new byte[] { 37, 104, 103 })]
		internal Fire(TimeoutFuture P_0)
		{
			timeoutFutureRef = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			45, 103, 99, 129, 103, 99, 225, 79, 103, 104,
			173, 103, 104, 198, 102, 114, 103, 191, 45, 159,
			71, 110, 132, 104, 235, 60, 112, 136, 104, 33,
			104, 130
		})]
		public virtual void run()
		{
			TimeoutFuture timeoutFuture = timeoutFutureRef;
			if (timeoutFuture == null)
			{
				return;
			}
			ListenableFuture listenableFuture = access_0024000(timeoutFuture);
			if (listenableFuture == null)
			{
				return;
			}
			timeoutFutureRef = null;
			if (listenableFuture.isDone())
			{
				timeoutFuture.setFuture(listenableFuture);
				return;
			}
			string text;
			System.Exception ex;
			try
			{
				ScheduledFuture scheduledFuture = access_0024100(timeoutFuture);
				access_0024102(timeoutFuture, null);
				text = "Timed out";
				try
				{
					int num2;
					if (scheduledFuture != null)
					{
						long num = java.lang.Math.abs(scheduledFuture.getDelay(TimeUnit.MILLISECONDS));
						if (num > 10u)
						{
							string text2 = java.lang.String.valueOf(text);
							num2 = 66 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
							num2 = num2;
							text = new StringBuilder(num2).append(text2).append(" (timeout delayed by ").append(num)
								.append(" ms after scheduled time)")
								.toString();
						}
					}
					string text3 = java.lang.String.valueOf(text);
					string text4 = java.lang.String.valueOf(listenableFuture);
					num2 = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text4));
					num2 = num2;
					text = new StringBuilder(num2).append(text3).append(": ").append(text4)
						.toString();
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto end_IL_0032;
				}
				timeoutFuture.setException(new TimeoutFutureException(text, null));
				goto IL_015e;
				end_IL_0032:;
			}
			catch
			{
				//try-fault
				listenableFuture.cancel(mayInterruptIfRunning: true);
				throw;
			}
			System.Exception ex2 = ex;
			try
			{
				System.Exception ex3 = ex2;
				timeoutFuture.setException(new TimeoutFutureException(text, null));
				throw Throwable.___003Cunmap_003E(ex3);
			}
			catch
			{
				//try-fault
				listenableFuture.cancel(mayInterruptIfRunning: true);
				throw;
			}
			IL_015e:
			listenableFuture.cancel(mayInterruptIfRunning: true);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class TimeoutFutureException : java.util.concurrent.TimeoutException
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(144)]
		internal TimeoutFutureException(string P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 96, 105 })]
		private TimeoutFutureException(string P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 101, 108 })]
		public override System.Exception fillInStackTrace()
		{
			base.setStackTrace(new StackTraceElement[0]);
			return this;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected TimeoutFutureException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ListenableFuture delegateRef;

	[Signature("Ljava/util/concurrent/ScheduledFuture<*>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ScheduledFuture timer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 64, 0, 0 })]
	[LineNumberTable(new byte[] { 159, 187, 103, 103, 111, 108 })]
	internal static ListenableFuture create(ListenableFuture P_0, long P_1, TimeUnit P_2, ScheduledExecutorService P_3)
	{
		TimeoutFuture timeoutFuture = new TimeoutFuture(P_0);
		Fire fire = new Fire(timeoutFuture);
		timeoutFuture.timer = P_3.schedule(fire, P_1, P_2);
		P_0.addListener(fire, MoreExecutors.directExecutor());
		return timeoutFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
	[LineNumberTable(new byte[] { 29, 104, 113 })]
	private TimeoutFuture(ListenableFuture P_0)
	{
		delegateRef = (ListenableFuture)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		109, 103, 103, 102, 127, 32, 102, 141, 102, 191,
		43, 131
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal override string pendingToString()
	{
		ListenableFuture listenableFuture = delegateRef;
		ScheduledFuture scheduledFuture = timer;
		if (listenableFuture != null)
		{
			string text = java.lang.String.valueOf(listenableFuture);
			int num = 14 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string text2 = new StringBuilder(num).append("inputFuture=[").append(text).append("]")
				.toString();
			if (scheduledFuture != null)
			{
				long delay = scheduledFuture.getDelay(TimeUnit.MILLISECONDS);
				if (delay > 0)
				{
					string text3 = java.lang.String.valueOf(text2);
					num = 43 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
					num = num;
					text2 = new StringBuilder(num).append(text3).append(", remaining delay=[").append(delay)
						.append(" ms]")
						.toString();
				}
			}
			return text2;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 127, 140, 199, 99, 168, 103, 103 })]
	protected internal override void afterDone()
	{
		maybePropagateCancellationTo(delegateRef);
		timer?.cancel(mayInterruptIfRunning: false);
		delegateRef = null;
		timer = null;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(39)]
	internal static ListenableFuture access_0024000(TimeoutFuture P_0)
	{
		return P_0.delegateRef;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(39)]
	internal static ScheduledFuture access_0024100(TimeoutFuture P_0)
	{
		return P_0.timer;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(39)]
	internal static ScheduledFuture access_0024102(TimeoutFuture P_0, ScheduledFuture P_1)
	{
		P_0.timer = P_1;
		return P_1;
	}

	[HideFromJava]
	static TimeoutFuture()
	{
		TrustedFuture.___003Cclinit_003E();
	}
}
