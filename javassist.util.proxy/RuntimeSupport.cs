using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.lang.reflect;

namespace javassist.util.proxy;

public class RuntimeSupport : java.lang.Object
{
	[Serializable]
	[Implements(new string[] { "javassist.util.proxy.MethodHandler", "java.io.Serializable" })]
	internal class DefaultMethodHandler : java.lang.Object, MethodHandler, Serializable.__Interface, ISerializable
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		private const long serialVersionUID = 1L;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(33)]
		internal DefaultMethodHandler()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(42)]
		public virtual object invoke(object P_0, Method P_1, Method P_2, object[] P_3)
		{
			object result = P_2.invoke(P_0, P_3, DefaultMethodHandler.___003CGetCallerID_003E());
			_ = null;
			return result;
		}

		static CallerID ___003CGetCallerID_003E()
		{
			if (___003CcallerID_003E == null)
			{
				___003CcallerID_003E = new ___003CCallerID_003E();
			}
			return ___003CcallerID_003E;
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
		protected DefaultMethodHandler(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	public static MethodHandler default_interceptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 76, 103 })]
	public static string makeDescriptor(Method m)
	{
		Class[] parameterTypes = m.getParameterTypes();
		string result = makeDescriptor(parameterTypes, m.getReturnType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/lang/Class<*>;Ljava/lang/Class<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[] { 160, 87, 102, 105, 103, 41, 166, 105, 99, 135 })]
	public static string makeDescriptor(Class[] @params, Class retType)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('(');
		for (int i = 0; i < (nint)@params.LongLength; i++)
		{
			makeDesc(stringBuilder, @params[i]);
		}
		stringBuilder.append(')');
		if (retType != null)
		{
			makeDesc(stringBuilder, retType);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 57, 105, 99, 136 })]
	public static Method findMethod(Class clazz, string name, string desc)
	{
		Method method = findMethod2(clazz, name, desc);
		if (method == null)
		{
			error(clazz, name, desc);
		}
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 83, 110, 99, 137, 99, 136 })]
	public static Method findSuperClassMethod(Class clazz, string name, string desc)
	{
		Method method = findSuperMethod2(clazz.getSuperclass(), name, desc);
		if (method == null)
		{
			method = searchInterfaces(clazz, name, desc);
		}
		if (method == null)
		{
			error(clazz, name, desc);
		}
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 43, 110, 99, 141 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Method findMethod(object self, string name, string desc)
	{
		Method method = findMethod2(java.lang.Object.instancehelper_getClass(self), name, desc);
		if (method == null)
		{
			error(java.lang.Object.instancehelper_getClass(self), name, desc);
		}
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 103 })]
	public static Method findSuperMethod(object self, string name, string desc)
	{
		Class clazz = java.lang.Object.instancehelper_getClass(self);
		Method result = findSuperClassMethod(clazz, name, desc);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 126, 103, 99, 102, 115, 109, 228, 61, 230, 69 })]
	private static Method findMethod2(Class P_0, string P_1, string P_2)
	{
		Method[] declaredMethods = SecurityActions.getDeclaredMethods(P_0);
		int num = declaredMethods.Length;
		for (int i = 0; i < num; i++)
		{
			if (java.lang.String.instancehelper_equals(declaredMethods[i].getName(), P_1) && java.lang.String.instancehelper_equals(makeDescriptor(declaredMethods[i]), P_2))
			{
				return declaredMethods[i];
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 94, 127, 17 })]
	private static void error(Class P_0, string P_1, string P_2)
	{
		string message = new StringBuilder().append("not found ").append(P_1).append(":")
			.append(P_2)
			.append(" in ")
			.append(P_0.getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 99, 105, 99, 130, 103, 99, 105, 99, 162 })]
	private static Method findSuperMethod2(Class P_0, string P_1, string P_2)
	{
		Method method = findMethod2(P_0, P_1, P_2);
		if (method != null)
		{
			return method;
		}
		Class superclass = P_0.getSuperclass();
		if (superclass != null)
		{
			method = findSuperMethod2(superclass, P_1, P_2);
			if (method != null)
			{
				return method;
			}
		}
		Method result = searchInterfaces(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 114, 98, 103, 103, 107, 99, 226, 61, 230, 70 })]
	private static Method searchInterfaces(Class P_0, string P_1, string P_2)
	{
		Method method = null;
		Class[] interfaces = P_0.getInterfaces();
		for (int i = 0; i < (nint)interfaces.LongLength; i++)
		{
			method = findSuperMethod2(interfaces[i], P_1, P_2);
			if (method != null)
			{
				return method;
			}
		}
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/StringBuilder;Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 112, 104, 105, 145, 107, 104, 110, 104, 110,
		104, 110, 104, 110, 104, 110, 104, 110, 104, 110,
		104, 107, 104, 139, 191, 11, 126, 102
	})]
	private static void makeDesc(StringBuilder P_0, Class P_1)
	{
		if (P_1.isArray())
		{
			P_0.append('[');
			makeDesc(P_0, P_1.getComponentType());
		}
		else if (P_1.isPrimitive())
		{
			if (P_1 == java.lang.Void.TYPE)
			{
				P_0.append('V');
				return;
			}
			if (P_1 == Integer.TYPE)
			{
				P_0.append('I');
				return;
			}
			if (P_1 == java.lang.Byte.TYPE)
			{
				P_0.append('B');
				return;
			}
			if (P_1 == Long.TYPE)
			{
				P_0.append('J');
				return;
			}
			if (P_1 == java.lang.Double.TYPE)
			{
				P_0.append('D');
				return;
			}
			if (P_1 == Float.TYPE)
			{
				P_0.append('F');
				return;
			}
			if (P_1 == Character.TYPE)
			{
				P_0.append('C');
				return;
			}
			if (P_1 == Short.TYPE)
			{
				P_0.append('S');
				return;
			}
			if (P_1 != java.lang.Boolean.TYPE)
			{
				string message = new StringBuilder().append("bad type: ").append(P_1.getName()).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
			P_0.append('Z');
		}
		else
		{
			P_0.append('L').append(java.lang.String.instancehelper_replace(P_1.getName(), '.', '/')).append(';');
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	public RuntimeSupport()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;[Ljava/lang/reflect/Method;)V")]
	[LineNumberTable(new byte[] { 7, 107, 106, 109 })]
	public static void find2Methods(Class clazz, string superMethod, string thisMethod, int index, string desc, Method[] methods)
	{
		methods[index + 1] = ((thisMethod != null) ? findMethod(clazz, thisMethod, desc) : null);
		methods[index] = findSuperClassMethod(clazz, superMethod, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 27, 107, 106, 109 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void find2Methods(object self, string superMethod, string thisMethod, int index, string desc, Method[] methods)
	{
		methods[index + 1] = ((thisMethod != null) ? findMethod(self, thisMethod, desc) : null);
		methods[index] = findSuperMethod(self, superMethod, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;Ljava/lang/Class<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[] { 160, 106, 103, 103 })]
	public static string makeDescriptor(string @params, Class retType)
	{
		StringBuilder stringBuilder = new StringBuilder(@params);
		makeDesc(stringBuilder, retType);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.InvalidClassException" })]
	[LineNumberTable(new byte[] { 160, 153, 135, 98, 104, 110, 104, 140 })]
	public static SerializedProxy makeSerializedProxy(object proxy)
	{
		Class @class = java.lang.Object.instancehelper_getClass(proxy);
		MethodHandler methodHandler = null;
		if (proxy is ProxyObject)
		{
			methodHandler = ((ProxyObject)proxy).getHandler();
		}
		else if (proxy is Proxy)
		{
			methodHandler = ProxyFactory.getHandler((Proxy)proxy);
		}
		SerializedProxy result = new SerializedProxy(@class, ProxyFactory.getFilterSignature(@class), methodHandler);
		_ = null;
		return result;
	}

	[LineNumberTable(31)]
	static RuntimeSupport()
	{
		default_interceptor = new DefaultMethodHandler();
	}

	[HideFromJava]
	[NameSig("makeSerializedProxy", "(Ljava.lang.Object;)Ljavassist.util.proxy.SerializedProxy;")]
	public static object makeSerializedProxy(object P_0)
	{
		return RuntimeSupport.makeSerializedProxy(P_0);
	}
}
