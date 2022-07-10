using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class FieldAccessExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel scopePropertyMetaModel;

	public PropertyMetaModel typeArgumentsPropertyMetaModel;

	public PropertyMetaModel usingDiamondOperatorPropertyMetaModel;

	
		
	
	internal FieldAccessExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<FieldAccessExpr>.Value, "FieldAccessExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
