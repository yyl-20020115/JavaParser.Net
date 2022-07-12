
using com.github.javaparser.resolution.types;

using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.promotion;

public class BooleanConditionalExprHandler : ConditionalExprHandler
{
	internal ResolvedType thenExpr;

	internal ResolvedType elseExpr;

	
	
	public BooleanConditionalExprHandler(ResolvedType thenExpr, ResolvedType elseExpr)
	{
		this.thenExpr = thenExpr;
		this.elseExpr = elseExpr;
	}

	
	
	public virtual ResolvedType resolveType()
	{
		if (thenExpr.isReferenceType() && elseExpr.isReferenceType())
		{
			ResolvedReferenceType result = thenExpr.asReferenceType();
			
			return result;
		}
		return (!thenExpr.isPrimitive()) ? elseExpr : thenExpr;
	}
}
