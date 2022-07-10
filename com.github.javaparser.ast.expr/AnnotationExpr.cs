using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public abstract class AnnotationExpr : Expression, NodeWithName, Resolvable
{
	protected internal Name name;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getNameAsString()
	{
		return NodeWithName._003Cdefault_003EgetNameAsString(this);
	}

	public virtual Name getName()
	{
		return name;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public AnnotationExpr(TokenRange tokenRange, Name name)
		: base(tokenRange)
	{
		setName(name);
		customInitialization();
	}

	
	
	
	public virtual AnnotationExpr setName(Name name)
	{
		Utils.assertNotNull(name);
		if (name == this.name)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ENAME, this.name, name);
		if (this.name != null)
		{
			this.name.setParentNode(null);
		}
		this.name = name;
		setAsParentNodeOf(name);
		return this;
	}

	
	
	public new virtual AnnotationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EannotationExprMetaModel;
	}

	
	
	public new virtual AnnotationExpr clone()
	{
		return (AnnotationExpr)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedAnnotationDeclaration resolve()
	{
		return (ResolvedAnnotationDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedAnnotationDeclaration>.Value);
	}

	
	
	public AnnotationExpr()
		: this(null, new Name())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public AnnotationExpr(Name name)
		: this(null, name)
	{
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
		if (node == name)
		{
			setName((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isAnnotationExpr()
	{
		return true;
	}

	public override AnnotationExpr asAnnotationExpr()
	{
		return this;
	}

	
		
	
	public override void ifAnnotationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toAnnotationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		AnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		AnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		AnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		AnnotationExpr result = setName(name);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedAnnotationDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setName(string P_0)
	{
		return NodeWithName._003Cdefault_003EsetName(this, P_0);
	}

	
	static AnnotationExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
