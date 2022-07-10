using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class ExecutionList : java.lang.Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class RunnableExecutorPair : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		internal Runnable runnable;

		[Modifiers(Modifiers.Final)]
		internal Executor executor;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal RunnableExecutorPair next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 111, 104, 103, 103, 103 })]
		internal RunnableExecutorPair(Runnable P_0, Executor P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] RunnableExecutorPair P_2)
		{
			runnable = P_0;
			executor = P_1;
			next = P_2;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger log;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private RunnableExecutorPair runnables;

	private bool executed;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		93,
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
	[LineNumberTable(60)]
	public ExecutionList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		23, 108, 236, 69, 104, 104, 115, 136, 246, 69,
		103
	})]
	public virtual void add(Runnable runnable, Executor executor)
	{
		Preconditions.checkNotNull((object)runnable, (object)"Runnable was null.");
		Preconditions.checkNotNull((object)executor, (object)"Executor was null.");
		ExecutionList obj;
		System.Threading.Monitor.Enter(obj = this);
		try
		{
			if (!executed)
			{
				runnables = new RunnableExecutorPair(runnable, executor, runnables);
				System.Threading.Monitor.Exit(obj);
				return;
			}
			System.Threading.Monitor.Exit(obj);
		}
		catch
		{
			//try-fault
			System.Threading.Monitor.Exit(obj);
			throw;
		}
		executeListener(runnable, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		57, 104, 104, 136, 103, 103, 103, 246, 74, 98,
		99, 98, 103, 103, 98, 98, 99, 113, 137
	})]
	public virtual void execute()
	{
		ExecutionList obj;
		System.Threading.Monitor.Enter(obj = this);
		RunnableExecutorPair next;
		try
		{
			if (executed)
			{
				System.Threading.Monitor.Exit(obj);
				return;
			}
			executed = true;
			next = runnables;
			runnables = null;
			System.Threading.Monitor.Exit(obj);
		}
		catch
		{
			//try-fault
			System.Threading.Monitor.Exit(obj);
			throw;
		}
		RunnableExecutorPair runnableExecutorPair = null;
		while (next != null)
		{
			RunnableExecutorPair runnableExecutorPair2 = next;
			next = next.next;
			runnableExecutorPair2.next = runnableExecutorPair;
			runnableExecutorPair = runnableExecutorPair2;
		}
		while (runnableExecutorPair != null)
		{
			executeListener(runnableExecutorPair.runnable, runnableExecutorPair.executor);
			runnableExecutorPair = runnableExecutorPair.next;
		}
	}

	[LineNumberTable(46)]
	static ExecutionList()
	{
		log = Logger.getLogger(ClassLiteral<ExecutionList>.Value.getName(), ExecutionList.___003CGetCallerID_003E());
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
