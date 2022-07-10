using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public class TransformBefore : TransformCall
{
	protected internal CtClass[] parameterTypes;

	protected internal int locals;

	protected internal int maxLocals;

	protected internal byte[] saveCode;

	protected internal byte[] loadCode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 159, 181, 171, 145, 108, 103, 103, 114 })]
	public TransformBefore(Transformer next, CtMethod origMethod, CtMethod beforeMethod)
		: base(next, origMethod, beforeMethod)
	{
		methodDescriptor = origMethod.getMethodInfo2().getDescriptor();
		parameterTypes = origMethod.getParameterTypes();
		locals = 0;
		maxLocals = 0;
		_ = null;
		loadCode = null;
		saveCode = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 105, 137, 103, 105, 103, 110, 135, 108, 108 })]
	protected internal virtual void makeCode(CtClass[] paramTypes, ConstPool cp)
	{
		Bytecode bytecode = new Bytecode(cp, 0, 0);
		Bytecode bytecode2 = new Bytecode(cp, 0, 0);
		int num = maxLocals;
		int num2 = (int)((paramTypes != null) ? paramTypes.LongLength : 0);
		bytecode2.addAload(num);
		makeCode2(bytecode, bytecode2, 0, num2, paramTypes, num + 1);
		bytecode.addAstore(num);
		saveCode = bytecode.get();
		loadCode = bytecode2.get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 28, 103, 109, 109, 104, 108, 111, 109 })]
	protected internal virtual int match2(int pos, CodeIterator iterator)
	{
		iterator.move(pos);
		iterator.insert(saveCode);
		iterator.insert(loadCode);
		int num = iterator.insertGap(3);
		iterator.writeByte(184, num);
		iterator.write16bit(newIndex, num + 1);
		iterator.insert(loadCode);
		int result = iterator.next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 101, 109, 115, 109, 130, 111 })]
	private void makeCode2(Bytecode P_0, Bytecode P_1, int P_2, int P_3, CtClass[] P_4, int P_5)
	{
		if (P_2 < P_3)
		{
			int num = P_1.addLoad(P_5, P_4[P_2]);
			makeCode2(P_0, P_1, P_2 + 1, P_3, P_4, P_5 + num);
			P_0.addStore(P_5, P_4[P_2]);
		}
		else
		{
			locals = P_5 - maxLocals;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 103, 108, 114 })]
	public override void initialize(ConstPool cp, CodeAttribute attr)
	{
		base.initialize(cp, attr);
		locals = 0;
		maxLocals = attr.getMaxLocals();
		_ = null;
		loadCode = null;
		saveCode = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		12, 104, 127, 3, 109, 111, 110, 111, 168, 104,
		142
	})]
	protected internal override int match(int c, int pos, CodeIterator iterator, int typedesc, ConstPool cp)
	{
		if (newIndex == 0)
		{
			string desc = new StringBuilder().append(Descriptor.ofParameters(parameterTypes)).append('V').toString();
			desc = Descriptor.insertParameter(classname, desc);
			int nameAndTypeInfo = cp.addNameAndTypeInfo(newMethodname, desc);
			int classInfo = cp.addClassInfo(newClassname);
			newIndex = cp.addMethodrefInfo(classInfo, nameAndTypeInfo);
			constPool = cp;
		}
		if (saveCode == null)
		{
			makeCode(parameterTypes, cp);
		}
		int result = match2(pos, iterator);
		_ = null;
		return result;
	}

	public override int extraLocals()
	{
		return locals;
	}
}
