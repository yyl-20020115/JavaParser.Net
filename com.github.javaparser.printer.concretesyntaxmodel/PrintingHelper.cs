

using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

internal class PrintingHelper
{
	
	
	
	internal static string printToString(object value)
	{
		if (value is Stringable)
		{
			string result = ((Stringable)value).asString();
			
			return result;
		}
		if (value is Enum)
		{
			string result2 = String.instancehelper_toLowerCase(((Enum)value).name());
			
			return result2;
		}
		if (value != null)
		{
			string result3 = Object.instancehelper_toString(value);
			
			return result3;
		}
		return "";
	}

	
	
	internal PrintingHelper()
	{
	}
}
