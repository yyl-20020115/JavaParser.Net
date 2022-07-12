using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public abstract class LiteralExpr : Expression
{
	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public LiteralExpr(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
	
	public new virtual LiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EliteralExprMetaModel;
	}

	
	
	public new virtual LiteralExpr clone()
	{
		return (LiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	public LiteralExpr()
		: this(null)
	{
	}

	public override bool isLiteralExpr()
	{
		return true;
	}

	public override LiteralExpr asLiteralExpr()
	{
		return this;
	}

	
		
	
	public override void ifLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		LiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		LiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LiteralExpr result = clone();
		
		return result;
	}

	
	static LiteralExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
