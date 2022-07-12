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


public class MethodReferenceExpr : Expression, NodeWithTypeArguments, NodeWithIdentifier, Resolvable
{
	private Expression scope;

		[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private NodeList typeArguments;

	[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private string identifier;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public MethodReferenceExpr(TokenRange tokenRange, Expression scope, NodeList typeArguments, string identifier)
		: base(tokenRange)
	{
		setScope(scope);
		setTypeArguments(typeArguments);
		setIdentifier(identifier);
		customInitialization();
	}

	
	
	
	public virtual MethodReferenceExpr setScope(Expression scope)
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

	
		
	
	public virtual MethodReferenceExpr setTypeArguments(NodeList typeArguments)
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

	
	
	
	public virtual MethodReferenceExpr setIdentifier(string identifier)
	{
		Utils.assertNonEmpty(identifier);
		if ((object)identifier == this.identifier)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EIDENTIFIER, this.identifier, identifier);
		this.identifier = identifier;
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual MethodReferenceExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmethodReferenceExprMetaModel;
	}

	
	
	public new virtual MethodReferenceExpr clone()
	{
		return (MethodReferenceExpr)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedMethodDeclaration resolve()
	{
		return (ResolvedMethodDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedMethodDeclaration>.Value);
	}

	
	
	public MethodReferenceExpr()
		: this(null, new ClassExpr(), null, "empty")
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public MethodReferenceExpr(Expression scope, NodeList typeArguments, string identifier)
		: this(null, scope, typeArguments, identifier)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
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

	public virtual string getIdentifier()
	{
		return identifier;
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

	public override bool isMethodReferenceExpr()
	{
		return true;
	}

	public override MethodReferenceExpr asMethodReferenceExpr()
	{
		return this;
	}

	
		
	
	public override void ifMethodReferenceExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toMethodReferenceExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public override bool isPolyExpression()
	{
		return true;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodReferenceExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		MethodReferenceExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodReferenceExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		MethodReferenceExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		MethodReferenceExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		MethodReferenceExpr result = setTypeArguments(typeArguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetIdentifier(string identifier)
	{
		MethodReferenceExpr result = setIdentifier(identifier);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedMethodDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUsingDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EisUsingDiamondOperator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EsetDiamondOperator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node removeTypeArguments()
	{
		return NodeWithTypeArguments._003Cdefault_003EremoveTypeArguments(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setTypeArguments(Type[] P_0)
	{
		return NodeWithTypeArguments._003Cdefault_003EsetTypeArguments(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getId()
	{
		return NodeWithIdentifier._003Cdefault_003EgetId(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setId(string P_0)
	{
		return NodeWithIdentifier._003Cdefault_003EsetId(this, P_0);
	}

	
	static MethodReferenceExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}

	Node NodeWithIdentifier.NodeWithIdentifier_003A_003AsetIdentifier(string P_0)
	{
		return _003Cbridge_003EsetIdentifier(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
