
using com.github.javaparser.ast;

using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmIndent:CsmElement
{
	
	
	public CsmIndent()
	{
	}

	
	
	
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
