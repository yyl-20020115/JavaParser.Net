using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class StringLiteralExpr : LiteralStringValueExpr
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public StringLiteralExpr(string value)
		: this(null, Utils.escapeEndOfLines(value))
	{
	}

	
	
	public StringLiteralExpr()
		: this(null, "empty")
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public StringLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
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

	
	
	public new virtual StringLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EstringLiteralExprMetaModel;
	}

	
	
	public new virtual StringLiteralExpr clone()
	{
		return (StringLiteralExpr)accept(new CloneVisitor(), null);
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

	
	
	
	public virtual StringLiteralExpr setEscapedValue(string value)
	{
		base.value = Utils.escapeEndOfLines(value);
		return this;
	}

	
	
	public virtual string asString()
	{
		string result = StringEscapeUtils.unescapeJava(value);
		
		return result;
	}

	
	
	
	public virtual StringLiteralExpr setString(string value)
	{
		base.value = StringEscapeUtils.escapeJava(value);
		return this;
	}

	public override bool isStringLiteralExpr()
	{
		return true;
	}

	public override StringLiteralExpr asStringLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifStringLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toStringLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		StringLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		StringLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		StringLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		StringLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		StringLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		StringLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		StringLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		StringLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		StringLiteralExpr result = clone();
		
		return result;
	}

	
	static StringLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
	}
}
