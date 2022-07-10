using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;

namespace javassist;

internal class CtNewWrappedConstructor : CtNewWrappedMethod
{
	private const int PASS_NONE = 0;

	private const int PASS_PARAMS = 2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 159, 180, 105, 103, 180, 145, 151, 98 })]
	public static CtConstructor wrapped(CtClass[] P_0, CtClass[] P_1, int P_2, CtMethod P_3, CtMethod.ConstParameter P_4, CtClass P_5)
	{
		//Discarded unreachable code: IL_0038
		NotFoundException ex;
		try
		{
			CtConstructor ctConstructor = new CtConstructor(P_0, P_5);
			ctConstructor.setExceptionTypes(P_1);
			Bytecode bytecode = makeBody(P_5, P_5.getClassFile2(), P_2, P_3, P_0, P_4);
			ctConstructor.getMethodInfo2().setCodeAttribute(bytecode.toCodeAttribute());
			return ctConstructor;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		11, 103, 115, 106, 103, 99, 98, 150, 100, 108,
		105, 37, 199, 138, 100, 98, 169, 107, 169, 100,
		130, 174, 99, 141, 180, 100, 162, 103
	})]
	protected internal static Bytecode makeBody(CtClass P_0, ClassFile P_1, int P_2, CtMethod P_3, CtClass[] P_4, CtMethod.ConstParameter P_5)
	{
		int superclassId = P_1.getSuperclassId();
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(P_1.getConstPool(), 0, 0);
		bytecode.setMaxLocals(isStatic: false, P_4, 0);
		bytecode.addAload(0);
		int num;
		switch (P_2)
		{
		case 0:
			num = 1;
			bytecode.addInvokespecial(superclassId, "<init>", "()V");
			break;
		case 2:
			num = bytecode.addLoadParameters(P_4, 1) + 1;
			bytecode.addInvokespecial(superclassId, "<init>", Descriptor.ofConstructor(P_4));
			break;
		default:
		{
			num = CtNewWrappedMethod.compileParameterList(bytecode, P_4, 1);
			int num2;
			string desc;
			if (P_5 == null)
			{
				num2 = 2;
				desc = CtMethod.ConstParameter.defaultConstDescriptor();
			}
			else
			{
				num2 = P_5.compile(bytecode) + 2;
				desc = P_5.constDescriptor();
			}
			if (num < num2)
			{
				num = num2;
			}
			bytecode.addInvokespecial(superclassId, "<init>", desc);
			break;
		}
		}
		if (P_3 == null)
		{
			bytecode.add(177);
		}
		else
		{
			int num2 = CtNewWrappedMethod.makeBody0(P_0, P_1, P_3, false, P_4, CtClass.voidType, P_5, bytecode);
			if (num < num2)
			{
				num = num2;
			}
		}
		bytecode.setMaxStack(num);
		return bytecode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	internal CtNewWrappedConstructor()
	{
	}
}
