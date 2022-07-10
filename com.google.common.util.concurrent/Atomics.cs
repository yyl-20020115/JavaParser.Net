using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent.atomic;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)22,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Atomics : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	private Atomics()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>()Ljava/util/concurrent/atomic/AtomicReference<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 22, 0, 0 })]
	[LineNumberTable(39)]
	public static AtomicReference newReference()
	{
		AtomicReference result = new AtomicReference();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(TV;)Ljava/util/concurrent/atomic/AtomicReference<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 22, 0, 0 })]
	[LineNumberTable(50)]
	public static AtomicReference newReference([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object initialValue)
	{
		AtomicReference result = new AtomicReference(initialValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 22, 0, 0 })]
	[LineNumberTable(60)]
	public static AtomicReferenceArray newReferenceArray(int length)
	{
		AtomicReferenceArray result = new AtomicReferenceArray(length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 22, 0, 0 })]
	[LineNumberTable(71)]
	public static AtomicReferenceArray newReferenceArray(object[] array)
	{
		AtomicReferenceArray result = new AtomicReferenceArray(array);
		_ = null;
		return result;
	}
}
