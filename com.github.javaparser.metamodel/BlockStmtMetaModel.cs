
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class BlockStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel statementsPropertyMetaModel;

	
		
	
	internal BlockStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BlockStmt>.Value, "BlockStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
