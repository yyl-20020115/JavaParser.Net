using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Partially : Object
{
	[InnerClass(null, Modifiers.Static | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
	[Modifiers(Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
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
				"METHOD"
			},
			new object[]
			{
				(byte)101,
				"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
				"CONSTRUCTOR"
			},
			new object[]
			{
				(byte)101,
				"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
				"FIELD"
			}
		}
	})]
	[Documented(new object[]
	{
		(byte)64,
		"Ljava/lang/annotation/Documented;"
	})]
	[Implements(new string[] { "java.lang.annotation.Annotation" })]
	internal interface GwtIncompatible : Annotation
	{
		virtual string value();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	private Partially()
	{
	}
}
