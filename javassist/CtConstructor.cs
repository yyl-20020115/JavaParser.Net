using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;

namespace javassist;

public sealed class CtConstructor : CtBehavior
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 98, 109, 102 })]
	public override string getName()
	{
		if (methodInfo.isStaticInitializer())
		{
			return "<clinit>";
		}
		string simpleName = declaringClass.getSimpleName();
		_ = null;
		return simpleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 106 })]
	protected internal CtConstructor(MethodInfo minfo, CtClass declaring)
		: base(declaring, minfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public virtual bool isConstructor()
	{
		bool result = methodInfo.isConstructor();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public virtual bool isClassInitializer()
	{
		bool result = methodInfo.isStaticInitializer();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 72, 108 })]
	private string getSuperclassName()
	{
		ClassFile classFile = declaringClass.getClassFile2();
		string superclass = classFile.getSuperclass();
		_ = null;
		return superclass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 249, 104, 105, 107, 103, 103, 99, 134, 109,
		37, 247, 69, 2, 98, 237, 69, 103
	})]
	public virtual CtMethod toMethod(string name, CtClass declaring, ClassMap map)
	{
		CtMethod ctMethod = new CtMethod(null, declaring);
		ctMethod.copy(this, false, map);
		BadBytecode badBytecode;
		if (isConstructor())
		{
			MethodInfo methodInfo = ctMethod.getMethodInfo2();
			CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
			if (codeAttribute != null)
			{
				removeConsCall(codeAttribute);
				try
				{
					base.methodInfo.rebuildStackMapIf6(declaring.getClassPool(), declaring.getClassFile2());
				}
				catch (BadBytecode x)
				{
					badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0059;
				}
			}
		}
		ctMethod.setName(name);
		return ctMethod;
		IL_0059:
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161,
		17,
		135,
		103,
		103,
		106,
		109,
		106,
		101,
		146,
		109,
		104,
		106,
		136,
		104,
		105,
		byte.MaxValue,
		15,
		73,
		2,
		98,
		141
	})]
	private static void removeConsCall(CodeAttribute P_0)
	{
		CodeIterator codeIterator = P_0.iterator();
		BadBytecode badBytecode;
		try
		{
			int num = codeIterator.skipConstructor();
			if (num < 0)
			{
				return;
			}
			int index = codeIterator.u16bitAt(num + 1);
			string methodrefType = P_0.getConstPool().getMethodrefType(index);
			int num2 = Descriptor.numOfParameters(methodrefType) + 1;
			if (num2 > 3)
			{
				num = codeIterator.insertGapAt(num, num2 - 3, exclusive: false).position;
			}
			int index2 = num;
			num++;
			codeIterator.writeByte(87, index2);
			codeIterator.writeByte(0, num);
			codeIterator.writeByte(0, num + 1);
			Descriptor.Iterator iterator = new Descriptor.Iterator(methodrefType);
			while (true)
			{
				iterator.next();
				if (!iterator.isParameter())
				{
					break;
				}
				int value = ((!iterator.is2byte()) ? 87 : 88);
				int index3 = num;
				num++;
				codeIterator.writeByte(value, index3);
			}
			return;
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 111, 108, 103, 114, 105 })]
	public CtConstructor(CtClass[] parameters, CtClass declaring)
		: this((MethodInfo)null, declaring)
	{
		ConstPool constPool = declaring.getClassFile2().getConstPool();
		string desc = Descriptor.ofConstructor(parameters);
		methodInfo = new MethodInfo(constPool, "<init>", desc);
		setModifiers(1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 59, 111, 107 })]
	public CtConstructor(CtConstructor src, CtClass declaring, ClassMap map)
		: this((MethodInfo)null, declaring)
	{
		base.copy(src, true, map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 117, 117, 17 })]
	public override string getLongName()
	{
		string result = new StringBuilder().append(base.getDeclaringClass().getName()).append((!isConstructor()) ? ".<clinit>()" : Descriptor.toString(getSignature())).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		112, 108, 99, 162, 103, 167, 109, 149, 118, 106,
		37, 146, 110, 114, 252, 57, 225, 73, 97
	})]
	public override bool isEmpty()
	{
		//Discarded unreachable code: IL_00a5
		CodeAttribute codeAttribute = base.getMethodInfo2().getCodeAttribute();
		if (codeAttribute == null)
		{
			return false;
		}
		ConstPool constPool = codeAttribute.getConstPool();
		CodeIterator codeIterator = codeAttribute.iterator();
		try
		{
			int num = codeIterator.byteAt(codeIterator.next());
			int num2;
			int index;
			return (num == 177 || (num == 42 && codeIterator.byteAt(num2 = codeIterator.next()) == 183 && (index = constPool.isConstructor(getSuperclassName(), codeIterator.u16bitAt(num2 + 1))) != 0 && String.instancehelper_equals("()V", constPool.getUtf8Info(index)) && codeIterator.byteAt(codeIterator.next()) == 177 && !codeIterator.hasNext())) ? true : false;
		}
		catch (BadBytecode)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 82, 108, 99, 135, 103, 159, 1, 98, 205 })]
	public virtual bool callsSuper()
	{
		//Discarded unreachable code: IL_0027
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute != null)
		{
			CodeIterator codeIterator = codeAttribute.iterator();
			BadBytecode badBytecode;
			try
			{
				int num = codeIterator.skipSuperConstructor();
				return num >= 0;
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			BadBytecode e = badBytecode;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 108, 99, 104, 137, 135, 105 })]
	public override void setBody(string src)
	{
		if (src == null)
		{
			src = ((!isClassInitializer()) ? "super();" : ";");
		}
		base.setBody(src);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 132, 159, 1 })]
	public virtual void setBody(CtConstructor src, ClassMap map)
	{
		CtBehavior.setBody0(src.declaringClass, src.methodInfo, declaringClass, methodInfo, map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160,
		145,
		103,
		102,
		104,
		144,
		108,
		103,
		113,
		113,
		108,
		137,
		111,
		104,
		108,
		108,
		103,
		110,
		110,
		byte.MaxValue,
		40,
		74,
		226,
		56,
		98,
		141,
		98,
		141,
		98,
		141
	})]
	public virtual void insertBeforeBody(string src)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		if (isClassInitializer())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("class initializer");
		}
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		CodeIterator codeIterator = codeAttribute.iterator();
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(methodInfo.getConstPool(), codeAttribute.getMaxStack(), codeAttribute.getMaxLocals());
		bytecode.setStackDepth(codeAttribute.getMaxStack());
		Javac javac = new Javac(bytecode, ctClass);
		NotFoundException ex;
		CompileError compileError;
		BadBytecode badBytecode;
		try
		{
			try
			{
				try
				{
					javac.recordParams(base.getParameterTypes(), isStatic: false);
					javac.compileStmnt(src);
					codeAttribute.setMaxStack(bytecode.getMaxStack());
					codeAttribute.setMaxLocals(bytecode.getMaxLocals());
					codeIterator.skipConstructor();
					int offset = codeIterator.insertEx(bytecode.get());
					codeIterator.insert(bytecode.getExceptionTable(), offset);
					methodInfo.rebuildStackMapIf6(ctClass.getClassPool(), ctClass.getClassFile2());
					return;
				}
				catch (NotFoundException x)
				{
					ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (CompileError x2)
			{
				compileError = ByteCodeHelper.MapException<CompileError>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0100;
			}
		}
		catch (BadBytecode x3)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0104;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0104:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_0100:
		CompileError e3 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 182, 135, 103, 156, 97 })]
	internal override int getStartPosOfBody(CodeAttribute P_0)
	{
		//Discarded unreachable code: IL_0016
		CodeIterator codeIterator = P_0.iterator();
		BadBytecode badBytecode;
		try
		{
			codeIterator.skipConstructor();
			return codeIterator.next();
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(329)]
	public virtual CtMethod toMethod(string name, CtClass declaring)
	{
		CtMethod result = toMethod(name, declaring, null);
		_ = null;
		return result;
	}
}
