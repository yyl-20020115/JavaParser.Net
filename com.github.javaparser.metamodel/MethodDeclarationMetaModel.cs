using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class MethodDeclarationMetaModel : CallableDeclarationMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel typePropertyMetaModel;

	
		
	
	internal MethodDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<MethodDeclaration>.Value, "MethodDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
