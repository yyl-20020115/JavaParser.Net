
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class InstanceOfExprContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((PatternExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public InstanceOfExprContext(InstanceOfExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		Optional pattern = ((InstanceOfExpr)wrappedNode).getPattern();
		if (pattern.isPresent() && String.instancehelper_equals(((PatternExpr)pattern.get()).getNameAsString(), name))
		{
			JavaParserPatternDeclaration symbolDeclaration = JavaParserSymbolDeclaration.patternVar((PatternExpr)pattern.get(), typeSolver);
			SymbolReference result = SymbolReference.solved(symbolDeclaration);
			
			return result;
		}
		Optional parent = getParent();
		if (!parent.isPresent())
		{
			SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			
			return result2;
		}
		Context context = (Context)parent.get();
		if (context is BinaryExprContext)
		{
			Optional optional = context.patternExprInScope(name);
			if (optional.isPresent())
			{
				JavaParserPatternDeclaration symbolDeclaration2 = JavaParserSymbolDeclaration.patternVar((PatternExpr)optional.get(), typeSolver);
				SymbolReference result3 = SymbolReference.solved(symbolDeclaration2);
				
				return result3;
			}
		}
		SymbolReference result4 = solveSymbolInParentContext(name);
		
		return result4;
	}

	
		
	public unsafe override List patternExprsExposedFromChildren()
	{
		ArrayList arrayList = new ArrayList();
		Optional pattern = ((InstanceOfExpr)wrappedNode).getPattern();
		
		pattern.ifPresent(new ___003C_003EAnon0(arrayList));
		return arrayList;
	}
}
