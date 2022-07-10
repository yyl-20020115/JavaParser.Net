using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.DataOutput" })]
public sealed class LittleEndianDataOutputStream : FilterOutputStream, DataOutput
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 108, 114, 118 })]
	public virtual void writeShort(int v)
	{
		@out.write(0xFF & v);
		@out.write(0xFF & (v >> 8));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 36, 105 })]
	public virtual void writeChar(int v)
	{
		writeShort(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 96, 108, 108 })]
	public virtual void writeLong(long v)
	{
		byte[] array = Longs.toByteArray(Long.reverseBytes(v));
		write(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 82, 114, 116, 117, 119 })]
	public virtual void writeInt(int v)
	{
		@out.write(0xFF & v);
		@out.write(0xFF & (v >> 8));
		@out.write(0xFF & (v >> 16));
		@out.write(0xFF & (v >> 24));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 5, 112 })]
	public override void write(byte[] b, int off, int len)
	{
		@out.write(b, off, len);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 120 })]
	public LittleEndianDataOutputStream(OutputStream @out)
		: base(new DataOutputStream((OutputStream)Preconditions.checkNotNull(@out)))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 127, 66, 115 })]
	public virtual void writeBoolean(bool v)
	{
		((DataOutputStream)@out).writeBoolean(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 15, 115 })]
	public virtual void writeByte(int v)
	{
		((DataOutputStream)@out).writeByte(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 25, 115 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual void writeBytes(string s)
	{
		((DataOutputStream)@out).writeBytes(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 47, 107, 45, 166 })]
	public virtual void writeChars(string s)
	{
		for (int i = 0; i < java.lang.String.instancehelper_length(s); i++)
		{
			writeChar(java.lang.String.instancehelper_charAt(s, i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 60, 111 })]
	public virtual void writeDouble(double v)
	{
		writeLong(java.lang.Double.doubleToLongBits(v));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 71, 111 })]
	public virtual void writeFloat(float v)
	{
		writeInt(Float.floatToIntBits(v));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 114, 115 })]
	public virtual void writeUTF(string str)
	{
		((DataOutputStream)@out).writeUTF(str);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 122, 109 })]
	public override void close()
	{
		@out.close();
	}

	void DataOutput.DataOutput_003A_003Awrite(int P_0)
	{
		write(P_0);
	}

	void DataOutput.DataOutput_003A_003Awrite(byte[] P_0)
	{
		write(P_0);
	}
}
