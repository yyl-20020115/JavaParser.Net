using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ReceiverParameterMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal ReceiverParameterMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ReceiverParameter>.Value, "ReceiverParameter", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
