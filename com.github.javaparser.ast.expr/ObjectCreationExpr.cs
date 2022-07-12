using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class ObjectCreationExpr : Expression, NodeWithTypeArguments, NodeWithType, NodeWithArguments, NodeWithOptionalScope, NodeWithTraversableScope, Resolvable
{
	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Expression scope;

	private ClassOrInterfaceType type;

		[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private NodeList typeArguments;

		private NodeList arguments;

		[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private NodeList anonymousClassBody;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ObjectCreationExpr(TokenRange tokenRange, Expression scope, ClassOrInterfaceType type, NodeList typeArguments, NodeList arguments, NodeList anonymousClassBody)
		: base(tokenRange)
	{
		setScope(scope);
		setType(type);
		setTypeArguments(typeArguments);
		setArguments(arguments);
		setAnonymousClassBody(anonymousClassBody);
		customInitialization();
	}

	
	
	
	public virtual ObjectCreationExpr setScope(Expression scope)
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

	
	
	
	public virtual ObjectCreationExpr setType(ClassOrInterfaceType type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		if (this.type != null)
		{
			this.type.setParentNode(null);
		}
		this.type = type;
		setAsParentNodeOf(type);
		return this;
	}

	
		
	
	public virtual ObjectCreationExpr setTypeArguments(NodeList typeArguments)
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

	
		
	
	public virtual ObjectCreationExpr setArguments(NodeList arguments)
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

	
		
	
	public virtual ObjectCreationExpr setAnonymousClassBody(NodeList anonymousClassBody)
	{
		if (anonymousClassBody == this.anonymousClassBody)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EANONYMOUS_CLASS_BODY, this.anonymousClassBody, anonymousClassBody);
		if (this.anonymousClassBody != null)
		{
			this.anonymousClassBody.setParentNode(null);
		}
		this.anonymousClassBody = anonymousClassBody;
		setAsParentNodeOf(anonymousClassBody);
		return this;
	}

	
	
	public virtual ObjectCreationExpr removeScope()
	{
		ObjectCreationExpr result = setScope(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUsingDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EisUsingDiamondOperator(this);
	}

	
	
	public new virtual ObjectCreationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EobjectCreationExprMetaModel;
	}

	
	
	public new virtual ObjectCreationExpr clone()
	{
		return (ObjectCreationExpr)accept(new CloneVisitor(), null);
	}

	public virtual ClassOrInterfaceType getType()
	{
		return type;
	}

	
	
	public virtual ResolvedConstructorDeclaration resolve()
	{
		return (ResolvedConstructorDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedConstructorDeclaration>.Value);
	}

	
	
	public ObjectCreationExpr()
		: this(null, null, new ClassOrInterfaceType(), new NodeList(), new NodeList(), null)
	{
	}

	
		
	
	public ObjectCreationExpr(Expression scope, ClassOrInterfaceType type, NodeList arguments)
		: this(null, scope, type, null, arguments, null)
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ObjectCreationExpr(Expression scope, ClassOrInterfaceType type, NodeList typeArguments, NodeList arguments, NodeList anonymousClassBody)
		: this(null, scope, type, typeArguments, arguments, anonymousClassBody)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	public virtual Optional getAnonymousClassBody()
	{
		Optional result = Optional.ofNullable(anonymousClassBody);
		
		return result;
	}

	
		
	
	public virtual void addAnonymousClassBody(BodyDeclaration body)
	{
		if (anonymousClassBody == null)
		{
			anonymousClassBody = new NodeList();
		}
		anonymousClassBody.add(body);
	}

		public virtual NodeList getArguments()
	{
		return arguments;
	}

	
		
	public virtual Optional getScope()
	{
		Optional result = Optional.ofNullable(scope);
		
		return result;
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
		if (anonymousClassBody != null)
		{
			for (int i = 0; i < anonymousClassBody.size(); i++)
			{
				if (anonymousClassBody.get(i) == node)
				{
					anonymousClassBody.remove(i);
					return true;
				}
			}
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
		if (anonymousClassBody != null)
		{
			for (int i = 0; i < anonymousClassBody.size(); i++)
			{
				if (anonymousClassBody.get(i) == node)
				{
					anonymousClassBody.set(i, (BodyDeclaration)replacementNode);
					return true;
				}
			}
		}
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.set(i, (Expression)replacementNode);
				return true;
			}
		}
		if (scope != null && node == scope)
		{
			setScope((Expression)replacementNode);
			return true;
		}
		if (node == type)
		{
			setType((ClassOrInterfaceType)replacementNode);
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

	public override bool isObjectCreationExpr()
	{
		return true;
	}

	public override ObjectCreationExpr asObjectCreationExpr()
	{
		return this;
	}

	
		
	
	public override void ifObjectCreationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toObjectCreationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public override bool isPolyExpression()
	{
		return (isUsingDiamondOperator() && (appearsInInvocationContext() || appearsInAssignmentContext())) ? true : false;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ObjectCreationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ObjectCreationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ObjectCreationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ObjectCreationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ObjectCreationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		ObjectCreationExpr result = setTypeArguments(typeArguments);
		
		return result;
	}

	
	
	
	
	
	public virtual Node setType(Type type)
	{
		ObjectCreationExpr result = setType((ClassOrInterfaceType)type);
		
		return result;
	}

	
	
	
	
	public virtual Type _003Cbridge_003EgetType()
	{
		ClassOrInterfaceType result = getType();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetArguments(NodeList arguments)
	{
		ObjectCreationExpr result = setArguments(arguments);
		
		return result;
	}

	
	
	
	
	public virtual Node _003Cbridge_003EremoveScope()
	{
		ObjectCreationExpr result = removeScope();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetScope(Expression scope)
	{
		ObjectCreationExpr result = setScope(scope);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedConstructorDeclaration result = resolve();
		
		return result;
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
	public virtual Node setType(Class P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setType(string P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getTypeAsString()
	{
		return NodeWithType._003Cdefault_003EgetTypeAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Expression getArgument(int P_0)
	{
		return NodeWithArguments._003Cdefault_003EgetArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(string P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(Expression P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setArgument(int P_0, Expression P_1)
	{
		return NodeWithArguments._003Cdefault_003EsetArgument(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional traverseScope()
	{
		return NodeWithOptionalScope._003Cdefault_003EtraverseScope(this);
	}

	
	static ObjectCreationExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}

	Type NodeWithType.NodeWithType_003A_003AgetType()
	{
		return _003Cbridge_003EgetType();
	}

	Node NodeWithArguments.NodeWithArguments_003A_003AsetArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetArguments(P_0);
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
