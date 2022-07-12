using System;

using com.github.javaparser.utils;

using java.lang;

namespace com.github.javaparser;

public class TokenTypes
{

	public static bool isComment(int kind)
	{
		bool result = getCategory(kind).isComment();
		
		return result;
	}

	
	
	
	public static bool isEndOfLineToken(int kind)
	{
		bool result = getCategory(kind).isEndOfLine();
		
		return result;
	}

	
	
	
	public static bool isWhitespace(int kind)
	{
		bool result = getCategory(kind).isWhitespace();
		
		return result;
	}

	
	
	
	public static JavaToken.Category getCategory(int kind)
	{
		switch (kind)
		{
		case 2:
		case 3:
		case 4:
			return JavaToken.Category.___003C_003EEOL;
		case 0:
		case 1:
		case 147:
			return JavaToken.Category.___003C_003EWHITESPACE_NO_EOL;
		case 5:
		case 8:
		case 9:
			return JavaToken.Category.___003C_003ECOMMENT;
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 26:
		case 27:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
		case 39:
		case 40:
		case 41:
		case 42:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 59:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
			return JavaToken.Category.___003C_003EKEYWORD;
		case 28:
		case 43:
		case 60:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
		case 83:
		case 84:
		case 85:
		case 86:
		case 89:
		case 90:
		case 92:
			return JavaToken.Category.___003C_003ELITERAL;
		case 94:
			return JavaToken.Category.___003C_003EIDENTIFIER;
		case 97:
		case 98:
		case 99:
		case 100:
		case 101:
		case 102:
		case 103:
		case 104:
		case 105:
		case 106:
		case 107:
		case 108:
			return JavaToken.Category.___003C_003ESEPARATOR;
		case 109:
		case 110:
		case 111:
		case 112:
		case 113:
		case 114:
		case 115:
		case 116:
		case 117:
		case 118:
		case 119:
		case 120:
		case 121:
		case 122:
		case 123:
		case 124:
		case 125:
		case 126:
		case 127:
		case 128:
		case 129:
		case 130:
		case 131:
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
		case 137:
		case 138:
		case 139:
		case 140:
		case 141:
		case 142:
		case 143:
		case 144:
		case 145:
		case 146:
			return JavaToken.Category.___003C_003EOPERATOR;
		default:
		{
			string detailMessage = new StringBuilder().append("Unable to categorise token kind ").append(kind).append(" -- has it recently been added to the grammar but not classified within TokenTypes.java, perhaps?")
				.ToString();
			
			throw new AssertionError(detailMessage);
		}
		}
	}

	public static int spaceTokenKind()
	{
		return 1;
	}

	
	
	
	public static int eolTokenKind(LineSeparator lineSeparator)
	{
		if (lineSeparator.equalsString(LineSeparator.___003C_003ELF))
		{
			return 3;
		}
		if (lineSeparator.equalsString(LineSeparator.___003C_003ECRLF))
		{
			return 2;
		}
		if (lineSeparator.equalsString(LineSeparator.___003C_003ECR))
		{
			return 4;
		}
		
		throw new AssertionError("Unknown EOL character sequence");
	}

	
	
	
	public static bool isWhitespaceButNotEndOfLine(int kind)
	{
		bool result = getCategory(kind).isWhitespaceButNotEndOfLine();
		
		return result;
	}

	
	
	public static int eolTokenKind()
	{
		int result = eolTokenKind(LineSeparator.___003C_003ESYSTEM);
		
		return result;
	}

	
	
	
	public static bool isWhitespaceOrComment(int kind)
	{
		bool result = getCategory(kind).isWhitespaceOrComment();
		
		return result;
	}

	
	
	public TokenTypes()
	{
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static bool isSpaceOrTab(int kind)
	{
		bool result = isWhitespaceButNotEndOfLine(kind);
		
		return result;
	}
}
