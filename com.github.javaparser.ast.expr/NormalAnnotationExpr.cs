using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class NormalAnnotationExpr : AnnotationExpr
{
		private NodeList pairs;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public NormalAnnotationExpr(Name name, NodeList pairs)
		: this(null, name, pairs)
	{
	}

	
		
	
	public NormalAnnotationExpr(TokenRange tokenRange, Name name, NodeList pairs)
		: base(tokenRange, name)
	{
		setPairs(pairs);
		customInitialization();
	}

	
		
	
	public virtual NormalAnnotationExpr setPairs(NodeList pairs)
	{
		Utils.assertNotNull(pairs);
		if (pairs == this.pairs)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPAIRS, this.pairs, pairs);
		if (this.pairs != null)
		{
			this.pairs.setParentNode(null);
		}
		this.pairs = pairs;
		setAsParentNodeOf(pairs);
		return this;
	}

	
	
	
	public virtual NormalAnnotationExpr addPair(string key, Expression value)
	{
		MemberValuePair node = new MemberValuePair(key, value);
		getPairs().add(node);
		return this;
	}

		public virtual NodeList getPairs()
	{
		return pairs;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual NormalAnnotationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EnormalAnnotationExprMetaModel;
	}

	
	
	public new virtual NormalAnnotationExpr clone()
	{
		return (NormalAnnotationExpr)accept(new CloneVisitor(), null);
	}

	
	
	public NormalAnnotationExpr()
		: this(null, new Name(), new NodeList())
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public virtual NormalAnnotationExpr addPair(string key, string value)
	{
		NormalAnnotationExpr result = addPair(key, new NameExpr(value));
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < pairs.size(); i++)
		{
			if (pairs.get(i) == node)
			{
				pairs.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < pairs.size(); i++)
		{
			if (pairs.get(i) == node)
			{
				pairs.set(i, (MemberValuePair)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isNormalAnnotationExpr()
	{
		return true;
	}

	public override NormalAnnotationExpr asNormalAnnotationExpr()
	{
		return this;
	}

	
		
	
	public override void ifNormalAnnotationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toNormalAnnotationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual AnnotationExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		NormalAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual AnnotationExpr _003Cbridge_003Eclone()
	{
		NormalAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		NormalAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		NormalAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		NormalAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		NormalAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		NormalAnnotationExpr result = clone();
		
		return result;
	}

	
	static NormalAnnotationExpr()
	{
		AnnotationExpr.___003Cclinit_003E();
	}
}
