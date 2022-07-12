
using com.github.javaparser.ast.modules;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleDirectiveMetaModel : NodeMetaModel
{
	
		
	
	internal ModuleDirectiveMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleDirective>.Value, "ModuleDirective", "com.github.javaparser.ast.modules", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal ModuleDirectiveMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
