using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.nio;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractByteHasher : AbstractHasher
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ByteBuffer scratch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 104, 41, 166 })]
	protected internal virtual void update(byte[] P_0, int P_1, int P_2)
	{
		for (int i = P_1; i < P_1 + P_2; i++)
		{
			update(P_0[i]);
		}
	}

	protected internal abstract void update(byte P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 108 })]
	protected internal virtual void update(byte[] P_0)
	{
		update(P_0, 0, P_0.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 104, 127, 0, 142, 107, 45, 198 })]
	protected internal virtual void update(ByteBuffer P_0)
	{
		if (P_0.hasArray())
		{
			update(P_0.array(), P_0.arrayOffset() + P_0.position(), P_0.remaining());
			Java8Compatibility.position(P_0, P_0.limit());
			return;
		}
		for (int i = P_0.remaining(); i > 0; i += -1)
		{
			update((byte)(sbyte)P_0.get());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 19, 151, 107, 35, 98, 98 })]
	private Hasher update(int P_0)
	{
		try
		{
			update(scratch.array(), 0, P_0);
		}
		finally
		{
			Java8Compatibility.clear(scratch);
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 112, 130, 109 })]
	public override Hasher putChar(char P_0)
	{
		scratch.putChar(P_0);
		Hasher result = update(2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 66, 109 })]
	public override Hasher putLong(long P_0)
	{
		scratch.putLong(P_0);
		Hasher result = update(8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 60, 109 })]
	public override Hasher putInt(int P_0)
	{
		scratch.putInt(P_0);
		Hasher result = update(4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 116, 66, 109 })]
	public override Hasher putShort(short P_0)
	{
		scratch.putShort(P_0);
		Hasher result = update(2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 103 })]
	public override Hasher putBytes(ByteBuffer P_0)
	{
		update(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 41, 107, 105 })]
	public override Hasher putBytes(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		update(P_0, P_1, P_2);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 103, 103 })]
	public override Hasher putBytes(byte[] P_0)
	{
		Preconditions.checkNotNull(P_0);
		update(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 123, 131, 103 })]
	public override Hasher putByte(byte P_0)
	{
		int num = (sbyte)P_0;
		update((byte)num);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 104 })]
	internal AbstractByteHasher()
	{
		scratch = ByteBuffer.allocate(8).order(ByteOrder.LITTLE_ENDIAN);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putChar(char P_0)
	{
		Hasher result = this.putChar(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putLong(long P_0)
	{
		Hasher result = this.putLong(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putInt(int P_0)
	{
		Hasher result = this.putInt(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putShort(short P_0)
	{
		Hasher result = this.putShort(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putBytes(ByteBuffer P_0)
	{
		Hasher result = this.putBytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
	{
		Hasher result = this.putBytes(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putBytes(byte[] P_0)
	{
		Hasher result = this.putBytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override PrimitiveSink putByte(byte P_0)
	{
		int num = (sbyte)P_0;
		Hasher result = this.putByte((byte)num);
		_ = null;
		return result;
	}
}
