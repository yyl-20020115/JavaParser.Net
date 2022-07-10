using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.generator.core.utils;

public class CodeUtils
{
	
	
	public static string castValue(string value, Type requiredType, string valueType)
	{
		string text = requiredType.asString();
		if (String.instancehelper_equals(text, valueType))
		{
			return value;
		}
		string result = String.format("(%s) %s", text, value);
		
		return result;
	}

	
	
	private CodeUtils()
	{
	}
}
