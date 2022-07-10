using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util.function;

namespace com.github.javaparser.ast.validator;


public interface Validator : TypedValidator, BiConsumer
{
	
	public new static class __DefaultMethods
	{
		public unsafe static void accept(Validator P_0, object P_1, object P_2)
		{
			
			_003Cdefault_003Eaccept(P_0, P_1, P_2);
		}
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	void accept(Node node, ProblemReporter problemReporter);

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	void accept(object node, object problemReporter);

	
	
	
	static void _003Cdefault_003Eaccept(Validator P_0, object P_1, object P_2)
	{
		P_0.accept((Node)P_1, (ProblemReporter)P_2);
	}
}
