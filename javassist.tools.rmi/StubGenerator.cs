using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.tools.rmi;

public class StubGenerator : Object, Translator
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const string fieldImporter = "importer";

	private const string fieldObjectId = "objectId";

	private const string accessorObjectId = "_getObjectId";

	private const string sampleClass = "javassist.tools.rmi.Sample";

	private ClassPool classPool;

	[Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	private Map proxyClasses;

	private CtMethod forwardMethod;

	private CtMethod forwardStaticMethod;

	private CtClass[] proxyConstructorParamTypes;

	private CtClass[] interfacesForProxy;

	private CtClass[] exceptionForProxy;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 23, 104, 107 })]
	public StubGenerator()
	{
		proxyClasses = new Hashtable();
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[] { 80, 103, 110, 98, 148, 110, 103 })]
	public virtual bool makeProxyClass(Class clazz)
	{
		string name = clazz.getName();
		if (proxyClasses.get(name) != null)
		{
			return false;
		}
		CtClass ctClass = produceProxyClass(classPool.get(name), clazz);
		proxyClasses.put(name, ctClass);
		modifySuperclass(ctClass);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(115)]
	public virtual bool isProxyClass(string name)
	{
		return proxyClasses.get(name) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[Signature("(Ljavassist/CtClass;Ljava/lang/Class<*>;)Ljavassist/CtClass;")]
	[LineNumberTable(new byte[]
	{
		93, 103, 113, 103, 191, 11, 109, 37, 166, 140,
		107, 145, 103, 141, 113, 103, 141, 145, 108, 104,
		134, 167, 114, 156, 98
	})]
	private CtClass produceProxyClass(CtClass P_0, Class P_1)
	{
		//Discarded unreachable code: IL_0109
		int modifiers = P_0.getModifiers();
		if (Modifier.isAbstract(modifiers) || Modifier.isNative(modifiers) || !Modifier.isPublic(modifiers))
		{
			string msg = new StringBuilder().append(P_0.getName()).append(" must be public, non-native, and non-abstract.").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
		CtClass ctClass = classPool.makeClass(P_0.getName(), P_0.getSuperclass());
		ctClass.setInterfaces(interfacesForProxy);
		CtField ctField = new CtField(classPool.get("javassist.tools.rmi.ObjectImporter"), "importer", ctClass);
		ctField.setModifiers(2);
		ctClass.addField(ctField, CtField.Initializer.byParameter(0));
		ctField = new CtField(CtClass.intType, "objectId", ctClass);
		ctField.setModifiers(2);
		ctClass.addField(ctField, CtField.Initializer.byParameter(1));
		ctClass.addMethod(CtNewMethod.getter("_getObjectId", ctField));
		ctClass.addConstructor(CtNewConstructor.defaultConstructor(ctClass));
		CtConstructor c = CtNewConstructor.skeleton(proxyConstructorParamTypes, null, ctClass);
		ctClass.addConstructor(c);
		SecurityException ex;
		try
		{
			addMethods(ctClass, P_1.getMethods(StubGenerator.___003CGetCallerID_003E()));
			return ctClass;
		}
		catch (SecurityException x)
		{
			ex = ByteCodeHelper.MapException<SecurityException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		SecurityException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 139, 103, 99, 162, 115, 130, 161, 98, 37,
		229, 52, 229, 79
	})]
	private void modifySuperclass(CtClass P_0)
	{
		while (true)
		{
			CtClass superclass = P_0.getSuperclass();
			if (superclass == null)
			{
				break;
			}
			try
			{
				superclass.getDeclaredConstructor(null);
				break;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
			superclass.addConstructor(CtNewConstructor.defaultConstructor(superclass));
			P_0 = superclass;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 100, 106, 100, 103, 113, 106, 139, 104, 137,
		135, 98, 107, 103, 178, 230, 59, 231, 71, 104,
		104, 98, 105, 135, 240, 38, 233, 93
	})]
	private void addMethods(CtClass P_0, Method[] P_1)
	{
		for (int i = 0; i < (nint)P_1.LongLength; i++)
		{
			Method method = P_1[i];
			int modifiers = method.getModifiers();
			if (method.getDeclaringClass() != ClassLiteral<Object>.Value && !Modifier.isFinal(modifiers))
			{
				if (Modifier.isPublic(modifiers))
				{
					CtMethod ctMethod = CtNewMethod.wrapped(body: (!Modifier.isStatic(modifiers)) ? forwardMethod : forwardStaticMethod, returnType: toCtClass(method.getReturnType()), mname: method.getName(), parameterTypes: toCtClass(method.getParameterTypes()), exceptionTypes: exceptionForProxy, constParam: CtMethod.ConstParameter.integer(i), declaring: P_0);
					ctMethod.setModifiers(modifiers);
					P_0.addMethod(ctMethod);
				}
				else if (!Modifier.isProtected(modifiers) && !Modifier.isPrivate(modifiers))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CannotCompileException("the methods must be public, protected, or private.");
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[Signature("(Ljava/lang/Class<*>;)Ljavassist/CtClass;")]
	[LineNumberTable(new byte[] { 160, 69, 104, 137, 134, 108, 104, 104, 110, 167 })]
	private CtClass toCtClass(Class P_0)
	{
		string classname;
		if (!P_0.isArray())
		{
			classname = P_0.getName();
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			do
			{
				stringBuilder.append("[]");
				P_0 = P_0.getComponentType();
			}
			while (P_0.isArray());
			stringBuilder.insert(0, P_0.getName());
			classname = stringBuilder.toString();
		}
		CtClass result = classPool.get(classname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[Signature("([Ljava/lang/Class<*>;)[Ljavassist/CtClass;")]
	[LineNumberTable(new byte[] { 160, 85, 99, 103, 102, 44, 166 })]
	private CtClass[] toCtClass(Class[] P_0)
	{
		int num = P_0.Length;
		CtClass[] array = new CtClass[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = toCtClass(P_0[i]);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		35, 103, 108, 113, 145, 120, 138, 120, 138, 111,
		107
	})]
	public virtual void start(ClassPool pool)
	{
		classPool = pool;
		CtClass ctClass = pool.get("javassist.tools.rmi.Sample");
		forwardMethod = ctClass.getDeclaredMethod("forward");
		forwardStaticMethod = ctClass.getDeclaredMethod("forwardStatic");
		proxyConstructorParamTypes = pool.get(new string[2] { "javassist.tools.rmi.ObjectImporter", "int" });
		interfacesForProxy = pool.get(new string[2] { "java.io.Serializable", "javassist.tools.rmi.Proxy" });
		exceptionForProxy = new CtClass[1] { pool.get("javassist.tools.rmi.RemoteException") };
	}

	public virtual void onLoad(ClassPool pool, string classname)
	{
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
