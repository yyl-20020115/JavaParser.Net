using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class Name : Node, NodeWithIdentifier
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isInternal_00240((Node)P_0);
			
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

	[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private string identifier;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Name qualifier;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public Name(string identifier)
		: this(null, null, identifier)
	{
	}

	
	
	public virtual string asString()
	{
		if (qualifier != null)
		{
			string result = new StringBuilder().append(qualifier.asString()).append(".").append(identifier)
				.ToString();
			
			return result;
		}
		return identifier;
	}

	public virtual string getIdentifier()
	{
		return identifier;
	}

	
	
	public Name()
		: this(null, null, "empty")
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public Name(Name qualifier, string identifier)
		: this(null, qualifier, identifier)
	{
	}

	
		
	public virtual Optional getQualifier()
	{
		Optional result = Optional.ofNullable(qualifier);
		
		return result;
	}

	
	
	
	public Name(TokenRange tokenRange, Name qualifier, string identifier)
		: base(tokenRange)
	{
		setQualifier(qualifier);
		setIdentifier(identifier);
		customInitialization();
	}

	
	
	
	public virtual Name setQualifier(Name qualifier)
	{
		if (qualifier == this.qualifier)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EQUALIFIER, this.qualifier, qualifier);
		if (this.qualifier != null)
		{
			this.qualifier.setParentNode(null);
		}
		this.qualifier = qualifier;
		setAsParentNodeOf(qualifier);
		return this;
	}

	
	
	
	public virtual Name setIdentifier(string identifier)
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

	
	
	public virtual Name removeQualifier()
	{
		Name result = setQualifier(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public virtual bool isInternal()
	{
		bool result = getParentNode().filter(new ___003C_003EAnon0()).isPresent();
		
		return result;
	}

	
	
	public new virtual NameMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EnameMetaModel;
	}

	
	
	public new virtual Name clone()
	{
		return (Name)accept(new CloneVisitor(), null);
	}

	
	
	
	private static bool lambda_0024isInternal_00240(Node parent)
	{
		return parent is Name;
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (qualifier != null && node == qualifier)
		{
			removeQualifier();
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
		if (qualifier != null && node == qualifier)
		{
			setQualifier((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	public virtual bool isTopLevel()
	{
		return (!isInternal()) ? true : false;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		NameMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Name result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Name result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetIdentifier(string identifier)
	{
		Name result = setIdentifier(identifier);
		
		return result;
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

	
	static Name()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithIdentifier.NodeWithIdentifier_003A_003AsetIdentifier(string P_0)
	{
		return _003Cbridge_003EsetIdentifier(P_0);
	}
}
