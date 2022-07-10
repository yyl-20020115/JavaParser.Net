using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class InitializerDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel isStaticPropertyMetaModel;

	
		
	
	internal InitializerDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<InitializerDeclaration>.Value, "InitializerDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
