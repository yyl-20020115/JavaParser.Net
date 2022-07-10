using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.utils;

[Serializable]

public class LineSeparator : java.lang.Enum
{
	[Serializable]
	
	public enum __Enum
	{
		CR,
		LF,
		CRLF,
		SYSTEM,
		ARBITRARY,
		MIXED,
		UNKNOWN,
		NONE
	}

	
	internal static LineSeparator ___003C_003ECR;

	
	internal static LineSeparator ___003C_003ELF;

	
	internal static LineSeparator ___003C_003ECRLF;

	
	internal static LineSeparator ___003C_003ESYSTEM;

	
	internal static LineSeparator ___003C_003EARBITRARY;

	
	internal static LineSeparator ___003C_003EMIXED;

	
	internal static LineSeparator ___003C_003EUNKNOWN;

	
	internal static LineSeparator ___003C_003ENONE;

	
	private string text;

	
	private string description;

	
	private static LineSeparator[] _0024VALUES;

	
	public static LineSeparator CR
	{
		
		get
		{
			return ___003C_003ECR;
		}
	}

	
	public static LineSeparator LF
	{
		
		get
		{
			return ___003C_003ELF;
		}
	}

	
	public static LineSeparator CRLF
	{
		
		get
		{
			return ___003C_003ECRLF;
		}
	}

	
	public static LineSeparator SYSTEM
	{
		
		get
		{
			return ___003C_003ESYSTEM;
		}
	}

	
	public static LineSeparator ARBITRARY
	{
		
		get
		{
			return ___003C_003EARBITRARY;
		}
	}

	
	public static LineSeparator MIXED
	{
		
		get
		{
			return ___003C_003EMIXED;
		}
	}

	
	public static LineSeparator UNKNOWN
	{
		
		get
		{
			return ___003C_003EUNKNOWN;
		}
	}

	
	public static LineSeparator NONE
	{
		
		get
		{
			return ___003C_003ENONE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public virtual string asRawString()
	{
		return text;
	}

	
	
	public virtual bool isStandardEol()
	{
		return (equalsString(___003C_003ECR) || equalsString(___003C_003ELF) || equalsString(___003C_003ECRLF)) ? true : false;
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public static LineSeparator getLineEnding(int countCr, int countLf, int countCrLf)
	{
		if ((countCr == 0 && countLf == 0 && countCrLf == 0) ? true : false)
		{
			return ___003C_003ENONE;
		}
		if ((countCr > 0 && countLf == 0 && countCrLf == 0) ? true : false)
		{
			return ___003C_003ECR;
		}
		if ((countCr == 0 && countLf > 0 && countCrLf == 0) ? true : false)
		{
			return ___003C_003ELF;
		}
		if ((countCr == countLf && countLf == countCrLf) ? true : false)
		{
			return ___003C_003ECRLF;
		}
		return ___003C_003EMIXED;
	}

	
		
	
	public static Optional lookup(string ending)
	{
		if (java.lang.String.instancehelper_equals(___003C_003ECR.asRawString(), ending))
		{
			Optional result = Optional.of(___003C_003ECR);
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(___003C_003ELF.asRawString(), ending))
		{
			Optional result2 = Optional.of(___003C_003ELF);
			
			return result2;
		}
		if (java.lang.String.instancehelper_equals(___003C_003ECRLF.asRawString(), ending))
		{
			Optional result3 = Optional.of(___003C_003ECRLF);
			
			return result3;
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	
		
	
	public static Optional lookupEscaped(string ending)
	{
		if (java.lang.String.instancehelper_equals(___003C_003ECR.asEscapedString(), ending))
		{
			Optional result = Optional.of(___003C_003ECR);
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(___003C_003ELF.asEscapedString(), ending))
		{
			Optional result2 = Optional.of(___003C_003ELF);
			
			return result2;
		}
		if (java.lang.String.instancehelper_equals(___003C_003ECRLF.asEscapedString(), ending))
		{
			Optional result3 = Optional.of(___003C_003ECRLF);
			
			return result3;
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	
	
	
	public virtual bool equalsString(LineSeparator lineSeparator)
	{
		bool result = java.lang.String.instancehelper_equals(text, lineSeparator.asRawString());
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static int count(string haystack, string needle)
	{
		int num = java.lang.String.instancehelper_length(haystack) - java.lang.String.instancehelper_length(java.lang.String.instancehelper_replaceAll(haystack, needle, ""));
		int num2 = java.lang.String.instancehelper_length(needle);
		return (num2 != -1) ? (num / num2) : (-num);
	}

	
	
	public virtual string asEscapedString()
	{
		string @this = text;
		object __003Cref_003E = "\\r";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "\r");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string this2 = java.lang.String.instancehelper_replace(@this, target, charSequence);
		obj = "\\n";
		__003Cref_003E = (charSequence.___003Cref_003E = "\n");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		return java.lang.String.instancehelper_replace(this2, target2, charSequence);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private LineSeparator(string _0024enum_0024name, int _0024enum_0024ordinal, string text, string description)
		: base(_0024enum_0024name, _0024enum_0024ordinal)
	{
		this.text = text;
		this.description = description;
		GC.KeepAlive(this);
	}

	
	
	public static LineSeparator[] values()
	{
		return (LineSeparator[])_0024VALUES.Clone();
	}

	
	
	
	public static LineSeparator valueOf(string name)
	{
		return (LineSeparator)java.lang.Enum.valueOf(ClassLiteral<LineSeparator>.Value, name);
	}

	
	
	
	public static LineSeparator detect(string @string)
	{
		int countCr = count(@string, "\r");
		int countLf = count(@string, "\n");
		int countCrLf = count(@string, "\r\n");
		LineSeparator lineEnding = getLineEnding(countCr, countLf, countCrLf);
		
		return lineEnding;
	}

	public virtual string describe()
	{
		return description;
	}

	
		
	private Optional asJavaTokenKind()
	{
		if (this == ___003C_003ECR)
		{
			Optional result = Optional.of(JavaToken.Kind.___003C_003EOLD_MAC_EOL);
			
			return result;
		}
		if (this == ___003C_003ELF)
		{
			Optional result2 = Optional.of(JavaToken.Kind.___003C_003EUNIX_EOL);
			
			return result2;
		}
		if (this == ___003C_003ECRLF)
		{
			Optional result3 = Optional.of(JavaToken.Kind.___003C_003EWINDOWS_EOL);
			
			return result3;
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	
	
	public override string ToString()
	{
		string result = asRawString();
		
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159,
		161,
		218,
		218,
		218,
		107,
		121,
		111,
		127,
		18,
		byte.MaxValue,
		38,
		71,
		250,
		69,
		250,
		69,
		218,
		250,
		23
	})]
	static LineSeparator()
	{
		___003C_003ECR = new LineSeparator("CR", 0, "\r", "CR (\\r)");
		___003C_003ELF = new LineSeparator("LF", 1, "\n", "LF (\\n)");
		___003C_003ECRLF = new LineSeparator("CRLF", 2, "\r\n", "CRLF (\\r\\n)");
		string property = java.lang.System.getProperty("line.separator");
		StringBuilder stringBuilder = new StringBuilder().append("SYSTEM : (");
		string property2 = java.lang.System.getProperty("line.separator");
		object __003Cref_003E = "\\r";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "\r");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string @this = java.lang.String.instancehelper_replace(property2, target, charSequence);
		obj = "\\n";
		__003Cref_003E = (charSequence.___003Cref_003E = "\n");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		___003C_003ESYSTEM = new LineSeparator("SYSTEM", 3, property, stringBuilder.append(java.lang.String.instancehelper_replace(@this, target2, charSequence)).append(")").ToString());
		___003C_003EARBITRARY = new LineSeparator("ARBITRARY", 4, "\n", "ARBITRARY (\\n)");
		___003C_003EMIXED = new LineSeparator("MIXED", 5, "", "MIXED");
		___003C_003EUNKNOWN = new LineSeparator("UNKNOWN", 6, "", "UNKNOWN");
		___003C_003ENONE = new LineSeparator("NONE", 7, "", "NONE");
		_0024VALUES = new LineSeparator[8] { ___003C_003ECR, ___003C_003ELF, ___003C_003ECRLF, ___003C_003ESYSTEM, ___003C_003EARBITRARY, ___003C_003EMIXED, ___003C_003EUNKNOWN, ___003C_003ENONE };
	}
}
