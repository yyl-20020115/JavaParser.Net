using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class ArrayCreationExpr : Expression
{
		[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private NodeList levels;

	private Type elementType;

	
	private ArrayInitializerExpr initializer;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ArrayCreationExpr(TokenRange tokenRange, Type elementType, NodeList levels, ArrayInitializerExpr initializer)
		: base(tokenRange)
	{
		setElementType(elementType);
		setLevels(levels);
		setInitializer(initializer);
		customInitialization();
	}

	
	
	
	public virtual ArrayCreationExpr setElementType(Type elementType)
	{
		Utils.assertNotNull(elementType);
		if (elementType == this.elementType)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EELEMENT_TYPE, this.elementType, elementType);
		if (this.elementType != null)
		{
			this.elementType.setParentNode(null);
		}
		this.elementType = elementType;
		setAsParentNodeOf(elementType);
		return this;
	}

	
		
	
	public virtual ArrayCreationExpr setLevels(NodeList levels)
	{
		Utils.assertNotNull(levels);
		if (levels == this.levels)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ELEVELS, this.levels, levels);
		if (this.levels != null)
		{
			this.levels.setParentNode(null);
		}
		this.levels = levels;
		if (this.levels.isEmpty())
		{
			this.levels = new NodeList(new ArrayCreationLevel());
		}
		setAsParentNodeOf(levels);
		return this;
	}

	
	
	
	public virtual ArrayCreationExpr setInitializer(ArrayInitializerExpr initializer)
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

	
	
	public virtual ArrayCreationExpr removeInitializer()
	{
		ArrayCreationExpr result = setInitializer(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ArrayCreationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EarrayCreationExprMetaModel;
	}

	
	
	public new virtual ArrayCreationExpr clone()
	{
		return (ArrayCreationExpr)accept(new CloneVisitor(), null);
	}

	
	
	public ArrayCreationExpr()
		: this(null, new ClassOrInterfaceType(), new NodeList(new ArrayCreationLevel()), new ArrayInitializerExpr())
	{
	}

	
		
	
	
	public ArrayCreationExpr(Type elementType, NodeList levels, ArrayInitializerExpr initializer)
		: this(null, elementType, levels, initializer)
	{
	}

	
	
	
	public ArrayCreationExpr(Type elementType)
		: this(null, elementType, new NodeList(new ArrayCreationLevel()), new ArrayInitializerExpr())
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	public virtual Optional getInitializer()
	{
		Optional result = Optional.ofNullable(initializer);
		
		return result;
	}

	public virtual Type getElementType()
	{
		return elementType;
	}

		public virtual NodeList getLevels()
	{
		return levels;
	}

	
	
	public virtual Type createdType()
	{
		Type type = elementType;
		for (int i = 0; i < levels.size(); i++)
		{
			ArrayType.___003Cclinit_003E();
			type = new ArrayType(type, ArrayType.Origin.___003C_003ETYPE, new NodeList());
		}
		return type;
	}

	
		
	
	public virtual ArrayCreationExpr setElementType(Class typeClass)
	{
		tryAddImportToParentCompilationUnit(typeClass);
		ArrayCreationExpr result = setElementType(StaticJavaParser.parseType(typeClass.getSimpleName()));
		
		return result;
	}

	
	
	
	public virtual ArrayCreationExpr setElementType(string type)
	{
		ArrayCreationExpr result = setElementType(StaticJavaParser.parseType(type));
		
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
		for (int i = 0; i < levels.size(); i++)
		{
			if (levels.get(i) == node)
			{
				levels.remove(i);
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
		if (node == elementType)
		{
			setElementType((Type)replacementNode);
			return true;
		}
		if (initializer != null && node == initializer)
		{
			setInitializer((ArrayInitializerExpr)replacementNode);
			return true;
		}
		for (int i = 0; i < levels.size(); i++)
		{
			if (levels.get(i) == node)
			{
				levels.set(i, (ArrayCreationLevel)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isArrayCreationExpr()
	{
		return true;
	}

	public override ArrayCreationExpr asArrayCreationExpr()
	{
		return this;
	}

	
		
	
	public override void ifArrayCreationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toArrayCreationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayCreationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		ArrayCreationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayCreationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ArrayCreationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ArrayCreationExpr result = clone();
		
		return result;
	}

	
	static ArrayCreationExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
