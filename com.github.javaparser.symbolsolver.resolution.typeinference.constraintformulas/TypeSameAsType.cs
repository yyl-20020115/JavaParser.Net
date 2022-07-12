
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class TypeSameAsType : ConstraintFormula
{
	private ResolvedType S;

	private ResolvedType T;

	
	
	public TypeSameAsType(ResolvedType s, ResolvedType t)
	{
		S = s;
		T = t;
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		if (!S.isWildcard() && !T.isWildcard())
		{
			if (TypeHelper.isProperType(S) && TypeHelper.isProperType(T))
			{
				if (Object.instancehelper_equals(S, T))
				{
					ReductionResult result = ReductionResult.trueResult();
					
					return result;
				}
				ReductionResult result2 = ReductionResult.falseResult();
				
				return result2;
			}
			if (S.isNull() || T.isNull())
			{
				ReductionResult result3 = ReductionResult.falseResult();
				
				return result3;
			}
			if (S.isInferenceVariable() && !T.isPrimitive())
			{
				ReductionResult result4 = ReductionResult.oneBound(new SameAsBound(S, T));
				
				return result4;
			}
			if (T.isInferenceVariable() && !S.isPrimitive())
			{
				ReductionResult result5 = ReductionResult.oneBound(new SameAsBound(S, T));
				
				return result5;
			}
			if (S.isReferenceType() && T.isReferenceType() && Object.instancehelper_equals(S.asReferenceType().toRawType(), T.asReferenceType().toRawType()))
			{
				ReductionResult reductionResult = ReductionResult.empty();
				List list = S.asReferenceType().typeParametersValues();
				List list2 = T.asReferenceType().typeParametersValues();
				for (int i = 0; i < list.size(); i++)
				{
					reductionResult = reductionResult.withConstraint(new TypeSameAsType((ResolvedType)list.get(i), (ResolvedType)list2.get(i)));
				}
				return reductionResult;
			}
			if (S.isArray() && T.isArray())
			{
				ReductionResult result6 = ReductionResult.oneConstraint(new TypeSameAsType(S.asArrayType().getComponentType(), T.asArrayType().getComponentType()));
				
				return result6;
			}
			ReductionResult result7 = ReductionResult.falseResult();
			
			return result7;
		}
		
		throw new UnsupportedOperationException();
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		TypeSameAsType typeSameAsType = (TypeSameAsType)o;
		if (!Object.instancehelper_equals(S, typeSameAsType.S))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, typeSameAsType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(S);
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("TypeSameAsType{S=").append(S).append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
