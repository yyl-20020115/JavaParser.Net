using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.promotion;

public class ConditionalExprResolver
{
	
	private static ResolvedPrimitiveType TYPE_BOOLEAN;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public static ConditionalExprHandler getConditionExprHandler(ResolvedType thenExpr, ResolvedType elseExpr)
	{
		if (!thenExpr.isNull() && !elseExpr.isNull() && thenExpr.isAssignableBy(TYPE_BOOLEAN) && elseExpr.isAssignableBy(TYPE_BOOLEAN))
		{
			BooleanConditionalExprHandler result = new BooleanConditionalExprHandler(thenExpr, elseExpr);
			
			return result;
		}
		if (thenExpr.isNumericType() && elseExpr.isNumericType())
		{
			NumericConditionalExprHandler result2 = new NumericConditionalExprHandler(thenExpr, elseExpr);
			
			return result2;
		}
		ReferenceConditionalExprHandler result3 = new ReferenceConditionalExprHandler(thenExpr, elseExpr);
		
		return result3;
	}

	
	
	public ConditionalExprResolver()
	{
	}

	
	static ConditionalExprResolver()
	{
		TYPE_BOOLEAN = ResolvedPrimitiveType.___003C_003EBOOLEAN;
	}
}
