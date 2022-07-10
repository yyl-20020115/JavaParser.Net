using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.google.common.@base;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/function/Supplier<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 19, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)19,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[FunctionalInterface(new object[]
{
	(byte)64,
	"Ljava/lang/FunctionalInterface;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.function.Supplier" })]
public interface Supplier : java.util.function.Supplier
{
	[Signature("()TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})]
	object get();
}
