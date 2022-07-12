using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class ArrayInitializerExpr : Expression
{
		private NodeList values;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	public ArrayInitializerExpr()
		: this(null, new NodeList())
	{
	}

	
		
	
	public ArrayInitializerExpr(TokenRange tokenRange, NodeList values)
		: base(tokenRange)
	{
		setValues(values);
		customInitialization();
	}

	
		
	
	public virtual ArrayInitializerExpr setValues(NodeList values)
	{
		Utils.assertNotNull(values);
		if (values == this.values)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVALUES, this.values, values);
		if (this.values != null)
		{
			this.values.setParentNode(null);
		}
		this.values = values;
		setAsParentNodeOf(values);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ArrayInitializerExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EarrayInitializerExprMetaModel;
	}

	
	
	public new virtual ArrayInitializerExpr clone()
	{
		return (ArrayInitializerExpr)accept(new CloneVisitor(), null);
	}

	
		
	
	
	public ArrayInitializerExpr(NodeList values)
		: this(null, values)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getValues()
	{
		return values;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < values.size(); i++)
		{
			if (values.get(i) == node)
			{
				values.remove(i);
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
		for (int i = 0; i < values.size(); i++)
		{
			if (values.get(i) == node)
			{
				values.set(i, (Expression)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isArrayInitializerExpr()
	{
		return true;
	}

	public override ArrayInitializerExpr asArrayInitializerExpr()
	{
		return this;
	}

	
		
	
	public override void ifArrayInitializerExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toArrayInitializerExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayInitializerExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ArrayInitializerExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayInitializerExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ArrayInitializerExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ArrayInitializerExpr result = clone();
		
		return result;
	}

	
	static ArrayInitializerExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
