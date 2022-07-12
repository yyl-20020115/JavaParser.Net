using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class SwitchStmt : Statement, SwitchNode
{
	private Expression selector;

		private NodeList entries;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

		public virtual NodeList getEntries()
	{
		return entries;
	}

	
		
	
	public SwitchStmt(TokenRange tokenRange, Expression selector, NodeList entries)
		: base(tokenRange)
	{
		setSelector(selector);
		setEntries(entries);
		customInitialization();
	}

	
	
	
	public virtual SwitchStmt setSelector(Expression selector)
	{
		Utils.assertNotNull(selector);
		if (selector == this.selector)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESELECTOR, this.selector, selector);
		if (this.selector != null)
		{
			this.selector.setParentNode(null);
		}
		this.selector = selector;
		setAsParentNodeOf(selector);
		return this;
	}

	
		
	
	public virtual SwitchStmt setEntries(NodeList entries)
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

	
	
	public new virtual SwitchStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EswitchStmtMetaModel;
	}

	
	
	public new virtual SwitchStmt clone()
	{
		return (SwitchStmt)accept(new CloneVisitor(), null);
	}

	
	
	public SwitchStmt()
		: this(null, new NameExpr(), new NodeList())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public SwitchStmt(Expression selector, NodeList entries)
		: this(null, selector, entries)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public virtual SwitchEntry getEntry(int i)
	{
		return (SwitchEntry)getEntries().get(i);
	}

	public virtual Expression getSelector()
	{
		return selector;
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
				entries.set(i, (SwitchEntry)replacementNode);
				return true;
			}
		}
		if (node == selector)
		{
			setSelector((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isSwitchStmt()
	{
		return true;
	}

	public override SwitchStmt asSwitchStmt()
	{
		return this;
	}

	
		
	
	public override void ifSwitchStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toSwitchStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		SwitchStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		SwitchStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SwitchStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		SwitchStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SwitchStmt result = clone();
		
		return result;
	}

	
	
	
	
	public new virtual SwitchNode _003Cbridge_003Eclone()
	{
		SwitchStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual SwitchNode _003Cbridge_003EsetSelector(Expression selector)
	{
		SwitchStmt result = setSelector(selector);
		
		return result;
	}

	
	
	
	
	
	public virtual SwitchNode _003Cbridge_003EsetEntries(NodeList entries)
	{
		SwitchStmt result = setEntries(entries);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isEmpty()
	{
		return SwitchNode._003Cdefault_003EisEmpty(this);
	}

	
	static SwitchStmt()
	{
		Statement.___003Cclinit_003E();
	}

	SwitchNode SwitchNode.SwitchNode_003A_003AsetEntries(NodeList P_0)
	{
		return _003Cbridge_003EsetEntries(P_0);
	}

	SwitchNode SwitchNode.SwitchNode_003A_003AsetSelector(Expression P_0)
	{
		return _003Cbridge_003EsetSelector(P_0);
	}

	SwitchNode SwitchNode.SwitchNode_003A_003Aclone()
	{
		return this._003Cbridge_003Eclone();
	}
}
