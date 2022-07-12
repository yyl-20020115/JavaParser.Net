
using com.github.javaparser.ast.body;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public class FieldSymbolDeclarator : AbstractSymbolDeclarator
{
	
	
	public FieldSymbolDeclarator(FieldDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List getSymbolDeclarations()
	{
		LinkedList linkedList = new LinkedList();
		Iterator iterator = ((FieldDeclaration)wrappedNode).getVariables().iterator();
		while (iterator.hasNext())
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)iterator.next();
			((List)linkedList).add((object)JavaParserSymbolDeclaration.field(variableDeclarator, typeSolver));
		}
		return linkedList;
	}
}
