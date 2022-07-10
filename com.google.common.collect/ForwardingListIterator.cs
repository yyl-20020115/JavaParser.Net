using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingIterator<TE;>;Ljava/util/ListIterator<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 52, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)52,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.ListIterator" })]
public abstract class ForwardingListIterator : ForwardingIterator, ListIterator, Iterator
{
	[Signature("()Ljava/util/ListIterator<TE;>;")]
	protected internal new abstract ListIterator @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	protected internal ForwardingListIterator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 2, 110 })]
	public virtual void add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		@delegate().add(element);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public virtual bool hasPrevious()
	{
		bool result = @delegate().hasPrevious();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public virtual int nextIndex()
	{
		int result = @delegate().nextIndex();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(69)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object previous()
	{
		object result = @delegate().previous();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public virtual int previousIndex()
	{
		int result = @delegate().previousIndex();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 29, 110 })]
	public virtual void set([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		@delegate().set(element);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal new virtual Iterator _003Cbridge_003Edelegate()
	{
		ListIterator result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		ListIterator result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachRemaining(Consumer P_0)
	{
		Iterator._003Cdefault_003EforEachRemaining(this, P_0);
	}
}
