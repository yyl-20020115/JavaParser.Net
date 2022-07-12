using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class UnparsableStmt : Statement
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public UnparsableStmt(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual UnparsableStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EunparsableStmtMetaModel;
	}

	
	
	public new virtual UnparsableStmt clone()
	{
		return (UnparsableStmt)accept(new CloneVisitor(), null);
	}

	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public UnparsableStmt()
		: this(null)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	public override Parsedness getParsed()
	{
		return Parsedness.___003C_003EUNPARSABLE;
	}

	public override bool isUnparsableStmt()
	{
		return true;
	}

	public override UnparsableStmt asUnparsableStmt()
	{
		return this;
	}

	
		
	
	public override void ifUnparsableStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toUnparsableStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnparsableStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		UnparsableStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnparsableStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		UnparsableStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		UnparsableStmt result = clone();
		
		return result;
	}

	
	static UnparsableStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
