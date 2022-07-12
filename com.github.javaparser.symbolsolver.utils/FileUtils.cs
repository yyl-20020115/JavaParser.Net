
using com.github.javaparser.utils;

using java.io;
using java.lang;

namespace com.github.javaparser.symbolsolver.utils;

public class FileUtils
{
	
	
	public static bool isValidPath(string filename)
	{
		File file = new File(filename);
		bool result = file.exists();
		
		return result;
	}

	
	
	public static string getParentPath(string filename)
	{
		Utils.assertNotNull(filename);
		int endIndex = String.instancehelper_lastIndexOf(filename, File.separator);
		string result = String.instancehelper_substring(filename, 0, endIndex);
		
		return result;
	}

	
	
	public FileUtils()
	{
	}
}
