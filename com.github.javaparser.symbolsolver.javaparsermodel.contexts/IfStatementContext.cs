using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class IfStatementContext : StatementContext
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly Node arg_00241;

		private readonly List arg_00242;

		private readonly Context arg_00243;

		internal ___003C_003EAnon0(Node P_0, List P_1, Context P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			lambda_0024patternExprsExposedToChild_00240(arg_00241, arg_00242, arg_00243, (Statement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	
	private static void lambda_0024patternExprsExposedToChild_00240(Node P_0, List P_1, Context P_2, Statement P_3)
	{
		if (P_3.containsWithinRange(P_0))
		{
			P_1.addAll(P_2.negatedPatternExprsExposedFromChildren());
		}
	}

	
	
	public IfStatementContext(IfStmt wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		[LineNumberTable(new byte[]
	{
		159,
		166,
		113,
		141,
		134,
		119,
		99,
		173,
		byte.MaxValue,
		3,
		71
	})]
	public override List patternExprsExposedToChild(Node child)
	{
		Expression condition = ((IfStmt)wrappedNode).getCondition();
		Context context = JavaParserFactory.getContext(condition, typeSolver);
		ArrayList arrayList = new ArrayList();
		if (((IfStmt)wrappedNode).getThenStmt().containsWithinRange(child))
		{
			((List)arrayList).addAll((Collection)context.patternExprsExposedFromChildren());
		}
		((IfStmt)wrappedNode).getElseStmt().ifPresent(new ___003C_003EAnon0(child, arrayList, context));
		return arrayList;
	}

	
	
	public virtual bool nodeContextIsChainedIfElseIf(Context parentContext)
	{
		return (parentContext is AbstractJavaParserContext && getWrappedNode() is IfStmt && ((AbstractJavaParserContext)parentContext).getWrappedNode() is IfStmt) ? true : false;
	}

	
	[LineNumberTable(new byte[]
	{
		26, 104, 130, 104, 162, 98, 135, 103, 135, 104,
		104, 110, 113, 100, 226, 69
	})]
	public virtual bool nodeContextIsImmediateChildElse(Context parentContext)
	{
		if (!(parentContext is AbstractJavaParserContext))
		{
			return false;
		}
		if (!(this is AbstractJavaParserContext))
		{
			return false;
		}
		AbstractJavaParserContext abstractJavaParserContext = (AbstractJavaParserContext)parentContext;
		Node node = getWrappedNode();
		Node node2 = abstractJavaParserContext.getWrappedNode();
		if (node2 is IfStmt)
		{
			IfStmt ifStmt = (IfStmt)node2;
			if (ifStmt.getElseStmt().isPresent() && ifStmt.getElseStmt().get() == node)
			{
				return true;
			}
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		64, 104, 130, 104, 162, 98, 135, 103, 135, 104,
		104, 108, 100, 194
	})]
	public virtual bool nodeContextIsThenOfIfStmt(Context parentContext)
	{
		if (!(parentContext is AbstractJavaParserContext))
		{
			return false;
		}
		if (!(this is AbstractJavaParserContext))
		{
			return false;
		}
		AbstractJavaParserContext abstractJavaParserContext = (AbstractJavaParserContext)parentContext;
		Node node = getWrappedNode();
		Node node2 = abstractJavaParserContext.getWrappedNode();
		if (node2 is IfStmt)
		{
			IfStmt ifStmt = (IfStmt)node2;
			if (ifStmt.getThenStmt() == node)
			{
				return true;
			}
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		90, 104, 130, 104, 162, 98, 135, 103, 135, 104,
		104, 108, 100, 194
	})]
	public virtual bool nodeContextIsConditionOfIfStmt(Context parentContext)
	{
		if (!(parentContext is AbstractJavaParserContext))
		{
			return false;
		}
		if (!(this is AbstractJavaParserContext))
		{
			return false;
		}
		AbstractJavaParserContext abstractJavaParserContext = (AbstractJavaParserContext)parentContext;
		Node node = getWrappedNode();
		Node node2 = abstractJavaParserContext.getWrappedNode();
		if (node2 is IfStmt)
		{
			IfStmt ifStmt = (IfStmt)node2;
			if (ifStmt.getCondition() == node)
			{
				return true;
			}
		}
		return false;
	}
}
