using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.tools.reflect;

[Serializable]
[Implements(new string[] { "java.io.Serializable" })]
public class ClassMetaobject : java.lang.Object, Serializable.__Interface, ISerializable
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const long serialVersionUID = 1L;

	internal const string methodPrefix = "_m_";

	internal const int methodPrefixLen = 3;

	[Signature("Ljava/lang/Class<*>;")]
	private Class javaClass;

	[Signature("[Ljava/lang/reflect/Constructor<*>;")]
	private Constructor[] constructors;

	private Method[] methods;

	public static bool useContextClassLoader;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 53, 103, 107, 39, 129 })]
	private Class getClassObject(string P_0)
	{
		if (useContextClassLoader)
		{
			Class result = Thread.currentThread().getContextClassLoader().loadClass(P_0);
			_ = null;
			return result;
		}
		Class result2 = Class.forName(P_0, ClassMetaobject.___003CGetCallerID_003E());
		_ = null;
		return result2;
	}

	[Signature("()Ljava/lang/Class<*>;")]
	public Class getJavaClass()
	{
		return javaClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 140, 104, 135, 103, 108, 99, 103, 99, 107,
		102, 105, 113, 99, 99, 107, 108, 237, 61, 232,
		72, 108, 102, 228, 49, 235, 83, 109, 104, 103,
		17, 200
	})]
	public Method[] getReflectiveMethods()
	{
		if (methods != null)
		{
			return methods;
		}
		Class @class = getJavaClass();
		Method[] declaredMethods = @class.getDeclaredMethods(ClassMetaobject.___003CGetCallerID_003E());
		int num = declaredMethods.Length;
		int[] array = new int[num];
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			Method method = declaredMethods[i];
			string name = method.getName();
			if (!java.lang.String.instancehelper_startsWith(name, "_m_"))
			{
				continue;
			}
			int num3 = 0;
			int num4 = 3;
			while (true)
			{
				int num5 = java.lang.String.instancehelper_charAt(name, num4);
				if (48 > num5 || num5 > 57)
				{
					break;
				}
				num3 = num3 * 10 + num5 - 48;
				num4++;
			}
			num3 = (array[i] = num3 + 1);
			if (num3 > num2)
			{
				num2 = num3;
			}
		}
		methods = new Method[num2];
		for (int i = 0; i < num; i++)
		{
			if (array[i] > 0)
			{
				methods[array[i] - 1] = declaredMethods[i];
			}
		}
		return methods;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 196, 110, 130, 108, 106, 98, 130 })]
	public string getMethodName(int identifier)
	{
		string name = getReflectiveMethods()[identifier].getName();
		int num = 3;
		int num2;
		do
		{
			int index = num;
			num++;
			num2 = java.lang.String.instancehelper_charAt(name, index);
		}
		while (num2 >= 48 && 57 >= num2);
		string result = java.lang.String.instancehelper_substring(name, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		26,
		136,
		byte.MaxValue,
		2,
		70,
		226,
		60,
		97,
		159,
		7,
		187,
		118,
		103
	})]
	public ClassMetaobject(string[] @params)
	{
		java.lang.ClassNotFoundException ex;
		try
		{
			javaClass = getClassObject(@params[0]);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0026;
		}
		constructors = javaClass.getConstructors(ClassMetaobject.___003CGetCallerID_003E());
		methods = null;
		return;
		IL_0026:
		java.lang.ClassNotFoundException cause = ex;
		string message = new StringBuilder().append("not found: ").append(@params[0]).append(", useContextClassLoader: ")
			.append(java.lang.Boolean.toString(useContextClassLoader))
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 41, 115 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.writeUTF(javaClass.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 47, 114, 118, 103 })]
	private void readObject(ObjectInputStream P_0)
	{
		javaClass = getClassObject(P_0.readUTF());
		constructors = javaClass.getConstructors(ClassMetaobject.___003CGetCallerID_003E());
		methods = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(120)]
	public string getName()
	{
		string name = javaClass.getName();
		_ = null;
		return name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(127)]
	public bool isInstance(object obj)
	{
		bool result = javaClass.isInstance(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.tools.reflect.CannotCreateException" })]
	[LineNumberTable(new byte[]
	{
		88, 104, 137, 159, 43, 225, 75, 226, 56, 98,
		141, 98, 141, 98, 237, 50, 233, 82
	})]
	public object newInstance(object[] args)
	{
		//Discarded unreachable code: IL_0026
		int num = constructors.Length;
		for (int i = 0; i < num; i++)
		{
			InstantiationException ex2;
			IllegalAccessException ex3;
			InvocationTargetException ex4;
			try
			{
				try
				{
					try
					{
						try
						{
							return constructors[i].newInstance(args, ClassMetaobject.___003CGetCallerID_003E());
						}
						catch (IllegalArgumentException)
						{
						}
					}
					catch (InstantiationException x)
					{
						ex2 = ByteCodeHelper.MapException<InstantiationException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_004f;
					}
				}
				catch (IllegalAccessException x2)
				{
					ex3 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0052;
				}
			}
			catch (InvocationTargetException x3)
			{
				ex4 = ByteCodeHelper.MapException<InvocationTargetException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0056;
			}
			_ = null;
			continue;
			IL_0052:
			IllegalAccessException e = ex3;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCreateException(e);
			IL_004f:
			InstantiationException e2 = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCreateException(e2);
			IL_0056:
			InvocationTargetException e3 = ex4;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCreateException(e3);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCreateException("no constructor matches");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 118, 135, 159, 26, 98, 146, 98 })]
	public virtual object trapFieldRead(string name)
	{
		//Discarded unreachable code: IL_0020
		Class @class = getJavaClass();
		NoSuchFieldException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				return @class.getField(name, ClassMetaobject.___003CGetCallerID_003E()).get(null, ClassMetaobject.___003CGetCallerID_003E());
			}
			catch (NoSuchFieldException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalAccessException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_003c;
		}
		NoSuchFieldException @this = ex;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
		IL_003c:
		IllegalAccessException this2 = ex2;
		string message2 = Throwable.instancehelper_toString(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		74,
		135,
		byte.MaxValue,
		23,
		71,
		226,
		59,
		97,
		145,
		98,
		146
	})]
	public virtual void trapFieldWrite(string name, object value)
	{
		Class @class = getJavaClass();
		NoSuchFieldException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				@class.getField(name, ClassMetaobject.___003CGetCallerID_003E()).set(null, value, ClassMetaobject.___003CGetCallerID_003E());
				return;
			}
			catch (NoSuchFieldException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalAccessException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_003a;
		}
		NoSuchFieldException @this = ex;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
		IL_003a:
		IllegalAccessException this2 = ex2;
		string message2 = Throwable.instancehelper_toString(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[]
	{
		160, 95, 113, 99, 123, 105, 147, 127, 25, 98,
		109, 98, 237, 57, 233, 75
	})]
	public static object invoke(object target, int identifier, object[] args)
	{
		//Discarded unreachable code: IL_005c
		Method[] array = java.lang.Object.instancehelper_getClass(target).getMethods(ClassMetaobject.___003CGetCallerID_003E());
		int num = array.Length;
		string prefix = new StringBuilder().append("_m_").append(identifier).toString();
		for (int i = 0; i < num; i++)
		{
			if (!java.lang.String.instancehelper_startsWith(array[i].getName(), prefix))
			{
				continue;
			}
			InvocationTargetException ex;
			IllegalAccessException ex2;
			try
			{
				try
				{
					return array[i].invoke(target, args, ClassMetaobject.___003CGetCallerID_003E());
				}
				catch (InvocationTargetException x)
				{
					ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (IllegalAccessException x2)
			{
				ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_007e;
			}
			InvocationTargetException ex3 = ex;
			throw Throwable.___003Cunmap_003E(ex3.getTargetException());
			IL_007e:
			IllegalAccessException e = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotInvokeException(e);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotInvokeException("cannot find a method");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 160, 124, 103, 159, 18, 98, 141, 98 })]
	public virtual object trapMethodcall(int identifier, object[] args)
	{
		//Discarded unreachable code: IL_0018
		InvocationTargetException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				Method[] reflectiveMethods = getReflectiveMethods();
				return reflectiveMethods[identifier].invoke(null, args, ClassMetaobject.___003CGetCallerID_003E());
			}
			catch (InvocationTargetException x)
			{
				ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalAccessException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0034;
		}
		InvocationTargetException ex3 = ex;
		throw Throwable.___003Cunmap_003E(ex3.getTargetException());
		IL_0034:
		IllegalAccessException e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotInvokeException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(302)]
	public Method getMethod(int identifier)
	{
		return getReflectiveMethods()[identifier];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)[Ljava/lang/Class<*>;")]
	[LineNumberTable(327)]
	public Class[] getParameterTypes(int identifier)
	{
		Class[] parameterTypes = getReflectiveMethods()[identifier].getParameterTypes();
		_ = null;
		return parameterTypes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/lang/Class<*>;")]
	[LineNumberTable(335)]
	public Class getReturnType(int identifier)
	{
		Class returnType = getReflectiveMethods()[identifier].getReturnType();
		_ = null;
		return returnType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException" })]
	[Signature("(Ljava/lang/String;[Ljava/lang/Class<*>;)I")]
	[LineNumberTable(new byte[]
	{
		160, 245, 103, 103, 101, 162, 115, 108, 226, 57,
		230, 74
	})]
	public int getMethodIndex(string originalName, Class[] argTypes)
	{
		Method[] reflectiveMethods = getReflectiveMethods();
		for (int i = 0; i < (nint)reflectiveMethods.LongLength; i++)
		{
			if (reflectiveMethods[i] != null && java.lang.String.instancehelper_equals(getMethodName(i), originalName) && Arrays.equals(argTypes, reflectiveMethods[i].getParameterTypes()))
			{
				return i;
			}
		}
		string s = new StringBuilder().append("Method ").append(originalName).append(" not found")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchMethodException(s);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	[HideFromJava]
	public static implicit operator Serializable(ClassMetaobject P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
		this.GetObjectData(P_0, P_1);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ClassMetaobject(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
