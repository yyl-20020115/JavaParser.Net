using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SequentialExecutor : java.lang.Object, Executor
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "execute", "(Ljava.lang.Runnable;)V")]
	internal class _1 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Runnable val_0024task;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		internal _1(SequentialExecutor P_0, Runnable P_1)
		{
			val_0024task = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 73, 109 })]
		public virtual void run()
		{
			val_0024task.run();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(128)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024task);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class QueueWorker : java.lang.Object, Runnable
	{
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Runnable task;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SequentialExecutor this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(174)]
		internal QueueWorker(SequentialExecutor P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(174)]
		private QueueWorker(SequentialExecutor P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 90, 98, 162, 178, 99, 146, 247, 96, 99,
			138, 240, 61, 99, 234, 31, 225, 69, 108, 113,
			240, 89, 99, 138, 234, 39, 123, 104, 113, 246,
			83, 99, 138, 233, 61, 99, 234, 44, 129, 244,
			81, 99, 138, 253, 61, 99, 138, 225, 48, 136,
			223, 11, 103, 228, 70, 99, 138, 249, 51, 98,
			159, 65, 103, 228, 70, 99, 138, 235, 54, 105,
			232, 70, 99, 138
		})]
		private void workOnQueue()
		{
			int num = 0;
			int num2 = 0;
			System.Exception ex12;
			while (true)
			{
				Deque obj;
				System.Exception ex;
				try
				{
					System.Threading.Monitor.Enter(obj = access_0024100(this_00240));
					try
					{
						if (num2 == 0)
						{
							if (access_0024200(this_00240) == WorkerRunningState.RUNNING)
							{
								System.Threading.Monitor.Exit(obj);
								goto IL_005f;
							}
							goto IL_006d;
						}
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_0059;
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
				goto IL_00b1;
				IL_0059:
				System.Exception ex2 = ex;
				goto IL_0149;
				IL_005f:
				if (num != 0)
				{
					java.lang.Thread.currentThread().interrupt();
				}
				return;
				IL_0149:
				System.Exception ex3 = ex2;
				try
				{
					System.Exception ex4 = ex3;
					System.Threading.Monitor.Exit(obj);
					throw Throwable.___003Cunmap_003E(ex4);
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
				IL_006d:
				System.Exception ex5;
				try
				{
					try
					{
						access_0024308(this_00240);
						access_0024202(this_00240, WorkerRunningState.RUNNING);
						num2 = 1;
					}
					catch (System.Exception x2)
					{
						ex5 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_00aa;
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
				goto IL_00b1;
				IL_00b1:
				System.Exception ex6;
				try
				{
					try
					{
						task = (Runnable)access_0024100(this_00240).poll();
						if (task == null)
						{
							access_0024202(this_00240, WorkerRunningState.IDLE);
							System.Threading.Monitor.Exit(obj);
							goto IL_0111;
						}
					}
					catch (System.Exception x3)
					{
						ex6 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
						goto IL_010d;
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
				System.Exception ex7;
				try
				{
					try
					{
						System.Threading.Monitor.Exit(obj);
					}
					catch (System.Exception x4)
					{
						ex7 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
						goto IL_0143;
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
				RuntimeException ex9;
				try
				{
					num |= (java.lang.Thread.interrupted() ? 1 : 0);
					try
					{
						try
						{
							task.run();
						}
						catch (System.Exception x5)
						{
							RuntimeException ex8 = ByteCodeHelper.MapException<RuntimeException>(x5, ByteCodeHelper.MapFlags.None);
							if (ex8 == null)
							{
								throw;
							}
							ex9 = ex8;
							goto end_IL_016b;
						}
					}
					catch (System.Exception x6)
					{
						ex3 = ByteCodeHelper.MapException<System.Exception>(x6, ByteCodeHelper.MapFlags.None);
						goto IL_01ba;
					}
					task = null;
					continue;
					end_IL_016b:;
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
				RuntimeException ex10 = ex9;
				System.Exception ex11;
				try
				{
					ex10 = ex10;
					try
					{
						RuntimeException thrown = ex10;
						Logger logger = access_0024400();
						Level sEVERE = Level.SEVERE;
						string text = java.lang.String.valueOf(task);
						int num3 = 35 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
						num3 = num3;
						logger.log(sEVERE, new StringBuilder(num3).append("Exception while executing runnable ").append(text).toString(), thrown);
					}
					catch (System.Exception x7)
					{
						ex11 = ByteCodeHelper.MapException<System.Exception>(x7, ByteCodeHelper.MapFlags.None);
						goto end_IL_01c8;
					}
					task = null;
					continue;
					end_IL_01c8:;
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
				ex12 = ex11;
				break;
				IL_0143:
				ex2 = ex7;
				goto IL_0149;
				IL_010d:
				ex2 = ex6;
				goto IL_0149;
				IL_0111:
				if (num != 0)
				{
					java.lang.Thread.currentThread().interrupt();
				}
				return;
				IL_00aa:
				ex2 = ex5;
				goto IL_0149;
				IL_01ba:
				ex12 = ex3;
				break;
			}
			System.Exception ex13 = ex12;
			try
			{
				System.Exception ex14 = ex13;
				task = null;
				throw Throwable.___003Cunmap_003E(ex14);
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 66, 253, 73, 226, 56, 97, 114, 113, 111,
			231, 69
		})]
		public virtual void run()
		{
			Error error2;
			try
			{
				workOnQueue();
				return;
			}
			catch (System.Exception x)
			{
				Error error = ByteCodeHelper.MapException<Error>(x, ByteCodeHelper.MapFlags.None);
				if (error == null)
				{
					throw;
				}
				error2 = error;
			}
			Error error3 = error2;
			lock (access_0024100(this_00240))
			{
				access_0024202(this_00240, WorkerRunningState.IDLE);
			}
			throw Throwable.___003Cunmap_003E(error3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 141, 103, 99, 159, 33 })]
		public override string toString()
		{
			Runnable runnable = task;
			string text;
			int num;
			if (runnable != null)
			{
				text = java.lang.String.valueOf(runnable);
				num = 34 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string result = new StringBuilder(num).append("SequentialExecutorWorker{running=").append(text).append("}")
					.toString();
				_ = null;
				return result;
			}
			text = java.lang.String.valueOf(access_0024200(this_00240));
			num = 32 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result2 = new StringBuilder(num).append("SequentialExecutorWorker{state=").append(text).append("}")
				.toString();
			_ = null;
			return result2;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/SequentialExecutor$WorkerRunningState;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class WorkerRunningState : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static WorkerRunningState IDLE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static WorkerRunningState QUEUING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static WorkerRunningState QUEUED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static WorkerRunningState RUNNING;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static WorkerRunningState[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(55)]
		private WorkerRunningState(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(55)]
		private static WorkerRunningState[] _0024values()
		{
			return new WorkerRunningState[4] { IDLE, QUEUING, QUEUED, RUNNING };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(55)]
		public static WorkerRunningState[] values()
		{
			return (WorkerRunningState[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(55)]
		public static WorkerRunningState valueOf(string P_0)
		{
			return (WorkerRunningState)java.lang.Enum.valueOf(ClassLiteral<WorkerRunningState>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 7, 144, 144, 112, 240, 57 })]
		static WorkerRunningState()
		{
			IDLE = new WorkerRunningState("IDLE", 0);
			QUEUING = new WorkerRunningState("QUEUING", 1);
			QUEUED = new WorkerRunningState("QUEUED", 2);
			RUNNING = new WorkerRunningState("RUNNING", 3);
			_0024VALUES = _0024values();
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Executor executor;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Deque<Ljava/lang/Runnable;>;")]
	private Deque queue;

	private WorkerRunningState workerRunningState;

	private long workerRunCount;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private QueueWorker worker;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 38, 232, 44, 203, 235, 74, 168, 205, 113 })]
	internal SequentialExecutor(Executor P_0)
	{
		queue = new ArrayDeque();
		workerRunningState = WorkerRunningState.IDLE;
		workerRunCount = 0L;
		worker = new QueueWorker(this, null);
		executor = (Executor)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		50,
		167,
		173,
		122,
		109,
		168,
		231,
		72,
		232,
		76,
		109,
		107,
		182,
		byte.MaxValue,
		28,
		77,
		229,
		52,
		98,
		110,
		159,
		2,
		173,
		109,
		136,
		119,
		225,
		78,
		114,
		100,
		129,
		110,
		118,
		139,
		112
	})]
	public virtual void execute(Runnable P_0)
	{
		Preconditions.checkNotNull(P_0);
		Deque obj;
		System.Threading.Monitor.Enter(obj = queue);
		long num;
		_1 ;
		try
		{
			if (workerRunningState == WorkerRunningState.RUNNING || workerRunningState == WorkerRunningState.QUEUED)
			{
				queue.add(P_0);
				System.Threading.Monitor.Exit(obj);
				return;
			}
			num = workerRunCount;
			 = new _1(this, P_0);
			queue.add();
			workerRunningState = WorkerRunningState.QUEUING;
			System.Threading.Monitor.Exit(obj);
		}
		catch
		{
			//try-fault
			System.Threading.Monitor.Exit(obj);
			throw;
		}
		RuntimeException ex2;
		Error error2;
		try
		{
			try
			{
				executor.execute(worker);
			}
			catch (System.Exception x)
			{
				RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_00b4;
			}
		}
		catch (System.Exception x2)
		{
			Error error = ByteCodeHelper.MapException<Error>(x2, ByteCodeHelper.MapFlags.None);
			if (error == null)
			{
				throw;
			}
			error2 = error;
			goto IL_00b7;
		}
		if (workerRunningState != WorkerRunningState.QUEUING)
		{
			return;
		}
		lock (queue)
		{
			if (workerRunCount == num && workerRunningState == WorkerRunningState.QUEUING)
			{
				workerRunningState = WorkerRunningState.QUEUED;
			}
			return;
		}
		IL_00c0:
		object obj2;
		System.Exception ex3 = (System.Exception)obj2;
		Deque obj3;
		System.Threading.Monitor.Enter(obj3 = queue);
		try
		{
			int num2 = (((workerRunningState == WorkerRunningState.IDLE || workerRunningState == WorkerRunningState.QUEUING) && queue.removeLastOccurrence()) ? 1 : 0);
			if (!(ex3 is RejectedExecutionException) || num2 != 0)
			{
				throw Throwable.___003Cunmap_003E(ex3);
			}
			System.Threading.Monitor.Exit(obj3);
			return;
		}
		catch
		{
			//try-fault
			System.Threading.Monitor.Exit(obj3);
			throw;
		}
		IL_00b7:
		obj2 = error2;
		goto IL_00c0;
		IL_00b4:
		obj2 = ex2;
		goto IL_00c0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(265)]
	public override string toString()
	{
		int i = java.lang.System.identityHashCode(this);
		string text = java.lang.String.valueOf(executor);
		int num = 32 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append("SequentialExecutor@").append(i).append("{")
			.append(text)
			.append("}")
			.toString();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static Deque access_0024100(SequentialExecutor P_0)
	{
		return P_0.queue;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static WorkerRunningState access_0024202(SequentialExecutor P_0, WorkerRunningState P_1)
	{
		P_0.workerRunningState = P_1;
		return P_1;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static WorkerRunningState access_0024200(SequentialExecutor P_0)
	{
		return P_0.workerRunningState;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static long access_0024308(SequentialExecutor P_0)
	{
		long num = P_0.workerRunCount;
		P_0.workerRunCount = num + 1;
		return num;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024400()
	{
		return log;
	}

	[LineNumberTable(53)]
	static SequentialExecutor()
	{
		log = Logger.getLogger(ClassLiteral<SequentialExecutor>.Value.getName(), SequentialExecutor.___003CGetCallerID_003E());
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
