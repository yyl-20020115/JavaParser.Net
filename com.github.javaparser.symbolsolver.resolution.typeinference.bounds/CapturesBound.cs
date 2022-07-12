

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

public class CapturesBound : Bound
{
		private List inferenceVariables;

		private List typesOrWildcards;

	
		
	public CapturesBound(List inferenceVariables, List typesOrWildcards)
	{
		this.inferenceVariables = inferenceVariables;
		this.typesOrWildcards = typesOrWildcards;
	}

	
	
	public override bool isSatisfied(InferenceVariableSubstitution inferenceVariableSubstitution)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public override Set usedInferenceVariables()
	{
		
		throw new UnsupportedOperationException();
	}

		public virtual List getInferenceVariables()
	{
		return inferenceVariables;
	}

		public virtual List getTypesOrWildcards()
	{
		return typesOrWildcards;
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
		CapturesBound capturesBound = (CapturesBound)o;
		if (!inferenceVariables.equals(capturesBound.inferenceVariables))
		{
			return false;
		}
		bool result = typesOrWildcards.equals(capturesBound.typesOrWildcards);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = inferenceVariables.GetHashCode();
		return 31 * num + typesOrWildcards.GetHashCode();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("CapturesBound{inferenceVariables=").append(inferenceVariables).append(", typesOrWildcards=")
			.append(typesOrWildcards)
			.append('}')
			.ToString();
		
		return result;
	}
}
