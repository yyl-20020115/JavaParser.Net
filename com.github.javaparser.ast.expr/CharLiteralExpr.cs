using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class CharLiteralExpr : LiteralStringValueExpr
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CharLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public CharLiteralExpr(string value)
		: this(null, value)
	{
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

	
	
	public new virtual CharLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcharLiteralExprMetaModel;
	}

	
	
	public new virtual CharLiteralExpr clone()
	{
		return (CharLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	public CharLiteralExpr()
		: this(null, "?")
	{
	}

	
	
	
	public CharLiteralExpr(char value)
		: this(null, StringEscapeUtils.escapeJava(String.valueOf(value)))
	{
	}

	
	
	
	public static CharLiteralExpr escape(string @string)
	{
		CharLiteralExpr result = new CharLiteralExpr(Utils.escapeEndOfLines(@string));
		
		return result;
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

	
	
	public virtual char asChar()
	{
		char result = String.instancehelper_charAt(StringEscapeUtils.unescapeJava(value), 0);
		
		return result;
	}

	
	
	
	public virtual CharLiteralExpr setChar(char value)
	{
		base.value = String.valueOf(value);
		return this;
	}

	public override bool isCharLiteralExpr()
	{
		return true;
	}

	public override CharLiteralExpr asCharLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifCharLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toCharLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		CharLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		CharLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		CharLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		CharLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		CharLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		CharLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CharLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		CharLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CharLiteralExpr result = clone();
		
		return result;
	}

	
	static CharLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
	}
}
