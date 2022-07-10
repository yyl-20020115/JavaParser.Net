using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation.changes;

public class NoChange: Change
{
	
	
	public NoChange()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual object getValue(ObservableProperty property, Node node)
	{
		object rawValue = property.getRawValue(node);
		
		return rawValue;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool evaluate(CsmConditional P_0, Node P_1)
	{
		return Change._003Cdefault_003Eevaluate(this, P_0, P_1);
	}
}
