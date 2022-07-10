using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[ConstantPool(new object[]
{
	(byte)23,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public interface HashFunction
{
	virtual Hasher newHasher();

	virtual Hasher newHasher(int i);

	virtual HashCode hashInt(int i);

	virtual HashCode hashLong(long l);

	virtual HashCode hashBytes(byte[] barr);

	virtual HashCode hashBytes(byte[] barr, int i1, int i2);

	virtual HashCode hashBytes(ByteBuffer bb);

	virtual HashCode hashUnencodedChars(CharSequence cs);

	virtual HashCode hashString(CharSequence cs, Charset c);

	[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/HashCode;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 23, 0, 0 })]
	virtual HashCode hashObject([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object obj, Funnel f);

	virtual int bits();
}
