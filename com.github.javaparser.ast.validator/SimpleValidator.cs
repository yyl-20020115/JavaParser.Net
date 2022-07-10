using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.validator;

public class SimpleValidator : SingleNodeTypeValidator
{
	
	private sealed class ___003C_003EAnon0 : TypedValidator
	{
		private readonly Predicate arg_00241;

		private readonly BiConsumer arg_00242;

		internal ___003C_003EAnon0(Predicate P_0, BiConsumer P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00240(arg_00241, arg_00242, P_0, P_1);
			
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public void accept(object P_0, object P_1)
		{
			TypedValidator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public SimpleValidator(Class type, Predicate condition, BiConsumer problemSupplier)
		: base(type, new ___003C_003EAnon0(condition, problemSupplier))
	{
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00240(Predicate condition, BiConsumer problemSupplier, Node node, ProblemReporter problemReporter)
	{
		if (condition.test(node))
		{
			problemSupplier.accept(node, problemReporter);
		}
	}
}
