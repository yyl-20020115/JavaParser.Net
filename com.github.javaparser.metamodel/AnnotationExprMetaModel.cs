
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class AnnotationExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal AnnotationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<AnnotationExpr>.Value, "AnnotationExpr", "com.github.javaparser.ast.expr", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal AnnotationExprMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
