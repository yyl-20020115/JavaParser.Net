using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.ast.stmt;


public class SwitchEntry : Node, NodeWithStatements
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class Type : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			STATEMENT_GROUP,
			EXPRESSION,
			BLOCK,
			THROWS_STATEMENT
		}

		
		internal static Type ___003C_003ESTATEMENT_GROUP;

		
		internal static Type ___003C_003EEXPRESSION;

		
		internal static Type ___003C_003EBLOCK;

		
		internal static Type ___003C_003ETHROWS_STATEMENT;

		
		private static Type[] _0024VALUES;

		
		public static Type STATEMENT_GROUP
		{
			
			get
			{
				return ___003C_003ESTATEMENT_GROUP;
			}
		}

		
		public static Type EXPRESSION
		{
			
			get
			{
				return ___003C_003EEXPRESSION;
			}
		}

		
		public static Type BLOCK
		{
			
			get
			{
				return ___003C_003EBLOCK;
			}
		}

		
		public static Type THROWS_STATEMENT
		{
			
			get
			{
				return ___003C_003ETHROWS_STATEMENT;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private Type(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static Type[] values()
		{
			return (Type[])_0024VALUES.Clone();
		}

		
		
		
		public static Type valueOf(string name)
		{
			return (Type)java.lang.Enum.valueOf(ClassLiteral<Type>.Value, name);
		}

		
		static Type()
		{
			___003C_003ESTATEMENT_GROUP = new Type("STATEMENT_GROUP", 0);
			___003C_003EEXPRESSION = new Type("EXPRESSION", 1);
			___003C_003EBLOCK = new Type("BLOCK", 2);
			___003C_003ETHROWS_STATEMENT = new Type("THROWS_STATEMENT", 3);
			_0024VALUES = new Type[4] { ___003C_003ESTATEMENT_GROUP, ___003C_003EEXPRESSION, ___003C_003EBLOCK, ___003C_003ETHROWS_STATEMENT };
		}
	}

		private NodeList labels;

		private NodeList statements;

	private Type type;

	
	
	public new static void ___003Cclinit_003E()
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
	public SwitchEntry(NodeList labels, Type type, NodeList statements)
		: this(null, labels, type, statements)
	{
	}

		public virtual NodeList getLabels()
	{
		return labels;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public SwitchEntry(TokenRange tokenRange, NodeList labels, Type type, NodeList statements)
		: base(tokenRange)
	{
		setLabels(labels);
		setType(type);
		setStatements(statements);
		customInitialization();
	}

	
		
	
	public virtual SwitchEntry setLabels(NodeList labels)
	{
		Utils.assertNotNull(labels);
		if (labels == this.labels)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ELABELS, this.labels, labels);
		if (this.labels != null)
		{
			this.labels.setParentNode(null);
		}
		this.labels = labels;
		setAsParentNodeOf(labels);
		return this;
	}

	
	
	
	public virtual SwitchEntry setType(Type type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		this.type = type;
		return this;
	}

	
		
	
	public virtual SwitchEntry setStatements(NodeList statements)
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

	
	
	public new virtual SwitchEntryMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EswitchEntryMetaModel;
	}

	
	
	public new virtual SwitchEntry clone()
	{
		return (SwitchEntry)accept(new CloneVisitor(), null);
	}

	
	
	public SwitchEntry()
		: this(null, new NodeList(), Type.___003C_003ESTATEMENT_GROUP, new NodeList())
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

		public virtual NodeList getStatements()
	{
		return statements;
	}

	
	
	[LineNumberTable(new byte[]
	{
		127, 99, 130, 112, 111, 109, 226, 61, 230, 70,
		112, 111, 109, 226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < labels.size(); i++)
		{
			if (labels.get(i) == node)
			{
				labels.remove(i);
				return true;
			}
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

	public virtual Type getType()
	{
		return type;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 112, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 112, 111, 115, 226, 61, 230, 70
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < labels.size(); i++)
		{
			if (labels.get(i) == node)
			{
				labels.set(i, (Expression)replacementNode);
				return true;
			}
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

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		SwitchEntryMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		SwitchEntry result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		SwitchEntry result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetStatements(NodeList statements)
	{
		SwitchEntry result = setStatements(statements);
		
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
	public virtual Node addStatement(Statement P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(int P_0, Statement P_1)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(Expression P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addStatement(string P_0)
	{
		return NodeWithStatements._003Cdefault_003EaddStatement(this, P_0);
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
	public virtual bool isEmpty()
	{
		return NodeWithStatements._003Cdefault_003EisEmpty(this);
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

	
	static SwitchEntry()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithStatements.NodeWithStatements_003A_003AsetStatements(NodeList P_0)
	{
		return _003Cbridge_003EsetStatements(P_0);
	}
}
