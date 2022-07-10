using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class ExceptionTable : Object, Cloneable.__Interface
{
	private ConstPool constPool;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/ExceptionTableEntry;>;")]
	private List entries;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 96, 100, 118 })]
	public virtual void add(int start, int end, int handler, int type)
	{
		if (start < end)
		{
			entries.add(new ExceptionTableEntry(start, end, handler, type));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 103, 107 })]
	public ExceptionTable(ConstPool cp)
	{
		constPool = cp;
		entries = new ArrayList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.CloneNotSupportedException" })]
	[LineNumberTable(new byte[] { 29, 108, 118 })]
	public override object clone()
	{
		ExceptionTable exceptionTable = (ExceptionTable)base.clone();
		ArrayList.___003Cclinit_003E();
		exceptionTable.entries = new ArrayList(entries);
		return exceptionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public virtual int size()
	{
		int result = entries.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(136)]
	public virtual int handlerPc(int nth)
	{
		return ((ExceptionTableEntry)entries.get(nth)).handlerPc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/ExceptionTable;")]
	[LineNumberTable(new byte[] { 160, 119, 103, 103, 127, 1, 112, 122, 130 })]
	public virtual ExceptionTable copy(ConstPool newCp, Map classnames)
	{
		ExceptionTable exceptionTable = new ExceptionTable(newCp);
		ConstPool constPool = this.constPool;
		Iterator iterator = entries.iterator();
		while (iterator.hasNext())
		{
			ExceptionTableEntry exceptionTableEntry = (ExceptionTableEntry)iterator.next();
			int type = constPool.copy(exceptionTableEntry.catchType, newCp, classnames);
			exceptionTable.add(exceptionTableEntry.startPc, exceptionTableEntry.endPc, exceptionTableEntry.handlerPc, type);
		}
		return exceptionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		7, 104, 103, 103, 103, 102, 104, 104, 104, 104,
		244, 59, 230, 72, 103
	})]
	internal ExceptionTable(ConstPool P_0, DataInputStream P_1)
	{
		constPool = P_0;
		int num = P_1.readUnsignedShort();
		ArrayList arrayList = new ArrayList(num);
		for (int i = 0; i < num; i++)
		{
			int num2 = P_1.readUnsignedShort();
			int num3 = P_1.readUnsignedShort();
			int num4 = P_1.readUnsignedShort();
			int num5 = P_1.readUnsignedShort();
			((List)arrayList).add((object)new ExceptionTableEntry(num2, num3, num4, num5));
		}
		entries = arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 146, 108, 127, 1, 108, 108, 108, 108, 98 })]
	internal virtual void write(DataOutputStream P_0)
	{
		P_0.writeShort(size());
		Iterator iterator = entries.iterator();
		while (iterator.hasNext())
		{
			ExceptionTableEntry exceptionTableEntry = (ExceptionTableEntry)iterator.next();
			P_0.writeShort(exceptionTableEntry.startPc);
			P_0.writeShort(exceptionTableEntry.endPc);
			P_0.writeShort(exceptionTableEntry.handlerPc);
			P_0.writeShort(exceptionTableEntry.catchType);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 64, 103, 104, 114, 159, 6, 98 })]
	public virtual void add(int index, ExceptionTable table, int offset)
	{
		int num = table.size();
		while (true)
		{
			num += -1;
			if (num >= 0)
			{
				ExceptionTableEntry exceptionTableEntry = (ExceptionTableEntry)table.entries.get(num);
				add(index, exceptionTableEntry.startPc + offset, exceptionTableEntry.endPc + offset, exceptionTableEntry.handlerPc + offset, exceptionTableEntry.catchType);
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 81, 66, 127, 1, 116, 116, 116, 98 })]
	internal virtual void shiftPc(int P_0, int P_1, bool P_2)
	{
		Iterator iterator = entries.iterator();
		while (iterator.hasNext())
		{
			ExceptionTableEntry exceptionTableEntry = (ExceptionTableEntry)iterator.next();
			exceptionTableEntry.startPc = shiftPc(exceptionTableEntry.startPc, P_0, P_1, P_2);
			exceptionTableEntry.endPc = shiftPc(exceptionTableEntry.endPc, P_0, P_1, P_2);
			exceptionTableEntry.handlerPc = shiftPc(exceptionTableEntry.handlerPc, P_0, P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 82, 100, 153 })]
	public virtual void add(int index, int start, int end, int handler, int type)
	{
		if (start < end)
		{
			entries.add(index, new ExceptionTableEntry(start, end, handler, type));
		}
	}

	private static int shiftPc(int P_0, int P_1, int P_2, bool P_3)
	{
		if (P_0 > P_1 || (P_3 && P_0 == P_1))
		{
			P_0 += P_2;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(98)]
	public virtual int startPc(int nth)
	{
		return ((ExceptionTableEntry)entries.get(nth)).startPc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 119 })]
	public virtual void setStartPc(int nth, int value)
	{
		((ExceptionTableEntry)entries.get(nth)).startPc = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public virtual int endPc(int nth)
	{
		return ((ExceptionTableEntry)entries.get(nth)).endPc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 77, 119 })]
	public virtual void setEndPc(int nth, int value)
	{
		((ExceptionTableEntry)entries.get(nth)).endPc = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 96, 119 })]
	public virtual void setHandlerPc(int nth, int value)
	{
		((ExceptionTableEntry)entries.get(nth)).handlerPc = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(157)]
	public virtual int catchType(int nth)
	{
		return ((ExceptionTableEntry)entries.get(nth)).catchType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 117, 119 })]
	public virtual void setCatchType(int nth, int value)
	{
		((ExceptionTableEntry)entries.get(nth)).catchType = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 109 })]
	public virtual void remove(int index)
	{
		entries.remove(index);
	}

	[HideFromJava]
	public static implicit operator Cloneable(ExceptionTable P_0)
	{
		Cloneable result = default(Cloneable);
		result.___003Cref_003E = P_0;
		return result;
	}
}
