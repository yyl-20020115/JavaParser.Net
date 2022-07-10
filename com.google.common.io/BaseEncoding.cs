using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.math;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public abstract class BaseEncoding : java.lang.Object
{
	[SpecialName]
	[EnclosingMethod(null, "encodingSink", "(Lcom.google.common.io.CharSink;)Lcom.google.common.io.ByteSink;")]
	internal class _1 : ByteSink
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharSink val_0024encodedSink;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal BaseEncoding this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(181)]
		internal _1(BaseEncoding P_0, CharSink P_1)
		{
			this_00240 = P_0;
			val_0024encodedSink = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(184)]
		public override OutputStream openStream()
		{
			OutputStream result = this_00240.encodingStream(val_0024encodedSink.openStream());
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "decodingSource", "(Lcom.google.common.io.CharSource;)Lcom.google.common.io.ByteSource;")]
	internal class _2 : ByteSource
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharSource val_0024encodedSource;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal BaseEncoding this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(252)]
		internal _2(BaseEncoding P_0, CharSource P_1)
		{
			this_00240 = P_0;
			val_0024encodedSource = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(255)]
		public override InputStream openStream()
		{
			InputStream result = this_00240.decodingStream(val_0024encodedSource.openStream());
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "ignoringReader", "(Ljava.io.Reader;Ljava.lang.String;)Ljava.io.Reader;")]
	internal class _3 : Reader
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Reader val_0024delegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024toIgnore;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(998)]
		internal _3(Reader P_0, string P_1)
		{
			val_0024delegate = P_0;
			val_0024toIgnore = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 121, 108, 116 })]
		public override int read()
		{
			int num;
			do
			{
				num = val_0024delegate.read();
			}
			while (num != -1 && java.lang.String.instancehelper_indexOf(val_0024toIgnore, (ushort)num) >= 0);
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(1010)]
		public override int read(char[] P_0, int P_1, int P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 133, 109 })]
		public override void close()
		{
			val_0024delegate.close();
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "separatingAppendable", "(Ljava.lang.Appendable;Ljava.lang.String;I)Ljava.lang.Appendable;")]
	internal class _4 : java.lang.Object, Appendable
	{
		internal int charsUntilSeparator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024afterEveryChars;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Appendable val_0024delegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024separator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 143, 125 })]
		internal _4(int P_0, Appendable P_1, string P_2)
		{
			val_0024afterEveryChars = P_0;
			val_0024delegate = P_1;
			val_0024separator = P_2;
			base._002Ector();
			charsUntilSeparator = val_0024afterEveryChars;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 158, 141, 130, 104, 127, 3, 140, 109, 110 })]
		public virtual Appendable append(char P_0)
		{
			if (charsUntilSeparator == 0)
			{
				Appendable appendable = val_0024delegate;
				CharSequence csq = default(CharSequence);
				object obj = (csq.___003Cref_003E = val_0024separator);
				appendable.append(csq);
				charsUntilSeparator = val_0024afterEveryChars;
			}
			val_0024delegate.append(P_0);
			charsUntilSeparator--;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1041)]
		public virtual Appendable append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0, int P_1, int P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1046)]
		public virtual Appendable append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "separatingWriter", "(Ljava.io.Writer;Ljava.lang.String;I)Ljava.io.Writer;")]
	internal class _5 : Writer
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Appendable val_0024separatingAppendable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Writer val_0024delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1054)]
		internal _5(Appendable P_0, Writer P_1)
		{
			val_0024separatingAppendable = P_0;
			val_0024delegate = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 175, 110 })]
		public override void write(int P_0)
		{
			val_0024separatingAppendable.append((char)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(1062)]
		public override void write(char[] P_0, int P_1, int P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 185, 109 })]
		public override void flush()
		{
			val_0024delegate.flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 190, 109 })]
		public override void close()
		{
			val_0024delegate.close();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Alphabet : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string name;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char[] chars;

		[Modifiers(Modifiers.Final)]
		internal int mask;

		[Modifiers(Modifiers.Final)]
		internal int bitsPerChar;

		[Modifiers(Modifiers.Final)]
		internal int charsPerChunk;

		[Modifiers(Modifiers.Final)]
		internal int bytesPerChunk;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private byte[] decodabet;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool[] validPadding;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 130, 116, 104, 2, 230, 69 })]
		private bool hasLowerCase()
		{
			char[] array = chars;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				int c = array[i];
				if (Ascii.isLowerCase((char)c))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 139, 116, 104, 2, 230, 69 })]
		private bool hasUpperCase()
		{
			char[] array = chars;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				int c = array[i];
				if (Ascii.isUpperCase((char)c))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161,
			62,
			104,
			113,
			145,
			191,
			10,
			2,
			97,
			byte.MaxValue,
			20,
			71,
			147,
			114,
			191,
			17,
			2,
			98,
			191,
			27,
			138,
			108,
			104,
			105,
			102,
			115,
			116,
			232,
			60,
			232,
			70,
			136,
			109,
			109,
			56,
			168,
			104
		})]
		internal Alphabet(string P_0, char[] P_1)
		{
			name = (string)Preconditions.checkNotNull(P_0);
			chars = (char[])Preconditions.checkNotNull(P_1);
			java.lang.ArithmeticException ex2;
			try
			{
				bitsPerChar = IntMath.log2(P_1.Length, RoundingMode.UNNECESSARY);
			}
			catch (System.Exception x)
			{
				java.lang.ArithmeticException ex = ByteCodeHelper.MapException<java.lang.ArithmeticException>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_0050;
			}
			int num = java.lang.Math.min(8, Integer.lowestOneBit(bitsPerChar));
			java.lang.ArithmeticException ex4;
			try
			{
				charsPerChunk = ((num != -1) ? (8 / num) : (-8));
				int num2 = bitsPerChar;
				bytesPerChunk = ((num != -1) ? (num2 / num) : (-num2));
			}
			catch (System.Exception x2)
			{
				java.lang.ArithmeticException ex3 = ByteCodeHelper.MapException<java.lang.ArithmeticException>(x2, ByteCodeHelper.MapFlags.None);
				if (ex3 == null)
				{
					throw;
				}
				ex4 = ex3;
				goto IL_00da;
			}
			mask = (int)((nint)P_1.LongLength - 1);
			byte[] array = new byte[128];
			Arrays.fill(array, byte.MaxValue);
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				int num3 = P_1[i];
				Preconditions.checkArgument(num3 < (nint)array.LongLength, "Non-ASCII character: %s", (char)num3);
				Preconditions.checkArgument(array[num3] == -1, "Duplicate character: %s", (char)num3);
				array[num3] = (byte)(sbyte)i;
			}
			decodabet = array;
			bool[] array2 = new bool[charsPerChunk];
			for (int num3 = 0; num3 < bytesPerChunk; num3++)
			{
				array2[IntMath.divide(num3 * 8, bitsPerChar, RoundingMode.CEILING)] = true;
			}
			validPadding = array2;
			return;
			IL_0050:
			java.lang.ArithmeticException cause = ex2;
			int i2 = P_1.Length;
			int num4 = 35;
			num4 = num4;
			string message = new StringBuilder(num4).append("Illegal alphabet length ").append(i2).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(message, cause);
			IL_00da:
			java.lang.ArithmeticException cause2 = ex4;
			string text = java.lang.String.valueOf(java.lang.String.newhelper(P_1));
			string message2;
			if (java.lang.String.instancehelper_length(text) != 0)
			{
				message2 = java.lang.String.instancehelper_concat("Illegal alphabet ", text);
			}
			else
			{
				string text2 = "Illegal alphabet ";
				text2 = text2;
				message2 = java.lang.String.newhelper(text2);
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(message2, cause2);
		}

		[LineNumberTable(473)]
		internal virtual char encode(int P_0)
		{
			return chars[P_0];
		}

		[LineNumberTable(477)]
		internal virtual bool isValidPaddingStartPosition(int P_0)
		{
			bool[] array = validPadding;
			int num = charsPerChunk;
			return array[(num != -1) ? (P_0 % num) : 0];
		}

		[LineNumberTable(481)]
		internal virtual bool canDecode(char P_0)
		{
			return (P_0 <= '\u007f' && decodabet[(uint)P_0] != -1) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
		[LineNumberTable(new byte[]
		{
			159, 21, 98, 101, 159, 21, 105, 103, 106, 159,
			21, 191, 12
		})]
		internal virtual int decode(char P_0)
		{
			if (P_0 > '\u007f')
			{
				string text = java.lang.String.valueOf(Integer.toHexString(P_0));
				string text2;
				if (java.lang.String.instancehelper_length(text) != 0)
				{
					text2 = java.lang.String.instancehelper_concat("Unrecognized character: 0x", text);
				}
				else
				{
					string text3 = "Unrecognized character: 0x";
					text3 = text3;
					text2 = java.lang.String.newhelper(text3);
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DecodingException(text2);
			}
			int num = decodabet[(uint)P_0];
			if (num == -1)
			{
				if (P_0 <= ' ' || P_0 == '\u007f')
				{
					string text4 = java.lang.String.valueOf(Integer.toHexString(P_0));
					string text5;
					if (java.lang.String.instancehelper_length(text4) != 0)
					{
						text5 = java.lang.String.instancehelper_concat("Unrecognized character: 0x", text4);
					}
					else
					{
						string text3 = "Unrecognized character: 0x";
						text3 = text3;
						text5 = java.lang.String.newhelper(text3);
					}
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new DecodingException(text5);
				}
				int num2 = 25;
				num2 = num2;
				string text6 = new StringBuilder(num2).append("Unrecognized character: ").append(P_0).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DecodingException(text6);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 148, 104, 130, 118, 109, 108, 48, 166 })]
		internal virtual Alphabet upperCase()
		{
			if (!hasLowerCase())
			{
				return this;
			}
			Preconditions.checkState((!hasUpperCase()) ? true : false, (object)"Cannot call upperCase() on a mixed-case alphabet");
			char[] array = new char[(nint)chars.LongLength];
			for (int i = 0; i < (nint)chars.LongLength; i++)
			{
				array[i] = Ascii.toUpperCase(chars[i]);
			}
			Alphabet result = new Alphabet(java.lang.String.instancehelper_concat(java.lang.String.valueOf(name), ".upperCase()"), array);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 160, 104, 130, 118, 109, 108, 48, 166 })]
		internal virtual Alphabet lowerCase()
		{
			if (!hasUpperCase())
			{
				return this;
			}
			Preconditions.checkState((!hasLowerCase()) ? true : false, (object)"Cannot call lowerCase() on a mixed-case alphabet");
			char[] array = new char[(nint)chars.LongLength];
			for (int i = 0; i < (nint)chars.LongLength; i++)
			{
				array[i] = Ascii.toLowerCase(chars[i]);
			}
			Alphabet result = new Alphabet(java.lang.String.instancehelper_concat(java.lang.String.valueOf(name), ".lowerCase()"), array);
			_ = null;
			return result;
		}

		[LineNumberTable(542)]
		public virtual bool matches(char P_0)
		{
			return ((int)P_0 < (nint)decodabet.LongLength && decodabet[(uint)P_0] != -1) ? true : false;
		}

		public override string toString()
		{
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 182, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Alphabet)
			{
				Alphabet alphabet = (Alphabet)P_0;
				bool result = Arrays.equals(chars, alphabet.chars);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(561)]
		public override int hashCode()
		{
			int result = Arrays.hashCode(chars);
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(421)]
		internal static char[] access_0024000(Alphabet P_0)
		{
			return P_0.chars;
		}
	}

	internal sealed class Base16Encoding : StandardBaseEncoding
	{
		[Modifiers(Modifiers.Final)]
		internal char[] encoding;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 12, 116 })]
		internal Base16Encoding(string P_0, string P_1)
			: this(new Alphabet(P_0, java.lang.String.instancehelper_toCharArray(P_1)))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 16, 234, 57, 240, 72, 112, 106, 113, 24,
			198
		})]
		private Base16Encoding(Alphabet P_0)
			: base(P_0, null)
		{
			encoding = new char[512];
			Preconditions.checkArgument((nint)Alphabet.access_0024000(P_0).LongLength == 16);
			for (int i = 0; i < 256; i++)
			{
				encoding[i] = P_0.encode((int)((uint)i >> 4));
				encoding[i | 0x100] = P_0.encode(i & 0xF);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			163, 26, 103, 108, 103, 102, 111, 245, 61, 230,
			69
		})]
		internal override void encodeTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkPositionIndexes(P_2, P_2 + P_3, P_1.Length);
			for (int i = 0; i < P_3; i++)
			{
				int num = P_1[P_2 + i];
				P_0.append(encoding[num]);
				P_0.append(encoding[num | 0x100]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
		[LineNumberTable(new byte[]
		{
			158, 169, 170, 103, 127, 0, 159, 36, 99, 123,
			127, 44, 13, 203
		})]
		internal override int decodeTo(byte[] P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(P_0);
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.length();
			int i;
			if (((2 != -1) ? (num % 2) : 0) == 1)
			{
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				i = charSequence2.length();
				int num2 = 32;
				num2 = num2;
				string text = new StringBuilder(num2).append("Invalid input length ").append(i).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DecodingException(text);
			}
			i = 0;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num4 >= charSequence2.length())
				{
					break;
				}
				Alphabet obj2 = alphabet;
				int num2 = num3;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num5 = obj2.decode(charSequence2.charAt(num2)) << 4;
				Alphabet obj3 = alphabet;
				num2 = num3 + 1;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num6 = num5 | obj3.decode(charSequence2.charAt(num2));
				int num7 = i;
				i++;
				P_0[num7] = (byte)(sbyte)num6;
				num3 += 2;
			}
			return i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(933)]
		internal override BaseEncoding newInstance(Alphabet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_1)
		{
			Base16Encoding result = new Base16Encoding(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Base16Encoding()
		{
			StandardBaseEncoding.___003Cclinit_003E();
		}
	}

	internal sealed class Base64Encoding : StandardBaseEncoding
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 57, 117 })]
		internal Base64Encoding(string P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_2)
			: this(new Alphabet(P_0, java.lang.String.instancehelper_toCharArray(P_1)), P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 61, 104, 114 })]
		private Base64Encoding(Alphabet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_1)
			: base(P_0, P_1)
		{
			Preconditions.checkArgument((nint)Alphabet.access_0024000(P_0).LongLength == 64);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			163, 67, 103, 108, 98, 106, 125, 118, 121, 120,
			246, 59, 234, 71, 103, 145
		})]
		internal override void encodeTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkPositionIndexes(P_2, P_2 + P_3, P_1.Length);
			int num = P_2;
			for (int i = P_3; i >= 3; i += -3)
			{
				int num2 = num;
				num++;
				int num3 = P_1[num2] << 16;
				int num4 = num;
				num++;
				int num5 = num3 | (P_1[num4] << 8);
				int num6 = num;
				num++;
				int num7 = num5 | P_1[num6];
				P_0.append(alphabet.encode((int)((uint)num7 >> 18)));
				P_0.append(alphabet.encode((int)(((uint)num7 >> 12) & 0x3F)));
				P_0.append(alphabet.encode((int)(((uint)num7 >> 6) & 0x3F)));
				P_0.append(alphabet.encode(num7 & 0x3F));
			}
			if (num < P_2 + P_3)
			{
				base.encodeChunkTo(P_0, P_1, num, P_2 + P_3 - num);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
		[LineNumberTable(new byte[]
		{
			158, 157, 138, 103, 127, 2, 126, 159, 36, 99,
			123, 127, 14, 127, 17, 112, 120, 127, 16, 117,
			117, 127, 14, 179, 101
		})]
		internal override int decodeTo(byte[] P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(P_0);
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			__003Cref_003E = trimTrailingPadding(charSequence2).___003Cref_003E;
			Alphabet obj2 = alphabet;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int i;
			if (!obj2.isValidPaddingStartPosition(charSequence2.length()))
			{
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				i = charSequence2.length();
				int num = 32;
				num = num;
				string text = new StringBuilder(num).append("Invalid input length ").append(i).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DecodingException(text);
			}
			i = 0;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num3 >= charSequence2.length())
				{
					break;
				}
				Alphabet obj3 = alphabet;
				object __003Cref_003E2 = __003Cref_003E;
				int num4 = num2;
				num2++;
				int num = num4;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
				int num5 = obj3.decode(charSequence2.charAt(num)) << 18;
				int num6 = num5;
				Alphabet obj4 = alphabet;
				object __003Cref_003E3 = __003Cref_003E;
				int num7 = num2;
				num2++;
				num = num7;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E3);
				num5 = num6 | (obj4.decode(charSequence2.charAt(num)) << 12);
				int num8 = i;
				i++;
				P_0[num8] = (byte)(sbyte)((uint)num5 >> 16);
				int num9 = num2;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num9 < charSequence2.length())
				{
					int num10 = num5;
					Alphabet obj5 = alphabet;
					object __003Cref_003E4 = __003Cref_003E;
					int num11 = num2;
					num2++;
					num = num11;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E4);
					num5 = num10 | (obj5.decode(charSequence2.charAt(num)) << 6);
					int num12 = i;
					i++;
					P_0[num12] = (byte)(sbyte)(((uint)num5 >> 8) & 0xFFu);
					int num13 = num2;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (num13 < charSequence2.length())
					{
						int num14 = num5;
						Alphabet obj6 = alphabet;
						object __003Cref_003E5 = __003Cref_003E;
						int num15 = num2;
						num2++;
						num = num15;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E5);
						num5 = num14 | obj6.decode(charSequence2.charAt(num));
						int num16 = i;
						i++;
						P_0[num16] = (byte)(sbyte)((uint)num5 & 0xFFu);
					}
				}
			}
			return i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(990)]
		internal override BaseEncoding newInstance(Alphabet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_1)
		{
			Base64Encoding result = new Base64Encoding(P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Base64Encoding()
		{
			StandardBaseEncoding.___003Cclinit_003E();
		}
	}

	[Serializable]
	public sealed class DecodingException : IOException
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 89, 105 })]
		internal DecodingException(string P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 93, 105 })]
		internal DecodingException(System.Exception P_0)
			: base(P_0)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected DecodingException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal sealed class SeparatedBaseEncoding : BaseEncoding
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private BaseEncoding @delegate;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string separator;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int afterEveryChars;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 200, 104, 113, 113, 103, 145 })]
		internal SeparatedBaseEncoding(BaseEncoding P_0, string P_1, int P_2)
		{
			@delegate = (BaseEncoding)Preconditions.checkNotNull(P_0);
			separator = (string)Preconditions.checkNotNull(P_1);
			afterEveryChars = P_2;
			Preconditions.checkArgument(P_2 > 0, "Cannot add a separator after every %s chars", P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1092)]
		internal override CharSequence trimTrailingPadding(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			BaseEncoding baseEncoding = @delegate;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			CharSequence charSequence3 = default(CharSequence);
			object obj2 = (charSequence3.___003Cref_003E = baseEncoding.trimTrailingPadding(charSequence2).___003Cref_003E);
			CharSequence result = charSequence3;
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 215, 109, 103, 63, 1 })]
		internal override int maxEncodedSize(int P_0)
		{
			int num = @delegate.maxEncodedSize(P_0);
			return num + java.lang.String.instancehelper_length(separator) * IntMath.divide(java.lang.Math.max(0, num - 1), afterEveryChars, RoundingMode.FLOOR);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1105)]
		public override OutputStream encodingStream(Writer P_0)
		{
			OutputStream result = @delegate.encodingStream(separatingWriter(P_0, separator, afterEveryChars));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 163, 228, 127, 4 })]
		internal override void encodeTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
		{
			@delegate.encodeTo(separatingAppendable(P_0, separator, afterEveryChars), P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1115)]
		internal override int maxDecodedSize(int P_0)
		{
			int result = @delegate.maxDecodedSize(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			158, 118, 74, 102, 120, 122, 112, 233, 61, 233,
			70
		})]
		public override bool canDecode(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			CharSequence cs = default(CharSequence);
			object obj;
			while (true)
			{
				int num2 = num;
				obj = (cs.___003Cref_003E = __003Cref_003E);
				if (num2 >= cs.length())
				{
					break;
				}
				int i = num;
				obj = (cs.___003Cref_003E = __003Cref_003E);
				int num3 = cs.charAt(i);
				if (java.lang.String.instancehelper_indexOf(separator, num3) < 0)
				{
					stringBuilder.append((char)num3);
				}
				num++;
			}
			BaseEncoding baseEncoding = @delegate;
			obj = (cs.___003Cref_003E = stringBuilder);
			bool result = baseEncoding.canDecode(cs);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
		[LineNumberTable(new byte[]
		{
			158, 115, 74, 120, 120, 121, 112, 234, 61, 235,
			70
		})]
		internal override int decodeTo(byte[] P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			StringBuilder stringBuilder = new StringBuilder(charSequence2.length());
			int num = 0;
			while (true)
			{
				int num2 = num;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num2 >= charSequence2.length())
				{
					break;
				}
				int i = num;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num3 = charSequence2.charAt(i);
				if (java.lang.String.instancehelper_indexOf(separator, num3) < 0)
				{
					stringBuilder.append((char)num3);
				}
				num++;
			}
			BaseEncoding baseEncoding = @delegate;
			obj = (charSequence2.___003Cref_003E = stringBuilder);
			int result = baseEncoding.decodeTo(P_0, charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1145)]
		public override InputStream decodingStream(Reader P_0)
		{
			InputStream result = @delegate.decodingStream(ignoringReader(P_0, separator));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1150)]
		public override BaseEncoding omitPadding()
		{
			BaseEncoding result = @delegate.omitPadding().withSeparator(separator, afterEveryChars);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1155)]
		public override BaseEncoding withPadChar(char P_0)
		{
			BaseEncoding result = @delegate.withPadChar(P_0).withSeparator(separator, afterEveryChars);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1160)]
		public override BaseEncoding withSeparator(string P_0, int P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("Already have a separator");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1165)]
		public override BaseEncoding upperCase()
		{
			BaseEncoding result = @delegate.upperCase().withSeparator(separator, afterEveryChars);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1170)]
		public override BaseEncoding lowerCase()
		{
			BaseEncoding result = @delegate.lowerCase().withSeparator(separator, afterEveryChars);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1175)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(@delegate);
			string text2 = separator;
			int i = afterEveryChars;
			int num = 31 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".withSeparator(\"").append(text2)
				.append("\", ")
				.append(i)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		static SeparatedBaseEncoding()
		{
			BaseEncoding.___003Cclinit_003E();
		}
	}

	internal class StandardBaseEncoding : BaseEncoding
	{
		[SpecialName]
		[EnclosingMethod(null, "encodingStream", "(Ljava.io.Writer;)Ljava.io.OutputStream;")]
		internal new class _1 : OutputStream
		{
			internal int bitBuffer;

			internal int bitBufferLength;

			internal int writtenChars;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Writer val_0024out;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal StandardBaseEncoding this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 223, 118, 103, 103 })]
			internal _1(StandardBaseEncoding P_0, Writer P_1)
			{
				this_00240 = P_0;
				val_0024out = P_1;
				base._002Ector();
				bitBuffer = 0;
				bitBufferLength = 0;
				writtenChars = 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[]
			{
				161, 230, 110, 116, 110, 123, 127, 20, 124, 110,
				125, 101
			})]
			public override void write(int P_0)
			{
				bitBuffer <<= 8;
				bitBuffer |= P_0 & 0xFF;
				bitBufferLength += 8;
				while (bitBufferLength >= this_00240.alphabet.bitsPerChar)
				{
					int num = (bitBuffer >> bitBufferLength - this_00240.alphabet.bitsPerChar) & this_00240.alphabet.mask;
					val_0024out.write(this_00240.alphabet.encode(num));
					writtenChars++;
					bitBufferLength -= this_00240.alphabet.bitsPerChar;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[] { 161, 243, 109 })]
			public override void flush()
			{
				val_0024out.flush();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[]
			{
				161, 248, 108, 127, 20, 124, 110, 109, 127, 3,
				123, 208, 109
			})]
			public override void close()
			{
				if (bitBufferLength > 0)
				{
					int num = (bitBuffer << this_00240.alphabet.bitsPerChar - bitBufferLength) & this_00240.alphabet.mask;
					val_0024out.write(this_00240.alphabet.encode(num));
					writtenChars++;
					if (this_00240.paddingChar != null)
					{
						while (true)
						{
							int num2 = writtenChars;
							int charsPerChunk = this_00240.alphabet.charsPerChunk;
							if (charsPerChunk == -1 || num2 % charsPerChunk == 0)
							{
								break;
							}
							val_0024out.write(this_00240.paddingChar.charValue());
							writtenChars++;
						}
					}
				}
				val_0024out.close();
			}
		}

		[SpecialName]
		[EnclosingMethod(null, "decodingStream", "(Ljava.io.Reader;)Ljava.io.InputStream;")]
		internal new class _2 : InputStream
		{
			internal int bitBuffer;

			internal int bitBufferLength;

			internal int readChars;

			internal bool hitPadding;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Reader val_0024reader;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal StandardBaseEncoding this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 107, 118, 103, 103, 103 })]
			internal _2(StandardBaseEncoding P_0, Reader P_1)
			{
				this_00240 = P_0;
				val_0024reader = P_1;
				base._002Ector();
				bitBuffer = 0;
				bitBufferLength = 0;
				readChars = 0;
				hitPadding = false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[]
			{
				162, 116, 108, 100, 127, 1, 159, 19, 130, 110,
				99, 127, 7, 127, 5, 103, 159, 19, 108, 104,
				191, 35, 127, 1, 126, 157, 105, 110, 183
			})]
			public override int read()
			{
				while (true)
				{
					int num = val_0024reader.read();
					int i;
					if (num == -1)
					{
						if (!hitPadding && !this_00240.alphabet.isValidPaddingStartPosition(readChars))
						{
							i = readChars;
							int num2 = 32;
							num2 = num2;
							string text = new StringBuilder(num2).append("Invalid input length ").append(i).toString();
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new DecodingException(text);
						}
						return -1;
					}
					readChars++;
					i = (ushort)num;
					if (this_00240.paddingChar != null && this_00240.paddingChar.charValue() == i)
					{
						if (!hitPadding && (readChars == 1 || !this_00240.alphabet.isValidPaddingStartPosition(readChars - 1)))
						{
							int i2 = readChars;
							int num2 = 41;
							num2 = num2;
							string text2 = new StringBuilder(num2).append("Padding cannot start at index ").append(i2).toString();
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new DecodingException(text2);
						}
						hitPadding = true;
						continue;
					}
					if (hitPadding)
					{
						int i2 = readChars;
						int num2 = 61;
						num2 = num2;
						string text3 = new StringBuilder(num2).append("Expected padding character but found '").append((char)i).append("' at index ")
							.append(i2)
							.toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new DecodingException(text3);
					}
					bitBuffer <<= this_00240.alphabet.bitsPerChar;
					bitBuffer |= this_00240.alphabet.decode((char)i);
					bitBufferLength += this_00240.alphabet.bitsPerChar;
					if (bitBufferLength >= 8)
					{
						break;
					}
				}
				bitBufferLength -= 8;
				return (bitBuffer >> bitBufferLength) & 0xFF;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[]
			{
				162, 154, 139, 98, 102, 103, 100, 100, 136, 229,
				58, 230, 72
			})]
			public override int read(byte[] P_0, int P_1, int P_2)
			{
				Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
				int i;
				for (i = P_1; i < P_1 + P_2; i++)
				{
					int num = read();
					if (num == -1)
					{
						int num2 = i - P_1;
						return (num2 != 0) ? num2 : (-1);
					}
					P_0[i] = (byte)(sbyte)num;
				}
				return i - P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[LineNumberTable(new byte[] { 162, 170, 109 })]
			public override void close()
			{
				val_0024reader.close();
			}
		}

		[Modifiers(Modifiers.Final)]
		internal Alphabet alphabet;

		[Modifiers(Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Character paddingChar;

		[NonSerialized]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new BaseEncoding m_upperCase;

		[NonSerialized]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new BaseEncoding m_lowerCase;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 202, 117 })]
		internal StandardBaseEncoding(string P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_2)
			: this(new Alphabet(P_0, java.lang.String.instancehelper_toCharArray(P_1)), P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 205, 104, 113, 101, 54, 197, 103 })]
		internal StandardBaseEncoding(Alphabet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_1)
		{
			alphabet = (Alphabet)Preconditions.checkNotNull(P_0);
			Preconditions.checkArgument((P_1 == null || !P_0.matches(P_1.charValue())) ? true : false, "Padding character %s was already in alphabet", P_1);
			paddingChar = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			162, 18, 103, 108, 119, 99, 103, 105, 4, 230,
			69, 115, 98, 103, 118, 115, 110, 98, 104, 112,
			114, 176
		})]
		internal virtual void encodeChunkTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkPositionIndexes(P_2, P_2 + P_3, P_1.Length);
			Preconditions.checkArgument(P_3 <= alphabet.bytesPerChunk);
			long num = 0L;
			int i;
			for (i = 0; i < P_3; i++)
			{
				num |= (int)P_1[P_2 + i];
				num <<= 8;
			}
			i = (P_3 + 1) * 8 - alphabet.bitsPerChar;
			int j;
			for (j = 0; j < P_3 * 8; j += alphabet.bitsPerChar)
			{
				int num2 = (int)((ulong)num >> i - j) & alphabet.mask;
				P_0.append(alphabet.encode(num2));
			}
			if (paddingChar != null)
			{
				for (; j < alphabet.bytesPerChunk * 8; j += alphabet.bitsPerChar)
				{
					P_0.append(paddingChar.charValue());
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			158, 230, 170, 103, 104, 146, 141, 124, 125, 2,
			232, 69
		})]
		internal override CharSequence trimTrailingPadding(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			if (paddingChar != null)
			{
				int num = paddingChar.charValue();
				CharSequence charSequence2 = default(CharSequence);
				object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int i;
				int i2;
				for (i = charSequence2.length() - 1; i >= 0; i += -1)
				{
					i2 = i;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (charSequence2.charAt(i2) != num)
					{
						break;
					}
				}
				int i3 = i + 1;
				i2 = 0;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				CharSequence charSequence3 = default(CharSequence);
				object obj2 = (charSequence3.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
				CharSequence result = charSequence3;
				_ = null;
				return result;
			}
			CharSequence result2 = default(CharSequence);
			object obj3 = (result2.___003Cref_003E = __003Cref_003E);
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(857)]
		internal virtual BaseEncoding newInstance(Alphabet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Character P_1)
		{
			StandardBaseEncoding result = new StandardBaseEncoding(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(586)]
		internal override int maxEncodedSize(int P_0)
		{
			return alphabet.charsPerChunk * IntMath.divide(P_0, alphabet.bytesPerChunk, RoundingMode.CEILING);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 222, 103 })]
		public override OutputStream encodingStream(Writer P_0)
		{
			Preconditions.checkNotNull(P_0);
			_1 result = new _1(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 10, 103, 108, 103, 63, 0, 176 })]
		internal override void encodeTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkPositionIndexes(P_2, P_2 + P_3, P_1.Length);
			for (int i = 0; i < P_3; i += alphabet.bytesPerChunk)
			{
				encodeChunkTo(P_0, P_1, P_2 + i, java.lang.Math.min(alphabet.bytesPerChunk, P_3 - i));
			}
		}

		[LineNumberTable(670)]
		internal override int maxDecodedSize(int P_0)
		{
			return (int)(((long)alphabet.bitsPerChar * (long)P_0 + 7) / 8);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			158, 226, 170, 103, 127, 2, 126, 130, 120, 127,
			5, 2, 232, 69
		})]
		public override bool canDecode(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			__003Cref_003E = trimTrailingPadding(charSequence2).___003Cref_003E;
			Alphabet obj2 = alphabet;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!obj2.isValidPaddingStartPosition(charSequence2.length()))
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				int num2 = num;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num2 >= charSequence2.length())
				{
					break;
				}
				Alphabet obj3 = alphabet;
				object __003Cref_003E2 = __003Cref_003E;
				int i = num;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
				if (!obj3.canDecode(charSequence2.charAt(i)))
				{
					return false;
				}
				num++;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
		[LineNumberTable(new byte[]
		{
			158,
			222,
			138,
			103,
			127,
			2,
			126,
			159,
			36,
			99,
			123,
			100,
			99,
			117,
			115,
			120,
			byte.MaxValue,
			18,
			61,
			235,
			70,
			126,
			119,
			59,
			233,
			54,
			245,
			78
		})]
		internal override int decodeTo(byte[] P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(P_0);
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			__003Cref_003E = trimTrailingPadding(charSequence2).___003Cref_003E;
			Alphabet obj2 = alphabet;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int i;
			if (!obj2.isValidPaddingStartPosition(charSequence2.length()))
			{
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				i = charSequence2.length();
				int num = 32;
				num = num;
				string text = new StringBuilder(num).append("Invalid input length ").append(i).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DecodingException(text);
			}
			i = 0;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num3 >= charSequence2.length())
				{
					break;
				}
				long num4 = 0L;
				int num5 = 0;
				int j;
				for (j = 0; j < alphabet.charsPerChunk; j++)
				{
					num4 <<= alphabet.bitsPerChar;
					int num6 = num2 + j;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (num6 < charSequence2.length())
					{
						long num7 = num4;
						Alphabet obj3 = alphabet;
						object __003Cref_003E2 = __003Cref_003E;
						int num8 = num2;
						int num9 = num5;
						num5++;
						int num = num8 + num9;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
						num4 = num7 | obj3.decode(charSequence2.charAt(num));
					}
				}
				j = alphabet.bytesPerChunk * 8 - num5 * alphabet.bitsPerChar;
				for (int k = (alphabet.bytesPerChunk - 1) * 8; k >= j; k += -8)
				{
					int num10 = i;
					i++;
					P_0[num10] = (byte)(sbyte)(((ulong)num4 >> k) & 0xFFu);
				}
				num2 += alphabet.charsPerChunk;
			}
			return i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 106, 103 })]
		public override InputStream decodingStream(Reader P_0)
		{
			Preconditions.checkNotNull(P_0);
			_2 result = new _2(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(803)]
		public override BaseEncoding omitPadding()
		{
			BaseEncoding result = ((paddingChar != null) ? newInstance(alphabet, null) : this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 196, 66, 127, 7, 104, 130 })]
		public override BaseEncoding withPadChar(char P_0)
		{
			int bitsPerChar = alphabet.bitsPerChar;
			if (bitsPerChar == -1 || 8 % bitsPerChar == 0 || (paddingChar != null && paddingChar.charValue() == P_0))
			{
				return this;
			}
			BaseEncoding result = newInstance(alphabet, Character.valueOf(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 192, 107, 104, 54, 37, 230, 70, 104, 103,
			51, 229, 69
		})]
		public override BaseEncoding withSeparator(string P_0, int P_1)
		{
			for (int i = 0; i < java.lang.String.instancehelper_length(P_0); i++)
			{
				Preconditions.checkArgument((!alphabet.matches(java.lang.String.instancehelper_charAt(P_0, i))) ? true : false, "Separator (%s) cannot contain alphabet characters", P_0);
			}
			if (paddingChar != null)
			{
				Preconditions.checkArgument(java.lang.String.instancehelper_indexOf(P_0, paddingChar.charValue()) < 0, "Separator (%s) cannot contain padding character", P_0);
			}
			SeparatedBaseEncoding result = new SeparatedBaseEncoding(this, P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 212, 103, 99, 108, 159, 6 })]
		public override BaseEncoding upperCase()
		{
			BaseEncoding baseEncoding = this.m_upperCase;
			if (baseEncoding == null)
			{
				Alphabet alphabet = this.alphabet.upperCase();
				BaseEncoding baseEncoding2 = ((alphabet != this.alphabet) ? newInstance(alphabet, paddingChar) : this);
				this.m_upperCase = baseEncoding2;
				baseEncoding = baseEncoding2;
			}
			return baseEncoding;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 222, 103, 99, 108, 159, 6 })]
		public override BaseEncoding lowerCase()
		{
			BaseEncoding baseEncoding = this.m_lowerCase;
			if (baseEncoding == null)
			{
				Alphabet alphabet = this.alphabet.lowerCase();
				BaseEncoding baseEncoding2 = ((alphabet != this.alphabet) ? newInstance(alphabet, paddingChar) : this);
				this.m_lowerCase = baseEncoding2;
				baseEncoding = baseEncoding2;
			}
			return baseEncoding;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 236, 107, 114, 120, 104, 142, 191, 2 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder("BaseEncoding.");
			stringBuilder.append(alphabet.toString());
			int bitsPerChar = alphabet.bitsPerChar;
			if (bitsPerChar != -1 && 8 % bitsPerChar != 0)
			{
				if (paddingChar == null)
				{
					stringBuilder.append(".omitPadding()");
				}
				else
				{
					stringBuilder.append(".withPadChar('").append(paddingChar).append("')");
				}
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 250, 104, 103, 127, 0, 43, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is StandardBaseEncoding)
			{
				StandardBaseEncoding standardBaseEncoding = (StandardBaseEncoding)P_0;
				return (alphabet.equals(standardBaseEncoding.alphabet) && com.google.common.@base.Objects.equal(paddingChar, standardBaseEncoding.paddingChar)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(886)]
		public override int hashCode()
		{
			return alphabet.hashCode() ^ com.google.common.@base.Objects.hashCode(paddingChar);
		}

		[HideFromJava]
		static StandardBaseEncoding()
		{
			BaseEncoding.___003Cclinit_003E();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static BaseEncoding BASE64;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static BaseEncoding BASE64_URL;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static BaseEncoding BASE32;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static BaseEncoding BASE32_HEX;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static BaseEncoding BASE16;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	public abstract OutputStream encodingStream(Writer w);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 107, 107, 141, 188, 2, 97, 140 })]
	public string encode(byte[] bytes, int off, int len)
	{
		Preconditions.checkPositionIndexes(off, off + len, bytes.Length);
		StringBuilder stringBuilder = new StringBuilder(maxEncodedSize(len));
		IOException ex;
		try
		{
			encodeTo(stringBuilder, bytes, off, len);
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0031;
		}
		return stringBuilder.toString();
		IL_0031:
		IOException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual int maxEncodedSize(int P_0)
	{
		throw new AbstractMethodError("com.google.common.io.BaseEncoding.maxEncodedSize(I)I");
	}

	[Throws(new string[] { "java.io.IOException" })]
	[Modifiers(Modifiers.Abstract)]
	internal virtual void encodeTo(Appendable P_0, byte[] P_1, int P_2, int P_3)
	{
		throw new AbstractMethodError("com.google.common.io.BaseEncoding.encodeTo(Ljava.lang.Appendable;[BII)V");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
	[LineNumberTable(new byte[] { 159, 84, 74, 127, 2, 126, 123 })]
	internal byte[] decodeChecked(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		__003Cref_003E = trimTrailingPadding(charSequence2).___003Cref_003E;
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		byte[] array = new byte[maxDecodedSize(charSequence2.length())];
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = decodeTo(array, charSequence2);
		byte[] result = extract(array, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(271)]
	internal virtual CharSequence trimTrailingPadding(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		object obj = Preconditions.checkNotNull(__003Cref_003E);
		CharSequence.Cast(obj);
		CharSequence result = default(CharSequence);
		object obj2 = (result.___003Cref_003E = obj);
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual int maxDecodedSize(int P_0)
	{
		throw new AbstractMethodError("com.google.common.io.BaseEncoding.maxDecodedSize(I)I");
	}

	[Throws(new string[] { "com.google.common.io.BaseEncoding$DecodingException" })]
	[Modifiers(Modifiers.Abstract)]
	internal virtual int decodeTo(byte[] P_0, CharSequence P_1)
	{
		throw new AbstractMethodError("com.google.common.io.BaseEncoding.decodeTo([BLjava.lang.CharSequence;)I");
	}

	[LineNumberTable(new byte[] { 160, 78, 101, 130, 103, 106 })]
	private static byte[] extract(byte[] P_0, int P_1)
	{
		if ((nint)P_1 == (nint)P_0.LongLength)
		{
			return P_0;
		}
		byte[] array = new byte[P_1];
		ByteCodeHelper.arraycopy_primitive_1(P_0, 0, array, 0, P_1);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 140, 103, 103, 105 })]
	internal static Appendable separatingAppendable(Appendable P_0, string P_1, int P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkArgument(P_2 > 0);
		_4 result = new _4(P_2, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	internal BaseEncoding()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(149)]
	public virtual string encode(byte[] bytes)
	{
		string result = encode(bytes, 0, bytes.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 66, 103 })]
	public ByteSink encodingSink(CharSink encodedSink)
	{
		Preconditions.checkNotNull(encodedSink);
		_1 result = new _1(this, encodedSink);
		_ = null;
		return result;
	}

	public abstract bool canDecode(CharSequence cs);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 88, 106, 127, 19, 98 })]
	public byte[] decode(CharSequence chars)
	{
		//Discarded unreachable code: IL_0023
		CharSequence charSequence = chars;
		object __003Cref_003E = charSequence.___003Cref_003E;
		DecodingException ex;
		try
		{
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			return decodeChecked(charSequence2);
		}
		catch (DecodingException x)
		{
			ex = ByteCodeHelper.MapException<DecodingException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		DecodingException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(cause);
	}

	public abstract InputStream decodingStream(Reader r);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 137, 103 })]
	public ByteSource decodingSource(CharSource encodedSource)
	{
		Preconditions.checkNotNull(encodedSource);
		_2 result = new _2(this, encodedSource);
		_ = null;
		return result;
	}

	public abstract BaseEncoding omitPadding();

	public abstract BaseEncoding withPadChar(char ch);

	public abstract BaseEncoding withSeparator(string str, int i);

	public abstract BaseEncoding upperCase();

	public abstract BaseEncoding lowerCase();

	public static BaseEncoding base64()
	{
		return BASE64;
	}

	public static BaseEncoding base64Url()
	{
		return BASE64_URL;
	}

	public static BaseEncoding base32()
	{
		return BASE32;
	}

	public static BaseEncoding base32Hex()
	{
		return BASE32_HEX;
	}

	public static BaseEncoding base16()
	{
		return BASE16;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 114, 103, 103 })]
	internal static Reader ignoringReader(Reader P_0, string P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_3 result = new _3(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 171, 105 })]
	internal static Writer separatingWriter(Writer P_0, string P_1, int P_2)
	{
		Appendable appendable = separatingAppendable(P_0, P_1, P_2);
		_5 result = new _5(appendable, P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		160, 207, 145, 239, 83, 145, 239, 84, 113, 239,
		82, 113, 239, 82
	})]
	static BaseEncoding()
	{
		Base64Encoding.___003Cclinit_003E();
		BASE64 = new Base64Encoding("base64()", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/", Character.valueOf('='));
		Base64Encoding.___003Cclinit_003E();
		BASE64_URL = new Base64Encoding("base64Url()", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_", Character.valueOf('='));
		StandardBaseEncoding.___003Cclinit_003E();
		BASE32 = new StandardBaseEncoding("base32()", "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567", Character.valueOf('='));
		StandardBaseEncoding.___003Cclinit_003E();
		BASE32_HEX = new StandardBaseEncoding("base32Hex()", "0123456789ABCDEFGHIJKLMNOPQRSTUV", Character.valueOf('='));
		BASE16 = new Base16Encoding("base16()", "0123456789ABCDEF");
	}
}
