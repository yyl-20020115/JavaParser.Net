using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.javadoc;
using com.github.javaparser.javadoc.description;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.regex;
using java.util.stream;

namespace com.github.javaparser;

internal class JavadocParser
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = isABlockLine((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon1(List P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Integer result = Integer.valueOf(arg_00241.indexOf((string)P_0));
			
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
			bool result = lambda_0024parse_00240((string)P_0);
			
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
			string result = lambda_0024parse_00241((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly Javadoc arg_00241;

		internal ___003C_003EAnon4(Javadoc P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024parse_00242(arg_00241, (string)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024cleanLines_00243((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024cleanLines_00244((string)P_0);
			
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

	private static string BLOCK_TAG_PREFIX;

	private static Pattern BLOCK_PATTERN;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		0,
		113,
		112,
		122,
		101,
		102,
		181,
		100,
		127,
		5,
		140,
		223,
		12,
		109,
		106,
		byte.MaxValue,
		2,
		69,
		103,
		127,
		0,
		111,
		101,
		145,
		110,
		115
	})]
	public unsafe static Javadoc parse(string commentContent)
	{
		List list = cleanLines(Utils.normalizeEolInTextBlock(commentContent, Utils.___003C_003ESYSTEM_EOL));
		Stream stream = list.stream().filter(new ___003C_003EAnon0());
		
		int num = ((Integer)stream.map(new ___003C_003EAnon1(list)).findFirst().orElse(Integer.valueOf(-1))).intValue();
		CharSequence charSequence = default(CharSequence);
		string text;
		List list2;
		if (num == -1)
		{
			string __003C_003ESYSTEM_EOL = Utils.___003C_003ESYSTEM_EOL;
			Iterable elements = list;
			object obj = (charSequence.___003Cref_003E = __003C_003ESYSTEM_EOL);
			text = trimRight(String.join(charSequence, elements));
			list2 = Collections.emptyList();
		}
		else
		{
			string __003C_003ESYSTEM_EOL2 = Utils.___003C_003ESYSTEM_EOL;
			Iterable elements = list.subList(0, num);
			object obj = (charSequence.___003Cref_003E = __003C_003ESYSTEM_EOL2);
			text = trimRight(String.join(charSequence, elements));
			Stream stream2 = list.subList(num, list.size()).stream();
			obj = (charSequence.___003Cref_003E = Utils.___003C_003ESYSTEM_EOL);
			string __003Cref_003E = (string)stream2.collect(Collectors.joining(charSequence));
			Pattern bLOCK_PATTERN = BLOCK_PATTERN;
			obj = (charSequence.___003Cref_003E = __003Cref_003E);
			list2 = (List)bLOCK_PATTERN.splitAsStream(charSequence).filter(new ___003C_003EAnon2()).map(new ___003C_003EAnon3())
				.collect(Collectors.toList());
		}
		Javadoc javadoc = new Javadoc(JavadocDescription.parseText(text));
		list2.forEach(new ___003C_003EAnon4(javadoc));
		return javadoc;
	}

	
		
	[LineNumberTable(new byte[]
	{
		53, 108, 100, 168, 245, 80, 144, 159, 6, 127,
		32, 186, 127, 2, 144, 127, 9, 146
	})]
	private static List cleanLines(string content)
	{
		string[] array = String.instancehelper_split(content, Utils.___003C_003ESYSTEM_EOL);
		if (array.Length == 0)
		{
			List result = Collections.emptyList();
			
			return result;
		}
		List list = (List)Arrays.stream(array).map(new ___003C_003EAnon5()).collect(Collectors.toList());
		list = (List)list.stream().map(new ___003C_003EAnon6()).collect(Collectors.toList());
		if (!String.instancehelper_isEmpty((string)list.get(0)) && (String.instancehelper_charAt((string)list.get(0), 0) == ' ' || String.instancehelper_charAt((string)list.get(0), 0) == '\t'))
		{
			list.set(0, String.instancehelper_substring((string)list.get(0), 1));
		}
		while (list.size() > 0 && String.instancehelper_isEmpty(String.instancehelper_trim((string)list.get(0))))
		{
			list = list.subList(1, list.size());
		}
		while (list.size() > 0 && String.instancehelper_isEmpty(String.instancehelper_trim((string)list.get(list.size() - 1))))
		{
			list = list.subList(0, list.size() - 1);
		}
		return list;
	}

	
	
	
	private static string trimRight(string @string)
	{
		while (!String.instancehelper_isEmpty(@string) && Character.isWhitespace(String.instancehelper_charAt(@string, String.instancehelper_length(@string) - 1)))
		{
			@string = String.instancehelper_substring(@string, 0, String.instancehelper_length(@string) - 1);
		}
		return @string;
	}

	
	
	
	internal static int startsWithAsterisk(string line)
	{
		if (String.instancehelper_startsWith(line, "*"))
		{
			return 0;
		}
		if ((String.instancehelper_startsWith(line, " ") || String.instancehelper_startsWith(line, "\t")) && String.instancehelper_length(line) > 1)
		{
			int num = startsWithAsterisk(String.instancehelper_substring(line, 1));
			if (num == -1)
			{
				return -1;
			}
			return 1 + num;
		}
		return -1;
	}

	
	
	
	private static JavadocBlockTag parseBlockTag(string line)
	{
		line = String.instancehelper_substring(String.instancehelper_trim(line), 1);
		string text = Utils.nextWord(line);
		string content = String.instancehelper_trim(String.instancehelper_substring(line, String.instancehelper_length(text)));
		JavadocBlockTag result = new JavadocBlockTag(text, content);
		
		return result;
	}

	
	
	
	private static bool isABlockLine(string line)
	{
		bool result = String.instancehelper_startsWith(String.instancehelper_trim(line), BLOCK_TAG_PREFIX);
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024parse_00240(string s1)
	{
		return (!String.instancehelper_isEmpty(s1)) ? true : false;
	}

	
	
	
	
	private static string lambda_0024parse_00241(string s)
	{
		string result = new StringBuilder().append(BLOCK_TAG_PREFIX).append(s).ToString();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024parse_00242(Javadoc document, string l)
	{
		document.addBlockTag(parseBlockTag(l));
	}

	
	
	
	
	private static string lambda_0024cleanLines_00243(string l)
	{
		int num = startsWithAsterisk(l);
		if (num == -1)
		{
			return l;
		}
		if (String.instancehelper_length(l) > num + 1)
		{
			int num2 = String.instancehelper_charAt(l, num + 1);
			if (num2 == 32 || num2 == 9)
			{
				string result = String.instancehelper_substring(l, num + 2);
				
				return result;
			}
		}
		string result2 = String.instancehelper_substring(l, num + 1);
		
		return result2;
	}

	
	
	
	
	private static string lambda_0024cleanLines_00244(string l)
	{
		return (!String.instancehelper_isEmpty(String.instancehelper_trim(l))) ? l : "";
	}

	
	
	internal JavadocParser()
	{
	}

	
	
	
	public static Javadoc parse(JavadocComment comment)
	{
		Javadoc result = parse(comment.getContent());
		
		return result;
	}

	
	static JavadocParser()
	{
		BLOCK_TAG_PREFIX = "@";
		BLOCK_PATTERN = Pattern.compile(new StringBuilder().append("^\\s*").append(BLOCK_TAG_PREFIX).ToString(), 8);
	}
}
