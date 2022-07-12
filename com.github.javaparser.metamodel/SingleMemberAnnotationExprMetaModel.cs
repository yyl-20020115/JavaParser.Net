
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SingleMemberAnnotationExprMetaModel : AnnotationExprMetaModel
{
	public PropertyMetaModel memberValuePropertyMetaModel;

	
		
	
	internal SingleMemberAnnotationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SingleMemberAnnotationExpr>.Value, "SingleMemberAnnotationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
