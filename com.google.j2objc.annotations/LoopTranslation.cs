using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.annotation;

namespace com.google.j2objc.annotations;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[Target(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Target;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"LOCAL_VARIABLE"
		}
	}
})]
[Retention(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Retention;",
	"value",
	new object[]
	{
		(byte)101,
		"Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
		"SOURCE"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface LoopTranslation : Annotation
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/j2objc/annotations/LoopTranslation$LoopStyle;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class LoopStyle : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			JAVA_ITERATOR,
			FAST_ENUMERATION
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static LoopStyle ___003C_003EJAVA_ITERATOR;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static LoopStyle ___003C_003EFAST_ENUMERATION;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static LoopStyle[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LoopStyle JAVA_ITERATOR
		{
			[HideFromJava]
			get
			{
				return ___003C_003EJAVA_ITERATOR;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LoopStyle FAST_ENUMERATION
		{
			[HideFromJava]
			get
			{
				return ___003C_003EFAST_ENUMERATION;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(36)]
		private LoopStyle(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(36)]
		public static LoopStyle[] values()
		{
			return (LoopStyle[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(36)]
		public static LoopStyle valueOf(string name)
		{
			return (LoopStyle)java.lang.Enum.valueOf(ClassLiteral<LoopStyle>.Value, name);
		}

		[LineNumberTable(new byte[] { 159, 186, 240, 70, 240, 50 })]
		static LoopStyle()
		{
			___003C_003EJAVA_ITERATOR = new LoopStyle("JAVA_ITERATOR", 0);
			___003C_003EFAST_ENUMERATION = new LoopStyle("FAST_ENUMERATION", 1);
			_0024VALUES = new LoopStyle[2] { ___003C_003EJAVA_ITERATOR, ___003C_003EFAST_ENUMERATION };
		}
	}

	virtual LoopStyle value();
}
