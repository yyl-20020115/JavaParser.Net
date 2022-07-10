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
			"TYPE"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"PACKAGE"
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
		"CLASS"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface ReflectionSupport : Annotation
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/j2objc/annotations/ReflectionSupport$Level;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class Level : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			NATIVE_ONLY,
			FULL
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Level ___003C_003ENATIVE_ONLY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Level ___003C_003EFULL;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Level[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Level NATIVE_ONLY
		{
			[HideFromJava]
			get
			{
				return ___003C_003ENATIVE_ONLY;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Level FULL
		{
			[HideFromJava]
			get
			{
				return ___003C_003EFULL;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(35)]
		private Level(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(35)]
		public static Level[] values()
		{
			return (Level[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(35)]
		public static Level valueOf(string name)
		{
			return (Level)java.lang.Enum.valueOf(ClassLiteral<Level>.Value, name);
		}

		[LineNumberTable(new byte[] { 159, 182, 208, 240, 55 })]
		static Level()
		{
			___003C_003ENATIVE_ONLY = new Level("NATIVE_ONLY", 0);
			___003C_003EFULL = new Level("FULL", 1);
			_0024VALUES = new Level[2] { ___003C_003ENATIVE_ONLY, ___003C_003EFULL };
		}
	}

	virtual Level value();
}
