using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.compiler.ast;

namespace javassist.compiler;

public sealed class Parser : Object, TokenId
{
	private Lex lex;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] binaryOpPrecedence;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 104, 103 })]
	public Parser(Lex lex)
	{
		this.lex = lex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		15, 135, 98, 127, 3, 108, 164, 136, 114, 177,
		99, 136, 140, 108, 114, 109
	})]
	public virtual ASTList parseMember1(SymbolTable tbl)
	{
		ASTList aSTList = parseMemberMods();
		int num = 0;
		Declarator declarator;
		if (lex.lookAhead() == 400 && lex.lookAhead(1) == 40)
		{
			declarator = new Declarator(344, 0);
			num = 1;
		}
		else
		{
			declarator = parseFormalType(tbl);
		}
		if (lex.get() != 400)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		string sym = ((num == 0) ? lex.getString() : "<init>");
		declarator.setVariable(new Symbol(sym));
		if (num != 0 || lex.lookAhead() == 40)
		{
			MethodDecl result = parseMethod1(tbl, (byte)num != 0, aSTList, declarator);
			_ = null;
			return result;
		}
		FieldDecl result2 = parseField(tbl, aSTList, declarator);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 118, 98, 111, 142, 104, 99, 168, 109 })]
	public virtual MethodDecl parseMethod2(SymbolTable tbl, MethodDecl md)
	{
		Stmnt stmnt = null;
		if (lex.lookAhead() == 59)
		{
			lex.get();
		}
		else
		{
			stmnt = parseBlock(tbl);
			if (stmnt == null)
			{
				stmnt = new Stmnt(66);
			}
		}
		md.sublist(4).setHead(stmnt);
		return md;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 145, 108, 101, 106, 101, 108, 138, 120, 108,
		108, 108, 151, 104, 106, 104, 106, 104, 106, 104,
		106, 104, 106, 104, 106, 104, 106, 104, 106, 104,
		106, 104, 106, 104, 138
	})]
	public virtual Stmnt parseStatement(SymbolTable tbl)
	{
		int num = lex.lookAhead();
		switch (num)
		{
		case 123:
		{
			Stmnt result2 = parseBlock(tbl);
			_ = null;
			return result2;
		}
		case 59:
		{
			lex.get();
			Stmnt result3 = new Stmnt(66);
			_ = null;
			return result3;
		}
		case 400:
			if (lex.lookAhead(1) == 58)
			{
				lex.get();
				string @string = lex.getString();
				lex.get();
				Stmnt result = Stmnt.make(76, new Symbol(@string), parseStatement(tbl));
				_ = null;
				return result;
			}
			break;
		}
		switch (num)
		{
		case 320:
		{
			Stmnt result15 = parseIf(tbl);
			_ = null;
			return result15;
		}
		case 346:
		{
			Stmnt result14 = parseWhile(tbl);
			_ = null;
			return result14;
		}
		case 311:
		{
			Stmnt result13 = parseDo(tbl);
			_ = null;
			return result13;
		}
		case 318:
		{
			Stmnt result12 = parseFor(tbl);
			_ = null;
			return result12;
		}
		case 343:
		{
			Stmnt result11 = parseTry(tbl);
			_ = null;
			return result11;
		}
		case 337:
		{
			Stmnt result10 = parseSwitch(tbl);
			_ = null;
			return result10;
		}
		case 338:
		{
			Stmnt result9 = parseSynchronized(tbl);
			_ = null;
			return result9;
		}
		case 333:
		{
			Stmnt result8 = parseReturn(tbl);
			_ = null;
			return result8;
		}
		case 340:
		{
			Stmnt result7 = parseThrow(tbl);
			_ = null;
			return result7;
		}
		case 302:
		{
			Stmnt result6 = parseBreak(tbl);
			_ = null;
			return result6;
		}
		case 309:
		{
			Stmnt result5 = parseContinue(tbl);
			_ = null;
			return result5;
		}
		default:
		{
			Stmnt result4 = parseDeclarationOrExpression(tbl, false);
			_ = null;
			return result4;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(50)]
	public virtual bool hasMore()
	{
		return lex.lookAhead() >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 93, 104, 114, 130, 108, 104 })]
	public virtual ASTree parseExpression(SymbolTable tbl)
	{
		ASTree aSTree = parseConditionalExpr(tbl);
		if (!isAssignOp(lex.lookAhead()))
		{
			return aSTree;
		}
		int op = lex.get();
		ASTree oprand = parseExpression(tbl);
		AssignExpr result = AssignExpr.makeAssign(op, aSTree, oprand);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 74, 130, 108, 191, 52, 252, 69 })]
	private ASTList parseMemberMods()
	{
		ASTList aSTList = null;
		while (true)
		{
			int num = lex.lookAhead();
			if (num != 300 && num != 315 && num != 332 && num != 331 && num != 330 && num != 338 && num != 335 && num != 345 && num != 342 && num != 347)
			{
				break;
			}
			aSTList = new ASTList(new Keyword(lex.get()), aSTList);
		}
		return aSTList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 91, 108, 112, 108, 103, 138, 104, 103 })]
	private Declarator parseFormalType(SymbolTable P_0)
	{
		int num = lex.lookAhead();
		if (isBuiltinType(num) || num == 344)
		{
			lex.get();
			int dim = parseArrayDimension();
			Declarator result = new Declarator(num, dim);
			_ = null;
			return result;
		}
		ASTList className = parseClassType(P_0);
		int dim2 = parseArrayDimension();
		Declarator result2 = new Declarator(className, dim2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 110, 66, 111, 145, 98, 143, 110, 108, 101,
		110, 101, 98, 130, 108, 109, 109, 145, 98, 114,
		140, 110, 111, 238, 70, 102, 49
	})]
	private MethodDecl parseMethod1(SymbolTable P_0, bool P_1, ASTList P_2, Declarator P_3)
	{
		if (lex.get() != 40)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		ASTList aSTList = null;
		if (lex.lookAhead() != 41)
		{
			while (true)
			{
				aSTList = ASTList.append(aSTList, parseFormalParam(P_0));
				switch (lex.lookAhead())
				{
				default:
					continue;
				case 44:
					goto IL_0052;
				case 41:
					break;
				}
				break;
				IL_0052:
				lex.get();
			}
		}
		lex.get();
		P_3.addArrayDim(parseArrayDimension());
		if (P_1 && P_3.getArrayDim() > 0)
		{
			Lex lexer2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer2);
		}
		ASTList aSTList2 = null;
		if (lex.lookAhead() == 341)
		{
			lex.get();
			while (true)
			{
				aSTList2 = ASTList.append(aSTList2, parseClassType(P_0));
				if (lex.lookAhead() != 44)
				{
					break;
				}
				lex.get();
			}
		}
		MethodDecl result = new MethodDecl(P_2, new ASTList(P_3, ASTList.make(aSTList, aSTList2, null)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 48, 98, 111, 108, 168, 108, 101, 117, 101, 182 })]
	private FieldDecl parseField(SymbolTable P_0, ASTList P_1, Declarator P_2)
	{
		ASTree head = null;
		if (lex.lookAhead() == 61)
		{
			lex.get();
			head = parseExpression(P_0);
		}
		switch (lex.get())
		{
		case 59:
		{
			FieldDecl result = new FieldDecl(P_1, new ASTList(P_2, new ASTList(head)));
			_ = null;
			return result;
		}
		case 44:
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("only one field can be declared in one declaration", l);
		}
		default:
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 112, 104, 114, 145, 108, 108, 108, 104 })]
	private Declarator parseFormalParam(SymbolTable P_0)
	{
		Declarator declarator = parseFormalType(P_0);
		if (lex.get() != 400)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		string @string = lex.getString();
		declarator.setVariable(new Symbol(@string));
		declarator.addArrayDim(parseArrayDimension());
		P_0.append(@string, declarator);
		return declarator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 103, 98, 111, 100, 108, 111, 182 })]
	private int parseArrayDimension()
	{
		int num = 0;
		while (lex.lookAhead() == 91)
		{
			num++;
			lex.get();
			if (lex.get() != 93)
			{
				Lex l = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("] is missing", l);
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 117, 130, 114, 145, 119, 111, 238, 69 })]
	private ASTList parseClassType(SymbolTable P_0)
	{
		ASTList aSTList = null;
		while (true)
		{
			if (lex.get() != 400)
			{
				Lex lexer = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer);
			}
			aSTList = ASTList.append(aSTList, new Symbol(lex.getString()));
			if (lex.lookAhead() != 46)
			{
				break;
			}
			lex.get();
		}
		return aSTList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 187, 111, 145, 98, 103, 111, 104, 99, 116,
		130, 108, 99, 106
	})]
	private Stmnt parseBlock(SymbolTable P_0)
	{
		if (lex.get() != 123)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		Stmnt stmnt = null;
		SymbolTable tbl = new SymbolTable(P_0);
		while (lex.lookAhead() != 125)
		{
			Stmnt stmnt2 = parseStatement(tbl);
			if (stmnt2 != null)
			{
				stmnt = (Stmnt)ASTList.concat(stmnt, new Stmnt(66, stmnt2));
			}
		}
		lex.get();
		if (stmnt == null)
		{
			Stmnt result = new Stmnt(66);
			_ = null;
			return result;
		}
		return stmnt;
	}

	private static bool isBuiltinType(int P_0)
	{
		return (P_0 == 301 || P_0 == 303 || P_0 == 306 || P_0 == 334 || P_0 == 324 || P_0 == 326 || P_0 == 317 || P_0 == 312) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 208, 108, 104, 136, 114, 108, 170, 130 })]
	private Stmnt parseIf(SymbolTable P_0)
	{
		int op = lex.get();
		ASTree head = parseParExpression(P_0);
		Stmnt head2 = parseStatement(P_0);
		Stmnt head3;
		if (lex.lookAhead() == 313)
		{
			lex.get();
			head3 = parseStatement(P_0);
		}
		else
		{
			head3 = null;
		}
		Stmnt result = new Stmnt(op, head, new ASTList(head2, new ASTList(head3)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 227, 108, 104, 104 })]
	private Stmnt parseWhile(SymbolTable P_0)
	{
		int op = lex.get();
		ASTree head = parseParExpression(P_0);
		Stmnt tail = parseStatement(P_0);
		Stmnt result = new Stmnt(op, head, tail);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 236, 108, 104, 127, 2, 145, 104, 126, 145 })]
	private Stmnt parseDo(SymbolTable P_0)
	{
		int op = lex.get();
		Stmnt tail = parseStatement(P_0);
		if (lex.get() != 346 || lex.get() != 40)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		ASTree head = parseExpression(P_0);
		if (lex.get() != 41 || lex.get() != 59)
		{
			Lex lexer2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer2);
		}
		Stmnt result = new Stmnt(op, head, tail);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 254, 140, 135, 111, 145, 111, 108, 164, 137,
		111, 132, 136, 111, 150, 111, 133, 137, 111, 150,
		105
	})]
	private Stmnt parseFor(SymbolTable P_0)
	{
		int op = lex.get();
		SymbolTable symbolTable = new SymbolTable(P_0);
		if (lex.get() != 40)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		Stmnt head;
		if (lex.lookAhead() == 59)
		{
			lex.get();
			head = null;
		}
		else
		{
			head = parseDeclarationOrExpression(symbolTable, true);
		}
		ASTree head2 = ((lex.lookAhead() != 59) ? parseExpression(symbolTable) : null);
		if (lex.get() != 59)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
		Stmnt head3 = ((lex.lookAhead() != 41) ? parseExprList(symbolTable) : null);
		if (lex.get() != 41)
		{
			Lex l2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(") is missing", l2);
		}
		Stmnt tail = parseStatement(symbolTable);
		Stmnt result = new Stmnt(op, head, new ASTList(head2, new ASTList(head3, tail)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 119, 108, 104, 98, 117, 108, 111, 145, 103,
		104, 118, 145, 111, 145, 105, 111, 133, 99, 114,
		108, 169
	})]
	private Stmnt parseTry(SymbolTable P_0)
	{
		lex.get();
		Stmnt op = parseBlock(P_0);
		ASTList aSTList = null;
		while (lex.lookAhead() == 305)
		{
			lex.get();
			if (lex.get() != 40)
			{
				Lex lexer = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer);
			}
			SymbolTable symbolTable = new SymbolTable(P_0);
			Declarator declarator = parseFormalParam(symbolTable);
			if (declarator.getArrayDim() > 0 || declarator.getType() != 307)
			{
				Lex lexer2 = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer2);
			}
			if (lex.get() != 41)
			{
				Lex lexer3 = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer3);
			}
			Stmnt right = parseBlock(symbolTable);
			aSTList = ASTList.append(aSTList, new Pair(declarator, right));
		}
		Stmnt op2 = null;
		if (lex.lookAhead() == 316)
		{
			lex.get();
			op2 = parseBlock(P_0);
		}
		Stmnt result = Stmnt.make(343, op, aSTList, op2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 41, 108, 104, 104 })]
	private Stmnt parseSwitch(SymbolTable P_0)
	{
		int op = lex.get();
		ASTree head = parseParExpression(P_0);
		Stmnt tail = parseSwitchBlock(P_0);
		Stmnt result = new Stmnt(op, head, tail);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 101, 108, 111, 145, 104, 111, 145, 104 })]
	private Stmnt parseSynchronized(SymbolTable P_0)
	{
		int op = lex.get();
		if (lex.get() != 40)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		ASTree head = parseExpression(P_0);
		if (lex.get() != 41)
		{
			Lex lexer2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer2);
		}
		Stmnt tail = parseBlock(P_0);
		Stmnt result = new Stmnt(op, head, tail);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 151, 108, 103, 111, 141, 111, 150 })]
	private Stmnt parseReturn(SymbolTable P_0)
	{
		int op = lex.get();
		Stmnt stmnt = new Stmnt(op);
		if (lex.lookAhead() != 59)
		{
			stmnt.setLeft(parseExpression(P_0));
		}
		if (lex.get() != 59)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
		return stmnt;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 165, 108, 104, 111, 150 })]
	private Stmnt parseThrow(SymbolTable P_0)
	{
		int op = lex.get();
		ASTree head = parseExpression(P_0);
		if (lex.get() != 59)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
		Stmnt result = new Stmnt(op, head);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(548)]
	private Stmnt parseBreak(SymbolTable P_0)
	{
		Stmnt result = parseContinue(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 186, 108, 103, 108, 104, 118, 172, 101, 150 })]
	private Stmnt parseContinue(SymbolTable P_0)
	{
		int op = lex.get();
		Stmnt stmnt = new Stmnt(op);
		int num = lex.get();
		if (num == 400)
		{
			stmnt.setLeft(new Symbol(lex.getString()));
			num = lex.get();
		}
		if (num != 59)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
		return stmnt;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 253, 162, 108, 104, 108, 174, 104, 108, 103,
		145, 104, 104, 100, 115, 104, 104, 242, 69, 99,
		139, 144, 111, 150
	})]
	private Stmnt parseDeclarationOrExpression(SymbolTable P_0, bool P_1)
	{
		int num;
		for (num = lex.lookAhead(); num == 315; num = lex.lookAhead())
		{
			lex.get();
		}
		if (isBuiltinType(num))
		{
			num = lex.get();
			int dim = parseArrayDimension();
			Stmnt result = parseDeclarators(P_0, new Declarator(num, dim));
			_ = null;
			return result;
		}
		if (num == 400)
		{
			int dim = nextIsClassType(0);
			if (dim >= 0 && lex.lookAhead(dim) == 400)
			{
				ASTList className = parseClassType(P_0);
				int dim2 = parseArrayDimension();
				Stmnt result2 = parseDeclarators(P_0, new Declarator(className, dim2));
				_ = null;
				return result2;
			}
		}
		Stmnt result3 = ((!P_1) ? new Stmnt(69, parseExpression(P_0)) : parseExprList(P_0));
		if (lex.get() != 59)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 79, 111, 145, 104, 111, 145 })]
	private ASTree parseParExpression(SymbolTable P_0)
	{
		if (lex.get() != 40)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		ASTree result = parseExpression(P_0);
		if (lex.get() != 41)
		{
			Lex lexer2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer2);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 249, 130, 111, 116, 111, 142, 98 })]
	private Stmnt parseExprList(SymbolTable P_0)
	{
		Stmnt stmnt = null;
		while (true)
		{
			Stmnt head = new Stmnt(69, parseExpression(P_0));
			stmnt = (Stmnt)ASTList.concat(stmnt, new Stmnt(66, head));
			if (lex.lookAhead() != 44)
			{
				break;
			}
			lex.get();
		}
		return stmnt;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 48, 111, 145, 103, 104, 99, 150, 103, 112,
		182, 105, 114, 105, 100, 105, 114, 117, 165, 149,
		133, 108
	})]
	private Stmnt parseSwitchBlock(SymbolTable P_0)
	{
		if (lex.get() != 123)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		SymbolTable symbolTable = new SymbolTable(P_0);
		Stmnt stmnt = parseStmntOrCase(symbolTable);
		if (stmnt == null)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("empty switch block", l);
		}
		int @operator = stmnt.getOperator();
		if (@operator != 304 && @operator != 310)
		{
			Lex l2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("no case or default in a switch block", l2);
		}
		Stmnt stmnt2 = new Stmnt(66, stmnt);
		while (lex.lookAhead() != 125)
		{
			Stmnt stmnt3 = parseStmntOrCase(symbolTable);
			if (stmnt3 != null)
			{
				int operator2 = stmnt3.getOperator();
				if (operator2 == 304 || operator2 == 310)
				{
					stmnt2 = (Stmnt)ASTList.concat(stmnt2, new Stmnt(66, stmnt3));
					stmnt = stmnt3;
				}
				else
				{
					stmnt = (Stmnt)ASTList.concat(stmnt, new Stmnt(66, stmnt3));
				}
			}
		}
		lex.get();
		return stmnt2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 80, 108, 112, 138, 140, 104, 144, 139, 111,
		150
	})]
	private Stmnt parseStmntOrCase(SymbolTable P_0)
	{
		int num = lex.lookAhead();
		if (num != 304 && num != 310)
		{
			Stmnt result = parseStatement(P_0);
			_ = null;
			return result;
		}
		lex.get();
		Stmnt result2 = ((num != 304) ? new Stmnt(310) : new Stmnt(num, parseExpression(P_0)));
		if (lex.get() != 58)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(": is missing", l);
		}
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 9, 130, 102, 42, 139, 108, 101, 98, 101,
		118
	})]
	private Stmnt parseDeclarators(SymbolTable P_0, Declarator P_1)
	{
		Stmnt stmnt = null;
		while (true)
		{
			stmnt = (Stmnt)ASTList.concat(stmnt, new Stmnt(68, parseDeclarator(P_0, P_1)));
			switch (lex.get())
			{
			case 44:
				continue;
			case 59:
				return stmnt;
			}
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("; is missing", l);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 89, 117, 120, 130, 119, 117, 130 })]
	private int nextIsClassType(int P_0)
	{
		while (true)
		{
			Lex obj = lex;
			P_0++;
			if (obj.lookAhead(P_0) != 46)
			{
				break;
			}
			Lex obj2 = lex;
			P_0++;
			if (obj2.lookAhead(P_0) != 400)
			{
				return -1;
			}
		}
		while (true)
		{
			Lex obj3 = lex;
			int i = P_0;
			P_0++;
			if (obj3.lookAhead(i) != 91)
			{
				break;
			}
			Lex obj4 = lex;
			int i2 = P_0;
			P_0++;
			if (obj4.lookAhead(i2) != 93)
			{
				return -1;
			}
		}
		return P_0 - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 26, 127, 0, 145, 108, 103, 103, 98, 111,
		108, 168, 107, 105
	})]
	private Declarator parseDeclarator(SymbolTable P_0, Declarator P_1)
	{
		if (lex.get() != 400 || P_1.getType() == 344)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		string @string = lex.getString();
		Symbol sym = new Symbol(@string);
		int dim = parseArrayDimension();
		ASTree init = null;
		if (lex.lookAhead() == 61)
		{
			lex.get();
			init = parseInitializer(P_0);
		}
		Declarator declarator = P_1.make(sym, dim, init);
		P_0.append(@string, declarator);
		return declarator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 46, 111, 106 })]
	private ASTree parseInitializer(SymbolTable P_0)
	{
		if (lex.lookAhead() == 123)
		{
			ArrayInit result = parseArrayInitializer(P_0);
			_ = null;
			return result;
		}
		ASTree result2 = parseExpression(P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 57, 108, 111, 108, 137, 104, 103, 111, 108,
		104, 170, 111, 145
	})]
	private ArrayInit parseArrayInitializer(SymbolTable P_0)
	{
		lex.get();
		if (lex.lookAhead() == 125)
		{
			lex.get();
			ArrayInit result = new ArrayInit(null);
			_ = null;
			return result;
		}
		ASTree firstElement = parseExpression(P_0);
		ArrayInit arrayInit = new ArrayInit(firstElement);
		while (lex.lookAhead() == 44)
		{
			lex.get();
			firstElement = parseExpression(P_0);
			ASTList.append(arrayInit, firstElement);
		}
		if (lex.get() != 125)
		{
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		return arrayInit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 113, 104, 111, 108, 104, 111, 150, 104, 139 })]
	private ASTree parseConditionalExpr(SymbolTable P_0)
	{
		ASTree aSTree = parseBinaryExpr(P_0);
		if (lex.lookAhead() == 63)
		{
			lex.get();
			ASTree thenp = parseExpression(P_0);
			if (lex.get() != 58)
			{
				Lex l = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(": is missing", l);
			}
			ASTree elsep = parseExpression(P_0);
			CondExpr result = new CondExpr(aSTree, thenp, elsep);
			_ = null;
			return result;
		}
		return aSTree;
	}

	private static bool isAssignOp(int P_0)
	{
		return (P_0 == 61 || P_0 == 351 || P_0 == 352 || P_0 == 353 || P_0 == 354 || P_0 == 355 || P_0 == 356 || P_0 == 360 || P_0 == 361 || P_0 == 365 || P_0 == 367 || P_0 == 371) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 168, 136, 108, 104, 99, 98, 106 })]
	private ASTree parseBinaryExpr(SymbolTable P_0)
	{
		ASTree aSTree = parseUnaryExpr(P_0);
		while (true)
		{
			int num = lex.lookAhead();
			int opPrecedence = getOpPrecedence(num);
			if (opPrecedence == 0)
			{
				break;
			}
			aSTree = binaryExpr2(P_0, aSTree, opPrecedence);
		}
		return aSTree;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162,
		249,
		byte.MaxValue,
		51,
		71,
		108,
		104,
		108,
		223,
		3,
		108,
		181,
		108,
		245,
		70,
		144,
		138
	})]
	private ASTree parseUnaryExpr(SymbolTable P_0)
	{
		switch (lex.lookAhead())
		{
		case 33:
		case 43:
		case 45:
		case 126:
		case 362:
		case 363:
		{
			int num = lex.get();
			if (num == 45)
			{
				int num2 = lex.lookAhead();
				switch (num2)
				{
				case 401:
				case 402:
				case 403:
				{
					lex.get();
					IntConst result4 = new IntConst(-lex.getLong(), num2);
					_ = null;
					return result4;
				}
				case 404:
				case 405:
				{
					lex.get();
					DoubleConst result3 = new DoubleConst(0.0 - lex.getDouble(), num2);
					_ = null;
					return result3;
				}
				}
			}
			Expr result5 = Expr.make(num, parseUnaryExpr(P_0));
			_ = null;
			return result5;
		}
		case 40:
		{
			ASTree result2 = parseCast(P_0);
			_ = null;
			return result2;
		}
		default:
		{
			ASTree result = parsePostfix(P_0);
			_ = null;
			return result;
		}
		}
	}

	[LineNumberTable(new byte[]
	{
		162, 218, 106, 107, 101, 98, 101, 98, 104, 99,
		104, 99, 112, 98, 120, 98, 120, 130
	})]
	private int getOpPrecedence(int P_0)
	{
		if (33 <= P_0 && P_0 <= 63)
		{
			return binaryOpPrecedence[P_0 - 33];
		}
		switch (P_0)
		{
		case 94:
			return 7;
		case 124:
			return 8;
		case 369:
			return 9;
		case 368:
			return 10;
		case 350:
		case 358:
			return 5;
		case 323:
		case 357:
		case 359:
			return 4;
		case 364:
		case 366:
		case 370:
			return 3;
		default:
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 195, 108, 104, 139, 136, 108, 104, 103, 140,
		107
	})]
	private ASTree binaryExpr2(SymbolTable P_0, ASTree P_1, int P_2)
	{
		int num = lex.get();
		if (num == 323)
		{
			ASTree result = parseInstanceOf(P_0, P_1);
			_ = null;
			return result;
		}
		ASTree aSTree = parseUnaryExpr(P_0);
		while (true)
		{
			int num2 = lex.lookAhead();
			int opPrecedence = getOpPrecedence(num2);
			if (opPrecedence == 0 || P_2 <= opPrecedence)
			{
				break;
			}
			aSTree = binaryExpr2(P_0, aSTree, opPrecedence);
		}
		BinExpr result2 = BinExpr.makeBin(num, P_1, aSTree);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 181, 108, 104, 108, 103, 139, 104, 103 })]
	private ASTree parseInstanceOf(SymbolTable P_0, ASTree P_1)
	{
		int num = lex.lookAhead();
		if (isBuiltinType(num))
		{
			lex.get();
			int dim = parseArrayDimension();
			InstanceOfExpr result = new InstanceOfExpr(num, dim, P_1);
			_ = null;
			return result;
		}
		ASTList className = parseClassType(P_0);
		int dim2 = parseArrayDimension();
		InstanceOfExpr result2 = new InstanceOfExpr(className, dim2, P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 35, 109, 112, 108, 108, 103, 111, 150, 145,
		112, 108, 104, 103, 111, 150, 177
	})]
	private ASTree parseCast(SymbolTable P_0)
	{
		int num = lex.lookAhead(1);
		if (isBuiltinType(num) && nextIsBuiltinCast())
		{
			lex.get();
			lex.get();
			int dim = parseArrayDimension();
			if (lex.get() != 41)
			{
				Lex l = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(") is missing", l);
			}
			CastExpr result = new CastExpr(num, dim, parseUnaryExpr(P_0));
			_ = null;
			return result;
		}
		if (num == 400 && nextIsClassCast())
		{
			lex.get();
			ASTList className = parseClassType(P_0);
			int dim2 = parseArrayDimension();
			if (lex.get() != 41)
			{
				Lex l2 = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(") is missing", l2);
			}
			CastExpr result2 = new CastExpr(className, dim2, parseUnaryExpr(P_0));
			_ = null;
			return result2;
		}
		ASTree result3 = parsePostfix(P_0);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 150, 108, 223, 3, 108, 180, 108, 244, 71,
		168, 159, 52, 105, 130, 112, 103, 127, 2, 145,
		105, 133, 104, 99, 145, 138, 165, 109, 106, 133,
		108, 109, 105, 110, 105, 127, 1, 105, 109, 181,
		182, 108, 109, 105, 150, 109, 155, 133
	})]
	private ASTree parsePostfix(SymbolTable P_0)
	{
		int num = lex.lookAhead();
		switch (num)
		{
		case 401:
		case 402:
		case 403:
		{
			lex.get();
			IntConst result = new IntConst(lex.getLong(), num);
			_ = null;
			return result;
		}
		case 404:
		case 405:
		{
			lex.get();
			DoubleConst result2 = new DoubleConst(lex.getDouble(), num);
			_ = null;
			return result2;
		}
		default:
		{
			ASTree aSTree = parsePrimaryExpr(P_0);
			while (true)
			{
				switch (lex.lookAhead())
				{
				case 40:
					aSTree = parseMethodCall(P_0, aSTree);
					break;
				case 91:
					if (lex.lookAhead(1) == 93)
					{
						int num3 = parseArrayDimension();
						if (lex.get() != 46 || lex.get() != 307)
						{
							Lex lexer = lex;
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new SyntaxError(lexer);
						}
						aSTree = parseDotClass(aSTree, num3);
					}
					else
					{
						ASTree aSTree2 = parseArrayIndex(P_0);
						if (aSTree2 == null)
						{
							Lex lexer2 = lex;
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new SyntaxError(lexer2);
						}
						aSTree = Expr.make(65, aSTree, aSTree2);
					}
					break;
				case 362:
				case 363:
				{
					int num2 = lex.get();
					aSTree = Expr.make(num2, null, aSTree);
					break;
				}
				case 46:
				{
					lex.get();
					int num2 = lex.get();
					switch (num2)
					{
					case 307:
						aSTree = parseDotClass(aSTree, 0);
						break;
					case 336:
						aSTree = Expr.make(46, new Symbol(toClassName(aSTree)), new Keyword(num2));
						break;
					case 400:
					{
						string @string = lex.getString();
						aSTree = Expr.make(46, aSTree, new Member(@string));
						break;
					}
					default:
					{
						Lex l2 = lex;
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new CompileError("missing member name", l2);
					}
					}
					break;
				}
				case 35:
				{
					lex.get();
					int num2 = lex.get();
					if (num2 != 400)
					{
						Lex l = lex;
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new CompileError("missing static member name", l);
					}
					string @string = lex.getString();
					aSTree = Expr.make(35, new Symbol(toClassName(aSTree)), new Member(@string));
					break;
				}
				default:
					return aSTree;
				}
			}
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 61, 98, 118, 116, 130 })]
	private bool nextIsBuiltinCast()
	{
		int num = 2;
		while (true)
		{
			Lex obj = lex;
			int i = num;
			num++;
			if (obj.lookAhead(i) != 91)
			{
				break;
			}
			Lex obj2 = lex;
			int i2 = num;
			num++;
			if (obj2.lookAhead(i2) != 93)
			{
				return false;
			}
		}
		return lex.lookAhead(num - 1) == 41;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 70, 104, 100, 130, 109, 101, 130, 111 })]
	private bool nextIsClassCast()
	{
		int num = nextIsClassType(1);
		if (num < 0)
		{
			return false;
		}
		int num2 = lex.lookAhead(num);
		if (num2 != 41)
		{
			return false;
		}
		num2 = lex.lookAhead(num + 1);
		return (num2 == 40 || num2 == 412 || num2 == 406 || num2 == 400 || num2 == 339 || num2 == 336 || num2 == 328 || num2 == 410 || num2 == 411 || num2 == 403 || num2 == 402 || num2 == 401 || num2 == 405 || num2 == 404) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164,
		105,
		byte.MaxValue,
		93,
		70,
		137,
		108,
		104,
		99,
		105,
		138,
		147,
		138,
		104,
		111,
		98,
		150,
		112,
		104,
		127,
		2,
		172
	})]
	private ASTree parsePrimaryExpr(SymbolTable P_0)
	{
		int num;
		switch (num = lex.get())
		{
		case 336:
		case 339:
		case 410:
		case 411:
		case 412:
		{
			Keyword result2 = new Keyword(num);
			_ = null;
			return result2;
		}
		case 400:
		{
			string @string = lex.getString();
			Declarator declarator = P_0.lookup(@string);
			if (declarator == null)
			{
				Member result3 = new Member(@string);
				_ = null;
				return result3;
			}
			Variable result4 = new Variable(@string, declarator);
			_ = null;
			return result4;
		}
		case 406:
		{
			StringL result6 = new StringL(lex.getString());
			_ = null;
			return result6;
		}
		case 328:
		{
			NewExpr result5 = parseNew(P_0);
			_ = null;
			return result5;
		}
		case 40:
		{
			ASTree result7 = parseExpression(P_0);
			if (lex.get() == 41)
			{
				return result7;
			}
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(") is missing", l);
		}
		default:
		{
			if (isBuiltinType(num) || num == 344)
			{
				int num2 = parseArrayDimension();
				if (lex.get() == 46 && lex.get() == 307)
				{
					ASTree result = parseDotClass(num, num2);
					_ = null;
					return result;
				}
			}
			Lex lexer = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new SyntaxError(lexer);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 45, 104, 108, 112, 113, 98, 104, 98, 104,
		108, 106, 177
	})]
	private ASTree parseMethodCall(SymbolTable P_0, ASTree P_1)
	{
		if (P_1 is Keyword)
		{
			int num = ((Keyword)P_1).get();
			if (num != 339 && num != 336)
			{
				Lex lexer = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer);
			}
		}
		else if (!(P_1 is Symbol) && P_1 is Expr)
		{
			int num = ((Expr)P_1).getOperator();
			if (num != 46 && num != 35)
			{
				Lex lexer2 = lex;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new SyntaxError(lexer2);
			}
		}
		CallExpr result = CallExpr.makeCall(P_1, parseArgumentList(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 232, 104, 100, 102, 105, 139, 127, 0, 167 })]
	private ASTree parseDotClass(ASTree P_0, int P_1)
	{
		string text = toClassName(P_0);
		if (P_1 > 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (true)
			{
				int num = P_1;
				P_1 += -1;
				if (num <= 0)
				{
					break;
				}
				stringBuilder.append('[');
			}
			stringBuilder.append('L').append(String.instancehelper_replace(text, '.', '/')).append(';');
			text = stringBuilder.toString();
		}
		Expr result = Expr.make(46, new Symbol(text), new Member("class"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 164, 185, 108, 111, 108, 130, 104, 111, 150 })]
	private ASTree parseArrayIndex(SymbolTable P_0)
	{
		lex.get();
		if (lex.lookAhead() == 93)
		{
			lex.get();
			return null;
		}
		ASTree result = parseExpression(P_0);
		if (lex.get() != 93)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("] is missing", l);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 164, 64, 102, 104 })]
	private string toClassName(ASTree P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		toClassName(P_0, stringBuilder);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 200, 111, 150, 98, 143, 110, 111, 238, 69,
		111, 150
	})]
	private ASTList parseArgumentList(SymbolTable P_0)
	{
		if (lex.get() != 40)
		{
			Lex l = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("( is missing", l);
		}
		ASTList aSTList = null;
		if (lex.lookAhead() != 41)
		{
			while (true)
			{
				aSTList = ASTList.append(aSTList, parseExpression(P_0));
				if (lex.lookAhead() != 44)
				{
					break;
				}
				lex.get();
			}
		}
		if (lex.get() != 41)
		{
			Lex l2 = lex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(") is missing", l2);
		}
		return aSTList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 72, 104, 114, 129, 104, 103, 106, 109, 105,
		111, 193
	})]
	private void toClassName(ASTree P_0, StringBuilder P_1)
	{
		if (P_0 is Symbol)
		{
			P_1.append(((Symbol)P_0).get());
			return;
		}
		if (P_0 is Expr)
		{
			Expr expr = (Expr)P_0;
			if (expr.getOperator() == 46)
			{
				toClassName(expr.oprand1(), P_1);
				P_1.append('.');
				toClassName(expr.oprand2(), P_1);
				return;
			}
		}
		Lex l = lex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad static member access", l);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 143, 98, 108, 104, 108, 104, 111, 136, 139,
		107, 104, 108, 101, 104, 138, 101, 104, 111, 136,
		203
	})]
	private NewExpr parseNew(SymbolTable P_0)
	{
		ArrayInit init = null;
		int num = lex.lookAhead();
		if (isBuiltinType(num))
		{
			lex.get();
			ASTList arraySize = parseArraySize(P_0);
			if (lex.lookAhead() == 123)
			{
				init = parseArrayInitializer(P_0);
			}
			NewExpr result = new NewExpr(num, arraySize, init);
			_ = null;
			return result;
		}
		if (num == 400)
		{
			ASTList arraySize = parseClassType(P_0);
			switch (lex.lookAhead())
			{
			case 40:
			{
				ASTList arraySize2 = parseArgumentList(P_0);
				NewExpr result3 = new NewExpr(arraySize, arraySize2);
				_ = null;
				return result3;
			}
			case 91:
			{
				ASTList arraySize2 = parseArraySize(P_0);
				if (lex.lookAhead() == 123)
				{
					init = parseArrayInitializer(P_0);
				}
				NewExpr result2 = NewExpr.makeObjectArray(arraySize, arraySize2, init);
				_ = null;
				return result2;
			}
			}
		}
		Lex lexer = lex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new SyntaxError(lexer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 252, 100, 104, 186, 159, 90, 102, 133, 102,
		133, 102, 130, 102, 130, 102, 130, 102, 130, 102,
		130, 102, 130, 102, 130, 223, 6
	})]
	private ASTree parseDotClass(int P_0, int P_1)
	{
		string sym;
		if (P_1 > 0)
		{
			sym = CodeGen.toJvmTypeName(P_0, P_1);
			Expr result = Expr.make(46, new Symbol(sym), new Member("class"));
			_ = null;
			return result;
		}
		switch (P_0)
		{
		case 301:
			sym = "java.lang.Boolean";
			break;
		case 303:
			sym = "java.lang.Byte";
			break;
		case 306:
			sym = "java.lang.Character";
			break;
		case 334:
			sym = "java.lang.Short";
			break;
		case 324:
			sym = "java.lang.Integer";
			break;
		case 326:
			sym = "java.lang.Long";
			break;
		case 317:
			sym = "java.lang.Float";
			break;
		case 312:
			sym = "java.lang.Double";
			break;
		case 344:
			sym = "java.lang.Void";
			break;
		default:
		{
			string s = new StringBuilder().append("invalid builtin type: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		}
		Expr result2 = Expr.make(35, new Symbol(sym), new Member("TYPE"));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 164, 175, 98, 111, 144 })]
	private ASTList parseArraySize(SymbolTable P_0)
	{
		ASTList aSTList = null;
		while (lex.lookAhead() == 91)
		{
			aSTList = ASTList.append(aSTList, parseArrayIndex(P_0));
		}
		return aSTList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 6, 104, 104, 112 })]
	public virtual ASTList parseMember(SymbolTable tbl)
	{
		ASTList aSTList = parseMember1(tbl);
		if (aSTList is MethodDecl)
		{
			MethodDecl result = parseMethod2(tbl, (MethodDecl)aSTList);
			_ = null;
			return result;
		}
		return aSTList;
	}

	[LineNumberTable(837)]
	static Parser()
	{
		binaryOpPrecedence = new int[31]
		{
			0, 0, 0, 0, 1, 6, 0, 0, 0, 1,
			2, 0, 2, 0, 1, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 4, 0, 4,
			0
		};
	}
}
