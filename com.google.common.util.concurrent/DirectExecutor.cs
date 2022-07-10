using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/DirectExecutor;>;Ljava/util/concurrent/Executor;")]
[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.Executor" })]
internal sealed class DirectExecutor : java.lang.Enum, Executor
{
	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static DirectExecutor INSTANCE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static DirectExecutor[] _0024VALUES;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(26)]
	private DirectExecutor(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(24)]
	private static DirectExecutor[] _0024values()
	{
		return new DirectExecutor[1] { INSTANCE };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	public static DirectExecutor[] values()
	{
		return (DirectExecutor[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	public static DirectExecutor valueOf(string P_0)
	{
		return (DirectExecutor)java.lang.Enum.valueOf(ClassLiteral<DirectExecutor>.Value, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 104 })]
	public virtual void execute(Runnable P_0)
	{
		P_0.run();
	}

	public override string toString()
	{
		return "MoreExecutors.directExecutor()";
	}

	[LineNumberTable(new byte[] { 159, 169, 240, 61 })]
	static DirectExecutor()
	{
		INSTANCE = new DirectExecutor("INSTANCE", 0);
		_0024VALUES = _0024values();
	}
}
