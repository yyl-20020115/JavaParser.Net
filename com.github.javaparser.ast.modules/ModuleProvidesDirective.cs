using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.modules;


public class ModuleProvidesDirective : ModuleDirective, NodeWithName
{
	private Name name;

		private NodeList with;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ModuleProvidesDirective(TokenRange tokenRange, Name name, NodeList with)
		: base(tokenRange)
	{
		setName(name);
		setWith(with);
		customInitialization();
	}

	
	
	
	public virtual ModuleProvidesDirective setName(Name name)
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

	
		
	
	public virtual ModuleProvidesDirective setWith(NodeList with)
	{
		Utils.assertNotNull(with);
		if (with == this.with)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EWITH, this.with, with);
		if (this.with != null)
		{
			this.with.setParentNode(null);
		}
		this.with = with;
		setAsParentNodeOf(with);
		return this;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ModuleProvidesDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleProvidesDirectiveMetaModel;
	}

	
	
	public new virtual ModuleProvidesDirective clone()
	{
		return (ModuleProvidesDirective)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleProvidesDirective()
		: this(null, new Name(), new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ModuleProvidesDirective(Name name, NodeList with)
		: this(null, name, with)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
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
		for (int i = 0; i < with.size(); i++)
		{
			if (with.get(i) == node)
			{
				with.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	public override bool isModuleProvidesStmt()
	{
		return true;
	}

	public override ModuleProvidesDirective asModuleProvidesStmt()
	{
		return this;
	}

	
		
	
	public override void ifModuleProvidesStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toModuleProvidesStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public virtual Name getName()
	{
		return name;
	}

		public virtual NodeList getWith()
	{
		return with;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		116, 99, 130, 105, 109, 130, 112, 111, 115, 226,
		61, 230, 70
	})]
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
		for (int i = 0; i < with.size(); i++)
		{
			if (with.get(i) == node)
			{
				with.set(i, (Name)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isModuleProvidesDirective()
	{
		return true;
	}

	public override ModuleProvidesDirective asModuleProvidesDirective()
	{
		return this;
	}

	
		
	public override Optional toModuleProvidesDirective()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifModuleProvidesDirective(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual ModuleDirectiveMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleProvidesDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ModuleDirective _003Cbridge_003Eclone()
	{
		ModuleProvidesDirective result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleProvidesDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ModuleProvidesDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleProvidesDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleProvidesDirective result = setName(name);
		
		return result;
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

	
	static ModuleProvidesDirective()
	{
		ModuleDirective.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
