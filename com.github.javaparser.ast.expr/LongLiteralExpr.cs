using System;
using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.math;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class LongLiteralExpr : LiteralStringValueExpr
{
	public const string MAX_63_BIT_UNSIGNED_VALUE_AS_STRING = "9223372036854775808L";

	internal static BigInteger ___003C_003EMAX_63_BIT_UNSIGNED_VALUE_AS_BIG_INTEGER;

	
	public static BigInteger MAX_63_BIT_UNSIGNED_VALUE_AS_BIG_INTEGER
	{
		
		get
		{
			return ___003C_003EMAX_63_BIT_UNSIGNED_VALUE_AS_BIG_INTEGER;
		}
	}

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public LongLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual long asLong()
	{
		string text = java.lang.String.instancehelper_replaceAll(value, "_", "");
		int num = java.lang.String.instancehelper_charAt(text, java.lang.String.instancehelper_length(text) - 1);
		if (num == 108 || num == 76)
		{
			text = java.lang.String.instancehelper_substring(text, 0, java.lang.String.instancehelper_length(text) - 1);
		}
		if (java.lang.String.instancehelper_startsWith(text, "0x") || java.lang.String.instancehelper_startsWith(text, "0X"))
		{
			long result = Long.parseUnsignedLong(java.lang.String.instancehelper_substring(text, 2), 16);
			
			return result;
		}
		if (java.lang.String.instancehelper_startsWith(text, "0b") || java.lang.String.instancehelper_startsWith(text, "0B"))
		{
			long result2 = Long.parseUnsignedLong(java.lang.String.instancehelper_substring(text, 2), 2);
			
			return result2;
		}
		if (java.lang.String.instancehelper_length(text) > 1 && java.lang.String.instancehelper_startsWith(text, "0"))
		{
			long result3 = Long.parseUnsignedLong(java.lang.String.instancehelper_substring(text, 1), 8);
			
			return result3;
		}
		long result4 = Long.parseLong(text);
		
		return result4;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual LongLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElongLiteralExprMetaModel;
	}

	
	
	public new virtual LongLiteralExpr clone()
	{
		return (LongLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	public LongLiteralExpr()
		: this(null, "0")
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LongLiteralExpr(string value)
		: this(null, value)
	{
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public LongLiteralExpr(long value)
		: this(null, java.lang.String.valueOf(value))
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	public virtual Number asNumber()
	{
		if (Objects.equals(value, "9223372036854775808L") && Utils.hasUnaryMinusAsParent(this))
		{
			return ___003C_003EMAX_63_BIT_UNSIGNED_VALUE_AS_BIG_INTEGER;
		}
		Long result = Long.valueOf(asLong());
		
		return result;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual LongLiteralExpr setLong(long value)
	{
		base.value = java.lang.String.valueOf(value);
		return this;
	}

	public override bool isLongLiteralExpr()
	{
		return true;
	}

	public override LongLiteralExpr asLongLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifLongLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLongLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		LongLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		LongLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		LongLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		LongLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		LongLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		LongLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LongLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LongLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LongLiteralExpr result = clone();
		
		return result;
	}

	
	static LongLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
		___003C_003EMAX_63_BIT_UNSIGNED_VALUE_AS_BIG_INTEGER = new BigInteger("9223372036854775808");
	}
}
