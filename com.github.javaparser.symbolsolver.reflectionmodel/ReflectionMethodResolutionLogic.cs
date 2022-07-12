
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;

internal class ReflectionMethodResolutionLogic
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly bool arg_00241;

		internal ___003C_003EAnon0(bool P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00240(arg_00241, (Method)P_0);
			
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon2(string P_0, List P_1, bool P_2, List P_3)
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

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon3(string P_0, List P_1, bool P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			lambda_0024solveMethod_00242(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly ResolvedReferenceTypeDeclaration arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon4(ResolvedReferenceTypeDeclaration P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = lambda_0024solveMethodAsUsage_00243(arg_00241, arg_00242, (ResolvedType)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private static CallerID ___003CcallerID_003E;

	
		
	internal static Optional solveMethodAsUsage(string P_0, List P_1, TypeSolver P_2, Context P_3, List P_4, ResolvedReferenceTypeDeclaration P_5, Class P_6)
	{
		object obj = P_4;
		if (((List)obj).size() != P_5.getTypeParameters().size() && !P_5.getTypeParameters().isEmpty())
		{
			obj = new ArrayList();
			for (int i = 0; i < P_5.getTypeParameters().size(); i++)
			{
				ArrayList obj2 = (ArrayList)obj;
				ReferenceTypeImpl.___003Cclinit_003E();
				((List)obj2).add((object)new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, P_2), P_2));
			}
		}
		ArrayList arrayList = new ArrayList();
		Method[] methods = P_6.getMethods(ReflectionMethodResolutionLogic.___003CGetCallerID_003E());
		int num = methods.Length;
		for (int j = 0; j < num; j++)
		{
			Method method = methods[j];
			if (String.instancehelper_equals(method.getName(), P_0) && !method.isBridge() && !method.isSynthetic())
			{
				ReflectionMethodDeclaration reflectionMethodDeclaration = new ReflectionMethodDeclaration(method, P_2);
				object obj3 = obj;
				ResolvedMethodDeclaration resolvedMethodDeclaration = reflectionMethodDeclaration;
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = P_5;
				MethodUsage e = replaceParams((obj3 == null) ? null : ((obj3 as List) ?? throw new java.lang.IncompatibleClassChangeError()), resolvedReferenceTypeDeclaration, resolvedMethodDeclaration);
				((List)arrayList).add((object)e);
			}
		}
		Iterator iterator = P_5.getAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (resolvedReferenceType.getTypeDeclaration().isPresent())
			{
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration2 = (ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().get();
				SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(resolvedReferenceTypeDeclaration2, P_0, P_1);
				if (symbolReference.isSolved())
				{
					ResolvedMethodDeclaration resolvedMethodDeclaration2 = (ResolvedMethodDeclaration)symbolReference.getCorrespondingDeclaration();
					object obj4 = obj;
					ResolvedMethodDeclaration resolvedMethodDeclaration = resolvedMethodDeclaration2;
					ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = resolvedReferenceTypeDeclaration2;
					MethodUsage e = replaceParams((obj4 == null) ? null : ((obj4 as List) ?? throw new java.lang.IncompatibleClassChangeError()), resolvedReferenceTypeDeclaration, resolvedMethodDeclaration);
					((List)arrayList).add((object)e);
				}
			}
		}
		if (P_5.getAncestors().isEmpty())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			Optional typeDeclaration = new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, P_2), P_2).getTypeDeclaration();
			if (typeDeclaration.isPresent())
			{
				SymbolReference symbolReference2 = MethodResolutionLogic.solveMethodInType((ResolvedTypeDeclaration)typeDeclaration.get(), P_0, P_1);
				if (symbolReference2.isSolved())
				{
					object obj5 = obj;
					ResolvedReferenceTypeDeclaration obj6 = (ResolvedReferenceTypeDeclaration)typeDeclaration.get();
					ResolvedMethodDeclaration resolvedMethodDeclaration = (ResolvedMethodDeclaration)symbolReference2.getCorrespondingDeclaration();
					ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = obj6;
					MethodUsage e2 = replaceParams((obj5 == null) ? null : ((obj5 as List) ?? throw new java.lang.IncompatibleClassChangeError()), resolvedReferenceTypeDeclaration, resolvedMethodDeclaration);
					((List)arrayList).add((object)e2);
				}
			}
		}
		object obj7 = obj;
		P_1 = (List)P_1.stream().map(new ___003C_003EAnon4(P_5, (obj7 == null) ? null : ((obj7 as List) ?? throw new java.lang.IncompatibleClassChangeError()))).collect(Collectors.toList());
		Optional result = MethodResolutionLogic.findMostApplicableUsage(arrayList, P_0, P_1, P_2);
		
		return result;
	}

	
		
	internal static SymbolReference solveMethod(string P_0, List P_1, bool P_2, TypeSolver P_3, ResolvedReferenceTypeDeclaration P_4, Class P_5)
	{
		ArrayList arrayList = new ArrayList();
		Predicate predicate = new ___003C_003EAnon0(P_2);
		Method[] methods = P_5.getMethods(ReflectionMethodResolutionLogic.___003CGetCallerID_003E());
		int num = methods.Length;
		for (int i = 0; i < num; i++)
		{
			Method method = methods[i];
			if (!method.isBridge() && !method.isSynthetic() && String.instancehelper_equals(method.getName(), P_0) && predicate.test(method))
			{
				ReflectionMethodDeclaration e = new ReflectionMethodDeclaration(method, P_3);
				((List)arrayList).add((object)e);
			}
		}
		Iterator iterator = P_4.getAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon2(P_0, P_1, P_2, arrayList));
		}
		if (P_4.getAncestors().isEmpty())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl referenceTypeImpl = new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, P_3), P_3);
			referenceTypeImpl.getTypeDeclaration().ifPresent(new ___003C_003EAnon3(P_0, P_1, P_2, arrayList));
		}
		SymbolReference result = MethodResolutionLogic.findMostApplicable(arrayList, P_0, P_1, P_3);
		
		return result;
	}

	
		
	private static MethodUsage replaceParams(List P_0, ResolvedReferenceTypeDeclaration P_1, ResolvedMethodDeclaration P_2)
	{
		MethodUsage methodUsage = new MethodUsage(P_2);
		int num = 0;
		Iterator iterator;
		if (P_0.size() == P_1.getTypeParameters().size())
		{
			iterator = P_1.getTypeParameters().iterator();
			while (iterator.hasNext())
			{
				ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)iterator.next();
				methodUsage = methodUsage.replaceTypeParameter(typeParameter, (ResolvedType)P_0.get(num));
				num++;
			}
		}
		iterator = P_2.getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)iterator.next();
			methodUsage = methodUsage.replaceTypeParameter(typeParameter, new ResolvedTypeVariable(typeParameter));
		}
		return methodUsage;
	}

	
	
	
	private static bool lambda_0024solveMethod_00240(bool P_0, Method P_1)
	{
		return (!P_0 || (P_0 && Modifier.isStatic(P_1.getModifiers()))) ? true : false;
	}

	
	
	
	private static void lambda_0024solveMethod_00241(string P_0, List P_1, bool P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(P_4, P_0, P_1, P_2);
		if (symbolReference.isSolved())
		{
			P_3.add(symbolReference.getCorrespondingDeclaration());
		}
	}

	
	
	
	private static void lambda_0024solveMethod_00242(string P_0, List P_1, bool P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(P_4, P_0, P_1, P_2);
		if (symbolReference.isSolved())
		{
			P_3.add(symbolReference.getCorrespondingDeclaration());
		}
	}

	
	
	
	private static ResolvedType lambda_0024solveMethodAsUsage_00243(ResolvedReferenceTypeDeclaration P_0, List P_1, ResolvedType P_2)
	{
		int num = 0;
		Iterator iterator = P_0.getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)iterator.next();
			P_2 = P_2.replaceTypeVariables(tp, (ResolvedType)P_1.get(num));
			num++;
		}
		return P_2;
	}

	
	
	internal ReflectionMethodResolutionLogic()
	{
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
