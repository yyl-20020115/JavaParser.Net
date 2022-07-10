using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class ThisExpr : Expression, Resolvable
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

	
	
	public ThisExpr()
		: this(null, null)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ThisExpr(TokenRange tokenRange, Name typeName)
		: base(tokenRange)
	{
		setTypeName(typeName);
		customInitialization();
	}

	
	
	
	public virtual ThisExpr setTypeName(Name typeName)
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

	
	
	public virtual ThisExpr removeTypeName()
	{
		ThisExpr result = setTypeName(null);
		
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

	
	
	public new virtual ThisExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EthisExprMetaModel;
	}

	
	
	public new virtual ThisExpr clone()
	{
		return (ThisExpr)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedTypeDeclaration resolve()
	{
		return (ResolvedTypeDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedTypeDeclaration>.Value);
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ThisExpr(Name typeName)
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

	
	
	public virtual ThisExpr removeClassName()
	{
		ThisExpr result = setTypeName(null);
		
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

	public override bool isThisExpr()
	{
		return true;
	}

	public override ThisExpr asThisExpr()
	{
		return this;
	}

	
		
	
	public override void ifThisExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toThisExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ThisExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ThisExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ThisExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ThisExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ThisExpr result = clone();
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedTypeDeclaration result = resolve();
		
		return result;
	}

	
	static ThisExpr()
	{
		Expression.___003Cclinit_003E();
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
