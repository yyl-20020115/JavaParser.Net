using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 24, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)24,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class GwtFluentFutureCatchingSpecialization : AbstractFuture
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	internal GwtFluentFutureCatchingSpecialization()
	{
	}

	[HideFromJava]
	static GwtFluentFutureCatchingSpecialization()
	{
		AbstractFuture.___003Cclinit_003E();
	}
}
