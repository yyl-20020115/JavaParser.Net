using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class Instantiation
{
	private InferenceVariable inferenceVariable;

	private ResolvedType properType;

	public virtual InferenceVariable getInferenceVariable()
	{
		return inferenceVariable;
	}

	
	
	public Instantiation(InferenceVariable inferenceVariable, ResolvedType properType)
	{
		this.inferenceVariable = inferenceVariable;
		this.properType = properType;
	}

	public virtual ResolvedType getProperType()
	{
		return properType;
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
		Instantiation instantiation = (Instantiation)o;
		if (!inferenceVariable.equals(instantiation.inferenceVariable))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(properType, instantiation.properType);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = inferenceVariable.GetHashCode();
		return 31 * num + Object.instancehelper_hashCode(properType);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Instantiation{inferenceVariable=").append(inferenceVariable).append(", properType=")
			.append(properType)
			.append('}')
			.ToString();
		
		return result;
	}
}
