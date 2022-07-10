using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Ljava/util/Map$Entry<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 77, 0, 0,
	17, 1, 0, 0, 0, 77, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)77,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map$Entry" })]
public abstract class ForwardingMapEntry : ForwardingObject, Map.Entry
{
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	protected internal new abstract Map.Entry @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(65)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object getKey()
	{
		object key = @delegate().getKey();
		_ = null;
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TV;")]
	[LineNumberTable(71)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object getValue()
	{
		object value = @delegate().getValue();
		_ = null;
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	protected internal ForwardingMapEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)TV;")]
	[LineNumberTable(77)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object setValue([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = @delegate().setValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = @delegate().equals(@object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	public override int hashCode()
	{
		int result = @delegate().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 104, 103, 116, 54, 161 })]
	protected internal virtual bool standardEquals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object is Map.Entry)
		{
			Map.Entry entry = (Map.Entry)@object;
			return (com.google.common.@base.Objects.equal(getKey(), entry.getKey()) && com.google.common.@base.Objects.equal(getValue(), entry.getValue())) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 103, 103 })]
	protected internal virtual int standardHashCode()
	{
		object key = getKey();
		object value = getValue();
		return ((key != null) ? Object.instancehelper_hashCode(key) : 0) ^ ((value != null) ? Object.instancehelper_hashCode(value) : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	protected internal virtual string standardToString()
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(50)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Map.Entry result = @delegate();
		_ = null;
		return result;
	}
}
