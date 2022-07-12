using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class SuperExpr : Expression
{
	
	private Name typeName;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public SuperExpr(TokenRange tokenRange, Name typeName)
		: base(tokenRange)
	{
		setTypeName(typeName);
		customInitialization();
	}

	
	
	
	public virtual SuperExpr setTypeName(Name typeName)
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

	
	
	public virtual SuperExpr removeTypeName()
	{
		SuperExpr result = setTypeName(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual SuperExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EsuperExprMetaModel;
	}

	
	
	public new virtual SuperExpr clone()
	{
		return (SuperExpr)accept(new CloneVisitor(), null);
	}

	
	
	public SuperExpr()
		: this(null, null)
	{
	}

	
	
	
	
	public SuperExpr(Name typeName)
		: this(null, typeName)
	{
	}

	
		
	
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

	public override bool isSuperExpr()
	{
		return true;
	}

	public override SuperExpr asSuperExpr()
	{
		return this;
	}

	
		
	
	public override void ifSuperExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toSuperExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public virtual SuperExpr removeClassName()
	{
		SuperExpr result = setTypeName(null);
		
		return result;
	}

	
	
	
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

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		SuperExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SuperExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SuperExpr result = clone();
		
		return result;
	}

	
	static SuperExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
