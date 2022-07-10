using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal abstract class CommonPattern : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	internal CommonPattern()
	{
	}

	public abstract CommonMatcher matcher(CharSequence P_0);

	public abstract string pattern();

	public abstract int flags();

	public abstract override string toString();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	public static CommonPattern compile(string P_0)
	{
		CommonPattern result = Platform.compilePattern(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public static bool isPcreLike()
	{
		bool result = Platform.patternCompilerIsPcreLike();
		_ = null;
		return result;
	}
}
