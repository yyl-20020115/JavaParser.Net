
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ConstructorContext : AbstractMethodLikeDeclarationContext
{
	
	
	public ConstructorContext(ConstructorDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List parametersExposedToChild(Node child)
	{
		if (child == ((ConstructorDeclaration)wrappedNode).getBody())
		{
			NodeList parameters = ((ConstructorDeclaration)wrappedNode).getParameters();
			
			return parameters;
		}
		List result = Collections.emptyList();
		
		return result;
	}
}
