
using com.github.javaparser.ast.expr;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithOptionalLabel
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static Optional lambda_0024getLabelAsString_00240(SimpleName l)
		{
			Optional result = Optional.of(l.getIdentifier());
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Node setLabel(NodeWithOptionalLabel P_0, string P_1)
		{
			
			return _003Cdefault_003EsetLabel(P_0, P_1);
		}

		public unsafe static Optional getLabelAsString(NodeWithOptionalLabel P_0)
		{
			
			return _003Cdefault_003EgetLabelAsString(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Optional result = ___003C_003EPIM.lambda_0024getLabelAsString_00240((SimpleName)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

		
	virtual Node setLabel(SimpleName label);

		virtual Optional getLabel();

		virtual Node removeLabel();

	
		
	virtual Node setLabel(string label);

	
	
	
	static Node _003Cdefault_003EsetLabel(NodeWithOptionalLabel P_0, string P_1)
	{
		Utils.assertNonEmpty(P_1);
		Node result = P_0.setLabel(new SimpleName(P_1));
		
		return result;
	}

	
		virtual Optional getLabelAsString();

	
	
	
	static Optional _003Cdefault_003EgetLabelAsString(NodeWithOptionalLabel P_0)
	{
		Optional result = P_0.getLabel().flatMap(new ___003C_003EAnon1());
		
		return result;
	}
}
