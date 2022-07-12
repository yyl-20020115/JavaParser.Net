using System.ComponentModel;

using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public class InitializerDeclaration : BodyDeclaration, NodeWithJavadoc, NodeWithBlockStmt
{
	private bool m_isStatic;

	private BlockStmt body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public InitializerDeclaration(bool isStatic, BlockStmt body)
		: this(null, isStatic, body)
	{
	}

	
	
	
	public InitializerDeclaration(TokenRange tokenRange, bool isStatic, BlockStmt body)
		: base(tokenRange)
	{
		setStatic(isStatic);
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual InitializerDeclaration setStatic(bool isStatic)
	{
		if (isStatic == this.m_isStatic)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESTATIC, Boolean.valueOf(this.m_isStatic), Boolean.valueOf(isStatic));
		this.m_isStatic = isStatic;
		return this;
	}

	
	
	
	public virtual InitializerDeclaration setBody(BlockStmt body)
	{
		Utils.assertNotNull(body);
		if (body == this.body)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EBODY, this.body, body);
		if (this.body != null)
		{
			this.body.setParentNode(null);
		}
		this.body = body;
		setAsParentNodeOf(body);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual InitializerDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EinitializerDeclarationMetaModel;
	}

	
	
	public new virtual InitializerDeclaration clone()
	{
		return (InitializerDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public InitializerDeclaration()
		: this(null, isStatic: false, new BlockStmt())
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual BlockStmt getBody()
	{
		return body;
	}

	public virtual bool isStatic()
	{
		return this.m_isStatic;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((BlockStmt)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isInitializerDeclaration()
	{
		return true;
	}

	public override InitializerDeclaration asInitializerDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifInitializerDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toInitializerDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		InitializerDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		InitializerDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		InitializerDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		InitializerDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		InitializerDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		InitializerDeclaration result = setBody(body);
		
		return result;
	}


	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}


	public virtual Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}


	public virtual Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}


	public virtual Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}


	public virtual bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}


	public virtual BlockStmt createBody()
	{
		return NodeWithBlockStmt._003Cdefault_003EcreateBody(this);
	}

	
	static InitializerDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithBlockStmt.NodeWithBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}
}
