using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace org.checkerframework.checker.i18nformatter.qual;

[Serializable]
[Signature("Ljava/lang/Enum<Lorg/checkerframework/checker/i18nformatter/qual/I18nConversionCategory;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ConstantPool(new object[]
{
	(byte)69,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
public sealed class I18nConversionCategory : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		UNUSED,
		GENERAL,
		DATE,
		NUMBER
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static I18nConversionCategory ___003C_003EUNUSED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static I18nConversionCategory ___003C_003EGENERAL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static I18nConversionCategory ___003C_003EDATE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static I18nConversionCategory ___003C_003ENUMBER;

	[Signature("[Ljava/lang/Class<*>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 69, 0, 0 })]
	internal Class[] ___003C_003Etypes;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 69, 0, 0 })]
	internal string[] ___003C_003Estrings;

	internal static I18nConversionCategory[] namedCategories;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static I18nConversionCategory[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static I18nConversionCategory UNUSED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUNUSED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static I18nConversionCategory GENERAL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EGENERAL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static I18nConversionCategory DATE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDATE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static I18nConversionCategory NUMBER
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENUMBER;
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
	public string[] strings
	{
		[HideFromJava]
		get
		{
			return ___003C_003Estrings;
		}
		[HideFromJava]
		private set
		{
			___003C_003Estrings = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		68, 104, 130, 104, 130, 104, 130, 104, 226, 70,
		204, 108, 104, 191, 9, 110, 106, 227, 59, 232,
		72
	})]
	public static I18nConversionCategory intersect(I18nConversionCategory a, I18nConversionCategory b)
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
		I18nConversionCategory[] array = new I18nConversionCategory[2] { ___003C_003EDATE, ___003C_003ENUMBER };
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			I18nConversionCategory i18nConversionCategory = array[i];
			Set set2 = arrayToSet(i18nConversionCategory.___003C_003Etypes);
			if (set2.equals(set))
			{
				return i18nConversionCategory;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(93)]
	private static Set arrayToSet(object[] P_0)
	{
		HashSet.___003Cclinit_003E();
		HashSet result = new HashSet(Arrays.asList(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/lang/Class<*>;[Ljava/lang/String;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 0, 0, 0, 69, 0, 0, 22,
		1, 0, 0, 69, 0, 0
	})]
	[LineNumberTable(new byte[] { 11, 106, 103, 104 })]
	private I18nConversionCategory(string P_0, int P_1, Class[] P_2, string[] P_3)
		: base(P_0, P_1)
	{
		___003C_003Etypes = P_2;
		___003C_003Estrings = P_3;
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	public static I18nConversionCategory[] values()
	{
		return (I18nConversionCategory[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	public static I18nConversionCategory valueOf(string name)
	{
		return (I18nConversionCategory)java.lang.Enum.valueOf(ClassLiteral<I18nConversionCategory>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 104, 115, 125, 106, 2, 40, 230, 71 })]
	public static I18nConversionCategory stringToI18nConversionCategory(string @string)
	{
		@string = java.lang.String.instancehelper_toLowerCase(@string);
		I18nConversionCategory[] array = namedCategories;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			I18nConversionCategory i18nConversionCategory = array[i];
			string[] __003C_003Estrings = i18nConversionCategory.___003C_003Estrings;
			int num2 = __003C_003Estrings.Length;
			for (int j = 0; j < num2; j++)
			{
				string @this = __003C_003Estrings[j];
				if (java.lang.String.instancehelper_equals(@this, @string))
				{
					return i18nConversionCategory;
				}
			}
		}
		string s = new StringBuilder().append("Invalid format type ").append(@string).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(102)]
	public static bool isSubsetOf(I18nConversionCategory a, I18nConversionCategory b)
	{
		return intersect(a, b) == a;
	}

	public static I18nConversionCategory union(I18nConversionCategory a, I18nConversionCategory b)
	{
		if (a == ___003C_003EUNUSED || b == ___003C_003EUNUSED)
		{
			return ___003C_003EUNUSED;
		}
		if (a == ___003C_003EGENERAL || b == ___003C_003EGENERAL)
		{
			return ___003C_003EGENERAL;
		}
		if (a == ___003C_003EDATE || b == ___003C_003EDATE)
		{
			return ___003C_003EDATE;
		}
		return ___003C_003ENUMBER;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 64, 104, 130, 104, 130, 116, 105, 2, 230,
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
		160, 81, 108, 104, 145, 127, 43, 125, 63, 0,
		168, 137
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder(name());
		if (___003C_003Etypes == null)
		{
			stringBuilder.append(" conversion category (all types)");
		}
		else
		{
			object __003Cref_003E = ")";
			object __003Cref_003E2 = " conversion category (one of: ";
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
				obj = (charSequence.___003Cref_003E = @class.getCanonicalName());
				stringJoiner.add(charSequence);
			}
			stringBuilder.append(stringJoiner);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159,
		178,
		178,
		178,
		byte.MaxValue,
		29,
		75,
		byte.MaxValue,
		21,
		35,
		byte.MaxValue,
		12,
		107
	})]
	static I18nConversionCategory()
	{
		___003C_003EUNUSED = new I18nConversionCategory("UNUSED", 0, null, null);
		___003C_003EGENERAL = new I18nConversionCategory("GENERAL", 1, null, null);
		___003C_003EDATE = new I18nConversionCategory("DATE", 2, new Class[2]
		{
			ClassLiteral<Date>.Value,
			ClassLiteral<Number>.Value
		}, new string[2] { "date", "time" });
		___003C_003ENUMBER = new I18nConversionCategory("NUMBER", 3, new Class[1] { ClassLiteral<Number>.Value }, new string[2] { "number", "choice" });
		_0024VALUES = new I18nConversionCategory[4] { ___003C_003EUNUSED, ___003C_003EGENERAL, ___003C_003EDATE, ___003C_003ENUMBER };
		namedCategories = new I18nConversionCategory[2] { ___003C_003EDATE, ___003C_003ENUMBER };
	}
}
