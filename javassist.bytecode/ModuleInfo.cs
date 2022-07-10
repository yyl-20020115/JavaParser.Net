using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class ModuleInfo : ConstInfo
{
	internal const int tag = 19;

	internal int name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 169, 39, 105, 103 })]
	public ModuleInfo(int P_0, int P_1)
		: base(P_1)
	{
		name = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 169, 46, 105, 108 })]
	public ModuleInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		name = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return name;
	}

	[LineNumberTable(2474)]
	public override bool equals(object P_0)
	{
		return (P_0 is ModuleInfo && ((ModuleInfo)P_0).name == name) ? true : false;
	}

	public override int getTag()
	{
		return 19;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2483)]
	public virtual string getModuleName(ConstPool P_0)
	{
		string utf8Info = P_0.getUtf8Info(name);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 169, 72, 109, 104 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(name);
		int nameIndex = P_1.addUtf8Info(utf8Info);
		int result = P_1.addModuleInfo(nameIndex);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 169, 80, 104, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(19);
		P_0.writeShort(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 169, 86, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Module #");
		P_0.println(name);
	}
}
