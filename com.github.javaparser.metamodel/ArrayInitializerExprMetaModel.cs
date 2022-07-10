using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ArrayInitializerExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel valuesPropertyMetaModel;

	
		
	
	internal ArrayInitializerExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ArrayInitializerExpr>.Value, "ArrayInitializerExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
