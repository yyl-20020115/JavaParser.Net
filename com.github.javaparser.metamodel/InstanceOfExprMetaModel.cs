
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class InstanceOfExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	public PropertyMetaModel patternPropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal InstanceOfExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<InstanceOfExpr>.Value, "InstanceOfExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
