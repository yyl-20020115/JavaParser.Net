using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmIndent:CsmElement
{
	
	
	public CsmIndent()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		printer.indent();
	}

	public override int GetHashCode()
	{
		return 1;
	}

	
	
	public override bool Equals(object obj)
	{
		return obj is CsmIndent;
	}
}
