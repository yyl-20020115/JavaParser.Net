
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.printer.concretesyntaxmodel;

using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation.changes;

public class NoChange: Change
{
	
	
	public NoChange()
	{
	}

	
	
	
	public virtual object getValue(ObservableProperty property, Node node)
	{
		object rawValue = property.getRawValue(node);
		
		return rawValue;
	}


	public virtual bool evaluate(CsmConditional P_0, Node P_1)
	{
		return Change._003Cdefault_003Eevaluate(this, P_0, P_1);
	}
}
