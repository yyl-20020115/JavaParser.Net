using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.modules;


public class ModuleRequiresDirective : ModuleDirective, NodeWithStaticModifier, NodeWithModifiers, NodeWithName
{
		private NodeList modifiers;

	private Name name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ModuleRequiresDirective(TokenRange tokenRange, NodeList modifiers, Name name)
		: base(tokenRange)
	{
		setModifiers(modifiers);
		setName(name);
		customInitialization();
	}

	
		
	
	public virtual ModuleRequiresDirective setModifiers(NodeList modifiers)
	{
		Utils.assertNotNull(modifiers);
		if (modifiers == this.modifiers)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMODIFIERS, this.modifiers, modifiers);
		if (this.modifiers != null)
		{
			this.modifiers.setParentNode(null);
		}
		this.modifiers = modifiers;
		setAsParentNodeOf(modifiers);
		return this;
	}

	
	
	
	public virtual ModuleRequiresDirective setName(Name name)
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ModuleRequiresDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleRequiresDirectiveMetaModel;
	}

	
	
	public new virtual ModuleRequiresDirective clone()
	{
		return (ModuleRequiresDirective)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleRequiresDirective()
		: this(null, new NodeList(), new Name())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ModuleRequiresDirective(NodeList modifiers, Name name)
		: this(null, modifiers, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

	public virtual Name getName()
	{
		return name;
	}

	
	
	public virtual bool isTransitive()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003ETRANSITIVE);
		
		return result;
	}

	
	
	
	public virtual ModuleRequiresDirective setTransitive(bool set)
	{
		return (ModuleRequiresDirective)setModifier(Modifier.Keyword.___003C_003ETRANSITIVE, set);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.remove(i);
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
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.set(i, (Modifier)replacementNode);
				return true;
			}
		}
		if (node == name)
		{
			setName((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isModuleRequiresStmt()
	{
		return true;
	}

	public override ModuleRequiresDirective asModuleRequiresStmt()
	{
		return this;
	}

	
		
	
	public override void ifModuleRequiresStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toModuleRequiresStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public override bool isModuleRequiresDirective()
	{
		return true;
	}

	public override ModuleRequiresDirective asModuleRequiresDirective()
	{
		return this;
	}

	
		
	public override Optional toModuleRequiresDirective()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifModuleRequiresDirective(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual ModuleDirectiveMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleRequiresDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ModuleDirective _003Cbridge_003Eclone()
	{
		ModuleRequiresDirective result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleRequiresDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ModuleRequiresDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleRequiresDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		ModuleRequiresDirective result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleRequiresDirective result = setName(name);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isStatic()
	{
		return NodeWithStaticModifier._003Cdefault_003EisStatic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setStatic(bool P_0)
	{
		return NodeWithStaticModifier._003Cdefault_003EsetStatic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setName(string P_0)
	{
		return NodeWithName._003Cdefault_003EsetName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getNameAsString()
	{
		return NodeWithName._003Cdefault_003EgetNameAsString(this);
	}

	
	static ModuleRequiresDirective()
	{
		ModuleDirective.___003Cclinit_003E();
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
