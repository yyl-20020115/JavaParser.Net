using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

[Implements(new string[] { "javassist.bytecode.Opcode", "javassist.compiler.TokenId" })]
public abstract class CodeGen : Visitor, Opcode, TokenId
{
	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "atSyncStmnt", "(Ljavassist.compiler.ast.Stmnt;)V")]
	internal class _1 : ReturnHook
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024var;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CodeGen this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(748)]
		internal _1(CodeGen P_0, CodeGen P_1, int P_2)
		{
			this_00240 = P_0;
			val_0024var = P_2;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 125, 108, 107 })]
		protected internal override bool doit(Bytecode P_0, int P_1)
		{
			P_0.addAload(val_0024var);
			P_0.addOpcode(195);
			return false;
		}
	}

	[InnerClass(null, Modifiers.Protected | Modifiers.Static | Modifiers.Abstract)]
	public abstract class ReturnHook : Object
	{
		internal ReturnHook next;

		protected internal abstract bool doit(Bytecode b, int i);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 40, 104, 108, 103 })]
		protected internal ReturnHook(CodeGen gen)
		{
			next = gen.returnHooks;
			gen.returnHooks = this;
		}

		[LineNumberTable(new byte[] { 46, 108 })]
		protected internal virtual void remove(CodeGen gen)
		{
			gen.returnHooks = next;
		}
	}

	internal const string javaLangObject = "java.lang.Object";

	internal const string jvmJavaLangObject = "java/lang/Object";

	internal const string javaLangString = "java.lang.String";

	internal const string jvmJavaLangString = "java/lang/String";

	protected internal Bytecode bytecode;

	private int tempVar;

	internal TypeChecker typeChecker;

	protected internal bool hasReturned;

	public bool inStaticMethod;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljava/lang/Integer;>;")]
	protected internal List breakList;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljava/lang/Integer;>;")]
	protected internal List continueList;

	protected internal ReturnHook returnHooks;

	protected internal int exprType;

	protected internal int arrayDim;

	protected internal string className;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int[] binOp;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] ifOp;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] ifOp2;

	private const int P_DOUBLE = 0;

	private const int P_FLOAT = 1;

	private const int P_LONG = 2;

	private const int P_INT = 3;

	private const int P_OTHER = -1;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] castOp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public virtual int getMaxLocals()
	{
		int maxLocals = bytecode.getMaxLocals();
		_ = null;
		return maxLocals;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 89, 110 })]
	protected internal virtual void incMaxLocals(int size)
	{
		bytecode.incMaxLocals(size);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 151, 104, 110 })]
	public virtual void doTypeCheck(ASTree expr)
	{
		if (typeChecker != null)
		{
			expr.accept(typeChecker);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 98, 162, 103, 104, 103, 168, 111, 101, 101,
		123, 120, 103, 118, 107, 103, 130, 108, 108, 112,
		144, 123, 101, 108, 144, 98, 137, 107, 103, 162,
		103, 117, 144, 186, 107, 103
	})]
	private bool booleanExpr(bool P_0, ASTree P_1)
	{
		int compOperator = getCompOperator(P_1);
		switch (compOperator)
		{
		case 358:
		{
			BinExpr binExpr = (BinExpr)P_1;
			int num2 = compileOprands(binExpr);
			compareExpr(P_0, binExpr.getOperator(), num2, binExpr);
			break;
		}
		case 33:
		{
			bool result = booleanExpr((!P_0) ? true : false, ((Expr)P_1).oprand1());
			_ = null;
			return result;
		}
		default:
		{
			int num;
			if ((num = ((compOperator == 369) ? 1 : 0)) != 0 || compOperator == 368)
			{
				BinExpr binExpr = (BinExpr)P_1;
				if (booleanExpr((num == 0) ? true : false, binExpr.oprand1()))
				{
					exprType = 301;
					arrayDim = 0;
					return true;
				}
				int num2 = bytecode.currentPc();
				bytecode.addIndex(0);
				if (booleanExpr((byte)num != 0, binExpr.oprand2()))
				{
					bytecode.addOpcode(167);
				}
				bytecode.write16bit(num2, bytecode.currentPc() - num2 + 3);
				if ((P_0 ? 1 : 0) != num)
				{
					bytecode.addIndex(6);
					bytecode.addOpcode(167);
				}
			}
			else
			{
				if (isAlwaysBranch(P_1, P_0))
				{
					exprType = 301;
					arrayDim = 0;
					return true;
				}
				P_1.accept(this);
				if (exprType != 301 || arrayDim != 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError("boolean expr is required");
				}
				bytecode.addOpcode((!P_0) ? 153 : 154);
			}
			break;
		}
		}
		exprType = 301;
		arrayDim = 0;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(125)]
	protected internal static void fatal()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("fatal");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 110 })]
	public virtual void setMaxLocals(int n)
	{
		bytecode.setMaxLocals(n);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 178, 108, 178, 115, 132, 130, 199, 103, 99,
		103, 143
	})]
	public override void atDeclarator(Declarator d)
	{
		d.setLocalVar(getMaxLocals());
		d.setClassName(resolveClassName(d.getClassName()));
		int size = ((!is2word(d.getType(), d.getArrayDim())) ? 1 : 2);
		incMaxLocals(size);
		ASTree initializer = d.getInitializer();
		if (initializer != null)
		{
			doTypeCheck(initializer);
			atVariableAssign(null, 61, null, d, initializer, false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 64, 132, 99, 129, 108, 134, 103, 103, 104,
		99, 112, 169, 112
	})]
	public virtual void atMethodBody(Stmnt s, bool isCons, bool isVoid)
	{
		if (s == null)
		{
			return;
		}
		if (isCons && needsSuperCall(s))
		{
			insertDefaultSuperCall();
		}
		hasReturned = false;
		s.accept(this);
		if (!hasReturned)
		{
			if (!isVoid)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("no return statement");
			}
			bytecode.addOpcode(177);
			hasReturned = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 218, 106, 141, 115, 103, 113, 105, 108, 104,
		108, 245, 69
	})]
	private bool needsSuperCall(Stmnt P_0)
	{
		if (P_0.getOperator() == 66)
		{
			P_0 = (Stmnt)P_0.head();
		}
		if (P_0 != null && P_0.getOperator() == 69)
		{
			ASTree aSTree = P_0.head();
			if (aSTree != null && aSTree is Expr && ((Expr)aSTree).getOperator() == 67)
			{
				ASTree aSTree2 = ((Expr)aSTree).head();
				if (aSTree2 is Keyword)
				{
					int num = ((Keyword)aSTree2).get();
					return (num != 339 && num != 336) ? true : false;
				}
			}
		}
		return true;
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract void insertDefaultSuperCall();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 189, 162, 103, 103, 103, 104, 111, 39, 199,
		104, 104, 107, 114, 193, 141
	})]
	protected internal virtual void atAssignExpr(AssignExpr expr, bool doDup)
	{
		int @operator = expr.getOperator();
		ASTree aSTree = expr.oprand1();
		ASTree aSTree2 = expr.oprand2();
		if (aSTree is Variable)
		{
			atVariableAssign(expr, @operator, (Variable)aSTree, ((Variable)aSTree).getDeclarator(), aSTree2, doDup);
			return;
		}
		if (aSTree is Expr)
		{
			Expr expr2 = (Expr)aSTree;
			if (expr2.getOperator() == 65)
			{
				atArrayAssign(expr, @operator, (Expr)aSTree, aSTree2, doDup);
				return;
			}
		}
		atFieldAssign(expr, @operator, aSTree, aSTree2, doDup);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 168, 104, 108, 181 })]
	private static bool isPlusPlusExpr(ASTree P_0)
	{
		if (P_0 is Expr)
		{
			int @operator = ((Expr)P_0).getOperator();
			return (@operator == 362 || @operator == 363) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		157, 203, 99, 104, 99, 136, 107, 108, 115, 108,
		105, 105, 134, 108, 109, 102, 141, 112, 121, 102,
		141, 146, 108, 109, 102, 141, 109, 121, 102, 141,
		146, 108, 109, 102, 141, 112, 121, 102, 141, 146,
		127, 8, 102, 141, 110, 105, 112, 112, 109, 175,
		112, 109, 173, 102, 109, 130, 102, 130, 104, 104,
		107, 109, 193, 141
	})]
	private void atPlusPlus(int P_0, ASTree P_1, Expr P_2, bool P_3)
	{
		int num = ((P_1 == null) ? 1 : 0);
		if (num != 0)
		{
			P_1 = P_2.oprand2();
		}
		if (P_1 is Variable)
		{
			Declarator declarator = ((Variable)P_1).getDeclarator();
			int type = declarator.getType();
			exprType = type;
			int num2 = type;
			arrayDim = declarator.getArrayDim();
			int localVar = getLocalVar(declarator);
			if (arrayDim > 0)
			{
				badType(P_2);
			}
			switch (num2)
			{
			case 312:
				bytecode.addDload(localVar);
				if (P_3 && num != 0)
				{
					bytecode.addOpcode(92);
				}
				bytecode.addDconst(1.0);
				bytecode.addOpcode((P_0 != 362) ? 103 : 99);
				if (P_3 && num == 0)
				{
					bytecode.addOpcode(92);
				}
				bytecode.addDstore(localVar);
				break;
			case 326:
				bytecode.addLload(localVar);
				if (P_3 && num != 0)
				{
					bytecode.addOpcode(92);
				}
				bytecode.addLconst(1L);
				bytecode.addOpcode((P_0 != 362) ? 101 : 97);
				if (P_3 && num == 0)
				{
					bytecode.addOpcode(92);
				}
				bytecode.addLstore(localVar);
				break;
			case 317:
				bytecode.addFload(localVar);
				if (P_3 && num != 0)
				{
					bytecode.addOpcode(89);
				}
				bytecode.addFconst(1f);
				bytecode.addOpcode((P_0 != 362) ? 102 : 98);
				if (P_3 && num == 0)
				{
					bytecode.addOpcode(89);
				}
				bytecode.addFstore(localVar);
				break;
			case 303:
			case 306:
			case 324:
			case 334:
			{
				if (P_3 && num != 0)
				{
					bytecode.addIload(localVar);
				}
				int num3 = ((P_0 == 362) ? 1 : (-1));
				if (localVar > 255)
				{
					bytecode.addOpcode(196);
					bytecode.addOpcode(132);
					bytecode.addIndex(localVar);
					bytecode.addIndex(num3);
				}
				else
				{
					bytecode.addOpcode(132);
					bytecode.add(localVar);
					bytecode.add(num3);
				}
				if (P_3 && num == 0)
				{
					bytecode.addIload(localVar);
				}
				break;
			}
			default:
				badType(P_2);
				break;
			}
			return;
		}
		if (P_1 is Expr)
		{
			Expr expr = (Expr)P_1;
			if (expr.getOperator() == 65)
			{
				atArrayPlusPlus(P_0, (byte)num != 0, expr, P_3);
				return;
			}
		}
		atFieldPlusPlus(P_0, (byte)num != 0, P_1, P_2, P_3);
	}

	public static bool is2word(int type, int dim)
	{
		return (dim == 0 && (type == 312 || type == 326)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 41, 103, 113, 118, 106, 103, 99, 137, 161,
		108, 99, 140, 103, 99, 135, 104, 135, 103, 112,
		109, 172, 123, 99, 103, 100, 157, 150
	})]
	private void atIfStmnt(Stmnt P_0)
	{
		ASTree expr = P_0.head();
		Stmnt stmnt = (Stmnt)P_0.tail().head();
		Stmnt stmnt2 = (Stmnt)P_0.tail().tail().head();
		if (compileBooleanExpr(branchIf: false, expr))
		{
			hasReturned = false;
			stmnt2?.accept(this);
			return;
		}
		int num = bytecode.currentPc();
		int num2 = 0;
		bytecode.addIndex(0);
		hasReturned = false;
		stmnt?.accept(this);
		int num3 = (hasReturned ? 1 : 0);
		hasReturned = false;
		if (stmnt2 != null && num3 == 0)
		{
			bytecode.addOpcode(167);
			num2 = bytecode.currentPc();
			bytecode.addIndex(0);
		}
		bytecode.write16bit(num, bytecode.currentPc() - num + 1);
		if (stmnt2 != null)
		{
			stmnt2.accept(this);
			if (num3 == 0)
			{
				bytecode.write16bit(num2, bytecode.currentPc() - num2 + 1);
			}
			hasReturned = ((num3 != 0 && hasReturned) ? true : false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 30, 130, 103, 103, 107, 139, 103, 141, 99,
		99, 112, 109, 172, 109, 100, 136, 109, 99, 148,
		106, 100, 112, 173, 123, 119, 110, 103, 103, 104
	})]
	private void atWhileStmnt(Stmnt P_0, bool P_1)
	{
		List list = breakList;
		List list2 = continueList;
		breakList = new ArrayList();
		continueList = new ArrayList();
		ASTree expr = P_0.head();
		Stmnt stmnt = (Stmnt)P_0.tail();
		int num = 0;
		if (P_1)
		{
			bytecode.addOpcode(167);
			num = bytecode.currentPc();
			bytecode.addIndex(0);
		}
		int num2 = bytecode.currentPc();
		stmnt?.accept(this);
		int num3 = bytecode.currentPc();
		if (P_1)
		{
			bytecode.write16bit(num, num3 - num + 1);
		}
		int num4 = (compileBooleanExpr(branchIf: true, expr) ? 1 : 0);
		if (num4 != 0)
		{
			bytecode.addOpcode(167);
			num4 = (breakList.isEmpty() ? 1 : 0);
		}
		bytecode.addIndex(num2 - bytecode.currentPc() + 1);
		patchGoto(breakList, bytecode.currentPc());
		patchGoto(continueList, num3);
		continueList = list2;
		breakList = list;
		hasReturned = (byte)num4 != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 123, 103, 103, 107, 139, 108, 103, 104, 103,
		109, 141, 99, 135, 109, 99, 100, 139, 103, 103,
		103, 161, 109, 172, 100, 136, 109, 100, 136, 112,
		155, 109, 100, 148, 110, 110, 103, 103, 103
	})]
	private void atForStmnt(Stmnt P_0)
	{
		List list = breakList;
		List list2 = continueList;
		breakList = new ArrayList();
		continueList = new ArrayList();
		Stmnt stmnt = (Stmnt)P_0.head();
		ASTList aSTList = P_0.tail();
		ASTree aSTree = aSTList.head();
		aSTList = aSTList.tail();
		Stmnt stmnt2 = (Stmnt)aSTList.head();
		Stmnt stmnt3 = (Stmnt)aSTList.tail();
		stmnt?.accept(this);
		int num = bytecode.currentPc();
		int num2 = 0;
		if (aSTree != null)
		{
			if (compileBooleanExpr(branchIf: false, aSTree))
			{
				continueList = list2;
				breakList = list;
				hasReturned = false;
				return;
			}
			num2 = bytecode.currentPc();
			bytecode.addIndex(0);
		}
		stmnt3?.accept(this);
		int targetPc = bytecode.currentPc();
		stmnt2?.accept(this);
		bytecode.addOpcode(167);
		bytecode.addIndex(num - bytecode.currentPc() + 1);
		int num3 = bytecode.currentPc();
		if (aSTree != null)
		{
			bytecode.write16bit(num2, num3 - num2 + 1);
		}
		patchGoto(breakList, num3);
		patchGoto(continueList, targetPc);
		continueList = list2;
		breakList = list;
		hasReturned = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 232, 162, 104, 176, 112, 113, 108, 99, 143,
		109
	})]
	private void atBreakStmnt(Stmnt P_0, bool P_1)
	{
		if (P_0.head() != null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("sorry, not support labeled break or continue");
		}
		bytecode.addOpcode(167);
		Integer e = Integer.valueOf(bytecode.currentPc());
		bytecode.addIndex(0);
		if (P_1)
		{
			breakList.add(e);
		}
		else
		{
			continueList.add(e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 55, 110 })]
	protected internal virtual void atReturnStmnt(Stmnt st)
	{
		atReturnStmnt2(st.getLeft());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 92, 103, 103, 118, 144, 112, 103 })]
	private void atThrowStmnt(Stmnt P_0)
	{
		ASTree left = P_0.getLeft();
		compileExpr(left);
		if (exprType != 307 || arrayDim > 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("bad throw statement");
		}
		bytecode.addOpcode(191);
		hasReturned = true;
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal virtual void atTryStmnt(Stmnt st)
	{
		hasReturned = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 175, 98, 104, 108, 159, 16, 172, 108, 98,
		99, 103, 103, 108, 108, 186, 103, 107, 108, 112,
		103, 107, 142, 109, 99, 104, 120, 6, 235, 69,
		109, 108, 109, 143, 105, 103, 99, 99, 107, 110,
		105, 105, 114, 105, 135, 141, 131, 181, 144, 249,
		69, 103, 242, 41, 238, 90, 103, 102, 105, 118,
		117, 230, 61, 232, 70, 115, 135, 109, 101, 132,
		113, 127, 6, 150, 110, 103
	})]
	private void atSwitchStmnt(Stmnt P_0)
	{
		int num = 0;
		if (typeChecker != null)
		{
			doTypeCheck(P_0.head());
			num = ((typeChecker.exprType == 307 && typeChecker.arrayDim == 0 && String.instancehelper_equals("java/lang/String", typeChecker.className)) ? 1 : 0);
		}
		compileExpr(P_0.head());
		int num2 = -1;
		if (num != 0)
		{
			num2 = getMaxLocals();
			incMaxLocals(1);
			bytecode.addAstore(num2);
			bytecode.addAload(num2);
			bytecode.addInvokevirtual("java/lang/String", "hashCode", "()I");
		}
		List list = breakList;
		breakList = new ArrayList();
		int num3 = bytecode.currentPc();
		bytecode.addOpcode(171);
		int num4 = 3 - (num3 & 3);
		while (true)
		{
			int num5 = num4;
			num4 += -1;
			if (num5 <= 0)
			{
				break;
			}
			bytecode.add(0);
		}
		Stmnt stmnt = (Stmnt)P_0.tail();
		int num6 = 0;
		for (ASTList aSTList = stmnt; aSTList != null; aSTList = aSTList.tail())
		{
			if (((Stmnt)aSTList.head()).getOperator() == 304)
			{
				num6++;
			}
		}
		int num7 = bytecode.currentPc();
		bytecode.addGap(4);
		bytecode.add32bit(num6);
		bytecode.addGap(num6 * 8);
		long[] array = new long[num6];
		ArrayList arrayList = new ArrayList();
		int num8 = 0;
		int num9 = -1;
		for (ASTList aSTList2 = stmnt; aSTList2 != null; aSTList2 = aSTList2.tail())
		{
			Stmnt stmnt2 = (Stmnt)aSTList2.head();
			switch (stmnt2.getOperator())
			{
			case 310:
				num9 = bytecode.currentPc();
				break;
			default:
				fatal();
				break;
			case 304:
			{
				int num10 = bytecode.currentPc();
				long num11 = ((num == 0) ? computeLabel(stmnt2.head()) : computeStringLabel(stmnt2.head(), num2, arrayList));
				int num12 = num8;
				num8++;
				array[num12] = (num11 << 32) + (long)((ulong)(num10 - num3) & 0xFFFFFFFFFFFFFFFFuL);
				break;
			}
			}
			hasReturned = false;
			((Stmnt)stmnt2.tail()).accept(this);
		}
		Arrays.sort(array);
		int num13 = num7 + 8;
		int i;
		for (i = 0; i < num6; i++)
		{
			bytecode.write32bit(num13, (int)((ulong)array[i] >> 32));
			bytecode.write32bit(num13 + 4, (int)array[i]);
			num13 += 8;
		}
		if (num9 < 0 || breakList.size() > 0)
		{
			hasReturned = false;
		}
		i = bytecode.currentPc();
		if (num9 < 0)
		{
			num9 = i;
		}
		bytecode.write32bit(num7, num9 - num3);
		Iterator iterator = arrayList.iterator();
		while (iterator.hasNext())
		{
			int num10 = ((Integer)iterator.next()).intValue();
			bytecode.write16bit(num10, num9 - num10 + 1);
		}
		patchGoto(breakList, i);
		breakList = list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 108, 108, 140, 108, 117, 144, 103, 103, 103,
		104, 103, 139, 234, 73, 104, 109, 100, 136, 104,
		99, 104, 106, 107, 104, 167, 102, 104, 106, 107,
		173, 104, 147, 136, 116, 104, 144
	})]
	private void atSyncStmnt(Stmnt P_0)
	{
		int listSize = getListSize(breakList);
		int listSize2 = getListSize(continueList);
		compileExpr(P_0.head());
		if (exprType != 307 && arrayDim == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("bad type expr for synchronized block");
		}
		Bytecode bytecode = this.bytecode;
		int maxLocals = bytecode.getMaxLocals();
		bytecode.incMaxLocals(1);
		bytecode.addOpcode(89);
		bytecode.addAstore(maxLocals);
		bytecode.addOpcode(194);
		_1  = new _1(this, this, maxLocals);
		int num = bytecode.currentPc();
		((Stmnt)P_0.tail())?.accept(this);
		int num2 = bytecode.currentPc();
		int num3 = 0;
		if (!hasReturned)
		{
			.doit(bytecode, 0);
			bytecode.addOpcode(167);
			num3 = bytecode.currentPc();
			bytecode.addIndex(0);
		}
		if (num < num2)
		{
			int handler = bytecode.currentPc();
			.doit(bytecode, 0);
			bytecode.addOpcode(191);
			bytecode.addExceptionHandler(num, num2, handler, 0);
		}
		if (!hasReturned)
		{
			bytecode.write16bit(num3, bytecode.currentPc() - num3 + 1);
		}
		.remove(this);
		if (getListSize(breakList) != listSize || getListSize(continueList) != listSize2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("sorry, cannot break/continue in synchronized block");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 77, 66, 103 })]
	public virtual bool compileBooleanExpr(bool branchIf, ASTree expr)
	{
		doTypeCheck(expr);
		bool result = booleanExpr(branchIf, expr);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljava/lang/Integer;>;I)V")]
	[LineNumberTable(new byte[] { 161, 118, 127, 1, 115 })]
	protected internal virtual void patchGoto(List list, int targetPc)
	{
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			int num = ((Integer)iterator.next()).intValue();
			bytecode.write16bit(num, targetPc - num + 1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 139, 103, 105 })]
	public virtual void compileExpr(ASTree expr)
	{
		doTypeCheck(expr);
		expr.accept(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[IKVM.Attributes.Signature("(Ljavassist/compiler/ast/ASTree;ILjava/util/List<Ljava/lang/Integer;>;)I")]
	[LineNumberTable(new byte[]
	{
		162, 21, 103, 104, 107, 108, 108, 108, 154, 112,
		113, 108, 104, 137
	})]
	private int computeStringLabel(ASTree P_0, int P_1, List P_2)
	{
		doTypeCheck(P_0);
		P_0 = TypeChecker.stripPlusExpr(P_0);
		if (P_0 is StringL)
		{
			string text = ((StringL)P_0).get();
			bytecode.addAload(P_1);
			bytecode.addLdc(text);
			bytecode.addInvokevirtual("java/lang/String", "equals", "(Ljava/lang/Object;)Z");
			bytecode.addOpcode(153);
			Integer e = Integer.valueOf(bytecode.currentPc());
			bytecode.addIndex(0);
			P_2.add(e);
			int result = String.instancehelper_hashCode(text);
			_ = null;
			return result;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad case label");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 11, 103, 104, 104, 109 })]
	private int computeLabel(ASTree P_0)
	{
		doTypeCheck(P_0);
		P_0 = TypeChecker.stripPlusExpr(P_0);
		if (P_0 is IntConst)
		{
			return (int)((IntConst)P_0).get();
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad case label");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 60, 99, 139, 103, 105, 139, 103, 104, 104,
		104, 104, 104, 104, 104, 136, 198, 106, 111, 103,
		225, 61, 233, 70, 108, 103
	})]
	protected internal void atReturnStmnt2(ASTree result)
	{
		int num;
		if (result == null)
		{
			num = 177;
		}
		else
		{
			compileExpr(result);
			if (arrayDim > 0)
			{
				num = 176;
			}
			else
			{
				int num2 = exprType;
				num = num2 switch
				{
					312 => 175, 
					317 => 174, 
					326 => 173, 
					_ => (!isRefType(num2)) ? 172 : 176, 
				};
			}
		}
		for (ReturnHook next = returnHooks; next != null; next = next.next)
		{
			if (next.doit(bytecode, num))
			{
				hasReturned = true;
				return;
			}
		}
		bytecode.addOpcode(num);
		hasReturned = true;
	}

	protected internal static bool isRefType(int type)
	{
		return (type == 307 || type == 412) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljava/lang/Integer;>;)I")]
	[LineNumberTable(790)]
	private static int getListSize(List P_0)
	{
		int result = P_0?.size() ?? 0;
		_ = null;
		return result;
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract string resolveClassName(string str);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 179, 99, 104, 104, 104, 138, 101, 167, 108,
		146, 141, 99, 105, 143, 141, 100, 114, 104, 111,
		104, 111, 104, 111, 104, 143, 141, 103, 103, 103
	})]
	private void atVariableAssign(Expr P_0, int P_1, Variable P_2, Declarator P_3, ASTree P_4, bool P_5)
	{
		int type = P_3.getType();
		int num = P_3.getArrayDim();
		string text = P_3.getClassName();
		int localVar = getLocalVar(P_3);
		if (P_1 != 61)
		{
			atVariable(P_2);
		}
		if (P_0 == null && P_4 is ArrayInit)
		{
			atArrayVariableAssign((ArrayInit)P_4, type, num, text);
		}
		else
		{
			atAssignCore(P_0, P_1, P_4, type, num, text);
		}
		if (P_5)
		{
			if (is2word(type, num))
			{
				bytecode.addOpcode(92);
			}
			else
			{
				bytecode.addOpcode(89);
			}
		}
		if (num > 0)
		{
			bytecode.addAstore(localVar);
		}
		else
		{
			switch (type)
			{
			case 312:
				bytecode.addDstore(localVar);
				break;
			case 317:
				bytecode.addFstore(localVar);
				break;
			case 326:
				bytecode.addLstore(localVar);
				break;
			default:
				if (isRefType(type))
				{
					bytecode.addAstore(localVar);
				}
				else
				{
					bytecode.addIstore(localVar);
				}
				break;
			}
		}
		exprType = type;
		arrayDim = num;
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 168, 99, 146, 101, 109, 188, 103, 103, 135,
		141, 99, 105, 143, 141, 114, 103, 103, 103
	})]
	private void atArrayAssign(Expr P_0, int P_1, Expr P_2, ASTree P_3, bool P_4)
	{
		arrayAccess(P_2.oprand1(), P_2.oprand2());
		if (P_1 != 61)
		{
			bytecode.addOpcode(92);
			bytecode.addOpcode(getArrayReadOp(exprType, arrayDim));
		}
		int type = exprType;
		int dim = arrayDim;
		string cname = className;
		atAssignCore(P_0, P_1, P_3, type, dim, cname);
		if (P_4)
		{
			if (is2word(type, dim))
			{
				bytecode.addOpcode(94);
			}
			else
			{
				bytecode.addOpcode(91);
			}
		}
		bytecode.addOpcode(getArrayWriteOp(type, dim));
		exprType = type;
		arrayDim = dim;
		className = cname;
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract void atFieldAssign(Expr e, int i, ASTree ast1, ASTree ast2, bool b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 106, 103, 100, 103, 103, 167 })]
	protected internal virtual int getLocalVar(Declarator d)
	{
		int num = d.getLocalVar();
		if (num < 0)
		{
			num = getMaxLocals();
			d.setLocalVar(num);
			incMaxLocals(1);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		167, 40, 103, 108, 108, 108, 136, 105, 145, 159,
		22, 108, 130, 108, 130, 108, 130, 108, 130, 174
	})]
	public override void atVariable(Variable v)
	{
		Declarator declarator = v.getDeclarator();
		exprType = declarator.getType();
		arrayDim = declarator.getArrayDim();
		className = declarator.getClassName();
		int localVar = getLocalVar(declarator);
		if (arrayDim > 0)
		{
			bytecode.addAload(localVar);
			return;
		}
		switch (exprType)
		{
		case 307:
			bytecode.addAload(localVar);
			break;
		case 326:
			bytecode.addLload(localVar);
			break;
		case 317:
			bytecode.addFload(localVar);
			break;
		case 312:
			bytecode.addDload(localVar);
			break;
		default:
			bytecode.addIload(localVar);
			break;
		}
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract void atArrayVariableAssign(ArrayInit ai, int i1, int i2, string str);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 71, 117, 147, 103, 159, 12, 134, 101, 110,
		103, 100, 133, 203, 114, 176
	})]
	protected internal virtual void atAssignCore(Expr expr, int op, ASTree right, int type, int dim, string cname)
	{
		if (op == 354 && dim == 0 && type == 307)
		{
			atStringPlusEq(expr, type, dim, cname, right);
		}
		else
		{
			right.accept(this);
			if (invalidDim(exprType, arrayDim, className, type, dim, cname, false) || (op != 61 && dim > 0))
			{
				badAssign(expr);
			}
			if (op != 61)
			{
				int num = TokenId.assignOps[op - 351];
				int num2 = lookupBinOp(num);
				if (num2 < 0)
				{
					fatal();
				}
				atArithBinExpr(expr, num, num2, type);
			}
		}
		if (op != 61 || (dim == 0 && !isRefType(type)))
		{
			atNumCastExpr(exprType, type);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		166, 85, 103, 103, 103, 99, 144, 135, 103, 119,
		144, 103, 105, 103
	})]
	protected internal virtual void arrayAccess(ASTree array, ASTree index)
	{
		array.accept(this);
		int num = exprType;
		int num2 = arrayDim;
		if (num2 == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("bad array access");
		}
		string text = className;
		index.accept(this);
		if (typePrecedence(exprType) != 3 || arrayDim > 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("bad array index");
		}
		exprType = num;
		arrayDim = num2 - 1;
		className = text;
	}

	protected internal static int getArrayReadOp(int type, int dim)
	{
		if (dim > 0)
		{
			return 50;
		}
		switch (type)
		{
		case 312:
			return 49;
		case 317:
			return 48;
		case 326:
			return 47;
		case 324:
			return 46;
		case 334:
			return 53;
		case 306:
			return 52;
		case 301:
		case 303:
			return 51;
		default:
			return 50;
		}
	}

	protected internal static int getArrayWriteOp(int type, int dim)
	{
		if (dim > 0)
		{
			return 83;
		}
		switch (type)
		{
		case 312:
			return 82;
		case 317:
			return 81;
		case 326:
			return 80;
		case 324:
			return 79;
		case 334:
			return 86;
		case 306:
			return 85;
		case 301:
		case 303:
			return 84;
		default:
			return 83;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 99, 110, 134, 104, 104, 114, 154, 107, 103,
		107
	})]
	private void atStringPlusEq(Expr P_0, int P_1, int P_2, string P_3, ASTree P_4)
	{
		if (!String.instancehelper_equals("java/lang/String", P_3))
		{
			badAssign(P_0);
		}
		convToString(P_1, P_2);
		P_4.accept(this);
		convToString(exprType, arrayDim);
		bytecode.addInvokevirtual("java.lang.String", "concat", "(Ljava/lang/String;)Ljava/lang/String;");
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/String";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 149, 131, 101, 104, 98, 116, 103, 98, 116,
		103, 130, 130
	})]
	private bool invalidDim(int P_0, int P_1, string P_2, int P_3, int P_4, string P_5, bool P_6)
	{
		if (P_1 != P_4)
		{
			if (P_0 == 412)
			{
				return false;
			}
			if (P_4 == 0 && P_3 == 307 && String.instancehelper_equals("java/lang/Object", P_5))
			{
				return false;
			}
			if (P_6 && P_1 == 0 && P_0 == 307 && String.instancehelper_equals("java/lang/Object", P_2))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 235, 99, 136, 159, 1 })]
	protected internal static void badAssign(Expr expr)
	{
		string s = ((expr != null) ? new StringBuilder().append("incompatible type for ").append(expr.getName()).toString() : "incompatible type for assignment");
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[LineNumberTable(new byte[] { 163, 166, 102, 99, 102, 102, 2, 198 })]
	internal static int lookupBinOp(int P_0)
	{
		int[] array = binOp;
		int num = array.Length;
		for (int i = 0; i < num; i += 5)
		{
			if (array[i] == P_0)
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 222, 104, 134, 103, 120, 159, 1, 138, 136,
		138, 108, 100, 108, 99, 113, 139, 110, 193, 104
	})]
	private void atArithBinExpr(Expr P_0, int P_1, int P_2, int P_3)
	{
		if (arrayDim != 0)
		{
			badTypes(P_0);
		}
		int num = exprType;
		if (P_1 == 364 || P_1 == 366 || P_1 == 370)
		{
			if (num == 324 || num == 334 || num == 306 || num == 303)
			{
				exprType = P_3;
			}
			else
			{
				badTypes(P_0);
			}
		}
		else
		{
			convertOprandTypes(P_3, num, P_0);
		}
		int num2 = typePrecedence(exprType);
		if (num2 >= 0)
		{
			int num3 = binOp[P_2 + num2 + 1];
			if (num3 != 0)
			{
				if (num2 == 3 && exprType != 301)
				{
					exprType = 324;
				}
				bytecode.addOpcode(num3);
				return;
			}
		}
		badTypes(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		165, 130, 100, 161, 103, 103, 104, 142, 130, 104,
		107, 104, 104, 104, 104, 104, 104, 104, 104, 104,
		136, 130, 99, 140, 123, 99, 110
	})]
	internal virtual void atNumCastExpr(int P_0, int P_1)
	{
		if (P_0 != P_1)
		{
			int num = typePrecedence(P_0);
			int num2 = typePrecedence(P_1);
			int num3 = ((0 <= num && num < 3) ? castOp[num * 4 + num2] : 0);
			int num4 = P_1 switch
			{
				312 => 135, 
				317 => 134, 
				326 => 133, 
				334 => 147, 
				306 => 146, 
				303 => 145, 
				_ => 0, 
			};
			if (num3 != 0)
			{
				bytecode.addOpcode(num3);
			}
			if ((num3 == 0 || num3 == 136 || num3 == 139 || num3 == 142) && num4 != 0)
			{
				bytecode.addOpcode(num4);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 28, 134, 108, 159, 0, 104, 159, 0, 104,
		159, 0, 104, 159, 0, 104, 156, 104, 156, 104,
		144, 156
	})]
	private void convToString(int P_0, int P_1)
	{
		if (isRefType(P_0) || P_1 > 0)
		{
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;");
			return;
		}
		switch (P_0)
		{
		case 312:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(D)Ljava/lang/String;");
			break;
		case 317:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(F)Ljava/lang/String;");
			break;
		case 326:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(J)Ljava/lang/String;");
			break;
		case 301:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(Z)Ljava/lang/String;");
			break;
		case 306:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(C)Ljava/lang/String;");
			break;
		case 344:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("void type expression");
		default:
			bytecode.addInvokestatic("java.lang.String", "valueOf", "(I)Ljava/lang/String;");
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 253, 103, 103, 104, 115, 140, 99, 136, 105,
		109, 175, 173, 104, 141, 102, 136, 154, 107, 103,
		107
	})]
	private void atStringConcatExpr(Expr P_0, int P_1, int P_2, string P_3)
	{
		int num = exprType;
		int num2 = arrayDim;
		int num3 = (is2word(num, num2) ? 1 : 0);
		int num4 = ((num == 307 && String.instancehelper_equals("java/lang/String", className)) ? 1 : 0);
		if (num3 != 0)
		{
			convToString(num, num2);
		}
		if (is2word(P_1, P_2))
		{
			bytecode.addOpcode(91);
			bytecode.addOpcode(87);
		}
		else
		{
			bytecode.addOpcode(95);
		}
		convToString(P_1, P_2);
		bytecode.addOpcode(95);
		if (num3 == 0 && num4 == 0)
		{
			convToString(num, num2);
		}
		bytecode.addInvokevirtual("java.lang.String", "concat", "(Ljava/lang/String;)Ljava/lang/String;");
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/String";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(1365)]
	protected internal static void badTypes(Expr expr)
	{
		string s = new StringBuilder().append("invalid types for ").append(expr.getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		165, 25, 103, 135, 104, 129, 104, 166, 100, 98,
		103, 108, 165, 98, 108, 163, 102, 105, 103, 143,
		141, 109, 108, 109, 146, 101, 100, 109, 175, 141,
		108, 175, 135, 99, 110
	})]
	private void convertOprandTypes(int P_0, int P_1, Expr P_2)
	{
		int num = typePrecedence(P_0);
		int num2 = typePrecedence(P_1);
		if (num2 < 0 && num < 0)
		{
			return;
		}
		if (num2 < 0 || num < 0)
		{
			badTypes(P_2);
		}
		int num3;
		int num4;
		int num5;
		if (num <= num2)
		{
			num3 = 0;
			exprType = P_0;
			num4 = castOp[num2 * 4 + num];
			num5 = num;
		}
		else
		{
			num3 = 1;
			num4 = castOp[num * 4 + num2];
			num5 = num2;
		}
		if (num3 != 0)
		{
			switch (num5)
			{
			case 0:
			case 2:
				if (num == 0 || num == 2)
				{
					bytecode.addOpcode(94);
				}
				else
				{
					bytecode.addOpcode(93);
				}
				bytecode.addOpcode(88);
				bytecode.addOpcode(num4);
				bytecode.addOpcode(94);
				bytecode.addOpcode(88);
				break;
			case 1:
				if (num == 2)
				{
					bytecode.addOpcode(91);
					bytecode.addOpcode(87);
				}
				else
				{
					bytecode.addOpcode(95);
				}
				bytecode.addOpcode(num4);
				bytecode.addOpcode(95);
				break;
			default:
				fatal();
				break;
			}
		}
		else if (num4 != 0)
		{
			bytecode.addOpcode(num4);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 241, 104, 98, 104, 98, 104, 98, 104, 98,
		104, 130
	})]
	private static int typePrecedence(int P_0)
	{
		switch (P_0)
		{
		case 312:
			return 0;
		case 317:
			return 1;
		case 326:
			return 2;
		default:
			if (isRefType(P_0))
			{
				return -1;
			}
			if (P_0 == 344)
			{
				return -1;
			}
			return 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 122, 104, 103, 103, 101, 99, 191, 3, 134,
		162
	})]
	internal static int getCompOperator(ASTree P_0)
	{
		if (P_0 is Expr)
		{
			Expr expr = (Expr)P_0;
			int @operator = expr.getOperator();
			if (@operator == 33)
			{
				return 33;
			}
			if (expr is BinExpr && @operator != 368 && @operator != 369 && @operator != 38 && @operator != 124)
			{
				return 358;
			}
			return @operator;
		}
		return 32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		164, 139, 108, 103, 103, 108, 105, 117, 112, 109,
		135, 104, 103
	})]
	private int compileOprands(BinExpr P_0)
	{
		P_0.oprand1().accept(this);
		int num = exprType;
		int num2 = arrayDim;
		P_0.oprand2().accept(this);
		if (num2 != arrayDim)
		{
			if (num != 412 && exprType != 412)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("incompatible array types");
			}
			if (exprType == 412)
			{
				arrayDim = num2;
			}
		}
		if (num == 412)
		{
			return exprType;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 70, 162, 104, 143, 108, 109, 104, 127, 0,
		104, 159, 0, 140, 100, 102, 103, 102, 120, 225,
		61, 230, 70, 103, 133, 99, 109, 149, 114, 100,
		109, 146, 114, 100, 146, 133, 102, 103, 102, 120,
		225, 61, 230, 70, 137
	})]
	private void compareExpr(bool P_0, int P_1, int P_2, BinExpr P_3)
	{
		if (arrayDim == 0)
		{
			convertOprandTypes(P_2, exprType, P_3);
		}
		int num = typePrecedence(exprType);
		if (num == -1 || arrayDim > 0)
		{
			switch (P_1)
			{
			case 358:
				bytecode.addOpcode((!P_0) ? 166 : 165);
				break;
			case 350:
				bytecode.addOpcode((!P_0) ? 165 : 166);
				break;
			default:
				badTypes(P_3);
				break;
			}
			return;
		}
		int[] array;
		switch (num)
		{
		case 3:
		{
			array = ifOp;
			for (int i = 0; i < (nint)array.LongLength; i += 3)
			{
				if (array[i] == P_1)
				{
					bytecode.addOpcode(array[i + (P_0 ? 1 : 2)]);
					return;
				}
			}
			badTypes(P_3);
			return;
		}
		case 0:
			if (P_1 == 60 || P_1 == 357)
			{
				bytecode.addOpcode(152);
			}
			else
			{
				bytecode.addOpcode(151);
			}
			break;
		case 1:
			if (P_1 == 60 || P_1 == 357)
			{
				bytecode.addOpcode(150);
			}
			else
			{
				bytecode.addOpcode(149);
			}
			break;
		case 2:
			bytecode.addOpcode(148);
			break;
		default:
			fatal();
			break;
		}
		array = ifOp2;
		for (int i = 0; i < (nint)array.LongLength; i += 3)
		{
			if (array[i] == P_1)
			{
				bytecode.addOpcode(array[i + (P_0 ? 1 : 2)]);
				return;
			}
		}
		badTypes(P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 86, 162, 104, 108, 190 })]
	private static bool isAlwaysBranch(ASTree P_0, bool P_1)
	{
		if (P_0 is Keyword)
		{
			int num = ((Keyword)P_0).get();
			return P_1 ? (num == 410) : (num == 411);
		}
		return false;
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract string resolveClassName(ASTList astl);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		165, 103, 102, 103, 103, 103, 103, 103, 104, 159,
		10, 144, 104, 108, 144, 170, 100, 138
	})]
	private string checkCastExpr(CastExpr P_0, string P_1)
	{
		ASTree oprand = P_0.getOprand();
		int num = P_0.getArrayDim();
		int type = P_0.getType();
		oprand.accept(this);
		int num2 = exprType;
		int num3 = arrayDim;
		if (!invalidDim(num2, arrayDim, className, type, num, P_1, true) && num2 != 344)
		{
			switch (type)
			{
			case 344:
				break;
			case 307:
			{
				if (!isRefType(num2) && num3 == 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError("invalid cast");
				}
				string result2 = toJvmArrayName(P_1, num);
				_ = null;
				return result2;
			}
			default:
				if (num > 0)
				{
					string result = toJvmTypeName(type, num);
					_ = null;
					return result;
				}
				return null;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("invalid cast");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 81, 99, 130, 99, 98, 102, 98, 104, 139,
		105, 104, 137
	})]
	protected internal static string toJvmArrayName(string name, int dim)
	{
		if (name == null)
		{
			return null;
		}
		if (dim == 0)
		{
			return name;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = dim;
		while (true)
		{
			int num2 = num;
			num += -1;
			if (num2 <= 0)
			{
				break;
			}
			stringBuilder.append('[');
		}
		stringBuilder.append('L');
		stringBuilder.append(name);
		stringBuilder.append(';');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 99, 99, 159, 87, 99, 130, 99, 130, 99,
		130, 99, 130, 99, 130, 99, 130, 99, 130, 99,
		130, 195, 102, 105, 139, 104
	})]
	protected internal static string toJvmTypeName(int type, int dim)
	{
		int c = 73;
		switch (type)
		{
		case 301:
			c = 90;
			break;
		case 303:
			c = 66;
			break;
		case 306:
			c = 67;
			break;
		case 334:
			c = 83;
			break;
		case 324:
			c = 73;
			break;
		case 326:
			c = 74;
			break;
		case 317:
			c = 70;
			break;
		case 312:
			c = 68;
			break;
		case 344:
			c = 86;
			break;
		}
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			int num = dim;
			dim += -1;
			if (num <= 0)
			{
				break;
			}
			stringBuilder.append('[');
		}
		stringBuilder.append((char)c);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		166, 0, 103, 104, 144, 108, 112, 108, 103, 114,
		105, 234, 69, 105, 103, 104, 140, 120, 168, 130,
		109, 167, 103, 107, 103, 107
	})]
	public virtual void atClassObject(Expr expr)
	{
		ASTree aSTree = expr.oprand1();
		if (!(aSTree is Symbol))
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("fatal error: badly parsed .class expr");
		}
		string text = ((Symbol)aSTree).get();
		if (String.instancehelper_startsWith(text, "["))
		{
			int num = String.instancehelper_indexOf(text, "[L");
			if (num >= 0)
			{
				string text2 = String.instancehelper_substring(text, num + 2, String.instancehelper_length(text) - 1);
				string text3 = resolveClassName(text2);
				if (!String.instancehelper_equals(text2, text3))
				{
					text3 = MemberResolver.jvmToJavaName(text3);
					StringBuilder stringBuilder = new StringBuilder();
					while (true)
					{
						int num2 = num;
						num += -1;
						if (num2 < 0)
						{
							break;
						}
						stringBuilder.append('[');
					}
					stringBuilder.append('L').append(text3).append(';');
					text = stringBuilder.toString();
				}
			}
		}
		else
		{
			text = resolveClassName(MemberResolver.javaToJvmName(text));
			text = MemberResolver.jvmToJavaName(text);
		}
		atClassObject2(text);
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/Class";
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract void atFieldRead(ASTree ast);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 166, 78, 104, 126 })]
	public virtual void atArrayRead(ASTree array, ASTree index)
	{
		arrayAccess(array, index);
		bytecode.addOpcode(getArrayReadOp(exprType, arrayDim));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(1641)]
	protected internal static void badType(Expr expr)
	{
		string s = new StringBuilder().append("invalid type for ").append(expr.getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		166, 39, 108, 108, 154, 108, 112, 108, 140, 253,
		83, 108, 186, 112, 125
	})]
	protected internal virtual void atClassObject2(string cname)
	{
		int start = bytecode.currentPc();
		bytecode.addLdc(cname);
		bytecode.addInvokestatic("java.lang.Class", "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
		int end = bytecode.currentPc();
		bytecode.addOpcode(167);
		int num = bytecode.currentPc();
		bytecode.addIndex(0);
		bytecode.addExceptionHandler(start, end, bytecode.currentPc(), "java.lang.ClassNotFoundException");
		bytecode.growStack(1);
		bytecode.addInvokestatic("javassist.runtime.DotClass", "fail", "(Ljava/lang/ClassNotFoundException;)Ljava/lang/NoClassDefFoundError;");
		bytecode.addOpcode(191);
		bytecode.write16bit(num, bytecode.currentPc() - num + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		157, 181, 69, 114, 103, 103, 100, 134, 109, 119,
		113, 108, 116
	})]
	public virtual void atArrayPlusPlus(int token, bool isPost, Expr expr, bool doDup)
	{
		arrayAccess(expr.oprand1(), expr.oprand2());
		int type = exprType;
		int num = arrayDim;
		if (num > 0)
		{
			badType(expr);
		}
		bytecode.addOpcode(92);
		bytecode.addOpcode(getArrayReadOp(type, arrayDim));
		int dup_code = ((!is2word(type, num)) ? 91 : 94);
		atPlusPlusCore(dup_code, doDup, token, isPost, expr);
		bytecode.addOpcode(getArrayWriteOp(type, num));
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract void atFieldPlusPlus(int i, bool b1, ASTree ast, Expr e, bool b2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		157, 177, 101, 135, 102, 140, 127, 1, 108, 121,
		144, 104, 109, 158, 104, 112, 155, 104, 112, 187,
		135, 102, 110
	})]
	protected internal virtual void atPlusPlusCore(int dup_code, bool doDup, int token, bool isPost, Expr expr)
	{
		int num = exprType;
		if (doDup && isPost)
		{
			bytecode.addOpcode(dup_code);
		}
		switch (num)
		{
		case 303:
		case 306:
		case 324:
		case 334:
			bytecode.addIconst(1);
			bytecode.addOpcode((token != 362) ? 100 : 96);
			exprType = 324;
			break;
		case 326:
			bytecode.addLconst(1L);
			bytecode.addOpcode((token != 362) ? 101 : 97);
			break;
		case 317:
			bytecode.addFconst(1f);
			bytecode.addOpcode((token != 362) ? 102 : 98);
			break;
		case 312:
			bytecode.addDconst(1.0);
			bytecode.addOpcode((token != 362) ? 103 : 99);
			break;
		default:
			badType(expr);
			break;
		}
		if (doDup && !isPost)
		{
			bytecode.addOpcode(dup_code);
		}
	}

	protected internal abstract string getThisName();

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal abstract string getSuperName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 104, 103, 103, 103, 103, 103, 103, 103, 103 })]
	public CodeGen(Bytecode b)
	{
		bytecode = b;
		tempVar = -1;
		typeChecker = null;
		hasReturned = false;
		inStaticMethod = false;
		breakList = null;
		continueList = null;
		returnHooks = null;
	}

	public virtual void setTypeChecker(TypeChecker checker)
	{
		typeChecker = checker;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 97, 105, 108, 167 })]
	protected internal virtual int getTempVar()
	{
		if (tempVar < 0)
		{
			tempVar = getMaxLocals();
			incMaxLocals(2);
		}
		return tempVar;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(270)]
	public override void atASTList(ASTList n)
	{
		fatal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(273)]
	public override void atPair(Pair n)
	{
		fatal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(276)]
	public override void atSymbol(Symbol n)
	{
		fatal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 166, 110 })]
	public override void atFieldDecl(FieldDecl field)
	{
		field.getInit().accept(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 171, 103, 103, 99, 108, 103, 109, 103, 135,
		130, 103, 99, 113, 169, 103, 105, 49, 135
	})]
	public override void atMethodDecl(MethodDecl method)
	{
		ASTList aSTList = method.getModifiers();
		setMaxLocals(1);
		while (aSTList != null)
		{
			Keyword keyword = (Keyword)aSTList.head();
			aSTList = aSTList.tail();
			if (keyword.get() == 335)
			{
				setMaxLocals(0);
				inStaticMethod = true;
			}
		}
		for (ASTList aSTList2 = method.getParams(); aSTList2 != null; aSTList2 = aSTList2.tail())
		{
			atDeclarator((Declarator)aSTList2.head());
		}
		Stmnt body = method.getBody();
		atMethodBody(body, method.isConstructor(), method.getReturn().getType() == 344);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 240, 99, 129, 103, 104, 103, 103, 104, 114,
		104, 103, 116, 130, 103, 115, 111, 109, 141, 101,
		106, 98, 99, 104, 103, 100, 104, 98, 101, 104,
		108, 112, 116, 104, 108, 112, 116, 104, 108, 104,
		108, 104, 105, 104, 105, 104, 169, 103, 191, 6
	})]
	public override void atStmnt(Stmnt st)
	{
		if (st == null)
		{
			return;
		}
		int @operator = st.getOperator();
		switch (@operator)
		{
		case 69:
		{
			ASTree left = st.getLeft();
			doTypeCheck(left);
			if (left is AssignExpr)
			{
				atAssignExpr((AssignExpr)left, doDup: false);
				break;
			}
			if (isPlusPlusExpr(left))
			{
				Expr expr = (Expr)left;
				atPlusPlus(expr.getOperator(), expr.oprand1(), expr, false);
				break;
			}
			left.accept(this);
			if (is2word(exprType, arrayDim))
			{
				bytecode.addOpcode(88);
			}
			else if (exprType != 344)
			{
				bytecode.addOpcode(87);
			}
			break;
		}
		case 66:
		case 68:
		{
			ASTList aSTList = st;
			while (aSTList != null)
			{
				ASTree aSTree = aSTList.head();
				aSTList = aSTList.tail();
				aSTree?.accept(this);
			}
			break;
		}
		case 320:
			atIfStmnt(st);
			break;
		case 311:
		case 346:
			atWhileStmnt(st, @operator == 346);
			break;
		case 318:
			atForStmnt(st);
			break;
		case 302:
		case 309:
			atBreakStmnt(st, @operator == 302);
			break;
		case 333:
			atReturnStmnt(st);
			break;
		case 340:
			atThrowStmnt(st);
			break;
		case 343:
			atTryStmnt(st);
			break;
		case 337:
			atSwitchStmnt(st);
			break;
		case 338:
			atSyncStmnt(st);
			break;
		default:
		{
			hasReturned = false;
			string s = new StringBuilder().append("sorry, not supported statement: TokenId ").append(@operator).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		}
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public abstract override void atNewExpr(NewExpr ne);

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public abstract override void atArrayInit(ArrayInit ai);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 206, 106 })]
	public override void atAssignExpr(AssignExpr expr)
	{
		atAssignExpr(expr, doDup: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 133, 111, 145, 108, 108, 108, 103, 112, 108,
		108, 123, 108, 105, 144, 157
	})]
	public override void atCondExpr(CondExpr expr)
	{
		if (booleanExpr(false, expr.condExpr()))
		{
			expr.elseExpr().accept(this);
			return;
		}
		int num = bytecode.currentPc();
		bytecode.addIndex(0);
		expr.thenExpr().accept(this);
		int num2 = arrayDim;
		bytecode.addOpcode(167);
		int num3 = bytecode.currentPc();
		bytecode.addIndex(0);
		bytecode.write16bit(num, bytecode.currentPc() - num + 1);
		expr.elseExpr().accept(this);
		if (num2 != arrayDim)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("type mismatch in ?:");
		}
		bytecode.write16bit(num3, bytecode.currentPc() - num3 + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 177, 199, 103, 103, 108, 103, 99, 129, 103,
		104, 104, 103, 106, 144, 158, 142, 106, 194, 106,
		108, 108, 112, 172, 142
	})]
	public override void atBinExpr(BinExpr expr)
	{
		int @operator = expr.getOperator();
		int num = lookupBinOp(@operator);
		if (num >= 0)
		{
			expr.oprand1().accept(this);
			ASTree aSTree = expr.oprand2();
			if (aSTree != null)
			{
				int num2 = exprType;
				int num3 = arrayDim;
				string text = className;
				aSTree.accept(this);
				if (num3 != arrayDim)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError("incompatible array types");
				}
				if (@operator == 43 && num3 == 0 && (num2 == 307 || exprType == 307))
				{
					atStringConcatExpr(expr, num2, num3, text);
				}
				else
				{
					atArithBinExpr(expr, @operator, num, num2);
				}
			}
		}
		else
		{
			if (!booleanExpr(true, expr))
			{
				bytecode.addIndex(7);
				bytecode.addIconst(0);
				bytecode.addOpcode(167);
				bytecode.addIndex(4);
			}
			bytecode.addIconst(1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1395)]
	internal static bool isP_INT(int P_0)
	{
		return typePrecedence(P_0) == 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 6, 103, 103 })]
	internal static bool rightIsStrong(int P_0, int P_1)
	{
		int num = typePrecedence(P_0);
		int num2 = typePrecedence(P_1);
		return (num >= 0 && num2 >= 0 && num > num2) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		165, 79, 109, 105, 103, 108, 108, 103, 99, 143,
		110
	})]
	public override void atCastExpr(CastExpr expr)
	{
		string text = resolveClassName(expr.getClassName());
		string text2 = checkCastExpr(expr, text);
		int num = exprType;
		exprType = expr.getType();
		arrayDim = expr.getArrayDim();
		className = text;
		if (text2 == null)
		{
			atNumCastExpr(num, exprType);
		}
		else
		{
			bytecode.addCheckcast(text2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 165, 93, 109, 105, 108, 107, 103 })]
	public override void atInstanceOfExpr(InstanceOfExpr expr)
	{
		string text = resolveClassName(expr.getClassName());
		string classname = checkCastExpr(expr, text);
		bytecode.addInstanceof(classname);
		exprType = 301;
		arrayDim = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		165, 169, 103, 103, 101, 113, 109, 137, 103, 101,
		229, 69, 140, 101, 114, 112, 111, 101, 106, 108,
		108, 112, 172, 145, 101, 138, 108, 108, 105, 134,
		104, 99, 114, 100, 114, 100, 114, 100, 109, 176,
		139, 101, 100, 108, 112, 141, 100, 109, 178, 168,
		101, 100, 232, 69, 135
	})]
	public override void atExpr(Expr expr)
	{
		int @operator = expr.getOperator();
		ASTree aSTree = expr.oprand1();
		switch (@operator)
		{
		case 46:
		{
			string @this = ((Symbol)expr.oprand2()).get();
			if (String.instancehelper_equals(@this, "class"))
			{
				atClassObject(expr);
			}
			else
			{
				atFieldRead(expr);
			}
			return;
		}
		case 35:
			atFieldRead(expr);
			return;
		case 65:
			atArrayRead(aSTree, expr.oprand2());
			return;
		case 362:
		case 363:
			atPlusPlus(@operator, aSTree, expr, true);
			return;
		case 33:
			if (!booleanExpr(false, expr))
			{
				bytecode.addIndex(7);
				bytecode.addIconst(1);
				bytecode.addOpcode(167);
				bytecode.addIndex(4);
			}
			bytecode.addIconst(0);
			return;
		case 67:
			fatal();
			return;
		}
		expr.oprand1().accept(this);
		int num = typePrecedence(exprType);
		if (arrayDim > 0)
		{
			badType(expr);
		}
		switch (@operator)
		{
		case 45:
			switch (num)
			{
			case 0:
				bytecode.addOpcode(119);
				break;
			case 1:
				bytecode.addOpcode(118);
				break;
			case 2:
				bytecode.addOpcode(117);
				break;
			case 3:
				bytecode.addOpcode(116);
				exprType = 324;
				break;
			default:
				badType(expr);
				break;
			}
			break;
		case 126:
			switch (num)
			{
			case 3:
				bytecode.addIconst(-1);
				bytecode.addOpcode(130);
				exprType = 324;
				break;
			case 2:
				bytecode.addLconst(-1L);
				bytecode.addOpcode(131);
				break;
			default:
				badType(expr);
				break;
			}
			break;
		case 43:
			if (num == -1)
			{
				badType(expr);
			}
			break;
		default:
			fatal();
			break;
		}
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public abstract override void atCallExpr(CallExpr ce);

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public abstract override void atMember(Member m);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		167, 70, 103, 103, 159, 37, 108, 107, 133, 108,
		107, 133, 108, 107, 165, 104, 111, 159, 10, 108,
		107, 104, 142, 108, 130, 135
	})]
	public override void atKeyword(Keyword k)
	{
		arrayDim = 0;
		int num = k.get();
		switch (num)
		{
		case 410:
			bytecode.addIconst(1);
			exprType = 301;
			break;
		case 411:
			bytecode.addIconst(0);
			exprType = 301;
			break;
		case 412:
			bytecode.addOpcode(1);
			exprType = 412;
			break;
		case 336:
		case 339:
			if (inStaticMethod)
			{
				string s = new StringBuilder().append("not-available: ").append((num != 339) ? "super" : "this").toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(s);
			}
			bytecode.addAload(0);
			exprType = 307;
			if (num == 339)
			{
				className = getThisName();
			}
			else
			{
				className = getSuperName();
			}
			break;
		default:
			fatal();
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 167, 105, 107, 103, 107, 115 })]
	public override void atStringL(StringL s)
	{
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/String";
		bytecode.addLdc(s.get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 167, 113, 103, 103, 103, 112, 122, 175, 107, 142 })]
	public override void atIntConst(IntConst i)
	{
		arrayDim = 0;
		long num = i.get();
		int type = i.getType();
		if (type == 402 || type == 401)
		{
			exprType = ((type != 402) ? 306 : 324);
			bytecode.addIconst((int)num);
		}
		else
		{
			exprType = 326;
			bytecode.addLconst(num);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 167, 128, 103, 109, 107, 179, 107, 148 })]
	public override void atDoubleConst(DoubleConst d)
	{
		arrayDim = 0;
		if (d.getType() == 405)
		{
			exprType = 312;
			bytecode.addDconst(d.get());
		}
		else
		{
			exprType = 317;
			bytecode.addFconst((float)d.get());
		}
	}

	[LineNumberTable(new byte[]
	{
		163,
		152,
		byte.MaxValue,
		160,
		247,
		161,
		2,
		byte.MaxValue,
		160,
		64,
		71,
		byte.MaxValue,
		160,
		64,
		160,
		106
	})]
	static CodeGen()
	{
		binOp = new int[55]
		{
			43, 99, 98, 97, 96, 45, 103, 102, 101, 100,
			42, 107, 106, 105, 104, 47, 111, 110, 109, 108,
			37, 115, 114, 113, 112, 124, 0, 0, 129, 128,
			94, 0, 0, 131, 130, 38, 0, 0, 127, 126,
			364, 0, 0, 121, 120, 366, 0, 0, 123, 122,
			370, 0, 0, 125, 124
		};
		ifOp = new int[18]
		{
			358, 159, 160, 350, 160, 159, 357, 164, 163, 359,
			162, 161, 60, 161, 162, 62, 163, 164
		};
		ifOp2 = new int[18]
		{
			358, 153, 154, 350, 154, 153, 357, 158, 157, 359,
			156, 155, 60, 155, 156, 62, 157, 158
		};
		castOp = new int[16]
		{
			0, 144, 143, 142, 141, 0, 140, 139, 138, 137,
			0, 136, 135, 134, 133, 0
		};
	}
}
