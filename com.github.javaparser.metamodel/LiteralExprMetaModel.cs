
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class LiteralExprMetaModel : ExpressionMetaModel
{
	
		
	
	internal LiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LiteralExpr>.Value, "LiteralExpr", "com.github.javaparser.ast.expr", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal LiteralExprMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
