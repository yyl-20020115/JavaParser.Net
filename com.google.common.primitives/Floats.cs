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
public sealed class Floats : FloatsMethodsForWeb
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Float;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class FloatArrayAsList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal float[] array;

		[Modifiers(Modifiers.Final)]
		internal int start;

		[Modifiers(Modifiers.Final)]
		internal int end;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 158, 104, 103, 103, 103 })]
		internal FloatArrayAsList(float[] P_0, int P_1, int P_2)
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
		[LineNumberTable(new byte[] { 161, 212, 109, 144, 127, 0 })]
		public virtual Float set(int P_0, Float P_1)
		{
			Preconditions.checkElementIndex(P_0, size());
			float f = array[start + P_0];
			array[start + P_0] = ((Float)Preconditions.checkNotNull(P_1)).floatValue();
			Float result = Float.valueOf(f);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 176, 109 })]
		public new virtual Float get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			Float result = Float.valueOf(array[start + P_0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 155, 108 })]
		internal FloatArrayAsList(float[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(553)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 is Float && access_0024000(array, ((Float)P_0).floatValue(), start, end) != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 189, 104, 127, 4, 100, 169 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Float)
			{
				int num = access_0024000(array, ((Float)P_0).floatValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 201, 104, 127, 4, 100, 169 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Float)
			{
				int num = access_0024100(array, ((Float)P_0).floatValue(), start, end);
				if (num >= 0)
				{
					return num - start;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<Ljava/lang/Float;>;")]
		[LineNumberTable(new byte[] { 161, 221, 103, 104, 100, 136 })]
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
			FloatArrayAsList result2 = new FloatArrayAsList(array, start + P_0, start + P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 231, 100, 130, 104, 103, 103, 105, 130, 102,
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
			if (P_0 is FloatArrayAsList)
			{
				FloatArrayAsList floatArrayAsList = (FloatArrayAsList)P_0;
				int num = size();
				if (floatArrayAsList.size() != num)
				{
					return false;
				}
				for (int i = 0; i < num; i++)
				{
					if (array[start + i] != floatArrayAsList.array[floatArrayAsList.start + i])
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
		[LineNumberTable(new byte[] { 161, 252, 98, 112, 51, 166 })]
		public override int hashCode()
		{
			int num = 1;
			for (int i = start; i < end; i++)
			{
				num = 31 * num + Floats.hashCode(array[i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 5, 111, 123, 114, 57, 166 })]
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
		[LineNumberTable(640)]
		internal virtual float[] toFloatArray()
		{
			float[] result = Arrays.copyOfRange(array, start, end);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(517)]
		public override object set(int P_0, object P_1)
		{
			Float result = set(P_0, (Float)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(517)]
		public override object get(int P_0)
		{
			Float result = get(P_0);
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
		protected FloatArrayAsList(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Float;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class FloatConverter : Converter, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static FloatConverter INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(297)]
		protected internal virtual string doBackward(Float P_0)
		{
			string result = P_0.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(292)]
		protected internal virtual Float doForward(string P_0)
		{
			Float result = Float.valueOf(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(286)]
		private FloatConverter()
		{
		}

		public override string toString()
		{
			return "Floats.stringConverter()";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(286)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((Float)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(286)]
		protected internal override object doForward(object P_0)
		{
			Float result = doForward((string)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(288)]
		static FloatConverter()
		{
			INSTANCE = new FloatConverter();
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
		protected FloatConverter(SerializationInfo P_0, StreamingContext P_1)
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
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/Floats$LexicographicalComparator;>;Ljava/util/Comparator<[F>;")]
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
		[LineNumberTable(new byte[] { 161, 21, 106, 102, 108, 99, 226, 61, 230, 70 })]
		public virtual int compare(float[] P_0, float[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = Float.compare(P_0[i], P_1[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(386)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(386)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(386)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(386)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "Floats.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(386)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((float[])P_0, (float[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 17, 48 })]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static int access_0024000(float[] P_0, float P_1, int P_2, int P_3)
	{
		int result = indexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static int access_0024100(float[] P_0, float P_1, int P_2, int P_3)
	{
		int result = lastIndexOf(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public static int hashCode(float value)
	{
		int result = Float.valueOf(value).hashCode();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 78, 104, 103, 2, 230, 69 })]
	private static int lastIndexOf(float[] P_0, float P_1, int P_2, int P_3)
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

	[LineNumberTable(new byte[] { 88, 102, 103, 2, 230, 69 })]
	private static int indexOf(float[] P_0, float P_1, int P_2, int P_3)
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
	[LineNumberTable(new byte[] { 161, 60, 103, 105, 104, 106 })]
	public static void sortDescending(float[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		Arrays.sort(array, fromIndex, toIndex);
		reverse(array, fromIndex, toIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 88, 103, 105, 106, 100, 102, 228, 61, 234,
		69
	})]
	public static void reverse(float[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		int num = fromIndex;
		for (int i = toIndex - 1; num < i; i += -1)
		{
			float num2 = array[num];
			array[num] = array[i];
			array[i] = num2;
			num++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	private Floats()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public static int compare(float a, float b)
	{
		int result = Float.compare(a, b);
		_ = null;
		return result;
	}

	public static bool isFinite(float value)
	{
		return (float.NegativeInfinity < value && value < float.PositiveInfinity) ? true : false;
	}

	[LineNumberTable(new byte[] { 65, 111, 101, 2, 230, 69 })]
	public static bool contains(float[] array, float target)
	{
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			float num2 = array[i];
			if (num2 == target)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(133)]
	public static int indexOf(float[] array, float target)
	{
		int result = indexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		109, 108, 108, 100, 194, 108, 103, 106, 2, 230,
		69, 226, 58, 230, 72
	})]
	public static int indexOf(float[] array, float[] target)
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
	[LineNumberTable(187)]
	public static int lastIndexOf(float[] array, float target)
	{
		int result = lastIndexOf(array, target, 0, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 98, 106, 100, 103, 42, 166 })]
	public static float min(params float[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		float num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			num = java.lang.Math.min(num, array[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 118, 106, 100, 103, 42, 166 })]
	public static float max(params float[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		float num = array[0];
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			num = java.lang.Math.max(num, array[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 143, 102, 147, 111 })]
	public static float constrainToRange(float value, float min, float max)
	{
		if (min <= max)
		{
			float result = java.lang.Math.min(java.lang.Math.max(value, min), max);
			_ = null;
			return result;
		}
		string s = Strings.lenientFormat("min (%s) must be less than or equal to max (%s)", Float.valueOf(min), Float.valueOf(max));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[LineNumberTable(new byte[]
	{
		160, 159, 98, 112, 38, 166, 104, 98, 120, 110,
		6, 200
	})]
	public static float[] concat(params float[][] arrays)
	{
		int num = 0;
		int num2 = arrays.Length;
		for (int i = 0; i < num2; i++)
		{
			float[] array = arrays[i];
			num = (int)(num + (nint)array.LongLength);
		}
		float[] array2 = new float[num];
		num2 = 0;
		int num3 = arrays.Length;
		for (int j = 0; j < num3; j++)
		{
			float[] array3 = arrays[j];
			ByteCodeHelper.arraycopy_primitive_4(array3, 0, array2, num2, array3.Length);
			num2 = (int)(num2 + (nint)array3.LongLength);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/Float;>;")]
	[LineNumberTable(320)]
	public static Converter stringConverter()
	{
		return FloatConverter.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 223, 114, 114 })]
	public static float[] ensureCapacity(float[] array, int minLength, int padding)
	{
		Preconditions.checkArgument(minLength >= 0, "Invalid minLength: %s", minLength);
		Preconditions.checkArgument(padding >= 0, "Invalid padding: %s", padding);
		return ((nint)array.LongLength >= minLength) ? array : Arrays.copyOf(array, minLength + padding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 241, 103, 100, 198, 107, 106, 103, 48, 166 })]
	public static string join(string separator, params float[] array)
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
	[Signature("()Ljava/util/Comparator<[F>;")]
	[LineNumberTable(383)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 46, 103, 107 })]
	public static void sortDescending(float[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 73, 103, 107 })]
	public static void reverse(float[] array)
	{
		Preconditions.checkNotNull(array);
		reverse(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)[F")]
	[LineNumberTable(new byte[] { 161, 111, 104, 174, 103, 99, 103, 134, 21, 198 })]
	public static float[] toArray(Collection collection)
	{
		if (collection is FloatArrayAsList)
		{
			float[] result = ((FloatArrayAsList)collection).toFloatArray();
			_ = null;
			return result;
		}
		object[] array = collection.toArray();
		int num = array.Length;
		float[] array2 = new float[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = ((Number)Preconditions.checkNotNull(array[i])).floatValue();
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([F)Ljava/util/List<Ljava/lang/Float;>;")]
	[LineNumberTable(new byte[] { 161, 141, 100, 136 })]
	public static List asList(params float[] backingArray)
	{
		if (backingArray.Length == 0)
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		FloatArrayAsList result2 = new FloatArrayAsList(backingArray);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 41, 223, 3, 122, 225, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Float tryParse(string @string)
	{
		//Discarded unreachable code: IL_002f
		Pattern fLOATING_POINT_PATTERN = Doubles.FLOATING_POINT_PATTERN;
		CharSequence input = default(CharSequence);
		object obj = (input.___003Cref_003E = @string);
		if (fLOATING_POINT_PATTERN.matcher(input).matches())
		{
			try
			{
				return Float.valueOf(Float.parseFloat(@string));
			}
			catch (NumberFormatException)
			{
			}
			_ = null;
		}
		return null;
	}
}
