using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map$Entry<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 68, 0, 0,
	17, 1, 0, 0, 0, 68, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)68,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractMapEntry : Object, Map.Entry
{
	[Signature("()TK;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public abstract object getKey();

	[Signature("()TV;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public abstract object getValue();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(33)]
	internal AbstractMapEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)TV;")]
	[LineNumberTable(47)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object setValue([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 103, 116, 54, 161 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Map.Entry)
		{
			Map.Entry entry = (Map.Entry)P_0;
			return (com.google.common.@base.Objects.equal(getKey(), entry.getKey()) && com.google.common.@base.Objects.equal(getValue(), entry.getValue())) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 12, 103, 103 })]
	public override int hashCode()
	{
		object key = getKey();
		object value = getValue();
		return ((key != null) ? Object.instancehelper_hashCode(key) : 0) ^ ((value != null) ? Object.instancehelper_hashCode(value) : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	public override string toString()
	{
		string text = String.valueOf(getKey());
		string text2 = String.valueOf(getValue());
		int num = 1 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append(text).append("=").append(text2)
			.toString();
		_ = null;
		return result;
	}
}
