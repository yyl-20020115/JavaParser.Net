
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SuperExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel typeNamePropertyMetaModel;

	
		
	
	internal SuperExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SuperExpr>.Value, "SuperExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
