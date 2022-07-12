
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ExpressionStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	
		
	
	internal ExpressionStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ExpressionStmt>.Value, "ExpressionStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
