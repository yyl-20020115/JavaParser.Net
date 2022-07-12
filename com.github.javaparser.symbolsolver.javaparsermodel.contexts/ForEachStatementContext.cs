
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ForEachStatementContext : AbstractJavaParserContext
{
	
	
	public ForEachStatementContext(ForEachStmt wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		if (((ForEachStmt)wrappedNode).getVariable().getVariables().size() != 1)
		{
			
			throw new IllegalStateException();
		}
		VariableDeclarator variableDeclarator = (VariableDeclarator)((ForEachStmt)wrappedNode).getVariable().getVariables().get(0);
		if (String.instancehelper_equals(variableDeclarator.getName().getId(), name))
		{
			SymbolReference result = SymbolReference.solved(JavaParserSymbolDeclaration.localVar(variableDeclarator, typeSolver));
			
			return result;
		}
		if (Navigator.demandParentNode(wrappedNode) is BlockStmt)
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
		if (child == ((ForEachStmt)wrappedNode).getBody())
		{
			NodeList variables = ((ForEachStmt)wrappedNode).getVariable().getVariables();
			
			return variables;
		}
		List result = Collections.emptyList();
		
		return result;
	}
}
