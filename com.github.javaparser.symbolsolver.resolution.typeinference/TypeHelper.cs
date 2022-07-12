
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class TypeHelper
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isProperType_00240((ResolvedType)P_0);
			
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
		private readonly ResolvedType arg_00241;

		internal ___003C_003EAnon1(ResolvedType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024areCompatibleThroughWideningReferenceConversion_00241(arg_00241, (ResolvedPrimitiveType)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024groundTargetTypeOfLambda_00242((ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024nonWildcardParameterizationOf_00243();
			
			return result;
		}
	}

	
		
	public static Set usedInferenceVariables(ResolvedType type)
	{
		if (type.isInferenceVariable())
		{
			HashSet.___003Cclinit_003E();
			HashSet result = new HashSet(Arrays.asList((InferenceVariable)type));
			
			return result;
		}
		if (type.isReferenceType())
		{
			HashSet hashSet = new HashSet();
			Iterator iterator = type.asReferenceType().typeParametersValues().iterator();
			while (iterator.hasNext())
			{
				ResolvedType type2 = (ResolvedType)iterator.next();
				((Set)hashSet).addAll((Collection)usedInferenceVariables(type2));
			}
			return hashSet;
		}
		string message = Object.instancehelper_toString(type);
		
		throw new UnsupportedOperationException(message);
	}

	
	
	public static bool isProperType(ResolvedType type)
	{
		if (type is InferenceVariable)
		{
			return false;
		}
		if (type is ResolvedReferenceType)
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)type;
			bool result = resolvedReferenceType.typeParametersValues().stream().allMatch(new ___003C_003EAnon0());
			
			return result;
		}
		if (type is ResolvedWildcard)
		{
			ResolvedWildcard resolvedWildcard = (ResolvedWildcard)type;
			if (resolvedWildcard.isBounded())
			{
				bool result2 = isProperType(resolvedWildcard.getBoundedType());
				
				return result2;
			}
			return true;
		}
		if (type.isPrimitive())
		{
			return true;
		}
		if (type.isTypeVariable())
		{
			return false;
		}
		if (type.isArray())
		{
			bool result3 = isProperType(type.asArrayType().getComponentType());
			
			return result3;
		}
		string message = Object.instancehelper_toString(type);
		
		throw new UnsupportedOperationException(message);
	}

	
		
	public static ResolvedType leastUpperBound(Set types)
	{
		if (types.isEmpty())
		{
			
			throw new IllegalArgumentException();
		}
		if (types.size() == 1)
		{
			return (ResolvedType)types.stream().findFirst().get();
		}
		
		throw new UnsupportedOperationException();
	}

	
		
	public static ResolvedType glb(Set types)
	{
		if (types.isEmpty())
		{
			
			throw new IllegalArgumentException();
		}
		if (types.size() == 1)
		{
			return (ResolvedType)types.iterator().next();
		}
		ResolvedIntersectionType result = new ResolvedIntersectionType(types);
		
		return result;
	}

	
	
	public static bool isCompatibleInALooseInvocationContext(TypeSolver typeSolver, Expression expression, ResolvedType t)
	{
		bool result = isCompatibleInALooseInvocationContext(JavaParserFacade.get(typeSolver).getType(expression), t);
		
		return result;
	}

	
		
	public static Pair groundTargetTypeOfLambda(LambdaExpr lambdaExpr, ResolvedType T, TypeSolver typeSolver)
	{
		int b = 0;
		if (T.asReferenceType().typeParametersValues().stream()
			.anyMatch(new ___003C_003EAnon2()))
		{
			if (ExpressionHelper.isExplicitlyTyped(lambdaExpr))
			{
				_ = 1;
				
				throw new UnsupportedOperationException();
			}
			Pair result = new Pair(nonWildcardParameterizationOf(T.asReferenceType(), typeSolver), Boolean.valueOf((byte)b != 0));
			
			return result;
		}
		Pair result2 = new Pair(T, Boolean.valueOf((byte)b != 0));
		
		return result2;
	}

	
	
	public static MethodType getFunctionType(ResolvedType type)
	{
		Optional functionalMethod = FunctionalInterfaceLogic.getFunctionalMethod(type);
		if (functionalMethod.isPresent())
		{
			MethodType result = MethodType.fromMethodUsage((MethodUsage)functionalMethod.get());
			
			return result;
		}
		
		throw new IllegalArgumentException();
	}

	
	
	public static bool isCompatibleInALooseInvocationContext(ResolvedType s, ResolvedType t)
	{
		if (Object.instancehelper_equals(s, t))
		{
			return true;
		}
		if (s.isPrimitive() && t.isPrimitive() && areCompatibleThroughWideningPrimitiveConversion(s, t))
		{
			return true;
		}
		if (s.isReferenceType() && t.isReferenceType() && areCompatibleThroughWideningReferenceConversion(s, t))
		{
			return true;
		}
		if (s.isPrimitive() && t.isReferenceType() && areCompatibleThroughWideningReferenceConversion(toBoxedType(s.asPrimitive()), t))
		{
			return true;
		}
		if (s.isReferenceType() && s.asReferenceType().isUnboxable() && t.isPrimitive() && areCompatibleThroughWideningPrimitiveConversion((ResolvedType)s.asReferenceType().toUnboxedType().get(), t))
		{
			return true;
		}
		if (s.isNull() && t.isReferenceType())
		{
			return true;
		}
		bool result = t.isAssignableBy(s);
		
		return result;
	}

	
	
	public static bool areCompatibleThroughWideningPrimitiveConversion(ResolvedType s, ResolvedType t)
	{
		if (s.isPrimitive() && t.isPrimitive())
		{
			bool result = s.isAssignableBy(t);
			
			return result;
		}
		return false;
	}

	
	
	public static bool areCompatibleThroughWideningReferenceConversion(ResolvedType s, ResolvedType t)
	{
		Optional optional = Arrays.stream(ResolvedPrimitiveType.values()).filter(new ___003C_003EAnon1(s)).findFirst();
		if (!optional.isPresent())
		{
			return false;
		}
		string message = new StringBuilder().append("areCompatibleThroughWideningReferenceConversion s=").append(s).append(", t=")
			.append(t)
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	public static ResolvedType toBoxedType(ResolvedPrimitiveType primitiveType)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	private static ResolvedReferenceType nonWildcardParameterizationOf(ResolvedReferenceType P_0, TypeSolver P_1)
	{
		ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)P_0.getTypeDeclaration().orElseThrow(new ___003C_003EAnon3());
		LinkedList linkedList = new LinkedList();
		List list = P_0.typeParametersValues();
		List typeParameters = resolvedReferenceTypeDeclaration.getTypeParameters();
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl referenceTypeImpl = new ReferenceTypeImpl(P_1.getSolvedJavaLangObject(), P_1);
		for (int i = 0; i < list.size(); i++)
		{
			ResolvedType resolvedType = (ResolvedType)list.get(i);
			object obj = null;
			if (!resolvedType.isWildcard())
			{
				obj = resolvedType;
			}
			if ((ResolvedType)obj == null && resolvedType.isWildcard() && resolvedType.asWildcard().mention(resolvedReferenceTypeDeclaration.getTypeParameters()))
			{
				
				throw new IllegalArgumentException();
			}
			if ((ResolvedType)obj == null)
			{
				object obj2 = ((!((ResolvedTypeParameterDeclaration)typeParameters.get(i)).hasLowerBound()) ? referenceTypeImpl : ((ResolvedTypeParameterDeclaration)typeParameters.get(i)).getLowerBound());
				if (resolvedType.isWildcard() && !resolvedType.asWildcard().isBounded())
				{
					obj = obj2;
				}
				else if (resolvedType.isWildcard() && resolvedType.asWildcard().isUpperBounded())
				{
					ResolvedType boundedType = resolvedType.asWildcard().getBoundedType();
					HashSet.___003Cclinit_003E();
					obj = glb(new HashSet(Arrays.asList(boundedType, (ResolvedType)obj2)));
				}
				else
				{
					if (!resolvedType.isWildcard() || !resolvedType.asWildcard().isLowerBounded())
					{
						
						throw new RuntimeException("This should not happen");
					}
					obj = resolvedType.asWildcard().getBoundedType();
				}
			}
			((List)linkedList).add(obj);
		}
		ReferenceTypeImpl result = new ReferenceTypeImpl(resolvedReferenceTypeDeclaration, linkedList, P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isProperType_00240(ResolvedType P_0)
	{
		bool result = isProperType(P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024areCompatibleThroughWideningReferenceConversion_00241(ResolvedType P_0, ResolvedPrimitiveType P_1)
	{
		bool result = String.instancehelper_equals(P_1.getBoxTypeQName(), P_0.asReferenceType().getQualifiedName());
		
		return result;
	}

	
	
	
	private static bool lambda_0024groundTargetTypeOfLambda_00242(ResolvedType P_0)
	{
		bool result = P_0.isWildcard();
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024nonWildcardParameterizationOf_00243()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	public TypeHelper()
	{
	}

	
	
	public static bool isCompatibleInAStrictInvocationContext(Expression expression, ResolvedType t)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public static ResolvedType toBoxedType(ResolvedPrimitiveType primitiveType, TypeSolver typeSolver)
	{
		SymbolReference symbolReference = typeSolver.tryToSolveType(primitiveType.getBoxTypeQName());
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration(), typeSolver);
		
		return result;
	}
}
