using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;
using javassist.compiler.ast;

namespace javassist.expr;

public class FieldAccess : Expr
{
	internal class ProceedForRead : Object, ProceedHandler
	{
		internal CtClass fieldType;

		internal int opcode;

		internal int targetVar;

		internal int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 140, 104, 103, 104, 103, 103 })]
		internal ProceedForRead(CtClass P_0, int P_1, int P_2, int P_3)
		{
			fieldType = P_0;
			targetVar = P_3;
			opcode = P_1;
			index = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[]
		{
			160, 151, 108, 208, 109, 132, 98, 172, 109, 149,
			132, 108, 108, 103, 110
		})]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			if (P_2 != null && !P_0.isParamListName(P_2))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$proceed() cannot take a parameter for field reading");
			}
			int num;
			if (isStatic(opcode))
			{
				num = 0;
			}
			else
			{
				num = -1;
				P_1.addAload(targetVar);
			}
			num = ((!(fieldType is CtPrimitiveType)) ? (num + 1) : (num + ((CtPrimitiveType)fieldType).getDataSize()));
			P_1.add(opcode);
			P_1.addIndex(index);
			P_1.growStack(num);
			P_0.setType(fieldType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 178, 110 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.setType(fieldType);
		}
	}

	internal class ProceedForWrite : Object, ProceedHandler
	{
		internal CtClass fieldType;

		internal int opcode;

		internal int targetVar;

		internal int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 190, 104, 103, 104, 103, 103 })]
		internal ProceedForWrite(CtClass P_0, int P_1, int P_2, int P_3)
		{
			fieldType = P_0;
			targetVar = P_3;
			opcode = P_1;
			index = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[]
		{
			160, 201, 106, 240, 69, 109, 132, 98, 172, 121,
			108, 109, 149, 132, 108, 108, 103, 107, 104
		})]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			if (P_0.getMethodArgsLength(P_2) != 1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$proceed() cannot take more than one parameter for field writing");
			}
			int num;
			if (isStatic(opcode))
			{
				num = 0;
			}
			else
			{
				num = -1;
				P_1.addAload(targetVar);
			}
			P_0.atMethodArgs(P_2, new int[1], new int[1], new string[1]);
			P_0.doNumCast(fieldType);
			num = ((!(fieldType is CtPrimitiveType)) ? (num + -1) : (num - ((CtPrimitiveType)fieldType).getDataSize()));
			P_1.add(opcode);
			P_1.addIndex(index);
			P_1.growStack(num);
			P_0.setType(CtClass.voidType);
			P_0.addNullIfVoid();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 232, 121, 107, 104 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.atMethodArgs(P_1, new int[1], new int[1], new string[1]);
			P_0.setType(CtClass.voidType);
			P_0.addNullIfVoid();
		}
	}

	internal int opcode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 109, 104 })]
	protected internal FieldAccess(int pos, CodeIterator i, CtClass declaring, MethodInfo m, int op)
		: base(pos, i, declaring, m)
	{
		opcode = op;
	}

	internal static bool isStatic(int P_0)
	{
		return (P_0 == 178 || P_0 == 179) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 67, 116 })]
	public virtual string getClassName()
	{
		int index = iterator.u16bitAt(currentPos + 1);
		string fieldrefClassName = getConstPool().getFieldrefClassName(index);
		_ = null;
		return fieldrefClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(110)]
	private CtClass getCtClass()
	{
		CtClass result = thisClass.getClassPool().get(getClassName());
		_ = null;
		return result;
	}

	public virtual bool isReader()
	{
		return (opcode == 180 || opcode == 178) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(85)]
	public virtual bool isStatic()
	{
		bool result = isStatic(opcode);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public override CtBehavior where()
	{
		CtBehavior result = base.where();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public override int getLineNumber()
	{
		int lineNumber = base.getLineNumber();
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public override string getFileName()
	{
		string fileName = base.getFileName();
		_ = null;
		return fileName;
	}

	public virtual bool isWriter()
	{
		return (opcode == 181 || opcode == 179) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 75, 116 })]
	public virtual string getFieldName()
	{
		int index = iterator.u16bitAt(currentPos + 1);
		string fieldrefName = getConstPool().getFieldrefName(index);
		_ = null;
		return fieldrefName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 83, 103, 116, 103 })]
	public virtual CtField getField()
	{
		CtClass ctClass = getCtClass();
		int index = iterator.u16bitAt(currentPos + 1);
		ConstPool constPool = getConstPool();
		CtField field = ctClass.getField(constPool.getFieldrefName(index), constPool.getFieldrefType(index));
		_ = null;
		return field;
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
	[LineNumberTable(new byte[] { 109, 116 })]
	public virtual string getSignature()
	{
		int index = iterator.u16bitAt(currentPos + 1);
		string fieldrefType = getConstPool().getFieldrefType(index);
		_ = null;
		return fieldrefType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		125,
		108,
		103,
		103,
		143,
		108,
		205,
		98,
		107,
		37,
		135,
		104,
		100,
		104,
		166,
		104,
		102,
		167,
		105,
		110,
		37,
		230,
		69,
		106,
		100,
		131,
		108,
		100,
		216,
		104,
		216,
		104,
		113,
		138,
		100,
		105,
		104,
		171,
		105,
		172,
		103,
		100,
		140,
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
		ConstPool constPool = getConstPool();
		int num = currentPos;
		int num2 = iterator.u16bitAt(num + 1);
		Javac javac = new Javac(thisClass);
		CodeAttribute codeAttribute = iterator.get();
		CompileError compileError;
		NotFoundException ex;
		try
		{
			try
			{
				try
				{
					CtClass ctClass = Descriptor.toCtClass(constPool.getFieldrefType(num2), thisClass.getClassPool());
					int num3 = (isReader() ? 1 : 0);
					CtClass[] array;
					CtClass ctClass2;
					if (num3 != 0)
					{
						array = new CtClass[0];
						ctClass2 = ctClass;
					}
					else
					{
						array = new CtClass[1] { ctClass };
						ctClass2 = CtClass.voidType;
					}
					int num4 = codeAttribute.getMaxLocals();
					javac.recordParams(constPool.getFieldrefClassName(num2), array, use0: true, num4, withinStatic());
					int num5 = (Expr.checkResultValue(ctClass2, statement) ? 1 : 0);
					if (num3 != 0)
					{
						num5 = 1;
					}
					int n = javac.recordReturnType(ctClass2, (byte)num5 != 0);
					if (num3 != 0)
					{
						javac.recordProceed(new ProceedForRead(ctClass2, opcode, num2, num4));
					}
					else
					{
						javac.recordType(ctClass);
						javac.recordProceed(new ProceedForWrite(array[0], opcode, num2, num4));
					}
					Bytecode bytecode = javac.getBytecode();
					Expr.storeStack(array, isStatic(), num4, bytecode);
					javac.recordLocalVariables(codeAttribute, num);
					if (num5 != 0)
					{
						if (ctClass2 == CtClass.voidType)
						{
							bytecode.addOpcode(1);
							bytecode.addAstore(n);
						}
						else
						{
							bytecode.addConstZero(ctClass2);
							bytecode.addStore(n, ctClass2);
						}
					}
					javac.compileStmnt(statement);
					if (num3 != 0)
					{
						bytecode.addLoad(n, ctClass2);
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
				goto IL_019e;
			}
		}
		catch (BadBytecode)
		{
			goto IL_01a2;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_01a2:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("broken method");
		IL_019e:
		NotFoundException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}
}
