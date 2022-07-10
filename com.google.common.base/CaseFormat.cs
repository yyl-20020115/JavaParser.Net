using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/base/CaseFormat;>;")]
[Modifiers(Modifiers.Public | Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public abstract class CaseFormat : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		LOWER_HYPHEN,
		LOWER_UNDERSCORE,
		LOWER_CAMEL,
		UPPER_CAMEL,
		UPPER_UNDERSCORE
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _1 : CaseFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(35)]
		internal _1(string P_0, int P_1, CharMatcher P_2, string P_3)
			: base(P_0, P_1, P_2, P_3, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(38)]
		internal override string normalizeWord(string P_0)
		{
			string result = Ascii.toLowerCase(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 185, 104, 141, 104, 146 })]
		internal override string convert(CaseFormat P_0, string P_1)
		{
			if (P_0 == ___003C_003ELOWER_UNDERSCORE)
			{
				string result = java.lang.String.instancehelper_replace(P_1, '-', '_');
				_ = null;
				return result;
			}
			if (P_0 == ___003C_003EUPPER_UNDERSCORE)
			{
				string result2 = Ascii.toUpperCase(java.lang.String.instancehelper_replace(P_1, '-', '_'));
				_ = null;
				return result2;
			}
			string result3 = base.convert(P_0, P_1);
			_ = null;
			return result3;
		}

		[HideFromJava]
		static _1()
		{
			CaseFormat.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _2 : CaseFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(54)]
		internal _2(string P_0, int P_1, CharMatcher P_2, string P_3)
			: base(P_0, P_1, P_2, P_3, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(57)]
		internal override string normalizeWord(string P_0)
		{
			string result = Ascii.toLowerCase(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 104, 141, 104, 137 })]
		internal override string convert(CaseFormat P_0, string P_1)
		{
			if (P_0 == ___003C_003ELOWER_HYPHEN)
			{
				string result = java.lang.String.instancehelper_replace(P_1, '_', '-');
				_ = null;
				return result;
			}
			if (P_0 == ___003C_003EUPPER_UNDERSCORE)
			{
				string result2 = Ascii.toUpperCase(P_1);
				_ = null;
				return result2;
			}
			string result3 = base.convert(P_0, P_1);
			_ = null;
			return result3;
		}

		[HideFromJava]
		static _2()
		{
			CaseFormat.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _3 : CaseFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		internal _3(string P_0, int P_1, CharMatcher P_2, string P_3)
			: base(P_0, P_1, P_2, P_3, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(76)]
		internal override string normalizeWord(string P_0)
		{
			string result = access_0024100(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(81)]
		internal override string normalizeFirstWord(string P_0)
		{
			string result = Ascii.toLowerCase(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static _3()
		{
			CaseFormat.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _4 : CaseFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(86)]
		internal _4(string P_0, int P_1, CharMatcher P_2, string P_3)
			: base(P_0, P_1, P_2, P_3, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(89)]
		internal override string normalizeWord(string P_0)
		{
			string result = access_0024100(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static _4()
		{
			CaseFormat.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _5 : CaseFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(94)]
		internal _5(string P_0, int P_1, CharMatcher P_2, string P_3)
			: base(P_0, P_1, P_2, P_3, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(97)]
		internal override string normalizeWord(string P_0)
		{
			string result = Ascii.toUpperCase(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 52, 104, 146, 104, 137 })]
		internal override string convert(CaseFormat P_0, string P_1)
		{
			if (P_0 == ___003C_003ELOWER_HYPHEN)
			{
				string result = Ascii.toLowerCase(java.lang.String.instancehelper_replace(P_1, '_', '-'));
				_ = null;
				return result;
			}
			if (P_0 == ___003C_003ELOWER_UNDERSCORE)
			{
				string result2 = Ascii.toLowerCase(P_1);
				_ = null;
				return result2;
			}
			string result3 = base.convert(P_0, P_1);
			_ = null;
			return result3;
		}

		[HideFromJava]
		static _5()
		{
			CaseFormat.___003Cclinit_003E();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/String;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class StringConverter : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private CaseFormat sourceFormat;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private CaseFormat targetFormat;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 118, 104, 113, 113 })]
		internal StringConverter(CaseFormat P_0, CaseFormat P_1)
		{
			sourceFormat = (CaseFormat)Preconditions.checkNotNull(P_0);
			targetFormat = (CaseFormat)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(180)]
		protected internal virtual string doBackward(string P_0)
		{
			string result = targetFormat.to(sourceFormat, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		protected internal virtual string doForward(string P_0)
		{
			string result = sourceFormat.to(targetFormat, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 71, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is StringConverter)
			{
				StringConverter stringConverter = (StringConverter)P_0;
				return (sourceFormat.equals(stringConverter.sourceFormat) && targetFormat.equals(stringConverter.targetFormat)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(194)]
		public override int hashCode()
		{
			return sourceFormat.hashCode() ^ targetFormat.hashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(199)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(sourceFormat);
			string text2 = java.lang.String.valueOf(targetFormat);
			int num = 14 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".converterTo(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(162)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((string)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(162)]
		protected internal override object doForward(object P_0)
		{
			string result = doForward((string)P_0);
			_ = null;
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
		protected StringConverter(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static CaseFormat ___003C_003ELOWER_HYPHEN;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static CaseFormat ___003C_003ELOWER_UNDERSCORE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static CaseFormat ___003C_003ELOWER_CAMEL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static CaseFormat ___003C_003EUPPER_CAMEL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static CaseFormat ___003C_003EUPPER_UNDERSCORE;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CharMatcher wordBoundary;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string wordSeparator;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static CaseFormat[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static CaseFormat LOWER_HYPHEN
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELOWER_HYPHEN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static CaseFormat LOWER_UNDERSCORE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELOWER_UNDERSCORE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static CaseFormat LOWER_CAMEL
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELOWER_CAMEL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static CaseFormat UPPER_CAMEL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUPPER_CAMEL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static CaseFormat UPPER_UNDERSCORE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUPPER_UNDERSCORE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 98, 104, 99, 31, 36 })]
	private static string firstCharOnlyToUpper(string P_0)
	{
		string result;
		if (java.lang.String.instancehelper_isEmpty(P_0))
		{
			result = P_0;
		}
		else
		{
			int c = Ascii.toUpperCase(java.lang.String.instancehelper_charAt(P_0, 0));
			string text = Ascii.toLowerCase(java.lang.String.instancehelper_substring(P_0, 1));
			int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			result = new StringBuilder(num).append((char)c).append(text).toString();
		}
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/CharMatcher;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 65, 106, 103, 104 })]
	private CaseFormat(string P_0, int P_1, CharMatcher P_2, string P_3)
		: base(P_0, P_1)
	{
		wordBoundary = P_2;
		wordSeparator = P_3;
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		84, 98, 98, 98, 127, 14, 131, 122, 151, 159,
		0, 109, 147, 99, 105, 31, 5
	})]
	internal virtual string convert(CaseFormat P_0, string P_1)
	{
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = -1;
		CharSequence sequence = default(CharSequence);
		while (true)
		{
			CharMatcher charMatcher = wordBoundary;
			num2++;
			int start = num2;
			object obj = (sequence.___003Cref_003E = P_1);
			if ((num2 = charMatcher.indexIn(sequence, start)) == -1)
			{
				break;
			}
			if (num == 0)
			{
				stringBuilder = new StringBuilder(java.lang.String.instancehelper_length(P_1) + 4 * java.lang.String.instancehelper_length(P_0.wordSeparator));
				stringBuilder.append(P_0.normalizeFirstWord(java.lang.String.instancehelper_substring(P_1, num, num2)));
			}
			else
			{
				((StringBuilder)java.util.Objects.requireNonNull(stringBuilder)).append(P_0.normalizeWord(java.lang.String.instancehelper_substring(P_1, num, num2)));
			}
			stringBuilder.append(P_0.wordSeparator);
			num = num2 + java.lang.String.instancehelper_length(wordSeparator);
		}
		string result = ((num != 0) ? ((StringBuilder)java.util.Objects.requireNonNull(stringBuilder)).append(P_0.normalizeWord(java.lang.String.instancehelper_substring(P_1, num))).toString() : P_0.normalizeFirstWord(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(208)]
	internal virtual string normalizeFirstWord(string P_0)
	{
		string result = normalizeWord(P_0);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual string normalizeWord(string P_0)
	{
		throw new AbstractMethodError("com.google.common.base.CaseFormat.normalizeWord(Ljava.lang.String;)Ljava.lang.String;");
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	private static CaseFormat[] _0024values()
	{
		return new CaseFormat[5] { ___003C_003ELOWER_HYPHEN, ___003C_003ELOWER_UNDERSCORE, ___003C_003ELOWER_CAMEL, ___003C_003EUPPER_CAMEL, ___003C_003EUPPER_UNDERSCORE };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public static CaseFormat[] values()
	{
		return (CaseFormat[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public static CaseFormat valueOf(string name)
	{
		return (CaseFormat)java.lang.Enum.valueOf(ClassLiteral<CaseFormat>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 76, 103, 103 })]
	public string to(CaseFormat format, string str)
	{
		Preconditions.checkNotNull(format);
		Preconditions.checkNotNull(str);
		string result = ((format != this) ? convert(format, str) : str);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/CaseFormat;)Lcom/google/common/base/Converter<Ljava/lang/String;Ljava/lang/String;>;")]
	[LineNumberTable(159)]
	public virtual Converter converterTo(CaseFormat targetFormat)
	{
		StringConverter result = new StringConverter(this, targetFormat);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(33)]
	internal CaseFormat(string P_0, int P_1, CharMatcher P_2, string P_3, _1 P_4)
		: this(P_0, P_1, P_2, P_3)
	{
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	internal static string access_0024100(string P_0)
	{
		string result = firstCharOnlyToUpper(P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159,
		177,
		byte.MaxValue,
		2,
		83,
		byte.MaxValue,
		2,
		83,
		byte.MaxValue,
		4,
		77,
		byte.MaxValue,
		4,
		72,
		byte.MaxValue,
		2,
		1
	})]
	static CaseFormat()
	{
		_1.___003Cclinit_003E();
		___003C_003ELOWER_HYPHEN = new _1("LOWER_HYPHEN", 0, CharMatcher.@is('-'), "-");
		_2.___003Cclinit_003E();
		___003C_003ELOWER_UNDERSCORE = new _2("LOWER_UNDERSCORE", 1, CharMatcher.@is('_'), "_");
		_3.___003Cclinit_003E();
		___003C_003ELOWER_CAMEL = new _3("LOWER_CAMEL", 2, CharMatcher.inRange('A', 'Z'), "");
		_4.___003Cclinit_003E();
		___003C_003EUPPER_CAMEL = new _4("UPPER_CAMEL", 3, CharMatcher.inRange('A', 'Z'), "");
		_5.___003Cclinit_003E();
		___003C_003EUPPER_UNDERSCORE = new _5("UPPER_UNDERSCORE", 4, CharMatcher.@is('_'), "_");
		_0024VALUES = _0024values();
	}
}
