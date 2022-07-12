
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LongLiteralExprMetaModel : LiteralStringValueExprMetaModel
{
	
		
	
	internal LongLiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LongLiteralExpr>.Value, "LongLiteralExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
