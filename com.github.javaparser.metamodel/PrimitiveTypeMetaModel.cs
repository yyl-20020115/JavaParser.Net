using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class PrimitiveTypeMetaModel : TypeMetaModel
{
	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal PrimitiveTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<PrimitiveType>.Value, "PrimitiveType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
