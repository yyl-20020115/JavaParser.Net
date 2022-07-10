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
public sealed class LineReader : Object
{
	[SpecialName]
	[EnclosingMethod(null, null, null)]
	internal class _1 : LineBuffer
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LineReader this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(49)]
		internal _1(LineReader P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 2, 114 })]
		protected internal override void handleLine(string P_0, string P_1)
		{
			access_0024000(this_00240).add(P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Readable readable;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Reader reader;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CharBuffer cbuf;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char[] buf;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Queue<Ljava/lang/String;>;")]
	private Queue lines;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private LineBuffer lineBuf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 232, 51, 107, 145, 107, 236, 74, 113, 119 })]
	public LineReader(Readable readable)
	{
		cbuf = CharStreams.createBuffer();
		buf = cbuf.array();
		lines = new ArrayDeque();
		lineBuf = new _1(this);
		this.readable = (Readable)Preconditions.checkNotNull(readable);
		reader = ((!(readable is Reader)) ? null : ((Reader)readable));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 24, 112, 171, 127, 22, 100, 107, 130, 115, 101 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual string readLine()
	{
		while (lines.peek() == null)
		{
			Java8Compatibility.clear(cbuf);
			int num = ((reader == null) ? readable.read(cbuf) : reader.read(buf, 0, buf.Length));
			if (num == -1)
			{
				lineBuf.finish();
				break;
			}
			lineBuf.add(buf, 0, num);
		}
		return (string)lines.poll();
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	internal static Queue access_0024000(LineReader P_0)
	{
		return P_0.lines;
	}
}
