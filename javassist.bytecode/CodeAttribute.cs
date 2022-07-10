using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[Implements(new string[] { "javassist.bytecode.Opcode" })]
public class CodeAttribute : AttributeInfo, Opcode
{
	internal class LdcEntry : java.lang.Object
	{
		internal LdcEntry next;

		internal int where;

		internal int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(446)]
		internal LdcEntry()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 161, 85, 99, 235, 79 })]
		internal static byte[] doit(byte[] P_0, LdcEntry P_1, ExceptionTable P_2, CodeAttribute P_3)
		{
			if (P_1 != null)
			{
				P_0 = CodeIterator.changeLdcToLdcW(P_0, P_2, P_3, P_1);
			}
			return P_0;
		}
	}

	[Serializable]
	public class RuntimeCopyException : RuntimeException
	{
		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 107, 105 })]
		public RuntimeCopyException(string s)
			: base(s)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected RuntimeCopyException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	public const string tag = "Code";

	private int maxStack;

	private int maxLocals;

	private ExceptionTable exceptions;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	private List attributes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(318)]
	public virtual AttributeInfo getAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.lookup(attributes, name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(292)]
	public virtual CodeIterator iterator()
	{
		CodeIterator result = new CodeIterator(this);
		_ = null;
		return result;
	}

	public virtual int getMaxLocals()
	{
		return maxLocals;
	}

	public virtual void setMaxLocals(int value)
	{
		maxLocals = value;
	}

	public virtual int getMaxStack()
	{
		return maxStack;
	}

	public virtual void setMaxStack(int value)
	{
		maxStack = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.CodeAttribute$RuntimeCopyException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 88, 151, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_000a
		try
		{
			return new CodeAttribute(newCp, this, classnames);
		}
		catch (BadBytecode)
		{
		}
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeCopyException("bad bytecode. fatal?");
	}

	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	public virtual List getAttributes()
	{
		return attributes;
	}

	[LineNumberTable(273)]
	public virtual int getCodeLength()
	{
		return info.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 122, 103, 104, 138, 112 })]
	public virtual void insertLocalVar(int where, int size)
	{
		CodeIterator codeIterator = iterator();
		while (codeIterator.hasNext())
		{
			shiftIndex(codeIterator, where, size);
		}
		setMaxLocals(getMaxLocals() + size);
	}

	public virtual ExceptionTable getExceptionTable()
	{
		return exceptions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		50, 144, 135, 108, 140, 103, 108, 140, 141, 107,
		103, 102, 51, 134
	})]
	internal CodeAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, (byte[])null)
	{
		P_2.readInt();
		maxStack = P_2.readUnsignedShort();
		maxLocals = P_2.readUnsignedShort();
		int num = P_2.readInt();
		info = new byte[num];
		P_2.readFully(info);
		exceptions = new ExceptionTable(P_0, P_2);
		attributes = new ArrayList();
		int num2 = P_2.readUnsignedShort();
		for (int i = 0; i < num2; i++)
		{
			attributes.add(AttributeInfo.read(P_0, P_2));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 110, 103, 103, 104, 104, 107 })]
	public CodeAttribute(ConstPool cp, int stack, int locals, byte[] code, ExceptionTable etable)
		: base(cp, "Code")
	{
		maxStack = stack;
		maxLocals = locals;
		info = code;
		exceptions = etable;
		attributes = new ArrayList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljavassist/bytecode/ExceptionTable;Ljavassist/bytecode/CodeAttribute;)[B")]
	[LineNumberTable(new byte[] { 160, 243, 103, 103, 104, 151 })]
	private byte[] copyCode(ConstPool P_0, Map P_1, ExceptionTable P_2, CodeAttribute P_3)
	{
		int codeLength = getCodeLength();
		byte[] array = (P_3.info = new byte[codeLength]);
		LdcEntry ldcEntry = copyCode(info, 0, codeLength, getConstPool(), array, P_0, P_1);
		byte[] result = LdcEntry.doit(array, ldcEntry, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/CodeAttribute;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		31, 142, 108, 108, 115, 107, 103, 103, 102, 110,
		21, 230, 69, 117
	})]
	private CodeAttribute(ConstPool P_0, CodeAttribute P_1, Map P_2)
		: base(P_0, "Code")
	{
		maxStack = P_1.getMaxStack();
		maxLocals = P_1.getMaxLocals();
		exceptions = P_1.getExceptionTable().copy(P_0, P_2);
		attributes = new ArrayList();
		List list = P_1.getAttributes();
		int num = list.size();
		for (int i = 0; i < num; i++)
		{
			AttributeInfo attributeInfo = (AttributeInfo)list.get(i);
			attributes.add(attributeInfo.copy(P_0, P_2));
		}
		info = P_1.copyCode(P_0, P_2, exceptions, this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 118, 126, 38 })]
	public override int length()
	{
		return (int)(18 + (nint)info.LongLength + exceptions.size() * 8 + AttributeInfo.getLength(attributes));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("([BIILjavassist/bytecode/ConstPool;[BLjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/CodeAttribute$LdcEntry;")]
	[LineNumberTable(new byte[]
	{
		161,
		1,
		130,
		105,
		104,
		100,
		101,
		byte.MaxValue,
		160,
		135,
		78,
		144,
		133,
		103,
		110,
		105,
		142,
		101,
		103,
		103,
		104,
		105,
		104,
		131,
		133,
		144,
		107,
		107,
		133,
		144,
		103,
		103,
		130,
		144,
		107,
		130,
		104,
		233,
		9,
		231,
		125
	})]
	private static LdcEntry copyCode(byte[] P_0, int P_1, int P_2, ConstPool P_3, byte[] P_4, ConstPool P_5, Map P_6)
	{
		LdcEntry ldcEntry = null;
		int num2;
		for (int num = P_1; num < P_2; num = num2)
		{
			num2 = CodeIterator.nextOpcode(P_0, num);
			int num3 = P_0[num];
			P_4[num] = (byte)num3;
			switch (num3 & 0xFF)
			{
			case 19:
			case 20:
			case 178:
			case 179:
			case 180:
			case 181:
			case 182:
			case 183:
			case 184:
			case 187:
			case 189:
			case 192:
			case 193:
				copyConstPoolInfo(num + 1, P_0, P_3, P_4, P_5, P_6);
				continue;
			case 18:
			{
				int n = P_0[num + 1];
				n = P_3.copy(n, P_5, P_6);
				if (n < 256)
				{
					P_4[num + 1] = (byte)(sbyte)n;
					continue;
				}
				P_4[num] = 0;
				P_4[num + 1] = 0;
				LdcEntry ldcEntry2 = new LdcEntry();
				ldcEntry2.where = num;
				ldcEntry2.index = n;
				ldcEntry2.next = ldcEntry;
				ldcEntry = ldcEntry2;
				continue;
			}
			case 185:
				copyConstPoolInfo(num + 1, P_0, P_3, P_4, P_5, P_6);
				P_4[num + 3] = P_0[num + 3];
				P_4[num + 4] = P_0[num + 4];
				continue;
			case 186:
				copyConstPoolInfo(num + 1, P_0, P_3, P_4, P_5, P_6);
				P_4[num + 3] = 0;
				P_4[num + 4] = 0;
				continue;
			case 197:
				copyConstPoolInfo(num + 1, P_0, P_3, P_4, P_5, P_6);
				P_4[num + 3] = P_0[num + 3];
				continue;
			}
			while (true)
			{
				num++;
				if (num >= num2)
				{
					break;
				}
				P_4[num] = P_0[num];
			}
		}
		return ldcEntry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(I[BLjavassist/bytecode/ConstPool;[BLjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 161, 70, 108, 108, 103, 103 })]
	private static void copyConstPoolInfo(int P_0, byte[] P_1, ConstPool P_2, byte[] P_3, ConstPool P_4, Map P_5)
	{
		int n = (P_1[P_0] << 8) | P_1[P_0 + 1];
		n = P_2.copy(n, P_4, P_5);
		P_3[P_0] = (byte)(sbyte)(n >> 8);
		P_3[P_0 + 1] = (byte)(sbyte)n;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 137, 103, 104, 101, 97, 104, 133, 143, 133,
		147, 101, 97, 133, 207, 179, 107, 106, 100, 129,
		100, 104, 140, 107, 105, 111, 111, 107, 139, 98,
		104, 108, 104, 106, 100, 129, 100, 140
	})]
	private static void shiftIndex(CodeIterator P_0, int P_1, int P_2)
	{
		int num = P_0.next();
		int num2 = P_0.byteAt(num);
		switch (num2)
		{
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
			shiftIndex8(P_0, num, num2, P_1, P_2);
			break;
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
		case 39:
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
			shiftIndex0(P_0, num, num2, P_1, P_2, 26, 21);
			break;
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
			shiftIndex8(P_0, num, num2, P_1, P_2);
			break;
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
			shiftIndex0(P_0, num, num2, P_1, P_2, 59, 54);
			break;
		case 132:
		{
			int num3 = P_0.byteAt(num + 1);
			if (num3 >= P_1)
			{
				num3 += P_2;
				if (num3 < 256)
				{
					P_0.writeByte(num3, num + 1);
					break;
				}
				int value = (sbyte)P_0.byteAt(num + 2);
				int num4 = P_0.insertExGap(3);
				P_0.writeByte(196, num4 - 3);
				P_0.writeByte(132, num4 - 2);
				P_0.write16bit(num3, num4 - 1);
				P_0.write16bit(value, num4 + 1);
			}
			break;
		}
		case 169:
			shiftIndex8(P_0, num, num2, P_1, P_2);
			break;
		case 196:
		{
			int num3 = P_0.u16bitAt(num + 2);
			if (num3 >= P_1)
			{
				num3 += P_2;
				P_0.write16bit(num3, num + 2);
			}
			break;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 194, 106, 100, 129, 101, 104, 140, 104, 110,
		106, 138
	})]
	private static void shiftIndex8(CodeIterator P_0, int P_1, int P_2, int P_3, int P_4)
	{
		int num = P_0.byteAt(P_1 + 1);
		if (num >= P_3)
		{
			num += P_4;
			if (num < 256)
			{
				P_0.writeByte(num, P_1 + 1);
				return;
			}
			int num2 = P_0.insertExGap(2);
			P_0.writeByte(196, num2 - 2);
			P_0.writeByte(P_2, num2 - 1);
			P_0.write16bit(num, num2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 214, 112, 100, 129, 101, 100, 141, 107, 104,
		104, 106, 104, 130, 104, 110, 104, 172
	})]
	private static void shiftIndex0(CodeIterator P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6)
	{
		int num = P_2 - P_5;
		int num2 = ((4 != -1) ? (num % 4) : 0);
		if (num2 < P_3)
		{
			return;
		}
		num2 += P_4;
		if (num2 < 4)
		{
			P_0.writeByte(P_2 + P_4, P_1);
			return;
		}
		P_2 = (P_2 - P_5) / 4 + P_6;
		if (num2 < 256)
		{
			int num3 = P_0.insertExGap(1);
			P_0.writeByte(P_2, num3 - 1);
			P_0.writeByte(num2, num3);
		}
		else
		{
			int num3 = P_0.insertExGap(3);
			P_0.writeByte(196, num3 - 1);
			P_0.writeByte(P_2, num3);
			P_0.write16bit(num2, num3 + 1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 124, 108, 110, 108, 108, 109, 108, 108, 113, 110 })]
	internal override void write(DataOutputStream P_0)
	{
		P_0.writeShort(name);
		P_0.writeInt(length() - 6);
		P_0.writeShort(maxStack);
		P_0.writeShort(maxLocals);
		P_0.writeInt(info.Length);
		P_0.write(info);
		exceptions.write(P_0);
		P_0.writeShort(attributes.size());
		AttributeInfo.writeAll(attributes, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(192)]
	public override byte[] get()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("CodeAttribute.get()");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(202)]
	public override void set(byte[] newinfo)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("CodeAttribute.set()");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 93, 111 })]
	internal override void renameClass(string P_0, string P_1)
	{
		AttributeInfo.renameClass(attributes, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 98, 110 })]
	internal override void renameClass(Map P_0)
	{
		AttributeInfo.renameClass(attributes, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 103, 110 })]
	internal override void getRefClasses(Map P_0)
	{
		AttributeInfo.getRefClasses(attributes, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 111, 103 })]
	public virtual string getDeclaringClass()
	{
		ConstPool constPool = getConstPool();
		string className = constPool.getClassName();
		_ = null;
		return className;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 137, 113 })]
	public virtual int computeMaxStack()
	{
		maxStack = new CodeAnalyzer(this).computeMaxStack();
		return maxStack;
	}

	public virtual byte[] getCode()
	{
		return info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(286)]
	internal virtual void setCode(byte[] P_0)
	{
		base.set(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 216, 113, 99, 109 })]
	public virtual void setAttribute(StackMapTable smt)
	{
		AttributeInfo.remove(attributes, "StackMapTable");
		if (smt != null)
		{
			attributes.add(smt);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 231, 113, 99, 109 })]
	public virtual void setAttribute(StackMap sm)
	{
		AttributeInfo.remove(attributes, "StackMap");
		if (sm != null)
		{
			attributes.add(sm);
		}
	}
}
