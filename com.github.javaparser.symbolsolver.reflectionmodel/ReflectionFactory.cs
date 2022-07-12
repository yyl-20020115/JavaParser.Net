
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.symbolsolver.reflectionmodel;

public class ReflectionFactory
{
	
	private sealed class ___003C_003EAnon0 : ResolvedTypeTransformer
	{
		private readonly List arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon0(List P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = lambda_0024typeUsageFor_00240(arg_00241, arg_00242, P_0);
			
			return result;
		}
	}

	private static string JAVA_LANG_OBJECT;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public static ResolvedType typeUsageFor(Type type, TypeSolver typeSolver)
	{
		if (type is TypeVariable)
		{
			TypeVariable typeVariable = (TypeVariable)type;
			int declaredOnClass = ((typeVariable.getGenericDeclaration() is Type) ? 1 : 0);
			ReflectionTypeParameter typeParameter = new ReflectionTypeParameter(typeVariable, (byte)declaredOnClass != 0, typeSolver);
			ResolvedTypeVariable result = new ResolvedTypeVariable(typeParameter);
			
			return result;
		}
		if (type is ParameterizedType)
		{
			ParameterizedType parameterizedType = (ParameterizedType)type;
			ResolvedReferenceType resolvedReferenceType = typeUsageFor(parameterizedType.getRawType(), typeSolver).asReferenceType();
			ArrayList arrayList = new ArrayList();
			((List)arrayList).addAll((Collection)Arrays.asList(parameterizedType.getActualTypeArguments()));
			return resolvedReferenceType.transformTypeParameters(new ___003C_003EAnon0(arrayList, typeSolver)).asReferenceType();
		}
		if (type is Class)
		{
			Class @class = (Class)type;
			if (@class.isPrimitive())
			{
				if (String.instancehelper_equals(@class.getName(), Void.TYPE.getName()))
				{
					return ResolvedVoidType.___003C_003EINSTANCE;
				}
				ResolvedType result2 = ResolvedPrimitiveType.byName(@class.getName());
				
				return result2;
			}
			if (@class.isArray())
			{
				ResolvedArrayType result3 = new ResolvedArrayType(typeUsageFor(@class.getComponentType(), typeSolver));
				
				return result3;
			}
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result4 = new ReferenceTypeImpl(typeDeclarationFor(@class, typeSolver), typeSolver);
			
			return result4;
		}
		if (type is GenericArrayType)
		{
			GenericArrayType genericArrayType = (GenericArrayType)type;
			ResolvedArrayType result5 = new ResolvedArrayType(typeUsageFor(genericArrayType.getGenericComponentType(), typeSolver));
			
			return result5;
		}
		if (type is WildcardType)
		{
			WildcardType wildcardType = (WildcardType)type;
			if ((nint)wildcardType.getLowerBounds().LongLength <= 0 || (nint)wildcardType.getUpperBounds().LongLength <= 0 || (nint)wildcardType.getUpperBounds().LongLength != 1 || String.instancehelper_equals(wildcardType.getUpperBounds()[0].getTypeName(), JAVA_LANG_OBJECT))
			{
			}
			if ((nint)wildcardType.getLowerBounds().LongLength > 0)
			{
				if ((nint)wildcardType.getLowerBounds().LongLength > 1)
				{
					
					throw new UnsupportedOperationException();
				}
				ResolvedWildcard result6 = ResolvedWildcard.superBound(typeUsageFor(wildcardType.getLowerBounds()[0], typeSolver));
				
				return result6;
			}
			if ((nint)wildcardType.getUpperBounds().LongLength > 0)
			{
				if ((nint)wildcardType.getUpperBounds().LongLength > 1)
				{
					
					throw new UnsupportedOperationException();
				}
				ResolvedWildcard result7 = ResolvedWildcard.extendsBound(typeUsageFor(wildcardType.getUpperBounds()[0], typeSolver));
				
				return result7;
			}
			return ResolvedWildcard.UNBOUNDED;
		}
		string message = new StringBuilder().append(Object.instancehelper_getClass(type).getCanonicalName()).append(" ").append(type)
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		
	public static ResolvedReferenceTypeDeclaration typeDeclarationFor(Class clazz, TypeSolver typeSolver)
	{
		if (clazz.isArray())
		{
			
			throw new IllegalArgumentException("No type declaration available for an Array");
		}
		if (clazz.isPrimitive())
		{
			
			throw new IllegalArgumentException();
		}
		if (clazz.isAnnotation())
		{
			ReflectionAnnotationDeclaration result = new ReflectionAnnotationDeclaration(clazz, typeSolver);
			
			return result;
		}
		if (clazz.isInterface())
		{
			ReflectionInterfaceDeclaration result2 = new ReflectionInterfaceDeclaration(clazz, typeSolver);
			
			return result2;
		}
		if (clazz.isEnum())
		{
			ReflectionEnumDeclaration result3 = new ReflectionEnumDeclaration(clazz, typeSolver);
			
			return result3;
		}
		ReflectionClassDeclaration result4 = new ReflectionClassDeclaration(clazz, typeSolver);
		
		return result4;
	}

	
	
	internal static AccessSpecifier modifiersToAccessLevel(int P_0)
	{
		if (java.lang.reflect.Modifier.isPublic(P_0))
		{
			return AccessSpecifier.___003C_003EPUBLIC;
		}
		if (java.lang.reflect.Modifier.isProtected(P_0))
		{
			return AccessSpecifier.___003C_003EPROTECTED;
		}
		if (java.lang.reflect.Modifier.isPrivate(P_0))
		{
			return AccessSpecifier.___003C_003EPRIVATE;
		}
		return AccessSpecifier.___003C_003ENONE;
	}

	
	
	
	private static ResolvedType lambda_0024typeUsageFor_00240(List P_0, TypeSolver P_1, ResolvedType P_2)
	{
		ResolvedType result = typeUsageFor((Type)P_0.remove(0), P_1);
		
		return result;
	}

	
	
	public ReflectionFactory()
	{
	}

	
	static ReflectionFactory()
	{
		JAVA_LANG_OBJECT = ClassLiteral<Object>.Value.getCanonicalName();
	}
}
