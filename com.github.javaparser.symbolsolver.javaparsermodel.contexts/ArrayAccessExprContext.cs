using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ArrayAccessExprContext : AbstractJavaParserContext
{
	
	
	public ArrayAccessExprContext(ArrayAccessExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbolInParentContext(string name)
	{
		SymbolReference result = base.solveSymbolInParentContext(name);
		
		return result;
	}
}
