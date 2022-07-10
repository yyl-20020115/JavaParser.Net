using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

public class ThrowsBound : Bound
{
	private InferenceVariable inferenceVariable;

	
	
	public ThrowsBound(InferenceVariable inferenceVariable)
	{
		this.inferenceVariable = inferenceVariable;
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
		ThrowsBound throwsBound = (ThrowsBound)o;
		bool result = inferenceVariable.equals(throwsBound.inferenceVariable);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ThrowsBound{inferenceVariable=").append(inferenceVariable).append('}')
			.ToString();
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = inferenceVariable.GetHashCode();
		
		return result;
	}

	
		
	public override Set usedInferenceVariables()
	{
		HashSet hashSet = new HashSet();
		((Set)hashSet).add((object)inferenceVariable);
		return hashSet;
	}

	
	
	public override bool isSatisfied(InferenceVariableSubstitution inferenceVariableSubstitution)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public new virtual bool isThrowsBoundOn(InferenceVariable inferenceVariable)
	{
		bool result = inferenceVariable.equals(this.inferenceVariable);
		
		return result;
	}
}
