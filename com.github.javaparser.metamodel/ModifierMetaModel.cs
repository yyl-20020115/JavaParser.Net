using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModifierMetaModel : NodeMetaModel
{
	public PropertyMetaModel keywordPropertyMetaModel;

	
		
	
	internal ModifierMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Modifier>.Value, "Modifier", "com.github.javaparser.ast", isAbstract: false, hasWildcard: false)
	{
	}
}
