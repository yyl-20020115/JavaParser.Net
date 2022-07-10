using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace javassist.bytecode;

public class ClassFileWriter : Object
{
	public interface AttributeWriter
	{
		virtual int size();

		[Throws(new string[] { "java.io.IOException" })]
		virtual void write(DataOutputStream dos);
	}

	public sealed class ConstPoolWriter : Object
	{
		internal ByteStream output;

		protected internal int startPos;

		protected internal int num;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 163, 104, 103, 108, 103, 110 })]
		internal ConstPoolWriter(ByteStream P_0)
		{
			output = P_0;
			startPos = P_0.getPos();
			num = 1;
			output.writeShort(1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 179, 121 })]
		internal virtual void end()
		{
			output.writeShort(startPos, num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 195, 104, 108, 108 })]
		public virtual int addClassInfo(string jvmname)
		{
			int num = addUtf8Info(jvmname);
			output.write(7);
			output.writeShort(num);
			int num2 = this.num;
			this.num = num2 + 1;
			return num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 170, 108, 108 })]
		public virtual int addUtf8Info(string utf8)
		{
			output.write(1);
			output.writeUTF(utf8);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 232, 109, 108, 108 })]
		public virtual int addNameAndTypeInfo(int name, int type)
		{
			output.write(12);
			output.writeShort(name);
			output.writeShort(type);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 176, 99, 103, 102, 44, 166 })]
		public virtual int[] addClassInfo(string[] classNames)
		{
			int num = classNames.Length;
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = addClassInfo(classNames[i]);
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 208, 108, 108 })]
		public virtual int addClassInfo(int name)
		{
			output.write(7);
			output.writeShort(name);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(591)]
		public virtual int addNameAndTypeInfo(string name, string type)
		{
			int result = addNameAndTypeInfo(addUtf8Info(name), addUtf8Info(type));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 246, 109, 108, 108 })]
		public virtual int addFieldrefInfo(int classInfo, int nameAndTypeInfo)
		{
			output.write(9);
			output.writeShort(classInfo);
			output.writeShort(nameAndTypeInfo);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 4, 109, 108, 108 })]
		public virtual int addMethodrefInfo(int classInfo, int nameAndTypeInfo)
		{
			output.write(10);
			output.writeShort(classInfo);
			output.writeShort(nameAndTypeInfo);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 20, 109, 108, 108 })]
		public virtual int addInterfaceMethodrefInfo(int classInfo, int nameAndTypeInfo)
		{
			output.write(11);
			output.writeShort(classInfo);
			output.writeShort(nameAndTypeInfo);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 38, 109, 108, 108 })]
		public virtual int addMethodHandleInfo(int kind, int index)
		{
			output.write(15);
			output.write(kind);
			output.writeShort(index);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 54, 109, 108 })]
		public virtual int addMethodTypeInfo(int desc)
		{
			output.write(16);
			output.writeShort(desc);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 71, 109, 108, 108 })]
		public virtual int addInvokeDynamicInfo(int bootstrap, int nameAndTypeInfo)
		{
			output.write(18);
			output.writeShort(bootstrap);
			output.writeShort(nameAndTypeInfo);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 89, 109, 108, 108 })]
		public virtual int addDynamicInfo(int bootstrap, int nameAndTypeInfo)
		{
			output.write(17);
			output.writeShort(bootstrap);
			output.writeShort(nameAndTypeInfo);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 105, 104, 108, 108 })]
		public virtual int addStringInfo(string str)
		{
			int num = addUtf8Info(str);
			output.write(8);
			output.writeShort(num);
			int num2 = this.num;
			this.num = num2 + 1;
			return num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 118, 108, 108 })]
		public virtual int addIntegerInfo(int i)
		{
			output.write(3);
			output.writeInt(i);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 130, 108, 109 })]
		public virtual int addFloatInfo(float f)
		{
			output.write(4);
			output.writeFloat(f);
			int num = this.num;
			this.num = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 142, 108, 108, 103, 110 })]
		public virtual int addLongInfo(long l)
		{
			output.write(5);
			output.writeLong(l);
			int result = num;
			num += 2;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 156, 108, 109, 103, 110 })]
		public virtual int addDoubleInfo(double d)
		{
			output.write(6);
			output.writeDouble(d);
			int result = num;
			num += 2;
			return result;
		}
	}

	public sealed class FieldWriter : Object
	{
		protected internal ByteStream output;

		protected internal ConstPoolWriter constPool;

		private int fieldCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 144, 104, 112, 103, 103 })]
		internal FieldWriter(ConstPoolWriter P_0)
		{
			output = new ByteStream(128);
			constPool = P_0;
			fieldCount = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(298)]
		internal virtual int dataSize()
		{
			int result = output.size();
			_ = null;
			return result;
		}

		internal virtual int size()
		{
			return fieldCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 160, 190, 110 })]
		internal virtual void write(OutputStream P_0)
		{
			output.writeTo(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 175, 110, 108, 108, 108, 112 })]
		public virtual void add(int accessFlags, int name, int descriptor, AttributeWriter aw)
		{
			fieldCount++;
			output.writeShort(accessFlags);
			output.writeShort(name);
			output.writeShort(descriptor);
			writeAttribute(output, aw, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 160, 109, 109, 109 })]
		public virtual void add(int accessFlags, string name, string descriptor, AttributeWriter aw)
		{
			int name2 = constPool.addUtf8Info(name);
			int descriptor2 = constPool.addUtf8Info(descriptor);
			add(accessFlags, name2, descriptor2, aw);
		}
	}

	public sealed class MethodWriter : Object
	{
		protected internal ByteStream output;

		protected internal ConstPoolWriter constPool;

		private int methodCount;

		protected internal int codeIndex;

		protected internal int throwsIndex;

		protected internal int stackIndex;

		private int startPos;

		private bool isAbstract;

		private int catchPos;

		private int catchCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 210, 104, 112, 103, 103, 103, 103, 103 })]
		internal MethodWriter(ConstPoolWriter P_0)
		{
			output = new ByteStream(256);
			constPool = P_0;
			methodCount = 0;
			codeIndex = 0;
			throwsIndex = 0;
			stackIndex = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(515)]
		internal virtual int dataSize()
		{
			int result = output.size();
			_ = null;
			return result;
		}

		internal virtual int numOfMethods()
		{
			return methodCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 161, 151, 110 })]
		internal virtual void write(OutputStream P_0)
		{
			output.writeTo(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 254, 110, 108, 108, 108, 147, 109, 100, 132,
			142, 100, 136, 104, 104, 150, 113, 113, 173, 103,
			103
		})]
		public virtual void begin(int accessFlags, int name, int descriptor, int[] exceptions, AttributeWriter aw)
		{
			methodCount++;
			output.writeShort(accessFlags);
			output.writeShort(name);
			output.writeShort(descriptor);
			isAbstract = ((((uint)accessFlags & 0x400u) != 0) ? true : false);
			int num = ((!isAbstract) ? 1 : 0);
			if (exceptions != null)
			{
				num++;
			}
			writeAttribute(output, aw, num);
			if (exceptions != null)
			{
				writeThrows(exceptions);
			}
			if (!isAbstract)
			{
				if (codeIndex == 0)
				{
					codeIndex = constPool.addUtf8Info("Code");
				}
				startPos = output.getPos();
				output.writeShort(codeIndex);
				output.writeBlank(12);
			}
			catchPos = -1;
			catchCount = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 27, 104, 150, 113, 113, 109, 103, 46, 134 })]
		private void writeThrows(int[] P_0)
		{
			if (throwsIndex == 0)
			{
				throwsIndex = constPool.addUtf8Info("Exceptions");
			}
			output.writeShort(throwsIndex);
			output.writeInt((int)((nint)P_0.LongLength * 2 + 2));
			output.writeShort(P_0.Length);
			for (int i = 0; i < (nint)P_0.LongLength; i++)
			{
				output.writeShort(P_0[i]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 43, 110 })]
		public virtual void add(int b)
		{
			output.write(b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 50, 110 })]
		public virtual void add16(int b)
		{
			output.writeShort(b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 232, 109, 141, 100, 132, 142, 110 })]
		public virtual void begin(int accessFlags, string name, string descriptor, string[] exceptions, AttributeWriter aw)
		{
			int name2 = constPool.addUtf8Info(name);
			int descriptor2 = constPool.addUtf8Info(descriptor);
			int[] exceptions2 = ((exceptions != null) ? constPool.addClassInfo(exceptions) : null);
			begin(accessFlags, name2, descriptor2, exceptions2, aw);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 57, 110 })]
		public virtual void add32(int b)
		{
			output.writeInt(b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 67, 109, 111, 110, 103, 105 })]
		public virtual void addInvoke(int opcode, string targetClass, string methodName, string descriptor)
		{
			int classInfo = constPool.addClassInfo(targetClass);
			int nameAndTypeInfo = constPool.addNameAndTypeInfo(methodName, descriptor);
			int b = constPool.addMethodrefInfo(classInfo, nameAndTypeInfo);
			add(opcode);
			add16(b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 78, 104, 116, 116, 127, 10, 113, 103, 142 })]
		public virtual void codeEnd(int maxStack, int maxLocals)
		{
			if (!isAbstract)
			{
				output.writeShort(startPos + 6, maxStack);
				output.writeShort(startPos + 8, maxLocals);
				output.writeInt(startPos + 10, output.getPos() - startPos - 14);
				catchPos = output.getPos();
				catchCount = 0;
				output.writeShort(0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 96, 110, 108, 108, 108, 111 })]
		public virtual void addCatch(int startPc, int endPc, int handlerPc, int catchType)
		{
			catchCount++;
			output.writeShort(startPc);
			output.writeShort(endPc);
			output.writeShort(handlerPc);
			output.writeShort(catchType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 112, 104, 161, 151, 104, 141, 99, 104, 150,
			113, 103, 109, 204, 127, 10
		})]
		public virtual void end(StackMapTable.Writer smap, AttributeWriter aw)
		{
			if (isAbstract)
			{
				return;
			}
			output.writeShort(catchPos, catchCount);
			int num = ((smap != null) ? 1 : 0);
			writeAttribute(output, aw, num);
			if (smap != null)
			{
				if (stackIndex == 0)
				{
					stackIndex = constPool.addUtf8Info("StackMapTable");
				}
				output.writeShort(stackIndex);
				byte[] array = smap.toByteArray();
				output.writeInt(array.Length);
				output.write(array);
			}
			output.writeInt(startPos + 2, output.getPos() - startPos - 6);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(511)]
		public virtual int size()
		{
			return output.getPos() - startPos - 14;
		}
	}

	private ByteStream output;

	private ConstPoolWriter constPool;

	private FieldWriter fields;

	private MethodWriter methods;

	internal int thisClass;

	internal int superClass;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 122, 99, 103, 161, 110, 135, 103, 145, 99 })]
	internal static void writeAttribute(ByteStream P_0, AttributeWriter P_1, int P_2)
	{
		if (P_1 == null)
		{
			P_0.writeShort(P_2);
			return;
		}
		P_0.writeShort(P_1.size() + P_2);
		DataOutputStream dataOutputStream = new DataOutputStream(P_0);
		try
		{
			P_1.write(dataOutputStream);
			dataOutputStream.flush();
			return;
		}
		catch (IOException)
		{
		}
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 38, 104, 112, 112, 108, 108, 113, 113, 145 })]
	public ClassFileWriter(int major, int minor)
	{
		output = new ByteStream(512);
		output.writeInt(-889275714);
		output.writeShort(minor);
		output.writeShort(major);
		constPool = new ConstPoolWriter(output);
		fields = new FieldWriter(constPool);
		methods = new MethodWriter(constPool);
	}

	public virtual ConstPoolWriter getConstPool()
	{
		return constPool;
	}

	public virtual FieldWriter getFieldWriter()
	{
		return fields;
	}

	public virtual MethodWriter getMethodWriter()
	{
		return methods;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		79, 107, 108, 108, 108, 100, 142, 100, 108, 102,
		47, 198, 159, 5, 118, 145, 118, 156, 131, 110
	})]
	public virtual byte[] end(int accessFlags, int thisClass, int superClass, int[] interfaces, AttributeWriter aw)
	{
		constPool.end();
		output.writeShort(accessFlags);
		output.writeShort(thisClass);
		output.writeShort(superClass);
		if (interfaces == null)
		{
			output.writeShort(0);
		}
		else
		{
			int num = interfaces.Length;
			output.writeShort(num);
			for (int i = 0; i < num; i++)
			{
				output.writeShort(interfaces[i]);
			}
		}
		output.enlarge(fields.dataSize() + methods.dataSize() + 6);
		try
		{
			output.writeShort(fields.size());
			fields.write(output);
			output.writeShort(methods.numOfMethods());
			methods.write(output);
		}
		catch (IOException)
		{
			goto IL_00e6;
		}
		goto IL_00ec;
		IL_00ec:
		writeAttribute(output, aw, 0);
		return output.toByteArray();
		IL_00e6:
		_ = null;
		goto IL_00ec;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		125, 107, 108, 103, 103, 104, 100, 137, 100, 103,
		102, 42, 198, 113, 140, 113, 108, 100, 137, 109,
		138
	})]
	public virtual void end(DataOutputStream @out, int accessFlags, int thisClass, int superClass, int[] interfaces, AttributeWriter aw)
	{
		constPool.end();
		output.writeTo(@out);
		@out.writeShort(accessFlags);
		@out.writeShort(thisClass);
		@out.writeShort(superClass);
		if (interfaces == null)
		{
			@out.writeShort(0);
		}
		else
		{
			int num = interfaces.Length;
			@out.writeShort(num);
			for (int i = 0; i < num; i++)
			{
				@out.writeShort(interfaces[i]);
			}
		}
		@out.writeShort(fields.size());
		fields.write(@out);
		@out.writeShort(methods.numOfMethods());
		methods.write(@out);
		if (aw == null)
		{
			@out.writeShort(0);
			return;
		}
		@out.writeShort(aw.size());
		aw.write(@out);
	}
}
