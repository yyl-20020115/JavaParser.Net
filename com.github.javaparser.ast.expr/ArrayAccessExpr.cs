using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class ArrayAccessExpr : Expression
{
	private Expression name;

	private Expression index;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ArrayAccessExpr(TokenRange tokenRange, Expression name, Expression index)
		: base(tokenRange)
	{
		setName(name);
		setIndex(index);
		customInitialization();
	}

	
	
	
	public virtual ArrayAccessExpr setName(Expression name)
	{
		Utils.assertNotNull(name);
		if (name == this.name)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ENAME, this.name, name);
		if (this.name != null)
		{
			this.name.setParentNode(null);
		}
		this.name = name;
		setAsParentNodeOf(name);
		return this;
	}

	
	
	
	public virtual ArrayAccessExpr setIndex(Expression index)
	{
		Utils.assertNotNull(index);
		if (index == this.index)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EINDEX, this.index, index);
		if (this.index != null)
		{
			this.index.setParentNode(null);
		}
		this.index = index;
		setAsParentNodeOf(index);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ArrayAccessExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EarrayAccessExprMetaModel;
	}

	
	
	public new virtual ArrayAccessExpr clone()
	{
		return (ArrayAccessExpr)accept(new CloneVisitor(), null);
	}

	
	
	public ArrayAccessExpr()
		: this(null, new NameExpr(), new IntegerLiteralExpr())
	{
	}

	
	
	
	
	public ArrayAccessExpr(Expression name, Expression index)
		: this(null, name, index)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Expression getIndex()
	{
		return index;
	}

	public virtual Expression getName()
	{
		return name;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == index)
		{
			setIndex((Expression)replacementNode);
			return true;
		}
		if (node == name)
		{
			setName((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isArrayAccessExpr()
	{
		return true;
	}

	public override ArrayAccessExpr asArrayAccessExpr()
	{
		return this;
	}

	
		
	
	public override void ifArrayAccessExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toArrayAccessExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayAccessExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ArrayAccessExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayAccessExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ArrayAccessExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ArrayAccessExpr result = clone();
		
		return result;
	}

	
	static ArrayAccessExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
