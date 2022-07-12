using System;
using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class IntegerLiteralExpr : LiteralStringValueExpr
{
	public const string MAX_31_BIT_UNSIGNED_VALUE_AS_STRING = "2147483648";

	public const long MAX_31_BIT_UNSIGNED_VALUE_AS_LONG = 2147483648L;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public IntegerLiteralExpr(string value)
		: this(null, value)
	{
	}

	
	
	public IntegerLiteralExpr()
		: this(null, "0")
	{
	}

	
	
	
	public IntegerLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual int asInt()
	{
		string text = java.lang.String.instancehelper_replaceAll(value, "_", "");
		if (java.lang.String.instancehelper_startsWith(text, "0x") || java.lang.String.instancehelper_startsWith(text, "0X"))
		{
			int result = Integer.parseUnsignedInt(java.lang.String.instancehelper_substring(text, 2), 16);
			
			return result;
		}
		if (java.lang.String.instancehelper_startsWith(text, "0b") || java.lang.String.instancehelper_startsWith(text, "0B"))
		{
			int result2 = Integer.parseUnsignedInt(java.lang.String.instancehelper_substring(text, 2), 2);
			
			return result2;
		}
		if (java.lang.String.instancehelper_length(text) > 1 && java.lang.String.instancehelper_startsWith(text, "0"))
		{
			int result3 = Integer.parseUnsignedInt(java.lang.String.instancehelper_substring(text, 1), 8);
			
			return result3;
		}
		int result4 = Integer.parseInt(text);
		
		return result4;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual IntegerLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EintegerLiteralExprMetaModel;
	}

	
	
	public new virtual IntegerLiteralExpr clone()
	{
		return (IntegerLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public IntegerLiteralExpr(int value)
		: this(null, java.lang.String.valueOf(value))
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	public virtual Number asNumber()
	{
		if (Objects.equals(value, "2147483648") && Utils.hasUnaryMinusAsParent(this))
		{
			Long result = Long.valueOf(2147483648L);
			
			return result;
		}
		Integer result2 = Integer.valueOf(asInt());
		
		return result2;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual IntegerLiteralExpr setInt(int value)
	{
		base.value = java.lang.String.valueOf(value);
		return this;
	}

	public override bool isIntegerLiteralExpr()
	{
		return true;
	}

	public override IntegerLiteralExpr asIntegerLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifIntegerLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toIntegerLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntegerLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		IntegerLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntegerLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		IntegerLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntegerLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		IntegerLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntegerLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		IntegerLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		IntegerLiteralExpr result = clone();
		
		return result;
	}

	
	static IntegerLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
	}
}
