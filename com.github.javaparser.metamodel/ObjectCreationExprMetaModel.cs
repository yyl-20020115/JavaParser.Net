
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ObjectCreationExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel anonymousClassBodyPropertyMetaModel;

	public PropertyMetaModel argumentsPropertyMetaModel;

	public PropertyMetaModel scopePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	public PropertyMetaModel typeArgumentsPropertyMetaModel;

	public PropertyMetaModel usingDiamondOperatorPropertyMetaModel;

	
		
	
	internal ObjectCreationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ObjectCreationExpr>.Value, "ObjectCreationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
