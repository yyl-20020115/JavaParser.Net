using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class DoubleLiteralExpr : LiteralStringValueExpr
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public DoubleLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual DoubleLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EdoubleLiteralExprMetaModel;
	}

	
	
	public new virtual DoubleLiteralExpr clone()
	{
		return (DoubleLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	public DoubleLiteralExpr()
		: this(null, "0")
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public DoubleLiteralExpr(string value)
		: this(null, value)
	{
	}

	
	
	
	public DoubleLiteralExpr(double value)
		: this(null, String.valueOf(value))
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	public virtual double asDouble()
	{
		string s = String.instancehelper_replaceAll(value, "_", "");
		double result = Double.parseDouble(s);
		
		return result;
	}

	
	
	
	public virtual DoubleLiteralExpr setDouble(double value)
	{
		base.value = String.valueOf(value);
		return this;
	}

	public override bool isDoubleLiteralExpr()
	{
		return true;
	}

	public override DoubleLiteralExpr asDoubleLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifDoubleLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toDoubleLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoubleLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		DoubleLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoubleLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		DoubleLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoubleLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		DoubleLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		DoubleLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		DoubleLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		DoubleLiteralExpr result = clone();
		
		return result;
	}

	
	static DoubleLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
	}
}
