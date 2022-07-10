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
internal class MultiReader : Reader
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Iterator<+Lcom/google/common/io/CharSource;>;")]
	private Iterator it;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Reader current;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/util/Iterator<+Lcom/google/common/io/CharSource;>;)V")]
	[LineNumberTable(new byte[] { 159, 180, 104, 103, 104 })]
	internal MultiReader(Iterator P_0)
	{
		it = P_0;
		advance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 187, 102, 109, 155 })]
	private void advance()
	{
		close();
		if (it.hasNext())
		{
			current = ((CharSource)it.next()).openStream();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 37, 136, 143, 103, 35, 98, 130 })]
	public override void close()
	{
		if (current != null)
		{
			try
			{
				current.close();
			}
			finally
			{
				current = null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 3, 103, 104, 130, 111, 100, 102, 140 })]
	public override int read(char[] P_0, int P_1, int P_2)
	{
		Preconditions.checkNotNull(P_0);
		if (current == null)
		{
			return -1;
		}
		int num = current.read(P_0, P_1, P_2);
		if (num == -1)
		{
			advance();
			int result = read(P_0, P_1, P_2);
			_ = null;
			return result;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 17, 114, 101, 104, 109, 101, 130, 102, 130 })]
	public override long skip(long P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, (object)"n is negative");
		if (P_0 > 0)
		{
			while (current != null)
			{
				long num = current.skip(P_0);
				if (num > 0)
				{
					return num;
				}
				advance();
			}
		}
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(82)]
	public override bool ready()
	{
		return (current != null && current.ready()) ? true : false;
	}
}
