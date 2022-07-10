using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.logic;

public class FunctionalInterfaceLogic
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getFunctionalMethod_00240((MethodUsage)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getFunctionalMethod_00241((MethodUsage)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024getSignature_00242((Parameter)P_0);
			
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon4 : Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024static_00243((Method)P_0);
			
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

	private static string JAVA_LANG_FUNCTIONAL_INTERFACE;

		private static List OBJECT_METHODS_SIGNATURES;

	
	private static CallerID ___003CcallerID_003E;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	public static Optional getFunctionalMethod(ResolvedType type)
	{
		Optional typeDeclaration = type.asReferenceType().getTypeDeclaration();
		if (!typeDeclaration.isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)typeDeclaration.get();
		if (type.isReferenceType() && resolvedReferenceTypeDeclaration.isInterface())
		{
			Optional functionalMethod = getFunctionalMethod(resolvedReferenceTypeDeclaration);
			
			return functionalMethod;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public static Optional getFunctionalMethod(ResolvedReferenceTypeDeclaration typeDeclaration)
	{
		Set set = (Set)typeDeclaration.getAllMethods().stream().filter(new ___003C_003EAnon0())
			.filter(new ___003C_003EAnon1())
			.collect(Collectors.toSet());
		if (set.size() == 1)
		{
			Optional result = Optional.of(set.iterator().next());
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	private static string getSignature(Method P_0)
	{
		object[] obj = new object[2]
		{
			P_0.getName(),
			null
		};
		Iterable elements = (Iterable)Arrays.stream(P_0.getParameters()).map(new ___003C_003EAnon2()).collect(Collectors.toList());
		CharSequence delimiter = default(CharSequence);
		object obj2 = (delimiter.___003Cref_003E = ", ");
		obj[1] = String.join(delimiter, elements);
		string result = String.format("%s(%s)", obj);
		
		return result;
	}

	
	
	private static string toSignature(Parameter P_0)
	{
		string canonicalName = P_0.getType().getCanonicalName();
		
		return canonicalName;
	}

	
	
	private static bool declaredOnObject(MethodUsage P_0)
	{
		bool result = OBJECT_METHODS_SIGNATURES.contains(P_0.getDeclaration().getSignature());
		
		return result;
	}

	
	
	
	private static bool lambda_0024getFunctionalMethod_00240(MethodUsage P_0)
	{
		bool result = P_0.getDeclaration().isAbstract();
		
		return result;
	}

	
	
	
	private static bool lambda_0024getFunctionalMethod_00241(MethodUsage P_0)
	{
		return (!declaredOnObject(P_0)) ? true : false;
	}

	
	
	
	private static string lambda_0024getSignature_00242(Parameter P_0)
	{
		string result = toSignature(P_0);
		
		return result;
	}

	
	
	
	private static string lambda_0024static_00243(Method P_0)
	{
		string signature = getSignature(P_0);
		
		return signature;
	}

	
	
	private FunctionalInterfaceLogic()
	{
	}

	
	
	public static bool isFunctionalInterfaceType(ResolvedType type)
	{
		if (type.isReferenceType())
		{
			Optional typeDeclaration = type.asReferenceType().getTypeDeclaration();
			if (typeDeclaration.isPresent() && ((ResolvedReferenceTypeDeclaration)typeDeclaration.get()).hasAnnotation(JAVA_LANG_FUNCTIONAL_INTERFACE))
			{
				return true;
			}
		}
		bool result = getFunctionalMethod(type).isPresent();
		
		return result;
	}

	
	static FunctionalInterfaceLogic()
	{
		JAVA_LANG_FUNCTIONAL_INTERFACE = ClassLiteral<FunctionalInterface>.Value.getCanonicalName();
		OBJECT_METHODS_SIGNATURES = (List)Arrays.stream(ClassLiteral<Object>.Value.getDeclaredMethods(FunctionalInterfaceLogic.___003CGetCallerID_003E())).map(new ___003C_003EAnon4()).collect(Collectors.toList());
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
