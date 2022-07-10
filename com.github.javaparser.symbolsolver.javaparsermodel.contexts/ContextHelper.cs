using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.core.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ContextHelper
{
	
	
	private ContextHelper()
	{
	}

	
		
	public static Optional solveMethodAsUsage(ResolvedTypeDeclaration typeDeclaration, string name, List argumentsTypes, Context invokationContext, List typeParameters)
	{
		if (typeDeclaration is MethodUsageResolutionCapability)
		{
			Optional result = ((MethodUsageResolutionCapability)typeDeclaration).solveMethodAsUsage(name, argumentsTypes, invokationContext, typeParameters);
			
			return result;
		}
		string message = Object.instancehelper_toString(typeDeclaration);
		
		throw new UnsupportedOperationException(message);
	}
}
