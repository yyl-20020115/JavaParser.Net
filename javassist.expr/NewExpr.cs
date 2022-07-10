using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;
using javassist.compiler.ast;

namespace javassist.expr;

public class NewExpr : Expr
{
	internal class ProceedForNew : Object, ProceedHandler
	{
		internal CtClass newType;

		internal int newIndex;

		internal int methodIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 132, 104, 103, 103, 103 })]
		internal ProceedForNew(CtClass P_0, int P_1, int P_2)
		{
			newType = P_0;
			newIndex = P_1;
			methodIndex = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 142, 107, 108, 104, 150, 110 })]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			P_1.addOpcode(187);
			P_1.addIndex(newIndex);
			P_1.addOpcode(89);
			P_0.atMethodCallCore(newType, "<init>", P_2, isStatic: false, isSpecial: true, -1, null);
			P_0.setType(newType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 154, 115, 110 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.atMethodCallCore(newType, "<init>", P_1);
			P_0.setType(newType);
		}
	}

	internal string newTypeName;

	internal int newPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 109, 104, 104 })]
	protected internal NewExpr(int pos, CodeIterator i, CtClass declaring, MethodInfo m, string type, int np)
		: base(pos, i, declaring, m)
	{
		newTypeName = type;
		newPos = np;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(103)]
	private CtClass getCtClass()
	{
		CtClass result = thisClass.getClassPool().get(newTypeName);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 112, 116, 101, 127, 6, 45, 129, 115, 105, 130 })]
	private int canReplace()
	{
		switch (iterator.byteAt(newPos + 3))
		{
		case 89:
			return (iterator.byteAt(newPos + 4) != 94 || iterator.byteAt(newPos + 5) != 88) ? 4 : 6;
		case 90:
			if (iterator.byteAt(newPos + 4) == 95)
			{
				return 5;
			}
			break;
		}
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public override CtBehavior where()
	{
		CtBehavior result = base.where();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(86)]
	public override int getLineNumber()
	{
		int lineNumber = base.getLineNumber();
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public override string getFileName()
	{
		string fileName = base.getFileName();
		_ = null;
		return fileName;
	}

	public virtual string getClassName()
	{
		return newTypeName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 74, 103, 116 })]
	public virtual string getSignature()
	{
		ConstPool constPool = getConstPool();
		int index = iterator.u16bitAt(currentPos + 1);
		string methodrefType = constPool.getMethodrefType(index);
		_ = null;
		return methodrefType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 83, 103, 116, 104 })]
	public virtual CtConstructor getConstructor()
	{
		ConstPool constPool = getConstPool();
		int index = iterator.u16bitAt(currentPos + 1);
		string methodrefType = constPool.getMethodrefType(index);
		CtConstructor constructor = getCtClass().getConstructor(methodrefType);
		_ = null;
		return constructor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(147)]
	public override CtClass[] mayThrow()
	{
		CtClass[] result = base.mayThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160,
		71,
		140,
		98,
		135,
		207,
		103,
		100,
		104,
		46,
		168,
		104,
		103,
		144,
		139,
		109,
		109,
		141,
		107,
		111,
		105,
		110,
		37,
		134,
		108,
		241,
		69,
		137,
		105,
		108,
		139,
		105,
		140,
		104,
		100,
		137,
		byte.MaxValue,
		18,
		70,
		226,
		60,
		111,
		111,
		97,
		144
	})]
	public override void replace(string statement)
	{
		thisClass.getClassFile();
		_ = 3;
		int num = newPos;
		int num2 = iterator.u16bitAt(num + 1);
		int num3 = canReplace();
		int num4 = num + num3;
		for (int i = num; i < num4; i++)
		{
			iterator.writeByte(0, i);
		}
		ConstPool constPool = getConstPool();
		num = currentPos;
		int num5 = iterator.u16bitAt(num + 1);
		string methodrefType = constPool.getMethodrefType(num5);
		Javac javac = new Javac(thisClass);
		ClassPool classPool = thisClass.getClassPool();
		CodeAttribute codeAttribute = iterator.get();
		CompileError compileError;
		NotFoundException ex;
		try
		{
			try
			{
				try
				{
					CtClass[] parameterTypes = Descriptor.getParameterTypes(methodrefType, classPool);
					CtClass ctClass = classPool.get(newTypeName);
					int num6 = codeAttribute.getMaxLocals();
					javac.recordParams(newTypeName, parameterTypes, use0: true, num6, withinStatic());
					int n = javac.recordReturnType(ctClass, useResultVar: true);
					javac.recordProceed(new ProceedForNew(ctClass, num2, num5));
					Expr.checkResultValue(ctClass, statement);
					Bytecode bytecode = javac.getBytecode();
					Expr.storeStack(parameterTypes, true, num6, bytecode);
					javac.recordLocalVariables(codeAttribute, num);
					bytecode.addConstZero(ctClass);
					bytecode.addStore(n, ctClass);
					javac.compileStmnt(statement);
					if (num3 > 3)
					{
						bytecode.addAload(n);
					}
					replace0(num, bytecode, 3);
					return;
				}
				catch (CompileError x)
				{
					compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (NotFoundException x2)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0174;
			}
		}
		catch (BadBytecode)
		{
			goto IL_0178;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0178:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("broken method");
		IL_0174:
		NotFoundException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}
}
