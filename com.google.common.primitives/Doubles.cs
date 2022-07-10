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
using java.util.regex;
using javax.annotation;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class Doubles : DoublesMethodsForWeb
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Double;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class DoubleArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal double[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 166, 104, 103, 103, 103 })]
		internal DoubleArrayAsList(double[] P_0, int P_1, int P_2)
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
		[LineNumberTable(new byte[] { 161, 226, 109, 144, 127, 1 })]
		public virtual java.lang.Double set(int P_0, java.lang.Double P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			double d = array[start + P_0];
			array[start + P_0] = ((java.lang.Double)Preconditions.checkNotNull(P_1)).doubleValue();
			java.lang.Double result = java.lang.Double.valueOf(d);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 184, 109 })]
		public new virtual java.lang.Double get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			java.lang.Double result = java.lang.Double.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(560)]
		public new virtual Spliterator.OfDouble spliterator()
		{
			Spliterator.OfDouble result = Spliterators.spliterator(array, start, end, 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 163, 108 })]
		internal DoubleArrayAsList(double[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 196, 116, 61 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is java.lang.Double && access_0024000(array, ((java.lang.Double)P_0).doubleValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 203, 104, 127, 4, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Double)
			{
				int num = access_0024000(array, ((java.lang.Double)P_0).doubleValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 215, 104, 127, 4, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is java.lang.Double)
			{
				int num = access_0024100(array, ((java.lang.Double)P_0).doubleValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Double;>;")]
		[LineNumberTable(new byte[] { 161, 235, 103, 104, 100, 136 })]
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
			DoubleArrayAsList result2 = new DoubleArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 245, 100, 130, 104, 103, 103, 105, 130, 102,
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
			if (P_0 is DoubleArrayAsList)
			{
				DoubleArrayAsList doubleArrayAsList = (DoubleArrayAsList)P_0;
				int num = size();
				if (doubleArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != doubleArrayAsList.array[doubleArrayAsList.start + i])
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
		[LineNumberTable(new byte[] { 162, 10, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Doubles.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 19, 111, 123, 114, 57, 166 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(size() * 12);
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
		[LineNumberTable(654)]
		internal virtual double[] toDoubleArray()
		{
			double[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		public override object set(int P_0, object P_1)
		{
			java.lang.Double result = set(P_0, (java.lang.Double)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		public override object get(int P_0)
		{
			java.lang.Double result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		public override Spliterator spliterator()
		{
			Spliterator.OfDouble result = spliterator();
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
		protected DoubleArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Double;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class DoubleConverter : Converter, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static DoubleConverter INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(302)]
		protected internal virtual string doBackward(java.lang.Double P_0)
		{
			string result = P_0.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(297)]
		protected internal virtual java.lang.Double doForward(string P_0)
		{
			java.lang.Double result = java.lang.Double.valueOf(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(291)]
		private DoubleConverter()
		{
		}

		public override string toString()
		{
			return "Doubles.stringConverter()";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(291)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((java.lang.Double)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(291)]
		protected internal override object doForward(object P_0)
		{
			java.lang.Double result = doForward((string)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(293)]
		static DoubleConverter()
		{
			INSTANCE = new DoubleConverter();
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
		protected DoubleConverter(SerializationInfo P_0, StreamingContext P_1)
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
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Doubles$LexicographicalComparator;>;Ljava/util/Comparator<[D>;")]
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
		[LineNumberTable(new byte[] { 161, 26, 106, 102, 108, 99, 226, 61, 230, 70 })]
		public virtual int compare(double[] P_0, double[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = java.lang.Double.compare(P_0[i], P_1[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(391)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(391)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(391)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(391)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "Doubles.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(391)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((double[])P_0, (double[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 22, 48 })]
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

	public const int BYTES = 8;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static Pattern FLOATING_POINT_PATTERN;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public static bool isFinite(double value)
	{
		return (double.NegativeInfinity < value && value < double.PositiveInfinity) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 148, 102, 147, 111 })]
	public static double constrainToRange(double value, double min, double max)
	{
		if (min <= max)
		{
			double result = java.lang.Math.min(java.lang.Math.max(value, min), max);
			_ = null;
			return result;
		}
		string s = Strings.lenientFormat("min (%s) must be less than or equal to max (%s)", java.lang.Double.valueOf(min), java.lang.Double.valueOf(max));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)[D")]
	[LineNumberTable(new byte[] { 161, 116, 104, 174, 103, 99, 103, 134, 22, 198 })]
	public static double[] toArray(Collection collection)
	{
		if (collection is DoubleArrayAsList)
		{
			double[] result = ((DoubleArrayAsList)collection).toDoubleArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		double[] array2 = new double[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = ((Number)Preconditions.checkNotNull(array[i])).doubleValue();
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(53)]
	internal static int access_0024000(double[] P_0, double P_1, int P_2, int P_3)
	{
		int result = indexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(53)]
	internal static int access_0024100(double[] P_0, double P_1, int P_2, int P_3)
	{
		int result = lastIndexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(75)]
	public static int hashCode(double value)
	{
		int result = java.lang.Double.valueOf(value).hashCode();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 83, 104, 103, 2, 230, 69 })]
	private static int lastIndexOf(double[] P_0, double P_1, int P_2, int P_3)
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

	[LineNumberTable(new byte[] { 93, 102, 103, 2, 230, 69 })]
	private static int indexOf(double[] P_0, double P_1, int P_2, int P_3)
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
	[LineNumberTable(new byte[] { 161, 65, 103, 105, 104, 106 })]
	public static void sortDescending(double[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		Arrays.sort(array, fromIndex, toIndex);
		reverse(array, fromIndex, toIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 93, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(double[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			double num2 = array[num];
			array[num] = array[i];
			array[i] = num2;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 53, 102, 113, 102, 127, 25, 127, 55, 108,
		223, 16, 130, 7
	})]
	private static Pattern fpPattern()
	{
		string obj = "(?:\\d+#(?:\\.\\d*#)?|\\.\\d+#)";
		string text = java.lang.String.instancehelper_concat(java.lang.String.valueOf(obj), "(?:[eE][+-]?\\d+#)?[fFdD]?");
		string text2 = "(?:[0-9a-fA-F]+#(?:\\.[0-9a-fA-F]*#)?|\\.[0-9a-fA-F]+#)";
		int num = 25 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string text3 = new StringBuilder(num).append("0[xX]").append(text2).append("[pP][+-]?\\d+#[fFdD]?")
			.toString();
		num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
		num = num;
		string text4 = new StringBuilder(num).append("[+-]?(?:NaN|Infinity|").append(text).append("|")
			.append(text3)
			.append(")")
			.toString();
		string @this = text4;
		object __003Cref_003E = "+";
		CharSequence charSequence = default(CharSequence);
		object obj2 = (charSequence.___003Cref_003E = "#");
		CharSequence target = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E);
		text4 = java.lang.String.instancehelper_replace(@this, target, charSequence);
		Pattern result = Pattern.compile(text4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	private Doubles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public static int compare(double a, double b)
	{
		int result = java.lang.Double.compare(a, b);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 70, 111, 101, 2, 230, 69 })]
	public static bool contains(double[] array, double target)
	{
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			double num2 = array[i];
			if (num2 == target)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(138)]
	public static int indexOf(double[] array, double target)
	{
		int result = indexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		114, 108, 108, 100, 194, 108, 103, 106, 2, 230,
		69, 226, 58, 230, 72
	})]
	public static int indexOf(double[] array, double[] target)
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
	[LineNumberTable(192)]
	public static int lastIndexOf(double[] array, double target)
	{
		int result = lastIndexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 103, 106, 100, 103, 43, 166 })]
	public static double min(params double[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		double num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			num = java.lang.Math.min(num, array[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 123, 106, 100, 103, 43, 166 })]
	public static double max(params double[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		double num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			num = java.lang.Math.max(num, array[i]);
		}
		return num;
	}

	[LineNumberTable(new byte[]
	{
		160, 164, 98, 112, 38, 166, 104, 98, 120, 110,
		6, 200
	})]
	public static double[] concat(params double[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			double[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		double[] array2 = new double[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			double[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_8(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Double;>;")]
	[LineNumberTable(325)]
	public static Converter stringConverter()
	{
		return DoubleConverter.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 228, 114, 114 })]
	public static double[] ensureCapacity(double[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 246, 103, 100, 198, 107, 106, 103, 48, 166 })]
	public static string join(string separator, params double[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * 12));
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
	[Signature("()Ljava/util/Comparator<[D>;")]
	[LineNumberTable(388)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 51, 103, 107 })]
	public static void sortDescending(double[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 78, 103, 107 })]
	public static void reverse(double[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([D)Ljava/util/List<Ljava/lang/Double;>;")]
	[LineNumberTable(new byte[] { 161, 149, 100, 136 })]
	public static List asList(params double[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		DoubleArrayAsList result2 = new DoubleArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 89, 223, 3, 122, 225, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static java.lang.Double tryParse(string @string)
	{
		//Discarded unreachable code: IL_002f
		Pattern fLOATING_POINT_PATTERN = FLOATING_POINT_PATTERN;
		CharSequence input = default(CharSequence);
		object obj = (input.___003Cref_003E = @string);
		if (fLOATING_POINT_PATTERN.matcher(input).matches())
		{
			try
			{
				return java.lang.Double.valueOf(java.lang.Double.parseDouble(@string));
			}
			catch (NumberFormatException)
			{
			}
			_ = null;
		}
		return null;
	}

	[LineNumberTable(668)]
	static Doubles()
	{
		FLOATING_POINT_PATTERN = fpPattern();
	}
}
