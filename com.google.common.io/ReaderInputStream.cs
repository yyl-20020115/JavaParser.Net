using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio;
using java.nio.charset;
using java.util;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ReaderInputStream : InputStream
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Reader reader;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CharsetEncoder encoder;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private byte[] singleByte;

	private CharBuffer charBuffer;

	private ByteBuffer byteBuffer;

	private bool endOfInput;

	private bool draining;

	private bool doneFlushing;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 33, 163, 106, 106, 230, 59, 231, 71 })]
	internal ReaderInputStream(Reader P_0, Charset P_1, int P_2)
		: this(P_0, P_1.newEncoder().onMalformedInput(CodingErrorAction.REPLACE).onUnmappableCharacter(CodingErrorAction.REPLACE), P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		51, 232, 14, 236, 115, 113, 113, 111, 135, 108,
		139, 108
	})]
	internal ReaderInputStream(Reader P_0, CharsetEncoder P_1, int P_2)
	{
		singleByte = new byte[1];
		reader = (Reader)Preconditions.checkNotNull(P_0);
		encoder = (CharsetEncoder)Preconditions.checkNotNull(P_1);
		Preconditions.checkArgument(P_2 > 0, "bufferSize must be positive: %s", P_2);
		P_1.reset();
		charBuffer = CharBuffer.allocate(P_2);
		Java8Compatibility.flip(charBuffer);
		byteBuffer = ByteBuffer.allocate(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 138, 114, 111 })]
	private int drain(byte[] P_0, int P_1, int P_2)
	{
		int num = Math.min(P_2, byteBuffer.remaining());
		byteBuffer.get(P_0, P_1, num);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 83, 162, 107, 112, 154, 135 })]
	private void startDraining(bool P_0)
	{
		Java8Compatibility.flip(byteBuffer);
		if (P_0 && byteBuffer.remaining() == 0)
		{
			byteBuffer = ByteBuffer.allocate(byteBuffer.capacity() * 2);
		}
		else
		{
			draining = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 94, 109, 142, 178, 241, 69, 108, 127, 4,
		100, 137, 144
	})]
	private void readMoreChars()
	{
		if (availableCapacity(charBuffer) == 0)
		{
			if (charBuffer.position() > 0)
			{
				Java8Compatibility.flip(charBuffer.compact());
			}
			else
			{
				charBuffer = grow(charBuffer);
			}
		}
		int num = charBuffer.limit();
		int num2 = reader.read(charBuffer.array(), num, availableCapacity(charBuffer));
		if (num2 == -1)
		{
			endOfInput = true;
		}
		else
		{
			Java8Compatibility.limit(charBuffer, num + num2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(230)]
	private static int availableCapacity(Buffer P_0)
	{
		return P_0.capacity() - P_0.limit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 77, 116, 103, 108, 108 })]
	private static CharBuffer grow(CharBuffer P_0)
	{
		char[] array = Arrays.copyOf(P_0.array(), P_0.capacity() * 2);
		CharBuffer charBuffer = CharBuffer.wrap(array);
		Java8Compatibility.position(charBuffer, P_0.position());
		Java8Compatibility.limit(charBuffer, P_0.limit());
		return charBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 65, 109 })]
	public override void close()
	{
		reader.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(120)]
	public override int read()
	{
		return (base.read(singleByte) != 1) ? (-1) : UnsignedBytes.toInt(singleByte[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		78, 107, 99, 194, 98, 231, 70, 104, 112, 108,
		137, 103, 235, 71, 104, 104, 99, 148, 190, 136,
		103, 101, 232, 69, 99, 103, 103, 101, 104, 132,
		136, 136, 102, 130
	})]
	public override int read(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		if (P_2 == 0)
		{
			return 0;
		}
		int num = 0;
		int num2 = (endOfInput ? 1 : 0);
		while (true)
		{
			if (draining)
			{
				num += drain(P_0, P_1 + num, P_2 - num);
				if (num == P_2 || doneFlushing)
				{
					break;
				}
				draining = false;
				Java8Compatibility.clear(byteBuffer);
			}
			while (true)
			{
				CoderResult coderResult = (doneFlushing ? CoderResult.UNDERFLOW : ((num2 == 0) ? encoder.encode(charBuffer, byteBuffer, endOfInput) : encoder.flush(byteBuffer)));
				if (coderResult.isOverflow())
				{
					startDraining(true);
					break;
				}
				if (coderResult.isUnderflow())
				{
					if (num2 != 0)
					{
						doneFlushing = true;
						startDraining(false);
						break;
					}
					if (endOfInput)
					{
						num2 = 1;
					}
					else
					{
						readMoreChars();
					}
				}
				else if (coderResult.isError())
				{
					coderResult.throwException();
					return 0;
				}
			}
		}
		return (num <= 0) ? (-1) : num;
	}
}
