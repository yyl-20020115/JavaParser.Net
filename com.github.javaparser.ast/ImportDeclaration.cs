using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;

namespace com.github.javaparser.ast;


public class ImportDeclaration : Node, NodeWithName
{
	private Name name;

	private bool m_isStatic;

	private bool m_isAsterisk;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	public virtual Name getName()
	{
		return name;
	}

	public virtual bool isAsterisk()
	{
		return this.m_isAsterisk;
	}

	
	
	
	public ImportDeclaration(TokenRange tokenRange, Name name, bool isStatic, bool isAsterisk)
		: base(tokenRange)
	{
		setName(name);
		setStatic(isStatic);
		setAsterisk(isAsterisk);
		customInitialization();
	}

	
	
	
	public virtual ImportDeclaration setName(Name name)
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

	
	
	
	public virtual ImportDeclaration setStatic(bool isStatic)
	{
		if (isStatic == this.m_isStatic)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESTATIC, Boolean.valueOf(this.m_isStatic), Boolean.valueOf(isStatic));
		this.m_isStatic = isStatic;
		return this;
	}

	
	
	
	public virtual ImportDeclaration setAsterisk(bool isAsterisk)
	{
		if (isAsterisk == this.m_isAsterisk)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EASTERISK, Boolean.valueOf(this.m_isAsterisk), Boolean.valueOf(isAsterisk));
		this.m_isAsterisk = isAsterisk;
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ImportDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EimportDeclarationMetaModel;
	}

	
	
	public new virtual ImportDeclaration clone()
	{
		return (ImportDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	private ImportDeclaration()
		: this(null, new Name(), isStatic: false, isAsterisk: false)
	{
	}

	
	
	
	public ImportDeclaration(string name, bool isStatic, bool isAsterisk)
		: this(null, StaticJavaParser.parseName(name), isStatic, isAsterisk)
	{
	}

	
	
	
	
	public ImportDeclaration(Name name, bool isStatic, bool isAsterisk)
		: this(null, name, isStatic, isAsterisk)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual bool isStatic()
	{
		return this.m_isStatic;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == name)
		{
			setName((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ImportDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		ImportDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ImportDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ImportDeclaration result = setName(name);
		
		return result;
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual string getNameAsString()
	{
		return NodeWithName._003Cdefault_003EgetNameAsString(this);
	}

	
	static ImportDeclaration()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
