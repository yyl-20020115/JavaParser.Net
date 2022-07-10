using IKVM.Attributes;

namespace com.google.common.io;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 22, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)22,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public interface LineProcessor
{
	[Throws(new string[] { "java.io.IOException" })]
	virtual bool processLine(string str);

	[Signature("()TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	virtual object getResult();
}
