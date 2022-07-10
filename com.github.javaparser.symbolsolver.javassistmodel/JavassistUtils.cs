using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;
using javassist;
using javassist.bytecode;

namespace com.github.javaparser.symbolsolver.javassistmodel;

internal class JavassistUtils
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon0(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024solveMethodAsUsage_00240(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly Context arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon1(string P_0, List P_1, Context P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024solveMethodAsUsage_00241(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((MethodUsage)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly bool arg_00241;

		internal ___003C_003EAnon3(bool P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00242(arg_00241, (CtMethod)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly TypeSolver arg_00241;

		private readonly ResolvedTypeParametrizable arg_00242;

		internal ___003C_003EAnon4(TypeSolver P_0, ResolvedTypeParametrizable P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = lambda_0024signatureTypeToType_00243(arg_00241, arg_00242, (javassist.bytecode.SignatureAttribute.TypeArgument)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			ResolvedType result = new ResolvedTypeVariable((ResolvedTypeParameterDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Supplier
	{
		private readonly TypeSolver arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon6(TypeSolver P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			ResolvedType result = lambda_0024getGenericParameterByName_00244(arg_00241, arg_00242);
			
			return result;
		}
	}

	
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedType;>;Lcom/github/javaparser/symbolsolver/model/resolution/TypeSolver;Lcom/github/javaparser/symbolsolver/core/resolution/Context;Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedType;>;Lcom/github/javaparser/resolution/declarations/ResolvedReferenceTypeDeclaration;Ljavassist/CtClass;)Ljava/util/Optional<Lcom/github/javaparser/resolution/MethodUsage;>;")]
	[LineNumberTable(new byte[]
	{
		21, 136, 102, 124, 116, 116, 117, 111, 120, 111,
		112, 237, 61, 232, 69, 169, 113, 234, 50, 235,
		83, 127, 6, 115, 116, 122, 101, 130
	})]
	internal unsafe static Optional solveMethodAsUsage(string P_0, List P_1, TypeSolver P_2, Context P_3, List P_4, ResolvedReferenceTypeDeclaration P_5, CtClass P_6)
	{
		List typeParameters = P_5.getTypeParameters();
		ArrayList arrayList = new ArrayList();
		CtMethod[] declaredMethods = P_6.getDeclaredMethods();
		int num = declaredMethods.Length;
		for (int i = 0; i < num; i++)
		{
			CtMethod ctMethod = declaredMethods[i];
			if (String.instancehelper_equals(ctMethod.getName(), P_0) && (ctMethod.getMethodInfo().getAccessFlags() & 0x40) == 0 && (ctMethod.getMethodInfo().getAccessFlags() & 0x1000) == 0)
			{
				MethodUsage methodUsage = new MethodUsage(new JavassistMethodDeclaration(ctMethod, P_2));
				for (int j = 0; j < typeParameters.size() && j < P_4.size(); j++)
				{
					ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)typeParameters.get(j);
					ResolvedType type = (ResolvedType)P_4.get(j);
					methodUsage = methodUsage.replaceTypeParameter(typeParameter, type);
				}
				((List)arrayList).add((object)methodUsage);
				if (P_1.isEmpty() && methodUsage.getNoParams() == 0)
				{
					Optional result = Optional.of(methodUsage);
					
					return result;
				}
			}
		}
		Iterator iterator = P_5.getAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			Optional optional = resolvedReferenceType.getTypeDeclaration().flatMap(new ___003C_003EAnon0(resolvedReferenceType)).flatMap(new ___003C_003EAnon1(P_0, P_1, P_3, P_4));
			
			optional.ifPresent(new ___003C_003EAnon2(arrayList));
		}
		Optional result2 = MethodResolutionLogic.findMostApplicableUsage(arrayList, P_0, P_1, P_2);
		
		return result2;
	}

	
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedType;>;ZLcom/github/javaparser/symbolsolver/model/resolution/TypeSolver;Lcom/github/javaparser/resolution/declarations/ResolvedReferenceTypeDeclaration;Ljavassist/CtClass;)Lcom/github/javaparser/symbolsolver/model/resolution/SymbolReference<Lcom/github/javaparser/resolution/declarations/ResolvedMethodDeclaration;>;")]
	[LineNumberTable(new byte[]
	{
		159, 116, 98, 102, 108, 126, 121, 119, 127, 2,
		106, 169, 113, 234, 55, 235, 79, 127, 6, 105,
		105, 98, 45, 231, 70, 105, 238, 69, 130
	})]
	internal static SymbolReference solveMethod(string P_0, List P_1, bool P_2, TypeSolver P_3, ResolvedReferenceTypeDeclaration P_4, CtClass P_5)
	{
		ArrayList arrayList = new ArrayList();
		Predicate predicate = new ___003C_003EAnon3(P_2);
		CtMethod[] declaredMethods = P_5.getDeclaredMethods();
		int num = declaredMethods.Length;
		for (int i = 0; i < num; i++)
		{
			CtMethod ctMethod = declaredMethods[i];
			int num2 = ((ctMethod.getMethodInfo().getAttribute("Synthetic") != null) ? 1 : 0);
			int num3 = (((ctMethod.getMethodInfo().getAccessFlags() & 0x40) == 0) ? 1 : 0);
			if (String.instancehelper_equals(ctMethod.getName(), P_0) && num2 == 0 && num3 != 0 && predicate.test(ctMethod))
			{
				JavassistMethodDeclaration javassistMethodDeclaration = new JavassistMethodDeclaration(ctMethod, P_3);
				((List)arrayList).add((object)javassistMethodDeclaration);
				if (P_1.isEmpty() && ((ResolvedMethodLikeDeclaration)javassistMethodDeclaration).getNumberOfParams() == 0)
				{
					SymbolReference result = SymbolReference.solved(javassistMethodDeclaration);
					
					return result;
				}
			}
		}
		Iterator iterator = P_4.getAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			Optional typeDeclaration = resolvedReferenceType.getTypeDeclaration();
			if (typeDeclaration.isPresent())
			{
				SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType((ResolvedTypeDeclaration)typeDeclaration.get(), P_0, P_1, P_2);
				if (symbolReference.isSolved())
				{
					((List)arrayList).add((object)symbolReference.getCorrespondingDeclaration());
				}
			}
		}
		SymbolReference result2 = MethodResolutionLogic.findMostApplicable(arrayList, P_0, P_1, P_3);
		
		return result2;
	}

	
	[LineNumberTable(new byte[]
	{
		93, 107, 103, 127, 28, 98, 47, 134, 107, 104,
		103, 110, 105, 159, 6, 110, 106, 104, 104, 112,
		113, 104, 104, 115, 134, 175
	})]
	internal static ResolvedType signatureTypeToType(javassist.bytecode.SignatureAttribute.Type P_0, TypeSolver P_1, ResolvedTypeParametrizable P_2)
	{
		if (P_0 is javassist.bytecode.SignatureAttribute.ClassType)
		{
			javassist.bytecode.SignatureAttribute.ClassType classType = (javassist.bytecode.SignatureAttribute.ClassType)P_0;
			List typeArguments = ((classType.getTypeArguments() != null) ? ((List)Arrays.stream(classType.getTypeArguments()).map(new ___003C_003EAnon4(P_1, P_2)).collect(Collectors.toList())) : Collections.emptyList());
			ResolvedReferenceTypeDeclaration typeDeclaration = P_1.solveType(removeTypeArguments(internalNameToCanonicalName(getTypeName(classType))));
			ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeArguments, P_1);
			
			return result;
		}
		if (P_0 is javassist.bytecode.SignatureAttribute.TypeVariable)
		{
			javassist.bytecode.SignatureAttribute.TypeVariable typeVariable = (javassist.bytecode.SignatureAttribute.TypeVariable)P_0;
			Optional optional = P_2.findTypeParameter(typeVariable.getName());
			if (!optional.isPresent())
			{
				string name = new StringBuilder().append("Unable to solve TypeVariable ").append(typeVariable).ToString();
				
				throw new UnsolvedSymbolException(name);
			}
			ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)optional.get();
			ResolvedTypeVariable result2 = new ResolvedTypeVariable(typeParameter);
			
			return result2;
		}
		if (P_0 is javassist.bytecode.SignatureAttribute.ArrayType)
		{
			javassist.bytecode.SignatureAttribute.ArrayType arrayType = (javassist.bytecode.SignatureAttribute.ArrayType)P_0;
			ResolvedType resolvedType = signatureTypeToType(arrayType.getComponentType(), P_1, P_2);
			ResolvedType arrayType2 = getArrayType(resolvedType, arrayType.getDimension());
			
			return arrayType2;
		}
		if (P_0 is javassist.bytecode.SignatureAttribute.BaseType)
		{
			javassist.bytecode.SignatureAttribute.BaseType baseType = (javassist.bytecode.SignatureAttribute.BaseType)P_0;
			if (String.instancehelper_equals(baseType.ToString(), "void"))
			{
				return ResolvedVoidType.___003C_003EINSTANCE;
			}
			ResolvedType result3 = ResolvedPrimitiveType.byName(baseType.ToString());
			
			return result3;
		}
		string canonicalName = Object.instancehelper_getClass(P_0).getCanonicalName();
		
		throw new RuntimeException(canonicalName);
	}

	
	[IKVM.Attributes.Signature("(Ljavassist/CtBehavior;I)Ljava/util/Optional<Ljava/lang/String;>;")]
	
	internal static Optional extractParameterName(CtBehavior P_0, int P_1)
	{
		MethodInfo methodInfo = P_0.getMethodInfo();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute != null)
		{
			LocalVariableAttribute localVariableAttribute = (LocalVariableAttribute)codeAttribute.getAttribute("LocalVariableTable");
			if (localVariableAttribute != null)
			{
				int num = ((!javassist.Modifier.isStatic(P_0.getModifiers())) ? 1 : 0);
				Optional result = Optional.ofNullable(localVariableAttribute.variableName(P_1 + num));
				
				return result;
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	internal static string internalNameToCanonicalName(string P_0)
	{
		string result = String.instancehelper_replaceAll(P_0, "\\$", ".");
		
		return result;
	}

	
	
	private static string getTypeName(javassist.bytecode.SignatureAttribute.ClassType P_0)
	{
		javassist.bytecode.SignatureAttribute.ClassType declaringClass = P_0.getDeclaringClass();
		string result = ((declaringClass != null) ? new StringBuilder().append(getTypeName(declaringClass)).append(".").append(P_0.getName())
			.ToString() : P_0.getName());
		
		return result;
	}

	
	
	private static string removeTypeArguments(string P_0)
	{
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = "<");
		if (String.instancehelper_contains(P_0, s))
		{
			string result = String.instancehelper_substring(P_0, 0, String.instancehelper_indexOf(P_0, 60));
			
			return result;
		}
		return P_0;
	}

	
	
	private static ResolvedType getArrayType(ResolvedType P_0, int P_1)
	{
		if (P_1 > 0)
		{
			ResolvedArrayType resolvedArrayType = new ResolvedArrayType(P_0);
			P_1 += -1;
			ResolvedType arrayType = getArrayType(resolvedArrayType, P_1);
			
			return arrayType;
		}
		return P_0;
	}

	
	
	private static ResolvedType getGenericParameterByName(string P_0, ResolvedTypeParametrizable P_1, TypeSolver P_2)
	{
		Optional optional = P_1.findTypeParameter(P_0).map(new ___003C_003EAnon5());
		return (ResolvedType)optional.orElseGet(new ___003C_003EAnon6(P_2, P_0));
	}

	
	
	private static ResolvedType objectTypeArgumentToType(javassist.bytecode.SignatureAttribute.ObjectType P_0, TypeSolver P_1, ResolvedTypeParametrizable P_2)
	{
		if (P_0 is javassist.bytecode.SignatureAttribute.ClassType)
		{
			ResolvedType result = signatureTypeToType(P_0, P_1, P_2);
			
			return result;
		}
		if (P_0 is javassist.bytecode.SignatureAttribute.ArrayType)
		{
			ResolvedArrayType result2 = new ResolvedArrayType(signatureTypeToType(((javassist.bytecode.SignatureAttribute.ArrayType)P_0).getComponentType(), P_1, P_2));
			
			return result2;
		}
		string text = P_0.jvmTypeName();
		ResolvedType genericParameterByName = getGenericParameterByName(text, P_2, P_1);
		
		return genericParameterByName;
	}

	
	
	private static ResolvedType typeArgumentToType(javassist.bytecode.SignatureAttribute.TypeArgument P_0, TypeSolver P_1, ResolvedTypeParametrizable P_2)
	{
		if (P_0.isWildcard())
		{
			if (P_0.getType() == null)
			{
				return ResolvedWildcard.UNBOUNDED;
			}
			if (P_0.getKind() == '+')
			{
				ResolvedWildcard result = ResolvedWildcard.extendsBound(objectTypeArgumentToType(P_0.getType(), P_1, P_2));
				
				return result;
			}
			if (P_0.getKind() == '-')
			{
				ResolvedWildcard result2 = ResolvedWildcard.superBound(objectTypeArgumentToType(P_0.getType(), P_1, P_2));
				
				return result2;
			}
			
			throw new UnsupportedOperationException();
		}
		ResolvedType result3 = objectTypeArgumentToType(P_0.getType(), P_1, P_2);
		
		return result3;
	}

	
	
	
	private static Optional lambda_0024solveMethodAsUsage_00240(ResolvedReferenceType P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		Optional typeDeclaration = P_0.getTypeDeclaration();
		
		return typeDeclaration;
	}

	
	
	
	private static Optional lambda_0024solveMethodAsUsage_00241(string P_0, List P_1, Context P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		Optional result = ContextHelper.solveMethodAsUsage(P_4, P_0, P_1, P_2, P_3);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveMethod_00242(bool P_0, CtMethod P_1)
	{
		return (!P_0 || java.lang.reflect.Modifier.isStatic(P_1.getModifiers())) ? true : false;
	}

	
	
	
	private static ResolvedType lambda_0024signatureTypeToType_00243(TypeSolver P_0, ResolvedTypeParametrizable P_1, javassist.bytecode.SignatureAttribute.TypeArgument P_2)
	{
		ResolvedType result = typeArgumentToType(P_2, P_0, P_1);
		
		return result;
	}

	
	
	
	private static ResolvedType lambda_0024getGenericParameterByName_00244(TypeSolver P_0, string P_1)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(P_0.solveType(removeTypeArguments(internalNameToCanonicalName(P_1))), P_0);
		
		return result;
	}

	
	
	internal JavassistUtils()
	{
	}
}
