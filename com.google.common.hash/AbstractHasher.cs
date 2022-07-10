using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[ConstantPool(new object[]
{
	(byte)100,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.hash.Hasher" })]
internal abstract class AbstractHasher : Object, Hasher, PrimitiveSink
{
	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Hasher putByte(byte P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 55, 103, 47, 166 })]
	public virtual Hasher putLong(long P_0)
	{
		for (int i = 0; i < 64; i += 8)
		{
			this.putByte((byte)(sbyte)((ulong)P_0 >> i));
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 46, 105, 107, 108, 108 })]
	public virtual Hasher putInt(int P_0)
	{
		this.putByte((byte)(sbyte)P_0);
		this.putByte((byte)(sbyte)((uint)P_0 >> 8));
		this.putByte((byte)(sbyte)((uint)P_0 >> 16));
		this.putByte((byte)(sbyte)((uint)P_0 >> 24));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 114, 98, 105, 107 })]
	public virtual Hasher putChar(char P_0)
	{
		this.putByte((byte)(sbyte)P_0);
		this.putByte((byte)(sbyte)((uint)P_0 >> 8));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public virtual Hasher putBytes(byte[] P_0)
	{
		Hasher result = this.putBytes(P_0, 0, P_0.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 107, 102, 44, 166 })]
	public virtual Hasher putBytes(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		for (int i = 0; i < P_2; i++)
		{
			this.putByte(P_0[P_1 + i]);
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public virtual Hasher putString(CharSequence P_0, Charset P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Hasher result = this.putBytes(String.instancehelper_getBytes(charSequence2.toString(), P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 130, 106, 122, 61, 166 })]
	public virtual Hasher putUnencodedChars(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int i = 0;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		for (int num = charSequence2.length(); i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			this.putChar(charSequence2.charAt(i2));
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	public Hasher putBoolean(bool P_0)
	{
		Hasher result = this.putByte((byte)(P_0 ? 1 : 0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	public Hasher putDouble(double P_0)
	{
		DoubleConverter converter = default(DoubleConverter);
		Hasher result = this.putLong(DoubleConverter.ToLong(P_0, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	public Hasher putFloat(float P_0)
	{
		FloatConverter converter = default(FloatConverter);
		Hasher result = this.putInt(FloatConverter.ToInt(P_0, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 120, 98, 105, 107 })]
	public virtual Hasher putShort(short P_0)
	{
		this.putByte((byte)(sbyte)P_0);
		this.putByte((byte)(sbyte)((uint)P_0 >> 8));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 26, 104, 127, 1, 142, 107, 46, 198 })]
	public virtual Hasher putBytes(ByteBuffer P_0)
	{
		if (P_0.hasArray())
		{
			this.putBytes(P_0.array(), P_0.arrayOffset() + P_0.position(), P_0.remaining());
			Java8Compatibility.position(P_0, P_0.limit());
		}
		else
		{
			for (int i = P_0.remaining(); i > 0; i += -1)
			{
				this.putByte((byte)(sbyte)P_0.get());
			}
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	internal AbstractHasher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/Hasher;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 100, 0, 0 })]
	[LineNumberTable(new byte[] { 71, 104 })]
	public virtual Hasher putObject([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object P_0, Funnel P_1)
	{
		P_1.funnel(P_0, this);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putString(CharSequence P_0, Charset P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Hasher result = this.putString(charSequence2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putUnencodedChars(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Hasher result = this.putUnencodedChars(charSequence2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putChar(char P_0)
	{
		Hasher result = this.putChar(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putBoolean(bool P_0)
	{
		Hasher result = this.putBoolean(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putDouble(double P_0)
	{
		Hasher result = this.putDouble(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putFloat(float P_0)
	{
		Hasher result = this.putFloat(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putLong(long P_0)
	{
		Hasher result = this.putLong(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putInt(int P_0)
	{
		Hasher result = this.putInt(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putShort(short P_0)
	{
		Hasher result = this.putShort(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putBytes(ByteBuffer P_0)
	{
		Hasher result = this.putBytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
	{
		Hasher result = this.putBytes(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public virtual PrimitiveSink putBytes(byte[] P_0)
	{
		Hasher result = this.putBytes(P_0);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual PrimitiveSink putByte(byte P_0)
	{
		return Hasher._003Cdefault_003E_003Cbridge_003EputByte(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract HashCode hash();

	int Hasher.Hasher_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputString(CharSequence P_0, Charset P_1)
	{
		return this.putString(P_0, P_1);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputUnencodedChars(CharSequence P_0)
	{
		return this.putUnencodedChars(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputChar(char P_0)
	{
		return this.putChar(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputBoolean(bool P_0)
	{
		return this.putBoolean(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputDouble(double P_0)
	{
		return this.putDouble(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputFloat(float P_0)
	{
		return this.putFloat(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputLong(long P_0)
	{
		return this.putLong(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputInt(int P_0)
	{
		return this.putInt(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputShort(short P_0)
	{
		return this.putShort(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputBytes(ByteBuffer P_0)
	{
		return this.putBytes(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputBytes(byte[] P_0, int P_1, int P_2)
	{
		return this.putBytes(P_0, P_1, P_2);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputBytes(byte[] P_0)
	{
		return this.putBytes(P_0);
	}

	PrimitiveSink Hasher.Hasher_003A_003AputByte(byte P_0)
	{
		return this.putByte(P_0);
	}
}
