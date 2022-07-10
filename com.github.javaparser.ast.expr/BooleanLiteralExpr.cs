using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class BooleanLiteralExpr : LiteralExpr
{
	private bool value;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	public BooleanLiteralExpr()
		: this(null, value: false)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public BooleanLiteralExpr(TokenRange tokenRange, bool value)
		: base(tokenRange)
	{
		setValue(value);
		customInitialization();
	}

	
	
	
	public virtual BooleanLiteralExpr setValue(bool value)
	{
		if (value == this.value)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVALUE, Boolean.valueOf(this.value), Boolean.valueOf(value));
		this.value = value;
		return this;
	}

	public virtual bool isValue()
	{
		return value;
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

	
	
	public new virtual BooleanLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EbooleanLiteralExprMetaModel;
	}

	
	
	public new virtual BooleanLiteralExpr clone()
	{
		return (BooleanLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public BooleanLiteralExpr(bool value)
		: this(null, value)
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

	
	
	public virtual bool getValue()
	{
		bool result = isValue();
		
		return result;
	}

	public override bool isBooleanLiteralExpr()
	{
		return true;
	}

	public override BooleanLiteralExpr asBooleanLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifBooleanLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toBooleanLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		BooleanLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralExpr _003Cbridge_003Eclone()
	{
		BooleanLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		BooleanLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		BooleanLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		BooleanLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		BooleanLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		BooleanLiteralExpr result = clone();
		
		return result;
	}

	
	static BooleanLiteralExpr()
	{
		LiteralExpr.___003Cclinit_003E();
	}
}
