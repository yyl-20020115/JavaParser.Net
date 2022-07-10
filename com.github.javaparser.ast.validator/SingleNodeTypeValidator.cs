using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.validator;


public class SingleNodeTypeValidator: Validator, TypedValidator, BiConsumer
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly SingleNodeTypeValidator arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon0(SingleNodeTypeValidator P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024accept_00240(arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		private Class type;

	
		private TypedValidator validator;

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public SingleNodeTypeValidator(Class type, TypedValidator validator)
	{
		this.type = type;
		this.validator = validator;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void accept(Node node, ProblemReporter problemReporter)
	{
		if (type.isInstance(node))
		{
			validator.accept((Node)type.cast(node), problemReporter);
		}
		node.findAll(type).forEach(new ___003C_003EAnon0(this, problemReporter));
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024accept_00240(ProblemReporter problemReporter, Node n)
	{
		validator.accept(n, problemReporter);
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
