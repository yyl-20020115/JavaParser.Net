
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class ReferenceTypeMetaModel : TypeMetaModel
{
	
		
	
	internal ReferenceTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ReferenceType>.Value, "ReferenceType", "com.github.javaparser.ast.type", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal ReferenceTypeMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
