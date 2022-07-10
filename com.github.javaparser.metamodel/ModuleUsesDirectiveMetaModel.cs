using System.Runtime.CompilerServices;
using com.github.javaparser.ast.modules;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleUsesDirectiveMetaModel : ModuleDirectiveMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ModuleUsesDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleUsesDirective>.Value, "ModuleUsesDirective", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
