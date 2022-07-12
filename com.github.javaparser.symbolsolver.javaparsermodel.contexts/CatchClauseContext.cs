
using com.github.javaparser.ast;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class CatchClauseContext : AbstractJavaParserContext
{
	
	
	public CatchClauseContext(CatchClause wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public sealed override SymbolReference solveSymbol(string name)
	{
		SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(((CatchClause)wrappedNode).getParameter(), typeSolver);
		SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		SymbolReference result = solveSymbolInParentContext(name);
		
		return result;
	}

	
		
	public sealed override Optional solveSymbolAsValue(string name)
	{
		SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(((CatchClause)wrappedNode).getParameter(), typeSolver);
		Optional optional = solveWithAsValue(symbolDeclarator, name);
		if (optional.isPresent())
		{
			return optional;
		}
		Optional result = solveSymbolAsValueInParentContext(name);
		
		return result;
	}

	
		
	public sealed override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}

	
		
	public override List localVariablesExposedToChild(Node child)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public override List parametersExposedToChild(Node child)
	{
		if (child == ((CatchClause)getWrappedNode()).getBody())
		{
			List result = Collections.singletonList(((CatchClause)getWrappedNode()).getParameter());
			
			return result;
		}
		List result2 = Collections.emptyList();
		
		return result2;
	}
}
