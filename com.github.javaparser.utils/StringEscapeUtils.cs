

using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace com.github.javaparser.utils;

public class StringEscapeUtils
{
	
	
	
	
	internal class _1
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class AggregateTranslator : CharSequenceTranslator
	{
		
		private CharSequenceTranslator[] translators;

		
		
		
		internal AggregateTranslator(CharSequenceTranslator[] P_0, _1 P_1)
			: this(P_0)
		{
		}

		
		
		
		private AggregateTranslator(params CharSequenceTranslator[] translators)
			: base(null)
		{
			this.translators = ((translators != null) ? ((CharSequenceTranslator[])translators.Clone()) : null);
		}

		
		
		
		
		protected internal override int translate(CharSequence input, int index, Writer @out)
		{
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequenceTranslator[] array = translators;
			int num = array.Length;
			CharSequence input2 = default(CharSequence);
			for (int i = 0; i < num; i++)
			{
				CharSequenceTranslator charSequenceTranslator = array[i];
				object obj = (input2.___003Cref_003E = __003Cref_003E);
				int num2 = charSequenceTranslator.translate(input2, index, @out);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	internal abstract class CharSequenceTranslator
	{
		
		
		
		internal static string access_0024000(CharSequenceTranslator P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence input = default(CharSequence);
			object obj = (input.___003Cref_003E = __003Cref_003E);
			string result = P_0.translate(input);
			
			return result;
		}

		
		
		private CharSequenceTranslator()
		{
		}

		
		
		
		private string translate(CharSequence input)
		{
			//Discarded unreachable code: IL_004f
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			if (__003Cref_003E == null)
			{
				return null;
			}
			IOException ex;
			try
			{
				CharSequence input2 = default(CharSequence);
				object obj = (input2.___003Cref_003E = __003Cref_003E);
				StringWriter stringWriter = new StringWriter(input2.length() * 2);
				Writer @out = stringWriter;
				obj = (input2.___003Cref_003E = __003Cref_003E);
				translate(input2, @out);
				return stringWriter.ToString();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			
			throw new RuntimeException(cause);
		}

		
		
		
		
		private void translate(CharSequence input, Writer @out)
		{
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			if (@out == null)
			{
				
				throw new IllegalArgumentException("The Writer must not be null");
			}
			if (__003Cref_003E == null)
			{
				return;
			}
			int num = 0;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num2 = charSequence2.length();
			while (num < num2)
			{
				int index = num;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num3 = translate(charSequence2, index, @out);
				if (num3 == 0)
				{
					index = num;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					int num4 = charSequence2.charAt(index);
					@out.write(num4);
					num++;
					if (Character.isHighSurrogate((char)num4) && num < num2)
					{
						index = num;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						int num5 = charSequence2.charAt(index);
						if (Character.isLowSurrogate((char)num5))
						{
							@out.write(num5);
							num++;
						}
					}
				}
				else
				{
					for (int num4 = 0; num4 < num3; num4++)
					{
						int num6 = num;
						index = num;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						num = num6 + Character.charCount(Character.codePointAt(charSequence2, index));
					}
				}
			}
		}

		
		
		protected internal abstract int translate(CharSequence input, int index, Writer @out);

		
		
		
		internal CharSequenceTranslator(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class LookupTranslator : CharSequenceTranslator
	{
		
				private HashMap lookupMap;

		
				private HashSet prefixSet;

		
		private int shortest;

		
		private int longest;

		
		
		
		internal LookupTranslator(object[][] P_0, _1 P_1)
			: this(P_0)
		{
		}

		
		
		
		private LookupTranslator(params object[][] lookup)
			: base(null)
		{
			lookupMap = new HashMap();
			prefixSet = new HashSet();
			int num = int.MaxValue;
			int num2 = 0;
			if (lookup != null)
			{
				int num3 = lookup.Length;
				CharSequence charSequence = default(CharSequence);
				for (int i = 0; i < num3; i++)
				{
					object[] array = lookup[i];
					HashMap hashMap = lookupMap;
					object obj = (charSequence.___003Cref_003E = array[0]);
					string key = charSequence.ToString();
					obj = (charSequence.___003Cref_003E = array[1]);
					hashMap.put(key, charSequence.ToString());
					HashSet hashSet = prefixSet;
					object __003Cref_003E = array[0];
					int i2 = 0;
					obj = (charSequence.___003Cref_003E = __003Cref_003E);
					hashSet.add(Character.valueOf(charSequence.charAt(i2)));
					obj = (charSequence.___003Cref_003E = array[0]);
					int num4 = charSequence.length();
					if (num4 < num)
					{
						num = num4;
					}
					if (num4 > num2)
					{
						num2 = num4;
					}
				}
			}
			shortest = num;
			longest = num2;
		}

		
		
		
		
		protected internal override int translate(CharSequence input, int index, Writer @out)
		{
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			HashSet hashSet = prefixSet;
			int i = index;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (hashSet.contains(Character.valueOf(charSequence2.charAt(i))))
			{
				int num = longest;
				int num2 = index + longest;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num2 > charSequence2.length())
				{
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					num = charSequence2.length() - index;
				}
				for (int j = num; j >= shortest; j += -1)
				{
					int i2 = index + j;
					i = index;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					object __003Cref_003E2 = charSequence2.subSequence(i, i2).___003Cref_003E;
					HashMap hashMap = lookupMap;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
					string text = (string)hashMap.get(charSequence2.ToString());
					if (text != null)
					{
						@out.write(text);
						return j;
					}
				}
			}
			return 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class OctalUnescaper : CharSequenceTranslator
	{
		
		
		
		internal OctalUnescaper(_1 P_0)
			: this()
		{
		}

		
		
		private OctalUnescaper()
			: base(null)
		{
		}

		
		private bool isOctalDigit(char ch)
		{
			return (ch >= '0' && ch <= '7') ? true : false;
		}

		
		private bool isZeroToThree(char ch)
		{
			return (ch >= '0' && ch <= '3') ? true : false;
		}

		
		
		
		
		protected internal override int translate(CharSequence input, int index, Writer @out)
		{
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.length() - index - 1;
			StringBuilder stringBuilder = new StringBuilder();
			int i = index;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (charSequence2.charAt(i) == '\\' && num > 0)
			{
				i = index + 1;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (isOctalDigit(charSequence2.charAt(i)))
				{
					int num2 = index + 1;
					int num3 = index + 2;
					int num4 = index + 3;
					i = num2;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					stringBuilder.append(charSequence2.charAt(i));
					if (num > 1)
					{
						i = num3;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						if (isOctalDigit(charSequence2.charAt(i)))
						{
							i = num3;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							stringBuilder.append(charSequence2.charAt(i));
							if (num > 2)
							{
								i = num2;
								obj = (charSequence2.___003Cref_003E = __003Cref_003E);
								if (isZeroToThree(charSequence2.charAt(i)))
								{
									i = num4;
									obj = (charSequence2.___003Cref_003E = __003Cref_003E);
									if (isOctalDigit(charSequence2.charAt(i)))
									{
										i = num4;
										obj = (charSequence2.___003Cref_003E = __003Cref_003E);
										stringBuilder.append(charSequence2.charAt(i));
									}
								}
							}
						}
					}
					@out.write(Integer.parseInt(stringBuilder.ToString(), 8));
					return 1 + stringBuilder.length();
				}
			}
			return 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class UnicodeUnescaper : CharSequenceTranslator
	{
		
		
		
		internal UnicodeUnescaper(_1 P_0)
			: this()
		{
		}

		
		
		private UnicodeUnescaper()
			: base(null)
		{
		}

		
		
		
		
		protected internal override int translate(CharSequence input, int index, Writer @out)
		{
			CharSequence charSequence = input;
			object __003Cref_003E = charSequence.___003Cref_003E;
			int i = index;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			object __003Cref_003E2;
			NumberFormatException ex;
			if (charSequence2.charAt(i) == '\\')
			{
				int num = index + 1;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (num < charSequence2.length())
				{
					i = index + 1;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (charSequence2.charAt(i) == 'u')
					{
						int num2 = 2;
						while (true)
						{
							int num3 = index + num2;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							if (num3 >= charSequence2.length())
							{
								break;
							}
							i = index + num2;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							if (charSequence2.charAt(i) != 'u')
							{
								break;
							}
							num2++;
						}
						int num4 = index + num2;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						if (num4 < charSequence2.length())
						{
							i = index + num2;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							if (charSequence2.charAt(i) == '+')
							{
								num2++;
							}
						}
						int num5 = index + num2 + 4;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						int i2;
						if (num5 <= charSequence2.length())
						{
							int num6 = index + num2;
							i2 = index + num2 + 4;
							i = num6;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							__003Cref_003E2 = charSequence2.subSequence(i, i2).___003Cref_003E;
							try
							{
								obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
								int num7 = Integer.parseInt(charSequence2.ToString(), 16);
								@out.write((ushort)num7);
							}
							catch (NumberFormatException x)
							{
								ex = ByteCodeHelper.MapException<NumberFormatException>(x, ByteCodeHelper.MapFlags.NoRemapping);
								goto IL_014c;
							}
							return num2 + 4;
						}
						StringBuilder stringBuilder = new StringBuilder().append("Less than 4 hex digits in unicode value: '");
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						i2 = charSequence2.length();
						i = index;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E);
						string s = stringBuilder.append(charSequence2.subSequence(i, i2).___003Cref_003E).append("' due to end of CharSequence").ToString();
						
						throw new IllegalArgumentException(s);
					}
				}
			}
			return 0;
			IL_014c:
			NumberFormatException cause = ex;
			string message = new StringBuilder().append("Unable to parse unicode value: ").append(__003Cref_003E2).ToString();
			
			throw new IllegalArgumentException(message, cause);
		}
	}

	
	private static LookupTranslator JAVA_CTRL_CHARS_UNESCAPE;

	
	private static LookupTranslator JAVA_CTRL_CHARS_ESCAPE;

	
	private static CharSequenceTranslator ESCAPE_JAVA;

	
	private static CharSequenceTranslator UNESCAPE_JAVA;

	
	private static CharSequenceTranslator UNESCAPE_JAVA_TEXT_BLOCK;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public static string escapeJava(string input)
	{
		CharSequenceTranslator eSCAPE_JAVA = ESCAPE_JAVA;
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = input);
		string result = CharSequenceTranslator.access_0024000(eSCAPE_JAVA, charSequence);
		
		return result;
	}

	
	
	
	public static string unescapeJava(string input)
	{
		CharSequenceTranslator uNESCAPE_JAVA = UNESCAPE_JAVA;
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = input);
		string result = CharSequenceTranslator.access_0024000(uNESCAPE_JAVA, charSequence);
		
		return result;
	}

	
	
	
	public static string unescapeJavaTextBlock(string input)
	{
		CharSequenceTranslator uNESCAPE_JAVA_TEXT_BLOCK = UNESCAPE_JAVA_TEXT_BLOCK;
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = input);
		string result = CharSequenceTranslator.access_0024000(uNESCAPE_JAVA_TEXT_BLOCK, charSequence);
		
		return result;
	}

	
	
	private StringEscapeUtils()
	{
	}

	
	static StringEscapeUtils()
	{
		JAVA_CTRL_CHARS_UNESCAPE = new LookupTranslator(new string[5][]
		{
			new string[2] { "\\b", "\b" },
			new string[2] { "\\n", "\n" },
			new string[2] { "\\t", "\t" },
			new string[2] { "\\f", "\f" },
			new string[2] { "\\r", "\r" }
		}, null);
		JAVA_CTRL_CHARS_ESCAPE = new LookupTranslator(new string[5][]
		{
			new string[2] { "\b", "\\b" },
			new string[2] { "\n", "\\n" },
			new string[2] { "\t", "\\t" },
			new string[2] { "\f", "\\f" },
			new string[2] { "\r", "\\r" }
		}, null);
		ESCAPE_JAVA = new AggregateTranslator(new CharSequenceTranslator[2]
		{
			new LookupTranslator(new string[2][]
			{
				new string[2] { "\"", "\\\"" },
				new string[2] { "\\", "\\\\" }
			}, null),
			JAVA_CTRL_CHARS_ESCAPE
		}, null);
		UNESCAPE_JAVA = new AggregateTranslator(new CharSequenceTranslator[4]
		{
			new OctalUnescaper(null),
			new UnicodeUnescaper(null),
			JAVA_CTRL_CHARS_UNESCAPE,
			new LookupTranslator(new string[4][]
			{
				new string[2] { "\\\\", "\\" },
				new string[2] { "\\\"", "\"" },
				new string[2] { "\\'", "'" },
				new string[2] { "\\", "" }
			}, null)
		}, null);
		UNESCAPE_JAVA_TEXT_BLOCK = new AggregateTranslator(new CharSequenceTranslator[4]
		{
			new OctalUnescaper(null),
			new UnicodeUnescaper(null),
			JAVA_CTRL_CHARS_UNESCAPE,
			new LookupTranslator(new string[6][]
			{
				new string[2] { "\\\\", "\\" },
				new string[2] { "\\\"", "\"" },
				new string[2] { "\\'", "'" },
				new string[2] { "\\", "" },
				new string[2] { "\\s", " " },
				new string[2] { "\\\n", "" }
			}, null)
		}, null);
	}
}
