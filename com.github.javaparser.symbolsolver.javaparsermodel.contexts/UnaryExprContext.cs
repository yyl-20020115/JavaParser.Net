using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class UnaryExprContext : AbstractJavaParserContext
{
	
	
	public UnaryExprContext(UnaryExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List patternExprsExposedFromChildren()
	{
		ArrayList arrayList = new ArrayList();
		if (((UnaryExpr)wrappedNode).getOperator() == UnaryExpr.Operator.___003C_003ELOGICAL_COMPLEMENT)
		{
			Context context = JavaParserFactory.getContext(((UnaryExpr)wrappedNode).getExpression(), typeSolver);
			if (!equals(context))
			{
				((List)arrayList).addAll((Collection)context.negatedPatternExprsExposedFromChildren());
			}
		}
		return arrayList;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		ArrayList arrayList = new ArrayList();
		if (((UnaryExpr)wrappedNode).getOperator() == UnaryExpr.Operator.___003C_003ELOGICAL_COMPLEMENT)
		{
			Context context = JavaParserFactory.getContext(((UnaryExpr)wrappedNode).getExpression(), typeSolver);
			if (!equals(context))
			{
				((List)arrayList).addAll((Collection)context.patternExprsExposedFromChildren());
			}
		}
		return arrayList;
	}
}
