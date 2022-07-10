using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler;

[SourceFile("Lex.java")]
internal class Token : Object
{
	public Token next;

	public int tokenId;

	public long longValue;

	public double doubleValue;

	public string textValue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 161, 104 })]
	internal Token()
	{
		next = null;
	}
}
