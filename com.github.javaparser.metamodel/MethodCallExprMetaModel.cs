using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class MethodCallExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel argumentsPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel scopePropertyMetaModel;

	public PropertyMetaModel typeArgumentsPropertyMetaModel;

	public PropertyMetaModel usingDiamondOperatorPropertyMetaModel;

	
		
	
	internal MethodCallExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<MethodCallExpr>.Value, "MethodCallExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
