using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public abstract class LiteralStringValueExpr : LiteralExpr
{
	protected internal string value;

	
	
	
	public LiteralStringValueExpr(TokenRange tokenRange, string value)
		: base(tokenRange)
	{
		setValue(value);
		customInitialization();
	}

	
	
	
	public virtual LiteralStringValueExpr setValue(string value)
	{
		Utils.assertNotNull(value);
		if ((object)value == this.value)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVALUE, this.value, value);
		this.value = value;
		return this;
	}

	
	
	public new virtual LiteralStringValueExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EliteralStringValueExprMetaModel;
	}

	
	
	public new virtual LiteralStringValueExpr clone()
	{
		return (LiteralStringValueExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	
	public LiteralStringValueExpr(string value)
		: this(null, value)
	{
	}

	public virtual string getValue()
	{
		return value;
	}

	public override bool isLiteralStringValueExpr()
	{
		return true;
	}

	public override LiteralStringValueExpr asLiteralStringValueExpr()
	{
		return this;
	}

	
		
	
	public override void ifLiteralStringValueExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLiteralStringValueExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		LiteralStringValueExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralExpr _003Cbridge_003Eclone()
	{
		LiteralStringValueExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		LiteralStringValueExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		LiteralStringValueExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LiteralStringValueExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LiteralStringValueExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LiteralStringValueExpr result = clone();
		
		return result;
	}

	
	static LiteralStringValueExpr()
	{
		LiteralExpr.___003Cclinit_003E();
	}
}
