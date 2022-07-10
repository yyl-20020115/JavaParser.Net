using System.Runtime.CompilerServices;
using com.github.javaparser.ast.modules;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ModuleDeclarationMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel directivesPropertyMetaModel;

	public PropertyMetaModel isOpenPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ModuleDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ModuleDeclaration>.Value, "ModuleDeclaration", "com.github.javaparser.ast.modules", isAbstract: false, hasWildcard: false)
	{
	}
}
