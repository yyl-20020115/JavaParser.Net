using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;


public interface NodeWithOptionalScope : NodeWithTraversableScope
{
	
	public static class __DefaultMethods
	{
		public unsafe static Optional traverseScope(NodeWithOptionalScope P_0)
		{
			
			return _003Cdefault_003EtraverseScope(P_0);
		}
	}

		virtual Optional getScope();

		
	virtual Node setScope(Expression scope);

		virtual Node removeScope();

	
		Optional traverseScope();

	
	
	
	static Optional _003Cdefault_003EtraverseScope(NodeWithOptionalScope P_0)
	{
		Optional scope = P_0.getScope();
		
		return scope;
	}
}
