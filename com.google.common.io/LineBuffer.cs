using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal abstract class LineBuffer : Object
{
	private StringBuilder line;

	private bool sawReturn;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 120, 98, 127, 10, 114, 107, 103 })]
	private bool finishLine(bool P_0)
	{
		string text = (sawReturn ? ((!P_0) ? "\r" : "\r\n") : ((!P_0) ? "" : "\n"));
		handleLine(line.toString(), text);
		line = new StringBuilder();
		sawReturn = false;
		return P_0;
	}

	[Throws(new string[] { "java.io.IOException" })]
	protected internal abstract void handleLine(string P_0, string P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 176, 136 })]
	internal LineBuffer()
	{
		line = new StringBuilder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		1, 98, 140, 111, 196, 98, 107, 153, 113, 103,
		102, 113, 164, 100, 162, 113, 104, 100, 226, 47,
		233, 87, 115
	})]
	protected internal virtual void add(char[] P_0, int P_1, int P_2)
	{
		int i = P_1;
		if (sawReturn && P_2 > 0 && finishLine(P_0[i] == '\n'))
		{
			i++;
		}
		int num = i;
		for (int num2 = P_1 + P_2; i < num2; i++)
		{
			switch (P_0[i])
			{
			case '\r':
				line.append(P_0, num, i - num);
				sawReturn = true;
				if (i + 1 < num2 && finishLine(P_0[i + 1] == '\n'))
				{
					i++;
				}
				num = i + 1;
				break;
			case '\n':
				line.append(P_0, num, i - num);
				finishLine(true);
				num = i + 1;
				break;
			}
		}
		line.append(P_0, num, P_1 + P_2 - num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 53, 118, 136 })]
	protected internal virtual void finish()
	{
		if (sawReturn || line.length() > 0)
		{
			finishLine(false);
		}
	}
}
