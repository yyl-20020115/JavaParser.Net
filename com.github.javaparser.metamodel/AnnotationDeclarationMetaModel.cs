using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class AnnotationDeclarationMetaModel : TypeDeclarationMetaModel
{
	
		
	
	internal AnnotationDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<AnnotationDeclaration>.Value, "AnnotationDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
