using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractCompositeHashFunction : AbstractHashFunction
{
	[SpecialName]
	[EnclosingMethod(null, "fromHashers", "([Lcom.google.common.hash.Hasher;)Lcom.google.common.hash.Hasher;")]
	[ConstantPool(new object[]
	{
		(byte)115,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.hash.Hasher" })]
	internal class _1 : Object, Hasher, PrimitiveSink
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Hasher[] val_0024hashers;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractCompositeHashFunction this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 99, 170, 120, 63, 1, 168 })]
		public virtual Hasher putString(CharSequence P_0, Charset P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			CharSequence cs = default(CharSequence);
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				object obj = (cs.___003Cref_003E = __003Cref_003E);
				hasher.putString(cs, P_1);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 101, 170, 120, 59, 168 })]
		public virtual Hasher putUnencodedChars(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			CharSequence cs = default(CharSequence);
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				object obj = (cs.___003Cref_003E = __003Cref_003E);
				hasher.putUnencodedChars(cs);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 103, 162, 117, 41, 166 })]
		public virtual Hasher putChar(char P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putChar(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 105, 162, 117, 41, 166 })]
		public virtual Hasher putBoolean(bool P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putBoolean(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 93, 116, 41, 166 })]
		public virtual Hasher putDouble(double P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putDouble(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 85, 116, 41, 166 })]
		public virtual Hasher putFloat(float P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putFloat(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 77, 116, 40, 166 })]
		public virtual Hasher putLong(long P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putLong(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 69, 116, 40, 166 })]
		public virtual Hasher putInt(int P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putInt(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 115, 162, 117, 41, 166 })]
		public virtual Hasher putShort(short P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putShort(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 51, 103, 117, 103, 9, 198 })]
		public virtual Hasher putBytes(ByteBuffer P_0)
		{
			int num = P_0.position();
			Hasher[] array = val_0024hashers;
			int num2 = array.Length;
			for (int i = 0; i < num2; i++)
			{
				Hasher hasher = array[i];
				Java8Compatibility.position(P_0, num);
				hasher.putBytes(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 43, 116, 42, 166 })]
		public virtual Hasher putBytes(byte[] P_0, int P_1, int P_2)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putBytes(P_0, P_1, P_2);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 35, 116, 40, 166 })]
		public virtual Hasher putBytes(byte[] P_0)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putBytes(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 123, 99, 117, 41, 166 })]
		public virtual Hasher putByte(byte P_0)
		{
			int b = (sbyte)P_0;
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putByte((byte)b);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(74)]
		internal _1(AbstractCompositeHashFunction P_0, Hasher[] P_1)
		{
			this_00240 = P_0;
			val_0024hashers = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/Hasher;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 115, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 70, 116, 41, 166 })]
		public virtual Hasher putObject([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1)
		{
			Hasher[] array = val_0024hashers;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Hasher hasher = array[i];
				hasher.putObject(P_0, P_1);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(192)]
		public virtual HashCode hash()
		{
			HashCode result = this_00240.makeHash(val_0024hashers);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
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
		[LineNumberTable(74)]
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
		[LineNumberTable(74)]
		public virtual PrimitiveSink putChar(char P_0)
		{
			Hasher result = this.putChar(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putBoolean(bool P_0)
		{
			Hasher result = this.putBoolean(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putDouble(double P_0)
		{
			Hasher result = this.putDouble(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putFloat(float P_0)
		{
			Hasher result = this.putFloat(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putLong(long P_0)
		{
			Hasher result = this.putLong(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putInt(int P_0)
		{
			Hasher result = this.putInt(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putShort(short P_0)
		{
			Hasher result = this.putShort(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putBytes(ByteBuffer P_0)
		{
			Hasher result = this.putBytes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
		{
			Hasher result = this.putBytes(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putBytes(byte[] P_0)
		{
			Hasher result = this.putBytes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(74)]
		public virtual PrimitiveSink putByte(byte P_0)
		{
			int num = (sbyte)P_0;
			Hasher result = this.putByte((byte)num);
			_ = null;
			return result;
		}

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

	[Modifiers(Modifiers.Final)]
	internal HashFunction[] functions;

	private const long serialVersionUID = 0L;

	internal abstract HashCode makeHash(Hasher[] P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	private Hasher fromHashers(Hasher[] P_0)
	{
		_1 result = new _1(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 104, 112, 40, 166, 103 })]
	internal AbstractCompositeHashFunction(params HashFunction[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			HashFunction reference = P_0[i];
			Preconditions.checkNotNull(reference);
		}
		functions = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 109, 103, 48, 166 })]
	public override Hasher newHasher()
	{
		Hasher[] array = new Hasher[(nint)functions.LongLength];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			array[i] = functions[i].newHasher();
		}
		Hasher result = fromHashers(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 108, 109, 103, 49, 166 })]
	public override Hasher newHasher(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0);
		Hasher[] array = new Hasher[(nint)functions.LongLength];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			array[i] = functions[i].newHasher(P_0);
		}
		Hasher result = fromHashers(array);
		_ = null;
		return result;
	}
}
