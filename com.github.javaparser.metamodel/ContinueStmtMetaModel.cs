
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ContinueStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel labelPropertyMetaModel;

	
		
	
	internal ContinueStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ContinueStmt>.Value, "ContinueStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
