using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class AssertStmt : Statement
{
	private Expression check;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Expression message;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public AssertStmt(TokenRange tokenRange, Expression check, Expression message)
		: base(tokenRange)
	{
		setCheck(check);
		setMessage(message);
		customInitialization();
	}

	
	
	
	public virtual AssertStmt setCheck(Expression check)
	{
		Utils.assertNotNull(check);
		if (check == this.check)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECHECK, this.check, check);
		if (this.check != null)
		{
			this.check.setParentNode(null);
		}
		this.check = check;
		setAsParentNodeOf(check);
		return this;
	}

	
	
	
	public virtual AssertStmt setMessage(Expression message)
	{
		if (message == this.message)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMESSAGE, this.message, message);
		if (this.message != null)
		{
			this.message.setParentNode(null);
		}
		this.message = message;
		setAsParentNodeOf(message);
		return this;
	}

	
	
	public virtual AssertStmt removeMessage()
	{
		AssertStmt result = setMessage(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual AssertStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EassertStmtMetaModel;
	}

	
	
	public new virtual AssertStmt clone()
	{
		return (AssertStmt)accept(new CloneVisitor(), null);
	}

	
	
	public AssertStmt()
		: this(null, new BooleanLiteralExpr(), null)
	{
	}

	
	
	
	public AssertStmt(Expression check)
		: this(null, check, null)
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public AssertStmt(Expression check, Expression message)
		: this(null, check, message)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Expression getCheck()
	{
		return check;
	}

	
		
	public virtual Optional getMessage()
	{
		Optional result = Optional.ofNullable(message);
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (message != null && node == message)
		{
			removeMessage();
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
		if (node == check)
		{
			setCheck((Expression)replacementNode);
			return true;
		}
		if (message != null && node == message)
		{
			setMessage((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isAssertStmt()
	{
		return true;
	}

	public override AssertStmt asAssertStmt()
	{
		return this;
	}

	
		
	
	public override void ifAssertStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toAssertStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		AssertStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		AssertStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		AssertStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		AssertStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		AssertStmt result = clone();
		
		return result;
	}

	
	static AssertStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
