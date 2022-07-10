using System.Runtime.CompilerServices;
using IKVM.Attributes;
using javassist.bytecode;

namespace javassist.convert;

public class TransformAfter : TransformBefore
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 159, 171, 107 })]
	public TransformAfter(Transformer next, CtMethod origMethod, CtMethod afterMethod)
		: base(next, origMethod, afterMethod)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 176, 103, 109, 109, 104, 103, 109, 104, 103,
		110, 114, 108, 111, 103
	})]
	protected internal override int match2(int pos, CodeIterator iterator)
	{
		iterator.move(pos);
		iterator.insert(saveCode);
		iterator.insert(loadCode);
		int mark = iterator.insertGap(3);
		iterator.setMark(mark);
		iterator.insert(loadCode);
		pos = iterator.next();
		mark = iterator.getMark();
		iterator.writeByte(iterator.byteAt(pos), mark);
		iterator.write16bit(iterator.u16bitAt(pos + 1), mark + 1);
		iterator.writeByte(184, pos);
		iterator.write16bit(newIndex, pos + 1);
		iterator.move(mark);
		int result = iterator.next();
		_ = null;
		return result;
	}
}
