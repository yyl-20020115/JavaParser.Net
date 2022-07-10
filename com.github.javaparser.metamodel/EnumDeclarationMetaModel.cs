using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class EnumDeclarationMetaModel : TypeDeclarationMetaModel
{
	public PropertyMetaModel entriesPropertyMetaModel;

	public PropertyMetaModel implementedTypesPropertyMetaModel;

	
		
	
	internal EnumDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<EnumDeclaration>.Value, "EnumDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
