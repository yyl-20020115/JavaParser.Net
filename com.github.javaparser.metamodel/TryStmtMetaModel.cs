using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class TryStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel catchClausesPropertyMetaModel;

	public PropertyMetaModel finallyBlockPropertyMetaModel;

	public PropertyMetaModel resourcesPropertyMetaModel;

	public PropertyMetaModel tryBlockPropertyMetaModel;

	
		
	
	internal TryStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<TryStmt>.Value, "TryStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
