
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class PrimitiveTypeMetaModel : TypeMetaModel
{
	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal PrimitiveTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<PrimitiveType>.Value, "PrimitiveType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
