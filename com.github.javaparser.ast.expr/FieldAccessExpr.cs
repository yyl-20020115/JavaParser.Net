using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class FieldAccessExpr : Expression, NodeWithSimpleName, NodeWithTypeArguments, NodeWithScope, NodeWithTraversableScope, Resolvable
{
	private Expression scope;

		
	private NodeList typeArguments;

	private SimpleName name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public FieldAccessExpr(TokenRange tokenRange, Expression scope, NodeList typeArguments, SimpleName name)
		: base(tokenRange)
	{
		setScope(scope);
		setTypeArguments(typeArguments);
		setName(name);
		customInitialization();
	}

	
	
	
	public virtual FieldAccessExpr setScope(Expression scope)
	{
		Utils.assertNotNull(scope);
		if (scope == this.scope)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESCOPE, this.scope, scope);
		if (this.scope != null)
		{
			this.scope.setParentNode(null);
		}
		this.scope = scope;
		setAsParentNodeOf(scope);
		return this;
	}

	
		
	
	public virtual FieldAccessExpr setTypeArguments(NodeList typeArguments)
	{
		if (typeArguments == this.typeArguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_ARGUMENTS, this.typeArguments, typeArguments);
		if (this.typeArguments != null)
		{
			this.typeArguments.setParentNode(null);
		}
		this.typeArguments = typeArguments;
		setAsParentNodeOf(typeArguments);
		return this;
	}

	
	
	
	public virtual FieldAccessExpr setName(SimpleName name)
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

	
	
	public virtual bool isInternal()
	{
		return (getParentNode().isPresent() && getParentNode().get() is FieldAccessExpr) ? true : false;
	}

	
	
	public new virtual FieldAccessExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EfieldAccessExprMetaModel;
	}

	
	
	public new virtual FieldAccessExpr clone()
	{
		return (FieldAccessExpr)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedValueDeclaration resolve()
	{
		return (ResolvedValueDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedValueDeclaration>.Value);
	}

	
	
	public FieldAccessExpr()
		: this(null, new ThisExpr(), null, new SimpleName())
	{
	}

	
	
	
	public FieldAccessExpr(Expression scope, string name)
		: this(null, scope, null, new SimpleName(name))
	{
	}

	
		
	
	
	public FieldAccessExpr(Expression scope, NodeList typeArguments, SimpleName name)
		: this(null, scope, typeArguments, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	public virtual Expression getScope()
	{
		return scope;
	}

	
		
	public virtual Optional getTypeArguments()
	{
		Optional result = Optional.ofNullable(typeArguments);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.remove(i);
					return true;
				}
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
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		if (node == scope)
		{
			setScope((Expression)replacementNode);
			return true;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.set(i, (Type)replacementNode);
					return true;
				}
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isFieldAccessExpr()
	{
		return true;
	}

	public override FieldAccessExpr asFieldAccessExpr()
	{
		return this;
	}

	
		
	
	public override void ifFieldAccessExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toFieldAccessExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public virtual bool isTopLevel()
	{
		return (!isInternal()) ? true : false;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		FieldAccessExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		FieldAccessExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		FieldAccessExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		FieldAccessExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		FieldAccessExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		FieldAccessExpr result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		FieldAccessExpr result = setTypeArguments(typeArguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetScope(Expression scope)
	{
		FieldAccessExpr result = setScope(scope);
		
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


	public virtual bool isUsingDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EisUsingDiamondOperator(this);
	}


	public virtual Node setDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EsetDiamondOperator(this);
	}


	public virtual Node removeTypeArguments()
	{
		return NodeWithTypeArguments._003Cdefault_003EremoveTypeArguments(this);
	}


	public virtual Node setTypeArguments(Type[] P_0)
	{
		return NodeWithTypeArguments._003Cdefault_003EsetTypeArguments(this, P_0);
	}


	public virtual Optional traverseScope()
	{
		return NodeWithScope._003Cdefault_003EtraverseScope(this);
	}

	
	static FieldAccessExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}

	Node NodeWithScope.NodeWithScope_003A_003AsetScope(Expression P_0)
	{
		return _003Cbridge_003EsetScope(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
