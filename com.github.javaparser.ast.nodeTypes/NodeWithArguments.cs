using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes;

public class NodeWithArguments
{
	
	public static class __DefaultMethods
	{
		public unsafe static Expression getArgument(NodeWithArguments P_0, int P_1)
		{
			
			return _003Cdefault_003EgetArgument(P_0, P_1);
		}

		public unsafe static Node addArgument(NodeWithArguments P_0, string P_1)
		{
			
			return _003Cdefault_003EaddArgument(P_0, P_1);
		}

		public unsafe static Node addArgument(NodeWithArguments P_0, Expression P_1)
		{
			
			return _003Cdefault_003EaddArgument(P_0, P_1);
		}

		public unsafe static Node setArgument(NodeWithArguments P_0, int P_1, Expression P_2)
		{
			
			return _003Cdefault_003EsetArgument(P_0, P_1, P_2);
		}
	}

	
		
	virtual Node addArgument(string arg);

	
	
	
	static Node _003Cdefault_003EaddArgument(NodeWithArguments P_0, string P_1)
	{
		Node result = P_0.addArgument(StaticJavaParser.parseExpression(P_1));
		
		return result;
	}

		virtual NodeList getArguments();

	
		
	virtual Node addArgument(Expression arg);

	
	
	
	static Node _003Cdefault_003EaddArgument(NodeWithArguments P_0, Expression P_1)
	{
		P_0.getArguments().add(P_1);
		return (Node)P_0;
	}

		
	virtual Node setArguments(NodeList arguments);

	
	
	virtual Expression getArgument(int i);

	
	
	
	static Expression _003Cdefault_003EgetArgument(NodeWithArguments P_0, int P_1)
	{
		return (Expression)P_0.getArguments().get(P_1);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual Node setArgument(int i, Expression arg);

	
	
	
	static Node _003Cdefault_003EsetArgument(NodeWithArguments P_0, int P_1, Expression P_2)
	{
		P_0.getArguments().set(P_1, P_2);
		return (Node)P_0;
	}
}
