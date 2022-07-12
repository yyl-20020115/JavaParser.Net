
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public class PatternSymbolDeclarator : AbstractSymbolDeclarator
{
	
	
	public PatternSymbolDeclarator(PatternExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List getSymbolDeclarations()
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).add((object)JavaParserSymbolDeclaration.patternVar((PatternExpr)wrappedNode, typeSolver));
		return linkedList;
	}
}
