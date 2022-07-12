using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.comments;

public class LineComment : Comment
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public LineComment(string content)
		: this(null, content)
	{
	}

	
	
	
	public LineComment(TokenRange tokenRange, string content)
		: base(tokenRange, content)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual LineCommentMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElineCommentMetaModel;
	}

	
	
	public new virtual LineComment clone()
	{
		return (LineComment)accept(new CloneVisitor(), null);
	}

	
	
	public LineComment()
		: this(null, "empty")
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isLineComment()
	{
		return true;
	}

	public override LineComment asLineComment()
	{
		return this;
	}

	
		
	
	public override void ifLineComment(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLineComment()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual CommentMetaModel _003Cbridge_003EgetMetaModel()
	{
		LineCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Comment _003Cbridge_003Eclone()
	{
		LineComment result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LineCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LineComment result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LineComment result = clone();
		
		return result;
	}

	
	static LineComment()
	{
		Comment.___003Cclinit_003E();
	}
}
