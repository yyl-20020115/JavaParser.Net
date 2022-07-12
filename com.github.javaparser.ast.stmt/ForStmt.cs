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


public class ForStmt : Statement, NodeWithBody
{
		private NodeList initialization;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Expression compare;

		private NodeList update;

	private Statement body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ForStmt(TokenRange tokenRange, NodeList initialization, Expression compare, NodeList update, Statement body)
		: base(tokenRange)
	{
		setInitialization(initialization);
		setCompare(compare);
		setUpdate(update);
		setBody(body);
		customInitialization();
	}

	
		
	
	public virtual ForStmt setInitialization(NodeList initialization)
	{
		Utils.assertNotNull(initialization);
		if (initialization == this.initialization)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EINITIALIZATION, this.initialization, initialization);
		if (this.initialization != null)
		{
			this.initialization.setParentNode(null);
		}
		this.initialization = initialization;
		setAsParentNodeOf(initialization);
		return this;
	}

	
	
	
	public virtual ForStmt setCompare(Expression compare)
	{
		if (compare == this.compare)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECOMPARE, this.compare, compare);
		if (this.compare != null)
		{
			this.compare.setParentNode(null);
		}
		this.compare = compare;
		setAsParentNodeOf(compare);
		return this;
	}

	
		
	
	public virtual ForStmt setUpdate(NodeList update)
	{
		Utils.assertNotNull(update);
		if (update == this.update)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EUPDATE, this.update, update);
		if (this.update != null)
		{
			this.update.setParentNode(null);
		}
		this.update = update;
		setAsParentNodeOf(update);
		return this;
	}

	
	
	
	public virtual ForStmt setBody(Statement body)
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

	
	
	public virtual ForStmt removeCompare()
	{
		ForStmt result = setCompare(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ForStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EforStmtMetaModel;
	}

	
	
	public new virtual ForStmt clone()
	{
		return (ForStmt)accept(new CloneVisitor(), null);
	}

	
	
	public ForStmt()
		: this(null, new NodeList(), new BooleanLiteralExpr(), new NodeList(), new ReturnStmt())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ForStmt(NodeList initialization, Expression compare, NodeList update, Statement body)
		: this(null, initialization, compare, update, body)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Statement getBody()
	{
		return body;
	}

	
		
	public virtual Optional getCompare()
	{
		Optional result = Optional.ofNullable(compare);
		
		return result;
	}

		public virtual NodeList getInitialization()
	{
		return initialization;
	}

		public virtual NodeList getUpdate()
	{
		return update;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (compare != null && node == compare)
		{
			removeCompare();
			return true;
		}
		for (int i = 0; i < initialization.size(); i++)
		{
			if (initialization.get(i) == node)
			{
				initialization.remove(i);
				return true;
			}
		}
		for (int i = 0; i < update.size(); i++)
		{
			if (update.get(i) == node)
			{
				update.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((Statement)replacementNode);
			return true;
		}
		if (compare != null && node == compare)
		{
			setCompare((Expression)replacementNode);
			return true;
		}
		for (int i = 0; i < initialization.size(); i++)
		{
			if (initialization.get(i) == node)
			{
				initialization.set(i, (Expression)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < update.size(); i++)
		{
			if (update.get(i) == node)
			{
				update.set(i, (Expression)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isForStmt()
	{
		return true;
	}

	public override ForStmt asForStmt()
	{
		return this;
	}

	
		
	
	public override void ifForStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toForStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ForStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ForStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ForStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ForStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ForStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(Statement body)
	{
		ForStmt result = setBody(body);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBlockStatementAsBody()
	{
		return NodeWithBody._003Cdefault_003EcreateBlockStatementAsBody(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasEmptyBody()
	{
		return NodeWithBody._003Cdefault_003EhasEmptyBody(this);
	}

	
	static ForStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithBody.NodeWithBody_003A_003AsetBody(Statement P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}
}
