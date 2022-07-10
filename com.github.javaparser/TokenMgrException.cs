using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

[Serializable]
public class TokenMgrException : RuntimeException
{
	private const long serialVersionUID = 1L;

	public const int LEXICAL_ERROR = 0;

	public const int STATIC_LEXER_ERROR = 1;

	public const int INVALID_LEXICAL_STATE = 2;

	public const int LOOP_DETECTED = 3;

	internal int errorCode;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public TokenMgrException(bool EOFSeen, int lexState, int errorLine, int errorColumn, string errorAfter, int curChar, int reason)
		: this(LexicalErr(EOFSeen, lexState, errorLine, errorColumn, errorAfter, curChar), reason)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public TokenMgrException(string message, int reason)
		: base(message)
	{
		errorCode = reason;
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		21, 102, 110, 104, 191, 51, 108, 133, 108, 133,
		108, 133, 108, 133, 108, 133, 108, 133, 108, 133,
		108, 133, 106, 127, 3, 127, 6, 98, 136, 226,
		29, 233, 102
	})]
	protected internal static string addEscapes(string str)
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
				stringBuilder.append("\\u").append(java.lang.String.instancehelper_substring(@this, java.lang.String.instancehelper_length(@this) - 4, java.lang.String.instancehelper_length(@this)));
			}
			else
			{
				stringBuilder.append((char)num);
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	protected internal static string LexicalErr(bool EOFSeen, int lexState, int errorLine, int errorColumn, string errorAfter, int curChar)
	{
		int c = (ushort)curChar;
		string result = new StringBuilder().append("Lexical error at line ").append(errorLine).append(", column ")
			.append(errorColumn)
			.append(".  Encountered: ")
			.append((!EOFSeen) ? new StringBuilder().append("\"").append(addEscapes(java.lang.String.valueOf((char)c))).append("\"")
				.append(" (")
				.append(curChar)
				.append("), ")
				.ToString() : "<EOF> ")
			.append("after : \"")
			.append(addEscapes(errorAfter))
			.append("\"")
			.ToString();
		
		return result;
	}

	
	
	public override string getMessage()
	{
		string message = base.getMessage();
		
		return message;
	}

	
	
	public TokenMgrException()
	{
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected TokenMgrException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
