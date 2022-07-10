using System.Runtime.CompilerServices;
using IKVM.Attributes;
using javassist.bytecode;

namespace javassist.convert;

public class TransformCallToStatic : TransformCall
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 153, 107, 113 })]
	public TransformCallToStatic(Transformer next, CtMethod origMethod, CtMethod substMethod)
		: base(next, origMethod, substMethod)
	{
		methodDescriptor = origMethod.getMethodInfo2().getDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 159, 104, 114, 111, 110, 111, 136, 108, 111 })]
	protected internal override int match(int c, int pos, CodeIterator iterator, int typedesc, ConstPool cp)
	{
		if (newIndex == 0)
		{
			string type = Descriptor.insertParameter(classname, methodDescriptor);
			int nameAndTypeInfo = cp.addNameAndTypeInfo(newMethodname, type);
			int classInfo = cp.addClassInfo(newClassname);
			newIndex = cp.addMethodrefInfo(classInfo, nameAndTypeInfo);
			constPool = cp;
		}
		iterator.writeByte(184, pos);
		iterator.write16bit(newIndex, pos + 1);
		return pos;
	}
}
