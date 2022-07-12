using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class CastExpr : Expression, NodeWithType, NodeWithExpression
{
	private Type type;

	private Expression expression;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public CastExpr(TokenRange tokenRange, Type type, Expression expression)
		: base(tokenRange)
	{
		setType(type);
		setExpression(expression);
		customInitialization();
	}

	
	
	
	public virtual CastExpr setType(Type type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		if (this.type != null)
		{
			this.type.setParentNode(null);
		}
		this.type = type;
		setAsParentNodeOf(type);
		return this;
	}

	
	
	
	public virtual CastExpr setExpression(Expression expression)
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

	
	
	public new virtual CastExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcastExprMetaModel;
	}

	
	
	public new virtual CastExpr clone()
	{
		return (CastExpr)accept(new CloneVisitor(), null);
	}

	
	
	public CastExpr()
		: this(null, new ClassOrInterfaceType(), new NameExpr())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public CastExpr(Type type, Expression expression)
		: this(null, type, expression)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Expression getExpression()
	{
		return expression;
	}

	public virtual Type getType()
	{
		return type;
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
		if (node == type)
		{
			setType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isCastExpr()
	{
		return true;
	}

	public override CastExpr asCastExpr()
	{
		return this;
	}

	
		
	
	public override void ifCastExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toCastExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		CastExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		CastExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CastExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		CastExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CastExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		CastExpr result = setType(type);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		CastExpr result = setExpression(expression);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setType(Class P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setType(string P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getTypeAsString()
	{
		return NodeWithType._003Cdefault_003EgetTypeAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setExpression(string P_0)
	{
		return NodeWithExpression._003Cdefault_003EsetExpression(this, P_0);
	}

	
	static CastExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
