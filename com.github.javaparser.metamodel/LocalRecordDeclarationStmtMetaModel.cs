
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LocalRecordDeclarationStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel recordDeclarationPropertyMetaModel;

	
		
	
	internal LocalRecordDeclarationStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LocalRecordDeclarationStmt>.Value, "LocalRecordDeclarationStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
