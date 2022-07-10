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

public class TryStmt : Statement
{
		private NodeList resources;

	private BlockStmt tryBlock;

		private NodeList catchClauses;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private BlockStmt finallyBlock;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public TryStmt(TokenRange tokenRange, NodeList resources, BlockStmt tryBlock, NodeList catchClauses, BlockStmt finallyBlock)
		: base(tokenRange)
	{
		setResources(resources);
		setTryBlock(tryBlock);
		setCatchClauses(catchClauses);
		setFinallyBlock(finallyBlock);
		customInitialization();
	}

	
		
	
	public virtual TryStmt setResources(NodeList resources)
	{
		Utils.assertNotNull(resources);
		if (resources == this.resources)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ERESOURCES, this.resources, resources);
		if (this.resources != null)
		{
			this.resources.setParentNode(null);
		}
		this.resources = resources;
		setAsParentNodeOf(resources);
		return this;
	}

	
	
	
	public virtual TryStmt setTryBlock(BlockStmt tryBlock)
	{
		Utils.assertNotNull(tryBlock);
		if (tryBlock == this.tryBlock)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETRY_BLOCK, this.tryBlock, tryBlock);
		if (this.tryBlock != null)
		{
			this.tryBlock.setParentNode(null);
		}
		this.tryBlock = tryBlock;
		setAsParentNodeOf(tryBlock);
		return this;
	}

	
		
	
	public virtual TryStmt setCatchClauses(NodeList catchClauses)
	{
		Utils.assertNotNull(catchClauses);
		if (catchClauses == this.catchClauses)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECATCH_CLAUSES, this.catchClauses, catchClauses);
		if (this.catchClauses != null)
		{
			this.catchClauses.setParentNode(null);
		}
		this.catchClauses = catchClauses;
		setAsParentNodeOf(catchClauses);
		return this;
	}

	
	
	
	public virtual TryStmt setFinallyBlock(BlockStmt finallyBlock)
	{
		if (finallyBlock == this.finallyBlock)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EFINALLY_BLOCK, this.finallyBlock, finallyBlock);
		if (this.finallyBlock != null)
		{
			this.finallyBlock.setParentNode(null);
		}
		this.finallyBlock = finallyBlock;
		setAsParentNodeOf(finallyBlock);
		return this;
	}

	
	
	public virtual TryStmt removeFinallyBlock()
	{
		TryStmt result = setFinallyBlock(null);
		
		return result;
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

	
	
	public new virtual TryStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EtryStmtMetaModel;
	}

	
	
	public new virtual TryStmt clone()
	{
		return (TryStmt)accept(new CloneVisitor(), null);
	}

	
	
	public TryStmt()
		: this(null, new NodeList(), new BlockStmt(), new NodeList(), null)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public TryStmt(BlockStmt tryBlock, NodeList catchClauses, BlockStmt finallyBlock)
		: this(null, new NodeList(), tryBlock, catchClauses, finallyBlock)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public TryStmt(NodeList resources, BlockStmt tryBlock, NodeList catchClauses, BlockStmt finallyBlock)
		: this(null, resources, tryBlock, catchClauses, finallyBlock)
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

		public virtual NodeList getCatchClauses()
	{
		return catchClauses;
	}

	
		
	public virtual Optional getFinallyBlock()
	{
		Optional result = Optional.ofNullable(finallyBlock);
		
		return result;
	}

	public virtual BlockStmt getTryBlock()
	{
		return tryBlock;
	}

		public virtual NodeList getResources()
	{
		return resources;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 108, 99, 130, 112, 111, 109, 226, 61, 230,
		70, 104, 105, 103, 162, 112, 111, 109, 226, 61,
		230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < catchClauses.size(); i++)
		{
			if (catchClauses.get(i) == node)
			{
				catchClauses.remove(i);
				return true;
			}
		}
		if (finallyBlock != null && node == finallyBlock)
		{
			removeFinallyBlock();
			return true;
		}
		for (int i = 0; i < resources.size(); i++)
		{
			if (resources.get(i) == node)
			{
				resources.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 152, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 104, 105, 109, 162, 112, 111, 115, 226, 61,
		230, 70, 105, 109, 130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < catchClauses.size(); i++)
		{
			if (catchClauses.get(i) == node)
			{
				catchClauses.set(i, (CatchClause)replacementNode);
				return true;
			}
		}
		if (finallyBlock != null && node == finallyBlock)
		{
			setFinallyBlock((BlockStmt)replacementNode);
			return true;
		}
		for (int i = 0; i < resources.size(); i++)
		{
			if (resources.get(i) == node)
			{
				resources.set(i, (Expression)replacementNode);
				return true;
			}
		}
		if (node == tryBlock)
		{
			setTryBlock((BlockStmt)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isTryStmt()
	{
		return true;
	}

	public override TryStmt asTryStmt()
	{
		return this;
	}

	
		
	
	public override void ifTryStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toTryStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		TryStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		TryStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TryStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		TryStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		TryStmt result = clone();
		
		return result;
	}

	
	static TryStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
