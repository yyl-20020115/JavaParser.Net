using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmNone: CsmElement
{
	
	
	public CsmNone()
	{
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
	}
}
