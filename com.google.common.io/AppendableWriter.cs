using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal class AppendableWriter : Writer
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Appendable target;

	private bool closed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 74, 104, 144 })]
	private void checkNotClosed()
	{
		if (closed)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException("Cannot write to a closed writer.");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 116, 66, 102, 109 })]
	public override Writer append(char P_0)
	{
		checkNotClosed();
		target.append(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 113, 138, 102, 127, 6 })]
	public override Writer append([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] CharSequence P_0, int P_1, int P_2)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		checkNotClosed();
		Appendable appendable = target;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = __003Cref_003E);
		appendable.append(csq, P_1, P_2);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 115, 170, 102, 125 })]
	public override Writer append([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		checkNotClosed();
		Appendable appendable = target;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = __003Cref_003E);
		appendable.append(csq);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 104, 113 })]
	internal AppendableWriter(Appendable P_0)
	{
		target = (Appendable)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 5, 166, 127, 5 })]
	public override void write(char[] P_0, int P_1, int P_2)
	{
		checkNotClosed();
		Appendable appendable = target;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = String.newhelper(P_0, P_1, P_2));
		appendable.append(csq);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 17, 102, 110 })]
	public override void write(int P_0)
	{
		checkNotClosed();
		target.append((char)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 23, 103, 102, 125 })]
	public override void write(string P_0)
	{
		Preconditions.checkNotNull(P_0);
		checkNotClosed();
		Appendable appendable = target;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = P_0);
		appendable.append(csq);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 30, 103, 134, 127, 6 })]
	public override void write(string P_0, int P_1, int P_2)
	{
		Preconditions.checkNotNull(P_0);
		checkNotClosed();
		Appendable appendable = target;
		int end = P_1 + P_2;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = P_0);
		appendable.append(csq, P_1, end);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 38, 102, 109, 146 })]
	public override void flush()
	{
		checkNotClosed();
		if (target is Flushable)
		{
			((Flushable)target).flush();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 46, 103, 109, 146 })]
	public override void close()
	{
		closed = true;
		if (target is Closeable)
		{
			((Closeable)target).close();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual Appendable append(char P_0)
	{
		Writer result = this.append(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual Appendable append([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] CharSequence P_0, int P_1, int P_2)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Writer result = this.append(charSequence2, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual Appendable append([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Writer result = this.append(charSequence2);
		_ = null;
		return result;
	}
}
