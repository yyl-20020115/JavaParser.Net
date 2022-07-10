using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javassist.compiler;

public interface TokenId
{
	[HideFromJava]
	public static class __Fields
	{
		public const int ABSTRACT = 300;

		public const int BOOLEAN = 301;

		public const int BREAK = 302;

		public const int BYTE = 303;

		public const int CASE = 304;

		public const int CATCH = 305;

		public const int CHAR = 306;

		public const int CLASS = 307;

		public const int CONST = 308;

		public const int CONTINUE = 309;

		public const int DEFAULT = 310;

		public const int DO = 311;

		public const int DOUBLE = 312;

		public const int ELSE = 313;

		public const int EXTENDS = 314;

		public const int FINAL = 315;

		public const int FINALLY = 316;

		public const int FLOAT = 317;

		public const int FOR = 318;

		public const int GOTO = 319;

		public const int IF = 320;

		public const int IMPLEMENTS = 321;

		public const int IMPORT = 322;

		public const int INSTANCEOF = 323;

		public const int INT = 324;

		public const int INTERFACE = 325;

		public const int LONG = 326;

		public const int NATIVE = 327;

		public const int NEW = 328;

		public const int PACKAGE = 329;

		public const int PRIVATE = 330;

		public const int PROTECTED = 331;

		public const int PUBLIC = 332;

		public const int RETURN = 333;

		public const int SHORT = 334;

		public const int STATIC = 335;

		public const int SUPER = 336;

		public const int SWITCH = 337;

		public const int SYNCHRONIZED = 338;

		public const int THIS = 339;

		public const int THROW = 340;

		public const int THROWS = 341;

		public const int TRANSIENT = 342;

		public const int TRY = 343;

		public const int VOID = 344;

		public const int VOLATILE = 345;

		public const int WHILE = 346;

		public const int STRICT = 347;

		public const int NEQ = 350;

		public const int MOD_E = 351;

		public const int AND_E = 352;

		public const int MUL_E = 353;

		public const int PLUS_E = 354;

		public const int MINUS_E = 355;

		public const int DIV_E = 356;

		public const int LE = 357;

		public const int EQ = 358;

		public const int GE = 359;

		public const int EXOR_E = 360;

		public const int OR_E = 361;

		public const int PLUSPLUS = 362;

		public const int MINUSMINUS = 363;

		public const int LSHIFT = 364;

		public const int LSHIFT_E = 365;

		public const int RSHIFT = 366;

		public const int RSHIFT_E = 367;

		public const int OROR = 368;

		public const int ANDAND = 369;

		public const int ARSHIFT = 370;

		public const int ARSHIFT_E = 371;

		public static readonly string[] opNames;

		public static readonly int[] assignOps;

		public const int Identifier = 400;

		public const int CharConstant = 401;

		public const int IntConstant = 402;

		public const int LongConstant = 403;

		public const int FloatConstant = 404;

		public const int DoubleConstant = 405;

		public const int StringL = 406;

		public const int TRUE = 410;

		public const int FALSE = 411;

		public const int NULL = 412;

		public const int CALL = 67;

		public const int ARRAY = 65;

		public const int MEMBER = 35;

		public const int EXPR = 69;

		public const int LABEL = 76;

		public const int BLOCK = 66;

		public const int DECL = 68;

		public const int BadToken = 500;

		static __Fields()
		{
			opNames = TokenId.opNames;
			assignOps = TokenId.assignOps;
		}
	}

	const int ABSTRACT = 300;

	const int BOOLEAN = 301;

	const int BREAK = 302;

	const int BYTE = 303;

	const int CASE = 304;

	const int CATCH = 305;

	const int CHAR = 306;

	const int CLASS = 307;

	const int CONST = 308;

	const int CONTINUE = 309;

	const int DEFAULT = 310;

	const int DO = 311;

	const int DOUBLE = 312;

	const int ELSE = 313;

	const int EXTENDS = 314;

	const int FINAL = 315;

	const int FINALLY = 316;

	const int FLOAT = 317;

	const int FOR = 318;

	const int GOTO = 319;

	const int IF = 320;

	const int IMPLEMENTS = 321;

	const int IMPORT = 322;

	const int INSTANCEOF = 323;

	const int INT = 324;

	const int INTERFACE = 325;

	const int LONG = 326;

	const int NATIVE = 327;

	const int NEW = 328;

	const int PACKAGE = 329;

	const int PRIVATE = 330;

	const int PROTECTED = 331;

	const int PUBLIC = 332;

	const int RETURN = 333;

	const int SHORT = 334;

	const int STATIC = 335;

	const int SUPER = 336;

	const int SWITCH = 337;

	const int SYNCHRONIZED = 338;

	const int THIS = 339;

	const int THROW = 340;

	const int THROWS = 341;

	const int TRANSIENT = 342;

	const int TRY = 343;

	const int VOID = 344;

	const int VOLATILE = 345;

	const int WHILE = 346;

	const int STRICT = 347;

	const int NEQ = 350;

	const int MOD_E = 351;

	const int AND_E = 352;

	const int MUL_E = 353;

	const int PLUS_E = 354;

	const int MINUS_E = 355;

	const int DIV_E = 356;

	const int LE = 357;

	const int EQ = 358;

	const int GE = 359;

	const int EXOR_E = 360;

	const int OR_E = 361;

	const int PLUSPLUS = 362;

	const int MINUSMINUS = 363;

	const int LSHIFT = 364;

	const int LSHIFT_E = 365;

	const int RSHIFT = 366;

	const int RSHIFT_E = 367;

	const int OROR = 368;

	const int ANDAND = 369;

	const int ARSHIFT = 370;

	const int ARSHIFT_E = 371;

	static readonly string[] opNames;

	static readonly int[] assignOps;

	const int Identifier = 400;

	const int CharConstant = 401;

	const int IntConstant = 402;

	const int LongConstant = 403;

	const int FloatConstant = 404;

	const int DoubleConstant = 405;

	const int StringL = 406;

	const int TRUE = 410;

	const int FALSE = 411;

	const int NULL = 412;

	const int CALL = 67;

	const int ARRAY = 65;

	const int MEMBER = 35;

	const int EXPR = 69;

	const int LABEL = 76;

	const int BLOCK = 66;

	const int DECL = 68;

	const int BadToken = 500;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	static void ___003Cclinit_003E()
	{
	}

	[LineNumberTable(new byte[]
	{
		43,
		byte.MaxValue,
		160,
		106,
		70
	})]
	static TokenId()
	{
		opNames = new string[22]
		{
			"!=", "%=", "&=", "*=", "+=", "-=", "/=", "<=", "==", ">=",
			"^=", "|=", "++", "--", "<<", "<<=", ">>", ">>=", "||", "&&",
			">>>", ">>>="
		};
		assignOps = new int[21]
		{
			37, 38, 42, 43, 45, 47, 0, 0, 0, 94,
			124, 0, 0, 0, 364, 0, 366, 0, 0, 0,
			370
		};
	}
}
