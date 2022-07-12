
using com.github.javaparser.ast.modules;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleOpensDirectiveMetaModel : ModuleDirectiveMetaModel
{
	public PropertyMetaModel moduleNamesPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ModuleOpensDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleOpensDirective>.Value, "ModuleOpensDirective", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
