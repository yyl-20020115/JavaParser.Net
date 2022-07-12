using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.comments;

public class BlockComment : Comment
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public BlockComment(string content)
		: this(null, content)
	{
	}

	
	
	
	public BlockComment(TokenRange tokenRange, string content)
		: base(tokenRange, content)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual BlockCommentMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EblockCommentMetaModel;
	}

	
	
	public new virtual BlockComment clone()
	{
		return (BlockComment)accept(new CloneVisitor(), null);
	}

	
	
	public BlockComment()
		: this(null, "empty")
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isBlockComment()
	{
		return true;
	}

	public override BlockComment asBlockComment()
	{
		return this;
	}

	
		
	
	public override void ifBlockComment(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toBlockComment()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual CommentMetaModel _003Cbridge_003EgetMetaModel()
	{
		BlockCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Comment _003Cbridge_003Eclone()
	{
		BlockComment result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		BlockCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		BlockComment result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		BlockComment result = clone();
		
		return result;
	}

	
	static BlockComment()
	{
		Comment.___003Cclinit_003E();
	}
}
