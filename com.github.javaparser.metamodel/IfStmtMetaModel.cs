
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class IfStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel conditionPropertyMetaModel;

	public PropertyMetaModel elseStmtPropertyMetaModel;

	public PropertyMetaModel thenStmtPropertyMetaModel;

	public PropertyMetaModel cascadingIfStmtPropertyMetaModel;

	public PropertyMetaModel elseBlockPropertyMetaModel;

	public PropertyMetaModel elseBranchPropertyMetaModel;

	public PropertyMetaModel thenBlockPropertyMetaModel;

	
		
	
	internal IfStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<IfStmt>.Value, "IfStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
