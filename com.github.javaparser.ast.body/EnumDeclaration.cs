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
using java.util.function;

namespace com.github.javaparser.ast.body;


public class EnumDeclaration : TypeDeclaration, NodeWithImplements, Resolvable
{
		private NodeList implementedTypes;

		private NodeList entries;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public virtual EnumConstantDeclaration addEnumConstant(string name)
	{
		Utils.assertNonEmpty(name);
		EnumConstantDeclaration enumConstantDeclaration = new EnumConstantDeclaration(name);
		getEntries().add(enumConstantDeclaration);
		return enumConstantDeclaration;
	}

		public virtual NodeList getEntries()
	{
		return entries;
	}

	
	
	
	public virtual EnumDeclaration addEntry(EnumConstantDeclaration element)
	{
		getEntries().add(element);
		return this;
	}

	
		
	
	public EnumDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, SimpleName name, NodeList implementedTypes, NodeList entries, NodeList members)
		: base(tokenRange, modifiers, annotations, name, members)
	{
		setImplementedTypes(implementedTypes);
		setEntries(entries);
		customInitialization();
	}

	
		
	
	public virtual EnumDeclaration setImplementedTypes(NodeList implementedTypes)
	{
		Utils.assertNotNull(implementedTypes);
		if (implementedTypes == this.implementedTypes)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EIMPLEMENTED_TYPES, this.implementedTypes, implementedTypes);
		if (this.implementedTypes != null)
		{
			this.implementedTypes.setParentNode(null);
		}
		this.implementedTypes = implementedTypes;
		setAsParentNodeOf(implementedTypes);
		return this;
	}

	
		
	
	public virtual EnumDeclaration setEntries(NodeList entries)
	{
		Utils.assertNotNull(entries);
		if (entries == this.entries)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EENTRIES, this.entries, entries);
		if (this.entries != null)
		{
			this.entries.setParentNode(null);
		}
		this.entries = entries;
		setAsParentNodeOf(entries);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ResolvedEnumDeclaration resolve()
	{
		return (ResolvedEnumDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedEnumDeclaration>.Value);
	}

	
	
	public new virtual EnumDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EenumDeclarationMetaModel;
	}

	
	
	public new virtual EnumDeclaration clone()
	{
		return (EnumDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public EnumDeclaration()
		: this(null, new NodeList(), new NodeList(), new SimpleName(), new NodeList(), new NodeList(), new NodeList())
	{
	}

	
		
	
	public EnumDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new SimpleName(name), new NodeList(), new NodeList(), new NodeList())
	{
	}

	
		
	
	
	public EnumDeclaration(NodeList modifiers, NodeList annotations, SimpleName name, NodeList implementedTypes, NodeList entries, NodeList members)
		: this(null, modifiers, annotations, name, implementedTypes, entries, members)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public virtual EnumConstantDeclaration getEntry(int i)
	{
		return (EnumConstantDeclaration)getEntries().get(i);
	}

	
	
	
	public virtual EnumDeclaration setEntry(int i, EnumConstantDeclaration element)
	{
		getEntries().set(i, element);
		return this;
	}

		public virtual NodeList getImplementedTypes()
	{
		return implementedTypes;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < entries.size(); i++)
		{
			if (entries.get(i) == node)
			{
				entries.remove(i);
				return true;
			}
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.remove(i);
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
		for (int i = 0; i < entries.size(); i++)
		{
			if (entries.get(i) == node)
			{
				entries.set(i, (EnumConstantDeclaration)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.set(i, (ClassOrInterfaceType)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isEnumDeclaration()
	{
		return true;
	}

	public override EnumDeclaration asEnumDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifEnumDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toEnumDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public virtual ResolvedReferenceTypeDeclaration _003Cbridge_003Eresolve()
	{
		ResolvedEnumDeclaration result = resolve();
		
		return result;
	}

	
	
	
	
	public new virtual TypeDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnumDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual TypeDeclaration _003Cbridge_003Eclone()
	{
		EnumDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnumDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		EnumDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnumDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		EnumDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		EnumDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetImplementedTypes(NodeList implementedTypes)
	{
		EnumDeclaration result = setImplementedTypes(implementedTypes);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedEnumDeclaration result = resolve();
		
		return result;
	}


	public virtual ClassOrInterfaceType getImplementedTypes(int P_0)
	{
		return NodeWithImplements._003Cdefault_003EgetImplementedTypes(this, P_0);
	}


	public virtual Node setImplementedType(int P_0, ClassOrInterfaceType P_1)
	{
		return NodeWithImplements._003Cdefault_003EsetImplementedType(this, P_0, P_1);
	}


	public virtual Node addImplementedType(ClassOrInterfaceType P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
	}


	public virtual Node addImplements(string P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplements(this, P_0);
	}


	public virtual Node addImplements(Class P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplements(this, P_0);
	}


	public virtual Node addImplementedType(string P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
	}


	public virtual Node addImplementedType(Class P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
	}

	
	static EnumDeclaration()
	{
		TypeDeclaration.___003Cclinit_003E();
	}

	Node NodeWithImplements.NodeWithImplements_003A_003AsetImplementedTypes(NodeList P_0)
	{
		return _003Cbridge_003EsetImplementedTypes(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return this._003Cbridge_003Eresolve();
	}
}
