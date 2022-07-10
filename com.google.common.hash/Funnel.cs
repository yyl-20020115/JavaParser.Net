using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.io;

namespace com.google.common.hash;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 21, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)21,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Implement with a lambda"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public interface Funnel : Serializable.__Interface
{
	[Signature("(TT;Lcom/google/common/hash/PrimitiveSink;)V")]
	virtual void funnel([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object obj, PrimitiveSink ps);
}
