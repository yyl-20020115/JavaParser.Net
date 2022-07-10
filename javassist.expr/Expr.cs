using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javassist.bytecode;

namespace javassist.expr;

public abstract class Expr : java.lang.Object, Opcode
{
	internal int currentPos;

	internal CodeIterator iterator;

	internal CtClass thisClass;

	internal MethodInfo thisMethod;

	internal bool edited;

	internal int maxLocals;

	internal int maxStack;

	internal const string javaLangObject = "java.lang.Object";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/CtClass;>;Ljavassist/CtClass;)V")]
	[LineNumberTable(new byte[] { 123, 105, 129, 104 })]
	private static void addClass(List P_0, CtClass P_1)
	{
		if (!P_0.contains(P_1))
		{
			P_0.add(P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 127, 100, 97, 132, 104, 142, 130, 111, 106 })]
	private static void storeStack0(int P_0, int P_1, CtClass[] P_2, int P_3, Bytecode P_4)
	{
		if (P_0 < P_1)
		{
			CtClass ctClass = P_2[P_0];
			int num = ((!(ctClass is CtPrimitiveType)) ? 1 : ((CtPrimitiveType)ctClass).getDataSize());
			storeStack0(P_0 + 1, P_1, P_2, P_3 + num, P_4);
			P_4.addStore(P_3, ctClass);
		}
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public abstract void replace(string str);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 191, 103, 103, 103, 103, 108, 103, 136, 104,
		104, 108, 121, 135, 114, 103, 103, 109, 116
	})]
	protected internal virtual void runEditor(ExprEditor ed, CodeIterator oldIterator)
	{
		CodeAttribute codeAttribute = oldIterator.get();
		int num = codeAttribute.getMaxLocals();
		int num2 = codeAttribute.getMaxStack();
		int num3 = locals();
		codeAttribute.setMaxStack(stack());
		codeAttribute.setMaxLocals(num3);
		ExprEditor.LoopContext loopContext = new ExprEditor.LoopContext(num3);
		int codeLength = oldIterator.getCodeLength();
		int num4 = oldIterator.lookAhead();
		oldIterator.move(currentPos);
		if (ed.doit(thisClass, thisMethod, loopContext, oldIterator, num4))
		{
			this.edited = true;
		}
		oldIterator.move(num4 + oldIterator.getCodeLength() - codeLength);
		codeAttribute.setMaxLocals(num);
		codeAttribute.setMaxStack(num2);
		maxLocals = loopContext.maxLocals;
		maxStack += loopContext.maxStack;
	}

	protected internal int locals()
	{
		return maxLocals;
	}

	protected internal int stack()
	{
		return maxStack;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 104, 103, 103, 103, 104 })]
	protected internal Expr(int pos, CodeIterator i, CtClass declaring, MethodInfo m)
	{
		currentPos = pos;
		iterator = i;
		thisClass = declaring;
		thisMethod = m;
	}

	public virtual CtClass getEnclosingClass()
	{
		return thisClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	protected internal ConstPool getConstPool()
	{
		ConstPool constPool = thisMethod.getConstPool();
		_ = null;
		return constPool;
	}

	protected internal bool edited()
	{
		return this.edited;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	protected internal bool withinStatic()
	{
		return (((uint)thisMethod.getAccessFlags() & 8u) != 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		50, 103, 108, 105, 107, 4, 198, 108, 108, 226,
		71, 107, 127, 7, 105, 113, 229, 60, 232, 72
	})]
	public virtual CtBehavior where()
	{
		MethodInfo methodInfo = thisMethod;
		CtBehavior[] declaredBehaviors = thisClass.getDeclaredBehaviors();
		for (int i = (int)((nint)declaredBehaviors.LongLength - 1); i >= 0; i += -1)
		{
			if (declaredBehaviors[i].getMethodInfo2() == methodInfo)
			{
				return declaredBehaviors[i];
			}
		}
		CtConstructor classInitializer = thisClass.getClassInitializer();
		if (classInitializer != null && classInitializer.getMethodInfo2() == methodInfo)
		{
			return classInitializer;
		}
		for (int j = (int)((nint)declaredBehaviors.LongLength - 1); j >= 0; j += -1)
		{
			if (java.lang.String.instancehelper_equals(thisMethod.getName(), declaredBehaviors[j].getMethodInfo2().getName()) && java.lang.String.instancehelper_equals(thisMethod.getDescriptor(), declaredBehaviors[j].getMethodInfo2().getDescriptor()))
			{
				return declaredBehaviors[j];
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("fatal: not found");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		83, 108, 108, 134, 108, 104, 104, 105, 127, 5,
		122, 107, 133, 188, 60, 225, 57, 235, 76, 34,
		161, 109, 100, 105, 100, 101, 137, 188, 34, 225,
		60, 232, 73
	})]
	public virtual CtClass[] mayThrow()
	{
		ClassPool classPool = thisClass.getClassPool();
		ConstPool constPool = thisMethod.getConstPool();
		LinkedList linkedList = new LinkedList();
		ExceptionTable exceptionTable;
		int num3;
		int num;
		int num2;
		try
		{
			CodeAttribute codeAttribute = thisMethod.getCodeAttribute();
			exceptionTable = codeAttribute.getExceptionTable();
			num = currentPos;
			num2 = exceptionTable.size();
			num3 = 0;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0058;
		}
		object obj;
		while (true)
		{
			try
			{
				if (num3 >= num2)
				{
					break;
				}
				if (exceptionTable.startPc(num3) <= num && num < exceptionTable.endPc(num3))
				{
					int num4 = exceptionTable.catchType(num3);
					if (num4 > 0)
					{
						try
						{
							addClass(linkedList, classPool.get(constPool.getClassInfo(num4)));
						}
						catch (NotFoundException)
						{
							goto IL_00c3;
						}
					}
				}
				goto IL_00ca;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00c6;
			}
			IL_00c6:
			obj = null;
			break;
			IL_00c3:
			_ = null;
			goto IL_00ca;
			IL_00ca:
			num3++;
		}
		goto IL_00d8;
		IL_0058:
		obj = null;
		goto IL_00d8;
		IL_00d8:
		ExceptionsAttribute exceptionsAttribute = thisMethod.getExceptionsAttribute();
		if (exceptionsAttribute != null)
		{
			string[] exceptions = exceptionsAttribute.getExceptions();
			if (exceptions != null)
			{
				num = exceptions.Length;
				for (num2 = 0; num2 < num; num2++)
				{
					try
					{
						addClass(linkedList, classPool.get(exceptions[num2]));
					}
					catch (NotFoundException)
					{
						goto IL_011d;
					}
					continue;
					IL_011d:
					_ = null;
				}
			}
		}
		return (CtClass[])((List)linkedList).toArray((object[])new CtClass[((List)linkedList).size()]);
	}

	public virtual int indexOfBytecode()
	{
		return currentPos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(194)]
	public virtual int getLineNumber()
	{
		int lineNumber = thisMethod.getLineNumber(currentPos);
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 108, 99, 98 })]
	public virtual string getFileName()
	{
		ClassFile classFile = thisClass.getClassFile2();
		if (classFile == null)
		{
			return null;
		}
		string sourceFile = classFile.getSourceFile();
		_ = null;
		return sourceFile;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[LineNumberTable(new byte[] { 160, 100, 114, 107, 208 })]
	internal static bool checkResultValue(CtClass P_0, string P_1)
	{
		int num = ((java.lang.String.instancehelper_indexOf(P_1, "$_") >= 0) ? 1 : 0);
		if (num == 0 && P_0 != CtClass.voidType)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("the resulting value is not stored in $_");
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[LineNumberTable(new byte[] { 159, 84, 66, 109, 99, 135, 105 })]
	internal static void storeStack(CtClass[] P_0, bool P_1, int P_2, Bytecode P_3)
	{
		storeStack0(0, P_0.Length, P_0, P_2 + 1, P_3);
		if (P_1)
		{
			P_3.addOpcode(1);
		}
		P_3.addAstore(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 166, 103, 99, 111 })]
	public virtual void replace(string statement, ExprEditor recursive)
	{
		replace(statement);
		if (recursive != null)
		{
			runEditor(recursive, iterator);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 173, 103, 103, 101, 102, 47, 166, 100, 149,
		109, 114, 108, 108
	})]
	protected internal virtual void replace0(int pos, Bytecode bytecode, int size)
	{
		byte[] array = bytecode.get();
		this.edited = true;
		int num = (int)((nint)array.LongLength - size);
		for (int i = 0; i < size; i++)
		{
			iterator.writeByte(0, pos + i);
		}
		if (num > 0)
		{
			pos = iterator.insertGapAt(pos, num, exclusive: false).position;
		}
		iterator.write(array, pos);
		iterator.insert(bytecode.getExceptionTable(), pos);
		maxLocals = bytecode.getMaxLocals();
		maxStack = bytecode.getMaxStack();
	}
}
