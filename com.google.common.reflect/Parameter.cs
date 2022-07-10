using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.reflect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Parameter : Object, AnnotatedElement
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/reflect/Invokable<**>;")]
	private Invokable declaration;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int position;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/reflect/TypeToken<*>;")]
	private TypeToken type;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/annotation/Annotation;>;")]
	private ImmutableList annotations;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private AnnotatedType annotatedType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/reflect/Invokable<**>;ILcom/google/common/reflect/TypeToken<*>;[Ljava/lang/annotation/Annotation;Ljava/lang/reflect/AnnotatedType;)V")]
	[LineNumberTable(new byte[] { 3, 104, 103, 103, 103, 109, 104 })]
	internal Parameter(Invokable P_0, int P_1, TypeToken P_2, Annotation[] P_3, AnnotatedType P_4)
	{
		declaration = P_0;
		position = P_1;
		type = P_2;
		annotations = ImmutableList.copyOf(P_3);
		annotatedType = P_4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
	[LineNumberTable(new byte[] { 29, 103, 127, 1, 105, 141, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Annotation getAnnotation(Class annotationType)
	{
		Preconditions.checkNotNull(annotationType);
		UnmodifiableIterator unmodifiableIterator = annotations.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Annotation obj = (Annotation)((Iterator)unmodifiableIterator).next();
			if (annotationType.isInstance(obj))
			{
				return (Annotation)annotationType.cast(obj);
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual Annotation[] getDeclaredAnnotations()
	{
		return (Annotation[])annotations.toArray(new Annotation[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)[TA;")]
	[LineNumberTable(new byte[] { 71, 157, 98 })]
	public virtual Annotation[] getDeclaredAnnotationsByType(Class annotationType)
	{
		return (Annotation[])FluentIterable.from(annotations).filter(annotationType).toArray(annotationType);
	}

	[Signature("()Lcom/google/common/reflect/TypeToken<*>;")]
	public virtual TypeToken getType()
	{
		return type;
	}

	[Signature("()Lcom/google/common/reflect/Invokable<**>;")]
	public virtual Invokable getDeclaringInvokable()
	{
		return declaration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
	[LineNumberTable(73)]
	public virtual bool isAnnotationPresent(Class annotationType)
	{
		return getAnnotation(annotationType) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(90)]
	public virtual Annotation[] getAnnotations()
	{
		Annotation[] declaredAnnotations = getDeclaredAnnotations();
		_ = null;
		return declaredAnnotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)[TA;")]
	[LineNumberTable(97)]
	public virtual Annotation[] getAnnotationsByType(Class annotationType)
	{
		Annotation[] declaredAnnotationsByType = getDeclaredAnnotationsByType(annotationType);
		_ = null;
		return declaredAnnotationsByType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
	[LineNumberTable(new byte[] { 62, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Annotation getDeclaredAnnotation(Class annotationType)
	{
		Preconditions.checkNotNull(annotationType);
		return (Annotation)FluentIterable.from(annotations).filter(annotationType).first()
			.orNull();
	}

	public virtual AnnotatedType getAnnotatedType()
	{
		return annotatedType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 104, 103, 159, 7 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj is Parameter)
		{
			Parameter parameter = (Parameter)obj;
			return (position == parameter.position && declaration.equals(parameter.declaration)) ? true : false;
		}
		return false;
	}

	public override int hashCode()
	{
		return position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(149)]
	public override string toString()
	{
		string text = String.valueOf(type);
		int i = position;
		int num = 15 + String.instancehelper_length(String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(text).append(" arg").append(i)
			.toString();
		_ = null;
		return result;
	}
}
