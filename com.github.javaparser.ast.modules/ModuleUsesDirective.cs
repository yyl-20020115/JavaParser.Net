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


public class ModuleUsesDirective : ModuleDirective, NodeWithName
{
	private Name name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ModuleUsesDirective(TokenRange tokenRange, Name name)
		: base(tokenRange)
	{
		setName(name);
		customInitialization();
	}

	
	
	
	public virtual ModuleUsesDirective setName(Name name)
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

	
	
	public new virtual ModuleUsesDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleUsesDirectiveMetaModel;
	}

	
	
	public new virtual ModuleUsesDirective clone()
	{
		return (ModuleUsesDirective)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleUsesDirective()
		: this(null, new Name())
	{
	}

	
	
	
	
	public ModuleUsesDirective(Name name)
		: this(null, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public virtual ModuleUsesDirective setType(Name name)
	{
		Utils.assertNotNull(name);
		if (name == this.name)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.name, name);
		if (this.name != null)
		{
			this.name.setParentNode(null);
		}
		this.name = name;
		setAsParentNodeOf(name);
		return this;
	}

	public override bool isModuleUsesStmt()
	{
		return true;
	}

	public override ModuleUsesDirective asModuleUsesStmt()
	{
		return this;
	}

	
		
	
	public override void ifModuleUsesStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toModuleUsesStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public virtual Name getName()
	{
		return name;
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

	public override bool isModuleUsesDirective()
	{
		return true;
	}

	public override ModuleUsesDirective asModuleUsesDirective()
	{
		return this;
	}

	
		
	public override Optional toModuleUsesDirective()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifModuleUsesDirective(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual ModuleDirectiveMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleUsesDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ModuleDirective _003Cbridge_003Eclone()
	{
		ModuleUsesDirective result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleUsesDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ModuleUsesDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleUsesDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleUsesDirective result = setName(name);
		
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

	
	static ModuleUsesDirective()
	{
		ModuleDirective.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
