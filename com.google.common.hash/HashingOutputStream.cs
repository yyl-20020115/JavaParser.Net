using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public sealed class HashingOutputStream : FilterOutputStream
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Hasher hasher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 115, 118 })]
	public HashingOutputStream(HashFunction hashFunction, OutputStream @out)
		: base((OutputStream)Preconditions.checkNotNull(@out))
	{
		hasher = (Hasher)Preconditions.checkNotNull(hashFunction.newHasher());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 2, 110, 110 })]
	public override void write(int b)
	{
		hasher.putByte((byte)(sbyte)b);
		@out.write(b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 8, 111, 112 })]
	public override void write(byte[] bytes, int off, int len)
	{
		hasher.putBytes(bytes, off, len);
		@out.write(bytes, off, len);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	public virtual HashCode hash()
	{
		HashCode result = hasher.hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 25, 109 })]
	public override void close()
	{
		@out.close();
	}
}
