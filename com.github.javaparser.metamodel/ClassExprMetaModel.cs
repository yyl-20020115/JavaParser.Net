
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ClassExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal ClassExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ClassExpr>.Value, "ClassExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
