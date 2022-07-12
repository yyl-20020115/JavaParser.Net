using System.ComponentModel;

using com.github.javaparser.ast.expr;
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

namespace com.github.javaparser.ast.body;


public class VariableDeclarator : Node, NodeWithType, NodeWithSimpleName, Resolvable
{
	
	[EnclosingMethod(null, "customInitialization", "()V")]
	internal new class _1 : AstObserverAdapter
	{
		
		internal VariableDeclarator this_00240;

		
		
		
		internal _1(VariableDeclarator this_00240)
		{
			this.this_00240 = this_00240;
			
		}

		
		
		
		public override void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
		{
			if (property != ObservableProperty.___003C_003ETYPE)
			{
				return;
			}
			VariableDeclarator variableDeclarator = this_00240;
			if (!variableDeclarator.getParentNode().isPresent() || !(variableDeclarator.getParentNode().get() is NodeWithVariables))
			{
				return;
			}
			NodeWithVariables nodeWithVariables = (NodeWithVariables)variableDeclarator.getParentNode().get();
			Optional maximumCommonType = nodeWithVariables.getMaximumCommonType();
			LinkedList linkedList = new LinkedList();
			int num = nodeWithVariables.getVariables().indexOf(variableDeclarator);
			for (int i = 0; i < nodeWithVariables.getVariables().size(); i++)
			{
				if (i == num)
				{
					((List)linkedList).add((object)(Type)newValue);
				}
				else
				{
					((List)linkedList).add((object)nodeWithVariables.getVariable(i).getType());
				}
			}
			Optional optional = NodeWithVariables.calculateMaximumCommonType(linkedList);
			((Node)nodeWithVariables).notifyPropertyChange(ObservableProperty.___003C_003EMAXIMUM_COMMON_TYPE, maximumCommonType.orElse(null), optional.orElse(null));
		}
	}

	private SimpleName name;

	
	[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private Expression initializer;

	private Type type;

	
	
	public new static void ___003Cclinit_003E()
	{
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

	
		
	public virtual Optional getInitializer()
	{
		Optional result = Optional.ofNullable(initializer);
		
		return result;
	}

	
	
	
	public VariableDeclarator(Type type, string variableName)
		: this(null, type, new SimpleName(variableName), null)
	{
	}

	
	
	
	public virtual VariableDeclarator setInitializer(Expression initializer)
	{
		if (initializer == this.initializer)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EINITIALIZER, this.initializer, initializer);
		if (this.initializer != null)
		{
			this.initializer.setParentNode(null);
		}
		this.initializer = initializer;
		setAsParentNodeOf(initializer);
		return this;
	}

	public virtual Type getType()
	{
		return type;
	}

	
	
	
	public virtual VariableDeclarator setType(Type type)
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

	
	
	
	public VariableDeclarator(TokenRange tokenRange, Type type, SimpleName name, Expression initializer)
		: base(tokenRange)
	{
		setType(type);
		setName(name);
		setInitializer(initializer);
		customInitialization();
	}

	
	
	
	public virtual VariableDeclarator setName(SimpleName name)
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

	
	
	protected internal override void customInitialization()
	{
		register(new _1(this));
	}

	
	
	public virtual VariableDeclarator removeInitializer()
	{
		VariableDeclarator result = setInitializer((Expression)null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual VariableDeclaratorMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EvariableDeclaratorMetaModel;
	}

	
	
	public new virtual VariableDeclarator clone()
	{
		return (VariableDeclarator)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedValueDeclaration resolve()
	{
		return (ResolvedValueDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedValueDeclaration>.Value);
	}

	
	
	public VariableDeclarator()
		: this(null, new ClassOrInterfaceType(), new SimpleName(), null)
	{
	}

	
	
	
	public VariableDeclarator(Type type, SimpleName name)
		: this(null, type, name, null)
	{
	}

	
	
	
	public VariableDeclarator(Type type, string variableName, Expression initializer)
		: this(null, type, new SimpleName(variableName), initializer)
	{
	}

	
	
	
	
	public VariableDeclarator(Type type, SimpleName name, Expression initializer)
		: this(null, type, name, initializer)
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

	
	
	
	public virtual VariableDeclarator setInitializer(string init)
	{
		NameExpr.___003Cclinit_003E();
		VariableDeclarator result = setInitializer(new NameExpr(Utils.assertNonEmpty(init)));
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (initializer != null && node == initializer)
		{
			removeInitializer();
			return true;
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
		if (initializer != null && node == initializer)
		{
			setInitializer((Expression)replacementNode);
			return true;
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		if (node == type)
		{
			setType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		VariableDeclaratorMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		VariableDeclarator result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		VariableDeclarator result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		VariableDeclarator result = setType(type);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		VariableDeclarator result = setName(name);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedValueDeclaration result = resolve();
		
		return result;
	}


	public virtual Node setType(Class P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}


	public virtual Node setType(string P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}


	public virtual string getTypeAsString()
	{
		return NodeWithType._003Cdefault_003EgetTypeAsString(this);
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}

	
	static VariableDeclarator()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
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
