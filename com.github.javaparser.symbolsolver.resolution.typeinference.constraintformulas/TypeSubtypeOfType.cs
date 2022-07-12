
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class TypeSubtypeOfType : ConstraintFormula
{
	private ResolvedType S;

	private ResolvedType T;

	private TypeSolver typeSolver;

	
	
	public TypeSubtypeOfType(TypeSolver typeSolver, ResolvedType S, ResolvedType T)
	{
		this.typeSolver = typeSolver;
		this.S = S;
		this.T = T;
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		if (TypeHelper.isProperType(S) && TypeHelper.isProperType(T))
		{
			if (T.isAssignableBy(S))
			{
				ReductionResult result = ReductionResult.trueResult();
				
				return result;
			}
			ReductionResult result2 = ReductionResult.falseResult();
			
			return result2;
		}
		if (S is NullType)
		{
			ReductionResult result3 = ReductionResult.trueResult();
			
			return result3;
		}
		if (T is NullType)
		{
			ReductionResult result4 = ReductionResult.falseResult();
			
			return result4;
		}
		if (S.isInferenceVariable())
		{
			ReductionResult result5 = ReductionResult.oneBound(new SubtypeOfBound(S, T));
			
			return result5;
		}
		if (T.isInferenceVariable())
		{
			ReductionResult result6 = ReductionResult.oneBound(new SubtypeOfBound(S, T));
			
			return result6;
		}
		if (T.isTypeVariable())
		{
			if (S is ResolvedIntersectionType)
			{
				
				throw new UnsupportedOperationException();
			}
			if (T.asTypeVariable().asTypeParameter().hasLowerBound())
			{
				ReductionResult result7 = ReductionResult.oneConstraint(new TypeSubtypeOfType(typeSolver, S, T.asTypeVariable().asTypeParameter().getLowerBound()));
				
				return result7;
			}
			ReductionResult result8 = ReductionResult.falseResult();
			
			return result8;
		}
		string message = new StringBuilder().append("S = ").append(S).append(", T = ")
			.append(T)
			.ToString();
		
		throw new UnsupportedOperationException(message);
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
		TypeSubtypeOfType typeSubtypeOfType = (TypeSubtypeOfType)o;
		if (!Object.instancehelper_equals(S, typeSubtypeOfType.S))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, typeSubtypeOfType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(S);
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("TypeSubtypeOfType{S=").append(S).append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
