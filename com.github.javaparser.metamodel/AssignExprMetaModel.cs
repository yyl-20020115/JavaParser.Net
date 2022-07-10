using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class AssignExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel operatorPropertyMetaModel;

	public PropertyMetaModel targetPropertyMetaModel;

	public PropertyMetaModel valuePropertyMetaModel;

	
		
	
	internal AssignExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<AssignExpr>.Value, "AssignExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
