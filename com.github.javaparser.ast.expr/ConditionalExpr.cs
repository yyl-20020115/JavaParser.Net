using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class ConditionalExpr : Expression, NodeWithCondition
{
	private Expression condition;

	private Expression thenExpr;

	private Expression elseExpr;

	
	
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
	
	public ConditionalExpr(TokenRange tokenRange, Expression condition, Expression thenExpr, Expression elseExpr)
		: base(tokenRange)
	{
		setCondition(condition);
		setThenExpr(thenExpr);
		setElseExpr(elseExpr);
		customInitialization();
	}

	
	
	
	public virtual ConditionalExpr setCondition(Expression condition)
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

	
	
	
	public virtual ConditionalExpr setThenExpr(Expression thenExpr)
	{
		Utils.assertNotNull(thenExpr);
		if (thenExpr == this.thenExpr)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETHEN_EXPR, this.thenExpr, thenExpr);
		if (this.thenExpr != null)
		{
			this.thenExpr.setParentNode(null);
		}
		this.thenExpr = thenExpr;
		setAsParentNodeOf(thenExpr);
		return this;
	}

	
	
	
	public virtual ConditionalExpr setElseExpr(Expression elseExpr)
	{
		Utils.assertNotNull(elseExpr);
		if (elseExpr == this.elseExpr)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EELSE_EXPR, this.elseExpr, elseExpr);
		if (this.elseExpr != null)
		{
			this.elseExpr.setParentNode(null);
		}
		this.elseExpr = elseExpr;
		setAsParentNodeOf(elseExpr);
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

	
	
	public new virtual ConditionalExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EconditionalExprMetaModel;
	}

	
	
	public new virtual ConditionalExpr clone()
	{
		return (ConditionalExpr)accept(new CloneVisitor(), null);
	}

	
	
	public ConditionalExpr()
		: this(null, new BooleanLiteralExpr(), new StringLiteralExpr(), new StringLiteralExpr())
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ConditionalExpr(Expression condition, Expression thenExpr, Expression elseExpr)
		: this(null, condition, thenExpr, elseExpr)
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

	public virtual Expression getElseExpr()
	{
		return elseExpr;
	}

	public virtual Expression getThenExpr()
	{
		return thenExpr;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		107, 99, 130, 105, 109, 130, 105, 109, 130, 105,
		109, 130
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
		if (node == elseExpr)
		{
			setElseExpr((Expression)replacementNode);
			return true;
		}
		if (node == thenExpr)
		{
			setThenExpr((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isConditionalExpr()
	{
		return true;
	}

	public override ConditionalExpr asConditionalExpr()
	{
		return this;
	}

	
		
	
	public override void ifConditionalExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toConditionalExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public override bool isPolyExpression()
	{
		return (appearsInAssignmentContext() || appearsInInvocationContext()) ? true : false;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ConditionalExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ConditionalExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ConditionalExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ConditionalExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ConditionalExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetCondition(Expression condition)
	{
		ConditionalExpr result = setCondition(condition);
		
		return result;
	}

	
	static ConditionalExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithCondition.NodeWithCondition_003A_003AsetCondition(Expression P_0)
	{
		return _003Cbridge_003EsetCondition(P_0);
	}
}
