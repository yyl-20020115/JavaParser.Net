using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class SynchronizedStmt : Statement, NodeWithBlockStmt, NodeWithExpression
{
	private Expression expression;

	private BlockStmt body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public SynchronizedStmt(TokenRange tokenRange, Expression expression, BlockStmt body)
		: base(tokenRange)
	{
		setExpression(expression);
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual SynchronizedStmt setExpression(Expression expression)
	{
		Utils.assertNotNull(expression);
		if (expression == this.expression)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EEXPRESSION, this.expression, expression);
		if (this.expression != null)
		{
			this.expression.setParentNode(null);
		}
		this.expression = expression;
		setAsParentNodeOf(expression);
		return this;
	}

	
	
	
	public virtual SynchronizedStmt setBody(BlockStmt body)
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

	
	
	public new virtual SynchronizedStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EsynchronizedStmtMetaModel;
	}

	
	
	public new virtual SynchronizedStmt clone()
	{
		return (SynchronizedStmt)accept(new CloneVisitor(), null);
	}

	
	
	public SynchronizedStmt()
		: this(null, new NameExpr(), new BlockStmt())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public SynchronizedStmt(Expression expression, BlockStmt body)
		: this(null, expression, body)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Expression getExpression()
	{
		return expression;
	}

	public virtual BlockStmt getBody()
	{
		return body;
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
		if (node == expression)
		{
			setExpression((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isSynchronizedStmt()
	{
		return true;
	}

	public override SynchronizedStmt asSynchronizedStmt()
	{
		return this;
	}

	
		
	
	public override void ifSynchronizedStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toSynchronizedStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		SynchronizedStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		SynchronizedStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SynchronizedStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		SynchronizedStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SynchronizedStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		SynchronizedStmt result = setBody(body);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		SynchronizedStmt result = setExpression(expression);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBody()
	{
		return NodeWithBlockStmt._003Cdefault_003EcreateBody(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setExpression(string P_0)
	{
		return NodeWithExpression._003Cdefault_003EsetExpression(this, P_0);
	}

	
	static SynchronizedStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithBlockStmt.NodeWithBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
