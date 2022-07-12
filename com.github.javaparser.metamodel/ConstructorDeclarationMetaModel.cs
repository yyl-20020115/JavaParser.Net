
using com.github.javaparser.ast.body;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ConstructorDeclarationMetaModel : CallableDeclarationMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	
		
	
	internal ConstructorDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ConstructorDeclaration>.Value, "ConstructorDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
