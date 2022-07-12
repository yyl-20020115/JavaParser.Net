
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class LiteralStringValueExprMetaModel : LiteralExprMetaModel
{
	public PropertyMetaModel valuePropertyMetaModel;

	
		
	
	internal LiteralStringValueExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LiteralStringValueExpr>.Value, "LiteralStringValueExpr", "com.github.javaparser.ast.expr", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal LiteralStringValueExprMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
