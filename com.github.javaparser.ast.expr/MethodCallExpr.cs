using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class MethodCallExpr : Expression, NodeWithTypeArguments, NodeWithArguments, NodeWithSimpleName, NodeWithOptionalScope, NodeWithTraversableScope, Resolvable
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly ResolvedType arg_00241;

		internal ___003C_003EAnon0(ResolvedType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024hasParameterwithSameTypeThanResultType_00240(arg_00241, (Type)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private Expression scope;

		
	private NodeList typeArguments;

	private SimpleName name;

		private NodeList arguments;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public MethodCallExpr(TokenRange tokenRange, Expression scope, NodeList typeArguments, SimpleName name, NodeList arguments)
		: base(tokenRange)
	{
		setScope(scope);
		setTypeArguments(typeArguments);
		setName(name);
		setArguments(arguments);
		customInitialization();
	}

	
	
	
	public virtual MethodCallExpr setScope(Expression scope)
	{
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

	
		
	
	public virtual MethodCallExpr setTypeArguments(NodeList typeArguments)
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

	
	
	
	public virtual MethodCallExpr setName(SimpleName name)
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

	
		
	
	public virtual MethodCallExpr setArguments(NodeList arguments)
	{
		Utils.assertNotNull(arguments);
		if (arguments == this.arguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EARGUMENTS, this.arguments, arguments);
		if (this.arguments != null)
		{
			this.arguments.setParentNode(null);
		}
		this.arguments = arguments;
		setAsParentNodeOf(arguments);
		return this;
	}

	
	
	public virtual MethodCallExpr removeScope()
	{
		MethodCallExpr result = setScope(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	private bool isGenericMethod()
	{
		return (getTypeArguments().isPresent() && !((NodeList)getTypeArguments().get()).isEmpty()) ? true : false;
	}

	
	
	public virtual ResolvedMethodDeclaration resolve()
	{
		return (ResolvedMethodDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedMethodDeclaration>.Value);
	}

	
	
	
	private bool hasParameterwithSameTypeThanResultType(ResolvedType resolvedReturnType)
	{
		return (getTypeArguments().isPresent() && ((NodeList)getTypeArguments().get()).stream().anyMatch(new ___003C_003EAnon0(resolvedReturnType))) ? true : false;
	}

	
		
	public virtual Optional getTypeArguments()
	{
		Optional result = Optional.ofNullable(typeArguments);
		
		return result;
	}

	
	
	public new virtual MethodCallExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmethodCallExprMetaModel;
	}

	
	
	public new virtual MethodCallExpr clone()
	{
		return (MethodCallExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	
	private static bool lambda_0024hasParameterwithSameTypeThanResultType_00240(ResolvedType resolvedReturnType, Type argType)
	{
		bool result = argType.resolve().isAssignableBy(resolvedReturnType);
		
		return result;
	}

	
	
	public MethodCallExpr()
		: this(null, null, null, new SimpleName(), new NodeList())
	{
	}

	
	
	
	public MethodCallExpr(string name, params Expression[] arguments)
		: this(null, null, null, new SimpleName(name), new NodeList(arguments))
	{
	}

	
	
	
	public MethodCallExpr(Expression scope, string name)
		: this(null, scope, null, new SimpleName(name), new NodeList())
	{
	}

	
	
	
	public MethodCallExpr(Expression scope, SimpleName name)
		: this(null, scope, null, name, new NodeList())
	{
	}

	
		
	
	public MethodCallExpr(Expression scope, string name, NodeList arguments)
		: this(null, scope, null, new SimpleName(name), arguments)
	{
	}

	
		
	
	public MethodCallExpr(Expression scope, NodeList typeArguments, string name, NodeList arguments)
		: this(null, scope, typeArguments, new SimpleName(name), arguments)
	{
	}

	
		
	
	public MethodCallExpr(Expression scope, SimpleName name, NodeList arguments)
		: this(null, scope, null, name, arguments)
	{
	}

	
		
	
	
	public MethodCallExpr(Expression scope, NodeList typeArguments, SimpleName name, NodeList arguments)
		: this(null, scope, typeArguments, name, arguments)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getArguments()
	{
		return arguments;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
		
	public virtual Optional getScope()
	{
		Optional result = Optional.ofNullable(scope);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.remove(i);
				return true;
			}
		}
		if (scope != null && node == scope)
		{
			removeScope();
			return true;
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
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.set(i, (Expression)replacementNode);
				return true;
			}
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		if (scope != null && node == scope)
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

	public override bool isMethodCallExpr()
	{
		return true;
	}

	public override MethodCallExpr asMethodCallExpr()
	{
		return this;
	}

	
		
	
	public override void ifMethodCallExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toMethodCallExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public override bool isPolyExpression()
	{
		if (!appearsInAssignmentContext() && !appearsInInvocationContext())
		{
			return false;
		}
		if (isQualified() && !elidesTypeArguments())
		{
			return false;
		}
		if (isGenericMethod() && hasParameterwithSameTypeThanResultType(resolve().getReturnType()))
		{
			return true;
		}
		return false;
	}

	protected internal override bool isInvocationContext()
	{
		return true;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodCallExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		MethodCallExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodCallExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		MethodCallExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		MethodCallExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		MethodCallExpr result = setTypeArguments(typeArguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetArguments(NodeList arguments)
	{
		MethodCallExpr result = setArguments(arguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		MethodCallExpr result = setName(name);
		
		return result;
	}

	
	
	
	
	public virtual Node _003Cbridge_003EremoveScope()
	{
		MethodCallExpr result = removeScope();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetScope(Expression scope)
	{
		MethodCallExpr result = setScope(scope);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedMethodDeclaration result = resolve();
		
		return result;
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


	public virtual Expression getArgument(int P_0)
	{
		return NodeWithArguments._003Cdefault_003EgetArgument(this, P_0);
	}


	public virtual Node addArgument(string P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}


	public virtual Node addArgument(Expression P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}


	public virtual Node setArgument(int P_0, Expression P_1)
	{
		return NodeWithArguments._003Cdefault_003EsetArgument(this, P_0, P_1);
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


	public virtual Optional traverseScope()
	{
		return NodeWithOptionalScope._003Cdefault_003EtraverseScope(this);
	}

	
	static MethodCallExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}

	Node NodeWithArguments.NodeWithArguments_003A_003AsetArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetArguments(P_0);
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithOptionalScope.NodeWithOptionalScope_003A_003AsetScope(Expression P_0)
	{
		return _003Cbridge_003EsetScope(P_0);
	}

	Node NodeWithOptionalScope.NodeWithOptionalScope_003A_003AremoveScope()
	{
		return _003Cbridge_003EremoveScope();
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
