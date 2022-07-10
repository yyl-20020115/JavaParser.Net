using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class VarTypeMetaModel : TypeMetaModel
{
	
		
	
	internal VarTypeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<VarType>.Value, "VarType", "com.github.javaparser.ast.type", isAbstract: false, hasWildcard: false)
	{
	}
}
