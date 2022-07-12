using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.comments;

public class JavadocComment : Comment
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public JavadocComment(string content)
		: this(null, content)
	{
	}

	
	
	public virtual Javadoc parse()
	{
		Javadoc result = StaticJavaParser.parseJavadoc(getContent());
		
		return result;
	}

	
	
	
	public JavadocComment(TokenRange tokenRange, string content)
		: base(tokenRange, content)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual JavadocCommentMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EjavadocCommentMetaModel;
	}

	
	
	public new virtual JavadocComment clone()
	{
		return (JavadocComment)accept(new CloneVisitor(), null);
	}

	
	
	public JavadocComment()
		: this(null, "empty")
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isJavadocComment()
	{
		return true;
	}

	public override JavadocComment asJavadocComment()
	{
		return this;
	}

	
		
	
	public override void ifJavadocComment(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toJavadocComment()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual CommentMetaModel _003Cbridge_003EgetMetaModel()
	{
		JavadocCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Comment _003Cbridge_003Eclone()
	{
		JavadocComment result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		JavadocCommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		JavadocComment result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		JavadocComment result = clone();
		
		return result;
	}

	
	static JavadocComment()
	{
		Comment.___003Cclinit_003E();
	}
}
