using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class Utf8Info : ConstInfo
{
	internal const int tag = 1;

	internal string @string;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 231, 105, 103 })]
	public Utf8Info(string P_0, int P_1)
		: base(P_1)
	{
		@string = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 238, 105, 108 })]
	public Utf8Info(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		@string = P_0.readUTF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2150)]
	public override int hashCode()
	{
		int result = String.instancehelper_hashCode(@string);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 249, 121, 43 })]
	public override bool equals(object P_0)
	{
		return (P_0 is Utf8Info && String.instancehelper_equals(((Utf8Info)P_0).@string, @string)) ? true : false;
	}

	public override int getTag()
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(2166)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addUtf8Info(@string);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 11, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(1);
		P_0.writeUTF(@string);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 17, 107, 108, 109 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("UTF8 \"");
		P_0.print(@string);
		P_0.println("\"");
	}
}
