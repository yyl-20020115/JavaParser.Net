using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.annotation;

namespace org.checkerframework.dataflow.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.dataflow.qual.PureAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
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
		"RUNTIME"
	}
})]
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
			"METHOD"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"CONSTRUCTOR"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface Pure : Annotation
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lorg/checkerframework/dataflow/qual/Pure$Kind;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class Kind : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			SIDE_EFFECT_FREE,
			DETERMINISTIC
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Kind ___003C_003ESIDE_EFFECT_FREE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Kind ___003C_003EDETERMINISTIC;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Kind[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Kind SIDE_EFFECT_FREE
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESIDE_EFFECT_FREE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Kind DETERMINISTIC
		{
			[HideFromJava]
			get
			{
				return ___003C_003EDETERMINISTIC;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(30)]
		private Kind(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(30)]
		public static Kind[] values()
		{
			return (Kind[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(30)]
		public static Kind valueOf(string name)
		{
			return (Kind)java.lang.Enum.valueOf(ClassLiteral<Kind>.Value, name);
		}

		[LineNumberTable(new byte[] { 159, 174, 176, 240, 59 })]
		static Kind()
		{
			___003C_003ESIDE_EFFECT_FREE = new Kind("SIDE_EFFECT_FREE", 0);
			___003C_003EDETERMINISTIC = new Kind("DETERMINISTIC", 1);
			_0024VALUES = new Kind[2] { ___003C_003ESIDE_EFFECT_FREE, ___003C_003EDETERMINISTIC };
		}
	}
}
