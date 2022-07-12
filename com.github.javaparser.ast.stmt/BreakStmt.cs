using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class BreakStmt : Statement
{
	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private SimpleName label;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public BreakStmt(TokenRange tokenRange, SimpleName label)
		: base(tokenRange)
	{
		setLabel(label);
		customInitialization();
	}

	
	
	
	public virtual BreakStmt setLabel(SimpleName label)
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

	
	
	public virtual BreakStmt removeLabel()
	{
		BreakStmt result = setLabel(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual BreakStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EbreakStmtMetaModel;
	}

	
	
	public new virtual BreakStmt clone()
	{
		return (BreakStmt)accept(new CloneVisitor(), null);
	}

	
	
	public BreakStmt()
		: this(null, null)
	{
	}

	
	
	
	public BreakStmt(string label)
		: this(null, new SimpleName(label))
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public BreakStmt(SimpleName label)
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

	public override bool isBreakStmt()
	{
		return true;
	}

	public override BreakStmt asBreakStmt()
	{
		return this;
	}

	
		
	
	public override void ifBreakStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toBreakStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		BreakStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		BreakStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		BreakStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		BreakStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		BreakStmt result = clone();
		
		return result;
	}

	
	static BreakStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
