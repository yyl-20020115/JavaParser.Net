using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class AssertStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel checkPropertyMetaModel;

	public PropertyMetaModel messagePropertyMetaModel;

	
		
	
	internal AssertStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<AssertStmt>.Value, "AssertStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
