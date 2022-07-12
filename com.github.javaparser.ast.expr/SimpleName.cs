using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;


namespace com.github.javaparser.ast.expr;


public class SimpleName : Node, NodeWithIdentifier
{
	[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private string identifier;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public SimpleName(string identifier)
		: this(null, identifier)
	{
	}

	public virtual string getIdentifier()
	{
		return identifier;
	}

	
	
	public SimpleName()
		: this(null, "empty")
	{
	}

	
	
	
	public SimpleName(TokenRange tokenRange, string identifier)
		: base(tokenRange)
	{
		setIdentifier(identifier);
		customInitialization();
	}

	
	
	
	public virtual SimpleName setIdentifier(string identifier)
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

	
	
	public new virtual SimpleNameMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EsimpleNameMetaModel;
	}

	
	
	public new virtual SimpleName clone()
	{
		return (SimpleName)accept(new CloneVisitor(), null);
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual string asString()
	{
		return identifier;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SimpleNameMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		SimpleName result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SimpleName result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetIdentifier(string identifier)
	{
		SimpleName result = setIdentifier(identifier);
		
		return result;
	}


	public virtual string getId()
	{
		return NodeWithIdentifier._003Cdefault_003EgetId(this);
	}


	public virtual Node setId(string P_0)
	{
		return NodeWithIdentifier._003Cdefault_003EsetId(this, P_0);
	}

	
	static SimpleName()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithIdentifier.NodeWithIdentifier_003A_003AsetIdentifier(string P_0)
	{
		return _003Cbridge_003EsetIdentifier(P_0);
	}
}
