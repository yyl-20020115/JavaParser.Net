using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class AnnotationMemberDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel defaultValuePropertyMetaModel;

	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal AnnotationMemberDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<AnnotationMemberDeclaration>.Value, "AnnotationMemberDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
