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


public class IfStmt : Statement, NodeWithCondition
{
	private Expression condition;

	private Statement thenStmt;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Statement elseStmt;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public IfStmt(TokenRange tokenRange, Expression condition, Statement thenStmt, Statement elseStmt)
		: base(tokenRange)
	{
		setCondition(condition);
		setThenStmt(thenStmt);
		setElseStmt(elseStmt);
		customInitialization();
	}

	
	
	
	public virtual IfStmt setCondition(Expression condition)
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

	
	
	
	public virtual IfStmt setThenStmt(Statement thenStmt)
	{
		Utils.assertNotNull(thenStmt);
		if (thenStmt == this.thenStmt)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETHEN_STMT, this.thenStmt, thenStmt);
		if (this.thenStmt != null)
		{
			this.thenStmt.setParentNode(null);
		}
		this.thenStmt = thenStmt;
		setAsParentNodeOf(thenStmt);
		return this;
	}

	
	
	
	public virtual IfStmt setElseStmt(Statement elseStmt)
	{
		if (elseStmt == this.elseStmt)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EELSE_STMT, this.elseStmt, elseStmt);
		if (this.elseStmt != null)
		{
			this.elseStmt.setParentNode(null);
		}
		this.elseStmt = elseStmt;
		setAsParentNodeOf(elseStmt);
		return this;
	}

	
	
	public virtual IfStmt removeElseStmt()
	{
		IfStmt result = setElseStmt(null);
		
		return result;
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

	
	
	public new virtual IfStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EifStmtMetaModel;
	}

	
	
	public new virtual IfStmt clone()
	{
		return (IfStmt)accept(new CloneVisitor(), null);
	}

	
	
	public IfStmt()
		: this(null, new BooleanLiteralExpr(), new ReturnStmt(), null)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public IfStmt(Expression condition, Statement thenStmt, Statement elseStmt)
		: this(null, condition, thenStmt, elseStmt)
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

	public virtual Expression getCondition()
	{
		return condition;
	}

	
		
	public virtual Optional getElseStmt()
	{
		Optional result = Optional.ofNullable(elseStmt);
		
		return result;
	}

	public virtual Statement getThenStmt()
	{
		return thenStmt;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (elseStmt != null && node == elseStmt)
		{
			removeElseStmt();
			return true;
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool hasThenBlock()
	{
		return thenStmt is BlockStmt;
	}

	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool hasElseBlock()
	{
		return elseStmt is BlockStmt;
	}

	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool hasCascadingIfStmt()
	{
		return elseStmt is IfStmt;
	}

	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool hasElseBranch()
	{
		return elseStmt != null;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 106, 99, 130, 105, 109, 130, 104, 105, 109,
		162, 105, 109, 130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == condition)
		{
			setCondition((Expression)replacementNode);
			return true;
		}
		if (elseStmt != null && node == elseStmt)
		{
			setElseStmt((Statement)replacementNode);
			return true;
		}
		if (node == thenStmt)
		{
			setThenStmt((Statement)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isIfStmt()
	{
		return true;
	}

	public override IfStmt asIfStmt()
	{
		return this;
	}

	
		
	
	public override void ifIfStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toIfStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		IfStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		IfStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		IfStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		IfStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		IfStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetCondition(Expression condition)
	{
		IfStmt result = setCondition(condition);
		
		return result;
	}

	
	static IfStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithCondition.NodeWithCondition_003A_003AsetCondition(Expression P_0)
	{
		return _003Cbridge_003EsetCondition(P_0);
	}
}
