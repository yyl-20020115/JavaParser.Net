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


public class ModuleExportsDirective : ModuleDirective, NodeWithName
{
	private Name name;

		private NodeList moduleNames;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ModuleExportsDirective(TokenRange tokenRange, Name name, NodeList moduleNames)
		: base(tokenRange)
	{
		setName(name);
		setModuleNames(moduleNames);
		customInitialization();
	}

	
	
	
	public virtual ModuleExportsDirective setName(Name name)
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

	
		
	
	public virtual ModuleExportsDirective setModuleNames(NodeList moduleNames)
	{
		Utils.assertNotNull(moduleNames);
		if (moduleNames == this.moduleNames)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMODULE_NAMES, this.moduleNames, moduleNames);
		if (this.moduleNames != null)
		{
			this.moduleNames.setParentNode(null);
		}
		this.moduleNames = moduleNames;
		setAsParentNodeOf(moduleNames);
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

	
	
	public new virtual ModuleExportsDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleExportsDirectiveMetaModel;
	}

	
	
	public new virtual ModuleExportsDirective clone()
	{
		return (ModuleExportsDirective)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleExportsDirective()
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
	public ModuleExportsDirective(Name name, NodeList moduleNames)
		: this(null, name, moduleNames)
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
		for (int i = 0; i < moduleNames.size(); i++)
		{
			if (moduleNames.get(i) == node)
			{
				moduleNames.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	public virtual Name getName()
	{
		return name;
	}

		public virtual NodeList getModuleNames()
	{
		return moduleNames;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		94, 99, 130, 112, 111, 115, 226, 61, 230, 70,
		105, 109, 130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < moduleNames.size(); i++)
		{
			if (moduleNames.get(i) == node)
			{
				moduleNames.set(i, (Name)replacementNode);
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

	public override bool isModuleExportsStmt()
	{
		return true;
	}

	public override ModuleExportsDirective asModuleExportsStmt()
	{
		return this;
	}

	
		
	
	public override void ifModuleExportsStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toModuleExportsStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	public virtual ModuleExportsDirective addModuleName(string name)
	{
		moduleNames.add(StaticJavaParser.parseName(name));
		return this;
	}

	public override bool isModuleExportsDirective()
	{
		return true;
	}

	public override ModuleExportsDirective asModuleExportsDirective()
	{
		return this;
	}

	
		
	public override Optional toModuleExportsDirective()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifModuleExportsDirective(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual ModuleDirectiveMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleExportsDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ModuleDirective _003Cbridge_003Eclone()
	{
		ModuleExportsDirective result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleExportsDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ModuleExportsDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleExportsDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleExportsDirective result = setName(name);
		
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

	
	static ModuleExportsDirective()
	{
		ModuleDirective.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
