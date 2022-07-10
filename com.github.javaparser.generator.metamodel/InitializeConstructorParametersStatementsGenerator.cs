using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;

namespace com.github.javaparser.generator.metamodel;

internal class InitializeConstructorParametersStatementsGenerator
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private static CallerID ___003CcallerID_003E;

	
		
	private Constructor findAllFieldsConstructor(Class P_0)
	{
		Constructor[] declaredConstructors = P_0.getDeclaredConstructors(InitializeConstructorParametersStatementsGenerator.___003CGetCallerID_003E());
		int num = declaredConstructors.Length;
		for (int i = 0; i < num; i++)
		{
			Constructor constructor = declaredConstructors[i];
			Annotation[] annotations = constructor.getAnnotations();
			int num2 = annotations.Length;
			for (int j = 0; j < num2; j++)
			{
				Annotation annotation = annotations[j];
				if (annotation.annotationType() == ClassLiteral<AllFieldsConstructor>.Value)
				{
					return constructor;
				}
			}
		}
		string detailMessage = CodeGenerationUtils.f("Node class %s has no constructor annotated with @AllFieldsConstructor", P_0.getSimpleName());
		
		throw new AssertionError(detailMessage);
	}

	
		
	private Field findFieldInClass(Class P_0, string P_1)
	{
		Class @class = P_0;
		do
		{
			Field[] declaredFields = @class.getDeclaredFields(InitializeConstructorParametersStatementsGenerator.___003CGetCallerID_003E());
			int num = declaredFields.Length;
			for (int i = 0; i < num; i++)
			{
				Field field = declaredFields[i];
				if (String.instancehelper_equals(field.getName(), P_1))
				{
					return field;
				}
			}
			@class = @class.getSuperclass();
		}
		while (@class != null);
		string detailMessage = CodeGenerationUtils.f("Couldn't find constructor parameter %s as a field, class %s", P_1, P_0.getSimpleName());
		
		throw new AssertionError(detailMessage);
	}

	
	
	internal InitializeConstructorParametersStatementsGenerator()
	{
	}

	
		[LineNumberTable(new byte[]
	{
		159, 182, 104, 129, 104, 117, 144, 110, 106, 111,
		230, 61, 231, 69, 238, 56, 233, 74
	})]
	internal virtual void generate(Class P_0, NodeList P_1)
	{
		if (P_0 != ClassLiteral<Node>.Value)
		{
			Constructor constructor = findAllFieldsConstructor(P_0);
			Parameter[] parameters = constructor.getParameters();
			int num = parameters.Length;
			for (int i = 0; i < num; i++)
			{
				Parameter parameter = parameters[i];
				Field field = findFieldInClass(P_0, parameter.getName());
				string statement = CodeGenerationUtils.f("%s.getConstructorParameters().add(%s.%s);", MetaModelGenerator.nodeMetaModelFieldName(P_0), MetaModelGenerator.nodeMetaModelFieldName(field.getDeclaringClass()), MetaModelGenerator.propertyMetaModelFieldName(field));
				P_1.add(StaticJavaParser.parseStatement(statement));
			}
		}
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
