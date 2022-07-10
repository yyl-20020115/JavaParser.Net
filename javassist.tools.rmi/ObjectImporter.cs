using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.applet;
using java.io;
using java.lang;
using java.lang.reflect;
using java.net;

namespace javassist.tools.rmi;

[Serializable]
[Implements(new string[] { "java.io.Serializable" })]
public class ObjectImporter : java.lang.Object, Serializable.__Interface, ISerializable
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const long serialVersionUID = 1L;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private byte[] endofline;

	private string servername;

	private string orgServername;

	private int port;

	private int orgPort;

	protected internal byte[] lookupCommand;

	protected internal byte[] rmiCommand;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("[Ljava/lang/Class<*>;")]
	private static Class[] proxyConstructorParamTypes;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.tools.rmi.ObjectNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		115,
		114,
		103,
		108,
		108,
		140,
		103,
		103,
		134,
		113,
		103,
		104,
		105,
		105,
		103,
		102,
		134,
		101,
		byte.MaxValue,
		15,
		69,
		226,
		61,
		98,
		103,
		174
	})]
	public virtual object lookupObject(string name)
	{
		//Discarded unreachable code: IL_00a9
		java.lang.Exception ex2;
		try
		{
			Socket socket = new Socket(servername, port);
			OutputStream outputStream = socket.getOutputStream();
			outputStream.write(lookupCommand);
			outputStream.write(endofline);
			outputStream.write(endofline);
			ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);
			objectOutputStream.writeUTF(name);
			objectOutputStream.flush();
			BufferedInputStream.___003Cclinit_003E();
			BufferedInputStream bufferedInputStream = new BufferedInputStream(socket.getInputStream());
			skipHeader(bufferedInputStream);
			ObjectInputStream objectInputStream = new ObjectInputStream(bufferedInputStream);
			int num = objectInputStream.readInt();
			string text = objectInputStream.readUTF();
			objectInputStream.close();
			objectOutputStream.close();
			socket.close();
			if (num >= 0)
			{
				return createProxy(num, text);
			}
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
			goto IL_00c4;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ObjectNotFoundException(name);
		IL_00c4:
		java.lang.Exception ex3 = ex2;
		Throwable.instancehelper_printStackTrace(ex3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ObjectNotFoundException(name, ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 172, 98, 112, 134, 103, 100 })]
	private void skipHeader(InputStream P_0)
	{
		int num;
		do
		{
			num = 0;
			int num2;
			while ((num2 = P_0.read()) >= 0 && num2 != 13)
			{
				num++;
			}
			P_0.read();
		}
		while (num > 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[] { 160, 85, 108, 113 })]
	private object createProxy(int P_0, string P_1)
	{
		Class @class = Class.forName(P_1, ObjectImporter.___003CGetCallerID_003E());
		Constructor constructor = @class.getConstructor(proxyConstructorParamTypes, ObjectImporter.___003CGetCallerID_003E());
		object result = constructor.newInstance(new object[2]
		{
			this,
			Integer.valueOf(P_0)
		}, ObjectImporter.___003CGetCallerID_003E());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 183, 99, 103, 102, 106, 105, 113, 130, 233,
		58, 230, 71
	})]
	private void writeParameters(ObjectOutputStream P_0, object[] P_1)
	{
		int num = P_1.Length;
		P_0.writeInt(num);
		for (int i = 0; i < num; i++)
		{
			if (P_1[i] is Proxy)
			{
				Proxy proxy = (Proxy)P_1[i];
				P_0.writeObject(new RemoteRef(proxy._getObjectId()));
			}
			else
			{
				P_0.writeObject(P_1[i]);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 232, 49, 214, 112, 240, 76, 103, 119, 119 })]
	public ObjectImporter(Applet applet)
	{
		endofline = new byte[2] { 13, 10 };
		lookupCommand = java.lang.String.instancehelper_getBytes("POST /lookup HTTP/1.0");
		rmiCommand = java.lang.String.instancehelper_getBytes("POST /rmi HTTP/1.0");
		URL codeBase = applet.getCodeBase();
		string host = codeBase.getHost();
		servername = host;
		orgServername = host;
		int num = codeBase.getPort();
		port = num;
		orgPort = num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 69, 232, 29, 214, 112, 240, 95, 114, 114 })]
	public ObjectImporter(string servername, int port)
	{
		endofline = new byte[2] { 13, 10 };
		lookupCommand = java.lang.String.instancehelper_getBytes("POST /lookup HTTP/1.0");
		rmiCommand = java.lang.String.instancehelper_getBytes("POST /rmi HTTP/1.0");
		this.servername = servername;
		orgServername = servername;
		this.port = port;
		orgPort = port;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 150, 97 })]
	public virtual object getObject(string name)
	{
		//Discarded unreachable code: IL_0009
		try
		{
			return lookupObject(name);
		}
		catch (ObjectNotFoundException)
		{
		}
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 127, 22, 123, 108, 123, 108, 103, 103 })]
	public virtual void setHttpProxy(string host, int port)
	{
		string str = new StringBuilder().append("POST http://").append(orgServername).append(":")
			.append(orgPort)
			.toString();
		string @this = new StringBuilder().append(str).append("/lookup HTTP/1.0").toString();
		lookupCommand = java.lang.String.instancehelper_getBytes(@this);
		@this = new StringBuilder().append(str).append("/rmi HTTP/1.0").toString();
		rmiCommand = java.lang.String.instancehelper_getBytes(@this);
		servername = host;
		this.port = port;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.tools.rmi.RemoteException" })]
	[LineNumberTable(new byte[]
	{
		160,
		120,
		114,
		97,
		107,
		108,
		108,
		140,
		103,
		103,
		103,
		104,
		134,
		113,
		103,
		104,
		105,
		99,
		99,
		100,
		139,
		137,
		103,
		102,
		134,
		105,
		105,
		byte.MaxValue,
		44,
		75,
		226,
		56,
		98,
		141,
		98,
		141,
		98,
		173,
		100,
		99
	})]
	public virtual object call(int objectid, int methodid, object[] args)
	{
		int num;
		object obj;
		string text;
		java.lang.ClassNotFoundException ex;
		IOException ex2;
		java.lang.Exception ex4;
		try
		{
			try
			{
				try
				{
					Socket socket = new Socket(servername, port);
					BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(socket.getOutputStream());
					bufferedOutputStream.write(rmiCommand);
					bufferedOutputStream.write(endofline);
					bufferedOutputStream.write(endofline);
					ObjectOutputStream objectOutputStream = new ObjectOutputStream(bufferedOutputStream);
					objectOutputStream.writeInt(objectid);
					objectOutputStream.writeInt(methodid);
					writeParameters(objectOutputStream, args);
					objectOutputStream.flush();
					BufferedInputStream.___003Cclinit_003E();
					BufferedInputStream bufferedInputStream = new BufferedInputStream(socket.getInputStream());
					skipHeader(bufferedInputStream);
					ObjectInputStream objectInputStream = new ObjectInputStream(bufferedInputStream);
					num = (objectInputStream.readBoolean() ? 1 : 0);
					obj = null;
					text = null;
					if (num != 0)
					{
						obj = objectInputStream.readObject();
					}
					else
					{
						text = objectInputStream.readUTF();
					}
					objectInputStream.close();
					objectOutputStream.close();
					socket.close();
					if (obj is RemoteRef)
					{
						RemoteRef remoteRef = (RemoteRef)obj;
						obj = createProxy(remoteRef.oid, remoteRef.classname);
					}
				}
				catch (java.lang.ClassNotFoundException x)
				{
					ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0110;
				}
			}
			catch (IOException x2)
			{
				ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0114;
			}
		}
		catch (System.Exception x3)
		{
			java.lang.Exception ex3 = ByteCodeHelper.MapException<java.lang.Exception>(x3, ByteCodeHelper.MapFlags.None);
			if (ex3 == null)
			{
				throw;
			}
			ex4 = ex3;
			goto IL_0118;
		}
		if (num != 0)
		{
			return obj;
		}
		string msg = text;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RemoteException(msg);
		IL_0118:
		java.lang.Exception e = ex4;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RemoteException(e);
		IL_0114:
		IOException e2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RemoteException(e2);
		IL_0110:
		java.lang.ClassNotFoundException e3 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RemoteException(e3);
	}

	[LineNumberTable(195)]
	static ObjectImporter()
	{
		proxyConstructorParamTypes = new Class[2]
		{
			ClassLiteral<ObjectImporter>.Value,
			Integer.TYPE
		};
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
	public static implicit operator Serializable(ObjectImporter P_0)
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
	protected ObjectImporter(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
