
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class WhileStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel conditionPropertyMetaModel;

	
		
	
	internal WhileStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<WhileStmt>.Value, "WhileStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
