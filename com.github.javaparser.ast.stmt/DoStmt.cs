using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class DoStmt : Statement, NodeWithBody, NodeWithCondition
{
	private Statement body;

	private Expression condition;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public DoStmt(TokenRange tokenRange, Statement body, Expression condition)
		: base(tokenRange)
	{
		setBody(body);
		setCondition(condition);
		customInitialization();
	}

	
	
	
	public virtual DoStmt setBody(Statement body)
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

	
	
	
	public virtual DoStmt setCondition(Expression condition)
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

	
	
	public new virtual DoStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EdoStmtMetaModel;
	}

	
	
	public new virtual DoStmt clone()
	{
		return (DoStmt)accept(new CloneVisitor(), null);
	}

	
	
	public DoStmt()
		: this(null, new ReturnStmt(), new BooleanLiteralExpr())
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public DoStmt(Statement body, Expression condition)
		: this(null, body, condition)
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

	public virtual Statement getBody()
	{
		return body;
	}

	public virtual Expression getCondition()
	{
		return condition;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
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

	public override bool isDoStmt()
	{
		return true;
	}

	public override DoStmt asDoStmt()
	{
		return this;
	}

	
		
	
	public override void ifDoStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toDoStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		DoStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		DoStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		DoStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(Statement body)
	{
		DoStmt result = setBody(body);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetCondition(Expression condition)
	{
		DoStmt result = setCondition(condition);
		
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

	
	static DoStmt()
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
