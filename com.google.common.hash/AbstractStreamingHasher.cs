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
internal abstract class AbstractStreamingHasher : AbstractHasher
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ByteBuffer buffer;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int bufferSize;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int chunkSize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 136, 215, 120, 103, 103 })]
	protected internal AbstractStreamingHasher(int P_0, int P_1)
	{
		Preconditions.checkArgument((P_0 == -1 || P_1 % P_0 == 0) ? true : false);
		buffer = ByteBuffer.allocate(P_1 + 7).order(ByteOrder.LITTLE_ENDIAN);
		bufferSize = P_1;
		chunkSize = P_0;
	}

	protected internal abstract void process(ByteBuffer P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		62, 115, 109, 102, 194, 115, 102, 51, 166, 166,
		110, 201, 109
	})]
	private Hasher putBytesInternal(ByteBuffer P_0)
	{
		if (P_0.remaining() <= buffer.remaining())
		{
			buffer.put(P_0);
			munchIfFull();
			return this;
		}
		int num = bufferSize - buffer.position();
		for (int i = 0; i < num; i++)
		{
			buffer.put((byte)(sbyte)P_0.get());
		}
		munch();
		while (P_0.remaining() >= chunkSize)
		{
			process(P_0);
		}
		buffer.put(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 86, 142, 136 })]
	private void munchIfFull()
	{
		if (buffer.remaining() < 8)
		{
			munch();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 93, 107, 179, 142, 108 })]
	private void munch()
	{
		Java8Compatibility.flip(buffer);
		while (buffer.remaining() >= chunkSize)
		{
			process(buffer);
		}
		buffer.compact();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 108, 110, 110, 139, 108, 102, 105 })]
	protected internal virtual void processRemaining(ByteBuffer P_0)
	{
		Java8Compatibility.position(P_0, P_0.limit());
		Java8Compatibility.limit(P_0, chunkSize + 7);
		while (P_0.position() < chunkSize)
		{
			P_0.putLong(0L);
		}
		Java8Compatibility.limit(P_0, chunkSize);
		Java8Compatibility.flip(P_0);
		process(P_0);
	}

	protected internal abstract HashCode makeHash();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 102, 98, 109, 102 })]
	public sealed override Hasher putChar(char P_0)
	{
		buffer.putChar(P_0);
		munchIfFull();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 125, 109, 102 })]
	public sealed override Hasher putLong(long P_0)
	{
		buffer.putLong(P_0);
		munchIfFull();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 118, 109, 102 })]
	public sealed override Hasher putInt(int P_0)
	{
		buffer.putInt(P_0);
		munchIfFull();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 104, 130, 109, 102 })]
	public sealed override Hasher putShort(short P_0)
	{
		buffer.putShort(P_0);
		munchIfFull();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 51, 135, 108, 140, 104, 35, 2 })]
	public sealed override Hasher putBytes(ByteBuffer P_0)
	{
		ByteOrder bo = P_0.order();
		try
		{
			P_0.order(ByteOrder.LITTLE_ENDIAN);
			return putBytesInternal(P_0);
		}
		finally
		{
			P_0.order(bo);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public sealed override Hasher putBytes(byte[] P_0, int P_1, int P_2)
	{
		Hasher result = putBytesInternal(ByteBuffer.wrap(P_0, P_1, P_2).order(ByteOrder.LITTLE_ENDIAN));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 106, 163, 109, 102 })]
	public sealed override Hasher putByte(byte P_0)
	{
		int b = (sbyte)P_0;
		buffer.put((byte)b);
		munchIfFull();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 106 })]
	protected internal AbstractStreamingHasher(int P_0)
		: this(P_0, P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 68, 102, 107, 110, 108, 150 })]
	public sealed override HashCode hash()
	{
		munch();
		Java8Compatibility.flip(buffer);
		if (buffer.remaining() > 0)
		{
			processRemaining(buffer);
			Java8Compatibility.position(buffer, buffer.limit());
		}
		HashCode result = makeHash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putChar(char P_0)
	{
		Hasher result = this.putChar(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putLong(long P_0)
	{
		Hasher result = this.putLong(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putInt(int P_0)
	{
		Hasher result = this.putInt(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putShort(short P_0)
	{
		Hasher result = this.putShort(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putBytes(ByteBuffer P_0)
	{
		Hasher result = this.putBytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
	{
		Hasher result = this.putBytes(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override PrimitiveSink putByte(byte P_0)
	{
		int num = (sbyte)P_0;
		Hasher result = this.putByte((byte)num);
		_ = null;
		return result;
	}
}
