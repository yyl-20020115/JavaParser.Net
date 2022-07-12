
using com.github.javaparser.resolution.types;

using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class TypeContainedByType : ConstraintFormula
{
	private ResolvedType S;

	private ResolvedType T;

	
	
	public TypeContainedByType()
	{
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		if (TypeHelper.isProperType(T) && !T.isWildcard())
		{
			
			throw new UnsupportedOperationException();
		}
		if (T.isWildcard() && !T.asWildcard().isBounded())
		{
			ReductionResult result = ReductionResult.trueResult();
			
			return result;
		}
		if (T.isWildcard() && T.asWildcard().isExtends())
		{
			
			throw new UnsupportedOperationException();
		}
		if (T.isWildcard() && T.asWildcard().isSuper())
		{
			
			throw new UnsupportedOperationException();
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
		TypeContainedByType typeContainedByType = (TypeContainedByType)o;
		if (!Object.instancehelper_equals(S, typeContainedByType.S))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, typeContainedByType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(S);
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("TypeContainedByType{S=").append(S).append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
