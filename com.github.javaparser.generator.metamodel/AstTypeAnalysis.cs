using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
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

	
	[LineNumberTable(new byte[]
	{
		159, 186, 232, 59, 103, 103, 199, 104, 108, 101,
		135, 101, 107, 103, 103, 104, 135, 104, 167, 111,
		104, 103, 130, 106, 133, 108, 118
	})]
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
