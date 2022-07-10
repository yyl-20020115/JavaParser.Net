using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class EnclosedExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel innerPropertyMetaModel;

	
		
	
	internal EnclosedExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<EnclosedExpr>.Value, "EnclosedExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
