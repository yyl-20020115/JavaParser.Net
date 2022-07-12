
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ArrayCreationExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel elementTypePropertyMetaModel;

	public PropertyMetaModel initializerPropertyMetaModel;

	public PropertyMetaModel levelsPropertyMetaModel;

	
		
	
	internal ArrayCreationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ArrayCreationExpr>.Value, "ArrayCreationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
