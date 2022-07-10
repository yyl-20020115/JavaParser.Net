using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class SuperExpr : Expression
{
	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Name typeName;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public SuperExpr(TokenRange tokenRange, Name typeName)
		: base(tokenRange)
	{
		setTypeName(typeName);
		customInitialization();
	}

	
	
	
	public virtual SuperExpr setTypeName(Name typeName)
	{
		if (typeName == this.typeName)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_NAME, this.typeName, typeName);
		if (this.typeName != null)
		{
			this.typeName.setParentNode(null);
		}
		this.typeName = typeName;
		setAsParentNodeOf(typeName);
		return this;
	}

	
	
	public virtual SuperExpr removeTypeName()
	{
		SuperExpr result = setTypeName(null);
		
		return result;
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

	
	
	public new virtual SuperExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EsuperExprMetaModel;
	}

	
	
	public new virtual SuperExpr clone()
	{
		return (SuperExpr)accept(new CloneVisitor(), null);
	}

	
	
	public SuperExpr()
		: this(null, null)
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public SuperExpr(Name typeName)
		: this(null, typeName)
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

	
		
	public virtual Optional getTypeName()
	{
		Optional result = Optional.ofNullable(typeName);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (typeName != null && node == typeName)
		{
			removeTypeName();
			return true;
		}
		bool result = base.remove(node);
		
		return result;
	}

	public override bool isSuperExpr()
	{
		return true;
	}

	public override SuperExpr asSuperExpr()
	{
		return this;
	}

	
		
	
	public override void ifSuperExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toSuperExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public virtual SuperExpr removeClassName()
	{
		SuperExpr result = setTypeName(null);
		
		return result;
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
		if (typeName != null && node == typeName)
		{
			setTypeName((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		SuperExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SuperExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	static SuperExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
