using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode.stackmap;

public class BasicBlock : java.lang.Object
{
	public class Catch : java.lang.Object
	{
		public Catch next;

		public BasicBlock body;

		public int typeIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 22, 104, 103, 103, 103 })]
		internal Catch(BasicBlock P_0, int P_1, Catch P_2)
		{
			body = P_0;
			typeIndex = P_1;
			next = P_2;
		}
	}

	[Serializable]
	internal class JsrBytecode : BadBytecode
	{
		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(43)]
		internal JsrBytecode()
			: base("JSR")
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected JsrBytecode(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	public class Maker : java.lang.Object
	{
		[LineNumberTable(154)]
		protected internal virtual BasicBlock[] makeArray(int size)
		{
			return new BasicBlock[size];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 160, 69, 108, 104, 105 })]
		public virtual BasicBlock[] make(CodeIterator ci, int begin, int end, ExceptionTable et)
		{
			Map map = makeMarks(ci, begin, end, et);
			BasicBlock[] array = makeBlocks(map);
			addCatchers(array, et);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[IKVM.Attributes.Signature("(Ljavassist/bytecode/CodeIterator;IILjavassist/bytecode/ExceptionTable;)Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;")]
		[LineNumberTable(new byte[]
		{
			160, 115, 102, 103, 102, 107, 103, 100, 133, 104,
			159, 1, 115, 108, 126, 101, 118, 159, 6, 116,
			133, 116, 133, 108, 133, 104, 108, 108, 105, 108,
			122, 103, 105, 99, 102, 127, 2, 136, 112, 133,
			104, 108, 108, 122, 104, 107, 99, 102, 127, 2,
			136, 112, 135, 120, 113, 104, 118, 104, 118, 120,
			108, 133, 100, 104, 104, 114, 210
		})]
		private Map makeMarks(CodeIterator P_0, int P_1, int P_2, ExceptionTable P_3)
		{
			P_0.begin();
			P_0.move(P_1);
			HashMap hashMap = new HashMap();
			while (P_0.hasNext())
			{
				int num = P_0.next();
				if (num >= P_2)
				{
					break;
				}
				int num2 = P_0.byteAt(num);
				if ((153 <= num2 && num2 <= 166) || num2 == 198 || num2 == 199)
				{
					Mark mark = makeMark(hashMap, num + P_0.s16bitAt(num + 1));
					Mark mark2 = makeMark(hashMap, num + 3);
					makeMark(hashMap, num, makeArray(mark.block, mark2.block), 3, false);
					continue;
				}
				if (167 <= num2 && num2 <= 171)
				{
					switch (num2)
					{
					case 167:
						makeGoto(hashMap, num, num + P_0.s16bitAt(num + 1), 3);
						break;
					case 168:
						makeJsr(hashMap, num, num + P_0.s16bitAt(num + 1), 3);
						break;
					case 169:
						makeMark(hashMap, num, null, 2, true);
						break;
					case 170:
					{
						int num3 = (num & -4) + 4;
						int num4 = P_0.s32bitAt(num3 + 4);
						int num8 = P_0.s32bitAt(num3 + 8);
						int i = num8 - num4 + 1;
						BasicBlock[] array2 = makeArray(i + 1);
						array2[0] = makeMark(hashMap, num + P_0.s32bitAt(num3)).block;
						int num6 = num3 + 12;
						int num9 = num6 + i * 4;
						int num10 = 1;
						for (; num6 < num9; num6 += 4)
						{
							int num11 = num10;
							num10++;
							array2[num11] = makeMark(hashMap, num + P_0.s32bitAt(num6)).block;
						}
						makeMark(hashMap, num, array2, num9 - num, true);
						break;
					}
					case 171:
					{
						int num3 = (num & -4) + 4;
						int num4 = P_0.s32bitAt(num3 + 4);
						BasicBlock[] array = makeArray(num4 + 1);
						array[0] = makeMark(hashMap, num + P_0.s32bitAt(num3)).block;
						int i = num3 + 8 + 4;
						int num5 = i + num4 * 8 - 4;
						int num6 = 1;
						for (; i < num5; i += 8)
						{
							int num7 = num6;
							num6++;
							array[num7] = makeMark(hashMap, num + P_0.s32bitAt(i)).block;
						}
						makeMark(hashMap, num, array, num5 - num, true);
						break;
					}
					}
					continue;
				}
				if (172 > num2 || num2 > 177)
				{
					switch (num2)
					{
					default:
						continue;
					case 191:
						break;
					case 200:
						makeGoto(hashMap, num, num + P_0.s32bitAt(num + 1), 5);
						continue;
					case 201:
						makeJsr(hashMap, num, num + P_0.s32bitAt(num + 1), 5);
						continue;
					case 196:
						if (P_0.byteAt(num + 1) == 169)
						{
							makeMark(hashMap, num, null, 4, true);
						}
						continue;
					}
				}
				makeMark(hashMap, num, null, 1, true);
			}
			if (P_3 != null)
			{
				int num = P_3.size();
				while (true)
				{
					num += -1;
					if (num < 0)
					{
						break;
					}
					makeMark0(hashMap, P_3.startPc(num), true, false);
					makeMark(hashMap, P_3.handlerPc(num));
				}
			}
			return hashMap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;)[Ljavassist/bytecode/stackmap/BasicBlock;")]
		[LineNumberTable(new byte[]
		{
			160, 214, 124, 102, 102, 130, 121, 143, 136, 104,
			104, 105, 105, 135, 137, 116, 168, 124, 109, 210,
			104, 116, 111, 211, 150, 116, 104, 180, 103, 206,
			105, 131, 133
		})]
		private BasicBlock[] makeBlocks(Map P_0)
		{
			Mark[] array = (Mark[])P_0.values().toArray(new Mark[P_0.size()]);
			Arrays.sort(array);
			ArrayList arrayList = new ArrayList();
			int num = 0;
			BasicBlock basicBlock;
			if ((nint)array.LongLength > 0 && array[0].position == 0 && array[0].block != null)
			{
				int num2 = num;
				num++;
				basicBlock = getBBlock(array[num2]);
			}
			else
			{
				basicBlock = makeBlock(0);
			}
			((List)arrayList).add((object)basicBlock);
			while (num < (nint)array.LongLength)
			{
				int num3 = num;
				num++;
				Mark mark = array[num3];
				BasicBlock bBlock = getBBlock(mark);
				if (bBlock == null)
				{
					if (basicBlock.length > 0)
					{
						basicBlock = makeBlock(basicBlock.position + basicBlock.length);
						((List)arrayList).add((object)basicBlock);
					}
					basicBlock.length = mark.position + mark.size - basicBlock.position;
					basicBlock.exit = mark.jump;
					basicBlock.stop = mark.alwaysJmp;
					continue;
				}
				if (basicBlock.length == 0)
				{
					basicBlock.length = mark.position - basicBlock.position;
					bBlock.incoming++;
					basicBlock.exit = makeArray(bBlock);
				}
				else if (basicBlock.position + basicBlock.length < mark.position)
				{
					basicBlock = makeBlock(basicBlock.position + basicBlock.length);
					((List)arrayList).add((object)basicBlock);
					basicBlock.length = mark.position - basicBlock.position;
					basicBlock.stop = true;
					basicBlock.exit = makeArray(bBlock);
				}
				((List)arrayList).add((object)bBlock);
				basicBlock = bBlock;
			}
			return (BasicBlock[])((List)arrayList).toArray((object[])makeArray(((List)arrayList).size()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			161, 27, 99, 129, 103, 107, 110, 104, 104, 105,
			110, 105, 102, 105, 106, 118, 238, 59, 232, 72,
			101
		})]
		private void addCatchers(BasicBlock[] P_0, ExceptionTable P_1)
		{
			if (P_1 == null)
			{
				return;
			}
			int num = P_1.size();
			while (true)
			{
				num += -1;
				if (num < 0)
				{
					break;
				}
				BasicBlock basicBlock = find(P_0, P_1.handlerPc(num));
				int num2 = P_1.startPc(num);
				int num3 = P_1.endPc(num);
				int num4 = P_1.catchType(num);
				basicBlock.incoming--;
				for (int i = 0; i < (nint)P_0.LongLength; i++)
				{
					BasicBlock basicBlock2 = P_0[i];
					int position = basicBlock2.position;
					if (num2 <= position && position < num3)
					{
						basicBlock2.toCatch = new Catch(basicBlock, num4, basicBlock2.toCatch);
						basicBlock.incoming++;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;IZZ)Ljavassist/bytecode/stackmap/BasicBlock$Mark;")]
		[LineNumberTable(new byte[]
		{
			159, 91, 165, 103, 109, 99, 103, 169, 99, 104,
			141, 99, 179
		})]
		private Mark makeMark0(Map P_0, int P_1, bool P_2, bool P_3)
		{
			Integer key = Integer.valueOf(P_1);
			Mark mark = (Mark)P_0.get(key);
			if (mark == null)
			{
				mark = new Mark(P_1);
				P_0.put(key, mark);
			}
			if (P_2)
			{
				if (mark.block == null)
				{
					mark.block = makeBlock(P_1);
				}
				if (P_3)
				{
					mark.block.incoming++;
				}
			}
			return mark;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(150)]
		protected internal virtual BasicBlock makeBlock(int pos)
		{
			BasicBlock result = new BasicBlock(pos);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;I)Ljavassist/bytecode/stackmap/BasicBlock$Mark;")]
		[LineNumberTable(192)]
		private Mark makeMark(Map P_0, int P_1)
		{
			Mark result = makeMark0(P_0, P_1, true, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 114, 104, 100, 100 })]
		private BasicBlock[] makeArray(BasicBlock P_0, BasicBlock P_1)
		{
			BasicBlock[] array = makeArray(2);
			array[0] = P_0;
			array[1] = P_1;
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;I[Ljavassist/bytecode/stackmap/BasicBlock;IZ)Ljavassist/bytecode/stackmap/BasicBlock$Mark;")]
		[LineNumberTable(new byte[] { 159, 92, 67, 107, 106 })]
		private Mark makeMark(Map P_0, int P_1, BasicBlock[] P_2, int P_3, bool P_4)
		{
			Mark mark = makeMark0(P_0, P_1, false, false);
			mark.setJump(P_2, P_3, P_4);
			return mark;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;III)V")]
		[LineNumberTable(new byte[] { 160, 194, 105, 109, 109 })]
		private void makeGoto(Map P_0, int P_1, int P_2, int P_3)
		{
			Mark mark = makeMark(P_0, P_2);
			BasicBlock[] array = makeArray(mark.block);
			makeMark(P_0, P_1, array, P_3, true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;III)V")]
		[LineNumberTable(324)]
		protected internal virtual void makeJsr(Map marks, int pos, int target, int size)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new JsrBytecode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 108, 104, 100 })]
		private BasicBlock[] makeArray(BasicBlock P_0)
		{
			BasicBlock[] array = makeArray(1);
			array[0] = P_0;
			return array;
		}

		[LineNumberTable(new byte[] { 161, 14, 103, 108, 108, 108, 172 })]
		private static BasicBlock getBBlock(Mark P_0)
		{
			BasicBlock block = P_0.block;
			if (block != null && P_0.size > 0)
			{
				block.exit = P_0.jump;
				block.length = P_0.size;
				block.stop = P_0.alwaysJmp;
			}
			return block;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(145)]
		public Maker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 121, 103, 99, 130, 103 })]
		public virtual BasicBlock[] make(MethodInfo minfo)
		{
			CodeAttribute codeAttribute = minfo.getCodeAttribute();
			if (codeAttribute == null)
			{
				return null;
			}
			CodeIterator codeIterator = codeAttribute.iterator();
			BasicBlock[] result = make(codeIterator, 0, codeIterator.getCodeLength(), codeAttribute.getExceptionTable());
			_ = null;
			return result;
		}
	}

	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/lang/Comparable<Ljavassist/bytecode/stackmap/BasicBlock$Mark;>;")]
	[Implements(new string[] { "java.lang.Comparable" })]
	internal class Mark : java.lang.Object, Comparable
	{
		internal int position;

		internal BasicBlock block;

		internal BasicBlock[] jump;

		internal bool alwaysJmp;

		internal int size;

		internal Catch catcher;

		internal virtual void setJump(BasicBlock[] P_0, int P_1, bool P_2)
		{
			jump = P_0;
			size = P_1;
			alwaysJmp = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 72, 104, 103, 103, 103, 103, 103, 103 })]
		internal Mark(int P_0)
		{
			position = P_0;
			block = null;
			jump = null;
			alwaysJmp = false;
			size = 0;
			catcher = null;
		}

		[LineNumberTable(new byte[] { 83, 100, 98 })]
		public virtual int compareTo(Mark P_0)
		{
			if (null == P_0)
			{
				return -1;
			}
			return position - P_0.position;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(114)]
		public virtual int compareTo(object P_0)
		{
			int result = compareTo((Mark)P_0);
			_ = null;
			return result;
		}

		int IComparable.Comparable_003A_003AcompareTo(object P_0)
		{
			return compareTo(P_0);
		}
	}

	protected internal int position;

	protected internal int length;

	protected internal int incoming;

	protected internal BasicBlock[] exit;

	protected internal bool stop;

	protected internal Catch toCatch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 103, 103, 103 })]
	protected internal BasicBlock(int pos)
	{
		position = pos;
		length = 0;
		incoming = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 11, 111, 121, 2, 198 })]
	public static BasicBlock find(BasicBlock[] blocks, int pos)
	{
		int num = blocks.Length;
		for (int i = 0; i < num; i++)
		{
			BasicBlock basicBlock = blocks[i];
			if (basicBlock.position <= pos && pos < basicBlock.position + basicBlock.length)
			{
				return basicBlock;
			}
		}
		string msg = new StringBuilder().append("no basic block at ").append(pos).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		42, 127, 7, 127, 0, 102, 104, 116, 52, 166,
		108, 104, 100, 127, 11, 112, 171, 105
	})]
	protected internal virtual void toString2(StringBuilder sbuf)
	{
		sbuf.append("pos=").append(position).append(", len=")
			.append(length)
			.append(", in=")
			.append(incoming)
			.append(", exit{");
		if (exit != null)
		{
			BasicBlock[] array = exit;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				BasicBlock basicBlock = array[i];
				sbuf.append(basicBlock.position).append(',');
			}
		}
		sbuf.append("}, {");
		for (Catch next = toCatch; next != null; next = next.next)
		{
			sbuf.append('(').append(next.body.position).append(", ")
				.append(next.typeIndex)
				.append("), ");
		}
		sbuf.append('}');
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 102, 108, 105, 119, 105, 103, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string name = java.lang.Object.instancehelper_getClass(this).getName();
		int num = java.lang.String.instancehelper_lastIndexOf(name, 46);
		stringBuilder.append((num >= 0) ? java.lang.String.instancehelper_substring(name, num + 1) : name);
		stringBuilder.append('[');
		toString2(stringBuilder);
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}
}
