using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class EnclosedExpr : Expression
{
	private Expression inner;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public EnclosedExpr(TokenRange tokenRange, Expression inner)
		: base(tokenRange)
	{
		setInner(inner);
		customInitialization();
	}

	
	
	
	public virtual EnclosedExpr setInner(Expression inner)
	{
		Utils.assertNotNull(inner);
		if (inner == this.inner)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EINNER, this.inner, inner);
		if (this.inner != null)
		{
			this.inner.setParentNode(null);
		}
		this.inner = inner;
		setAsParentNodeOf(inner);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	public virtual Expression getInner()
	{
		return inner;
	}

	
	
	public new virtual EnclosedExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EenclosedExprMetaModel;
	}

	
	
	public new virtual EnclosedExpr clone()
	{
		return (EnclosedExpr)accept(new CloneVisitor(), null);
	}

	
	
	public EnclosedExpr()
		: this(null, new StringLiteralExpr())
	{
	}

	
	
	
	
	public EnclosedExpr(Expression inner)
		: this(null, inner)
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
		if (node == inner)
		{
			setInner((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isEnclosedExpr()
	{
		return true;
	}

	public override EnclosedExpr asEnclosedExpr()
	{
		return this;
	}

	
		
	
	public override void ifEnclosedExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toEnclosedExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public override bool isPolyExpression()
	{
		bool result = getInner().isPolyExpression();
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnclosedExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		EnclosedExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnclosedExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		EnclosedExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		EnclosedExpr result = clone();
		
		return result;
	}

	
	static EnclosedExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
