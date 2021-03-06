
using com.github.javaparser.ast.body;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class BodyDeclarationMetaModel : NodeMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	
		
	
	internal BodyDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BodyDeclaration>.Value, "BodyDeclaration", "com.github.javaparser.ast.body", isAbstract: true, hasWildcard: true)
	{
	}

	
		
	
	protected internal BodyDeclarationMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
