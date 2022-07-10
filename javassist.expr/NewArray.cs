using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;
using javassist.compiler.ast;

namespace javassist.expr;

public class NewArray : Expr
{
	internal class ProceedForArray : Object, ProceedHandler
	{
		internal CtClass arrayType;

		internal int opcode;

		internal int index;

		internal int dimension;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 151, 104, 103, 103, 103, 104 })]
		internal ProceedForArray(CtClass P_0, int P_1, int P_2, int P_3)
		{
			arrayType = P_0;
			opcode = P_1;
			index = P_2;
			dimension = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[]
		{
			160, 162, 104, 105, 176, 153, 108, 109, 110, 109,
			142, 108, 108, 174, 110
		})]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			int methodArgsLength = P_0.getMethodArgsLength(P_2);
			if (methodArgsLength != dimension)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$proceed() with a wrong number of parameters");
			}
			P_0.atMethodArgs(P_2, new int[methodArgsLength], new int[methodArgsLength], new string[methodArgsLength]);
			P_1.addOpcode(opcode);
			if (opcode == 189)
			{
				P_1.addIndex(index);
			}
			else if (opcode == 188)
			{
				P_1.add(index);
			}
			else
			{
				P_1.addIndex(index);
				P_1.add(dimension);
				P_1.growStack(1 - dimension);
			}
			P_0.setType(arrayType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 187, 110 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.setType(arrayType);
		}
	}

	internal int opcode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 109, 104 })]
	protected internal NewArray(int pos, CodeIterator i, CtClass declaring, MethodInfo m, int op)
		: base(pos, i, declaring, m)
	{
		opcode = op;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		67, 159, 11, 134, 134, 134, 134, 134, 134, 134,
		134
	})]
	internal virtual CtClass getPrimitiveType(int P_0)
	{
		switch (P_0)
		{
		case 4:
			return CtClass.booleanType;
		case 5:
			return CtClass.charType;
		case 6:
			return CtClass.floatType;
		case 7:
			return CtClass.doubleType;
		case 8:
			return CtClass.byteType;
		case 9:
			return CtClass.shortType;
		case 10:
			return CtClass.intType;
		case 11:
			return CtClass.longType;
		default:
		{
			string message = new StringBuilder().append("bad atype: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError", "javassist.NotFoundException", "javassist.bytecode.BadBytecode", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 79, 108, 103, 167, 98, 130, 109, 116, 110,
		127, 3, 99, 101, 112, 111, 105, 110, 159, 0,
		159, 8, 136, 109, 116, 105, 116, 165, 159, 11,
		148, 109, 141, 104, 104, 42, 168, 105, 109, 37,
		230, 69, 105, 108, 150, 105, 108, 139, 104, 137,
		104, 137, 109
	})]
	private void replace2(string P_0)
	{
		thisClass.getClassFile();
		ConstPool constPool = getConstPool();
		int num = currentPos;
		_ = 0;
		int num2 = 1;
		int num3;
		int size;
		string desc;
		if (opcode == 188)
		{
			num3 = iterator.byteAt(currentPos + 1);
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)getPrimitiveType(num3);
			desc = new StringBuilder().append("[").append(ctPrimitiveType.getDescriptor()).toString();
			size = 2;
		}
		else if (opcode == 189)
		{
			num3 = iterator.u16bitAt(num + 1);
			desc = constPool.getClassInfo(num3);
			desc = ((!String.instancehelper_startsWith(desc, "[")) ? new StringBuilder().append("[L").append(desc).append(";")
				.toString() : new StringBuilder().append("[").append(desc).toString());
			size = 3;
		}
		else
		{
			if (opcode != 197)
			{
				string message = new StringBuilder().append("bad opcode: ").append(opcode).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
			num3 = iterator.u16bitAt(currentPos + 1);
			desc = constPool.getClassInfo(num3);
			num2 = iterator.byteAt(currentPos + 3);
			size = 4;
		}
		CtClass ctClass = Descriptor.toCtClass(desc, thisClass.getClassPool());
		Javac javac = new Javac(thisClass);
		CodeAttribute codeAttribute = iterator.get();
		CtClass[] array = new CtClass[num2];
		int i;
		for (i = 0; i < num2; i++)
		{
			array[i] = CtClass.intType;
		}
		i = codeAttribute.getMaxLocals();
		javac.recordParams("java.lang.Object", array, use0: true, i, withinStatic());
		Expr.checkResultValue(ctClass, P_0);
		int n = javac.recordReturnType(ctClass, useResultVar: true);
		javac.recordProceed(new ProceedForArray(ctClass, opcode, num3, num2));
		Bytecode bytecode = javac.getBytecode();
		Expr.storeStack(array, true, i, bytecode);
		javac.recordLocalVariables(codeAttribute, num);
		bytecode.addOpcode(1);
		bytecode.addAstore(n);
		javac.compileStmnt(P_0);
		bytecode.addAload(n);
		replace0(num, bytecode, size);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	public override CtBehavior where()
	{
		CtBehavior result = base.where();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public override int getLineNumber()
	{
		int lineNumber = base.getLineNumber();
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public override string getFileName()
	{
		string fileName = base.getFileName();
		_ = null;
		return fileName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(90)]
	public override CtClass[] mayThrow()
	{
		CtClass[] result = base.mayThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 50, 109, 116, 138, 154, 116, 109, 103, 104, 180 })]
	public virtual CtClass getComponentType()
	{
		if (opcode == 188)
		{
			int num = iterator.byteAt(currentPos + 1);
			CtClass primitiveType = getPrimitiveType(num);
			_ = null;
			return primitiveType;
		}
		if (opcode == 189 || opcode == 197)
		{
			int num = iterator.u16bitAt(currentPos + 1);
			string classInfo = getConstPool().getClassInfo(num);
			int dim = Descriptor.arrayDimension(classInfo);
			classInfo = Descriptor.toArrayComponent(classInfo, dim);
			CtClass result = Descriptor.toCtClass(classInfo, thisClass.getClassPool());
			_ = null;
			return result;
		}
		string message = new StringBuilder().append("bad opcode: ").append(opcode).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 109, 98, 154, 116, 109, 102, 46, 193 })]
	public virtual int getDimension()
	{
		if (opcode == 188)
		{
			return 1;
		}
		if (opcode == 189 || opcode == 197)
		{
			int index = iterator.u16bitAt(currentPos + 1);
			string classInfo = getConstPool().getClassInfo(index);
			return Descriptor.arrayDimension(classInfo) + ((opcode == 189) ? 1 : 0);
		}
		string message = new StringBuilder().append("bad opcode: ").append(opcode).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 112, 109, 118 })]
	public virtual int getCreatedDimensions()
	{
		if (opcode == 197)
		{
			int result = iterator.byteAt(currentPos + 3);
			_ = null;
			return result;
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160,
		66,
		byte.MaxValue,
		11,
		70,
		226,
		60,
		109,
		109,
		97,
		144
	})]
	public override void replace(string statement)
	{
		CompileError compileError;
		NotFoundException ex;
		try
		{
			try
			{
				try
				{
					replace2(statement);
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
				goto IL_0024;
			}
		}
		catch (BadBytecode)
		{
			goto IL_0027;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0027:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("broken method");
		IL_0024:
		NotFoundException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}
}
