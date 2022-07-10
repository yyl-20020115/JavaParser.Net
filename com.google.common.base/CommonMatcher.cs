using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal abstract class CommonMatcher : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	internal CommonMatcher()
	{
	}

	public abstract bool matches();

	public abstract bool find();

	public abstract bool find(int P_0);

	public abstract string replaceAll(string P_0);

	public abstract int end();

	public abstract int start();
}
