using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public class ParameterSymbolDeclarator : AbstractSymbolDeclarator
{
	
	
	public ParameterSymbolDeclarator(Parameter wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List getSymbolDeclarations()
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).add((object)JavaParserSymbolDeclaration.parameter((Parameter)wrappedNode, typeSolver));
		return linkedList;
	}
}
