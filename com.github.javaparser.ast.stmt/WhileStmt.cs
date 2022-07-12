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


public class WhileStmt : Statement, NodeWithBody, NodeWithCondition
{
	private Expression condition;

	private Statement body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public WhileStmt(TokenRange tokenRange, Expression condition, Statement body)
		: base(tokenRange)
	{
		setCondition(condition);
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual WhileStmt setCondition(Expression condition)
	{
		Utils.assertNotNull(condition);
		if (condition == this.condition)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECONDITION, this.condition, condition);
		if (this.condition != null)
		{
			this.condition.setParentNode(null);
		}
		this.condition = condition;
		setAsParentNodeOf(condition);
		return this;
	}

	
	
	
	public virtual WhileStmt setBody(Statement body)
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

	
	
	public new virtual WhileStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EwhileStmtMetaModel;
	}

	
	
	public new virtual WhileStmt clone()
	{
		return (WhileStmt)accept(new CloneVisitor(), null);
	}

	
	
	public WhileStmt()
		: this(null, new BooleanLiteralExpr(), new ReturnStmt())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public WhileStmt(Expression condition, Statement body)
		: this(null, condition, body)
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

	public virtual Expression getCondition()
	{
		return condition;
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
		if (node == condition)
		{
			setCondition((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isWhileStmt()
	{
		return true;
	}

	public override WhileStmt asWhileStmt()
	{
		return this;
	}

	
		
	
	public override void ifWhileStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toWhileStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		WhileStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		WhileStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		WhileStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		WhileStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		WhileStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(Statement body)
	{
		WhileStmt result = setBody(body);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetCondition(Expression condition)
	{
		WhileStmt result = setCondition(condition);
		
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

	
	static WhileStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithBody.NodeWithBody_003A_003AsetBody(Statement P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}

	Node NodeWithCondition.NodeWithCondition_003A_003AsetCondition(Expression P_0)
	{
		return _003Cbridge_003EsetCondition(P_0);
	}
}
