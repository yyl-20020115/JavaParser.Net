
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ArrayTypeMetaModel : ReferenceTypeMetaModel
{
	public PropertyMetaModel componentTypePropertyMetaModel;

	public PropertyMetaModel originPropertyMetaModel;

	
		
	
	internal ArrayTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ArrayType>.Value, "ArrayType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
