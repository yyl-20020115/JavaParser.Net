
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ForEachStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel iterablePropertyMetaModel;

	public PropertyMetaModel variablePropertyMetaModel;

	
		
	
	internal ForEachStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ForEachStmt>.Value, "ForEachStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
