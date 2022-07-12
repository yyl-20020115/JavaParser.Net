using System;

using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;

public class JavaToken
{
	
	
		
	public class Category : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			WHITESPACE_NO_EOL,
			EOL,
			COMMENT,
			IDENTIFIER,
			KEYWORD,
			LITERAL,
			SEPARATOR,
			OPERATOR
		}

		
		internal static Category ___003C_003EWHITESPACE_NO_EOL;

		
		internal static Category ___003C_003EEOL;

		
		internal static Category ___003C_003ECOMMENT;

		
		internal static Category ___003C_003EIDENTIFIER;

		
		internal static Category ___003C_003EKEYWORD;

		
		internal static Category ___003C_003ELITERAL;

		
		internal static Category ___003C_003ESEPARATOR;

		
		internal static Category ___003C_003EOPERATOR;

		
		private static Category[] _0024VALUES;

		
		public static Category WHITESPACE_NO_EOL
		{
			
			get
			{
				return ___003C_003EWHITESPACE_NO_EOL;
			}
		}

		
		public static Category EOL
		{
			
			get
			{
				return ___003C_003EEOL;
			}
		}

		
		public static Category COMMENT
		{
			
			get
			{
				return ___003C_003ECOMMENT;
			}
		}

		
		public static Category IDENTIFIER
		{
			
			get
			{
				return ___003C_003EIDENTIFIER;
			}
		}

		
		public static Category KEYWORD
		{
			
			get
			{
				return ___003C_003EKEYWORD;
			}
		}

		
		public static Category LITERAL
		{
			
			get
			{
				return ___003C_003ELITERAL;
			}
		}

		
		public static Category SEPARATOR
		{
			
			get
			{
				return ___003C_003ESEPARATOR;
			}
		}

		
		public static Category OPERATOR
		{
			
			get
			{
				return ___003C_003EOPERATOR;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		public virtual bool isEndOfLine()
		{
			return this == ___003C_003EEOL;
		}

		public virtual bool isWhitespace()
		{
			return (this == ___003C_003EWHITESPACE_NO_EOL || this == ___003C_003EEOL) ? true : false;
		}

		
				
		
		private Category(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static Category[] values()
		{
			return (Category[])_0024VALUES.Clone();
		}

		
		
		
		public static Category valueOf(string name)
		{
			return (Category)java.lang.Enum.valueOf(ClassLiteral<Category>.Value, name);
		}

		
		
		public virtual bool isWhitespaceOrComment()
		{
			return (isWhitespace() || this == ___003C_003ECOMMENT) ? true : false;
		}

		public virtual bool isComment()
		{
			return this == ___003C_003ECOMMENT;
		}

		public virtual bool isWhitespaceButNotEndOfLine()
		{
			return this == ___003C_003EWHITESPACE_NO_EOL;
		}

		public virtual bool isIdentifier()
		{
			return this == ___003C_003EIDENTIFIER;
		}

		public virtual bool isKeyword()
		{
			return this == ___003C_003EKEYWORD;
		}

		public virtual bool isLiteral()
		{
			return this == ___003C_003ELITERAL;
		}

		public virtual bool isSeparator()
		{
			return this == ___003C_003ESEPARATOR;
		}

		public virtual bool isOperator()
		{
			return this == ___003C_003EOPERATOR;
		}

		
		static Category()
		{
			___003C_003EWHITESPACE_NO_EOL = new Category("WHITESPACE_NO_EOL", 0);
			___003C_003EEOL = new Category("EOL", 1);
			___003C_003ECOMMENT = new Category("COMMENT", 2);
			___003C_003EIDENTIFIER = new Category("IDENTIFIER", 3);
			___003C_003EKEYWORD = new Category("KEYWORD", 4);
			___003C_003ELITERAL = new Category("LITERAL", 5);
			___003C_003ESEPARATOR = new Category("SEPARATOR", 6);
			___003C_003EOPERATOR = new Category("OPERATOR", 7);
			_0024VALUES = new Category[8] { ___003C_003EWHITESPACE_NO_EOL, ___003C_003EEOL, ___003C_003ECOMMENT, ___003C_003EIDENTIFIER, ___003C_003EKEYWORD, ___003C_003ELITERAL, ___003C_003ESEPARATOR, ___003C_003EOPERATOR };
		}
	}

	
	
		
	public class Kind : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			EOF,
			SPACE,
			WINDOWS_EOL,
			UNIX_EOL,
			OLD_MAC_EOL,
			SINGLE_LINE_COMMENT,
			ENTER_JAVADOC_COMMENT,
			ENTER_MULTILINE_COMMENT,
			JAVADOC_COMMENT,
			MULTI_LINE_COMMENT,
			COMMENT_CONTENT,
			ABSTRACT,
			ASSERT,
			BOOLEAN,
			BREAK,
			BYTE,
			CASE,
			CATCH,
			CHAR,
			CLASS,
			CONST,
			CONTINUE,
			_DEFAULT,
			DO,
			DOUBLE,
			ELSE,
			ENUM,
			EXTENDS,
			FALSE,
			FINAL,
			FINALLY,
			FLOAT,
			FOR,
			GOTO,
			IF,
			IMPLEMENTS,
			IMPORT,
			INSTANCEOF,
			INT,
			INTERFACE,
			LONG,
			NATIVE,
			NEW,
			NULL,
			PACKAGE,
			PRIVATE,
			PROTECTED,
			PUBLIC,
			RECORD,
			RETURN,
			SHORT,
			STATIC,
			STRICTFP,
			SUPER,
			SWITCH,
			SYNCHRONIZED,
			THIS,
			THROW,
			THROWS,
			TRANSIENT,
			TRUE,
			TRY,
			VOID,
			VOLATILE,
			WHILE,
			YIELD,
			REQUIRES,
			TO,
			WITH,
			OPEN,
			OPENS,
			USES,
			MODULE,
			EXPORTS,
			PROVIDES,
			TRANSITIVE,
			LONG_LITERAL,
			INTEGER_LITERAL,
			DECIMAL_LITERAL,
			HEX_LITERAL,
			OCTAL_LITERAL,
			BINARY_LITERAL,
			FLOATING_POINT_LITERAL,
			DECIMAL_FLOATING_POINT_LITERAL,
			DECIMAL_EXPONENT,
			HEXADECIMAL_FLOATING_POINT_LITERAL,
			HEXADECIMAL_EXPONENT,
			HEX_DIGITS,
			UNICODE_ESCAPE,
			CHARACTER_LITERAL,
			STRING_LITERAL,
			ENTER_TEXT_BLOCK,
			TEXT_BLOCK_LITERAL,
			TEXT_BLOCK_CONTENT,
			IDENTIFIER,
			LETTER,
			PART_LETTER,
			LPAREN,
			RPAREN,
			LBRACE,
			RBRACE,
			LBRACKET,
			RBRACKET,
			SEMICOLON,
			COMMA,
			DOT,
			ELLIPSIS,
			AT,
			DOUBLECOLON,
			ASSIGN,
			LT,
			BANG,
			TILDE,
			HOOK,
			COLON,
			ARROW,
			EQ,
			GE,
			LE,
			NE,
			SC_AND,
			SC_OR,
			INCR,
			DECR,
			PLUS,
			MINUS,
			STAR,
			SLASH,
			BIT_AND,
			BIT_OR,
			XOR,
			REM,
			LSHIFT,
			PLUSASSIGN,
			MINUSASSIGN,
			STARASSIGN,
			SLASHASSIGN,
			ANDASSIGN,
			ORASSIGN,
			XORASSIGN,
			REMASSIGN,
			LSHIFTASSIGN,
			RSIGNEDSHIFTASSIGN,
			RUNSIGNEDSHIFTASSIGN,
			RUNSIGNEDSHIFT,
			RSIGNEDSHIFT,
			GT,
			CTRL_Z
		}

		
		internal static Kind ___003C_003EEOF;

		
		internal static Kind ___003C_003ESPACE;

		
		internal static Kind ___003C_003EWINDOWS_EOL;

		
		internal static Kind ___003C_003EUNIX_EOL;

		
		internal static Kind ___003C_003EOLD_MAC_EOL;

		
		internal static Kind ___003C_003ESINGLE_LINE_COMMENT;

		
		internal static Kind ___003C_003EENTER_JAVADOC_COMMENT;

		
		internal static Kind ___003C_003EENTER_MULTILINE_COMMENT;

		
		internal static Kind ___003C_003EJAVADOC_COMMENT;

		
		internal static Kind ___003C_003EMULTI_LINE_COMMENT;

		
		internal static Kind ___003C_003ECOMMENT_CONTENT;

		
		internal static Kind ___003C_003EABSTRACT;

		
		internal static Kind ___003C_003EASSERT;

		
		internal static Kind ___003C_003EBOOLEAN;

		
		internal static Kind ___003C_003EBREAK;

		
		internal static Kind ___003C_003EBYTE;

		
		internal static Kind ___003C_003ECASE;

		
		internal static Kind ___003C_003ECATCH;

		
		internal static Kind ___003C_003ECHAR;

		
		internal static Kind ___003C_003ECLASS;

		
		internal static Kind ___003C_003ECONST;

		
		internal static Kind ___003C_003ECONTINUE;

		
		internal static Kind ___003C_003E_DEFAULT;

		
		internal static Kind ___003C_003EDO;

		
		internal static Kind ___003C_003EDOUBLE;

		
		internal static Kind ___003C_003EELSE;

		
		internal static Kind ___003C_003EENUM;

		
		internal static Kind ___003C_003EEXTENDS;

		
		internal static Kind ___003C_003EFALSE;

		
		internal static Kind ___003C_003EFINAL;

		
		internal static Kind ___003C_003EFINALLY;

		
		internal static Kind ___003C_003EFLOAT;

		
		internal static Kind ___003C_003EFOR;

		
		internal static Kind ___003C_003EGOTO;

		
		internal static Kind ___003C_003EIF;

		
		internal static Kind ___003C_003EIMPLEMENTS;

		
		internal static Kind ___003C_003EIMPORT;

		
		internal static Kind ___003C_003EINSTANCEOF;

		
		internal static Kind ___003C_003EINT;

		
		internal static Kind ___003C_003EINTERFACE;

		
		internal static Kind ___003C_003ELONG;

		
		internal static Kind ___003C_003ENATIVE;

		
		internal static Kind ___003C_003ENEW;

		
		internal static Kind ___003C_003ENULL;

		
		internal static Kind ___003C_003EPACKAGE;

		
		internal static Kind ___003C_003EPRIVATE;

		
		internal static Kind ___003C_003EPROTECTED;

		
		internal static Kind ___003C_003EPUBLIC;

		
		internal static Kind ___003C_003ERECORD;

		
		internal static Kind ___003C_003ERETURN;

		
		internal static Kind ___003C_003ESHORT;

		
		internal static Kind ___003C_003ESTATIC;

		
		internal static Kind ___003C_003ESTRICTFP;

		
		internal static Kind ___003C_003ESUPER;

		
		internal static Kind ___003C_003ESWITCH;

		
		internal static Kind ___003C_003ESYNCHRONIZED;

		
		internal static Kind ___003C_003ETHIS;

		
		internal static Kind ___003C_003ETHROW;

		
		internal static Kind ___003C_003ETHROWS;

		
		internal static Kind ___003C_003ETRANSIENT;

		
		internal static Kind ___003C_003ETRUE;

		
		internal static Kind ___003C_003ETRY;

		
		internal static Kind ___003C_003EVOID;

		
		internal static Kind ___003C_003EVOLATILE;

		
		internal static Kind ___003C_003EWHILE;

		
		internal static Kind ___003C_003EYIELD;

		
		internal static Kind ___003C_003EREQUIRES;

		
		internal static Kind ___003C_003ETO;

		
		internal static Kind ___003C_003EWITH;

		
		internal static Kind ___003C_003EOPEN;

		
		internal static Kind ___003C_003EOPENS;

		
		internal static Kind ___003C_003EUSES;

		
		internal static Kind ___003C_003EMODULE;

		
		internal static Kind ___003C_003EEXPORTS;

		
		internal static Kind ___003C_003EPROVIDES;

		
		internal static Kind ___003C_003ETRANSITIVE;

		
		internal static Kind ___003C_003ELONG_LITERAL;

		
		internal static Kind ___003C_003EINTEGER_LITERAL;

		
		internal static Kind ___003C_003EDECIMAL_LITERAL;

		
		internal static Kind ___003C_003EHEX_LITERAL;

		
		internal static Kind ___003C_003EOCTAL_LITERAL;

		
		internal static Kind ___003C_003EBINARY_LITERAL;

		
		internal static Kind ___003C_003EFLOATING_POINT_LITERAL;

		
		internal static Kind ___003C_003EDECIMAL_FLOATING_POINT_LITERAL;

		
		internal static Kind ___003C_003EDECIMAL_EXPONENT;

		
		internal static Kind ___003C_003EHEXADECIMAL_FLOATING_POINT_LITERAL;

		
		internal static Kind ___003C_003EHEXADECIMAL_EXPONENT;

		
		internal static Kind ___003C_003EHEX_DIGITS;

		
		internal static Kind ___003C_003EUNICODE_ESCAPE;

		
		internal static Kind ___003C_003ECHARACTER_LITERAL;

		
		internal static Kind ___003C_003ESTRING_LITERAL;

		
		internal static Kind ___003C_003EENTER_TEXT_BLOCK;

		
		internal static Kind ___003C_003ETEXT_BLOCK_LITERAL;

		
		internal static Kind ___003C_003ETEXT_BLOCK_CONTENT;

		
		internal static Kind ___003C_003EIDENTIFIER;

		
		internal static Kind ___003C_003ELETTER;

		
		internal static Kind ___003C_003EPART_LETTER;

		
		internal static Kind ___003C_003ELPAREN;

		
		internal static Kind ___003C_003ERPAREN;

		
		internal static Kind ___003C_003ELBRACE;

		
		internal static Kind ___003C_003ERBRACE;

		
		internal static Kind ___003C_003ELBRACKET;

		
		internal static Kind ___003C_003ERBRACKET;

		
		internal static Kind ___003C_003ESEMICOLON;

		
		internal static Kind ___003C_003ECOMMA;

		
		internal static Kind ___003C_003EDOT;

		
		internal static Kind ___003C_003EELLIPSIS;

		
		internal static Kind ___003C_003EAT;

		
		internal static Kind ___003C_003EDOUBLECOLON;

		
		internal static Kind ___003C_003EASSIGN;

		
		internal static Kind ___003C_003ELT;

		
		internal static Kind ___003C_003EBANG;

		
		internal static Kind ___003C_003ETILDE;

		
		internal static Kind ___003C_003EHOOK;

		
		internal static Kind ___003C_003ECOLON;

		
		internal static Kind ___003C_003EARROW;

		
		internal static Kind ___003C_003EEQ;

		
		internal static Kind ___003C_003EGE;

		
		internal static Kind ___003C_003ELE;

		
		internal static Kind ___003C_003ENE;

		
		internal static Kind ___003C_003ESC_AND;

		
		internal static Kind ___003C_003ESC_OR;

		
		internal static Kind ___003C_003EINCR;

		
		internal static Kind ___003C_003EDECR;

		
		internal static Kind ___003C_003EPLUS;

		
		internal static Kind ___003C_003EMINUS;

		
		internal static Kind ___003C_003ESTAR;

		
		internal static Kind ___003C_003ESLASH;

		
		internal static Kind ___003C_003EBIT_AND;

		
		internal static Kind ___003C_003EBIT_OR;

		
		internal static Kind ___003C_003EXOR;

		
		internal static Kind ___003C_003EREM;

		
		internal static Kind ___003C_003ELSHIFT;

		
		internal static Kind ___003C_003EPLUSASSIGN;

		
		internal static Kind ___003C_003EMINUSASSIGN;

		
		internal static Kind ___003C_003ESTARASSIGN;

		
		internal static Kind ___003C_003ESLASHASSIGN;

		
		internal static Kind ___003C_003EANDASSIGN;

		
		internal static Kind ___003C_003EORASSIGN;

		
		internal static Kind ___003C_003EXORASSIGN;

		
		internal static Kind ___003C_003EREMASSIGN;

		
		internal static Kind ___003C_003ELSHIFTASSIGN;

		
		internal static Kind ___003C_003ERSIGNEDSHIFTASSIGN;

		
		internal static Kind ___003C_003ERUNSIGNEDSHIFTASSIGN;

		
		internal static Kind ___003C_003ERUNSIGNEDSHIFT;

		
		internal static Kind ___003C_003ERSIGNEDSHIFT;

		
		internal static Kind ___003C_003EGT;

		
		internal static Kind ___003C_003ECTRL_Z;

		
		private int kind;

		
		private static Kind[] _0024VALUES;

		
		public static Kind EOF
		{
			
			get
			{
				return ___003C_003EEOF;
			}
		}

		
		public static Kind SPACE
		{
			
			get
			{
				return ___003C_003ESPACE;
			}
		}

		
		public static Kind WINDOWS_EOL
		{
			
			get
			{
				return ___003C_003EWINDOWS_EOL;
			}
		}

		
		public static Kind UNIX_EOL
		{
			
			get
			{
				return ___003C_003EUNIX_EOL;
			}
		}

		
		public static Kind OLD_MAC_EOL
		{
			
			get
			{
				return ___003C_003EOLD_MAC_EOL;
			}
		}

		
		public static Kind SINGLE_LINE_COMMENT
		{
			
			get
			{
				return ___003C_003ESINGLE_LINE_COMMENT;
			}
		}

		
		public static Kind ENTER_JAVADOC_COMMENT
		{
			
			get
			{
				return ___003C_003EENTER_JAVADOC_COMMENT;
			}
		}

		
		public static Kind ENTER_MULTILINE_COMMENT
		{
			
			get
			{
				return ___003C_003EENTER_MULTILINE_COMMENT;
			}
		}

		
		public static Kind JAVADOC_COMMENT
		{
			
			get
			{
				return ___003C_003EJAVADOC_COMMENT;
			}
		}

		
		public static Kind MULTI_LINE_COMMENT
		{
			
			get
			{
				return ___003C_003EMULTI_LINE_COMMENT;
			}
		}

		
		public static Kind COMMENT_CONTENT
		{
			
			get
			{
				return ___003C_003ECOMMENT_CONTENT;
			}
		}

		
		public static Kind ABSTRACT
		{
			
			get
			{
				return ___003C_003EABSTRACT;
			}
		}

		
		public static Kind ASSERT
		{
			
			get
			{
				return ___003C_003EASSERT;
			}
		}

		
		public static Kind BOOLEAN
		{
			
			get
			{
				return ___003C_003EBOOLEAN;
			}
		}

		
		public static Kind BREAK
		{
			
			get
			{
				return ___003C_003EBREAK;
			}
		}

		
		public static Kind BYTE
		{
			
			get
			{
				return ___003C_003EBYTE;
			}
		}

		
		public static Kind CASE
		{
			
			get
			{
				return ___003C_003ECASE;
			}
		}

		
		public static Kind CATCH
		{
			
			get
			{
				return ___003C_003ECATCH;
			}
		}

		
		public static Kind CHAR
		{
			
			get
			{
				return ___003C_003ECHAR;
			}
		}

		
		public static Kind CLASS
		{
			
			get
			{
				return ___003C_003ECLASS;
			}
		}

		
		public static Kind CONST
		{
			
			get
			{
				return ___003C_003ECONST;
			}
		}

		
		public static Kind CONTINUE
		{
			
			get
			{
				return ___003C_003ECONTINUE;
			}
		}

		
		public static Kind _DEFAULT
		{
			
			get
			{
				return ___003C_003E_DEFAULT;
			}
		}

		
		public static Kind DO
		{
			
			get
			{
				return ___003C_003EDO;
			}
		}

		
		public static Kind DOUBLE
		{
			
			get
			{
				return ___003C_003EDOUBLE;
			}
		}

		
		public static Kind ELSE
		{
			
			get
			{
				return ___003C_003EELSE;
			}
		}

		
		public static Kind ENUM
		{
			
			get
			{
				return ___003C_003EENUM;
			}
		}

		
		public static Kind EXTENDS
		{
			
			get
			{
				return ___003C_003EEXTENDS;
			}
		}

		
		public static Kind FALSE
		{
			
			get
			{
				return ___003C_003EFALSE;
			}
		}

		
		public static Kind FINAL
		{
			
			get
			{
				return ___003C_003EFINAL;
			}
		}

		
		public static Kind FINALLY
		{
			
			get
			{
				return ___003C_003EFINALLY;
			}
		}

		
		public static Kind FLOAT
		{
			
			get
			{
				return ___003C_003EFLOAT;
			}
		}

		
		public static Kind FOR
		{
			
			get
			{
				return ___003C_003EFOR;
			}
		}

		
		public static Kind GOTO
		{
			
			get
			{
				return ___003C_003EGOTO;
			}
		}

		
		public static Kind IF
		{
			
			get
			{
				return ___003C_003EIF;
			}
		}

		
		public static Kind IMPLEMENTS
		{
			
			get
			{
				return ___003C_003EIMPLEMENTS;
			}
		}

		
		public static Kind IMPORT
		{
			
			get
			{
				return ___003C_003EIMPORT;
			}
		}

		
		public static Kind INSTANCEOF
		{
			
			get
			{
				return ___003C_003EINSTANCEOF;
			}
		}

		
		public static Kind INT
		{
			
			get
			{
				return ___003C_003EINT;
			}
		}

		
		public static Kind INTERFACE
		{
			
			get
			{
				return ___003C_003EINTERFACE;
			}
		}

		
		public static Kind LONG
		{
			
			get
			{
				return ___003C_003ELONG;
			}
		}

		
		public static Kind NATIVE
		{
			
			get
			{
				return ___003C_003ENATIVE;
			}
		}

		
		public static Kind NEW
		{
			
			get
			{
				return ___003C_003ENEW;
			}
		}

		
		public static Kind NULL
		{
			
			get
			{
				return ___003C_003ENULL;
			}
		}

		
		public static Kind PACKAGE
		{
			
			get
			{
				return ___003C_003EPACKAGE;
			}
		}

		
		public static Kind PRIVATE
		{
			
			get
			{
				return ___003C_003EPRIVATE;
			}
		}

		
		public static Kind PROTECTED
		{
			
			get
			{
				return ___003C_003EPROTECTED;
			}
		}

		
		public static Kind PUBLIC
		{
			
			get
			{
				return ___003C_003EPUBLIC;
			}
		}

		
		public static Kind RECORD
		{
			
			get
			{
				return ___003C_003ERECORD;
			}
		}

		
		public static Kind RETURN
		{
			
			get
			{
				return ___003C_003ERETURN;
			}
		}

		
		public static Kind SHORT
		{
			
			get
			{
				return ___003C_003ESHORT;
			}
		}

		
		public static Kind STATIC
		{
			
			get
			{
				return ___003C_003ESTATIC;
			}
		}

		
		public static Kind STRICTFP
		{
			
			get
			{
				return ___003C_003ESTRICTFP;
			}
		}

		
		public static Kind SUPER
		{
			
			get
			{
				return ___003C_003ESUPER;
			}
		}

		
		public static Kind SWITCH
		{
			
			get
			{
				return ___003C_003ESWITCH;
			}
		}

		
		public static Kind SYNCHRONIZED
		{
			
			get
			{
				return ___003C_003ESYNCHRONIZED;
			}
		}

		
		public static Kind THIS
		{
			
			get
			{
				return ___003C_003ETHIS;
			}
		}

		
		public static Kind THROW
		{
			
			get
			{
				return ___003C_003ETHROW;
			}
		}

		
		public static Kind THROWS
		{
			
			get
			{
				return ___003C_003ETHROWS;
			}
		}

		
		public static Kind TRANSIENT
		{
			
			get
			{
				return ___003C_003ETRANSIENT;
			}
		}

		
		public static Kind TRUE
		{
			
			get
			{
				return ___003C_003ETRUE;
			}
		}

		
		public static Kind TRY
		{
			
			get
			{
				return ___003C_003ETRY;
			}
		}

		
		public static Kind VOID
		{
			
			get
			{
				return ___003C_003EVOID;
			}
		}

		
		public static Kind VOLATILE
		{
			
			get
			{
				return ___003C_003EVOLATILE;
			}
		}

		
		public static Kind WHILE
		{
			
			get
			{
				return ___003C_003EWHILE;
			}
		}

		
		public static Kind YIELD
		{
			
			get
			{
				return ___003C_003EYIELD;
			}
		}

		
		public static Kind REQUIRES
		{
			
			get
			{
				return ___003C_003EREQUIRES;
			}
		}

		
		public static Kind TO
		{
			
			get
			{
				return ___003C_003ETO;
			}
		}

		
		public static Kind WITH
		{
			
			get
			{
				return ___003C_003EWITH;
			}
		}

		
		public static Kind OPEN
		{
			
			get
			{
				return ___003C_003EOPEN;
			}
		}

		
		public static Kind OPENS
		{
			
			get
			{
				return ___003C_003EOPENS;
			}
		}

		
		public static Kind USES
		{
			
			get
			{
				return ___003C_003EUSES;
			}
		}

		
		public static Kind MODULE
		{
			
			get
			{
				return ___003C_003EMODULE;
			}
		}

		
		public static Kind EXPORTS
		{
			
			get
			{
				return ___003C_003EEXPORTS;
			}
		}

		
		public static Kind PROVIDES
		{
			
			get
			{
				return ___003C_003EPROVIDES;
			}
		}

		
		public static Kind TRANSITIVE
		{
			
			get
			{
				return ___003C_003ETRANSITIVE;
			}
		}

		
		public static Kind LONG_LITERAL
		{
			
			get
			{
				return ___003C_003ELONG_LITERAL;
			}
		}

		
		public static Kind INTEGER_LITERAL
		{
			
			get
			{
				return ___003C_003EINTEGER_LITERAL;
			}
		}

		
		public static Kind DECIMAL_LITERAL
		{
			
			get
			{
				return ___003C_003EDECIMAL_LITERAL;
			}
		}

		
		public static Kind HEX_LITERAL
		{
			
			get
			{
				return ___003C_003EHEX_LITERAL;
			}
		}

		
		public static Kind OCTAL_LITERAL
		{
			
			get
			{
				return ___003C_003EOCTAL_LITERAL;
			}
		}

		
		public static Kind BINARY_LITERAL
		{
			
			get
			{
				return ___003C_003EBINARY_LITERAL;
			}
		}

		
		public static Kind FLOATING_POINT_LITERAL
		{
			
			get
			{
				return ___003C_003EFLOATING_POINT_LITERAL;
			}
		}

		
		public static Kind DECIMAL_FLOATING_POINT_LITERAL
		{
			
			get
			{
				return ___003C_003EDECIMAL_FLOATING_POINT_LITERAL;
			}
		}

		
		public static Kind DECIMAL_EXPONENT
		{
			
			get
			{
				return ___003C_003EDECIMAL_EXPONENT;
			}
		}

		
		public static Kind HEXADECIMAL_FLOATING_POINT_LITERAL
		{
			
			get
			{
				return ___003C_003EHEXADECIMAL_FLOATING_POINT_LITERAL;
			}
		}

		
		public static Kind HEXADECIMAL_EXPONENT
		{
			
			get
			{
				return ___003C_003EHEXADECIMAL_EXPONENT;
			}
		}

		
		public static Kind HEX_DIGITS
		{
			
			get
			{
				return ___003C_003EHEX_DIGITS;
			}
		}

		
		public static Kind UNICODE_ESCAPE
		{
			
			get
			{
				return ___003C_003EUNICODE_ESCAPE;
			}
		}

		
		public static Kind CHARACTER_LITERAL
		{
			
			get
			{
				return ___003C_003ECHARACTER_LITERAL;
			}
		}

		
		public static Kind STRING_LITERAL
		{
			
			get
			{
				return ___003C_003ESTRING_LITERAL;
			}
		}

		
		public static Kind ENTER_TEXT_BLOCK
		{
			
			get
			{
				return ___003C_003EENTER_TEXT_BLOCK;
			}
		}

		
		public static Kind TEXT_BLOCK_LITERAL
		{
			
			get
			{
				return ___003C_003ETEXT_BLOCK_LITERAL;
			}
		}

		
		public static Kind TEXT_BLOCK_CONTENT
		{
			
			get
			{
				return ___003C_003ETEXT_BLOCK_CONTENT;
			}
		}

		
		public static Kind IDENTIFIER
		{
			
			get
			{
				return ___003C_003EIDENTIFIER;
			}
		}

		
		public static Kind LETTER
		{
			
			get
			{
				return ___003C_003ELETTER;
			}
		}

		
		public static Kind PART_LETTER
		{
			
			get
			{
				return ___003C_003EPART_LETTER;
			}
		}

		
		public static Kind LPAREN
		{
			
			get
			{
				return ___003C_003ELPAREN;
			}
		}

		
		public static Kind RPAREN
		{
			
			get
			{
				return ___003C_003ERPAREN;
			}
		}

		
		public static Kind LBRACE
		{
			
			get
			{
				return ___003C_003ELBRACE;
			}
		}

		
		public static Kind RBRACE
		{
			
			get
			{
				return ___003C_003ERBRACE;
			}
		}

		
		public static Kind LBRACKET
		{
			
			get
			{
				return ___003C_003ELBRACKET;
			}
		}

		
		public static Kind RBRACKET
		{
			
			get
			{
				return ___003C_003ERBRACKET;
			}
		}

		
		public static Kind SEMICOLON
		{
			
			get
			{
				return ___003C_003ESEMICOLON;
			}
		}

		
		public static Kind COMMA
		{
			
			get
			{
				return ___003C_003ECOMMA;
			}
		}

		
		public static Kind DOT
		{
			
			get
			{
				return ___003C_003EDOT;
			}
		}

		
		public static Kind ELLIPSIS
		{
			
			get
			{
				return ___003C_003EELLIPSIS;
			}
		}

		
		public static Kind AT
		{
			
			get
			{
				return ___003C_003EAT;
			}
		}

		
		public static Kind DOUBLECOLON
		{
			
			get
			{
				return ___003C_003EDOUBLECOLON;
			}
		}

		
		public static Kind ASSIGN
		{
			
			get
			{
				return ___003C_003EASSIGN;
			}
		}

		
		public static Kind LT
		{
			
			get
			{
				return ___003C_003ELT;
			}
		}

		
		public static Kind BANG
		{
			
			get
			{
				return ___003C_003EBANG;
			}
		}

		
		public static Kind TILDE
		{
			
			get
			{
				return ___003C_003ETILDE;
			}
		}

		
		public static Kind HOOK
		{
			
			get
			{
				return ___003C_003EHOOK;
			}
		}

		
		public static Kind COLON
		{
			
			get
			{
				return ___003C_003ECOLON;
			}
		}

		
		public static Kind ARROW
		{
			
			get
			{
				return ___003C_003EARROW;
			}
		}

		
		public static Kind EQ
		{
			
			get
			{
				return ___003C_003EEQ;
			}
		}

		
		public static Kind GE
		{
			
			get
			{
				return ___003C_003EGE;
			}
		}

		
		public static Kind LE
		{
			
			get
			{
				return ___003C_003ELE;
			}
		}

		
		public static Kind NE
		{
			
			get
			{
				return ___003C_003ENE;
			}
		}

		
		public static Kind SC_AND
		{
			
			get
			{
				return ___003C_003ESC_AND;
			}
		}

		
		public static Kind SC_OR
		{
			
			get
			{
				return ___003C_003ESC_OR;
			}
		}

		
		public static Kind INCR
		{
			
			get
			{
				return ___003C_003EINCR;
			}
		}

		
		public static Kind DECR
		{
			
			get
			{
				return ___003C_003EDECR;
			}
		}

		
		public static Kind PLUS
		{
			
			get
			{
				return ___003C_003EPLUS;
			}
		}

		
		public static Kind MINUS
		{
			
			get
			{
				return ___003C_003EMINUS;
			}
		}

		
		public static Kind STAR
		{
			
			get
			{
				return ___003C_003ESTAR;
			}
		}

		
		public static Kind SLASH
		{
			
			get
			{
				return ___003C_003ESLASH;
			}
		}

		
		public static Kind BIT_AND
		{
			
			get
			{
				return ___003C_003EBIT_AND;
			}
		}

		
		public static Kind BIT_OR
		{
			
			get
			{
				return ___003C_003EBIT_OR;
			}
		}

		
		public static Kind XOR
		{
			
			get
			{
				return ___003C_003EXOR;
			}
		}

		
		public static Kind REM
		{
			
			get
			{
				return ___003C_003EREM;
			}
		}

		
		public static Kind LSHIFT
		{
			
			get
			{
				return ___003C_003ELSHIFT;
			}
		}

		
		public static Kind PLUSASSIGN
		{
			
			get
			{
				return ___003C_003EPLUSASSIGN;
			}
		}

		
		public static Kind MINUSASSIGN
		{
			
			get
			{
				return ___003C_003EMINUSASSIGN;
			}
		}

		
		public static Kind STARASSIGN
		{
			
			get
			{
				return ___003C_003ESTARASSIGN;
			}
		}

		
		public static Kind SLASHASSIGN
		{
			
			get
			{
				return ___003C_003ESLASHASSIGN;
			}
		}

		
		public static Kind ANDASSIGN
		{
			
			get
			{
				return ___003C_003EANDASSIGN;
			}
		}

		
		public static Kind ORASSIGN
		{
			
			get
			{
				return ___003C_003EORASSIGN;
			}
		}

		
		public static Kind XORASSIGN
		{
			
			get
			{
				return ___003C_003EXORASSIGN;
			}
		}

		
		public static Kind REMASSIGN
		{
			
			get
			{
				return ___003C_003EREMASSIGN;
			}
		}

		
		public static Kind LSHIFTASSIGN
		{
			
			get
			{
				return ___003C_003ELSHIFTASSIGN;
			}
		}

		
		public static Kind RSIGNEDSHIFTASSIGN
		{
			
			get
			{
				return ___003C_003ERSIGNEDSHIFTASSIGN;
			}
		}

		
		public static Kind RUNSIGNEDSHIFTASSIGN
		{
			
			get
			{
				return ___003C_003ERUNSIGNEDSHIFTASSIGN;
			}
		}

		
		public static Kind RUNSIGNEDSHIFT
		{
			
			get
			{
				return ___003C_003ERUNSIGNEDSHIFT;
			}
		}

		
		public static Kind RSIGNEDSHIFT
		{
			
			get
			{
				return ___003C_003ERSIGNEDSHIFT;
			}
		}

		
		public static Kind GT
		{
			
			get
			{
				return ___003C_003EGT;
			}
		}

		
		public static Kind CTRL_Z
		{
			
			get
			{
				return ___003C_003ECTRL_Z;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		public virtual int getKind()
		{
			return kind;
		}

		
				
		
		private Kind(string _0024enum_0024name, int _0024enum_0024ordinal, int kind)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.kind = kind;
			GC.KeepAlive(this);
		}

		
		
		public static Kind[] values()
		{
			return (Kind[])_0024VALUES.Clone();
		}

		
		
		
		public static Kind valueOf(string name)
		{
			return (Kind)java.lang.Enum.valueOf(ClassLiteral<Kind>.Value, name);
		}

		
		
		
		public static Kind valueOf(int kind)
		{
			switch (kind)
			{
			case 147:
				return ___003C_003ECTRL_Z;
			case 146:
				return ___003C_003EGT;
			case 145:
				return ___003C_003ERSIGNEDSHIFT;
			case 144:
				return ___003C_003ERUNSIGNEDSHIFT;
			case 143:
				return ___003C_003ERUNSIGNEDSHIFTASSIGN;
			case 142:
				return ___003C_003ERSIGNEDSHIFTASSIGN;
			case 141:
				return ___003C_003ELSHIFTASSIGN;
			case 140:
				return ___003C_003EREMASSIGN;
			case 139:
				return ___003C_003EXORASSIGN;
			case 138:
				return ___003C_003EORASSIGN;
			case 137:
				return ___003C_003EANDASSIGN;
			case 136:
				return ___003C_003ESLASHASSIGN;
			case 135:
				return ___003C_003ESTARASSIGN;
			case 134:
				return ___003C_003EMINUSASSIGN;
			case 133:
				return ___003C_003EPLUSASSIGN;
			case 132:
				return ___003C_003ELSHIFT;
			case 131:
				return ___003C_003EREM;
			case 130:
				return ___003C_003EXOR;
			case 129:
				return ___003C_003EBIT_OR;
			case 128:
				return ___003C_003EBIT_AND;
			case 127:
				return ___003C_003ESLASH;
			case 126:
				return ___003C_003ESTAR;
			case 125:
				return ___003C_003EMINUS;
			case 124:
				return ___003C_003EPLUS;
			case 123:
				return ___003C_003EDECR;
			case 122:
				return ___003C_003EINCR;
			case 121:
				return ___003C_003ESC_OR;
			case 120:
				return ___003C_003ESC_AND;
			case 119:
				return ___003C_003ENE;
			case 118:
				return ___003C_003ELE;
			case 117:
				return ___003C_003EGE;
			case 116:
				return ___003C_003EEQ;
			case 115:
				return ___003C_003EARROW;
			case 114:
				return ___003C_003ECOLON;
			case 113:
				return ___003C_003EHOOK;
			case 112:
				return ___003C_003ETILDE;
			case 111:
				return ___003C_003EBANG;
			case 110:
				return ___003C_003ELT;
			case 109:
				return ___003C_003EASSIGN;
			case 108:
				return ___003C_003EDOUBLECOLON;
			case 107:
				return ___003C_003EAT;
			case 106:
				return ___003C_003EELLIPSIS;
			case 105:
				return ___003C_003EDOT;
			case 104:
				return ___003C_003ECOMMA;
			case 103:
				return ___003C_003ESEMICOLON;
			case 102:
				return ___003C_003ERBRACKET;
			case 101:
				return ___003C_003ELBRACKET;
			case 100:
				return ___003C_003ERBRACE;
			case 99:
				return ___003C_003ELBRACE;
			case 98:
				return ___003C_003ERPAREN;
			case 97:
				return ___003C_003ELPAREN;
			case 96:
				return ___003C_003EPART_LETTER;
			case 95:
				return ___003C_003ELETTER;
			case 94:
				return ___003C_003EIDENTIFIER;
			case 93:
				return ___003C_003ETEXT_BLOCK_CONTENT;
			case 92:
				return ___003C_003ETEXT_BLOCK_LITERAL;
			case 91:
				return ___003C_003EENTER_TEXT_BLOCK;
			case 90:
				return ___003C_003ESTRING_LITERAL;
			case 89:
				return ___003C_003ECHARACTER_LITERAL;
			case 88:
				return ___003C_003EUNICODE_ESCAPE;
			case 87:
				return ___003C_003EHEX_DIGITS;
			case 86:
				return ___003C_003EHEXADECIMAL_EXPONENT;
			case 85:
				return ___003C_003EHEXADECIMAL_FLOATING_POINT_LITERAL;
			case 84:
				return ___003C_003EDECIMAL_EXPONENT;
			case 83:
				return ___003C_003EDECIMAL_FLOATING_POINT_LITERAL;
			case 82:
				return ___003C_003EFLOATING_POINT_LITERAL;
			case 81:
				return ___003C_003EBINARY_LITERAL;
			case 80:
				return ___003C_003EOCTAL_LITERAL;
			case 79:
				return ___003C_003EHEX_LITERAL;
			case 78:
				return ___003C_003EDECIMAL_LITERAL;
			case 77:
				return ___003C_003EINTEGER_LITERAL;
			case 76:
				return ___003C_003ELONG_LITERAL;
			case 75:
				return ___003C_003ETRANSITIVE;
			case 74:
				return ___003C_003EPROVIDES;
			case 73:
				return ___003C_003EEXPORTS;
			case 72:
				return ___003C_003EMODULE;
			case 71:
				return ___003C_003EUSES;
			case 70:
				return ___003C_003EOPENS;
			case 69:
				return ___003C_003EOPEN;
			case 68:
				return ___003C_003EWITH;
			case 67:
				return ___003C_003ETO;
			case 66:
				return ___003C_003EREQUIRES;
			case 65:
				return ___003C_003EYIELD;
			case 64:
				return ___003C_003EWHILE;
			case 63:
				return ___003C_003EVOLATILE;
			case 62:
				return ___003C_003EVOID;
			case 61:
				return ___003C_003ETRY;
			case 60:
				return ___003C_003ETRUE;
			case 59:
				return ___003C_003ETRANSIENT;
			case 58:
				return ___003C_003ETHROWS;
			case 57:
				return ___003C_003ETHROW;
			case 56:
				return ___003C_003ETHIS;
			case 55:
				return ___003C_003ESYNCHRONIZED;
			case 54:
				return ___003C_003ESWITCH;
			case 53:
				return ___003C_003ESUPER;
			case 52:
				return ___003C_003ESTRICTFP;
			case 51:
				return ___003C_003ESTATIC;
			case 50:
				return ___003C_003ESHORT;
			case 49:
				return ___003C_003ERETURN;
			case 48:
				return ___003C_003ERECORD;
			case 47:
				return ___003C_003EPUBLIC;
			case 46:
				return ___003C_003EPROTECTED;
			case 45:
				return ___003C_003EPRIVATE;
			case 44:
				return ___003C_003EPACKAGE;
			case 43:
				return ___003C_003ENULL;
			case 42:
				return ___003C_003ENEW;
			case 41:
				return ___003C_003ENATIVE;
			case 40:
				return ___003C_003ELONG;
			case 39:
				return ___003C_003EINTERFACE;
			case 38:
				return ___003C_003EINT;
			case 37:
				return ___003C_003EINSTANCEOF;
			case 36:
				return ___003C_003EIMPORT;
			case 35:
				return ___003C_003EIMPLEMENTS;
			case 34:
				return ___003C_003EIF;
			case 33:
				return ___003C_003EGOTO;
			case 32:
				return ___003C_003EFOR;
			case 31:
				return ___003C_003EFLOAT;
			case 30:
				return ___003C_003EFINALLY;
			case 29:
				return ___003C_003EFINAL;
			case 28:
				return ___003C_003EFALSE;
			case 27:
				return ___003C_003EEXTENDS;
			case 26:
				return ___003C_003EENUM;
			case 25:
				return ___003C_003EELSE;
			case 24:
				return ___003C_003EDOUBLE;
			case 23:
				return ___003C_003EDO;
			case 22:
				return ___003C_003E_DEFAULT;
			case 21:
				return ___003C_003ECONTINUE;
			case 20:
				return ___003C_003ECONST;
			case 19:
				return ___003C_003ECLASS;
			case 18:
				return ___003C_003ECHAR;
			case 17:
				return ___003C_003ECATCH;
			case 16:
				return ___003C_003ECASE;
			case 15:
				return ___003C_003EBYTE;
			case 14:
				return ___003C_003EBREAK;
			case 13:
				return ___003C_003EBOOLEAN;
			case 12:
				return ___003C_003EASSERT;
			case 11:
				return ___003C_003EABSTRACT;
			case 10:
				return ___003C_003ECOMMENT_CONTENT;
			case 9:
				return ___003C_003EMULTI_LINE_COMMENT;
			case 8:
				return ___003C_003EJAVADOC_COMMENT;
			case 7:
				return ___003C_003EENTER_MULTILINE_COMMENT;
			case 6:
				return ___003C_003EENTER_JAVADOC_COMMENT;
			case 5:
				return ___003C_003ESINGLE_LINE_COMMENT;
			case 4:
				return ___003C_003EOLD_MAC_EOL;
			case 3:
				return ___003C_003EUNIX_EOL;
			case 2:
				return ___003C_003EWINDOWS_EOL;
			case 1:
				return ___003C_003ESPACE;
			case 0:
				return ___003C_003EEOF;
			default:
			{
				string s = CodeGenerationUtils.f("Token kind %i is unknown.", Integer.valueOf(kind));
				
				throw new IllegalArgumentException(s);
			}
			}
		}

		public virtual bool isPrimitive()
		{
			return (this == ___003C_003EBYTE || this == ___003C_003ECHAR || this == ___003C_003ESHORT || this == ___003C_003EINT || this == ___003C_003ELONG || this == ___003C_003EFLOAT || this == ___003C_003EDOUBLE) ? true : false;
		}

		
		static Kind()
		{
			___003C_003EEOF = new Kind("EOF", 0, 0);
			___003C_003ESPACE = new Kind("SPACE", 1, 1);
			___003C_003EWINDOWS_EOL = new Kind("WINDOWS_EOL", 2, 2);
			___003C_003EUNIX_EOL = new Kind("UNIX_EOL", 3, 3);
			___003C_003EOLD_MAC_EOL = new Kind("OLD_MAC_EOL", 4, 4);
			___003C_003ESINGLE_LINE_COMMENT = new Kind("SINGLE_LINE_COMMENT", 5, 5);
			___003C_003EENTER_JAVADOC_COMMENT = new Kind("ENTER_JAVADOC_COMMENT", 6, 6);
			___003C_003EENTER_MULTILINE_COMMENT = new Kind("ENTER_MULTILINE_COMMENT", 7, 7);
			___003C_003EJAVADOC_COMMENT = new Kind("JAVADOC_COMMENT", 8, 8);
			___003C_003EMULTI_LINE_COMMENT = new Kind("MULTI_LINE_COMMENT", 9, 9);
			___003C_003ECOMMENT_CONTENT = new Kind("COMMENT_CONTENT", 10, 10);
			___003C_003EABSTRACT = new Kind("ABSTRACT", 11, 11);
			___003C_003EASSERT = new Kind("ASSERT", 12, 12);
			___003C_003EBOOLEAN = new Kind("BOOLEAN", 13, 13);
			___003C_003EBREAK = new Kind("BREAK", 14, 14);
			___003C_003EBYTE = new Kind("BYTE", 15, 15);
			___003C_003ECASE = new Kind("CASE", 16, 16);
			___003C_003ECATCH = new Kind("CATCH", 17, 17);
			___003C_003ECHAR = new Kind("CHAR", 18, 18);
			___003C_003ECLASS = new Kind("CLASS", 19, 19);
			___003C_003ECONST = new Kind("CONST", 20, 20);
			___003C_003ECONTINUE = new Kind("CONTINUE", 21, 21);
			___003C_003E_DEFAULT = new Kind("_DEFAULT", 22, 22);
			___003C_003EDO = new Kind("DO", 23, 23);
			___003C_003EDOUBLE = new Kind("DOUBLE", 24, 24);
			___003C_003EELSE = new Kind("ELSE", 25, 25);
			___003C_003EENUM = new Kind("ENUM", 26, 26);
			___003C_003EEXTENDS = new Kind("EXTENDS", 27, 27);
			___003C_003EFALSE = new Kind("FALSE", 28, 28);
			___003C_003EFINAL = new Kind("FINAL", 29, 29);
			___003C_003EFINALLY = new Kind("FINALLY", 30, 30);
			___003C_003EFLOAT = new Kind("FLOAT", 31, 31);
			___003C_003EFOR = new Kind("FOR", 32, 32);
			___003C_003EGOTO = new Kind("GOTO", 33, 33);
			___003C_003EIF = new Kind("IF", 34, 34);
			___003C_003EIMPLEMENTS = new Kind("IMPLEMENTS", 35, 35);
			___003C_003EIMPORT = new Kind("IMPORT", 36, 36);
			___003C_003EINSTANCEOF = new Kind("INSTANCEOF", 37, 37);
			___003C_003EINT = new Kind("INT", 38, 38);
			___003C_003EINTERFACE = new Kind("INTERFACE", 39, 39);
			___003C_003ELONG = new Kind("LONG", 40, 40);
			___003C_003ENATIVE = new Kind("NATIVE", 41, 41);
			___003C_003ENEW = new Kind("NEW", 42, 42);
			___003C_003ENULL = new Kind("NULL", 43, 43);
			___003C_003EPACKAGE = new Kind("PACKAGE", 44, 44);
			___003C_003EPRIVATE = new Kind("PRIVATE", 45, 45);
			___003C_003EPROTECTED = new Kind("PROTECTED", 46, 46);
			___003C_003EPUBLIC = new Kind("PUBLIC", 47, 47);
			___003C_003ERECORD = new Kind("RECORD", 48, 48);
			___003C_003ERETURN = new Kind("RETURN", 49, 49);
			___003C_003ESHORT = new Kind("SHORT", 50, 50);
			___003C_003ESTATIC = new Kind("STATIC", 51, 51);
			___003C_003ESTRICTFP = new Kind("STRICTFP", 52, 52);
			___003C_003ESUPER = new Kind("SUPER", 53, 53);
			___003C_003ESWITCH = new Kind("SWITCH", 54, 54);
			___003C_003ESYNCHRONIZED = new Kind("SYNCHRONIZED", 55, 55);
			___003C_003ETHIS = new Kind("THIS", 56, 56);
			___003C_003ETHROW = new Kind("THROW", 57, 57);
			___003C_003ETHROWS = new Kind("THROWS", 58, 58);
			___003C_003ETRANSIENT = new Kind("TRANSIENT", 59, 59);
			___003C_003ETRUE = new Kind("TRUE", 60, 60);
			___003C_003ETRY = new Kind("TRY", 61, 61);
			___003C_003EVOID = new Kind("VOID", 62, 62);
			___003C_003EVOLATILE = new Kind("VOLATILE", 63, 63);
			___003C_003EWHILE = new Kind("WHILE", 64, 64);
			___003C_003EYIELD = new Kind("YIELD", 65, 65);
			___003C_003EREQUIRES = new Kind("REQUIRES", 66, 66);
			___003C_003ETO = new Kind("TO", 67, 67);
			___003C_003EWITH = new Kind("WITH", 68, 68);
			___003C_003EOPEN = new Kind("OPEN", 69, 69);
			___003C_003EOPENS = new Kind("OPENS", 70, 70);
			___003C_003EUSES = new Kind("USES", 71, 71);
			___003C_003EMODULE = new Kind("MODULE", 72, 72);
			___003C_003EEXPORTS = new Kind("EXPORTS", 73, 73);
			___003C_003EPROVIDES = new Kind("PROVIDES", 74, 74);
			___003C_003ETRANSITIVE = new Kind("TRANSITIVE", 75, 75);
			___003C_003ELONG_LITERAL = new Kind("LONG_LITERAL", 76, 76);
			___003C_003EINTEGER_LITERAL = new Kind("INTEGER_LITERAL", 77, 77);
			___003C_003EDECIMAL_LITERAL = new Kind("DECIMAL_LITERAL", 78, 78);
			___003C_003EHEX_LITERAL = new Kind("HEX_LITERAL", 79, 79);
			___003C_003EOCTAL_LITERAL = new Kind("OCTAL_LITERAL", 80, 80);
			___003C_003EBINARY_LITERAL = new Kind("BINARY_LITERAL", 81, 81);
			___003C_003EFLOATING_POINT_LITERAL = new Kind("FLOATING_POINT_LITERAL", 82, 82);
			___003C_003EDECIMAL_FLOATING_POINT_LITERAL = new Kind("DECIMAL_FLOATING_POINT_LITERAL", 83, 83);
			___003C_003EDECIMAL_EXPONENT = new Kind("DECIMAL_EXPONENT", 84, 84);
			___003C_003EHEXADECIMAL_FLOATING_POINT_LITERAL = new Kind("HEXADECIMAL_FLOATING_POINT_LITERAL", 85, 85);
			___003C_003EHEXADECIMAL_EXPONENT = new Kind("HEXADECIMAL_EXPONENT", 86, 86);
			___003C_003EHEX_DIGITS = new Kind("HEX_DIGITS", 87, 87);
			___003C_003EUNICODE_ESCAPE = new Kind("UNICODE_ESCAPE", 88, 88);
			___003C_003ECHARACTER_LITERAL = new Kind("CHARACTER_LITERAL", 89, 89);
			___003C_003ESTRING_LITERAL = new Kind("STRING_LITERAL", 90, 90);
			___003C_003EENTER_TEXT_BLOCK = new Kind("ENTER_TEXT_BLOCK", 91, 91);
			___003C_003ETEXT_BLOCK_LITERAL = new Kind("TEXT_BLOCK_LITERAL", 92, 92);
			___003C_003ETEXT_BLOCK_CONTENT = new Kind("TEXT_BLOCK_CONTENT", 93, 93);
			___003C_003EIDENTIFIER = new Kind("IDENTIFIER", 94, 94);
			___003C_003ELETTER = new Kind("LETTER", 95, 95);
			___003C_003EPART_LETTER = new Kind("PART_LETTER", 96, 96);
			___003C_003ELPAREN = new Kind("LPAREN", 97, 97);
			___003C_003ERPAREN = new Kind("RPAREN", 98, 98);
			___003C_003ELBRACE = new Kind("LBRACE", 99, 99);
			___003C_003ERBRACE = new Kind("RBRACE", 100, 100);
			___003C_003ELBRACKET = new Kind("LBRACKET", 101, 101);
			___003C_003ERBRACKET = new Kind("RBRACKET", 102, 102);
			___003C_003ESEMICOLON = new Kind("SEMICOLON", 103, 103);
			___003C_003ECOMMA = new Kind("COMMA", 104, 104);
			___003C_003EDOT = new Kind("DOT", 105, 105);
			___003C_003EELLIPSIS = new Kind("ELLIPSIS", 106, 106);
			___003C_003EAT = new Kind("AT", 107, 107);
			___003C_003EDOUBLECOLON = new Kind("DOUBLECOLON", 108, 108);
			___003C_003EASSIGN = new Kind("ASSIGN", 109, 109);
			___003C_003ELT = new Kind("LT", 110, 110);
			___003C_003EBANG = new Kind("BANG", 111, 111);
			___003C_003ETILDE = new Kind("TILDE", 112, 112);
			___003C_003EHOOK = new Kind("HOOK", 113, 113);
			___003C_003ECOLON = new Kind("COLON", 114, 114);
			___003C_003EARROW = new Kind("ARROW", 115, 115);
			___003C_003EEQ = new Kind("EQ", 116, 116);
			___003C_003EGE = new Kind("GE", 117, 117);
			___003C_003ELE = new Kind("LE", 118, 118);
			___003C_003ENE = new Kind("NE", 119, 119);
			___003C_003ESC_AND = new Kind("SC_AND", 120, 120);
			___003C_003ESC_OR = new Kind("SC_OR", 121, 121);
			___003C_003EINCR = new Kind("INCR", 122, 122);
			___003C_003EDECR = new Kind("DECR", 123, 123);
			___003C_003EPLUS = new Kind("PLUS", 124, 124);
			___003C_003EMINUS = new Kind("MINUS", 125, 125);
			___003C_003ESTAR = new Kind("STAR", 126, 126);
			___003C_003ESLASH = new Kind("SLASH", 127, 127);
			___003C_003EBIT_AND = new Kind("BIT_AND", 128, 128);
			___003C_003EBIT_OR = new Kind("BIT_OR", 129, 129);
			___003C_003EXOR = new Kind("XOR", 130, 130);
			___003C_003EREM = new Kind("REM", 131, 131);
			___003C_003ELSHIFT = new Kind("LSHIFT", 132, 132);
			___003C_003EPLUSASSIGN = new Kind("PLUSASSIGN", 133, 133);
			___003C_003EMINUSASSIGN = new Kind("MINUSASSIGN", 134, 134);
			___003C_003ESTARASSIGN = new Kind("STARASSIGN", 135, 135);
			___003C_003ESLASHASSIGN = new Kind("SLASHASSIGN", 136, 136);
			___003C_003EANDASSIGN = new Kind("ANDASSIGN", 137, 137);
			___003C_003EORASSIGN = new Kind("ORASSIGN", 138, 138);
			___003C_003EXORASSIGN = new Kind("XORASSIGN", 139, 139);
			___003C_003EREMASSIGN = new Kind("REMASSIGN", 140, 140);
			___003C_003ELSHIFTASSIGN = new Kind("LSHIFTASSIGN", 141, 141);
			___003C_003ERSIGNEDSHIFTASSIGN = new Kind("RSIGNEDSHIFTASSIGN", 142, 142);
			___003C_003ERUNSIGNEDSHIFTASSIGN = new Kind("RUNSIGNEDSHIFTASSIGN", 143, 143);
			___003C_003ERUNSIGNEDSHIFT = new Kind("RUNSIGNEDSHIFT", 144, 144);
			___003C_003ERSIGNEDSHIFT = new Kind("RSIGNEDSHIFT", 145, 145);
			___003C_003EGT = new Kind("GT", 146, 146);
			___003C_003ECTRL_Z = new Kind("CTRL_Z", 147, 147);
			_0024VALUES = new Kind[148]
			{
				___003C_003EEOF, ___003C_003ESPACE, ___003C_003EWINDOWS_EOL, ___003C_003EUNIX_EOL, ___003C_003EOLD_MAC_EOL, ___003C_003ESINGLE_LINE_COMMENT, ___003C_003EENTER_JAVADOC_COMMENT, ___003C_003EENTER_MULTILINE_COMMENT, ___003C_003EJAVADOC_COMMENT, ___003C_003EMULTI_LINE_COMMENT,
				___003C_003ECOMMENT_CONTENT, ___003C_003EABSTRACT, ___003C_003EASSERT, ___003C_003EBOOLEAN, ___003C_003EBREAK, ___003C_003EBYTE, ___003C_003ECASE, ___003C_003ECATCH, ___003C_003ECHAR, ___003C_003ECLASS,
				___003C_003ECONST, ___003C_003ECONTINUE, ___003C_003E_DEFAULT, ___003C_003EDO, ___003C_003EDOUBLE, ___003C_003EELSE, ___003C_003EENUM, ___003C_003EEXTENDS, ___003C_003EFALSE, ___003C_003EFINAL,
				___003C_003EFINALLY, ___003C_003EFLOAT, ___003C_003EFOR, ___003C_003EGOTO, ___003C_003EIF, ___003C_003EIMPLEMENTS, ___003C_003EIMPORT, ___003C_003EINSTANCEOF, ___003C_003EINT, ___003C_003EINTERFACE,
				___003C_003ELONG, ___003C_003ENATIVE, ___003C_003ENEW, ___003C_003ENULL, ___003C_003EPACKAGE, ___003C_003EPRIVATE, ___003C_003EPROTECTED, ___003C_003EPUBLIC, ___003C_003ERECORD, ___003C_003ERETURN,
				___003C_003ESHORT, ___003C_003ESTATIC, ___003C_003ESTRICTFP, ___003C_003ESUPER, ___003C_003ESWITCH, ___003C_003ESYNCHRONIZED, ___003C_003ETHIS, ___003C_003ETHROW, ___003C_003ETHROWS, ___003C_003ETRANSIENT,
				___003C_003ETRUE, ___003C_003ETRY, ___003C_003EVOID, ___003C_003EVOLATILE, ___003C_003EWHILE, ___003C_003EYIELD, ___003C_003EREQUIRES, ___003C_003ETO, ___003C_003EWITH, ___003C_003EOPEN,
				___003C_003EOPENS, ___003C_003EUSES, ___003C_003EMODULE, ___003C_003EEXPORTS, ___003C_003EPROVIDES, ___003C_003ETRANSITIVE, ___003C_003ELONG_LITERAL, ___003C_003EINTEGER_LITERAL, ___003C_003EDECIMAL_LITERAL, ___003C_003EHEX_LITERAL,
				___003C_003EOCTAL_LITERAL, ___003C_003EBINARY_LITERAL, ___003C_003EFLOATING_POINT_LITERAL, ___003C_003EDECIMAL_FLOATING_POINT_LITERAL, ___003C_003EDECIMAL_EXPONENT, ___003C_003EHEXADECIMAL_FLOATING_POINT_LITERAL, ___003C_003EHEXADECIMAL_EXPONENT, ___003C_003EHEX_DIGITS, ___003C_003EUNICODE_ESCAPE, ___003C_003ECHARACTER_LITERAL,
				___003C_003ESTRING_LITERAL, ___003C_003EENTER_TEXT_BLOCK, ___003C_003ETEXT_BLOCK_LITERAL, ___003C_003ETEXT_BLOCK_CONTENT, ___003C_003EIDENTIFIER, ___003C_003ELETTER, ___003C_003EPART_LETTER, ___003C_003ELPAREN, ___003C_003ERPAREN, ___003C_003ELBRACE,
				___003C_003ERBRACE, ___003C_003ELBRACKET, ___003C_003ERBRACKET, ___003C_003ESEMICOLON, ___003C_003ECOMMA, ___003C_003EDOT, ___003C_003EELLIPSIS, ___003C_003EAT, ___003C_003EDOUBLECOLON, ___003C_003EASSIGN,
				___003C_003ELT, ___003C_003EBANG, ___003C_003ETILDE, ___003C_003EHOOK, ___003C_003ECOLON, ___003C_003EARROW, ___003C_003EEQ, ___003C_003EGE, ___003C_003ELE, ___003C_003ENE,
				___003C_003ESC_AND, ___003C_003ESC_OR, ___003C_003EINCR, ___003C_003EDECR, ___003C_003EPLUS, ___003C_003EMINUS, ___003C_003ESTAR, ___003C_003ESLASH, ___003C_003EBIT_AND, ___003C_003EBIT_OR,
				___003C_003EXOR, ___003C_003EREM, ___003C_003ELSHIFT, ___003C_003EPLUSASSIGN, ___003C_003EMINUSASSIGN, ___003C_003ESTARASSIGN, ___003C_003ESLASHASSIGN, ___003C_003EANDASSIGN, ___003C_003EORASSIGN, ___003C_003EXORASSIGN,
				___003C_003EREMASSIGN, ___003C_003ELSHIFTASSIGN, ___003C_003ERSIGNEDSHIFTASSIGN, ___003C_003ERUNSIGNEDSHIFTASSIGN, ___003C_003ERUNSIGNEDSHIFT, ___003C_003ERSIGNEDSHIFT, ___003C_003EGT, ___003C_003ECTRL_Z
			};
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			string result = ((Range)P_0).ToString();
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon1(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024insert_00240(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon2(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024insertAfter_00241(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly Optional arg_00241;

		internal ___003C_003EAnon3(Optional P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024deleteToken_00242(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly Optional arg_00241;

		internal ___003C_003EAnon4(Optional P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024deleteToken_00243(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon5(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024replaceToken_00244(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon6(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024replaceToken_00245(arg_00241, (JavaToken)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	internal static JavaToken ___003C_003EINVALID;

	private Range range;

	private int kind;

	private string text;

	private JavaToken previousToken;

	private JavaToken nextToken;

	
	public static JavaToken INVALID
	{
		
		get
		{
			return ___003C_003EINVALID;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual bool hasRange()
	{
		bool result = getRange().isPresent();
		
		return result;
	}

	
		
	public virtual Optional getRange()
	{
		Optional result = Optional.ofNullable(range);
		
		return result;
	}

	public virtual int getKind()
	{
		return kind;
	}

	public virtual string getText()
	{
		return text;
	}

	
	public virtual void setRange(Range range)
	{
		this.range = range;
	}

	
	
	public virtual Category getCategory()
	{
		Category category = TokenTypes.getCategory(kind);
		
		return category;
	}

	
	
	public virtual bool valid()
	{
		return (!invalid()) ? true : false;
	}

	public virtual bool invalid()
	{
		return this == ___003C_003EINVALID;
	}

	
	internal virtual void setKind(int kind)
	{
		this.kind = kind;
	}

	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		JavaToken javaToken = (JavaToken)o;
		if (kind != javaToken.kind)
		{
			return false;
		}
		if (!java.lang.String.instancehelper_equals(text, javaToken.text))
		{
			return false;
		}
		return true;
	}

	
		
	
	internal JavaToken(Token token, List tokens)
	{
		previousToken = null;
		nextToken = null;
		Range range = Range.range(token.beginLine, token.beginColumn, token.endLine, token.endColumn);
		string text = token.image;
		if (token.kind == 146)
		{
			range = Range.range(token.beginLine, token.beginColumn, token.endLine, token.beginColumn);
			text = ">";
		}
		else if (token.kind == 145)
		{
			range = Range.range(token.beginLine, token.beginColumn, token.endLine, token.beginColumn + 1);
			text = ">>";
		}
		this.range = range;
		kind = token.kind;
		this.text = text;
		if (!tokens.isEmpty())
		{
			(previousToken = (JavaToken)tokens.get(tokens.size() - 1)).nextToken = this;
		}
		else
		{
			previousToken = null;
		}
	}

	
	
	
	public JavaToken(Range range, int kind, string text, JavaToken previousToken, JavaToken nextToken)
	{
		this.previousToken = null;
		this.nextToken = null;
		Utils.assertNotNull(text);
		this.range = range;
		this.kind = kind;
		this.text = text;
		this.previousToken = previousToken;
		this.nextToken = nextToken;
	}

	
	
	public virtual JavaToken findFirstToken()
	{
		JavaToken javaToken = this;
		while (javaToken.getPreviousToken().isPresent())
		{
			javaToken = (JavaToken)javaToken.getPreviousToken().get();
		}
		return javaToken;
	}

	
	
	public virtual JavaToken findLastToken()
	{
		JavaToken javaToken = this;
		while (javaToken.getNextToken().isPresent())
		{
			javaToken = (JavaToken)javaToken.getNextToken().get();
		}
		return javaToken;
	}

	
		
	public virtual Optional getPreviousToken()
	{
		Optional result = Optional.ofNullable(previousToken);
		
		return result;
	}

	
		
	public virtual Optional getNextToken()
	{
		Optional result = Optional.ofNullable(nextToken);
		
		return result;
	}

	
	
	private JavaToken()
		: this(null, 0, "INVALID", null, null)
	{
	}

	
	
	
	private static void lambda_0024insert_00240(JavaToken newToken, JavaToken p)
	{
		p.nextToken = newToken;
		newToken.previousToken = p;
	}

	
	
	
	private static void lambda_0024insertAfter_00241(JavaToken newToken, JavaToken n)
	{
		n.previousToken = newToken;
		newToken.nextToken = n;
	}

	
	
	
	
	private static void lambda_0024deleteToken_00242(Optional nextToken, JavaToken p)
	{
		p.nextToken = (JavaToken)nextToken.orElse(null);
	}

	
	
	
	
	private static void lambda_0024deleteToken_00243(Optional previousToken, JavaToken n)
	{
		n.previousToken = (JavaToken)previousToken.orElse(null);
	}

	
	
	
	private static void lambda_0024replaceToken_00244(JavaToken newToken, JavaToken p)
	{
		p.nextToken = newToken;
		newToken.previousToken = p;
	}

	
	
	
	private static void lambda_0024replaceToken_00245(JavaToken newToken, JavaToken n)
	{
		n.previousToken = newToken;
		newToken.nextToken = n;
	}

	
	
	
	public JavaToken(int kind, string text)
		: this(null, kind, text, null, null)
	{
	}

	
	
	
	public JavaToken(int kind)
	{
		previousToken = null;
		nextToken = null;
		string @this = GeneratedJavaParserConstants.tokenImage[kind];
		if (java.lang.String.instancehelper_startsWith(@this, "\""))
		{
			@this = java.lang.String.instancehelper_substring(@this, 1, java.lang.String.instancehelper_length(@this) - 1);
		}
		if (TokenTypes.isEndOfLineToken(kind))
		{
			@this = Utils.___003C_003ESYSTEM_EOL;
		}
		else if (TokenTypes.isWhitespace(kind))
		{
			@this = " ";
		}
		this.kind = kind;
		text = @this;
	}

	
	public virtual void setText(string text)
	{
		this.text = text;
	}

	public virtual string asString()
	{
		return text;
	}

	
	
	public virtual TokenRange toTokenRange()
	{
		TokenRange.___003Cclinit_003E();
		TokenRange result = new TokenRange(findFirstToken(), findLastToken());
		
		return result;
	}

	
	
	public override string ToString()
	{
		string @this = getText();
		object __003Cref_003E = "\\n";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "\n");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string this2 = java.lang.String.instancehelper_replace(@this, target, charSequence);
		obj = "\\r";
		__003Cref_003E = (charSequence.___003Cref_003E = "\r");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string this3 = java.lang.String.instancehelper_replace(this2, target2, charSequence);
		__003Cref_003E = "\\r\\n";
		obj = (charSequence.___003Cref_003E = "\r\n");
		CharSequence target3 = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string this4 = java.lang.String.instancehelper_replace(this3, target3, charSequence);
		obj = "\\t";
		__003Cref_003E = (charSequence.___003Cref_003E = "\t");
		CharSequence target4 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string text = java.lang.String.instancehelper_replace(this4, target4, charSequence);
		string result = CodeGenerationUtils.f("\"%s\"   <%s>   %s", text, Integer.valueOf(getKind()), getRange().map(new ___003C_003EAnon0()).orElse("(?)-(?)"));
		
		return result;
	}

	
	
	
	public virtual void insert(JavaToken newToken)
	{
		Utils.assertNotNull(newToken);
		getPreviousToken().ifPresent(new ___003C_003EAnon1(newToken));
		previousToken = newToken;
		newToken.nextToken = this;
	}

	
	
	
	public virtual void insertAfter(JavaToken newToken)
	{
		Utils.assertNotNull(newToken);
		getNextToken().ifPresent(new ___003C_003EAnon2(newToken));
		nextToken = newToken;
		newToken.previousToken = this;
	}

	
	
	public virtual void deleteToken()
	{
		Optional optional = getNextToken();
		Optional optional2 = getPreviousToken();
		optional2.ifPresent(new ___003C_003EAnon3(optional));
		optional.ifPresent(new ___003C_003EAnon4(optional2));
	}

	
	
	
	public virtual void replaceToken(JavaToken newToken)
	{
		Utils.assertNotNull(newToken);
		getPreviousToken().ifPresent(new ___003C_003EAnon5(newToken));
		getNextToken().ifPresent(new ___003C_003EAnon6(newToken));
	}

	
	
	public override int GetHashCode()
	{
		int num = kind;
		return 31 * num + java.lang.String.instancehelper_hashCode(text);
	}

	
	static JavaToken()
	{
		___003C_003EINVALID = new JavaToken();
	}
}
