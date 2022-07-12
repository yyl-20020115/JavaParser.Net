
using com.github.javaparser.ast.comments;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class BlockCommentMetaModel : CommentMetaModel
{
	
		
	
	internal BlockCommentMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<BlockComment>.Value, "BlockComment", "com.github.javaparser.ast.comments", isAbstract: false, hasWildcard: false)
	{
	}
}
