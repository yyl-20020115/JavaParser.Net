using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler;

public class Lex : Object, TokenId
{
	private int lastChar;

	private StringBuilder textBuffer;

	private Token currentToken;

	private Token lookAheadTokens;

	private string input;

	private int position;

	private int maxlen;

	private int lineNumber;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] equalOps;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static KeywordTable ktable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 183, 104, 103, 107, 107, 135, 103, 103, 108,
		103
	})]
	public Lex(string s)
	{
		lastChar = -1;
		textBuffer = new StringBuilder();
		currentToken = new Token();
		lookAheadTokens = null;
		input = s;
		position = 0;
		maxlen = String.instancehelper_length(s);
		lineNumber = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 53, 104, 101, 103 })]
	private int get(Token P_0)
	{
		int num;
		do
		{
			num = readLine(P_0);
		}
		while (num == 10);
		P_0.tokenId = num;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		20, 103, 99, 110, 103, 168, 105, 136, 109, 232,
		60, 233, 71, 103
	})]
	public virtual int lookAhead(int i)
	{
		Token token = lookAheadTokens;
		if (token == null)
		{
			token = (lookAheadTokens = currentToken);
			token.next = null;
			get(token);
		}
		while (true)
		{
			int num = i;
			i += -1;
			if (num <= 0)
			{
				break;
			}
			if (token.next == null)
			{
				get(token.next = new Token());
			}
			token = token.next;
		}
		currentToken = token;
		return token.tokenId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		60, 103, 100, 98, 101, 110, 131, 101, 106, 101,
		106, 106, 107, 101, 103, 106, 103, 103, 105, 140,
		103, 139, 105, 107
	})]
	private int readLine(Token P_0)
	{
		int nextNonWhiteChar = getNextNonWhiteChar();
		if (nextNonWhiteChar < 0)
		{
			return nextNonWhiteChar;
		}
		switch (nextNonWhiteChar)
		{
		case 10:
			lineNumber++;
			return 10;
		case 39:
		{
			int result7 = readCharConst(P_0);
			_ = null;
			return result7;
		}
		case 34:
		{
			int result6 = readStringL(P_0);
			_ = null;
			return result6;
		}
		default:
		{
			if (48 <= nextNonWhiteChar && nextNonWhiteChar <= 57)
			{
				int result = readNumber(nextNonWhiteChar, P_0);
				_ = null;
				return result;
			}
			if (nextNonWhiteChar == 46)
			{
				nextNonWhiteChar = getc();
				if (48 <= nextNonWhiteChar && nextNonWhiteChar <= 57)
				{
					StringBuilder stringBuilder = textBuffer;
					stringBuilder.setLength(0);
					stringBuilder.append('.');
					int result2 = readDouble(stringBuilder, nextNonWhiteChar, P_0);
					_ = null;
					return result2;
				}
				ungetc(nextNonWhiteChar);
				int result3 = readSeparator(46);
				_ = null;
				return result3;
			}
			if (Character.isJavaIdentifierStart((char)nextNonWhiteChar))
			{
				int result4 = readIdentifier(nextNonWhiteChar, P_0);
				_ = null;
				return result4;
			}
			int result5 = readSeparator(nextNonWhiteChar);
			_ = null;
			return result5;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		92, 103, 104, 103, 133, 103, 115, 133, 103, 100,
		98, 101, 108, 99, 162, 169, 103, 163, 107
	})]
	private int getNextNonWhiteChar()
	{
		int num;
		do
		{
			num = getc();
			if (num != 47)
			{
				continue;
			}
			num = getc();
			if (num == 47)
			{
				do
				{
					num = getc();
				}
				while (num != 10 && num != 13 && num != -1);
			}
			else if (num == 42)
			{
				while (true)
				{
					num = getc();
					switch (num)
					{
					default:
						continue;
					case 42:
						if ((num = getc()) == 47)
						{
							num = 32;
							break;
						}
						goto IL_005d;
					case -1:
						break;
					}
					break;
					IL_005d:
					ungetc(num);
				}
			}
			else
			{
				ungetc(num);
				num = 47;
			}
		}
		while (isBlank(num));
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		123, 98, 108, 101, 105, 101, 101, 142, 166, 132,
		104
	})]
	private int readCharConst(Token P_0)
	{
		int num = 0;
		int num2;
		while ((num2 = getc()) != 39)
		{
			if (num2 == 92)
			{
				num = readEscapeChar();
				continue;
			}
			if (num2 < 32)
			{
				if (num2 == 10)
				{
					lineNumber++;
				}
				return 500;
			}
			num = num2;
		}
		P_0.longValue = num;
		return 401;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 94, 103, 135, 108, 101, 105, 105, 110, 166,
		203, 103, 101, 112, 104, 162, 104, 103, 194, 108
	})]
	private int readStringL(Token P_0)
	{
		StringBuilder stringBuilder = textBuffer;
		stringBuilder.setLength(0);
		int num;
		while (true)
		{
			if ((num = getc()) != 34)
			{
				if (num == 92)
				{
					num = readEscapeChar();
				}
				else if (num == 10 || num < 0)
				{
					lineNumber++;
					return 500;
				}
				stringBuilder.append((char)num);
				continue;
			}
			while (true)
			{
				num = getc();
				if (num == 10)
				{
					lineNumber++;
				}
				else if (!isBlank(num))
				{
					break;
				}
			}
			if (num != 34)
			{
				break;
			}
		}
		ungetc(num);
		P_0.textValue = stringBuilder.toString();
		return 406;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 127, 99, 103, 104, 141, 104, 106, 110, 106,
		113, 106, 145, 103, 106, 102, 103, 166, 106, 134,
		104, 106, 141, 103, 106, 102, 103, 230, 69, 102,
		106, 109, 169, 103, 106, 105, 134, 153, 103, 103,
		104, 140, 106, 134, 103
	})]
	private int readNumber(int P_0, Token P_1)
	{
		long num = 0L;
		int num2 = getc();
		if (P_0 == 48)
		{
			if (num2 == 88 || num2 == 120)
			{
				while (true)
				{
					P_0 = getc();
					if (48 <= P_0 && P_0 <= 57)
					{
						num = num * 16u + (P_0 - 48);
						continue;
					}
					if (65 <= P_0 && P_0 <= 70)
					{
						num = num * 16u + (P_0 - 65 + 10);
						continue;
					}
					if (97 > P_0 || P_0 > 102)
					{
						break;
					}
					num = num * 16u + (P_0 - 97 + 10);
				}
				P_1.longValue = num;
				if (P_0 == 76 || P_0 == 108)
				{
					return 403;
				}
				ungetc(P_0);
				return 402;
			}
			if (48 <= num2 && num2 <= 55)
			{
				num = num2 - 48;
				while (true)
				{
					P_0 = getc();
					if (48 > P_0 || P_0 > 55)
					{
						break;
					}
					num = num * 8 + (P_0 - 48);
				}
				P_1.longValue = num;
				if (P_0 == 76 || P_0 == 108)
				{
					return 403;
				}
				ungetc(P_0);
				return 402;
			}
		}
		num = P_0 - 48;
		while (48 <= num2 && num2 <= 57)
		{
			num = num * 10u + num2 - 48u;
			num2 = getc();
		}
		P_1.longValue = num;
		switch (num2)
		{
		case 70:
		case 102:
			P_1.doubleValue = num;
			return 404;
		case 46:
		case 68:
		case 69:
		case 100:
		case 101:
		{
			StringBuilder stringBuilder = textBuffer;
			stringBuilder.setLength(0);
			stringBuilder.append(num);
			int result = readDouble(stringBuilder, num2, P_1);
			_ = null;
			return result;
		}
		case 76:
		case 108:
			return 403;
		default:
			ungetc(num2);
			return 402;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 153, 105, 110, 159, 2, 98, 103, 103 })]
	private int getc()
	{
		if (lastChar < 0)
		{
			if (position < maxlen)
			{
				string @this = input;
				int num = position;
				position = num + 1;
				char result = String.instancehelper_charAt(@this, num);
				_ = null;
				return result;
			}
			return -1;
		}
		int result2 = lastChar;
		lastChar = -1;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 190, 116, 137, 104, 106, 235, 70, 106, 105,
		104, 106, 105, 168, 106, 105, 234, 69, 221, 2,
		97, 166, 106, 102, 106, 135
	})]
	private int readDouble(StringBuilder P_0, int P_1, Token P_2)
	{
		if (P_1 != 69 && P_1 != 101 && P_1 != 68 && P_1 != 100)
		{
			P_0.append((char)P_1);
			while (true)
			{
				P_1 = getc();
				if (48 > P_1 || P_1 > 57)
				{
					break;
				}
				P_0.append((char)P_1);
			}
		}
		if (P_1 == 69 || P_1 == 101)
		{
			P_0.append((char)P_1);
			P_1 = getc();
			if (P_1 == 43 || P_1 == 45)
			{
				P_0.append((char)P_1);
				P_1 = getc();
			}
			while (48 <= P_1 && P_1 <= 57)
			{
				P_0.append((char)P_1);
				P_1 = getc();
			}
		}
		try
		{
			P_2.doubleValue = Double.parseDouble(P_0.toString());
		}
		catch (NumberFormatException)
		{
			goto IL_00a7;
		}
		switch (P_1)
		{
		case 70:
		case 102:
			return 404;
		default:
			ungetc(P_1);
			break;
		case 68:
		case 100:
			break;
		}
		return 405;
		IL_00a7:
		_ = null;
		return 500;
	}

	private void ungetc(int P_0)
	{
		lastChar = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 239, 112, 107, 99, 98, 103, 103, 159, 24,
		134, 134, 134, 134, 103, 101, 102, 103, 134, 103,
		101, 102, 101, 103, 101, 102, 103, 166, 103, 166,
		130, 101, 98, 98, 101, 103, 101, 134, 101, 103,
		101, 102, 101, 166, 130, 103
	})]
	private int readSeparator(int P_0)
	{
		int num2;
		if (33 <= P_0 && P_0 <= 63)
		{
			int num = equalOps[P_0 - 33];
			if (num == 0)
			{
				return P_0;
			}
			num2 = getc();
			if (P_0 == num2)
			{
				switch (P_0)
				{
				case 61:
					return 358;
				case 43:
					return 362;
				case 45:
					return 363;
				case 38:
					return 369;
				case 60:
				{
					int num3 = getc();
					if (num3 == 61)
					{
						return 365;
					}
					ungetc(num3);
					return 364;
				}
				case 62:
				{
					int num3 = getc();
					switch (num3)
					{
					case 61:
						return 367;
					case 62:
						num3 = getc();
						if (num3 == 61)
						{
							return 371;
						}
						ungetc(num3);
						return 370;
					default:
						ungetc(num3);
						return 366;
					}
				}
				}
			}
			else if (num2 == 61)
			{
				return num;
			}
		}
		else
		{
			switch (P_0)
			{
			case 94:
				num2 = getc();
				if (num2 == 61)
				{
					return 360;
				}
				break;
			case 124:
				num2 = getc();
				switch (num2)
				{
				case 61:
					return 361;
				case 124:
					return 368;
				}
				break;
			default:
				return P_0;
			}
		}
		ungetc(num2);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 45, 103, 167, 105, 104, 137, 135, 103, 108,
		100, 226, 72, 103
	})]
	private int readIdentifier(int P_0, Token P_1)
	{
		StringBuilder stringBuilder = textBuffer;
		stringBuilder.setLength(0);
		do
		{
			stringBuilder.append((char)P_0);
			P_0 = getc();
		}
		while (Character.isJavaIdentifierPart((char)P_0));
		ungetc(P_0);
		string text = stringBuilder.toString();
		int num = ktable.lookup(text);
		if (num >= 0)
		{
			return num;
		}
		P_1.textValue = text;
		return 400;
	}

	private static bool isBlank(int P_0)
	{
		return (P_0 == 32 || P_0 == 9 || P_0 == 12 || P_0 == 13 || P_0 == 10) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 77, 103, 101, 101, 101, 101, 101, 101, 101,
		101, 101, 142
	})]
	private int readEscapeChar()
	{
		int num = getc();
		switch (num)
		{
		case 110:
			num = 10;
			break;
		case 116:
			num = 9;
			break;
		case 114:
			num = 13;
			break;
		case 102:
			num = 12;
			break;
		case 10:
			lineNumber++;
			break;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 104, 143, 110, 113 })]
	public virtual int get()
	{
		if (lookAheadTokens == null)
		{
			int result = get(currentToken);
			_ = null;
			return result;
		}
		Token token = (currentToken = lookAheadTokens);
		lookAheadTokens = lookAheadTokens.next;
		return token.tokenId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	public virtual int lookAhead()
	{
		int result = lookAhead(0);
		_ = null;
		return result;
	}

	[LineNumberTable(89)]
	public virtual string getString()
	{
		return currentToken.textValue;
	}

	[LineNumberTable(93)]
	public virtual long getLong()
	{
		return currentToken.longValue;
	}

	[LineNumberTable(97)]
	public virtual double getDouble()
	{
		return currentToken.doubleValue;
	}

	private static bool isDigit(int P_0)
	{
		return (48 <= P_0 && P_0 <= 57) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 141, 106, 100, 130, 106, 105, 135 })]
	public virtual string getTextAround()
	{
		int num = position - 10;
		if (num < 0)
		{
			num = 0;
		}
		int num2 = position + 10;
		if (num2 > maxlen)
		{
			num2 = maxlen;
		}
		string result = String.instancehelper_substring(input, num, num2);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		160,
		231,
		byte.MaxValue,
		160,
		103,
		160,
		95,
		170,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		116,
		118
	})]
	static Lex()
	{
		equalOps = new int[31]
		{
			350, 0, 0, 0, 351, 352, 0, 0, 0, 353,
			354, 0, 355, 0, 356, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 357, 358, 359,
			0
		};
		ktable = new KeywordTable();
		ktable.append("abstract", 300);
		ktable.append("boolean", 301);
		ktable.append("break", 302);
		ktable.append("byte", 303);
		ktable.append("case", 304);
		ktable.append("catch", 305);
		ktable.append("char", 306);
		ktable.append("class", 307);
		ktable.append("const", 308);
		ktable.append("continue", 309);
		ktable.append("default", 310);
		ktable.append("do", 311);
		ktable.append("double", 312);
		ktable.append("else", 313);
		ktable.append("extends", 314);
		ktable.append("false", 411);
		ktable.append("final", 315);
		ktable.append("finally", 316);
		ktable.append("float", 317);
		ktable.append("for", 318);
		ktable.append("goto", 319);
		ktable.append("if", 320);
		ktable.append("implements", 321);
		ktable.append("import", 322);
		ktable.append("instanceof", 323);
		ktable.append("int", 324);
		ktable.append("interface", 325);
		ktable.append("long", 326);
		ktable.append("native", 327);
		ktable.append("new", 328);
		ktable.append("null", 412);
		ktable.append("package", 329);
		ktable.append("private", 330);
		ktable.append("protected", 331);
		ktable.append("public", 332);
		ktable.append("return", 333);
		ktable.append("short", 334);
		ktable.append("static", 335);
		ktable.append("strictfp", 347);
		ktable.append("super", 336);
		ktable.append("switch", 337);
		ktable.append("synchronized", 338);
		ktable.append("this", 339);
		ktable.append("throw", 340);
		ktable.append("throws", 341);
		ktable.append("transient", 342);
		ktable.append("true", 410);
		ktable.append("try", 343);
		ktable.append("void", 344);
		ktable.append("volatile", 345);
		ktable.append("while", 346);
	}
}
