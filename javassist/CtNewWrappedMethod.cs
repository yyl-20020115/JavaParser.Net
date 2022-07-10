using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javassist.bytecode;
using javassist.compiler;

namespace javassist;

internal class CtNewWrappedMethod : Object
{
	private const string addedWrappedMethod = "_added_m$";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(182)]
	internal static int compileParameterList(Bytecode P_0, CtClass[] P_1, int P_2)
	{
		int result = JvstCodeGen.compileParameterList(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 16, 108, 115, 144, 103, 105 })]
	internal static Bytecode makeBody(CtClass P_0, ClassFile P_1, CtMethod P_2, CtClass[] P_3, CtClass P_4, CtMethod.ConstParameter P_5)
	{
		int num = (Modifier.isStatic(P_2.getModifiers()) ? 1 : 0);
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(P_1.getConstPool(), 0, 0);
		int maxStack = makeBody0(P_0, P_1, P_2, (byte)num != 0, P_3, P_4, P_5, bytecode);
		bytecode.setMaxStack(maxStack);
		bytecode.setMaxLocals((byte)num != 0, P_3, 0);
		return bytecode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		159, 183, 139, 141, 217, 2, 97, 172, 149, 104,
		141
	})]
	public static CtMethod wrapped(CtClass P_0, string P_1, CtClass[] P_2, CtClass[] P_3, CtMethod P_4, CtMethod.ConstParameter P_5, CtClass P_6)
	{
		CtMethod ctMethod = new CtMethod(P_0, P_1, P_2, P_6);
		ctMethod.setModifiers(P_4.getModifiers());
		NotFoundException ex;
		try
		{
			ctMethod.setExceptionTypes(P_3);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002e;
		}
		Bytecode bytecode = makeBody(P_6, P_6.getClassFile2(), P_4, P_2, P_0, P_5);
		MethodInfo methodInfo = ctMethod.getMethodInfo2();
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		return ctMethod;
		IL_002e:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		159,
		121,
		98,
		104,
		112,
		154,
		99,
		136,
		100,
		39,
		198,
		100,
		98,
		168,
		106,
		168,
		199,
		byte.MaxValue,
		4,
		72,
		2,
		98,
		173,
		99,
		145,
		143,
		137,
		102,
		132
	})]
	protected internal static int makeBody0(CtClass P_0, ClassFile P_1, CtMethod P_2, bool P_3, CtClass[] P_4, CtClass P_5, CtMethod.ConstParameter P_6, Bytecode P_7)
	{
		if (!(P_0 is CtClassType))
		{
			string msg = new StringBuilder().append("bad declaring class").append(P_0.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
		if (!P_3)
		{
			P_7.addAload(0);
		}
		int num = compileParameterList(P_7, P_4, (!P_3) ? 1 : 0);
		int num2;
		string text;
		if (P_6 == null)
		{
			num2 = 0;
			text = CtMethod.ConstParameter.defaultDescriptor();
		}
		else
		{
			num2 = P_6.compile(P_7);
			text = P_6.descriptor();
		}
		checkSignature(P_2, text);
		string name;
		BadBytecode badBytecode;
		try
		{
			name = addBodyMethod((CtClassType)P_0, P_1, P_2);
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0096;
		}
		if (P_3)
		{
			P_7.addInvokestatic(Bytecode.___003C_003ETHIS, name, text);
		}
		else
		{
			P_7.addInvokespecial(Bytecode.___003C_003ETHIS, name, text);
		}
		compileReturn(P_7, P_5);
		if (num < num2 + 2)
		{
			num = num2 + 2;
		}
		return num;
		IL_0096:
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 86, 115, 144, 119, 122 })]
	private static void checkSignature(CtMethod P_0, string P_1)
	{
		if (!String.instancehelper_equals(P_1, P_0.getMethodInfo2().getDescriptor()))
		{
			string msg = new StringBuilder().append("wrapped method with a bad signature: ").append(P_0.getDeclaringClass().getName()).append('.')
				.append(P_0.getName())
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		98, 103, 109, 134, 127, 1, 105, 102, 120, 104,
		140, 104, 109, 145, 103, 105, 104, 100, 174
	})]
	private static string addBodyMethod(CtClassType P_0, ClassFile P_1, CtMethod P_2)
	{
		Map hiddenMethods = P_0.getHiddenMethods();
		string text = (string)hiddenMethods.get(P_2);
		if (text == null)
		{
			do
			{
				text = new StringBuilder().append("_added_m$").append(P_0.getUniqueNumber()).toString();
			}
			while (P_1.getMethod(text) != null);
			ClassMap classMap = new ClassMap();
			classMap.put(P_2.getDeclaringClass().getName(), P_0.getName());
			MethodInfo methodInfo = new MethodInfo(P_1.getConstPool(), text, P_2.getMethodInfo2(), classMap);
			int accessFlags = methodInfo.getAccessFlags();
			methodInfo.setAccessFlags(AccessFlag.setPrivate(accessFlags));
			methodInfo.addAttribute(new SyntheticAttribute(P_1.getConstPool()));
			P_1.addMethod(methodInfo);
			hiddenMethods.put(P_2, text);
			P_0.hasMemberCache()?.addMethod(new CtMethod(methodInfo, P_0));
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 75, 104, 103, 104, 103, 103, 105, 37, 197,
		108, 130, 103, 141
	})]
	private static void compileReturn(Bytecode P_0, CtClass P_1)
	{
		if (P_1.isPrimitive())
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_1;
			if (ctPrimitiveType != CtClass.voidType)
			{
				string wrapperName = ctPrimitiveType.getWrapperName();
				P_0.addCheckcast(wrapperName);
				P_0.addInvokevirtual(wrapperName, ctPrimitiveType.getGetMethodName(), ctPrimitiveType.getGetMethodDescriptor());
			}
			P_0.addOpcode(ctPrimitiveType.getReturnOp());
		}
		else
		{
			P_0.addCheckcast(P_1);
			P_0.addOpcode(176);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(30)]
	internal CtNewWrappedMethod()
	{
	}
}
