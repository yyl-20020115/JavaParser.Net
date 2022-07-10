using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SwitchExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel entriesPropertyMetaModel;

	public PropertyMetaModel selectorPropertyMetaModel;

	
		
	
	internal SwitchExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SwitchExpr>.Value, "SwitchExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
