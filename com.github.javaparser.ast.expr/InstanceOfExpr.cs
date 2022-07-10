using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class InstanceOfExpr : Expression, NodeWithType, NodeWithExpression
{
	private Expression expression;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private PatternExpr pattern;

	private ReferenceType type;

	
	
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
	
	public InstanceOfExpr(TokenRange tokenRange, Expression expression, ReferenceType type, PatternExpr pattern)
		: base(tokenRange)
	{
		setExpression(expression);
		setType(type);
		setPattern(pattern);
		customInitialization();
	}

	
	
	
	public virtual InstanceOfExpr setExpression(Expression expression)
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

	
	
	
	public virtual InstanceOfExpr setType(ReferenceType type)
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

	
	
	
	public virtual InstanceOfExpr setPattern(PatternExpr pattern)
	{
		if (pattern == this.pattern)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPATTERN, this.pattern, pattern);
		if (this.pattern != null)
		{
			this.pattern.setParentNode(null);
		}
		this.pattern = pattern;
		setAsParentNodeOf(pattern);
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

	
	
	public virtual InstanceOfExpr removePattern()
	{
		InstanceOfExpr result = setPattern(null);
		
		return result;
	}

	
	
	public new virtual InstanceOfExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EinstanceOfExprMetaModel;
	}

	
	
	public new virtual InstanceOfExpr clone()
	{
		return (InstanceOfExpr)accept(new CloneVisitor(), null);
	}

	public virtual ReferenceType getType()
	{
		return type;
	}

	
	
	public InstanceOfExpr()
		: this(null, new NameExpr(), new ClassOrInterfaceType(), null)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public InstanceOfExpr(Expression expression, ReferenceType type)
		: this(null, expression, type, null)
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
	public InstanceOfExpr(Expression expression, ReferenceType type, PatternExpr pattern)
		: this(null, expression, type, pattern)
	{
	}

	
		
	public virtual Optional getName()
	{
		if (pattern == null)
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(pattern.getName());
		
		return result2;
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

	public override InstanceOfExpr asInstanceOfExpr()
	{
		return this;
	}

	public virtual Expression getExpression()
	{
		return expression;
	}

	
		
	public virtual Optional getPattern()
	{
		Optional result = Optional.ofNullable(pattern);
		
		return result;
	}

	
		
	
	public override void ifInstanceOfExpr(Consumer action)
	{
		action.accept(this);
	}

	public override bool isInstanceOfExpr()
	{
		return true;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (pattern != null && node == pattern)
		{
			removePattern();
			return true;
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 113, 99, 130, 105, 109, 130, 104, 105, 109,
		162, 105, 109, 130
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
		if (pattern != null && node == pattern)
		{
			setPattern((PatternExpr)replacementNode);
			return true;
		}
		if (node == type)
		{
			setType((ReferenceType)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
		
	public override Optional toInstanceOfExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		InstanceOfExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		InstanceOfExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		InstanceOfExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		InstanceOfExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		InstanceOfExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node setType(Type type)
	{
		InstanceOfExpr result = setType((ReferenceType)type);
		
		return result;
	}

	
	
	
	
	public virtual Type _003Cbridge_003EgetType()
	{
		ReferenceType result = getType();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		InstanceOfExpr result = setExpression(expression);
		
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

	
	static InstanceOfExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Type NodeWithType.NodeWithType_003A_003AgetType()
	{
		return _003Cbridge_003EgetType();
	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
