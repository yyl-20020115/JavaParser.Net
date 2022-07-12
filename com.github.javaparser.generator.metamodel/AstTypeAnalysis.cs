
using com.github.javaparser.ast;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.generator.metamodel;

internal class AstTypeAnalysis
{
	
	internal bool isAbstract;

	internal bool isOptional;

	internal bool isNodeList;

	internal bool isSelfType;

		internal Class innerType;

	
	
	internal AstTypeAnalysis(Type P_0)
	{
		isOptional = false;
		isNodeList = false;
		isSelfType = false;
		if (P_0 is Class)
		{
			TypeVariable[] typeParameters = ((Class)P_0).getTypeParameters();
			if ((nint)typeParameters.LongLength > 0)
			{
				isSelfType = true;
			}
		}
		else
		{
			while (P_0 is ParameterizedType)
			{
				ParameterizedType parameterizedType = (ParameterizedType)P_0;
				Type rawType = parameterizedType.getRawType();
				if (rawType == ClassLiteral<NodeList>.Value)
				{
					isNodeList = true;
				}
				if (rawType == ClassLiteral<Optional>.Value)
				{
					isOptional = true;
				}
				if (parameterizedType.getActualTypeArguments()[0] is WildcardType)
				{
					P_0 = parameterizedType.getRawType();
					isSelfType = true;
					break;
				}
				P_0 = parameterizedType.getActualTypeArguments()[0];
			}
		}
		innerType = (Class)P_0;
		isAbstract = java.lang.reflect.Modifier.isAbstract(innerType.getModifiers());
	}
}
