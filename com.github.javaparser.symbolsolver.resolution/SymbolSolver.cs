using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.javassistmodel;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution;

public class SymbolSolver
{
	
	private TypeSolver typeSolver;

	
	
	public SymbolSolver(TypeSolver typeSolver)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException("Missing Parameter - Cannot initialise a SymbolSolver, without a way to solve types.");
		}
		this.typeSolver = typeSolver;
	}

	
		
	public virtual SymbolReference solveSymbolInType(ResolvedTypeDeclaration typeDeclaration, string name)
	{
		if (typeDeclaration is JavaParserClassDeclaration)
		{
			Context context = ((JavaParserClassDeclaration)typeDeclaration).getContext();
			SymbolReference result = context.solveSymbol(name);
			
			return result;
		}
		if (typeDeclaration is JavaParserInterfaceDeclaration)
		{
			Context context = ((JavaParserInterfaceDeclaration)typeDeclaration).getContext();
			SymbolReference result2 = context.solveSymbol(name);
			
			return result2;
		}
		if (typeDeclaration is JavaParserEnumDeclaration)
		{
			Context context = ((JavaParserEnumDeclaration)typeDeclaration).getContext();
			SymbolReference result3 = context.solveSymbol(name);
			
			return result3;
		}
		if (typeDeclaration is ReflectionClassDeclaration)
		{
			SymbolReference result4 = ((ReflectionClassDeclaration)typeDeclaration).solveSymbol(name, typeSolver);
			
			return result4;
		}
		if (typeDeclaration is ReflectionInterfaceDeclaration)
		{
			SymbolReference result5 = ((ReflectionInterfaceDeclaration)typeDeclaration).solveSymbol(name, typeSolver);
			
			return result5;
		}
		if (typeDeclaration is ReflectionEnumDeclaration)
		{
			ResolvedEnumConstantDeclaration enumConstant = ((ReflectionEnumDeclaration)typeDeclaration).getEnumConstant(name);
			SymbolReference result6 = SymbolReference.solved(enumConstant);
			
			return result6;
		}
		if (typeDeclaration is JavassistClassDeclaration)
		{
			SymbolReference result7 = ((JavassistClassDeclaration)typeDeclaration).solveSymbol(name, typeSolver);
			
			return result7;
		}
		if (typeDeclaration is JavassistEnumDeclaration)
		{
			SymbolReference result8 = ((JavassistEnumDeclaration)typeDeclaration).solveSymbol(name, typeSolver);
			
			return result8;
		}
		if (typeDeclaration is JavassistInterfaceDeclaration)
		{
			SymbolReference result9 = ((JavassistInterfaceDeclaration)typeDeclaration).solveSymbol(name, typeSolver);
			
			return result9;
		}
		SymbolReference result10 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result10;
	}

	
	
	public virtual ResolvedTypeDeclaration solveType(com.github.javaparser.ast.type.Type type)
	{
		if (type is ClassOrInterfaceType)
		{
			string nameWithScope = ((ClassOrInterfaceType)type).getNameWithScope();
			SymbolReference symbolReference = JavaParserFactory.getContext(type, typeSolver).solveType(nameWithScope);
			if (!symbolReference.isSolved())
			{
				string name = java.lang.Object.instancehelper_toString(JavaParserFactory.getContext(type, typeSolver));
				
				throw new UnsolvedSymbolException(name, nameWithScope);
			}
			return (ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration();
		}
		string canonicalName = java.lang.Object.instancehelper_getClass(type).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveTypeInType(ResolvedTypeDeclaration typeDeclaration, string name)
	{
		if (typeDeclaration is JavaParserClassDeclaration)
		{
			SymbolReference result = ((JavaParserClassDeclaration)typeDeclaration).solveType(name);
			
			return result;
		}
		if (typeDeclaration is JavaParserInterfaceDeclaration)
		{
			SymbolReference result2 = ((JavaParserInterfaceDeclaration)typeDeclaration).solveType(name);
			
			return result2;
		}
		SymbolReference result3 = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		
		return result3;
	}

	
		
	public virtual SymbolReference solveSymbol(string name, Node node)
	{
		SymbolReference result = solveSymbol(name, JavaParserFactory.getContext(node, typeSolver));
		
		return result;
	}

	
		
	public virtual Optional solveSymbolAsValue(string name, Node node)
	{
		Context context = JavaParserFactory.getContext(node, typeSolver);
		Optional result = solveSymbolAsValue(name, context);
		
		return result;
	}

	
		
	public virtual SymbolReference solveSymbol(string name, Context context)
	{
		SymbolReference result = context.solveSymbol(name);
		
		return result;
	}

	
		
	public virtual Optional solveSymbolAsValue(string name, Context context)
	{
		Optional result = context.solveSymbolAsValue(name);
		
		return result;
	}

	
		
	public virtual SymbolReference solveType(string name, Context context)
	{
		SymbolReference result = context.solveType(name);
		
		return result;
	}

	
		
	public virtual MethodUsage solveMethod(string methodName, List argumentsTypes, Context context)
	{
		SymbolReference symbolReference = context.solveMethod(methodName, argumentsTypes, staticOnly: false);
		if (!symbolReference.isSolved())
		{
			string name = java.lang.Object.instancehelper_toString(context);
			
			throw new UnsolvedSymbolException(name, methodName);
		}
		MethodUsage result = new MethodUsage((ResolvedMethodDeclaration)symbolReference.getCorrespondingDeclaration());
		
		return result;
	}

	
		
	public virtual SymbolReference solveType(string name, Node node)
	{
		SymbolReference result = solveType(name, JavaParserFactory.getContext(node, typeSolver));
		
		return result;
	}

	
		
	public virtual MethodUsage solveMethod(string methodName, List argumentsTypes, Node node)
	{
		MethodUsage result = solveMethod(methodName, argumentsTypes, JavaParserFactory.getContext(node, typeSolver));
		
		return result;
	}

	
	
	public virtual ResolvedType solveTypeUsage(string name, Context context)
	{
		Optional optional = context.solveGenericType(name);
		if (optional.isPresent())
		{
			return (ResolvedType)optional.get();
		}
		ResolvedReferenceTypeDeclaration typeDeclaration = typeSolver.solveType(name);
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeSolver);
		
		return result;
	}
}
