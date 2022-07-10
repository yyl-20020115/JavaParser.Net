using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class JavadocCommentMetaModel : CommentMetaModel
{
	
		
	
	internal JavadocCommentMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<JavadocComment>.Value, "JavadocComment", "com.github.javaparser.ast.comments", isAbstract: false, hasWildcard: false)
	{
	}
}
