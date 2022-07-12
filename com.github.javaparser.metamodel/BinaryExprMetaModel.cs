
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class BinaryExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel leftPropertyMetaModel;

	public PropertyMetaModel operatorPropertyMetaModel;

	public PropertyMetaModel rightPropertyMetaModel;

	
		
	
	internal BinaryExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BinaryExpr>.Value, "BinaryExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
