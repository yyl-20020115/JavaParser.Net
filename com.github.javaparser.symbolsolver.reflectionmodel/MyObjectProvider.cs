using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution.typesolvers;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.symbolsolver.reflectionmodel;

public class MyObjectProvider: ObjectProvider
{
	internal static MyObjectProvider ___003C_003EINSTANCE;

	
	public static MyObjectProvider INSTANCE
	{
		
		get
		{
			return ___003C_003EINSTANCE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual ResolvedReferenceType byName(string qualifiedName)
	{
		ReflectionTypeSolver reflectionTypeSolver = new ReflectionTypeSolver();
		ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = ((TypeSolver)reflectionTypeSolver).solveType(qualifiedName);
		if (!resolvedReferenceTypeDeclaration.getTypeParameters().isEmpty())
		{
			
			throw new UnsupportedOperationException();
		}
		ReferenceTypeImpl result = new ReferenceTypeImpl(resolvedReferenceTypeDeclaration, reflectionTypeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, new ReflectionTypeSolver()), new ReflectionTypeSolver());
		
		return result;
	}

	
	
	private MyObjectProvider()
	{
	}

	
	static MyObjectProvider()
	{
		___003C_003EINSTANCE = new MyObjectProvider();
	}
}
