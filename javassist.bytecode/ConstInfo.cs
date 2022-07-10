using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal abstract class ConstInfo : Object
{
	internal int index;

	public abstract void print(PrintWriter P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1469)]
	public ConstInfo(int P_0)
	{
		index = P_0;
	}

	public abstract int getTag();

	public virtual string getClassName(ConstPool P_0)
	{
		return null;
	}

	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	public virtual void renameClass(ConstPool P_0, string P_1, string P_2, Map P_3)
	{
	}

	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	public virtual void renameClass(ConstPool P_0, Map P_1, Map P_2)
	{
	}

	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	public abstract int copy(ConstPool P_0, ConstPool P_1, Map P_2);

	[Throws(new string[] { "java.io.IOException" })]
	public abstract void write(DataOutputStream P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 93, 102, 103, 103 })]
	public override string toString()
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		PrintWriter printWriter = new PrintWriter(byteArrayOutputStream);
		print(printWriter);
		string result = byteArrayOutputStream.toString();
		_ = null;
		return result;
	}
}
