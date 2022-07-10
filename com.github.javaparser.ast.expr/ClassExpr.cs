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


public class ClassExpr : Expression, NodeWithType
{
	private Type type;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ClassExpr(TokenRange tokenRange, Type type)
		: base(tokenRange)
	{
		setType(type);
		customInitialization();
	}

	
	
	
	public virtual ClassExpr setType(Type type)
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

	
	
	public new virtual ClassExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EclassExprMetaModel;
	}

	
	
	public new virtual ClassExpr clone()
	{
		return (ClassExpr)accept(new CloneVisitor(), null);
	}

	
	
	public ClassExpr()
		: this(null, new ClassOrInterfaceType())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ClassExpr(Type type)
		: this(null, type)
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

	public virtual Type getType()
	{
		return type;
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
		if (node == type)
		{
			setType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isClassExpr()
	{
		return true;
	}

	public override ClassExpr asClassExpr()
	{
		return this;
	}

	
		
	
	public override void ifClassExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toClassExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ClassExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ClassExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ClassExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		ClassExpr result = setType(type);
		
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

	
	static ClassExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
	}
}
