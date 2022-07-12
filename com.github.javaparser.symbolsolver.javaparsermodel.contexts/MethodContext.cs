
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class MethodContext : AbstractMethodLikeDeclarationContext
{
	
	
	public MethodContext(MethodDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List parametersExposedToChild(Node child)
	{
		if (((MethodDeclaration)wrappedNode).getBody().isPresent() && child == ((MethodDeclaration)wrappedNode).getBody().get())
		{
			NodeList parameters = ((MethodDeclaration)wrappedNode).getParameters();
			
			return parameters;
		}
		List result = Collections.emptyList();
		
		return result;
	}
}
