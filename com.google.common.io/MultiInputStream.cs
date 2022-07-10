using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal sealed class MultiInputStream : InputStream
{
	[Signature("Ljava/util/Iterator<+Lcom/google/common/io/ByteSource;>;")]
	private Iterator it;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private InputStream @in;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/util/Iterator<+Lcom/google/common/io/ByteSource;>;)V")]
	[LineNumberTable(new byte[] { 159, 186, 104, 113, 104 })]
	public MultiInputStream(Iterator P_0)
	{
		it = (Iterator)Preconditions.checkNotNull(P_0);
		advance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 12, 102, 109, 155 })]
	private void advance()
	{
		close();
		if (it.hasNext())
		{
			@in = ((ByteSource)it.next()).openStream();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 1, 136, 143, 103, 35, 98, 130 })]
	public override void close()
	{
		if (@in != null)
		{
			try
			{
				@in.close();
			}
			finally
			{
				@in = null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 33, 104, 108, 100, 130, 102, 98 })]
	public override int read()
	{
		while (@in != null)
		{
			int num = @in.read();
			if (num != -1)
			{
				return num;
			}
			advance();
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 20, 104, 130 })]
	public override int available()
	{
		if (@in == null)
		{
			return 0;
		}
		int result = @in.available();
		_ = null;
		return result;
	}

	public override bool markSupported()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 45, 103, 104, 111, 100, 130, 102, 98 })]
	public override int read(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkNotNull(P_0);
		while (@in != null)
		{
			int num = @in.read(P_0, P_1, P_2);
			if (num != -1)
			{
				return num;
			}
			advance();
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 58, 109, 131, 109, 101, 130, 105, 131 })]
	public override long skip(long P_0)
	{
		if (@in == null || P_0 <= 0)
		{
			return 0L;
		}
		long num = @in.skip(P_0);
		if (num != 0)
		{
			return num;
		}
		if (read() == -1)
		{
			return 0L;
		}
		return 1 + @in.skip(P_0 - 1);
	}
}
