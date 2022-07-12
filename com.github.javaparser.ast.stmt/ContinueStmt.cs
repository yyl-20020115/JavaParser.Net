using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class ContinueStmt : Statement, NodeWithOptionalLabel
{
	
	private SimpleName label;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ContinueStmt(TokenRange tokenRange, SimpleName label)
		: base(tokenRange)
	{
		setLabel(label);
		customInitialization();
	}

	
	
	
	public virtual ContinueStmt setLabel(SimpleName label)
	{
		if (label == this.label)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ELABEL, this.label, label);
		if (this.label != null)
		{
			this.label.setParentNode(null);
		}
		this.label = label;
		setAsParentNodeOf(label);
		return this;
	}

	
	
	public virtual ContinueStmt removeLabel()
	{
		ContinueStmt result = setLabel((SimpleName)null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ContinueStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcontinueStmtMetaModel;
	}

	
	
	public new virtual ContinueStmt clone()
	{
		return (ContinueStmt)accept(new CloneVisitor(), null);
	}

	
	
	public ContinueStmt()
		: this(null, null)
	{
	}

	
	
	
	public ContinueStmt(string label)
		: this(null, new SimpleName(label))
	{
	}

	
	
	
	
	public ContinueStmt(SimpleName label)
		: this(null, label)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	public virtual Optional getLabel()
	{
		Optional result = Optional.ofNullable(label);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (label != null && node == label)
		{
			removeLabel();
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
		if (label != null && node == label)
		{
			setLabel((SimpleName)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isContinueStmt()
	{
		return true;
	}

	public override ContinueStmt asContinueStmt()
	{
		return this;
	}

	
		
	
	public override void ifContinueStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toContinueStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ContinueStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ContinueStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ContinueStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ContinueStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ContinueStmt result = clone();
		
		return result;
	}

	
	
	
	
	public virtual Node _003Cbridge_003EremoveLabel()
	{
		ContinueStmt result = removeLabel();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetLabel(SimpleName label)
	{
		ContinueStmt result = setLabel(label);
		
		return result;
	}


	public virtual Node setLabel(string P_0)
	{
		return NodeWithOptionalLabel._003Cdefault_003EsetLabel(this, P_0);
	}


	public virtual Optional getLabelAsString()
	{
		return NodeWithOptionalLabel._003Cdefault_003EgetLabelAsString(this);
	}

	
	static ContinueStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithOptionalLabel.NodeWithOptionalLabel_003A_003AsetLabel(SimpleName P_0)
	{
		return _003Cbridge_003EsetLabel(P_0);
	}

	Node NodeWithOptionalLabel.NodeWithOptionalLabel_003A_003AremoveLabel()
	{
		return _003Cbridge_003EremoveLabel();
	}
}
