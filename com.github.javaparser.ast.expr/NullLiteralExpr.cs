using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class NullLiteralExpr : LiteralExpr
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public NullLiteralExpr(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual NullLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EnullLiteralExprMetaModel;
	}

	
	
	public new virtual NullLiteralExpr clone()
	{
		return (NullLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public NullLiteralExpr()
		: this(null)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isNullLiteralExpr()
	{
		return true;
	}

	public override NullLiteralExpr asNullLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifNullLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toNullLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		NullLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralExpr _003Cbridge_003Eclone()
	{
		NullLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		NullLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		NullLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		NullLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		NullLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		NullLiteralExpr result = clone();
		
		return result;
	}

	
	static NullLiteralExpr()
	{
		LiteralExpr.___003Cclinit_003E();
	}
}
