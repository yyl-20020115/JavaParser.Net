using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class AnonymousClassDeclarationContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : java.util.function.Predicate
	{
		private readonly string arg_00241;

		private readonly bool arg_00242;

		internal ___003C_003EAnon0(string P_0, bool P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00240(arg_00241, arg_00242, (ResolvedMethodDeclaration)P_0);
			
			return result;
		}

		
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon1(string P_0, List P_1, bool P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			lambda_0024solveMethod_00241(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : java.util.function.Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveMethod_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : java.util.function.Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveType_00243(arg_00241, (TypeDeclaration)P_0);
			
			return result;
		}

		
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : java.util.function.Function
	{
		private readonly AnonymousClassDeclarationContext arg_00241;

		internal ___003C_003EAnon4(AnonymousClassDeclarationContext P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			SymbolReference result = arg_00241.lambda_0024solveType_00244((TypeDeclaration)P_0);
			
			return result;
		}

		
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : java.util.function.Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon5(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveType_00245(arg_00241, (TypeDeclaration)P_0);
			
			return result;
		}

		
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : java.util.function.Function
	{
		private readonly AnonymousClassDeclarationContext arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon6(AnonymousClassDeclarationContext P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			SymbolReference result = arg_00241.lambda_0024solveType_00246(arg_00242, (TypeDeclaration)P_0);
			
			return result;
		}

		
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : java.util.function.Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			NodeList result = lambda_0024solveType_00247((NodeList)P_0);
			
			return result;
		}

		
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : java.util.function.Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon8(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveType_00248(arg_00241, (Type)P_0);
			
			return result;
		}

		
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : java.util.function.Function
	{
		private readonly AnonymousClassDeclarationContext arg_00241;

		internal ___003C_003EAnon9(AnonymousClassDeclarationContext P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			SymbolReference result = arg_00241.lambda_0024solveType_00249((Type)P_0);
			
			return result;
		}

		
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private JavaParserAnonymousClassDeclaration myDeclaration;

	
	
	
	private static bool lambda_0024solveMethod_00240(string P_0, bool P_1, ResolvedMethodDeclaration P_2)
	{
		return (String.instancehelper_equals(P_2.getName(), P_0) && (!P_1 || P_2.isStatic())) ? true : false;
	}

	
	
	
	private static void lambda_0024solveMethod_00241(string P_0, List P_1, bool P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(P_4, P_0, P_1, P_2);
		if (symbolReference.isSolved())
		{
			P_3.add(symbolReference.getCorrespondingDeclaration());
		}
	}

	
	
	
	private static RuntimeException lambda_0024solveMethod_00242()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveType_00243(string P_0, TypeDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName().getId(), P_0);
		
		return result;
	}

	
	
	
	private SymbolReference lambda_0024solveType_00244(TypeDeclaration P_0)
	{
		SymbolReference result = SymbolReference.solved(JavaParserFacade.get(typeSolver).getTypeDeclaration(P_0));
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveType_00245(string P_0, TypeDeclaration P_1)
	{
		bool result = String.instancehelper_startsWith(P_0, String.format("%s.", P_1.getName()));
		
		return result;
	}

	
	
	
	private SymbolReference lambda_0024solveType_00246(string P_0, TypeDeclaration P_1)
	{
		SymbolReference result = JavaParserFactory.getContext(P_1, typeSolver).solveType(String.instancehelper_substring(P_0, String.instancehelper_length(P_1.getName().getId()) + 1));
		
		return result;
	}

	
	
	
	private static NodeList lambda_0024solveType_00247(NodeList P_0)
	{
		return (NodeList)((NodeWithTypeArguments)P_0).getTypeArguments().orElse(new NodeList());
	}

	
	
	
	private static bool lambda_0024solveType_00248(string P_0, Type P_1)
	{
		bool result = String.instancehelper_equals(P_1.ToString(), P_0);
		
		return result;
	}

	
	
	
	private SymbolReference lambda_0024solveType_00249(Type P_0)
	{
		TypeParameter.___003Cclinit_003E();
		SymbolReference result = SymbolReference.solved(new JavaParserTypeParameter(new TypeParameter(P_0.ToString()), typeSolver));
		
		return result;
	}

	
	
	public AnonymousClassDeclarationContext(ObjectCreationExpr node, TypeSolver typeSolver)
		: base(node, typeSolver)
	{
		myDeclaration = new JavaParserAnonymousClassDeclaration((ObjectCreationExpr)wrappedNode, base.typeSolver);
		Preconditions.checkArgument(node.getAnonymousClassBody().isPresent(), (object)"An anonymous class must have a body");
	}

	
		[LineNumberTable(new byte[]
	{
		159, 126, 162, 102, 101, 113, 101, 144, 109, 127,
		6, 249, 79, 226, 69, 104, 97, 111, 109, 103,
		105, 238, 69, 122, 115, 231, 69, 105, 206
	})]
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		List list = (List)myDeclaration.getDeclaredMethods().stream().filter(new ___003C_003EAnon0(name, staticOnly))
			.collect(Collectors.toList());
		if (!myDeclaration.isJavaLangObject())
		{
			Iterator iterator = myDeclaration.getAncestors().iterator();
			while (iterator.hasNext())
			{
				ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
				resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon1(name, argumentsTypes, staticOnly, list));
			}
		}
		if (list.isEmpty())
		{
			SymbolReference symbolReference = ((Context)getParent().orElseThrow(new ___003C_003EAnon2())).solveMethod(name, argumentsTypes, staticOnly);
			if (symbolReference.isSolved())
			{
				list.add(symbolReference.getCorrespondingDeclaration());
			}
		}
		if (list.isEmpty() && myDeclaration.getSuperTypeDeclaration().isInterface())
		{
			SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, typeSolver), name, argumentsTypes, staticOnly: false);
			if (symbolReference.isSolved())
			{
				list.add(symbolReference.getCorrespondingDeclaration());
			}
		}
		SymbolReference result = MethodResolutionLogic.findMostApplicable(list, name, argumentsTypes, typeSolver);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		76, 145, 129, 112, 101, 112, 198, 104, 172, 129,
		112, 101, 113, 230, 69, 104, 172, 139, 111, 170,
		106, 112, 101, 112, 230, 69, 104, 204, 159, 13,
		105, 108, 110, 111, 200, 127, 6, 111, 139, 174,
		2, 193, 133
	})]
	public override SymbolReference solveType(string name)
	{
		List list = myDeclaration.findMembersOfKind(ClassLiteral<TypeDeclaration>.Value);
		java.util.Optional optional = list.stream().filter(new ___003C_003EAnon3(name)).findFirst()
			.map(new ___003C_003EAnon4(this));
		if (optional.isPresent())
		{
			return (SymbolReference)optional.get();
		}
		java.util.Optional optional2 = list.stream().filter(new ___003C_003EAnon5(name)).findFirst()
			.map(new ___003C_003EAnon6(this, name));
		if (optional2.isPresent())
		{
			return (SymbolReference)optional2.get();
		}
		java.util.Optional optional3 = ((NodeList)((ObjectCreationExpr)wrappedNode).getTypeArguments().map(new ___003C_003EAnon7()).orElse(new NodeList())).stream().filter(new ___003C_003EAnon8(name)).findFirst()
			.map(new ___003C_003EAnon9(this));
		if (optional3.isPresent())
		{
			return (SymbolReference)optional3.get();
		}
		Iterator iterator = myDeclaration.getAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			java.util.Optional typeDeclaration = resolvedReferenceType.getTypeDeclaration();
			if (!typeDeclaration.isPresent())
			{
				continue;
			}
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)typeDeclaration.get();
			if (String.instancehelper_equals(resolvedReferenceTypeDeclaration.getName(), name))
			{
				return SymbolReference.solved(resolvedReferenceTypeDeclaration);
			}
			try
			{
				Iterator iterator2 = resolvedReferenceTypeDeclaration.internalTypes().iterator();
				while (iterator2.hasNext())
				{
					ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)iterator2.next();
					if (String.instancehelper_equals(resolvedTypeDeclaration.getName(), name))
					{
						return SymbolReference.solved(resolvedTypeDeclaration);
					}
				}
			}
			catch (UnsupportedOperationException)
			{
				goto IL_01af;
			}
			continue;
		IL_01af:
			;
			
		}
		return solveTypeInParentContext(name);
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		Preconditions.checkArgument(typeSolver != null);
		if (myDeclaration.hasField(name))
		{
			SymbolReference result = SymbolReference.solved(myDeclaration.getField(name));
			
			return result;
		}
		SymbolReference result2 = solveSymbolInParentContext(name);
		
		return result2;
	}
}
