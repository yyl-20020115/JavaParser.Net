using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class LocalRecordDeclarationStmt : Statement
{
	private RecordDeclaration recordDeclaration;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public LocalRecordDeclarationStmt(TokenRange tokenRange, RecordDeclaration recordDeclaration)
		: base(tokenRange)
	{
		setRecordDeclaration(recordDeclaration);
		customInitialization();
	}

	
	
	
	public virtual LocalRecordDeclarationStmt setRecordDeclaration(RecordDeclaration recordDeclaration)
	{
		Utils.assertNotNull(recordDeclaration);
		if (recordDeclaration == this.recordDeclaration)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ERECORD_DECLARATION, this.recordDeclaration, recordDeclaration);
		if (this.recordDeclaration != null)
		{
			this.recordDeclaration.setParentNode(null);
		}
		this.recordDeclaration = recordDeclaration;
		setAsParentNodeOf(recordDeclaration);
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

	
	
	public new virtual LocalRecordDeclarationStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElocalRecordDeclarationStmtMetaModel;
	}

	
	
	public new virtual LocalRecordDeclarationStmt clone()
	{
		return (LocalRecordDeclarationStmt)accept(new CloneVisitor(), null);
	}

	
	
	public LocalRecordDeclarationStmt()
		: this(null, new RecordDeclaration())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LocalRecordDeclarationStmt(RecordDeclaration recordDeclaration)
		: this(null, recordDeclaration)
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

	public virtual RecordDeclaration getRecordDeclaration()
	{
		return recordDeclaration;
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
		if (node == recordDeclaration)
		{
			setRecordDeclaration((RecordDeclaration)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isLocalRecordDeclarationStmt()
	{
		return true;
	}

	public override LocalRecordDeclarationStmt asLocalRecordDeclarationStmt()
	{
		return this;
	}

	
		
	
	public override void ifLocalRecordDeclarationStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLocalRecordDeclarationStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		LocalRecordDeclarationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		LocalRecordDeclarationStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LocalRecordDeclarationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LocalRecordDeclarationStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LocalRecordDeclarationStmt result = clone();
		
		return result;
	}

	
	static LocalRecordDeclarationStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
