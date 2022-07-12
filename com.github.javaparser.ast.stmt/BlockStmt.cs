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


public class BlockStmt : Statement, NodeWithStatements
{
		private NodeList statements;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(string P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
	}

		public virtual NodeList getStatements()
	{
		return statements;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(Statement P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
	}

	
	
	public BlockStmt()
		: this(null, new NodeList())
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(Expression P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isEmpty()
	{
		return NodeWithStatements._003Cdefault_003EisEmpty(this);
	}

	
		
	
	public BlockStmt(TokenRange tokenRange, NodeList statements)
		: base(tokenRange)
	{
		setStatements(statements);
		customInitialization();
	}

	
		
	
	public virtual BlockStmt setStatements(NodeList statements)
	{
		Utils.assertNotNull(statements);
		if (statements == this.statements)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESTATEMENTS, this.statements, statements);
		if (this.statements != null)
		{
			this.statements.setParentNode(null);
		}
		this.statements = statements;
		setAsParentNodeOf(statements);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual BlockStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EblockStmtMetaModel;
	}

	
	
	public new virtual BlockStmt clone()
	{
		return (BlockStmt)accept(new CloneVisitor(), null);
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public BlockStmt(NodeList statements)
		: this(null, statements)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < statements.size(); i++)
		{
			if (statements.get(i) == node)
			{
				statements.remove(i);
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
		for (int i = 0; i < statements.size(); i++)
		{
			if (statements.get(i) == node)
			{
				statements.set(i, (Statement)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isBlockStmt()
	{
		return true;
	}

	public override BlockStmt asBlockStmt()
	{
		return this;
	}

	
		
	
	public override void ifBlockStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toBlockStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		BlockStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		BlockStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		BlockStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		BlockStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		BlockStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetStatements(NodeList statements)
	{
		BlockStmt result = setStatements(statements);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Statement getStatement(int P_0)
	{
		return NodeWithStatements._003Cdefault_003EgetStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setStatement(int P_0, Statement P_1)
	{
		return NodeWithStatements._003Cdefault_003EsetStatement(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(int P_0, Statement P_1)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(int P_0, Expression P_1)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Statement addAndGetStatement(Statement P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddAndGetStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Statement addAndGetStatement(int P_0, Statement P_1)
	{
		return NodeWithStatements._003Cdefault_003EaddAndGetStatement(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ExpressionStmt addAndGetStatement(Expression P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddAndGetStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ExpressionStmt addAndGetStatement(string P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddAndGetStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node copyStatements(NodeList P_0)
	{
		return NodeWithStatements._003Cdefault_003EcopyStatements(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node copyStatements(NodeWithStatements P_0)
	{
		return NodeWithStatements._003Cdefault_003EcopyStatements(this, P_0);
	}

	
	static BlockStmt()
	{
		Statement.___003Cclinit_003E();
	}

	Node NodeWithStatements.NodeWithStatements_003A_003AsetStatements(NodeList P_0)
	{
		return _003Cbridge_003EsetStatements(P_0);
	}
}
