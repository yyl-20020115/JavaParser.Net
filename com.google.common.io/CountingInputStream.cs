using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class CountingInputStream : FilterInputStream
{
	private long count;

	private new long m_mark;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 243, 56, 232, 73 })]
	public CountingInputStream(InputStream @in)
		: base((InputStream)Preconditions.checkNotNull(@in))
	{
		this.m_mark = -1L;
	}

	public virtual long getCount()
	{
		return count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 5, 110, 100, 143 })]
	public override int read()
	{
		int num = @in.read();
		if (num != -1)
		{
			count++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 14, 113, 100, 143 })]
	public override int read(byte[] b, int off, int len)
	{
		int num = @in.read(b, off, len);
		if (num != -1)
		{
			count += num;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 23, 111, 110 })]
	public override long skip(long n)
	{
		long num = @in.skip(n);
		count += num;
		return num;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 30, 110, 140 })]
	public override void mark(int readlimit)
	{
		@in.mark(readlimit);
		this.m_mark = count;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 37, 111, 144, 106, 176, 109, 108 })]
	public override void reset()
	{
		if (!@in.markSupported())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException("Mark not supported");
		}
		if (this.m_mark == -1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException("Mark not set");
		}
		@in.reset();
		count = this.m_mark;
	}
}
