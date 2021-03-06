


namespace com.github.javaparser;

public interface GeneratedJavaParserConstants
{
	
	public static class __Fields
	{
		public const int EOF = 0;

		public const int SPACE = 1;

		public const int WINDOWS_EOL = 2;

		public const int UNIX_EOL = 3;

		public const int OLD_MAC_EOL = 4;

		public const int SINGLE_LINE_COMMENT = 5;

		public const int ENTER_JAVADOC_COMMENT = 6;

		public const int ENTER_MULTILINE_COMMENT = 7;

		public const int JAVADOC_COMMENT = 8;

		public const int MULTI_LINE_COMMENT = 9;

		public const int COMMENT_CONTENT = 10;

		public const int ABSTRACT = 11;

		public const int ASSERT = 12;

		public const int BOOLEAN = 13;

		public const int BREAK = 14;

		public const int BYTE = 15;

		public const int CASE = 16;

		public const int CATCH = 17;

		public const int CHAR = 18;

		public const int CLASS = 19;

		public const int CONST = 20;

		public const int CONTINUE = 21;

		public const int _DEFAULT = 22;

		public const int DO = 23;

		public const int DOUBLE = 24;

		public const int ELSE = 25;

		public const int ENUM = 26;

		public const int EXTENDS = 27;

		public const int FALSE = 28;

		public const int FINAL = 29;

		public const int FINALLY = 30;

		public const int FLOAT = 31;

		public const int FOR = 32;

		public const int GOTO = 33;

		public const int IF = 34;

		public const int IMPLEMENTS = 35;

		public const int IMPORT = 36;

		public const int INSTANCEOF = 37;

		public const int INT = 38;

		public const int INTERFACE = 39;

		public const int LONG = 40;

		public const int NATIVE = 41;

		public const int NEW = 42;

		public const int NULL = 43;

		public const int PACKAGE = 44;

		public const int PRIVATE = 45;

		public const int PROTECTED = 46;

		public const int PUBLIC = 47;

		public const int RECORD = 48;

		public const int RETURN = 49;

		public const int SHORT = 50;

		public const int STATIC = 51;

		public const int STRICTFP = 52;

		public const int SUPER = 53;

		public const int SWITCH = 54;

		public const int SYNCHRONIZED = 55;

		public const int THIS = 56;

		public const int THROW = 57;

		public const int THROWS = 58;

		public const int TRANSIENT = 59;

		public const int TRUE = 60;

		public const int TRY = 61;

		public const int VOID = 62;

		public const int VOLATILE = 63;

		public const int WHILE = 64;

		public const int YIELD = 65;

		public const int REQUIRES = 66;

		public const int TO = 67;

		public const int WITH = 68;

		public const int OPEN = 69;

		public const int OPENS = 70;

		public const int USES = 71;

		public const int MODULE = 72;

		public const int EXPORTS = 73;

		public const int PROVIDES = 74;

		public const int TRANSITIVE = 75;

		public const int LONG_LITERAL = 76;

		public const int INTEGER_LITERAL = 77;

		public const int DECIMAL_LITERAL = 78;

		public const int HEX_LITERAL = 79;

		public const int OCTAL_LITERAL = 80;

		public const int BINARY_LITERAL = 81;

		public const int FLOATING_POINT_LITERAL = 82;

		public const int DECIMAL_FLOATING_POINT_LITERAL = 83;

		public const int DECIMAL_EXPONENT = 84;

		public const int HEXADECIMAL_FLOATING_POINT_LITERAL = 85;

		public const int HEXADECIMAL_EXPONENT = 86;

		public const int HEX_DIGITS = 87;

		public const int UNICODE_ESCAPE = 88;

		public const int CHARACTER_LITERAL = 89;

		public const int STRING_LITERAL = 90;

		public const int ENTER_TEXT_BLOCK = 91;

		public const int TEXT_BLOCK_LITERAL = 92;

		public const int TEXT_BLOCK_CONTENT = 93;

		public const int IDENTIFIER = 94;

		public const int LETTER = 95;

		public const int PART_LETTER = 96;

		public const int LPAREN = 97;

		public const int RPAREN = 98;

		public const int LBRACE = 99;

		public const int RBRACE = 100;

		public const int LBRACKET = 101;

		public const int RBRACKET = 102;

		public const int SEMICOLON = 103;

		public const int COMMA = 104;

		public const int DOT = 105;

		public const int ELLIPSIS = 106;

		public const int AT = 107;

		public const int DOUBLECOLON = 108;

		public const int ASSIGN = 109;

		public const int LT = 110;

		public const int BANG = 111;

		public const int TILDE = 112;

		public const int HOOK = 113;

		public const int COLON = 114;

		public const int ARROW = 115;

		public const int EQ = 116;

		public const int GE = 117;

		public const int LE = 118;

		public const int NE = 119;

		public const int SC_AND = 120;

		public const int SC_OR = 121;

		public const int INCR = 122;

		public const int DECR = 123;

		public const int PLUS = 124;

		public const int MINUS = 125;

		public const int STAR = 126;

		public const int SLASH = 127;

		public const int BIT_AND = 128;

		public const int BIT_OR = 129;

		public const int XOR = 130;

		public const int REM = 131;

		public const int LSHIFT = 132;

		public const int PLUSASSIGN = 133;

		public const int MINUSASSIGN = 134;

		public const int STARASSIGN = 135;

		public const int SLASHASSIGN = 136;

		public const int ANDASSIGN = 137;

		public const int ORASSIGN = 138;

		public const int XORASSIGN = 139;

		public const int REMASSIGN = 140;

		public const int LSHIFTASSIGN = 141;

		public const int RSIGNEDSHIFTASSIGN = 142;

		public const int RUNSIGNEDSHIFTASSIGN = 143;

		public const int RUNSIGNEDSHIFT = 144;

		public const int RSIGNEDSHIFT = 145;

		public const int GT = 146;

		public const int CTRL_Z = 147;

		public const int DEFAULT = 0;

		public const int IN_JAVADOC_COMMENT = 1;

		public const int IN_MULTI_LINE_COMMENT = 2;

		public const int IN_TEXT_BLOCK = 3;

		public static readonly string[] tokenImage;

		static __Fields()
		{
			tokenImage = new string[148]
			{
			"<EOF>", "<SPACE>", "\"\\r\\n\"", "\"\\n\"", "\"\\r\"", "<SINGLE_LINE_COMMENT>", "<ENTER_JAVADOC_COMMENT>", "\"/*\"", "\"*/\"", "\"*/\"",
			"<COMMENT_CONTENT>", "\"abstract\"", "\"assert\"", "\"boolean\"", "\"break\"", "\"byte\"", "\"case\"", "\"catch\"", "\"char\"", "\"class\"",
			"\"const\"", "\"continue\"", "\"default\"", "\"do\"", "\"double\"", "\"else\"", "\"enum\"", "\"extends\"", "\"false\"", "\"final\"",
			"\"finally\"", "\"float\"", "\"for\"", "\"goto\"", "\"if\"", "\"implements\"", "\"import\"", "\"instanceof\"", "\"int\"", "\"interface\"",
			"\"long\"", "\"native\"", "\"new\"", "\"null\"", "\"package\"", "\"private\"", "\"protected\"", "\"public\"", "\"record\"", "\"return\"",
			"\"short\"", "\"static\"", "\"strictfp\"", "\"super\"", "\"switch\"", "\"synchronized\"", "\"this\"", "\"throw\"", "\"throws\"", "\"transient\"",
			"\"true\"", "\"try\"", "\"void\"", "\"volatile\"", "\"while\"", "\"yield\"", "\"requires\"", "\"to\"", "\"with\"", "\"open\"",
			"\"opens\"", "\"uses\"", "\"module\"", "\"exports\"", "\"provides\"", "\"transitive\"", "<LONG_LITERAL>", "<INTEGER_LITERAL>", "<DECIMAL_LITERAL>", "<HEX_LITERAL>",
			"<OCTAL_LITERAL>", "<BINARY_LITERAL>", "<FLOATING_POINT_LITERAL>", "<DECIMAL_FLOATING_POINT_LITERAL>", "<DECIMAL_EXPONENT>", "<HEXADECIMAL_FLOATING_POINT_LITERAL>", "<HEXADECIMAL_EXPONENT>", "<HEX_DIGITS>", "<UNICODE_ESCAPE>", "<CHARACTER_LITERAL>",
			"<STRING_LITERAL>", "\"\\\"\\\"\\\"\"", "\"\\\"\\\"\\\"\"", "<TEXT_BLOCK_CONTENT>", "<IDENTIFIER>", "<LETTER>", "<PART_LETTER>", "\"(\"", "\")\"", "\"{\"",
			"\"}\"", "\"[\"", "\"]\"", "\";\"", "\",\"", "\".\"", "\"...\"", "\"@\"", "\"::\"", "\"=\"",
			"\"<\"", "\"!\"", "\"~\"", "\"?\"", "\":\"", "\"->\"", "\"==\"", "\">=\"", "\"<=\"", "\"!=\"",
			"\"&&\"", "\"||\"", "\"++\"", "\"--\"", "\"+\"", "\"-\"", "\"*\"", "\"/\"", "\"&\"", "\"|\"",
			"\"^\"", "\"%\"", "\"<<\"", "\"+=\"", "\"-=\"", "\"*=\"", "\"/=\"", "\"&=\"", "\"|=\"", "\"^=\"",
			"\"%=\"", "\"<<=\"", "\">>=\"", "\">>>=\"", "\">>>\"", "\">>\"", "\">\"", "\"\\u001a\""
			};
		}
	}




	static void ___003Cclinit_003E()
	{
	}

	
}
