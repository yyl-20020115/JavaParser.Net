
using com.github.javaparser.ast.body;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class EnumConstantDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel argumentsPropertyMetaModel;

	public PropertyMetaModel classBodyPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	
		
	
	internal EnumConstantDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<EnumConstantDeclaration>.Value, "EnumConstantDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
