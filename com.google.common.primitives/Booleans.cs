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
public sealed class Booleans : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Boolean;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class BooleanArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal bool[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 19, 104, 103, 103, 103 })]
		internal BooleanArrayAsList(bool[] P_0, int P_1, int P_2)
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
		[LineNumberTable(new byte[] { 161, 74, 109, 144, 127, 0 })]
		public virtual java.lang.Boolean set(int P_0, java.lang.Boolean P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			int b = (array[start + P_0] ? 1 : 0);
			array[start + P_0] = ((java.lang.Boolean)Preconditions.checkNotNull(P_1)).booleanValue();
			java.lang.Boolean result = java.lang.Boolean.valueOf((byte)b != 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 37, 109 })]
		public new virtual java.lang.Boolean get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			java.lang.Boolean result = java.lang.Boolean.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 16, 108 })]
		internal BooleanArrayAsList(bool[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 44, 116, 61 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is java.lang.Boolean && access_0024000(array, ((java.lang.Boolean)P_0).booleanValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 51, 104, 127, 4, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Boolean)
			{
				int num = access_0024000(array, ((java.lang.Boolean)P_0).booleanValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 63, 104, 127, 4, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Boolean)
			{
				int num = access_0024100(array, ((java.lang.Boolean)P_0).booleanValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Boolean;>;")]
		[LineNumberTable(new byte[] { 161, 83, 103, 104, 100, 136 })]
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
			BooleanArrayAsList result2 = new BooleanArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 93, 100, 130, 104, 103, 103, 105, 130, 102,
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
			if (P_0 is BooleanArrayAsList)
			{
				BooleanArrayAsList booleanArrayAsList = (BooleanArrayAsList)P_0;
				int num = size();
				if (booleanArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != booleanArrayAsList.array[booleanArrayAsList.start + i])
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
		[LineNumberTable(new byte[] { 161, 114, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Booleans.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 123, 110, 127, 3, 114, 61, 166 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(size() * 7);
			stringBuilder.append((!array[start]) ? "[false" : "[true");
			for (int i = start + 1; i < end; i++)
			{
				stringBuilder.append((!array[i]) ? ", false" : ", true");
			}
			string result = stringBuilder.append(']').toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(502)]
		internal virtual bool[] toBooleanArray()
		{
			bool[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(378)]
		public override object set(int P_0, object P_1)
		{
			java.lang.Boolean result = set(P_0, (java.lang.Boolean)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(378)]
		public override object get(int P_0)
		{
			java.lang.Boolean result = get(P_0);
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
		protected BooleanArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Booleans$BooleanComparator;>;Ljava/util/Comparator<Ljava/lang/Boolean;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "java.util.Comparator" })]
	internal sealed class BooleanComparator : java.lang.Enum, Comparator
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static BooleanComparator TRUE_FIRST;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static BooleanComparator FALSE_FIRST;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int trueValue;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new string m_toString;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static BooleanComparator[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 14, 114, 114 })]
		public virtual int compare(java.lang.Boolean P_0, java.lang.Boolean P_1)
		{
			int num = (P_0.booleanValue() ? trueValue : 0);
			int num2 = (P_1.booleanValue() ? trueValue : 0);
			return num2 - num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/lang/String;)V")]
		[LineNumberTable(new byte[] { 7, 106, 103, 104 })]
		private BooleanComparator(string P_0, int P_1, int P_2, string P_3)
			: base(P_0, P_1)
		{
			trueValue = P_2;
			this.m_toString = P_3;
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(50)]
		private static BooleanComparator[] _0024values()
		{
			return new BooleanComparator[2] { TRUE_FIRST, FALSE_FIRST };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(50)]
		public static BooleanComparator[] values()
		{
			return (BooleanComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(50)]
		public static BooleanComparator valueOf(string P_0)
		{
			return (BooleanComparator)java.lang.Enum.valueOf(ClassLiteral<BooleanComparator>.Value, P_0);
		}

		public override string toString()
		{
			return this.m_toString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(50)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((java.lang.Boolean)P_0, (java.lang.Boolean)P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 1, 118, 22 })]
		static BooleanComparator()
		{
			TRUE_FIRST = new BooleanComparator("TRUE_FIRST", 0, 1, "Booleans.trueFirst()");
			FALSE_FIRST = new BooleanComparator("FALSE_FIRST", 1, -1, "Booleans.falseFirst()");
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
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Booleans$LexicographicalComparator;>;Ljava/util/Comparator<[Z>;")]
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
		[LineNumberTable(new byte[] { 160, 200, 106, 102, 108, 99, 226, 61, 230, 70 })]
		public virtual int compare(bool[] P_0, bool[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = Booleans.compare(P_0[i], P_1[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(309)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(309)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(309)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(309)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "Booleans.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(309)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((bool[])P_0, (bool[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 196, 48 })]
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

	public static int compare(bool a, bool b)
	{
		return (a != b) ? (a ? 1 : (-1)) : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	internal static int access_0024000(bool[] P_0, bool P_1, int P_2, int P_3)
	{
		int result = indexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	internal static int access_0024100(bool[] P_0, bool P_1, int P_2, int P_3)
	{
		int result = lastIndexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	public static int hashCode(bool value)
	{
		return (!value) ? 1237 : 1231;
	}

	[LineNumberTable(new byte[] { 159, 88, 162, 104, 102, 2, 230, 69 })]
	private static int lastIndexOf(bool[] P_0, bool P_1, int P_2, int P_3)
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

	[LineNumberTable(new byte[] { 159, 100, 66, 102, 102, 2, 230, 69 })]
	private static int indexOf(bool[] P_0, bool P_1, int P_2, int P_3)
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
	[LineNumberTable(new byte[]
	{
		161, 176, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(bool[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			int num2 = (array[num] ? 1 : 0);
			array[num] = array[i];
			array[i] = (byte)num2 != 0;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	private Booleans()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<Ljava/lang/Boolean;>;")]
	[LineNumberTable(85)]
	public static Comparator trueFirst()
	{
		return BooleanComparator.TRUE_FIRST;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<Ljava/lang/Boolean;>;")]
	[LineNumberTable(98)]
	public static Comparator falseFirst()
	{
		return BooleanComparator.FALSE_FIRST;
	}

	[LineNumberTable(new byte[] { 159, 107, 162, 112, 101, 2, 230, 69 })]
	public static bool contains(bool[] array, bool target)
	{
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = (array[i] ? 1 : 0);
			if (num2 == (target ? 1 : 0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(163)]
	public static int indexOf(bool[] array, bool target)
	{
		int result = indexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 73, 108, 108, 100, 194, 108, 103, 106, 2,
		230, 69, 226, 58, 230, 72
	})]
	public static int indexOf(bool[] array, bool[] target)
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
	[LineNumberTable(214)]
	public static int lastIndexOf(bool[] array, bool target)
	{
		int result = lastIndexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		160, 122, 98, 112, 38, 166, 104, 98, 120, 110,
		6, 200
	})]
	public static bool[] concat(params bool[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			bool[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		bool[] array2 = new bool[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			bool[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_1(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 149, 114, 114 })]
	public static bool[] ensureCapacity(bool[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 164, 103, 100, 198, 106, 106, 103, 48, 166 })]
	public static string join(string separator, params bool[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * 7));
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
	[Signature("()Ljava/util/Comparator<[Z>;")]
	[LineNumberTable(306)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/lang/Boolean;>;)[Z")]
	[LineNumberTable(new byte[] { 160, 231, 104, 174, 103, 99, 103, 134, 21, 198 })]
	public static bool[] toArray(Collection collection)
	{
		if (collection is BooleanArrayAsList)
		{
			bool[] result = ((BooleanArrayAsList)collection).toBooleanArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		bool[] array2 = new bool[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = ((java.lang.Boolean)Preconditions.checkNotNull(array[i])).booleanValue();
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Z)Ljava/util/List<Ljava/lang/Boolean;>;")]
	[LineNumberTable(new byte[] { 161, 2, 100, 136 })]
	public static List asList(params bool[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		BooleanArrayAsList result2 = new BooleanArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[LineNumberTable(new byte[] { 161, 145, 98, 112, 100, 4, 230, 69 })]
	public static int countTrue(params bool[] values)
	{
		int num = 0;
		int num2 = values.Length;
		for (int i = 0; i < num2; i++)
		{
			if (values[i])
			{
				num++;
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 161, 103, 107 })]
	public static void reverse(bool[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}
}
