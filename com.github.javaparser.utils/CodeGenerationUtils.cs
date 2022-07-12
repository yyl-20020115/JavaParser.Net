

using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using java.nio.file;

namespace com.github.javaparser.utils;

public class CodeGenerationUtils
{
	
	
	
	public static string f(string format, params object[] @params)
	{
		string result = String.format(format, @params);
		
		return result;
	}

	
	
	
	public static Path subtractPaths(Path full, Path difference)
	{
		while (difference != null)
		{
			if (difference.getFileName().equals(full.getFileName()))
			{
				difference = difference.getParent();
				full = full.getParent();
				continue;
			}
			string message = f("'%s' could not be subtracted from '%s'", difference, full);
			
			throw new RuntimeException(message);
		}
		return full;
	}

	
	
	
	public static string packageToPath(string pkg)
	{
		string result = String.instancehelper_replace(pkg, '.', File.separatorChar);
		
		return result;
	}

	
	
	
	public static string setterName(string fieldName)
	{
		if (String.instancehelper_startsWith(fieldName, "is"))
		{
			string result = new StringBuilder().append("set").append(String.instancehelper_substring(fieldName, 2)).ToString();
			
			return result;
		}
		string result2 = new StringBuilder().append("set").append(Utils.capitalize(fieldName)).ToString();
		
		return result2;
	}

	
		
	
	public static string getterName(Class type, string name)
	{
		if (String.instancehelper_startsWith(name, "is") && Object.instancehelper_equals(Boolean.TYPE, type))
		{
			return name;
		}
		if (Object.instancehelper_equals(Boolean.TYPE, type))
		{
			string result = new StringBuilder().append("is").append(Utils.capitalize(name)).ToString();
			
			return result;
		}
		string result2 = new StringBuilder().append("get").append(Utils.capitalize(name)).ToString();
		
		return result2;
	}

	
	
	
	public static Path fileInPackageAbsolutePath(string root, string pkg, string file)
	{
		pkg = packageToPath(pkg);
		Path result = Paths.get(root, pkg, file).normalize();
		
		return result;
	}

	
	
	
	public static Path packageAbsolutePath(string root, string pkg)
	{
		pkg = packageToPath(pkg);
		Path result = Paths.get(root, pkg).normalize();
		
		return result;
	}

	
		
	
	public static Path classLoaderRoot(Class c)
	{
		//Discarded unreachable code: IL_001c
		URISyntaxException ex;
		try
		{
			return Paths.get(c.getProtectionDomain().getCodeSource().getLocation()
				.toURI());
		}
		catch (URISyntaxException x)
		{
			ex = ByteCodeHelper.MapException<URISyntaxException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		URISyntaxException cause = ex;
		
		throw new AssertionError("Bug in JavaParser, please report.", cause);
	}

	
	
	private CodeGenerationUtils()
	{
	}

	
	
	
	public static string getterToPropertyName(string getterName)
	{
		if (String.instancehelper_startsWith(getterName, "is"))
		{
			string result = Utils.decapitalize(String.instancehelper_substring(getterName, String.instancehelper_length("is")));
			
			return result;
		}
		if (String.instancehelper_startsWith(getterName, "get"))
		{
			string result2 = Utils.decapitalize(String.instancehelper_substring(getterName, String.instancehelper_length("get")));
			
			return result2;
		}
		if (String.instancehelper_startsWith(getterName, "has"))
		{
			string result3 = Utils.decapitalize(String.instancehelper_substring(getterName, String.instancehelper_length("has")));
			
			return result3;
		}
		string s = new StringBuilder().append("Unexpected getterName '").append(getterName).append("'")
			.ToString();
		
		throw new IllegalArgumentException(s);
	}

	
	
	
	public static string optionalOf(string text, bool isOptional)
	{
		if (isOptional)
		{
			string result = f("Optional.of(%s)", text);
			
			return result;
		}
		return "Optional.empty()";
	}

	
	
	
	public static Path fileInPackageAbsolutePath(Path root, string pkg, string file)
	{
		Path result = fileInPackageAbsolutePath(root.ToString(), pkg, file);
		
		return result;
	}

	
	
	
	public static Path fileInPackageRelativePath(string pkg, string file)
	{
		pkg = packageToPath(pkg);
		Path result = Paths.get(pkg, file).normalize();
		
		return result;
	}

	
	
	
	public static Path packageAbsolutePath(Path root, string pkg)
	{
		Path result = packageAbsolutePath(root.ToString(), pkg);
		
		return result;
	}

	
		
	
	public static Path mavenModuleRoot(Class c)
	{
		Path result = classLoaderRoot(c).resolve(Paths.get("..", "..")).normalize();
		
		return result;
	}
}
