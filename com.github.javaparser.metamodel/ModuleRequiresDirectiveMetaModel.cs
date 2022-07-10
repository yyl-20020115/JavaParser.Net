using System.Runtime.CompilerServices;
using com.github.javaparser.ast.modules;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleRequiresDirectiveMetaModel : ModuleDirectiveMetaModel
{
	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ModuleRequiresDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleRequiresDirective>.Value, "ModuleRequiresDirective", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
