using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.resolution;

public class MethodResolutionLogic
{
	
	private sealed class ___003C_003EAnon0 : ResolvedTypeTransformer
	{
		private readonly ResolvedTypeParameterDeclaration arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon0(ResolvedTypeParameterDeclaration P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = lambda_0024replaceTypeParam_00240(arg_00241, arg_00242, P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly Set arg_00241;

		private readonly Function arg_00242;

		internal ___003C_003EAnon1(Set P_0, Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024distinctByKey_00241(arg_00241, arg_00242, P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMostApplicable_00242(arg_00241, (ResolvedMethodDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			object result = ((ResolvedMethodDeclaration)P_0).getQualifiedSignature();
			
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

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly TypeSolver arg_00243;

		private readonly bool arg_00244;

		internal ___003C_003EAnon4(string P_0, List P_1, TypeSolver P_2, bool P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMostApplicable_00243(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedMethodDeclaration)P_0);
			
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
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly TypeSolver arg_00243;

		internal ___003C_003EAnon5(string P_0, List P_1, TypeSolver P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMostApplicableUsage_00244(arg_00241, arg_00242, arg_00243, (MethodUsage)P_0);
			
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

	private static string JAVA_LANG_OBJECT;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	public static SymbolReference solveMethodInType(ResolvedTypeDeclaration typeDeclaration, string name, List argumentsTypes, bool staticOnly)
	{
		if (typeDeclaration is MethodResolutionCapability)
		{
			SymbolReference result = ((MethodResolutionCapability)typeDeclaration).solveMethod(name, argumentsTypes, staticOnly);
			
			return result;
		}
		string canonicalName = Object.instancehelper_getClass(typeDeclaration).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
		
	public static SymbolReference findMostApplicable(List methods, string name, List argumentsTypes, TypeSolver typeSolver)
	{
		SymbolReference symbolReference = findMostApplicable(methods, name, argumentsTypes, typeSolver, wildcardTolerance: false);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		SymbolReference result = findMostApplicable(methods, name, argumentsTypes, typeSolver, wildcardTolerance: true);
		
		return result;
	}

	
		
	public static SymbolReference solveMethodInType(ResolvedTypeDeclaration typeDeclaration, string name, List argumentsTypes)
	{
		SymbolReference result = solveMethodInType(typeDeclaration, name, argumentsTypes, staticOnly: false);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 239, 112, 115, 103, 105, 139, 105, 148, 153,
		130, 104, 130, 104, 154, 104, 103, 120, 130
	})]
	public static ResolvedType replaceTypeParam(ResolvedType type, ResolvedTypeParameterDeclaration tp, TypeSolver typeSolver)
	{
		if (type.isTypeVariable() || type.isWildcard())
		{
			if (String.instancehelper_equals(type.describe(), tp.getName()))
			{
				List bounds = tp.getBounds();
				if (bounds.size() > 1)
				{
					
					throw new UnsupportedOperationException();
				}
				if (bounds.size() == 1)
				{
					ResolvedType type2 = ((ResolvedTypeParameterDeclaration.Bound)bounds.get(0)).getType();
					
					return type2;
				}
				ReferenceTypeImpl.___003Cclinit_003E();
				ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.solveType(JAVA_LANG_OBJECT), typeSolver);
				
				return result;
			}
			return type;
		}
		if (type.isPrimitive())
		{
			return type;
		}
		if (type.isArray())
		{
			ResolvedArrayType result2 = new ResolvedArrayType(replaceTypeParam(type.asArrayType().getComponentType(), tp, typeSolver));
			
			return result2;
		}
		if (type.isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = type.asReferenceType();
			return resolvedReferenceType.transformTypeParameters(new ___003C_003EAnon0(tp, typeSolver)).asReferenceType();
		}
		string message = new StringBuilder().append("Replacing ").append(type).append(", param ")
			.append(tp)
			.append(" with ")
			.append(Object.instancehelper_getClass(type).getCanonicalName())
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		[LineNumberTable(new byte[]
	{
		162,
		174,
		159,
		9,
		104,
		136,
		105,
		143,
		109,
		110,
		109,
		142,
		105,
		135,
		125,
		105,
		byte.MaxValue,
		48,
		55,
		233,
		81
	})]
	public static Optional findMostApplicableUsage(List methods, string name, List argumentsTypes, TypeSolver typeSolver)
	{
		List list = (List)methods.stream().filter(new ___003C_003EAnon5(name, argumentsTypes, typeSolver)).collect(Collectors.toList());
		if (list.isEmpty())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		if (list.size() == 1)
		{
			Optional result2 = Optional.of(list.get(0));
			
			return result2;
		}
		MethodUsage methodUsage = (MethodUsage)list.get(0);
		for (int i = 1; i < list.size(); i++)
		{
			MethodUsage methodUsage2 = (MethodUsage)list.get(i);
			if (!isMoreSpecific(methodUsage, methodUsage2))
			{
				if (isMoreSpecific(methodUsage2, methodUsage))
				{
					methodUsage = methodUsage2;
				}
				else if (String.instancehelper_equals(methodUsage.declaringType().getQualifiedName(), methodUsage2.declaringType().getQualifiedName()) && !areOverride(methodUsage, methodUsage2))
				{
					string description = new StringBuilder().append("Ambiguous method call: cannot find a most applicable method: ").append(methodUsage).append(", ")
						.append(methodUsage2)
						.append(". First declared in ")
						.append(methodUsage.declaringType().getQualifiedName())
						.ToString();
					
					throw new MethodAmbiguityException(description);
				}
			}
		}
		Optional result3 = Optional.of(methodUsage);
		
		return result3;
	}

	
		
	public static bool isAssignableMatchTypeParameters(ResolvedReferenceType expected, ResolvedReferenceType actual, Map matchedParameters)
	{
		if (String.instancehelper_equals(actual.getQualifiedName(), expected.getQualifiedName()))
		{
			bool result = isAssignableMatchTypeParametersMatchingQName(expected, actual, matchedParameters);
			
			return result;
		}
		List allAncestors = actual.getAllAncestors();
		Iterator iterator = allAncestors.iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (isAssignableMatchTypeParametersMatchingQName(expected, resolvedReferenceType, matchedParameters))
			{
				return true;
			}
		}
		return false;
	}

	
		
	protected internal static bool isExactMatch(ResolvedMethodLikeDeclaration method, List argumentsTypes)
	{
		for (int i = 0; i < method.getNumberOfParams(); i++)
		{
			if (!Object.instancehelper_equals(method.getParam(i).getType(), argumentsTypes.get(i)))
			{
				return false;
			}
		}
		return true;
	}

	
		
	private static ResolvedType findCommonType(List P_0)
	{
		if (P_0.isEmpty())
		{
			
			throw new IllegalArgumentException();
		}
		return (ResolvedType)P_0.get(0);
	}

	
		[LineNumberTable(new byte[]
	{
		159, 119, 163, 110, 194, 167, 135, 135, 135, 162,
		134, 198, 226, 71, 109, 127, 5, 108, 130, 164,
		104, 111, 117, 132, 226, 59, 232, 73, 235, 69,
		104, 199, 101, 194, 103, 99, 107, 111, 111, 127,
		1, 118, 165, 110, 159, 3, 118, 98, 103, 7,
		231, 69, 103, 104, 115, 127, 1, 108, 130, 110,
		117, 99, 226, 69, 117, 99, 130, 106, 112, 162,
		226, 23, 235, 109
	})]
	private static bool isApplicable(ResolvedMethodDeclaration P_0, string P_1, List P_2, TypeSolver P_3, bool P_4)
	{
		if (!String.instancehelper_equals(P_0.getName(), P_1))
		{
			return false;
		}
		int numberOfParams = P_0.getNumberOfParams();
		int num = P_2.size();
		int num2 = (P_0.hasVariadicParameter() ? 1 : 0);
		if (num2 == 0 && num != numberOfParams)
		{
			return false;
		}
		if (num2 != 0)
		{
			if (num <= numberOfParams - 2)
			{
				return false;
			}
			ResolvedType resolvedType = P_0.getLastParam().getType();
			Iterator iterator = P_0.getTypeParameters().iterator();
			while (iterator.hasNext())
			{
				ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)iterator.next();
				resolvedType = replaceTypeParam(resolvedType, tp, P_3);
			}
			if (num > numberOfParams)
			{
				for (int i = numberOfParams; i < num; i++)
				{
					ResolvedType other = (ResolvedType)P_2.get(i);
					if (!resolvedType.asArrayType().getComponentType().isAssignableBy(other))
					{
						return false;
					}
				}
			}
			P_2 = groupTrailingArgumentsIntoArray(P_0, P_2, resolvedType);
		}
		int num3 = P_2.size();
		getLastParameterIndex(num);
		if (num3 != numberOfParams)
		{
			return false;
		}
		HashMap hashMap = new HashMap();
		int num4 = 0;
		for (int j = 0; j < numberOfParams; j++)
		{
			ResolvedType resolvedType2 = P_0.getParam(j).getType();
			ResolvedType resolvedType3 = (ResolvedType)P_2.get(j);
			if (resolvedType2.isTypeVariable() && !resolvedType2.isWildcard() && resolvedType2.asTypeParameter().declaredOnMethod())
			{
				((Map)hashMap).put((object)resolvedType2.asTypeParameter().getName(), (object)resolvedType3);
				continue;
			}
			int num5 = ((resolvedType2.isAssignableBy(resolvedType3) || (P_0.getParam(j).isVariadic() && new ResolvedArrayType(resolvedType2).isAssignableBy(resolvedType3))) ? 1 : 0);
			if (num5 == 0 && resolvedType2.isReferenceType() && resolvedType3.isReferenceType())
			{
				num5 = (isAssignableMatchTypeParameters(resolvedType2.asReferenceType(), resolvedType3.asReferenceType(), hashMap) ? 1 : 0);
			}
			if (num5 != 0)
			{
				continue;
			}
			List typeParameters = P_0.getTypeParameters();
			typeParameters.addAll(P_0.declaringType().getTypeParameters());
			Iterator iterator2 = typeParameters.iterator();
			while (iterator2.hasNext())
			{
				ResolvedTypeParameterDeclaration tp2 = (ResolvedTypeParameterDeclaration)iterator2.next();
				resolvedType2 = replaceTypeParam(resolvedType2, tp2, P_3);
			}
			if (!resolvedType2.isAssignableBy(resolvedType3))
			{
				if (resolvedType3.isWildcard() && P_4 && !resolvedType2.isPrimitive())
				{
					num4 = 1;
				}
				else if (resolvedType3.isConstraint() && P_4 && resolvedType2.isPrimitive())
				{
					num4 = 1;
				}
				else if (num2 == 0 || j != numberOfParams - 1 || !new ResolvedArrayType(resolvedType2).isAssignableBy(resolvedType3))
				{
					return false;
				}
			}
		}
		return (!P_4 || num4 != 0) ? true : false;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 104, 103, 167, 103, 135, 164, 148, 230, 70,
		118, 100, 110, 127, 4, 230, 70, 244, 69
	})]
	private static List groupTrailingArgumentsIntoArray(ResolvedMethodDeclaration P_0, List P_1, ResolvedType P_2)
	{
		int numberOfParams = P_0.getNumberOfParams();
		int lastParameterIndex = getLastParameterIndex(numberOfParams);
		int num = P_1.size();
		int lastParameterIndex2 = getLastParameterIndex(num);
		if (num > numberOfParams)
		{
			P_1 = groupVariadicParamValues(P_1, lastParameterIndex, P_0.getLastParam().getType());
		}
		if (num == numberOfParams - 1)
		{
			P_1 = groupVariadicParamValues(P_1, lastParameterIndex, P_0.getLastParam().getType());
		}
		else if (num == numberOfParams)
		{
			ResolvedType resolvedType = (ResolvedType)P_1.get(lastParameterIndex2);
			if ((!resolvedType.isArray() || !P_2.isAssignableBy(resolvedType.asArrayType().getComponentType())) && 0 == 0)
			{
				P_1 = groupVariadicParamValues(P_1, lastParameterIndex, P_0.getLastParam().getType());
			}
		}
		return P_1;
	}

	
	
	private static int getLastParameterIndex(int P_0)
	{
		int result = Math.max(0, P_0 - 1);
		
		return result;
	}

	
		
	private static List groupVariadicParamValues(List P_0, int P_1, ResolvedType P_2)
	{
		
		ArrayList arrayList = new ArrayList(P_0.subList(0, P_1));
		List list = P_0.subList(P_1, P_0.size());
		if (list.isEmpty())
		{
			((List)arrayList).add((object)P_2);
		}
		else
		{
			ResolvedType baseType = findCommonType(list);
			((List)arrayList).add((object)new ResolvedArrayType(baseType));
		}
		return arrayList;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 174, 115, 130, 120, 171, 115, 114, 210, 112,
		103, 168, 172, 104, 109, 124, 144, 109, 104, 144,
		105, 130, 104, 109, 181, 130, 241, 31, 233, 100
	})]
	private static bool isAssignableMatchTypeParametersMatchingQName(ResolvedReferenceType P_0, ResolvedReferenceType P_1, Map P_2)
	{
		if (!String.instancehelper_equals(P_0.getQualifiedName(), P_1.getQualifiedName()))
		{
			return false;
		}
		if (P_0.typeParametersValues().size() != P_1.typeParametersValues().size())
		{
			
			throw new UnsupportedOperationException();
		}
		for (int i = 0; i < P_0.typeParametersValues().size(); i++)
		{
			ResolvedType resolvedType = (ResolvedType)P_0.typeParametersValues().get(i);
			ResolvedType resolvedType2 = (ResolvedType)P_1.typeParametersValues().get(i);
			if (resolvedType.isReferenceType() && resolvedType2.isReferenceType())
			{
				ResolvedReferenceType expected = resolvedType.asReferenceType();
				ResolvedReferenceType actual = resolvedType2.asReferenceType();
				bool result = isAssignableMatchTypeParameters(expected, actual, P_2);
				
				return result;
			}
			if (resolvedType.isTypeVariable())
			{
				string name = resolvedType.asTypeParameter().getName();
				if (!resolvedType2.isTypeVariable() || !String.instancehelper_equals(resolvedType2.asTypeParameter().getName(), name))
				{
					bool result2 = matchTypeVariable(resolvedType.asTypeVariable(), resolvedType2, P_2);
					
					return result2;
				}
				continue;
			}
			if (resolvedType.isReferenceType())
			{
				if (resolvedType2.isTypeVariable())
				{
					bool result3 = matchTypeVariable(resolvedType2.asTypeVariable(), resolvedType, P_2);
					
					return result3;
				}
				if (!Object.instancehelper_equals(resolvedType, resolvedType2))
				{
					return false;
				}
				continue;
			}
			if (resolvedType.isWildcard())
			{
				if (resolvedType.asWildcard().isExtends())
				{
					bool result4 = isAssignableMatchTypeParameters(resolvedType.asWildcard().getBoundedType(), P_1, P_2);
					
					return result4;
				}
				return true;
			}
			string message = resolvedType.describe();
			
			throw new UnsupportedOperationException(message);
		}
		return true;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 221, 108, 105, 109, 105, 98, 137, 105, 130,
		130, 137
	})]
	private static bool matchTypeVariable(ResolvedTypeVariable P_0, ResolvedType P_1, Map P_2)
	{
		string name = P_0.asTypeParameter().getName();
		if (P_2.containsKey(name))
		{
			ResolvedType resolvedType = (ResolvedType)P_2.get(name);
			if (resolvedType.isAssignableBy(P_1))
			{
				return true;
			}
			if (P_1.isAssignableBy(resolvedType))
			{
				P_2.put(name, P_1);
				return true;
			}
			return false;
		}
		P_2.put(name, P_1);
		return true;
	}

	
		
	public static bool isAssignableMatchTypeParameters(ResolvedType expected, ResolvedType actual, Map matchedParameters)
	{
		if (expected.isReferenceType() && actual.isReferenceType())
		{
			bool result = isAssignableMatchTypeParameters(expected.asReferenceType(), actual.asReferenceType(), matchedParameters);
			
			return result;
		}
		if (expected.isTypeVariable())
		{
			matchedParameters.put(expected.asTypeParameter().getName(), actual);
			return true;
		}
		if (expected.isArray())
		{
			matchedParameters.put(Object.instancehelper_toString(expected.asArrayType().getComponentType()), actual);
			return true;
		}
		string message = new StringBuilder().append(Object.instancehelper_getClass(expected).getCanonicalName()).append(" ").append(Object.instancehelper_getClass(actual).getCanonicalName())
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		[LineNumberTable(new byte[]
	{
		162, 239, 105, 129, 118, 103, 103, 115, 112, 112,
		63, 9, 230, 69, 129, 112, 109, 116, 129, 129,
		112, 129, 112, 110, 161, 112, 109, 148, 161, 112,
		110, 129, 112, 110, 129, 112, 129, 104, 129
	})]
	private static void inferTypes(ResolvedType P_0, ResolvedType P_1, Map P_2)
	{
		if (Object.instancehelper_equals(P_0, P_1))
		{
			return;
		}
		if (P_0.isReferenceType() && P_1.isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = P_0.asReferenceType();
			ResolvedReferenceType resolvedReferenceType2 = P_1.asReferenceType();
			if (String.instancehelper_equals(resolvedReferenceType.getQualifiedName(), resolvedReferenceType2.getQualifiedName()) && !resolvedReferenceType.isRawType() && !resolvedReferenceType2.isRawType())
			{
				for (int i = 0; i < resolvedReferenceType.typeParametersValues().size(); i++)
				{
					inferTypes((ResolvedType)resolvedReferenceType.typeParametersValues().get(i), (ResolvedType)resolvedReferenceType2.typeParametersValues().get(i), P_2);
				}
			}
		}
		else if (P_0.isReferenceType() && P_1.isWildcard())
		{
			if (P_1.asWildcard().isBounded())
			{
				inferTypes(P_0, P_1.asWildcard().getBoundedType(), P_2);
			}
		}
		else
		{
			if (P_0.isWildcard() && P_1.isWildcard())
			{
				return;
			}
			if (P_0.isReferenceType() && P_1.isTypeVariable())
			{
				P_2.put(P_1.asTypeParameter(), P_0);
			}
			else if (P_0.isWildcard() && P_1.isReferenceType())
			{
				if (P_0.asWildcard().isBounded())
				{
					inferTypes(P_0.asWildcard().getBoundedType(), P_1, P_2);
				}
			}
			else if (P_0.isWildcard() && P_1.isTypeVariable())
			{
				P_2.put(P_1.asTypeParameter(), P_0);
			}
			else if (P_0.isTypeVariable() && P_1.isTypeVariable())
			{
				P_2.put(P_1.asTypeParameter(), P_0);
			}
			else if (!P_0.isPrimitive() && !P_1.isPrimitive() && !P_0.isNull())
			{
			}
		}
	}

	
		[LineNumberTable(new byte[]
	{
		159,
		5,
		67,
		145,
		143,
		152,
		101,
		176,
		104,
		205,
		108,
		102,
		107,
		115,
		13,
		230,
		71,
		139,
		103,
		127,
		0,
		127,
		0,
		122,
		138,
		98,
		165,
		120,
		233,
		70,
		105,
		212,
		110,
		99,
		99,
		112,
		111,
		108,
		104,
		108,
		99,
		230,
		72,
		114,
		102,
		148,
		127,
		0,
		227,
		45,
		235,
		90,
		132,
		106,
		106,
		134,
		byte.MaxValue,
		24,
		71
	})]
	public static SymbolReference findMostApplicable(List methods, string name, List argumentsTypes, TypeSolver typeSolver, bool wildcardTolerance)
	{
		List list = (List)methods.stream().filter(new ___003C_003EAnon2(name)).filter(distinctByKey(new ___003C_003EAnon3()))
			.filter(new ___003C_003EAnon4(name, argumentsTypes, typeSolver, wildcardTolerance))
			.collect(Collectors.toList());
		if (list.isEmpty())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
			
			return result;
		}
		if (list.size() > 1)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < argumentsTypes.size(); i++)
			{
				if (((ResolvedType)argumentsTypes.get(i)).isNull())
				{
					((List)arrayList).add((object)Integer.valueOf(i));
				}
			}
			if (!((List)arrayList).isEmpty())
			{
				HashSet hashSet = new HashSet();
				Iterator iterator = ((List)arrayList).iterator();
				while (iterator.hasNext())
				{
					Integer integer = (Integer)iterator.next();
					Iterator iterator2 = list.iterator();
					while (iterator2.hasNext())
					{
						ResolvedMethodDeclaration resolvedMethodDeclaration = (ResolvedMethodDeclaration)iterator2.next();
						if (resolvedMethodDeclaration.getParam(integer.intValue()).getType().isArray())
						{
							((Set)hashSet).add((object)resolvedMethodDeclaration);
						}
					}
				}
				if (!((Set)hashSet).isEmpty() && ((Set)hashSet).size() < list.size())
				{
					list.removeAll(hashSet);
				}
			}
		}
		if (list.size() == 1)
		{
			SymbolReference result2 = SymbolReference.solved((ResolvedDeclaration)list.get(0));
			
			return result2;
		}
		ResolvedMethodDeclaration resolvedMethodDeclaration2 = (ResolvedMethodDeclaration)list.get(0);
		ResolvedMethodDeclaration resolvedMethodDeclaration3 = null;
		int num = 0;
		for (int j = 1; j < list.size(); j++)
		{
			resolvedMethodDeclaration3 = (ResolvedMethodDeclaration)list.get(j);
			if (isMoreSpecific(resolvedMethodDeclaration2, resolvedMethodDeclaration3, argumentsTypes))
			{
				num = 0;
			}
			else if (isMoreSpecific(resolvedMethodDeclaration3, resolvedMethodDeclaration2, argumentsTypes))
			{
				num = 0;
				resolvedMethodDeclaration2 = resolvedMethodDeclaration3;
			}
			else if (resolvedMethodDeclaration2.isGeneric() && !resolvedMethodDeclaration3.isGeneric())
			{
				resolvedMethodDeclaration2 = resolvedMethodDeclaration3;
			}
			else if ((resolvedMethodDeclaration2.isGeneric() || !resolvedMethodDeclaration3.isGeneric()) && String.instancehelper_equals(resolvedMethodDeclaration2.declaringType().getQualifiedName(), resolvedMethodDeclaration3.declaringType().getQualifiedName()))
			{
				num = 1;
			}
		}
		if (num != 0 && !isExactMatch(resolvedMethodDeclaration2, argumentsTypes))
		{
			if (!isExactMatch(resolvedMethodDeclaration3, argumentsTypes))
			{
				string description = new StringBuilder().append("Ambiguous method call: cannot find a most applicable method: ").append(resolvedMethodDeclaration2).append(", ")
					.append(resolvedMethodDeclaration3)
					.ToString();
				
				throw new MethodAmbiguityException(description);
			}
			resolvedMethodDeclaration2 = resolvedMethodDeclaration3;
		}
		SymbolReference result3 = SymbolReference.solved(resolvedMethodDeclaration2);
		
		return result3;
	}

	
		
	private static Predicate distinctByKey(Function P_0)
	{
		ConcurrentHashMap.KeySetView keySetView = ConcurrentHashMap.newKeySet();
		return new ___003C_003EAnon1(keySetView, P_0);
	}

	
		[LineNumberTable(new byte[]
	{
		162, 39, 103, 103, 103, 103, 104, 121, 115, 99,
		195, 148, 130, 148, 226, 69, 113, 198, 111, 106,
		138, 99, 106, 239, 69, 100, 130, 100, 226, 71,
		102, 112, 114, 135, 130, 102, 112, 114, 135, 226,
		69, 106, 176, 245, 70, 107, 139, 136, 130, 136,
		226, 6, 235, 127, 134, 131, 166, 169
	})]
	private static bool isMoreSpecific(ResolvedMethodDeclaration P_0, ResolvedMethodDeclaration P_1, List P_2)
	{
		int num = (P_0.hasVariadicParameter() ? 1 : 0);
		int num2 = (P_1.hasVariadicParameter() ? 1 : 0);
		int numberOfParams = P_0.getNumberOfParams();
		int numberOfParams2 = P_1.getNumberOfParams();
		int num3 = P_2.size();
		ResolvedType resolvedType = ((num3 <= 0) ? null : ((ResolvedType)P_2.get(num3 - 1)));
		int num4 = ((resolvedType != null && resolvedType.isArray()) ? 1 : 0);
		int num5 = 0;
		int num6 = 0;
		if (num == 0 && numberOfParams == num3 && num2 != 0 && (numberOfParams2 != num3 || num4 == 0))
		{
			return true;
		}
		if (num2 == 0 && numberOfParams2 == num3 && num != 0 && (numberOfParams != num3 || num4 == 0))
		{
			return false;
		}
		if (num != 0 && num2 != 0 && numberOfParams == numberOfParams2 && num3 == numberOfParams - 1)
		{
			num5++;
		}
		for (int i = 0; i < num3 + num5; i++)
		{
			ResolvedType methodsExplicitAndVariadicParameterType = getMethodsExplicitAndVariadicParameterType(P_0, i);
			ResolvedType methodsExplicitAndVariadicParameterType2 = getMethodsExplicitAndVariadicParameterType(P_1, i);
			ResolvedType resolvedType2 = null;
			if (i < P_2.size())
			{
				resolvedType2 = (ResolvedType)P_2.get(i);
			}
			if (methodsExplicitAndVariadicParameterType == null)
			{
				return false;
			}
			if (methodsExplicitAndVariadicParameterType2 == null)
			{
				return true;
			}
			if (resolvedType2 != null && methodsExplicitAndVariadicParameterType.isPrimitive() == resolvedType2.isPrimitive() && methodsExplicitAndVariadicParameterType2.isPrimitive() != resolvedType2.isPrimitive() && methodsExplicitAndVariadicParameterType.isAssignableBy(resolvedType2))
			{
				return true;
			}
			if (resolvedType2 != null && methodsExplicitAndVariadicParameterType2.isPrimitive() == resolvedType2.isPrimitive() && methodsExplicitAndVariadicParameterType.isPrimitive() != resolvedType2.isPrimitive() && methodsExplicitAndVariadicParameterType2.isAssignableBy(resolvedType2))
			{
				return false;
			}
			if (i < num3 - 1 && (isJavaLangObject(methodsExplicitAndVariadicParameterType2) || isJavaLangObject(methodsExplicitAndVariadicParameterType)))
			{
				num6 = ((num6 != 0 || isJavaLangObject(methodsExplicitAndVariadicParameterType2)) ? 1 : 0);
				continue;
			}
			int num7 = (methodsExplicitAndVariadicParameterType.isAssignableBy(methodsExplicitAndVariadicParameterType2) ? 1 : 0);
			int num8 = (methodsExplicitAndVariadicParameterType2.isAssignableBy(methodsExplicitAndVariadicParameterType) ? 1 : 0);
			if (num8 != 0 && num7 == 0)
			{
				return true;
			}
			if (num7 != 0 && num8 == 0)
			{
				return false;
			}
		}
		if (num != 0 && num2 == 0)
		{
			return (byte)num4 != 0;
		}
		if (num == 0 && num2 != 0)
		{
			return (num4 == 0) ? true : false;
		}
		return (byte)num6 != 0;
	}

	
	
	private static ResolvedType getMethodsExplicitAndVariadicParameterType(ResolvedMethodDeclaration P_0, int P_1)
	{
		int numberOfParams = P_0.getNumberOfParams();
		if (P_1 < numberOfParams)
		{
			ResolvedType type = P_0.getParam(P_1).getType();
			
			return type;
		}
		if (P_0.hasVariadicParameter())
		{
			ResolvedType type2 = P_0.getParam(numberOfParams - 1).getType();
			
			return type2;
		}
		return null;
	}

	
	
	private static bool isJavaLangObject(ResolvedType P_0)
	{
		return (P_0.isReferenceType() && String.instancehelper_equals(P_0.asReferenceType().getQualifiedName(), "java.lang.Object")) ? true : false;
	}

	
	[LineNumberTable(new byte[]
	{
		162, 148, 98, 110, 104, 136, 105, 169, 104, 162,
		104, 194, 123, 226, 46, 233, 85
	})]
	private static bool isMoreSpecific(MethodUsage P_0, MethodUsage P_1)
	{
		int result = 0;
		for (int i = 0; i < P_0.getNoParams(); i++)
		{
			ResolvedType paramType = P_0.getParamType(i);
			ResolvedType paramType2 = P_1.getParamType(i);
			int num = (paramType.isAssignableBy(paramType2) ? 1 : 0);
			int num2 = (paramType2.isAssignableBy(paramType) ? 1 : 0);
			if (num2 != 0 && num == 0)
			{
				result = 1;
			}
			if (num != 0 && num2 == 0)
			{
				return false;
			}
			if (paramType2.isArray() && paramType2.asArrayType().getComponentType().isAssignableBy(paramType))
			{
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	
	[LineNumberTable(new byte[]
	{
		162, 205, 115, 130, 110, 130, 107, 127, 5, 2,
		230, 69
	})]
	private static bool areOverride(MethodUsage P_0, MethodUsage P_1)
	{
		if (!String.instancehelper_equals(P_0.getName(), P_1.getName()))
		{
			return false;
		}
		if (P_0.getNoParams() != P_1.getNoParams())
		{
			return false;
		}
		for (int i = 0; i < P_0.getNoParams(); i++)
		{
			if (!Object.instancehelper_equals((ResolvedType)P_0.getParamTypes().get(i), P_1.getParamTypes().get(i)))
			{
				return false;
			}
		}
		return true;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 21, 110, 194, 103, 167, 103, 167, 172, 103,
		226, 69, 104, 194, 107, 175, 110, 132, 172, 233,
		69, 117, 132, 238, 69, 109, 147, 100, 100, 167,
		107, 111, 105, 137, 101, 130, 142, 246, 54, 235,
		77, 127, 6, 110, 119, 162, 127, 4, 142, 127,
		12, 111, 116, 137, 185, 151, 98, 139, 165, 100,
		127, 4, 110, 127, 7, 111, 116, 105, 148, 159,
		2, 98, 139, 165, 111, 107, 107, 103, 226, 159,
		166, 235, 160, 95
	})]
	public static bool isApplicable(MethodUsage methodUsage, string needleName, List needleParameterTypes, TypeSolver typeSolver)
	{
		if (!String.instancehelper_equals(methodUsage.getName(), needleName))
		{
			return false;
		}
		int noParams = methodUsage.getNoParams();
		int lastParameterIndex = getLastParameterIndex(noParams);
		int num = needleParameterTypes.size();
		getLastParameterIndex(num);
		int num2 = (methodUsage.getDeclaration().hasVariadicParameter() ? 1 : 0);
		if (num2 == 0 && num != noParams)
		{
			return false;
		}
		if (num != noParams && num < lastParameterIndex)
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			ResolvedType other = (ResolvedType)needleParameterTypes.get(i);
			ResolvedType resolvedType;
			if ((num2 == 0 || i < lastParameterIndex) && 0 == 0)
			{
				resolvedType = methodUsage.getParamType(i);
			}
			else
			{
				resolvedType = methodUsage.getParamType(lastParameterIndex);
				if ((num != noParams || !resolvedType.isAssignableBy(other)) && 0 == 0)
				{
					resolvedType = resolvedType.asArrayType().getComponentType();
				}
			}
			List typeParameters = methodUsage.getDeclaration().getTypeParameters();
			typeParameters.addAll(methodUsage.declaringType().getTypeParameters());
			ResolvedType resolvedType2 = resolvedType;
			ResolvedType resolvedType3 = resolvedType;
			HashMap hashMap = new HashMap();
			for (int j = 0; j < noParams; j++)
			{
				ResolvedParameterDeclaration param = methodUsage.getDeclaration().getParam(j);
				ResolvedType resolvedType4 = param.getType();
				if (param.isVariadic())
				{
					if (num == j)
					{
						break;
					}
					resolvedType4 = resolvedType4.asArrayType().getComponentType();
				}
				inferTypes((ResolvedType)needleParameterTypes.get(j), resolvedType4, hashMap);
			}
			Iterator iterator = ((Map)hashMap).entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)entry.getKey();
				resolvedType3 = resolvedType3.replaceTypeVariables(tp, (ResolvedType)entry.getValue());
			}
			iterator = typeParameters.iterator();
			while (iterator.hasNext())
			{
				ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
				if (resolvedTypeParameterDeclaration.getBounds().isEmpty())
				{
					ResolvedType resolvedType5 = resolvedType;
					ReferenceTypeImpl.___003Cclinit_003E();
					resolvedType = resolvedType5.replaceTypeVariables(resolvedTypeParameterDeclaration, ResolvedWildcard.extendsBound(new ReferenceTypeImpl(typeSolver.solveType(JAVA_LANG_OBJECT), typeSolver)));
					continue;
				}
				if (resolvedTypeParameterDeclaration.getBounds().size() == 1)
				{
					ResolvedTypeParameterDeclaration.Bound bound = (ResolvedTypeParameterDeclaration.Bound)resolvedTypeParameterDeclaration.getBounds().get(0);
					resolvedType = ((!bound.isExtends()) ? resolvedType.replaceTypeVariables(resolvedTypeParameterDeclaration, ResolvedWildcard.superBound(bound.getType())) : resolvedType.replaceTypeVariables(resolvedTypeParameterDeclaration, ResolvedWildcard.extendsBound(bound.getType())));
					continue;
				}
				
				throw new UnsupportedOperationException();
			}
			ResolvedType resolvedType6 = resolvedType2;
			Iterator iterator2 = typeParameters.iterator();
			while (iterator2.hasNext())
			{
				ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)iterator2.next();
				if (tp.getBounds().isEmpty())
				{
					ResolvedType resolvedType7 = resolvedType6;
					ResolvedTypeParameterDeclaration tp2 = tp;
					ReferenceTypeImpl.___003Cclinit_003E();
					resolvedType6 = resolvedType7.replaceTypeVariables(tp2, new ReferenceTypeImpl(typeSolver.solveType(JAVA_LANG_OBJECT), typeSolver));
					continue;
				}
				if (tp.getBounds().size() == 1)
				{
					ResolvedTypeParameterDeclaration.Bound bound2 = (ResolvedTypeParameterDeclaration.Bound)tp.getBounds().get(0);
					if (bound2.isExtends())
					{
						resolvedType6 = resolvedType6.replaceTypeVariables(tp, bound2.getType());
						continue;
					}
					ResolvedType resolvedType8 = resolvedType6;
					ResolvedTypeParameterDeclaration tp3 = tp;
					ReferenceTypeImpl.___003Cclinit_003E();
					resolvedType6 = resolvedType8.replaceTypeVariables(tp3, new ReferenceTypeImpl(typeSolver.solveType(JAVA_LANG_OBJECT), typeSolver));
					continue;
				}
				
				throw new UnsupportedOperationException();
			}
			if (!resolvedType.isAssignableBy(other) && !resolvedType6.isAssignableBy(other) && !resolvedType3.isAssignableBy(other) && !resolvedType2.isAssignableBy(other))
			{
				return false;
			}
		}
		return true;
	}

	
	
	
	private static ResolvedType lambda_0024replaceTypeParam_00240(ResolvedTypeParameterDeclaration P_0, TypeSolver P_1, ResolvedType P_2)
	{
		ResolvedType result = replaceTypeParam(P_2, P_0, P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024distinctByKey_00241(Set P_0, Function P_1, object P_2)
	{
		bool result = P_0.add(P_1.apply(P_2));
		
		return result;
	}

	
	
	
	private static bool lambda_0024findMostApplicable_00242(string P_0, ResolvedMethodDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findMostApplicable_00243(string P_0, List P_1, TypeSolver P_2, bool P_3, ResolvedMethodDeclaration P_4)
	{
		bool result = isApplicable(P_4, P_0, P_1, P_2, P_3);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findMostApplicableUsage_00244(string P_0, List P_1, TypeSolver P_2, MethodUsage P_3)
	{
		bool result = isApplicable(P_3, P_0, P_1, P_2);
		
		return result;
	}

	
	
	public MethodResolutionLogic()
	{
	}

	
		
	public static bool isApplicable(ResolvedMethodDeclaration method, string name, List argumentsTypes, TypeSolver typeSolver)
	{
		bool result = isApplicable(method, name, argumentsTypes, typeSolver, false);
		
		return result;
	}

	
	static MethodResolutionLogic()
	{
		JAVA_LANG_OBJECT = ClassLiteral<Object>.Value.getCanonicalName();
	}
}
