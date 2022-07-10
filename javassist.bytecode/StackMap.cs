using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class StackMap : AttributeInfo
{
	internal class Copier : Walker
	{
		internal byte[] dest;

		internal ConstPool srcCp;

		internal ConstPool destCp;

		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		internal Map classnames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljavassist/bytecode/StackMap;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 160, 114, 105, 108, 114, 103, 103 })]
		internal Copier(StackMap P_0, ConstPool P_1, Map P_2)
			: base(P_0)
		{
			srcCp = P_0.getConstPool();
			dest = new byte[(nint)info.LongLength];
			destCp = P_1;
			classnames = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 122, 109, 109, 104 })]
		public override void visit()
		{
			int value = ByteArray.readU16bit(info, 0);
			ByteArray.write16bit(value, dest, 0);
			base.visit();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 129, 111 })]
		public override int locals(int P_0, int P_1, int P_2)
		{
			ByteArray.write16bit(P_1, dest, P_0 - 4);
			int result = base.locals(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 80, 99, 111 })]
		public override int typeInfoArray(int P_0, int P_1, int P_2, bool P_3)
		{
			ByteArray.write16bit(P_2, dest, P_0 - 2);
			int result = base.typeInfoArray(P_0, P_1, P_2, P_3);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 159, 79, 163, 105 })]
		public override void typeInfo(int P_0, byte P_1)
		{
			int num = (sbyte)P_1;
			dest[P_0] = (byte)num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 146, 105, 121, 113 })]
		public override void objectVariable(int P_0, int P_1)
		{
			dest[P_0] = 7;
			int value = srcCp.copy(P_1, destCp, classnames);
			ByteArray.write16bit(value, dest, P_0 + 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 153, 105, 113 })]
		public override void uninitialized(int P_0, int P_1)
		{
			dest[P_0] = 8;
			ByteArray.write16bit(P_1, dest, P_0 + 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(272)]
		public virtual StackMap getStackMap()
		{
			StackMap result = new StackMap(destCp, dest);
			_ = null;
			return result;
		}
	}

	internal class InsertLocal : SimpleCopy
	{
		private int varIndex;

		private int varTag;

		private int varData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 237, 105, 103, 103, 104 })]
		internal InsertLocal(StackMap P_0, int P_1, int P_2, int P_3)
			: base(P_0)
		{
			varIndex = P_1;
			varTag = P_2;
			varData = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 7, 105, 116, 105, 148, 116 })]
		private void writeVarTypeInfo()
		{
			if (varTag == 7)
			{
				writer.writeVerifyTypeInfo(7, varData);
			}
			else if (varTag == 8)
			{
				writer.writeVerifyTypeInfo(8, varData);
			}
			else
			{
				writer.writeVerifyTypeInfo(varTag, 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			159, 53, 163, 108, 141, 110, 102, 105, 134, 234,
			60, 230, 71, 105, 134
		})]
		public override int typeInfoArray(int P_0, int P_1, int P_2, bool P_3)
		{
			if (!P_3 || P_2 < varIndex)
			{
				int result = base.typeInfoArray(P_0, P_1, P_2, P_3);
				_ = null;
				return result;
			}
			writer.write16bit(P_2 + 1);
			for (int i = 0; i < P_2; i++)
			{
				if (i == varIndex)
				{
					writeVarTypeInfo();
				}
				P_0 = typeInfoArray2(i, P_0);
			}
			if (P_2 == varIndex)
			{
				writeVarTypeInfo();
			}
			return P_0;
		}
	}

	internal class NewRemover : SimpleCopy
	{
		internal int posOfNew;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 93, 105, 103 })]
		internal NewRemover(StackMap P_0, int P_1)
			: base(P_0)
		{
			posOfNew = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 103, 98, 98, 105, 105, 100, 102, 100, 112,
			106, 132, 100, 130, 228, 52, 233, 79, 110, 105,
			105, 100, 112, 105, 101, 98, 100, 112, 106, 137,
			101, 130, 104, 229, 48, 233, 84
		})]
		private int stackTypeInfoArray(int P_0, int P_1, int P_2)
		{
			int num = P_0;
			int num2 = 0;
			for (int i = 0; i < P_2; i++)
			{
				switch (info[num])
				{
				case 7:
					num += 3;
					break;
				case 8:
				{
					int num3 = ByteArray.readU16bit(info, num + 1);
					if (num3 == posOfNew)
					{
						num2++;
					}
					num += 3;
					break;
				}
				default:
					num++;
					break;
				}
			}
			writer.write16bit(P_2 - num2);
			for (int i = 0; i < P_2; i++)
			{
				int num4 = info[P_0];
				switch (num4)
				{
				case 7:
				{
					int num3 = ByteArray.readU16bit(info, P_0 + 1);
					objectVariable(P_0, num3);
					P_0 += 3;
					break;
				}
				case 8:
				{
					int num3 = ByteArray.readU16bit(info, P_0 + 1);
					if (num3 != posOfNew)
					{
						uninitialized(P_0, num3);
					}
					P_0 += 3;
					break;
				}
				default:
					typeInfo(P_0, (byte)num4);
					P_0++;
					break;
				}
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(469)]
		public override int stack(int P_0, int P_1, int P_2)
		{
			int result = stackTypeInfoArray(P_0, P_1, P_2);
			_ = null;
			return result;
		}
	}

	internal class Printer : Walker
	{
		private PrintWriter writer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 156, 105, 103 })]
		public Printer(StackMap P_0, PrintWriter P_1)
			: base(P_0)
		{
			writer = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 161, 109, 127, 6, 104 })]
		public virtual void print()
		{
			int i = ByteArray.readU16bit(info, 0);
			writer.println(new StringBuilder().append(i).append(" entries").toString());
			visit();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 168, 127, 6 })]
		public override int locals(int P_0, int P_1, int P_2)
		{
			writer.println(new StringBuilder().append("  * offset ").append(P_1).toString());
			int result = base.locals(P_0, P_1, P_2);
			_ = null;
			return result;
		}
	}

	internal class Shifter : Walker
	{
		private int where;

		private int gap;

		private bool exclusive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 43, 99, 105, 103, 103, 103 })]
		public Shifter(StackMap P_0, int P_1, int P_2, bool P_3)
			: base(P_0)
		{
			where = P_1;
			gap = P_2;
			exclusive = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 35, 124, 150 })]
		public override int locals(int P_0, int P_1, int P_2)
		{
			if (exclusive)
			{
				if (where <= P_1)
				{
					goto IL_001c;
				}
			}
			else if (where < P_1)
			{
				goto IL_001c;
			}
			goto IL_0032;
			IL_001c:
			ByteArray.write16bit(P_1 + gap, info, P_0 - 4);
			goto IL_0032;
			IL_0032:
			int result = base.locals(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 43, 105, 120 })]
		public override void uninitialized(int P_0, int P_1)
		{
			if (where <= P_1)
			{
				ByteArray.write16bit(P_1 + gap, info, P_0 + 1);
			}
		}
	}

	internal class SimpleCopy : Walker
	{
		internal Writer writer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 193, 102 })]
		internal virtual byte[] doit()
		{
			visit();
			byte[] result = writer.toByteArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 199, 109, 108, 104 })]
		public override void visit()
		{
			int value = ByteArray.readU16bit(info, 0);
			writer.write16bit(value);
			base.visit();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 188, 105, 107 })]
		internal SimpleCopy(StackMap P_0)
			: base(P_0)
		{
			writer = new Writer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 206, 108 })]
		public override int locals(int P_0, int P_1, int P_2)
		{
			writer.write16bit(P_1);
			int result = base.locals(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 61, 131, 108 })]
		public override int typeInfoArray(int P_0, int P_1, int P_2, bool P_3)
		{
			writer.write16bit(P_2);
			int result = base.typeInfoArray(P_0, P_1, P_2, P_3);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 59, 67, 111 })]
		public override void typeInfo(int P_0, byte P_1)
		{
			int tag = (sbyte)P_1;
			writer.writeVerifyTypeInfo(tag, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 223, 111 })]
		public override void objectVariable(int P_0, int P_1)
		{
			writer.writeVerifyTypeInfo(7, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 228, 111 })]
		public override void uninitialized(int P_0, int P_1)
		{
			writer.writeVerifyTypeInfo(8, P_1);
		}
	}

	internal class SwitchShifter : Walker
	{
		private int where;

		private int gap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 59, 105, 103, 103 })]
		public SwitchShifter(StackMap P_0, int P_1, int P_2)
			: base(P_0)
		{
			where = P_1;
			gap = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 66, 107, 120, 105, 150 })]
		public override int locals(int P_0, int P_1, int P_2)
		{
			if (where == P_0 + P_1)
			{
				ByteArray.write16bit(P_1 - gap, info, P_0 - 4);
			}
			else if (where == P_0)
			{
				ByteArray.write16bit(P_1 + gap, info, P_0 - 4);
			}
			int result = base.locals(P_0, P_1, P_2);
			_ = null;
			return result;
		}
	}

	public class Walker : Object
	{
		internal byte[] info;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(156)]
		public virtual int locals(int pos, int offset, int num)
		{
			int result = typeInfoArray(pos, offset, num, isLocals: true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(164)]
		public virtual int stack(int pos, int offset, int num)
		{
			int result = typeInfoArray(pos, offset, num, isLocals: false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 126, 102, 42, 166 })]
		public virtual int typeInfoArray(int pos, int offset, int num, bool isLocals)
		{
			for (int i = 0; i < num; i++)
			{
				pos = typeInfoArray2(i, pos);
			}
			return pos;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 69, 105, 100, 111, 104, 101, 98, 100, 111,
			104, 101, 130, 104, 165
		})]
		internal virtual int typeInfoArray2(int P_0, int P_1)
		{
			int num = info[P_1];
			switch (num)
			{
			case 7:
			{
				int offset = ByteArray.readU16bit(info, P_1 + 1);
				objectVariable(P_1, offset);
				P_1 += 3;
				break;
			}
			case 8:
			{
				int offset = ByteArray.readU16bit(info, P_1 + 1);
				uninitialized(P_1, offset);
				P_1 += 3;
				break;
			}
			default:
				typeInfo(P_1, (byte)num);
				P_1++;
				break;
			}
			return P_1;
		}

		public virtual void objectVariable(int pos, int clazz)
		{
		}

		public virtual void uninitialized(int pos, int offset)
		{
		}

		public virtual void typeInfo(int pos, byte tag)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 82, 104, 108 })]
		public Walker(StackMap sm)
		{
			info = sm.get();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			90, 109, 98, 102, 109, 112, 109, 110, 237, 59,
			233, 71
		})]
		public virtual void visit()
		{
			int num = ByteArray.readU16bit(info, 0);
			int num2 = 2;
			for (int i = 0; i < num; i++)
			{
				int offset = ByteArray.readU16bit(info, num2);
				int num3 = ByteArray.readU16bit(info, num2 + 2);
				num2 = locals(num2 + 4, offset, num3);
				int num4 = ByteArray.readU16bit(info, num2);
				num2 = stack(num2 + 2, offset, num4);
			}
		}
	}

	public class Writer : Object
	{
		private ByteArrayOutputStream output;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 184, 104, 107 })]
		public Writer()
		{
			output = new ByteArrayOutputStream();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(562)]
		public virtual byte[] toByteArray()
		{
			byte[] result = output.toByteArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 217, 116, 116 })]
		public virtual void write16bit(int value)
		{
			output.write((int)(((uint)value >> 8) & 0xFF));
			output.write(value & 0xFF);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 208, 108, 104, 105 })]
		public virtual void writeVerifyTypeInfo(int tag, int data)
		{
			output.write(tag);
			if (tag == 7 || tag == 8)
			{
				write16bit(data);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(569)]
		public virtual StackMap toStackMap(ConstPool cp)
		{
			StackMap result = new StackMap(cp, output.toByteArray());
			_ = null;
			return result;
		}
	}

	public const string tag = "StackMap";

	public const int TOP = 0;

	public const int INTEGER = 1;

	public const int FLOAT = 2;

	public const int DOUBLE = 3;

	public const int LONG = 4;

	public const int NULL = 5;

	public const int THIS = 6;

	public const int OBJECT = 7;

	public const int UNINIT = 8;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 180, 111, 105 })]
	public virtual void insertLocal(int index, int tag, int classInfo)
	{
		byte[] newinfo = new InsertLocal(this, index, tag, classInfo).doit();
		set(newinfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 8, 107 })]
	internal StackMap(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 149, 110 })]
	public virtual void print(PrintWriter @out)
	{
		new Printer(this, @out).print();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 159, 45, 98, 112 })]
	internal virtual void shiftPc(int P_0, int P_1, bool P_2)
	{
		new Shifter(this, P_0, P_1, P_2).visit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 52, 111 })]
	internal virtual void shiftForSwitch(int P_0, int P_1)
	{
		new SwitchShifter(this, P_0, P_1).visit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 111 })]
	internal StackMap(ConstPool P_0, byte[] P_1)
		: base(P_0, "StackMap", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	public virtual int numOfEntries()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 68, 105, 102 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		Copier copier = new Copier(this, newCp, classnames);
		copier.visit();
		StackMap stackMap = copier.getStackMap();
		_ = null;
		return stackMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 161, 85, 109, 105 })]
	public virtual void removeNew(int where)
	{
		byte[] newinfo = new NewRemover(this, where).doit();
		set(newinfo);
	}
}
