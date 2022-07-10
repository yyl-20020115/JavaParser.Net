using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class SwitchEntryMetaModel : NodeMetaModel
{
	public PropertyMetaModel labelsPropertyMetaModel;

	public PropertyMetaModel statementsPropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal SwitchEntryMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<SwitchEntry>.Value, "SwitchEntry", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
