using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.net;
using java.nio.charset;
using java.util;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)65,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class Resources : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/io/LineProcessor<Ljava/util/List<Ljava/lang/String;>;>;")]
	[EnclosingMethod(null, "readLines", "(Ljava.net.URL;Ljava.nio.charset.Charset;)Ljava.util.List;")]
	internal class _1 : Object, LineProcessor
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<Ljava/lang/String;>;")]
		internal List result;

		[Signature("()Ljava/util/List<Ljava/lang/String;>;")]
		public virtual List getResult()
		{
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 97, 104 })]
		internal _1()
		{
			result = Lists.newArrayList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 102, 109 })]
		public virtual bool processLine(string P_0)
		{
			result.add(P_0);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(147)]
		public virtual object getResult()
		{
			List list = this.getResult();
			_ = null;
			return list;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class UrlByteSource : ByteSource
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private URL url;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(58)]
		internal UrlByteSource(URL P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 104, 113 })]
		private UrlByteSource(URL P_0)
		{
			url = (URL)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(68)]
		public override InputStream openStream()
		{
			InputStream result = url.openStream();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		public override string toString()
		{
			string text = String.valueOf(url);
			int num = 24 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Resources.asByteSource(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public static ByteSource asByteSource(URL url)
	{
		UrlByteSource result = new UrlByteSource(url, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public static CharSource asCharSource(URL url, Charset charset)
	{
		CharSource result = asByteSource(url).asCharSource(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/net/URL;Ljava/nio/charset/Charset;Lcom/google/common/io/LineProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 65, 0, 0 })]
	[LineNumberTable(125)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public static object readLines(URL url, Charset charset, LineProcessor callback)
	{
		object result = asCharSource(url, charset).readLines(callback);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	private Resources()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(94)]
	public static byte[] toByteArray(URL url)
	{
		byte[] result = asByteSource(url).read();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(107)]
	public static string toString(URL url, Charset charset)
	{
		string result = asCharSource(url, charset).read();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/net/URL;Ljava/nio/charset/Charset;)Ljava/util/List<Ljava/lang/String;>;")]
	[LineNumberTable(144)]
	public static List readLines(URL url, Charset charset)
	{
		return (List)readLines(url, charset, new _1());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 121, 109 })]
	public static void copy(URL from, OutputStream to)
	{
		asByteSource(from).copyTo(to);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 78, 57, 139, 104, 114 })]
	public static URL getResource(string resourceName)
	{
		ClassLoader classLoader = (ClassLoader)MoreObjects.firstNonNull(Thread.currentThread().getContextClassLoader(), ClassLiteral<Resources>.Value.getClassLoader(Resources.___003CGetCallerID_003E()));
		URL resource = classLoader.getResource(resourceName);
		Preconditions.checkArgument(resource != null, "resource %s not found.", resourceName);
		return resource;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/String;)Ljava/net/URL;")]
	[LineNumberTable(new byte[] { 160, 92, 104, 110, 37, 133 })]
	public static URL getResource(Class contextClass, string resourceName)
	{
		URL resource = contextClass.getResource(resourceName);
		Preconditions.checkArgument(resource != null, "resource %s relative to %s not found.", resourceName, contextClass.getName());
		return resource;
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
