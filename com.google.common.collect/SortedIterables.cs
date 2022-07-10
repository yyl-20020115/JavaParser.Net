using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)41,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SortedIterables : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<*>;Ljava/lang/Iterable<*>;)Z")]
	[LineNumberTable(new byte[] { 159, 181, 103, 135, 104, 110, 104, 142, 130 })]
	public static bool hasSameComparator(Comparator P_0, Iterable P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Comparator obj;
		if (P_1 is SortedSet)
		{
			obj = comparator((SortedSet)P_1);
		}
		else
		{
			if (!(P_1 is SortedIterable))
			{
				return false;
			}
			obj = ((SortedIterable)P_1).comparator();
		}
		bool result = P_0.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/Comparator<-TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 41, 0, 0 })]
	[LineNumberTable(new byte[] { 6, 103, 104, 134 })]
	public static Comparator comparator(SortedSet P_0)
	{
		object obj = P_0.comparator();
		if ((Comparator)obj == null)
		{
			obj = Ordering.natural();
		}
		object obj2 = obj;
		return (obj2 == null) ? null : ((obj2 as Comparator) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	private SortedIterables()
	{
	}
}
