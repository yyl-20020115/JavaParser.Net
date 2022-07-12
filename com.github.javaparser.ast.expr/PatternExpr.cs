using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class PatternExpr : Expression, NodeWithSimpleName, NodeWithType
{
	private SimpleName name;

	private ReferenceType type;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	
	public PatternExpr(TokenRange tokenRange, ReferenceType type, SimpleName name)
		: base(tokenRange)
	{
		setType(type);
		setName(name);
		customInitialization();
	}

	
	
	
	public virtual PatternExpr setType(ReferenceType type)
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

	
	
	
	public virtual PatternExpr setName(SimpleName name)
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

	
	
	public new virtual PatternExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EpatternExprMetaModel;
	}

	
	
	public new virtual PatternExpr clone()
	{
		return (PatternExpr)accept(new CloneVisitor(), null);
	}

	public virtual ReferenceType getType()
	{
		return type;
	}

	
	
	public PatternExpr()
		: this(null, new ClassOrInterfaceType(), new SimpleName())
	{
	}

	
	
	
	
	public PatternExpr(ReferenceType type, SimpleName name)
		: this(null, type, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isPatternExpr()
	{
		return true;
	}

	public override PatternExpr asPatternExpr()
	{
		return this;
	}

	
		
	public override Optional toPatternExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifPatternExpr(Consumer action)
	{
		action.accept(this);
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
		if (node == type)
		{
			setType((ReferenceType)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		PatternExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		PatternExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		PatternExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		PatternExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		PatternExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		PatternExpr result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node setType(Type type)
	{
		PatternExpr result = setType((ReferenceType)type);
		
		return result;
	}

	
	
	
	
	public virtual Type _003Cbridge_003EgetType()
	{
		ReferenceType result = getType();
		
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

	
	static PatternExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Type NodeWithType.NodeWithType_003A_003AgetType()
	{
		return _003Cbridge_003EgetType();
	}
}
