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


public class ExpressionStmt : Statement, NodeWithExpression
{
	private Expression expression;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public ExpressionStmt(Expression expression)
		: this(null, expression)
	{
	}

	public virtual Expression getExpression()
	{
		return expression;
	}

	
	
	
	public ExpressionStmt(TokenRange tokenRange, Expression expression)
		: base(tokenRange)
	{
		setExpression(expression);
		customInitialization();
	}

	
	
	
	public virtual ExpressionStmt setExpression(Expression expression)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ExpressionStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EexpressionStmtMetaModel;
	}

	
	
	public new virtual ExpressionStmt clone()
	{
		return (ExpressionStmt)accept(new CloneVisitor(), null);
	}

	
	
	public ExpressionStmt()
		: this(null, new BooleanLiteralExpr())
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
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

	public override bool isExpressionStmt()
	{
		return true;
	}

	public override ExpressionStmt asExpressionStmt()
	{
		return this;
	}

	
		
	
	public override void ifExpressionStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toExpressionStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ExpressionStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ExpressionStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ExpressionStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ExpressionStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ExpressionStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		ExpressionStmt result = setExpression(expression);
		
		return result;
	}


	public virtual Node setExpression(string P_0)
	{
		return NodeWithExpression._003Cdefault_003EsetExpression(this, P_0);
	}

	
	static ExpressionStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
