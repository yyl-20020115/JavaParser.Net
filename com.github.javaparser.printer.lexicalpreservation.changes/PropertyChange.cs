using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation.changes;

public class PropertyChange: Change
{
	
	private ObservableProperty property;

	
	private object oldValue;

	
	private object newValue;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public PropertyChange(ObservableProperty property, object oldValue, object newValue)
	{
		this.property = property;
		this.oldValue = oldValue;
		this.newValue = newValue;
	}

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	public virtual object getOldValue()
	{
		return oldValue;
	}

	public virtual object getNewValue()
	{
		return newValue;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual object getValue(ObservableProperty property, Node node)
	{
		if (property == this.property)
		{
			return newValue;
		}
		object rawValue = property.getRawValue(node);
		
		return rawValue;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool evaluate(CsmConditional P_0, Node P_1)
	{
		return Change._003Cdefault_003Eevaluate(this, P_0, P_1);
	}
}
