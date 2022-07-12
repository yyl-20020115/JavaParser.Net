
using com.github.javaparser.ast;

using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmUnindent: CsmElement
{
	
	
	public CsmUnindent()
	{
	}

	
	
	
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
