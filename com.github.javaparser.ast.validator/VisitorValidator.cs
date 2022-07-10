using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.visitor;
using IKVM.Attributes;
using java.util.function;

namespace com.github.javaparser.ast.validator;


public abstract class VisitorValidator : VoidVisitorAdapter, Validator, TypedValidator, BiConsumer
{
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void accept(Node node, ProblemReporter problemReporter)
	{
		node.accept(this, problemReporter);
	}

	
	
	public VisitorValidator()
	{
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void accept(object node, object problemReporter)
	{
		accept((Node)node, (ProblemReporter)problemReporter);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiConsumer andThen(BiConsumer P_0)
	{
		return BiConsumer._003Cdefault_003EandThen(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Processor processor()
	{
		return TypedValidator._003Cdefault_003Eprocessor(this);
	}
}
