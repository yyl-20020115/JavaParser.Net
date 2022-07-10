using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class TypeInferenceCache
{
		private static Map typeForLambdaParameters;

		private static Map inferenceVariables;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public static void addRecord(TypeSolver typeSolver, LambdaExpr lambdaExpr, string paramName, ResolvedType type)
	{
		if (!typeForLambdaParameters.containsKey(typeSolver))
		{
			typeForLambdaParameters.put(typeSolver, new IdentityHashMap());
		}
		if (!((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).containsKey(lambdaExpr))
		{
			((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).put(lambdaExpr, new HashMap());
		}
		((Map)((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).get(lambdaExpr)).put(paramName, type);
	}

	
		
	public static void recordInferenceVariables(TypeSolver typeSolver, LambdaExpr lambdaExpr, List _inferenceVariables)
	{
		if (!inferenceVariables.containsKey(typeSolver))
		{
			inferenceVariables.put(typeSolver, new IdentityHashMap());
		}
		((IdentityHashMap)inferenceVariables.get(typeSolver)).put(lambdaExpr, _inferenceVariables);
	}

	
	
	public TypeInferenceCache()
	{
	}

	
		
	public static Optional retrieve(TypeSolver typeSolver, LambdaExpr lambdaExpr, string paramName)
	{
		if (!typeForLambdaParameters.containsKey(typeSolver))
		{
			Optional result = Optional.empty();
			
			return result;
		}
		if (!((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).containsKey(lambdaExpr))
		{
			Optional result2 = Optional.empty();
			
			return result2;
		}
		if (!((Map)((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).get(lambdaExpr)).containsKey(paramName))
		{
			Optional result3 = Optional.empty();
			
			return result3;
		}
		Optional result4 = Optional.of(((Map)((IdentityHashMap)typeForLambdaParameters.get(typeSolver)).get(lambdaExpr)).get(paramName));
		
		return result4;
	}

	
		
	public static Optional retrieveInferenceVariables(TypeSolver typeSolver, LambdaExpr lambdaExpr)
	{
		if (!inferenceVariables.containsKey(typeSolver))
		{
			Optional result = Optional.empty();
			
			return result;
		}
		if (!((IdentityHashMap)inferenceVariables.get(typeSolver)).containsKey(lambdaExpr))
		{
			Optional result2 = Optional.empty();
			
			return result2;
		}
		Optional result3 = Optional.of(((IdentityHashMap)inferenceVariables.get(typeSolver)).get(lambdaExpr));
		
		return result3;
	}

	
	static TypeInferenceCache()
	{
		typeForLambdaParameters = new HashMap();
		inferenceVariables = new HashMap();
	}
}
