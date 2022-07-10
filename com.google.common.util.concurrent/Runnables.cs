using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Runnables : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _1 : Object, Runnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(31)]
		internal _1()
		{
		}

		public virtual void run()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Runnable EMPTY_RUNNABLE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public static Runnable doNothing()
	{
		return EMPTY_RUNNABLE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	private Runnables()
	{
	}

	[LineNumberTable(30)]
	static Runnables()
	{
		EMPTY_RUNNABLE = new _1();
	}
}
