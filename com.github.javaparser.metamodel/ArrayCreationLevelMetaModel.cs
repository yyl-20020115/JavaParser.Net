
using com.github.javaparser.ast;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ArrayCreationLevelMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel dimensionPropertyMetaModel;

	
		
	
	internal ArrayCreationLevelMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ArrayCreationLevel>.Value, "ArrayCreationLevel", "com.github.javaparser.ast", isAbstract: false, hasWildcard: false)
	{
	}
}
