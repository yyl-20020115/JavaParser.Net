
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class NormalAnnotationExprMetaModel : AnnotationExprMetaModel
{
	public PropertyMetaModel pairsPropertyMetaModel;

	
		
	
	internal NormalAnnotationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<NormalAnnotationExpr>.Value, "NormalAnnotationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
