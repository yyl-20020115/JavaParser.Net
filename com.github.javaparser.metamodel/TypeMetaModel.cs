
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class TypeMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	
		
	
	internal TypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Type>.Value, "Type", "com.github.javaparser.ast.type", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal TypeMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
