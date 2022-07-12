
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class JavaParserTypeDeclarationAdapter
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveType_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		internal ___003C_003EAnon1()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveType_00241();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveType_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024checkAncestorsForType_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon4(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00244(arg_00241, (ResolvedMethodDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		private readonly bool arg_00241;

		internal ___003C_003EAnon5(bool P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00245(arg_00241, (ResolvedMethodDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon6(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00246(arg_00241, (ResolvedMethodDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Supplier
	{
		internal ___003C_003EAnon7()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveMethod_00247();
			
			return result;
		}
	}

		private TypeDeclaration wrappedNode;

	private TypeSolver typeSolver;

	private Context context;

	private ResolvedReferenceTypeDeclaration typeDeclaration;

	
		
	public JavaParserTypeDeclarationAdapter(TypeDeclaration wrappedNode, TypeSolver typeSolver, ResolvedReferenceTypeDeclaration typeDeclaration, Context context)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
		this.typeDeclaration = typeDeclaration;
		this.context = context;
	}

	
		
	public virtual SymbolReference solveType(string name)
	{
		if (String.instancehelper_equals(wrappedNode.getName().getId(), name))
		{
			SymbolReference result = SymbolReference.solved(JavaParserFacade.get(typeSolver).getTypeDeclaration(wrappedNode));
			
			return result;
		}
		Iterator iterator = wrappedNode.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is TypeDeclaration)
			{
				TypeDeclaration typeDeclaration = (TypeDeclaration)bodyDeclaration;
				if (String.instancehelper_equals(typeDeclaration.getName().getId(), name))
				{
					SymbolReference result2 = SymbolReference.solved(JavaParserFacade.get(typeSolver).getTypeDeclaration(typeDeclaration));
					
					return result2;
				}
				if (String.instancehelper_startsWith(name, new StringBuilder().append(wrappedNode.getName().getId()).append(".").append(typeDeclaration.getName().getId())
					.ToString()))
				{
					SymbolReference result3 = JavaParserFactory.getContext(typeDeclaration, typeSolver).solveType(String.instancehelper_substring(name, String.instancehelper_length(wrappedNode.getName().getId()) + 1));
					
					return result3;
				}
				if (String.instancehelper_startsWith(name, new StringBuilder().append(typeDeclaration.getName().getId()).append(".").ToString()))
				{
					SymbolReference result4 = JavaParserFactory.getContext(typeDeclaration, typeSolver).solveType(String.instancehelper_substring(name, String.instancehelper_length(typeDeclaration.getName().getId()) + 1));
					
					return result4;
				}
			}
		}
		if (wrappedNode is NodeWithTypeParameters)
		{
			NodeWithTypeParameters nodeWithTypeParameters = (NodeWithTypeParameters)wrappedNode;
			Iterator iterator2 = nodeWithTypeParameters.getTypeParameters().iterator();
			while (iterator2.hasNext())
			{
				TypeParameter typeParameter = (TypeParameter)iterator2.next();
				TypeParameter typeParameter2 = typeParameter;
				if (String.instancehelper_equals(typeParameter2.getName().getId(), name))
				{
					SymbolReference result5 = SymbolReference.solved(new JavaParserTypeParameter(typeParameter2, typeSolver));
					
					return result5;
				}
			}
		}
		if (wrappedNode is NodeWithImplements)
		{
			NodeWithImplements nodeWithImplements = (NodeWithImplements)wrappedNode;
			Iterator iterator2 = nodeWithImplements.getImplementedTypes().iterator();
			while (iterator2.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator2.next();
				if (String.instancehelper_equals(classOrInterfaceType.getName().getId(), name))
				{
					SymbolReference result6 = ((Context)context.getParent().orElseThrow(new ___003C_003EAnon0())).solveType(classOrInterfaceType.getNameWithScope());
					
					return result6;
				}
			}
		}
		if (wrappedNode is NodeWithExtends)
		{
			NodeWithExtends nodeWithExtends = (NodeWithExtends)wrappedNode;
			Iterator iterator2 = nodeWithExtends.getExtendedTypes().iterator();
			while (iterator2.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator2.next();
				if (String.instancehelper_equals(classOrInterfaceType.getName().getId(), name))
				{
					SymbolReference result7 = ((Context)context.getParent().orElseThrow(new ___003C_003EAnon1())).solveType(classOrInterfaceType.getNameWithScope());
					
					return result7;
				}
			}
		}
		ResolvedTypeDeclaration resolvedTypeDeclaration = checkAncestorsForType(name, this.typeDeclaration);
		if (resolvedTypeDeclaration != null)
		{
			SymbolReference result8 = SymbolReference.solved(resolvedTypeDeclaration);
			
			return result8;
		}
		SymbolReference result9 = ((Context)context.getParent().orElseThrow(new ___003C_003EAnon2())).solveType(name);
		
		return result9;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		List list = (List)typeDeclaration.getDeclaredMethods().stream().filter(new ___003C_003EAnon4(name))
			.filter(new ___003C_003EAnon5(staticOnly))
			.collect(Collectors.toList());
		if (!typeDeclaration.isJavaLangObject())
		{
			Iterator iterator = typeDeclaration.getAncestors(acceptIncompleteList: true).iterator();
			while (iterator.hasNext())
			{
				ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
				Optional optional = resolvedReferenceType.getTypeDeclaration();
				if (resolvedReferenceType.getTypeDeclaration().isPresent() && typeDeclaration != optional.get())
				{
					list.addAll((Collection)resolvedReferenceType.getAllMethodsVisibleToInheritors().stream().filter(new ___003C_003EAnon6(name))
						.collect(Collectors.toList()));
					SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType((ResolvedTypeDeclaration)optional.get(), name, argumentsTypes, staticOnly);
					if (symbolReference.isSolved())
					{
						list.add(symbolReference.getCorrespondingDeclaration());
					}
				}
			}
		}
		if (list.isEmpty())
		{
			SymbolReference symbolReference2 = ((Context)context.getParent().orElseThrow(new ___003C_003EAnon7())).solveMethod(name, argumentsTypes, staticOnly);
			if (symbolReference2.isSolved())
			{
				list.add(symbolReference2.getCorrespondingDeclaration());
			}
		}
		if (list.isEmpty() && typeDeclaration.isInterface())
		{
			SymbolReference symbolReference2 = MethodResolutionLogic.solveMethodInType(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, typeSolver), name, argumentsTypes, staticOnly: false);
			if (symbolReference2.isSolved())
			{
				list.add(symbolReference2.getCorrespondingDeclaration());
			}
		}
		SymbolReference result = MethodResolutionLogic.findMostApplicable(list, name, argumentsTypes, typeSolver);
		
		return result;
	}

	
		
	public virtual SymbolReference solveConstructor(List argumentsTypes)
	{
		if (typeDeclaration is ResolvedClassDeclaration)
		{
			SymbolReference result = ConstructorResolutionLogic.findMostApplicable(typeDeclaration.getConstructors(), argumentsTypes, typeSolver);
			
			return result;
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedConstructorDeclaration>.Value);
		
		return result2;
	}

	
	
	private ResolvedTypeDeclaration checkAncestorsForType(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		//Discarded unreachable code: IL_00d0
		Iterator iterator = P_1.getAncestors(acceptIncompleteList: true).iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			try
			{
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().orElseThrow(new ___003C_003EAnon3());
				Iterator iterator2 = resolvedReferenceTypeDeclaration.internalTypes().iterator();
				while (iterator2.hasNext())
				{
					ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)iterator2.next();
					int num = 1;
					if (resolvedTypeDeclaration is ResolvedReferenceTypeDeclaration)
					{
						ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration2 = resolvedTypeDeclaration.asReferenceType();
						if (resolvedReferenceTypeDeclaration2 is HasAccessSpecifier)
						{
							num = ((((HasAccessSpecifier)resolvedReferenceTypeDeclaration2).accessSpecifier() != AccessSpecifier.___003C_003EPRIVATE) ? 1 : 0);
						}
					}
					if (String.instancehelper_equals(resolvedTypeDeclaration.getName(), P_0))
					{
						if (num != 0)
						{
							return resolvedTypeDeclaration;
						}
						return null;
					}
				}
				ResolvedTypeDeclaration resolvedTypeDeclaration2 = checkAncestorsForType(P_0, resolvedReferenceTypeDeclaration);
				if (resolvedTypeDeclaration2 != null)
				{
					return resolvedTypeDeclaration2;
				}
			}
			catch (UnsupportedOperationException)
			{
				goto IL_00e4;
			}
			continue;
		IL_00e4:
			;
			
		}
		return null;
	}

	
	
	
	private static RuntimeException lambda_0024solveType_00240()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024solveType_00241()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024solveType_00242()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024checkAncestorsForType_00243()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveMethod_00244(string P_0, ResolvedMethodDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveMethod_00245(bool P_0, ResolvedMethodDeclaration P_1)
	{
		return (!P_0 || P_1.isStatic()) ? true : false;
	}

	
	
	
	private static bool lambda_0024solveMethod_00246(string P_0, ResolvedMethodDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024solveMethod_00247()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}
}
