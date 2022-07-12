
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class StatementMetaModel : NodeMetaModel
{
	
		
	
	internal StatementMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Statement>.Value, "Statement", "com.github.javaparser.ast.stmt", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal StatementMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
