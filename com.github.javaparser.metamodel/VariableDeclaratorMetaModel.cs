using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class VariableDeclaratorMetaModel : NodeMetaModel
{
	public PropertyMetaModel initializerPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal VariableDeclaratorMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<VariableDeclarator>.Value, "VariableDeclarator", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
