using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public sealed class TransformNew : Transformer
{
	private int nested;

	private string classname;

	private string trapClass;

	private string trapMethod;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 176, 105, 103, 103, 104 })]
	public TransformNew(Transformer next, string classname, string trapClass, string trapMethod)
		: base(next)
	{
		this.classname = classname;
		this.trapClass = trapClass;
		this.trapMethod = trapMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 52, 109, 109, 137, 37, 37, 167, 101, 37 })]
	private int computeMethodref(int P_0, ConstPool P_1)
	{
		int classInfo = P_1.addClassInfo(trapClass);
		int name = P_1.addUtf8Info(trapMethod);
		P_0 = P_1.addUtf8Info(Descriptor.changeReturnType(classname, P_1.getUtf8Info(P_0)));
		int result = P_1.addMethodrefInfo(classInfo, P_1.addNameAndTypeInfo(name, P_0));
		_ = null;
		return result;
	}

	public override void initialize(ConstPool cp, CodeAttribute attr)
	{
		nested = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		12, 104, 107, 106, 120, 109, 176, 104, 106, 106,
		106, 142, 97, 117, 99, 135, 97, 117, 99, 103,
		130, 104, 106, 112, 109, 108, 108, 107, 206
	})]
	public override int transform(CtClass clazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		switch (iterator.byteAt(pos))
		{
		case 187:
		{
			int index = iterator.u16bitAt(pos + 1);
			if (String.instancehelper_equals(cp.getClassInfo(index), classname))
			{
				if (iterator.byteAt(pos + 3) != 89)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CannotCompileException("NEW followed by no DUP was found");
				}
				iterator.writeByte(0, pos);
				iterator.writeByte(0, pos + 1);
				iterator.writeByte(0, pos + 2);
				iterator.writeByte(0, pos + 3);
				nested++;
				((StackMapTable)iterator.get().getAttribute("StackMapTable"))?.removeNew(pos);
				((StackMap)iterator.get().getAttribute("StackMap"))?.removeNew(pos);
			}
			break;
		}
		case 183:
		{
			int index = iterator.u16bitAt(pos + 1);
			int num = cp.isConstructor(classname, index);
			if (num != 0 && nested > 0)
			{
				int value = computeMethodref(num, cp);
				iterator.writeByte(184, pos);
				iterator.write16bit(value, pos + 1);
				nested--;
			}
			break;
		}
		}
		return pos;
	}
}
