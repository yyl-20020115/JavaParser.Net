
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LocalClassDeclarationStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel classDeclarationPropertyMetaModel;

	
		
	
	internal LocalClassDeclarationStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LocalClassDeclarationStmt>.Value, "LocalClassDeclarationStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
