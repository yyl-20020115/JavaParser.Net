using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.comments;

public class LineComment : Comment
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LineComment(string content)
		: this(null, content)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public LineComment(TokenRange tokenRange, string content)
		: base(tokenRange, content)
	{
		customInitialization();
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
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

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
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
