using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.logging;

namespace com.google.common.util.concurrent;

[Signature("<L:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ListenerCallQueue : java.lang.Object
{
	[Signature("<L:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal interface Event
	{
		[Signature("(TL;)V")]
		virtual void call(object P_0);
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<L:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;")]
	internal sealed class PerListenerQueue : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TL;")]
		internal object listener;

		[Modifiers(Modifiers.Final)]
		internal Executor executor;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Lcom/google/common/util/concurrent/ListenerCallQueue$Event<TL;>;>;")]
		internal Queue waitQueue;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Ljava/lang/Object;>;")]
		internal Queue labelQueue;

		internal bool isThreadScheduled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TL;Ljava/util/concurrent/Executor;)V")]
		[LineNumberTable(new byte[] { 95, 232, 55, 97, 138, 97, 234, 70, 108, 113 })]
		internal PerListenerQueue(object P_0, Executor P_1)
		{
			waitQueue = Queues.newArrayDeque();
			labelQueue = Queues.newArrayDeque();
			listener = Preconditions.checkNotNull(P_0);
			executor = (Executor)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenerCallQueue$Event<TL;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 102, 109, 109 })]
		internal virtual void add(Event P_0, object P_1)
		{
			waitQueue.add(P_0);
			labelQueue.add(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			111,
			98,
			104,
			104,
			103,
			130,
			117,
			134,
			byte.MaxValue,
			4,
			76,
			229,
			53,
			129,
			105,
			103,
			144,
			223,
			91,
			167
		})]
		internal virtual void dispatch()
		{
			int num = 0;
			PerListenerQueue obj;
			System.Threading.Monitor.Enter(obj = this);
			try
			{
				if (!isThreadScheduled)
				{
					isThreadScheduled = true;
					num = 1;
				}
				System.Threading.Monitor.Exit(obj);
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
			if (num == 0)
			{
				return;
			}
			RuntimeException ex2;
			try
			{
				executor.execute(this);
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
			RuntimeException ex3 = ex2;
			lock (this)
			{
				isThreadScheduled = false;
			}
			Logger logger = access_0024000();
			Level sEVERE = Level.SEVERE;
			string text = java.lang.String.valueOf(listener);
			string text2 = java.lang.String.valueOf(executor);
			int num2 = 42 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num2 = num2;
			logger.log(sEVERE, new StringBuilder(num2).append("Exception while running callbacks for ").append(text).append(" on ")
				.append(text2)
				.toString(), ex3);
			throw Throwable.___003Cunmap_003E(ex3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160,
			74,
			226,
			69,
			104,
			107,
			113,
			108,
			99,
			103,
			98,
			159,
			0,
			252,
			78,
			163,
			105,
			103,
			144,
			byte.MaxValue,
			5,
			57,
			163,
			105,
			103,
			144,
			225,
			47,
			byte.MaxValue,
			2,
			71,
			164,
			163,
			105,
			103,
			144,
			238,
			48,
			130,
			byte.MaxValue,
			91,
			71,
			163,
			105,
			103,
			144,
			227,
			55,
			133,
			163,
			105,
			103,
			185
		})]
		public virtual void run()
		{
			int num = 1;
			while (true)
			{
				PerListenerQueue obj;
				Event @event;
				object obj2;
				System.Exception ex;
				System.Exception ex2;
				try
				{
					System.Threading.Monitor.Enter(obj = this);
					try
					{
						Preconditions.checkState(isThreadScheduled);
						@event = (Event)waitQueue.poll();
						obj2 = labelQueue.poll();
						if (@event == null)
						{
							isThreadScheduled = false;
							num = 0;
							System.Threading.Monitor.Exit(obj);
							break;
						}
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_009d;
					}
					try
					{
						System.Threading.Monitor.Exit(obj);
					}
					catch (System.Exception x2)
					{
						ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_00a6;
					}
					goto IL_00e4;
				}
				catch
				{
					//try-fault
					if (num != 0)
					{
						lock (this)
						{
							isThreadScheduled = false;
						}
					}
					throw;
				}
				IL_00e4:
				RuntimeException ex4;
				try
				{
					try
					{
						@event.call(listener);
					}
					catch (System.Exception x3)
					{
						RuntimeException ex3 = ByteCodeHelper.MapException<RuntimeException>(x3, ByteCodeHelper.MapFlags.None);
						if (ex3 == null)
						{
							throw;
						}
						ex4 = ex3;
						goto IL_012d;
					}
				}
				catch
				{
					//try-fault
					if (num != 0)
					{
						lock (this)
						{
							isThreadScheduled = false;
						}
					}
					throw;
				}
				continue;
				IL_012d:
				RuntimeException ex5 = ex4;
				try
				{
					RuntimeException thrown = ex5;
					Logger logger = access_0024000();
					Level sEVERE = Level.SEVERE;
					string text = java.lang.String.valueOf(listener);
					string text2 = java.lang.String.valueOf(obj2);
					int num2 = 37 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
					num2 = num2;
					logger.log(sEVERE, new StringBuilder(num2).append("Exception while executing callback: ").append(text).append(" ")
						.append(text2)
						.toString(), thrown);
				}
				catch
				{
					//try-fault
					if (num != 0)
					{
						lock (this)
						{
							isThreadScheduled = false;
						}
					}
					throw;
				}
				continue;
				IL_00a6:
				System.Exception ex6 = ex2;
				goto IL_00ac;
				IL_009d:
				ex6 = ex;
				goto IL_00ac;
				IL_00ac:
				System.Exception ex7 = ex6;
				try
				{
					System.Exception ex8 = ex7;
					System.Threading.Monitor.Exit(obj);
					throw Throwable.___003Cunmap_003E(ex8);
				}
				catch
				{
					//try-fault
					if (num != 0)
					{
						lock (this)
						{
							isThreadScheduled = false;
						}
					}
					throw;
				}
			}
			if (num != 0)
			{
				PerListenerQueue obj3;
				System.Threading.Monitor.Enter(obj3 = this);
				try
				{
					isThreadScheduled = false;
					System.Threading.Monitor.Exit(obj3);
					return;
				}
				catch
				{
					//try-fault
					System.Threading.Monitor.Exit(obj3);
					throw;
				}
			}
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
	[Signature("Ljava/util/List<Lcom/google/common/util/concurrent/ListenerCallQueue$PerListenerQueue<TL;>;>;")]
	private List listeners;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 232, 69, 102, 42 })]
	internal ListenerCallQueue()
	{
		listeners = Collections.synchronizedList(new ArrayList());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TL;Ljava/util/concurrent/Executor;)V")]
	[LineNumberTable(new byte[] { 26, 108, 108, 115 })]
	public virtual void addListener(object P_0, Executor P_1)
	{
		Preconditions.checkNotNull(P_0, (object)"listener");
		Preconditions.checkNotNull((object)P_1, (object)"executor");
		listeners.add(new PerListenerQueue(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 70, 112, 54, 166 })]
	public virtual void dispatch()
	{
		for (int i = 0; i < listeners.size(); i++)
		{
			((PerListenerQueue)listeners.get(i)).dispatch();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenerCallQueue$Event<TL;>;)V")]
	[LineNumberTable(new byte[] { 40, 106 })]
	public virtual void enqueue(Event P_0)
	{
		enqueueHelper(P_0, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenerCallQueue$Event<TL;>;Ljava/lang/Object;)V")]
	[LineNumberTable(new byte[] { 54, 108, 108, 109, 127, 1, 104, 98, 111 })]
	private void enqueueHelper(Event P_0, object P_1)
	{
		Preconditions.checkNotNull((object)P_0, (object)"event");
		Preconditions.checkNotNull(P_1, (object)"label");
		lock (listeners)
		{
			Iterator iterator = listeners.iterator();
			while (iterator.hasNext())
			{
				PerListenerQueue perListenerQueue = (PerListenerQueue)iterator.next();
				perListenerQueue.add(P_0, P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenerCallQueue$Event<TL;>;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 50, 106 })]
	public virtual void enqueue(Event P_0, string P_1)
	{
		enqueueHelper(P_0, P_1);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024000()
	{
		return logger;
	}

	[LineNumberTable(59)]
	static ListenerCallQueue()
	{
		logger = Logger.getLogger(ClassLiteral<ListenerCallQueue>.Value.getName(), ListenerCallQueue.___003CGetCallerID_003E());
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
