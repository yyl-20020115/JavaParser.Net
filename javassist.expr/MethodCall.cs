using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;

namespace javassist.expr;

public class MethodCall : Expr
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 50, 103, 103, 109, 143, 104, 139, 137, 108, 137 })]
	public virtual string getClassName()
	{
		ConstPool constPool = getConstPool();
		int num = currentPos;
		int num2 = iterator.byteAt(num);
		int index = iterator.u16bitAt(num + 1);
		string text = ((num2 != 185) ? constPool.getMethodrefClassName(index) : constPool.getInterfaceMethodrefClassName(index));
		if (String.instancehelper_charAt(text, 0) == '[')
		{
			text = Descriptor.toClassName(text);
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 103, 109, 143, 104, 106 })]
	private int getNameAndType(ConstPool P_0)
	{
		int num = currentPos;
		int num2 = iterator.byteAt(num);
		int index = iterator.u16bitAt(num + 1);
		if (num2 == 185)
		{
			int interfaceMethodrefNameAndType = P_0.getInterfaceMethodrefNameAndType(index);
			_ = null;
			return interfaceMethodrefNameAndType;
		}
		int methodrefNameAndType = P_0.getMethodrefNameAndType(index);
		_ = null;
		return methodrefNameAndType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(90)]
	protected internal virtual CtClass getCtClass()
	{
		CtClass result = thisClass.getClassPool().get(getClassName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 70, 103, 104 })]
	public virtual string getMethodName()
	{
		ConstPool constPool = getConstPool();
		int nameAndType = getNameAndType(constPool);
		string utf8Info = constPool.getUtf8Info(constPool.getNameAndTypeName(nameAndType));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 103, 104 })]
	public virtual string getSignature()
	{
		ConstPool constPool = getConstPool();
		int nameAndType = getNameAndType(constPool);
		string utf8Info = constPool.getUtf8Info(constPool.getNameAndTypeDescriptor(nameAndType));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public override CtBehavior where()
	{
		CtBehavior result = base.where();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 109 })]
	protected internal MethodCall(int pos, CodeIterator i, CtClass declaring, MethodInfo m)
		: base(pos, i, declaring, m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	public override int getLineNumber()
	{
		int lineNumber = base.getLineNumber();
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	public override string getFileName()
	{
		string fileName = base.getFileName();
		_ = null;
		return fileName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(129)]
	public virtual CtMethod getMethod()
	{
		CtMethod method = getCtClass().getMethod(getMethodName(), getSignature());
		_ = null;
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(156)]
	public override CtClass[] mayThrow()
	{
		CtClass[] result = base.mayThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 114, 121, 63, 1 })]
	public virtual bool isSuper()
	{
		return (iterator.byteAt(currentPos) == 183 && !String.instancehelper_equals(where().getDeclaringClass().getName(), getClassName())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160,
		82,
		108,
		103,
		103,
		207,
		109,
		104,
		99,
		105,
		105,
		139,
		152,
		99,
		105,
		105,
		171,
		144,
		109,
		109,
		141,
		107,
		107,
		105,
		106,
		37,
		134,
		108,
		104,
		109,
		104,
		181,
		206,
		137,
		105,
		115,
		139,
		105,
		105,
		172,
		104,
		105,
		140,
		byte.MaxValue,
		19,
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
		int num3 = iterator.byteAt(num);
		int size;
		string text;
		string text2;
		string text3;
		switch (num3)
		{
		case 185:
			size = 5;
			text = constPool.getInterfaceMethodrefClassName(num2);
			text2 = constPool.getInterfaceMethodrefName(num2);
			text3 = constPool.getInterfaceMethodrefType(num2);
			break;
		case 182:
		case 183:
		case 184:
			size = 3;
			text = constPool.getMethodrefClassName(num2);
			text2 = constPool.getMethodrefName(num2);
			text3 = constPool.getMethodrefType(num2);
			break;
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("not method invocation");
		}
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
					CtClass[] parameterTypes = Descriptor.getParameterTypes(text3, classPool);
					CtClass returnType = Descriptor.getReturnType(text3, classPool);
					int num4 = codeAttribute.getMaxLocals();
					javac.recordParams(text, parameterTypes, use0: true, num4, withinStatic());
					int n = javac.recordReturnType(returnType, useResultVar: true);
					switch (num3)
					{
					case 184:
						javac.recordStaticProceed(text, text2);
						break;
					case 183:
						javac.recordSpecialProceed("$0", text, text2, text3, num2);
						break;
					default:
						javac.recordProceed("$0", text2);
						break;
					}
					Expr.checkResultValue(returnType, statement);
					Bytecode bytecode = javac.getBytecode();
					Expr.storeStack(parameterTypes, num3 == 184, num4, bytecode);
					javac.recordLocalVariables(codeAttribute, num);
					if (returnType != CtClass.voidType)
					{
						bytecode.addConstZero(returnType);
						bytecode.addStore(n, returnType);
					}
					javac.compileStmnt(statement);
					if (returnType != CtClass.voidType)
					{
						bytecode.addLoad(n, returnType);
					}
					replace0(num, bytecode, size);
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
				goto IL_01e3;
			}
		}
		catch (BadBytecode)
		{
			goto IL_01e7;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_01e7:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("broken method");
		IL_01e3:
		NotFoundException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}
}
