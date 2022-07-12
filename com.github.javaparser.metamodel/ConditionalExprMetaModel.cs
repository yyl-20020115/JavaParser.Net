
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ConditionalExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel conditionPropertyMetaModel;

	public PropertyMetaModel elseExprPropertyMetaModel;

	public PropertyMetaModel thenExprPropertyMetaModel;

	
		
	
	internal ConditionalExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ConditionalExpr>.Value, "ConditionalExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
