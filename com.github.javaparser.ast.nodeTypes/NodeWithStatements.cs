using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithStatements
{
	
	public static class __DefaultMethods
	{
		public unsafe static Statement getStatement(NodeWithStatements P_0, int P_1)
		{
			
			return _003Cdefault_003EgetStatement(P_0, P_1);
		}

		public unsafe static Node setStatement(NodeWithStatements P_0, int P_1, Statement P_2)
		{
			
			return _003Cdefault_003EsetStatement(P_0, P_1, P_2);
		}

		public unsafe static Node addStatement(NodeWithStatements P_0, Statement P_1)
		{
			
			return _003Cdefault_003EaddStatement(P_0, P_1);
		}

		public unsafe static Node addStatement(NodeWithStatements P_0, int P_1, Statement P_2)
		{
			
			return _003Cdefault_003EaddStatement(P_0, P_1, P_2);
		}

		public unsafe static Node addStatement(NodeWithStatements P_0, Expression P_1)
		{
			
			return _003Cdefault_003EaddStatement(P_0, P_1);
		}

		public unsafe static Node addStatement(NodeWithStatements P_0, string P_1)
		{
			
			return _003Cdefault_003EaddStatement(P_0, P_1);
		}

		public unsafe static Node addStatement(NodeWithStatements P_0, int P_1, Expression P_2)
		{
			
			return _003Cdefault_003EaddStatement(P_0, P_1, P_2);
		}

		public unsafe static Statement addAndGetStatement(NodeWithStatements P_0, Statement P_1)
		{
			
			return _003Cdefault_003EaddAndGetStatement(P_0, P_1);
		}

		public unsafe static Statement addAndGetStatement(NodeWithStatements P_0, int P_1, Statement P_2)
		{
			
			return _003Cdefault_003EaddAndGetStatement(P_0, P_1, P_2);
		}

		public unsafe static ExpressionStmt addAndGetStatement(NodeWithStatements P_0, Expression P_1)
		{
			
			return _003Cdefault_003EaddAndGetStatement(P_0, P_1);
		}

		public unsafe static ExpressionStmt addAndGetStatement(NodeWithStatements P_0, string P_1)
		{
			
			return _003Cdefault_003EaddAndGetStatement(P_0, P_1);
		}

		public unsafe static bool isEmpty(NodeWithStatements P_0)
		{
			
			return _003Cdefault_003EisEmpty(P_0);
		}

		public unsafe static Node copyStatements(NodeWithStatements P_0, NodeList P_1)
		{
			
			return _003Cdefault_003EcopyStatements(P_0, P_1);
		}

		public unsafe static Node copyStatements(NodeWithStatements P_0, NodeWithStatements P_1)
		{
			
			return _003Cdefault_003EcopyStatements(P_0, P_1);
		}
	}

	
		
	virtual Node addStatement(string statement);

	
	
	
	static Node _003Cdefault_003EaddStatement(NodeWithStatements P_0, string P_1)
	{
		Node result = P_0.addStatement(StaticJavaParser.parseStatement(P_1));
		
		return result;
	}

	
		
	virtual Node addStatement(Statement statement);

	
	
	
	static Node _003Cdefault_003EaddStatement(NodeWithStatements P_0, Statement P_1)
	{
		P_0.getStatements().add(P_1);
		return (Node)P_0;
	}

	
		
	virtual Node addStatement(Expression expr);

	
	
	
	static Node _003Cdefault_003EaddStatement(NodeWithStatements P_0, Expression P_1)
	{
		Node result = P_0.addStatement(new ExpressionStmt(P_1));
		
		return result;
	}

	
	virtual bool isEmpty();

	
	
	
	static bool _003Cdefault_003EisEmpty(NodeWithStatements P_0)
	{
		bool result = P_0.getStatements().isEmpty();
		
		return result;
	}

		virtual NodeList getStatements();

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final
	})]
	virtual Node addStatement(int index, Statement statement);

	
	
	
	static Node _003Cdefault_003EaddStatement(NodeWithStatements P_0, int P_1, Statement P_2)
	{
		P_0.getStatements().add(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Statement addAndGetStatement(Statement statement);

	
	
	
	static Statement _003Cdefault_003EaddAndGetStatement(NodeWithStatements P_0, Statement P_1)
	{
		P_0.getStatements().add(P_1);
		return P_1;
	}

	
	
	virtual ExpressionStmt addAndGetStatement(Expression expr);

	
	
	
	static ExpressionStmt _003Cdefault_003EaddAndGetStatement(NodeWithStatements P_0, Expression P_1)
	{
		ExpressionStmt statement = new ExpressionStmt(P_1);
		return (ExpressionStmt)P_0.addAndGetStatement(statement);
	}

	
		
	virtual Node copyStatements(NodeList nodeList);

	
	
	
	static Node _003Cdefault_003EcopyStatements(NodeWithStatements P_0, NodeList P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Statement statement = (Statement)iterator.next();
			P_0.addStatement(statement.clone());
		}
		return (Node)P_0;
	}

	
	
	virtual Statement getStatement(int i);

	
	
	
	static Statement _003Cdefault_003EgetStatement(NodeWithStatements P_0, int P_1)
	{
		return (Statement)P_0.getStatements().get(P_1);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual Node setStatement(int i, Statement statement);

	
	
	
	static Node _003Cdefault_003EsetStatement(NodeWithStatements P_0, int P_1, Statement P_2)
	{
		P_0.getStatements().set(P_1, P_2);
		return (Node)P_0;
	}

		
	virtual Node setStatements(NodeList statements);

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final
	})]
	virtual Node addStatement(int index, Expression expr);

	
	
	
	static Node _003Cdefault_003EaddStatement(NodeWithStatements P_0, int P_1, Expression P_2)
	{
		ExpressionStmt statement = new ExpressionStmt(P_2);
		Node result = P_0.addStatement(P_1, statement);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final
	})]
	virtual Statement addAndGetStatement(int index, Statement statement);

	
	
	
	static Statement _003Cdefault_003EaddAndGetStatement(NodeWithStatements P_0, int P_1, Statement P_2)
	{
		P_0.getStatements().add(P_1, P_2);
		return P_2;
	}

	
	
	virtual ExpressionStmt addAndGetStatement(string statement);

	
	
	
	static ExpressionStmt _003Cdefault_003EaddAndGetStatement(NodeWithStatements P_0, string P_1)
	{
		ExpressionStmt result = P_0.addAndGetStatement(new NameExpr(P_1));
		
		return result;
	}

	
		
	virtual Node copyStatements(NodeWithStatements other);

	
	
	
	static Node _003Cdefault_003EcopyStatements(NodeWithStatements P_0, NodeWithStatements P_1)
	{
		Node result = P_0.copyStatements(P_1.getStatements());
		
		return result;
	}
}
