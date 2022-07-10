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
using javax.annotation;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class Bytes : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Byte;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class ByteArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal byte[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 137, 104, 103, 103, 103 })]
		internal ByteArrayAsList(byte[] P_0, int P_1, int P_2)
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
		[LineNumberTable(new byte[] { 160, 191, 109, 144, 127, 1 })]
		public virtual java.lang.Byte set(int P_0, java.lang.Byte P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			int b = array[start + P_0];
			array[start + P_0] = (byte)(sbyte)((java.lang.Byte)Preconditions.checkNotNull(P_1)).byteValue();
			java.lang.Byte result = java.lang.Byte.valueOf((byte)b);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 155, 109 })]
		public new virtual java.lang.Byte get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			java.lang.Byte result = java.lang.Byte.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 134, 108 })]
		internal ByteArrayAsList(byte[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(276)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is java.lang.Byte && access_0024000(array, (byte)(sbyte)((java.lang.Byte)P_0).byteValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 168, 104, 127, 5, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Byte)
			{
				int num = access_0024000(array, (byte)(sbyte)((java.lang.Byte)P_0).byteValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 180, 104, 127, 5, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Byte)
			{
				int num = access_0024100(array, (byte)(sbyte)((java.lang.Byte)P_0).byteValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Byte;>;")]
		[LineNumberTable(new byte[] { 160, 200, 103, 104, 100, 136 })]
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
			ByteArrayAsList result2 = new ByteArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 210, 100, 130, 104, 103, 103, 105, 130, 102,
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
			if (P_0 is ByteArrayAsList)
			{
				ByteArrayAsList byteArrayAsList = (ByteArrayAsList)P_0;
				int num = size();
				if (byteArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != byteArrayAsList.array[byteArrayAsList.start + i])
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
		[LineNumberTable(new byte[] { 160, 231, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Bytes.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 240, 110, 123, 114, 57, 166 })]
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
		[LineNumberTable(363)]
		internal virtual byte[] toByteArray()
		{
			byte[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(240)]
		public override object set(int P_0, object P_1)
		{
			java.lang.Byte result = set(P_0, (java.lang.Byte)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(240)]
		public override object get(int P_0)
		{
			java.lang.Byte result = get(P_0);
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
		protected ByteArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static int access_0024000(byte[] P_0, byte P_1, int P_2, int P_3)
	{
		int num = (sbyte)P_1;
		int result = indexOf(P_0, (byte)num, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static int access_0024100(byte[] P_0, byte P_1, int P_2, int P_3)
	{
		int num = (sbyte)P_1;
		int result = lastIndexOf(P_0, (byte)num, P_2, P_3);
		_ = null;
		return result;
	}

	public static int hashCode(byte value)
	{
		return (sbyte)value;
	}

	[LineNumberTable(new byte[] { 159, 106, 99, 104, 102, 2, 230, 69 })]
	private static int lastIndexOf(byte[] P_0, byte P_1, int P_2, int P_3)
	{
		int num = (sbyte)P_1;
		for (int i = P_3 - 1; i >= P_2; i += -1)
		{
			if (P_0[i] == num)
			{
				return i;
			}
		}
		return -1;
	}

	[LineNumberTable(new byte[] { 159, 119, 131, 102, 102, 2, 230, 69 })]
	private static int indexOf(byte[] P_0, byte P_1, int P_2, int P_3)
	{
		int num = (sbyte)P_1;
		for (int i = P_2; i < P_3; i++)
		{
			if (P_0[i] == num)
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 21, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(byte[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			int num2 = array[num];
			array[num] = array[i];
			array[i] = (byte)num2;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	private Bytes()
	{
	}

	[LineNumberTable(new byte[] { 159, 124, 67, 112, 101, 2, 230, 69 })]
	public static bool contains(byte[] array, byte target)
	{
		int num = (sbyte)target;
		int num2 = array.Length;
		for (int i = 0; i < num2; i++)
		{
			int num3 = array[i];
			if (num3 == num)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public static int indexOf(byte[] array, byte target)
	{
		int num = (sbyte)target;
		int result = indexOf(array, (byte)num, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		63, 108, 108, 100, 194, 108, 103, 106, 2, 230,
		69, 226, 58, 230, 72
	})]
	public static int indexOf(byte[] array, byte[] target)
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
	[LineNumberTable(140)]
	public static int lastIndexOf(byte[] array, byte target)
	{
		int num = (sbyte)target;
		int result = lastIndexOf(array, (byte)num, 0, array.Length);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		111, 98, 112, 38, 166, 104, 98, 120, 110, 6,
		200
	})]
	public static byte[] concat(params byte[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			byte[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		byte[] array2 = new byte[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			byte[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_1(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 74, 114, 114 })]
	public static byte[] ensureCapacity(byte[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)[B")]
	[LineNumberTable(new byte[] { 160, 93, 104, 174, 103, 99, 103, 134, 22, 198 })]
	public static byte[] toArray(Collection collection)
	{
		if (collection is ByteArrayAsList)
		{
			byte[] result = ((ByteArrayAsList)collection).toByteArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		byte[] array2 = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = (byte)(sbyte)((Number)Preconditions.checkNotNull(array[i])).byteValue();
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([B)Ljava/util/List<Ljava/lang/Byte;>;")]
	[LineNumberTable(new byte[] { 160, 120, 100, 136 })]
	public static List asList(params byte[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		ByteArrayAsList result2 = new ByteArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 6, 103, 107 })]
	public static void reverse(byte[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}
}
