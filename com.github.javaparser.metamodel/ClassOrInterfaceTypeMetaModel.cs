
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ClassOrInterfaceTypeMetaModel : ReferenceTypeMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel scopePropertyMetaModel;

	public PropertyMetaModel typeArgumentsPropertyMetaModel;

	public PropertyMetaModel usingDiamondOperatorPropertyMetaModel;

	
		
	
	internal ClassOrInterfaceTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ClassOrInterfaceType>.Value, "ClassOrInterfaceType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
