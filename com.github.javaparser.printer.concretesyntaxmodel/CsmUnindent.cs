using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmUnindent: CsmElement
{
	
	
	public CsmUnindent()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		printer.unindent();
	}

	public override int GetHashCode()
	{
		return 2;
	}

	
	
	public override bool Equals(object obj)
	{
		return obj is CsmUnindent;
	}
}
