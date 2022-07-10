using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.common.io;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/io/FileWriteMode;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class FileWriteMode : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		APPEND
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static FileWriteMode ___003C_003EAPPEND;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static FileWriteMode[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static FileWriteMode APPEND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAPPEND;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(27)]
	private FileWriteMode(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	private static FileWriteMode[] _0024values()
	{
		return new FileWriteMode[1] { ___003C_003EAPPEND };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(25)]
	public static FileWriteMode[] values()
	{
		return (FileWriteMode[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(25)]
	public static FileWriteMode valueOf(string name)
	{
		return (FileWriteMode)java.lang.Enum.valueOf(ClassLiteral<FileWriteMode>.Value, name);
	}

	[LineNumberTable(new byte[] { 159, 171, 240, 60 })]
	static FileWriteMode()
	{
		___003C_003EAPPEND = new FileWriteMode("APPEND", 0);
		_0024VALUES = _0024values();
	}
}
