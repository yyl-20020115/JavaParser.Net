using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class PackageDeclarationMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal PackageDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<PackageDeclaration>.Value, "PackageDeclaration", "com.github.javaparser.ast", isAbstract: false, hasWildcard: false)
	{
	}
}
