using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class UnaryExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	public PropertyMetaModel operatorPropertyMetaModel;

	public PropertyMetaModel postfixPropertyMetaModel;

	public PropertyMetaModel prefixPropertyMetaModel;

	
		
	
	internal UnaryExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<UnaryExpr>.Value, "UnaryExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
