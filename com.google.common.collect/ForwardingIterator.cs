using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Ljava/util/Iterator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 38, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)38,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Iterator" })]
public abstract class ForwardingIterator : ForwardingObject, Iterator
{
	[Signature("()Ljava/util/Iterator<TT;>;")]
	protected internal new abstract Iterator @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	protected internal ForwardingIterator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	public virtual bool hasNext()
	{
		bool result = @delegate().hasNext();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(59)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object next()
	{
		object result = @delegate().next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 109 })]
	public virtual void remove()
	{
		@delegate().remove();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Iterator result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEachRemaining(Consumer P_0)
	{
		Iterator._003Cdefault_003EforEachRemaining(this, P_0);
	}
}
