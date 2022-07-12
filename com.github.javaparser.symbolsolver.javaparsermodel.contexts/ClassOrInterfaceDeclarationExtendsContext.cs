
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ClassOrInterfaceDeclarationExtendsContext : AbstractJavaParserContext
{
	
	
	public ClassOrInterfaceDeclarationExtendsContext(ClassOrInterfaceDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveType(string name)
	{
		Iterator iterator = ((ClassOrInterfaceDeclaration)wrappedNode).getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			TypeParameter typeParameter = (TypeParameter)iterator.next();
			if (String.instancehelper_equals(typeParameter.getName().getId(), name))
			{
				SymbolReference result = SymbolReference.solved(new JavaParserTypeParameter(typeParameter, typeSolver));
				
				return result;
			}
		}
		SymbolReference result2 = base.solveType(name);
		
		return result2;
	}
}
