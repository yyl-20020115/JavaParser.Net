using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class SingleMemberAnnotationExpr : AnnotationExpr
{
	private Expression memberValue;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public SingleMemberAnnotationExpr(Name name, Expression memberValue)
		: this(null, name, memberValue)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public SingleMemberAnnotationExpr(TokenRange tokenRange, Name name, Expression memberValue)
		: base(tokenRange, name)
	{
		setMemberValue(memberValue);
		customInitialization();
	}

	
	
	
	public virtual SingleMemberAnnotationExpr setMemberValue(Expression memberValue)
	{
		Utils.assertNotNull(memberValue);
		if (memberValue == this.memberValue)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMEMBER_VALUE, this.memberValue, memberValue);
		if (this.memberValue != null)
		{
			this.memberValue.setParentNode(null);
		}
		this.memberValue = memberValue;
		setAsParentNodeOf(memberValue);
		return this;
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

	
	
	public new virtual SingleMemberAnnotationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EsingleMemberAnnotationExprMetaModel;
	}

	
	
	public new virtual SingleMemberAnnotationExpr clone()
	{
		return (SingleMemberAnnotationExpr)accept(new CloneVisitor(), null);
	}

	
	
	public SingleMemberAnnotationExpr()
		: this(null, new Name(), new StringLiteralExpr())
	{
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

	public virtual Expression getMemberValue()
	{
		return memberValue;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == memberValue)
		{
			setMemberValue((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isSingleMemberAnnotationExpr()
	{
		return true;
	}

	public override SingleMemberAnnotationExpr asSingleMemberAnnotationExpr()
	{
		return this;
	}

	
		
	
	public override void ifSingleMemberAnnotationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toSingleMemberAnnotationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual AnnotationExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		SingleMemberAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual AnnotationExpr _003Cbridge_003Eclone()
	{
		SingleMemberAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		SingleMemberAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		SingleMemberAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SingleMemberAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		SingleMemberAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SingleMemberAnnotationExpr result = clone();
		
		return result;
	}

	
	static SingleMemberAnnotationExpr()
	{
		AnnotationExpr.___003Cclinit_003E();
	}
}
