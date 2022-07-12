
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ThisExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel typeNamePropertyMetaModel;

	
		
	
	internal ThisExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ThisExpr>.Value, "ThisExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
