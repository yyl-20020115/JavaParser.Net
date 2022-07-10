using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.annotation;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
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
		"SOURCE"
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
			"PACKAGE"
		},
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
			"CONSTRUCTOR"
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
			"FIELD"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"LOCAL_VARIABLE"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"PARAMETER"
		}
	}
})]
[Repeatable(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Repeatable;",
	"value",
	new object[]
	{
		(byte)99,
		"Lorg/checkerframework/framework/qual/DefaultQualifier+List, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface DefaultQualifier : Annotation
{
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
	[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
	[AnnotationAttribute("org.checkerframework.framework.qual.DefaultQualifier+ListAttribute")]
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
				"PACKAGE"
			},
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
				"CONSTRUCTOR"
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
				"FIELD"
			},
			new object[]
			{
				(byte)101,
				"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
				"LOCAL_VARIABLE"
			},
			new object[]
			{
				(byte)101,
				"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
				"PARAMETER"
			}
		}
	})]
	[Implements(new string[] { "java.lang.annotation.Annotation" })]
	public interface List : Annotation
	{
		virtual DefaultQualifier[] value();
	}

	[Modifiers(Modifiers.Final)]
	[InnerClass("org.checkerframework.framework.qual.$ProxyDefaultQualifier$List", Modifiers.Final)]
	[Implements(new string[] { "org.checkerframework.framework.qual.DefaultQualifier$List" })]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public sealed class ListAttribute : AnnotationAttributeBase, List
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ListAttribute(object[] P_0)
			: this()
		{
			setDefinition(P_0);
		}

		private ListAttribute()
			: base(ClassLiteral<List>.Value)
		{
		}

		[HideFromJava]
		public ListAttribute(DefaultQualifier[] value)
			: this()
		{
			setValue("value", value);
		}

		private DefaultQualifier[] value()
		{
			return (DefaultQualifier[])getValue("value");
		}

		DefaultQualifier[] List.value()
		{
			//ILSpy generated this explicit interface implementation from .override directive in value
			return this.value();
		}
	}

	[Signature("()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
	virtual Class value();

	[AnnotationDefault(new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation;",
			"ALL"
		}
	})]
	virtual TypeUseLocation[] locations();
}
