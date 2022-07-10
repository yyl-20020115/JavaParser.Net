using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class NameExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal NameExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<NameExpr>.Value, "NameExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
