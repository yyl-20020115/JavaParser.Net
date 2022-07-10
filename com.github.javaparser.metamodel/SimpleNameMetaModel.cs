using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SimpleNameMetaModel : NodeMetaModel
{
	public PropertyMetaModel identifierPropertyMetaModel;

	
		
	
	internal SimpleNameMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SimpleName>.Value, "SimpleName", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
