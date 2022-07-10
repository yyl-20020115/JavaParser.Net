using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.math;
using java.util;
using org.checkerframework.dataflow.qual;

namespace org.checkerframework.checker.formatter.qual;

[Serializable]
[Signature("Ljava/lang/Enum<Lorg/checkerframework/checker/formatter/qual/ConversionCategory;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ConstantPool(new object[]
{
	(byte)110,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
public sealed class ConversionCategory : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		GENERAL,
		CHAR,
		INT,
		FLOAT,
		TIME,
		CHAR_AND_INT,
		INT_AND_TIME,
		NULL,
		UNUSED
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003EGENERAL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003ECHAR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003EINT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003EFLOAT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003ETIME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003ECHAR_AND_INT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003EINT_AND_TIME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003ENULL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static ConversionCategory ___003C_003EUNUSED;

	[Signature("[Ljava/lang/Class<*>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 110, 0, 0 })]
	internal Class[] ___003C_003Etypes;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 110, 0, 0 })]
	internal string ___003C_003Echars;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static ConversionCategory[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory GENERAL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EGENERAL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory CHAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECHAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory INT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory FLOAT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFLOAT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory TIME
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETIME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory CHAR_AND_INT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECHAR_AND_INT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory INT_AND_TIME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINT_AND_TIME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory NULL
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENULL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static ConversionCategory UNUSED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUNUSED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Final)]
	public Class[] types
	{
		[HideFromJava]
		get
		{
			return ___003C_003Etypes;
		}
		[HideFromJava]
		private set
		{
			___003C_003Etypes = value;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Final)]
	public string chars
	{
		[HideFromJava]
		get
		{
			return ___003C_003Echars;
		}
		[HideFromJava]
		private set
		{
			___003C_003Echars = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<+Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 110, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		109, 104, 134, 104, 134, 104, 134, 104, 134, 104,
		134, 104, 134, 104, 134, 104, 134
	})]
	private static Class unwrapPrimitive(Class P_0)
	{
		if (P_0 == ClassLiteral<java.lang.Byte>.Value)
		{
			return java.lang.Byte.TYPE;
		}
		if (P_0 == ClassLiteral<Character>.Value)
		{
			return Character.TYPE;
		}
		if (P_0 == ClassLiteral<Short>.Value)
		{
			return Short.TYPE;
		}
		if (P_0 == ClassLiteral<Integer>.Value)
		{
			return Integer.TYPE;
		}
		if (P_0 == ClassLiteral<Long>.Value)
		{
			return Long.TYPE;
		}
		if (P_0 == ClassLiteral<Float>.Value)
		{
			return Float.TYPE;
		}
		if (P_0 == ClassLiteral<java.lang.Double>.Value)
		{
			return java.lang.Double.TYPE;
		}
		if (P_0 == ClassLiteral<java.lang.Boolean>.Value)
		{
			return java.lang.Boolean.TYPE;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 116, 104, 130, 104, 130, 104, 130, 104, 226,
		70, 204, 108, 136, 223, 49, 110, 106, 227, 58,
		232, 73
	})]
	public static ConversionCategory intersect(ConversionCategory a, ConversionCategory b)
	{
		if (a == ___003C_003EUNUSED)
		{
			return b;
		}
		if (b == ___003C_003EUNUSED)
		{
			return a;
		}
		if (a == ___003C_003EGENERAL)
		{
			return b;
		}
		if (b == ___003C_003EGENERAL)
		{
			return a;
		}
		Set set = arrayToSet(a.___003C_003Etypes);
		Set c = arrayToSet(b.___003C_003Etypes);
		set.retainAll(c);
		ConversionCategory[] array = new ConversionCategory[7] { ___003C_003ECHAR, ___003C_003EINT, ___003C_003EFLOAT, ___003C_003ETIME, ___003C_003ECHAR_AND_INT, ___003C_003EINT_AND_TIME, ___003C_003ENULL };
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			ConversionCategory conversionCategory = array[i];
			Set set2 = arrayToSet(conversionCategory.___003C_003Etypes);
			if (set2.equals(set))
			{
				return conversionCategory;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(207)]
	private static Set arrayToSet(object[] P_0)
	{
		HashSet.___003Cclinit_003E();
		HashSet result = new HashSet(Arrays.asList(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;[Ljava/lang/Class<*>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 0, 0, 0, 110, 0, 0, 22,
		1, 0, 0, 110, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		84, 106, 103, 100, 141, 110, 116, 105, 105, 100,
		233, 60, 238, 71, 156
	})]
	private ConversionCategory(string P_0, int P_1, string P_2, params Class[] P_3)
		: base(P_0, P_1)
	{
		___003C_003Echars = P_2;
		if (P_3 == null)
		{
			___003C_003Etypes = P_3;
		}
		else
		{
			ArrayList.___003Cclinit_003E();
			ArrayList arrayList = new ArrayList(P_3.Length);
			int num = P_3.Length;
			int num2 = 0;
			while (num2 < num)
			{
				Class @class = P_3[num2];
				((List)arrayList).add((object)@class);
				Class class2 = unwrapPrimitive(@class);
				if (class2 != null)
				{
					((List)arrayList).add((object)class2);
				}
				num2++;
				GC.KeepAlive(this);
			}
			___003C_003Etypes = (Class[])((List)arrayList).toArray((object[])new Class[((List)arrayList).size()]);
		}
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	public static ConversionCategory[] values()
	{
		return (ConversionCategory[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	public static ConversionCategory valueOf(string name)
	{
		return (ConversionCategory)java.lang.Enum.valueOf(ClassLiteral<ConversionCategory>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 93, 130, 127, 30, 127, 7, 3, 230, 69 })]
	public static ConversionCategory fromConversionChar(char c)
	{
		ConversionCategory[] array = new ConversionCategory[5] { ___003C_003EGENERAL, ___003C_003ECHAR, ___003C_003EINT, ___003C_003EFLOAT, ___003C_003ETIME };
		int num = array.Length;
		CharSequence s = default(CharSequence);
		for (int i = 0; i < num; i++)
		{
			ConversionCategory conversionCategory = array[i];
			string __003C_003Echars = conversionCategory.___003C_003Echars;
			object obj = (s.___003Cref_003E = java.lang.String.valueOf(c));
			if (java.lang.String.instancehelper_contains(__003C_003Echars, s))
			{
				return conversionCategory;
			}
		}
		string s2 = new StringBuilder().append("Bad conversion character ").append(c).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(211)]
	public static bool isSubsetOf(ConversionCategory a, ConversionCategory b)
	{
		return intersect(a, b) == a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 167, 112, 134, 112, 134, 223, 1, 230, 70,
		204, 108, 136, 223, 49, 110, 106, 227, 58, 232,
		74
	})]
	public static ConversionCategory union(ConversionCategory a, ConversionCategory b)
	{
		if (a == ___003C_003EUNUSED || b == ___003C_003EUNUSED)
		{
			return ___003C_003EUNUSED;
		}
		if (a == ___003C_003EGENERAL || b == ___003C_003EGENERAL)
		{
			return ___003C_003EGENERAL;
		}
		if ((a == ___003C_003ECHAR_AND_INT && b == ___003C_003EINT_AND_TIME) || (a == ___003C_003EINT_AND_TIME && b == ___003C_003ECHAR_AND_INT))
		{
			return ___003C_003EINT;
		}
		Set set = arrayToSet(a.___003C_003Etypes);
		Set c = arrayToSet(b.___003C_003Etypes);
		set.addAll(c);
		ConversionCategory[] array = new ConversionCategory[7] { ___003C_003ENULL, ___003C_003ECHAR_AND_INT, ___003C_003EINT_AND_TIME, ___003C_003ECHAR, ___003C_003EINT, ___003C_003EFLOAT, ___003C_003ETIME };
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			ConversionCategory conversionCategory = array[i];
			Set set2 = arrayToSet(conversionCategory.___003C_003Etypes);
			if (set2.equals(set))
			{
				return conversionCategory;
			}
		}
		return ___003C_003EGENERAL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 210, 104, 130, 104, 130, 116, 105, 2, 230,
		69
	})]
	public virtual bool isAssignableFrom(Class argType)
	{
		if (___003C_003Etypes == null)
		{
			return true;
		}
		if (argType == java.lang.Void.TYPE)
		{
			return true;
		}
		Class[] __003C_003Etypes = ___003C_003Etypes;
		int num = __003C_003Etypes.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = __003C_003Etypes[i];
			if (@class.isAssignableFrom(argType))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 228, 102, 109, 140, 113, 169, 127, 43, 125,
		63, 0, 168, 108, 137
	})]
	[Pure(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/dataflow/qual/Pure;"
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(name());
		stringBuilder.append(" conversion category");
		if (___003C_003Etypes == null || ___003C_003Etypes.Length == 0)
		{
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
		object __003Cref_003E = ")";
		object __003Cref_003E2 = "(one of: ";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = ", ");
		CharSequence delimiter = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E2);
		CharSequence prefix = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		StringJoiner stringJoiner = new StringJoiner(delimiter, prefix, charSequence);
		Class[] __003C_003Etypes = ___003C_003Etypes;
		int num = __003C_003Etypes.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = __003C_003Etypes[i];
			obj = (charSequence.___003Cref_003E = @class.getSimpleName());
			stringJoiner.add(charSequence);
		}
		stringBuilder.append(" ");
		stringBuilder.append(stringJoiner);
		string result2 = stringBuilder.toString();
		_ = null;
		return result2;
	}

	[LineNumberTable(new byte[]
	{
		159,
		182,
		251,
		71,
		byte.MaxValue,
		28,
		70,
		byte.MaxValue,
		36,
		70,
		byte.MaxValue,
		20,
		70,
		byte.MaxValue,
		20,
		87,
		byte.MaxValue,
		16,
		71,
		byte.MaxValue,
		0,
		76,
		247,
		76,
		247,
		159,
		173
	})]
	static ConversionCategory()
	{
		___003C_003EGENERAL = new ConversionCategory("GENERAL", 0, "bBhHsS", (Class[])null);
		___003C_003ECHAR = new ConversionCategory("CHAR", 1, "cC", ClassLiteral<Character>.Value, ClassLiteral<java.lang.Byte>.Value, ClassLiteral<Short>.Value, ClassLiteral<Integer>.Value);
		___003C_003EINT = new ConversionCategory("INT", 2, "doxX", ClassLiteral<java.lang.Byte>.Value, ClassLiteral<Short>.Value, ClassLiteral<Integer>.Value, ClassLiteral<Long>.Value, ClassLiteral<BigInteger>.Value);
		___003C_003EFLOAT = new ConversionCategory("FLOAT", 3, "eEfgGaA", ClassLiteral<Float>.Value, ClassLiteral<java.lang.Double>.Value, ClassLiteral<BigDecimal>.Value);
		___003C_003ETIME = new ConversionCategory("TIME", 4, "tT", ClassLiteral<Long>.Value, ClassLiteral<Calendar>.Value, ClassLiteral<Date>.Value);
		___003C_003ECHAR_AND_INT = new ConversionCategory("CHAR_AND_INT", 5, null, ClassLiteral<java.lang.Byte>.Value, ClassLiteral<Short>.Value, ClassLiteral<Integer>.Value);
		___003C_003EINT_AND_TIME = new ConversionCategory("INT_AND_TIME", 6, null, ClassLiteral<Long>.Value);
		___003C_003ENULL = new ConversionCategory("NULL", 7, null);
		___003C_003EUNUSED = new ConversionCategory("UNUSED", 8, (string)null, (Class[])null);
		_0024VALUES = new ConversionCategory[9] { ___003C_003EGENERAL, ___003C_003ECHAR, ___003C_003EINT, ___003C_003EFLOAT, ___003C_003ETIME, ___003C_003ECHAR_AND_INT, ___003C_003EINT_AND_TIME, ___003C_003ENULL, ___003C_003EUNUSED };
	}
}
