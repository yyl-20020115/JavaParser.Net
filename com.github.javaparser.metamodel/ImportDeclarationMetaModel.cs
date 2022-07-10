using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ImportDeclarationMetaModel : NodeMetaModel
{
	public PropertyMetaModel isAsteriskPropertyMetaModel;

	public PropertyMetaModel isStaticPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal ImportDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ImportDeclaration>.Value, "ImportDeclaration", "com.github.javaparser.ast", isAbstract: false, hasWildcard: false)
	{
	}
}
