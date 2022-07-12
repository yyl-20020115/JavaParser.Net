
using com.github.javaparser.ast.expr;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class PatternExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal PatternExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<PatternExpr>.Value, "PatternExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
