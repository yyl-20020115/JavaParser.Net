using System;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Create an AbstractIdleService"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public interface Service
{
	public abstract class Listener : java.lang.Object
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(242)]
		public Listener()
		{
		}

		public virtual void starting()
		{
		}

		public virtual void running()
		{
		}

		public virtual void stopping(State from)
		{
		}

		public virtual void terminated(State from)
		{
		}

		public virtual void failed(State from, System.Exception failure)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/Service$State;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class State : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			NEW,
			STARTING,
			RUNNING,
			STOPPING,
			TERMINATED,
			FAILED
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003ENEW;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003ESTARTING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003ERUNNING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003ESTOPPING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003ETERMINATED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static State ___003C_003EFAILED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static State[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State NEW
		{
			[HideFromJava]
			get
			{
				return ___003C_003ENEW;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State STARTING
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTARTING;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State RUNNING
		{
			[HideFromJava]
			get
			{
				return ___003C_003ERUNNING;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State STOPPING
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTOPPING;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State TERMINATED
		{
			[HideFromJava]
			get
			{
				return ___003C_003ETERMINATED;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State FAILED
		{
			[HideFromJava]
			get
			{
				return ___003C_003EFAILED;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(208)]
		public static State[] values()
		{
			return (State[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(208)]
		private State(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(208)]
		private static State[] _0024values()
		{
			return new State[6] { ___003C_003ENEW, ___003C_003ESTARTING, ___003C_003ERUNNING, ___003C_003ESTOPPING, ___003C_003ETERMINATED, ___003C_003EFAILED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(208)]
		public static State valueOf(string name)
		{
			return (State)java.lang.Enum.valueOf(ClassLiteral<State>.Value, name);
		}

		[LineNumberTable(new byte[]
		{
			160, 96, 176, 176, 176, 240, 70, 240, 70, 240,
			41
		})]
		static State()
		{
			___003C_003ENEW = new State("NEW", 0);
			___003C_003ESTARTING = new State("STARTING", 1);
			___003C_003ERUNNING = new State("RUNNING", 2);
			___003C_003ESTOPPING = new State("STOPPING", 3);
			___003C_003ETERMINATED = new State("TERMINATED", 4);
			___003C_003EFAILED = new State("FAILED", 5);
			_0024VALUES = _0024values();
		}
	}

	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static void awaitRunning(Service P_0, Duration P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EawaitRunning(P_0, P_1);
		}

		public unsafe static void awaitTerminated(Service P_0, Duration P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EawaitTerminated(P_0, P_1);
		}
	}

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	virtual void awaitRunning(long l, TimeUnit tu);

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	virtual void awaitTerminated(long l, TimeUnit tu);

	virtual Service startAsync();

	virtual bool isRunning();

	virtual State state();

	virtual Service stopAsync();

	virtual void awaitRunning();

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[Modifiers(Modifiers.Public)]
	virtual void awaitRunning(Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 63, 115 })]
	static void _003Cdefault_003EawaitRunning(Service P_0, Duration P_1)
	{
		P_0.awaitRunning(Internal.toNanosSaturated(P_1), TimeUnit.NANOSECONDS);
	}

	virtual void awaitTerminated();

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[Modifiers(Modifiers.Public)]
	virtual void awaitTerminated(Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 99, 115 })]
	static void _003Cdefault_003EawaitTerminated(Service P_0, Duration P_1)
	{
		P_0.awaitTerminated(Internal.toNanosSaturated(P_1), TimeUnit.NANOSECONDS);
	}

	virtual System.Exception failureCause();

	virtual void addListener(Listener sl, Executor e);
}
