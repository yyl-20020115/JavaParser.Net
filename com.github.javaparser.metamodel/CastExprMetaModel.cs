using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class CastExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal CastExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<CastExpr>.Value, "CastExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
