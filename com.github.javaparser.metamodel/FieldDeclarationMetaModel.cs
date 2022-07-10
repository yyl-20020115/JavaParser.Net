using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class FieldDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel variablesPropertyMetaModel;

	public PropertyMetaModel maximumCommonTypePropertyMetaModel;

	
		
	
	internal FieldDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<FieldDeclaration>.Value, "FieldDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
