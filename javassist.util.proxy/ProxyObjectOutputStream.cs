using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;

namespace javassist.util.proxy;

public class ProxyObjectOutputStream : ObjectOutputStream
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 186, 105 })]
	public ProxyObjectOutputStream(OutputStream @out)
		: base(@out)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		159, 191, 108, 107, 103, 103, 103, 103, 104, 136,
		106, 105, 102, 114, 107, 232, 60, 232, 71, 104,
		103, 98, 103, 137
	})]
	protected internal override void writeClassDescriptor(ObjectStreamClass desc)
	{
		Class @class = desc.forClass(ProxyObjectOutputStream.___003CGetCallerID_003E());
		if (ProxyFactory.isProxyClass(@class))
		{
			writeBoolean(val: true);
			Class superclass = @class.getSuperclass();
			Class[] interfaces = @class.getInterfaces();
			byte[] filterSignature = ProxyFactory.getFilterSignature(@class);
			string name = superclass.getName();
			writeObject(name);
			writeInt((int)((nint)interfaces.LongLength - 1));
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				Class class2 = interfaces[i];
				if (class2 != ClassLiteral<ProxyObject>.Value && class2 != ClassLiteral<Proxy>.Value)
				{
					name = interfaces[i].getName();
					writeObject(name);
				}
			}
			writeInt(filterSignature.Length);
			write(filterSignature);
		}
		else
		{
			writeBoolean(val: false);
			base.writeClassDescriptor(desc);
		}
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
	static ProxyObjectOutputStream()
	{
		ObjectOutputStream.___003Cclinit_003E();
	}
}
