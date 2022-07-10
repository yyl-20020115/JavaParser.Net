using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.promotion;

public class ReferenceConditionalExprHandler: ConditionalExprHandler
{
	internal ResolvedType thenExpr;

	internal ResolvedType elseExpr;

	
	
	public ReferenceConditionalExprHandler(ResolvedType thenExpr, ResolvedType elseExpr)
	{
		this.thenExpr = thenExpr;
		this.elseExpr = elseExpr;
	}

	
	
	public virtual ResolvedType resolveType()
	{
		if (thenExpr.isNull())
		{
			return elseExpr;
		}
		if (elseExpr.isNull())
		{
			return thenExpr;
		}
		
		throw new UnsupportedOperationException("resolving a reference conditional expression");
	}
}
