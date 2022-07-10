using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class UnionTypeMetaModel : TypeMetaModel
{
	public PropertyMetaModel elementsPropertyMetaModel;

	
		
	
	internal UnionTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<UnionType>.Value, "UnionType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
