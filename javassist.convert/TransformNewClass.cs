using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public sealed class TransformNewClass : Transformer
{
	private int nested;

	private string classname;

	private string newClassName;

	private int newClassIndex;

	private int newMethodNTIndex;

	private int newMethodIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 105, 103, 103 })]
	public TransformNewClass(Transformer next, string classname, string newClassName)
		: base(next)
	{
		this.classname = classname;
		this.newClassName = newClassName;
	}

	[LineNumberTable(new byte[] { 159, 181, 103, 125 })]
	public override void initialize(ConstPool cp, CodeAttribute attr)
	{
		nested = 0;
		int num = 0;
		int num2 = num;
		newMethodIndex = num;
		num = num2;
		int num3 = num;
		newMethodNTIndex = num;
		newClassIndex = num3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		5, 104, 107, 106, 120, 109, 176, 104, 147, 111,
		179, 107, 106, 111, 108, 105, 105, 103, 180, 111,
		206
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
				if (newClassIndex == 0)
				{
					newClassIndex = cp.addClassInfo(newClassName);
				}
				iterator.write16bit(newClassIndex, pos + 1);
				nested++;
			}
			break;
		}
		case 183:
		{
			int index = iterator.u16bitAt(pos + 1);
			if (cp.isConstructor(classname, index) != 0 && nested > 0)
			{
				int methodrefNameAndType = cp.getMethodrefNameAndType(index);
				if (newMethodNTIndex != methodrefNameAndType)
				{
					newMethodNTIndex = methodrefNameAndType;
					newMethodIndex = cp.addMethodrefInfo(newClassIndex, methodrefNameAndType);
				}
				iterator.write16bit(newMethodIndex, pos + 1);
				nested--;
			}
			break;
		}
		}
		return pos;
	}
}
