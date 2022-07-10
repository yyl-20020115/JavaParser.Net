using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ClassOrInterfaceDeclarationMetaModel : TypeDeclarationMetaModel
{
	public PropertyMetaModel extendedTypesPropertyMetaModel;

	public PropertyMetaModel implementedTypesPropertyMetaModel;

	public PropertyMetaModel isInterfacePropertyMetaModel;

	public PropertyMetaModel typeParametersPropertyMetaModel;

	
		
	
	internal ClassOrInterfaceDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ClassOrInterfaceDeclaration>.Value, "ClassOrInterfaceDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
