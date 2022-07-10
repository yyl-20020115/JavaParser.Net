using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.io;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using java.nio.charset;
using java.util;
using java.util.function;
using java.util.jar;
using java.util.logging;
using javax.annotation;

namespace com.google.common.reflect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public sealed class ClassPath : Object
{
	public sealed class ClassInfo : ResourceInfo
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string className;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 190, 107, 108 })]
		internal ClassInfo(File P_0, string P_1, ClassLoader P_2)
			: base(P_0, P_1, P_2)
		{
			className = getClassName(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(320)]
		public virtual string getPackageName()
		{
			string packageName = Reflection.getPackageName(className);
			_ = null;
			return packageName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 219, 110, 100, 175, 159, 3, 103, 104, 199 })]
		public virtual string getSimpleName()
		{
			int num = String.instancehelper_lastIndexOf(className, 36);
			string __003Cref_003E;
			if (num != -1)
			{
				__003Cref_003E = String.instancehelper_substring(className, num + 1);
				CharMatcher charMatcher = CharMatcher.inRange('0', '9');
				CharSequence sequence = default(CharSequence);
				object obj = (sequence.___003Cref_003E = __003Cref_003E);
				string result = charMatcher.trimLeadingFrom(sequence);
				_ = null;
				return result;
			}
			__003Cref_003E = getPackageName();
			if (String.instancehelper_isEmpty(__003Cref_003E))
			{
				return className;
			}
			string result2 = String.instancehelper_substring(className, String.instancehelper_length(__003Cref_003E) + 1);
			_ = null;
			return result2;
		}

		public virtual string getName()
		{
			return className;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(368)]
		public virtual bool isTopLevel()
		{
			return String.instancehelper_indexOf(className, 36) == -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 161, 9, 127, 8, 129 })]
		public virtual Class load()
		{
			//Discarded unreachable code: IL_0013
			java.lang.ClassNotFoundException ex;
			try
			{
				return loader.loadClass(className);
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			java.lang.ClassNotFoundException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		public override string toString()
		{
			return className;
		}
	}

	internal sealed class LocationInfo : Object
	{
		[Modifiers(Modifiers.Final)]
		internal File home;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ClassLoader classloader;

		public File file()
		{
			return home;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("(Ljava/util/Set<Ljava/io/File;>;)Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;")]
		[LineNumberTable(new byte[] { 161, 73, 102, 109, 110 })]
		public virtual ImmutableSet scanResources(Set P_0)
		{
			ImmutableSet.Builder builder = ImmutableSet.builder();
			P_0.add(home);
			scan(home, P_0, builder);
			ImmutableSet result = builder.build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 43, 104, 113, 113 })]
		internal LocationInfo(File P_0, ClassLoader P_1)
		{
			home = (File)Preconditions.checkNotNull(P_0);
			classloader = (ClassLoader)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("(Ljava/io/File;Ljava/util/Set<Ljava/io/File;>;Lcom/google/common/collect/ImmutableSet$Builder<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 82, 126, 225, 70, 229, 60, 97, 159, 69,
			129, 104, 138, 137
		})]
		private void scan(File P_0, Set P_1, ImmutableSet.Builder P_2)
		{
			SecurityException ex;
			try
			{
				if (!P_0.exists())
				{
					return;
				}
			}
			catch (SecurityException x)
			{
				ex = ByteCodeHelper.MapException<SecurityException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_001b;
			}
			if (P_0.isDirectory())
			{
				scanDirectory(P_0, P_2);
			}
			else
			{
				scanJar(P_0, P_1, P_2);
			}
			return;
			IL_001b:
			SecurityException obj = ex;
			Logger logger = access_0024000();
			string text = String.valueOf(P_0);
			string text2 = String.valueOf(obj);
			int num = 16 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
			num = num;
			logger.warning(new StringBuilder(num).append("Cannot access ").append(text).append(": ")
				.append(text2)
				.toString());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("(Ljava/io/File;Lcom/google/common/collect/ImmutableSet$Builder<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
		[LineNumberTable(new byte[] { 161, 137, 102, 109, 112 })]
		private void scanDirectory(File P_0, ImmutableSet.Builder P_1)
		{
			HashSet hashSet = new HashSet();
			((Set)hashSet).add((object)P_0.getCanonicalFile());
			scanDirectory(P_0, "", hashSet, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("(Ljava/io/File;Ljava/util/Set<Ljava/io/File;>;Lcom/google/common/collect/ImmutableSet$Builder<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 102, 210, 226, 61, 129, 161, 191, 7, 110,
			137, 98, 172, 145, 34, 129, 227, 61, 145, 34,
			129, 98
		})]
		private void scanJar(File P_0, Set P_1, ImmutableSet.Builder P_2)
		{
			JarFile jarFile;
			try
			{
				jarFile = new JarFile(P_0);
			}
			catch (IOException)
			{
				goto IL_000f;
			}
			try
			{
				UnmodifiableIterator unmodifiableIterator = getClassPathFromManifest(P_0, jarFile.getManifest()).iterator();
				while (((Iterator)unmodifiableIterator).hasNext())
				{
					File file = (File)((Iterator)unmodifiableIterator).next();
					if (P_1.add(file.getCanonicalFile()))
					{
						scan(file, P_1, P_2);
					}
				}
				scanJarFile(jarFile, P_2);
			}
			catch
			{
				//try-fault
				try
				{
					jarFile.close();
				}
				catch (IOException)
				{
					goto IL_006f;
				}
				goto end_IL_0061;
				IL_006f:
				_ = null;
				end_IL_0061:
				throw;
			}
			try
			{
				jarFile.close();
				return;
			}
			catch (IOException)
			{
			}
			_ = null;
			return;
			IL_000f:
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/jar/JarFile;Lcom/google/common/collect/ImmutableSet$Builder<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
		[LineNumberTable(new byte[] { 161, 125, 103, 104, 108, 122, 130, 127, 9, 98 })]
		private void scanJarFile(JarFile P_0, ImmutableSet.Builder P_1)
		{
			Enumeration enumeration = P_0.entries();
			while (enumeration.hasMoreElements())
			{
				JarEntry jarEntry = (JarEntry)enumeration.nextElement();
				if (!jarEntry.isDirectory() && !String.instancehelper_equals(jarEntry.getName(), "META-INF/MANIFEST.MF"))
				{
					File.___003Cclinit_003E();
					P_1.add(ResourceInfo.of(new File(P_0.getName()), jarEntry.getName(), classloader));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("(Ljava/io/File;Ljava/lang/String;Ljava/util/Set<Ljava/io/File;>;Lcom/google/common/collect/ImmutableSet$Builder<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 159, 103, 99, 159, 32, 129, 120, 105, 108,
			105, 106, 127, 43, 137, 98, 127, 13, 110, 247,
			53, 235, 79
		})]
		private void scanDirectory(File P_0, string P_1, Set P_2, ImmutableSet.Builder P_3)
		{
			File[] array = P_0.listFiles();
			if (array == null)
			{
				Logger logger = access_0024000();
				string text = String.valueOf(P_0);
				int num = 22 + String.instancehelper_length(String.valueOf(text));
				num = num;
				logger.warning(new StringBuilder(num).append("Cannot read directory ").append(text).toString());
				return;
			}
			File[] array2 = array;
			int num2 = array2.Length;
			for (int i = 0; i < num2; i++)
			{
				File file = array2[i];
				string name = file.getName();
				if (file.isDirectory())
				{
					File canonicalFile = file.getCanonicalFile();
					if (P_2.add(canonicalFile))
					{
						int num = 1 + String.instancehelper_length(String.valueOf(P_1)) + String.instancehelper_length(String.valueOf(name));
						num = num;
						scanDirectory(canonicalFile, new StringBuilder(num).append(P_1).append(name).append("/")
							.toString(), P_2, P_3);
						P_2.remove(canonicalFile);
					}
					continue;
				}
				string text2 = String.valueOf(P_1);
				string text3 = String.valueOf(name);
				string text4;
				if (String.instancehelper_length(text3) != 0)
				{
					text4 = String.instancehelper_concat(text2, text3);
				}
				else
				{
					string text5 = text2;
					text5 = text5;
					text4 = String.newhelper(text5);
				}
				string text6 = text4;
				if (!String.instancehelper_equals(text6, "META-INF/MANIFEST.MF"))
				{
					P_3.add(ResourceInfo.of(file, text6, classloader));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;")]
		[LineNumberTable(425)]
		public virtual ImmutableSet scanResources()
		{
			ImmutableSet result = scanResources(new HashSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 184, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is LocationInfo)
			{
				LocationInfo locationInfo = (LocationInfo)P_0;
				return (home.equals(locationInfo.home) && Object.instancehelper_equals(classloader, locationInfo.classloader)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(563)]
		public override int hashCode()
		{
			int result = home.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(568)]
		public override string toString()
		{
			string result = home.toString();
			_ = null;
			return result;
		}
	}

	public class ResourceInfo : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private File file;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string resourceName;

		[Modifiers(Modifiers.Final)]
		internal ClassLoader loader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 105, 104, 113, 113, 113 })]
		internal ResourceInfo(File P_0, string P_1, ClassLoader P_2)
		{
			file = (File)Preconditions.checkNotNull(P_0);
			resourceName = (string)Preconditions.checkNotNull(P_1);
			loader = (ClassLoader)Preconditions.checkNotNull(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 120, 114, 99, 145 })]
		public URL url()
		{
			URL resource = loader.getResource(resourceName);
			if (resource == null)
			{
				string s = resourceName;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException(s);
			}
			return resource;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 98, 109, 139 })]
		internal static ResourceInfo of(File P_0, string P_1, ClassLoader P_2)
		{
			if (String.instancehelper_endsWith(P_1, ".class"))
			{
				ClassInfo result = new ClassInfo(P_0, P_1, P_2);
				_ = null;
				return result;
			}
			ResourceInfo result2 = new ResourceInfo(P_0, P_1, P_2);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(249)]
		public ByteSource asByteSource()
		{
			ByteSource result = com.google.common.io.Resources.asByteSource(url());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(261)]
		public CharSource asCharSource(Charset charset)
		{
			CharSource result = com.google.common.io.Resources.asCharSource(url(), charset);
			_ = null;
			return result;
		}

		public string getResourceName()
		{
			return resourceName;
		}

		internal File getFile()
		{
			return file;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(276)]
		public override int hashCode()
		{
			int result = String.instancehelper_hashCode(resourceName);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 167, 104, 103, 159, 7 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object obj)
		{
			if (obj is ResourceInfo)
			{
				ResourceInfo resourceInfo = (ResourceInfo)obj;
				return (String.instancehelper_equals(resourceName, resourceInfo.resourceName) && loader == resourceInfo.loader) ? true : false;
			}
			return false;
		}

		public override string toString()
		{
			return resourceName;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool apply(object P_0)
		{
			bool result = ((ClassInfo)P_0).isTopLevel();
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public bool test(object P_0)
		{
			return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
		}

		[SpecialName]
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[SpecialName]
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[SpecialName]
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Splitter CLASS_PATH_ATTRIBUTE_SEPARATOR;

	private const string CLASS_FILE_NAME_EXTENSION = ".class";

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;")]
	private ImmutableSet resources;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 43, 114 })]
	internal static string getClassName(string P_0)
	{
		int endIndex = String.instancehelper_length(P_0) - String.instancehelper_length(".class");
		string result = String.instancehelper_replace(String.instancehelper_substring(P_0, 0, endIndex), '/', '.');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/ClassLoader;)Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$LocationInfo;>;")]
	[LineNumberTable(new byte[] { 161, 28, 102, 127, 6, 127, 3, 98 })]
	internal static ImmutableSet locationsFrom(ClassLoader P_0)
	{
		ImmutableSet.Builder builder = ImmutableSet.builder();
		UnmodifiableIterator unmodifiableIterator = getClassPathEntries(P_0).entrySet().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
			builder.add(new LocationInfo((File)entry.getKey(), (ClassLoader)entry.getValue()));
		}
		ImmutableSet result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;)V")]
	[LineNumberTable(new byte[] { 55, 104, 103 })]
	private ClassPath(ImmutableSet P_0)
	{
		resources = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ClassInfo;>;")]
	[LineNumberTable(new byte[] { 115, 112, 111, 101, 231, 61 })]
	public virtual ImmutableSet getTopLevelClasses()
	{
		ImmutableSet result = FluentIterable.from(resources).filter(ClassLiteral<ClassInfo>.Value).filter(new ___003C_003EAnon0())
			.toSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/ClassLoader;)Lcom/google/common/collect/ImmutableMap<Ljava/io/File;Ljava/lang/ClassLoader;>;")]
	[LineNumberTable(new byte[]
	{
		161, 238, 134, 103, 99, 140, 127, 1, 114, 104,
		106, 170, 98
	})]
	internal static ImmutableMap getClassPathEntries(ClassLoader P_0)
	{
		LinkedHashMap linkedHashMap = Maps.newLinkedHashMap();
		ClassLoader parent = P_0.getParent();
		if (parent != null)
		{
			linkedHashMap.putAll(getClassPathEntries(parent));
		}
		UnmodifiableIterator unmodifiableIterator = getClassLoaderUrls(P_0).iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			URL uRL = (URL)((Iterator)unmodifiableIterator).next();
			if (String.instancehelper_equals(uRL.getProtocol(), "file"))
			{
				File key = toFile(uRL);
				if (!linkedHashMap.containsKey(key))
				{
					linkedHashMap.put(key, P_0);
				}
			}
		}
		ImmutableMap result = ImmutableMap.copyOf(linkedHashMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.net.MalformedURLException" })]
	[LineNumberTable(664)]
	internal static URL getClassPathEntry(File P_0, string P_1)
	{
		URL.___003Cclinit_003E();
		URL result = new URL(P_0.toURI().toURL(), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 50, 149, 127, 0, 97 })]
	internal static File toFile(URL P_0)
	{
		//Discarded unreachable code: IL_0027
		Preconditions.checkArgument(String.instancehelper_equals(P_0.getProtocol(), "file"));
		try
		{
			File.___003Cclinit_003E();
			return new File(P_0.toURI());
		}
		catch (URISyntaxException)
		{
		}
		_ = null;
		File.___003Cclinit_003E();
		return new File(P_0.getPath());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/ClassLoader;)Lcom/google/common/collect/ImmutableList<Ljava/net/URL;>;")]
	[LineNumberTable(new byte[] { 162, 0, 104, 147, 114, 136 })]
	private static ImmutableList getClassLoaderUrls(ClassLoader P_0)
	{
		if (P_0 is URLClassLoader)
		{
			ImmutableList result = ImmutableList.copyOf(((URLClassLoader)P_0).getURLs());
			_ = null;
			return result;
		}
		if (Object.instancehelper_equals(P_0, ClassLoader.getSystemClassLoader(ClassPath.___003CGetCallerID_003E())))
		{
			ImmutableList result2 = parseJavaClassPath();
			_ = null;
			return result2;
		}
		ImmutableList result3 = ImmutableList.of();
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/net/URL;>;")]
	[LineNumberTable(new byte[]
	{
		162, 15, 102, 191, 45, 191, 18, 6, 97, 223,
		24, 2, 98, 159, 27, 101
	})]
	internal static ImmutableList parseJavaClassPath()
	{
		ImmutableList.Builder builder = ImmutableList.builder();
		Splitter splitter = Splitter.on(StandardSystemProperty.___003C_003EPATH_SEPARATOR.value());
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = StandardSystemProperty.___003C_003EJAVA_CLASS_PATH.value());
		Iterator iterator = splitter.split(sequence).iterator();
		while (iterator.hasNext())
		{
			string text = (string)iterator.next();
			MalformedURLException ex2;
			try
			{
				try
				{
					builder.add(new File(text).toURI().toURL());
				}
				catch (SecurityException)
				{
					goto IL_007c;
				}
			}
			catch (MalformedURLException x)
			{
				ex2 = ByteCodeHelper.MapException<MalformedURLException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_007f;
			}
			continue;
			IL_00c3:
			MalformedURLException ex3;
			MalformedURLException thrown = (MalformedURLException)ex3;
			Logger obj2 = logger;
			Level wARNING = Level.WARNING;
			string text2 = String.valueOf(text);
			string msg;
			if (String.instancehelper_length(text2) != 0)
			{
				msg = String.instancehelper_concat("malformed classpath entry: ", text2);
			}
			else
			{
				string text3 = "malformed classpath entry: ";
				text3 = text3;
				msg = String.newhelper(text3);
			}
			obj2.log(wARNING, msg, thrown);
			continue;
			IL_007f:
			ex3 = ex2;
			goto IL_00c3;
			IL_007c:
			SecurityException ex4 = null;
			MalformedURLException ex5;
			try
			{
				URL.___003Cclinit_003E();
				builder.add(new URL("file", null, new File(text).getAbsolutePath()));
			}
			catch (MalformedURLException x2)
			{
				ex5 = ByteCodeHelper.MapException<MalformedURLException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00bd;
			}
			continue;
			IL_00bd:
			ex3 = ex5;
			goto IL_00c3;
		}
		return builder.build();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		76, 199, 102, 123, 109, 162, 103, 127, 0, 112,
		98
	})]
	public static ClassPath from(ClassLoader classloader)
	{
		ImmutableSet immutableSet = locationsFrom(classloader);
		HashSet hashSet = new HashSet();
		UnmodifiableIterator unmodifiableIterator = immutableSet.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			LocationInfo locationInfo = (LocationInfo)((Iterator)unmodifiableIterator).next();
			((Set)hashSet).add((object)locationInfo.file());
		}
		ImmutableSet.Builder builder = ImmutableSet.builder();
		UnmodifiableIterator unmodifiableIterator2 = immutableSet.iterator();
		while (((Iterator)unmodifiableIterator2).hasNext())
		{
			LocationInfo locationInfo2 = (LocationInfo)((Iterator)unmodifiableIterator2).next();
			builder.addAll(locationInfo2.scanResources(hashSet));
		}
		ClassPath result = new ClassPath(builder.build());
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ResourceInfo;>;")]
	public virtual ImmutableSet getResources()
	{
		return resources;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ClassInfo;>;")]
	[LineNumberTable(157)]
	public virtual ImmutableSet getAllClasses()
	{
		ImmutableSet result = FluentIterable.from(resources).filter(ClassLiteral<ClassInfo>.Value).toSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ClassInfo;>;")]
	[LineNumberTable(new byte[] { 123, 103, 102, 127, 1, 110, 136, 98 })]
	public virtual ImmutableSet getTopLevelClasses(string packageName)
	{
		Preconditions.checkNotNull(packageName);
		ImmutableSet.Builder builder = ImmutableSet.builder();
		UnmodifiableIterator unmodifiableIterator = getTopLevelClasses().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			ClassInfo classInfo = (ClassInfo)((Iterator)unmodifiableIterator).next();
			if (String.instancehelper_equals(classInfo.getPackageName(), packageName))
			{
				builder.add(classInfo);
			}
		}
		ImmutableSet result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/ClassPath$ClassInfo;>;")]
	[LineNumberTable(new byte[]
	{
		160, 74, 103, 127, 10, 102, 127, 2, 111, 137,
		98
	})]
	public virtual ImmutableSet getTopLevelClassesRecursive(string packageName)
	{
		Preconditions.checkNotNull(packageName);
		int num = 1 + String.instancehelper_length(String.valueOf(packageName));
		num = num;
		string prefix = new StringBuilder(num).append(packageName).append('.').toString();
		ImmutableSet.Builder builder = ImmutableSet.builder();
		UnmodifiableIterator unmodifiableIterator = getTopLevelClasses().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			ClassInfo classInfo = (ClassInfo)((Iterator)unmodifiableIterator).next();
			if (String.instancehelper_startsWith(classInfo.getName(), prefix))
			{
				builder.add(classInfo);
			}
		}
		ImmutableSet result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/io/File;Ljava/util/jar/Manifest;)Lcom/google/common/collect/ImmutableSet<Ljava/io/File;>;")]
	[LineNumberTable(new byte[]
	{
		161, 212, 99, 134, 102, 97, 117, 102, 191, 29,
		245, 69, 226, 60, 129, 127, 20, 133, 115, 142,
		133
	})]
	internal static ImmutableSet getClassPathFromManifest(File P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Manifest P_1)
	{
		if (P_1 == null)
		{
			return ImmutableSet.of();
		}
		ImmutableSet.Builder builder = ImmutableSet.builder();
		string value = P_1.getMainAttributes().getValue(Attributes.Name.CLASS_PATH.toString());
		if (value != null)
		{
			Splitter cLASS_PATH_ATTRIBUTE_SEPARATOR = CLASS_PATH_ATTRIBUTE_SEPARATOR;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = value);
			Iterator iterator = cLASS_PATH_ATTRIBUTE_SEPARATOR.split(sequence).iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				URL classPathEntry;
				try
				{
					classPathEntry = getClassPathEntry(P_0, text);
				}
				catch (MalformedURLException)
				{
					goto IL_0079;
				}
				if (String.instancehelper_equals(classPathEntry.getProtocol(), "file"))
				{
					builder.add(toFile(classPathEntry));
				}
				continue;
				IL_0079:
				_ = null;
				Logger obj2 = logger;
				string text2 = String.valueOf(text);
				string msg;
				if (String.instancehelper_length(text2) != 0)
				{
					msg = String.instancehelper_concat("Invalid Class-Path entry: ", text2);
				}
				else
				{
					string text3 = "Invalid Class-Path entry: ";
					text3 = text3;
					msg = String.newhelper(text3);
				}
				obj2.warning(msg);
			}
		}
		return builder.build();
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024000()
	{
		return logger;
	}

	[LineNumberTable(new byte[] { 45, 185, 101, 47 })]
	static ClassPath()
	{
		logger = Logger.getLogger(ClassLiteral<ClassPath>.Value.getName(), ClassPath.___003CGetCallerID_003E());
		CLASS_PATH_ATTRIBUTE_SEPARATOR = Splitter.on(" ").omitEmptyStrings();
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
