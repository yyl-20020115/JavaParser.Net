using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class MethodTypeInfo : ConstInfo
{
	internal const int tag = 16;

	internal int descriptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 89, 105, 103 })]
	public MethodTypeInfo(int P_0, int P_1)
		: base(P_1)
	{
		descriptor = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 96, 105, 108 })]
	public MethodTypeInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		descriptor = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return descriptor;
	}

	[LineNumberTable(new byte[] { 168, 106, 104, 116 })]
	public override bool equals(object P_0)
	{
		if (P_0 is MethodTypeInfo)
		{
			return ((MethodTypeInfo)P_0).descriptor == descriptor;
		}
		return false;
	}

	public override int getTag()
	{
		return 16;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[] { 168, 118, 109, 105, 100, 100, 143, 105, 109, 138 })]
	public override void renameClass(ConstPool P_0, string P_1, string P_2, Map P_3)
	{
		string utf8Info = P_0.getUtf8Info(descriptor);
		string text = Descriptor.rename(utf8Info, P_1, P_2);
		if ((object)utf8Info != text)
		{
			if (P_3 == null)
			{
				descriptor = P_0.addUtf8Info(text);
				return;
			}
			P_3.remove(this);
			descriptor = P_0.addUtf8Info(text);
			P_3.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[] { 168, 134, 109, 104, 100, 99, 143, 104, 109, 137 })]
	public override void renameClass(ConstPool P_0, Map P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(descriptor);
		string text = Descriptor.rename(utf8Info, P_1);
		if ((object)utf8Info != text)
		{
			if (P_2 == null)
			{
				descriptor = P_0.addUtf8Info(text);
				return;
			}
			P_2.remove(this);
			descriptor = P_0.addUtf8Info(text);
			P_2.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 168, 149, 109, 104 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(descriptor);
		utf8Info = Descriptor.rename(utf8Info, P_2);
		int result = P_1.addMethodTypeInfo(P_1.addUtf8Info(utf8Info));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 157, 104, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(16);
		P_0.writeShort(descriptor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 163, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("MethodType #");
		P_0.println(descriptor);
	}
}
