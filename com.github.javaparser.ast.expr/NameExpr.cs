using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class NameExpr : Expression, NodeWithSimpleName, Resolvable
{
	private SimpleName name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public NameExpr(SimpleName name)
		: this((TokenRange)name.getTokenRange().orElse(null), name)
	{
		setRange((Range)name.getRange().orElse(null));
	}

	
	
	
	public NameExpr(string name)
		: this(null, new SimpleName(name))
	{
	}

	
	
	public NameExpr()
		: this(null, new SimpleName())
	{
	}

	
	
	
	public NameExpr(TokenRange tokenRange, SimpleName name)
		: base(tokenRange)
	{
		setName(name);
		customInitialization();
	}

	
	
	
	public virtual NameExpr setName(SimpleName name)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual NameExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EnameExprMetaModel;
	}

	
	
	public new virtual NameExpr clone()
	{
		return (NameExpr)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedValueDeclaration resolve()
	{
		return (ResolvedValueDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedValueDeclaration>.Value);
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isNameExpr()
	{
		return true;
	}

	public override NameExpr asNameExpr()
	{
		return this;
	}

	
		
	
	public override void ifNameExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toNameExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		NameExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		NameExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		NameExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		NameExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		NameExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		NameExpr result = setName(name);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedValueDeclaration result = resolve();
		
		return result;
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}

	
	static NameExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
