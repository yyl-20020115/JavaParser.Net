using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class VoidTypeMetaModel : TypeMetaModel
{
	
		
	
	internal VoidTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<VoidType>.Value, "VoidType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
