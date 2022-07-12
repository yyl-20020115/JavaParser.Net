
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class VariableDeclaratorContext : AbstractJavaParserContext
{
	
	
	public VariableDeclaratorContext(VariableDeclarator wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List localVariablesExposedToChild(Node child)
	{
		if (((VariableDeclarator)wrappedNode).getInitializer().isPresent() && ((VariableDeclarator)wrappedNode).getInitializer().get() == child)
		{
			List result = Collections.singletonList(wrappedNode);
			
			return result;
		}
		List result2 = Collections.emptyList();
		
		return result2;
	}

	
		
	public override List patternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		
		return result;
	}
}
