
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class ExpressionMetaModel : NodeMetaModel
{
	
		
	
	internal ExpressionMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Expression>.Value, "Expression", "com.github.javaparser.ast.expr", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal ExpressionMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
