
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class BlockStmtContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly BlockStmtContext arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon0(BlockStmtContext P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024solveSymbol_00240(arg_00242, (Statement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		
	private List localVariablesDeclaredIn(Statement P_0)
	{
		if (P_0 is ExpressionStmt)
		{
			ExpressionStmt expressionStmt = (ExpressionStmt)P_0;
			if (expressionStmt.getExpression() is VariableDeclarationExpr)
			{
				VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)expressionStmt.getExpression();
				LinkedList linkedList = new LinkedList();
				((List)linkedList).addAll((Collection)variableDeclarationExpr.getVariables());
				return linkedList;
			}
		}
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public override List localVariablesExposedToChild(Node child)
	{
		int num = ((BlockStmt)wrappedNode).getStatements().indexOf(child);
		if (num == -1)
		{
			
			throw new RuntimeException();
		}
		LinkedList linkedList = new LinkedList();
		for (int i = num - 1; i >= 0; i += -1)
		{
			((List)linkedList).addAll((Collection)localVariablesDeclaredIn(((BlockStmt)wrappedNode).getStatement(i)));
		}
		return linkedList;
	}

	
	
	
	private void lambda_0024solveSymbol_00240(List P_0, Statement P_1)
	{
		P_0.addAll(localVariablesExposedToChild(P_1));
	}

	
	
	public BlockStmtContext(BlockStmt wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		Optional parent = getParent();
		if (!parent.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			
			return result;
		}
		if (((BlockStmt)wrappedNode).getStatements().size() > 0)
		{
			LinkedList linkedList = new LinkedList();
			((BlockStmt)wrappedNode).getStatements().getLast().ifPresent(new ___003C_003EAnon0(this, linkedList));
			if (!((List)linkedList).isEmpty())
			{
				Iterator iterator = ((List)linkedList).iterator();
				while (iterator.hasNext())
				{
					VariableDeclarator variableDeclarator = (VariableDeclarator)iterator.next();
					if (String.instancehelper_equals(variableDeclarator.getNameAsString(), name))
					{
						SymbolReference result2 = SymbolReference.solved(JavaParserSymbolDeclaration.localVar(variableDeclarator, typeSolver));
						
						return result2;
					}
				}
			}
		}
		SymbolReference result3 = solveSymbolInParentContext(name);
		
		return result3;
	}
}
