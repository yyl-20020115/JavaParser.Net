

using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.bounds;

public class FalseBound : Bound
{
	private static FalseBound INSTANCE;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public static FalseBound getInstance()
	{
		return INSTANCE;
	}

	
	
	private FalseBound()
	{
	}

	public override string ToString()
	{
		return "FalseBound{}";
	}

	public override bool isSatisfied(InferenceVariableSubstitution inferenceVariableSubstitution)
	{
		return false;
	}

	
		
	public override Set usedInferenceVariables()
	{
		Set result = Collections.emptySet();
		
		return result;
	}

	
	static FalseBound()
	{
		INSTANCE = new FalseBound();
	}
}
