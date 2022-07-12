using System;




using java.lang;
using java.util;

namespace com.github.javaparser;


public class ParseException : System.Exception
{
	private const string INDENT = "    ";

	protected internal const string EOL = "\n";

	public Token currentToken;

	public int[][] expectedTokenSequences;

	public string[] tokenImage;

	
	
	
	internal static string add_escapes(string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < java.lang.String.instancehelper_length(str); i++)
		{
			int num = java.lang.String.instancehelper_charAt(str, i);
			switch (num)
			{
			case 8:
				stringBuilder.append("\\b");
				continue;
			case 9:
				stringBuilder.append("\\t");
				continue;
			case 10:
				stringBuilder.append("\\n");
				continue;
			case 12:
				stringBuilder.append("\\f");
				continue;
			case 13:
				stringBuilder.append("\\r");
				continue;
			case 34:
				stringBuilder.append("\\\"");
				continue;
			case 39:
				stringBuilder.append("\\'");
				continue;
			case 92:
				stringBuilder.append("\\\\");
				continue;
			}
			if (num < 32 || num > 126)
			{
				string @this = new StringBuilder().append("0000").append(Integer.toString(num, 16)).ToString();
				stringBuilder.append(new StringBuilder().append("\\u").append(java.lang.String.instancehelper_substring(@this, java.lang.String.instancehelper_length(@this) - 4, java.lang.String.instancehelper_length(@this))).ToString());
			}
			else
			{
				stringBuilder.append((char)num);
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public ParseException()
	{
	}

	
	
	
	public ParseException(Token currentTokenVal, int[][] expectedTokenSequencesVal, string[] tokenImageVal, string lexicalStateName)
		: base(_initialise(currentTokenVal, expectedTokenSequencesVal, tokenImageVal, lexicalStateName))
	{
		currentToken = currentTokenVal;
		expectedTokenSequences = expectedTokenSequencesVal;
		tokenImage = tokenImageVal;
	}

	
	
	
	private static string _initialise(Token currentToken, int[][] expectedTokenSequences, string[] tokenImage, string lexicalStateName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		TreeSet treeSet = new TreeSet();
		for (int i = 0; i < (nint)expectedTokenSequences.LongLength; i++)
		{
			if (num < (nint)expectedTokenSequences[i].LongLength)
			{
				num = expectedTokenSequences[i].Length;
			}
			for (int j = 0; j < (nint)expectedTokenSequences[i].LongLength; j++)
			{
				treeSet.add(tokenImage[expectedTokenSequences[i][j]]);
			}
		}
		Iterator iterator = treeSet.iterator();
		while (iterator.hasNext())
		{
			string str = (string)iterator.next();
			stringBuilder.append("    ").append(str).append("\n");
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.append("Encountered unexpected token:");
		Token next = currentToken.next;
		for (int k = 0; k < num; k++)
		{
			string image = next.image;
			string str2 = add_escapes(image);
			if (k != 0)
			{
				stringBuilder2.append(' ');
			}
			if (next.kind == 0)
			{
				stringBuilder2.append(tokenImage[0]);
				break;
			}
			stringBuilder2.append(" \"");
			stringBuilder2.append(str2);
			stringBuilder2.append("\"");
			stringBuilder2.append(new StringBuilder().append(" ").append(tokenImage[next.kind]).ToString());
			next = next.next;
		}
		stringBuilder2.append("\n").append("    ").append("at line ")
			.append(currentToken.next.beginLine)
			.append(", column ")
			.append(currentToken.next.beginColumn);
		stringBuilder2.append(".").append("\n");
		if (expectedTokenSequences.Length != 0)
		{
			StringBuilder stringBuilder3 = stringBuilder2.append("\n").append("Was expecting").append(((nint)expectedTokenSequences.LongLength != 1) ? " one of:" : ":")
				.append("\n")
				.append("\n");
			CharSequence s = default(CharSequence);
			object obj = (s.___003Cref_003E = stringBuilder);
			stringBuilder3.append(s);
		}
		string result = stringBuilder2.ToString();
		
		return result;
	}

	
	
	
	public ParseException(Token currentTokenVal, int[][] expectedTokenSequencesVal, string[] tokenImageVal)
		: this(currentTokenVal, expectedTokenSequencesVal, tokenImageVal, null)
	{
	}

	
	
	
	public ParseException(string message)
		: base(message)
	{
	}
}
