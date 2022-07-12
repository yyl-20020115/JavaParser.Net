
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class YieldStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	
		
	
	internal YieldStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<YieldStmt>.Value, "YieldStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
