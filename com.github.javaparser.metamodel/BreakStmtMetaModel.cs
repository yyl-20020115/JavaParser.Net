
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class BreakStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel labelPropertyMetaModel;

	
		
	
	internal BreakStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BreakStmt>.Value, "BreakStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
