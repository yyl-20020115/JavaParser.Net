
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class Substitution
{
		private List typeParameterDeclarations;

		private List types;

	
	private static Substitution EMPTY;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public static Substitution empty()
	{
		return EMPTY;
	}

	
	
	public virtual Substitution withPair(ResolvedTypeParameterDeclaration typeParameterDeclaration, ResolvedType type)
	{
		Substitution substitution = new Substitution();
		substitution.typeParameterDeclarations.addAll(typeParameterDeclarations);
		substitution.types.addAll(types);
		substitution.typeParameterDeclarations.add(typeParameterDeclaration);
		substitution.types.add(type);
		return substitution;
	}

	
	
	public virtual ResolvedType apply(ResolvedType originalType)
	{
		ResolvedType resolvedType = originalType;
		for (int i = 0; i < typeParameterDeclarations.size(); i++)
		{
			resolvedType = resolvedType.replaceTypeVariables((ResolvedTypeParameterDeclaration)typeParameterDeclarations.get(i), (ResolvedType)types.get(i));
		}
		return resolvedType;
	}

	
	
	private Substitution()
	{
		typeParameterDeclarations = new LinkedList();
		types = new LinkedList();
	}

	
	static Substitution()
	{
		EMPTY = new Substitution();
	}
}
