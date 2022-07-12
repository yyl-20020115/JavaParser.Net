
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class IntegerLiteralExprMetaModel : LiteralStringValueExprMetaModel
{
	
		
	
	internal IntegerLiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<IntegerLiteralExpr>.Value, "IntegerLiteralExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
