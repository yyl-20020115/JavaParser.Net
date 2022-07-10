using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CharSequenceReader : Reader
{
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private CharSequence seq;

	private int pos;

	private new int m_mark;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 116 })]
	private int remaining()
	{
		CharSequence charSequence = seq;
		java.util.Objects.requireNonNull(charSequence.___003Cref_003E);
		CharSequence charSequence2 = seq;
		CharSequence charSequence3 = default(CharSequence);
		object obj = (charSequence3.___003Cref_003E = charSequence2.___003Cref_003E);
		return charSequence3.length() - pos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 191, 112, 144 })]
	private void checkOpen()
	{
		CharSequence charSequence = seq;
		if (charSequence.___003Cref_003E == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException("reader closed");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	private bool hasRemaining()
	{
		return remaining() > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 131, 74, 104, 127, 4 })]
	public CharSequenceReader(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		base._002Ector();
		object obj = Preconditions.checkNotNull(__003Cref_003E);
		CharSequence.Cast(obj);
		CharSequence charSequence2 = default(CharSequence);
		object obj2 = (charSequence2.___003Cref_003E = obj);
		seq = charSequence2;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		27, 103, 102, 116, 104, 130, 114, 102, 63, 36,
		166
	})]
	public override int read(CharBuffer P_0)
	{
		Preconditions.checkNotNull(P_0);
		checkOpen();
		CharSequence charSequence = seq;
		java.util.Objects.requireNonNull(charSequence.___003Cref_003E);
		if (!hasRemaining())
		{
			return -1;
		}
		int num = Math.min(P_0.remaining(), remaining());
		CharSequence charSequence3 = default(CharSequence);
		for (int i = 0; i < num; i++)
		{
			CharSequence charSequence2 = seq;
			object __003Cref_003E = charSequence2.___003Cref_003E;
			int num2 = pos;
			int num3 = num2;
			pos = num2 + 1;
			num2 = num3;
			object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			P_0.put(charSequence3.charAt(num2));
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 42, 102, 116 })]
	public override int read()
	{
		checkOpen();
		CharSequence charSequence = seq;
		java.util.Objects.requireNonNull(charSequence.___003Cref_003E);
		int result;
		if (hasRemaining())
		{
			CharSequence charSequence2 = seq;
			object __003Cref_003E = charSequence2.___003Cref_003E;
			int num = pos;
			int num2 = num;
			pos = num + 1;
			num = num2;
			CharSequence charSequence3 = default(CharSequence);
			object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			result = charSequence3.charAt(num);
		}
		else
		{
			result = -1;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		49, 107, 102, 116, 104, 130, 109, 102, 63, 34,
		166
	})]
	public override int read(char[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		checkOpen();
		CharSequence charSequence = seq;
		java.util.Objects.requireNonNull(charSequence.___003Cref_003E);
		if (!hasRemaining())
		{
			return -1;
		}
		int num = Math.min(P_2, remaining());
		CharSequence charSequence3 = default(CharSequence);
		for (int i = 0; i < num; i++)
		{
			int num2 = P_1 + i;
			CharSequence charSequence2 = seq;
			object __003Cref_003E = charSequence2.___003Cref_003E;
			int num3 = pos;
			int num4 = num3;
			pos = num3 + 1;
			num3 = num4;
			object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			P_0[num2] = charSequence3.charAt(num3);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 64, 115, 102, 111, 110 })]
	public override long skip(long P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "n (%s) may not be negative", P_0);
		checkOpen();
		int num = (int)Math.min(remaining(), P_0);
		pos += num;
		return num;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 73, 102 })]
	public override bool ready()
	{
		checkOpen();
		return true;
	}

	public override bool markSupported()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 84, 114, 102, 108 })]
	public override void mark(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "readAheadLimit (%s) may not be negative", P_0);
		checkOpen();
		this.m_mark = pos;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 91, 102, 108 })]
	public override void reset()
	{
		checkOpen();
		pos = this.m_mark;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[Throws(new string[] { "java.io.IOException" })]
	public override void close()
	{
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = null);
		seq = charSequence;
	}
}
