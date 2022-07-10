using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class VariableDeclarationExprContext : AbstractJavaParserContext
{
	
		
	public override List patternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
	
	public VariableDeclarationExprContext(VariableDeclarationExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		List list = patternExprsExposedFromChildren();
		for (int i = 0; i < list.size(); i++)
		{
			PatternExpr patternExpr = (PatternExpr)list.get(i);
			if (String.instancehelper_equals(patternExpr.getNameAsString(), name))
			{
				SymbolReference result = SymbolReference.solved(JavaParserSymbolDeclaration.patternVar(patternExpr, typeSolver));
				
				return result;
			}
		}
		SymbolReference result2 = solveSymbolInParentContext(name);
		
		return result2;
	}

	
		
	public override List localVariablesExposedToChild(Node child)
	{
		for (int i = 0; i < ((VariableDeclarationExpr)wrappedNode).getVariables().size(); i++)
		{
			if (child == ((VariableDeclarationExpr)wrappedNode).getVariable(i))
			{
				List result = ((VariableDeclarationExpr)wrappedNode).getVariables().subList(0, i);
				
				return result;
			}
		}
		List result2 = Collections.emptyList();
		
		return result2;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		
		return result;
	}
}
