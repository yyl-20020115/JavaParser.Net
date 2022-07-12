
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ObjectCreationContext : AbstractJavaParserContext
{
	
	
	public ObjectCreationContext(ObjectCreationExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveType(string name)
	{
		if (((ObjectCreationExpr)wrappedNode).hasScope())
		{
			Expression node = (Expression)((ObjectCreationExpr)wrappedNode).getScope().get();
			ResolvedType type = JavaParserFacade.get(typeSolver).getType(node);
			if (type.isReferenceType() && type.asReferenceType().getTypeDeclaration().isPresent())
			{
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)type.asReferenceType().getTypeDeclaration().get();
				Iterator iterator = resolvedReferenceTypeDeclaration.internalTypes().iterator();
				while (iterator.hasNext())
				{
					ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)iterator.next();
					if (String.instancehelper_equals(resolvedTypeDeclaration.getName(), name))
					{
						SymbolReference result = SymbolReference.solved(resolvedTypeDeclaration);
						
						return result;
					}
				}
			}
		}
		Node node2 = Navigator.demandParentNode(wrappedNode);
		while (node2 is ObjectCreationExpr)
		{
			node2 = Navigator.demandParentNode(node2);
		}
		SymbolReference result2 = JavaParserFactory.getContext(node2, typeSolver).solveType(name);
		
		return result2;
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		SymbolReference result = JavaParserFactory.getContext(Navigator.demandParentNode(wrappedNode), typeSolver).solveSymbol(name);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = JavaParserFactory.getContext(Navigator.demandParentNode(wrappedNode), typeSolver).solveMethod(name, argumentsTypes, staticOnly: false);
		
		return result;
	}
}
