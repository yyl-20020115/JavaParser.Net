
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class MarkerAnnotationExprMetaModel : AnnotationExprMetaModel
{
	
		
	
	internal MarkerAnnotationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<MarkerAnnotationExpr>.Value, "MarkerAnnotationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
