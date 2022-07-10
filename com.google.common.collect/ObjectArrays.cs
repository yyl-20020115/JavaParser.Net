using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)52,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class ObjectArrays : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<*>;[TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(new byte[] { 79, 103, 101, 137, 104, 101, 98, 132 })]
	internal static object[] toArrayImpl(Collection P_0, object[] P_1)
	{
		int num = P_0.size();
		if ((nint)P_1.LongLength < num)
		{
			P_1 = newArray(P_1, num);
		}
		fillArray(P_0, P_1);
		if ((nint)P_1.LongLength > num)
		{
			object[] array = P_1;
			array[num] = null;
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;I)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(60)]
	public static object[] newArray(object[] reference, int length)
	{
		object[] result = Platform.newArray(reference, length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(213)]
	internal static object[] checkElementsNotNull(params object[] P_0)
	{
		object[] result = checkElementsNotNull(P_0, P_0.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 0, 0, 0, 52, 0, 0,
		22, 0, 1, 0, 0, 0, 52, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 72, 107, 99, 135, 103, 106 })]
	internal static object[] copyAsObjectArray(object[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		if (P_2 == 0)
		{
			return new object[0];
		}
		object[] array = new object[P_2];
		ByteCodeHelper.arraycopy(P_0, P_1, array, 0, P_2);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/lang/Object;II[TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 52, 0, 0,
		22, 0, 1, 0, 0, 0, 52, 0, 0
	})]
	[LineNumberTable(new byte[] { 104, 107, 101, 107, 101, 98, 132, 106 })]
	internal static object[] toArrayImpl(object[] P_0, int P_1, int P_2, object[] P_3)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		if ((nint)P_3.LongLength < P_2)
		{
			P_3 = newArray(P_3, P_2);
		}
		else if ((nint)P_3.LongLength > P_2)
		{
			object[] array = P_3;
			array[P_2] = null;
		}
		ByteCodeHelper.arraycopy(P_0, P_1, P_3, 0, P_2);
		return P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)[Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(178)]
	internal static object[] toArrayImpl(Collection P_0)
	{
		object[] result = fillArray(P_0, new object[P_0.size()]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 104, 102, 42, 166 })]
	internal static object[] checkElementsNotNull(object[] P_0, int P_1)
	{
		for (int i = 0; i < P_1; i++)
		{
			checkElementNotNull(P_0[i], i);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;I)[TT;")]
	[LineNumberTable(50)]
	public static object[] newArray(Class type, int length)
	{
		return (object[])Array.newInstance(type, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;[Ljava/lang/Object;)[Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 0, 0, 0, 52, 0, 0,
		22, 1, 1, 0, 0, 0, 52, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 83, 98, 118, 104, 98 })]
	private static object[] fillArray(Iterable P_0, object[] P_1)
	{
		int num = 0;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			int num2 = num;
			num++;
			P_1[num2] = obj;
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 114, 99, 159, 12 })]
	internal static object checkElementNotNull(object P_0, int P_1)
	{
		if (P_0 == null)
		{
			int num = 20;
			num = num;
			string s = new StringBuilder(num).append("at index ").append(P_1).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	private ObjectArrays()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;[TT;Ljava/lang/Class<TT;>;)[TT;")]
	[LineNumberTable(new byte[] { 22, 108, 107, 108 })]
	public static object[] concat(object[] first, object[] second, Class type)
	{
		object[] array = newArray(type, (int)((nint)first.LongLength + (nint)second.LongLength));
		ByteCodeHelper.arraycopy(first, 0, array, 0, first.Length);
		ByteCodeHelper.arraycopy(second, 0, array, first.Length, second.Length);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;[TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(new byte[] { 37, 107, 100, 107 })]
	public static object[] concat([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, object[] array)
	{
		object[] array2 = newArray(array, (int)((nint)array.LongLength + 1));
		array2[0] = element;
		ByteCodeHelper.arraycopy(array, 0, array2, 1, array.Length);
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(new byte[] { 52, 107, 101 })]
	public static object[] concat(object[] array, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		object[] array2 = Arrays.copyOf(array, (int)((nint)array.LongLength + 1));
		array2[(nint)array.LongLength] = element;
		return array2;
	}

	[LineNumberTable(new byte[] { 160, 92, 100, 102, 100 })]
	internal static void swap(object[] P_0, int P_1, int P_2)
	{
		object obj = P_0[P_1];
		P_0[P_1] = P_0[P_2];
		P_0[P_2] = obj;
	}
}
