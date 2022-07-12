
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ThrowStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel expressionPropertyMetaModel;

	
		
	
	internal ThrowStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ThrowStmt>.Value, "ThrowStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
