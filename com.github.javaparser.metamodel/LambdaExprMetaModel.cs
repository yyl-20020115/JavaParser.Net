using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LambdaExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel isEnclosingParametersPropertyMetaModel;

	public PropertyMetaModel parametersPropertyMetaModel;

	public PropertyMetaModel expressionBodyPropertyMetaModel;

	
		
	
	internal LambdaExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LambdaExpr>.Value, "LambdaExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
