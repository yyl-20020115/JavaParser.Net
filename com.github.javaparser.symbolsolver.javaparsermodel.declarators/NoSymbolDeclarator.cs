
using com.github.javaparser.ast;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public class NoSymbolDeclarator : AbstractSymbolDeclarator
{
	
		
	public NoSymbolDeclarator(Node wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List getSymbolDeclarations()
	{
		List result = Collections.emptyList();
		
		return result;
	}
}
