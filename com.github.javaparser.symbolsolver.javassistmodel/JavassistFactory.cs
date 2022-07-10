using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;

public class JavassistFactory
{
	
	
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

	
	
	public static ResolvedReferenceTypeDeclaration toTypeDeclaration(CtClass ctClazz, TypeSolver typeSolver)
	{
		if (ctClazz.isAnnotation())
		{
			JavassistAnnotationDeclaration result = new JavassistAnnotationDeclaration(ctClazz, typeSolver);
			
			return result;
		}
		if (ctClazz.isInterface())
		{
			JavassistInterfaceDeclaration result2 = new JavassistInterfaceDeclaration(ctClazz, typeSolver);
			
			return result2;
		}
		if (ctClazz.isEnum())
		{
			JavassistEnumDeclaration result3 = new JavassistEnumDeclaration(ctClazz, typeSolver);
			
			return result3;
		}
		if (ctClazz.isArray())
		{
			
			throw new IllegalArgumentException("This method should not be called passing an array");
		}
		JavassistClassDeclaration result4 = new JavassistClassDeclaration(ctClazz, typeSolver);
		
		return result4;
	}

	
	[LineNumberTable(new byte[]
	{
		159, 183, 104, 119, 104, 114, 139, 177, 104, 149,
		104, 181, 223, 19, 97
	})]
	public static ResolvedType typeUsageFor(CtClass ctClazz, TypeSolver typeSolver)
	{
		//Discarded unreachable code: IL_00a3
		NotFoundException ex;
		try
		{
			if (ctClazz.isArray())
			{
				return new ResolvedArrayType(typeUsageFor(ctClazz.getComponentType(), typeSolver));
			}
			if (ctClazz.isPrimitive())
			{
				if (String.instancehelper_equals(ctClazz.getName(), "void"))
				{
					return ResolvedVoidType.___003C_003EINSTANCE;
				}
				return ResolvedPrimitiveType.byName(ctClazz.getName());
			}
			if (ctClazz.isInterface())
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return new ReferenceTypeImpl(new JavassistInterfaceDeclaration(ctClazz, typeSolver), typeSolver);
			}
			if (ctClazz.isEnum())
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return new ReferenceTypeImpl(new JavassistEnumDeclaration(ctClazz, typeSolver), typeSolver);
			}
			ReferenceTypeImpl.___003Cclinit_003E();
			return new ReferenceTypeImpl(new JavassistClassDeclaration(ctClazz, typeSolver), typeSolver);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		
		throw new RuntimeException(cause);
	}

	
	
	public JavassistFactory()
	{
	}
}
