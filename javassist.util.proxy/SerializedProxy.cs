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
using java.security;

namespace javassist.util.proxy;

[Serializable]
[Implements(new string[] { "java.io.Serializable" })]
internal class SerializedProxy : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Ljava/lang/Class<*>;>;")]
	[EnclosingMethod(null, "loadClass", "(Ljava.lang.String;)Ljava.lang.Class;")]
	internal class _1 : java.lang.Object, PrivilegedExceptionAction
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024className;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SerializedProxy this_00240;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 20, 107 })]
		public virtual Class run()
		{
			ClassLoader contextClassLoader = Thread.currentThread().getContextClassLoader();
			Class result = Class.forName(val_0024className, true, contextClassLoader, _1.___003CGetCallerID_003E());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(67)]
		internal _1(SerializedProxy P_0, string P_1)
		{
			this_00240 = P_0;
			val_0024className = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(67)]
		public virtual object run()
		{
			Class result = this.run();
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
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const long serialVersionUID = 1L;

	private string superClass;

	private string[] interfaces;

	private byte[] filterSignature;

	private MethodHandler handler;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;[BLjavassist/util/proxy/MethodHandler;)V")]
	[LineNumberTable(new byte[]
	{
		159, 184, 104, 103, 103, 113, 103, 99, 110, 107,
		108, 104, 107, 117, 235, 61, 232, 69
	})]
	internal SerializedProxy(Class P_0, byte[] P_1, MethodHandler P_2)
	{
		filterSignature = P_1;
		handler = P_2;
		superClass = P_0.getSuperclass().getName();
		Class[] array = P_0.getInterfaces();
		int num = array.Length;
		interfaces = new string[num - 1];
		string name = ClassLiteral<ProxyObject>.Value.getName();
		string name2 = ClassLiteral<Proxy>.Value.getName();
		for (int i = 0; i < num; i++)
		{
			string name3 = array[i].getName();
			if (!java.lang.String.instancehelper_equals(name3, name) && !java.lang.String.instancehelper_equals(name3, name2))
			{
				interfaces[i] = name3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		17,
		byte.MaxValue,
		13,
		72,
		97
	})]
	protected internal virtual Class loadClass(string P_0)
	{
		//Discarded unreachable code: IL_0018
		PrivilegedActionException ex;
		try
		{
			return (Class)AccessController.doPrivileged(new _1(this, P_0), SerializedProxy.___003CGetCallerID_003E());
		}
		catch (PrivilegedActionException x)
		{
			ex = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		PrivilegedActionException ex2 = ex;
		string message = new StringBuilder().append("cannot load the class: ").append(P_0).toString();
		java.lang.Exception exception = ex2.getException();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message, exception);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.ObjectStreamException" })]
	[LineNumberTable(new byte[]
	{
		32, 104, 103, 102, 49, 166, 102, 114, 103, 127,
		20, 109, 159, 54, 98, 146, 98, 146, 98, 146,
		98, 146, 98
	})]
	internal virtual object readResolve()
	{
		//Discarded unreachable code: IL_008f
		NoSuchMethodException ex;
		InvocationTargetException ex2;
		java.lang.ClassNotFoundException ex3;
		InstantiationException ex4;
		IllegalAccessException ex5;
		try
		{
			try
			{
				try
				{
					try
					{
						try
						{
							int num = interfaces.Length;
							Class[] array = new Class[num];
							for (int i = 0; i < num; i++)
							{
								array[i] = loadClass(interfaces[i]);
							}
							ProxyFactory proxyFactory = new ProxyFactory();
							proxyFactory.setSuperclass(loadClass(superClass));
							proxyFactory.setInterfaces(array);
							Proxy proxy = (Proxy)proxyFactory.createClass(filterSignature).getConstructor(new Class[0], SerializedProxy.___003CGetCallerID_003E()).newInstance(new object[0], SerializedProxy.___003CGetCallerID_003E());
							proxy.setHandler(handler);
							return proxy;
						}
						catch (NoSuchMethodException x)
						{
							ex = ByteCodeHelper.MapException<NoSuchMethodException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						}
					}
					catch (InvocationTargetException x2)
					{
						ex2 = ByteCodeHelper.MapException<InvocationTargetException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_00cf;
					}
				}
				catch (java.lang.ClassNotFoundException x3)
				{
					ex3 = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00d3;
				}
			}
			catch (InstantiationException x4)
			{
				ex4 = ByteCodeHelper.MapException<InstantiationException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00d7;
			}
		}
		catch (IllegalAccessException x5)
		{
			ex5 = ByteCodeHelper.MapException<IllegalAccessException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00db;
		}
		NoSuchMethodException @this = ex;
		string reason = Throwable.instancehelper_getMessage(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidClassException(reason);
		IL_00db:
		IllegalAccessException this2 = ex5;
		string reason2 = Throwable.instancehelper_getMessage(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidClassException(reason2);
		IL_00d7:
		InstantiationException this3 = ex4;
		string reason3 = Throwable.instancehelper_getMessage(this3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidObjectException(reason3);
		IL_00d3:
		java.lang.ClassNotFoundException this4 = ex3;
		string reason4 = Throwable.instancehelper_getMessage(this4);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidClassException(reason4);
		IL_00cf:
		InvocationTargetException this5 = ex2;
		string reason5 = Throwable.instancehelper_getMessage(this5);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidClassException(reason5);
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
	protected SerializedProxy(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		if (((object)this).GetType() != typeof(SerializedProxy))
		{
			return this;
		}
		return readResolve();
	}
}
