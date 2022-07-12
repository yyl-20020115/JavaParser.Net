using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;

using java.io;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.utils;

public class Utils
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			string result = java.lang.String.instancehelper_toUpperCase((string)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			string result = java.lang.String.instancehelper_toLowerCase((string)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024hasUnaryMinusAsParent_00240((Node)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			UnaryExpr result = lambda_0024hasUnaryMinusAsParent_00241((Node)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			java.lang.Boolean result = lambda_0024hasUnaryMinusAsParent_00242((UnaryExpr)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	internal static string ___003C_003EEOL;

	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	internal static string ___003C_003ESYSTEM_EOL;

	
	public static string EOL
	{
		
		get
		{
			return ___003C_003EEOL;
		}
	}

	
	public static string SYSTEM_EOL
	{
		
		get
		{
			return ___003C_003ESYSTEM_EOL;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public static string camelCaseToScreaming(string input)
	{
		if (java.lang.String.instancehelper_isEmpty(input))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(java.lang.String.instancehelper_toUpperCase(java.lang.String.instancehelper_substring(input, 0, 1)));
		char[] array = java.lang.String.instancehelper_toCharArray(java.lang.String.instancehelper_substring(input, 1));
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int ch = array[i];
			if (Character.isUpperCase((char)ch))
			{
				stringBuilder.append("_");
			}
			stringBuilder.append(Character.toUpperCase((char)ch));
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public static string capitalize(string s)
	{
		string result = stringTransformer(s, "capitalize", new ___003C_003EAnon0());
		
		return result;
	}

	
		
	
	
	public static Set set(params object[] items)
	{
		HashSet.___003Cclinit_003E();
		HashSet result = new HashSet(Arrays.asList(items));
		
		return result;
	}

	
		
	
	public static object assertNotNull(object o)
	{
		if (o == null)
		{
			
			throw new AssertionError("A reference was unexpectedly null.");
		}
		return o;
	}

	
	
	
	public static string assertNonEmpty(string @string)
	{
		if (@string == null || java.lang.String.instancehelper_isEmpty(@string))
		{
			
			throw new AssertionError("A string was unexpectedly empty.");
		}
		return @string;
	}

	
	
	
	public static string removeFileExtension(string filename)
	{
		int num = java.lang.String.instancehelper_lastIndexOf(filename, ".");
		if (num == -1)
		{
			return filename;
		}
		string result = java.lang.String.instancehelper_substring(filename, 0, num);
		
		return result;
	}

	
	
	
	public static string escapeEndOfLines(string @string)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] array = java.lang.String.instancehelper_toCharArray(@string);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = array[i];
			switch (num2)
			{
			case 10:
				stringBuilder.append("\\n");
				break;
			case 13:
				stringBuilder.append("\\r");
				break;
			default:
				stringBuilder.append((char)num2);
				break;
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public static bool hasUnaryMinusAsParent(Node n)
	{
		bool result = ((java.lang.Boolean)n.getParentNode().filter(new ___003C_003EAnon2()).map(new ___003C_003EAnon3())
			.map(new ___003C_003EAnon4())
			.orElse(java.lang.Boolean.valueOf(b: false))).booleanValue();
		
		return result;
	}

	
	
	
	public static string screamingToCamelCase(string original)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = java.lang.String.instancehelper_split(java.lang.String.instancehelper_toLowerCase(original), "_");
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			stringBuilder.append((i != 0) ? capitalize(array[i]) : array[i]);
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public static bool valueIsNullOrEmpty(object value)
	{
		if (value == null)
		{
			return true;
		}
		if (value is Optional)
		{
			if (!((Optional)value).isPresent())
			{
				return true;
			}
			value = ((Optional)value).get();
		}
		if (value is Collection && ((Collection)value).isEmpty())
		{
			return true;
		}
		return false;
	}

	
		
	
	public static void removeElementByObjectIdentity(List list, object o)
	{
		int num = indexOfElementByObjectIdentity(list, o);
		if (num != -1)
		{
			list.remove(num);
		}
	}

	
		
	
	public static void replaceElementByObjectIdentity(List list, object oldObject, object newObject)
	{
		int num = indexOfElementByObjectIdentity(list, oldObject);
		if (num != -1)
		{
			list.set(num, newObject);
		}
	}

	
	
	
	public static string nextWord(string @string)
	{
		int i;
		for (i = 0; i < java.lang.String.instancehelper_length(@string) && !Character.isWhitespace(java.lang.String.instancehelper_charAt(@string, i)); i++)
		{
		}
		string result = java.lang.String.instancehelper_substring(@string, 0, i);
		
		return result;
	}

	
	
	
	public static string normalizeEolInTextBlock(string content, string desiredEndOfLineCharacter)
	{
		string result = java.lang.String.instancehelper_replaceAll(content, "\\R", desiredEndOfLineCharacter);
		
		return result;
	}

	
	
	
	public static string decapitalize(string s)
	{
		string result = stringTransformer(s, "decapitalize", new ___003C_003EAnon1());
		
		return result;
	}

	
		
	
	public static Number assertNonNegative(Number number)
	{
		if (number.longValue() < 0)
		{
			
			throw new AssertionError("A number was unexpectedly negative.");
		}
		return number;
	}

	
		
	
	public static Number assertPositive(Number number)
	{
		if (number.longValue() <= 0)
		{
			
			throw new AssertionError("A number was unexpectedly non-positive.");
		}
		return number;
	}

	
		
	
	public static bool isNullOrEmpty(Collection collection)
	{
		return (collection == null || collection.isEmpty()) ? true : false;
	}

	
	
	
	public static string trimTrailingSpaces(string line)
	{
		while (java.lang.String.instancehelper_length(line) > 0 && java.lang.String.instancehelper_charAt(line, java.lang.String.instancehelper_length(line) - 1) <= ' ')
		{
			line = java.lang.String.instancehelper_substring(line, 0, java.lang.String.instancehelper_length(line) - 1);
		}
		return line;
	}

	
	
	
	public static bool valueIsNullOrEmptyStringOrOptional(object value)
	{
		if (value == null)
		{
			return true;
		}
		if (value is Optional)
		{
			if (!((Optional)value).isPresent())
			{
				return true;
			}
			((Optional)value).get();
		}
		return false;
	}

	
		
	
	private static string stringTransformer(string s, string operationDescription, Function transformation)
	{
		if (java.lang.String.instancehelper_isEmpty(s))
		{
			string s2 = java.lang.String.format("You cannot %s an empty string", operationDescription);
			
			throw new IllegalArgumentException(s2);
		}
		string result = new StringBuilder().append((string)transformation.apply(java.lang.String.instancehelper_substring(s, 0, 1))).append(java.lang.String.instancehelper_substring(s, 1)).ToString();
		
		return result;
	}

	
		
	
	public static int indexOfElementByObjectIdentity(List list, object o)
	{
		for (int i = 0; i < list.size(); i++)
		{
			object obj = list.get(i);
			if (o == obj)
			{
				return i;
			}
		}
		return -1;
	}

	
	
	
	private static bool lambda_0024hasUnaryMinusAsParent_00240(Node parent)
	{
		return parent is UnaryExpr;
	}

	
	
	
	private static UnaryExpr lambda_0024hasUnaryMinusAsParent_00241(Node parent)
	{
		return (UnaryExpr)parent;
	}

	
	
	
	
	private static java.lang.Boolean lambda_0024hasUnaryMinusAsParent_00242(UnaryExpr unaryExpr)
	{
		java.lang.Boolean result = java.lang.Boolean.valueOf(unaryExpr.getOperator() == UnaryExpr.Operator.___003C_003EMINUS);
		
		return result;
	}

	
	
	public Utils()
	{
	}

	
	
	
	
	public static string readerToString(Reader reader)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] array = new char[8192];
		int len;
		while ((len = reader.read(array, 0, array.Length)) > 0)
		{
			stringBuilder.append(array, 0, len);
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static string toCamelCase(string original)
	{
		string result = screamingToCamelCase(original);
		
		return result;
	}

	
	
	
	public static StringBuilder indent(StringBuilder builder, int indentLevel)
	{
		for (int i = 0; i < indentLevel; i++)
		{
			builder.append("\t");
		}
		return builder;
	}

	
	
	
	public static string normalizeEolInTextBlock(string content, LineSeparator desiredEndOfLineCharacter)
	{
		string result = normalizeEolInTextBlock(content, desiredEndOfLineCharacter.asRawString());
		
		return result;
	}

	
	static Utils()
	{
		___003C_003EEOL = LineSeparator.___003C_003ESYSTEM.asRawString();
		___003C_003ESYSTEM_EOL = LineSeparator.___003C_003ESYSTEM.asRawString();
	}
}
