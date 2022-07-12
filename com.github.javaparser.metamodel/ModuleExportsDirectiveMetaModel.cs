
using com.github.javaparser.ast.modules;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleExportsDirectiveMetaModel : ModuleDirectiveMetaModel
{
	public PropertyMetaModel moduleNamesPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ModuleExportsDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleExportsDirective>.Value, "ModuleExportsDirective", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
