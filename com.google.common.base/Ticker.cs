using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public abstract class Ticker : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _1 : Ticker
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(49)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(52)]
		public override long read()
		{
			long result = Platform.systemNanoTime();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			Ticker.___003Cclinit_003E();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Ticker SYSTEM_TICKER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	public static Ticker systemTicker()
	{
		return SYSTEM_TICKER;
	}

	public abstract long read();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	protected internal Ticker()
	{
	}

	[LineNumberTable(48)]
	static Ticker()
	{
		SYSTEM_TICKER = new _1();
	}
}
