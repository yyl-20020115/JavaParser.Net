
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ForStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel comparePropertyMetaModel;

	public PropertyMetaModel initializationPropertyMetaModel;

	public PropertyMetaModel updatePropertyMetaModel;

	
		
	
	internal ForStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ForStmt>.Value, "ForStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
