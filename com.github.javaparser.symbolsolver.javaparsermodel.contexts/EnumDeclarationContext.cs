using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class EnumDeclarationContext : AbstractJavaParserContext
{
	private JavaParserTypeDeclarationAdapter javaParserTypeDeclarationAdapter;

	
	
	private ResolvedReferenceTypeDeclaration getDeclaration()
	{
		JavaParserEnumDeclaration.___003Cclinit_003E();
		JavaParserEnumDeclaration result = new JavaParserEnumDeclaration((EnumDeclaration)wrappedNode, typeSolver);
		
		return result;
	}

	
	
	public EnumDeclarationContext(EnumDeclaration wrappedNode, TypeSolver typeSolver)
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
		Iterator iterator = ((EnumDeclaration)wrappedNode).getEntries().iterator();
		while (iterator.hasNext())
		{
			EnumConstantDeclaration enumConstantDeclaration = (EnumConstantDeclaration)iterator.next();
			if (String.instancehelper_equals(enumConstantDeclaration.getName().getId(), name))
			{
				SymbolReference result = SymbolReference.solved(new JavaParserEnumConstantDeclaration(enumConstantDeclaration, typeSolver));
				
				return result;
			}
		}
		if (getDeclaration().hasField(name))
		{
			SymbolReference result2 = SymbolReference.solved(getDeclaration().getField(name));
			
			return result2;
		}
		SymbolReference result3 = solveSymbolInParentContext(name);
		
		return result3;
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
