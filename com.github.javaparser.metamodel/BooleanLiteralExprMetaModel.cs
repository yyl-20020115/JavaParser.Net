using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class BooleanLiteralExprMetaModel : LiteralExprMetaModel
{
	public PropertyMetaModel valuePropertyMetaModel;

	
		
	
	internal BooleanLiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BooleanLiteralExpr>.Value, "BooleanLiteralExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
