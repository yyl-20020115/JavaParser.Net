using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class LabeledStmt : Statement
{
	private SimpleName label;

	private Statement statement;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public LabeledStmt(TokenRange tokenRange, SimpleName label, Statement statement)
		: base(tokenRange)
	{
		setLabel(label);
		setStatement(statement);
		customInitialization();
	}

	
	
	
	public virtual LabeledStmt setLabel(SimpleName label)
	{
		Utils.assertNotNull(label);
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

	
	
	
	public virtual LabeledStmt setStatement(Statement statement)
	{
		Utils.assertNotNull(statement);
		if (statement == this.statement)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESTATEMENT, this.statement, statement);
		if (this.statement != null)
		{
			this.statement.setParentNode(null);
		}
		this.statement = statement;
		setAsParentNodeOf(statement);
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

	
	
	public new virtual LabeledStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElabeledStmtMetaModel;
	}

	
	
	public new virtual LabeledStmt clone()
	{
		return (LabeledStmt)accept(new CloneVisitor(), null);
	}

	
	
	public LabeledStmt()
		: this(null, new SimpleName(), new ReturnStmt())
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public LabeledStmt(string label, Statement statement)
		: this(null, new SimpleName(label), statement)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LabeledStmt(SimpleName label, Statement statement)
		: this(null, label, statement)
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

	public virtual Statement getStatement()
	{
		return statement;
	}

	public virtual SimpleName getLabel()
	{
		return label;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == label)
		{
			setLabel((SimpleName)replacementNode);
			return true;
		}
		if (node == statement)
		{
			setStatement((Statement)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isLabeledStmt()
	{
		return true;
	}

	public override LabeledStmt asLabeledStmt()
	{
		return this;
	}

	
		
	
	public override void ifLabeledStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLabeledStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		LabeledStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		LabeledStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LabeledStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LabeledStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LabeledStmt result = clone();
		
		return result;
	}

	
	static LabeledStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
