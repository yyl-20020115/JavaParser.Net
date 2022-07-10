using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithExpression
{
	
	public static class __DefaultMethods
	{
		public unsafe static Node setExpression(NodeWithExpression P_0, string P_1)
		{
			
			return _003Cdefault_003EsetExpression(P_0, P_1);
		}
	}

		
	Node setExpression(Expression expression);

	Expression getExpression();

	
		
	Node setExpression(string expression);

	
		
	static Node _003Cdefault_003EsetExpression(NodeWithExpression P_0, string P_1)
	{
		Node result = P_0.setExpression(StaticJavaParser.parseExpression(P_1));
		
		return result;
	}
}
