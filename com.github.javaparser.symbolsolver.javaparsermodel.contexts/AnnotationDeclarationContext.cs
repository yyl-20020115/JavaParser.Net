
using com.github.javaparser.ast.body;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class AnnotationDeclarationContext : AbstractJavaParserContext
{
	private JavaParserTypeDeclarationAdapter javaParserTypeDeclarationAdapter;

	
	
	private ResolvedReferenceTypeDeclaration getDeclaration()
	{
		JavaParserAnnotationDeclaration result = new JavaParserAnnotationDeclaration((AnnotationDeclaration)wrappedNode, typeSolver);
		
		return result;
	}

	
	
	public AnnotationDeclarationContext(AnnotationDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
		javaParserTypeDeclarationAdapter = new JavaParserTypeDeclarationAdapter(wrappedNode, typeSolver, getDeclaration(), this);
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (getDeclaration().hasField(name))
		{
			SymbolReference result = SymbolReference.solved(getDeclaration().getField(name));
			
			return result;
		}
		SymbolReference result2 = solveSymbolInParentContext(name);
		
		return result2;
	}

	
		
	public override SymbolReference solveType(string name)
	{
		SymbolReference result = javaParserTypeDeclarationAdapter.solveType(name);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = javaParserTypeDeclarationAdapter.solveMethod(name, argumentsTypes, staticOnly);
		
		return result;
	}
}
