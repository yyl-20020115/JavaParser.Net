using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class AnnotationImpl : java.lang.Object, InvocationHandler
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const string JDK_ANNOTATION_CLASS_NAME = "java.lang.annotation.Annotation";

	private static Method JDK_ANNOTATION_TYPE_METHOD;

	private Annotation annotation;

	private ClassPool pool;

	private ClassLoader classLoader;

	[NonSerialized]
	[IKVM.Attributes.Signature("Ljava/lang/Class<*>;")]
	private Class annotationType;

	[NonSerialized]
	private int cachedHashCode;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.IllegalArgumentException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;Ljava/lang/Class<*>;Ljavassist/ClassPool;Ljavassist/bytecode/annotation/Annotation;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 23, 105 })]
	public static object make(ClassLoader cl, Class clazz, ClassPool cp, Annotation anon)
	{
		AnnotationImpl h = new AnnotationImpl(anon, cp, cl);
		object result = Proxy.newProxyInstance(cl, new Class[1] { clazz }, h, AnnotationImpl.___003CGetCallerID_003E());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 232, 33, 235, 96, 103, 103, 103 })]
	private AnnotationImpl(Annotation P_0, ClassPool P_1, ClassLoader P_2)
	{
		cachedHashCode = int.MinValue;
		annotation = P_0;
		pool = P_1;
		classLoader = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[]
	{
		160,
		124,
		99,
		162,
		104,
		108,
		104,
		103,
		210,
		124,
		110,
		130,
		113,
		108,
		171,
		111,
		99,
		130,
		100,
		121,
		100,
		110,
		byte.MaxValue,
		36,
		71,
		226,
		59,
		98,
		136,
		98,
		191,
		35,
		104,
		98,
		111,
		226,
		40,
		235,
		91
	})]
	private bool checkEquals(object P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_0 is Proxy)
		{
			InvocationHandler invocationHandler = Proxy.getInvocationHandler(P_0, AnnotationImpl.___003CGetCallerID_003E());
			if (invocationHandler is AnnotationImpl)
			{
				AnnotationImpl annotationImpl = (AnnotationImpl)invocationHandler;
				return annotation.equals(annotationImpl.annotation);
			}
		}
		Class obj = (Class)JDK_ANNOTATION_TYPE_METHOD.invoke(P_0, new object[0], AnnotationImpl.___003CGetCallerID_003E());
		if (!java.lang.Object.instancehelper_equals(getAnnotationType(), obj))
		{
			return false;
		}
		Method[] declaredMethods = annotationType.getDeclaredMethods(AnnotationImpl.___003CGetCallerID_003E());
		for (int i = 0; i < (nint)declaredMethods.LongLength; i++)
		{
			string name = declaredMethods[i].getName();
			MemberValue memberValue = annotation.getMemberValue(name);
			object obj2 = null;
			_ = null;
			object obj3;
			RuntimeException ex2;
			java.lang.Exception ex4;
			try
			{
				try
				{
					if (memberValue != null)
					{
						obj2 = memberValue.getValue(classLoader, pool, declaredMethods[i]);
					}
					if (obj2 == null)
					{
						obj2 = getDefault(name, declaredMethods[i]);
					}
					obj3 = declaredMethods[i].invoke(P_0, new object[0], AnnotationImpl.___003CGetCallerID_003E());
				}
				catch (System.Exception x)
				{
					RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
					if (ex == null)
					{
						throw;
					}
					ex2 = ex;
					goto IL_010c;
				}
			}
			catch (System.Exception x2)
			{
				java.lang.Exception ex3 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
				if (ex3 == null)
				{
					throw;
				}
				ex4 = ex3;
				goto IL_0110;
			}
			if (obj2 == null && obj3 != null)
			{
				return false;
			}
			if (obj2 != null && !java.lang.Object.instancehelper_equals(obj2, obj3))
			{
				return false;
			}
			continue;
			IL_0110:
			java.lang.Exception cause = ex4;
			string message = new StringBuilder().append("Error retrieving value ").append(name).append(" for annotation ")
				.append(annotation.getTypeName())
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message, cause);
			IL_010c:
			RuntimeException ex5 = ex2;
			throw Throwable.___003Cunmap_003E(ex5);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		74,
		112,
		162,
		135,
		113,
		106,
		105,
		163,
		110,
		131,
		100,
		120,
		100,
		byte.MaxValue,
		25,
		71,
		226,
		59,
		98,
		136,
		98,
		223,
		34,
		100,
		110,
		139,
		137,
		239,
		37,
		233,
		94,
		135
	})]
	public override int hashCode()
	{
		if (cachedHashCode == int.MinValue)
		{
			int num = 0;
			getAnnotationType();
			Method[] declaredMethods = annotationType.getDeclaredMethods(AnnotationImpl.___003CGetCallerID_003E());
			for (int i = 0; i < (nint)declaredMethods.LongLength; i++)
			{
				string name = declaredMethods[i].getName();
				int num2 = 0;
				MemberValue memberValue = annotation.getMemberValue(name);
				object obj = null;
				RuntimeException ex2;
				java.lang.Exception ex4;
				try
				{
					try
					{
						if (memberValue != null)
						{
							obj = memberValue.getValue(classLoader, pool, declaredMethods[i]);
						}
						if (obj == null)
						{
							obj = getDefault(name, declaredMethods[i]);
						}
					}
					catch (System.Exception x)
					{
						RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
						if (ex == null)
						{
							throw;
						}
						ex2 = ex;
						goto IL_00a1;
					}
				}
				catch (System.Exception x2)
				{
					java.lang.Exception ex3 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
					if (ex3 == null)
					{
						throw;
					}
					ex4 = ex3;
					goto IL_00a5;
				}
				if (obj != null)
				{
					num2 = ((!java.lang.Object.instancehelper_getClass(obj).isArray()) ? java.lang.Object.instancehelper_hashCode(obj) : arrayHashCode(obj));
				}
				num += (127 * java.lang.String.instancehelper_hashCode(name)) ^ num2;
				continue;
				IL_00a1:
				RuntimeException ex5 = ex2;
				throw Throwable.___003Cunmap_003E(ex5);
				IL_00a5:
				java.lang.Exception cause = ex4;
				string message = new StringBuilder().append("Error retrieving value ").append(name).append(" for annotation ")
					.append(annotation.getTypeName())
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message, cause);
			}
			cachedHashCode = num;
		}
		return cachedHashCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		49,
		107,
		140,
		byte.MaxValue,
		5,
		70,
		226,
		60,
		97,
		127,
		1,
		108,
		167
	})]
	private Class getAnnotationType()
	{
		string typeName;
		java.lang.ClassNotFoundException ex;
		if (annotationType == null)
		{
			typeName = annotation.getTypeName();
			try
			{
				annotationType = classLoader.loadClass(typeName);
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0038;
			}
		}
		return annotationType;
		IL_0038:
		java.lang.ClassNotFoundException @this = ex;
		java.lang.NoClassDefFoundError noClassDefFoundError = new java.lang.NoClassDefFoundError(new StringBuilder().append("Error loading annotation class: ").append(typeName).toString());
		Throwable.instancehelper_setStackTrace(noClassDefFoundError, Throwable.instancehelper_getStackTrace(@this));
		throw Throwable.___003Cunmap_003E(noClassDefFoundError);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException", "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		107,
		108,
		139,
		109,
		103,
		104,
		99,
		134,
		108,
		100,
		105,
		byte.MaxValue,
		11,
		71,
		226,
		61,
		97,
		byte.MaxValue,
		6,
		69
	})]
	private object getDefault(string P_0, Method P_1)
	{
		//Discarded unreachable code: IL_006d
		string typeName = annotation.getTypeName();
		if (pool != null)
		{
			try
			{
				CtClass ctClass = pool.get(typeName);
				ClassFile classFile = ctClass.getClassFile2();
				MethodInfo method = classFile.getMethod(P_0);
				if (method != null)
				{
					AnnotationDefaultAttribute annotationDefaultAttribute = (AnnotationDefaultAttribute)method.getAttribute("AnnotationDefault");
					if (annotationDefaultAttribute != null)
					{
						MemberValue defaultValue = annotationDefaultAttribute.getDefaultValue();
						return defaultValue.getValue(classLoader, pool, P_1);
					}
				}
			}
			catch (NotFoundException)
			{
				goto IL_007b;
			}
		}
		string message = new StringBuilder().append("no default value: ").append(typeName).append(".")
			.append(P_0)
			.append("()")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
		IL_007b:
		_ = null;
		string message2 = new StringBuilder().append("cannot find a class file: ").append(typeName).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 180, 99, 130, 130, 103, 103, 98, 101, 105,
		231, 60, 230, 70
	})]
	private static int arrayHashCode(object P_0)
	{
		if (P_0 == null)
		{
			return 0;
		}
		int num = 1;
		object[] array = (object[])P_0;
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			int num2 = 0;
			if (array[i] != null)
			{
				num2 = java.lang.Object.instancehelper_hashCode(array[i]);
			}
			num = 31 * num + num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public virtual string getTypeName()
	{
		string typeName = annotation.getTypeName();
		_ = null;
		return typeName;
	}

	public virtual Annotation getAnnotation()
	{
		return annotation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[]
	{
		83, 103, 109, 109, 100, 143, 109, 110, 109, 142,
		110, 104, 137, 109, 99, 107
	})]
	public virtual object invoke(object proxy, Method method, object[] args)
	{
		string name = method.getName();
		if (ClassLiteral<java.lang.Object>.Value == method.getDeclaringClass())
		{
			if (java.lang.String.instancehelper_equals("equals", name))
			{
				object obj = args[0];
				java.lang.Boolean result = java.lang.Boolean.valueOf(checkEquals(obj));
				_ = null;
				return result;
			}
			if (java.lang.String.instancehelper_equals("toString", name))
			{
				string result2 = annotation.toString();
				_ = null;
				return result2;
			}
			if (java.lang.String.instancehelper_equals("hashCode", name))
			{
				Integer result3 = Integer.valueOf(hashCode());
				_ = null;
				return result3;
			}
		}
		else if (java.lang.String.instancehelper_equals("annotationType", name) && method.getParameterTypes().Length == 0)
		{
			Class result4 = getAnnotationType();
			_ = null;
			return result4;
		}
		MemberValue memberValue = annotation.getMemberValue(name);
		if (memberValue == null)
		{
			object @default = getDefault(name, method);
			_ = null;
			return @default;
		}
		object value = memberValue.getValue(classLoader, pool, method);
		_ = null;
		return value;
	}

	[LineNumberTable(new byte[] { 159, 182, 230, 75, 112, 223, 17, 2, 161 })]
	static AnnotationImpl()
	{
		JDK_ANNOTATION_TYPE_METHOD = null;
		try
		{
			Class @class = Class.forName("java.lang.annotation.Annotation", AnnotationImpl.___003CGetCallerID_003E());
			JDK_ANNOTATION_TYPE_METHOD = @class.getMethod("annotationType", null, AnnotationImpl.___003CGetCallerID_003E());
			return;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
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
