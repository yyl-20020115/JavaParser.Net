using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ParameterMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel isVarArgsPropertyMetaModel;

	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	public PropertyMetaModel varArgsAnnotationsPropertyMetaModel;

	
		
	
	internal ParameterMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Parameter>.Value, "Parameter", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
