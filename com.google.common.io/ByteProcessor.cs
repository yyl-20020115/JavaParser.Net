using com.google.errorprone.annotations;
using IKVM.Attributes;

namespace com.google.common.io;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 25, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)25,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Implement it normally"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public interface ByteProcessor
{
	[Throws(new string[] { "java.io.IOException" })]
	virtual bool processBytes(byte[] barr, int i1, int i2);

	[Signature("()TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	virtual object getResult();
}
