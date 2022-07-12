
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class EnclosedExprContext : AbstractJavaParserContext
{
	
	
	public EnclosedExprContext(EnclosedExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List patternExprsExposedFromChildren()
	{
		ArrayList result = new ArrayList();
		if (!((EnclosedExpr)wrappedNode).getInner().isAssignExpr())
		{
			Context context = JavaParserFactory.getContext(((EnclosedExpr)wrappedNode).getInner(), typeSolver);
			if (!equals(context))
			{
				
				result = new ArrayList(context.patternExprsExposedFromChildren());
			}
		}
		return result;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		ArrayList result = new ArrayList();
		if (!((EnclosedExpr)wrappedNode).getInner().isAssignExpr())
		{
			Context context = JavaParserFactory.getContext(((EnclosedExpr)wrappedNode).getInner(), typeSolver);
			if (!equals(context))
			{
				
				result = new ArrayList(context.negatedPatternExprsExposedFromChildren());
			}
		}
		return result;
	}
}
