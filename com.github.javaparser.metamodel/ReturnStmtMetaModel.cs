
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ReturnStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	
		
	
	internal ReturnStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ReturnStmt>.Value, "ReturnStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
