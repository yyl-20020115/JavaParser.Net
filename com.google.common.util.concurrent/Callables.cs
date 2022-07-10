using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)35,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Callables : Object
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : Callable
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon0(object P_0)
		{
			arg_00241 = P_0;
		}

		public object call()
		{
			object result = lambda_0024returning_00240(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : AsyncCallable
	{
		private readonly ListeningExecutorService arg_00241;

		private readonly Callable arg_00242;

		internal ___003C_003EAnon1(ListeningExecutorService P_0, Callable P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public ListenableFuture call()
		{
			ListenableFuture result = lambda_0024asAsyncCallable_00241(arg_00241, arg_00242);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : Callable
	{
		private readonly Supplier arg_00241;

		private readonly Callable arg_00242;

		internal ___003C_003EAnon2(Supplier P_0, Callable P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object call()
		{
			object result = lambda_0024threadRenaming_00242(arg_00241, arg_00242);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : Runnable
	{
		private readonly Supplier arg_00241;

		private readonly Runnable arg_00242;

		internal ___003C_003EAnon3(Supplier P_0, Runnable P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			lambda_0024threadRenaming_00243(arg_00241, arg_00242);
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 70, 103, 112, 97 })]
	private static bool trySetName(string P_0, Thread P_1)
	{
		//Discarded unreachable code: IL_000a
		try
		{
			P_1.setName(P_0);
			return true;
		}
		catch (SecurityException)
		{
		}
		_ = null;
		return false;
	}

	[Throws(new string[] { "java.lang.Exception" })]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static object lambda_0024returning_00240(object P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	private static ListenableFuture lambda_0024asAsyncCallable_00241(ListeningExecutorService P_0, Callable P_1)
	{
		ListenableFuture result = P_0.submit(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[]
	{
		23, 102, 103, 146, 139, 99, 136, 227, 61, 99,
		232, 61
	})]
	private static object lambda_0024threadRenaming_00242(Supplier P_0, Callable P_1)
	{
		Thread thread = Thread.currentThread();
		string name = thread.getName();
		int num = (trySetName((string)P_0.get(), thread) ? 1 : 0);
		object result;
		try
		{
			result = P_1.call();
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				trySetName(name, thread);
			}
			throw;
		}
		if (num != 0)
		{
			trySetName(name, thread);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[]
	{
		49, 102, 103, 146, 138, 99, 136, 227, 61, 99,
		104, 130
	})]
	private static void lambda_0024threadRenaming_00243(Supplier P_0, Runnable P_1)
	{
		Thread thread = Thread.currentThread();
		string name = thread.getName();
		int num = (trySetName((string)P_0.get(), thread) ? 1 : 0);
		try
		{
			P_1.run();
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				trySetName(name, thread);
			}
			throw;
		}
		if (num != 0)
		{
			trySetName(name, thread);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	private Callables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Ljava/util/concurrent/Callable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 35, 0, 0 })]
	[LineNumberTable(39)]
	public static Callable returning([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object value)
	{
		return new ___003C_003EAnon0(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;Lcom/google/common/util/concurrent/ListeningExecutorService;)Lcom/google/common/util/concurrent/AsyncCallable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 35, 0, 0 })]
	[LineNumberTable(new byte[] { 4, 103, 103 })]
	public static AsyncCallable asAsyncCallable(Callable callable, ListeningExecutorService listeningExecutorService)
	{
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(listeningExecutorService);
		return new ___003C_003EAnon1(listeningExecutorService, callable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;Lcom/google/common/base/Supplier<Ljava/lang/String;>;)Ljava/util/concurrent/Callable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 35, 0, 0 })]
	[LineNumberTable(new byte[] { 20, 103, 103 })]
	internal static Callable threadRenaming(Callable P_0, Supplier P_1)
	{
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_0);
		return new ___003C_003EAnon2(P_1, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;Lcom/google/common/base/Supplier<Ljava/lang/String;>;)Ljava/lang/Runnable;")]
	[LineNumberTable(new byte[] { 46, 103, 103 })]
	internal static Runnable threadRenaming(Runnable P_0, Supplier P_1)
	{
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_0);
		return new ___003C_003EAnon3(P_1, P_0);
	}
}
