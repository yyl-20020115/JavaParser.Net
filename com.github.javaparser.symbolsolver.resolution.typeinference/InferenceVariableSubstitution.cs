
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class InferenceVariableSubstitution
{
	
	private static InferenceVariableSubstitution EMPTY;

		private List inferenceVariables;

		private List types;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	private InferenceVariableSubstitution()
	{
		inferenceVariables = new LinkedList();
		types = new LinkedList();
	}

	public static InferenceVariableSubstitution empty()
	{
		return EMPTY;
	}

	
	
	public virtual InferenceVariableSubstitution withPair(InferenceVariable inferenceVariable, ResolvedType type)
	{
		InferenceVariableSubstitution inferenceVariableSubstitution = new InferenceVariableSubstitution();
		inferenceVariableSubstitution.inferenceVariables.addAll(inferenceVariables);
		inferenceVariableSubstitution.types.addAll(types);
		inferenceVariableSubstitution.inferenceVariables.add(inferenceVariable);
		inferenceVariableSubstitution.types.add(type);
		return inferenceVariableSubstitution;
	}

	
	static InferenceVariableSubstitution()
	{
		EMPTY = new InferenceVariableSubstitution();
	}
}
