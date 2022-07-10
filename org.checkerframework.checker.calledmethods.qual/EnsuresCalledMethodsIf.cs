using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.checker.calledmethods.qual.EnsuresCalledMethodsIfAttribute")]
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
[ConditionalPostconditionAnnotation(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/ConditionalPostconditionAnnotation;",
	"qualifier",
	new object[]
	{
		(byte)99,
		"Lorg/checkerframework/checker/calledmethods/qual/CalledMethods, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
	}
})]
[InheritedAnnotation(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/InheritedAnnotation;"
})]
[Repeatable(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Repeatable;",
	"value",
	new object[]
	{
		(byte)99,
		"Lorg/checkerframework/checker/calledmethods/qual/EnsuresCalledMethodsIf+List, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface EnsuresCalledMethodsIf : Annotation
{
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
	[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
	[AnnotationAttribute("org.checkerframework.checker.calledmethods.qual.EnsuresCalledMethodsIf+ListAttribute")]
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
	[ConditionalPostconditionAnnotation(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/ConditionalPostconditionAnnotation;",
		"qualifier",
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/checker/calledmethods/qual/CalledMethods, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		}
	})]
	[InheritedAnnotation(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/InheritedAnnotation;"
	})]
	[Implements(new string[] { "java.lang.annotation.Annotation" })]
	public interface List : Annotation
	{
		virtual EnsuresCalledMethodsIf[] value();
	}

	[Modifiers(Modifiers.Final)]
	[InnerClass("org.checkerframework.checker.calledmethods.qual.$ProxyEnsuresCalledMethodsIf$List", Modifiers.Final)]
	[Implements(new string[] { "org.checkerframework.checker.calledmethods.qual.EnsuresCalledMethodsIf$List" })]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
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

		private EnsuresCalledMethodsIf[] value()
		{
			return (EnsuresCalledMethodsIf[])getValue("value");
		}

		EnsuresCalledMethodsIf[] List.value()
		{
			//ILSpy generated this explicit interface implementation from .override directive in value
			return this.value();
		}
	}

	virtual string[] expression();

	virtual bool result();

	[QualifierArgument(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/QualifierArgument;",
		"value",
		"value"
	})]
	virtual string[] methods();
}
