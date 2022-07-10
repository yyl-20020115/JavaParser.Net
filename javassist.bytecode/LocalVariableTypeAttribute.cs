using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class LocalVariableTypeAttribute : LocalVariableAttribute
{
	public new const string tag = "LocalVariableTypeTable";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 187, 107 })]
	internal LocalVariableTypeAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 111 })]
	private LocalVariableTypeAttribute(ConstPool P_0, byte[] P_1)
		: base(P_0, "LocalVariableTypeTable", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 116, 111 })]
	public LocalVariableTypeAttribute(ConstPool cp)
		: base(cp, "LocalVariableTypeTable", new byte[2])
	{
		ByteArray.write16bit(0, info, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	internal override string renameEntry(string P_0, string P_1, string P_2)
	{
		string result = SignatureAttribute.renameClass(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljava/lang/String;")]
	[LineNumberTable(59)]
	internal override string renameEntry(string P_0, Map P_1)
	{
		string result = SignatureAttribute.renameClass(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	internal override LocalVariableAttribute makeThisAttr(ConstPool P_0, byte[] P_1)
	{
		LocalVariableTypeAttribute result = new LocalVariableTypeAttribute(P_0, P_1);
		_ = null;
		return result;
	}
}
