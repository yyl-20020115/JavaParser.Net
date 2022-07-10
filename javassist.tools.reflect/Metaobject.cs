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

namespace javassist.tools.reflect;

[Serializable]
[Implements(new string[] { "java.io.Serializable" })]
public class Metaobject : java.lang.Object, Serializable.__Interface, ISerializable
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const long serialVersionUID = 1L;

	protected internal ClassMetaobject classmetaobject;

	protected internal Metalevel baseobject;

	protected internal Method[] methods;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	public ClassMetaobject getClassMetaobject()
	{
		return classmetaobject;
	}

	public object getObject()
	{
		return baseobject;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 104, 108, 113, 113 })]
	public Metaobject(object self, object[] args)
	{
		baseobject = (Metalevel)self;
		classmetaobject = baseobject._getClass();
		methods = classmetaobject.getReflectiveMethods();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 104, 103, 103, 103 })]
	protected internal Metaobject()
	{
		baseobject = null;
		classmetaobject = null;
		methods = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 31, 110 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.writeObject(baseobject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 37, 113, 113, 113 })]
	private void readObject(ObjectInputStream P_0)
	{
		baseobject = (Metalevel)P_0.readObject();
		classmetaobject = baseobject._getClass();
		methods = classmetaobject.getReflectiveMethods();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 108, 113, 177, 110 })]
	public void setObject(object self)
	{
		baseobject = (Metalevel)self;
		classmetaobject = baseobject._getClass();
		methods = classmetaobject.getReflectiveMethods();
		baseobject._setMetaobject(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 77, 110, 130, 108, 106, 98, 130 })]
	public string getMethodName(int identifier)
	{
		string name = methods[identifier].getName();
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
	[Signature("(I)[Ljava/lang/Class<*>;")]
	[LineNumberTable(144)]
	public Class[] getParameterTypes(int identifier)
	{
		Class[] parameterTypes = methods[identifier].getParameterTypes();
		_ = null;
		return parameterTypes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/lang/Class<*>;")]
	[LineNumberTable(152)]
	public Class getReturnType(int identifier)
	{
		Class returnType = methods[identifier].getReturnType();
		_ = null;
		return returnType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 113, 140, 159, 31, 98, 146, 98 })]
	public virtual object trapFieldRead(string name)
	{
		//Discarded unreachable code: IL_002a
		Class javaClass = getClassMetaobject().getJavaClass();
		NoSuchFieldException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				return javaClass.getField(name, Metaobject.___003CGetCallerID_003E()).get(getObject(), Metaobject.___003CGetCallerID_003E());
			}
			catch (NoSuchFieldException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalAccessException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0046;
		}
		NoSuchFieldException @this = ex;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
		IL_0046:
		IllegalAccessException this2 = ex2;
		string message2 = Throwable.instancehelper_toString(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		69,
		140,
		byte.MaxValue,
		28,
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
		Class javaClass = getClassMetaobject().getJavaClass();
		NoSuchFieldException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				javaClass.getField(name, Metaobject.___003CGetCallerID_003E()).set(getObject(), value, Metaobject.___003CGetCallerID_003E());
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
			goto IL_0044;
		}
		NoSuchFieldException @this = ex;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
		IL_0044:
		IllegalAccessException this2 = ex2;
		string message2 = Throwable.instancehelper_toString(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 160, 118, 159, 28, 97, 140, 98 })]
	public virtual object trapMethodcall(int identifier, object[] args)
	{
		//Discarded unreachable code: IL_001b
		InvocationTargetException ex;
		IllegalAccessException ex2;
		try
		{
			try
			{
				return methods[identifier].invoke(getObject(), args, Metaobject.___003CGetCallerID_003E());
			}
			catch (InvocationTargetException x)
			{
				ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IllegalAccessException x2)
		{
			ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0037;
		}
		InvocationTargetException ex3 = ex;
		throw Throwable.___003Cunmap_003E(ex3.getTargetException());
		IL_0037:
		IllegalAccessException e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotInvokeException(e);
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
	public static implicit operator Serializable(Metaobject P_0)
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
	protected Metaobject(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
