using System.ComponentModel;


using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator;


public class TreeVisitorValidator: Validator, TypedValidator, BiConsumer
{
	
	private Validator validator;

	
	
	
	public TreeVisitorValidator(Validator validator)
	{
		this.validator = validator;
	}

	
	
	
	public void accept(Node node, ProblemReporter reporter)
	{
		validator.accept(node, reporter);
		Iterator iterator = node.getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			accept(node2, reporter);
		}
	}

	
	
	
	
	
	public virtual void accept(object node, object reporter)
	{
		accept((Node)node, (ProblemReporter)reporter);
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
