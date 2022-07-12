
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.visitor;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class ControlFlowLogic
{
	
		[EnclosingMethod(null, "canCompleteNormally", "(Lcom.github.javaparser.ast.stmt.Statement;)Z")]
	internal class _1 : GenericVisitorAdapter
	{
		
		internal Statement val_0024statement;

		
		internal ControlFlowLogic this_00240;

		
		
		public virtual Boolean visit(LocalRecordDeclarationStmt P_0, Void P_1)
		{
			Boolean result = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result;
		}

		
		
		public virtual Boolean visit(LocalClassDeclarationStmt P_0, Void P_1)
		{
			Boolean result = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result;
		}

		
		
		public virtual Boolean visit(LabeledStmt P_0, Void P_1)
		{
			
			throw new UnsupportedOperationException();
		}

		
		
		public virtual Boolean visit(IfStmt P_0, Void P_1)
		{
			if (P_0.getElseStmt().isPresent())
			{
				Boolean result = Boolean.valueOf((this_00240.canCompleteNormally(P_0.getThenStmt()) || this_00240.canCompleteNormally((Statement)P_0.getElseStmt().get())) ? true : false);
				
				return result;
			}
			Boolean result2 = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result2;
		}

		
		
		public virtual Boolean visit(ExpressionStmt P_0, Void P_1)
		{
			if (P_0.getExpression() is VariableDeclarationExpr)
			{
				_ = (VariableDeclarationExpr)P_0.getExpression();
				Boolean result = Boolean.valueOf(this_00240.isReachable(P_0));
				
				return result;
			}
			Boolean result2 = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result2;
		}

		
		
		public virtual Boolean visit(EmptyStmt P_0, Void P_1)
		{
			Boolean result = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result;
		}

		
		
		public virtual Boolean visit(BlockStmt P_0, Void P_1)
		{
			if (P_0.isEmpty() && !access_0024000(this_00240, val_0024statement, ClassLiteral<SwitchStmt>.Value))
			{
				Boolean result = Boolean.valueOf(this_00240.isReachable(val_0024statement));
				
				return result;
			}
			if (!P_0.isEmpty() && !access_0024000(this_00240, val_0024statement, ClassLiteral<SwitchStmt>.Value))
			{
				Boolean result2 = Boolean.valueOf(this_00240.canCompleteNormally(P_0.getStatement(P_0.getStatements().size() - 1)));
				
				return result2;
			}
			
			throw new UnsupportedOperationException();
		}

		
		
		public virtual Boolean visit(AssertStmt P_0, Void P_1)
		{
			Boolean result = Boolean.valueOf(this_00240.isReachable(P_0));
			
			return result;
		}

		
		
		internal _1(ControlFlowLogic P_0, Statement P_1)
		{
			this_00240 = P_0;
			val_0024statement = P_1;
			
		}

		
		
		
		public override object visit(LocalRecordDeclarationStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(LocalClassDeclarationStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(LabeledStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(IfStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(ExpressionStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(EmptyStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(BlockStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(AssertStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}
	}

	
		[EnclosingMethod(null, "isReachable", "(Lcom.github.javaparser.ast.stmt.Statement;)Z")]
	internal class _2 : GenericVisitorAdapter
	{
		
		internal Statement val_0024statement;

		
		internal ControlFlowLogic this_00240;

		
		
		internal _2(ControlFlowLogic P_0, Statement P_1)
		{
			this_00240 = P_0;
			val_0024statement = P_1;
			
		}

		
		
		public virtual Boolean visit(LocalRecordDeclarationStmt P_0, Void P_1)
		{
			return (Boolean)base.visit(P_0, P_1);
		}

		
		
		public virtual Boolean visit(LocalClassDeclarationStmt P_0, Void P_1)
		{
			return (Boolean)base.visit(P_0, P_1);
		}

		
		
		public virtual Boolean visit(BlockStmt P_0, Void P_1)
		{
			if (val_0024statement.getParentNode().isPresent())
			{
				if (val_0024statement.getParentNode().get() is ConstructorDeclaration)
				{
					Boolean result = Boolean.valueOf(b: true);
					
					return result;
				}
				if (val_0024statement.getParentNode().get() is MethodDeclaration)
				{
					Boolean result2 = Boolean.valueOf(b: true);
					
					return result2;
				}
				if (val_0024statement.getParentNode().get() is InitializerDeclaration)
				{
					Boolean result3 = Boolean.valueOf(b: true);
					
					return result3;
				}
			}
			Boolean result4 = Boolean.valueOf(access_0024100(this_00240, val_0024statement));
			
			return result4;
		}

		
		
		
		public override object visit(LocalRecordDeclarationStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(LocalClassDeclarationStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}

		
		
		
		public override object visit(BlockStmt P_0, object P_1)
		{
			Boolean result = visit(P_0, (Void)P_1);
			
			return result;
		}
	}

	private static ControlFlowLogic instance;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public static ControlFlowLogic getInstance()
	{
		return instance;
	}

	
	
	public virtual bool canCompleteNormally(Statement statement)
	{
		if (!isReachable(statement))
		{
			return false;
		}
		var _1  = new _1(this, statement);
		bool result = ((Boolean)statement.accept(null, null)).booleanValue();
		
		return result;
	}

	
	
	
	internal static bool access_0024000(ControlFlowLogic P_0, Node P_1, Class P_2)
	{
		bool result = P_0.parentIs(P_1, P_2);
		
		return result;
	}

	
	
	public virtual bool isReachable(Statement statement)
	{
		_2  = new _2(this, statement);
		bool result = ((Boolean)statement.accept(null, null)).booleanValue();
		
		return result;
	}

	
	
	private bool isReachableBecauseOfPosition(Statement P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	private bool parentIs(Node P_0, Class P_1)
	{
		if (P_0.getParentNode().isPresent())
		{
			bool result = P_1.isInstance(P_0.getParentNode().get());
			
			return result;
		}
		return false;
	}

	
	
	public virtual Statement breakTarget(BreakStmt breakStmt)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	private List containedTryStmts(Statement P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	private bool contains(Statement P_0, Statement P_1)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	private ControlFlowLogic()
	{
	}

	
	
	public virtual bool exitTheStatement(BreakStmt breakStmt)
	{
		if (!isReachable(breakStmt))
		{
			return false;
		}
		Statement statement = breakTarget(breakStmt);
		Iterator iterator = containedTryStmts(statement).iterator();
		while (iterator.hasNext())
		{
			TryStmt tryStmt = (TryStmt)iterator.next();
			if (contains(tryStmt.getTryBlock(), breakStmt) && !tryStmt.getFinallyBlock().isPresent() && !canCompleteNormally((Statement)tryStmt.getFinallyBlock().get()))
			{
				return false;
			}
		}
		return true;
	}

	
	
	public virtual bool continueADoStatement(ContinueStmt continueStmt, DoStmt doStmt)
	{
		Iterator iterator = containedTryStmts(continueStmt).iterator();
		while (iterator.hasNext())
		{
			TryStmt tryStmt = (TryStmt)iterator.next();
			if (contains(tryStmt.getTryBlock(), continueStmt) && !tryStmt.getFinallyBlock().isPresent() && !canCompleteNormally((Statement)tryStmt.getFinallyBlock().get()))
			{
				return false;
			}
		}
		return true;
	}

	
	
	
	internal static bool access_0024100(ControlFlowLogic P_0, Statement P_1)
	{
		bool result = P_0.isReachableBecauseOfPosition(P_1);
		
		return result;
	}

	
	static ControlFlowLogic()
	{
		instance = new ControlFlowLogic();
	}
}
