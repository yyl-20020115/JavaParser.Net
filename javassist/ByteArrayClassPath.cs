using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;

namespace javassist;

public class ByteArrayClassPath : Object, ClassPath
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class BytecodeURLConnection : URLConnection
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ByteArrayClassPath this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 57, 103, 105 })]
		protected internal BytecodeURLConnection(ByteArrayClassPath P_0, URL P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[Throws(new string[] { "java.io.IOException" })]
		public override void connect()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(115)]
		public override InputStream getInputStream()
		{
			ByteArrayInputStream result = new ByteArrayInputStream(this_00240.classfile);
			_ = null;
			return result;
		}

		[LineNumberTable(119)]
		public override int getContentLength()
		{
			return this_00240.classfile.Length;
		}

		[HideFromJava]
		static BytecodeURLConnection()
		{
			URLConnection.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class BytecodeURLStreamHandler : URLStreamHandler
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ByteArrayClassPath this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(100)]
		internal BytecodeURLStreamHandler(ByteArrayClassPath P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		private BytecodeURLStreamHandler(ByteArrayClassPath P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(102)]
		protected internal override URLConnection openConnection(URL P_0)
		{
			BytecodeURLConnection.___003Cclinit_003E();
			BytecodeURLConnection result = new BytecodeURLConnection(this_00240, P_0);
			_ = null;
			return result;
		}
	}

	protected internal string classname;

	protected internal byte[] classfile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 104, 103, 103 })]
	public ByteArrayClassPath(string name, byte[] classfile)
	{
		classname = name;
		this.classfile = classfile;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public override string toString()
	{
		string result = new StringBuilder().append("byte[]:").append(classname).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 29, 110, 110 })]
	public virtual InputStream openClassfile(string classname)
	{
		if (String.instancehelper_equals(this.classname, classname))
		{
			ByteArrayInputStream result = new ByteArrayInputStream(classfile);
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 113, 159, 5, 159, 28, 161 })]
	public virtual URL find(string classname)
	{
		//Discarded unreachable code: IL_0063
		if (String.instancehelper_equals(this.classname, classname))
		{
			string str = new StringBuilder().append(String.instancehelper_replace(classname, '.', '/')).append(".class").toString();
			try
			{
				URL.___003Cclinit_003E();
				return new URL(null, new StringBuilder().append("file:/ByteArrayClassPath/").append(str).toString(), new BytecodeURLStreamHandler(this, null));
			}
			catch (MalformedURLException)
			{
			}
			_ = null;
		}
		return null;
	}
}
