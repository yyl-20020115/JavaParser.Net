using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class ClassInfo : ConstInfo
{
	internal const int tag = 7;

	internal int name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 132, 105, 103 })]
	public ClassInfo(int P_0, int P_1)
		: base(P_1)
	{
		name = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 165, 138, 105, 108 })]
	public ClassInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		name = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return name;
	}

	[LineNumberTable(1542)]
	public override bool equals(object P_0)
	{
		return (P_0 is ClassInfo && ((ClassInfo)P_0).name == name) ? true : false;
	}

	public override int getTag()
	{
		return 7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1551)]
	public override string getClassName(ConstPool P_0)
	{
		string utf8Info = P_0.getUtf8Info(name);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[]
	{
		165, 164, 109, 98, 105, 100, 107, 105, 100, 162,
		99, 100, 143, 105, 109, 138
	})]
	public override void renameClass(ConstPool P_0, string P_1, string P_2, Map P_3)
	{
		string utf8Info = P_0.getUtf8Info(name);
		string text = null;
		if (String.instancehelper_equals(utf8Info, P_1))
		{
			text = P_2;
		}
		else if (String.instancehelper_charAt(utf8Info, 0) == '[')
		{
			string text2 = Descriptor.rename(utf8Info, P_1, P_2);
			if ((object)utf8Info != text2)
			{
				text = text2;
			}
		}
		if (text != null)
		{
			if (P_3 == null)
			{
				name = P_0.addUtf8Info(text);
				return;
			}
			P_3.remove(this);
			name = P_0.addUtf8Info(text);
			P_3.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[]
	{
		165, 188, 109, 98, 107, 104, 100, 98, 130, 109,
		108, 162, 99, 99, 143, 104, 109, 169
	})]
	public override void renameClass(ConstPool P_0, Map P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(name);
		string text = null;
		if (String.instancehelper_charAt(utf8Info, 0) == '[')
		{
			string text2 = Descriptor.rename(utf8Info, P_1);
			if ((object)utf8Info != text2)
			{
				text = text2;
			}
		}
		else
		{
			string text2 = (string)P_1.get(utf8Info);
			if (text2 != null && !String.instancehelper_equals(text2, utf8Info))
			{
				text = text2;
			}
		}
		if (text != null)
		{
			if (P_2 == null)
			{
				name = P_0.addUtf8Info(text);
				return;
			}
			P_2.remove(this);
			name = P_0.addUtf8Info(text);
			P_2.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 165, 215, 109, 99, 109, 99, 162 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		string text = P_0.getUtf8Info(name);
		if (P_2 != null)
		{
			string text2 = (string)P_2.get(text);
			if (text2 != null)
			{
				text = text2;
			}
		}
		int result = P_1.addClassInfo(text);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 165, 228, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(7);
		P_0.writeShort(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 235, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Class #");
		P_0.println(name);
	}
}
