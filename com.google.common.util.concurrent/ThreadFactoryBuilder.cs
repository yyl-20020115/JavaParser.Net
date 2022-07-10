using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class ThreadFactoryBuilder : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "doBuild", "(Lcom.google.common.util.concurrent.ThreadFactoryBuilder;)Ljava.util.concurrent.ThreadFactory;")]
	internal class _1 : Object, ThreadFactory
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ThreadFactory val_0024backingThreadFactory;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024nameFormat;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AtomicLong val_0024count;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Boolean val_0024daemon;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Integer val_0024priority;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Thread.UncaughtExceptionHandler val_0024uncaughtExceptionHandler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(163)]
		internal _1(ThreadFactory P_0, string P_1, AtomicLong P_2, Boolean P_3, Integer P_4, Thread.UncaughtExceptionHandler P_5)
		{
			val_0024backingThreadFactory = P_0;
			val_0024nameFormat = P_1;
			val_0024count = P_2;
			val_0024daemon = P_3;
			val_0024priority = P_4;
			val_0024uncaughtExceptionHandler = P_5;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			116, 109, 136, 159, 21, 104, 145, 104, 145, 104,
			140
		})]
		public virtual Thread newThread(Runnable P_0)
		{
			Thread thread = val_0024backingThreadFactory.newThread(P_0);
			if (val_0024nameFormat != null)
			{
				thread.setName(access_0024000(val_0024nameFormat, new object[1] { Long.valueOf(((AtomicLong)java.util.Objects.requireNonNull(val_0024count)).getAndIncrement()) }));
			}
			if (val_0024daemon != null)
			{
				thread.setDaemon(val_0024daemon.booleanValue());
			}
			if (val_0024priority != null)
			{
				thread.setPriority(val_0024priority.intValue());
			}
			if (val_0024uncaughtExceptionHandler != null)
			{
				thread.setUncaughtExceptionHandler(val_0024uncaughtExceptionHandler);
			}
			return thread;
		}
	}

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private string nameFormat;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Boolean daemon;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Integer priority;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Thread.UncaughtExceptionHandler uncaughtExceptionHandler;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ThreadFactory backingThreadFactory;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 232, 57, 103, 103, 103, 103, 167 })]
	public ThreadFactoryBuilder()
	{
		nameFormat = null;
		daemon = null;
		priority = null;
		uncaughtExceptionHandler = null;
		backingThreadFactory = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 121, 98, 108 })]
	public virtual ThreadFactoryBuilder setDaemon(bool daemon)
	{
		this.daemon = Boolean.valueOf(daemon);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 23, 118, 103 })]
	public virtual ThreadFactoryBuilder setNameFormat(string nameFormat)
	{
		format(nameFormat, Integer.valueOf(0));
		this.nameFormat = nameFormat;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(148)]
	[com.google.errorprone.annotations.CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public virtual ThreadFactory build()
	{
		ThreadFactory result = doBuild(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 113 })]
	public virtual ThreadFactoryBuilder setThreadFactory(ThreadFactory backingThreadFactory)
	{
		this.backingThreadFactory = (ThreadFactory)Preconditions.checkNotNull(backingThreadFactory);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static string access_0024000(string P_0, object[] P_1)
	{
		string result = format(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(186)]
	private static string format(string P_0, params object[] P_1)
	{
		string result = String.format(Locale.ROOT, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 104, 103, 103, 103, 135, 104, 104, 103, 111 })]
	private static ThreadFactory doBuild(ThreadFactoryBuilder P_0)
	{
		string text = P_0.nameFormat;
		Boolean boolean = P_0.daemon;
		Integer integer = P_0.priority;
		Thread.UncaughtExceptionHandler uncaughtExceptionHandler = P_0.uncaughtExceptionHandler;
		ThreadFactory threadFactory = ((P_0.backingThreadFactory == null) ? Executors.defaultThreadFactory() : P_0.backingThreadFactory);
		AtomicLong atomicLong = ((text == null) ? null : new AtomicLong(0L));
		_1 result = new _1(threadFactory, text, atomicLong, boolean, integer, uncaughtExceptionHandler);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 243, 69, 245, 69, 108 })]
	public virtual ThreadFactoryBuilder setPriority(int priority)
	{
		Preconditions.checkArgument(priority >= 1, "Thread priority (%s) must be >= %s", priority, 1);
		Preconditions.checkArgument(priority <= 10, "Thread priority (%s) must be <= %s", priority, 10);
		this.priority = Integer.valueOf(priority);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 71, 113 })]
	public virtual ThreadFactoryBuilder setUncaughtExceptionHandler(Thread.UncaughtExceptionHandler uncaughtExceptionHandler)
	{
		this.uncaughtExceptionHandler = (Thread.UncaughtExceptionHandler)Preconditions.checkNotNull(uncaughtExceptionHandler);
		return this;
	}
}
