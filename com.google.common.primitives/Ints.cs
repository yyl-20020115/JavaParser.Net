using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class Ints : IntsMethodsForWeb
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Integer;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class IntArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal int[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 206, 104, 103, 103, 103 })]
		internal IntArrayAsList(int[] P_0, int P_1, int P_2)
		{
			array = P_0;
			start = P_1;
			end = P_2;
		}

		public override int size()
		{
			return end - start;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 9, 109, 144, 127, 0 })]
		public virtual Integer set(int P_0, Integer P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			int i = array[start + P_0];
			array[start + P_0] = ((Integer)Preconditions.checkNotNull(P_1)).intValue();
			Integer result = Integer.valueOf(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 224, 109 })]
		public new virtual Integer get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			Integer result = Integer.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(600)]
		public new virtual Spliterator.OfInt spliterator()
		{
			Spliterator.OfInt result = Spliterators.spliterator(array, start, end, 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 203, 108 })]
		internal IntArrayAsList(int[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(606)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is Integer && access_0024000(array, ((Integer)P_0).intValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 242, 104, 127, 4, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Integer)
			{
				int num = access_0024000(array, ((Integer)P_0).intValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 254, 104, 127, 4, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Integer)
			{
				int num = access_0024100(array, ((Integer)P_0).intValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Integer;>;")]
		[LineNumberTable(new byte[] { 162, 18, 103, 104, 100, 136 })]
		public override List subList(int P_0, int P_1)
		{
			int num = size();
			Preconditions.checkPositionIndexes(P_0, P_1, num);
			if (P_0 == P_1)
			{
				List result = Collections.emptyList();
				_ = null;
				return result;
			}
			IntArrayAsList result2 = new IntArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 28, 100, 130, 104, 103, 103, 105, 130, 102,
			127, 1, 2, 230, 69, 130
		})]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == this)
			{
				return true;
			}
			if (P_0 is IntArrayAsList)
			{
				IntArrayAsList intArrayAsList = (IntArrayAsList)P_0;
				int num = size();
				if (intArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != intArrayAsList.array[intArrayAsList.start + i])
					{
						return false;
					}
				}
				return true;
			}
			bool result = base.equals(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 49, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Ints.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 58, 110, 123, 114, 57, 166 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(size() * 5);
			stringBuilder.append('[').append(array[start]);
			for (int i = start + 1; i < end; i++)
			{
				stringBuilder.append(", ").append(array[i]);
			}
			string result = stringBuilder.append(']').toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(693)]
		internal virtual int[] toIntArray()
		{
			int[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(565)]
		public override object set(int P_0, object P_1)
		{
			Integer result = set(P_0, (Integer)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(565)]
		public override object get(int P_0)
		{
			Integer result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(565)]
		public override Spliterator spliterator()
		{
			Spliterator.OfInt result = spliterator();
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
		protected IntArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Integer;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class IntConverter : Converter, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static IntConverter INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(351)]
		protected internal virtual string doBackward(Integer P_0)
		{
			string result = P_0.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(346)]
		protected internal virtual Integer doForward(string P_0)
		{
			Integer result = Integer.decode(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(340)]
		private IntConverter()
		{
		}

		public override string toString()
		{
			return "Ints.stringConverter()";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(340)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((Integer)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(340)]
		protected internal override object doForward(object P_0)
		{
			Integer result = doForward((string)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(342)]
		static IntConverter()
		{
			INSTANCE = new IntConverter();
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
		protected IntConverter(SerializationInfo P_0, StreamingContext P_1)
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Ints$LexicographicalComparator;>;Ljava/util/Comparator<[I>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "java.util.Comparator" })]
	internal sealed class LexicographicalComparator : java.lang.Enum, Comparator
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LexicographicalComparator INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static LexicographicalComparator[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 75, 106, 102, 108, 99, 226, 61, 230, 70 })]
		public virtual int compare(int[] P_0, int[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = Ints.compare(P_0[i], P_1[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(440)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(440)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(440)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(440)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "Ints.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(440)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((int[])P_0, (int[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 71, 48 })]
		static LexicographicalComparator()
		{
			INSTANCE = new LexicographicalComparator("INSTANCE", 0);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	public const int BYTES = 4;

	public const int MAX_POWER_OF_TWO = 1073741824;

	public static int saturatedCast(long value)
	{
		if (value > 2147483647u)
		{
			return int.MaxValue;
		}
		if (value < int.MinValue)
		{
			return int.MinValue;
		}
		return (int)value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 160, 115 })]
	public static int constrainToRange(int value, int min, int max)
	{
		Preconditions.checkArgument(min <= max, "min (%s) must be less than or equal to max (%s)", min, max);
		int result = java.lang.Math.min(java.lang.Math.max(value, min), max);
		_ = null;
		return result;
	}

	public static int compare(int a, int b)
	{
		return (a < b) ? (-1) : ((a > b) ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 99, 112 })]
	public static int checkedCast(long value)
	{
		int num = (int)value;
		Preconditions.checkArgument(num == value, "Out of range: %s", value);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 114, 106, 100, 103, 102, 4, 230, 69 })]
	public static int min(params int[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			if (array[i] < num)
			{
				num = array[i];
			}
		}
		return num;
	}

	public static int fromBytes(byte b1, byte b2, byte b3, byte b4)
	{
		int num = (sbyte)b1;
		int num2 = (sbyte)b2;
		int num3 = (sbyte)b3;
		int num4 = (sbyte)b4;
		return (num << 24) | ((num2 & 0xFF) << 16) | ((num3 & 0xFF) << 8) | (num4 & 0xFF);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)[I")]
	[LineNumberTable(new byte[] { 161, 159, 104, 174, 103, 99, 103, 134, 21, 198 })]
	public static int[] toArray(Collection collection)
	{
		if (collection is IntArrayAsList)
		{
			int[] result = ((IntArrayAsList)collection).toIntArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		int[] array2 = new int[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = ((Number)Preconditions.checkNotNull(array[i])).intValue();
		}
		return array2;
	}

	[LineNumberTable(309)]
	public static byte[] toByteArray(int value)
	{
		return new byte[4]
		{
			(byte)(sbyte)(value >> 24),
			(byte)(sbyte)(value >> 16),
			(byte)(sbyte)(value >> 8),
			(byte)(sbyte)value
		};
	}

	public static int hashCode(int value)
	{
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	internal static int access_0024000(int[] P_0, int P_1, int P_2, int P_3)
	{
		int result = indexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	internal static int access_0024100(int[] P_0, int P_1, int P_2, int P_3)
	{
		int result = lastIndexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 95, 104, 102, 2, 230, 69 })]
	private static int lastIndexOf(int[] P_0, int P_1, int P_2, int P_3)
	{
		for (int i = P_3 - 1; i >= P_2; i += -1)
		{
			if (P_0[i] == P_1)
			{
				return i;
			}
		}
		return -1;
	}

	[LineNumberTable(new byte[] { 108, 102, 102, 2, 230, 69 })]
	private static int indexOf(int[] P_0, int P_1, int P_2, int P_3)
	{
		for (int i = P_2; i < P_3; i++)
		{
			if (P_0[i] == P_1)
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 108, 103, 105, 104, 106 })]
	public static void sortDescending(int[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		Arrays.sort(array, fromIndex, toIndex);
		reverse(array, fromIndex, toIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 136, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(int[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			int num2 = array[num];
			array[num] = array[i];
			array[i] = num2;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 119, 104, 114, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Integer tryParse(string @string, int radix)
	{
		Long @long = Longs.tryParse(@string, radix);
		if (@long == null || @long.longValue() != @long.intValue())
		{
			return null;
		}
		Integer result = Integer.valueOf(@long.intValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	private Ints()
	{
	}

	[LineNumberTable(new byte[] { 86, 111, 100, 2, 230, 69 })]
	public static bool contains(int[] array, int target)
	{
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = array[i];
			if (num2 == target)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(153)]
	public static int indexOf(int[] array, int target)
	{
		int result = indexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		127, 108, 108, 100, 194, 108, 103, 106, 2, 230,
		69, 226, 58, 230, 72
	})]
	public static int indexOf(int[] array, int[] target)
	{
		Preconditions.checkNotNull((object)array, (object)"array");
		Preconditions.checkNotNull((object)target, (object)"target");
		if (target.Length == 0)
		{
			return 0;
		}
		for (int i = 0; i < (nint)array.LongLength - (nint)target.LongLength + 1; i++)
		{
			int num = 0;
			while (true)
			{
				if (num < (nint)target.LongLength)
				{
					if (array[i + num] != target[num])
					{
						break;
					}
					num++;
					continue;
				}
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(204)]
	public static int lastIndexOf(int[] array, int target)
	{
		int result = lastIndexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 135, 106, 100, 103, 102, 4, 230, 69 })]
	public static int max(params int[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			if (array[i] > num)
			{
				num = array[i];
			}
		}
		return num;
	}

	[LineNumberTable(new byte[]
	{
		160, 172, 98, 112, 38, 166, 104, 98, 120, 110,
		6, 200
	})]
	public static int[] concat(params int[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			int[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		int[] array2 = new int[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			int[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_4(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 212, 117 })]
	public static int fromByteArray(byte[] bytes)
	{
		Preconditions.checkArgument((nint)bytes.LongLength >= 4, "array too small: %s < %s", bytes.Length, 4);
		int result = fromBytes(bytes[0], bytes[1], bytes[2], bytes[3]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Integer;>;")]
	[LineNumberTable(379)]
	public static Converter stringConverter()
	{
		return IntConverter.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 26, 114, 114 })]
	public static int[] ensureCapacity(int[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 40, 103, 100, 198, 106, 106, 103, 48, 166 })]
	public static string join(string separator, params int[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * 5));
		stringBuilder.append(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			stringBuilder.append(separator).append(array[i]);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<[I>;")]
	[LineNumberTable(437)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 97, 103, 107 })]
	public static void sortDescending(int[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 121, 103, 107 })]
	public static void reverse(int[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([I)Ljava/util/List<Ljava/lang/Integer;>;")]
	[LineNumberTable(new byte[] { 161, 189, 100, 136 })]
	public static List asList(params int[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		IntArrayAsList result2 = new IntArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(719)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Integer tryParse(string @string)
	{
		Integer result = tryParse(@string, 10);
		_ = null;
		return result;
	}
}
