using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

public class SameAsBound : Bound
{
	private ResolvedType s;

	private ResolvedType t;

	
		
	public override Optional isAnInstantiation()
	{
		if (s.isInferenceVariable() && TypeHelper.isProperType(t))
		{
			Optional result = Optional.of(new Instantiation((InferenceVariable)s, t));
			
			return result;
		}
		if (TypeHelper.isProperType(s) && t.isInferenceVariable())
		{
			Optional result2 = Optional.of(new Instantiation((InferenceVariable)t, s));
			
			return result2;
		}
		Optional result3 = Optional.empty();
		
		return result3;
	}

	
	
	public SameAsBound(ResolvedType s, ResolvedType t)
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
		SameAsBound sameAsBound = (SameAsBound)o;
		if (!Object.instancehelper_equals(s, sameAsBound.s))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(t, sameAsBound.t);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("SameAsBound{s=").append(s).append(", t=")
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

	
		
	public override Set usedInferenceVariables()
	{
		HashSet hashSet = new HashSet();
		((Set)hashSet).addAll((Collection)TypeHelper.usedInferenceVariables(s));
		((Set)hashSet).addAll((Collection)TypeHelper.usedInferenceVariables(t));
		return hashSet;
	}

	public virtual ResolvedType getS()
	{
		return s;
	}

	public virtual ResolvedType getT()
	{
		return t;
	}

	
	
	public override bool isADependency()
	{
		return (!isAnInstantiation().isPresent()) ? true : false;
	}

	
	
	public override bool isSatisfied(InferenceVariableSubstitution inferenceVariableSubstitution)
	{
		
		throw new UnsupportedOperationException();
	}
}
