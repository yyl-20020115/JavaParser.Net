using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.escape;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Platform : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/ThreadLocal<[C>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : ThreadLocal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(43)]
		protected internal new virtual char[] initialValue()
		{
			return new char[1024];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(40)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(40)]
		protected internal override object initialValue()
		{
			char[] result = initialValue();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			ThreadLocal.___003Cclinit_003E();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/ThreadLocal<[C>;")]
	private static ThreadLocal DEST_TL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	internal static char[] charBufferFromThreadLocal()
	{
		return (char[])DEST_TL.get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	private Platform()
	{
	}

	[LineNumberTable(39)]
	static Platform()
	{
		DEST_TL = new _1();
	}
}
