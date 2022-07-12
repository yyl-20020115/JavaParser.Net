
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ArrayAccessExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel indexPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ArrayAccessExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ArrayAccessExpr>.Value, "ArrayAccessExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
