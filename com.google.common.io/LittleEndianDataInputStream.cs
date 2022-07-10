using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.DataInput" })]
public sealed class LittleEndianDataInputStream : FilterInputStream, DataInput
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.io.EOFException" })]
	[LineNumberTable(new byte[] { 160, 118, 142, 100, 171 })]
	private byte readAndCheckByte()
	{
		int num = @in.read();
		if (-1 == num)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new EOFException();
		}
		return (byte)(sbyte)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 68, 104, 104, 104, 136 })]
	public virtual int readInt()
	{
		int b = (sbyte)readAndCheckByte();
		int b2 = (sbyte)readAndCheckByte();
		int b3 = (sbyte)readAndCheckByte();
		int b4 = (sbyte)readAndCheckByte();
		int result = Ints.fromBytes((byte)b4, (byte)b3, (byte)b2, (byte)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 87, 104, 104, 104, 104, 105, 105, 105, 137 })]
	public virtual long readLong()
	{
		int b = (sbyte)readAndCheckByte();
		int b2 = (sbyte)readAndCheckByte();
		int b3 = (sbyte)readAndCheckByte();
		int b4 = (sbyte)readAndCheckByte();
		int b5 = (sbyte)readAndCheckByte();
		int b6 = (sbyte)readAndCheckByte();
		int b7 = (sbyte)readAndCheckByte();
		int b8 = (sbyte)readAndCheckByte();
		long result = Longs.fromBytes((byte)b8, (byte)b7, (byte)b6, (byte)b5, (byte)b4, (byte)b3, (byte)b2, (byte)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 51, 104, 136 })]
	public virtual int readUnsignedShort()
	{
		int b = (sbyte)readAndCheckByte();
		int b2 = (sbyte)readAndCheckByte();
		int result = Ints.fromBytes(0, 0, (byte)b2, (byte)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 32, 110, 100, 171 })]
	public virtual int readUnsignedByte()
	{
		int num = @in.read();
		if (0 > num)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new EOFException();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 115 })]
	public LittleEndianDataInputStream(InputStream @in)
		: base((InputStream)Preconditions.checkNotNull(@in))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(61)]
	public virtual string readLine()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("readLine is not supported");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 16, 105 })]
	public virtual void readFully(byte[] b)
	{
		ByteStreams.readFully(this, b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 21, 107 })]
	public virtual void readFully(byte[] b, int off, int len)
	{
		ByteStreams.readFully(this, b, off, len);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(76)]
	public virtual int skipBytes(int n)
	{
		return (int)@in.skip(n);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(160)]
	public virtual float readFloat()
	{
		FloatConverter converter = default(FloatConverter);
		float result = FloatConverter.ToFloat(readInt(), ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(174)]
	public virtual double readDouble()
	{
		DoubleConverter converter = default(DoubleConverter);
		double result = DoubleConverter.ToDouble(readLong(), ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(180)]
	public virtual string readUTF()
	{
		string result = new DataInputStream(@in).readUTF();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(194)]
	public virtual short readShort()
	{
		return (short)readUnsignedShort();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(208)]
	public virtual char readChar()
	{
		return (char)readUnsignedShort();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(214)]
	public virtual byte readByte()
	{
		return (byte)(sbyte)readUnsignedByte();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(220)]
	public virtual bool readBoolean()
	{
		return (readUnsignedByte() != 0) ? true : false;
	}
}
