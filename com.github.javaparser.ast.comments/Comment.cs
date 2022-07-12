using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.comments;

public abstract class Comment : Node
{
	private string content;

	
	private Node commentedNode;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	public virtual string getContent()
	{
		return content;
	}

	
	
	
	public virtual Comment setCommentedNode(Node commentedNode)
	{
		notifyPropertyChange(ObservableProperty.___003C_003ECOMMENTED_NODE, this.commentedNode, commentedNode);
		if (commentedNode == null)
		{
			this.commentedNode = null;
			return this;
		}
		if (commentedNode == this)
		{
			
			throw new IllegalArgumentException();
		}
		if (commentedNode is Comment)
		{
			
			throw new IllegalArgumentException();
		}
		this.commentedNode = commentedNode;
		return this;
	}

	
	
	public override bool remove()
	{
		if (commentedNode != null)
		{
			commentedNode.setComment(null);
			return true;
		}
		if (getParentNode().isPresent())
		{
			bool result = ((Node)getParentNode().get()).removeOrphanComment(this);
			
			return result;
		}
		return false;
	}

	
	
	
	public Comment(TokenRange tokenRange, string content)
		: base(tokenRange)
	{
		setContent(content);
		customInitialization();
	}

	
	
	
	public virtual Comment setContent(string content)
	{
		Utils.assertNotNull(content);
		if ((object)content == this.content)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECONTENT, this.content, content);
		this.content = content;
		return this;
	}

	
		
	public virtual Optional getCommentedNode()
	{
		Optional result = Optional.ofNullable(commentedNode);
		
		return result;
	}

	
	
	public new virtual CommentMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcommentMetaModel;
	}

	
	
	public new virtual Comment clone()
	{
		return (Comment)accept(new CloneVisitor(), null);
	}

	
	
	
	
	public Comment(string content)
		: this(null, content)
	{
	}

	public virtual bool isLineComment()
	{
		return false;
	}

	
	
	public virtual LineComment asLineComment()
	{
		string s = CodeGenerationUtils.f("%s is not LineComment, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isOrphan()
	{
		return commentedNode == null;
	}

	
	
	
	public override Node setComment(Comment comment)
	{
		if (comment != null)
		{
			
			throw new IllegalArgumentException("A comment cannot be commented.");
		}
		Node result = base.setComment(comment);
		
		return result;
	}

	
	
	public override Node findRootNode()
	{
		Node node = (Node)getCommentedNode().orElse(this);
		while (node.getParentNode().isPresent())
		{
			node = (Node)node.getParentNode().get();
		}
		return node;
	}

	public virtual bool isBlockComment()
	{
		return false;
	}

	
	
	public virtual BlockComment asBlockComment()
	{
		string s = CodeGenerationUtils.f("%s is not BlockComment, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isJavadocComment()
	{
		return false;
	}

	
	
	public virtual JavadocComment asJavadocComment()
	{
		string s = CodeGenerationUtils.f("%s is not JavadocComment, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifBlockComment(Consumer action)
	{
	}

		
	public virtual void ifJavadocComment(Consumer action)
	{
	}

		
	public virtual void ifLineComment(Consumer action)
	{
	}

	
		
	public virtual Optional toBlockComment()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toJavadocComment()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLineComment()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CommentMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Comment result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Comment result = clone();
		
		return result;
	}

	
	static Comment()
	{
		Node.___003Cclinit_003E();
	}
}
