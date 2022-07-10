using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SynchronizedStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel expressionPropertyMetaModel;

	
		
	
	internal SynchronizedStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SynchronizedStmt>.Value, "SynchronizedStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
