using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;


namespace com.github.javaparser.ast.expr;


public class MemberValuePair : Node, NodeWithSimpleName
{
	private SimpleName name;

	private Expression value;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public MemberValuePair(TokenRange tokenRange, SimpleName name, Expression value)
		: base(tokenRange)
	{
		setName(name);
		setValue(value);
		customInitialization();
	}

	
	
	
	public virtual MemberValuePair setName(SimpleName name)
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

	
	
	
	public virtual MemberValuePair setValue(Expression value)
	{
		Utils.assertNotNull(value);
		if (value == this.value)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVALUE, this.value, value);
		if (this.value != null)
		{
			this.value.setParentNode(null);
		}
		this.value = value;
		setAsParentNodeOf(value);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual MemberValuePairMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmemberValuePairMetaModel;
	}

	
	
	public new virtual MemberValuePair clone()
	{
		return (MemberValuePair)accept(new CloneVisitor(), null);
	}

	
	
	public MemberValuePair()
		: this(null, new SimpleName(), new StringLiteralExpr())
	{
	}

	
	
	
	public MemberValuePair(string name, Expression value)
		: this(null, new SimpleName(name), value)
	{
	}

	
	
	
	
	public MemberValuePair(SimpleName name, Expression value)
		: this(null, name, value)
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

	public virtual Expression getValue()
	{
		return value;
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
		if (node == value)
		{
			setValue((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		MemberValuePairMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		MemberValuePair result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		MemberValuePair result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		MemberValuePair result = setName(name);
		
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

	
	static MemberValuePair()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
