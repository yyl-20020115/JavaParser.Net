
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class TypeExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal TypeExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<TypeExpr>.Value, "TypeExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
