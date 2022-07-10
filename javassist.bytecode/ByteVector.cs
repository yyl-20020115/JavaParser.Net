using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("Bytecode.java")]
internal class ByteVector : Object, Cloneable.__Interface
{
	private byte[] buffer;

	private int size;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 103, 113 })]
	public virtual void add(int P_0)
	{
		addGap(1);
		buffer[size - 1] = (byte)(sbyte)P_0;
	}

	[LineNumberTable(new byte[] { 30, 113, 105, 107, 137, 103, 116, 167, 110 })]
	public virtual void addGap(int P_0)
	{
		if (size + P_0 > (nint)buffer.LongLength)
		{
			int num = size << 1;
			if (num < size + P_0)
			{
				num = size + P_0;
			}
			byte[] dest = new byte[num];
			ByteCodeHelper.arraycopy_primitive_1(buffer, 0, dest, 0, size);
			buffer = dest;
		}
		size += P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 168, 104, 109, 103 })]
	public ByteVector()
	{
		buffer = new byte[64];
		size = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.CloneNotSupportedException" })]
	[LineNumberTable(new byte[] { 159, 175, 108, 118 })]
	public override object clone()
	{
		ByteVector byteVector = (ByteVector)base.clone();
		byteVector.buffer = (byte[])buffer.Clone();
		return byteVector;
	}

	public int getSize()
	{
		return size;
	}

	[LineNumberTable(new byte[] { 159, 183, 108, 116 })]
	public byte[] copy()
	{
		byte[] array = new byte[size];
		ByteCodeHelper.arraycopy_primitive_1(buffer, 0, array, 0, size);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 109, 140 })]
	public virtual int read(int P_0)
	{
		if (P_0 < 0 || size <= P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArrayIndexOutOfBoundsException(P_0);
		}
		return buffer[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 109, 140, 106 })]
	public virtual void write(int P_0, int P_1)
	{
		if (P_0 < 0 || size <= P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArrayIndexOutOfBoundsException(P_0);
		}
		buffer[P_0] = (byte)(sbyte)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 16, 103, 113, 113 })]
	public virtual void add(int P_0, int P_1)
	{
		addGap(2);
		buffer[size - 2] = (byte)(sbyte)P_0;
		buffer[size - 1] = (byte)(sbyte)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 22, 103, 113, 113, 113, 114 })]
	public virtual void add(int P_0, int P_1, int P_2, int P_3)
	{
		addGap(4);
		buffer[size - 4] = (byte)(sbyte)P_0;
		buffer[size - 3] = (byte)(sbyte)P_1;
		buffer[size - 2] = (byte)(sbyte)P_2;
		buffer[size - 1] = (byte)(sbyte)P_3;
	}
}
