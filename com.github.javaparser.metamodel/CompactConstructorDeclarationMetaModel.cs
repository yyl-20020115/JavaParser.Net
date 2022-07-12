
using com.github.javaparser.ast.body;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class CompactConstructorDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel thrownExceptionsPropertyMetaModel;

	public PropertyMetaModel typeParametersPropertyMetaModel;

	
		
	
	internal CompactConstructorDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<CompactConstructorDeclaration>.Value, "CompactConstructorDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
