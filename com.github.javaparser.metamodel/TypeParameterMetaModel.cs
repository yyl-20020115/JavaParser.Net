
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class TypeParameterMetaModel : ReferenceTypeMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typeBoundPropertyMetaModel;

	
		
	
	internal TypeParameterMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<TypeParameter>.Value, "TypeParameter", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
