using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class ReturnStmt : Statement
{
	
	private Expression expression;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ReturnStmt(string expression)
		: this(null, new NameExpr(expression))
	{
	}

	
	
	public ReturnStmt()
		: this(null, null)
	{
	}

	
	
	
	public ReturnStmt(TokenRange tokenRange, Expression expression)
		: base(tokenRange)
	{
		setExpression(expression);
		customInitialization();
	}

	
	
	
	public virtual ReturnStmt setExpression(Expression expression)
	{
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

	
	
	public virtual ReturnStmt removeExpression()
	{
		ReturnStmt result = setExpression(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ReturnStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EreturnStmtMetaModel;
	}

	
	
	public new virtual ReturnStmt clone()
	{
		return (ReturnStmt)accept(new CloneVisitor(), null);
	}

	
	
	
	
	public ReturnStmt(Expression expression)
		: this(null, expression)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	public virtual Optional getExpression()
	{
		Optional result = Optional.ofNullable(expression);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (expression != null && node == expression)
		{
			removeExpression();
			return true;
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
		if (expression != null && node == expression)
		{
			setExpression((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isReturnStmt()
	{
		return true;
	}

	public override ReturnStmt asReturnStmt()
	{
		return this;
	}

	
		
	
	public override void ifReturnStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toReturnStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ReturnStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ReturnStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ReturnStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ReturnStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ReturnStmt result = clone();
		
		return result;
	}

	
	static ReturnStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
