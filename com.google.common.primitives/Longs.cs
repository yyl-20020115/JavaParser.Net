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
public sealed class Longs : java.lang.Object
{
	internal sealed class AsciiDigits : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static byte[] asciiDigits;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(327)]
		private AsciiDigits()
		{
		}

		[LineNumberTable(345)]
		internal static int digit(char P_0)
		{
			return (P_0 >= '\u0080') ? (-1) : asciiDigits[(uint)P_0];
		}

		[LineNumberTable(new byte[]
		{
			160, 218, 107, 103, 103, 40, 166, 103, 107, 11,
			198, 102
		})]
		static AsciiDigits()
		{
			byte[] array = new byte[128];
			Arrays.fill(array, byte.MaxValue);
			for (int i = 0; i < 10; i++)
			{
				array[48 + i] = (byte)(sbyte)i;
			}
			for (int i = 0; i < 26; i++)
			{
				array[65 + i] = (byte)(sbyte)(10 + i);
				array[97 + i] = (byte)(sbyte)(10 + i);
			}
			asciiDigits = array;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Longs$LexicographicalComparator;>;Ljava/util/Comparator<[J>;")]
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
		[LineNumberTable(new byte[] { 161, 171, 106, 102, 108, 99, 226, 61, 230, 70 })]
		public virtual int compare(long[] P_0, long[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = Longs.compare(P_0[i], P_1[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(536)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(536)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(536)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(536)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "Longs.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(536)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((long[])P_0, (long[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 167, 48 })]
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Long;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class LongArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal long[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(789)]
		internal virtual long[] toLongArray()
		{
			long[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 43, 108 })]
		internal LongArrayAsList(long[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 46, 104, 103, 103, 103 })]
		internal LongArrayAsList(long[] P_0, int P_1, int P_2)
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
		[LineNumberTable(new byte[] { 162, 105, 109, 144, 127, 0 })]
		public virtual Long set(int P_0, Long P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			long l = array[start + P_0];
			array[start + P_0] = ((Long)Preconditions.checkNotNull(P_1)).longValue();
			Long result = Long.valueOf(l);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 64, 109 })]
		public new virtual Long get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			Long result = Long.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(696)]
		public new virtual Spliterator.OfLong spliterator()
		{
			Spliterator.OfLong result = Spliterators.spliterator(array, start, end, 0);
			_ = null;
			return result;
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(702)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is Long && access_0024000(array, ((Long)P_0).longValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 82, 104, 127, 4, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Long)
			{
				int num = access_0024000(array, ((Long)P_0).longValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 94, 104, 127, 4, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Long)
			{
				int num = access_0024100(array, ((Long)P_0).longValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[] { 162, 114, 103, 104, 100, 136 })]
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
			LongArrayAsList result2 = new LongArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 124, 100, 130, 104, 103, 103, 105, 130, 102,
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
			if (P_0 is LongArrayAsList)
			{
				LongArrayAsList longArrayAsList = (LongArrayAsList)P_0;
				int num = size();
				if (longArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != longArrayAsList.array[longArrayAsList.start + i])
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
		[LineNumberTable(new byte[] { 162, 145, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Longs.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 154, 111, 123, 114, 57, 166 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(size() * 10);
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
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(661)]
		public override object set(int P_0, object P_1)
		{
			Long result = set(P_0, (Long)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(661)]
		public override object get(int P_0)
		{
			Long result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(661)]
		public override Spliterator spliterator()
		{
			Spliterator.OfLong result = spliterator();
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
		protected LongArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Long;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class LongConverter : Converter, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static LongConverter INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(446)]
		protected internal virtual string doBackward(Long P_0)
		{
			string result = P_0.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(441)]
		protected internal virtual Long doForward(string P_0)
		{
			Long result = Long.decode(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(436)]
		private LongConverter()
		{
		}

		public override string toString()
		{
			return "Longs.stringConverter()";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(436)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((Long)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(436)]
		protected internal override object doForward(object P_0)
		{
			Long result = doForward((string)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(437)]
		static LongConverter()
		{
			INSTANCE = new LongConverter();
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
		protected LongConverter(SerializationInfo P_0, StreamingContext P_1)
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

	public const int BYTES = 8;

	public const long MAX_POWER_OF_TWO = 4611686018427387904L;

	public static int compare(long a, long b)
	{
		return (a < b) ? (-1) : ((a > b) ? 1 : 0);
	}

	public static long fromBytes(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8)
	{
		int num = (sbyte)b1;
		int num2 = (sbyte)b2;
		int num3 = (sbyte)b3;
		int num4 = (sbyte)b4;
		int num5 = (sbyte)b5;
		int num6 = (sbyte)b6;
		int num7 = (sbyte)b7;
		int num8 = (sbyte)b8;
		return ((num & 0xFFu) << 56) | ((num2 & 0xFFu) << 48) | ((num3 & 0xFFu) << 40) | ((num4 & 0xFFu) << 32) | ((num5 & 0xFFu) << 24) | ((num6 & 0xFFu) << 16) | ((num7 & 0xFFu) << 8) | (num8 & 0xFFu);
	}

	[LineNumberTable(new byte[] { 160, 165, 103, 102, 109, 5, 198 })]
	public static byte[] toByteArray(long value)
	{
		byte[] array = new byte[8];
		for (int i = 7; i >= 0; i += -1)
		{
			array[i] = (byte)(sbyte)(value & 0xFFu);
			value >>= 8;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)[J")]
	[LineNumberTable(new byte[]
	{
		161,
		byte.MaxValue,
		104,
		174,
		103,
		99,
		103,
		134,
		21,
		198
	})]
	public static long[] toArray(Collection collection)
	{
		if (collection is LongArrayAsList)
		{
			long[] result = ((LongArrayAsList)collection).toLongArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		long[] array2 = new long[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = ((Number)Preconditions.checkNotNull(array[i])).longValue();
		}
		return array2;
	}

	public static int hashCode(long value)
	{
		return (int)(value ^ (long)((ulong)value >> 32));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 25, 114, 130, 105, 191, 12, 108, 104, 105,
		130, 113, 104, 130, 133, 151, 105, 113, 110, 130,
		103, 112, 130, 172, 99, 106, 109, 130
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Long tryParse(string @string, int radix)
	{
		if (java.lang.String.instancehelper_isEmpty((string)Preconditions.checkNotNull(@string)))
		{
			return null;
		}
		if (radix < 2 || radix > 36)
		{
			int num = 65;
			num = num;
			string s = new StringBuilder(num).append("radix must be between MIN_RADIX and MAX_RADIX but was ").append(radix).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		int num2 = ((java.lang.String.instancehelper_charAt(@string, 0) == '-') ? 1 : 0);
		int num3 = ((num2 != 0) ? 1 : 0);
		if (num3 == java.lang.String.instancehelper_length(@string))
		{
			return null;
		}
		int index = num3;
		num3++;
		int num4 = AsciiDigits.digit(java.lang.String.instancehelper_charAt(@string, index));
		if (num4 < 0 || num4 >= radix)
		{
			return null;
		}
		long num5 = -num4;
		long num6 = radix;
		long num7 = ((num6 != -1) ? (long.MinValue / num6) : (-long.MinValue));
		while (num3 < java.lang.String.instancehelper_length(@string))
		{
			int index2 = num3;
			num3++;
			num4 = AsciiDigits.digit(java.lang.String.instancehelper_charAt(@string, index2));
			if (num4 < 0 || num4 >= radix || num5 < num7)
			{
				return null;
			}
			num5 *= radix;
			if (num5 < long.MinValue + num4)
			{
				return null;
			}
			num5 -= num4;
		}
		if (num2 != 0)
		{
			Long result = Long.valueOf(num5);
			_ = null;
			return result;
		}
		if (num5 == long.MinValue)
		{
			return null;
		}
		Long result2 = Long.valueOf(-num5);
		_ = null;
		return result2;
	}

	[LineNumberTable(new byte[] { 160, 66, 104, 102, 2, 230, 69 })]
	private static int lastIndexOf(long[] P_0, long P_1, int P_2, int P_3)
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

	[LineNumberTable(new byte[] { 79, 102, 102, 2, 230, 69 })]
	private static int indexOf(long[] P_0, long P_1, int P_2, int P_3)
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
	[LineNumberTable(new byte[] { 161, 204, 103, 105, 104, 106 })]
	public static void sortDescending(long[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		Arrays.sort(array, fromIndex, toIndex);
		reverse(array, fromIndex, toIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 232, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(long[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			long num2 = array[num];
			array[num] = array[i];
			array[i] = num2;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(50)]
	private Longs()
	{
	}

	[LineNumberTable(new byte[] { 57, 111, 100, 2, 230, 69 })]
	public static bool contains(long[] array, long target)
	{
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			long num2 = array[i];
			if (num2 == target)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public static int indexOf(long[] array, long target)
	{
		int result = indexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		98, 108, 108, 100, 194, 108, 103, 106, 2, 230,
		69, 226, 58, 230, 72
	})]
	public static int indexOf(long[] array, long[] target)
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
	[LineNumberTable(175)]
	public static int lastIndexOf(long[] array, long target)
	{
		int result = lastIndexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 83, 106, 100, 103, 102, 4, 230, 69 })]
	public static long min(params long[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		long num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			if (array[i] < num)
			{
				num = array[i];
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 102, 106, 100, 103, 102, 4, 230, 69 })]
	public static long max(params long[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		long num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			if (array[i] > num)
			{
				num = array[i];
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 127, 115 })]
	public static long constrainToRange(long value, long min, long max)
	{
		Preconditions.checkArgument(min <= max, "min (%s) must be less than or equal to max (%s)", min, max);
		long result = java.lang.Math.min(java.lang.Math.max(value, min), max);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		160, 139, 98, 112, 38, 166, 104, 98, 120, 110,
		6, 200
	})]
	public static long[] concat(params long[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			long[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		long[] array2 = new long[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			long[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_8(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 185, 117 })]
	public static long fromByteArray(byte[] bytes)
	{
		Preconditions.checkArgument((nint)bytes.LongLength >= 8, "array too small: %s < %s", bytes.Length, 8);
		long result = fromBytes(bytes[0], bytes[1], bytes[2], bytes[3], bytes[4], bytes[5], bytes[6], bytes[7]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(369)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Long tryParse(string @string)
	{
		Long result = tryParse(@string, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Long;>;")]
	[LineNumberTable(474)]
	public static Converter stringConverter()
	{
		return LongConverter.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 121, 114, 114 })]
	public static long[] ensureCapacity(long[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 135, 103, 100, 198, 107, 106, 103, 48, 166 })]
	public static string join(string separator, params long[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * 10));
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
	[Signature("()Ljava/util/Comparator<[J>;")]
	[LineNumberTable(533)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 193, 103, 107 })]
	public static void sortDescending(long[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 217, 103, 107 })]
	public static void reverse(long[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([J)Ljava/util/List<Ljava/lang/Long;>;")]
	[LineNumberTable(new byte[] { 162, 29, 100, 136 })]
	public static List asList(params long[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		LongArrayAsList result2 = new LongArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(49)]
	internal static int access_0024000(long[] P_0, long P_1, int P_2, int P_3)
	{
		int result = indexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(49)]
	internal static int access_0024100(long[] P_0, long P_1, int P_2, int P_3)
	{
		int result = lastIndexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}
}
