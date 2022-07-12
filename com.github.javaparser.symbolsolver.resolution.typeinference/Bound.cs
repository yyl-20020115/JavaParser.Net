
using com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public abstract class Bound
{
	
		
	public virtual Optional isAnInstantiation()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional isProperLowerBound()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional isProperUpperBound()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	public Bound()
	{
	}

	
	
	internal static Bound falseBound()
	{
		FalseBound instance = FalseBound.getInstance();
		
		return instance;
	}

	public abstract bool isSatisfied(InferenceVariableSubstitution ivs);

	
	
	internal virtual bool isAnInstantiationFor(InferenceVariable P_0)
	{
		return (isAnInstantiation().isPresent() && ((Instantiation)isAnInstantiation().get()).getInferenceVariable().equals(P_0)) ? true : false;
	}

	
		
	internal virtual Optional isProperLowerBoundFor(InferenceVariable P_0)
	{
		Optional optional = isProperLowerBound();
		if (optional.isPresent() && ((ProperLowerBound)optional.get()).getInferenceVariable().equals(P_0))
		{
			return optional;
		}
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	internal virtual Optional isProperUpperBoundFor(InferenceVariable P_0)
	{
		Optional optional = isProperUpperBound();
		if (optional.isPresent() && ((ProperUpperBound)optional.get()).getInferenceVariable().equals(P_0))
		{
			return optional;
		}
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isADependency()
	{
		return false;
	}

	internal virtual bool isThrowsBoundOn(InferenceVariable P_0)
	{
		return false;
	}

		public abstract Set usedInferenceVariables();
}
