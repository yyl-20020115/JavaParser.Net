using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode;

[Implements(new string[] { "java.lang.Cloneable", "javassist.bytecode.Opcode" })]
public class Bytecode : ByteVector, Cloneable.__Interface, Opcode
{
	internal static CtClass ___003C_003ETHIS;

	internal ConstPool constPool;

	internal int maxStack;

	internal int maxLocals;

	internal ExceptionTable tryblocks;

	private int stackDepth;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static CtClass THIS
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETHIS;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 80, 115, 50 })]
	public virtual CodeAttribute toCodeAttribute()
	{
		CodeAttribute result = new CodeAttribute(constPool, maxStack, maxLocals, get(), tryblocks);
		_ = null;
		return result;
	}

	public virtual int getMaxStack()
	{
		return maxStack;
	}

	public virtual int getMaxLocals()
	{
		return maxLocals;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(209)]
	public virtual byte[] get()
	{
		byte[] result = base.copy();
		_ = null;
		return result;
	}

	public virtual ExceptionTable getExceptionTable()
	{
		return tryblocks;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 104, 103, 103, 103, 108, 103 })]
	public Bytecode(ConstPool cp, int stacksize, int localvars)
	{
		constPool = cp;
		maxStack = stacksize;
		maxLocals = localvars;
		tryblocks = new ExceptionTable(cp);
		stackDepth = 0;
	}

	public virtual void setStackDepth(int depth)
	{
		stackDepth = depth;
		if (stackDepth > maxStack)
		{
			maxStack = stackDepth;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(321)]
	public virtual int currentPc()
	{
		int result = base.getSize();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 51, 103, 111 })]
	public virtual void addOpcode(int code)
	{
		add(code);
		growStack(Opcode.STACK_GROW[code]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 117, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addAstore(int n)
	{
		if (n < 4)
		{
			addOpcode(75 + n);
		}
		else if (n < 256)
		{
			addOpcode(58);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(58);
			addIndex(n);
		}
	}

	public virtual void setMaxLocals(int size)
	{
		maxLocals = size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 148, 107, 191, 9, 105, 104, 103, 130, 104,
		105, 104, 103, 162, 176, 135
	})]
	public virtual int addStore(int n, CtClass type)
	{
		if (type.isPrimitive())
		{
			if (type == CtClass.booleanType || type == CtClass.charType || type == CtClass.byteType || type == CtClass.shortType || type == CtClass.intType)
			{
				addIstore(n);
			}
			else
			{
				if (type == CtClass.longType)
				{
					addLstore(n);
					return 2;
				}
				if (type != CtClass.floatType)
				{
					if (type == CtClass.doubleType)
					{
						addDstore(n);
						return 2;
					}
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new RuntimeException("void type?");
				}
				addFstore(n);
			}
		}
		else
		{
			addAstore(n);
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 115, 107, 191, 9, 105, 104, 103, 130, 104,
		105, 104, 103, 162, 176, 135
	})]
	public virtual int addLoad(int n, CtClass type)
	{
		if (type.isPrimitive())
		{
			if (type == CtClass.booleanType || type == CtClass.charType || type == CtClass.byteType || type == CtClass.shortType || type == CtClass.intType)
			{
				addIload(n);
			}
			else
			{
				if (type == CtClass.longType)
				{
					addLload(n);
					return 2;
				}
				if (type != CtClass.floatType)
				{
					if (type == CtClass.doubleType)
					{
						addDload(n);
						return 2;
					}
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new RuntimeException("void type?");
				}
				addFload(n);
			}
		}
		else
		{
			addAload(n);
		}
		return 1;
	}

	[LineNumberTable(new byte[] { 160, 171, 110 })]
	public virtual void incMaxLocals(int diff)
	{
		maxLocals += diff;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 12, 114, 146, 106 })]
	public virtual void addDconst(double d)
	{
		if (d == 0.0 || d == 1.0)
		{
			addOpcode(14 + ByteCodeHelper.d2i(d));
		}
		else
		{
			addLdc2w(d);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 43, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addDstore(int n)
	{
		if (n < 4)
		{
			addOpcode(71 + n);
		}
		else if (n < 256)
		{
			addOpcode(57);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(57);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 62, 123, 146, 117 })]
	public virtual void addFconst(float f)
	{
		if (f == 0f || f == 1f || f == 2f)
		{
			addOpcode(11 + ByteCodeHelper.f2i(f));
		}
		else
		{
			addLdc(constPool.addFloatInfo(f));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 93, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addFstore(int n)
	{
		if (n < 4)
		{
			addOpcode(67 + n);
		}
		else if (n < 256)
		{
			addOpcode(56);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(56);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 218, 110, 141, 105 })]
	public virtual void addLconst(long n)
	{
		if (n == 0 || n == 1)
		{
			addOpcode(9 + (int)n);
		}
		else
		{
			addLdc2w(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 249, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addLstore(int n)
	{
		if (n < 4)
		{
			addOpcode(63 + n);
		}
		else if (n < 256)
		{
			addOpcode(55);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(55);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 136, 105, 107, 106, 104, 137, 112, 104, 105,
		169, 116
	})]
	public virtual void addIconst(int n)
	{
		if (n < 6 && -2 < n)
		{
			addOpcode(3 + n);
		}
		else if (n <= 127 && -128 <= n)
		{
			addOpcode(16);
			add(n);
		}
		else if (n <= 32767 && -32768 <= n)
		{
			addOpcode(17);
			add(n >> 8);
			add(n);
		}
		else
		{
			addLdc(constPool.addIntegerInfo(n));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 199, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addIstore(int n)
	{
		if (n < 4)
		{
			addOpcode(59 + n);
		}
		else if (n < 256)
		{
			addOpcode(54);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(54);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 98, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addAload(int n)
	{
		if (n < 4)
		{
			addOpcode(42 + n);
		}
		else if (n < 256)
		{
			addOpcode(25);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(25);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 19, 105 })]
	public override void add(int code)
	{
		base.add(code);
	}

	public virtual void setMaxStack(int size)
	{
		maxStack = size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 196, 103, 107, 105 })]
	public virtual void addNewarray(int atype, int length)
	{
		addIconst(length);
		addOpcode(188);
		add(atype);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 184, 103, 107, 116 })]
	public virtual void addAnewarray(CtClass clazz, int length)
	{
		addIconst(length);
		addOpcode(189);
		addIndex(constPool.addClassInfo(clazz));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 0, 108 })]
	public virtual void addPutfield(CtClass c, string name, string desc)
	{
		addPutfield0(c, null, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 33, 108 })]
	public virtual void addPutstatic(CtClass c, string name, string desc)
	{
		addPutstatic0(c, null, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 143, 104, 117 })]
	public virtual void addLdc2w(double d)
	{
		addOpcode(20);
		addIndex(constPool.addDoubleInfo(d));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 135, 104, 116 })]
	public virtual void addLdc2w(long l)
	{
		addOpcode(20);
		addIndex(constPool.addLongInfo(l));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 153, 107, 116 })]
	public virtual void addNew(CtClass clazz)
	{
		addOpcode(187);
		addIndex(constPool.addClassInfo(clazz));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 53, 109, 105, 39, 135 })]
	public virtual void addInvokespecial(CtClass clazz, string name, string desc)
	{
		int isInterface = ((clazz?.isInterface() ?? false) ? 1 : 0);
		addInvokespecial((byte)isInterface != 0, constPool.addClassInfo(clazz), name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 173, 107, 116 })]
	public virtual void addAnewarray(string classname)
	{
		addOpcode(189);
		addIndex(constPool.addClassInfo(classname));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 112, 116 })]
	public virtual void addLdc(string s)
	{
		addLdc(constPool.addStringInfo(s));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 153, 104, 132, 135, 119 })]
	public virtual void addInvokestatic(CtClass clazz, string name, string desc)
	{
		int num = ((clazz != ___003C_003ETHIS && clazz.isInterface()) ? 1 : 0);
		addInvokestatic(constPool.addClassInfo(clazz), name, desc, (byte)num != 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 209, 99, 102, 41, 166, 103 })]
	public virtual int addMultiNewarray(CtClass clazz, int[] dimensions)
	{
		int num = dimensions.Length;
		for (int i = 0; i < num; i++)
		{
			addIconst(dimensions[i]);
		}
		growStack(num);
		int result = addMultiNewarray(clazz, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 230, 107, 109, 116, 112 })]
	public virtual void addGetfield(CtClass c, string name, string type)
	{
		add(180);
		int classInfo = constPool.addClassInfo(c);
		addIndex(constPool.addFieldrefInfo(classInfo, name, type));
		growStack(Descriptor.dataSize(type) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 6, 107, 109, 116, 110 })]
	public virtual void addGetstatic(CtClass c, string name, string type)
	{
		add(178);
		int classInfo = constPool.addClassInfo(c);
		addIndex(constPool.addFieldrefInfo(classInfo, name, type));
		growStack(Descriptor.dataSize(type));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 64, 99, 109, 104, 103, 108, 130, 109 })]
	public virtual void addReturn(CtClass type)
	{
		if (type == null)
		{
			addOpcode(177);
		}
		else if (type.isPrimitive())
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)type;
			addOpcode(ctPrimitiveType.getReturnOp());
		}
		else
		{
			addOpcode(176);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 180, 98, 99, 99, 102, 47, 198 })]
	public virtual int addLoadParameters(CtClass[] @params, int offset)
	{
		int num = 0;
		if (@params != null)
		{
			int num2 = @params.Length;
			for (int i = 0; i < num2; i++)
			{
				num += addLoad(num + offset, @params[i]);
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 77, 130, 99, 133, 99, 102, 102, 99, 104,
		102, 106, 135, 229, 59, 232, 73, 103
	})]
	public virtual void setMaxLocals(bool isStatic, CtClass[] @params, int locals)
	{
		if (!isStatic)
		{
			locals++;
		}
		if (@params != null)
		{
			CtClass doubleType = CtClass.doubleType;
			CtClass longType = CtClass.longType;
			int num = @params.Length;
			for (int i = 0; i < num; i++)
			{
				CtClass ctClass = @params[i];
				locals = ((ctClass != doubleType && ctClass != longType) ? (locals + 1) : (locals + 2));
			}
		}
		maxLocals = locals;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 206, 107, 116 })]
	public virtual void addCheckcast(string classname)
	{
		addOpcode(192);
		addIndex(constPool.addClassInfo(classname));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 251, 118 })]
	public virtual void addInvokevirtual(string classname, string name, string desc)
	{
		addInvokevirtual(constPool.addClassInfo(classname), name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 196, 107, 116 })]
	public virtual void addCheckcast(CtClass c)
	{
		addOpcode(192);
		addIndex(constPool.addClassInfo(c));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 86, 108 })]
	public virtual void addInvokespecial(int clazz, string name, string desc)
	{
		addInvokespecial(isInterface: false, clazz, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 199, 114 })]
	public virtual void addExceptionHandler(int start, int end, int handler, int type)
	{
		tryblocks.add(start, end, handler, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(332)]
	public override int read(int offset)
	{
		int result = base.read(offset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 226, 104, 106 })]
	public virtual int read16bit(int offset)
	{
		int num = read(offset);
		int num2 = read(offset + 1);
		return (num << 8) + (num2 & 0xFF);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 249, 106 })]
	public override void write(int offset, int value)
	{
		base.write(offset, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 1, 106, 108 })]
	public virtual void write16bit(int offset, int value)
	{
		write(offset, value >> 8);
		write(offset + 1, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(117)]
	public override void add(int i1, int i2, int i3, int i4)
	{
		base.add(i1, i2, i3, i4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 63, 112 })]
	public virtual void growStack(int diff)
	{
		setStackDepth(stackDepth + diff);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(117)]
	public override void add(int i1, int i2)
	{
		base.add(i1, i2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 89, 108 })]
	public virtual void addIndex(int index)
	{
		add(index >> 8, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 121, 104, 104, 169, 104, 137 })]
	public virtual void addLdc(int i)
	{
		if (i > 255)
		{
			addOpcode(19);
			addIndex(i);
		}
		else
		{
			addOpcode(18);
			add(i);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 180, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addIload(int n)
	{
		if (n < 4)
		{
			addOpcode(26 + n);
		}
		else if (n < 256)
		{
			addOpcode(21);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(21);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 230, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addLload(int n)
	{
		if (n < 4)
		{
			addOpcode(30 + n);
		}
		else if (n < 256)
		{
			addOpcode(22);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(22);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 74, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addFload(int n)
	{
		if (n < 4)
		{
			addOpcode(34 + n);
		}
		else if (n < 256)
		{
			addOpcode(23);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(23);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 24, 100, 108, 104, 104, 169, 107, 104, 137 })]
	public virtual void addDload(int n)
	{
		if (n < 4)
		{
			addOpcode(38 + n);
		}
		else if (n < 256)
		{
			addOpcode(24);
			add(n);
		}
		else
		{
			addOpcode(196);
			addOpcode(24);
			addIndex(n);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 152, 130, 99, 146, 144, 107 })]
	public virtual void addInvokespecial(bool isInterface, int clazz, string name, string desc)
	{
		int index = ((!isInterface) ? constPool.addMethodrefInfo(clazz, name, desc) : constPool.addInterfaceMethodrefInfo(clazz, name, desc));
		addInvokespecial(index, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 123, 107, 103, 112 })]
	public virtual void addInvokespecial(int index, string desc)
	{
		add(183);
		addIndex(index);
		growStack(Descriptor.dataSize(desc) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 130, 99, 139, 99, 145, 143, 103, 110 })]
	private void addInvokestatic(int P_0, string P_1, string P_2, bool P_3)
	{
		add(184);
		int index = ((!P_3) ? constPool.addMethodrefInfo(P_0, P_1, P_2) : constPool.addInterfaceMethodrefInfo(P_0, P_1, P_2));
		addIndex(index);
		growStack(Descriptor.dataSize(P_2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 186, 108 })]
	public virtual void addInvokestatic(int clazz, string name, string desc)
	{
		addInvokestatic(clazz, name, desc, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 234, 118 })]
	public virtual void addInvokevirtual(CtClass clazz, string name, string desc)
	{
		addInvokevirtual(constPool.addClassInfo(clazz), name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 13, 107, 116, 112 })]
	public virtual void addInvokevirtual(int clazz, string name, string desc)
	{
		add(182);
		addIndex(constPool.addMethodrefInfo(clazz, name, desc));
		growStack(Descriptor.dataSize(desc) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 46, 152 })]
	public virtual void addInvokeinterface(CtClass clazz, string name, string desc, int count)
	{
		addInvokeinterface(constPool.addClassInfo(clazz), name, desc, count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 79, 107, 116, 104, 103, 112 })]
	public virtual void addInvokeinterface(int clazz, string name, string desc, int count)
	{
		add(185);
		addIndex(constPool.addInterfaceMethodrefInfo(clazz, name, desc));
		add(count);
		add(0);
		growStack(Descriptor.dataSize(desc) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 226, 107, 114, 103, 105 })]
	public virtual int addMultiNewarray(CtClass clazz, int dim)
	{
		add(197);
		addIndex(constPool.addClassInfo(clazz));
		add(dim);
		growStack(1 - dim);
		return dim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 17, 139, 113, 109, 117, 113 })]
	private void addPutfield0(CtClass P_0, string P_1, string P_2, string P_3)
	{
		add(181);
		int classInfo = ((P_1 != null) ? constPool.addClassInfo(P_1) : constPool.addClassInfo(P_0));
		addIndex(constPool.addFieldrefInfo(classInfo, P_2, P_3));
		growStack(-1 - Descriptor.dataSize(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 50, 139, 113, 109, 117, 112 })]
	private void addPutstatic0(CtClass P_0, string P_1, string P_2, string P_3)
	{
		add(179);
		int classInfo = ((P_1 != null) ? constPool.addClassInfo(P_1) : constPool.addClassInfo(P_0));
		addIndex(constPool.addFieldrefInfo(classInfo, P_2, P_3));
		growStack(-Descriptor.dataSize(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 22, 107, 109, 116, 110 })]
	public virtual void addGetstatic(string c, string name, string type)
	{
		add(178);
		int classInfo = constPool.addClassInfo(c);
		addIndex(constPool.addFieldrefInfo(classInfo, name, type));
		growStack(Descriptor.dataSize(type));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 110, 107 })]
	public Bytecode(ConstPool cp)
		: this(cp, 0, 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 121, 108, 118, 151, 97 })]
	public override object clone()
	{
		//Discarded unreachable code: IL_0025
		CloneNotSupportedException ex;
		try
		{
			Bytecode bytecode = (Bytecode)base.clone();
			bytecode.tryblocks = (ExceptionTable)tryblocks.clone();
			return bytecode;
		}
		catch (CloneNotSupportedException x)
		{
			ex = ByteCodeHelper.MapException<CloneNotSupportedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		CloneNotSupportedException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	public virtual ConstPool getConstPool()
	{
		return constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(202)]
	public virtual int length()
	{
		int result = base.getSize();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 179, 108, 37, 135 })]
	public virtual void addExceptionHandler(int start, int end, int handler, CtClass type)
	{
		addExceptionHandler(start, end, handler, constPool.addClassInfo(type));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 190, 108, 37, 135 })]
	public virtual void addExceptionHandler(int start, int end, int handler, string type)
	{
		addExceptionHandler(start, end, handler, constPool.addClassInfo(type));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 236, 104, 106 })]
	public virtual int read32bit(int offset)
	{
		int num = read16bit(offset);
		int num2 = read16bit(offset + 2);
		return (num << 16) + (num2 & 0xFFFF);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 10, 107, 108 })]
	public virtual void write32bit(int offset, int value)
	{
		write16bit(offset, value >> 16);
		write16bit(offset + 2, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 26, 116 })]
	public virtual void add32bit(int value)
	{
		add(value >> 24, value >> 16, value >> 8, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 36, 105 })]
	public override void addGap(int length)
	{
		base.addGap(length);
	}

	public virtual int getStackDepth()
	{
		return stackDepth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 158, 104, 104, 106, 104, 106, 104, 106, 104,
		144, 169, 105
	})]
	public virtual void addConstZero(CtClass type)
	{
		if (type.isPrimitive())
		{
			if (type == CtClass.longType)
			{
				addOpcode(9);
				return;
			}
			if (type == CtClass.floatType)
			{
				addOpcode(11);
				return;
			}
			if (type == CtClass.doubleType)
			{
				addOpcode(14);
				return;
			}
			if (type == CtClass.voidType)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("void type?");
			}
			addOpcode(3);
		}
		else
		{
			addOpcode(1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 216, 107, 116 })]
	public virtual void addInstanceof(string classname)
	{
		addOpcode(193);
		addIndex(constPool.addClassInfo(classname));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 246, 107, 109, 116, 112 })]
	public virtual void addGetfield(string c, string name, string type)
	{
		add(180);
		int classInfo = constPool.addClassInfo(c);
		addIndex(constPool.addFieldrefInfo(classInfo, name, type));
		growStack(Descriptor.dataSize(type) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 38, 105, 107 })]
	public virtual void addInvokespecial(CtClass clazz, string name, CtClass returnType, CtClass[] paramTypes)
	{
		string desc = Descriptor.ofMethod(returnType, paramTypes);
		addInvokespecial(clazz, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 70, 119 })]
	public virtual void addInvokespecial(string clazz, string name, string desc)
	{
		addInvokespecial(isInterface: false, constPool.addClassInfo(clazz), name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 138, 105, 107 })]
	public virtual void addInvokestatic(CtClass clazz, string name, CtClass returnType, CtClass[] paramTypes)
	{
		string desc = Descriptor.ofMethod(returnType, paramTypes);
		addInvokestatic(clazz, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 172, 118 })]
	public virtual void addInvokestatic(string classname, string name, string desc)
	{
		addInvokestatic(constPool.addClassInfo(classname), name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 216, 105, 107 })]
	public virtual void addInvokevirtual(CtClass clazz, string name, CtClass returnType, CtClass[] paramTypes)
	{
		string desc = Descriptor.ofMethod(returnType, paramTypes);
		addInvokevirtual(clazz, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 30, 105, 109 })]
	public virtual void addInvokeinterface(CtClass clazz, string name, CtClass returnType, CtClass[] paramTypes, int count)
	{
		string desc = Descriptor.ofMethod(returnType, paramTypes);
		addInvokeinterface(clazz, name, desc, count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 62, 152 })]
	public virtual void addInvokeinterface(string classname, string name, string desc, int count)
	{
		addInvokeinterface(constPool.addClassInfo(classname), name, desc, count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 97, 110, 110, 107, 103, 104, 110 })]
	public virtual void addInvokedynamic(int bootstrap, string name, string desc)
	{
		int nameAndType = constPool.addNameAndTypeInfo(name, desc);
		int index = constPool.addInvokeDynamicInfo(bootstrap, nameAndType);
		add(186);
		addIndex(index);
		add(0, 0);
		growStack(Descriptor.dataSize(desc));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 163, 107, 116 })]
	public virtual void addNew(string classname)
	{
		addOpcode(187);
		addIndex(constPool.addClassInfo(classname));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 241, 107, 114, 103, 105 })]
	public virtual int addMultiNewarray(string desc, int dim)
	{
		add(197);
		addIndex(constPool.addClassInfo(desc));
		add(dim);
		growStack(1 - dim);
		return dim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 12, 108 })]
	public virtual void addPutfield(string classname, string name, string desc)
	{
		addPutfield0(null, classname, name, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 45, 108 })]
	public virtual void addPutstatic(string classname, string fieldName, string desc)
	{
		addPutstatic0(null, classname, fieldName, desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 80, 104, 107, 169, 107, 107, 137 })]
	public virtual void addRet(int var)
	{
		if (var < 256)
		{
			addOpcode(169);
			add(var);
		}
		else
		{
			addOpcode(196);
			addOpcode(169);
			addIndex(var);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 98, 117, 103, 151 })]
	public virtual void addPrintln(string message)
	{
		addGetstatic("java.lang.System", "err", "Ljava/io/PrintStream;");
		addLdc(message);
		addInvokevirtual("java.io.PrintStream", "println", "(Ljava/lang/String;)V");
	}

	[LineNumberTable(122)]
	static Bytecode()
	{
		___003C_003ETHIS = ConstPool.___003C_003ETHIS;
	}

	[HideFromJava]
	public static implicit operator Cloneable(Bytecode P_0)
	{
		Cloneable result = default(Cloneable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|getSize", "()I")]
	public new int getSize()
	{
		return ((ByteVector)this).getSize();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|copy", "()[B")]
	public new byte[] copy()
	{
		return ((ByteVector)this).copy();
	}
}
