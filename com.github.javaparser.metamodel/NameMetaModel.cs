using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class NameMetaModel : NodeMetaModel
{
	public PropertyMetaModel identifierPropertyMetaModel;

	public PropertyMetaModel qualifierPropertyMetaModel;

	
		
	
	internal NameMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Name>.Value, "Name", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
