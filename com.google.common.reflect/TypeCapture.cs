using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace com.google.common.reflect;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class TypeCapture : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	internal TypeCapture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 108, 116 })]
	internal Type capture()
	{
		Type genericSuperclass = Object.instancehelper_getClass(this).getGenericSuperclass();
		Preconditions.checkArgument(genericSuperclass is ParameterizedType, "%s isn't parameterized", genericSuperclass);
		return ((ParameterizedType)genericSuperclass).getActualTypeArguments()[0];
	}
}
