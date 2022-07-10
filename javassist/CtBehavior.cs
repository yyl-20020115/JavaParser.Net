using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;
using javassist.expr;

namespace javassist;

public abstract class CtBehavior : CtMember
{
	protected internal MethodInfo methodInfo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 107 })]
	public virtual MethodInfo getMethodInfo()
	{
		declaringClass.checkModify();
		return methodInfo;
	}

	public abstract string getLongName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(164)]
	public override int getModifiers()
	{
		int result = AccessFlag.toModifier(methodInfo.getAccessFlags());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 252, 107, 107 })]
	public override string getGenericSignature()
	{
		string result = ((javassist.bytecode.SignatureAttribute)methodInfo.getAttribute("Signature"))?.getSignature();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(354)]
	public override string getSignature()
	{
		string descriptor = methodInfo.getDescriptor();
		_ = null;
		return descriptor;
	}

	public virtual MethodInfo getMethodInfo2()
	{
		return methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 159, 78, 162, 103, 102, 107, 102, 107, 98, 44 })]
	private object[] getAnnotations(bool P_0)
	{
		MethodInfo methodInfo = getMethodInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeVisibleAnnotations");
		object[] result = CtClassType.toAnnotationType(P_0, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 159, 65, 98, 103, 102, 107, 102, 107, 98, 45 })]
	internal virtual object[][] getParameterAnnotations(bool P_0)
	{
		MethodInfo methodInfo = getMethodInfo2();
		ParameterAnnotationsAttribute parameterAnnotationsAttribute = (ParameterAnnotationsAttribute)methodInfo.getAttribute("RuntimeInvisibleParameterAnnotations");
		ParameterAnnotationsAttribute parameterAnnotationsAttribute2 = (ParameterAnnotationsAttribute)methodInfo.getAttribute("RuntimeVisibleParameterAnnotations");
		object[][] result = CtClassType.toAnnotationType(P_0, getDeclaringClass().getClassPool(), parameterAnnotationsAttribute, parameterAnnotationsAttribute2, methodInfo);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161,
		89,
		103,
		134,
		103,
		99,
		136,
		105,
		113,
		156,
		119,
		byte.MaxValue,
		12,
		70,
		226,
		60,
		98,
		109,
		98,
		141
	})]
	public virtual void setBody(string src, string delegateObj, string delegateMethod)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		CompileError compileError;
		BadBytecode badBytecode;
		try
		{
			try
			{
				Javac javac = new Javac(ctClass);
				if (delegateMethod != null)
				{
					javac.recordProceed(delegateObj, delegateMethod);
				}
				Bytecode bytecode = javac.compileBody(this, src);
				methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
				methodInfo.setAccessFlags(methodInfo.getAccessFlags() & -1025);
				methodInfo.rebuildStackMapIf6(ctClass.getClassPool(), ctClass.getClassFile2());
				declaringClass.rebuildClassFile();
				return;
			}
			catch (CompileError x)
			{
				compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (BadBytecode x2)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0093;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0093:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		158,
		205,
		66,
		103,
		102,
		108,
		99,
		144,
		103,
		136,
		105,
		42,
		135,
		107,
		106,
		111,
		104,
		105,
		105,
		137,
		106,
		136,
		106,
		136,
		111,
		111,
		99,
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
	private void insertBefore(string P_0, bool P_1)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("no method body");
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		Javac javac = new Javac(ctClass);
		NotFoundException ex;
		CompileError compileError;
		BadBytecode badBytecode;
		try
		{
			try
			{
				try
				{
					int numOfLocalVars = javac.recordParams(getParameterTypes(), Modifier.isStatic(getModifiers()));
					javac.recordParamNames(codeAttribute, numOfLocalVars);
					javac.recordLocalVariables(codeAttribute, 0);
					javac.recordReturnType(getReturnType0(), useResultVar: false);
					javac.compileStmnt(P_0);
					Bytecode bytecode = javac.getBytecode();
					int maxStack = bytecode.getMaxStack();
					int maxLocals = bytecode.getMaxLocals();
					if (maxStack > codeAttribute.getMaxStack())
					{
						codeAttribute.setMaxStack(maxStack);
					}
					if (maxLocals > codeAttribute.getMaxLocals())
					{
						codeAttribute.setMaxLocals(maxLocals);
					}
					int offset = codeIterator.insertEx(bytecode.get());
					codeIterator.insert(bytecode.getExceptionTable(), offset);
					if (P_1)
					{
						methodInfo.rebuildStackMapIf6(ctClass.getClassPool(), ctClass.getClassFile2());
					}
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
				goto IL_0122;
			}
		}
		catch (BadBytecode x3)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0126;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0126:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_0122:
		CompileError e3 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 158, 188, 130, 107 })]
	public virtual void insertAfter(string src, bool asFinally)
	{
		insertAfter(src, asFinally, redundant: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 50, 108, 102, 98, 99, 98, 104, 104, 104,
		104, 130, 146, 104, 102, 108, 100, 137, 102, 108,
		100, 137, 114, 100, 143, 114, 100, 145
	})]
	private void addParameter2(int P_0, CtClass P_1, string P_2)
	{
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute != null)
		{
			int num = 1;
			int descriptor = 76;
			int classInfo = 0;
			if (P_1.isPrimitive())
			{
				CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_1;
				num = ctPrimitiveType.getDataSize();
				descriptor = ctPrimitiveType.getDescriptor();
			}
			else
			{
				classInfo = methodInfo.getConstPool().addClassInfo(P_1);
			}
			codeAttribute.insertLocalVar(P_0, num);
			((LocalVariableAttribute)codeAttribute.getAttribute("LocalVariableTable"))?.shiftIndex(P_0, num);
			((LocalVariableTypeAttribute)codeAttribute.getAttribute("LocalVariableTypeTable"))?.shiftIndex(P_0, num);
			((StackMapTable)codeAttribute.getAttribute("StackMapTable"))?.insertLocal(P_0, StackMapTable.typeTagOf((char)descriptor), classInfo);
			((StackMap)codeAttribute.getAttribute("StackMap"))?.insertLocal(P_0, StackMapTable.typeTagOf((char)descriptor), classInfo);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 209, 113, 37 })]
	public virtual CtClass[] getParameterTypes()
	{
		CtClass[] parameterTypes = Descriptor.getParameterTypes(methodInfo.getDescriptor(), declaringClass.getClassPool());
		_ = null;
		return parameterTypes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 217, 113, 37 })]
	internal virtual CtClass getReturnType0()
	{
		CtClass returnType = Descriptor.getReturnType(methodInfo.getDescriptor(), declaringClass.getClassPool());
		_ = null;
		return returnType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		158,
		181,
		164,
		103,
		102,
		108,
		109,
		100,
		144,
		105,
		105,
		109,
		112,
		138,
		105,
		42,
		135,
		108,
		104,
		108,
		171,
		146,
		105,
		99,
		153,
		99,
		99,
		99,
		108,
		105,
		102,
		133,
		107,
		191,
		26,
		102,
		201,
		100,
		99,
		100,
		100,
		169,
		109,
		112,
		106,
		105,
		42,
		135,
		108,
		108,
		171,
		114,
		112,
		112,
		108,
		108,
		105,
		133,
		132,
		114,
		112,
		112,
		108,
		103,
		163,
		108,
		108,
		167,
		133,
		100,
		112,
		176,
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
	public virtual void insertAfter(string src, bool asFinally, bool redundant)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		ConstPool constPool = methodInfo.getConstPool();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("no method body");
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		int maxLocals = codeAttribute.getMaxLocals();
		Bytecode bytecode = new Bytecode(constPool, 0, maxLocals + 1);
		bytecode.setStackDepth(codeAttribute.getMaxStack() + 1);
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
					int numOfLocalVars = javac.recordParams(getParameterTypes(), Modifier.isStatic(getModifiers()));
					javac.recordParamNames(codeAttribute, numOfLocalVars);
					CtClass returnType = getReturnType0();
					int num = javac.recordReturnType(returnType, useResultVar: true);
					javac.recordLocalVariables(codeAttribute, 0);
					int num2 = insertAfterHandler(asFinally, bytecode, returnType, num, javac, src);
					int num3 = codeIterator.getCodeLength();
					if (asFinally)
					{
						codeAttribute.getExceptionTable().add(getStartPosOfBody(codeAttribute), num3, num3, 0);
					}
					int num4 = 0;
					int num5 = 0;
					int num6 = 1;
					while (codeIterator.hasNext())
					{
						int num7 = codeIterator.next();
						if (num7 >= num3)
						{
							break;
						}
						int num8 = codeIterator.byteAt(num7);
						if (num8 != 176 && num8 != 172 && num8 != 174 && num8 != 173 && num8 != 175 && num8 != 177)
						{
							continue;
						}
						if (redundant)
						{
							codeIterator.setMark2(num3);
							Bytecode bytecode2;
							Javac javac2;
							int num9;
							int numOfLocalVars2;
							if (num6 != 0)
							{
								num6 = 0;
								bytecode2 = bytecode;
								javac2 = javac;
								num9 = num;
							}
							else
							{
								bytecode2 = new Bytecode(constPool, 0, maxLocals + 1);
								bytecode2.setStackDepth(codeAttribute.getMaxStack() + 1);
								javac2 = new Javac(bytecode2, ctClass);
								numOfLocalVars2 = javac2.recordParams(getParameterTypes(), Modifier.isStatic(getModifiers()));
								javac2.recordParamNames(codeAttribute, numOfLocalVars2);
								num9 = javac2.recordReturnType(returnType, useResultVar: true);
								javac2.recordLocalVariables(codeAttribute, 0);
							}
							numOfLocalVars2 = insertAfterAdvice(bytecode2, javac2, src, constPool, returnType, num9);
							int offset = codeIterator.append(bytecode2.get());
							codeIterator.append(bytecode2.getExceptionTable(), offset);
							int num10 = codeIterator.getCodeLength() - numOfLocalVars2;
							insertGoto(codeIterator, num10, num7);
							num3 = codeIterator.getMark2();
						}
						else
						{
							if (num6 != 0)
							{
								num4 = insertAfterAdvice(bytecode, javac, src, constPool, returnType, num);
								num3 = codeIterator.append(bytecode.get());
								codeIterator.append(bytecode.getExceptionTable(), num3);
								num5 = codeIterator.getCodeLength() - num4;
								num2 = num5 - num3;
								num6 = 0;
							}
							insertGoto(codeIterator, num5, num7);
							num5 = codeIterator.getCodeLength() - num4;
							num3 = num5 - num2;
						}
					}
					if (num6 != 0)
					{
						num3 = codeIterator.append(bytecode.get());
						codeIterator.append(bytecode.getExceptionTable(), num3);
					}
					codeAttribute.setMaxStack(bytecode.getMaxStack());
					codeAttribute.setMaxLocals(bytecode.getMaxLocals());
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
				goto IL_0332;
			}
		}
		catch (BadBytecode x3)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0336;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0336:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_0332:
		CompileError e3 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 138, 162, 99, 130, 103, 103, 103, 103, 107,
		108, 101, 107, 138, 101, 107, 138, 101, 104, 138,
		101, 103, 170, 103, 136, 130, 103, 168, 105, 103,
		107
	})]
	private int insertAfterHandler(bool P_0, Bytecode P_1, CtClass P_2, int P_3, Javac P_4, string P_5)
	{
		if (!P_0)
		{
			return 0;
		}
		int maxLocals = P_1.getMaxLocals();
		P_1.incMaxLocals(1);
		int num = P_1.currentPc();
		P_1.addAstore(maxLocals);
		if (P_2.isPrimitive())
		{
			switch (((CtPrimitiveType)P_2).getDescriptor())
			{
			case 'D':
				P_1.addDconst(0.0);
				P_1.addDstore(P_3);
				break;
			case 'F':
				P_1.addFconst(0f);
				P_1.addFstore(P_3);
				break;
			case 'J':
				P_1.addLconst(0L);
				P_1.addLstore(P_3);
				break;
			case 'V':
				P_1.addOpcode(1);
				P_1.addAstore(P_3);
				break;
			default:
				P_1.addIconst(0);
				P_1.addIstore(P_3);
				break;
			}
		}
		else
		{
			P_1.addOpcode(1);
			P_1.addAstore(P_3);
		}
		P_4.compileStmnt(P_5);
		P_1.addAload(maxLocals);
		P_1.addOpcode(191);
		return P_1.currentPc() - num;
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	internal virtual int getStartPosOfBody(CodeAttribute P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 99, 103, 105, 103, 104, 103, 107, 105, 169,
		107, 103, 107, 105, 148, 171
	})]
	private int insertAfterAdvice(Bytecode P_0, Javac P_1, string P_2, ConstPool P_3, CtClass P_4, int P_5)
	{
		int num = P_0.currentPc();
		if (P_4 == CtClass.voidType)
		{
			P_0.addOpcode(1);
			P_0.addAstore(P_5);
			P_1.compileStmnt(P_2);
			P_0.addOpcode(177);
			if (P_0.getMaxLocals() < 1)
			{
				P_0.setMaxLocals(1);
			}
		}
		else
		{
			P_0.addStore(P_5, P_4);
			P_1.compileStmnt(P_2);
			P_0.addLoad(P_5, P_4);
			if (P_4.isPrimitive())
			{
				P_0.addOpcode(((CtPrimitiveType)P_4).getReturnOp());
			}
			else
			{
				P_0.addOpcode(176);
			}
		}
		return P_0.currentPc() - num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 127, 135, 104, 109, 104, 106, 113, 105, 99,
		108, 143, 104, 108, 172, 105, 112, 186, 108, 147
	})]
	private void insertGoto(CodeIterator P_0, int P_1, int P_2)
	{
		P_0.setMark(P_1);
		P_0.writeByte(0, P_2);
		int num = ((P_1 + 2 - P_2 > 32767) ? 1 : 0);
		int num2 = ((num == 0) ? 2 : 4);
		CodeIterator.Gap gap = P_0.insertGapAt(P_2, num2, exclusive: false);
		P_2 = gap.position + gap.length - num2;
		int num3 = P_0.getMark() - P_2;
		if (num != 0)
		{
			P_0.writeByte(200, P_2);
			P_0.write32bit(num3, P_2 + 1);
			return;
		}
		if (num3 <= 32767)
		{
			P_0.writeByte(167, P_2);
			P_0.write16bit(num3, P_2 + 1);
			return;
		}
		if (gap.length < 4)
		{
			CodeIterator.Gap gap2 = P_0.insertGapAt(gap.position, 2, exclusive: false);
			P_2 = gap2.position + gap2.length + gap.length - 4;
		}
		P_0.writeByte(200, P_2);
		P_0.write32bit(P_0.getMark() - P_2, P_2 + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		164,
		28,
		103,
		102,
		108,
		108,
		103,
		121,
		104,
		138,
		105,
		42,
		134,
		107,
		105,
		136,
		105,
		137,
		106,
		136,
		106,
		136,
		104,
		111,
		115,
		37,
		133,
		111,
		byte.MaxValue,
		40,
		73,
		226,
		57,
		98,
		141,
		98,
		109,
		98,
		141
	})]
	public virtual void addCatch(string src, CtClass exceptionType, string exceptionName)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		ConstPool constPool = methodInfo.getConstPool();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		CodeIterator codeIterator = codeAttribute.iterator();
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(constPool, codeAttribute.getMaxStack(), codeAttribute.getMaxLocals());
		bytecode.setStackDepth(1);
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
					javac.recordParams(getParameterTypes(), Modifier.isStatic(getModifiers()));
					int n = javac.recordVariable(exceptionType, exceptionName);
					bytecode.addAstore(n);
					javac.compileStmnt(src);
					int maxStack = bytecode.getMaxStack();
					int maxLocals = bytecode.getMaxLocals();
					if (maxStack > codeAttribute.getMaxStack())
					{
						codeAttribute.setMaxStack(maxStack);
					}
					if (maxLocals > codeAttribute.getMaxLocals())
					{
						codeAttribute.setMaxLocals(maxLocals);
					}
					int codeLength = codeIterator.getCodeLength();
					int offset = codeIterator.append(bytecode.get());
					codeAttribute.getExceptionTable().add(getStartPosOfBody(codeAttribute), codeLength, codeLength, constPool.addClassInfo(exceptionType));
					codeIterator.append(bytecode.getExceptionTable(), offset);
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
				goto IL_0144;
			}
		}
		catch (BadBytecode x3)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0148;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0148:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_0144:
		CompileError e3 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		158, 83, 98, 108, 99, 144, 102, 107, 99, 144,
		104, 104, 104, 99, 130, 104, 103, 104, 137, 107,
		105, 42, 134, 109, 104, 105, 105, 105, 232, 69,
		106, 136, 114, 112, 121, 159, 25, 98, 141, 98,
		141, 98
	})]
	public virtual int insertAt(int lineNum, bool modify, string src)
	{
		//Discarded unreachable code: IL_012e
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("no method body");
		}
		LineNumberAttribute lineNumberAttribute = (LineNumberAttribute)codeAttribute.getAttribute("LineNumberTable");
		if (lineNumberAttribute == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("no line number info");
		}
		LineNumberAttribute.Pc pc = lineNumberAttribute.toNearPc(lineNum);
		lineNum = pc.line;
		int index = pc.index;
		if (!modify)
		{
			return lineNum;
		}
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		CodeIterator codeIterator = codeAttribute.iterator();
		Javac javac = new Javac(ctClass);
		NotFoundException ex;
		CompileError compileError;
		BadBytecode badBytecode;
		try
		{
			try
			{
				try
				{
					javac.recordLocalVariables(codeAttribute, index);
					javac.recordParams(getParameterTypes(), Modifier.isStatic(getModifiers()));
					javac.setMaxLocals(codeAttribute.getMaxLocals());
					javac.compileStmnt(src);
					Bytecode bytecode = javac.getBytecode();
					int maxLocals = bytecode.getMaxLocals();
					int maxStack = bytecode.getMaxStack();
					codeAttribute.setMaxLocals(maxLocals);
					if (maxStack > codeAttribute.getMaxStack())
					{
						codeAttribute.setMaxStack(maxStack);
					}
					index = codeIterator.insertAt(index, bytecode.get());
					codeIterator.insert(bytecode.getExceptionTable(), index);
					methodInfo.rebuildStackMapIf6(ctClass.getClassPool(), ctClass.getClassFile2());
					return lineNum;
				}
				catch (NotFoundException x)
				{
					ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (CompileError x2)
			{
				compileError = ByteCodeHelper.MapException<CompileError>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_015a;
			}
		}
		catch (BadBytecode x3)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_015e;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_015e:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
		IL_015a:
		CompileError e3 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 105, 103 })]
	protected internal CtBehavior(CtClass clazz, MethodInfo minfo)
		: base(clazz)
	{
		methodInfo = minfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		159,
		126,
		162,
		103,
		103,
		103,
		141,
		104,
		147,
		99,
		104,
		104,
		99,
		104,
		105,
		105,
		107,
		110,
		133,
		202,
		117,
		103,
		byte.MaxValue,
		16,
		71,
		226,
		59,
		98,
		141,
		98,
		141
	})]
	internal virtual void copy(CtBehavior P_0, bool P_1, ClassMap P_2)
	{
		CtClass ctClass = declaringClass;
		MethodInfo methodInfo = P_0.methodInfo;
		CtClass ctClass2 = P_0.getDeclaringClass();
		ConstPool constPool = ctClass.getClassFile2().getConstPool();
		P_2 = new ClassMap(P_2);
		P_2.put(ctClass2.getName(), ctClass.getName());
		NotFoundException ex;
		BadBytecode badBytecode;
		try
		{
			try
			{
				int num = 0;
				CtClass superclass = ctClass2.getSuperclass();
				CtClass superclass2 = ctClass.getSuperclass();
				string text = null;
				if (superclass != null && superclass2 != null)
				{
					string name = superclass.getName();
					text = superclass2.getName();
					if (!String.instancehelper_equals(name, text))
					{
						if (String.instancehelper_equals(name, "java.lang.Object"))
						{
							num = 1;
						}
						else
						{
							P_2.putIfNone(name, text);
						}
					}
				}
				this.methodInfo = new MethodInfo(constPool, methodInfo.getName(), methodInfo, P_2);
				if (P_1 && num != 0)
				{
					this.methodInfo.setSuperclass(text);
				}
				return;
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (BadBytecode x2)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00de;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_00de:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 54, 105, 109, 105, 114 })]
	protected internal override void extendToString(StringBuilder buffer)
	{
		buffer.append(' ');
		buffer.append(getName());
		buffer.append(' ');
		buffer.append(methodInfo.getDescriptor());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 64, 107, 115 })]
	public override void setModifiers(int mod)
	{
		declaringClass.checkModify();
		methodInfo.setAccessFlags(AccessFlag.of(mod));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 78, 103, 102, 107, 102, 107, 98, 44 })]
	public override bool hasAnnotation(string typeName)
	{
		MethodInfo methodInfo = getMethodInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeVisibleAnnotations");
		bool result = CtClassType.hasAnnotationType(typeName, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 160, 101, 103, 102, 107, 102, 107, 98, 44 })]
	public override object getAnnotation(Class clz)
	{
		MethodInfo methodInfo = getMethodInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)methodInfo.getAttribute("RuntimeVisibleAnnotations");
		object annotationType = CtClassType.getAnnotationType(clz, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return annotationType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(234)]
	public override object[] getAnnotations()
	{
		object[] annotations = getAnnotations(false);
		_ = null;
		return annotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 135, 157, 97 })]
	public override object[] getAvailableAnnotations()
	{
		//Discarded unreachable code: IL_0009
		java.lang.ClassNotFoundException ex;
		try
		{
			return getAnnotations(true);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Unexpected exception", cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(281)]
	public virtual object[][] getParameterAnnotations()
	{
		object[][] parameterAnnotations = getParameterAnnotations(false);
		_ = null;
		return parameterAnnotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 185, 157, 97 })]
	public virtual object[][] getAvailableParameterAnnotations()
	{
		//Discarded unreachable code: IL_0009
		java.lang.ClassNotFoundException ex;
		try
		{
			return getParameterAnnotations(true);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Unexpected exception", cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 13, 107, 126 })]
	public override void setGenericSignature(string sig)
	{
		declaringClass.checkModify();
		methodInfo.addAttribute(new javassist.bytecode.SignatureAttribute(methodInfo.getConstPool(), sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 24, 108, 99, 132, 135 })]
	public virtual CtClass[] getExceptionTypes()
	{
		string[] classnames = methodInfo.getExceptionsAttribute()?.getExceptions();
		CtClass[] result = declaringClass.getClassPool().get(classnames);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 37, 107, 103, 109, 161, 104, 103, 43, 166,
		108, 99, 113, 172, 105
	})]
	public virtual void setExceptionTypes(CtClass[] types)
	{
		declaringClass.checkModify();
		if (types == null || types.Length == 0)
		{
			methodInfo.removeExceptionsAttribute();
			return;
		}
		string[] array = new string[(nint)types.LongLength];
		for (int i = 0; i < (nint)types.LongLength; i++)
		{
			array[i] = types[i].getName();
		}
		ExceptionsAttribute exceptionsAttribute = methodInfo.getExceptionsAttribute();
		if (exceptionsAttribute == null)
		{
			exceptionsAttribute = new ExceptionsAttribute(methodInfo.getConstPool());
			methodInfo.setExceptionsAttribute(exceptionsAttribute);
		}
		exceptionsAttribute.setExceptions(array);
	}

	public abstract bool isEmpty();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 161, 70, 107 })]
	public virtual void setBody(string src)
	{
		setBody(src, null, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		159, 21, 99, 134, 105, 148, 103, 99, 103, 111,
		249, 72, 226, 60, 162, 173, 146, 102
	})]
	internal static void setBody0(CtClass P_0, MethodInfo P_1, CtClass P_2, MethodInfo P_3, ClassMap P_4)
	{
		_ = ref P_4;
		P_2.checkModify();
		P_4 = new ClassMap(P_4);
		P_4.put(P_0.getName(), P_2.getName());
		CodeAttribute.RuntimeCopyException ex;
		try
		{
			CodeAttribute codeAttribute = P_1.getCodeAttribute();
			if (codeAttribute != null)
			{
				ConstPool constPool = P_3.getConstPool();
				CodeAttribute codeAttribute2 = (CodeAttribute)codeAttribute.copy(constPool, P_4);
				P_3.setCodeAttribute(codeAttribute2);
			}
		}
		catch (CodeAttribute.RuntimeCopyException x)
		{
			ex = ByteCodeHelper.MapException<CodeAttribute.RuntimeCopyException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_005c;
		}
		P_3.setAccessFlags(P_3.getAccessFlags() & -1025);
		P_2.rebuildClassFile();
		return;
		IL_005c:
		CodeAttribute.RuntimeCopyException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 153, 109, 99, 98 })]
	public override byte[] getAttribute(string name)
	{
		AttributeInfo attribute = methodInfo.getAttribute(name);
		if (attribute == null)
		{
			return null;
		}
		byte[] result = attribute.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 172, 107, 159, 0 })]
	public override void setAttribute(string name, byte[] data)
	{
		declaringClass.checkModify();
		methodInfo.addAttribute(new AttributeInfo(methodInfo.getConstPool(), name, data));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161, 196, 103, 102, 135, 130, 159, 0, 211, 2,
		97, 194, 147, 109, 107, 105, 111, 127, 2, 124,
		221, 2, 98, 141
	})]
	public virtual void useCflow(string name)
	{
		CtClass ctClass = declaringClass;
		ctClass.checkModify();
		ClassPool classPool = ctClass.getClassPool();
		int num = 0;
		string text;
		while (true)
		{
			StringBuilder stringBuilder = new StringBuilder().append("_cflow$");
			int i = num;
			num++;
			text = stringBuilder.append(i).toString();
			try
			{
				ctClass.getDeclaredField(text);
			}
			catch (NotFoundException)
			{
				break;
			}
		}
		_ = null;
		classPool.recordCflow(name, declaringClass.getName(), text);
		NotFoundException ex2;
		try
		{
			CtClass ctClass2 = classPool.get("javassist.runtime.Cflow");
			CtField ctField = new CtField(ctClass2, text, ctClass);
			ctField.setModifiers(9);
			ctClass.addField(ctField, CtField.Initializer.byNew(ctClass2));
			insertBefore(new StringBuilder().append(text).append(".enter();").toString(), false);
			string src = new StringBuilder().append(text).append(".exit();").toString();
			insertAfter(src, asFinally: true);
			return;
		}
		catch (NotFoundException x)
		{
			ex2 = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161, 244, 107, 108, 108, 99, 144, 145, 99, 103,
		173, 103, 104, 106, 46, 133, 113
	})]
	public virtual void addLocalVariable(string name, CtClass type)
	{
		declaringClass.checkModify();
		ConstPool constPool = methodInfo.getConstPool();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("no method body");
		}
		LocalVariableAttribute localVariableAttribute = (LocalVariableAttribute)codeAttribute.getAttribute("LocalVariableTable");
		if (localVariableAttribute == null)
		{
			localVariableAttribute = new LocalVariableAttribute(constPool);
			codeAttribute.getAttributes().add(localVariableAttribute);
		}
		int maxLocals = codeAttribute.getMaxLocals();
		string text = Descriptor.of(type);
		localVariableAttribute.addEntry(0, codeAttribute.getCodeLength(), constPool.addUtf8Info(name), constPool.addUtf8Info(text), maxLocals);
		codeAttribute.setMaxLocals(maxLocals + Descriptor.dataSize(text));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		162, 14, 107, 108, 136, 223, 12, 2, 97, 172,
		108
	})]
	public virtual void insertParameter(CtClass type)
	{
		declaringClass.checkModify();
		string descriptor = methodInfo.getDescriptor();
		string descriptor2 = Descriptor.insertParameter(type, descriptor);
		BadBytecode badBytecode;
		try
		{
			addParameter2((!Modifier.isStatic(getModifiers())) ? 1 : 0, type, descriptor);
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0047;
		}
		methodInfo.setDescriptor(descriptor2);
		return;
		IL_0047:
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		162, 33, 107, 108, 104, 146, 223, 3, 2, 98,
		173, 108
	})]
	public virtual void addParameter(CtClass type)
	{
		declaringClass.checkModify();
		string descriptor = methodInfo.getDescriptor();
		string descriptor2 = Descriptor.appendParameter(type, descriptor);
		int num = ((!Modifier.isStatic(getModifiers())) ? 1 : 0);
		BadBytecode badBytecode;
		try
		{
			addParameter2(num + Descriptor.paramSize(descriptor), type, descriptor);
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0050;
		}
		methodInfo.setDescriptor(descriptor2);
		return;
		IL_0050:
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 92, 107, 108, 117 })]
	public virtual void instrument(CodeConverter converter)
	{
		declaringClass.checkModify();
		ConstPool constPool = methodInfo.getConstPool();
		converter.doit(getDeclaringClass(), methodInfo, constPool);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 115, 109, 139, 116, 109 })]
	public virtual void instrument(ExprEditor editor)
	{
		if (declaringClass.isFrozen())
		{
			declaringClass.checkModify();
		}
		if (editor.doit(declaringClass, methodInfo))
		{
			declaringClass.checkModify();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 140, 106 })]
	public virtual void insertBefore(string src)
	{
		insertBefore(src, true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 198, 107 })]
	public virtual void insertAfter(string src)
	{
		insertAfter(src, asFinally: false, redundant: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 9, 111 })]
	public virtual void addCatch(string src, CtClass exceptionType)
	{
		addCatch(src, exceptionType, "$e");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(1233)]
	public virtual int insertAt(int lineNum, string src)
	{
		int result = insertAt(lineNum, modify: true, src);
		_ = null;
		return result;
	}
}
