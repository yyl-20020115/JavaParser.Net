using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.modules;


public class ModuleOpensDirective : ModuleDirective, NodeWithName
{
	private Name name;

		private NodeList moduleNames;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ModuleOpensDirective(TokenRange tokenRange, Name name, NodeList moduleNames)
		: base(tokenRange)
	{
		setName(name);
		setModuleNames(moduleNames);
		customInitialization();
	}

	
	
	
	public virtual ModuleOpensDirective setName(Name name)
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

	
		
	
	public virtual ModuleOpensDirective setModuleNames(NodeList moduleNames)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ModuleOpensDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleOpensDirectiveMetaModel;
	}

	
	
	public new virtual ModuleOpensDirective clone()
	{
		return (ModuleOpensDirective)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleOpensDirective()
		: this(null, new Name(), new NodeList())
	{
	}

	
		
	
	
	public ModuleOpensDirective(Name name, NodeList moduleNames)
		: this(null, name, moduleNames)
	{
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

	public override bool isModuleOpensStmt()
	{
		return true;
	}

	public override ModuleOpensDirective asModuleOpensStmt()
	{
		return this;
	}

	
		
	
	public override void ifModuleOpensStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toModuleOpensStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public override bool isModuleOpensDirective()
	{
		return true;
	}

	public override ModuleOpensDirective asModuleOpensDirective()
	{
		return this;
	}

	
		
	public override Optional toModuleOpensDirective()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifModuleOpensDirective(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual ModuleDirectiveMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleOpensDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ModuleDirective _003Cbridge_003Eclone()
	{
		ModuleOpensDirective result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleOpensDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ModuleOpensDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleOpensDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleOpensDirective result = setName(name);
		
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

	
	static ModuleOpensDirective()
	{
		ModuleDirective.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
