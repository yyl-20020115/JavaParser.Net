using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.tools.rmi;

public class Sample : Object
{
	private ObjectImporter importer;

	private int objectId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	public Sample()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public virtual object forward(object[] args, int identifier)
	{
		object result = importer.call(objectId, identifier, args);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.tools.rmi.RemoteException" })]
	[LineNumberTable(35)]
	public static object forwardStatic(object[] args, int identifier)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RemoteException("cannot call a static method.");
	}
}
