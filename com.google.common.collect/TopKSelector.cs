using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using java.math;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 52, 0, 0 })]
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
internal sealed class TopKSelector : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int k;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Comparator<-TT;>;")]
	private Comparator comparator;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 52, 0, 0 })]
	private object[] buffer;

	private int bufferSize;

	[Signature("TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object threshold;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(ILjava/util/Comparator<-TT;>;)Lcom/google/common/collect/TopKSelector<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(80)]
	public static TopKSelector least(int P_0, Comparator P_1)
	{
		TopKSelector result = new TopKSelector(P_1, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+TT;>;)V")]
	[LineNumberTable(new byte[] { 160, 148, 104, 142 })]
	public virtual void offerAll(Iterator P_0)
	{
		while (P_0.hasNext())
		{
			offer(P_0.next());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<TT;>;")]
	[LineNumberTable(new byte[] { 160, 163, 103, 115, 110, 121, 108, 181 })]
	public virtual List topK()
	{
		object[] a = buffer;
		Arrays.sort(a, 0, bufferSize, comparator);
		if (bufferSize > k)
		{
			Arrays.fill(buffer, k, buffer.Length, null);
			bufferSize = k;
			threshold = buffer[k - 1];
		}
		List result = Collections.unmodifiableList(Arrays.asList(Arrays.copyOf(buffer, bufferSize)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)V")]
	[LineNumberTable(new byte[]
	{
		87, 104, 97, 104, 105, 103, 108, 110, 155, 122,
		169, 154, 123, 112, 168
	})]
	public virtual void offer([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (k == 0)
		{
			return;
		}
		if (bufferSize == 0)
		{
			buffer[0] = P_0;
			threshold = P_0;
			bufferSize = 1;
		}
		else if (bufferSize < k)
		{
			object[] array = buffer;
			int num = bufferSize;
			TopKSelector topKSelector = this;
			int num2 = num;
			topKSelector.bufferSize = num + 1;
			array[num2] = P_0;
			if (comparator.compare(P_0, NullnessCasts.uncheckedCastNullableTToT(threshold)) > 0)
			{
				threshold = P_0;
			}
		}
		else if (comparator.compare(P_0, NullnessCasts.uncheckedCastNullableTToT(threshold)) < 0)
		{
			object[] array2 = buffer;
			int num = bufferSize;
			TopKSelector topKSelector = this;
			int num3 = num;
			topKSelector.bufferSize = num + 1;
			array2[num3] = P_0;
			if (bufferSize == 2 * k)
			{
				trim();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TopKSelector<TT;>;)Lcom/google/common/collect/TopKSelector<TT;>;")]
	[LineNumberTable(new byte[] { 160, 122, 107, 51, 166 })]
	internal virtual TopKSelector combine(TopKSelector P_0)
	{
		for (int i = 0; i < P_0.bufferSize; i++)
		{
			offer(NullnessCasts.uncheckedCastNullableTToT(P_0.buffer[i]));
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TT;>;I)V")]
	[LineNumberTable(new byte[] { 72, 104, 118, 103, 114, 118, 114, 103, 103 })]
	private TopKSelector(Comparator P_0, int P_1)
	{
		comparator = (Comparator)Preconditions.checkNotNull((object)P_0, (object)"comparator");
		k = P_1;
		Preconditions.checkArgument(P_1 >= 0, "k (%s) must be >= 0", P_1);
		Preconditions.checkArgument(P_1 <= 1073741823, "k (%s) must be <= Integer.MAX_VALUE / 2", P_1);
		buffer = new object[IntMath.checkedMultiply(P_1, 2)];
		bufferSize = 0;
		threshold = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(ILjava/util/Comparator<-TT;>;)Lcom/google/common/collect/TopKSelector<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(102)]
	public static TopKSelector greatest(int P_0, Comparator P_1)
	{
		TopKSelector result = new TopKSelector(Ordering.from(P_1).reverse(), P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		114, 98, 139, 194, 98, 113, 103, 137, 140, 106,
		103, 106, 107, 195, 100, 133, 136, 113, 130, 101,
		140, 115, 111, 111, 48, 168, 239, 60, 232, 71
	})]
	private void trim()
	{
		int num = 0;
		int num2 = 2 * k - 1;
		int num3 = 0;
		int num4 = 0;
		int num5 = IntMath.log2(num2 - num, RoundingMode.CEILING) * 3;
		while (num < num2)
		{
			int num6 = (int)((uint)(num + num2 + 1) >> 1);
			int num7 = partition(num, num2, num6);
			if (num7 > k)
			{
				num2 = num7 - 1;
			}
			else
			{
				if (num7 >= k)
				{
					break;
				}
				num = Math.max(num7, num + 1);
				num3 = num7;
			}
			num4++;
			if (num4 >= num5)
			{
				object[] a = buffer;
				Arrays.sort(a, num, num2 + 1, comparator);
				break;
			}
		}
		bufferSize = k;
		threshold = NullnessCasts.uncheckedCastNullableTToT(buffer[num3]);
		for (int num6 = num3 + 1; num6 < k; num6++)
		{
			if (comparator.compare(NullnessCasts.uncheckedCastNullableTToT(buffer[num6]), NullnessCasts.uncheckedCastNullableTToT(threshold)) > 0)
			{
				threshold = buffer[num6];
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 100, 110, 144, 98, 102, 124, 104, 228, 61,
		230, 70, 112, 105
	})]
	private int partition(int P_0, int P_1, int P_2)
	{
		object obj = NullnessCasts.uncheckedCastNullableTToT(buffer[P_2]);
		buffer[P_2] = buffer[P_1];
		int num = P_0;
		for (int i = P_0; i < P_1; i++)
		{
			if (comparator.compare(NullnessCasts.uncheckedCastNullableTToT(buffer[i]), obj) < 0)
			{
				swap(num, i);
				num++;
			}
		}
		buffer[P_1] = buffer[num];
		buffer[num] = obj;
		return num;
	}

	[LineNumberTable(new byte[] { 160, 116, 105, 112, 105 })]
	private void swap(int P_0, int P_1)
	{
		object obj = buffer[P_0];
		buffer[P_0] = buffer[P_1];
		buffer[P_1] = obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljava/lang/Comparable<-TT;>;>(I)Lcom/google/common/collect/TopKSelector<TT;>;")]
	[LineNumberTable(69)]
	public static TopKSelector least(int P_0)
	{
		TopKSelector result = least(P_0, Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljava/lang/Comparable<-TT;>;>(I)Lcom/google/common/collect/TopKSelector<TT;>;")]
	[LineNumberTable(91)]
	public static TopKSelector greatest(int P_0)
	{
		TopKSelector result = greatest(P_0, Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TT;>;)V")]
	[LineNumberTable(new byte[] { 160, 136, 110 })]
	public virtual void offerAll(Iterable P_0)
	{
		offerAll(P_0.iterator());
	}
}
