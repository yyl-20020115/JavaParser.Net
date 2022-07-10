using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class LineCommentMetaModel : CommentMetaModel
{
	
		
	
	internal LineCommentMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<LineComment>.Value, "LineComment", "com.github.javaparser.ast.comments", isAbstract: false, hasWildcard: false)
	{
	}
}
