using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio;
using java.nio.charset;
using java.util;

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
internal abstract class AbstractNonStreamingHashFunction : AbstractHashFunction
{
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class BufferingHasher : AbstractHasher
	{
		[Modifiers(Modifiers.Final)]
		internal ExposedByteArrayOutputStream stream;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractNonStreamingHashFunction this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 51, 108 })]
		public override Hasher putBytes(ByteBuffer P_0)
		{
			stream.write(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 45, 110 })]
		public override Hasher putBytes(byte[] P_0, int P_1, int P_2)
		{
			stream.write(P_0, P_1, P_2);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 120, 99, 108 })]
		public override Hasher putByte(byte P_0)
		{
			int b = (sbyte)P_0;
			stream.write(b);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 33, 111, 108 })]
		internal BufferingHasher(AbstractNonStreamingHashFunction P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			stream = new ExposedByteArrayOutputStream(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(107)]
		public override HashCode hash()
		{
			HashCode result = this_00240.hashBytes(stream.byteArray(), 0, stream.length());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(80)]
		public override PrimitiveSink putBytes(ByteBuffer P_0)
		{
			Hasher result = this.putBytes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(80)]
		public override PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
		{
			Hasher result = this.putBytes(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(80)]
		public override PrimitiveSink putByte(byte P_0)
		{
			int num = (sbyte)P_0;
			Hasher result = this.putByte((byte)num);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ExposedByteArrayOutputStream : ByteArrayOutputStream
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 64, 105 })]
		internal ExposedByteArrayOutputStream(int P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 68, 103, 113, 153, 116, 110 })]
		internal virtual void write(ByteBuffer P_0)
		{
			int num = P_0.remaining();
			if (count + num > (nint)buf.LongLength)
			{
				buf = Arrays.copyOf(buf, count + num);
			}
			P_0.get(buf, count, num);
			count += num;
		}

		internal virtual byte[] byteArray()
		{
			return buf;
		}

		internal virtual int length()
		{
			return count;
		}
	}

	public abstract override HashCode hashBytes(byte[] P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 108 })]
	public override Hasher newHasher(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0);
		BufferingHasher result = new BufferingHasher(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	internal AbstractNonStreamingHashFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	public override Hasher newHasher()
	{
		Hasher result = newHasher(32);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	public override HashCode hashInt(int P_0)
	{
		HashCode result = hashBytes(ByteBuffer.allocate(4).order(ByteOrder.LITTLE_ENDIAN).putInt(P_0)
			.array());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public override HashCode hashLong(long P_0)
	{
		HashCode result = hashBytes(ByteBuffer.allocate(8).order(ByteOrder.LITTLE_ENDIAN).putLong(P_0)
			.array());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 128, 138, 115, 117, 105, 63, 0, 168 })]
	public override HashCode hashUnencodedChars(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		ByteBuffer byteBuffer = ByteBuffer.allocate(num * 2).order(ByteOrder.LITTLE_ENDIAN);
		for (int i = 0; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			byteBuffer.putChar(charSequence2.charAt(i2));
		}
		HashCode result = hashBytes(byteBuffer.array());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public override HashCode hashString(CharSequence P_0, Charset P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		HashCode result = hashBytes(String.instancehelper_getBytes(charSequence2.toString(), P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public override HashCode hashBytes(ByteBuffer P_0)
	{
		HashCode result = newHasher(P_0.remaining()).putBytes(P_0).hash();
		_ = null;
		return result;
	}
}
