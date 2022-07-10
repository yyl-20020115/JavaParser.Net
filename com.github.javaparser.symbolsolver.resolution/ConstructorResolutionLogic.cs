using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.resolution;

public class ConstructorResolutionLogic
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly List arg_00241;

		private readonly TypeSolver arg_00242;

		private readonly bool arg_00243;

		internal ___003C_003EAnon0(List P_0, TypeSolver P_1, bool P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMostApplicable_00240(arg_00241, arg_00242, arg_00243, (ResolvedConstructorDeclaration)P_0);
			
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

	
		
	public static SymbolReference findMostApplicable(List constructors, List argumentsTypes, TypeSolver typeSolver)
	{
		SymbolReference symbolReference = findMostApplicable(constructors, argumentsTypes, typeSolver, wildcardTolerance: false);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		SymbolReference result = findMostApplicable(constructors, argumentsTypes, typeSolver, wildcardTolerance: true);
		
		return result;
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
		159, 124, 66, 107, 105, 145, 108, 109, 108, 127,
		5, 106, 98, 105, 106, 113, 149, 99, 42, 231,
		69, 98, 105, 130, 99, 209, 110, 130, 103, 99,
		112, 111, 111, 116, 108, 118, 133, 100, 127, 0,
		109, 111, 103, 98, 46, 167, 103, 127, 5, 108,
		98, 127, 10, 108, 130, 107, 117, 99, 130, 116,
		112, 162, 226, 30, 235, 102
	})]
	private static bool isApplicable(ResolvedConstructorDeclaration P_0, List P_1, TypeSolver P_2, bool P_3)
	{
		if (P_0.hasVariadicParameter())
		{
			int num = P_0.getNumberOfParams() - 1;
			if (P_0.getNumberOfParams() == P_1.size())
			{
				ResolvedType resolvedType = P_0.getLastParam().getType();
				ResolvedType resolvedType2 = (ResolvedType)P_1.get(num);
				if (!resolvedType.isAssignableBy(resolvedType2))
				{
					Iterator iterator = P_0.getTypeParameters().iterator();
					while (iterator.hasNext())
					{
						ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)iterator.next();
						resolvedType = MethodResolutionLogic.replaceTypeParam(resolvedType, tp, P_2);
					}
					if (!resolvedType.isAssignableBy(resolvedType2))
					{
						if (resolvedType2.isArray() && resolvedType.isAssignableBy(resolvedType2.asArrayType().getComponentType()))
						{
							P_1.set(num, resolvedType2.asArrayType().getComponentType());
						}
						else
						{
							P_1 = groupVariadicParamValues(P_1, num, P_0.getLastParam().getType());
						}
					}
				}
			}
			else
			{
				if (num > P_1.size())
				{
					return false;
				}
				P_1 = groupVariadicParamValues(P_1, num, P_0.getLastParam().getType());
			}
		}
		if (P_0.getNumberOfParams() != P_1.size())
		{
			return false;
		}
		HashMap hashMap = new HashMap();
		int num2 = 0;
		for (int i = 0; i < P_0.getNumberOfParams(); i++)
		{
			ResolvedType resolvedType3 = P_0.getParam(i).getType();
			ResolvedType resolvedType4 = (ResolvedType)P_1.get(i);
			if (resolvedType3.isTypeVariable() && !resolvedType3.isWildcard() && resolvedType3.asTypeParameter().declaredOnMethod())
			{
				((Map)hashMap).put((object)resolvedType3.asTypeParameter().getName(), (object)resolvedType4);
				continue;
			}
			int num3 = ((resolvedType3.isAssignableBy(resolvedType4) || (P_0.getParam(i).isVariadic() && new ResolvedArrayType(resolvedType3).isAssignableBy(resolvedType4))) ? 1 : 0);
			if (num3 == 0 && resolvedType3.isReferenceType() && resolvedType4.isReferenceType())
			{
				num3 = (MethodResolutionLogic.isAssignableMatchTypeParameters(resolvedType3.asReferenceType(), resolvedType4.asReferenceType(), hashMap) ? 1 : 0);
			}
			if (num3 != 0)
			{
				continue;
			}
			Iterator iterator2 = P_0.getTypeParameters().iterator();
			while (iterator2.hasNext())
			{
				ResolvedTypeParameterDeclaration tp2 = (ResolvedTypeParameterDeclaration)iterator2.next();
				resolvedType3 = MethodResolutionLogic.replaceTypeParam(resolvedType3, tp2, P_2);
			}
			iterator2 = P_0.declaringType().getTypeParameters().iterator();
			while (iterator2.hasNext())
			{
				ResolvedTypeParameterDeclaration tp2 = (ResolvedTypeParameterDeclaration)iterator2.next();
				resolvedType3 = MethodResolutionLogic.replaceTypeParam(resolvedType3, tp2, P_2);
			}
			if (!resolvedType3.isAssignableBy(resolvedType4))
			{
				if (resolvedType4.isWildcard() && P_3 && !resolvedType3.isPrimitive())
				{
					num2 = 1;
				}
				else if (!P_0.hasVariadicParameter() || i != P_0.getNumberOfParams() - 1 || !new ResolvedArrayType(resolvedType3).isAssignableBy(resolvedType4))
				{
					return false;
				}
			}
		}
		return (!P_3 || num2 != 0) ? true : false;
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
		159,
		101,
		98,
		127,
		9,
		104,
		141,
		105,
		148,
		109,
		98,
		98,
		112,
		111,
		107,
		100,
		107,
		98,
		133,
		109,
		113,
		226,
		69,
		131,
		105,
		106,
		133,
		byte.MaxValue,
		23,
		43,
		235,
		91
	})]
	public static SymbolReference findMostApplicable(List constructors, List argumentsTypes, TypeSolver typeSolver, bool wildcardTolerance)
	{
		List list = (List)constructors.stream().filter(new ___003C_003EAnon0(argumentsTypes, typeSolver, wildcardTolerance)).collect(Collectors.toList());
		if (list.isEmpty())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedConstructorDeclaration>.Value);
			
			return result;
		}
		if (list.size() == 1)
		{
			SymbolReference result2 = SymbolReference.solved((ResolvedDeclaration)list.get(0));
			
			return result2;
		}
		ResolvedConstructorDeclaration resolvedConstructorDeclaration = (ResolvedConstructorDeclaration)list.get(0);
		
		int num = 0;
		for (int i = 1; i < list.size(); i++)
		{
			ResolvedConstructorDeclaration resolvedConstructorDeclaration2 = (ResolvedConstructorDeclaration)list.get(i);
			if (isMoreSpecific(resolvedConstructorDeclaration, resolvedConstructorDeclaration2, typeSolver))
			{
				num = 0;
			}
			else if (isMoreSpecific(resolvedConstructorDeclaration2, resolvedConstructorDeclaration, typeSolver))
			{
				num = 0;
				resolvedConstructorDeclaration = resolvedConstructorDeclaration2;
			}
			else if (String.instancehelper_equals(resolvedConstructorDeclaration.declaringType().getQualifiedName(), resolvedConstructorDeclaration2.declaringType().getQualifiedName()))
			{
				num = 1;
			}
			if (num != 0 && !MethodResolutionLogic.isExactMatch(resolvedConstructorDeclaration, argumentsTypes))
			{
				if (!MethodResolutionLogic.isExactMatch(resolvedConstructorDeclaration2, argumentsTypes))
				{
					string description = new StringBuilder().append("Ambiguous constructor call: cannot find a most applicable constructor: ").append(resolvedConstructorDeclaration).append(", ")
						.append(resolvedConstructorDeclaration2)
						.ToString();
					
					throw new MethodAmbiguityException(description);
				}
				resolvedConstructorDeclaration = resolvedConstructorDeclaration2;
			}
		}
		SymbolReference result3 = SymbolReference.solved(resolvedConstructorDeclaration);
		
		return result3;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 94, 98, 110, 130, 110, 130, 110, 109, 141,
		114, 162, 114, 162, 112, 162, 121, 226, 47, 233,
		84
	})]
	private static bool isMoreSpecific(ResolvedConstructorDeclaration P_0, ResolvedConstructorDeclaration P_1, TypeSolver P_2)
	{
		int result = 0;
		if (P_0.getNumberOfParams() < P_1.getNumberOfParams())
		{
			return true;
		}
		if (P_0.getNumberOfParams() > P_1.getNumberOfParams())
		{
			return false;
		}
		for (int i = 0; i < P_0.getNumberOfParams(); i++)
		{
			ResolvedType type = P_0.getParam(i).getType();
			ResolvedType type2 = P_1.getParam(i).getType();
			if (type2.isAssignableBy(type) && !type.isAssignableBy(type2))
			{
				result = 1;
			}
			if (type.isAssignableBy(type2) && !type2.isAssignableBy(type))
			{
				return false;
			}
			if (!type.isArray() && type2.isArray())
			{
				return true;
			}
			if (i == P_0.getNumberOfParams() - 1 && type.arrayLevel() > type2.arrayLevel())
			{
				return true;
			}
		}
		return (byte)result != 0;
	}

	
	
	
	private static bool lambda_0024findMostApplicable_00240(List P_0, TypeSolver P_1, bool P_2, ResolvedConstructorDeclaration P_3)
	{
		bool result = isApplicable(P_3, P_0, P_1, P_2);
		
		return result;
	}

	
	
	public ConstructorResolutionLogic()
	{
	}

	
		
	public static bool isApplicable(ResolvedConstructorDeclaration constructor, List argumentsTypes, TypeSolver typeSolver)
	{
		bool result = isApplicable(constructor, argumentsTypes, typeSolver, false);
		
		return result;
	}
}
