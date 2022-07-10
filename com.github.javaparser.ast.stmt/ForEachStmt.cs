using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;


public class ForEachStmt : Statement, NodeWithBody
{
	private VariableDeclarationExpr variable;

	private Expression iterable;

	private Statement body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ForEachStmt(TokenRange tokenRange, VariableDeclarationExpr variable, Expression iterable, Statement body)
		: base(tokenRange)
	{
		setVariable(variable);
		setIterable(iterable);
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual ForEachStmt setVariable(VariableDeclarationExpr variable)
	{
		Utils.assertNotNull(variable);
		if (variable == this.variable)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVARIABLE, this.variable, variable);
		if (this.variable != null)
		{
			this.variable.setParentNode(null);
		}
		this.variable = variable;
		setAsParentNodeOf(variable);
		return this;
	}

	
	
	
	public virtual ForEachStmt setIterable(Expression iterable)
	{
		Utils.assertNotNull(iterable);
		if (iterable == this.iterable)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EITERABLE, this.iterable, iterable);
		if (this.iterable != null)
		{
			this.iterable.setParentNode(null);
		}
		this.iterable = iterable;
		setAsParentNodeOf(iterable);
		return this;
	}

	
	
	
	public virtual ForEachStmt setBody(Statement body)
	{
		Utils.assertNotNull(body);
		if (body == this.body)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EBODY, this.body, body);
		if (this.body != null)
		{
			this.body.setParentNode(null);
		}
		this.body = body;
		setAsParentNodeOf(body);
		return this;
	}

	public virtual VariableDeclarationExpr getVariable()
	{
		return variable;
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

	
	
	public new virtual ForEachStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EforEachStmtMetaModel;
	}

	
	
	public new virtual ForEachStmt clone()
	{
		return (ForEachStmt)accept(new CloneVisitor(), null);
	}

	
	
	public ForEachStmt()
		: this(null, new VariableDeclarationExpr(), new NameExpr(), new ReturnStmt())
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ForEachStmt(VariableDeclarationExpr variable, Expression iterable, Statement body)
		: this(null, variable, iterable, body)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ForEachStmt(VariableDeclarationExpr variable, string iterable, BlockStmt body)
		: this(null, variable, new NameExpr(iterable), body)
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

	public virtual Statement getBody()
	{
		return body;
	}

	public virtual Expression getIterable()
	{
		return iterable;
	}

	
	
	public virtual VariableDeclarator getVariableDeclarator()
	{
		VariableDeclarator result = getVariable().getVariable(0);
		
		return result;
	}

	
	
	public virtual bool hasFinalVariable()
	{
		return (getVariable().getModifiers().isNonEmpty() && ((Modifier)getVariable().getModifiers().get(0)).getKeyword() == Modifier.Keyword.___003C_003EFINAL) ? true : false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 76, 99, 130, 105, 109, 130, 105, 109, 130,
		105, 109, 130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((Statement)replacementNode);
			return true;
		}
		if (node == iterable)
		{
			setIterable((Expression)replacementNode);
			return true;
		}
		if (node == variable)
		{
			setVariable((VariableDeclarationExpr)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isForEachStmt()
	{
		return true;
	}

	public override ForEachStmt asForEachStmt()
	{
		return this;
	}

	
		
	public override Optional toForEachStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifForEachStmt(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		ForEachStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		ForEachStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ForEachStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ForEachStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ForEachStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(Statement body)
	{
		ForEachStmt result = setBody(body);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBlockStatementAsBody()
	{
		return NodeWithBody._003Cdefault_003EcreateBlockStatementAsBody(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasEmptyBody()
	{
		return NodeWithBody._003Cdefault_003EhasEmptyBody(this);
	}

	
	static ForEachStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithBody.NodeWithBody_003A_003AsetBody(Statement P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}
}
