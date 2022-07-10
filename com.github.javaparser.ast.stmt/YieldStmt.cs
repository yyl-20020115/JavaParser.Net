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


public class YieldStmt : Statement, NodeWithExpression
{
	private Expression expression;
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public YieldStmt(TokenRange tokenRange, Expression expression)
		: base(tokenRange)
	{
		setExpression(expression);
		customInitialization();
	}

	
	
	
	public virtual YieldStmt setExpression(Expression expression)
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

	
	
	public new virtual YieldStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EyieldStmtMetaModel;
	}

	
	
	public new virtual YieldStmt clone()
	{
		return (YieldStmt)accept(new CloneVisitor(), null);
	}

	
	
	public YieldStmt()
		: this(null, new NameExpr())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public YieldStmt(Expression expression)
		: this(null, expression)
	{
	}

	public virtual Expression getExpression()
	{
		return expression;
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

	public override bool isYieldStmt()
	{
		return true;
	}

	public override YieldStmt asYieldStmt()
	{
		return this;
	}

	
		
	public override Optional toYieldStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifYieldStmt(Consumer action)
	{
		action.accept(this);
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
		if (node == expression)
		{
			setExpression((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		YieldStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		YieldStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		YieldStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		YieldStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		YieldStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		YieldStmt result = setExpression(expression);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setExpression(string P_0)
	{
		return NodeWithExpression._003Cdefault_003EsetExpression(this, P_0);
	}

	
	static YieldStmt()
	{

	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
