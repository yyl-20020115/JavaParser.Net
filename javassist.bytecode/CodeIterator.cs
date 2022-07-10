using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class CodeIterator : java.lang.Object, Opcode
{
	[Serializable]
	internal class AlignmentException : java.lang.Exception
	{
		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(823)]
		internal AlignmentException()
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AlignmentException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal abstract class Branch : java.lang.Object
	{
		internal int pos;

		internal int orgPos;

		[LineNumberTable(new byte[] { 158, 67, 130, 117, 110 })]
		internal virtual void shift(int P_0, int P_1, bool P_2)
		{
			if (P_0 < pos || (P_0 == pos && P_2))
			{
				pos += P_1;
			}
		}

		internal virtual bool expanded()
		{
			return false;
		}

		internal virtual int deltaSize()
		{
			return 0;
		}

		internal virtual int gapChanged()
		{
			return 0;
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		internal abstract int write(int P_0, byte[] P_1, int P_2, byte[] P_3);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1324)]
		internal Branch(int P_0)
		{
			orgPos = P_0;
			pos = P_0;
		}

		internal static int shiftOffset(int P_0, int P_1, int P_2, int P_3, bool P_4)
		{
			int num = P_0 + P_1;
			if (P_0 < P_2)
			{
				if (P_2 < num || (P_4 && P_2 == num))
				{
					P_1 += P_3;
				}
			}
			else if (P_0 == P_2)
			{
				if (num < P_2 && P_4)
				{
					P_1 -= P_3;
				}
				else if (P_2 < num && !P_4)
				{
					P_1 += P_3;
				}
			}
			else if (num < P_2 || (!P_4 && P_2 == num))
			{
				P_1 -= P_3;
			}
			return P_1;
		}
	}

	internal abstract class Branch16 : Branch
	{
		internal int offset;

		internal int state;

		internal const int BIT16 = 0;

		internal const int EXPAND = 1;

		internal const int BIT32 = 2;

		internal abstract void write32(int P_0, byte[] P_1, int P_2, byte[] P_3);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 5, 105, 103, 103 })]
		internal Branch16(int P_0, int P_1)
			: base(P_0)
		{
			offset = P_1;
			state = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 47, 130, 122, 105, 104, 122, 103 })]
		internal override void shift(int P_0, int P_1, bool P_2)
		{
			offset = Branch.shiftOffset(pos, offset, P_0, P_1, P_2);
			base.shift(P_0, P_1, P_2);
			if (state == 0 && (offset < -32768 || 32767 < offset))
			{
				state = 1;
			}
		}

		internal override bool expanded()
		{
			if (state == 1)
			{
				state = 2;
				return true;
			}
			return false;
		}

		internal abstract override int deltaSize();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 34, 105, 141, 103, 176 })]
		internal override int write(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			if (state == 2)
			{
				write32(P_0, P_1, P_2, P_3);
			}
			else
			{
				P_3[P_2] = P_1[P_0];
				ByteArray.write16bit(offset, P_3, P_2 + 1);
			}
			return 3;
		}
	}

	public class Gap : java.lang.Object
	{
		public int position;

		public int length;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(593)]
		public Gap()
		{
		}
	}

	internal class If16 : Branch16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 66, 106 })]
		internal If16(int P_0, int P_1)
			: base(P_0, P_1)
		{
		}

		internal virtual int opcode(int P_0)
		{
			switch (P_0)
			{
			case 198:
				return 199;
			case 199:
				return 198;
			default:
				if (((P_0 - 153) & 1) == 0)
				{
					return P_0 + 1;
				}
				return P_0 - 1;
			}
		}

		internal override int deltaSize()
		{
			return (state == 2) ? 5 : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 76, 110, 103, 103, 104, 116 })]
		internal override void write32(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			P_3[P_2] = (byte)(sbyte)opcode(P_1[P_0]);
			P_3[P_2 + 1] = 0;
			P_3[P_2 + 2] = 8;
			P_3[P_2 + 3] = 200;
			ByteArray.write32bit(offset - 3, P_3, P_2 + 4);
		}
	}

	internal class Jump16 : Branch16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 48, 106 })]
		internal Jump16(int P_0, int P_1)
			: base(P_0, P_1)
		{
		}

		internal override int deltaSize()
		{
			return (state == 2) ? 2 : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 58, 123, 114 })]
		internal override void write32(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			P_3[P_2] = (byte)(sbyte)((P_1[P_0] != 167) ? 201u : 200u);
			ByteArray.write32bit(offset, P_3, P_2 + 1);
		}
	}

	internal class Jump32 : Branch
	{
		internal int offset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 98, 105, 103 })]
		internal Jump32(int P_0, int P_1)
			: base(P_0)
		{
			offset = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 24, 130, 122, 107 })]
		internal override void shift(int P_0, int P_1, bool P_2)
		{
			offset = Branch.shiftOffset(pos, offset, P_0, P_1, P_2);
			base.shift(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 110, 103, 112 })]
		internal override int write(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			P_3[P_2] = P_1[P_0];
			ByteArray.write32bit(offset, P_3, P_2 + 1);
			return 5;
		}
	}

	internal class LdcW : Branch
	{
		internal int index;

		internal bool state;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 228, 105, 103, 103 })]
		internal LdcW(int P_0, int P_1)
			: base(P_0)
		{
			index = P_1;
			state = true;
		}

		internal override bool expanded()
		{
			if (state)
			{
				state = false;
				return true;
			}
			return false;
		}

		internal override int deltaSize()
		{
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 247, 102, 112 })]
		internal override int write(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			P_3[P_2] = 19;
			ByteArray.write16bit(index, P_3, P_2 + 1);
			return 2;
		}
	}

	internal class Lookup : Switcher
	{
		internal int[] matches;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 232, 110, 103 })]
		internal Lookup(int P_0, int P_1, int[] P_2, int[] P_3, Pointers P_4)
			: base(P_0, P_1, P_3, P_4)
		{
			matches = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 238, 104, 104, 101, 102, 111, 113, 229, 61,
			230, 70
		})]
		internal override int write2(int P_0, byte[] P_1)
		{
			int num = matches.Length;
			ByteArray.write32bit(num, P_1, P_0);
			P_0 += 4;
			for (int i = 0; i < num; i++)
			{
				ByteArray.write32bit(matches[i], P_1, P_0);
				ByteArray.write32bit(offsets[i], P_1, P_0 + 4);
				P_0 += 8;
			}
			return 4 + 8 * num;
		}

		[LineNumberTable(1645)]
		internal override int tableSize()
		{
			return (int)(4 + 8 * (nint)matches.LongLength);
		}
	}

	internal class Pointers : java.lang.Object
	{
		internal int cursor;

		internal int mark0;

		internal int mark;

		internal int mark2;

		internal ExceptionTable etable;

		internal LineNumberAttribute line;

		internal LocalVariableAttribute vars;

		internal LocalVariableAttribute types;

		internal StackMapTable stack;

		internal StackMap stack2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 167, 104, 103, 103, 103, 104, 104, 119, 119,
			119, 119, 119
		})]
		internal Pointers(int P_0, int P_1, int P_2, int P_3, ExceptionTable P_4, CodeAttribute P_5)
		{
			cursor = P_0;
			mark = P_1;
			mark2 = P_2;
			mark0 = P_3;
			etable = P_4;
			line = (LineNumberAttribute)P_5.getAttribute("LineNumberTable");
			vars = (LocalVariableAttribute)P_5.getAttribute("LocalVariableTable");
			types = (LocalVariableAttribute)P_5.getAttribute("LocalVariableTypeTable");
			stack = (StackMapTable)P_5.getAttribute("StackMapTable");
			stack2 = (StackMap)P_5.getAttribute("StackMap");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			158, 133, 162, 117, 142, 117, 142, 117, 142, 117,
			142, 110, 104, 142, 104, 142, 104, 142, 104, 142,
			104, 112
		})]
		internal virtual void shiftPc(int P_0, int P_1, bool P_2)
		{
			if (P_0 < cursor || (P_0 == cursor && P_2))
			{
				cursor += P_1;
			}
			if (P_0 < mark || (P_0 == mark && P_2))
			{
				mark += P_1;
			}
			if (P_0 < mark2 || (P_0 == mark2 && P_2))
			{
				mark2 += P_1;
			}
			if (P_0 < mark0 || (P_0 == mark0 && P_2))
			{
				mark0 += P_1;
			}
			etable.shiftPc(P_0, P_1, P_2);
			if (line != null)
			{
				line.shiftPc(P_0, P_1, P_2);
			}
			if (vars != null)
			{
				vars.shiftPc(P_0, P_1, P_2);
			}
			if (types != null)
			{
				types.shiftPc(P_0, P_1, P_2);
			}
			if (stack != null)
			{
				stack.shiftPc(P_0, P_1, P_2);
			}
			if (stack2 != null)
			{
				stack2.shiftPc(P_0, P_1, P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 163, 211, 104, 141, 104, 111 })]
		internal virtual void shiftForSwitch(int P_0, int P_1)
		{
			if (stack != null)
			{
				stack.shiftForSwitch(P_0, P_1);
			}
			if (stack2 != null)
			{
				stack2.shiftForSwitch(P_0, P_1);
			}
		}
	}

	internal abstract class Switcher : Branch
	{
		internal int gap;

		internal int defaultByte;

		internal int[] offsets;

		internal Pointers pointers;

		internal abstract int tableSize();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 165, 191, 116, 105, 142, 108, 107, 17, 166 })]
		internal virtual void adjustOffsets(int P_0, int P_1)
		{
			pointers.shiftForSwitch(pos + P_0, P_1);
			if (defaultByte == P_0)
			{
				defaultByte -= P_1;
			}
			for (int i = 0; i < (nint)offsets.LongLength; i++)
			{
				if (offsets[i] == P_0)
				{
					int[] array = offsets;
					int num = i;
					int[] array2 = array;
					array2[num] -= P_1;
				}
			}
		}

		internal abstract int write2(int P_0, byte[] P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 122, 105, 107, 103, 103, 104 })]
		internal Switcher(int P_0, int P_1, int[] P_2, Pointers P_3)
			: base(P_0)
		{
			gap = 3 - (P_0 & 3);
			defaultByte = P_1;
			offsets = P_2;
			pointers = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 17, 98, 103, 117, 104, 102, 57, 166, 107 })]
		internal override void shift(int P_0, int P_1, bool P_2)
		{
			int num = pos;
			defaultByte = Branch.shiftOffset(num, defaultByte, P_0, P_1, P_2);
			int num2 = offsets.Length;
			for (int i = 0; i < num2; i++)
			{
				offsets[i] = Branch.shiftOffset(num, offsets[i], P_0, P_1, P_2);
			}
			base.shift(P_0, P_1, P_2);
		}

		internal override int gapChanged()
		{
			int num = 3 - (pos & 3);
			if (num > gap)
			{
				int result = num - gap;
				gap = num;
				return result;
			}
			return 0;
		}

		internal override int deltaSize()
		{
			return gap - (3 - (orgPos & 3));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			165, 159, 107, 105, 116, 100, 136, 108, 104, 140,
			110, 108, 103, 104, 140
		})]
		internal override int write(int P_0, byte[] P_1, int P_2, byte[] P_3)
		{
			int num = 3 - (pos & 3);
			int num2 = gap - num;
			int num3 = 5 + (3 - (orgPos & 3)) + tableSize();
			if (num2 > 0)
			{
				adjustOffsets(num3, num2);
			}
			int num4 = P_2;
			P_2++;
			P_3[num4] = P_1[P_0];
			while (true)
			{
				int num5 = num;
				num += -1;
				if (num5 <= 0)
				{
					break;
				}
				int num6 = P_2;
				P_2++;
				P_3[num6] = 0;
			}
			ByteArray.write32bit(defaultByte, P_3, P_2);
			int num7 = write2(P_2 + 4, P_3);
			P_2 += num7 + 4;
			while (true)
			{
				int num8 = num2;
				num2 += -1;
				if (num8 <= 0)
				{
					break;
				}
				int num9 = P_2;
				P_2++;
				P_3[num9] = 0;
			}
			return 5 + (3 - (orgPos & 3)) + num7;
		}
	}

	internal class Table : Switcher
	{
		internal int low;

		internal int high;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 205, 110, 103, 104 })]
		internal Table(int P_0, int P_1, int P_2, int P_3, int[] P_4, Pointers P_5)
			: base(P_0, P_1, P_4, P_5)
		{
			low = P_2;
			high = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 212, 109, 111, 104, 101, 102, 111, 5, 230,
			69
		})]
		internal override int write2(int P_0, byte[] P_1)
		{
			ByteArray.write32bit(low, P_1, P_0);
			ByteArray.write32bit(high, P_1, P_0 + 4);
			int num = offsets.Length;
			P_0 += 8;
			for (int i = 0; i < num; i++)
			{
				ByteArray.write32bit(offsets[i], P_1, P_0);
				P_0 += 4;
			}
			return 8 + 4 * num;
		}

		[LineNumberTable(1619)]
		internal override int tableSize()
		{
			return (int)(8 + 4 * (nint)offsets.LongLength);
		}
	}

	protected internal CodeAttribute codeAttr;

	protected internal byte[] bytecode;

	protected internal int endPos;

	protected internal int currentPos;

	protected internal int mark;

	protected internal int mark2;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] opcodeLength;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public virtual bool hasNext()
	{
		return currentPos < endPos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 114, 103, 114 })]
	public virtual int next()
	{
		int num = currentPos;
		currentPos = nextOpcode(bytecode, num);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(437)]
	public virtual int insertEx(byte[] code)
	{
		int result = insert0(currentPos, code, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 79, 117 })]
	public virtual void insert(ExceptionTable et, int offset)
	{
		codeAttr.getExceptionTable().add(0, et, offset);
	}

	[LineNumberTable(146)]
	public virtual int getCodeLength()
	{
		return bytecode.Length;
	}

	[LineNumberTable(152)]
	public virtual int byteAt(int index)
	{
		return bytecode[index];
	}

	public virtual void setMark2(int index)
	{
		mark2 = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 89, 103, 99, 100, 130, 103, 103, 102, 40,
		166
	})]
	public virtual int append(byte[] code)
	{
		int codeLength = getCodeLength();
		int num = code.Length;
		if (num <= 0)
		{
			return codeLength;
		}
		appendGap(num);
		byte[] array = bytecode;
		for (int i = 0; i < num; i++)
		{
			array[i + codeLength] = code[i];
		}
		return codeLength;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 133, 108, 112 })]
	public virtual void append(ExceptionTable et, int offset)
	{
		ExceptionTable exceptionTable = codeAttr.getExceptionTable();
		exceptionTable.add(exceptionTable.size(), et, offset);
	}

	public virtual int getMark2()
	{
		return mark2;
	}

	public virtual void setMark(int index)
	{
		mark = index;
	}

	[LineNumberTable(new byte[] { 113, 106 })]
	public virtual void writeByte(int value, int index)
	{
		bytecode[index] = (byte)(sbyte)value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		158, 237, 66, 102, 100, 103, 103, 226, 69, 144,
		107, 49, 134, 104, 167, 104, 106, 48, 166, 107,
		103, 103, 101, 138, 117, 142, 117, 174, 108, 103,
		108, 104
	})]
	public virtual Gap insertGapAt(int pos, int length, bool exclusive)
	{
		Gap gap = new Gap();
		if (length <= 0)
		{
			gap.position = pos;
			gap.length = 0;
			return gap;
		}
		byte[] array;
		int num;
		if ((nint)bytecode.LongLength + length > 32767)
		{
			array = insertGapCore0w(bytecode, pos, length, exclusive, get().getExceptionTable(), codeAttr, gap);
			pos = gap.position;
			num = length;
		}
		else
		{
			int num2 = currentPos;
			array = insertGapCore0(bytecode, pos, length, exclusive, get().getExceptionTable(), codeAttr);
			num = (int)((nint)array.LongLength - (nint)bytecode.LongLength);
			gap.position = pos;
			gap.length = num;
			if (num2 >= pos)
			{
				currentPos = num2 + num;
			}
			if (mark > pos || (mark == pos && exclusive))
			{
				mark += num;
			}
			if (mark2 > pos || (mark2 == pos && exclusive))
			{
				mark2 += num;
			}
		}
		codeAttr.setCode(array);
		bytecode = array;
		endPos = getCodeLength();
		updateCursors(pos, num);
		return gap;
	}

	public virtual int getMark()
	{
		return mark;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 84, 111 })]
	public virtual void write32bit(int value, int index)
	{
		ByteArray.write32bit(value, bytecode, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 70, 111 })]
	public virtual void write16bit(int value, int index)
	{
		ByteArray.write16bit(value, bytecode, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(413)]
	public virtual int insertAt(int pos, byte[] code)
	{
		int result = insert0(pos, code, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(286)]
	public virtual int skipSuperConstructor()
	{
		int result = skipSuperConstructor0(0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(308)]
	public virtual int skipThisConstructor()
	{
		int result = skipSuperConstructor0(1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(170)]
	public virtual int u16bitAt(int index)
	{
		int result = ByteArray.readU16bit(bytecode, index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(264)]
	public virtual int skipConstructor()
	{
		int result = skipSuperConstructor0(-1);
		_ = null;
		return result;
	}

	public virtual void move(int index)
	{
		currentPos = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(177)]
	public virtual int s16bitAt(int index)
	{
		int result = ByteArray.readS16bit(bytecode, index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(191)]
	public virtual int s32bitAt(int index)
	{
		int result = ByteArray.read32bit(bytecode, index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 226, 108, 106, 99, 103, 170, 108 })]
	internal static byte[] changeLdcToLdcW(byte[] P_0, ExceptionTable P_1, CodeAttribute P_2, CodeAttribute.LdcEntry P_3)
	{
		Pointers pointers = new Pointers(0, 0, 0, 0, P_1, P_2);
		List list = makeJumpList(P_0, P_0.Length, pointers);
		while (P_3 != null)
		{
			addLdcW(P_3, list);
			P_3 = P_3.next;
		}
		return insertGap2w(P_0, 0, 0, false, list, pointers);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 104, 103, 108, 104 })]
	protected internal CodeIterator(CodeAttribute ca)
	{
		codeAttr = ca;
		bytecode = ca.getCode();
		begin();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 162, 217, 2, 97, 208, 104, 100, 105, 104,
		105, 137, 105, 103, 104, 105, 139, 104, 105, 107,
		223, 19, 34, 193
	})]
	internal static int nextOpcode(byte[] P_0, int P_1)
	{
		//Discarded unreachable code: IL_00b4
		int num;
		try
		{
			num = P_0[P_1];
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0016;
		}
		try
		{
			int num2 = opcodeLength[num];
			if (num2 > 0)
			{
				return P_1 + num2;
			}
			if (num == 196)
			{
				if (P_0[P_1 + 1] == -124)
				{
					return P_1 + 6;
				}
				return P_1 + 4;
			}
			int num3 = (P_1 & -4) + 8;
			switch (num)
			{
			case 171:
			{
				int num4 = ByteArray.read32bit(P_0, num3);
				return num3 + num4 * 8 + 4;
			}
			case 170:
			{
				int num4 = ByteArray.read32bit(P_0, num3);
				int num5 = ByteArray.read32bit(P_0, num3 + 4);
				return num3 + (num5 - num4 + 1) * 4 + 8;
			}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_00d1;
		}
		goto IL_00d8;
		IL_0016:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode("invalid opcode address");
		IL_00d8:
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(num);
		IL_00d1:
		_ = null;
		goto IL_00d8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(565)]
	public virtual int insertExGap(int length)
	{
		return insertGapAt(currentPos, length, exclusive: true).position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 125, 108 })]
	public virtual void begin()
	{
		int num = 0;
		int num2 = num;
		mark2 = num;
		num = num2;
		int num3 = num;
		mark = num;
		currentPos = num3;
		endPos = getCodeLength();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 200, 102, 108, 108, 98, 107, 103, 105, 105,
		105, 108, 112, 116, 104, 100, 130, 106, 110, 226,
		69, 133, 102
	})]
	private int skipSuperConstructor0(int P_0)
	{
		begin();
		ConstPool constPool = codeAttr.getConstPool();
		string declaringClass = codeAttr.getDeclaringClass();
		int num = 0;
		while (hasNext())
		{
			int num2 = next();
			switch (byteAt(num2))
			{
			default:
				continue;
			case 187:
				num++;
				continue;
			case 183:
				break;
			}
			int index = ByteArray.readU16bit(bytecode, num2 + 1);
			if (!java.lang.String.instancehelper_equals(constPool.getMethodrefName(index), "<init>"))
			{
				continue;
			}
			num += -1;
			if (num < 0)
			{
				if (P_0 < 0)
				{
					return num2;
				}
				string methodrefClassName = constPool.getMethodrefClassName(index);
				if (java.lang.String.instancehelper_equals(methodrefClassName, declaringClass) != P_0 > 0)
				{
					break;
				}
				return num2;
			}
		}
		begin();
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 18, 66, 99, 100, 162, 144, 98, 102, 47,
		166
	})]
	private int insert0(int P_0, byte[] P_1, bool P_2)
	{
		int num = P_1.Length;
		if (num <= 0)
		{
			return P_0;
		}
		P_0 = insertGapAt(P_0, num, P_2).position;
		int num2 = P_0;
		for (int i = 0; i < num; i++)
		{
			byte[] array = bytecode;
			int num3 = num2;
			num2++;
			array[num3] = P_1[i];
		}
		return P_0;
	}

	public virtual CodeAttribute get()
	{
		return codeAttr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		158, 111, 99, 100, 130, 125, 106, 108, 108, 108,
		108, 104, 109, 142, 99, 134, 105, 104
	})]
	private byte[] insertGapCore0w(byte[] P_0, int P_1, int P_2, bool P_3, ExceptionTable P_4, CodeAttribute P_5, Gap P_6)
	{
		if (P_2 <= 0)
		{
			return P_0;
		}
		Pointers pointers = new Pointers(currentPos, mark, mark2, P_1, P_4, P_5);
		List list = makeJumpList(P_0, P_0.Length, pointers);
		byte[] result = insertGap2w(P_0, P_1, P_2, P_3, list, pointers);
		currentPos = pointers.cursor;
		mark = pointers.mark;
		mark2 = pointers.mark2;
		int num = pointers.mark0;
		if (num == currentPos && !P_3)
		{
			currentPos += P_2;
		}
		if (P_3)
		{
			num -= P_2;
		}
		P_6.position = num;
		P_6.length = P_2;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 158, 187, 162, 100, 162, 156, 129, 191, 2, 97 })]
	internal static byte[] insertGapCore0(byte[] P_0, int P_1, int P_2, bool P_3, ExceptionTable P_4, CodeAttribute P_5)
	{
		//Discarded unreachable code: IL_0017, IL_0039
		if (P_2 <= 0)
		{
			return P_0;
		}
		try
		{
			return insertGapCore1(P_0, P_1, P_2, P_3, P_4, P_5);
		}
		catch (AlignmentException)
		{
		}
		_ = null;
		try
		{
			return insertGapCore1(P_0, P_1, (P_2 + 3) & -4, P_3, P_4, P_5);
		}
		catch (AlignmentException)
		{
		}
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("fatal error?");
	}

	protected internal virtual void updateCursors(int pos, int length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 108, 103, 99, 169, 102, 38, 166, 104, 36,
		166, 108, 103, 108
	})]
	public virtual void appendGap(int gapLength)
	{
		byte[] array = bytecode;
		int num = array.Length;
		byte[] array2 = new byte[num + gapLength];
		for (int i = 0; i < num; i++)
		{
			array2[i] = array[i];
		}
		for (int i = num; i < num + gapLength; i++)
		{
			array2[i] = 0;
		}
		codeAttr.setCode(array2);
		bytecode = array2;
		endPos = getCodeLength();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode", "javassist.bytecode.CodeIterator$AlignmentException" })]
	[LineNumberTable(new byte[]
	{
		158, 181, 98, 99, 105, 107, 106, 103, 107, 99,
		137, 147, 100, 138, 103, 140, 100, 138, 115, 100,
		138, 115, 100, 138
	})]
	private static byte[] insertGapCore1(byte[] P_0, int P_1, int P_2, bool P_3, ExceptionTable P_4, CodeAttribute P_5)
	{
		int num = P_0.Length;
		byte[] array = new byte[num + P_2];
		insertGap2(P_0, P_1, P_2, num, array, P_3);
		P_4.shiftPc(P_1, P_2, P_3);
		((LineNumberAttribute)P_5.getAttribute("LineNumberTable"))?.shiftPc(P_1, P_2, P_3);
		((LocalVariableAttribute)P_5.getAttribute("LocalVariableTable"))?.shiftPc(P_1, P_2, P_3);
		((LocalVariableAttribute)P_5.getAttribute("LocalVariableTypeTable"))?.shiftPc(P_1, P_2, P_3);
		((StackMapTable)P_5.getAttribute("StackMapTable"))?.shiftPc(P_1, P_2, P_3);
		((StackMap)P_5.getAttribute("StackMap"))?.shiftPc(P_1, P_2, P_3);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode", "javassist.bytecode.CodeIterator$AlignmentException" })]
	[LineNumberTable(new byte[]
	{
		158, 172, 99, 98, 98, 103, 100, 100, 100, 171,
		105, 132, 191, 1, 111, 109, 103, 108, 100, 101,
		144, 107, 109, 107, 106, 100, 101, 107, 105, 139,
		232, 71, 141, 147, 106, 108, 108, 108, 108, 101,
		103, 110, 102, 147, 106, 100, 102, 98, 101, 107,
		105, 139, 232, 72, 141, 147, 106, 108, 108, 100,
		102, 105, 102, 107, 102, 40, 167, 108, 100, 102,
		98, 130, 101, 241, 159, 164, 232, 160, 94
	})]
	private static void insertGap2(byte[] P_0, int P_1, int P_2, int P_3, byte[] P_4, bool P_5)
	{
		int num = 0;
		int num2 = 0;
		int num5;
		for (; num < P_3; num = num5)
		{
			int num3;
			if (num == P_1)
			{
				num3 = num2 + P_2;
				while (num2 < num3)
				{
					int num4 = num2;
					num2++;
					P_4[num4] = 0;
				}
			}
			num5 = nextOpcode(P_0, num);
			num3 = P_0[num];
			if ((153 <= num3 && num3 <= 168) || num3 == 198 || num3 == 199)
			{
				int num6 = (P_0[num + 1] << 8) | P_0[num + 2];
				num6 = newOffset(num, num6, P_1, P_2, P_5);
				P_4[num2] = P_0[num];
				ByteArray.write16bit(num6, P_4, num2 + 1);
				num2 += 3;
				continue;
			}
			switch (num3)
			{
			case 200:
			case 201:
			{
				int num6 = ByteArray.read32bit(P_0, num + 1);
				num6 = newOffset(num, num6, P_1, P_2, P_5);
				int num8 = num2;
				num2++;
				P_4[num8] = P_0[num];
				ByteArray.write32bit(num6, P_4, num2);
				num2 += 4;
				continue;
			}
			case 170:
			{
				if (num != num2 && ((uint)P_2 & 3u) != 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AlignmentException();
				}
				int num6 = (num & -4) + 4;
				num2 = copyGapBytes(P_4, num2, P_0, num, num6);
				int value = newOffset(num, ByteArray.read32bit(P_0, num6), P_1, P_2, P_5);
				ByteArray.write32bit(value, P_4, num2);
				int num7 = ByteArray.read32bit(P_0, num6 + 4);
				ByteArray.write32bit(num7, P_4, num2 + 4);
				int i = ByteArray.read32bit(P_0, num6 + 8);
				ByteArray.write32bit(i, P_4, num2 + 8);
				num2 += 12;
				int value2 = num6 + 12;
				for (num6 = value2 + (i - num7 + 1) * 4; value2 < num6; value2 += 4)
				{
					int value3 = newOffset(num, ByteArray.read32bit(P_0, value2), P_1, P_2, P_5);
					ByteArray.write32bit(value3, P_4, num2);
					num2 += 4;
				}
				continue;
			}
			case 171:
			{
				if (num != num2 && ((uint)P_2 & 3u) != 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AlignmentException();
				}
				int num6 = (num & -4) + 4;
				num2 = copyGapBytes(P_4, num2, P_0, num, num6);
				int value = newOffset(num, ByteArray.read32bit(P_0, num6), P_1, P_2, P_5);
				ByteArray.write32bit(value, P_4, num2);
				int num7 = ByteArray.read32bit(P_0, num6 + 4);
				ByteArray.write32bit(num7, P_4, num2 + 4);
				num2 += 8;
				int i = num6 + 8;
				for (num6 = i + num7 * 8; i < num6; i += 8)
				{
					ByteArray.copy32bit(P_0, i, P_4, num2);
					int value2 = newOffset(num, ByteArray.read32bit(P_0, i + 4), P_1, P_2, P_5);
					ByteArray.write32bit(value2, P_4, num2 + 4);
					num2 += 8;
				}
				continue;
			}
			}
			while (num < num5)
			{
				int num9 = num2;
				num2++;
				int num10 = num;
				num++;
				P_4[num9] = P_0[num10];
			}
		}
	}

	private static int newOffset(int P_0, int P_1, int P_2, int P_3, bool P_4)
	{
		int num = P_0 + P_1;
		if (P_0 < P_2)
		{
			if (P_2 < num || (P_4 && P_2 == num))
			{
				P_1 += P_3;
			}
		}
		else if (P_0 == P_2)
		{
			if (num < P_2)
			{
				P_1 -= P_3;
			}
		}
		else if (num < P_2 || (!P_4 && P_2 == num))
		{
			P_1 -= P_3;
		}
		return P_1;
	}

	[LineNumberTable(new byte[] { 163, 123, 157, 144, 144, 144, 208 })]
	private static int copyGapBytes(byte[] P_0, int P_1, byte[] P_2, int P_3, int P_4)
	{
		switch (P_4 - P_3)
		{
		case 4:
		{
			int num = P_1;
			P_1++;
			int num2 = P_3;
			P_3++;
			P_0[num] = P_2[num2];
			goto case 3;
		}
		case 3:
		{
			int num3 = P_1;
			P_1++;
			int num4 = P_3;
			P_3++;
			P_0[num3] = P_2[num4];
			goto case 2;
		}
		case 2:
		{
			int num5 = P_1;
			P_1++;
			int num6 = P_3;
			P_3++;
			P_0[num5] = P_2[num6];
			goto case 1;
		}
		case 1:
		{
			int num7 = P_1;
			P_1++;
			int num8 = P_3;
			P_3++;
			P_0[num7] = P_2[num8];
			break;
		}
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("([BILjavassist/bytecode/CodeIterator$Pointers;)Ljava/util/List<Ljavassist/bytecode/CodeIterator$Branch;>;")]
	[LineNumberTable(new byte[]
	{
		164, 76, 134, 105, 104, 132, 191, 1, 143, 112,
		140, 138, 105, 101, 144, 107, 111, 101, 107, 104,
		106, 108, 108, 103, 105, 105, 105, 109, 6, 232,
		69, 118, 101, 107, 104, 106, 108, 102, 105, 105,
		105, 109, 111, 230, 61, 232, 70, 244, 15, 231,
		117
	})]
	private static List makeJumpList(byte[] P_0, int P_1, Pointers P_2)
	{
		ArrayList arrayList = new ArrayList();
		int num2;
		for (int num = 0; num < P_1; num = num2)
		{
			num2 = nextOpcode(P_0, num);
			int num3 = P_0[num];
			int num4;
			if (153 > num3 || num3 > 168)
			{
				switch (num3)
				{
				case 198:
				case 199:
					break;
				case 200:
				case 201:
					num4 = ByteArray.read32bit(P_0, num + 1);
					((List)arrayList).add((object)new Jump32(num, num4));
					continue;
				case 170:
				{
					num4 = (num & -4) + 4;
					int num5 = ByteArray.read32bit(P_0, num4);
					int num6 = ByteArray.read32bit(P_0, num4 + 4);
					int num7 = ByteArray.read32bit(P_0, num4 + 8);
					int num8 = num4 + 12;
					int num9 = num7 - num6 + 1;
					int[] array3 = new int[num9];
					for (int j = 0; j < num9; j++)
					{
						array3[j] = ByteArray.read32bit(P_0, num8);
						num8 += 4;
					}
					((List)arrayList).add((object)new Table(num, num5, num6, num7, array3, P_2));
					continue;
				}
				case 171:
				{
					num4 = (num & -4) + 4;
					int num5 = ByteArray.read32bit(P_0, num4);
					int num6 = ByteArray.read32bit(P_0, num4 + 4);
					int num7 = num4 + 8;
					int[] array = new int[num6];
					int[] array2 = new int[num6];
					for (int i = 0; i < num6; i++)
					{
						array[i] = ByteArray.read32bit(P_0, num7);
						array2[i] = ByteArray.read32bit(P_0, num7 + 4);
						num7 += 8;
					}
					((List)arrayList).add((object)new Lookup(num, num5, array, array2, P_2));
					continue;
				}
				default:
					continue;
				}
			}
			num4 = (P_0[num + 1] << 8) | P_0[num + 2];
			Branch16 e = ((num3 != 167 && num3 != 168) ? ((Branch16)new If16(num, num4)) : ((Branch16)new Jump16(num, num4)));
			((List)arrayList).add((object)e);
		}
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/CodeAttribute$LdcEntry;Ljava/util/List<Ljavassist/bytecode/CodeIterator$Branch;>;)V")]
	[LineNumberTable(new byte[]
	{
		163, 238, 103, 109, 103, 102, 116, 106, 225, 61,
		230, 70, 104
	})]
	private static void addLdcW(CodeAttribute.LdcEntry P_0, List P_1)
	{
		int where = P_0.where;
		LdcW ldcW = new LdcW(where, P_0.index);
		int num = P_1.size();
		for (int i = 0; i < num; i++)
		{
			if (where < ((Branch)P_1.get(i)).orgPos)
			{
				P_1.add(i, ldcW);
				return;
			}
		}
		P_1.add(ldcW);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("([BIIZLjava/util/List<Ljavassist/bytecode/CodeIterator$Branch;>;Ljavassist/bytecode/CodeIterator$Pointers;)[B")]
	[LineNumberTable(new byte[]
	{
		158, 105, 130, 100, 106, 124, 171, 130, 102, 98,
		127, 4, 105, 98, 105, 105, 108, 127, 1, 142,
		170, 127, 4, 105, 101, 98, 105, 108, 127, 1,
		142, 101, 134
	})]
	private static byte[] insertGap2w(byte[] P_0, int P_1, int P_2, bool P_3, List P_4, Pointers P_5)
	{
		if (P_2 > 0)
		{
			P_5.shiftPc(P_1, P_2, P_3);
			Iterator iterator = P_4.iterator();
			while (iterator.hasNext())
			{
				Branch branch = (Branch)iterator.next();
				branch.shift(P_1, P_2, P_3);
			}
		}
		int num = 1;
		while (true)
		{
			Iterator iterator2;
			if (num != 0)
			{
				num = 0;
				iterator2 = P_4.iterator();
				while (iterator2.hasNext())
				{
					Branch branch2 = (Branch)iterator2.next();
					if (branch2.expanded())
					{
						num = 1;
						int pos = branch2.pos;
						int num2 = branch2.deltaSize();
						P_5.shiftPc(pos, num2, false);
						Iterator iterator3 = P_4.iterator();
						while (iterator3.hasNext())
						{
							Branch branch3 = (Branch)iterator3.next();
							branch3.shift(pos, num2, false);
						}
					}
				}
				continue;
			}
			iterator2 = P_4.iterator();
			while (iterator2.hasNext())
			{
				Branch branch2 = (Branch)iterator2.next();
				int pos = branch2.gapChanged();
				if (pos > 0)
				{
					num = 1;
					int num2 = branch2.pos;
					P_5.shiftPc(num2, pos, false);
					Iterator iterator3 = P_4.iterator();
					while (iterator3.hasNext())
					{
						Branch branch3 = (Branch)iterator3.next();
						branch3.shift(num2, pos, false);
					}
				}
			}
			if (num == 0)
			{
				break;
			}
		}
		byte[] result = makeExapndedCode(P_0, P_4, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("([BLjava/util/List<Ljavassist/bytecode/CodeIterator$Branch;>;II)[B")]
	[LineNumberTable(new byte[]
	{
		164, 138, 103, 101, 123, 139, 104, 105, 164, 100,
		110, 171, 99, 164, 105, 101, 102, 102, 174, 102,
		151, 112, 103, 111, 107, 111, 171, 99, 132, 165
	})]
	private static byte[] makeExapndedCode(byte[] P_0, List P_1, int P_2, int P_3)
	{
		int num = P_1.size();
		int num2 = (int)((nint)P_0.LongLength + P_3);
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Branch branch = (Branch)iterator.next();
			num2 += branch.deltaSize();
		}
		byte[] array = new byte[num2];
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = P_0.Length;
		Branch branch2;
		int num7;
		if (0 < num)
		{
			branch2 = (Branch)P_1.get(0);
			num7 = branch2.orgPos;
		}
		else
		{
			branch2 = null;
			num7 = num6;
		}
		while (num3 < num6)
		{
			int num8;
			if (num3 == P_2)
			{
				num8 = num4 + P_3;
				while (num4 < num8)
				{
					int num9 = num4;
					num4++;
					array[num9] = 0;
				}
			}
			if (num3 != num7)
			{
				int num10 = num4;
				num4++;
				int num11 = num3;
				num3++;
				array[num10] = P_0[num11];
				continue;
			}
			num8 = branch2.write(num3, P_0, num4, array);
			num3 += num8;
			num4 += num8 + branch2.deltaSize();
			num5++;
			if (num5 < num)
			{
				branch2 = (Branch)P_1.get(num5);
				num7 = branch2.orgPos;
			}
			else
			{
				branch2 = null;
				num7 = num6;
			}
		}
		return array;
	}

	[LineNumberTable(157)]
	public virtual int signedByteAt(int index)
	{
		return bytecode[index];
	}

	[LineNumberTable(new byte[] { 160, 93, 99, 102, 48, 134 })]
	public virtual void write(byte[] code, int index)
	{
		int num = code.Length;
		for (int i = 0; i < num; i++)
		{
			byte[] array = bytecode;
			int num2 = index;
			index++;
			array[num2] = code[i];
		}
	}

	public virtual int lookAhead()
	{
		return currentPos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(364)]
	public virtual int insert(byte[] code)
	{
		int result = insert0(currentPos, code, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 19, 106 })]
	public virtual void insert(int pos, byte[] code)
	{
		insert0(pos, code, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 92, 106 })]
	public virtual void insertEx(int pos, byte[] code)
	{
		insert0(pos, code, true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(486)]
	public virtual int insertExAt(int pos, byte[] code)
	{
		int result = insert0(pos, code, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(526)]
	public virtual int insertGap(int length)
	{
		return insertGapAt(currentPos, length, exclusive: false).position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(546)]
	public virtual int insertGap(int pos, int length)
	{
		return insertGapAt(pos, length, exclusive: false).length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(585)]
	public virtual int insertExGap(int pos, int length)
	{
		return insertGapAt(pos, length, exclusive: true).length;
	}

	[LineNumberTable(765)]
	static CodeIterator()
	{
		opcodeLength = new int[202]
		{
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 2, 3, 2, 3,
			3, 2, 2, 2, 2, 2, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 2, 2, 2, 2, 2, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 3, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 2,
			0, 0, 1, 1, 1, 1, 1, 1, 3, 3,
			3, 3, 3, 3, 3, 5, 5, 3, 2, 3,
			1, 1, 3, 3, 1, 1, 0, 4, 3, 3,
			5, 5
		};
	}
}
