using System.Runtime.CompilerServices;
using com.github.javaparser.ast.modules;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleProvidesDirectiveMetaModel : ModuleDirectiveMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel withPropertyMetaModel;

	
		
	
	internal ModuleProvidesDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleProvidesDirective>.Value, "ModuleProvidesDirective", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
