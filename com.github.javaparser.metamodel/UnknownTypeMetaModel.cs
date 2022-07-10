using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class UnknownTypeMetaModel : TypeMetaModel
{
	
		
	
	internal UnknownTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<UnknownType>.Value, "UnknownType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
