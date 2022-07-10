using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class EmptyStmtMetaModel : StatementMetaModel
{
	
		
	
	internal EmptyStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<EmptyStmt>.Value, "EmptyStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
