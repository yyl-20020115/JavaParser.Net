using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class ExplicitConstructorInvocationStmt : Statement, NodeWithTypeArguments, NodeWithArguments, Resolvable
{
		[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private NodeList typeArguments;

	private bool m_isThis;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Expression expression;

		private NodeList arguments;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ExplicitConstructorInvocationStmt(TokenRange tokenRange, NodeList typeArguments, bool isThis, Expression expression, NodeList arguments)
		: base(tokenRange)
	{
		setTypeArguments(typeArguments);
		setThis(isThis);
		setExpression(expression);
		setArguments(arguments);
		customInitialization();
	}

	
		
	
	public virtual ExplicitConstructorInvocationStmt setTypeArguments(NodeList typeArguments)
	{
		if (typeArguments == this.typeArguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_ARGUMENTS, this.typeArguments, typeArguments);
		if (this.typeArguments != null)
		{
			this.typeArguments.setParentNode(null);
		}
		this.typeArguments = typeArguments;
		setAsParentNodeOf(typeArguments);
		return this;
	}

	
	
	
	public virtual ExplicitConstructorInvocationStmt setThis(bool isThis)
	{
		if (isThis == this.m_isThis)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETHIS, Boolean.valueOf(this.m_isThis), Boolean.valueOf(isThis));
		this.m_isThis = isThis;
		return this;
	}

	
	
	
	public virtual ExplicitConstructorInvocationStmt setExpression(Expression expression)
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

	
		
	
	public virtual ExplicitConstructorInvocationStmt setArguments(NodeList arguments)
	{
		Utils.assertNotNull(arguments);
		if (arguments == this.arguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EARGUMENTS, this.arguments, arguments);
		if (this.arguments != null)
		{
			this.arguments.setParentNode(null);
		}
		this.arguments = arguments;
		setAsParentNodeOf(arguments);
		return this;
	}

	
	
	public virtual ExplicitConstructorInvocationStmt removeExpression()
	{
		ExplicitConstructorInvocationStmt result = setExpression(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ExplicitConstructorInvocationStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EexplicitConstructorInvocationStmtMetaModel;
	}

	
	
	public new virtual ExplicitConstructorInvocationStmt clone()
	{
		return (ExplicitConstructorInvocationStmt)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedConstructorDeclaration resolve()
	{
		return (ResolvedConstructorDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedConstructorDeclaration>.Value);
	}

	
	
	public ExplicitConstructorInvocationStmt()
		: this(null, null, isThis: true, null, new NodeList())
	{
	}

	
		
	
	public ExplicitConstructorInvocationStmt(bool isThis, Expression expression, NodeList arguments)
		: this(null, null, isThis, expression, arguments)
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ExplicitConstructorInvocationStmt(NodeList typeArguments, bool isThis, Expression expression, NodeList arguments)
		: this(null, typeArguments, isThis, expression, arguments)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getArguments()
	{
		return arguments;
	}

	
		
	public virtual Optional getExpression()
	{
		Optional result = Optional.ofNullable(expression);
		
		return result;
	}

	public virtual bool isThis()
	{
		return this.m_isThis;
	}

	
		
	public virtual Optional getTypeArguments()
	{
		Optional result = Optional.ofNullable(typeArguments);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.remove(i);
				return true;
			}
		}
		if (expression != null && node == expression)
		{
			removeExpression();
			return true;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.remove(i);
					return true;
				}
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
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.set(i, (Expression)replacementNode);
				return true;
			}
		}
		if (expression != null && node == expression)
		{
			setExpression((Expression)replacementNode);
			return true;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.set(i, (Type)replacementNode);
					return true;
				}
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isExplicitConstructorInvocationStmt()
	{
		return true;
	}

	public override ExplicitConstructorInvocationStmt asExplicitConstructorInvocationStmt()
	{
		return this;
	}

	
		
	
	public override void ifExplicitConstructorInvocationStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toExplicitConstructorInvocationStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ExplicitConstructorInvocationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ExplicitConstructorInvocationStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ExplicitConstructorInvocationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ExplicitConstructorInvocationStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ExplicitConstructorInvocationStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		ExplicitConstructorInvocationStmt result = setTypeArguments(typeArguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetArguments(NodeList arguments)
	{
		ExplicitConstructorInvocationStmt result = setArguments(arguments);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedConstructorDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUsingDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EisUsingDiamondOperator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EsetDiamondOperator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node removeTypeArguments()
	{
		return NodeWithTypeArguments._003Cdefault_003EremoveTypeArguments(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setTypeArguments(Type[] P_0)
	{
		return NodeWithTypeArguments._003Cdefault_003EsetTypeArguments(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Expression getArgument(int P_0)
	{
		return NodeWithArguments._003Cdefault_003EgetArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(string P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(Expression P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setArgument(int P_0, Expression P_1)
	{
		return NodeWithArguments._003Cdefault_003EsetArgument(this, P_0, P_1);
	}

	
	static ExplicitConstructorInvocationStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}

	Node NodeWithArguments.NodeWithArguments_003A_003AsetArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetArguments(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
