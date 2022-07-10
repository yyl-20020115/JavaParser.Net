using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

public class SubtypeOfBound : Bound
{
	private ResolvedType s;

	private ResolvedType t;

	
		
	public override Optional isProperLowerBound()
	{
		if (TypeHelper.isProperType(s) && t.isInferenceVariable())
		{
			Optional result = Optional.of(new ProperLowerBound((InferenceVariable)t, s));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public override Optional isProperUpperBound()
	{
		if (s.isInferenceVariable() && TypeHelper.isProperType(t))
		{
			Optional result = Optional.of(new ProperUpperBound((InferenceVariable)s, t));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	public SubtypeOfBound(ResolvedType s, ResolvedType t)
	{
		if (!s.isInferenceVariable() && !t.isInferenceVariable())
		{
			
			throw new IllegalArgumentException("One of S or T should be an inference variable");
		}
		this.s = s;
		this.t = t;
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
		SubtypeOfBound subtypeOfBound = (SubtypeOfBound)o;
		if (!Object.instancehelper_equals(s, subtypeOfBound.s))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(t, subtypeOfBound.t);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("SubtypeOfBound{s=").append(s).append(", t=")
			.append(t)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(s);
		return 31 * num + Object.instancehelper_hashCode(t);
	}

	public virtual ResolvedType getS()
	{
		return s;
	}

	
		
	public override Set usedInferenceVariables()
	{
		HashSet hashSet = new HashSet();
		((Set)hashSet).addAll((Collection)TypeHelper.usedInferenceVariables(s));
		((Set)hashSet).addAll((Collection)TypeHelper.usedInferenceVariables(t));
		return hashSet;
	}

	public virtual ResolvedType getT()
	{
		return t;
	}

	
	
	public override bool isADependency()
	{
		return (!isProperLowerBound().isPresent() && !isProperUpperBound().isPresent()) ? true : false;
	}

	
	
	public override bool isSatisfied(InferenceVariableSubstitution inferenceVariableSubstitution)
	{
		
		throw new UnsupportedOperationException();
	}
}
