
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public abstract class AbstractMethodLikeDeclarationContext : AbstractJavaParserContext
{
	
		
	public AbstractMethodLikeDeclarationContext(Node wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public sealed override SymbolReference solveSymbol(string name)
	{
		Iterator iterator = ((NodeWithParameters)wrappedNode).getParameters().iterator();
		while (iterator.hasNext())
		{
			Parameter node = (Parameter)iterator.next();
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node, typeSolver);
			SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
			if (symbolReference.isSolved())
			{
				return symbolReference;
			}
		}
		SymbolReference result = solveSymbolInParentContext(name);
		
		return result;
	}

	
		
	public sealed override Optional solveGenericType(string name)
	{
		Iterator iterator = ((NodeWithTypeParameters)wrappedNode).getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			TypeParameter typeParameter = (TypeParameter)iterator.next();
			if (String.instancehelper_equals(typeParameter.getName().getId(), name))
			{
				Optional result = Optional.of(new ResolvedTypeVariable(new JavaParserTypeParameter(typeParameter, typeSolver)));
				
				return result;
			}
		}
		Optional result2 = solveGenericTypeInParentContext(name);
		
		return result2;
	}

	
		
	public sealed override Optional solveSymbolAsValue(string name)
	{
		Iterator iterator = ((NodeWithParameters)wrappedNode).getParameters().iterator();
		while (iterator.hasNext())
		{
			Parameter node = (Parameter)iterator.next();
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node, typeSolver);
			Optional optional = solveWithAsValue(symbolDeclarator, name);
			if (optional.isPresent())
			{
				return optional;
			}
		}
		Optional result = solveSymbolAsValueInParentContext(name);
		
		return result;
	}

	
		
	public sealed override SymbolReference solveType(string name)
	{
		if (((NodeWithTypeParameters)wrappedNode).getTypeParameters() != null)
		{
			Iterator iterator = ((NodeWithTypeParameters)wrappedNode).getTypeParameters().iterator();
			while (iterator.hasNext())
			{
				TypeParameter typeParameter = (TypeParameter)iterator.next();
				if (String.instancehelper_equals(typeParameter.getName().getId(), name))
				{
					SymbolReference result = SymbolReference.solved(new JavaParserTypeParameter(typeParameter, typeSolver));
					
					return result;
				}
			}
		}
		List list = wrappedNode.findAll(ClassLiteral<TypeDeclaration>.Value);
		Iterator iterator2 = list.iterator();
		while (iterator2.hasNext())
		{
			TypeDeclaration typeDeclaration = (TypeDeclaration)iterator2.next();
			if (String.instancehelper_equals(typeDeclaration.getName().getId(), name))
			{
				SymbolReference result2 = SymbolReference.solved(JavaParserFacade.get(typeSolver).getTypeDeclaration(typeDeclaration));
				
				return result2;
			}
			if (String.instancehelper_startsWith(name, String.format("%s.", typeDeclaration.getName())))
			{
				SymbolReference result3 = JavaParserFactory.getContext(typeDeclaration, typeSolver).solveType(String.instancehelper_substring(name, String.instancehelper_length(typeDeclaration.getName().getId()) + 1));
				
				return result3;
			}
		}
		SymbolReference result4 = solveTypeInParentContext(name);
		
		return result4;
	}

	
		
	public sealed override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}
}
