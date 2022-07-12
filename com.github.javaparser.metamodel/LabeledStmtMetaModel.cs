
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LabeledStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel labelPropertyMetaModel;

	public PropertyMetaModel statementPropertyMetaModel;

	
		
	
	internal LabeledStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LabeledStmt>.Value, "LabeledStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
