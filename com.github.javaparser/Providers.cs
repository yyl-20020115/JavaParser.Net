using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;

namespace com.github.javaparser;

public class Providers
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal static Charset ___003C_003EUTF8;

	
	private static CallerID ___003CcallerID_003E;

	
	public static Charset UTF8
	{
		
		get
		{
			return ___003C_003EUTF8;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	
	public static Provider provider(Path path)
	{
		Provider result = provider((Path)Utils.assertNotNull(path), ___003C_003EUTF8);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Provider provider(InputStream input, Charset encoding)
	{
		//Discarded unreachable code: IL_001c
		Utils.assertNotNull(input);
		Utils.assertNotNull(encoding);
		IOException ex;
		try
		{
			return new StreamProvider(input, encoding.name());
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException cause = ex;
		
		throw new RuntimeException(cause);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Provider provider(File file, Charset encoding)
	{
		FileInputStream.___003Cclinit_003E();
		Provider result = provider(new FileInputStream((File)Utils.assertNotNull(file)), (Charset)Utils.assertNotNull(encoding));
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Provider provider(Path path, Charset encoding)
	{
		Provider result = provider(Files.newInputStream((Path)Utils.assertNotNull(path)), (Charset)Utils.assertNotNull(encoding));
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Provider resourceProvider(string pathToResource, Charset encoding)
	{
		ClassLoader classLoader = ClassLiteral<Provider>.Value.getClassLoader(Providers.___003CGetCallerID_003E());
		Provider result = resourceProvider(classLoader, pathToResource, encoding);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Provider resourceProvider(ClassLoader classLoader, string pathToResource, Charset encoding)
	{
		InputStream resourceAsStream = classLoader.getResourceAsStream(pathToResource);
		if (resourceAsStream == null)
		{
			string message = new StringBuilder().append("Cannot find ").append(pathToResource).ToString();
			
			throw new IOException(message);
		}
		Provider result = provider(resourceAsStream, encoding);
		
		return result;
	}

	
	
	
	public static Provider provider(Reader reader)
	{
		StreamProvider result = new StreamProvider((Reader)Utils.assertNotNull(reader));
		
		return result;
	}

	
	
	
	public static Provider provider(string source)
	{
		StringProvider result = new StringProvider((string)Utils.assertNotNull(source));
		
		return result;
	}

	
	
	private Providers()
	{
	}

	
	
	
	public static Provider provider(InputStream input)
	{
		Provider result = provider(input, ___003C_003EUTF8);
		
		return result;
	}

	
	
	
	
	public static Provider provider(File file)
	{
		Provider result = provider((File)Utils.assertNotNull(file), ___003C_003EUTF8);
		
		return result;
	}

	
	
	
	
	public static Provider resourceProvider(string pathToResource)
	{
		Provider result = resourceProvider(pathToResource, ___003C_003EUTF8);
		
		return result;
	}

	
	static Providers()
	{
		___003C_003EUTF8 = Charset.forName("utf-8");
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
