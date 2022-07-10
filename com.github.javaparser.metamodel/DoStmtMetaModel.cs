using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class DoStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel conditionPropertyMetaModel;

	
		
	
	internal DoStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<DoStmt>.Value, "DoStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
