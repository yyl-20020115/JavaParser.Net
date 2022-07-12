
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class IntersectionTypeMetaModel : TypeMetaModel
{
	public PropertyMetaModel elementsPropertyMetaModel;

	
		
	
	internal IntersectionTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<IntersectionType>.Value, "IntersectionType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
