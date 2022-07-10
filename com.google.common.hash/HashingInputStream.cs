using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public sealed class HashingInputStream : FilterInputStream
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Hasher hasher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 115, 118 })]
	public HashingInputStream(HashFunction hashFunction, InputStream @in)
		: base((InputStream)Preconditions.checkNotNull(@in))
	{
		hasher = (Hasher)Preconditions.checkNotNull(hashFunction.newHasher());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 4, 110, 100, 142 })]
	public override int read()
	{
		int num = @in.read();
		if (num != -1)
		{
			hasher.putByte((byte)(sbyte)num);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 18, 113, 100, 143 })]
	public override int read(byte[] bytes, int off, int len)
	{
		int num = @in.read(bytes, off, len);
		if (num != -1)
		{
			hasher.putBytes(bytes, off, num);
		}
		return num;
	}

	public override bool markSupported()
	{
		return false;
	}

	public override void mark(int readlimit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(96)]
	public override void reset()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException("reset not supported");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual HashCode hash()
	{
		HashCode result = hasher.hash();
		_ = null;
		return result;
	}
}
