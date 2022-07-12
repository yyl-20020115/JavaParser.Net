
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SwitchStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel entriesPropertyMetaModel;

	public PropertyMetaModel selectorPropertyMetaModel;

	
		
	
	internal SwitchStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SwitchStmt>.Value, "SwitchStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
