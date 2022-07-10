using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;


public interface NodeWithScope : NodeWithTraversableScope
{
	
	public static class __DefaultMethods
	{
		public unsafe static Optional traverseScope(NodeWithScope P_0)
		{
			
			return _003Cdefault_003EtraverseScope(P_0);
		}
	}

	virtual Expression getScope();

		
	virtual Node setScope(Expression scope);

	
		Optional traverseScope();

	
	
	
	static Optional _003Cdefault_003EtraverseScope(NodeWithScope P_0)
	{
		Optional result = Optional.of(P_0.getScope());
		
		return result;
	}
}
