using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class EmptyStmt : Statement
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public EmptyStmt(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual EmptyStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EemptyStmtMetaModel;
	}

	
	
	public new virtual EmptyStmt clone()
	{
		return (EmptyStmt)accept(new CloneVisitor(), null);
	}

	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public EmptyStmt()
		: this(null)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isEmptyStmt()
	{
		return true;
	}

	public override EmptyStmt asEmptyStmt()
	{
		return this;
	}

	
		
	
	public override void ifEmptyStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toEmptyStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		EmptyStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		EmptyStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		EmptyStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		EmptyStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		EmptyStmt result = clone();
		
		return result;
	}

	
	static EmptyStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
