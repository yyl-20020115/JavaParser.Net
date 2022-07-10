using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class CountingOutputStream : FilterOutputStream
{
	private long count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 115 })]
	public CountingOutputStream(OutputStream @out)
		: base((OutputStream)Preconditions.checkNotNull(@out))
	{
	}

	public virtual long getCount()
	{
		return count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 2, 110, 111 })]
	public override void write(byte[] b, int off, int len)
	{
		@out.write(b, off, len);
		count += len;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 8, 108, 111 })]
	public override void write(int b)
	{
		@out.write(b);
		count++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 17, 109 })]
	public override void close()
	{
		@out.close();
	}
}
