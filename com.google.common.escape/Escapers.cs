using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.escape;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public sealed class Escapers : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _1 : CharEscaper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(48)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(51)]
		public override string escape(string P_0)
		{
			return (string)Preconditions.checkNotNull(P_0);
		}

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override char[] escape(char P_0)
		{
			return null;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "wrap", "(Lcom.google.common.escape.CharEscaper;)Lcom.google.common.escape.UnicodeEscaper;")]
	internal class _2 : UnicodeEscaper
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharEscaper val_0024escaper;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(229)]
		internal _2(CharEscaper P_0)
		{
			val_0024escaper = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 120, 104, 240, 70, 103, 105, 111, 239, 70,
			134, 162, 105, 106, 107, 131, 105, 41, 202, 135,
			99, 105, 43, 202, 135
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override char[] escape(int P_0)
		{
			if (P_0 < 65536)
			{
				char[] result = val_0024escaper.escape((char)P_0);
				_ = null;
				return result;
			}
			char[] array = new char[2];
			Character.toChars(P_0, array, 0);
			char[] array2 = val_0024escaper.escape(array[0]);
			char[] array3 = val_0024escaper.escape(array[1]);
			if (array2 == null && array3 == null)
			{
				return null;
			}
			int num = (int)((array2 == null) ? 1 : array2.LongLength);
			int num2 = (int)((array3 == null) ? 1 : array3.LongLength);
			char[] array4 = new char[num + num2];
			if (array2 != null)
			{
				for (int i = 0; i < (nint)array2.LongLength; i++)
				{
					array4[i] = array2[i];
				}
			}
			else
			{
				array4[0] = array[0];
			}
			if (array3 != null)
			{
				for (int i = 0; i < (nint)array3.LongLength; i++)
				{
					array4[num + i] = array3[i];
				}
			}
			else
			{
				array4[num] = array[1];
			}
			return array4;
		}
	}

	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Builder : Object
	{
		[SpecialName]
		[EnclosingMethod(null, "build", "()Lcom.google.common.escape.Escaper;")]
		internal class _1 : ArrayBasedCharEscaper
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			private char[] replacementChars;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Builder this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 159, 104, 101, 114, 129, 31, 6 })]
			internal _1(Builder P_0, Map P_1, char P_2, char P_3)
			{
				this_00240 = P_0;
				base._002Ector(P_1, P_2, P_3);
				replacementChars = ((access_0024100(this_00240) == null) ? null : String.instancehelper_toCharArray(access_0024100(this_00240)));
			}

			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override char[] escapeUnsafe(char P_0)
			{
				return replacementChars;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;")]
		private Map replacementMap;

		private char safeMin;

		private char safeMax;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private string unsafeReplacement;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(94)]
		internal Builder(Escapers._1 P_0)
			: this()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(94)]
		internal static string access_0024100(Builder P_0)
		{
			return P_0.unsafeReplacement;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 51, 232, 58, 107, 103, 107, 167 })]
		private Builder()
		{
			replacementMap = new HashMap();
			safeMin = '\0';
			safeMax = '\uffff';
			unsafeReplacement = null;
		}

		public virtual Builder setSafeRange(char safeMin, char safeMax)
		{
			this.safeMin = safeMin;
			this.safeMax = safeMax;
			return this;
		}

		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 45, 0, 0 })]
		public virtual Builder setUnsafeReplacement(string unsafeReplacement)
		{
			this.unsafeReplacement = unsafeReplacement;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 106, 98, 135, 115 })]
		public virtual Builder addEscape(char c, string replacement)
		{
			Preconditions.checkNotNull(replacement);
			replacementMap.put(Character.valueOf(c), replacement);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		public virtual Escaper build()
		{
			_1 result = new _1(this, replacementMap, safeMin, safeMax);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper NULL_ESCAPER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(229)]
	private static UnicodeEscaper wrap(CharEscaper P_0)
	{
		_2 result = new _2(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(224)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static string stringOrNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] char[] P_0)
	{
		string result = ((P_0 != null) ? String.newhelper(P_0) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	private Escapers()
	{
	}

	public static Escaper nullEscaper()
	{
		return NULL_ESCAPER;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(80)]
	public static Builder builder()
	{
		Builder result = new Builder(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 68, 103, 104, 103, 104, 206, 102 })]
	internal static UnicodeEscaper asUnicodeEscaper(Escaper P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (P_0 is UnicodeEscaper)
		{
			return (UnicodeEscaper)P_0;
		}
		if (P_0 is CharEscaper)
		{
			UnicodeEscaper result = wrap((CharEscaper)P_0);
			_ = null;
			return result;
		}
		string text = String.valueOf(Object.instancehelper_getClass(P_0).getName());
		string s;
		if (String.instancehelper_length(text) != 0)
		{
			s = String.instancehelper_concat("Cannot create a UnicodeEscaper from: ", text);
		}
		else
		{
			string text2 = "Cannot create a UnicodeEscaper from: ";
			text2 = text2;
			s = String.newhelper(text2);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(205)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static string computeReplacement(CharEscaper escaper, char c)
	{
		string result = stringOrNull(escaper.escape(c));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(219)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static string computeReplacement(UnicodeEscaper escaper, int cp)
	{
		string result = stringOrNull(escaper.escape(cp));
		_ = null;
		return result;
	}

	[LineNumberTable(47)]
	static Escapers()
	{
		NULL_ESCAPER = new _1();
	}
}
