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
public sealed class ImmutableLongArray : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
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
	[Signature("Ljava/util/AbstractList<Ljava/lang/Long;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class AsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ImmutableLongArray parent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(464)]
		internal AsList(ImmutableLongArray P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 97, 104, 103 })]
		private AsList(ImmutableLongArray P_0)
		{
			parent = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(490)]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is Long)) ? (-1) : parent.indexOf(((Long)P_0).longValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(475)]
		public override int size()
		{
			int result = parent.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(480)]
		public new virtual Long get(int P_0)
		{
			Long result = Long.valueOf(parent.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(485)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return indexOf(P_0) >= 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(495)]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is Long)) ? (-1) : parent.lastIndexOf(((Long)P_0).longValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Long;>;")]
		[LineNumberTable(500)]
		public override List subList(int P_0, int P_1)
		{
			List result = parent.subArray(P_0, P_1).asList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/lang/Long;>;")]
		[LineNumberTable(506)]
		public override Spliterator spliterator()
		{
			Spliterator.OfLong result = access_0024500(parent);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 141, 104, 103, 180, 104, 130, 103, 110, 130,
			140, 119, 127, 9, 130, 98
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
				if (obj is Long)
				{
					long[] array = access_0024000(parent);
					int num2 = num;
					num++;
					if (array[num2] == ((Long)obj).longValue())
					{
						continue;
					}
				}
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(536)]
		public override int hashCode()
		{
			int result = parent.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(541)]
		public override string toString()
		{
			string result = parent.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(464)]
		public override object get(int P_0)
		{
			Long result = get(P_0);
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
		private sealed class ___003C_003EAnon0 : LongConsumer
		{
			private readonly Builder arg_00241;

			internal ___003C_003EAnon0(Builder P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(long P_0)
			{
				arg_00241.add(P_0);
				_ = null;
			}

			[SpecialName]
			public LongConsumer andThen(LongConsumer P_0)
			{
				return LongConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		private long[] array;

		private int count;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<Ljava/lang/Long;>;)Lcom/google/common/primitives/ImmutableLongArray$Builder;")]
		[LineNumberTable(new byte[] { 160, 134, 104, 143, 123, 109, 98 })]
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
				Long @long = (Long)iterator.next();
				add(@long.longValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(327)]
		[com.google.errorprone.annotations.CheckReturnValue(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/CheckReturnValue;"
		})]
		public virtual ImmutableLongArray build()
		{
			ImmutableLongArray result;
			if (count == 0)
			{
				result = access_0024200();
			}
			else
			{
				___003Cclinit_003E();
				result = new ImmutableLongArray(array, 0, count, null);
			}
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 103, 8, 167, 108 })]
		internal Builder(int P_0)
		{
			count = 0;
			array = new long[P_0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 181, 105, 106, 158 })]
		private void ensureRoomFor(int P_0)
		{
			int num = count + P_0;
			if (num > (nint)array.LongLength)
			{
				array = Arrays.copyOf(array, expandedCapacity(array.Length, num));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Ljava/lang/Long;>;)Lcom/google/common/primitives/ImmutableLongArray$Builder;")]
		[LineNumberTable(new byte[] { 160, 148, 108, 123, 127, 1, 98 })]
		public virtual Builder addAll(Collection values)
		{
			ensureRoomFor(values.size());
			Iterator iterator = values.iterator();
			while (iterator.hasNext())
			{
				Long @long = (Long)iterator.next();
				long[] obj = array;
				int num = count;
				count = num + 1;
				obj[num] = @long.longValue();
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 112, 103, 110, 110 })]
		public virtual Builder add(long value)
		{
			ensureRoomFor(1);
			array[count] = value;
			count++;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 189, 100, 176, 104, 100, 139, 100, 134 })]
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
		[LineNumberTable(new byte[] { 160, 123, 104, 117, 111 })]
		public virtual Builder addAll(long[] values)
		{
			ensureRoomFor(values.Length);
			ByteCodeHelper.arraycopy_primitive_8(values, 0, array, count, values.Length);
			count = (int)(count + (nint)values.LongLength);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 160, 103, 103, 101, 140, 113 })]
		public virtual Builder addAll(LongStream stream)
		{
			Spliterator.OfLong ofLong = stream.spliterator();
			long exactSizeIfKnown = ofLong.getExactSizeIfKnown();
			if (exactSizeIfKnown > 0)
			{
				ensureRoomFor(Ints.saturatedCast(exactSizeIfKnown));
			}
			ofLong.forEachRemaining(new ___003C_003EAnon0(this));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 174, 108, 127, 4, 115 })]
		public virtual Builder addAll(ImmutableLongArray values)
		{
			ensureRoomFor(values.length());
			ByteCodeHelper.arraycopy_primitive_8(access_0024000(values), access_0024100(values), array, count, values.length());
			count += values.length();
			return this;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ImmutableLongArray EMPTY;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long[] array;

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
	[LineNumberTable(445)]
	private Spliterator.OfLong spliterator()
	{
		Spliterator.OfLong result = Spliterators.spliterator(array, start, end, 1040);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 237, 104, 103, 103, 103 })]
	private ImmutableLongArray(long[] P_0, int P_1, int P_2)
	{
		array = P_0;
		start = P_1;
		end = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 234, 108 })]
	private ImmutableLongArray(long[] P_0)
		: this(P_0, 0, P_0.Length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/lang/Long;>;)Lcom/google/common/primitives/ImmutableLongArray;")]
	[LineNumberTable(157)]
	public static ImmutableLongArray copyOf(Collection values)
	{
		ImmutableLongArray result = ((!values.isEmpty()) ? new ImmutableLongArray(Longs.toArray(values)) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(205)]
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

	[LineNumberTable(new byte[] { 161, 13, 112, 107, 9, 230, 69 })]
	public virtual int indexOf(long target)
	{
		for (int i = start; i < end; i++)
		{
			if (array[i] == target)
			{
				return i - start;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 4, 109 })]
	public virtual long get(int index)
	{
		Preconditions.checkElementIndex(index, length());
		return array[start + index];
	}

	public virtual bool isEmpty()
	{
		return end == start;
	}

	[LineNumberTable(610)]
	private bool isPartialView()
	{
		return (start > 0 || end < (nint)array.LongLength) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(427)]
	public virtual long[] toArray()
	{
		long[] result = Arrays.copyOfRange(array, start, end);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(606)]
	public virtual ImmutableLongArray trimmed()
	{
		return (!isPartialView()) ? this : new ImmutableLongArray(toArray());
	}

	public static ImmutableLongArray of()
	{
		return EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(102)]
	public static ImmutableLongArray of(long e0)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[1] { e0 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(107)]
	public static ImmutableLongArray of(long e0, long e1)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[2] { e0, e1 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(112)]
	public static ImmutableLongArray of(long e0, long e1, long e2)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[3] { e0, e1, e2 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public static ImmutableLongArray of(long e0, long e1, long e2, long e3)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[4] { e0, e1, e2, e3 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(122)]
	public static ImmutableLongArray of(long e0, long e1, long e2, long e3, long e4)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[5] { e0, e1, e2, e3, e4 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(127)]
	public static ImmutableLongArray of(long e0, long e1, long e2, long e3, long e4, long e5)
	{
		ImmutableLongArray result = new ImmutableLongArray(new long[6] { e0, e1, e2, e3, e4, e5 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 90, 150, 106, 100, 107 })]
	public static ImmutableLongArray of(long first, params long[] rest)
	{
		Preconditions.checkArgument((nint)rest.LongLength <= 2147483646, (object)"the total number of elements must fit in an int");
		long[] array = new long[(nint)rest.LongLength + 1];
		array[0] = first;
		ByteCodeHelper.arraycopy_primitive_8(rest, 0, array, 1, rest.Length);
		ImmutableLongArray result = new ImmutableLongArray(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 100, 100, 103, 15 })]
	public static ImmutableLongArray copyOf(long[] values)
	{
		ImmutableLongArray result = ((values.Length != 0) ? new ImmutableLongArray(Arrays.copyOf(values, values.Length)) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Ljava/lang/Long;>;)Lcom/google/common/primitives/ImmutableLongArray;")]
	[LineNumberTable(new byte[] { 118, 104, 142 })]
	public static ImmutableLongArray copyOf(Iterable values)
	{
		if (values is Collection)
		{
			ImmutableLongArray result = copyOf((Collection)values);
			_ = null;
			return result;
		}
		ImmutableLongArray result2 = builder().addAll(values).build();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 127, 103 })]
	public static ImmutableLongArray copyOf(LongStream stream)
	{
		long[] array = stream.toArray();
		ImmutableLongArray result = ((array.Length != 0) ? new ImmutableLongArray(array) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 78, 114 })]
	public static Builder builder(int initialCapacity)
	{
		Preconditions.checkArgument(initialCapacity >= 0, "Invalid initialCapacity: %s", initialCapacity);
		Builder result = new Builder(initialCapacity);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 161, 26, 114, 107, 9, 230, 69 })]
	public virtual int lastIndexOf(long target)
	{
		for (int i = end - 1; i >= start; i += -1)
		{
			if (array[i] == target)
			{
				return i - start;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(409)]
	public virtual bool contains(long target)
	{
		return indexOf(target) >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 44, 103, 112, 46, 166 })]
	public virtual void forEach(LongConsumer consumer)
	{
		Preconditions.checkNotNull(consumer);
		for (int i = start; i < end; i++)
		{
			consumer.accept(array[i]);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(422)]
	public virtual LongStream stream()
	{
		LongStream result = Arrays.stream(array, start, end);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 68, 109, 100, 103, 29 })]
	public virtual ImmutableLongArray subArray(int startIndex, int endIndex)
	{
		Preconditions.checkPositionIndexes(startIndex, endIndex, length());
		ImmutableLongArray result = ((startIndex != endIndex) ? new ImmutableLongArray(array, start + startIndex, start + endIndex) : EMPTY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/lang/Long;>;")]
	[LineNumberTable(461)]
	public virtual List asList()
	{
		AsList result = new AsList(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 181, 100, 130, 104, 130, 103, 110, 130, 107,
		112, 2, 230, 69
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
		if (!(@object is ImmutableLongArray))
		{
			return false;
		}
		ImmutableLongArray immutableLongArray = (ImmutableLongArray)@object;
		if (length() != immutableLongArray.length())
		{
			return false;
		}
		for (int i = 0; i < length(); i++)
		{
			if (get(i) != immutableLongArray.get(i))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 202, 98, 112, 101, 16, 198 })]
	public override int hashCode()
	{
		int num = 1;
		for (int i = start; i < end; i++)
		{
			num *= 31;
			num += Longs.hashCode(array[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 216, 104, 134, 110, 155, 114, 57, 166, 105 })]
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
	[LineNumberTable(614)]
	internal virtual object writeReplace()
	{
		ImmutableLongArray result = trimmed();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(618)]
	internal virtual object readResolve()
	{
		return (!isEmpty()) ? this : EMPTY;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static long[] access_0024000(ImmutableLongArray P_0)
	{
		return P_0.array;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static int access_0024100(ImmutableLongArray P_0)
	{
		return P_0.start;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ImmutableLongArray access_0024200()
	{
		return EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal ImmutableLongArray(long[] P_0, int P_1, int P_2, _1 P_3)
		: this(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static Spliterator.OfLong access_0024500(ImmutableLongArray P_0)
	{
		Spliterator.OfLong result = P_0.spliterator();
		_ = null;
		return result;
	}

	[LineNumberTable(93)]
	static ImmutableLongArray()
	{
		EMPTY = new ImmutableLongArray(new long[0]);
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableLongArray P_0)
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
	protected ImmutableLongArray(SerializationInfo P_0, StreamingContext P_1)
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
