using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public sealed class TransformWriteField : TransformReadField
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 172, 109 })]
	public TransformWriteField(Transformer next, CtField field, string methodClassname, string methodName)
		: base(next, field, methodClassname, methodName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 179, 104, 115, 106, 159, 2, 102, 107, 103,
		103, 105, 140, 105, 104, 107, 107, 208, 105, 104,
		107, 174, 168, 111, 127, 7, 115, 108, 203
	})]
	public override int transform(CtClass tclazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		int num = iterator.byteAt(pos);
		if (num == 181 || num == 179)
		{
			int num2 = iterator.u16bitAt(pos + 1);
			string text = TransformReadField.isField(tclazz.getClassPool(), cp, fieldClass, fieldname, isPrivate, num2);
			if (text != null)
			{
				if (num == 179)
				{
					CodeAttribute codeAttribute = iterator.get();
					iterator.move(pos);
					int num3 = String.instancehelper_charAt(text, 0);
					if (num3 == 74 || num3 == 68)
					{
						pos = iterator.insertGap(3);
						iterator.writeByte(1, pos);
						iterator.writeByte(91, pos + 1);
						iterator.writeByte(87, pos + 2);
						codeAttribute.setMaxStack(codeAttribute.getMaxStack() + 2);
					}
					else
					{
						pos = iterator.insertGap(2);
						iterator.writeByte(1, pos);
						iterator.writeByte(95, pos + 1);
						codeAttribute.setMaxStack(codeAttribute.getMaxStack() + 1);
					}
					pos = iterator.next();
				}
				int classInfo = cp.addClassInfo(methodClassname);
				string type = new StringBuilder().append("(Ljava/lang/Object;").append(text).append(")V")
					.toString();
				int value = cp.addMethodrefInfo(classInfo, methodName, type);
				iterator.writeByte(184, pos);
				iterator.write16bit(value, pos + 1);
			}
		}
		return pos;
	}
}
