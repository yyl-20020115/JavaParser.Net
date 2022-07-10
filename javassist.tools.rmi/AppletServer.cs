using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javassist.tools.web;

namespace javassist.tools.rmi;

public class AppletServer : Webserver
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private StubGenerator stubGen;

	[Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/tools/rmi/ExportedObject;>;")]
	private Map exportedNames;

	[Signature("Ljava/util/List<Ljavassist/tools/rmi/ExportedObject;>;")]
	private List exportedObjects;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static byte[] okHeader;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 25, 115 })]
	public AppletServer(int port)
		: this(ClassPool.getDefault(), new StubGenerator(), port)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 43, 105, 107, 107, 103, 106 })]
	private AppletServer(ClassPool P_0, StubGenerator P_1, int P_2)
		: base(P_2)
	{
		exportedNames = new Hashtable();
		exportedObjects = new Vector();
		stubGen = P_1;
		addTranslator(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		110,
		135,
		103,
		103,
		98,
		131,
		115,
		105,
		byte.MaxValue,
		30,
		70,
		226,
		61,
		98,
		99,
		173,
		107,
		104,
		99,
		104,
		210,
		104,
		byte.MaxValue,
		12,
		71,
		226,
		59,
		98,
		205,
		2,
		98,
		173,
		103,
		103,
		102
	})]
	private void processRMI(InputStream P_0, OutputStream P_1)
	{
		ObjectInputStream objectInputStream = new ObjectInputStream(P_0);
		int index = objectInputStream.readInt();
		int num = objectInputStream.readInt();
		java.lang.Exception ex = null;
		object obj = null;
		java.lang.Exception ex3;
		try
		{
			ExportedObject exportedObject = (ExportedObject)exportedObjects.get(index);
			object[] args = readParameters(objectInputStream);
			obj = convertRvalue(exportedObject.methods[num].invoke(exportedObject.@object, args, AppletServer.___003CGetCallerID_003E()));
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex2 = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex2 == null)
			{
				throw;
			}
			ex3 = ex2;
			goto IL_006f;
		}
		goto IL_0087;
		IL_006f:
		java.lang.Exception ex4 = ex3;
		ex = ex4;
		logging2(Throwable.instancehelper_toString(ex4));
		goto IL_0087;
		IL_0087:
		P_1.write(okHeader);
		ObjectOutputStream objectOutputStream = new ObjectOutputStream(P_1);
		NotSerializableException ex5;
		InvalidClassException ex6;
		if (ex != null)
		{
			objectOutputStream.writeBoolean(val: false);
			objectOutputStream.writeUTF(Throwable.instancehelper_toString(ex));
		}
		else
		{
			try
			{
				try
				{
					objectOutputStream.writeBoolean(val: true);
					objectOutputStream.writeObject(obj);
				}
				catch (NotSerializableException x2)
				{
					ex5 = ByteCodeHelper.MapException<NotSerializableException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00e2;
				}
			}
			catch (InvalidClassException x3)
			{
				ex6 = ByteCodeHelper.MapException<InvalidClassException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00e6;
			}
		}
		goto IL_010c;
		IL_00e2:
		NotSerializableException @this = ex5;
		logging2(Throwable.instancehelper_toString(@this));
		goto IL_010c;
		IL_010c:
		objectOutputStream.flush();
		objectOutputStream.close();
		objectInputStream.close();
		return;
		IL_00e6:
		InvalidClassException this2 = ex6;
		logging2(Throwable.instancehelper_toString(this2));
		goto IL_010c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 120, 103, 103, 114, 107, 103, 99, 127, 1,
		103, 173, 103, 108, 182, 102, 102, 104
	})]
	private void lookupName(string P_0, InputStream P_1, OutputStream P_2)
	{
		ObjectInputStream objectInputStream = new ObjectInputStream(P_1);
		string text = DataInputStream.readUTF(objectInputStream);
		ExportedObject exportedObject = (ExportedObject)exportedNames.get(text);
		P_2.write(okHeader);
		ObjectOutputStream objectOutputStream = new ObjectOutputStream(P_2);
		if (exportedObject == null)
		{
			logging2(new StringBuilder().append(text).append("not found.").toString());
			objectOutputStream.writeInt(-1);
			objectOutputStream.writeUTF("error");
		}
		else
		{
			logging2(text);
			objectOutputStream.writeInt(exportedObject.identifier);
			objectOutputStream.writeUTF(java.lang.Object.instancehelper_getClass(exportedObject.@object).getName());
		}
		objectOutputStream.flush();
		objectOutputStream.close();
		objectInputStream.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 89, 103, 103, 102, 103, 104, 104, 121, 168,
		228, 56, 230, 75
	})]
	private object[] readParameters(ObjectInputStream P_0)
	{
		int num = P_0.readInt();
		object[] array = new object[num];
		for (int i = 0; i < num; i++)
		{
			object obj = P_0.readObject();
			if (obj is RemoteRef)
			{
				RemoteRef remoteRef = (RemoteRef)obj;
				ExportedObject exportedObject = (ExportedObject)exportedObjects.get(remoteRef.oid);
				obj = exportedObject.@object;
			}
			array[i] = obj;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 108, 99, 130, 108, 110, 113 })]
	private object convertRvalue(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		string name = java.lang.Object.instancehelper_getClass(P_0).getName();
		if (stubGen.isProxyClass(name))
		{
			RemoteRef result = new RemoteRef(exportObject(null, P_0), name);
			_ = null;
			return result;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		73, 103, 102, 103, 113, 109, 115, 99, 174, 223,
		0, 2, 97, 172
	})]
	public virtual int exportObject(string name, object obj)
	{
		Class @class = java.lang.Object.instancehelper_getClass(obj);
		ExportedObject exportedObject = new ExportedObject();
		exportedObject.@object = obj;
		exportedObject.methods = @class.getMethods(AppletServer.___003CGetCallerID_003E());
		exportedObjects.add(exportedObject);
		exportedObject.identifier = exportedObjects.size() - 1;
		if (name != null)
		{
			exportedNames.put(name, exportedObject);
		}
		NotFoundException ex;
		try
		{
			stubGen.makeProxyClass(@class);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0072;
		}
		return exportedObject.identifier;
		IL_0072:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 14, 110 })]
	public AppletServer(string port)
		: this(Integer.parseInt(port))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 37, 116 })]
	public AppletServer(int port, ClassPool src)
		: this(new ClassPool(src), new StubGenerator(), port)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 55, 104 })]
	public override void run()
	{
		base.run();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.tools.web.BadHttpRequest" })]
	[LineNumberTable(new byte[] { 99, 109, 106, 109, 139, 107 })]
	public override void doReply(InputStream @in, OutputStream @out, string cmd)
	{
		if (java.lang.String.instancehelper_startsWith(cmd, "POST /rmi "))
		{
			processRMI(@in, @out);
		}
		else if (java.lang.String.instancehelper_startsWith(cmd, "POST /lookup "))
		{
			lookupName(cmd, @in, @out);
		}
		else
		{
			base.doReply(@in, @out, cmd);
		}
	}

	[LineNumberTable(new byte[] { 159, 129, 101, 101, 42 })]
	static AppletServer()
	{
		Webserver.___003Cclinit_003E();
		okHeader = java.lang.String.instancehelper_getBytes("HTTP/1.0 200 OK\r\n\r\n");
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
