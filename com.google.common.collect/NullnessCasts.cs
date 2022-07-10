using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)18,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class NullnessCasts : Object
{
	[Signature("<T:Ljava/lang/Object;>(TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 18, 0, 0 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	internal static object uncheckedCastNullableTToT([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return P_0;
	}

	[Signature("<T:Ljava/lang/Object;>()TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 18, 0, 0 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	internal static object unsafeNull()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	private NullnessCasts()
	{
	}
}
