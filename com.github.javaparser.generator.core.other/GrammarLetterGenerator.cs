using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.generator.core.other;

public class GrammarLetterGenerator
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024main_00240((Integer)P_0);
			
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
			Boolean result = lambda_0024main_00241((Integer)P_0);
			
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

	
		[LineNumberTable(new byte[]
	{
		159, 178, 102, 127, 15, 111, 98, 98, 107, 127,
		1, 134, 103, 127, 1, 134, 105, 104, 133, 105,
		100, 159, 7, 100, 159, 21, 101, 98, 106, 143,
		133, 111, 111, 113
	})]
	private static void generate(string P_0, Function P_1)
	{
		java.lang.System.@out.println(new StringBuilder().append("  < #").append(P_0).append(": [")
			.ToString());
		java.lang.System.@out.print("         ");
		int num = 0;
		int i = 0;
		while (i < 65536)
		{
			for (; !((Boolean)P_1.apply(Integer.valueOf(i))).booleanValue() && i < 65536; i++)
			{
			}
			string text = format(i);
			for (; ((Boolean)P_1.apply(Integer.valueOf(i))).booleanValue() && i < 65536; i++)
			{
			}
			string text2 = format(i - 1);
			if (i >= 65536)
			{
				break;
			}
			if (String.instancehelper_equals(text, text2))
			{
				num++;
				java.lang.System.@out.print(new StringBuilder().append(text).append(",  ").ToString());
			}
			else
			{
				num += 2;
				java.lang.System.@out.print(new StringBuilder().append(text).append("-").append(text2)
					.append(",  ")
					.ToString());
			}
			if (num >= 10)
			{
				num = 0;
				java.lang.System.@out.println();
				java.lang.System.@out.print("         ");
			}
		}
		java.lang.System.@out.println("]");
		java.lang.System.@out.println("        | <UNICODE_ESCAPE>");
		java.lang.System.@out.println("  >");
	}

	
	
	private static string format(int P_0)
	{
		string result = String.format("\"\\u%04x\"", Integer.valueOf(P_0));
		
		return result;
	}

	
	
	
	private static Boolean lambda_0024main_00240(Integer P_0)
	{
		Boolean result = Boolean.valueOf((Character.isJavaIdentifierStart(P_0.intValue()) || Character.isHighSurrogate((char)P_0.intValue()) || Character.isLowSurrogate((char)P_0.intValue())) ? true : false);
		
		return result;
	}

	
	
	
	private static Boolean lambda_0024main_00241(Integer P_0)
	{
		Boolean result = Boolean.valueOf((Character.isJavaIdentifierPart(P_0.intValue()) || Character.isHighSurrogate((char)P_0.intValue()) || Character.isLowSurrogate((char)P_0.intValue())) ? true : false);
		
		return result;
	}

	
	
	public GrammarLetterGenerator()
	{
	}

	
	
	public static void main(string[] args)
	{
		generate("LETTER", new ___003C_003EAnon0());
		generate("PART_LETTER", new ___003C_003EAnon1());
	}
}
