using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[ConstantPool(new object[]
{
	(byte)46,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.hash.PrimitiveSink" })]
public interface Hasher : PrimitiveSink
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static PrimitiveSink putString(Hasher P_0, CharSequence P_1, Charset P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputString(P_0, P_1, P_2);
		}

		public unsafe static PrimitiveSink putUnencodedChars(Hasher P_0, CharSequence P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputUnencodedChars(P_0, P_1);
		}

		public unsafe static PrimitiveSink putChar(Hasher P_0, char P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputChar(P_0, P_1);
		}

		public unsafe static PrimitiveSink putBoolean(Hasher P_0, bool P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputBoolean(P_0, P_1);
		}

		public unsafe static PrimitiveSink putDouble(Hasher P_0, double P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputDouble(P_0, P_1);
		}

		public unsafe static PrimitiveSink putFloat(Hasher P_0, float P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputFloat(P_0, P_1);
		}

		public unsafe static PrimitiveSink putLong(Hasher P_0, long P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputLong(P_0, P_1);
		}

		public unsafe static PrimitiveSink putInt(Hasher P_0, int P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputInt(P_0, P_1);
		}

		public unsafe static PrimitiveSink putShort(Hasher P_0, short P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputShort(P_0, P_1);
		}

		public unsafe static PrimitiveSink putBytes(Hasher P_0, ByteBuffer P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputBytes(P_0, P_1);
		}

		public unsafe static PrimitiveSink putBytes(Hasher P_0, byte[] P_1, int P_2, int P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputBytes(P_0, P_1, P_2, P_3);
		}

		public unsafe static PrimitiveSink putBytes(Hasher P_0, byte[] P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputBytes(P_0, P_1);
		}

		public unsafe static PrimitiveSink putByte(Hasher P_0, byte P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EputByte(P_0, P_1);
		}
	}

	Hasher putString(CharSequence cs, Charset c);

	Hasher putUnencodedChars(CharSequence cs);

	Hasher putChar(char ch);

	Hasher putBoolean(bool b);

	Hasher putDouble(double d);

	Hasher putFloat(float f);

	Hasher putLong(long l);

	Hasher putInt(int i);

	Hasher putShort(short s);

	Hasher putBytes(ByteBuffer bb);

	Hasher putBytes(byte[] barr, int i1, int i2);

	Hasher putBytes(byte[] barr);

	Hasher putByte(byte b);

	[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/Hasher;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 46, 0, 0 })]
	virtual Hasher putObject([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object obj, Funnel f);

	virtual HashCode hash();

	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	virtual int hashCode();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputString(CharSequence cs, Charset c);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputString(Hasher P_0, CharSequence P_1, Charset P_2)
	{
		CharSequence charSequence = P_1;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence cs = default(CharSequence);
		object obj = (cs.___003Cref_003E = __003Cref_003E);
		Hasher result = P_0.putString(cs, P_2);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputUnencodedChars(CharSequence cs);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputUnencodedChars(Hasher P_0, CharSequence P_1)
	{
		CharSequence charSequence = P_1;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence cs = default(CharSequence);
		object obj = (cs.___003Cref_003E = __003Cref_003E);
		Hasher result = P_0.putUnencodedChars(cs);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputChar(char ch);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputChar(Hasher P_0, char P_1)
	{
		Hasher result = P_0.putChar(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputBoolean(bool b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputBoolean(Hasher P_0, bool P_1)
	{
		Hasher result = P_0.putBoolean(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputDouble(double d);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputDouble(Hasher P_0, double P_1)
	{
		Hasher result = P_0.putDouble(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputFloat(float f);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputFloat(Hasher P_0, float P_1)
	{
		Hasher result = P_0.putFloat(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputLong(long l);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputLong(Hasher P_0, long P_1)
	{
		Hasher result = P_0.putLong(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputInt(int i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputInt(Hasher P_0, int P_1)
	{
		Hasher result = P_0.putInt(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputShort(short s);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputShort(Hasher P_0, short P_1)
	{
		Hasher result = P_0.putShort(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputBytes(ByteBuffer bb);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputBytes(Hasher P_0, ByteBuffer P_1)
	{
		Hasher result = P_0.putBytes(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputBytes(byte[] barr, int i1, int i2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputBytes(Hasher P_0, byte[] P_1, int P_2, int P_3)
	{
		Hasher result = P_0.putBytes(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputBytes(byte[] barr);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputBytes(Hasher P_0, byte[] P_1)
	{
		Hasher result = P_0.putBytes(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual PrimitiveSink _003Cbridge_003EputByte(byte b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(56)]
	static PrimitiveSink _003Cdefault_003E_003Cbridge_003EputByte(Hasher P_0, byte P_1)
	{
		int b = (sbyte)P_1;
		Hasher result = P_0.putByte((byte)b);
		_ = null;
		return result;
	}
}
