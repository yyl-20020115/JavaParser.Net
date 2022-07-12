
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ForStatementContext : AbstractJavaParserContext
{
	
	
	public ForStatementContext(ForStmt wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		Iterator iterator = ((ForStmt)wrappedNode).getInitialization().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (expression is VariableDeclarationExpr)
			{
				VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)expression;
				Iterator iterator2 = variableDeclarationExpr.getVariables().iterator();
				while (iterator2.hasNext())
				{
					VariableDeclarator variableDeclarator = (VariableDeclarator)iterator2.next();
					if (String.instancehelper_equals(variableDeclarator.getName().getId(), name))
					{
						SymbolReference result = SymbolReference.solved(JavaParserSymbolDeclaration.localVar(variableDeclarator, typeSolver));
						
						return result;
					}
				}
			}
			else if (!(expression is AssignExpr) && !(expression is MethodCallExpr) && !(expression is UnaryExpr))
			{
				string canonicalName = Object.instancehelper_getClass(expression).getCanonicalName();
				
				throw new UnsupportedOperationException(canonicalName);
			}
		}
		if (Navigator.demandParentNode(wrappedNode) is NodeWithStatements)
		{
			SymbolReference result2 = StatementContext.solveInBlock(name, typeSolver, (Statement)wrappedNode);
			
			return result2;
		}
		SymbolReference result3 = solveSymbolInParentContext(name);
		
		return result3;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}

	
		
	public override List localVariablesExposedToChild(Node child)
	{
		LinkedList linkedList = new LinkedList();
		Iterator iterator = ((ForStmt)wrappedNode).getInitialization().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (expression is VariableDeclarationExpr)
			{
				VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)expression;
				((List)linkedList).addAll((Collection)variableDeclarationExpr.getVariables());
			}
		}
		return linkedList;
	}
}
