using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.resolution.types;

public class ResolvedType
{
	private static class ___003C_003EPIM
	{
		
		internal unsafe static bool _003Cpiim_003Elambda_0024isNumericType_00240(ResolvedType rpt, ResolvedPrimitiveType P_1)
		{
			
			bool result = P_1.isAssignableBy(rpt);
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static bool isArray(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisArray(P_0);
		}

		public unsafe static int arrayLevel(ResolvedType P_0)
		{
			
			return _003Cdefault_003EarrayLevel(P_0);
		}

		public unsafe static bool isPrimitive(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisPrimitive(P_0);
		}

		public unsafe static bool isNull(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisNull(P_0);
		}

		public unsafe static bool isUnionType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisUnionType(P_0);
		}

		public unsafe static bool isReference(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisReference(P_0);
		}

		public unsafe static bool isConstraint(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisConstraint(P_0);
		}

		public unsafe static bool isReferenceType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisReferenceType(P_0);
		}

		public unsafe static bool isVoid(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisVoid(P_0);
		}

		public unsafe static bool isTypeVariable(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisTypeVariable(P_0);
		}

		public unsafe static bool isWildcard(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisWildcard(P_0);
		}

		public unsafe static bool isInferenceVariable(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisInferenceVariable(P_0);
		}

		public unsafe static ResolvedArrayType asArrayType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasArrayType(P_0);
		}

		public unsafe static ResolvedReferenceType asReferenceType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasReferenceType(P_0);
		}

		public unsafe static ResolvedTypeParameterDeclaration asTypeParameter(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasTypeParameter(P_0);
		}

		public unsafe static ResolvedTypeVariable asTypeVariable(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasTypeVariable(P_0);
		}

		public unsafe static ResolvedPrimitiveType asPrimitive(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasPrimitive(P_0);
		}

		public unsafe static ResolvedWildcard asWildcard(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasWildcard(P_0);
		}

		public unsafe static ResolvedLambdaConstraintType asConstraintType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasConstraintType(P_0);
		}

		public unsafe static ResolvedUnionType asUnionType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EasUnionType(P_0);
		}

		public unsafe static ResolvedType replaceTypeVariables(ResolvedType P_0, ResolvedTypeParameterDeclaration P_1, ResolvedType P_2, Map P_3)
		{
			
			return _003Cdefault_003EreplaceTypeVariables(P_0, P_1, P_2, P_3);
		}

		public unsafe static ResolvedType replaceTypeVariables(ResolvedType P_0, ResolvedTypeParameterDeclaration P_1, ResolvedType P_2)
		{
			
			return _003Cdefault_003EreplaceTypeVariables(P_0, P_1, P_2);
		}

		public unsafe static bool mention(ResolvedType P_0, List P_1)
		{
			
			return _003Cdefault_003Emention(P_0, P_1);
		}

		public unsafe static bool isNumericType(ResolvedType P_0)
		{
			
			return _003Cdefault_003EisNumericType(P_0);
		}

		public unsafe static ResolvedType erasure(ResolvedType P_0)
		{
			
			return _003Cdefault_003Eerasure(P_0);
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
			bool result = ___003C_003EPIM._003Cpiim_003Elambda_0024isNumericType_00240(arg_00241, (ResolvedPrimitiveType)P_0);
			
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

	
	virtual bool isAssignableBy(ResolvedType other);

	
	virtual ResolvedReferenceType asReferenceType();

	
	
	
	static ResolvedReferenceType _003Cdefault_003EasReferenceType(ResolvedType P_0)
	{
		string message = String.format("%s is not a Reference Type", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedArrayType asArrayType();

	
	
	
	static ResolvedArrayType _003Cdefault_003EasArrayType(ResolvedType P_0)
	{
		string message = String.format("%s is not an Array", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	virtual string describe();

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tp, ResolvedType replaced, Map inferredTypes);

	
	static ResolvedType _003Cdefault_003EreplaceTypeVariables(ResolvedType P_0, ResolvedTypeParameterDeclaration P_1, ResolvedType P_2, Map P_3)
	{
		return P_0;
	}

	
	virtual bool isArray();

	
	static bool _003Cdefault_003EisArray(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isTypeVariable();

	
	static bool _003Cdefault_003EisTypeVariable(ResolvedType P_0)
	{
		return false;
	}

	
	virtual ResolvedTypeParameterDeclaration asTypeParameter();

	
	
	
	static ResolvedTypeParameterDeclaration _003Cdefault_003EasTypeParameter(ResolvedType P_0)
	{
		string message = String.format("%s is not a Type parameter", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual bool isWildcard();

	
	static bool _003Cdefault_003EisWildcard(ResolvedType P_0)
	{
		return false;
	}

	
	virtual ResolvedWildcard asWildcard();

	
	
	
	static ResolvedWildcard _003Cdefault_003EasWildcard(ResolvedType P_0)
	{
		string message = String.format("%s is not a Wildcard", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual bool isReferenceType();

	
	static bool _003Cdefault_003EisReferenceType(ResolvedType P_0)
	{
		return false;
	}

	
	virtual int arrayLevel();

	
	
	
	static int _003Cdefault_003EarrayLevel(ResolvedType P_0)
	{
		if (P_0.isArray())
		{
			return 1 + P_0.asArrayType().getComponentType().arrayLevel();
		}
		return 0;
	}

	
	virtual bool isNull();

	
	static bool _003Cdefault_003EisNull(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isUnionType();

	
	static bool _003Cdefault_003EisUnionType(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isPrimitive();

	
	static bool _003Cdefault_003EisPrimitive(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isReference();

	
	
	
	static bool _003Cdefault_003EisReference(ResolvedType P_0)
	{
		return (P_0.isReferenceType() || P_0.isArray() || P_0.isTypeVariable() || P_0.isNull() || P_0.isWildcard() || P_0.isUnionType()) ? true : false;
	}

	
	virtual bool isConstraint();

	
	static bool _003Cdefault_003EisConstraint(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isVoid();

	
	static bool _003Cdefault_003EisVoid(ResolvedType P_0)
	{
		return false;
	}

	
	virtual bool isInferenceVariable();

	
	static bool _003Cdefault_003EisInferenceVariable(ResolvedType P_0)
	{
		return false;
	}

	
	virtual ResolvedTypeVariable asTypeVariable();

	
	
	
	static ResolvedTypeVariable _003Cdefault_003EasTypeVariable(ResolvedType P_0)
	{
		string message = String.format("%s is not a Type variable", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedPrimitiveType asPrimitive();

	
	
	
	static ResolvedPrimitiveType _003Cdefault_003EasPrimitive(ResolvedType P_0)
	{
		string message = String.format("%s is not a Primitive type", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedLambdaConstraintType asConstraintType();

	
	
	
	static ResolvedLambdaConstraintType _003Cdefault_003EasConstraintType(ResolvedType P_0)
	{
		string message = String.format("%s is not a constraint type", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedUnionType asUnionType();

	
	
	
	static ResolvedUnionType _003Cdefault_003EasUnionType(ResolvedType P_0)
	{
		string message = String.format("%s is not a union type", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tp, ResolvedType replaced);

	
	
	
	static ResolvedType _003Cdefault_003EreplaceTypeVariables(ResolvedType P_0, ResolvedTypeParameterDeclaration P_1, ResolvedType P_2)
	{
		ResolvedType result = P_0.replaceTypeVariables(P_1, P_2, new HashMap());
		
		return result;
	}

	
		
	virtual bool mention(List typeParameters);

	
	
	
	static bool _003Cdefault_003Emention(ResolvedType P_0, List P_1)
	{
		string canonicalName = Object.instancehelper_getClass(P_0).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	virtual bool isNumericType();

	
	
	
	static bool _003Cdefault_003EisNumericType(ResolvedType P_0)
	{
		bool result = Arrays.stream(ResolvedPrimitiveType.getNumericPrimitiveTypes()).anyMatch(new ___003C_003EAnon1(P_0));
		
		return result;
	}

	
	virtual ResolvedType erasure();

	
	static ResolvedType _003Cdefault_003Eerasure(ResolvedType P_0)
	{
		return P_0;
	}
}
