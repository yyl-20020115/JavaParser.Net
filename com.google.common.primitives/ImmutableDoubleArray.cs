using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.primitives;

[Serializable]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class ImmutableDoubleArray : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Double;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class AsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ImmutableDoubleArray parent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(467)]
		internal AsList(ImmutableDoubleArray P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 100, 104, 103 })]
		private AsList(ImmutableDoubleArray P_0)
		{
			parent = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(493)]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is java.lang.Double)) ? (-1) : parent.indexOf(((java.lang.Double)P_0).doubleValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(478)]
		public override int size()
		{
			int result = parent.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(483)]
		public new virtual java.lang.Double get(int P_0)
		{
			java.lang.Double result = java.lang.Double.valueOf(parent.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(488)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return indexOf(P_0) >= 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(498)]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is java.lang.Double)) ? (-1) : parent.lastIndexOf(((java.lang.Double)P_0).doubleValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Double;>;")]
		[LineNumberTable(503)]
		public override List subList(int P_0, int P_1)
		{
			List result = parent.subArray(P_0, P_1).asList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/lang/Double;>;")]
		[LineNumberTable(509)]
		public override Spliterator spliterator()
		{
			Spliterator.OfDouble result = access_0024500(parent);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 144, 104, 103, 180, 104, 130, 103, 110, 130,
			140, 119, 127, 14, 130, 98
		})]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is AsList)
			{
				AsList asList = (AsList)P_0;
				bool result = parent.equals(asList.parent);
				_ = null;
				return result;
			}
			if (!(P_0 is List))
			{
				return false;
			}
			List list = (List)P_0;
			if (size() != list.size())
			{
				return false;
			}
			int num = access_0024100(parent);
			Iterator iterator = list.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (obj is java.lang.Double)
				{
					double[] array = access_0024000(parent);
					int num2 = num;
					num++;
					if (access_0024600(array[num2], ((java.lang.Double)obj).doubleValue()))
					{
						continue;
					}
				}
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(539)]
		public override int hashCode()
		{
			int result = parent.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(544)]
		public override string toString()
		{
			string result = parent.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(467)]
		public override object get(int P_0)
		{
			java.lang.Double result = get(P_0);
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	public sealed class Builder : java.lang.Object
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : DoubleConsumer
		{
			private readonly Builder arg_00241;

			internal ___003C_003EAnon0(Builder P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(double P_0)
			{
				arg_00241.add(P_0);
				_ = null;
			}

			[SpecialName]
			public DoubleConsumer andThen(DoubleConsumer P_0)
			{
				return DoubleConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		private double[] array;

		private int count;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<Ljava/lang/Double;>;)Lcom/google/common/primitives/ImmutableDoubleArray$Builder;")]
		[LineNumberTable(new byte[] { 160, 135, 104, 143, 123, 109, 98 })]
		public virtual Builder addAll(Iterable values)
		{
			if (values is Collection)
			{
				Builder result = addAll((Collection)values);
				_ = null;
				return result;
			}
			Iterator iterator = values.iterator();
			while (iterator.hasNext())
			{
				java.lang.Double @double = (java.lang.Double)iterator.next();
				add(@double.doubleValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(328)]
		[com.google.errorprone.annotations.CheckReturnValue(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/CheckReturnValue;"
		})]
		public virtual ImmutableDoubleArray build()
		{
			ImmutableDoubleArray result;
			if (count == 0)
			{
				result = access_0024200();
			}
			else
			{
				___003Cclinit_003E();
				result = new ImmutableDoubleArray(array, 0, count, null);
			}
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 104, 8, 167, 108 })]
		internal Builder(int P_0)
		{
			count = 0;
			array = new double[P_0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 182, 105, 106, 158 })]
		private void ensureRoomFor(int P_0)
		{
			int num = count + P_0;
			if (num > (nint)array.LongLength)
			{
				array = Arrays.copyOf(array, expandedCapacity(array.Length, num));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Ljava/lang/Double;>;)Lcom/google/common/primitives/ImmutableDoubleArray$Builder;")]
		[LineNumberTable(new byte[] { 160, 149, 108, 123, 127, 2, 98 })]
		public virtual Builder addAll(Collection values)
		{
			ensureRoomFor(values.size());
			Iterator iterator = values.iterator();
			while (iterator.hasNext())
			{
				java.lang.Double @double = (java.lang.Double)iterator.next();
				double[] obj = array;
				int num = count;
				count = num + 1;
				obj[num] = @double.doubleValue();
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 113, 103, 111, 110 })]
		public virtual Builder add(double value)
		{
			ensureRoomFor(1);
			array[count] = value;
			count++;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 190, 100, 176, 104, 100, 139, 100, 134 })]
		private static int expandedCapacity(int P_0, int P_1)
		{
			if (P_1 < 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("cannot store more than MAX_VALUE elements");
			}
			int num = P_0 + (P_0 >> 1) + 1;
			if (num < P_1)
			{
				num = Integer.highestOneBit(P_1 - 1) << 1;
			}
			if (num < 0)
			{
				num = int.MaxValue;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 124, 104, 117, 111 })]
		public virtual Builder addAll(double[] values)
		{
			ensureRoomFor(values.Length);
			ByteCodeHelper.arraycopy_primitive_8(values, 0, array, count, values.Length);
			count = (int)(count + (nint)values.LongLength);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 161, 103, 103, 101, 140, 113 })]
		public virtual Builder addAll(DoubleStream stream)
		{
			Spliterator.OfDouble ofDouble = stream.spliterator();
			long exactSizeIfKnown = ofDouble.getExactSizeIfKnown();
			if (exactSizeIfKnown > 0)
			{
				ensureRoomFor(Ints.saturatedCast(exactSizeIfKnown));
			}
			ofDouble.forEachRemaining(new ___003C_003EAnon0(this));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 175, 108, 127, 4, 115 })]
		public virtual Builder addAll(ImmutableDoubleArray values)
		{
			ensureRoomFor(values.length());
			ByteCodeHelper.arraycopy_primitive_8(access_0024000(values), access_0024100(values), array, count, values.length());
			count += values.length();
			return this;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ImmutableDoubleArray EMPTY;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double[] array;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int start;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int end;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(574)]
	private static bool areEqual(double P_0, double P_1)
	{
		return java.lang.Double.doubleToLongBits(P_0) == java.lang.Double.doubleToLongBits(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(448)]
	private Spliterator.OfDouble spliterator()
	{
		Spliterator.OfDouble result = Spliterators.spliterator(array, start, end, 1040);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 238, 104, 103, 103, 103 })]
	private ImmutableDoubleArray(double[] P_0, int P_1, int P_2)
	{
		array = P_0;
		start = P_1;
		end = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 235, 108 })]
	private ImmutableDoubleArray(double[] P_0)
		: this(P_0, 0, P_0.Length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/lang/Double;>;)Lcom/google/common/primitives/ImmutableDoubleArray;")]
	[LineNumberTable(158)]
	public static ImmutableDoubleArray copyOf(Collection values)
	{
		ImmutableDoubleArray result = ((!values.isEmpty()) ? new ImmutableDoubleArray(Doubles.toArray(values)) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(206)]
	public static Builder builder()
	{
		Builder result = new Builder(10);
		_ = null;
		return result;
	}

	public virtual int length()
	{
		return end - start;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 15, 112, 113, 9, 230, 69 })]
	public virtual int indexOf(double target)
	{
		for (int i = start; i < end; i++)
		{
			if (areEqual(array[i], target))
			{
				return i - start;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 5, 109 })]
	public virtual double get(int index)
	{
		Preconditions.checkElementIndex(index, length());
		return array[start + index];
	}

	public virtual bool isEmpty()
	{
		return end == start;
	}

	[LineNumberTable(618)]
	private bool isPartialView()
	{
		return (start > 0 || end < (nint)array.LongLength) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(430)]
	public virtual double[] toArray()
	{
		double[] result = Arrays.copyOfRange(array, start, end);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(614)]
	public virtual ImmutableDoubleArray trimmed()
	{
		return (!isPartialView()) ? this : new ImmutableDoubleArray(toArray());
	}

	public static ImmutableDoubleArray of()
	{
		return EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(102)]
	public static ImmutableDoubleArray of(double e0)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[1] { e0 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(107)]
	public static ImmutableDoubleArray of(double e0, double e1)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[2] { e0, e1 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(112)]
	public static ImmutableDoubleArray of(double e0, double e1, double e2)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[3] { e0, e1, e2 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public static ImmutableDoubleArray of(double e0, double e1, double e2, double e3)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[4] { e0, e1, e2, e3 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(122)]
	public static ImmutableDoubleArray of(double e0, double e1, double e2, double e3, double e4)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[5] { e0, e1, e2, e3, e4 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public static ImmutableDoubleArray of(double e0, double e1, double e2, double e3, double e4, double e5)
	{
		ImmutableDoubleArray result = new ImmutableDoubleArray(new double[6] { e0, e1, e2, e3, e4, e5 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 91, 150, 106, 101, 107 })]
	public static ImmutableDoubleArray of(double first, params double[] rest)
	{
		Preconditions.checkArgument((nint)rest.LongLength <= 2147483646, (object)"the total number of elements must fit in an int");
		double[] array = new double[(nint)rest.LongLength + 1];
		array[0] = first;
		ByteCodeHelper.arraycopy_primitive_8(rest, 0, array, 1, rest.Length);
		ImmutableDoubleArray result = new ImmutableDoubleArray(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 101, 100, 103, 15 })]
	public static ImmutableDoubleArray copyOf(double[] values)
	{
		ImmutableDoubleArray result = ((values.Length != 0) ? new ImmutableDoubleArray(Arrays.copyOf(values, values.Length)) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Ljava/lang/Double;>;)Lcom/google/common/primitives/ImmutableDoubleArray;")]
	[LineNumberTable(new byte[] { 119, 104, 142 })]
	public static ImmutableDoubleArray copyOf(Iterable values)
	{
		if (values is Collection)
		{
			ImmutableDoubleArray result = copyOf((Collection)values);
			_ = null;
			return result;
		}
		ImmutableDoubleArray result2 = builder().addAll(values).build();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 64, 103 })]
	public static ImmutableDoubleArray copyOf(DoubleStream stream)
	{
		double[] array = stream.toArray();
		ImmutableDoubleArray result = ((array.Length != 0) ? new ImmutableDoubleArray(array) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 79, 114 })]
	public static Builder builder(int initialCapacity)
	{
		Preconditions.checkArgument(initialCapacity >= 0, "Invalid initialCapacity: %s", initialCapacity);
		Builder result = new Builder(initialCapacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 29, 114, 113, 9, 230, 69 })]
	public virtual int lastIndexOf(double target)
	{
		for (int i = end - 1; i >= start; i += -1)
		{
			if (areEqual(array[i], target))
			{
				return i - start;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(412)]
	public virtual bool contains(double target)
	{
		return indexOf(target) >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 47, 103, 112, 46, 166 })]
	public virtual void forEach(DoubleConsumer consumer)
	{
		Preconditions.checkNotNull(consumer);
		for (int i = start; i < end; i++)
		{
			consumer.accept(array[i]);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(425)]
	public virtual DoubleStream stream()
	{
		DoubleStream result = Arrays.stream(array, start, end);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 71, 109, 100, 103, 29 })]
	public virtual ImmutableDoubleArray subArray(int startIndex, int endIndex)
	{
		Preconditions.checkPositionIndexes(startIndex, endIndex, length());
		ImmutableDoubleArray result = ((startIndex != endIndex) ? new ImmutableDoubleArray(array, start + startIndex, start + endIndex) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/lang/Double;>;")]
	[LineNumberTable(464)]
	public virtual List asList()
	{
		AsList result = new AsList(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 184, 100, 130, 104, 130, 103, 110, 130, 107,
		117, 2, 230, 69
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object == this)
		{
			return true;
		}
		if (!(@object is ImmutableDoubleArray))
		{
			return false;
		}
		ImmutableDoubleArray immutableDoubleArray = (ImmutableDoubleArray)@object;
		if (length() != immutableDoubleArray.length())
		{
			return false;
		}
		for (int i = 0; i < length(); i++)
		{
			if (!areEqual(get(i), immutableDoubleArray.get(i)))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 210, 98, 112, 101, 16, 198 })]
	public override int hashCode()
	{
		int num = 1;
		for (int i = start; i < end; i++)
		{
			num *= 31;
			num += Doubles.hashCode(array[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 224, 104, 134, 110, 155, 114, 57, 166, 105 })]
	public override string toString()
	{
		if (isEmpty())
		{
			return "[]";
		}
		StringBuilder stringBuilder = new StringBuilder(length() * 5);
		stringBuilder.append('[').append(array[start]);
		for (int i = start + 1; i < end; i++)
		{
			stringBuilder.append(", ").append(array[i]);
		}
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(622)]
	internal virtual object writeReplace()
	{
		ImmutableDoubleArray result = trimmed();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(626)]
	internal virtual object readResolve()
	{
		return (!isEmpty()) ? this : EMPTY;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static double[] access_0024000(ImmutableDoubleArray P_0)
	{
		return P_0.array;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static int access_0024100(ImmutableDoubleArray P_0)
	{
		return P_0.start;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ImmutableDoubleArray access_0024200()
	{
		return EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal ImmutableDoubleArray(double[] P_0, int P_1, int P_2, _1 P_3)
		: this(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static Spliterator.OfDouble access_0024500(ImmutableDoubleArray P_0)
	{
		Spliterator.OfDouble result = P_0.spliterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static bool access_0024600(double P_0, double P_1)
	{
		bool result = areEqual(P_0, P_1);
		_ = null;
		return result;
	}

	[LineNumberTable(93)]
	static ImmutableDoubleArray()
	{
		EMPTY = new ImmutableDoubleArray(new double[0]);
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableDoubleArray P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableDoubleArray(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		return readResolve();
	}
}
