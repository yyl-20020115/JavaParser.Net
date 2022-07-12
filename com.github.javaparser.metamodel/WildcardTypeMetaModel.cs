
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class WildcardTypeMetaModel : TypeMetaModel
{
	public PropertyMetaModel extendedTypePropertyMetaModel;

	public PropertyMetaModel superTypePropertyMetaModel;

	
		
	
	internal WildcardTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<WildcardType>.Value, "WildcardType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
